#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Input
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class MouseEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Input.MouseDelta MouseDelta
		{
			get
			{
				throw new global::System.NotImplementedException("The member MouseDelta MouseEventArgs.MouseDelta is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=MouseDelta%20MouseEventArgs.MouseDelta");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.Input.MouseEventArgs.MouseDelta.get
	}
}
