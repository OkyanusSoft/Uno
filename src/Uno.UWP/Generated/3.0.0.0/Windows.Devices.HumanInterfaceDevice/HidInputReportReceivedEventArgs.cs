#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.HumanInterfaceDevice
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class HidInputReportReceivedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.HumanInterfaceDevice.HidInputReport Report
		{
			get
			{
				throw new global::System.NotImplementedException("The member HidInputReport HidInputReportReceivedEventArgs.Report is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=HidInputReport%20HidInputReportReceivedEventArgs.Report");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.HumanInterfaceDevice.HidInputReportReceivedEventArgs.Report.get
	}
}
