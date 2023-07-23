#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Services.Store
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class StoreQueueItem 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Services.Store.StoreQueueItemKind InstallKind
		{
			get
			{
				throw new global::System.NotImplementedException("The member StoreQueueItemKind StoreQueueItem.InstallKind is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StoreQueueItemKind%20StoreQueueItem.InstallKind");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string PackageFamilyName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string StoreQueueItem.PackageFamilyName is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20StoreQueueItem.PackageFamilyName");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string ProductId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string StoreQueueItem.ProductId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20StoreQueueItem.ProductId");
			}
		}
#endif
		// Forced skipping of method Windows.Services.Store.StoreQueueItem.ProductId.get
		// Forced skipping of method Windows.Services.Store.StoreQueueItem.PackageFamilyName.get
		// Forced skipping of method Windows.Services.Store.StoreQueueItem.InstallKind.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Services.Store.StoreQueueItemStatus GetCurrentStatus()
		{
			throw new global::System.NotImplementedException("The member StoreQueueItemStatus StoreQueueItem.GetCurrentStatus() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StoreQueueItemStatus%20StoreQueueItem.GetCurrentStatus%28%29");
		}
#endif
		// Forced skipping of method Windows.Services.Store.StoreQueueItem.Completed.add
		// Forced skipping of method Windows.Services.Store.StoreQueueItem.Completed.remove
		// Forced skipping of method Windows.Services.Store.StoreQueueItem.StatusChanged.add
		// Forced skipping of method Windows.Services.Store.StoreQueueItem.StatusChanged.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction CancelInstallAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction StoreQueueItem.CancelInstallAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20StoreQueueItem.CancelInstallAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction PauseInstallAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction StoreQueueItem.PauseInstallAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20StoreQueueItem.PauseInstallAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction ResumeInstallAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction StoreQueueItem.ResumeInstallAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20StoreQueueItem.ResumeInstallAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Services.Store.StoreQueueItem, global::Windows.Services.Store.StoreQueueItemCompletedEventArgs> Completed
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Services.Store.StoreQueueItem", "event TypedEventHandler<StoreQueueItem, StoreQueueItemCompletedEventArgs> StoreQueueItem.Completed");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Services.Store.StoreQueueItem", "event TypedEventHandler<StoreQueueItem, StoreQueueItemCompletedEventArgs> StoreQueueItem.Completed");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Services.Store.StoreQueueItem, object> StatusChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Services.Store.StoreQueueItem", "event TypedEventHandler<StoreQueueItem, object> StoreQueueItem.StatusChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Services.Store.StoreQueueItem", "event TypedEventHandler<StoreQueueItem, object> StoreQueueItem.StatusChanged");
			}
		}
#endif
	}
}
