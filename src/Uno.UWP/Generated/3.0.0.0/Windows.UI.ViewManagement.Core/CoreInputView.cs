#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.ViewManagement.Core
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class CoreInputView 
	{
		// Forced skipping of method Windows.UI.ViewManagement.Core.CoreInputView.OcclusionsChanged.add
		// Forced skipping of method Windows.UI.ViewManagement.Core.CoreInputView.OcclusionsChanged.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.UI.ViewManagement.Core.CoreInputViewOcclusion> GetCoreInputViewOcclusions()
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<CoreInputViewOcclusion> CoreInputView.GetCoreInputViewOcclusions() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CCoreInputViewOcclusion%3E%20CoreInputView.GetCoreInputViewOcclusions%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool TryShowPrimaryView()
		{
			throw new global::System.NotImplementedException("The member bool CoreInputView.TryShowPrimaryView() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20CoreInputView.TryShowPrimaryView%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool TryHidePrimaryView()
		{
			throw new global::System.NotImplementedException("The member bool CoreInputView.TryHidePrimaryView() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20CoreInputView.TryHidePrimaryView%28%29");
		}
#endif
		// Forced skipping of method Windows.UI.ViewManagement.Core.CoreInputView.XYFocusTransferringFromPrimaryView.add
		// Forced skipping of method Windows.UI.ViewManagement.Core.CoreInputView.XYFocusTransferringFromPrimaryView.remove
		// Forced skipping of method Windows.UI.ViewManagement.Core.CoreInputView.XYFocusTransferredToPrimaryView.add
		// Forced skipping of method Windows.UI.ViewManagement.Core.CoreInputView.XYFocusTransferredToPrimaryView.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool TryTransferXYFocusToPrimaryView( global::Windows.Foundation.Rect origin,  global::Windows.UI.ViewManagement.Core.CoreInputViewXYFocusTransferDirection direction)
		{
			throw new global::System.NotImplementedException("The member bool CoreInputView.TryTransferXYFocusToPrimaryView(Rect origin, CoreInputViewXYFocusTransferDirection direction) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20CoreInputView.TryTransferXYFocusToPrimaryView%28Rect%20origin%2C%20CoreInputViewXYFocusTransferDirection%20direction%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool TryShow()
		{
			throw new global::System.NotImplementedException("The member bool CoreInputView.TryShow() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20CoreInputView.TryShow%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool TryShow( global::Windows.UI.ViewManagement.Core.CoreInputViewKind type)
		{
			throw new global::System.NotImplementedException("The member bool CoreInputView.TryShow(CoreInputViewKind type) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20CoreInputView.TryShow%28CoreInputViewKind%20type%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool TryHide()
		{
			throw new global::System.NotImplementedException("The member bool CoreInputView.TryHide() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20CoreInputView.TryHide%28%29");
		}
#endif
		// Forced skipping of method Windows.UI.ViewManagement.Core.CoreInputView.PrimaryViewShowing.add
		// Forced skipping of method Windows.UI.ViewManagement.Core.CoreInputView.PrimaryViewShowing.remove
		// Forced skipping of method Windows.UI.ViewManagement.Core.CoreInputView.PrimaryViewHiding.add
		// Forced skipping of method Windows.UI.ViewManagement.Core.CoreInputView.PrimaryViewHiding.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsKindSupported( global::Windows.UI.ViewManagement.Core.CoreInputViewKind type)
		{
			throw new global::System.NotImplementedException("The member bool CoreInputView.IsKindSupported(CoreInputViewKind type) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20CoreInputView.IsKindSupported%28CoreInputViewKind%20type%29");
		}
#endif
		// Forced skipping of method Windows.UI.ViewManagement.Core.CoreInputView.SupportedKindsChanged.add
		// Forced skipping of method Windows.UI.ViewManagement.Core.CoreInputView.SupportedKindsChanged.remove
		// Forced skipping of method Windows.UI.ViewManagement.Core.CoreInputView.PrimaryViewAnimationStarting.add
		// Forced skipping of method Windows.UI.ViewManagement.Core.CoreInputView.PrimaryViewAnimationStarting.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.ViewManagement.Core.CoreInputView GetForUIContext( global::Windows.UI.UIContext context)
		{
			throw new global::System.NotImplementedException("The member CoreInputView CoreInputView.GetForUIContext(UIContext context) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=CoreInputView%20CoreInputView.GetForUIContext%28UIContext%20context%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.ViewManagement.Core.CoreInputView GetForCurrentView()
		{
			throw new global::System.NotImplementedException("The member CoreInputView CoreInputView.GetForCurrentView() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=CoreInputView%20CoreInputView.GetForCurrentView%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.ViewManagement.Core.CoreInputView, global::Windows.UI.ViewManagement.Core.CoreInputViewOcclusionsChangedEventArgs> OcclusionsChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.Core.CoreInputView", "event TypedEventHandler<CoreInputView, CoreInputViewOcclusionsChangedEventArgs> CoreInputView.OcclusionsChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.Core.CoreInputView", "event TypedEventHandler<CoreInputView, CoreInputViewOcclusionsChangedEventArgs> CoreInputView.OcclusionsChanged");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.ViewManagement.Core.CoreInputView, object> XYFocusTransferredToPrimaryView
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.Core.CoreInputView", "event TypedEventHandler<CoreInputView, object> CoreInputView.XYFocusTransferredToPrimaryView");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.Core.CoreInputView", "event TypedEventHandler<CoreInputView, object> CoreInputView.XYFocusTransferredToPrimaryView");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.ViewManagement.Core.CoreInputView, global::Windows.UI.ViewManagement.Core.CoreInputViewTransferringXYFocusEventArgs> XYFocusTransferringFromPrimaryView
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.Core.CoreInputView", "event TypedEventHandler<CoreInputView, CoreInputViewTransferringXYFocusEventArgs> CoreInputView.XYFocusTransferringFromPrimaryView");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.Core.CoreInputView", "event TypedEventHandler<CoreInputView, CoreInputViewTransferringXYFocusEventArgs> CoreInputView.XYFocusTransferringFromPrimaryView");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.ViewManagement.Core.CoreInputView, global::Windows.UI.ViewManagement.Core.CoreInputViewHidingEventArgs> PrimaryViewHiding
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.Core.CoreInputView", "event TypedEventHandler<CoreInputView, CoreInputViewHidingEventArgs> CoreInputView.PrimaryViewHiding");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.Core.CoreInputView", "event TypedEventHandler<CoreInputView, CoreInputViewHidingEventArgs> CoreInputView.PrimaryViewHiding");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.ViewManagement.Core.CoreInputView, global::Windows.UI.ViewManagement.Core.CoreInputViewShowingEventArgs> PrimaryViewShowing
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.Core.CoreInputView", "event TypedEventHandler<CoreInputView, CoreInputViewShowingEventArgs> CoreInputView.PrimaryViewShowing");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.Core.CoreInputView", "event TypedEventHandler<CoreInputView, CoreInputViewShowingEventArgs> CoreInputView.PrimaryViewShowing");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.ViewManagement.Core.CoreInputView, global::Windows.UI.ViewManagement.Core.CoreInputViewAnimationStartingEventArgs> PrimaryViewAnimationStarting
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.Core.CoreInputView", "event TypedEventHandler<CoreInputView, CoreInputViewAnimationStartingEventArgs> CoreInputView.PrimaryViewAnimationStarting");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.Core.CoreInputView", "event TypedEventHandler<CoreInputView, CoreInputViewAnimationStartingEventArgs> CoreInputView.PrimaryViewAnimationStarting");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.ViewManagement.Core.CoreInputView, object> SupportedKindsChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.Core.CoreInputView", "event TypedEventHandler<CoreInputView, object> CoreInputView.SupportedKindsChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.Core.CoreInputView", "event TypedEventHandler<CoreInputView, object> CoreInputView.SupportedKindsChanged");
			}
		}
#endif
	}
}
