#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.WebUI
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class WebUIPrintWorkflowForegroundTaskActivatedEventArgs : global::Windows.ApplicationModel.Activation.IActivatedEventArgs,global::Windows.UI.WebUI.IActivatedEventArgsDeferral
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.ActivationKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member ActivationKind WebUIPrintWorkflowForegroundTaskActivatedEventArgs.Kind is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ActivationKind%20WebUIPrintWorkflowForegroundTaskActivatedEventArgs.Kind");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.ApplicationExecutionState PreviousExecutionState
		{
			get
			{
				throw new global::System.NotImplementedException("The member ApplicationExecutionState WebUIPrintWorkflowForegroundTaskActivatedEventArgs.PreviousExecutionState is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ApplicationExecutionState%20WebUIPrintWorkflowForegroundTaskActivatedEventArgs.PreviousExecutionState");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.SplashScreen SplashScreen
		{
			get
			{
				throw new global::System.NotImplementedException("The member SplashScreen WebUIPrintWorkflowForegroundTaskActivatedEventArgs.SplashScreen is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SplashScreen%20WebUIPrintWorkflowForegroundTaskActivatedEventArgs.SplashScreen");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.WebUI.ActivatedOperation ActivatedOperation
		{
			get
			{
				throw new global::System.NotImplementedException("The member ActivatedOperation WebUIPrintWorkflowForegroundTaskActivatedEventArgs.ActivatedOperation is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ActivatedOperation%20WebUIPrintWorkflowForegroundTaskActivatedEventArgs.ActivatedOperation");
			}
		}
#endif
		// Forced skipping of method Windows.UI.WebUI.WebUIPrintWorkflowForegroundTaskActivatedEventArgs.Kind.get
		// Forced skipping of method Windows.UI.WebUI.WebUIPrintWorkflowForegroundTaskActivatedEventArgs.PreviousExecutionState.get
		// Forced skipping of method Windows.UI.WebUI.WebUIPrintWorkflowForegroundTaskActivatedEventArgs.SplashScreen.get
		// Forced skipping of method Windows.UI.WebUI.WebUIPrintWorkflowForegroundTaskActivatedEventArgs.ActivatedOperation.get
		// Processing: Windows.ApplicationModel.Activation.IActivatedEventArgs
		// Processing: Windows.UI.WebUI.IActivatedEventArgsDeferral
	}
}
