#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Animation
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class SwipeHintThemeAnimation : global::Windows.UI.Xaml.Media.Animation.Timeline
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double ToVerticalOffset
		{
			get
			{
				return (double)this.GetValue(ToVerticalOffsetProperty);
			}
			set
			{
				this.SetValue(ToVerticalOffsetProperty, value);
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double ToHorizontalOffset
		{
			get
			{
				return (double)this.GetValue(ToHorizontalOffsetProperty);
			}
			set
			{
				this.SetValue(ToHorizontalOffsetProperty, value);
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string TargetName
		{
			get
			{
				return (string)this.GetValue(TargetNameProperty);
			}
			set
			{
				this.SetValue(TargetNameProperty, value);
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty TargetNameProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(TargetName), typeof(string), 
			typeof(global::Windows.UI.Xaml.Media.Animation.SwipeHintThemeAnimation), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(string)));
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ToHorizontalOffsetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(ToHorizontalOffset), typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.Animation.SwipeHintThemeAnimation), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(double)));
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ToVerticalOffsetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(ToVerticalOffset), typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.Animation.SwipeHintThemeAnimation), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(double)));
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public SwipeHintThemeAnimation() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Animation.SwipeHintThemeAnimation", "SwipeHintThemeAnimation.SwipeHintThemeAnimation()");
		}
#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.SwipeHintThemeAnimation.SwipeHintThemeAnimation()
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.SwipeHintThemeAnimation.TargetName.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.SwipeHintThemeAnimation.TargetName.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.SwipeHintThemeAnimation.ToHorizontalOffset.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.SwipeHintThemeAnimation.ToHorizontalOffset.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.SwipeHintThemeAnimation.ToVerticalOffset.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.SwipeHintThemeAnimation.ToVerticalOffset.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.SwipeHintThemeAnimation.TargetNameProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.SwipeHintThemeAnimation.ToHorizontalOffsetProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.SwipeHintThemeAnimation.ToVerticalOffsetProperty.get
	}
}
