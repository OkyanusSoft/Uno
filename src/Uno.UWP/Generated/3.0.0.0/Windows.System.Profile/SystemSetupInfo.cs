#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.Profile
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public static partial class SystemSetupInfo 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.System.Profile.SystemOutOfBoxExperienceState OutOfBoxExperienceState
		{
			get
			{
				throw new global::System.NotImplementedException("The member SystemOutOfBoxExperienceState SystemSetupInfo.OutOfBoxExperienceState is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SystemOutOfBoxExperienceState%20SystemSetupInfo.OutOfBoxExperienceState");
			}
		}
#endif
		// Forced skipping of method Windows.System.Profile.SystemSetupInfo.OutOfBoxExperienceState.get
		// Forced skipping of method Windows.System.Profile.SystemSetupInfo.OutOfBoxExperienceStateChanged.add
		// Forced skipping of method Windows.System.Profile.SystemSetupInfo.OutOfBoxExperienceStateChanged.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static event global::System.EventHandler<object> OutOfBoxExperienceStateChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.System.Profile.SystemSetupInfo", "event EventHandler<object> SystemSetupInfo.OutOfBoxExperienceStateChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.System.Profile.SystemSetupInfo", "event EventHandler<object> SystemSetupInfo.OutOfBoxExperienceStateChanged");
			}
		}
#endif
	}
}
