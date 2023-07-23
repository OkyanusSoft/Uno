#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Connectivity
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class ConnectivityInterval 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan ConnectionDuration
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan ConnectivityInterval.ConnectionDuration is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=TimeSpan%20ConnectivityInterval.ConnectionDuration");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.DateTimeOffset StartTime
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset ConnectivityInterval.StartTime is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DateTimeOffset%20ConnectivityInterval.StartTime");
			}
		}
#endif
		// Forced skipping of method Windows.Networking.Connectivity.ConnectivityInterval.StartTime.get
		// Forced skipping of method Windows.Networking.Connectivity.ConnectivityInterval.ConnectionDuration.get
	}
}
