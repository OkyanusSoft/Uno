#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class AppMemoryUsageLimitChangingEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  ulong NewLimit
		{
			get
			{
				throw new global::System.NotImplementedException("The member ulong AppMemoryUsageLimitChangingEventArgs.NewLimit is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ulong%20AppMemoryUsageLimitChangingEventArgs.NewLimit");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  ulong OldLimit
		{
			get
			{
				throw new global::System.NotImplementedException("The member ulong AppMemoryUsageLimitChangingEventArgs.OldLimit is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ulong%20AppMemoryUsageLimitChangingEventArgs.OldLimit");
			}
		}
#endif
		// Forced skipping of method Windows.System.AppMemoryUsageLimitChangingEventArgs.OldLimit.get
		// Forced skipping of method Windows.System.AppMemoryUsageLimitChangingEventArgs.NewLimit.get
	}
}
