#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class AppResourceGroupInfo 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Guid InstanceId
		{
			get
			{
				throw new global::System.NotImplementedException("The member Guid AppResourceGroupInfo.InstanceId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Guid%20AppResourceGroupInfo.InstanceId");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsShared
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AppResourceGroupInfo.IsShared is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20AppResourceGroupInfo.IsShared");
			}
		}
#endif
		// Forced skipping of method Windows.System.AppResourceGroupInfo.InstanceId.get
		// Forced skipping of method Windows.System.AppResourceGroupInfo.IsShared.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Windows.System.AppResourceGroupBackgroundTaskReport> GetBackgroundTaskReports()
		{
			throw new global::System.NotImplementedException("The member IList<AppResourceGroupBackgroundTaskReport> AppResourceGroupInfo.GetBackgroundTaskReports() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IList%3CAppResourceGroupBackgroundTaskReport%3E%20AppResourceGroupInfo.GetBackgroundTaskReports%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.AppResourceGroupMemoryReport GetMemoryReport()
		{
			throw new global::System.NotImplementedException("The member AppResourceGroupMemoryReport AppResourceGroupInfo.GetMemoryReport() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AppResourceGroupMemoryReport%20AppResourceGroupInfo.GetMemoryReport%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Windows.System.Diagnostics.ProcessDiagnosticInfo> GetProcessDiagnosticInfos()
		{
			throw new global::System.NotImplementedException("The member IList<ProcessDiagnosticInfo> AppResourceGroupInfo.GetProcessDiagnosticInfos() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IList%3CProcessDiagnosticInfo%3E%20AppResourceGroupInfo.GetProcessDiagnosticInfos%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.AppResourceGroupStateReport GetStateReport()
		{
			throw new global::System.NotImplementedException("The member AppResourceGroupStateReport AppResourceGroupInfo.GetStateReport() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AppResourceGroupStateReport%20AppResourceGroupInfo.GetStateReport%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.System.AppExecutionStateChangeResult> StartSuspendAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<AppExecutionStateChangeResult> AppResourceGroupInfo.StartSuspendAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CAppExecutionStateChangeResult%3E%20AppResourceGroupInfo.StartSuspendAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.System.AppExecutionStateChangeResult> StartResumeAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<AppExecutionStateChangeResult> AppResourceGroupInfo.StartResumeAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CAppExecutionStateChangeResult%3E%20AppResourceGroupInfo.StartResumeAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.System.AppExecutionStateChangeResult> StartTerminateAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<AppExecutionStateChangeResult> AppResourceGroupInfo.StartTerminateAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CAppExecutionStateChangeResult%3E%20AppResourceGroupInfo.StartTerminateAsync%28%29");
		}
#endif
	}
}
