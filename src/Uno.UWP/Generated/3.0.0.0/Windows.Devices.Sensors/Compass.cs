#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sensors
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class Compass 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint ReportInterval
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint Compass.ReportInterval is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20Compass.ReportInterval");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.Compass", "uint Compass.ReportInterval");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint MinimumReportInterval
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint Compass.MinimumReportInterval is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20Compass.MinimumReportInterval");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Graphics.Display.DisplayOrientations ReadingTransform
		{
			get
			{
				throw new global::System.NotImplementedException("The member DisplayOrientations Compass.ReadingTransform is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DisplayOrientations%20Compass.ReadingTransform");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.Compass", "DisplayOrientations Compass.ReadingTransform");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint ReportLatency
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint Compass.ReportLatency is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20Compass.ReportLatency");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.Compass", "uint Compass.ReportLatency");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint MaxBatchSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint Compass.MaxBatchSize is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20Compass.MaxBatchSize");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Sensors.CompassDataThreshold ReportThreshold
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompassDataThreshold Compass.ReportThreshold is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=CompassDataThreshold%20Compass.ReportThreshold");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string DeviceId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string Compass.DeviceId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20Compass.DeviceId");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Sensors.CompassReading GetCurrentReading()
		{
			throw new global::System.NotImplementedException("The member CompassReading Compass.GetCurrentReading() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=CompassReading%20Compass.GetCurrentReading%28%29");
		}
#endif
		// Forced skipping of method Windows.Devices.Sensors.Compass.MinimumReportInterval.get
		// Forced skipping of method Windows.Devices.Sensors.Compass.ReportInterval.set
		// Forced skipping of method Windows.Devices.Sensors.Compass.ReportInterval.get
		// Forced skipping of method Windows.Devices.Sensors.Compass.ReadingChanged.add
		// Forced skipping of method Windows.Devices.Sensors.Compass.ReadingChanged.remove
		// Forced skipping of method Windows.Devices.Sensors.Compass.DeviceId.get
		// Forced skipping of method Windows.Devices.Sensors.Compass.ReadingTransform.set
		// Forced skipping of method Windows.Devices.Sensors.Compass.ReadingTransform.get
		// Forced skipping of method Windows.Devices.Sensors.Compass.ReportLatency.set
		// Forced skipping of method Windows.Devices.Sensors.Compass.ReportLatency.get
		// Forced skipping of method Windows.Devices.Sensors.Compass.MaxBatchSize.get
		// Forced skipping of method Windows.Devices.Sensors.Compass.ReportThreshold.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string GetDeviceSelector()
		{
			throw new global::System.NotImplementedException("The member string Compass.GetDeviceSelector() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20Compass.GetDeviceSelector%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Sensors.Compass> FromIdAsync( string deviceId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<Compass> Compass.FromIdAsync(string deviceId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CCompass%3E%20Compass.FromIdAsync%28string%20deviceId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Devices.Sensors.Compass GetDefault()
		{
			throw new global::System.NotImplementedException("The member Compass Compass.GetDefault() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Compass%20Compass.GetDefault%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Devices.Sensors.Compass, global::Windows.Devices.Sensors.CompassReadingChangedEventArgs> ReadingChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.Compass", "event TypedEventHandler<Compass, CompassReadingChangedEventArgs> Compass.ReadingChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.Compass", "event TypedEventHandler<Compass, CompassReadingChangedEventArgs> Compass.ReadingChanged");
			}
		}
#endif
	}
}
