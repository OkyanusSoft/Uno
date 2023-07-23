#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.FaceAnalysis
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class FaceTracker 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Graphics.Imaging.BitmapSize MinDetectableFaceSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member BitmapSize FaceTracker.MinDetectableFaceSize is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=BitmapSize%20FaceTracker.MinDetectableFaceSize");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.FaceAnalysis.FaceTracker", "BitmapSize FaceTracker.MinDetectableFaceSize");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Graphics.Imaging.BitmapSize MaxDetectableFaceSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member BitmapSize FaceTracker.MaxDetectableFaceSize is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=BitmapSize%20FaceTracker.MaxDetectableFaceSize");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.FaceAnalysis.FaceTracker", "BitmapSize FaceTracker.MaxDetectableFaceSize");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool IsSupported
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool FaceTracker.IsSupported is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20FaceTracker.IsSupported");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IList<global::Windows.Media.FaceAnalysis.DetectedFace>> ProcessNextFrameAsync( global::Windows.Media.VideoFrame videoFrame)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IList<DetectedFace>> FaceTracker.ProcessNextFrameAsync(VideoFrame videoFrame) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIList%3CDetectedFace%3E%3E%20FaceTracker.ProcessNextFrameAsync%28VideoFrame%20videoFrame%29");
		}
#endif
		// Forced skipping of method Windows.Media.FaceAnalysis.FaceTracker.MinDetectableFaceSize.get
		// Forced skipping of method Windows.Media.FaceAnalysis.FaceTracker.MinDetectableFaceSize.set
		// Forced skipping of method Windows.Media.FaceAnalysis.FaceTracker.MaxDetectableFaceSize.get
		// Forced skipping of method Windows.Media.FaceAnalysis.FaceTracker.MaxDetectableFaceSize.set
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Media.FaceAnalysis.FaceTracker> CreateAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<FaceTracker> FaceTracker.CreateAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CFaceTracker%3E%20FaceTracker.CreateAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Collections.Generic.IReadOnlyList<global::Windows.Graphics.Imaging.BitmapPixelFormat> GetSupportedBitmapPixelFormats()
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<BitmapPixelFormat> FaceTracker.GetSupportedBitmapPixelFormats() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CBitmapPixelFormat%3E%20FaceTracker.GetSupportedBitmapPixelFormats%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool IsBitmapPixelFormatSupported( global::Windows.Graphics.Imaging.BitmapPixelFormat bitmapPixelFormat)
		{
			throw new global::System.NotImplementedException("The member bool FaceTracker.IsBitmapPixelFormatSupported(BitmapPixelFormat bitmapPixelFormat) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20FaceTracker.IsBitmapPixelFormatSupported%28BitmapPixelFormat%20bitmapPixelFormat%29");
		}
#endif
		// Forced skipping of method Windows.Media.FaceAnalysis.FaceTracker.IsSupported.get
	}
}
