#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.ExtendedExecution
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class ExtendedExecutionRevokedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.ExtendedExecution.ExtendedExecutionRevokedReason Reason
		{
			get
			{
				throw new global::System.NotImplementedException("The member ExtendedExecutionRevokedReason ExtendedExecutionRevokedEventArgs.Reason is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ExtendedExecutionRevokedReason%20ExtendedExecutionRevokedEventArgs.Reason");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.ExtendedExecution.ExtendedExecutionRevokedEventArgs.Reason.get
	}
}
