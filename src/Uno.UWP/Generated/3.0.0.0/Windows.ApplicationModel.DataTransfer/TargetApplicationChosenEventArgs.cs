#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.DataTransfer
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class TargetApplicationChosenEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string ApplicationName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string TargetApplicationChosenEventArgs.ApplicationName is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20TargetApplicationChosenEventArgs.ApplicationName");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.TargetApplicationChosenEventArgs.ApplicationName.get
	}
}
