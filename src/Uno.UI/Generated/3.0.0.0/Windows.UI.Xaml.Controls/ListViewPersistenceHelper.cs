#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class ListViewPersistenceHelper 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string GetRelativeScrollPosition( global::Windows.UI.Xaml.Controls.ListViewBase listViewBase,  global::Windows.UI.Xaml.Controls.ListViewItemToKeyHandler itemToKeyHandler)
		{
			throw new global::System.NotImplementedException("The member string ListViewPersistenceHelper.GetRelativeScrollPosition(ListViewBase listViewBase, ListViewItemToKeyHandler itemToKeyHandler) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20ListViewPersistenceHelper.GetRelativeScrollPosition%28ListViewBase%20listViewBase%2C%20ListViewItemToKeyHandler%20itemToKeyHandler%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction SetRelativeScrollPositionAsync( global::Windows.UI.Xaml.Controls.ListViewBase listViewBase,  string relativeScrollPosition,  global::Windows.UI.Xaml.Controls.ListViewKeyToItemHandler keyToItemHandler)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ListViewPersistenceHelper.SetRelativeScrollPositionAsync(ListViewBase listViewBase, string relativeScrollPosition, ListViewKeyToItemHandler keyToItemHandler) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20ListViewPersistenceHelper.SetRelativeScrollPositionAsync%28ListViewBase%20listViewBase%2C%20string%20relativeScrollPosition%2C%20ListViewKeyToItemHandler%20keyToItemHandler%29");
		}
#endif
	}
}
