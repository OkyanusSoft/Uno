#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Enumeration.Pnp
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class PnpObject 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Id
		{
			get
			{
				throw new global::System.NotImplementedException("The member string PnpObject.Id is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20PnpObject.Id");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyDictionary<string, object> Properties
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyDictionary<string, object> PnpObject.Properties is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyDictionary%3Cstring%2C%20object%3E%20PnpObject.Properties");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Enumeration.Pnp.PnpObjectType Type
		{
			get
			{
				throw new global::System.NotImplementedException("The member PnpObjectType PnpObject.Type is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PnpObjectType%20PnpObject.Type");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.Enumeration.Pnp.PnpObject.Type.get
		// Forced skipping of method Windows.Devices.Enumeration.Pnp.PnpObject.Id.get
		// Forced skipping of method Windows.Devices.Enumeration.Pnp.PnpObject.Properties.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Update( global::Windows.Devices.Enumeration.Pnp.PnpObjectUpdate updateInfo)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Enumeration.Pnp.PnpObject", "void PnpObject.Update(PnpObjectUpdate updateInfo)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Enumeration.Pnp.PnpObject> CreateFromIdAsync( global::Windows.Devices.Enumeration.Pnp.PnpObjectType type,  string id,  global::System.Collections.Generic.IEnumerable<string> requestedProperties)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<PnpObject> PnpObject.CreateFromIdAsync(PnpObjectType type, string id, IEnumerable<string> requestedProperties) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CPnpObject%3E%20PnpObject.CreateFromIdAsync%28PnpObjectType%20type%2C%20string%20id%2C%20IEnumerable%3Cstring%3E%20requestedProperties%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Enumeration.Pnp.PnpObjectCollection> FindAllAsync( global::Windows.Devices.Enumeration.Pnp.PnpObjectType type,  global::System.Collections.Generic.IEnumerable<string> requestedProperties)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<PnpObjectCollection> PnpObject.FindAllAsync(PnpObjectType type, IEnumerable<string> requestedProperties) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CPnpObjectCollection%3E%20PnpObject.FindAllAsync%28PnpObjectType%20type%2C%20IEnumerable%3Cstring%3E%20requestedProperties%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Enumeration.Pnp.PnpObjectCollection> FindAllAsync( global::Windows.Devices.Enumeration.Pnp.PnpObjectType type,  global::System.Collections.Generic.IEnumerable<string> requestedProperties,  string aqsFilter)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<PnpObjectCollection> PnpObject.FindAllAsync(PnpObjectType type, IEnumerable<string> requestedProperties, string aqsFilter) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CPnpObjectCollection%3E%20PnpObject.FindAllAsync%28PnpObjectType%20type%2C%20IEnumerable%3Cstring%3E%20requestedProperties%2C%20string%20aqsFilter%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Devices.Enumeration.Pnp.PnpObjectWatcher CreateWatcher( global::Windows.Devices.Enumeration.Pnp.PnpObjectType type,  global::System.Collections.Generic.IEnumerable<string> requestedProperties)
		{
			throw new global::System.NotImplementedException("The member PnpObjectWatcher PnpObject.CreateWatcher(PnpObjectType type, IEnumerable<string> requestedProperties) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PnpObjectWatcher%20PnpObject.CreateWatcher%28PnpObjectType%20type%2C%20IEnumerable%3Cstring%3E%20requestedProperties%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Devices.Enumeration.Pnp.PnpObjectWatcher CreateWatcher( global::Windows.Devices.Enumeration.Pnp.PnpObjectType type,  global::System.Collections.Generic.IEnumerable<string> requestedProperties,  string aqsFilter)
		{
			throw new global::System.NotImplementedException("The member PnpObjectWatcher PnpObject.CreateWatcher(PnpObjectType type, IEnumerable<string> requestedProperties, string aqsFilter) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PnpObjectWatcher%20PnpObject.CreateWatcher%28PnpObjectType%20type%2C%20IEnumerable%3Cstring%3E%20requestedProperties%2C%20string%20aqsFilter%29");
		}
#endif
	}
}
