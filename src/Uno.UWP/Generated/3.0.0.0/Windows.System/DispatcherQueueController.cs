#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class DispatcherQueueController 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.DispatcherQueue DispatcherQueue
		{
			get
			{
				throw new global::System.NotImplementedException("The member DispatcherQueue DispatcherQueueController.DispatcherQueue is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DispatcherQueue%20DispatcherQueueController.DispatcherQueue");
			}
		}
#endif
		// Forced skipping of method Windows.System.DispatcherQueueController.DispatcherQueue.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction ShutdownQueueAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction DispatcherQueueController.ShutdownQueueAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20DispatcherQueueController.ShutdownQueueAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.System.DispatcherQueueController CreateOnDedicatedThread()
		{
			throw new global::System.NotImplementedException("The member DispatcherQueueController DispatcherQueueController.CreateOnDedicatedThread() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DispatcherQueueController%20DispatcherQueueController.CreateOnDedicatedThread%28%29");
		}
#endif
	}
}
