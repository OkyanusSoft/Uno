#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Perception.Spatial
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class SpatialLocatorPositionalTrackingDeactivatingEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool Canceled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool SpatialLocatorPositionalTrackingDeactivatingEventArgs.Canceled is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20SpatialLocatorPositionalTrackingDeactivatingEventArgs.Canceled");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Perception.Spatial.SpatialLocatorPositionalTrackingDeactivatingEventArgs", "bool SpatialLocatorPositionalTrackingDeactivatingEventArgs.Canceled");
			}
		}
#endif
		// Forced skipping of method Windows.Perception.Spatial.SpatialLocatorPositionalTrackingDeactivatingEventArgs.Canceled.get
		// Forced skipping of method Windows.Perception.Spatial.SpatialLocatorPositionalTrackingDeactivatingEventArgs.Canceled.set
	}
}
