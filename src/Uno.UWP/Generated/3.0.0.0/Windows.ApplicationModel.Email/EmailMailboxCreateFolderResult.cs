#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Email
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class EmailMailboxCreateFolderResult 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Email.EmailFolder Folder
		{
			get
			{
				throw new global::System.NotImplementedException("The member EmailFolder EmailMailboxCreateFolderResult.Folder is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=EmailFolder%20EmailMailboxCreateFolderResult.Folder");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Email.EmailMailboxCreateFolderStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member EmailMailboxCreateFolderStatus EmailMailboxCreateFolderResult.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=EmailMailboxCreateFolderStatus%20EmailMailboxCreateFolderResult.Status");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Email.EmailMailboxCreateFolderResult.Status.get
		// Forced skipping of method Windows.ApplicationModel.Email.EmailMailboxCreateFolderResult.Folder.get
	}
}
