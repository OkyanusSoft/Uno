#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Services.Store
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class StoreQueueItemCompletedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Services.Store.StoreQueueItemStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member StoreQueueItemStatus StoreQueueItemCompletedEventArgs.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StoreQueueItemStatus%20StoreQueueItemCompletedEventArgs.Status");
			}
		}
#endif
		// Forced skipping of method Windows.Services.Store.StoreQueueItemCompletedEventArgs.Status.get
	}
}
