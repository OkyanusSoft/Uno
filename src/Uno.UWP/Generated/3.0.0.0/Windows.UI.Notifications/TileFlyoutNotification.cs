#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Notifications
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class TileFlyoutNotification 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.DateTimeOffset? ExpirationTime
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset? TileFlyoutNotification.ExpirationTime is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DateTimeOffset%3F%20TileFlyoutNotification.ExpirationTime");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Notifications.TileFlyoutNotification", "DateTimeOffset? TileFlyoutNotification.ExpirationTime");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Data.Xml.Dom.XmlDocument Content
		{
			get
			{
				throw new global::System.NotImplementedException("The member XmlDocument TileFlyoutNotification.Content is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=XmlDocument%20TileFlyoutNotification.Content");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public TileFlyoutNotification( global::Windows.Data.Xml.Dom.XmlDocument content) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Notifications.TileFlyoutNotification", "TileFlyoutNotification.TileFlyoutNotification(XmlDocument content)");
		}
#endif
		// Forced skipping of method Windows.UI.Notifications.TileFlyoutNotification.TileFlyoutNotification(Windows.Data.Xml.Dom.XmlDocument)
		// Forced skipping of method Windows.UI.Notifications.TileFlyoutNotification.Content.get
		// Forced skipping of method Windows.UI.Notifications.TileFlyoutNotification.ExpirationTime.set
		// Forced skipping of method Windows.UI.Notifications.TileFlyoutNotification.ExpirationTime.get
	}
}
