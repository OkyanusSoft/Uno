#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Contacts
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class FullContactCardOptions 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.ViewManagement.ViewSizePreference DesiredRemainingView
		{
			get
			{
				throw new global::System.NotImplementedException("The member ViewSizePreference FullContactCardOptions.DesiredRemainingView is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ViewSizePreference%20FullContactCardOptions.DesiredRemainingView");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Contacts.FullContactCardOptions", "ViewSizePreference FullContactCardOptions.DesiredRemainingView");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public FullContactCardOptions() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Contacts.FullContactCardOptions", "FullContactCardOptions.FullContactCardOptions()");
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Contacts.FullContactCardOptions.FullContactCardOptions()
		// Forced skipping of method Windows.ApplicationModel.Contacts.FullContactCardOptions.DesiredRemainingView.get
		// Forced skipping of method Windows.ApplicationModel.Contacts.FullContactCardOptions.DesiredRemainingView.set
	}
}
