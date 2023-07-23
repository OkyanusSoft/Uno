#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Perception.Spatial
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class SpatialEntity 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Perception.Spatial.SpatialAnchor Anchor
		{
			get
			{
				throw new global::System.NotImplementedException("The member SpatialAnchor SpatialEntity.Anchor is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SpatialAnchor%20SpatialEntity.Anchor");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Id
		{
			get
			{
				throw new global::System.NotImplementedException("The member string SpatialEntity.Id is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20SpatialEntity.Id");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Collections.ValueSet Properties
		{
			get
			{
				throw new global::System.NotImplementedException("The member ValueSet SpatialEntity.Properties is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ValueSet%20SpatialEntity.Properties");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public SpatialEntity( global::Windows.Perception.Spatial.SpatialAnchor spatialAnchor) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Perception.Spatial.SpatialEntity", "SpatialEntity.SpatialEntity(SpatialAnchor spatialAnchor)");
		}
#endif
		// Forced skipping of method Windows.Perception.Spatial.SpatialEntity.SpatialEntity(Windows.Perception.Spatial.SpatialAnchor)
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public SpatialEntity( global::Windows.Perception.Spatial.SpatialAnchor spatialAnchor,  global::Windows.Foundation.Collections.ValueSet propertySet) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Perception.Spatial.SpatialEntity", "SpatialEntity.SpatialEntity(SpatialAnchor spatialAnchor, ValueSet propertySet)");
		}
#endif
		// Forced skipping of method Windows.Perception.Spatial.SpatialEntity.SpatialEntity(Windows.Perception.Spatial.SpatialAnchor, Windows.Foundation.Collections.ValueSet)
		// Forced skipping of method Windows.Perception.Spatial.SpatialEntity.Id.get
		// Forced skipping of method Windows.Perception.Spatial.SpatialEntity.Anchor.get
		// Forced skipping of method Windows.Perception.Spatial.SpatialEntity.Properties.get
	}
}
