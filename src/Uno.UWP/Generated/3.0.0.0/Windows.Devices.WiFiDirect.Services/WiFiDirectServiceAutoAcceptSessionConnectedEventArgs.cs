#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.WiFiDirect.Services
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class WiFiDirectServiceAutoAcceptSessionConnectedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSession Session
		{
			get
			{
				throw new global::System.NotImplementedException("The member WiFiDirectServiceSession WiFiDirectServiceAutoAcceptSessionConnectedEventArgs.Session is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=WiFiDirectServiceSession%20WiFiDirectServiceAutoAcceptSessionConnectedEventArgs.Session");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Streams.IBuffer SessionInfo
		{
			get
			{
				throw new global::System.NotImplementedException("The member IBuffer WiFiDirectServiceAutoAcceptSessionConnectedEventArgs.SessionInfo is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IBuffer%20WiFiDirectServiceAutoAcceptSessionConnectedEventArgs.SessionInfo");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.WiFiDirect.Services.WiFiDirectServiceAutoAcceptSessionConnectedEventArgs.Session.get
		// Forced skipping of method Windows.Devices.WiFiDirect.Services.WiFiDirectServiceAutoAcceptSessionConnectedEventArgs.SessionInfo.get
	}
}
