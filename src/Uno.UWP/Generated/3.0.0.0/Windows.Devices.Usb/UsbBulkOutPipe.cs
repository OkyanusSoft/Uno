#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Usb
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class UsbBulkOutPipe 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Usb.UsbWriteOptions WriteOptions
		{
			get
			{
				throw new global::System.NotImplementedException("The member UsbWriteOptions UsbBulkOutPipe.WriteOptions is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=UsbWriteOptions%20UsbBulkOutPipe.WriteOptions");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Usb.UsbBulkOutPipe", "UsbWriteOptions UsbBulkOutPipe.WriteOptions");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Usb.UsbBulkOutEndpointDescriptor EndpointDescriptor
		{
			get
			{
				throw new global::System.NotImplementedException("The member UsbBulkOutEndpointDescriptor UsbBulkOutPipe.EndpointDescriptor is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=UsbBulkOutEndpointDescriptor%20UsbBulkOutPipe.EndpointDescriptor");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Streams.IOutputStream OutputStream
		{
			get
			{
				throw new global::System.NotImplementedException("The member IOutputStream UsbBulkOutPipe.OutputStream is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IOutputStream%20UsbBulkOutPipe.OutputStream");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.Usb.UsbBulkOutPipe.EndpointDescriptor.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction ClearStallAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction UsbBulkOutPipe.ClearStallAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20UsbBulkOutPipe.ClearStallAsync%28%29");
		}
#endif
		// Forced skipping of method Windows.Devices.Usb.UsbBulkOutPipe.WriteOptions.set
		// Forced skipping of method Windows.Devices.Usb.UsbBulkOutPipe.WriteOptions.get
		// Forced skipping of method Windows.Devices.Usb.UsbBulkOutPipe.OutputStream.get
	}
}
