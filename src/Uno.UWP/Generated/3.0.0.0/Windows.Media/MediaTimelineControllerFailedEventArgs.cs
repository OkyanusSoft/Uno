#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class MediaTimelineControllerFailedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Exception ExtendedError
		{
			get
			{
				throw new global::System.NotImplementedException("The member Exception MediaTimelineControllerFailedEventArgs.ExtendedError is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Exception%20MediaTimelineControllerFailedEventArgs.ExtendedError");
			}
		}
#endif
		// Forced skipping of method Windows.Media.MediaTimelineControllerFailedEventArgs.ExtendedError.get
	}
}
