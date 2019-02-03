﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;

namespace Microsoft.AspNetCore.Mvc.Razor
{
    internal class RazorViewLookup
    {
        private static readonly TimeSpan _slidingExpirationInterval = TimeSpan.FromMinutes(20);
        private const string ViewExtension = ".cshtml";
        private readonly IViewCompilerProvider _viewCompilerProvider;
        private readonly RazorViewEngineOptions _options;
        private readonly MemoryCache _viewLocationCache;

        public RazorViewLookup(
            IViewCompilerProvider viewCompilerProvider,
            IOptions<RazorViewEngineOptions> options)
        {
            _viewCompilerProvider = viewCompilerProvider;
            _viewLocationCache = new MemoryCache(new MemoryCacheOptions());
            _options = options.Value;
        }

        private IViewCompiler Compiler => _viewCompilerProvider.GetCompiler();

        public ValueTask<ViewLocationCacheResult> LocateViewAsync(
            ActionContext actionContext,
            string name,
            string executingFilePath,
            bool isMainPage)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException(Resources.ArgumentCannotBeNullOrEmpty, nameof(name));
            }

            // Is this a relative or absolute path? If so, produce an absolute path and
            // lookup a file at the location.
            if (IsPath(name))
            {
                var applicationRelativePath = GetAbsolutePath(executingFilePath, name);
                return LookupViewAtPath(applicationRelativePath, isMainPage);
            }

            // If it's not a path, we need to search for the view using search paths.
            if (actionContext == null)
            {
                throw new ArgumentNullException(nameof(actionContext));
            }

