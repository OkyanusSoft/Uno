#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Effects
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial interface IVideoEffectDefinition 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		string ActivatableClassId
		{
			get;
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Windows.Foundation.Collections.IPropertySet Properties
		{
			get;
		}
#endif
		// Forced skipping of method Windows.Media.Effects.IVideoEffectDefinition.ActivatableClassId.get
		// Forced skipping of method Windows.Media.Effects.IVideoEffectDefinition.Properties.get
	}
}
