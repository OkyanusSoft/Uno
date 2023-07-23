#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Perception.Provider
{
	// This type is deprecated. Consider not implementing it.
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class PerceptionPropertyChangeRequest 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Perception.PerceptionFrameSourcePropertyChangeStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member PerceptionFrameSourcePropertyChangeStatus PerceptionPropertyChangeRequest.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PerceptionFrameSourcePropertyChangeStatus%20PerceptionPropertyChangeRequest.Status");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Perception.Provider.PerceptionPropertyChangeRequest", "PerceptionFrameSourcePropertyChangeStatus PerceptionPropertyChangeRequest.Status");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string PerceptionPropertyChangeRequest.Name is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20PerceptionPropertyChangeRequest.Name");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  object Value
		{
			get
			{
				throw new global::System.NotImplementedException("The member object PerceptionPropertyChangeRequest.Value is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=object%20PerceptionPropertyChangeRequest.Value");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.Perception.Provider.PerceptionPropertyChangeRequest.Name.get
		// Forced skipping of method Windows.Devices.Perception.Provider.PerceptionPropertyChangeRequest.Value.get
		// Forced skipping of method Windows.Devices.Perception.Provider.PerceptionPropertyChangeRequest.Status.get
		// Forced skipping of method Windows.Devices.Perception.Provider.PerceptionPropertyChangeRequest.Status.set
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral PerceptionPropertyChangeRequest.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Deferral%20PerceptionPropertyChangeRequest.GetDeferral%28%29");
		}
#endif
	}
}
