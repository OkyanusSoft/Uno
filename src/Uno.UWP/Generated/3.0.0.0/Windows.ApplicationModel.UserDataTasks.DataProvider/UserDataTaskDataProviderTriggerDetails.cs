#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.UserDataTasks.DataProvider
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class UserDataTaskDataProviderTriggerDetails 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.UserDataTasks.DataProvider.UserDataTaskDataProviderConnection Connection
		{
			get
			{
				throw new global::System.NotImplementedException("The member UserDataTaskDataProviderConnection UserDataTaskDataProviderTriggerDetails.Connection is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=UserDataTaskDataProviderConnection%20UserDataTaskDataProviderTriggerDetails.Connection");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.UserDataTasks.DataProvider.UserDataTaskDataProviderTriggerDetails.Connection.get
	}
}
