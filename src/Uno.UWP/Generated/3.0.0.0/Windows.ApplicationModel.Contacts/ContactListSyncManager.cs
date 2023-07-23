#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Contacts
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class ContactListSyncManager 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Contacts.ContactListSyncStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member ContactListSyncStatus ContactListSyncManager.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ContactListSyncStatus%20ContactListSyncManager.Status");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Contacts.ContactListSyncManager", "ContactListSyncStatus ContactListSyncManager.Status");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.DateTimeOffset LastSuccessfulSyncTime
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset ContactListSyncManager.LastSuccessfulSyncTime is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DateTimeOffset%20ContactListSyncManager.LastSuccessfulSyncTime");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Contacts.ContactListSyncManager", "DateTimeOffset ContactListSyncManager.LastSuccessfulSyncTime");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.DateTimeOffset LastAttemptedSyncTime
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset ContactListSyncManager.LastAttemptedSyncTime is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DateTimeOffset%20ContactListSyncManager.LastAttemptedSyncTime");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Contacts.ContactListSyncManager", "DateTimeOffset ContactListSyncManager.LastAttemptedSyncTime");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactListSyncManager.Status.get
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactListSyncManager.LastSuccessfulSyncTime.get
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactListSyncManager.LastAttemptedSyncTime.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<bool> SyncAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> ContactListSyncManager.SyncAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cbool%3E%20ContactListSyncManager.SyncAsync%28%29");
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactListSyncManager.SyncStatusChanged.add
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactListSyncManager.SyncStatusChanged.remove
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactListSyncManager.Status.set
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactListSyncManager.LastSuccessfulSyncTime.set
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactListSyncManager.LastAttemptedSyncTime.set
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.ApplicationModel.Contacts.ContactListSyncManager, object> SyncStatusChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Contacts.ContactListSyncManager", "event TypedEventHandler<ContactListSyncManager, object> ContactListSyncManager.SyncStatusChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Contacts.ContactListSyncManager", "event TypedEventHandler<ContactListSyncManager, object> ContactListSyncManager.SyncStatusChanged");
			}
		}
#endif
	}
}
