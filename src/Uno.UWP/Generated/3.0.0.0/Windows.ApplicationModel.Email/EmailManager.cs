#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Email
{
#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
#endif
	public static partial class EmailManager 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.ApplicationModel.Email.EmailManagerForUser GetForUser( global::Windows.System.User user)
		{
			throw new global::System.NotImplementedException("The member EmailManagerForUser EmailManager.GetForUser(User user) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=EmailManagerForUser%20EmailManager.GetForUser%28User%20user%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Email.EmailStore> RequestStoreAsync( global::Windows.ApplicationModel.Email.EmailStoreAccessType accessType)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<EmailStore> EmailManager.RequestStoreAsync(EmailStoreAccessType accessType) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CEmailStore%3E%20EmailManager.RequestStoreAsync%28EmailStoreAccessType%20accessType%29");
		}
#endif
		// Skipping already declared method Windows.ApplicationModel.Email.EmailManager.ShowComposeNewEmailAsync(Windows.ApplicationModel.Email.EmailMessage)
	}
}
