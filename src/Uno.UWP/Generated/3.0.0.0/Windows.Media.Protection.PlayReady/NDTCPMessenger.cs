#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Protection.PlayReady
{
	// This type is deprecated. Consider not implementing it.
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class NDTCPMessenger : global::Windows.Media.Protection.PlayReady.INDMessenger
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public NDTCPMessenger( string remoteHostName,  uint remoteHostPort) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Protection.PlayReady.NDTCPMessenger", "NDTCPMessenger.NDTCPMessenger(string remoteHostName, uint remoteHostPort)");
		}
#endif
		// Forced skipping of method Windows.Media.Protection.PlayReady.NDTCPMessenger.NDTCPMessenger(string, uint)
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Media.Protection.PlayReady.INDSendResult> SendRegistrationRequestAsync( byte[] sessionIDBytes,  byte[] challengeDataBytes)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<INDSendResult> NDTCPMessenger.SendRegistrationRequestAsync(byte[] sessionIDBytes, byte[] challengeDataBytes) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CINDSendResult%3E%20NDTCPMessenger.SendRegistrationRequestAsync%28byte%5B%5D%20sessionIDBytes%2C%20byte%5B%5D%20challengeDataBytes%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Media.Protection.PlayReady.INDSendResult> SendProximityDetectionStartAsync( global::Windows.Media.Protection.PlayReady.NDProximityDetectionType pdType,  byte[] transmitterChannelBytes,  byte[] sessionIDBytes,  byte[] challengeDataBytes)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<INDSendResult> NDTCPMessenger.SendProximityDetectionStartAsync(NDProximityDetectionType pdType, byte[] transmitterChannelBytes, byte[] sessionIDBytes, byte[] challengeDataBytes) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CINDSendResult%3E%20NDTCPMessenger.SendProximityDetectionStartAsync%28NDProximityDetectionType%20pdType%2C%20byte%5B%5D%20transmitterChannelBytes%2C%20byte%5B%5D%20sessionIDBytes%2C%20byte%5B%5D%20challengeDataBytes%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Media.Protection.PlayReady.INDSendResult> SendProximityDetectionResponseAsync( global::Windows.Media.Protection.PlayReady.NDProximityDetectionType pdType,  byte[] transmitterChannelBytes,  byte[] sessionIDBytes,  byte[] responseDataBytes)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<INDSendResult> NDTCPMessenger.SendProximityDetectionResponseAsync(NDProximityDetectionType pdType, byte[] transmitterChannelBytes, byte[] sessionIDBytes, byte[] responseDataBytes) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CINDSendResult%3E%20NDTCPMessenger.SendProximityDetectionResponseAsync%28NDProximityDetectionType%20pdType%2C%20byte%5B%5D%20transmitterChannelBytes%2C%20byte%5B%5D%20sessionIDBytes%2C%20byte%5B%5D%20responseDataBytes%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Media.Protection.PlayReady.INDSendResult> SendLicenseFetchRequestAsync( byte[] sessionIDBytes,  byte[] challengeDataBytes)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<INDSendResult> NDTCPMessenger.SendLicenseFetchRequestAsync(byte[] sessionIDBytes, byte[] challengeDataBytes) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CINDSendResult%3E%20NDTCPMessenger.SendLicenseFetchRequestAsync%28byte%5B%5D%20sessionIDBytes%2C%20byte%5B%5D%20challengeDataBytes%29");
		}
#endif
		// Processing: Windows.Media.Protection.PlayReady.INDMessenger
	}
}
