#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.UserProfile
{
#if false || false || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
#endif
	public static partial class GlobalizationPreferences 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Collections.Generic.IReadOnlyList<string> Calendars
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<string> GlobalizationPreferences.Calendars is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3Cstring%3E%20GlobalizationPreferences.Calendars");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Collections.Generic.IReadOnlyList<string> Clocks
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<string> GlobalizationPreferences.Clocks is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3Cstring%3E%20GlobalizationPreferences.Clocks");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Collections.Generic.IReadOnlyList<string> Currencies
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<string> GlobalizationPreferences.Currencies is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3Cstring%3E%20GlobalizationPreferences.Currencies");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string HomeGeographicRegion
		{
			get
			{
				throw new global::System.NotImplementedException("The member string GlobalizationPreferences.HomeGeographicRegion is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20GlobalizationPreferences.HomeGeographicRegion");
			}
		}
#endif
#if false || false || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Collections.Generic.IReadOnlyList<string> Languages
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<string> GlobalizationPreferences.Languages is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3Cstring%3E%20GlobalizationPreferences.Languages");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Globalization.DayOfWeek WeekStartsOn
		{
			get
			{
				throw new global::System.NotImplementedException("The member DayOfWeek GlobalizationPreferences.WeekStartsOn is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DayOfWeek%20GlobalizationPreferences.WeekStartsOn");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.System.UserProfile.GlobalizationPreferencesForUser GetForUser( global::Windows.System.User user)
		{
			throw new global::System.NotImplementedException("The member GlobalizationPreferencesForUser GlobalizationPreferences.GetForUser(User user) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=GlobalizationPreferencesForUser%20GlobalizationPreferences.GetForUser%28User%20user%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool TrySetHomeGeographicRegion( string region)
		{
			throw new global::System.NotImplementedException("The member bool GlobalizationPreferences.TrySetHomeGeographicRegion(string region) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20GlobalizationPreferences.TrySetHomeGeographicRegion%28string%20region%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool TrySetLanguages( global::System.Collections.Generic.IEnumerable<string> languageTags)
		{
			throw new global::System.NotImplementedException("The member bool GlobalizationPreferences.TrySetLanguages(IEnumerable<string> languageTags) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20GlobalizationPreferences.TrySetLanguages%28IEnumerable%3Cstring%3E%20languageTags%29");
		}
#endif
		// Forced skipping of method Windows.System.UserProfile.GlobalizationPreferences.Calendars.get
		// Forced skipping of method Windows.System.UserProfile.GlobalizationPreferences.Clocks.get
		// Forced skipping of method Windows.System.UserProfile.GlobalizationPreferences.Currencies.get
		// Forced skipping of method Windows.System.UserProfile.GlobalizationPreferences.Languages.get
		// Forced skipping of method Windows.System.UserProfile.GlobalizationPreferences.HomeGeographicRegion.get
		// Forced skipping of method Windows.System.UserProfile.GlobalizationPreferences.WeekStartsOn.get
	}
}
