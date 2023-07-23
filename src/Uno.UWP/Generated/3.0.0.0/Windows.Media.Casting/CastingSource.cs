#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Casting
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class CastingSource 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Uri PreferredSourceUri
		{
			get
			{
				throw new global::System.NotImplementedException("The member Uri CastingSource.PreferredSourceUri is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Uri%20CastingSource.PreferredSourceUri");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Casting.CastingSource", "Uri CastingSource.PreferredSourceUri");
			}
		}
#endif
		// Forced skipping of method Windows.Media.Casting.CastingSource.PreferredSourceUri.get
		// Forced skipping of method Windows.Media.Casting.CastingSource.PreferredSourceUri.set
	}
}
