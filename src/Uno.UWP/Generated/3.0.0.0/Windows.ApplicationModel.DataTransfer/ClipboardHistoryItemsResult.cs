#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.DataTransfer
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class ClipboardHistoryItemsResult 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.DataTransfer.ClipboardHistoryItem> Items
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<ClipboardHistoryItem> ClipboardHistoryItemsResult.Items is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CClipboardHistoryItem%3E%20ClipboardHistoryItemsResult.Items");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.DataTransfer.ClipboardHistoryItemsResultStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member ClipboardHistoryItemsResultStatus ClipboardHistoryItemsResult.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ClipboardHistoryItemsResultStatus%20ClipboardHistoryItemsResult.Status");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.ClipboardHistoryItemsResult.Status.get
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.ClipboardHistoryItemsResult.Items.get
	}
}
