#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Services.Store
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class StoreAcquireLicenseResult 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Exception ExtendedError
		{
			get
			{
				throw new global::System.NotImplementedException("The member Exception StoreAcquireLicenseResult.ExtendedError is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Exception%20StoreAcquireLicenseResult.ExtendedError");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Services.Store.StorePackageLicense StorePackageLicense
		{
			get
			{
				throw new global::System.NotImplementedException("The member StorePackageLicense StoreAcquireLicenseResult.StorePackageLicense is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StorePackageLicense%20StoreAcquireLicenseResult.StorePackageLicense");
			}
		}
#endif
		// Forced skipping of method Windows.Services.Store.StoreAcquireLicenseResult.StorePackageLicense.get
		// Forced skipping of method Windows.Services.Store.StoreAcquireLicenseResult.ExtendedError.get
	}
}
