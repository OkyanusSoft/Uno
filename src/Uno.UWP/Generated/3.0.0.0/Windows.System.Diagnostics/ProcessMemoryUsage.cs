#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.Diagnostics
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class ProcessMemoryUsage 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.Diagnostics.ProcessMemoryUsageReport GetReport()
		{
			throw new global::System.NotImplementedException("The member ProcessMemoryUsageReport ProcessMemoryUsage.GetReport() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ProcessMemoryUsageReport%20ProcessMemoryUsage.GetReport%28%29");
		}
#endif
	}
}
