#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Core
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial interface ICorePointerInputSource2 : global::Windows.UI.Core.ICorePointerInputSource
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Windows.System.DispatcherQueue DispatcherQueue
		{
			get;
		}
#endif
		// Forced skipping of method Windows.UI.Core.ICorePointerInputSource2.DispatcherQueue.get
	}
}
