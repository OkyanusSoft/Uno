#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.Diagnostics.DevicePortal
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class DevicePortalConnectionRequestReceivedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Web.Http.HttpRequestMessage RequestMessage
		{
			get
			{
				throw new global::System.NotImplementedException("The member HttpRequestMessage DevicePortalConnectionRequestReceivedEventArgs.RequestMessage is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=HttpRequestMessage%20DevicePortalConnectionRequestReceivedEventArgs.RequestMessage");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Web.Http.HttpResponseMessage ResponseMessage
		{
			get
			{
				throw new global::System.NotImplementedException("The member HttpResponseMessage DevicePortalConnectionRequestReceivedEventArgs.ResponseMessage is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=HttpResponseMessage%20DevicePortalConnectionRequestReceivedEventArgs.ResponseMessage");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsWebSocketUpgradeRequest
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool DevicePortalConnectionRequestReceivedEventArgs.IsWebSocketUpgradeRequest is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20DevicePortalConnectionRequestReceivedEventArgs.IsWebSocketUpgradeRequest");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<string> WebSocketProtocolsRequested
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<string> DevicePortalConnectionRequestReceivedEventArgs.WebSocketProtocolsRequested is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3Cstring%3E%20DevicePortalConnectionRequestReceivedEventArgs.WebSocketProtocolsRequested");
			}
		}
#endif
		// Forced skipping of method Windows.System.Diagnostics.DevicePortal.DevicePortalConnectionRequestReceivedEventArgs.RequestMessage.get
		// Forced skipping of method Windows.System.Diagnostics.DevicePortal.DevicePortalConnectionRequestReceivedEventArgs.ResponseMessage.get
		// Forced skipping of method Windows.System.Diagnostics.DevicePortal.DevicePortalConnectionRequestReceivedEventArgs.IsWebSocketUpgradeRequest.get
		// Forced skipping of method Windows.System.Diagnostics.DevicePortal.DevicePortalConnectionRequestReceivedEventArgs.WebSocketProtocolsRequested.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral DevicePortalConnectionRequestReceivedEventArgs.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Deferral%20DevicePortalConnectionRequestReceivedEventArgs.GetDeferral%28%29");
		}
#endif
	}
}
