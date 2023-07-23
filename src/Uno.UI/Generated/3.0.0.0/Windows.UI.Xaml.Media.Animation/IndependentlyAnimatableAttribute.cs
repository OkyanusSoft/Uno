#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Animation
{
	[global::System.AttributeUsageAttribute(global::System.AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class IndependentlyAnimatableAttribute : global::System.Attribute
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public IndependentlyAnimatableAttribute() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Animation.IndependentlyAnimatableAttribute", "IndependentlyAnimatableAttribute.IndependentlyAnimatableAttribute()");
		}
#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.IndependentlyAnimatableAttribute.IndependentlyAnimatableAttribute()
	}
}
