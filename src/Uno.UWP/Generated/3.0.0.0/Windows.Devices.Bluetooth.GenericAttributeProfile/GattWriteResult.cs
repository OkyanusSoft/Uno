#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class GattWriteResult 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  byte? ProtocolError
		{
			get
			{
				throw new global::System.NotImplementedException("The member byte? GattWriteResult.ProtocolError is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=byte%3F%20GattWriteResult.ProtocolError");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Bluetooth.GenericAttributeProfile.GattCommunicationStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member GattCommunicationStatus GattWriteResult.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=GattCommunicationStatus%20GattWriteResult.Status");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.Bluetooth.GenericAttributeProfile.GattWriteResult.Status.get
		// Forced skipping of method Windows.Devices.Bluetooth.GenericAttributeProfile.GattWriteResult.ProtocolError.get
	}
}
