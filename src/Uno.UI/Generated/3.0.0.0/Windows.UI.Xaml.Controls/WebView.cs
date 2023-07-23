#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
#endif
	public  partial class WebView 
	{
		// Skipping already declared property Source
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::System.Uri> AllowedScriptNotifyUris
		{
			get
			{
				return (global::System.Collections.Generic.IList<global::System.Uri>)this.GetValue(AllowedScriptNotifyUrisProperty);
			}
			set
			{
				this.SetValue(AllowedScriptNotifyUrisProperty, value);
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.DataTransfer.DataPackage DataTransferPackage
		{
			get
			{
				return (global::Windows.ApplicationModel.DataTransfer.DataPackage)this.GetValue(DataTransferPackageProperty);
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Color DefaultBackgroundColor
		{
			get
			{
				return (global::Windows.UI.Color)this.GetValue(DefaultBackgroundColorProperty);
			}
			set
			{
				this.SetValue(DefaultBackgroundColorProperty, value);
			}
		}
#endif
		// Skipping already declared property CanGoBack
		// Skipping already declared property CanGoForward
		// Skipping already declared property DocumentTitle
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool ContainsFullScreenElement
		{
			get
			{
				return (bool)this.GetValue(ContainsFullScreenElementProperty);
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Controls.WebViewDeferredPermissionRequest> DeferredPermissionRequests
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<WebViewDeferredPermissionRequest> WebView.DeferredPermissionRequests is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IList%3CWebViewDeferredPermissionRequest%3E%20WebView.DeferredPermissionRequests");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Controls.WebViewExecutionMode ExecutionMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member WebViewExecutionMode WebView.ExecutionMode is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=WebViewExecutionMode%20WebView.ExecutionMode");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Controls.WebViewSettings Settings
		{
			get
			{
				throw new global::System.NotImplementedException("The member WebViewSettings WebView.Settings is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=WebViewSettings%20WebView.Settings");
			}
		}
#endif
		// Skipping already declared property XYFocusUp
		// Skipping already declared property XYFocusRight
		// Skipping already declared property XYFocusLeft
		// Skipping already declared property XYFocusDown
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty AllowedScriptNotifyUrisProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(AllowedScriptNotifyUris), typeof(global::System.Collections.Generic.IList<global::System.Uri>), 
			typeof(global::Windows.UI.Xaml.Controls.WebView), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::System.Collections.Generic.IList<global::System.Uri>)));
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Collections.Generic.IList<global::System.Uri> AnyScriptNotifyUri
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<Uri> WebView.AnyScriptNotifyUri is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IList%3CUri%3E%20WebView.AnyScriptNotifyUri");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty DataTransferPackageProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(DataTransferPackage), typeof(global::Windows.ApplicationModel.DataTransfer.DataPackage), 
			typeof(global::Windows.UI.Xaml.Controls.WebView), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.ApplicationModel.DataTransfer.DataPackage)));
#endif
		// Skipping already declared property SourceProperty
		// Skipping already declared property CanGoBackProperty
		// Skipping already declared property CanGoForwardProperty
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty DefaultBackgroundColorProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(DefaultBackgroundColor), typeof(global::Windows.UI.Color), 
			typeof(global::Windows.UI.Xaml.Controls.WebView), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Color)));
#endif
		// Skipping already declared property DocumentTitleProperty
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ContainsFullScreenElementProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(ContainsFullScreenElement), typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.WebView), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.Controls.WebViewExecutionMode DefaultExecutionMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member WebViewExecutionMode WebView.DefaultExecutionMode is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=WebViewExecutionMode%20WebView.DefaultExecutionMode");
			}
		}
#endif
		// Skipping already declared property XYFocusDownProperty
		// Skipping already declared property XYFocusLeftProperty
		// Skipping already declared property XYFocusRightProperty
		// Skipping already declared property XYFocusUpProperty
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public WebView( global::Windows.UI.Xaml.Controls.WebViewExecutionMode executionMode) : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "WebView.WebView(WebViewExecutionMode executionMode)");
		}
#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.WebView(Windows.UI.Xaml.Controls.WebViewExecutionMode)
		// Skipping already declared method Windows.UI.Xaml.Controls.WebView.WebView()
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.WebView()
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.Source.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.Source.set
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.AllowedScriptNotifyUris.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.AllowedScriptNotifyUris.set
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.DataTransferPackage.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.LoadCompleted.add
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.LoadCompleted.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.ScriptNotify.add
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.ScriptNotify.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.NavigationFailed.add
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.NavigationFailed.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string InvokeScript( string scriptName,  string[] arguments)
		{
			throw new global::System.NotImplementedException("The member string WebView.InvokeScript(string scriptName, string[] arguments) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20WebView.InvokeScript%28string%20scriptName%2C%20string%5B%5D%20arguments%29");
		}
