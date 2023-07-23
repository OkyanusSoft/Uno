#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Usb
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class UsbConfiguration 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Usb.UsbConfigurationDescriptor ConfigurationDescriptor
		{
			get
			{
				throw new global::System.NotImplementedException("The member UsbConfigurationDescriptor UsbConfiguration.ConfigurationDescriptor is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=UsbConfigurationDescriptor%20UsbConfiguration.ConfigurationDescriptor");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.Usb.UsbDescriptor> Descriptors
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<UsbDescriptor> UsbConfiguration.Descriptors is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CUsbDescriptor%3E%20UsbConfiguration.Descriptors");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.Usb.UsbInterface> UsbInterfaces
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<UsbInterface> UsbConfiguration.UsbInterfaces is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CUsbInterface%3E%20UsbConfiguration.UsbInterfaces");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.Usb.UsbConfiguration.UsbInterfaces.get
		// Forced skipping of method Windows.Devices.Usb.UsbConfiguration.ConfigurationDescriptor.get
		// Forced skipping of method Windows.Devices.Usb.UsbConfiguration.Descriptors.get
	}
}
