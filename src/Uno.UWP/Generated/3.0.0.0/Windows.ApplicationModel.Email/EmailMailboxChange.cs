#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Email
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class EmailMailboxChange 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Email.EmailMailboxChangeType ChangeType
		{
			get
			{
				throw new global::System.NotImplementedException("The member EmailMailboxChangeType EmailMailboxChange.ChangeType is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=EmailMailboxChangeType%20EmailMailboxChange.ChangeType");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Email.EmailFolder Folder
		{
			get
			{
				throw new global::System.NotImplementedException("The member EmailFolder EmailMailboxChange.Folder is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=EmailFolder%20EmailMailboxChange.Folder");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Windows.ApplicationModel.Email.EmailMailboxAction> MailboxActions
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<EmailMailboxAction> EmailMailboxChange.MailboxActions is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IList%3CEmailMailboxAction%3E%20EmailMailboxChange.MailboxActions");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Email.EmailMessage Message
		{
			get
			{
				throw new global::System.NotImplementedException("The member EmailMessage EmailMailboxChange.Message is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=EmailMessage%20EmailMailboxChange.Message");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Email.EmailMailboxChange.ChangeType.get
		// Forced skipping of method Windows.ApplicationModel.Email.EmailMailboxChange.MailboxActions.get
		// Forced skipping of method Windows.ApplicationModel.Email.EmailMailboxChange.Message.get
		// Forced skipping of method Windows.ApplicationModel.Email.EmailMailboxChange.Folder.get
	}
}
