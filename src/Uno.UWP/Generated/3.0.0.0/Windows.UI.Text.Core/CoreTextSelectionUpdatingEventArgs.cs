#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Text.Core
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class CoreTextSelectionUpdatingEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Text.Core.CoreTextSelectionUpdatingResult Result
		{
			get
			{
				throw new global::System.NotImplementedException("The member CoreTextSelectionUpdatingResult CoreTextSelectionUpdatingEventArgs.Result is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=CoreTextSelectionUpdatingResult%20CoreTextSelectionUpdatingEventArgs.Result");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Text.Core.CoreTextSelectionUpdatingEventArgs", "CoreTextSelectionUpdatingResult CoreTextSelectionUpdatingEventArgs.Result");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsCanceled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool CoreTextSelectionUpdatingEventArgs.IsCanceled is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20CoreTextSelectionUpdatingEventArgs.IsCanceled");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Text.Core.CoreTextRange Selection
		{
			get
			{
				throw new global::System.NotImplementedException("The member CoreTextRange CoreTextSelectionUpdatingEventArgs.Selection is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=CoreTextRange%20CoreTextSelectionUpdatingEventArgs.Selection");
			}
		}
#endif
		// Forced skipping of method Windows.UI.Text.Core.CoreTextSelectionUpdatingEventArgs.Selection.get
		// Forced skipping of method Windows.UI.Text.Core.CoreTextSelectionUpdatingEventArgs.Result.get
		// Forced skipping of method Windows.UI.Text.Core.CoreTextSelectionUpdatingEventArgs.Result.set
		// Forced skipping of method Windows.UI.Text.Core.CoreTextSelectionUpdatingEventArgs.IsCanceled.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral CoreTextSelectionUpdatingEventArgs.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Deferral%20CoreTextSelectionUpdatingEventArgs.GetDeferral%28%29");
		}
#endif
	}
}
