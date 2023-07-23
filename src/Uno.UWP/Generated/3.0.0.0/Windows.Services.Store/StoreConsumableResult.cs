#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Services.Store
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class StoreConsumableResult 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint BalanceRemaining
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint StoreConsumableResult.BalanceRemaining is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20StoreConsumableResult.BalanceRemaining");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Exception ExtendedError
		{
			get
			{
				throw new global::System.NotImplementedException("The member Exception StoreConsumableResult.ExtendedError is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Exception%20StoreConsumableResult.ExtendedError");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Services.Store.StoreConsumableStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member StoreConsumableStatus StoreConsumableResult.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StoreConsumableStatus%20StoreConsumableResult.Status");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Guid TrackingId
		{
			get
			{
				throw new global::System.NotImplementedException("The member Guid StoreConsumableResult.TrackingId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Guid%20StoreConsumableResult.TrackingId");
			}
		}
#endif
		// Forced skipping of method Windows.Services.Store.StoreConsumableResult.Status.get
		// Forced skipping of method Windows.Services.Store.StoreConsumableResult.TrackingId.get
		// Forced skipping of method Windows.Services.Store.StoreConsumableResult.BalanceRemaining.get
		// Forced skipping of method Windows.Services.Store.StoreConsumableResult.ExtendedError.get
	}
}
