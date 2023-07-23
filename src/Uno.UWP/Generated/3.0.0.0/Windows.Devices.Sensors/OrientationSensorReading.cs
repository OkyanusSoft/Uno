#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sensors
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class OrientationSensorReading 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Sensors.SensorQuaternion Quaternion
		{
			get
			{
				throw new global::System.NotImplementedException("The member SensorQuaternion OrientationSensorReading.Quaternion is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SensorQuaternion%20OrientationSensorReading.Quaternion");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Sensors.SensorRotationMatrix RotationMatrix
		{
			get
			{
				throw new global::System.NotImplementedException("The member SensorRotationMatrix OrientationSensorReading.RotationMatrix is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SensorRotationMatrix%20OrientationSensorReading.RotationMatrix");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.DateTimeOffset Timestamp
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset OrientationSensorReading.Timestamp is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DateTimeOffset%20OrientationSensorReading.Timestamp");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan? PerformanceCount
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan? OrientationSensorReading.PerformanceCount is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=TimeSpan%3F%20OrientationSensorReading.PerformanceCount");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyDictionary<string, object> Properties
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyDictionary<string, object> OrientationSensorReading.Properties is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyDictionary%3Cstring%2C%20object%3E%20OrientationSensorReading.Properties");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Sensors.MagnetometerAccuracy YawAccuracy
		{
			get
			{
				throw new global::System.NotImplementedException("The member MagnetometerAccuracy OrientationSensorReading.YawAccuracy is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=MagnetometerAccuracy%20OrientationSensorReading.YawAccuracy");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.Sensors.OrientationSensorReading.Timestamp.get
		// Forced skipping of method Windows.Devices.Sensors.OrientationSensorReading.RotationMatrix.get
		// Forced skipping of method Windows.Devices.Sensors.OrientationSensorReading.Quaternion.get
		// Forced skipping of method Windows.Devices.Sensors.OrientationSensorReading.YawAccuracy.get
		// Forced skipping of method Windows.Devices.Sensors.OrientationSensorReading.PerformanceCount.get
		// Forced skipping of method Windows.Devices.Sensors.OrientationSensorReading.Properties.get
	}
}
