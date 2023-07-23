#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Capture.Frames
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class BufferMediaFrame 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Streams.IBuffer Buffer
		{
			get
			{
				throw new global::System.NotImplementedException("The member IBuffer BufferMediaFrame.Buffer is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IBuffer%20BufferMediaFrame.Buffer");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Capture.Frames.MediaFrameReference FrameReference
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaFrameReference BufferMediaFrame.FrameReference is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=MediaFrameReference%20BufferMediaFrame.FrameReference");
			}
		}
#endif
		// Forced skipping of method Windows.Media.Capture.Frames.BufferMediaFrame.FrameReference.get
		// Forced skipping of method Windows.Media.Capture.Frames.BufferMediaFrame.Buffer.get
	}
}
