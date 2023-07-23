#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Payments
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class PaymentRequest 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Payments.PaymentDetails Details
		{
			get
			{
				throw new global::System.NotImplementedException("The member PaymentDetails PaymentRequest.Details is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PaymentDetails%20PaymentRequest.Details");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Payments.PaymentMerchantInfo MerchantInfo
		{
			get
			{
				throw new global::System.NotImplementedException("The member PaymentMerchantInfo PaymentRequest.MerchantInfo is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PaymentMerchantInfo%20PaymentRequest.MerchantInfo");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Payments.PaymentMethodData> MethodData
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<PaymentMethodData> PaymentRequest.MethodData is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CPaymentMethodData%3E%20PaymentRequest.MethodData");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Payments.PaymentOptions Options
		{
			get
			{
				throw new global::System.NotImplementedException("The member PaymentOptions PaymentRequest.Options is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PaymentOptions%20PaymentRequest.Options");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Id
		{
			get
			{
				throw new global::System.NotImplementedException("The member string PaymentRequest.Id is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20PaymentRequest.Id");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public PaymentRequest( global::Windows.ApplicationModel.Payments.PaymentDetails details,  global::System.Collections.Generic.IEnumerable<global::Windows.ApplicationModel.Payments.PaymentMethodData> methodData,  global::Windows.ApplicationModel.Payments.PaymentMerchantInfo merchantInfo,  global::Windows.ApplicationModel.Payments.PaymentOptions options,  string id) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Payments.PaymentRequest", "PaymentRequest.PaymentRequest(PaymentDetails details, IEnumerable<PaymentMethodData> methodData, PaymentMerchantInfo merchantInfo, PaymentOptions options, string id)");
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Payments.PaymentRequest.PaymentRequest(Windows.ApplicationModel.Payments.PaymentDetails, System.Collections.Generic.IEnumerable<Windows.ApplicationModel.Payments.PaymentMethodData>, Windows.ApplicationModel.Payments.PaymentMerchantInfo, Windows.ApplicationModel.Payments.PaymentOptions, string)
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public PaymentRequest( global::Windows.ApplicationModel.Payments.PaymentDetails details,  global::System.Collections.Generic.IEnumerable<global::Windows.ApplicationModel.Payments.PaymentMethodData> methodData) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Payments.PaymentRequest", "PaymentRequest.PaymentRequest(PaymentDetails details, IEnumerable<PaymentMethodData> methodData)");
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Payments.PaymentRequest.PaymentRequest(Windows.ApplicationModel.Payments.PaymentDetails, System.Collections.Generic.IEnumerable<Windows.ApplicationModel.Payments.PaymentMethodData>)
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public PaymentRequest( global::Windows.ApplicationModel.Payments.PaymentDetails details,  global::System.Collections.Generic.IEnumerable<global::Windows.ApplicationModel.Payments.PaymentMethodData> methodData,  global::Windows.ApplicationModel.Payments.PaymentMerchantInfo merchantInfo) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Payments.PaymentRequest", "PaymentRequest.PaymentRequest(PaymentDetails details, IEnumerable<PaymentMethodData> methodData, PaymentMerchantInfo merchantInfo)");
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Payments.PaymentRequest.PaymentRequest(Windows.ApplicationModel.Payments.PaymentDetails, System.Collections.Generic.IEnumerable<Windows.ApplicationModel.Payments.PaymentMethodData>, Windows.ApplicationModel.Payments.PaymentMerchantInfo)
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public PaymentRequest( global::Windows.ApplicationModel.Payments.PaymentDetails details,  global::System.Collections.Generic.IEnumerable<global::Windows.ApplicationModel.Payments.PaymentMethodData> methodData,  global::Windows.ApplicationModel.Payments.PaymentMerchantInfo merchantInfo,  global::Windows.ApplicationModel.Payments.PaymentOptions options) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Payments.PaymentRequest", "PaymentRequest.PaymentRequest(PaymentDetails details, IEnumerable<PaymentMethodData> methodData, PaymentMerchantInfo merchantInfo, PaymentOptions options)");
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Payments.PaymentRequest.PaymentRequest(Windows.ApplicationModel.Payments.PaymentDetails, System.Collections.Generic.IEnumerable<Windows.ApplicationModel.Payments.PaymentMethodData>, Windows.ApplicationModel.Payments.PaymentMerchantInfo, Windows.ApplicationModel.Payments.PaymentOptions)
		// Forced skipping of method Windows.ApplicationModel.Payments.PaymentRequest.MerchantInfo.get
		// Forced skipping of method Windows.ApplicationModel.Payments.PaymentRequest.Details.get
		// Forced skipping of method Windows.ApplicationModel.Payments.PaymentRequest.MethodData.get
		// Forced skipping of method Windows.ApplicationModel.Payments.PaymentRequest.Options.get
		// Forced skipping of method Windows.ApplicationModel.Payments.PaymentRequest.Id.get
	}
}
