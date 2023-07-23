#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Notifications
{
#if __ANDROID__ || false || false || false || false || false || false
	[global::Uno.NotImplemented("__ANDROID__")]
#endif
	public  partial class BadgeNotification 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.DateTimeOffset? ExpirationTime
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset? BadgeNotification.ExpirationTime is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DateTimeOffset%3F%20BadgeNotification.ExpirationTime");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Notifications.BadgeNotification", "DateTimeOffset? BadgeNotification.ExpirationTime");
			}
		}
#endif
#if __ANDROID__ || false || false || false || false || false || false
		[global::Uno.NotImplemented("__ANDROID__")]
		public  global::Windows.Data.Xml.Dom.XmlDocument Content
		{
			get
			{
				throw new global::System.NotImplementedException("The member XmlDocument BadgeNotification.Content is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=XmlDocument%20BadgeNotification.Content");
			}
		}
#endif
#if __ANDROID__ || false || false || false || false || false || false
		[global::Uno.NotImplemented("__ANDROID__")]
		public BadgeNotification( global::Windows.Data.Xml.Dom.XmlDocument content) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Notifications.BadgeNotification", "BadgeNotification.BadgeNotification(XmlDocument content)");
		}
#endif
		// Forced skipping of method Windows.UI.Notifications.BadgeNotification.BadgeNotification(Windows.Data.Xml.Dom.XmlDocument)
		// Forced skipping of method Windows.UI.Notifications.BadgeNotification.Content.get
		// Forced skipping of method Windows.UI.Notifications.BadgeNotification.ExpirationTime.set
		// Forced skipping of method Windows.UI.Notifications.BadgeNotification.ExpirationTime.get
	}
}
