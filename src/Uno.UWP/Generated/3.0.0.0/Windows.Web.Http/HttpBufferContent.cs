#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Web.Http
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class HttpBufferContent : global::Windows.Web.Http.IHttpContent,global::System.IDisposable,global::Windows.Foundation.IStringable
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Web.Http.Headers.HttpContentHeaderCollection Headers
		{
			get
			{
				throw new global::System.NotImplementedException("The member HttpContentHeaderCollection HttpBufferContent.Headers is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=HttpContentHeaderCollection%20HttpBufferContent.Headers");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public HttpBufferContent( global::Windows.Storage.Streams.IBuffer content) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Web.Http.HttpBufferContent", "HttpBufferContent.HttpBufferContent(IBuffer content)");
		}
#endif
		// Forced skipping of method Windows.Web.Http.HttpBufferContent.HttpBufferContent(Windows.Storage.Streams.IBuffer)
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public HttpBufferContent( global::Windows.Storage.Streams.IBuffer content,  uint offset,  uint count) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Web.Http.HttpBufferContent", "HttpBufferContent.HttpBufferContent(IBuffer content, uint offset, uint count)");
		}
#endif
		// Forced skipping of method Windows.Web.Http.HttpBufferContent.HttpBufferContent(Windows.Storage.Streams.IBuffer, uint, uint)
		// Forced skipping of method Windows.Web.Http.HttpBufferContent.Headers.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperationWithProgress<ulong, ulong> BufferAllAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperationWithProgress<ulong, ulong> HttpBufferContent.BufferAllAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperationWithProgress%3Culong%2C%20ulong%3E%20HttpBufferContent.BufferAllAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperationWithProgress<global::Windows.Storage.Streams.IBuffer, ulong> ReadAsBufferAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperationWithProgress<IBuffer, ulong> HttpBufferContent.ReadAsBufferAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperationWithProgress%3CIBuffer%2C%20ulong%3E%20HttpBufferContent.ReadAsBufferAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperationWithProgress<global::Windows.Storage.Streams.IInputStream, ulong> ReadAsInputStreamAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperationWithProgress<IInputStream, ulong> HttpBufferContent.ReadAsInputStreamAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperationWithProgress%3CIInputStream%2C%20ulong%3E%20HttpBufferContent.ReadAsInputStreamAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperationWithProgress<string, ulong> ReadAsStringAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperationWithProgress<string, ulong> HttpBufferContent.ReadAsStringAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperationWithProgress%3Cstring%2C%20ulong%3E%20HttpBufferContent.ReadAsStringAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool TryComputeLength(out ulong length)
		{
			throw new global::System.NotImplementedException("The member bool HttpBufferContent.TryComputeLength(out ulong length) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20HttpBufferContent.TryComputeLength%28out%20ulong%20length%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperationWithProgress<ulong, ulong> WriteToStreamAsync( global::Windows.Storage.Streams.IOutputStream outputStream)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperationWithProgress<ulong, ulong> HttpBufferContent.WriteToStreamAsync(IOutputStream outputStream) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperationWithProgress%3Culong%2C%20ulong%3E%20HttpBufferContent.WriteToStreamAsync%28IOutputStream%20outputStream%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Web.Http.HttpBufferContent", "void HttpBufferContent.Dispose()");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public override string ToString()
		{
			throw new global::System.NotImplementedException("The member string HttpBufferContent.ToString() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20HttpBufferContent.ToString%28%29");
		}
#endif
		// Processing: Windows.Web.Http.IHttpContent
		// Processing: System.IDisposable
	}
}
