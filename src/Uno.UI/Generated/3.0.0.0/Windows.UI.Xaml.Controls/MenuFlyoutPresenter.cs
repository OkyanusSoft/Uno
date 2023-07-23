#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
#endif
	public  partial class MenuFlyoutPresenter : global::Windows.UI.Xaml.Controls.ItemsControl
	{
		// Skipping already declared property TemplateSettings
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsDefaultShadowEnabled
		{
			get
			{
				return (bool)this.GetValue(IsDefaultShadowEnabledProperty);
			}
			set
			{
				this.SetValue(IsDefaultShadowEnabledProperty, value);
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty IsDefaultShadowEnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(IsDefaultShadowEnabled), typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.MenuFlyoutPresenter), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
#endif
		// Skipping already declared method Windows.UI.Xaml.Controls.MenuFlyoutPresenter.MenuFlyoutPresenter()
		// Forced skipping of method Windows.UI.Xaml.Controls.MenuFlyoutPresenter.MenuFlyoutPresenter()
		// Forced skipping of method Windows.UI.Xaml.Controls.MenuFlyoutPresenter.TemplateSettings.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MenuFlyoutPresenter.IsDefaultShadowEnabled.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MenuFlyoutPresenter.IsDefaultShadowEnabled.set
		// Forced skipping of method Windows.UI.Xaml.Controls.MenuFlyoutPresenter.IsDefaultShadowEnabledProperty.get
	}
}
