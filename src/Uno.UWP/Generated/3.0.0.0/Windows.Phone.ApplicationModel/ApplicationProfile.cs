#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Phone.ApplicationModel
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public static partial class ApplicationProfile 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Phone.ApplicationModel.ApplicationProfileModes Modes
		{
			get
			{
				throw new global::System.NotImplementedException("The member ApplicationProfileModes ApplicationProfile.Modes is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ApplicationProfileModes%20ApplicationProfile.Modes");
			}
		}
#endif
		// Forced skipping of method Windows.Phone.ApplicationModel.ApplicationProfile.Modes.get
	}
}
