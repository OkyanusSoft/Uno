#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.PointOfService
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class BarcodeScannerImagePreviewReceivedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Streams.IRandomAccessStreamWithContentType Preview
		{
			get
			{
				throw new global::System.NotImplementedException("The member IRandomAccessStreamWithContentType BarcodeScannerImagePreviewReceivedEventArgs.Preview is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IRandomAccessStreamWithContentType%20BarcodeScannerImagePreviewReceivedEventArgs.Preview");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.PointOfService.BarcodeScannerImagePreviewReceivedEventArgs.Preview.get
	}
}
