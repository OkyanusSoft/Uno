#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Perception
{
	// This type is deprecated. Consider not implementing it.
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public static partial class KnownPerceptionDepthFrameSourceProperties 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string MaxDepth
		{
			get
			{
				throw new global::System.NotImplementedException("The member string KnownPerceptionDepthFrameSourceProperties.MaxDepth is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20KnownPerceptionDepthFrameSourceProperties.MaxDepth");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string MinDepth
		{
			get
			{
				throw new global::System.NotImplementedException("The member string KnownPerceptionDepthFrameSourceProperties.MinDepth is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20KnownPerceptionDepthFrameSourceProperties.MinDepth");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.Perception.KnownPerceptionDepthFrameSourceProperties.MinDepth.get
		// Forced skipping of method Windows.Devices.Perception.KnownPerceptionDepthFrameSourceProperties.MaxDepth.get
	}
}
