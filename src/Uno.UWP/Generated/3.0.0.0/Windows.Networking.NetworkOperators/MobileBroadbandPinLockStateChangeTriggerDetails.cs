#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.NetworkOperators
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class MobileBroadbandPinLockStateChangeTriggerDetails 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Networking.NetworkOperators.MobileBroadbandPinLockStateChange> PinLockStateChanges
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<MobileBroadbandPinLockStateChange> MobileBroadbandPinLockStateChangeTriggerDetails.PinLockStateChanges is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CMobileBroadbandPinLockStateChange%3E%20MobileBroadbandPinLockStateChangeTriggerDetails.PinLockStateChanges");
			}
		}
#endif
		// Forced skipping of method Windows.Networking.NetworkOperators.MobileBroadbandPinLockStateChangeTriggerDetails.PinLockStateChanges.get
	}
}
