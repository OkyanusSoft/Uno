#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.WiFiDirect
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class WiFiDirectConnectionRequestedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.WiFiDirect.WiFiDirectConnectionRequest GetConnectionRequest()
		{
			throw new global::System.NotImplementedException("The member WiFiDirectConnectionRequest WiFiDirectConnectionRequestedEventArgs.GetConnectionRequest() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=WiFiDirectConnectionRequest%20WiFiDirectConnectionRequestedEventArgs.GetConnectionRequest%28%29");
		}
#endif
	}
}
