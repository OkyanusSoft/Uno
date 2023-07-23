#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Devices
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class AudioDeviceModuleNotificationEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Devices.AudioDeviceModule Module
		{
			get
			{
				throw new global::System.NotImplementedException("The member AudioDeviceModule AudioDeviceModuleNotificationEventArgs.Module is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AudioDeviceModule%20AudioDeviceModuleNotificationEventArgs.Module");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Streams.IBuffer NotificationData
		{
			get
			{
				throw new global::System.NotImplementedException("The member IBuffer AudioDeviceModuleNotificationEventArgs.NotificationData is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IBuffer%20AudioDeviceModuleNotificationEventArgs.NotificationData");
			}
		}
#endif
		// Forced skipping of method Windows.Media.Devices.AudioDeviceModuleNotificationEventArgs.Module.get
		// Forced skipping of method Windows.Media.Devices.AudioDeviceModuleNotificationEventArgs.NotificationData.get
	}
}
