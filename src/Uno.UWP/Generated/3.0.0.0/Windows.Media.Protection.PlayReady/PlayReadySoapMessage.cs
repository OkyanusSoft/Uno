#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Protection.PlayReady
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class PlayReadySoapMessage 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Collections.IPropertySet MessageHeaders
		{
			get
			{
				throw new global::System.NotImplementedException("The member IPropertySet PlayReadySoapMessage.MessageHeaders is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IPropertySet%20PlayReadySoapMessage.MessageHeaders");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Uri Uri
		{
			get
			{
				throw new global::System.NotImplementedException("The member Uri PlayReadySoapMessage.Uri is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Uri%20PlayReadySoapMessage.Uri");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  byte[] GetMessageBody()
		{
			throw new global::System.NotImplementedException("The member byte[] PlayReadySoapMessage.GetMessageBody() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=byte%5B%5D%20PlayReadySoapMessage.GetMessageBody%28%29");
		}
#endif
		// Forced skipping of method Windows.Media.Protection.PlayReady.PlayReadySoapMessage.MessageHeaders.get
		// Forced skipping of method Windows.Media.Protection.PlayReady.PlayReadySoapMessage.Uri.get
	}
}
