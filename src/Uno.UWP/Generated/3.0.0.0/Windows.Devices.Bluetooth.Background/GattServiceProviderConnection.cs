#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Bluetooth.Background
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class GattServiceProviderConnection 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Bluetooth.GenericAttributeProfile.GattLocalService Service
		{
			get
			{
				throw new global::System.NotImplementedException("The member GattLocalService GattServiceProviderConnection.Service is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=GattLocalService%20GattServiceProviderConnection.Service");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string TriggerId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string GattServiceProviderConnection.TriggerId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20GattServiceProviderConnection.TriggerId");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Collections.Generic.IReadOnlyDictionary<string, global::Windows.Devices.Bluetooth.Background.GattServiceProviderConnection> AllServices
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyDictionary<string, GattServiceProviderConnection> GattServiceProviderConnection.AllServices is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyDictionary%3Cstring%2C%20GattServiceProviderConnection%3E%20GattServiceProviderConnection.AllServices");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.Bluetooth.Background.GattServiceProviderConnection.TriggerId.get
		// Forced skipping of method Windows.Devices.Bluetooth.Background.GattServiceProviderConnection.Service.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Start()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Bluetooth.Background.GattServiceProviderConnection", "void GattServiceProviderConnection.Start()");
		}
#endif
		// Forced skipping of method Windows.Devices.Bluetooth.Background.GattServiceProviderConnection.AllServices.get
	}
}
