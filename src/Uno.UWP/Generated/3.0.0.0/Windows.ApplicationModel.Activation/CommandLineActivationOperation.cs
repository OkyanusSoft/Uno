#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Activation
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class CommandLineActivationOperation 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int ExitCode
		{
			get
			{
				throw new global::System.NotImplementedException("The member int CommandLineActivationOperation.ExitCode is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=int%20CommandLineActivationOperation.ExitCode");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Activation.CommandLineActivationOperation", "int CommandLineActivationOperation.ExitCode");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Arguments
		{
			get
			{
				throw new global::System.NotImplementedException("The member string CommandLineActivationOperation.Arguments is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20CommandLineActivationOperation.Arguments");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string CurrentDirectoryPath
		{
			get
			{
				throw new global::System.NotImplementedException("The member string CommandLineActivationOperation.CurrentDirectoryPath is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20CommandLineActivationOperation.CurrentDirectoryPath");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Activation.CommandLineActivationOperation.Arguments.get
		// Forced skipping of method Windows.ApplicationModel.Activation.CommandLineActivationOperation.CurrentDirectoryPath.get
		// Forced skipping of method Windows.ApplicationModel.Activation.CommandLineActivationOperation.ExitCode.set
		// Forced skipping of method Windows.ApplicationModel.Activation.CommandLineActivationOperation.ExitCode.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral CommandLineActivationOperation.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Deferral%20CommandLineActivationOperation.GetDeferral%28%29");
		}
#endif
	}
}
