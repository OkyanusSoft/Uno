#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class FolderLauncherOptions : global::Windows.System.ILauncherViewOptions
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Windows.Storage.IStorageItem> ItemsToSelect
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<IStorageItem> FolderLauncherOptions.ItemsToSelect is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IList%3CIStorageItem%3E%20FolderLauncherOptions.ItemsToSelect");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.ViewManagement.ViewSizePreference DesiredRemainingView
		{
			get
			{
				throw new global::System.NotImplementedException("The member ViewSizePreference FolderLauncherOptions.DesiredRemainingView is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ViewSizePreference%20FolderLauncherOptions.DesiredRemainingView");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.System.FolderLauncherOptions", "ViewSizePreference FolderLauncherOptions.DesiredRemainingView");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public FolderLauncherOptions() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.System.FolderLauncherOptions", "FolderLauncherOptions.FolderLauncherOptions()");
		}
#endif
		// Forced skipping of method Windows.System.FolderLauncherOptions.FolderLauncherOptions()
		// Forced skipping of method Windows.System.FolderLauncherOptions.ItemsToSelect.get
		// Forced skipping of method Windows.System.FolderLauncherOptions.DesiredRemainingView.get
		// Forced skipping of method Windows.System.FolderLauncherOptions.DesiredRemainingView.set
		// Processing: Windows.System.ILauncherViewOptions
	}
}
