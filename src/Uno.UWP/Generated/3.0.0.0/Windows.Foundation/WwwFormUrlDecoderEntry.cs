#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Foundation
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class WwwFormUrlDecoderEntry : global::Windows.Foundation.IWwwFormUrlDecoderEntry
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string WwwFormUrlDecoderEntry.Name is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20WwwFormUrlDecoderEntry.Name");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Value
		{
			get
			{
				throw new global::System.NotImplementedException("The member string WwwFormUrlDecoderEntry.Value is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20WwwFormUrlDecoderEntry.Value");
			}
		}
#endif
		// Forced skipping of method Windows.Foundation.WwwFormUrlDecoderEntry.Name.get
		// Forced skipping of method Windows.Foundation.WwwFormUrlDecoderEntry.Value.get
		// Processing: Windows.Foundation.IWwwFormUrlDecoderEntry
	}
}
