#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class CompositionLight : global::Windows.UI.Composition.CompositionObject
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Composition.VisualUnorderedCollection Targets
		{
			get
			{
				throw new global::System.NotImplementedException("The member VisualUnorderedCollection CompositionLight.Targets is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=VisualUnorderedCollection%20CompositionLight.Targets");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Composition.VisualUnorderedCollection ExclusionsFromTargets
		{
			get
			{
				throw new global::System.NotImplementedException("The member VisualUnorderedCollection CompositionLight.ExclusionsFromTargets is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=VisualUnorderedCollection%20CompositionLight.ExclusionsFromTargets");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsEnabled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool CompositionLight.IsEnabled is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20CompositionLight.IsEnabled");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionLight", "bool CompositionLight.IsEnabled");
			}
		}
#endif
		// Forced skipping of method Windows.UI.Composition.CompositionLight.Targets.get
		// Forced skipping of method Windows.UI.Composition.CompositionLight.ExclusionsFromTargets.get
		// Forced skipping of method Windows.UI.Composition.CompositionLight.IsEnabled.get
		// Forced skipping of method Windows.UI.Composition.CompositionLight.IsEnabled.set
	}
}
