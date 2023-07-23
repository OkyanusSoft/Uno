#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.DataTransfer
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public static partial class SharedStorageAccessManager 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string AddFile( global::Windows.Storage.IStorageFile file)
		{
			throw new global::System.NotImplementedException("The member string SharedStorageAccessManager.AddFile(IStorageFile file) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20SharedStorageAccessManager.AddFile%28IStorageFile%20file%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.StorageFile> RedeemTokenForFileAsync( string token)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StorageFile> SharedStorageAccessManager.RedeemTokenForFileAsync(string token) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CStorageFile%3E%20SharedStorageAccessManager.RedeemTokenForFileAsync%28string%20token%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void RemoveFile( string token)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.SharedStorageAccessManager", "void SharedStorageAccessManager.RemoveFile(string token)");
		}
#endif
	}
}
