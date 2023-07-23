#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Sockets
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class DatagramSocketControl 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.Sockets.SocketQualityOfService QualityOfService
		{
			get
			{
				throw new global::System.NotImplementedException("The member SocketQualityOfService DatagramSocketControl.QualityOfService is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SocketQualityOfService%20DatagramSocketControl.QualityOfService");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.Sockets.DatagramSocketControl", "SocketQualityOfService DatagramSocketControl.QualityOfService");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  byte OutboundUnicastHopLimit
		{
			get
			{
				throw new global::System.NotImplementedException("The member byte DatagramSocketControl.OutboundUnicastHopLimit is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=byte%20DatagramSocketControl.OutboundUnicastHopLimit");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.Sockets.DatagramSocketControl", "byte DatagramSocketControl.OutboundUnicastHopLimit");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint InboundBufferSizeInBytes
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint DatagramSocketControl.InboundBufferSizeInBytes is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20DatagramSocketControl.InboundBufferSizeInBytes");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.Sockets.DatagramSocketControl", "uint DatagramSocketControl.InboundBufferSizeInBytes");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool DontFragment
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool DatagramSocketControl.DontFragment is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20DatagramSocketControl.DontFragment");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.Sockets.DatagramSocketControl", "bool DatagramSocketControl.DontFragment");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool MulticastOnly
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool DatagramSocketControl.MulticastOnly is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20DatagramSocketControl.MulticastOnly");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.Sockets.DatagramSocketControl", "bool DatagramSocketControl.MulticastOnly");
			}
		}
#endif
		// Forced skipping of method Windows.Networking.Sockets.DatagramSocketControl.QualityOfService.get
		// Forced skipping of method Windows.Networking.Sockets.DatagramSocketControl.QualityOfService.set
		// Forced skipping of method Windows.Networking.Sockets.DatagramSocketControl.OutboundUnicastHopLimit.get
		// Forced skipping of method Windows.Networking.Sockets.DatagramSocketControl.OutboundUnicastHopLimit.set
		// Forced skipping of method Windows.Networking.Sockets.DatagramSocketControl.InboundBufferSizeInBytes.get
		// Forced skipping of method Windows.Networking.Sockets.DatagramSocketControl.InboundBufferSizeInBytes.set
		// Forced skipping of method Windows.Networking.Sockets.DatagramSocketControl.DontFragment.get
		// Forced skipping of method Windows.Networking.Sockets.DatagramSocketControl.DontFragment.set
		// Forced skipping of method Windows.Networking.Sockets.DatagramSocketControl.MulticastOnly.get
		// Forced skipping of method Windows.Networking.Sockets.DatagramSocketControl.MulticastOnly.set
	}
}
