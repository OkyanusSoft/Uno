#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.NetworkOperators
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class MobileBroadbandUiccAppsResult 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.NetworkOperators.MobileBroadbandUiccAppOperationStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member MobileBroadbandUiccAppOperationStatus MobileBroadbandUiccAppsResult.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=MobileBroadbandUiccAppOperationStatus%20MobileBroadbandUiccAppsResult.Status");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Networking.NetworkOperators.MobileBroadbandUiccApp> UiccApps
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<MobileBroadbandUiccApp> MobileBroadbandUiccAppsResult.UiccApps is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CMobileBroadbandUiccApp%3E%20MobileBroadbandUiccAppsResult.UiccApps");
			}
		}
#endif
		// Forced skipping of method Windows.Networking.NetworkOperators.MobileBroadbandUiccAppsResult.Status.get
		// Forced skipping of method Windows.Networking.NetworkOperators.MobileBroadbandUiccAppsResult.UiccApps.get
	}
}
