#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Sockets
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class SocketActivityContext 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Streams.IBuffer Data
		{
			get
			{
				throw new global::System.NotImplementedException("The member IBuffer SocketActivityContext.Data is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IBuffer%20SocketActivityContext.Data");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public SocketActivityContext( global::Windows.Storage.Streams.IBuffer data) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.Sockets.SocketActivityContext", "SocketActivityContext.SocketActivityContext(IBuffer data)");
		}
#endif
		// Forced skipping of method Windows.Networking.Sockets.SocketActivityContext.SocketActivityContext(Windows.Storage.Streams.IBuffer)
		// Forced skipping of method Windows.Networking.Sockets.SocketActivityContext.Data.get
	}
}
