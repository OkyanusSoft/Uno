#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Email.DataProvider
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class EmailMailboxGetAutoReplySettingsRequestEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Email.DataProvider.EmailMailboxGetAutoReplySettingsRequest Request
		{
			get
			{
				throw new global::System.NotImplementedException("The member EmailMailboxGetAutoReplySettingsRequest EmailMailboxGetAutoReplySettingsRequestEventArgs.Request is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=EmailMailboxGetAutoReplySettingsRequest%20EmailMailboxGetAutoReplySettingsRequestEventArgs.Request");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Email.DataProvider.EmailMailboxGetAutoReplySettingsRequestEventArgs.Request.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral EmailMailboxGetAutoReplySettingsRequestEventArgs.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Deferral%20EmailMailboxGetAutoReplySettingsRequestEventArgs.GetDeferral%28%29");
		}
#endif
	}
}