#endif
		// Skipping already declared method Windows.UI.Xaml.Controls.WebView.Navigate(System.Uri)
		// Skipping already declared method Windows.UI.Xaml.Controls.WebView.NavigateToString(string)
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.CanGoBack.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.CanGoForward.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.DocumentTitle.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.NavigationStarting.add
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.NavigationStarting.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.ContentLoading.add
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.ContentLoading.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.DOMContentLoaded.add
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.DOMContentLoaded.remove
		// Skipping already declared method Windows.UI.Xaml.Controls.WebView.GoForward()
		// Skipping already declared method Windows.UI.Xaml.Controls.WebView.GoBack()
		// Skipping already declared method Windows.UI.Xaml.Controls.WebView.Refresh()
		// Skipping already declared method Windows.UI.Xaml.Controls.WebView.Stop()
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction CapturePreviewToStreamAsync( global::Windows.Storage.Streams.IRandomAccessStream stream)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction WebView.CapturePreviewToStreamAsync(IRandomAccessStream stream) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20WebView.CapturePreviewToStreamAsync%28IRandomAccessStream%20stream%29");
		}
#endif
		// Skipping already declared method Windows.UI.Xaml.Controls.WebView.InvokeScriptAsync(string, System.Collections.Generic.IEnumerable<string>)
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.DataTransfer.DataPackage> CaptureSelectedContentToDataPackageAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<DataPackage> WebView.CaptureSelectedContentToDataPackageAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CDataPackage%3E%20WebView.CaptureSelectedContentToDataPackageAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void NavigateToLocalStreamUri( global::System.Uri source,  global::Windows.Web.IUriToStreamResolver streamResolver)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "void WebView.NavigateToLocalStreamUri(Uri source, IUriToStreamResolver streamResolver)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Uri BuildLocalStreamUri( string contentIdentifier,  string relativePath)
		{
			throw new global::System.NotImplementedException("The member Uri WebView.BuildLocalStreamUri(string contentIdentifier, string relativePath) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Uri%20WebView.BuildLocalStreamUri%28string%20contentIdentifier%2C%20string%20relativePath%29");
		}
#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.DefaultBackgroundColor.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.DefaultBackgroundColor.set
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.NavigationCompleted.add
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.NavigationCompleted.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.FrameNavigationStarting.add
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.FrameNavigationStarting.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.FrameContentLoading.add
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.FrameContentLoading.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.FrameDOMContentLoaded.add
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.FrameDOMContentLoaded.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.FrameNavigationCompleted.add
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.FrameNavigationCompleted.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.LongRunningScriptDetected.add
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.LongRunningScriptDetected.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.UnsafeContentWarningDisplaying.add
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.UnsafeContentWarningDisplaying.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.UnviewableContentIdentified.add
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.UnviewableContentIdentified.remove
		// Skipping already declared method Windows.UI.Xaml.Controls.WebView.NavigateWithHttpRequestMessage(Windows.Web.Http.HttpRequestMessage)
		// Skipping already declared method Windows.UI.Xaml.Controls.WebView.Focus(Windows.UI.Xaml.FocusState)
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.ContainsFullScreenElement.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.ContainsFullScreenElementChanged.add
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.ContainsFullScreenElementChanged.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.ExecutionMode.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.DeferredPermissionRequests.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.Settings.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.UnsupportedUriSchemeIdentified.add
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.UnsupportedUriSchemeIdentified.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.NewWindowRequested.add
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.NewWindowRequested.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.PermissionRequested.add
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.PermissionRequested.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void AddWebAllowedObject( string name,  object pObject)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "void WebView.AddWebAllowedObject(string name, object pObject)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Controls.WebViewDeferredPermissionRequest DeferredPermissionRequestById( uint id)
		{
			throw new global::System.NotImplementedException("The member WebViewDeferredPermissionRequest WebView.DeferredPermissionRequestById(uint id) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=WebViewDeferredPermissionRequest%20WebView.DeferredPermissionRequestById%28uint%20id%29");
		}
#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.XYFocusLeft.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.XYFocusLeft.set
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.XYFocusRight.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.XYFocusRight.set
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.XYFocusUp.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.XYFocusUp.set
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.XYFocusDown.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.XYFocusDown.set
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.SeparateProcessLost.add
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.SeparateProcessLost.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.WebResourceRequested.add
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.WebResourceRequested.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.XYFocusLeftProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.XYFocusRightProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.XYFocusUpProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.XYFocusDownProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.DefaultExecutionMode.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction ClearTemporaryWebDataAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction WebView.ClearTemporaryWebDataAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20WebView.ClearTemporaryWebDataAsync%28%29");
		}
#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.ContainsFullScreenElementProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.CanGoBackProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.CanGoForwardProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.DocumentTitleProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.DefaultBackgroundColorProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.AnyScriptNotifyUri.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.SourceProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.AllowedScriptNotifyUrisProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebView.DataTransferPackageProperty.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.UI.Xaml.Navigation.LoadCompletedEventHandler LoadCompleted
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event LoadCompletedEventHandler WebView.LoadCompleted");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event LoadCompletedEventHandler WebView.LoadCompleted");
			}
		}
