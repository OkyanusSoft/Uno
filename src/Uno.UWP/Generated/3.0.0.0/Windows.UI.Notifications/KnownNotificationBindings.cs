#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Notifications
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public static partial class KnownNotificationBindings 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string ToastGeneric
		{
			get
			{
				throw new global::System.NotImplementedException("The member string KnownNotificationBindings.ToastGeneric is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20KnownNotificationBindings.ToastGeneric");
			}
		}
#endif
		// Forced skipping of method Windows.UI.Notifications.KnownNotificationBindings.ToastGeneric.get
	}
}
