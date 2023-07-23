#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Services.Store
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class StorePackageInstallOptions 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool AllowForcedAppRestart
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool StorePackageInstallOptions.AllowForcedAppRestart is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20StorePackageInstallOptions.AllowForcedAppRestart");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Services.Store.StorePackageInstallOptions", "bool StorePackageInstallOptions.AllowForcedAppRestart");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public StorePackageInstallOptions() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Services.Store.StorePackageInstallOptions", "StorePackageInstallOptions.StorePackageInstallOptions()");
		}
#endif
		// Forced skipping of method Windows.Services.Store.StorePackageInstallOptions.StorePackageInstallOptions()
		// Forced skipping of method Windows.Services.Store.StorePackageInstallOptions.AllowForcedAppRestart.get
		// Forced skipping of method Windows.Services.Store.StorePackageInstallOptions.AllowForcedAppRestart.set
	}
}
