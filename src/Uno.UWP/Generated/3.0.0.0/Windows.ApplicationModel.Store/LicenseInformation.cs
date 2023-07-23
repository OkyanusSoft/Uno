#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Store
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class LicenseInformation 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.DateTimeOffset ExpirationDate
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset LicenseInformation.ExpirationDate is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DateTimeOffset%20LicenseInformation.ExpirationDate");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsActive
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool LicenseInformation.IsActive is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20LicenseInformation.IsActive");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsTrial
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool LicenseInformation.IsTrial is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20LicenseInformation.IsTrial");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyDictionary<string, global::Windows.ApplicationModel.Store.ProductLicense> ProductLicenses
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyDictionary<string, ProductLicense> LicenseInformation.ProductLicenses is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyDictionary%3Cstring%2C%20ProductLicense%3E%20LicenseInformation.ProductLicenses");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Store.LicenseInformation.ProductLicenses.get
		// Forced skipping of method Windows.ApplicationModel.Store.LicenseInformation.IsActive.get
		// Forced skipping of method Windows.ApplicationModel.Store.LicenseInformation.IsTrial.get
		// Forced skipping of method Windows.ApplicationModel.Store.LicenseInformation.ExpirationDate.get
		// Forced skipping of method Windows.ApplicationModel.Store.LicenseInformation.LicenseChanged.add
		// Forced skipping of method Windows.ApplicationModel.Store.LicenseInformation.LicenseChanged.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.ApplicationModel.Store.LicenseChangedEventHandler LicenseChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Store.LicenseInformation", "event LicenseChangedEventHandler LicenseInformation.LicenseChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Store.LicenseInformation", "event LicenseChangedEventHandler LicenseInformation.LicenseChanged");
			}
		}
#endif
	}
}
