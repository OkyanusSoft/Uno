#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Services.Store
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class StoreUninstallStorePackageResult 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Exception ExtendedError
		{
			get
			{
				throw new global::System.NotImplementedException("The member Exception StoreUninstallStorePackageResult.ExtendedError is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Exception%20StoreUninstallStorePackageResult.ExtendedError");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Services.Store.StoreUninstallStorePackageStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member StoreUninstallStorePackageStatus StoreUninstallStorePackageResult.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StoreUninstallStorePackageStatus%20StoreUninstallStorePackageResult.Status");
			}
		}
#endif
		// Forced skipping of method Windows.Services.Store.StoreUninstallStorePackageResult.ExtendedError.get
		// Forced skipping of method Windows.Services.Store.StoreUninstallStorePackageResult.Status.get
	}
}
