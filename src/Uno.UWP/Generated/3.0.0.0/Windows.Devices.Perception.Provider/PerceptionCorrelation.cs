#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Perception.Provider
{
	// This type is deprecated. Consider not implementing it.
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class PerceptionCorrelation 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Numerics.Quaternion Orientation
		{
			get
			{
				throw new global::System.NotImplementedException("The member Quaternion PerceptionCorrelation.Orientation is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Quaternion%20PerceptionCorrelation.Orientation");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Numerics.Vector3 Position
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector3 PerceptionCorrelation.Position is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Vector3%20PerceptionCorrelation.Position");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string TargetId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string PerceptionCorrelation.TargetId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20PerceptionCorrelation.TargetId");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public PerceptionCorrelation( string targetId,  global::System.Numerics.Vector3 position,  global::System.Numerics.Quaternion orientation) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Perception.Provider.PerceptionCorrelation", "PerceptionCorrelation.PerceptionCorrelation(string targetId, Vector3 position, Quaternion orientation)");
		}
#endif
		// Forced skipping of method Windows.Devices.Perception.Provider.PerceptionCorrelation.PerceptionCorrelation(string, System.Numerics.Vector3, System.Numerics.Quaternion)
		// Forced skipping of method Windows.Devices.Perception.Provider.PerceptionCorrelation.TargetId.get
		// Forced skipping of method Windows.Devices.Perception.Provider.PerceptionCorrelation.Position.get
		// Forced skipping of method Windows.Devices.Perception.Provider.PerceptionCorrelation.Orientation.get
	}
}
