#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.Profile
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public static partial class EducationSettings 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool IsEducationEnvironment
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool EducationSettings.IsEducationEnvironment is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20EducationSettings.IsEducationEnvironment");
			}
		}
#endif
		// Forced skipping of method Windows.System.Profile.EducationSettings.IsEducationEnvironment.get
	}
}
