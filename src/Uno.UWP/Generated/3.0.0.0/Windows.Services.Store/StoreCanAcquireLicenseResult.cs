#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Services.Store
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class StoreCanAcquireLicenseResult 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Exception ExtendedError
		{
			get
			{
				throw new global::System.NotImplementedException("The member Exception StoreCanAcquireLicenseResult.ExtendedError is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Exception%20StoreCanAcquireLicenseResult.ExtendedError");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string LicensableSku
		{
			get
			{
				throw new global::System.NotImplementedException("The member string StoreCanAcquireLicenseResult.LicensableSku is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20StoreCanAcquireLicenseResult.LicensableSku");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Services.Store.StoreCanLicenseStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member StoreCanLicenseStatus StoreCanAcquireLicenseResult.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StoreCanLicenseStatus%20StoreCanAcquireLicenseResult.Status");
			}
		}
#endif
		// Forced skipping of method Windows.Services.Store.StoreCanAcquireLicenseResult.ExtendedError.get
		// Forced skipping of method Windows.Services.Store.StoreCanAcquireLicenseResult.LicensableSku.get
		// Forced skipping of method Windows.Services.Store.StoreCanAcquireLicenseResult.Status.get
	}
}
