#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.UserDataTasks.DataProvider
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class UserDataTaskListSyncManagerSyncRequest 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string TaskListId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string UserDataTaskListSyncManagerSyncRequest.TaskListId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20UserDataTaskListSyncManagerSyncRequest.TaskListId");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.UserDataTasks.DataProvider.UserDataTaskListSyncManagerSyncRequest.TaskListId.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction ReportCompletedAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction UserDataTaskListSyncManagerSyncRequest.ReportCompletedAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20UserDataTaskListSyncManagerSyncRequest.ReportCompletedAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction ReportFailedAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction UserDataTaskListSyncManagerSyncRequest.ReportFailedAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20UserDataTaskListSyncManagerSyncRequest.ReportFailedAsync%28%29");
		}
#endif
	}
}
