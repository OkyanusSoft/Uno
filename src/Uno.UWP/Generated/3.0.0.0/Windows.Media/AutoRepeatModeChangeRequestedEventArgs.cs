#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class AutoRepeatModeChangeRequestedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.MediaPlaybackAutoRepeatMode RequestedAutoRepeatMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaPlaybackAutoRepeatMode AutoRepeatModeChangeRequestedEventArgs.RequestedAutoRepeatMode is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=MediaPlaybackAutoRepeatMode%20AutoRepeatModeChangeRequestedEventArgs.RequestedAutoRepeatMode");
			}
		}
#endif
		// Forced skipping of method Windows.Media.AutoRepeatModeChangeRequestedEventArgs.RequestedAutoRepeatMode.get
	}
}
