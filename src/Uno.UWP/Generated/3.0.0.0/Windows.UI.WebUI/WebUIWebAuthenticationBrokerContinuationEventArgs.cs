#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.WebUI
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class WebUIWebAuthenticationBrokerContinuationEventArgs : global::Windows.ApplicationModel.Activation.IWebAuthenticationBrokerContinuationEventArgs,global::Windows.ApplicationModel.Activation.IContinuationActivatedEventArgs,global::Windows.ApplicationModel.Activation.IActivatedEventArgs,global::Windows.UI.WebUI.IActivatedEventArgsDeferral
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.ActivationKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member ActivationKind WebUIWebAuthenticationBrokerContinuationEventArgs.Kind is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ActivationKind%20WebUIWebAuthenticationBrokerContinuationEventArgs.Kind");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.ApplicationExecutionState PreviousExecutionState
		{
			get
			{
				throw new global::System.NotImplementedException("The member ApplicationExecutionState WebUIWebAuthenticationBrokerContinuationEventArgs.PreviousExecutionState is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ApplicationExecutionState%20WebUIWebAuthenticationBrokerContinuationEventArgs.PreviousExecutionState");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.SplashScreen SplashScreen
		{
			get
			{
				throw new global::System.NotImplementedException("The member SplashScreen WebUIWebAuthenticationBrokerContinuationEventArgs.SplashScreen is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SplashScreen%20WebUIWebAuthenticationBrokerContinuationEventArgs.SplashScreen");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Collections.ValueSet ContinuationData
		{
			get
			{
				throw new global::System.NotImplementedException("The member ValueSet WebUIWebAuthenticationBrokerContinuationEventArgs.ContinuationData is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ValueSet%20WebUIWebAuthenticationBrokerContinuationEventArgs.ContinuationData");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Security.Authentication.Web.WebAuthenticationResult WebAuthenticationResult
		{
			get
			{
				throw new global::System.NotImplementedException("The member WebAuthenticationResult WebUIWebAuthenticationBrokerContinuationEventArgs.WebAuthenticationResult is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=WebAuthenticationResult%20WebUIWebAuthenticationBrokerContinuationEventArgs.WebAuthenticationResult");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.WebUI.ActivatedOperation ActivatedOperation
		{
			get
			{
				throw new global::System.NotImplementedException("The member ActivatedOperation WebUIWebAuthenticationBrokerContinuationEventArgs.ActivatedOperation is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ActivatedOperation%20WebUIWebAuthenticationBrokerContinuationEventArgs.ActivatedOperation");
			}
		}
#endif
		// Forced skipping of method Windows.UI.WebUI.WebUIWebAuthenticationBrokerContinuationEventArgs.WebAuthenticationResult.get
		// Forced skipping of method Windows.UI.WebUI.WebUIWebAuthenticationBrokerContinuationEventArgs.ContinuationData.get
		// Forced skipping of method Windows.UI.WebUI.WebUIWebAuthenticationBrokerContinuationEventArgs.Kind.get
		// Forced skipping of method Windows.UI.WebUI.WebUIWebAuthenticationBrokerContinuationEventArgs.PreviousExecutionState.get
		// Forced skipping of method Windows.UI.WebUI.WebUIWebAuthenticationBrokerContinuationEventArgs.SplashScreen.get
		// Forced skipping of method Windows.UI.WebUI.WebUIWebAuthenticationBrokerContinuationEventArgs.ActivatedOperation.get
		// Processing: Windows.ApplicationModel.Activation.IWebAuthenticationBrokerContinuationEventArgs
		// Processing: Windows.ApplicationModel.Activation.IContinuationActivatedEventArgs
		// Processing: Windows.ApplicationModel.Activation.IActivatedEventArgs
		// Processing: Windows.UI.WebUI.IActivatedEventArgsDeferral
	}
}
