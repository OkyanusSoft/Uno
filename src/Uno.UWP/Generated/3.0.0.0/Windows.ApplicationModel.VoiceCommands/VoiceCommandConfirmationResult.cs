#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.VoiceCommands
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class VoiceCommandConfirmationResult 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool Confirmed
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool VoiceCommandConfirmationResult.Confirmed is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20VoiceCommandConfirmationResult.Confirmed");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.VoiceCommands.VoiceCommandConfirmationResult.Confirmed.get
	}
}
