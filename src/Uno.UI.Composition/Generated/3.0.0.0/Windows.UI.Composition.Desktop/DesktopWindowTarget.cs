#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition.Desktop
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class DesktopWindowTarget : global::Windows.UI.Composition.CompositionTarget
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsTopmost
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool DesktopWindowTarget.IsTopmost is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20DesktopWindowTarget.IsTopmost");
			}
		}
#endif
		// Forced skipping of method Windows.UI.Composition.Desktop.DesktopWindowTarget.IsTopmost.get
	}
}
