#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Background
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class BackgroundTaskProgressEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Guid InstanceId
		{
			get
			{
				throw new global::System.NotImplementedException("The member Guid BackgroundTaskProgressEventArgs.InstanceId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Guid%20BackgroundTaskProgressEventArgs.InstanceId");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint Progress
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint BackgroundTaskProgressEventArgs.Progress is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20BackgroundTaskProgressEventArgs.Progress");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskProgressEventArgs.InstanceId.get
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskProgressEventArgs.Progress.get
	}
}
