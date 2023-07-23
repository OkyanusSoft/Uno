#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Contacts
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public static partial class ContactManager 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.ApplicationModel.Contacts.ContactNameOrder SystemSortOrder
		{
			get
			{
				throw new global::System.NotImplementedException("The member ContactNameOrder ContactManager.SystemSortOrder is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ContactNameOrder%20ContactManager.SystemSortOrder");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Contacts.ContactManager", "ContactNameOrder ContactManager.SystemSortOrder");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.ApplicationModel.Contacts.ContactNameOrder SystemDisplayNameOrder
		{
			get
			{
				throw new global::System.NotImplementedException("The member ContactNameOrder ContactManager.SystemDisplayNameOrder is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ContactNameOrder%20ContactManager.SystemDisplayNameOrder");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Contacts.ContactManager", "ContactNameOrder ContactManager.SystemDisplayNameOrder");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool IncludeMiddleNameInSystemDisplayAndSort
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ContactManager.IncludeMiddleNameInSystemDisplayAndSort is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20ContactManager.IncludeMiddleNameInSystemDisplayAndSort");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Contacts.ContactManager", "bool ContactManager.IncludeMiddleNameInSystemDisplayAndSort");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<bool> IsShowFullContactCardSupportedAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> ContactManager.IsShowFullContactCardSupportedAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cbool%3E%20ContactManager.IsShowFullContactCardSupportedAsync%28%29");
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactManager.IncludeMiddleNameInSystemDisplayAndSort.get
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactManager.IncludeMiddleNameInSystemDisplayAndSort.set
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.ApplicationModel.Contacts.ContactManagerForUser GetForUser( global::Windows.System.User user)
		{
			throw new global::System.NotImplementedException("The member ContactManagerForUser ContactManager.GetForUser(User user) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ContactManagerForUser%20ContactManager.GetForUser%28User%20user%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.Streams.RandomAccessStreamReference> ConvertContactToVCardAsync( global::Windows.ApplicationModel.Contacts.Contact contact)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<RandomAccessStreamReference> ContactManager.ConvertContactToVCardAsync(Contact contact) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CRandomAccessStreamReference%3E%20ContactManager.ConvertContactToVCardAsync%28Contact%20contact%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.Streams.RandomAccessStreamReference> ConvertContactToVCardAsync( global::Windows.ApplicationModel.Contacts.Contact contact,  uint maxBytes)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<RandomAccessStreamReference> ContactManager.ConvertContactToVCardAsync(Contact contact, uint maxBytes) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CRandomAccessStreamReference%3E%20ContactManager.ConvertContactToVCardAsync%28Contact%20contact%2C%20uint%20maxBytes%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Contacts.Contact> ConvertVCardToContactAsync( global::Windows.Storage.Streams.IRandomAccessStreamReference vCard)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<Contact> ContactManager.ConvertVCardToContactAsync(IRandomAccessStreamReference vCard) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CContact%3E%20ContactManager.ConvertVCardToContactAsync%28IRandomAccessStreamReference%20vCard%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Contacts.ContactStore> RequestStoreAsync( global::Windows.ApplicationModel.Contacts.ContactStoreAccessType accessType)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ContactStore> ContactManager.RequestStoreAsync(ContactStoreAccessType accessType) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CContactStore%3E%20ContactManager.RequestStoreAsync%28ContactStoreAccessType%20accessType%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Contacts.ContactAnnotationStore> RequestAnnotationStoreAsync( global::Windows.ApplicationModel.Contacts.ContactAnnotationStoreAccessType accessType)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ContactAnnotationStore> ContactManager.RequestAnnotationStoreAsync(ContactAnnotationStoreAccessType accessType) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CContactAnnotationStore%3E%20ContactManager.RequestAnnotationStoreAsync%28ContactAnnotationStoreAccessType%20accessType%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool IsShowContactCardSupported()
		{
			throw new global::System.NotImplementedException("The member bool ContactManager.IsShowContactCardSupported() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20ContactManager.IsShowContactCardSupported%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void ShowContactCard( global::Windows.ApplicationModel.Contacts.Contact contact,  global::Windows.Foundation.Rect selection,  global::Windows.UI.Popups.Placement preferredPlacement,  global::Windows.ApplicationModel.Contacts.ContactCardOptions contactCardOptions)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Contacts.ContactManager", "void ContactManager.ShowContactCard(Contact contact, Rect selection, Placement preferredPlacement, ContactCardOptions contactCardOptions)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool IsShowDelayLoadedContactCardSupported()
		{
			throw new global::System.NotImplementedException("The member bool ContactManager.IsShowDelayLoadedContactCardSupported() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20ContactManager.IsShowDelayLoadedContactCardSupported%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.ApplicationModel.Contacts.ContactCardDelayedDataLoader ShowDelayLoadedContactCard( global::Windows.ApplicationModel.Contacts.Contact contact,  global::Windows.Foundation.Rect selection,  global::Windows.UI.Popups.Placement preferredPlacement,  global::Windows.ApplicationModel.Contacts.ContactCardOptions contactCardOptions)
		{
			throw new global::System.NotImplementedException("The member ContactCardDelayedDataLoader ContactManager.ShowDelayLoadedContactCard(Contact contact, Rect selection, Placement preferredPlacement, ContactCardOptions contactCardOptions) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ContactCardDelayedDataLoader%20ContactManager.ShowDelayLoadedContactCard%28Contact%20contact%2C%20Rect%20selection%2C%20Placement%20preferredPlacement%2C%20ContactCardOptions%20contactCardOptions%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void ShowFullContactCard( global::Windows.ApplicationModel.Contacts.Contact contact,  global::Windows.ApplicationModel.Contacts.FullContactCardOptions fullContactCardOptions)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Contacts.ContactManager", "void ContactManager.ShowFullContactCard(Contact contact, FullContactCardOptions fullContactCardOptions)");
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactManager.SystemDisplayNameOrder.get
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactManager.SystemDisplayNameOrder.set
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactManager.SystemSortOrder.get
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactManager.SystemSortOrder.set
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Contacts.ContactStore> RequestStoreAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ContactStore> ContactManager.RequestStoreAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CContactStore%3E%20ContactManager.RequestStoreAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void ShowContactCard( global::Windows.ApplicationModel.Contacts.Contact contact,  global::Windows.Foundation.Rect selection)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Contacts.ContactManager", "void ContactManager.ShowContactCard(Contact contact, Rect selection)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void ShowContactCard( global::Windows.ApplicationModel.Contacts.Contact contact,  global::Windows.Foundation.Rect selection,  global::Windows.UI.Popups.Placement preferredPlacement)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Contacts.ContactManager", "void ContactManager.ShowContactCard(Contact contact, Rect selection, Placement preferredPlacement)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.ApplicationModel.Contacts.ContactCardDelayedDataLoader ShowDelayLoadedContactCard( global::Windows.ApplicationModel.Contacts.Contact contact,  global::Windows.Foundation.Rect selection,  global::Windows.UI.Popups.Placement preferredPlacement)
		{
			throw new global::System.NotImplementedException("The member ContactCardDelayedDataLoader ContactManager.ShowDelayLoadedContactCard(Contact contact, Rect selection, Placement preferredPlacement) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ContactCardDelayedDataLoader%20ContactManager.ShowDelayLoadedContactCard%28Contact%20contact%2C%20Rect%20selection%2C%20Placement%20preferredPlacement%29");
		}
#endif
	}
}