            return LocateViewFromSearchPaths(actionContext, name, isMainPage);
        }

        private ValueTask<ViewLocationCacheResult> LocateViewFromSearchPaths(
            ActionContext actionContext,
            string name,
            bool isMainPage)
        {
            var expanders = _options.ViewLocationExpanders;
            var expanderContext = GetExpanderContext(actionContext, name, isMainPage);

            // Perf: Avoid allocations
            for (var i = 0; i < expanders.Count; i++)
            {
                expanders[i].PopulateValues(expanderContext);
            }

            var cacheKey = new ViewLocationCacheKey(
                expanderContext.ViewName,
                expanderContext.ControllerName,
                expanderContext.AreaName,
                expanderContext.PageName,
                expanderContext.IsMainPage,
                (IReadOnlyDictionary<string, string>)expanderContext.Values);

            if (_viewLocationCache.TryGetValue(cacheKey, out ViewLocationCacheResult cacheResult))
            {
                return new ValueTask<ViewLocationCacheResult>(cacheResult);
            }

            var viewLocationFormats = GetViewLocationFormats(_options, expanderContext);
            for (var i = 0; i < expanders.Count; i++)
            {
                viewLocationFormats = expanders[i].ExpandViewLocations(expanderContext, viewLocationFormats);
            }

            return LocateViewFromSearchPathsAwaited(cacheKey, viewLocationFormats);
        }

        private async ValueTask<ViewLocationCacheResult> LocateViewFromSearchPathsAwaited(
            ViewLocationCacheKey cacheKey,
            IEnumerable<string> viewLocationFormats)
        {
            var cacheEntryOptions = new MemoryCacheEntryOptions();
            cacheEntryOptions.SetSlidingExpiration(_slidingExpirationInterval);

            var searchedLocations = new List<string>();
            CompiledViewDescriptor foundView = null;
            foreach (var location in viewLocationFormats)
            {
                var path = string.Format(
                    CultureInfo.InvariantCulture,
                    location,
                    cacheKey.ViewName,
                    cacheKey.ControllerName,
                    cacheKey.AreaName);

                path = ViewEnginePath.ResolvePath(path);

                var viewDescriptor = await Compiler.CompileAsync(path);
                CopyExpirationTokens(cacheEntryOptions, viewDescriptor);

                if (viewDescriptor.Type != null)
                {
                    foundView = viewDescriptor;
                    break;
                }
            }

            ViewLocationCacheResult cacheResult;
            if (foundView != null)
            {
                cacheResult = await CreateFoundResult(foundView, cacheEntryOptions);
            }
            else
            {
                // We could not find a view at any of the search paths
                cacheResult = new ViewLocationCacheResult(searchedLocations);
            }

            _viewLocationCache.Set(cacheKey, cacheResult, cacheEntryOptions);
            return cacheResult;
        }

        private ValueTask<ViewLocationCacheResult> LookupViewAtPath(string path, bool isMainPage)
        {
            var cacheKey = new ViewLocationCacheKey(path, isMainPage);
            if (_viewLocationCache.TryGetValue(cacheKey, out ViewLocationCacheResult cacheResult))
            {
                return new ValueTask<ViewLocationCacheResult>(cacheResult);
            }

            return LookViewAtPathAwaited(cacheKey);
        }

        private async ValueTask<ViewLocationCacheResult> LookViewAtPathAwaited(ViewLocationCacheKey cacheKey)
        {
            var path = cacheKey.ViewName;
            var viewDescriptor = await Compiler.CompileAsync(path);

            var cacheEntryOptions = new MemoryCacheEntryOptions();
            cacheEntryOptions.SetSlidingExpiration(_slidingExpirationInterval);
            CopyExpirationTokens(cacheEntryOptions, viewDescriptor);

            ViewLocationCacheResult cacheResult;
            if (viewDescriptor.Item == null)
            {
                cacheResult = new ViewLocationCacheResult(new[] { path });
            }
            else
            {
                cacheResult = await CreateFoundResult(viewDescriptor, cacheEntryOptions);
            }

            _viewLocationCache.Set(cacheKey, cacheResult, cacheEntryOptions);
            return cacheResult;
        }

        private async ValueTask<ViewLocationCacheResult> CreateFoundResult(
            CompiledViewDescriptor viewDescriptor,
            MemoryCacheEntryOptions cacheEntryOptions)
        {
            var viewStarts = new List<ViewLocationCacheItem>();
            foreach (var viewStartPath in RazorFileHierarchy.GetViewStartPaths(viewDescriptor.RelativePath))
            {
                var viewStart = await Compiler.CompileAsync(viewStartPath);
                CopyExpirationTokens(cacheEntryOptions, viewStart);

                if (viewStart.Type != null)
                {
                    // GetViewStartPaths returns path inside-out (i.e. /Views/Home/_ViewStart, /Views/_ViewStart, /_ViewStart)
                    // Place the viewStarts in the result in the order in which we expect them to execute - outside-in.
                    var viewStartFactory = CreatePageFactory(viewStart);
                    viewStarts.Insert(0, new ViewLocationCacheItem(viewStartFactory, viewStart.RelativePath));
                }
            }

            var factory = CreatePageFactory(viewDescriptor);
            return new ViewLocationCacheResult(
                new ViewLocationCacheItem(factory, viewDescriptor.RelativePath),
                viewStarts);
        }

        internal static ViewLocationExpanderContext GetExpanderContext(
            ActionContext actionContext, 
            string name, 
            bool isMainPage)
        {
            var controllerName = NormalizedRouteValue.GetNormalizedRouteValue(actionContext, "controller");
            var areaName = NormalizedRouteValue.GetNormalizedRouteValue(actionContext, "area");

            string razorPageName = null;
            if (actionContext.ActionDescriptor.RouteValues.ContainsKey("page"))
            {
                // Only calculate the Razor Page name if "page" is registered in RouteValues.
                razorPageName = NormalizedRouteValue.GetNormalizedRouteValue(actionContext, "page");
            }

            var expanderContext = new ViewLocationExpanderContext(
                actionContext,
                name,
                controllerName,
                areaName,
                razorPageName,
                isMainPage)
            {
                Values = new Dictionary<string, string>(StringComparer.Ordinal),
            };
            
            return expanderContext;
        }

        internal static string GetAbsolutePath(string executingFilePath, string pagePath)
        {
            if (string.IsNullOrEmpty(pagePath))
            {
                // Path is not valid; no change required.
                return pagePath;
            }

            if (!IsPath(pagePath))
            {
                // A page name; no change required.
                return pagePath;
            }

            if (pagePath.StartsWith("~/", StringComparison.Ordinal))
            {
                pagePath = pagePath.Substring(1);
            }

            if (string.IsNullOrEmpty(executingFilePath))
            {
                // If no root is specified, assume app root.
                executingFilePath = "/";
            }

            return ViewEnginePath.CombinePath(executingFilePath, pagePath);
        }

        // internal for tests
        private static IEnumerable<string> GetViewLocationFormats(RazorViewEngineOptions options, ViewLocationExpanderContext context)
        {
            if (!string.IsNullOrEmpty(context.AreaName) &&
                !string.IsNullOrEmpty(context.ControllerName))
            {
                return options.AreaViewLocationFormats;
            }
            else if (!string.IsNullOrEmpty(context.ControllerName))
            {
                return options.ViewLocationFormats;
            }
            else if (!string.IsNullOrEmpty(context.AreaName) &&
                !string.IsNullOrEmpty(context.PageName))
            {
                return options.AreaPageViewLocationFormats;
            }
            else if (!string.IsNullOrEmpty(context.PageName))
            {
                return options.PageViewLocationFormats;
            }
            else
            {
                // If we don't match one of these conditions, we'll just treat it like regular controller/action
                // and use those search paths. This is what we did in 1.0.0 without giving much thought to it.
                return options.ViewLocationFormats;
            }
        }

        private static bool IsPath(string name)
        {
            Debug.Assert(!string.IsNullOrEmpty(name));
            return name[0] == '~' || name[0] == '/' || name.EndsWith(ViewExtension, StringComparison.OrdinalIgnoreCase);
        }

        private static void CopyExpirationTokens(MemoryCacheEntryOptions cacheEntryOptions, CompiledViewDescriptor viewDescriptor)
        {
            for (var i = 0; i < viewDescriptor.ExpirationTokens.Count; i++)
            {
                cacheEntryOptions.ExpirationTokens.Add(viewDescriptor.ExpirationTokens[i]);
            }
        }

        internal static Func<IRazorPage> CreatePageFactory(CompiledViewDescriptor viewDescriptor)
        {
            var pageType = viewDescriptor.Type;
            var newExpression = Expression.New(pageType);
            var pathProperty = pageType.GetProperty(nameof(IRazorPage.Path));

            // Generate: page.Path = relativePath;
            // Use the normalized path specified from the result.
            var propertyBindExpression = Expression.Bind(pathProperty, Expression.Constant(viewDescriptor.RelativePath));
            var objectInitializeExpression = Expression.MemberInit(newExpression, propertyBindExpression);
            return Expression
                .Lambda<Func<IRazorPage>>(objectInitializeExpression)
                .Compile();
        }
    }
}
