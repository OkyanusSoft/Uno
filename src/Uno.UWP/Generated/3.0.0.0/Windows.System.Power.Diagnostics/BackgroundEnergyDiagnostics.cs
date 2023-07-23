#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.Power.Diagnostics
{
	// This type is deprecated. Consider not implementing it.
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public static partial class BackgroundEnergyDiagnostics 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static double DeviceSpecificConversionFactor
		{
			get
			{
				throw new global::System.NotImplementedException("The member double BackgroundEnergyDiagnostics.DeviceSpecificConversionFactor is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=double%20BackgroundEnergyDiagnostics.DeviceSpecificConversionFactor");
			}
		}
#endif
		// Forced skipping of method Windows.System.Power.Diagnostics.BackgroundEnergyDiagnostics.DeviceSpecificConversionFactor.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static ulong ComputeTotalEnergyUsage()
		{
			throw new global::System.NotImplementedException("The member ulong BackgroundEnergyDiagnostics.ComputeTotalEnergyUsage() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ulong%20BackgroundEnergyDiagnostics.ComputeTotalEnergyUsage%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void ResetTotalEnergyUsage()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.System.Power.Diagnostics.BackgroundEnergyDiagnostics", "void BackgroundEnergyDiagnostics.ResetTotalEnergyUsage()");
		}
#endif
	}
}
