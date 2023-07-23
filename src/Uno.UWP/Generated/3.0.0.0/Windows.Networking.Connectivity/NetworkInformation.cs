#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Connectivity
{
#if false || false || IS_UNIT_TESTS || false || false || false || false
	[global::Uno.NotImplemented("IS_UNIT_TESTS")]
#endif
	public static partial class NetworkInformation 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Networking.Connectivity.ConnectionProfile>> FindConnectionProfilesAsync( global::Windows.Networking.Connectivity.ConnectionProfileFilter pProfileFilter)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<ConnectionProfile>> NetworkInformation.FindConnectionProfilesAsync(ConnectionProfileFilter pProfileFilter) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CConnectionProfile%3E%3E%20NetworkInformation.FindConnectionProfilesAsync%28ConnectionProfileFilter%20pProfileFilter%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Collections.Generic.IReadOnlyList<global::Windows.Networking.Connectivity.ConnectionProfile> GetConnectionProfiles()
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<ConnectionProfile> NetworkInformation.GetConnectionProfiles() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CConnectionProfile%3E%20NetworkInformation.GetConnectionProfiles%28%29");
		}
#endif
#if false || false || IS_UNIT_TESTS || false || false || false || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS")]
		public static global::Windows.Networking.Connectivity.ConnectionProfile GetInternetConnectionProfile()
		{
			throw new global::System.NotImplementedException("The member ConnectionProfile NetworkInformation.GetInternetConnectionProfile() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ConnectionProfile%20NetworkInformation.GetInternetConnectionProfile%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Collections.Generic.IReadOnlyList<global::Windows.Networking.Connectivity.LanIdentifier> GetLanIdentifiers()
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<LanIdentifier> NetworkInformation.GetLanIdentifiers() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CLanIdentifier%3E%20NetworkInformation.GetLanIdentifiers%28%29");
		}
#endif
#if false || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Collections.Generic.IReadOnlyList<global::Windows.Networking.HostName> GetHostNames()
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<HostName> NetworkInformation.GetHostNames() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CHostName%3E%20NetworkInformation.GetHostNames%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Networking.Connectivity.ProxyConfiguration> GetProxyConfigurationAsync( global::System.Uri uri)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ProxyConfiguration> NetworkInformation.GetProxyConfigurationAsync(Uri uri) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CProxyConfiguration%3E%20NetworkInformation.GetProxyConfigurationAsync%28Uri%20uri%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Collections.Generic.IReadOnlyList<global::Windows.Networking.EndpointPair> GetSortedEndpointPairs( global::System.Collections.Generic.IEnumerable<global::Windows.Networking.EndpointPair> destinationList,  global::Windows.Networking.HostNameSortOptions sortOptions)
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<EndpointPair> NetworkInformation.GetSortedEndpointPairs(IEnumerable<EndpointPair> destinationList, HostNameSortOptions sortOptions) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CEndpointPair%3E%20NetworkInformation.GetSortedEndpointPairs%28IEnumerable%3CEndpointPair%3E%20destinationList%2C%20HostNameSortOptions%20sortOptions%29");
		}
#endif
		// Forced skipping of method Windows.Networking.Connectivity.NetworkInformation.NetworkStatusChanged.add
		// Forced skipping of method Windows.Networking.Connectivity.NetworkInformation.NetworkStatusChanged.remove
#if false || false || IS_UNIT_TESTS || false || false || false || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS")]
		public static event global::Windows.Networking.Connectivity.NetworkStatusChangedEventHandler NetworkStatusChanged
		{
			[global::Uno.NotImplemented("IS_UNIT_TESTS")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.Connectivity.NetworkInformation", "event NetworkStatusChangedEventHandler NetworkInformation.NetworkStatusChanged");
			}
			[global::Uno.NotImplemented("IS_UNIT_TESTS")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.Connectivity.NetworkInformation", "event NetworkStatusChangedEventHandler NetworkInformation.NetworkStatusChanged");
			}
		}
#endif
	}
}
