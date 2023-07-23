#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Connectivity
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class RoutePolicy 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.Connectivity.ConnectionProfile ConnectionProfile
		{
			get
			{
				throw new global::System.NotImplementedException("The member ConnectionProfile RoutePolicy.ConnectionProfile is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ConnectionProfile%20RoutePolicy.ConnectionProfile");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.HostName HostName
		{
			get
			{
				throw new global::System.NotImplementedException("The member HostName RoutePolicy.HostName is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=HostName%20RoutePolicy.HostName");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.DomainNameType HostNameType
		{
			get
			{
				throw new global::System.NotImplementedException("The member DomainNameType RoutePolicy.HostNameType is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DomainNameType%20RoutePolicy.HostNameType");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public RoutePolicy( global::Windows.Networking.Connectivity.ConnectionProfile connectionProfile,  global::Windows.Networking.HostName hostName,  global::Windows.Networking.DomainNameType type) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.Connectivity.RoutePolicy", "RoutePolicy.RoutePolicy(ConnectionProfile connectionProfile, HostName hostName, DomainNameType type)");
		}
#endif
		// Forced skipping of method Windows.Networking.Connectivity.RoutePolicy.RoutePolicy(Windows.Networking.Connectivity.ConnectionProfile, Windows.Networking.HostName, Windows.Networking.DomainNameType)
		// Forced skipping of method Windows.Networking.Connectivity.RoutePolicy.ConnectionProfile.get
		// Forced skipping of method Windows.Networking.Connectivity.RoutePolicy.HostName.get
		// Forced skipping of method Windows.Networking.Connectivity.RoutePolicy.HostNameType.get
	}
}
