#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Appointments
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class AppointmentConflictResult 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.DateTimeOffset Date
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset AppointmentConflictResult.Date is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DateTimeOffset%20AppointmentConflictResult.Date");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Appointments.AppointmentConflictType Type
		{
			get
			{
				throw new global::System.NotImplementedException("The member AppointmentConflictType AppointmentConflictResult.Type is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AppointmentConflictType%20AppointmentConflictResult.Type");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Appointments.AppointmentConflictResult.Type.get
		// Forced skipping of method Windows.ApplicationModel.Appointments.AppointmentConflictResult.Date.get
	}
}
