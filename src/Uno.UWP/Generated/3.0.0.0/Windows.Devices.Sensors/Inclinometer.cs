#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sensors
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class Inclinometer 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint ReportInterval
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint Inclinometer.ReportInterval is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20Inclinometer.ReportInterval");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.Inclinometer", "uint Inclinometer.ReportInterval");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint MinimumReportInterval
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint Inclinometer.MinimumReportInterval is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20Inclinometer.MinimumReportInterval");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Graphics.Display.DisplayOrientations ReadingTransform
		{
			get
			{
				throw new global::System.NotImplementedException("The member DisplayOrientations Inclinometer.ReadingTransform is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DisplayOrientations%20Inclinometer.ReadingTransform");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.Inclinometer", "DisplayOrientations Inclinometer.ReadingTransform");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Sensors.SensorReadingType ReadingType
		{
			get
			{
				throw new global::System.NotImplementedException("The member SensorReadingType Inclinometer.ReadingType is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SensorReadingType%20Inclinometer.ReadingType");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint ReportLatency
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint Inclinometer.ReportLatency is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20Inclinometer.ReportLatency");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.Inclinometer", "uint Inclinometer.ReportLatency");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint MaxBatchSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint Inclinometer.MaxBatchSize is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20Inclinometer.MaxBatchSize");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Sensors.InclinometerDataThreshold ReportThreshold
		{
			get
			{
				throw new global::System.NotImplementedException("The member InclinometerDataThreshold Inclinometer.ReportThreshold is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=InclinometerDataThreshold%20Inclinometer.ReportThreshold");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string DeviceId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string Inclinometer.DeviceId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20Inclinometer.DeviceId");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Sensors.InclinometerReading GetCurrentReading()
		{
			throw new global::System.NotImplementedException("The member InclinometerReading Inclinometer.GetCurrentReading() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=InclinometerReading%20Inclinometer.GetCurrentReading%28%29");
		}
#endif
		// Forced skipping of method Windows.Devices.Sensors.Inclinometer.MinimumReportInterval.get
		// Forced skipping of method Windows.Devices.Sensors.Inclinometer.ReportInterval.set
		// Forced skipping of method Windows.Devices.Sensors.Inclinometer.ReportInterval.get
		// Forced skipping of method Windows.Devices.Sensors.Inclinometer.ReadingChanged.add
		// Forced skipping of method Windows.Devices.Sensors.Inclinometer.ReadingChanged.remove
		// Forced skipping of method Windows.Devices.Sensors.Inclinometer.DeviceId.get
		// Forced skipping of method Windows.Devices.Sensors.Inclinometer.ReadingTransform.set
		// Forced skipping of method Windows.Devices.Sensors.Inclinometer.ReadingTransform.get
		// Forced skipping of method Windows.Devices.Sensors.Inclinometer.ReadingType.get
		// Forced skipping of method Windows.Devices.Sensors.Inclinometer.ReportLatency.set
		// Forced skipping of method Windows.Devices.Sensors.Inclinometer.ReportLatency.get
		// Forced skipping of method Windows.Devices.Sensors.Inclinometer.MaxBatchSize.get
		// Forced skipping of method Windows.Devices.Sensors.Inclinometer.ReportThreshold.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string GetDeviceSelector( global::Windows.Devices.Sensors.SensorReadingType readingType)
		{
			throw new global::System.NotImplementedException("The member string Inclinometer.GetDeviceSelector(SensorReadingType readingType) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20Inclinometer.GetDeviceSelector%28SensorReadingType%20readingType%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Sensors.Inclinometer> FromIdAsync( string deviceId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<Inclinometer> Inclinometer.FromIdAsync(string deviceId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CInclinometer%3E%20Inclinometer.FromIdAsync%28string%20deviceId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Devices.Sensors.Inclinometer GetDefault( global::Windows.Devices.Sensors.SensorReadingType sensorReadingtype)
		{
			throw new global::System.NotImplementedException("The member Inclinometer Inclinometer.GetDefault(SensorReadingType sensorReadingtype) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Inclinometer%20Inclinometer.GetDefault%28SensorReadingType%20sensorReadingtype%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Devices.Sensors.Inclinometer GetDefaultForRelativeReadings()
		{
			throw new global::System.NotImplementedException("The member Inclinometer Inclinometer.GetDefaultForRelativeReadings() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Inclinometer%20Inclinometer.GetDefaultForRelativeReadings%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Devices.Sensors.Inclinometer GetDefault()
		{
			throw new global::System.NotImplementedException("The member Inclinometer Inclinometer.GetDefault() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Inclinometer%20Inclinometer.GetDefault%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Devices.Sensors.Inclinometer, global::Windows.Devices.Sensors.InclinometerReadingChangedEventArgs> ReadingChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.Inclinometer", "event TypedEventHandler<Inclinometer, InclinometerReadingChangedEventArgs> Inclinometer.ReadingChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.Inclinometer", "event TypedEventHandler<Inclinometer, InclinometerReadingChangedEventArgs> Inclinometer.ReadingChanged");
			}
		}
#endif
	}
}
