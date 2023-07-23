#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sensors
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class SensorDataThresholdTriggerDetails 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string DeviceId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string SensorDataThresholdTriggerDetails.DeviceId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20SensorDataThresholdTriggerDetails.DeviceId");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Sensors.SensorType SensorType
		{
			get
			{
				throw new global::System.NotImplementedException("The member SensorType SensorDataThresholdTriggerDetails.SensorType is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SensorType%20SensorDataThresholdTriggerDetails.SensorType");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.Sensors.SensorDataThresholdTriggerDetails.DeviceId.get
		// Forced skipping of method Windows.Devices.Sensors.SensorDataThresholdTriggerDetails.SensorType.get
	}
}
