#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class AppDiagnosticInfo 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.AppInfo AppInfo
		{
			get
			{
				throw new global::System.NotImplementedException("The member AppInfo AppDiagnosticInfo.AppInfo is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AppInfo%20AppDiagnosticInfo.AppInfo");
			}
		}
#endif
		// Forced skipping of method Windows.System.AppDiagnosticInfo.AppInfo.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Windows.System.AppResourceGroupInfo> GetResourceGroups()
		{
			throw new global::System.NotImplementedException("The member IList<AppResourceGroupInfo> AppDiagnosticInfo.GetResourceGroups() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IList%3CAppResourceGroupInfo%3E%20AppDiagnosticInfo.GetResourceGroups%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.AppResourceGroupInfoWatcher CreateResourceGroupWatcher()
		{
			throw new global::System.NotImplementedException("The member AppResourceGroupInfoWatcher AppDiagnosticInfo.CreateResourceGroupWatcher() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AppResourceGroupInfoWatcher%20AppDiagnosticInfo.CreateResourceGroupWatcher%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.System.AppActivationResult> LaunchAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<AppActivationResult> AppDiagnosticInfo.LaunchAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CAppActivationResult%3E%20AppDiagnosticInfo.LaunchAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.System.AppDiagnosticInfoWatcher CreateWatcher()
		{
			throw new global::System.NotImplementedException("The member AppDiagnosticInfoWatcher AppDiagnosticInfo.CreateWatcher() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AppDiagnosticInfoWatcher%20AppDiagnosticInfo.CreateWatcher%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.System.DiagnosticAccessStatus> RequestAccessAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<DiagnosticAccessStatus> AppDiagnosticInfo.RequestAccessAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CDiagnosticAccessStatus%3E%20AppDiagnosticInfo.RequestAccessAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IList<global::Windows.System.AppDiagnosticInfo>> RequestInfoForPackageAsync( string packageFamilyName)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IList<AppDiagnosticInfo>> AppDiagnosticInfo.RequestInfoForPackageAsync(string packageFamilyName) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIList%3CAppDiagnosticInfo%3E%3E%20AppDiagnosticInfo.RequestInfoForPackageAsync%28string%20packageFamilyName%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IList<global::Windows.System.AppDiagnosticInfo>> RequestInfoForAppAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IList<AppDiagnosticInfo>> AppDiagnosticInfo.RequestInfoForAppAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIList%3CAppDiagnosticInfo%3E%3E%20AppDiagnosticInfo.RequestInfoForAppAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IList<global::Windows.System.AppDiagnosticInfo>> RequestInfoForAppAsync( string appUserModelId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IList<AppDiagnosticInfo>> AppDiagnosticInfo.RequestInfoForAppAsync(string appUserModelId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIList%3CAppDiagnosticInfo%3E%3E%20AppDiagnosticInfo.RequestInfoForAppAsync%28string%20appUserModelId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IList<global::Windows.System.AppDiagnosticInfo>> RequestInfoAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IList<AppDiagnosticInfo>> AppDiagnosticInfo.RequestInfoAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIList%3CAppDiagnosticInfo%3E%3E%20AppDiagnosticInfo.RequestInfoAsync%28%29");
		}
#endif
	}
}
