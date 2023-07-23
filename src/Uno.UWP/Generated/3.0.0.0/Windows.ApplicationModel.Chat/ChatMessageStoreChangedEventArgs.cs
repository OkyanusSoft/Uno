#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Chat
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class ChatMessageStoreChangedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Id
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ChatMessageStoreChangedEventArgs.Id is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20ChatMessageStoreChangedEventArgs.Id");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Chat.ChatStoreChangedEventKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member ChatStoreChangedEventKind ChatMessageStoreChangedEventArgs.Kind is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ChatStoreChangedEventKind%20ChatMessageStoreChangedEventArgs.Kind");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Chat.ChatMessageStoreChangedEventArgs.Id.get
		// Forced skipping of method Windows.ApplicationModel.Chat.ChatMessageStoreChangedEventArgs.Kind.get
	}
}
