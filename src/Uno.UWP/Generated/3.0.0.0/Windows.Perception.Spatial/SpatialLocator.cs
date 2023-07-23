#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Perception.Spatial
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class SpatialLocator 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Perception.Spatial.SpatialLocatability Locatability
		{
			get
			{
				throw new global::System.NotImplementedException("The member SpatialLocatability SpatialLocator.Locatability is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SpatialLocatability%20SpatialLocator.Locatability");
			}
		}
#endif
		// Forced skipping of method Windows.Perception.Spatial.SpatialLocator.Locatability.get
		// Forced skipping of method Windows.Perception.Spatial.SpatialLocator.LocatabilityChanged.add
		// Forced skipping of method Windows.Perception.Spatial.SpatialLocator.LocatabilityChanged.remove
		// Forced skipping of method Windows.Perception.Spatial.SpatialLocator.PositionalTrackingDeactivating.add
		// Forced skipping of method Windows.Perception.Spatial.SpatialLocator.PositionalTrackingDeactivating.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Perception.Spatial.SpatialLocation TryLocateAtTimestamp( global::Windows.Perception.PerceptionTimestamp timestamp,  global::Windows.Perception.Spatial.SpatialCoordinateSystem coordinateSystem)
		{
			throw new global::System.NotImplementedException("The member SpatialLocation SpatialLocator.TryLocateAtTimestamp(PerceptionTimestamp timestamp, SpatialCoordinateSystem coordinateSystem) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SpatialLocation%20SpatialLocator.TryLocateAtTimestamp%28PerceptionTimestamp%20timestamp%2C%20SpatialCoordinateSystem%20coordinateSystem%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Perception.Spatial.SpatialLocatorAttachedFrameOfReference CreateAttachedFrameOfReferenceAtCurrentHeading()
		{
			throw new global::System.NotImplementedException("The member SpatialLocatorAttachedFrameOfReference SpatialLocator.CreateAttachedFrameOfReferenceAtCurrentHeading() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SpatialLocatorAttachedFrameOfReference%20SpatialLocator.CreateAttachedFrameOfReferenceAtCurrentHeading%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Perception.Spatial.SpatialLocatorAttachedFrameOfReference CreateAttachedFrameOfReferenceAtCurrentHeading( global::System.Numerics.Vector3 relativePosition)
		{
			throw new global::System.NotImplementedException("The member SpatialLocatorAttachedFrameOfReference SpatialLocator.CreateAttachedFrameOfReferenceAtCurrentHeading(Vector3 relativePosition) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SpatialLocatorAttachedFrameOfReference%20SpatialLocator.CreateAttachedFrameOfReferenceAtCurrentHeading%28Vector3%20relativePosition%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Perception.Spatial.SpatialLocatorAttachedFrameOfReference CreateAttachedFrameOfReferenceAtCurrentHeading( global::System.Numerics.Vector3 relativePosition,  global::System.Numerics.Quaternion relativeOrientation)
		{
			throw new global::System.NotImplementedException("The member SpatialLocatorAttachedFrameOfReference SpatialLocator.CreateAttachedFrameOfReferenceAtCurrentHeading(Vector3 relativePosition, Quaternion relativeOrientation) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SpatialLocatorAttachedFrameOfReference%20SpatialLocator.CreateAttachedFrameOfReferenceAtCurrentHeading%28Vector3%20relativePosition%2C%20Quaternion%20relativeOrientation%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Perception.Spatial.SpatialLocatorAttachedFrameOfReference CreateAttachedFrameOfReferenceAtCurrentHeading( global::System.Numerics.Vector3 relativePosition,  global::System.Numerics.Quaternion relativeOrientation,  double relativeHeadingInRadians)
		{
			throw new global::System.NotImplementedException("The member SpatialLocatorAttachedFrameOfReference SpatialLocator.CreateAttachedFrameOfReferenceAtCurrentHeading(Vector3 relativePosition, Quaternion relativeOrientation, double relativeHeadingInRadians) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SpatialLocatorAttachedFrameOfReference%20SpatialLocator.CreateAttachedFrameOfReferenceAtCurrentHeading%28Vector3%20relativePosition%2C%20Quaternion%20relativeOrientation%2C%20double%20relativeHeadingInRadians%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Perception.Spatial.SpatialStationaryFrameOfReference CreateStationaryFrameOfReferenceAtCurrentLocation()
		{
			throw new global::System.NotImplementedException("The member SpatialStationaryFrameOfReference SpatialLocator.CreateStationaryFrameOfReferenceAtCurrentLocation() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SpatialStationaryFrameOfReference%20SpatialLocator.CreateStationaryFrameOfReferenceAtCurrentLocation%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Perception.Spatial.SpatialStationaryFrameOfReference CreateStationaryFrameOfReferenceAtCurrentLocation( global::System.Numerics.Vector3 relativePosition)
		{
			throw new global::System.NotImplementedException("The member SpatialStationaryFrameOfReference SpatialLocator.CreateStationaryFrameOfReferenceAtCurrentLocation(Vector3 relativePosition) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SpatialStationaryFrameOfReference%20SpatialLocator.CreateStationaryFrameOfReferenceAtCurrentLocation%28Vector3%20relativePosition%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Perception.Spatial.SpatialStationaryFrameOfReference CreateStationaryFrameOfReferenceAtCurrentLocation( global::System.Numerics.Vector3 relativePosition,  global::System.Numerics.Quaternion relativeOrientation)
		{
			throw new global::System.NotImplementedException("The member SpatialStationaryFrameOfReference SpatialLocator.CreateStationaryFrameOfReferenceAtCurrentLocation(Vector3 relativePosition, Quaternion relativeOrientation) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SpatialStationaryFrameOfReference%20SpatialLocator.CreateStationaryFrameOfReferenceAtCurrentLocation%28Vector3%20relativePosition%2C%20Quaternion%20relativeOrientation%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Perception.Spatial.SpatialStationaryFrameOfReference CreateStationaryFrameOfReferenceAtCurrentLocation( global::System.Numerics.Vector3 relativePosition,  global::System.Numerics.Quaternion relativeOrientation,  double relativeHeadingInRadians)
		{
			throw new global::System.NotImplementedException("The member SpatialStationaryFrameOfReference SpatialLocator.CreateStationaryFrameOfReferenceAtCurrentLocation(Vector3 relativePosition, Quaternion relativeOrientation, double relativeHeadingInRadians) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SpatialStationaryFrameOfReference%20SpatialLocator.CreateStationaryFrameOfReferenceAtCurrentLocation%28Vector3%20relativePosition%2C%20Quaternion%20relativeOrientation%2C%20double%20relativeHeadingInRadians%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Perception.Spatial.SpatialLocator GetDefault()
		{
			throw new global::System.NotImplementedException("The member SpatialLocator SpatialLocator.GetDefault() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SpatialLocator%20SpatialLocator.GetDefault%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Perception.Spatial.SpatialLocator, object> LocatabilityChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Perception.Spatial.SpatialLocator", "event TypedEventHandler<SpatialLocator, object> SpatialLocator.LocatabilityChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Perception.Spatial.SpatialLocator", "event TypedEventHandler<SpatialLocator, object> SpatialLocator.LocatabilityChanged");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Perception.Spatial.SpatialLocator, global::Windows.Perception.Spatial.SpatialLocatorPositionalTrackingDeactivatingEventArgs> PositionalTrackingDeactivating
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Perception.Spatial.SpatialLocator", "event TypedEventHandler<SpatialLocator, SpatialLocatorPositionalTrackingDeactivatingEventArgs> SpatialLocator.PositionalTrackingDeactivating");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Perception.Spatial.SpatialLocator", "event TypedEventHandler<SpatialLocator, SpatialLocatorPositionalTrackingDeactivatingEventArgs> SpatialLocator.PositionalTrackingDeactivating");
			}
		}
#endif
	}
}
