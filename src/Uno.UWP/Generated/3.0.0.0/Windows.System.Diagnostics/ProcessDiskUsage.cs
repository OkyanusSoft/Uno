#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.Diagnostics
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class ProcessDiskUsage 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.Diagnostics.ProcessDiskUsageReport GetReport()
		{
			throw new global::System.NotImplementedException("The member ProcessDiskUsageReport ProcessDiskUsage.GetReport() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ProcessDiskUsageReport%20ProcessDiskUsage.GetReport%28%29");
		}
#endif
	}
}
