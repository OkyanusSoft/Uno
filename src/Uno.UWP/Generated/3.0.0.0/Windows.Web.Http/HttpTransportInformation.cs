#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Web.Http
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class HttpTransportInformation : global::Windows.Foundation.IStringable
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Security.Cryptography.Certificates.Certificate ServerCertificate
		{
			get
			{
				throw new global::System.NotImplementedException("The member Certificate HttpTransportInformation.ServerCertificate is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Certificate%20HttpTransportInformation.ServerCertificate");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.Sockets.SocketSslErrorSeverity ServerCertificateErrorSeverity
		{
			get
			{
				throw new global::System.NotImplementedException("The member SocketSslErrorSeverity HttpTransportInformation.ServerCertificateErrorSeverity is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SocketSslErrorSeverity%20HttpTransportInformation.ServerCertificateErrorSeverity");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Security.Cryptography.Certificates.ChainValidationResult> ServerCertificateErrors
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<ChainValidationResult> HttpTransportInformation.ServerCertificateErrors is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CChainValidationResult%3E%20HttpTransportInformation.ServerCertificateErrors");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Security.Cryptography.Certificates.Certificate> ServerIntermediateCertificates
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<Certificate> HttpTransportInformation.ServerIntermediateCertificates is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CCertificate%3E%20HttpTransportInformation.ServerIntermediateCertificates");
			}
		}
#endif
		// Forced skipping of method Windows.Web.Http.HttpTransportInformation.ServerCertificate.get
		// Forced skipping of method Windows.Web.Http.HttpTransportInformation.ServerCertificateErrorSeverity.get
		// Forced skipping of method Windows.Web.Http.HttpTransportInformation.ServerCertificateErrors.get
		// Forced skipping of method Windows.Web.Http.HttpTransportInformation.ServerIntermediateCertificates.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public override string ToString()
		{
			throw new global::System.NotImplementedException("The member string HttpTransportInformation.ToString() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20HttpTransportInformation.ToString%28%29");
		}
#endif
	}
}
