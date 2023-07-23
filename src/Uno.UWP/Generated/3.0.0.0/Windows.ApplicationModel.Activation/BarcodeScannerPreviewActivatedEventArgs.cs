#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Activation
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class BarcodeScannerPreviewActivatedEventArgs : global::Windows.ApplicationModel.Activation.IBarcodeScannerPreviewActivatedEventArgs,global::Windows.ApplicationModel.Activation.IActivatedEventArgs,global::Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.ActivationKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member ActivationKind BarcodeScannerPreviewActivatedEventArgs.Kind is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ActivationKind%20BarcodeScannerPreviewActivatedEventArgs.Kind");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.ApplicationExecutionState PreviousExecutionState
		{
			get
			{
				throw new global::System.NotImplementedException("The member ApplicationExecutionState BarcodeScannerPreviewActivatedEventArgs.PreviousExecutionState is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ApplicationExecutionState%20BarcodeScannerPreviewActivatedEventArgs.PreviousExecutionState");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.SplashScreen SplashScreen
		{
			get
			{
				throw new global::System.NotImplementedException("The member SplashScreen BarcodeScannerPreviewActivatedEventArgs.SplashScreen is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SplashScreen%20BarcodeScannerPreviewActivatedEventArgs.SplashScreen");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.User User
		{
			get
			{
				throw new global::System.NotImplementedException("The member User BarcodeScannerPreviewActivatedEventArgs.User is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=User%20BarcodeScannerPreviewActivatedEventArgs.User");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string ConnectionId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string BarcodeScannerPreviewActivatedEventArgs.ConnectionId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20BarcodeScannerPreviewActivatedEventArgs.ConnectionId");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Activation.BarcodeScannerPreviewActivatedEventArgs.ConnectionId.get
		// Forced skipping of method Windows.ApplicationModel.Activation.BarcodeScannerPreviewActivatedEventArgs.Kind.get
		// Forced skipping of method Windows.ApplicationModel.Activation.BarcodeScannerPreviewActivatedEventArgs.PreviousExecutionState.get
		// Forced skipping of method Windows.ApplicationModel.Activation.BarcodeScannerPreviewActivatedEventArgs.SplashScreen.get
		// Forced skipping of method Windows.ApplicationModel.Activation.BarcodeScannerPreviewActivatedEventArgs.User.get
		// Processing: Windows.ApplicationModel.Activation.IBarcodeScannerPreviewActivatedEventArgs
		// Processing: Windows.ApplicationModel.Activation.IActivatedEventArgs
		// Processing: Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser
	}
}
