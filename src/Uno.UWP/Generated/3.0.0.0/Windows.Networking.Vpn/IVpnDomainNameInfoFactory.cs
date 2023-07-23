#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Vpn
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial interface IVpnDomainNameInfoFactory 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Windows.Networking.Vpn.VpnDomainNameInfo CreateVpnDomainNameInfo( string name,  global::Windows.Networking.Vpn.VpnDomainNameType nameType,  global::System.Collections.Generic.IEnumerable<global::Windows.Networking.HostName> dnsServerList,  global::System.Collections.Generic.IEnumerable<global::Windows.Networking.HostName> proxyServerList);
#endif
	}
}
