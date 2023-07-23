#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.DataTransfer
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class ClipboardContentOptions 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsRoamable
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ClipboardContentOptions.IsRoamable is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20ClipboardContentOptions.IsRoamable");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.ClipboardContentOptions", "bool ClipboardContentOptions.IsRoamable");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsAllowedInHistory
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ClipboardContentOptions.IsAllowedInHistory is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20ClipboardContentOptions.IsAllowedInHistory");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.ClipboardContentOptions", "bool ClipboardContentOptions.IsAllowedInHistory");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<string> HistoryFormats
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<string> ClipboardContentOptions.HistoryFormats is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IList%3Cstring%3E%20ClipboardContentOptions.HistoryFormats");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<string> RoamingFormats
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<string> ClipboardContentOptions.RoamingFormats is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IList%3Cstring%3E%20ClipboardContentOptions.RoamingFormats");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ClipboardContentOptions() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.ClipboardContentOptions", "ClipboardContentOptions.ClipboardContentOptions()");
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.ClipboardContentOptions.ClipboardContentOptions()
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.ClipboardContentOptions.IsRoamable.get
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.ClipboardContentOptions.IsRoamable.set
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.ClipboardContentOptions.IsAllowedInHistory.get
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.ClipboardContentOptions.IsAllowedInHistory.set
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.ClipboardContentOptions.RoamingFormats.get
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.ClipboardContentOptions.HistoryFormats.get
	}
}
