#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Perception.Spatial
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class SpatialStationaryFrameOfReference 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Perception.Spatial.SpatialCoordinateSystem CoordinateSystem
		{
			get
			{
				throw new global::System.NotImplementedException("The member SpatialCoordinateSystem SpatialStationaryFrameOfReference.CoordinateSystem is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SpatialCoordinateSystem%20SpatialStationaryFrameOfReference.CoordinateSystem");
			}
		}
#endif
		// Forced skipping of method Windows.Perception.Spatial.SpatialStationaryFrameOfReference.CoordinateSystem.get
	}
}
