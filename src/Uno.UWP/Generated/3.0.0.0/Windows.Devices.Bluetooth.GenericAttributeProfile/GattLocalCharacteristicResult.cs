#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class GattLocalCharacteristicResult 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Bluetooth.GenericAttributeProfile.GattLocalCharacteristic Characteristic
		{
			get
			{
				throw new global::System.NotImplementedException("The member GattLocalCharacteristic GattLocalCharacteristicResult.Characteristic is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=GattLocalCharacteristic%20GattLocalCharacteristicResult.Characteristic");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Bluetooth.BluetoothError Error
		{
			get
			{
				throw new global::System.NotImplementedException("The member BluetoothError GattLocalCharacteristicResult.Error is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=BluetoothError%20GattLocalCharacteristicResult.Error");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.Bluetooth.GenericAttributeProfile.GattLocalCharacteristicResult.Characteristic.get
		// Forced skipping of method Windows.Devices.Bluetooth.GenericAttributeProfile.GattLocalCharacteristicResult.Error.get
	}
}
