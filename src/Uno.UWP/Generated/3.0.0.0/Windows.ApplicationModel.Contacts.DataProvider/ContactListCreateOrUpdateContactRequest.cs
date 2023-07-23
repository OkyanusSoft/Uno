#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Contacts.DataProvider
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class ContactListCreateOrUpdateContactRequest 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Contacts.Contact Contact
		{
			get
			{
				throw new global::System.NotImplementedException("The member Contact ContactListCreateOrUpdateContactRequest.Contact is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Contact%20ContactListCreateOrUpdateContactRequest.Contact");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string ContactListId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ContactListCreateOrUpdateContactRequest.ContactListId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20ContactListCreateOrUpdateContactRequest.ContactListId");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Contacts.DataProvider.ContactListCreateOrUpdateContactRequest.ContactListId.get
		// Forced skipping of method Windows.ApplicationModel.Contacts.DataProvider.ContactListCreateOrUpdateContactRequest.Contact.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction ReportCompletedAsync( global::Windows.ApplicationModel.Contacts.Contact createdOrUpdatedContact)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ContactListCreateOrUpdateContactRequest.ReportCompletedAsync(Contact createdOrUpdatedContact) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20ContactListCreateOrUpdateContactRequest.ReportCompletedAsync%28Contact%20createdOrUpdatedContact%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction ReportFailedAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ContactListCreateOrUpdateContactRequest.ReportFailedAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20ContactListCreateOrUpdateContactRequest.ReportFailedAsync%28%29");
		}
#endif
	}
}
