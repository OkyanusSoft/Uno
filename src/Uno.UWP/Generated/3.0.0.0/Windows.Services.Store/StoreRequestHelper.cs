#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Services.Store
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public static partial class StoreRequestHelper 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Services.Store.StoreSendRequestResult> SendRequestAsync( global::Windows.Services.Store.StoreContext context,  uint requestKind,  string parametersAsJson)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StoreSendRequestResult> StoreRequestHelper.SendRequestAsync(StoreContext context, uint requestKind, string parametersAsJson) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CStoreSendRequestResult%3E%20StoreRequestHelper.SendRequestAsync%28StoreContext%20context%2C%20uint%20requestKind%2C%20string%20parametersAsJson%29");
		}
#endif
	}
}
