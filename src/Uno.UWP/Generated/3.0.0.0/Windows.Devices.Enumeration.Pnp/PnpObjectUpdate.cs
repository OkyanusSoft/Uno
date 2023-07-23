#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Enumeration.Pnp
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class PnpObjectUpdate 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Id
		{
			get
			{
				throw new global::System.NotImplementedException("The member string PnpObjectUpdate.Id is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20PnpObjectUpdate.Id");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyDictionary<string, object> Properties
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyDictionary<string, object> PnpObjectUpdate.Properties is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyDictionary%3Cstring%2C%20object%3E%20PnpObjectUpdate.Properties");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Enumeration.Pnp.PnpObjectType Type
		{
			get
			{
				throw new global::System.NotImplementedException("The member PnpObjectType PnpObjectUpdate.Type is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PnpObjectType%20PnpObjectUpdate.Type");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.Enumeration.Pnp.PnpObjectUpdate.Type.get
		// Forced skipping of method Windows.Devices.Enumeration.Pnp.PnpObjectUpdate.Id.get
		// Forced skipping of method Windows.Devices.Enumeration.Pnp.PnpObjectUpdate.Properties.get
	}
}
