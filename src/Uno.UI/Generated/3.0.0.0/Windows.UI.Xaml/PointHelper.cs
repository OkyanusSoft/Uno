#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class PointHelper 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.Point FromCoordinates( float x,  float y)
		{
			throw new global::System.NotImplementedException("The member Point PointHelper.FromCoordinates(float x, float y) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Point%20PointHelper.FromCoordinates%28float%20x%2C%20float%20y%29");
		}
#endif
	}
}
