#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class PlaybackPositionChangeRequestedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan RequestedPlaybackPosition
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan PlaybackPositionChangeRequestedEventArgs.RequestedPlaybackPosition is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=TimeSpan%20PlaybackPositionChangeRequestedEventArgs.RequestedPlaybackPosition");
			}
		}
#endif
		// Forced skipping of method Windows.Media.PlaybackPositionChangeRequestedEventArgs.RequestedPlaybackPosition.get
	}
}
