#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sensors
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class BarometerDataThreshold 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double Hectopascals
		{
			get
			{
				throw new global::System.NotImplementedException("The member double BarometerDataThreshold.Hectopascals is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=double%20BarometerDataThreshold.Hectopascals");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.BarometerDataThreshold", "double BarometerDataThreshold.Hectopascals");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.Sensors.BarometerDataThreshold.Hectopascals.get
		// Forced skipping of method Windows.Devices.Sensors.BarometerDataThreshold.Hectopascals.set
	}
}
