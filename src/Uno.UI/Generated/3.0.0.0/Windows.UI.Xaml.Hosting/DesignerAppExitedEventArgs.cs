#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Hosting
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class DesignerAppExitedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint ExitCode
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint DesignerAppExitedEventArgs.ExitCode is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20DesignerAppExitedEventArgs.ExitCode");
			}
		}
#endif
		// Forced skipping of method Windows.UI.Xaml.Hosting.DesignerAppExitedEventArgs.ExitCode.get
	}
}
