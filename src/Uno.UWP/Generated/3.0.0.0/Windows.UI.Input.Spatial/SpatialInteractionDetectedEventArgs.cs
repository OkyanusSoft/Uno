#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input.Spatial
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class SpatialInteractionDetectedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Input.Spatial.SpatialInteraction Interaction
		{
			get
			{
				throw new global::System.NotImplementedException("The member SpatialInteraction SpatialInteractionDetectedEventArgs.Interaction is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SpatialInteraction%20SpatialInteractionDetectedEventArgs.Interaction");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Input.Spatial.SpatialInteractionSourceKind InteractionSourceKind
		{
			get
			{
				throw new global::System.NotImplementedException("The member SpatialInteractionSourceKind SpatialInteractionDetectedEventArgs.InteractionSourceKind is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SpatialInteractionSourceKind%20SpatialInteractionDetectedEventArgs.InteractionSourceKind");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Input.Spatial.SpatialInteractionSource InteractionSource
		{
			get
			{
				throw new global::System.NotImplementedException("The member SpatialInteractionSource SpatialInteractionDetectedEventArgs.InteractionSource is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SpatialInteractionSource%20SpatialInteractionDetectedEventArgs.InteractionSource");
			}
		}
#endif
		// Forced skipping of method Windows.UI.Input.Spatial.SpatialInteractionDetectedEventArgs.InteractionSourceKind.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Input.Spatial.SpatialPointerPose TryGetPointerPose( global::Windows.Perception.Spatial.SpatialCoordinateSystem coordinateSystem)
		{
			throw new global::System.NotImplementedException("The member SpatialPointerPose SpatialInteractionDetectedEventArgs.TryGetPointerPose(SpatialCoordinateSystem coordinateSystem) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SpatialPointerPose%20SpatialInteractionDetectedEventArgs.TryGetPointerPose%28SpatialCoordinateSystem%20coordinateSystem%29");
		}
#endif
		// Forced skipping of method Windows.UI.Input.Spatial.SpatialInteractionDetectedEventArgs.Interaction.get
		// Forced skipping of method Windows.UI.Input.Spatial.SpatialInteractionDetectedEventArgs.InteractionSource.get
	}
}