#endif
		// Skipping already declared event Windows.UI.Xaml.Controls.WebView.NavigationFailed
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.UI.Xaml.Controls.NotifyEventHandler ScriptNotify
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event NotifyEventHandler WebView.ScriptNotify");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event NotifyEventHandler WebView.ScriptNotify");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.WebView, global::Windows.UI.Xaml.Controls.WebViewContentLoadingEventArgs> ContentLoading
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, WebViewContentLoadingEventArgs> WebView.ContentLoading");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, WebViewContentLoadingEventArgs> WebView.ContentLoading");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.WebView, global::Windows.UI.Xaml.Controls.WebViewDOMContentLoadedEventArgs> DOMContentLoaded
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, WebViewDOMContentLoadedEventArgs> WebView.DOMContentLoaded");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, WebViewDOMContentLoadedEventArgs> WebView.DOMContentLoaded");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.WebView, global::Windows.UI.Xaml.Controls.WebViewContentLoadingEventArgs> FrameContentLoading
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, WebViewContentLoadingEventArgs> WebView.FrameContentLoading");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, WebViewContentLoadingEventArgs> WebView.FrameContentLoading");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.WebView, global::Windows.UI.Xaml.Controls.WebViewDOMContentLoadedEventArgs> FrameDOMContentLoaded
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, WebViewDOMContentLoadedEventArgs> WebView.FrameDOMContentLoaded");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, WebViewDOMContentLoadedEventArgs> WebView.FrameDOMContentLoaded");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.WebView, global::Windows.UI.Xaml.Controls.WebViewNavigationCompletedEventArgs> FrameNavigationCompleted
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, WebViewNavigationCompletedEventArgs> WebView.FrameNavigationCompleted");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, WebViewNavigationCompletedEventArgs> WebView.FrameNavigationCompleted");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.WebView, global::Windows.UI.Xaml.Controls.WebViewNavigationStartingEventArgs> FrameNavigationStarting
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, WebViewNavigationStartingEventArgs> WebView.FrameNavigationStarting");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, WebViewNavigationStartingEventArgs> WebView.FrameNavigationStarting");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.WebView, global::Windows.UI.Xaml.Controls.WebViewLongRunningScriptDetectedEventArgs> LongRunningScriptDetected
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, WebViewLongRunningScriptDetectedEventArgs> WebView.LongRunningScriptDetected");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, WebViewLongRunningScriptDetectedEventArgs> WebView.LongRunningScriptDetected");
			}
		}
#endif
		// Skipping already declared event Windows.UI.Xaml.Controls.WebView.NavigationCompleted
		// Skipping already declared event Windows.UI.Xaml.Controls.WebView.NavigationStarting
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.WebView, object> UnsafeContentWarningDisplaying
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, object> WebView.UnsafeContentWarningDisplaying");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, object> WebView.UnsafeContentWarningDisplaying");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.WebView, global::Windows.UI.Xaml.Controls.WebViewUnviewableContentIdentifiedEventArgs> UnviewableContentIdentified
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, WebViewUnviewableContentIdentifiedEventArgs> WebView.UnviewableContentIdentified");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, WebViewUnviewableContentIdentifiedEventArgs> WebView.UnviewableContentIdentified");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.WebView, object> ContainsFullScreenElementChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, object> WebView.ContainsFullScreenElementChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, object> WebView.ContainsFullScreenElementChanged");
			}
		}
#endif
		// Skipping already declared event Windows.UI.Xaml.Controls.WebView.NewWindowRequested
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.WebView, global::Windows.UI.Xaml.Controls.WebViewPermissionRequestedEventArgs> PermissionRequested
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, WebViewPermissionRequestedEventArgs> WebView.PermissionRequested");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, WebViewPermissionRequestedEventArgs> WebView.PermissionRequested");
			}
		}
#endif
		// Skipping already declared event Windows.UI.Xaml.Controls.WebView.UnsupportedUriSchemeIdentified
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.WebView, global::Windows.UI.Xaml.Controls.WebViewSeparateProcessLostEventArgs> SeparateProcessLost
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, WebViewSeparateProcessLostEventArgs> WebView.SeparateProcessLost");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, WebViewSeparateProcessLostEventArgs> WebView.SeparateProcessLost");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.WebView, global::Windows.UI.Xaml.Controls.WebViewWebResourceRequestedEventArgs> WebResourceRequested
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, WebViewWebResourceRequestedEventArgs> WebView.WebResourceRequested");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebView", "event TypedEventHandler<WebView, WebViewWebResourceRequestedEventArgs> WebView.WebResourceRequested");
			}
		}
#endif
	}
}
