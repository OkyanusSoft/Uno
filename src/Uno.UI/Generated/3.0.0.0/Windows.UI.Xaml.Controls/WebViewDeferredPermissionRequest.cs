#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class WebViewDeferredPermissionRequest 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint Id
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint WebViewDeferredPermissionRequest.Id is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20WebViewDeferredPermissionRequest.Id");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Controls.WebViewPermissionType PermissionType
		{
			get
			{
				throw new global::System.NotImplementedException("The member WebViewPermissionType WebViewDeferredPermissionRequest.PermissionType is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=WebViewPermissionType%20WebViewDeferredPermissionRequest.PermissionType");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Uri Uri
		{
			get
			{
				throw new global::System.NotImplementedException("The member Uri WebViewDeferredPermissionRequest.Uri is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Uri%20WebViewDeferredPermissionRequest.Uri");
			}
		}
#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.WebViewDeferredPermissionRequest.Uri.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebViewDeferredPermissionRequest.PermissionType.get
		// Forced skipping of method Windows.UI.Xaml.Controls.WebViewDeferredPermissionRequest.Id.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Allow()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebViewDeferredPermissionRequest", "void WebViewDeferredPermissionRequest.Allow()");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Deny()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.WebViewDeferredPermissionRequest", "void WebViewDeferredPermissionRequest.Deny()");
		}
#endif
	}
}
