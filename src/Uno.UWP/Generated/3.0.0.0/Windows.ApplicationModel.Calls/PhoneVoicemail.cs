#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Calls
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class PhoneVoicemail 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int MessageCount
		{
			get
			{
				throw new global::System.NotImplementedException("The member int PhoneVoicemail.MessageCount is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=int%20PhoneVoicemail.MessageCount");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Number
		{
			get
			{
				throw new global::System.NotImplementedException("The member string PhoneVoicemail.Number is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20PhoneVoicemail.Number");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Calls.PhoneVoicemailType Type
		{
			get
			{
				throw new global::System.NotImplementedException("The member PhoneVoicemailType PhoneVoicemail.Type is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PhoneVoicemailType%20PhoneVoicemail.Type");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Calls.PhoneVoicemail.Number.get
		// Forced skipping of method Windows.ApplicationModel.Calls.PhoneVoicemail.MessageCount.get
		// Forced skipping of method Windows.ApplicationModel.Calls.PhoneVoicemail.Type.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction DialVoicemailAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction PhoneVoicemail.DialVoicemailAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20PhoneVoicemail.DialVoicemailAsync%28%29");
		}
#endif
	}
}
