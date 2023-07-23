#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Haptics
{
#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
#endif
	public  partial class SimpleHapticsController 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Id
		{
			get
			{
				throw new global::System.NotImplementedException("The member string SimpleHapticsController.Id is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20SimpleHapticsController.Id");
			}
		}
#endif
#if false || false || IS_UNIT_TESTS || false || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__NETSTD_REFERENCE__")]
		public  bool IsIntensitySupported
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool SimpleHapticsController.IsIntensitySupported is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20SimpleHapticsController.IsIntensitySupported");
			}
		}
#endif
#if false || false || IS_UNIT_TESTS || false || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__NETSTD_REFERENCE__")]
		public  bool IsPlayCountSupported
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool SimpleHapticsController.IsPlayCountSupported is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20SimpleHapticsController.IsPlayCountSupported");
			}
		}
#endif
#if false || false || IS_UNIT_TESTS || false || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__NETSTD_REFERENCE__")]
		public  bool IsPlayDurationSupported
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool SimpleHapticsController.IsPlayDurationSupported is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20SimpleHapticsController.IsPlayDurationSupported");
			}
		}
#endif
#if false || false || IS_UNIT_TESTS || false || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__NETSTD_REFERENCE__")]
		public  bool IsReplayPauseIntervalSupported
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool SimpleHapticsController.IsReplayPauseIntervalSupported is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20SimpleHapticsController.IsReplayPauseIntervalSupported");
			}
		}
#endif
#if false || false || IS_UNIT_TESTS || false || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__NETSTD_REFERENCE__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.Haptics.SimpleHapticsControllerFeedback> SupportedFeedback
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<SimpleHapticsControllerFeedback> SimpleHapticsController.SupportedFeedback is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CSimpleHapticsControllerFeedback%3E%20SimpleHapticsController.SupportedFeedback");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.Haptics.SimpleHapticsController.Id.get
		// Forced skipping of method Windows.Devices.Haptics.SimpleHapticsController.SupportedFeedback.get
		// Forced skipping of method Windows.Devices.Haptics.SimpleHapticsController.IsIntensitySupported.get
		// Forced skipping of method Windows.Devices.Haptics.SimpleHapticsController.IsPlayCountSupported.get
		// Forced skipping of method Windows.Devices.Haptics.SimpleHapticsController.IsPlayDurationSupported.get
		// Forced skipping of method Windows.Devices.Haptics.SimpleHapticsController.IsReplayPauseIntervalSupported.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void StopFeedback()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Haptics.SimpleHapticsController", "void SimpleHapticsController.StopFeedback()");
		}
#endif
#if false || false || IS_UNIT_TESTS || false || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__NETSTD_REFERENCE__")]
		public  void SendHapticFeedback( global::Windows.Devices.Haptics.SimpleHapticsControllerFeedback feedback)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Haptics.SimpleHapticsController", "void SimpleHapticsController.SendHapticFeedback(SimpleHapticsControllerFeedback feedback)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void SendHapticFeedback( global::Windows.Devices.Haptics.SimpleHapticsControllerFeedback feedback,  double intensity)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Haptics.SimpleHapticsController", "void SimpleHapticsController.SendHapticFeedback(SimpleHapticsControllerFeedback feedback, double intensity)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void SendHapticFeedbackForDuration( global::Windows.Devices.Haptics.SimpleHapticsControllerFeedback feedback,  double intensity,  global::System.TimeSpan playDuration)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Haptics.SimpleHapticsController", "void SimpleHapticsController.SendHapticFeedbackForDuration(SimpleHapticsControllerFeedback feedback, double intensity, TimeSpan playDuration)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void SendHapticFeedbackForPlayCount( global::Windows.Devices.Haptics.SimpleHapticsControllerFeedback feedback,  double intensity,  int playCount,  global::System.TimeSpan replayPauseInterval)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Haptics.SimpleHapticsController", "void SimpleHapticsController.SendHapticFeedbackForPlayCount(SimpleHapticsControllerFeedback feedback, double intensity, int playCount, TimeSpan replayPauseInterval)");
		}
#endif
	}
}
