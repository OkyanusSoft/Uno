#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Chat
{
#if false || false || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
#endif
	public static partial class ChatMessageManager 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Chat.ChatSyncManager> RequestSyncManagerAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ChatSyncManager> ChatMessageManager.RequestSyncManagerAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CChatSyncManager%3E%20ChatMessageManager.RequestSyncManagerAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<string> RegisterTransportAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> ChatMessageManager.RegisterTransportAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cstring%3E%20ChatMessageManager.RegisterTransportAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Chat.ChatMessageTransport> GetTransportAsync( string transportId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ChatMessageTransport> ChatMessageManager.GetTransportAsync(string transportId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CChatMessageTransport%3E%20ChatMessageManager.GetTransportAsync%28string%20transportId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Chat.ChatMessageTransport>> GetTransportsAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<ChatMessageTransport>> ChatMessageManager.GetTransportsAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CChatMessageTransport%3E%3E%20ChatMessageManager.GetTransportsAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Chat.ChatMessageStore> RequestStoreAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ChatMessageStore> ChatMessageManager.RequestStoreAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CChatMessageStore%3E%20ChatMessageManager.RequestStoreAsync%28%29");
		}
#endif
#if false || false || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public static global::Windows.Foundation.IAsyncAction ShowComposeSmsMessageAsync( global::Windows.ApplicationModel.Chat.ChatMessage message)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ChatMessageManager.ShowComposeSmsMessageAsync(ChatMessage message) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20ChatMessageManager.ShowComposeSmsMessageAsync%28ChatMessage%20message%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void ShowSmsSettings()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Chat.ChatMessageManager", "void ChatMessageManager.ShowSmsSettings()");
		}
#endif
	}
}
