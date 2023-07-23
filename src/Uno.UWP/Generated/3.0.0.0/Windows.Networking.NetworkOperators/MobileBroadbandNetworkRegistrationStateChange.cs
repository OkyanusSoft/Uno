#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.NetworkOperators
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class MobileBroadbandNetworkRegistrationStateChange 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string DeviceId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string MobileBroadbandNetworkRegistrationStateChange.DeviceId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20MobileBroadbandNetworkRegistrationStateChange.DeviceId");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.NetworkOperators.MobileBroadbandNetwork Network
		{
			get
			{
				throw new global::System.NotImplementedException("The member MobileBroadbandNetwork MobileBroadbandNetworkRegistrationStateChange.Network is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=MobileBroadbandNetwork%20MobileBroadbandNetworkRegistrationStateChange.Network");
			}
		}
#endif
		// Forced skipping of method Windows.Networking.NetworkOperators.MobileBroadbandNetworkRegistrationStateChange.DeviceId.get
		// Forced skipping of method Windows.Networking.NetworkOperators.MobileBroadbandNetworkRegistrationStateChange.Network.get
	}
}
