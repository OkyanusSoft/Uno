#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Printing.OptionDetails
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class PrintCustomItemDetails 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string ItemDisplayName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string PrintCustomItemDetails.ItemDisplayName is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20PrintCustomItemDetails.ItemDisplayName");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Graphics.Printing.OptionDetails.PrintCustomItemDetails", "string PrintCustomItemDetails.ItemDisplayName");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string ItemId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string PrintCustomItemDetails.ItemId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20PrintCustomItemDetails.ItemId");
			}
		}
#endif
		// Forced skipping of method Windows.Graphics.Printing.OptionDetails.PrintCustomItemDetails.ItemId.get
		// Forced skipping of method Windows.Graphics.Printing.OptionDetails.PrintCustomItemDetails.ItemDisplayName.set
		// Forced skipping of method Windows.Graphics.Printing.OptionDetails.PrintCustomItemDetails.ItemDisplayName.get
	}
}
