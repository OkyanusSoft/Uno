#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Chat
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public static partial class RcsManager 
	{
		// Forced skipping of method Windows.ApplicationModel.Chat.RcsManager.TransportListChanged.add
		// Forced skipping of method Windows.ApplicationModel.Chat.RcsManager.TransportListChanged.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.ApplicationModel.Chat.RcsEndUserMessageManager GetEndUserMessageManager()
		{
			throw new global::System.NotImplementedException("The member RcsEndUserMessageManager RcsManager.GetEndUserMessageManager() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=RcsEndUserMessageManager%20RcsManager.GetEndUserMessageManager%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Chat.RcsTransport>> GetTransportsAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<RcsTransport>> RcsManager.GetTransportsAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CRcsTransport%3E%3E%20RcsManager.GetTransportsAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Chat.RcsTransport> GetTransportAsync( string transportId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<RcsTransport> RcsManager.GetTransportAsync(string transportId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CRcsTransport%3E%20RcsManager.GetTransportAsync%28string%20transportId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction LeaveConversationAsync( global::Windows.ApplicationModel.Chat.ChatConversation conversation)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction RcsManager.LeaveConversationAsync(ChatConversation conversation) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20RcsManager.LeaveConversationAsync%28ChatConversation%20conversation%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static event global::System.EventHandler<object> TransportListChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Chat.RcsManager", "event EventHandler<object> RcsManager.TransportListChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Chat.RcsManager", "event EventHandler<object> RcsManager.TransportListChanged");
			}
		}
#endif
	}
}
