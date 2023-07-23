#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public static partial class RemoteLauncher 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.System.RemoteLaunchUriStatus> LaunchUriAsync( global::Windows.System.RemoteSystems.RemoteSystemConnectionRequest remoteSystemConnectionRequest,  global::System.Uri uri)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<RemoteLaunchUriStatus> RemoteLauncher.LaunchUriAsync(RemoteSystemConnectionRequest remoteSystemConnectionRequest, Uri uri) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CRemoteLaunchUriStatus%3E%20RemoteLauncher.LaunchUriAsync%28RemoteSystemConnectionRequest%20remoteSystemConnectionRequest%2C%20Uri%20uri%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.System.RemoteLaunchUriStatus> LaunchUriAsync( global::Windows.System.RemoteSystems.RemoteSystemConnectionRequest remoteSystemConnectionRequest,  global::System.Uri uri,  global::Windows.System.RemoteLauncherOptions options)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<RemoteLaunchUriStatus> RemoteLauncher.LaunchUriAsync(RemoteSystemConnectionRequest remoteSystemConnectionRequest, Uri uri, RemoteLauncherOptions options) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CRemoteLaunchUriStatus%3E%20RemoteLauncher.LaunchUriAsync%28RemoteSystemConnectionRequest%20remoteSystemConnectionRequest%2C%20Uri%20uri%2C%20RemoteLauncherOptions%20options%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.System.RemoteLaunchUriStatus> LaunchUriAsync( global::Windows.System.RemoteSystems.RemoteSystemConnectionRequest remoteSystemConnectionRequest,  global::System.Uri uri,  global::Windows.System.RemoteLauncherOptions options,  global::Windows.Foundation.Collections.ValueSet inputData)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<RemoteLaunchUriStatus> RemoteLauncher.LaunchUriAsync(RemoteSystemConnectionRequest remoteSystemConnectionRequest, Uri uri, RemoteLauncherOptions options, ValueSet inputData) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CRemoteLaunchUriStatus%3E%20RemoteLauncher.LaunchUriAsync%28RemoteSystemConnectionRequest%20remoteSystemConnectionRequest%2C%20Uri%20uri%2C%20RemoteLauncherOptions%20options%2C%20ValueSet%20inputData%29");
		}
#endif
	}
}
