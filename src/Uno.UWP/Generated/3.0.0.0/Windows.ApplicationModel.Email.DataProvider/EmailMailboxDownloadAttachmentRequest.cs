#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Email.DataProvider
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class EmailMailboxDownloadAttachmentRequest 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string EmailAttachmentId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string EmailMailboxDownloadAttachmentRequest.EmailAttachmentId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20EmailMailboxDownloadAttachmentRequest.EmailAttachmentId");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string EmailMailboxId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string EmailMailboxDownloadAttachmentRequest.EmailMailboxId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20EmailMailboxDownloadAttachmentRequest.EmailMailboxId");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string EmailMessageId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string EmailMailboxDownloadAttachmentRequest.EmailMessageId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20EmailMailboxDownloadAttachmentRequest.EmailMessageId");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Email.DataProvider.EmailMailboxDownloadAttachmentRequest.EmailMailboxId.get
		// Forced skipping of method Windows.ApplicationModel.Email.DataProvider.EmailMailboxDownloadAttachmentRequest.EmailMessageId.get
		// Forced skipping of method Windows.ApplicationModel.Email.DataProvider.EmailMailboxDownloadAttachmentRequest.EmailAttachmentId.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction ReportCompletedAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction EmailMailboxDownloadAttachmentRequest.ReportCompletedAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20EmailMailboxDownloadAttachmentRequest.ReportCompletedAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction ReportFailedAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction EmailMailboxDownloadAttachmentRequest.ReportFailedAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20EmailMailboxDownloadAttachmentRequest.ReportFailedAsync%28%29");
		}
#endif
	}
}
