#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Authentication.OnlineId
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class OnlineIdSystemIdentity 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Id
		{
			get
			{
				throw new global::System.NotImplementedException("The member string OnlineIdSystemIdentity.Id is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20OnlineIdSystemIdentity.Id");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Security.Authentication.OnlineId.OnlineIdServiceTicket Ticket
		{
			get
			{
				throw new global::System.NotImplementedException("The member OnlineIdServiceTicket OnlineIdSystemIdentity.Ticket is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=OnlineIdServiceTicket%20OnlineIdSystemIdentity.Ticket");
			}
		}
#endif
		// Forced skipping of method Windows.Security.Authentication.OnlineId.OnlineIdSystemIdentity.Ticket.get
		// Forced skipping of method Windows.Security.Authentication.OnlineId.OnlineIdSystemIdentity.Id.get
	}
}
