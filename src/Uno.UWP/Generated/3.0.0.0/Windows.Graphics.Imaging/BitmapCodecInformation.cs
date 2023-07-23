#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Imaging
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class BitmapCodecInformation 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Guid CodecId
		{
			get
			{
				throw new global::System.NotImplementedException("The member Guid BitmapCodecInformation.CodecId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Guid%20BitmapCodecInformation.CodecId");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<string> FileExtensions
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<string> BitmapCodecInformation.FileExtensions is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3Cstring%3E%20BitmapCodecInformation.FileExtensions");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string FriendlyName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string BitmapCodecInformation.FriendlyName is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20BitmapCodecInformation.FriendlyName");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<string> MimeTypes
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<string> BitmapCodecInformation.MimeTypes is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3Cstring%3E%20BitmapCodecInformation.MimeTypes");
			}
		}
#endif
		// Forced skipping of method Windows.Graphics.Imaging.BitmapCodecInformation.CodecId.get
		// Forced skipping of method Windows.Graphics.Imaging.BitmapCodecInformation.FileExtensions.get
		// Forced skipping of method Windows.Graphics.Imaging.BitmapCodecInformation.FriendlyName.get
		// Forced skipping of method Windows.Graphics.Imaging.BitmapCodecInformation.MimeTypes.get
	}
}
