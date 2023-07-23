#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Sockets
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class WebSocketClosedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  ushort Code
		{
			get
			{
				throw new global::System.NotImplementedException("The member ushort WebSocketClosedEventArgs.Code is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ushort%20WebSocketClosedEventArgs.Code");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Reason
		{
			get
			{
				throw new global::System.NotImplementedException("The member string WebSocketClosedEventArgs.Reason is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20WebSocketClosedEventArgs.Reason");
			}
		}
#endif
		// Forced skipping of method Windows.Networking.Sockets.WebSocketClosedEventArgs.Code.get
		// Forced skipping of method Windows.Networking.Sockets.WebSocketClosedEventArgs.Reason.get
	}
}
