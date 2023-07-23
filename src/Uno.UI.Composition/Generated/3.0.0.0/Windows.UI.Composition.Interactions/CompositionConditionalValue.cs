#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition.Interactions
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class CompositionConditionalValue : global::Windows.UI.Composition.CompositionObject
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Composition.ExpressionAnimation Value
		{
			get
			{
				throw new global::System.NotImplementedException("The member ExpressionAnimation CompositionConditionalValue.Value is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ExpressionAnimation%20CompositionConditionalValue.Value");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Interactions.CompositionConditionalValue", "ExpressionAnimation CompositionConditionalValue.Value");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Composition.ExpressionAnimation Condition
		{
			get
			{
				throw new global::System.NotImplementedException("The member ExpressionAnimation CompositionConditionalValue.Condition is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ExpressionAnimation%20CompositionConditionalValue.Condition");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Interactions.CompositionConditionalValue", "ExpressionAnimation CompositionConditionalValue.Condition");
			}
		}
#endif
		// Forced skipping of method Windows.UI.Composition.Interactions.CompositionConditionalValue.Condition.get
		// Forced skipping of method Windows.UI.Composition.Interactions.CompositionConditionalValue.Condition.set
		// Forced skipping of method Windows.UI.Composition.Interactions.CompositionConditionalValue.Value.get
		// Forced skipping of method Windows.UI.Composition.Interactions.CompositionConditionalValue.Value.set
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Composition.Interactions.CompositionConditionalValue Create( global::Windows.UI.Composition.Compositor compositor)
		{
			throw new global::System.NotImplementedException("The member CompositionConditionalValue CompositionConditionalValue.Create(Compositor compositor) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=CompositionConditionalValue%20CompositionConditionalValue.Create%28Compositor%20compositor%29");
		}
#endif
	}
}
