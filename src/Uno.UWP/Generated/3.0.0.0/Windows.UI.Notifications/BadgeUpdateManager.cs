#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Notifications
{
#if __ANDROID__ || false || false || false || false || false || false
	[global::Uno.NotImplemented("__ANDROID__")]
#endif
	public static partial class BadgeUpdateManager 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Notifications.BadgeUpdateManagerForUser GetForUser( global::Windows.System.User user)
		{
			throw new global::System.NotImplementedException("The member BadgeUpdateManagerForUser BadgeUpdateManager.GetForUser(User user) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=BadgeUpdateManagerForUser%20BadgeUpdateManager.GetForUser%28User%20user%29");
		}
#endif
#if __ANDROID__ || false || false || false || false || false || false
		[global::Uno.NotImplemented("__ANDROID__")]
		public static global::Windows.UI.Notifications.BadgeUpdater CreateBadgeUpdaterForApplication()
		{
			throw new global::System.NotImplementedException("The member BadgeUpdater BadgeUpdateManager.CreateBadgeUpdaterForApplication() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=BadgeUpdater%20BadgeUpdateManager.CreateBadgeUpdaterForApplication%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Notifications.BadgeUpdater CreateBadgeUpdaterForApplication( string applicationId)
		{
			throw new global::System.NotImplementedException("The member BadgeUpdater BadgeUpdateManager.CreateBadgeUpdaterForApplication(string applicationId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=BadgeUpdater%20BadgeUpdateManager.CreateBadgeUpdaterForApplication%28string%20applicationId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Notifications.BadgeUpdater CreateBadgeUpdaterForSecondaryTile( string tileId)
		{
			throw new global::System.NotImplementedException("The member BadgeUpdater BadgeUpdateManager.CreateBadgeUpdaterForSecondaryTile(string tileId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=BadgeUpdater%20BadgeUpdateManager.CreateBadgeUpdaterForSecondaryTile%28string%20tileId%29");
		}
#endif
#if __ANDROID__ || false || false || false || false || false || false
		[global::Uno.NotImplemented("__ANDROID__")]
		public static global::Windows.Data.Xml.Dom.XmlDocument GetTemplateContent( global::Windows.UI.Notifications.BadgeTemplateType type)
		{
			throw new global::System.NotImplementedException("The member XmlDocument BadgeUpdateManager.GetTemplateContent(BadgeTemplateType type) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=XmlDocument%20BadgeUpdateManager.GetTemplateContent%28BadgeTemplateType%20type%29");
		}
#endif
	}
}
