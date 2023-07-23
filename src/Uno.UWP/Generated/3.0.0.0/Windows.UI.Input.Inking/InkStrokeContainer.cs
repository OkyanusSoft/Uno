#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input.Inking
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public  partial class InkStrokeContainer : global::Windows.UI.Input.Inking.IInkStrokeContainer
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Rect BoundingRect
		{
			get
			{
				throw new global::System.NotImplementedException("The member Rect InkStrokeContainer.BoundingRect is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Rect%20InkStrokeContainer.BoundingRect");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public InkStrokeContainer() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Input.Inking.InkStrokeContainer", "InkStrokeContainer.InkStrokeContainer()");
		}
#endif
		// Forced skipping of method Windows.UI.Input.Inking.InkStrokeContainer.InkStrokeContainer()
		// Forced skipping of method Windows.UI.Input.Inking.InkStrokeContainer.BoundingRect.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void AddStroke( global::Windows.UI.Input.Inking.InkStroke stroke)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Input.Inking.InkStrokeContainer", "void InkStrokeContainer.AddStroke(InkStroke stroke)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Rect DeleteSelected()
		{
			throw new global::System.NotImplementedException("The member Rect InkStrokeContainer.DeleteSelected() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Rect%20InkStrokeContainer.DeleteSelected%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Rect MoveSelected( global::Windows.Foundation.Point translation)
		{
			throw new global::System.NotImplementedException("The member Rect InkStrokeContainer.MoveSelected(Point translation) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Rect%20InkStrokeContainer.MoveSelected%28Point%20translation%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Rect SelectWithPolyLine( global::System.Collections.Generic.IEnumerable<global::Windows.Foundation.Point> polyline)
		{
			throw new global::System.NotImplementedException("The member Rect InkStrokeContainer.SelectWithPolyLine(IEnumerable<Point> polyline) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Rect%20InkStrokeContainer.SelectWithPolyLine%28IEnumerable%3CPoint%3E%20polyline%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Rect SelectWithLine( global::Windows.Foundation.Point from,  global::Windows.Foundation.Point to)
		{
			throw new global::System.NotImplementedException("The member Rect InkStrokeContainer.SelectWithLine(Point from, Point to) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Rect%20InkStrokeContainer.SelectWithLine%28Point%20from%2C%20Point%20to%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void CopySelectedToClipboard()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Input.Inking.InkStrokeContainer", "void InkStrokeContainer.CopySelectedToClipboard()");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Rect PasteFromClipboard( global::Windows.Foundation.Point position)
		{
			throw new global::System.NotImplementedException("The member Rect InkStrokeContainer.PasteFromClipboard(Point position) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Rect%20InkStrokeContainer.PasteFromClipboard%28Point%20position%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool CanPasteFromClipboard()
		{
			throw new global::System.NotImplementedException("The member bool InkStrokeContainer.CanPasteFromClipboard() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20InkStrokeContainer.CanPasteFromClipboard%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncActionWithProgress<ulong> LoadAsync( global::Windows.Storage.Streams.IInputStream inputStream)
		{
			throw new global::System.NotImplementedException("The member IAsyncActionWithProgress<ulong> InkStrokeContainer.LoadAsync(IInputStream inputStream) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncActionWithProgress%3Culong%3E%20InkStrokeContainer.LoadAsync%28IInputStream%20inputStream%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperationWithProgress<uint, uint> SaveAsync( global::Windows.Storage.Streams.IOutputStream outputStream)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperationWithProgress<uint, uint> InkStrokeContainer.SaveAsync(IOutputStream outputStream) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperationWithProgress%3Cuint%2C%20uint%3E%20InkStrokeContainer.SaveAsync%28IOutputStream%20outputStream%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void UpdateRecognitionResults( global::System.Collections.Generic.IReadOnlyList<global::Windows.UI.Input.Inking.InkRecognitionResult> recognitionResults)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Input.Inking.InkStrokeContainer", "void InkStrokeContainer.UpdateRecognitionResults(IReadOnlyList<InkRecognitionResult> recognitionResults)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.UI.Input.Inking.InkStroke> GetStrokes()
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<InkStroke> InkStrokeContainer.GetStrokes() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CInkStroke%3E%20InkStrokeContainer.GetStrokes%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.UI.Input.Inking.InkRecognitionResult> GetRecognitionResults()
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<InkRecognitionResult> InkStrokeContainer.GetRecognitionResults() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CInkRecognitionResult%3E%20InkStrokeContainer.GetRecognitionResults%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void AddStrokes( global::System.Collections.Generic.IEnumerable<global::Windows.UI.Input.Inking.InkStroke> strokes)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Input.Inking.InkStrokeContainer", "void InkStrokeContainer.AddStrokes(IEnumerable<InkStroke> strokes)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Clear()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Input.Inking.InkStrokeContainer", "void InkStrokeContainer.Clear()");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperationWithProgress<uint, uint> SaveAsync( global::Windows.Storage.Streams.IOutputStream outputStream,  global::Windows.UI.Input.Inking.InkPersistenceFormat inkPersistenceFormat)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperationWithProgress<uint, uint> InkStrokeContainer.SaveAsync(IOutputStream outputStream, InkPersistenceFormat inkPersistenceFormat) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperationWithProgress%3Cuint%2C%20uint%3E%20InkStrokeContainer.SaveAsync%28IOutputStream%20outputStream%2C%20InkPersistenceFormat%20inkPersistenceFormat%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Input.Inking.InkStroke GetStrokeById( uint id)
		{
			throw new global::System.NotImplementedException("The member InkStroke InkStrokeContainer.GetStrokeById(uint id) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=InkStroke%20InkStrokeContainer.GetStrokeById%28uint%20id%29");
		}
#endif
		// Processing: Windows.UI.Input.Inking.IInkStrokeContainer
	}
}
