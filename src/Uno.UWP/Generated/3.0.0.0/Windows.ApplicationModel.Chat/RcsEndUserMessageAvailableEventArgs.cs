#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Chat
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class RcsEndUserMessageAvailableEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsMessageAvailable
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool RcsEndUserMessageAvailableEventArgs.IsMessageAvailable is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20RcsEndUserMessageAvailableEventArgs.IsMessageAvailable");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Chat.RcsEndUserMessage Message
		{
			get
			{
				throw new global::System.NotImplementedException("The member RcsEndUserMessage RcsEndUserMessageAvailableEventArgs.Message is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=RcsEndUserMessage%20RcsEndUserMessageAvailableEventArgs.Message");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Chat.RcsEndUserMessageAvailableEventArgs.IsMessageAvailable.get
		// Forced skipping of method Windows.ApplicationModel.Chat.RcsEndUserMessageAvailableEventArgs.Message.get
	}
}
