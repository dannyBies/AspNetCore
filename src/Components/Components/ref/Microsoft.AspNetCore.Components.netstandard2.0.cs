// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Components
{
    public partial class AuthenticationState
    {
        public AuthenticationState(System.Security.Claims.ClaimsPrincipal user) { }
        public System.Security.Claims.ClaimsPrincipal User { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public delegate void AuthenticationStateChangedHandler(System.Threading.Tasks.Task<Microsoft.AspNetCore.Components.AuthenticationState> task);
    public abstract partial class AuthenticationStateProvider
    {
        protected AuthenticationStateProvider() { }
        public event Microsoft.AspNetCore.Components.AuthenticationStateChangedHandler AuthenticationStateChanged { add { } remove { } }
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Components.AuthenticationState> GetAuthenticationStateAsync();
        protected void NotifyAuthenticationStateChanged(System.Threading.Tasks.Task<Microsoft.AspNetCore.Components.AuthenticationState> task) { }
    }
    public static partial class BindConverter
    {
        public static bool FormatValue(bool value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(System.DateTime value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(System.DateTime value, string format, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(System.DateTimeOffset value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(System.DateTimeOffset value, string format, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(decimal value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(double value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(int value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(long value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static bool? FormatValue(bool? value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(System.DateTimeOffset? value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(System.DateTimeOffset? value, string format, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(System.DateTime? value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(System.DateTime? value, string format, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(decimal? value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(double? value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(int? value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(long? value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(float? value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(float value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static string FormatValue(string value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static object FormatValue<T>(T value, System.Globalization.CultureInfo culture = null) { throw null; }
        public static bool TryConvertToBool(object obj, System.Globalization.CultureInfo culture, out bool value) { throw null; }
        public static bool TryConvertToDateTime(object obj, System.Globalization.CultureInfo culture, out System.DateTime value) { throw null; }
        public static bool TryConvertToDateTime(object obj, System.Globalization.CultureInfo culture, string format, out System.DateTime value) { throw null; }
        public static bool TryConvertToDateTimeOffset(object obj, System.Globalization.CultureInfo culture, out System.DateTimeOffset value) { throw null; }
        public static bool TryConvertToDateTimeOffset(object obj, System.Globalization.CultureInfo culture, string format, out System.DateTimeOffset value) { throw null; }
        public static bool TryConvertToDecimal(object obj, System.Globalization.CultureInfo culture, out decimal value) { throw null; }
        public static bool TryConvertToDouble(object obj, System.Globalization.CultureInfo culture, out double value) { throw null; }
        public static bool TryConvertToFloat(object obj, System.Globalization.CultureInfo culture, out float value) { throw null; }
        public static bool TryConvertToInt(object obj, System.Globalization.CultureInfo culture, out int value) { throw null; }
        public static bool TryConvertToLong(object obj, System.Globalization.CultureInfo culture, out long value) { throw null; }
        public static bool TryConvertToNullableBool(object obj, System.Globalization.CultureInfo culture, out bool? value) { throw null; }
        public static bool TryConvertToNullableDateTime(object obj, System.Globalization.CultureInfo culture, out System.DateTime? value) { throw null; }
        public static bool TryConvertToNullableDateTime(object obj, System.Globalization.CultureInfo culture, string format, out System.DateTime? value) { throw null; }
        public static bool TryConvertToNullableDateTimeOffset(object obj, System.Globalization.CultureInfo culture, out System.DateTimeOffset? value) { throw null; }
        public static bool TryConvertToNullableDateTimeOffset(object obj, System.Globalization.CultureInfo culture, string format, out System.DateTimeOffset? value) { throw null; }
        public static bool TryConvertToNullableDecimal(object obj, System.Globalization.CultureInfo culture, out decimal? value) { throw null; }
        public static bool TryConvertToNullableDouble(object obj, System.Globalization.CultureInfo culture, out double? value) { throw null; }
        public static bool TryConvertToNullableFloat(object obj, System.Globalization.CultureInfo culture, out float? value) { throw null; }
        public static bool TryConvertToNullableInt(object obj, System.Globalization.CultureInfo culture, out int? value) { throw null; }
        public static bool TryConvertToNullableLong(object obj, System.Globalization.CultureInfo culture, out long? value) { throw null; }
        public static bool TryConvertToString(object obj, System.Globalization.CultureInfo culture, out string value) { throw null; }
        public static bool TryConvertTo<T>(object obj, System.Globalization.CultureInfo culture, out T value) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public sealed partial class CascadingParameterAttribute : System.Attribute
    {
        public CascadingParameterAttribute() { }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public abstract partial class ComponentBase : Microsoft.AspNetCore.Components.IComponent, Microsoft.AspNetCore.Components.IHandleAfterRender, Microsoft.AspNetCore.Components.IHandleEvent
    {
        public ComponentBase() { }
        protected virtual void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder) { }
        protected System.Threading.Tasks.Task InvokeAsync(System.Action workItem) { throw null; }
        protected System.Threading.Tasks.Task InvokeAsync(System.Func<System.Threading.Tasks.Task> workItem) { throw null; }
        void Microsoft.AspNetCore.Components.IComponent.Attach(Microsoft.AspNetCore.Components.RenderHandle renderHandle) { }
        System.Threading.Tasks.Task Microsoft.AspNetCore.Components.IHandleAfterRender.OnAfterRenderAsync() { throw null; }
        System.Threading.Tasks.Task Microsoft.AspNetCore.Components.IHandleEvent.HandleEventAsync(Microsoft.AspNetCore.Components.EventCallbackWorkItem callback, object arg) { throw null; }
        protected virtual void OnAfterRender() { }
        protected virtual System.Threading.Tasks.Task OnAfterRenderAsync() { throw null; }
        protected virtual void OnInitialized() { }
        protected virtual System.Threading.Tasks.Task OnInitializedAsync() { throw null; }
        protected virtual void OnParametersSet() { }
        protected virtual System.Threading.Tasks.Task OnParametersSetAsync() { throw null; }
        public virtual System.Threading.Tasks.Task SetParametersAsync(Microsoft.AspNetCore.Components.ParameterCollection parameters) { throw null; }
        protected virtual bool ShouldRender() { throw null; }
        protected void StateHasChanged() { }
    }
    public abstract partial class Dispatcher
    {
        protected Dispatcher() { }
        public abstract bool CheckAccess();
        public static Microsoft.AspNetCore.Components.Dispatcher CreateDefault() { throw null; }
        public abstract System.Threading.Tasks.Task InvokeAsync(System.Action workItem);
        public abstract System.Threading.Tasks.Task InvokeAsync(System.Func<System.Threading.Tasks.Task> workItem);
        public abstract System.Threading.Tasks.Task<TResult> InvokeAsync<TResult>(System.Func<System.Threading.Tasks.Task<TResult>> workItem);
        public abstract System.Threading.Tasks.Task<TResult> InvokeAsync<TResult>(System.Func<TResult> workItem);
        protected void OnUnhandledException(System.UnhandledExceptionEventArgs e) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ElementReference
    {
        private readonly object _dummy;
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EventCallback
    {
        private readonly object _dummy;
        public static readonly Microsoft.AspNetCore.Components.EventCallback Empty;
        public static readonly Microsoft.AspNetCore.Components.EventCallbackFactory Factory;
        public EventCallback(Microsoft.AspNetCore.Components.IHandleEvent receiver, System.MulticastDelegate @delegate) { throw null; }
        public bool HasDelegate { get { throw null; } }
        public System.Threading.Tasks.Task InvokeAsync(object arg) { throw null; }
    }
    public sealed partial class EventCallbackFactory
    {
        public EventCallbackFactory() { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public Microsoft.AspNetCore.Components.EventCallback Create(object receiver, Microsoft.AspNetCore.Components.EventCallback callback) { throw null; }
        public Microsoft.AspNetCore.Components.EventCallback Create(object receiver, System.Action callback) { throw null; }
        public Microsoft.AspNetCore.Components.EventCallback Create(object receiver, System.Action<object> callback) { throw null; }
        public Microsoft.AspNetCore.Components.EventCallback Create(object receiver, System.Func<object, System.Threading.Tasks.Task> callback) { throw null; }
        public Microsoft.AspNetCore.Components.EventCallback Create(object receiver, System.Func<System.Threading.Tasks.Task> callback) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public Microsoft.AspNetCore.Components.EventCallback<T> CreateInferred<T>(object receiver, System.Action<T> callback, T value) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public Microsoft.AspNetCore.Components.EventCallback<T> CreateInferred<T>(object receiver, System.Func<T, System.Threading.Tasks.Task> callback, T value) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public Microsoft.AspNetCore.Components.EventCallback<T> Create<T>(object receiver, Microsoft.AspNetCore.Components.EventCallback callback) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public Microsoft.AspNetCore.Components.EventCallback<T> Create<T>(object receiver, Microsoft.AspNetCore.Components.EventCallback<T> callback) { throw null; }
        public Microsoft.AspNetCore.Components.EventCallback<T> Create<T>(object receiver, System.Action callback) { throw null; }
        public Microsoft.AspNetCore.Components.EventCallback<T> Create<T>(object receiver, System.Action<T> callback) { throw null; }
        public Microsoft.AspNetCore.Components.EventCallback<T> Create<T>(object receiver, System.Func<System.Threading.Tasks.Task> callback) { throw null; }
        public Microsoft.AspNetCore.Components.EventCallback<T> Create<T>(object receiver, System.Func<T, System.Threading.Tasks.Task> callback) { throw null; }
    }
    public static partial class EventCallbackFactoryBinderExtensions
    {
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<bool> setter, bool existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<System.DateTimeOffset> setter, System.DateTimeOffset existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<System.DateTimeOffset> setter, System.DateTimeOffset existingValue, string format, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<System.DateTime> setter, System.DateTime existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<System.DateTime> setter, System.DateTime existingValue, string format, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<decimal> setter, decimal existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<double> setter, double existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<int> setter, int existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<long> setter, long existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<bool?> setter, bool? existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<System.DateTimeOffset?> setter, System.DateTimeOffset? existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<System.DateTimeOffset?> setter, System.DateTimeOffset? existingValue, string format, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<System.DateTime?> setter, System.DateTime? existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<System.DateTime?> setter, System.DateTime? existingValue, string format, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<decimal?> setter, decimal? existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<double?> setter, double? existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<int?> setter, int? existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<long?> setter, long? existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<float?> setter, float? existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<float> setter, float existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIChangeEventArgs> CreateBinder(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<string> setter, string existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIChangeEventArgs> CreateBinder<T>(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<T> setter, T existingValue, System.Globalization.CultureInfo culture = null) { throw null; }
    }
    public static partial class EventCallbackFactoryUIEventArgsExtensions
    {
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIChangeEventArgs> Create(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<Microsoft.AspNetCore.Components.UIChangeEventArgs> callback) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIEventArgs> Create(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Action<Microsoft.AspNetCore.Components.UIEventArgs> callback) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIChangeEventArgs> Create(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Func<Microsoft.AspNetCore.Components.UIChangeEventArgs, System.Threading.Tasks.Task> callback) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIEventArgs> Create(this Microsoft.AspNetCore.Components.EventCallbackFactory factory, object receiver, System.Func<Microsoft.AspNetCore.Components.UIEventArgs, System.Threading.Tasks.Task> callback) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EventCallbackWorkItem
    {
        private readonly object _dummy;
        public static readonly Microsoft.AspNetCore.Components.EventCallbackWorkItem Empty;
        public EventCallbackWorkItem(System.MulticastDelegate @delegate) { throw null; }
        public System.Threading.Tasks.Task InvokeAsync(object arg) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EventCallback<T>
    {
        private readonly object _dummy;
        public static readonly Microsoft.AspNetCore.Components.EventCallback<T> Empty;
        public EventCallback(Microsoft.AspNetCore.Components.IHandleEvent receiver, System.MulticastDelegate @delegate) { throw null; }
        public bool HasDelegate { get { throw null; } }
        public System.Threading.Tasks.Task InvokeAsync(T arg) { throw null; }
    }
    public partial interface IComponent
    {
        void Attach(Microsoft.AspNetCore.Components.RenderHandle renderHandle);
        System.Threading.Tasks.Task SetParametersAsync(Microsoft.AspNetCore.Components.ParameterCollection parameters);
    }
    public partial interface IComponentContext
    {
        bool IsConnected { get; }
    }
    public partial interface IHandleAfterRender
    {
        System.Threading.Tasks.Task OnAfterRenderAsync();
    }
    public partial interface IHandleEvent
    {
        System.Threading.Tasks.Task HandleEventAsync(Microsoft.AspNetCore.Components.EventCallbackWorkItem item, object arg);
    }
    public partial interface IHostEnvironmentAuthenticationStateProvider
    {
        void SetAuthenticationState(System.Threading.Tasks.Task<Microsoft.AspNetCore.Components.AuthenticationState> authenticationStateTask);
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public sealed partial class InjectAttribute : System.Attribute
    {
        public InjectAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=false, Inherited=true)]
    public sealed partial class LayoutAttribute : System.Attribute
    {
        public LayoutAttribute(System.Type layoutType) { }
        public System.Type LayoutType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public abstract partial class LayoutComponentBase : Microsoft.AspNetCore.Components.ComponentBase
    {
        protected LayoutComponentBase() { }
        [Microsoft.AspNetCore.Components.ParameterAttribute]
        public Microsoft.AspNetCore.Components.RenderFragment Body { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MarkupString
    {
        private readonly object _dummy;
        public MarkupString(string value) { throw null; }
        public string Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static explicit operator Microsoft.AspNetCore.Components.MarkupString (string value) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class NavigationException : System.Exception
    {
        public NavigationException(string uri) { }
        public string Location { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public abstract partial class NavigationManager
    {
        protected NavigationManager() { }
        public event System.EventHandler<Microsoft.AspNetCore.Components.Routing.LocationChangedEventArgs> OnLocationChanged { add { } remove { } }
        protected virtual void EnsureInitialized() { }
        public string GetAbsoluteUri() { throw null; }
        public virtual string GetBaseUri() { throw null; }
        public virtual void InitializeState(string uriAbsolute, string baseUriAbsolute) { }
        public void NavigateTo(string uri) { }
        public void NavigateTo(string uri, bool forceLoad) { }
        protected abstract void NavigateToCore(string uri, bool forceLoad);
        protected void SetAbsoluteBaseUri(string baseUri) { }
        protected void SetAbsoluteUri(string uri) { }
        public System.Uri ToAbsoluteUri(string href) { throw null; }
        public string ToBaseRelativePath(string baseUri, string locationAbsolute) { throw null; }
        protected void TriggerOnLocationChanged(bool isinterceptedLink) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct Parameter
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public bool Cascading { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public object Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public sealed partial class ParameterAttribute : System.Attribute
    {
        public ParameterAttribute() { }
        public bool CaptureUnmatchedValues { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ParameterCollection
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public static Microsoft.AspNetCore.Components.ParameterCollection Empty { get { throw null; } }
        public static Microsoft.AspNetCore.Components.ParameterCollection FromDictionary(System.Collections.Generic.IDictionary<string, object> parameters) { throw null; }
        public Microsoft.AspNetCore.Components.ParameterEnumerator GetEnumerator() { throw null; }
        public T GetValueOrDefault<T>(string parameterName) { throw null; }
        public T GetValueOrDefault<T>(string parameterName, T defaultValue) { throw null; }
        public System.Collections.Generic.IReadOnlyDictionary<string, object> ToDictionary() { throw null; }
        public bool TryGetValue<T>(string parameterName, out T result) { throw null; }
    }
    public static partial class ParameterCollectionExtensions
    {
        public static void SetParameterProperties(this in Microsoft.AspNetCore.Components.ParameterCollection parameterCollection, object target) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ParameterEnumerator
    {
        private object _dummy;
        private int _dummyPrimitive;
        public Microsoft.AspNetCore.Components.Parameter Current { get { throw null; } }
        public bool MoveNext() { throw null; }
    }
    public delegate void RenderFragment(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder);
    public delegate Microsoft.AspNetCore.Components.RenderFragment RenderFragment<T>(T value);
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RenderHandle
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Microsoft.AspNetCore.Components.Dispatcher Dispatcher { get { throw null; } }
        public bool IsInitialized { get { throw null; } }
        public void Render(Microsoft.AspNetCore.Components.RenderFragment renderFragment) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=true, Inherited=false)]
    public sealed partial class RouteAttribute : System.Attribute
    {
        public RouteAttribute(string template) { }
        public string Template { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class UIChangeEventArgs : Microsoft.AspNetCore.Components.UIEventArgs
    {
        public UIChangeEventArgs() { }
        public object Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class UIEventArgs
    {
        public UIEventArgs() { }
        public string Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
}
namespace Microsoft.AspNetCore.Components.CompilerServices
{
    public static partial class RuntimeHelpers
    {
        public static Microsoft.AspNetCore.Components.EventCallback<T> CreateInferredEventCallback<T>(object receiver, System.Action<T> callback, T value) { throw null; }
        public static Microsoft.AspNetCore.Components.EventCallback<T> CreateInferredEventCallback<T>(object receiver, System.Func<T, System.Threading.Tasks.Task> callback, T value) { throw null; }
        public static T TypeCheck<T>(T value) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Components.Forms
{
    public partial class DataAnnotationsValidator : Microsoft.AspNetCore.Components.ComponentBase
    {
        public DataAnnotationsValidator() { }
        protected override void OnInitialized() { }
    }
    public sealed partial class EditContext
    {
        public EditContext(object model) { }
        public object Model { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public event System.EventHandler<Microsoft.AspNetCore.Components.Forms.FieldChangedEventArgs> OnFieldChanged { add { } remove { } }
        public event System.EventHandler<Microsoft.AspNetCore.Components.Forms.ValidationRequestedEventArgs> OnValidationRequested { add { } remove { } }
        public event System.EventHandler<Microsoft.AspNetCore.Components.Forms.ValidationStateChangedEventArgs> OnValidationStateChanged { add { } remove { } }
        public Microsoft.AspNetCore.Components.Forms.FieldIdentifier Field(string fieldName) { throw null; }
        public System.Collections.Generic.IEnumerable<string> GetValidationMessages() { throw null; }
        public System.Collections.Generic.IEnumerable<string> GetValidationMessages(Microsoft.AspNetCore.Components.Forms.FieldIdentifier fieldIdentifier) { throw null; }
        public bool IsModified() { throw null; }
        public bool IsModified(in Microsoft.AspNetCore.Components.Forms.FieldIdentifier fieldIdentifier) { throw null; }
        public void MarkAsUnmodified() { }
        public void MarkAsUnmodified(in Microsoft.AspNetCore.Components.Forms.FieldIdentifier fieldIdentifier) { }
        public void NotifyFieldChanged(in Microsoft.AspNetCore.Components.Forms.FieldIdentifier fieldIdentifier) { }
        public void NotifyValidationStateChanged() { }
        public bool Validate() { throw null; }
    }
    public static partial class EditContextDataAnnotationsExtensions
    {
        public static Microsoft.AspNetCore.Components.Forms.EditContext AddDataAnnotationsValidation(this Microsoft.AspNetCore.Components.Forms.EditContext editContext) { throw null; }
    }
    public static partial class EditContextExpressionExtensions
    {
        public static System.Collections.Generic.IEnumerable<string> GetValidationMessages(this Microsoft.AspNetCore.Components.Forms.EditContext editContext, System.Linq.Expressions.Expression<System.Func<object>> accessor) { throw null; }
        public static bool IsModified(this Microsoft.AspNetCore.Components.Forms.EditContext editContext, System.Linq.Expressions.Expression<System.Func<object>> accessor) { throw null; }
    }
    public sealed partial class FieldChangedEventArgs
    {
        internal FieldChangedEventArgs() { }
        public Microsoft.AspNetCore.Components.Forms.FieldIdentifier FieldIdentifier { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct FieldIdentifier
    {
        private readonly object _dummy;
        public FieldIdentifier(object model, string fieldName) { throw null; }
        public string FieldName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public object Model { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static Microsoft.AspNetCore.Components.Forms.FieldIdentifier Create<T>(System.Linq.Expressions.Expression<System.Func<T>> accessor) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public sealed partial class ValidationMessageStore
    {
        public ValidationMessageStore(Microsoft.AspNetCore.Components.Forms.EditContext editContext) { }
        public System.Collections.Generic.IEnumerable<string> this[Microsoft.AspNetCore.Components.Forms.FieldIdentifier fieldIdentifier] { get { throw null; } }
        public System.Collections.Generic.IEnumerable<string> this[System.Linq.Expressions.Expression<System.Func<object>> accessor] { get { throw null; } }
        public void Add(in Microsoft.AspNetCore.Components.Forms.FieldIdentifier fieldIdentifier, string message) { }
        public void AddRange(in Microsoft.AspNetCore.Components.Forms.FieldIdentifier fieldIdentifier, System.Collections.Generic.IEnumerable<string> messages) { }
        public void Clear() { }
        public void Clear(in Microsoft.AspNetCore.Components.Forms.FieldIdentifier fieldIdentifier) { }
    }
    public static partial class ValidationMessageStoreExpressionExtensions
    {
        public static void Add(this Microsoft.AspNetCore.Components.Forms.ValidationMessageStore store, System.Linq.Expressions.Expression<System.Func<object>> accessor, string message) { }
        public static void AddRange(this Microsoft.AspNetCore.Components.Forms.ValidationMessageStore store, System.Linq.Expressions.Expression<System.Func<object>> accessor, System.Collections.Generic.IEnumerable<string> messages) { }
        public static void Clear(this Microsoft.AspNetCore.Components.Forms.ValidationMessageStore store, System.Linq.Expressions.Expression<System.Func<object>> accessor) { }
    }
    public sealed partial class ValidationRequestedEventArgs
    {
        internal ValidationRequestedEventArgs() { }
    }
    public sealed partial class ValidationStateChangedEventArgs
    {
        internal ValidationStateChangedEventArgs() { }
    }
}
namespace Microsoft.AspNetCore.Components.Rendering
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ComponentRenderedText
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public int ComponentId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IEnumerable<string> Tokens { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class EventFieldInfo
    {
        public EventFieldInfo() { }
        public int ComponentId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public object FieldValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class HtmlRenderer : Microsoft.AspNetCore.Components.Rendering.Renderer
    {
        public HtmlRenderer(System.IServiceProvider serviceProvider, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, System.Func<string, string> htmlEncoder) : base (default(System.IServiceProvider), default(Microsoft.Extensions.Logging.ILoggerFactory)) { }
        public override Microsoft.AspNetCore.Components.Dispatcher Dispatcher { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected override void HandleException(System.Exception exception) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Components.Rendering.ComponentRenderedText> RenderComponentAsync(System.Type componentType, Microsoft.AspNetCore.Components.ParameterCollection initialParameters) { throw null; }
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Components.Rendering.ComponentRenderedText> RenderComponentAsync<TComponent>(Microsoft.AspNetCore.Components.ParameterCollection initialParameters) where TComponent : Microsoft.AspNetCore.Components.IComponent { throw null; }
        protected override System.Threading.Tasks.Task UpdateDisplayAsync(in Microsoft.AspNetCore.Components.Rendering.RenderBatch renderBatch) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RenderBatch
    {
        private readonly object _dummy;
        public Microsoft.AspNetCore.Components.RenderTree.ArrayRange<int> DisposedComponentIDs { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Microsoft.AspNetCore.Components.RenderTree.ArrayRange<ulong> DisposedEventHandlerIDs { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Microsoft.AspNetCore.Components.RenderTree.ArrayRange<Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame> ReferenceFrames { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Microsoft.AspNetCore.Components.RenderTree.ArrayRange<Microsoft.AspNetCore.Components.RenderTree.RenderTreeDiff> UpdatedComponents { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public abstract partial class Renderer : System.IDisposable
    {
        public Renderer(System.IServiceProvider serviceProvider, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public abstract Microsoft.AspNetCore.Components.Dispatcher Dispatcher { get; }
        public event System.UnhandledExceptionEventHandler UnhandledSynchronizationException { add { } remove { } }
        protected internal virtual void AddToRenderQueue(int componentId, Microsoft.AspNetCore.Components.RenderFragment renderFragment) { }
        protected internal int AssignRootComponentId(Microsoft.AspNetCore.Components.IComponent component) { throw null; }
        public virtual System.Threading.Tasks.Task DispatchEventAsync(ulong eventHandlerId, Microsoft.AspNetCore.Components.Rendering.EventFieldInfo fieldInfo, Microsoft.AspNetCore.Components.UIEventArgs eventArgs) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        protected abstract void HandleException(System.Exception exception);
        protected Microsoft.AspNetCore.Components.IComponent InstantiateComponent(System.Type componentType) { throw null; }
        protected System.Threading.Tasks.Task RenderRootComponentAsync(int componentId) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        protected System.Threading.Tasks.Task RenderRootComponentAsync(int componentId, Microsoft.AspNetCore.Components.ParameterCollection initialParameters) { throw null; }
        protected abstract System.Threading.Tasks.Task UpdateDisplayAsync(in Microsoft.AspNetCore.Components.Rendering.RenderBatch renderBatch);
    }
}
namespace Microsoft.AspNetCore.Components.RenderTree
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ArrayBuilderSegment<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public T[] Array { get { throw null; } }
        public int Count { get { throw null; } }
        public T this[int index] { get { throw null; } }
        public int Offset { get { throw null; } }
        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ArrayRange<T>
    {
        public readonly T[] Array;
        public readonly int Count;
        public ArrayRange(T[] array, int count) { throw null; }
        public Microsoft.AspNetCore.Components.RenderTree.ArrayRange<T> Clone() { throw null; }
    }
    public partial class RenderTreeBuilder : System.IDisposable
    {
        public const string ChildContent = "ChildContent";
        public RenderTreeBuilder(Microsoft.AspNetCore.Components.Rendering.Renderer renderer) { }
        public void AddAttribute(int sequence, in Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame frame) { }
        public void AddAttribute(int sequence, string name, Microsoft.AspNetCore.Components.EventCallback value) { }
        public void AddAttribute(int sequence, string name, System.Action value) { }
        public void AddAttribute(int sequence, string name, bool value) { }
        public void AddAttribute(int sequence, string name, System.Func<System.Threading.Tasks.Task> value) { }
        public void AddAttribute(int sequence, string name, System.MulticastDelegate value) { }
        public void AddAttribute(int sequence, string name, object value) { }
        public void AddAttribute(int sequence, string name, string value) { }
        public void AddAttribute<T>(int sequence, string name, Microsoft.AspNetCore.Components.EventCallback<T> value) { }
        public void AddComponentReferenceCapture(int sequence, System.Action<object> componentReferenceCaptureAction) { }
        public void AddContent(int sequence, Microsoft.AspNetCore.Components.MarkupString markupContent) { }
        public void AddContent(int sequence, Microsoft.AspNetCore.Components.RenderFragment fragment) { }
        public void AddContent(int sequence, object textContent) { }
        public void AddContent(int sequence, string textContent) { }
        public void AddContent<T>(int sequence, Microsoft.AspNetCore.Components.RenderFragment<T> fragment, T value) { }
        public void AddElementReferenceCapture(int sequence, System.Action<Microsoft.AspNetCore.Components.ElementReference> elementReferenceCaptureAction) { }
        public void AddMarkupContent(int sequence, string markupContent) { }
        public void AddMultipleAttributes(int sequence, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>> attributes) { }
        public void Clear() { }
        public void CloseComponent() { }
        public void CloseElement() { }
        public void CloseRegion() { }
        public Microsoft.AspNetCore.Components.RenderTree.ArrayRange<Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame> GetFrames() { throw null; }
        public void OpenComponent(int sequence, System.Type componentType) { }
        public void OpenComponent<TComponent>(int sequence) where TComponent : Microsoft.AspNetCore.Components.IComponent { }
        public void OpenElement(int sequence, string elementName) { }
        public void OpenRegion(int sequence) { }
        public void SetKey(object value) { }
        public void SetUpdatesAttributeName(string updatesAttributeName) { }
        void System.IDisposable.Dispose() { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RenderTreeDiff
    {
        public readonly int ComponentId;
        public readonly Microsoft.AspNetCore.Components.RenderTree.ArrayBuilderSegment<Microsoft.AspNetCore.Components.RenderTree.RenderTreeEdit> Edits;
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public readonly partial struct RenderTreeEdit
    {
        [System.Runtime.InteropServices.FieldOffsetAttribute(8)]
        public readonly int MoveToSiblingIndex;
        [System.Runtime.InteropServices.FieldOffsetAttribute(8)]
        public readonly int ReferenceFrameIndex;
        [System.Runtime.InteropServices.FieldOffsetAttribute(16)]
        public readonly string RemovedAttributeName;
        [System.Runtime.InteropServices.FieldOffsetAttribute(4)]
        public readonly int SiblingIndex;
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public readonly Microsoft.AspNetCore.Components.RenderTree.RenderTreeEditType Type;
    }
    public enum RenderTreeEditType
    {
        PrependFrame = 1,
        RemoveFrame = 2,
        SetAttribute = 3,
        RemoveAttribute = 4,
        UpdateText = 5,
        StepIn = 6,
        StepOut = 7,
        UpdateMarkup = 8,
        PermutationListEntry = 9,
        PermutationListEnd = 10,
    }
    public enum RenderTreeFrameType : short
    {
        None = (short)0,
        Element = (short)1,
        Text = (short)2,
        Attribute = (short)3,
        Component = (short)4,
        Region = (short)5,
        ElementReferenceCapture = (short)6,
        ComponentReferenceCapture = (short)7,
        Markup = (short)8,
    }
}
namespace Microsoft.AspNetCore.Components.Routing
{
    public partial interface INavigationInterception
    {
        System.Threading.Tasks.Task EnableNavigationInterceptionAsync();
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct LocationChangedEventArgs
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public LocationChangedEventArgs(string location, bool isNavigationIntercepted) { throw null; }
        public bool IsNavigationIntercepted { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Location { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
}
