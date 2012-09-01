using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.CoreAnimation;
using MonoTouch.MediaPlayer;

namespace AlexTouch.PSPDFKit
{
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     PointF Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://docs.xamarin.com/ios/advanced_topics/binding_objective-c_types
	//
	
	//////////////////////////////
	////	PSPDFKitGlobal.h	//
	//////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFHangDetector 
	{
		[Static, Export ("startHangDetector")]
		void StartHangDetector ();
	}
	
	//////////////////////////////
	////	PSPDFGlobalLock.h	//
	//////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFGlobalLock 
	{
		[Static, Export ("sharedGlobalLock")]
		PSPDFGlobalLock SharedGlobalLock ();
		
		//TODO: Check if this works
		//		[Export ("tryLockWithDocument:page:error:")][Internal]
		//		CGPDFPage TryLockWithDocumentPageError_ (PSPDFDocument document, uint page, out NSError error);
		
		//		[Export ("lockWithDocument:page:error:")]
		//		CGPDFPage LockWithDocumentPageError (PSPDFDocument document, uint page, out NSError error);
		
		//		[Export ("freeWithPDFPageRef:")]
		//		void FreeWithPDFPageRef(CGPDFPage pdfPage);
		
		[Export("lockGlobal")]
		void LockGlobal();
		
		[Export("unlockGlobal")]
		void UnlockGlobal();
		
		[Export("requestClearCacheAndWait:")]
		void RequestClearCacheAndWait(bool wait);
	}
	
	
	//////////////////////////////////
	////	PSPDFViewController.h	//
	//////////////////////////////////
	
	[BaseType (typeof (PSPDFBaseViewController),
	Delegates=new string [] {"WeakDelegate"},
	Events=new Type [] { typeof (PSPDFViewControllerDelegate) })]
	interface PSPDFViewController 
	{
		[Export ("initWithDocument:")]
		IntPtr Constructor (PSPDFDocument document);
		
		[Export ("page", ArgumentSemantic.Assign)]
		uint Page { get; }
		
		[Export ("realPage", ArgumentSemantic.Assign)]
		uint RealPage { get; }
		
		[Export("setPage:animated:")]
		bool SetPageAnimated(uint page, bool animated);
		
		[Export("scrollToNextPageAnimated:")]
		bool ScrollToNextPageAnimated(bool animated);
		
		[Export("scrollToPreviousPageAnimated:")]
		bool ScrollToPreviousPageAnimated(bool animated);
		
		[Export("scrollRectToVisible:animated:")]
		void ScrollRectToVisibleAnimated(RectangleF rec, bool animated);
		
		[Export("zoomToRect:animated:")]
		void ZoomToRectAnimated(RectangleF rec, bool animated);
		
		[Export ("viewState")]
		PSPDFViewState ViewState { get; set; }
		
		[Export("setViewState:animated:")]
		void SetViewStateAnimated(PSPDFViewState viewState, bool animated);
		
		//
		//	- (IBAction)reloadData; -> Omited!!
		//	This method must be called from MonoTouch App Project like this
		//
		//	[Export ("reloadData")]
		//	public void ReloadData () {
		//		//reloadData funky code goes here
		//	}
		//	---------- o ----------- o ----------- o ---------- o ----------
		//	Experimental binding of reloadData 
		//	WebRef: http://stackoverflow.com/questions/5117960/monotouch-create-iboutlet-and-actions-programatically
		//	TODO: Verify if this worked if ever needed
		//
		[Export ("reloadData")]
		void ReloadData();
		
		[Export("searchForString:animated:")]
		void SearchForStringAnimated(string searchText, bool animated);
		
		[Export ("renderContentOpacity", ArgumentSemantic.Assign)]
		float RenderContentOpacity { get; set; }
		
		[Export ("renderBackgroundColor")]
		UIColor RenderBackgroundColor { get; set; }
		
		[Export ("renderInvertEnabled", ArgumentSemantic.Assign)]
		bool RenderInvertEnabled { get; set; }
		
		[Export ("HUDView")]
		PSPDFHUDView HUDView { get; }
		
		[Export ("HUDViewMode", ArgumentSemantic.Assign)]
		PSPDFHUDViewMode HUDViewMode { get; set; }
		
		[Export ("HUDVisible", ArgumentSemantic.Assign)]
		bool HUDVisible { [Bind ("isHUDVisible")] get; set; }
		
		[Export("setHUDVisible:animated:")]
		void SetHUDVisibleAnimated(bool show, bool animated);
		
		[Export("showControls")]
		void ShowControls();
		
		[Export("hideControls")]
		void HideControls();
		
		[Export("hideControlsAndPageElements")]
		void HideControlsAndPageElements();
		
		[Export("toggleControls")]
		void ToggleControls();
		
		[Export ("toolbarEnabled", ArgumentSemantic.Assign)]
		bool ToolbarEnabled { [Bind ("isToolbarEnabled")] get; set; }
		
		[Export ("scrobbleBarEnabled", ArgumentSemantic.Assign)]
		bool ScrobbleBarEnabled { [Bind ("isScrobbleBarEnabled")] get; set; }
		
		[Export ("positionViewEnabled", ArgumentSemantic.Assign)]
		bool PositionViewEnabled { [Bind ("isPositionViewEnabled")] get; set; }
		
		[Export ("renderAnimationEnabled", ArgumentSemantic.Assign)]
		bool RenderAnimationEnabled { [Bind ("isRenderAnimationEnabled")] get; set; }
		
		[Export ("contentView")]
		PSPDFHUDView ContentView { get; }
		
		[Wrap ("WeakDelegate")]
		PSPDFViewControllerDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }
		
		[Export ("document")]
		PSPDFDocument Document { get; set; }
		
		[Export ("margin", ArgumentSemantic.Assign)]
		UIEdgeInsets Margin { get; set; }
		
		[Export ("padding", ArgumentSemantic.Assign)]
		SizeF Padding { get; set; }
		
		[Export ("renderingMode", ArgumentSemantic.Assign)]
		PSPDFPageRenderingMode RenderingMode { get; set; }
		
		[Export ("smartZoomEnabled", ArgumentSemantic.Assign)]
		bool SmartZoomEnabled { [Bind ("isSmartZoomEnabled")] get; set; }
		
		[Export ("scrollingEnabled", ArgumentSemantic.Assign)]
		bool ScrollingEnabled { [Bind ("isScrollingEnabled")] get; set; }
		
		[Export ("viewLockEnabled", ArgumentSemantic.Assign)]
		bool ViewLockEnabled { [Bind ("isViewLockEnabled")] get; set; }
		
		[Export ("rotationLockEnabled", ArgumentSemantic.Assign)]
		bool RotationLockEnabled { [Bind ("isRotationLockEnabled")] get; set; }
		
		[Export ("scrollOnTapPageEndEnabled", ArgumentSemantic.Assign)]
		bool ScrollOnTapPageEndEnabled { [Bind ("isScrollOnTapPageEndEnabled")] get; set; }
		
		[Export ("textSelectionEnabled", ArgumentSemantic.Assign)]
		bool TextSelectionEnabled { [Bind ("isTextSelectionEnabled")] get; set; }
		
		[Export ("useParentNavigationBar", ArgumentSemantic.Assign)]
		bool UseParentNavigationBar { get; set; }
		
		[Export ("linkAction", ArgumentSemantic.Assign)]
		PSPDFLinkAction LinkAction { get; set; }
		
		[Export ("closeButtonItem")]
		PSPDFBarButtonItem CloseButtonItem { get; }
		
		[Export ("outlineButtonItem")]
		PSPDFBarButtonItem OutlineButtonItem { get; }
		
		[Export ("searchButtonItem")]
		PSPDFBarButtonItem searchButtonItem { get; }
		
		[Export ("viewModeButtonItem")]
		PSPDFBarButtonItem ViewModeButtonItem { get; }
		
		[Export ("printButtonItem")]
		PSPDFBarButtonItem PrintButtonItem { get; }
		
		[Export ("openInButtonItem")]
		PSPDFBarButtonItem OpenInButtonItem { get; }
		
		[Export ("emailButtonItem")]
		PSPDFBarButtonItem EmailButtonItem { get; }
		
		[Export ("annotationButtonItem")]
		PSPDFBarButtonItem AnnotationButtonItem { get; }
		
		[Export ("bookmarkButtonItem")]
		PSPDFBarButtonItem BookmarkButtonItem { get; }
		
		[Export ("leftBarButtonItems")]
		PSPDFBarButtonItem [] LeftBarButtonItems { get; set; }
		
		[Export ("rightBarButtonItems")]
		PSPDFBarButtonItem [] RightBarButtonItems { get; set; }
		
		[Export ("additionalRightBarButtonItems")][NullAllowed]
		PSPDFBarButtonItem [] AdditionalRightBarButtonItems { get; set; }
		
		[Export ("barButtonItemsAlwaysEnabled")]
		UIBarButtonItem [] BarButtonItemsAlwaysEnabled { get; set; }
		
		[Export ("minLeftToolbarWidth", ArgumentSemantic.Assign)]
		float MinLeftToolbarWidth { get; set; }
		
		[Export ("minRightToolbarWidth", ArgumentSemantic.Assign)]
		float MinRightToolbarWidth { get; set; }
		
		[Export ("pageMode", ArgumentSemantic.Assign)]
		PSPDFPageMode PageMode { get; set; }
		
		[Export ("pageTransition", ArgumentSemantic.Assign)]
		PSPDFPageTransition PageTransition { get; set; }
		
		[Export ("pageScrolling", ArgumentSemantic.Assign)]
		PSPDFScrollDirection PageScrolling { get; set; }
		
		[Export ("doublePageModeOnFirstPage", ArgumentSemantic.Assign)]
		bool DoublePageModeOnFirstPage { [Bind ("isDoublePageModeOnFirstPage")] get; set; }
		
		[Export ("zoomingSmallDocumentsEnabled", ArgumentSemantic.Assign)]
		bool ZoomingSmallDocumentsEnabled { [Bind ("isZoomingSmallDocumentsEnabled")] get; set; }
		
		[Export ("pageCurlDirectionLeftToRight", ArgumentSemantic.Assign)]
		bool PageCurlDirectionLeftToRight { [Bind ("isPageCurlDirectionLeftToRight")] get; set; }
		
		[Export ("fitToWidthEnabled", ArgumentSemantic.Assign)]
		bool FitToWidthEnabled { [Bind ("isFitToWidthEnabled")] get; set; }
		
		[Export ("fixedVerticalPositionForfitToWidthEnabledMode", ArgumentSemantic.Assign)]
		bool FixedVerticalPositionForfitToWidthEnabledMode { get; set; }
		
		[Export ("clipToPageBoundaries", ArgumentSemantic.Assign)]
		bool ClipToPageBoundaries { get; set; }
		
		[Export ("maximumZoomScale", ArgumentSemantic.Assign)]
		float MaximumZoomScale { get; set; }
		
		[Export ("pagePadding", ArgumentSemantic.Assign)]
		float PagePadding { get; set; }
		
		[Export ("shadowEnabled", ArgumentSemantic.Assign)]
		bool ShadowEnabled { [Bind ("isShadowEnabled")] get; set; }
		
		[Export ("statusBarStyleSetting", ArgumentSemantic.Assign)]
		PSPDFStatusBarStyleSetting StatusBarStyleSetting { get; set; }
		
		[Export ("backgroundColor")]
		UIColor BackgroundColor { get; set; }
		
		[Export ("tintColor")]
		UIColor TintColor { get; set; }
		
		[Export ("isNavigationBarHidden", ArgumentSemantic.Assign)]
		bool NavigationBarHidden { get; }
		
		[Export ("annotationAnimationDuration", ArgumentSemantic.Assign)]
		float AnnotationAnimationDuration { get; set; }
		
		[Export ("pageViewForPage:")][NullAllowed]
		PSPDFPageView PageViewForPage (uint page);
		
		[Export ("popoverController")]
		UIPopoverController PopoverController { get; set; }
		
		[Export ("pagingScrollView")]
		UIScrollView PagingScrollView { get; }
		
		[Export ("viewMode", ArgumentSemantic.Assign)]
		PSPDFViewMode ViewMode { get; set; }
		
		[Export ("setViewMode:animated:")]
		void setViewModeAnimated (PSPDFViewMode viewMode, bool animated);
		
		[Export ("gridView")]
		PSCollectionView GridView { get; }
		
		[Export ("thumbnailSize", ArgumentSemantic.Assign)]
		SizeF ThumbnailSize { get; set; }
		
		[Export ("iPhoneThumbnailSizeReductionFactor", ArgumentSemantic.Assign)]
		float IPhoneThumbnailSizeReductionFactor { get; set; }
		
		[Export ("isDoublePageMode")]
		bool IsDoublePageMode ();
		
		[Export ("isDoublePageModeForOrientation:")]
		bool IsDoublePageModeForOrientation (UIInterfaceOrientation interfaceOrientation);
		
		[Export ("isDoublePageModeForPage:")]
		bool IsDoublePageModeForPage (uint page);
		
		[Export ("isRightPageInDoublePageMode:")]
		bool IsRightPageInDoublePageMode (uint page);
		
		[Export ("presentModalViewController:embeddedInNavigationController:withCloseButton:animated:")]
		void PresentModalViewController (UIViewController controller, bool embedded, bool closeButton, bool animated);
		
		[Export ("visiblePageNumbers")]
		NSNumber [] VisiblePageNumbers { get; }
		
		[Export ("isLastPage")]
		bool IsLastPage { get; }
		
		[Export ("isFirstPage")]
		bool IsFirstPage { get; }
		
		[Export ("masterViewController:")]
		UIViewController MasterViewController ();
		
		//Extension methods SubclassingSupport
		
		[Export ("overrideClassNames")]
		NSDictionary OverrideClassNames { get; set; }
		
		[Bind ("createToolbarAnimated:")]
		bool CreateToolbarAnimated (bool animated);
		
		[Bind ("updateToolbarAnimated:")]
		bool UpdateToolbarAnimated (bool animated);
		
		[Bind ("updateBarButtonItem:animated:")]
		bool UpdateBarButtonItem (UIBarButtonItem barButtonItem, bool animated);
		
		[Bind ("updateGridForOrientation")]
		void UpdateGridForOrientation (bool animated);
		
		[Bind ("statusBarStyle")]
		UIStatusBarStyle statusBarStyle();
		
		[Bind ("clearHighlightedSearchResults")]
		void ClearHighlightedSearchResults();
		
		[Bind ("addHighlightSearchResults:")]
		void AddHighlightSearchResults(PSPDFSearchResult [] searchResults);
		
		[Bind ("animateSearchHighlight:")]
		void AnimateSearchHighlight(PSPDFSearchResult searchResult);
		
		[Export ("pageTransitionController")]
		UIViewController PageTransitionController { get; }
		
		[Bind ("contentRect")]
		RectangleF ContentRect ();
	}
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFStatusBarStyleHint 
	{
		[Export ("preferredStatusBarStyle")]
		UIStatusBarStyle PreferredStatusBarStyle ();
	}
	
	//////////////////////////////////////////
	////		PSPDFSearchResult.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFSearchResult 
	{
		[Export ("document")]
		PSPDFDocument Document { get; set; }
		
		[Export ("pageIndex", ArgumentSemantic.Assign)]
		uint PageIndex { get; set; }
		
		[Export ("previewText", ArgumentSemantic.Copy)]
		string PreviewText { get; set; }
		
		[Export ("selection")]
		PSPDFWord Selection { get; set; }
		
		[Export ("selection", ArgumentSemantic.Assign)]
		NSRange Range { get; set; }
	}
	
	//////////////////////////////////
	////		PSPDFWord.h			//
	//////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFWord 
	{
		[Export ("frame", ArgumentSemantic.Retain)]
		RectangleF Frame { get; set; }
		
		[Export ("glyphs")]
		PSPDFGlyph [] Glyphs { get; set; }
		
		[Export("initWithGlyphs:")]
		IntPtr Constructor (PSPDFGlyph [] wordGlyphs);
		
		[Export("initWithFrame:")]
		IntPtr Constructor (RectangleF wordFrame);
		
		[Export("stringValue")]
		string StringValue ();
		
		[Export("stringValue")]
		string Text { get; }
		
		[Export("isOnSameLineAs:")]
		bool IsOnSameLineAs (PSPDFWord word);
		
		[Export("compareByLayout:")]
		NSComparisonResult CompareByLayout (PSPDFWord word);
	}
	
	//////////////////////////////////////
	////		PSPDFGlyph.h			//
	//////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFGlyph 
	{
		[Export ("frame", ArgumentSemantic.Retain)]
		RectangleF Frame { get; set; }
		
		[Export ("content")]
		string Content { get; set; }
		
		[Export ("font")]
		PSPDFFontInfo Font { get; set; }
		
		[Export ("lineBreaker", ArgumentSemantic.Assign)]
		bool LineBreaker { get; set; }
		
		[Export ("indexOnPage", ArgumentSemantic.Assign)]
		int IndexOnPage { get; set; }
		
		[Export ("compareByXPosition:")]
		NSComparisonResult CompareByXPosition(PSPDFGlyph glyph);
		
		[Export ("isOnSameLineAs:")]
		bool IsOnSameLineAs (PSPDFGlyph glyph);
		
		[Export ("fontHeight", ArgumentSemantic.Assign)]
		float FontHeight { get; }
		
		[Export ("isOnSameLineSegmentAs:")]
		bool IsOnSameLineSegmentAs (PSPDFGlyph glyph);
	}
	
	//////////////////////////////////////
	////		PSPDFFontInfo.h			//
	//////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFFontInfo 
	{	
		[Export ("ascent", ArgumentSemantic.Assign)]
		float Ascent { get; set; }
		
		[Export ("descent", ArgumentSemantic.Assign)]
		float Descent { get; set; }
		
		[Export ("name")]
		string Name { get; set; }
		
		[Export ("encodingArray")]
		NSArray EncodingArray { get; set; }
		
		[Export ("toUnicodeMap")]
		NSMutableDictionary ToUnicodeMap { get; set; }
		
		[Export ("initWithFontDictionary:")][Internal]
		PSPDFFontInfo InitWithFontDictionary_ (IntPtr /*CGPDFDictionary*/ font);
		
		[Export ("widthForCharacter:")]
		float WidthForCharacter (UInt16 c);
		
		[Export ("isMultiByteFont")]
		bool IsMultiByteFont { get; }
		
		[Export ("parseToUnicodeMapWithString:")]
		void ParseToUnicodeMapWithString (string cmapString);
		
		[Static][Export ("glyphNames")]
		NSDictionary GlyphNames ();
		
		[Static][Export ("standardFontWidths")]
		NSDictionary StandardFontWidths ();
	}
	
	//////////////////////////////////////////////
	////	PSPDFViewControllerDelegate.h		//
	//////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFViewControllerDelegate 
	{
		[Export ("pdfViewController:shouldSetDocument:"), DelegateName ("PSPDFViewControllerShouldSetDocument"), DefaultValue (true)]
		bool ShouldSetDocument (PSPDFViewController pdfController, PSPDFDocument document);
		
		[Export ("pdfViewController:willDisplayDocument:"), EventArgs ("PSPDFViewControllerWillDisplayDocument")]
		void WillDisplayDocument (PSPDFViewController pdfController, PSPDFDocument document);
		
		[Export ("pdfViewController:didDisplayDocument:"), EventArgs ("PSPDFViewControllerDidDisplayDocument")]
		void DidDisplayDocument (PSPDFViewController pdfController, PSPDFDocument document);
		
		[Export ("pdfViewController:shouldScrollToPage:"), DelegateName ("PSPDFViewControllerShouldScrollToPage"), DefaultValue (true)]
		bool ShouldScrollToPage (PSPDFViewController pdfController, uint page);
		
		[Export ("pdfViewController:didShowPageView:"), EventArgs ("PSPDFViewControllerDidShowPageView")]
		void DidShowPageView (PSPDFViewController pdfController, PSPDFPageView pageView);
		
		[Export ("pdfViewController:didRenderPageView:"), EventArgs ("PSPDFViewControllerDidRenderPageView")]
		void DidRenderPageView (PSPDFViewController pdfController, PSPDFPageView pageView);
		
		[Export ("pdfViewController:didChangeViewMode:"), EventArgs ("PSPDFViewControllerDidChangeViewMode")]
		void DidChangeViewMode (PSPDFViewController pdfController, PSPDFViewMode viewMode);
		
		[Export ("pdfViewController:didEndPageDragging:willDecelerate:withVelocity:targetContentOffset:"), EventArgs ("PSPDFViewControllerDidEndPageDragging")]
		void DidEndPageDragging (PSPDFViewController pdfController, UIScrollView scrollView, bool decelerate, PointF velocity, ref PointF targetContentOffset);
		
		[Export ("pdfViewController:didEndPageScrollingAnimation:"), EventArgs ("PSPDFViewControllerDidEndPageScrollingAnimation")]
		void DidEndPageScrollingAnimation (PSPDFViewController pdfController, UIScrollView scrollView);

		[Export ("pdfViewController:didEndPageZooming:atScale:"), EventArgs ("PSPDFViewControllerDidEndPageZooming")]
		void DidEndPageZooming (PSPDFViewController pdfController, UIScrollView scrollView, float scale);
		
		[Export ("pdfViewController:documentForRelativePath:"), DelegateName ("PSPDFViewControllerDocumentForRelativePath"), DefaultValue (null)]
		PSPDFDocument DocumentForRelativePath (PSPDFViewController pdfController, string relativePath);
		
		[Export ("pdfViewController:didTapOnPageView:atPoint:"), DelegateName ("PSPDFViewControllerDidTapOnPageView"), DefaultValue (false)]
		bool DidTapOnPageView (PSPDFViewController pdfController, PSPDFPageView pageView, PointF viewPoint);
		
		[Export ("pdfViewController:didLongPressOnPageView:atPoint:gestureRecognizer:"), DelegateName ("PSPDFViewControllerDidLongPressOnPageView"), DefaultValue (false)]
		bool DidLongPressOnPageView (PSPDFViewController pdfController, PSPDFPageView pageView, PointF viewPoint, UILongPressGestureRecognizer gestureRecognizer);
		
		[Export ("pdfViewController:shouldDisplayAnnotation:onPageView:"), DelegateName ("PSPDFViewControllerShouldDisplayAnnotation"), DefaultValue (true)]
		bool ShouldDisplayAnnotation (PSPDFViewController pdfController, PSPDFAnnotation annotation, PSPDFPageView pageView);
		
		[Export ("pdfViewController:didTapOnAnnotation:annotationPoint:annotationView:pageView:viewPoint:"), DelegateName ("PSPDFViewControllerDidTapOnAnnotation"), DefaultValue (false)]
		bool DidTapOnAnnotation (PSPDFViewController pdfController, PSPDFAnnotation annotation, PointF annotationPoint, PSPDFAnnotationView annotationView, PSPDFPageView pageView, PointF viewPoint);
		
		[Export ("pdfViewController:annotationView:forAnnotation:onPageView:"), DelegateName ("PSPDFViewControllerAnnotationViewForAnnotation"), DefaultValueFromArgument ("annotationView")]
		PSPDFAnnotationView AnnotationViewForAnnotation (PSPDFViewController pdfController, PSPDFAnnotationView annotationView, PSPDFAnnotation annotation, PSPDFPageView pageView);
		
		[Export ("pdfViewController:resolveCustomAnnotationPathToken:"), DelegateName ("PSPDFViewControllerResolveCustomAnnotationPathToken"), DefaultValue (null)]
		string ResolveCustomAnnotationPathToken (PSPDFViewController pdfController, string pathToken);
		
		[Export ("pdfViewController:willShowAnnotationView:onPageView:"), EventArgs ("PSPDFViewControllerWillShowAnnotationView")]
		void WillShowAnnotationView (PSPDFViewController pdfController, PSPDFAnnotationView annotationView, PSPDFPageView pageView);
		
		[Export ("pdfViewController:didShowAnnotationView:onPageView:"), EventArgs ("PSPDFViewControllerDidShowAnnotationView")]
		void DidShowAnnotationView (PSPDFViewController pdfController, PSPDFAnnotationView annotationView, PSPDFPageView pageView);

		[Export ("pdfViewController:didLoadPageView:"), EventArgs ("PSPDFViewControllerDidLoadPageView")]
		void DidLoadPageView (PSPDFViewController pdfController, PSPDFPageView pageView);
		
		[Export ("pdfViewController:willUnloadPageView:"), EventArgs ("PSPDFViewControllerWillUnloadPageView")]
		void WillUnloadPageView (PSPDFViewController pdfController, PSPDFPageView pageView);
		
		[Export ("pdfViewController:willShowController:embeddedInController:animated:"), EventArgs ("PSPDFViewControllerWillShowController")]
		void WillShowController (PSPDFViewController pdfController, NSObject viewController, NSObject controller, bool animated);
		
		[Export ("pdfViewController:didShowController:embeddedInController:animated:"), EventArgs ("PSPDFViewControllerDidShowController")]
		void DidShowController (PSPDFViewController pdfController, NSObject viewController, NSObject controller, bool animated);
		
		[Export ("pdfViewController:shouldShowHUD:"), DelegateName ("PSPDFViewControllerShouldShowHUD"), DefaultValue (true)]
		bool ShouldShowHUD (PSPDFViewController pdfController, bool animated);
		
		[Export ("pdfViewController:willShowHUD:"), EventArgs ("PSPDFViewControllerWillShowHUD")]
		void WillShowHUD (PSPDFViewController pdfController, bool animated);
		
		[Export ("pdfViewController:didShowHUD:"), EventArgs ("PSPDFViewControllerDidShowHUD")]
		void DidShowHUD (PSPDFViewController pdfController, bool animated);
		
		[Export ("pdfViewController:shouldHideHUD:"), DelegateName ("PSPDFViewControllerShouldHideHUD"), DefaultValue (true)]
		bool ShouldHideHUD (PSPDFViewController pdfController, bool animated);
		
		[Export ("pdfViewController:willHideHUD:"), EventArgs ("PSPDFViewControllerWillHideHUD")]
		void WillHideHUD (PSPDFViewController pdfController, bool animated);
		
		[Export ("pdfViewController:didHideHUD:"), EventArgs ("PSPDFViewControllerDidHideHUD")]
		void DidHideHUD (PSPDFViewController pdfController, bool animated);
	}
	
	
	
	//////////////////////////////
	////	PSPDFDocument.h		//
	//////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFDocument 
	{
		[Static][Export("PDFDocument")]
		PSPDFDocument PDFDocument ();
		
		[Static][Export("PDFDocumentWithData:")]
		PSPDFDocument PDFDocument (NSData data);
		
		[Static][Export("PDFDocumentWithDataProvider:")][Internal]
		PSPDFDocument PDFDocumentWithDataProvider_ (IntPtr /*CGDataProvider*/ dataProvider);
		
		[Static][Export("PDFDocumentWithBaseURL:files:")]
		PSPDFDocument PDFDocumentWithBaseURL (NSUrl baseURL, NSArray files);
		
		[Static][Export("PDFDocumentWithURL:")]
		PSPDFDocument PDFDocumentWithURL (NSUrl url);
		
		[Export("initWithData:")]
		IntPtr Constructor (NSData data);
		
		[Export("initWithDataProvider:")][Internal]
		PSPDFDocument InitWithDataProvider_ (IntPtr /*CGDataProvider*/ dataProvider);
		
		[Export("initWithURL:")]
		IntPtr Constructor (NSUrl url);
		
		[Export("initWithBaseURL:files:")]
		IntPtr Constructor (NSUrl basePath, NSArray files);
		
		[Export("appendFile:")]
		void AppendFile (string file);
		
		[Export("pathForPage:")]
		NSUrl PathForPage (uint page);
		
		[Export("fileIndexForPage:")]
		int FileIndexForPage (uint page);
		
		[Export("URLForFileIndex:")]
		NSUrl URLForFileIndex (int fileIndex);
		
		[Export("filesWithBasePath")]
		NSArray FilesWithBasePath ();
		
		[Export("basePath")][NullAllowed]
		NSUrl BasePath { get; set; }
		
		[Export("files", ArgumentSemantic.Copy)][NullAllowed]
		string [] Files { get; set; }
		
		[Export("fileURL")][NullAllowed]
		NSUrl FileURL { get; set; }
		
		[Export("data")][NullAllowed]
		NSData Data { get; }
		
		[Export("dataProvider")][NullAllowed]
		NSObject DataProvider { get; }
		
		[Export("title", ArgumentSemantic.Copy)]
		string Title { get; set; }
		
		[Export("titleLoaded", ArgumentSemantic.Assign)]
		bool TitleLoaded { [Bind("isTitleLoaded")] get; }
		
		[Export("metadata")]
		NSDictionary Metadata { get; }
		
		[Export("uid", ArgumentSemantic.Copy)]
		string Uid { get; set; }
		
		[Export("bookmarks", ArgumentSemantic.Copy)]
		PSPDFBookmark [] Bookmarks { get; set; }
		
		[Export("addBookmarkForPage:")]
		bool AddBookmarkForPage (uint page);
		
		[Export("removeBookmarkForPage:")]
		bool RemoveBookmarkForPage (uint page);
		
		[Export("bookmarkForPage:")]
		PSPDFBookmark BookmarkForPage (uint page);
		
		[Export("canEmbedAnnotations", ArgumentSemantic.Assign)]
		bool CanEmbedAnnotations { get; }
		
		[Export("saveChangedAnnotationsWithError:")]
		bool SaveChangedAnnotationsWithError (out NSError error);
		
		[Export("pageCount")]
		uint PageCount { get; }
		
		[Export("pageNumberForPage:")]
		uint PageNumberForPage (uint page);
		
		[Export("compensatedPageForPage:")]
		uint CompensatedPageForPage (uint page);
		
		[Export("hasPageInfoForPage:")]
		bool HasPageInfoForPage (uint page);
		
		[Export("pageInfoForPage:")]
		PSPDFPageInfo PageInfoForPage (uint page);
		
		[Export("pageInfoForPage:")][Internal]
		PSPDFPageInfo PageInfoForPage_ (uint page, IntPtr /*CGPDFPage*/ pageRef);
		
		[Export("nearestPageInfoForPage:")]
		PSPDFPageInfo NearestPageInfoForPage (uint page);
		
		[Export("rectBoxForPage:")]
		RectangleF RectBoxForPage (uint page);
		
		[Export("rotationForPage:")]
		int RotationForPage (uint page);
		
		[Export("aspectRatioVariance")]
		float AspectRatioVariance ();
		
		[Export("clearCache")]
		void ClearCache ();
		
		[Export("fillCache")]
		void FillCache ();
		
		[Export("cacheDirectory", ArgumentSemantic.Copy)]
		string CacheDirectory { get; set; }
		
		[Export("aspectRatioEqual", ArgumentSemantic.Assign)]
		bool AspectRatioEqual { [Bind("isAspectRatioEqual")] get; set; }
		
		[Export("annotationsEnabled", ArgumentSemantic.Assign)]
		bool AnnotationsEnabled { [Bind("isAnnotationsEnabled")] get; set; }
		
		[Export("displayingPdfController")]
		PSPDFViewController DisplayingPdfController { get; set; }
		
		[Export("unlockWithPassword:")]
		bool UnlockWithPassword (string password);
		
		[Export("password", ArgumentSemantic.Copy)]
		string Password { get; set; }
		
		[Export("valid", ArgumentSemantic.Assign)]
		bool Valid { [Bind("isValid")] get; }
		
		[Export("allowsPrinting", ArgumentSemantic.Assign)]
		bool AllowsPrinting { get; }
		
		[Export("isEncrypted", ArgumentSemantic.Assign)]
		bool IsEncrypted { get; }
		
		[Export("encryptionFilter", ArgumentSemantic.Assign)]
		string EncryptionFilter { get; }
		
		[Export("isLocked", ArgumentSemantic.Assign)]
		bool IsLocked { get; }
		
		[Export("allowsCopying", ArgumentSemantic.Assign)]
		bool AllowsCopying { get; }
		
		[Export("textParserForPage:")]
		PSPDFTextParser TextParserForPage (uint page);
		
		[Export("textSearch")]
		PSPDFTextSearch TextSearch { get; set; }
		
		[Export("documentProviderForPage:")]
		PSPDFDocumentProvider DocumentProviderForPage (uint page);
		
		[Export("documentProviders")]
		PSPDFDocumentProvider [] DocumentProviders { get; }
		
		[Export("documentParserForPage:")]
		PSPDFDocumentParser DocumentParserForPage (uint page);
		
		[Export("outlineParser")]
		PSPDFOutlineParser OutlineParser { get; }
		
		[Export("annotationParser")]
		PSPDFAnnotationParser AnnotationParser { get; }
		
		[Export("annotationParserForPage:")]
		PSPDFAnnotationParser AnnotationParserForPage (uint page);
		
		[Export("pageLabelForPage:substituteWithPlainLabel:")] [NullAllowed]
		string PageLabelForPage (uint page, bool substitute);
		
		[Export("renderImageForPage:withSize:clippedToRect:withAnnotations:options:")] 
		UIImage RenderImageForPage (uint page, SizeF fullSize, RectangleF clipRect, PSPDFAnnotation [] annotations, NSDictionary options);
		
		[Export("renderPage:inContext:withSize:clippedToRect:withAnnotations:options:")] [Internal]
		void RenderPage_ (uint page, IntPtr /*CGContextRef*/ context, SizeF fullSize, RectangleF clipRect, PSPDFAnnotation [] annotations, NSDictionary options);
		
		[Field ("kPSPDFObjectsText", "__Internal")]
		NSString PSPDFObjectsText { get; }
		
		[Field ("kPSPDFObjectsFullWords", "__Internal")]
		NSString PSPDFObjectsFullWords { get; }
		
		[Field ("kPSPDFObjectsRespectTextBlocks", "__Internal")]
		NSString PSPDFObjectsRespectTextBlocks { get; }
		
		[Field ("kPSPDFObjectsAnnotations", "__Internal")]
		NSString PSPDFObjectsAnnotations { get; }
		
		[Field ("kPSPDFGlyphs", "__Internal")]
		NSString PSPDFGlyphs { get; }
		
		[Field ("kPSPDFWords", "__Internal")]
		NSString PSPDFWords { get; }
		
		[Field ("kPSPDFTextBlocks", "__Internal")]
		NSString PSPDFTextBlocks { get; }
		
		[Field ("kPSPDFAnnotations", "__Internal")]
		NSString PSPDFAnnotations { get; }
		
		[Export("objectsAtPDFPoint:page:options:")] [NullAllowed]
		NSDictionary ObjectsAtPDFPoint (PointF pdfPoint, uint page, NSDictionary options);
		
		[Export("objectsAtPDFRect:page:options:")] [NullAllowed]
		NSDictionary ObjectsAtPDFRect (RectangleF pdfRect, uint page, NSDictionary options);
		
		// Extension methods Subclassing
		
		[Export("overrideClassNames")]
		NSDictionary OverrideClassNames { get; set; }
		
		[Bind ("didCreateDocumentProvider:")]
		PSPDFDocumentProvider DidCreateDocumentProvider (PSPDFDocumentProvider documentProvider);
		
		[Bind ("thumbnailPathForPage:")] [NullAllowed]
		NSUrl ThumbnailPathForPage (uint page);
		
		[Bind ("pageContentForPage:")] [NullAllowed]
		string PageContentForPage (uint page);
		
		[Bind ("backgroundColorForPage:")]
		UIColor BackgroundColorForPage (uint page);
		
		// Aqui
		
		[Field ("kPSPDFMetadataKeyTitle", "__Internal")]
		NSString PSPDFMetadataKeyTitle { get; }
		
		[Field ("kPSPDFMetadataKeyAuthor", "__Internal")]
		NSString PSPDFMetadataKeyAuthor { get; }
		
		[Field ("kPSPDFMetadataKeySubject", "__Internal")]
		NSString PSPDFMetadataKeySubject { get; }
		
		[Field ("kPSPDFMetadataKeyKeywords", "__Internal")]
		NSString PSPDFMetadataKeyKeywords { get; }
		
		[Field ("kPSPDFMetadataKeyCreator", "__Internal")]
		NSString PSPDFMetadataKeyCreator { get; }
		
		[Field ("kPSPDFMetadataKeyProducer", "__Internal")]
		NSString PSPDFMetadataKeyProducer { get; }
		
		[Field ("kPSPDFMetadataKeyCreationDate", "__Internal")]
		NSString PSPDFMetadataKeyCreationDate { get; }
		
		[Field ("kPSPDFMetadataKeyModDate", "__Internal")]
		NSString PSPDFMetadataKeyModDate { get; }
		
		[Field ("kPSPDFMetadataKeyTrapped", "__Internal")]
		NSString PSPDFMetadataKeyTrapped { get; }
	}
	
	//////////////////////////////////////////
	////		PSPDFTextSearch.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFSearchDelegate 
	{		
		[Export ("willStartSearchForString:isFullSearch:")]
		void WillStartSearch (string searchString, bool isFullSearch);
		
		[Export ("didUpdateSearchForString:newSearchResults:forPage:")]
		void DidUpdateSearch (string searchString, PSPDFSearchResult [] searchResults, uint page);
		
		[Export ("didFinishSearchForString:searchResults:isFullSearch:")]
		void DidFinishSearch (string searchString, PSPDFSearchResult [] searchResults, bool isFullSearch);
		
		[Export ("didCancelSearchForString:isFullSearch:")]
		void DidCancelSearch (string searchString, bool isFullSearch);
	}
	
	[BaseType (typeof (NSObject))]
	interface PSPDFTextSearch 
	{
		[Export("initWithDocument:")]
		IntPtr Constructor (PSPDFDocument document);
		
		[Export("searchForString:")]
		void SearchForString (string searchText);
		
		[Export("searchForString:visiblePages:onlyVisible:")]
		void SearchForString (string searchText, NSArray visiblePages, bool onlyVisible);
		
		[Export("hasTextForPage:")]
		bool HasTextForPage (uint page);
		
		[Export("textForPage:")]
		string TextForPage (uint page);
		
		[Export("cancelAllOperationsAndWait")]
		void CancelAllOperationsAndWait ();
		
		[Export("searchMode", ArgumentSemantic.Assign)]
		PSPDFSearchMode SearchMode { get; set; }
		
		[Export("compareOptions", ArgumentSemantic.Assign)]
		NSStringCompareOptions CompareOptions { get; set; }
		
		[Export("document")]
		PSPDFDocument Document { get; }
		
		[Wrap ("WeakDelegate")]
		PSPDFSearchDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }
	}
	
	//////////////////////////////////////////////
	////		PSPDFSearchOperation.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFSearchOperationDelegate 
	{		
		[Export ("willStartSearchOperation:forString:isFullSearch:")]
		void WillStartSearchOperation (PSPDFSearchOperation operation, string searchString, bool isFullSearch);
		
		[Export ("didUpdateSearchOperation:forString:newSearchResults:forPage:")]
		void DidUpdateSearchOperation (PSPDFSearchOperation operation, string searchString, PSPDFSearchResult [] searchResults, uint page);
	}
	
	[BaseType (typeof (NSOperation))]
	interface PSPDFSearchOperation 
	{
		[Export("initWithDocument:searchText:")]
		IntPtr Constructor (PSPDFDocument document, string searchText);
		
		[Export("selectionSearchPages", ArgumentSemantic.Copy)]
		NSArray SelectionSearchPages { get; set; }
		
		[Export("searchPages", ArgumentSemantic.Copy)]
		NSArray SearchPages { get; set; }
		
		[Export("searchText", ArgumentSemantic.Copy)]
		string SearchText { get; }
		
		[Export("pageTextDict")]
		NSDictionary PageTextDict { get; set; }
		
		[Export("searchResults")]
		PSPDFSearchResult [] SearchResults { get; }
		
		[Export("document")]
		PSPDFDocument Document { get; }
		
		[Wrap ("WeakDelegate")]
		PSPDFSearchOperationDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }
		
		[Export("searchMode", ArgumentSemantic.Assign)]
		PSPDFSearchMode SearchMode { get; set; }
		
		[Export("compareOptions", ArgumentSemantic.Assign)]
		NSStringCompareOptions CompareOptions { get; set; }
	}
	
	//////////////////////////////////////////////
	////		PSPDFDocumentProvider.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFDocumentProviderDelegate 
	{		
		[Export ("documentProvider:shouldAppendData:")]
		bool ShouldAppendData (PSPDFDocumentProvider documentProvider, NSData data);
		
		[Export ("documentProvider:didAppendData:")]
		void DidAppendData (PSPDFDocumentProvider documentProvider, NSData data);
	}
	
	[BaseType (typeof (NSObject))]
	interface PSPDFDocumentProvider 
	{		
		[Export ("initWithFileURL:document:")]
		IntPtr Constructor (NSUrl fileURL, PSPDFDocument document);
		
		[Export ("initWithData:document:")]
		IntPtr Constructor (NSData data, PSPDFDocument document);
		
		[Export ("initWithDataProvider:document:")][Internal]
		IntPtr Constructor (IntPtr /*CGDataProvider*/ dataProvider, PSPDFDocument document);
		
		[Export("fileURL")][NullAllowed]
		NSUrl FileURL { get; }
		
		[Export("data")][NullAllowed]
		NSData Data { get; }
		
		[Export("dataProvider")][NullAllowed]
		NSObject DataProvider { get; }
		
		[Export("document")]
		PSPDFDocument Document { get; }
		
		[Wrap ("WeakDelegate")]
		PSPDFDocumentProviderDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }
		
		[Export("requestDocumentRef")][Internal]
		IntPtr RequestDocumentRef_ ();
		
		[Export("releaseDocumentRef")][Internal]
		void ReleaseDocumentRef_ (IntPtr /*CGPDFDocumentRef*/ documentRef);
		
		// - (void)performBlock:(void(^)(PSPDFDocumentProvider *docProvider, CGPDFDocumentRef documentRef))documentRefBlock;
		
		// - (void)iterateOverPageRef:(void(^)(PSPDFDocumentProvider *docProvider, CGPDFDocumentRef documentRef, CGPDFPageRef pageRef, NSUInteger pageNumber))pageRefBlock;
		
		//		[Export ("requestPageRefForPageNumber:")][Internal]
		//		IntPtr /*CGPDFPage*/ RequestPageRefForPageNumber_ (uint page);
		
		[Export("releasePageRef:")][Internal]
		void ReleasePageRef_ (IntPtr /*CGPDFPageRef*/ pageRef);
		
		[Export("pageCount", ArgumentSemantic.Assign)]
		uint PageCount { get; }
		
		[Export("unlockWithPassword:")]
		bool UnlockWithPassword (string password);
		
		[Export("password", ArgumentSemantic.Copy)]
		string Password { get; set; }
		
		[Export("allowsCopying", ArgumentSemantic.Assign)]
		bool AllowsCopying { get; }
		
		[Export("isEncrypted", ArgumentSemantic.Assign)]
		bool IsEncrypted { get; }
		
		[Export("encryptionFilter", ArgumentSemantic.Assign)]
		string EncryptionFilter { get; }
		
		[Export("isLocked", ArgumentSemantic.Assign)]
		bool IsLocked { get; }
		
		[Export("canEmbedAnnotations", ArgumentSemantic.Assign)]
		bool CanEmbedAnnotations { get; set; }
		
		[Export("saveChangedAnnotationsWithError:")]
		bool SaveChangedAnnotationsWithError (out NSError error);
		
		[Export("metadata")]
		NSDictionary Metadata { get; }
		
		[Export("metadataLoaded", ArgumentSemantic.Assign)]
		bool MetadataLoaded { [Bind("isMetadataLoaded")] get; }
		
		[Export("title", ArgumentSemantic.Copy)]
		string Title { get; }
		
		[Export("outlineParser")]
		PSPDFOutlineParser OutlineParser { get; set; }
		
		[Export("documentParser")]
		PSPDFDocumentParser DocumentParser { get; set; }
		
		[Export("annotationParser")]
		PSPDFAnnotationParser AnnotationParser { get; set; }
		
		[Export("labelParser")]
		PSPDFLabelParser LabelParser { get; set; }
		
		// EXTENSIONS
		
		[Export("hasOpenDocumentRef", ArgumentSemantic.Assign)]
		bool HasOpenDocumentRef { get; }
		
	}
	
	//////////////////////////////////////////
	////		PSPDFLabelParser.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFLabelParser 
	{
		[Export("initWithDocument:")]
		IntPtr Constructor (PSPDFDocument document);
		
		[Export("parseDocument")]
		NSDictionary ParseDocument ();
		
		[Export("pageLabelForPage:")][NullAllowed]
		string PageLabelForPage (uint page);
		
		[Export("labels")]
		NSDictionary labels { get; }
	}
	
	//////////////////////////////////////////////
	////		PSPDFAnnotationParser.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFAnnotationParser 
	{
		[Export("initWithDocumentProvider:")]
		IntPtr Constructor (PSPDFDocumentProvider documentProvider);
		
		[Export("annotationsForPage:PSPDFAnnotationType:")]
		PSPDFAnnotation [] AnnotationsForPage (uint page, PSPDFAnnotationType type);
		
		[Export("annotationsForPage:PSPDFAnnotationType:")][Internal]
		PSPDFAnnotation [] AnnotationsForPage_ (uint page, PSPDFAnnotationType type, IntPtr /*CGPDFPageRef*/ pageRef);
		
		[Export("parseAnnotationLinkTarget:")]
		void ParseAnnotationLinkTarget (PSPDFAnnotation annotation);
		
		[Export("hasLoadedAnnotationsForPage:")]
		bool HasLoadedAnnotationsForPage (uint page);
		
		[Export("annotationClassForAnnotation:")]
		Class AnnotationClassForAnnotation (PSPDFAnnotation annotation);
		
		[Export("createAnnotationViewForAnnotation:frame:")]
		PSPDFAnnotationView CreateAnnotationViewForAnnotation (PSPDFAnnotation annotation, RectangleF annotationRect);
		
		[Export("setAnnotations:forPage:")]
		void SetAnnotations (PSPDFAnnotation [] annotation, uint page);
		
		[Export("addAnnotations:forPage:")]
		void AddAnnotations (PSPDFAnnotation [] annotation, uint page);
		
		[Export("dirtyAnnotations")]
		NSDictionary DirtyAnnotations ();
		
		[Export("annotations")]
		NSDictionary Annotations ();
		
		[Export("removeDeletedAnnotations")]
		uint RemoveDeletedAnnotations ();
		
		[Export("documentProvider")]
		PSPDFDocumentProvider DocumentProvider { get; }
		
		[Export("protocolString")]
		string ProtocolString { get; }
	}
	
	
	//////////////////////////////////////////////
	////		PSPDFDocumentParser.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFDocumentParser 
	{
		[Export("initWithDocumentProvider:")]
		IntPtr Constructor (PSPDFDocumentProvider documentProvider);
		
		[Export("parseDocument")]
		void ParseDocument ();
		
		[Export("saveAnnotations:withError:")]
		bool SaveAnnotations (NSDictionary annotations, out NSError error);
		
		[Export("documentProvider")]
		PSPDFDocumentProvider DocumentProvider { get; }
		
		[Export("encryptionFilter")]
		string EncryptionFilter { get; }
		
		[Export("pageObjectNumbers")]
		NSArray PageObjectNumbers { get; }
	}
	
	[BaseType (typeof (NSObject))]
	interface PSPDFXRefEntry 
	{
		[Export("objectNumber", ArgumentSemantic.Assign)]
		int ObjectNumber { get; set; }
		
		[Export("byteOffset", ArgumentSemantic.Assign)]
		long ByteOffset { get; set; }
		
		[Export("isCompressed", ArgumentSemantic.Assign)]
		bool IsCompressed { get; set; }
		
		[Export("objectStreamNumber", ArgumentSemantic.Assign)]
		int ObjectStreamNumber { get; set; }
		
		[Export("isDeleted", ArgumentSemantic.Assign)]
		bool IsDeleted { get; set; }
	}
	
	
	
	//////////////////////////////////////////////
	////		PSPDFOutlineParser.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFOutlineParser 
	{
		[Export("initWithDocumentProvider:")]
		IntPtr Constructor (PSPDFDocumentProvider documentProvider);
		
		[Field ("kPSPDFOutlineParserErrorDomain", "__Internal")]
		NSString PSPDFOutlineParserErrorDomain { get; }
		
		[Export("outlineElementForPage:exactPageOnly:")]
		PSPDFOutlineElement OutlineElementForPage (uint page, bool exactPageOnly);
		
		[Export("outline")]
		PSPDFOutlineElement Outline { get; }
		
		[Export("outlineParsed", ArgumentSemantic.Assign)]
		bool OutlineParsed { [Bind("isOutlineParsed")] get; }
		
		[Export("outlineAvailable", ArgumentSemantic.Assign)]
		bool OutlineAvailable { [Bind("isOutlineAvailable")] get; }
		
		[Static][Export("resolveDestNames:documentRef:")][Internal]
		NSDictionary ResolveDestNames_ (NSSet destNames, IntPtr /*CGPDFDocumentRef*/ documentRef);
		
		[Export("firstVisibleElement", ArgumentSemantic.Assign)]
		uint FirstVisibleElement { get; set; }
		
	}
	
	
	
	//////////////////////////////////////////////
	////		PSPDFOutlineElement.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFBookmark))]
	interface PSPDFOutlineElement 
	{
		[Export("initWithTitle:page:relativePath:children:level:")]
		IntPtr Constructor (string title, uint page, string relativePath, NSArray children, uint level);
		
		[Export("flattenedChildren")]
		NSArray FlattenedChildren ();
		
		[Export("title")]
		string Title { get; set; }
		
		[Export("relativePath", ArgumentSemantic.Copy)]
		string RelativePath { get; set; }
		
		[Export("children")]
		NSArray Children { get; }
		
		[Export("level", ArgumentSemantic.Assign)]
		uint Level { get; set; }
		
		[Export("expanded", ArgumentSemantic.Assign)]
		bool Expanded { [Bind("isExpanded")] get; set; }
	}
	
	//////////////////////////////////////
	////		PSPDFBookmark.h			//
	//////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFBookmark 
	{
		[Export("initWithPage:")]
		IntPtr Constructor (uint page);
		
		[Export("page", ArgumentSemantic.Assign)]
		uint Page { get; set; }
	}
	
	
	//////////////////////////////
	////	PSPDFPageView.h		//
	//////////////////////////////
	
	delegate void UpdateShadowBlock (PSPDFPageView pageView);
	
	[BaseType (typeof (UIView))]
	interface PSPDFPageView 
	{
		[Field ("kPSPDFHidePageHUDElements", "__Internal")]
		NSString PSPDFHidePageHUDElements { get; }
		
		[Export ("initWithFrame:pdfController:")]
		IntPtr Constructor (RectangleF frame, PSPDFViewController pdfController);
		
		[Export ("displayDocument:page:pageRect:scale:delayPageAnnotations:pdfController:")]
		void DisplayDocument (PSPDFDocument document, uint page, RectangleF pageRect, float scale, bool delayPageAnnotations, PSPDFViewController pdfController);
		
		[Export ("prepareForReuse")]
		void PrepareForReuse ();
		
		[Export ("updateRenderView")]
		void UpdateRenderView ();
		
		[Export ("updateView")]
		void UpdateView ();
		
		[Export ("loadPageAnnotationsAnimated:")]
		void LoadPageAnnotationsAnimated (bool animated);
		
		[Export ("annotationViewForAnnotation:")]
		PSPDFAnnotationView AnnotationViewForAnnotation (PSPDFAnnotation annotation);
		
		[Export ("contentView")]
		UIImageView ContentView { get; }
		
		[Export ("renderView")]
		UIImageView RenderView { get; }
		
		[Export ("renderSize", ArgumentSemantic.Assign)]
		SizeF RenderSize { get; set; }
		
		[Export ("pdfScale")]
		float PdfScale { get; }
		
		[Export ("suspendUpdate", ArgumentSemantic.Assign)]
		bool SuspendUpdate { get; set; }
		
		[Export ("rendering", ArgumentSemantic.Assign)]
		bool Rendering { [Bind("isRendering")] get; }
		
		[Export ("visibleRect", ArgumentSemantic.Assign)]
		RectangleF VisibleRect { get; }
		
		[Export ("selectionView")]
		PSPDFTextSelectionView SelectionView { get; }
		
		[Export ("renderStatusView")]
		PSPDFRenderStatusView RenderStatusView { get; set; }
		
		[Export ("textParser")]
		PSPDFTextParser TextParser { get; }
		
		[Export ("convertViewPointToPDFPoint:")]
		PointF ConvertViewPointToPDFPoint (PointF viewPoint);
		
		[Export ("convertPDFPointToViewPoint:")]
		PointF ConvertPDFPointToViewPoint (PointF pdfPoint);
		
		[Export ("convertViewRectToPDFRect:")]
		RectangleF ConvertViewRectToPDFRect (RectangleF viewRect);
		
		[Export ("convertPDFRectToViewRect:")]
		RectangleF ConvertPDFRectToViewRect (RectangleF pdfRect);
		
		[Export ("objectsAtPoint:options:")]
		NSDictionary ObjectsAtPointOptions (PointF pdfPoint, NSDictionary options);
		
		[Export ("objectsAtRect:options:")]
		NSDictionary ObjectsAtRectOptions (RectangleF pdfRect, NSDictionary options);
		
		[Export("scrollView")]
		PSPDFScrollView ScrollView { get; }
		
		[Export("visibleAnnotationViews")]
		PSPDFAnnotationView [] VisibleAnnotationViews { get; }
		
		[Export("pdfController")]
		PSPDFViewController PdfController { get; }
		
		[Export("page")]
		uint Page { get; }
		
		[Export("document")]
		PSPDFDocument Document { get; }
		
		[Export("pageInfo", ArgumentSemantic.Assign)]
		PSPDFPageInfo PageInfo { get; }
		
		[Export ("rightPage", ArgumentSemantic.Assign)]
		bool RightPage { [Bind("isRightPage")] get; }
		
		[Export ("shadowEnabled", ArgumentSemantic.Assign)]
		bool ShadowEnabled { [Bind("isShadowEnabled")] get; set; }
		
		[Export ("shadowOpacity", ArgumentSemantic.Assign)]
		float ShadowOpacity { get; set; }
		
		[Export("updateShadow")]
		void UpdateShadow();
		
		// Since it is not really useful to get "back" the block
		//@property(nonatomic, copy) void(^updateShadowBlock)(PSPDFPageView *pageView);
		[Export ("setUpdateShadowBlock:")]
		void SetUpdateShadowBlock (UpdateShadowBlock ShadowBlock);
		
		//TODO: Extension Methods
		
		//@property(nonatomic, strong, readonly) PSPDFAnnotation *selectedAnnotation;
		[Export("selectedAnnotation")]
		PSPDFAnnotation SelectedAnnotation { get; }
		
		[Bind ("singleTap:")]
		bool SingleTap (UIGestureRecognizer recognizer);
		
		[Bind ("longPress:")]
		bool LongPress (UILongPressGestureRecognizer recognizer);
		
		[Bind ("menuItemsForAnnotation:")]
		UIMenuItem [] MenuItemsForAnnotation (PSPDFAnnotation annotation);
		
		[Bind ("showMenuForAnnotation:")]
		void ShowMenuForAnnotation (PSPDFAnnotation annotation);
		
		[Bind ("loadPageAnnotation:animated:")]
		void LoadPageAnnotationAnimated (PSPDFAnnotation annotation, bool animated);
		
		[Bind ("pspdf_scrollView:willZoomToScale:animated:")]
		void Pspdf_scrollView (UIScrollView scrollView, float scale, bool animated);
	}

	[BaseType (typeof (UIImageView))]
	interface PSPDFRenderStatusView 
	{

	}
	
	//////////////////////////////////////
	////	PSPDFBarButtonItem.h		//
	//////////////////////////////////////
	
	[BaseType (typeof (UIBarButtonItem))]
	interface PSPDFBarButtonItem 
	{
		[Static][Export ("dismissPopoverAnimated:")]
		void DismissPopoverAnimated (bool animated);
		
		[Static][Export ("isPopoverVisible")]
		bool IsPopoverVisible { get; }
		
		[Export ("initWithPDFViewController:")]
		IntPtr Constructor (PSPDFViewController pdfViewController);
		
		[Export ("pdfController")]
		PSPDFViewController PdfController { get; }
		
		[Export ("customView")][New]
		UIView CustomView ();
		
		[Export ("image")][New]
		UIImage Image ();
		
		[Export ("systemItem")]
		UIBarButtonSystemItem SystemItem ();
		
		[Export ("landscapeImagePhone")][New]
		UIImage LandscapeImagePhone ();
		
		[Export ("actionName")]
		string ActionName ();
		
		[Export ("itemStyle")]
		UIBarButtonItemStyle ItemStyle ();
		
		[Export ("isAvailable")]
		bool IsAvailable { get; }
		
		[Export ("updateBarButtonItem")]
		void UpdateBarButtonItem ();
		
		[Export ("presentAnimated:sender:")]
		NSObject PresentAnimatedSender (bool animated, PSPDFBarButtonItem sender);
		
		[Export ("dismissAnimated:")]
		void DismissAnimated (bool animated);
		
		[Export ("didDismiss")]
		void DidDismiss ();
		
		[Export ("presentModalOrInPopover:sender:")]
		NSObject PresentModalOrInPopoverSender (UIViewController viewController, NSObject sender);
		
		[Export ("dismissModalOrPopoverAnimated:")]
		void DismissModalOrPopoverAnimated (bool animated);
		
		[Static][Export ("popoverControllerForObject:")]
		UIPopoverController PopoverControllerForObject (NSObject obj);
		
		[Export ("action:")][New]
		void Action (PSPDFBarButtonItem sender);
	}
	
	//////////////////////////////
	////	PSPDFViewState.h	//
	//////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFViewState 
	{
		[Export ("zoomScale", ArgumentSemantic.Assign)]
		float ZoomScale { get; set; }
		
		[Export ("contentOffset", ArgumentSemantic.Assign)]
		PointF ContentOffset { get; set; }
		
		[Export ("page", ArgumentSemantic.Assign)]
		uint Page { get; set; }
		
		[Export ("HUDVisible", ArgumentSemantic.Assign)]
		bool HUDVisible { [Bind ("isHUDVisible")] get; set; }
	}
	
	
	//////////////////////////////////////
	////	PSPDFBaseViewController.h	//
	//////////////////////////////////////
	
	[BaseType (typeof (UIViewController))]
	interface PSPDFBaseViewController // Este es asi solo
	{
		
	}
	
	
	//////////////////////////////////
	////	PSPDFAnnotationView.h	//
	//////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFAnnotationView 
	{
		[Export ("annotation")]
		PSPDFAnnotation Annotation { get; set; }
		
		[Export ("willShowPage:")]
		void WillShowPage (uint page);
		
		[Export ("didShowPage:")]
		void DidShowPage (uint page);
		
		[Export ("willHidePage:")]
		void WillHidePage (uint page);
		
		[Export ("didHidePage:")]
		void DidHidePage (uint page);
		
		[Export ("didChangePageFrame:")]
		void DidChangePageFrame (Rectangle frame);
	}
	
	//////////////////////////////////////////
	////		PSPDFAnnotation.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFAnnotation 
	{
		[Static][Export ("supportedTypes")]
		string [] SupportedTypes { get; }
		
		[Export ("initWithType:")]
		IntPtr Constructor (PSPDFAnnotationType annotationType);
		
		// TODO: Check if this works
		
		[Export ("initWithAnnotationDictionary:inAnnotsArray:")][Internal]
		IntPtr Constructor (IntPtr /*CGPDFDictionary*/ annotDict, IntPtr /*CGPDFArray*/ annotsArray);
		
		// TODO: Check if this works
		
		[Export ("initWithAnnotationDictionary:inAnnotsArray:type:")][Internal]
		IntPtr Constructor (IntPtr /*CGPDFDictionary*/ annotDict, IntPtr /*CGPDFArray*/ annotsArray, PSPDFAnnotationType annotationType);
		
		[Export ("copyAndDeleteOriginalIfNeeded")]
		PSPDFAnnotation copyAndDeleteOriginalIfNeeded ();
		
		[Export ("hitTest:")]
		bool HitTest (PointF point);
		
		[Export ("rectForPageRect:")]
		RectangleF RectForPageRect (RectangleF pageRect);
		
		[Export ("compareByPositionOnPage:")]
		NSComparisonResult CompareByPositionOnPage (PSPDFAnnotation otherAnnotation);
		
		//		// TODO: Check if this works
		[Export ("rectFromPDFArray:")][Internal]
		RectangleF RectFromPDFArray_ (IntPtr /* CGPDFArray */ array);
		
		// TODO: Check if this works
		[Export ("rectsFromQuadPointsInArray:")][Internal]
		NSArray RectsFromQuadPointsInArray_ (IntPtr /*CGPDFArray*/ quadPointsArray);
		
		[Export ("drawInContext:")]
		void DrawInContext (CGContext context);
		
		[Export ("pdfDataRepresentation")]
		NSData PdfDataRepresentation ();
		
		[Export ("type", ArgumentSemantic.Assign)]
		PSPDFAnnotationType AnnotationType { get; }
		
		[Export ("typeString", ArgumentSemantic.Copy)]
		string TypeString { get; set; }
		
		[Export ("alpha", ArgumentSemantic.Assign)]
		float Alpha { get; set; }
		
		[Export ("color")]
		UIColor Color { get; set; }
		
		[Export ("colorWithAlpha")]
		UIColor colorWithAlpha { get; }
		
		[Export ("contents")]
		string Contents { get; set; }
		
		[Export ("lineWidth", ArgumentSemantic.Assign)]
		float LineWidth { get; set; }
		
		[Export ("indexOnPage", ArgumentSemantic.Assign)]
		int IndexOnPage { get; set; }
		
		[Export ("popupIndex", ArgumentSemantic.Assign)]
		int PopupIndex { get; set; }
		
		[Export ("deleted", ArgumentSemantic.Assign)]
		bool Deleted { [Bind ("isDeleted")] get; set; }
		
		[Export ("boundingBox", ArgumentSemantic.Assign)]
		RectangleF BoundingBox { get; set; }
		
		[Export ("page", ArgumentSemantic.Assign)]
		uint Page { get; set; }
		
		[Export ("dirty", ArgumentSemantic.Assign)]
		bool Dirty { [Bind ("isDirty")] get; set; }
		
		[Export ("document", ArgumentSemantic.Assign)]
		PSPDFDocument Document { get; set; }
		
		[Export ("pdfRectString")]
		string PdfRectString { get; }
		
		[Export ("pdfColorString")]
		string PdfColorString { get; }
		
		[Export ("pdfColorWithAlphaString")]
		string pdfColorWithAlphaString { get; }
		
		[Export ("appendEscapedContents:")]
		void AppendEscapedContents (NSMutableData pdfData);
		
		// This should accept RectangleF array but it goes kaboom...
		[Static][Export ("stringsFromRectsArray:")]
		string [] StringsFromRectsArray (NSArray rects);
		
		// This should return a RectangleF array but it goes kaboom...
		[Static][Export ("rectsFromStringsArray:")]
		NSArray RectsFromStringsArray (string [] rectStrings);
		
	}
	
	
	//////////////////////////////////////////////////
	////		PSPDFTextSelectionView.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (UIView))]
	interface PSPDFTextSelectionView 
	{
		[Export ("selectedGlyphs")]
		PSPDFGlyph [] SelectedGlyphs { get; set; }
		
		[Export ("selectedText")]
		string SelectedText { get; set; }
		
		[Export ("trimmedSelectedText")]
		string TrimmedSelectedText { get; }
		
		[Export ("selectedInk")]
		PSPDFInkAnnotation SelectedInk { get; set; }
		
		[Export ("selectedAnnotation")]
		PSPDFHighlightAnnotation SelectedAnnotation { get; set; }

		[Export ("loupeView")]
		PSPDFLoupeView LoupeView { get; set; }
		
		[Export ("pageView")]
		PSPDFPageView PageView { get; set; }
		
		[Export ("showLoupe")]
		void ShowLoupe ();
		
		[Export ("hideLoupe")]
		void HideLoupe ();
		
		[Export ("discardSelection")]
		void DiscardSelection ();
		
		[Export ("hasSelection")]
		bool HasSelection { get; }
		
		[Export ("discardInkSelection")]
		void DiscardInkSelection ();
		
		[Export ("longPress:")]
		void LongPress (UILongPressGestureRecognizer recognizer);
		
		[Export ("shouldHandleLongPressWithRecognizer:")]
		bool ShouldHandleLongPressWithRecognizer (UILongPressGestureRecognizer recognizer);
		
		[Export ("updateSelectionHandleSize")]
		void UpdateSelectionHandleSize ();
		
		[Export ("showTextFlowData:animated:")]
		void ShowTextFlowData (bool show, bool animated);
	}

	//////////////////////////////////////////
	////		PSPDFLoupeView.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (UIView))]
	interface PSPDFLoupeView 
	{
		[Export ("initWithReferenceView:")]
		IntPtr Constructor (UIView referenceView);
		
		[Export ("mode", ArgumentSemantic.Assign)]
		PSPDFLoupeViewMode Mode { get; set; }
		
		[Export ("targetSize", ArgumentSemantic.Assign)]
		SizeF TargetSize { get; set; }
		
	}
	
	//////////////////////////////////////
	////	PSPDFBaseViewController.h	//
	//////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFTextParser 
	{		
		[Export ("text")][NullAllowed]
		string Text { get; set; }
		
		[Export ("glyphs")]
		NSMutableArray Glyphs { get; set; }
		
		[Export ("words")]
		NSMutableArray Words { get; set; }
		
		[Export ("textBlocks")]
		NSArray TextBlocks { get; set; }
		
		// TODO: This had to be bound like this due to there btouch limitations
		[Export ("initWithPDFPage:")][Internal][Static]
		PSPDFTextParser initWithPDFPage_ (IntPtr /*CGPDFPage*/ page);
		
	}
	
	//////////////////////////////////////////////
	////		PSPDFInkAnnotation.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFAnnotation))]
	interface PSPDFInkAnnotation 
	{
		[Export ("lines")]
		NSArray Lines { get; set; }
		
		[Export ("paths")]
		UIBezierPath [] Paths { get; set; }
		
		//		// TODO: Check if this works
		[Export ("initWithAnnotationDictionary:inAnnotsArray:")][Internal]
		IntPtr Constructor (IntPtr /*CGPDFDictionary*/ annotDict, IntPtr /*CGPDFArray*/ annotsArray);
		
		[Export ("rebuildPaths")]
		void RebuildPaths ();
		
		[Export ("clearAllData")]
		void ClearAllData ();
		
		[Export ("clearCachedPaths")]
		void ClearCachedPaths ();
		
	}
	
	//////////////////////////////////////////////////
	////		PSPDFHighlightAnnotation.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFAnnotation))]
	interface PSPDFHighlightAnnotation 
	{
		[Export ("highlightType", ArgumentSemantic.Assign)]
		PSPDFHighlightAnnotationType HighlightType { get; set; }
		
		[Export ("rects")]
		NSArray Rects { get; set; }
		
		// TODO: Check if this works
		[Export ("initWithAnnotationDictionary:inAnnotsArray:")][Internal]
		IntPtr Constructor (IntPtr /*CGPDFDictionary*/ annotDict, IntPtr /*CGPDFArray*/ annotsArray);
		
		[Export ("initWithType:")]
		IntPtr Constructor (PSPDFHighlightAnnotationType annotationType);
		
		[Export ("setType:withDefaultColor:")]
		void SetTypeWithDefaultColor (PSPDFHighlightAnnotationType annotationType, bool useDefaultColor);
	}
	
	//////////////////////////////////////////
	////		PSPDFScrollView.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (UIScrollView))]
	interface PSPDFScrollView 
	{
		[Export("displayDocument:withPage:")]
		void DisplayDocumentWithPage(PSPDFDocument document, uint page);
		
		[Export("releaseDocument")]
		void ReleaseDocument();
		
		[Export("page", ArgumentSemantic.Assign)]
		uint Page { get; set; }
		
		[Export("document")]
		PSPDFDocument Document { get; }
		
		[Export("pdfController")]
		PSPDFViewController PdfController { get; set; }
		
		[Export("leftPage")][NullAllowed]
		PSPDFPageView LeftPage { get; }
		
		[Export("rightPage")][NullAllowed]
		PSPDFPageView RightPage { get; }
		
		[Export("shadowStyle", ArgumentSemantic.Assign)]
		PSPDFShadowStyle ShadowStyle { get; set; }
		
		[Export("zoomingEnabled", ArgumentSemantic.Assign)]
		bool ZoomingEnabled { [Bind("isZoomingEnabled")] get; set; }
		
		[Export("doublePageMode", ArgumentSemantic.Assign)]
		bool DoublePageMode { [Bind("isDoublePageMode")] get; set; }
		
		[Export("doublePageModeOnFirstPage", ArgumentSemantic.Assign)]
		bool DoublePageModeOnFirstPage { [Bind("isDoublePageModeOnFirstPage")] get; set; }
		
		[Export("zoomingSmallDocumentsEnabled", ArgumentSemantic.Assign)]
		bool ZoomingSmallDocumentsEnabled { [Bind("isZoomingSmallDocumentsEnabled")] get; set; }
		
		[Export("fitToWidthEnabled", ArgumentSemantic.Assign)]
		bool FitToWidthEnabled { [Bind("isFitToWidthEnabled")] get; set; }
		
		[Export("shadowEnabled", ArgumentSemantic.Assign)]
		bool ShadowEnabled { [Bind("isShadowEnabled")] get; set; }
		
		[Export("scrollOnTapPageEndEnabled", ArgumentSemantic.Assign)]
		bool ScrollOnTapPageEndEnabled { [Bind("isScrollOnTapPageEndEnabled")] get; set; }
		
		// Obj-c Extension PSPDFSubclassing
		
		[Export("singleTapGesture")]
		UITapGestureRecognizer SingleTapGesture { get; }
		
		[Export("doubleTapGesture")]
		UITapGestureRecognizer DoubleTapGesture { get; }
		
		[Export("longPressGesture")]
		UILongPressGestureRecognizer LongPressGesture { get; }
		
		[Bind("singleTapped:")]
		void SingleTapped (UITapGestureRecognizer recognizer);
		
		[Bind("doubleTapped:")]
		void DoubleTapped (UITapGestureRecognizer recognizer);
		
		[Bind("longPress:")]
		void LongPress (UILongPressGestureRecognizer recognizer);
		
		[Bind("pathShadowForView:")]
		NSObject PathShadowForView (UIView imgView);
		
		// Obj-c Extension PSPDFInternal
		
		[Export("compoundView")]
		UIView CompoundView { get; }

		[Export("loupeView")]
		PSPDFLoupeView LoupeView { get; }
		
		[Export("rotationActive", ArgumentSemantic.Assign)]
		bool RotationActive { [Bind("isRotationActive")] get; set; }
		
		[Bind("didReceiveMemoryWarning")]
		void DidReceiveMemoryWarning ();
		
		[Bind("switchPages")]
		void SwitchPages ();
		
		[Bind("pageViewForPoint:")]
		PSPDFPageView SwitchPages (PointF point);
	}
	
	//////////////////////////////////////
	////		PSPDFPageInfo.h			//
	//////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFPageInfo 
	{
		[Export ("initWithPage:rect:rotation:document:")]
		IntPtr Constructor (uint page, RectangleF pageRect, int rotation, PSPDFDocument document);
		
		[Export("pageRect", ArgumentSemantic.Assign)]
		RectangleF PageRect { get; }
		
		[Export("rotatedPageRect", ArgumentSemantic.Assign)]
		RectangleF RotatedPageRect { get; }
		
		[Export("pageRotation", ArgumentSemantic.Assign)]
		uint PageRotation { get; }
		
		[Export("pageRotationTransform", ArgumentSemantic.Assign)]
		CGAffineTransform pageRotationTransform { get; }
		
		[Export("page", ArgumentSemantic.Assign)]
		uint Page { get; }
		
		[Export("document")]
		PSPDFDocument Document { get; }
	}
	
	//////////////////////////////////////////////
	////		PSCollectionViewCell.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (UIView))]
	interface PSCollectionReusableView 
	{
		[Export("reuseIdentifier", ArgumentSemantic.Copy)]
		string ReuseIdentifier { get; }
		
		[Export("prepareForReuse")]
		void PrepareForReuse ();
		
		[Export("applyLayoutAttributes:")]
		void ApplyLayoutAttributes (PSCollectionViewLayoutAttributes layoutAttributes);
		
		[Export("willTransitionFromLayout:toLayout:")]
		void WillTransitionFromLayoutToLayout (PSCollectionViewLayout oldLayout, PSCollectionViewLayout newLayout);
		
		[Export("didTransitionFromLayout:toLayout:")]
		void DidTransitionFromLayoutToLayout (PSCollectionViewLayout oldLayout, PSCollectionViewLayout newLayout);
	}
	
	[BaseType (typeof (PSCollectionReusableView))]
	interface PSCollectionViewCell 
	{
		[Export("contentView")]
		UIView ContentView { get; }
		
		[Export("selected")]
		bool Selected { [Bind("isSelected")] get; set; }
		
		[Export("highlighted")]
		bool Highlighted { [Bind("isHighlighted")] get; set; }
		
		[Export("backgroundView")]
		UIView BackgroundView { get; set; }
		
		[Export("selectedBackgroundView")]
		UIView SelectedBackgroundView { get; set; }
	}
	
	//////////////////////////////////////////
	////		PSCollectionView.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSCollectionViewDataSource 
	{
		[Abstract][Export ("collectionView:numberOfItemsInSection:")]
		int CollectionViewNumberOfItemsInSection (PSCollectionView collectionView, int section);
		
		[Abstract][Export ("collectionView:cellForItemAtIndexPath:")]
		PSCollectionViewCell CollectionViewCellForItemAtIndexPath (PSCollectionView collectionView, NSIndexPath indexPath);
		
		[Export ("numberOfSectionsInCollectionView:")]
		int NumberOfSectionsInCollectionView (PSCollectionView collectionView);
		
		[Export ("collectionView:viewForSupplementaryElementOfKind:atIndexPath:")]
		PSCollectionReusableView CollectionViewViewForSupplementaryElementOfKind (PSCollectionView collectionView, string kind, NSIndexPath indexPath);
	}
	
	[BaseType (typeof (UIScrollViewDelegate))]
	[Model]
	interface PSCollectionViewDelegate 
	{
		[Export ("collectionView:shouldHighlightItemAtIndexPath:")]
		bool ShouldHighlightItem (PSCollectionView collectionView, NSIndexPath indexPath);
		
		[Export ("collectionView:didHighlightItemAtIndexPath:")]
		void DidHighlightItem (PSCollectionView collectionView, NSIndexPath indexPath);
		
		[Export ("collectionView:didUnhighlightItemAtIndexPath:")]
		void DidUnhighlightItem (PSCollectionView collectionView, NSIndexPath indexPath);
		
		[Export ("collectionView:shouldSelectItemAtIndexPath:")]
		bool ShouldSelectItem (PSCollectionView collectionView, NSIndexPath indexPath);
		
		[Export ("collectionView:shouldDeselectItemAtIndexPath:")]
		bool ShouldDeselectItem (PSCollectionView collectionView, NSIndexPath indexPath);
		
		[Export ("collectionView:didSelectItemAtIndexPath:")]
		void DidSelectItem (PSCollectionView collectionView, NSIndexPath indexPath);
		
		[Export ("collectionView:didDeselectItemAtIndexPath:")]
		void DidDeselectItem (PSCollectionView collectionView, NSIndexPath indexPath);
		
		[Export ("collectionView:didEndDisplayingCell:forItemAtIndexPath:")]
		void DidEndDisplayingCell (PSCollectionView collectionView, PSCollectionViewCell cell, NSIndexPath indexPath);
		
		[Export ("collectionView:didEndDisplayingSupplementaryView:forElementOfKind:atIndexPath:")]
		void DidEndDisplayingSupplementaryView (PSCollectionView collectionView, PSCollectionReusableView view, string elementKind, NSIndexPath indexPath);
		
		[Export ("collectionView:shouldShowMenuForItemAtIndexPath:")]
		bool ShouldShowMenuForItem (PSCollectionView collectionView, NSIndexPath indexPath);
		
		[Export ("collectionView:canPerformAction:forItemAtIndexPath:withSender")]
		bool CanPerformAction (PSCollectionView collectionView, Selector action, NSIndexPath indexPath, NSObject sender);
		
		[Export ("collectionView:performAction:forItemAtIndexPath:withSender")]
		void PerformAction (PSCollectionView collectionView, Selector action, NSIndexPath indexPath, NSObject sender);
		
	}	
	
	[BaseType (typeof (UIScrollView))]
	interface PSCollectionView 
	{
		[Export ("initWithFrame:collectionViewLayout:")]
		IntPtr Constructor (RectangleF frame, PSCollectionViewLayout layout);
		
		[Export("collectionViewLayout", ArgumentSemantic.Retain)]
		PSCollectionViewLayout CollectionViewLayout { get; set; }
		
		[Wrap ("WeakDelegate")][New]
		PSCollectionViewDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed][New]
		NSObject WeakDelegate { get; set; }
		
		// TODO: test data source
		
		[Wrap ("WeakDataSource")]
		PSCollectionViewDataSource DataSource { get; set; }
		
		[Export ("dataSource", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDataSource { get; set; }
		
		[Export("backgroundView", ArgumentSemantic.Retain)]
		UIView BackgroundView { get; set; }
		
		[Export ("registerClass:forCellWithReuseIdentifier:")]
		void RegisterClass (Class cellClass, string identifier);
		
		[Export ("registerClass:forSupplementaryViewOfKind:withReuseIdentifier:")]
		void RegisterClass (Class viewClass, string elementKind, string identifier);
		
		[Export ("dequeueReusableCellWithReuseIdentifier:forIndexPath:")]
		NSObject DequeueReusableCell (string identifier, NSIndexPath indexPath);
		
		[Export ("dequeueReusableSupplementaryViewOfKind:withReuseIdentifier:forIndexPath:")]
		NSObject DequeueReusableSupplementaryView (string elementKind, string identifier, NSIndexPath indexPath);
		
		[Export("allowsSelection")]
		bool AllowsSelection { get; set; }
		
		[Export("allowsMultipleSelection")]
		bool AllowsMultipleSelection { get; set; }
		
		[Export("indexPathsForSelectedItems")][NullAllowed]
		NSIndexPath [] IndexPathsForSelectedItems();
		
		[Export("selectItemAtIndexPath:animated:scrollPosition:")]
		void SelectItemAtIndexPath(NSIndexPath indexPath, bool animated, PSCollectionViewScrollPosition scrollPosition);
		
		[Export("deselectItemAtIndexPath:animated:")]
		void DeselectItemAtIndexPath(NSIndexPath indexPath, bool animated);
		
		[Export("reloadData")]
		void ReloadData();
		
		[Export("setCollectionViewLayout:animated:")]
		void SetCollectionViewLayout(PSCollectionViewLayout layout, bool animated);
		
		[Export("numberOfSections")]
		int NumberOfSections();
		
		[Export("numberOfItemsInSection:")]
		int NumberOfItemsInSection(int section);
		
		[Export("layoutAttributesForItemAtIndexPath:")]
		PSCollectionViewLayoutAttributes LayoutAttributesForItemAtIndexPath(NSIndexPath indexPath);
		
		[Export("layoutAttributesForSupplementaryElementOfKind:atIndexPath:")]
		PSCollectionViewLayoutAttributes LayoutAttributesForSupplementaryElementOfKind(string kind, NSIndexPath indexPath);
		
		[Export("indexPathForItemAtPoint:")]
		NSIndexPath IndexPathForItemAtPoint(PointF point);
		
		[Export("indexPathForCell:")]
		NSIndexPath IndexPathForCell(PSCollectionViewCell cell);
		
		[Export("cellForItemAtIndexPath:")]
		PSCollectionViewCell CellForItemAtIndexPath(NSIndexPath indexPath);
		
		[Export("visibleCells")]
		NSArray VisibleCells();
		
		[Export("indexPathsForVisibleItems")]
		NSIndexPath [] IndexPathsForVisibleItems();
		
		[Export("scrollToItemAtIndexPath:atScrollPosition:animated:")]
		void ScrollToItemAtIndexPath(NSIndexPath indexPath, PSCollectionViewScrollPosition scrollPosition, bool animated);
		
		[Export("insertSections:")]
		void InsertSections(NSIndexSet sections);
		
		[Export("deleteSections:")]
		void DeleteSections(NSIndexSet sections);
		
		[Export("reloadSections:")]
		void ReloadSections(NSIndexSet sections);
		
		[Export("moveSection:toSection:")]
		void MoveSection(int section, int newSection);
		
		[Export("insertItemsAtIndexPaths:")]
		void InsertItemsAtIndexPaths(NSIndexPath [] indexPaths);
		
		[Export("deleteItemsAtIndexPaths:")]
		void DeleteItemsAtIndexPaths(NSIndexPath [] indexPaths);
		
		[Export("reloadItemsAtIndexPaths:")]
		void ReloadItemsAtIndexPaths(NSIndexPath [] indexPaths);
		
		[Export("moveItemAtIndexPath:toIndexPath:")]
		void MoveItemAtIndexPath(NSIndexPath fromIndexPath, NSIndexPath toIndexPath);
		
		//		//TODO: Examine how to bind this
		//		- (void)performBatchUpdates:(void (^)(void))updates completion:(void (^)(BOOL finished))completion; // allows multiple insert/delete/reload/move calls to be animated simultaneously. Nestable.
		
		
		
	}
	
	//////////////////////////////////////////////////
	////		PSCollectionViewLayout.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSCollectionViewLayoutAttributes 
	{
		[Export("frame")]
		RectangleF Frame { get; set; }
		
		[Export("center")]
		PointF Center { get; set; }
		
		[Export("size")]
		SizeF Size { get; set; }
		
		[Export("transform3D")]
		CATransform3D Transform3D { get; set; }
		
		[Export("alpha")]
		float Alpha { get; set; }
		
		[Export("zIndex")]
		int ZIndex { get; set; }
		
		[Export("hidden")]
		bool Hidden { [Bind("isHidden")] get; set; }
		
		[Export("indexPath")]
		NSIndexPath IndexPath { get; set; }
		
		[Static][Export("layoutAttributesForCellWithIndexPath:")]
		NSObject LayoutAttributesForCellWithIndexPath (NSIndexPath indexPath);
		
		[Static][Export("layoutAttributesForSupplementaryViewOfKind:withIndexPath:")]
		NSObject LayoutAttributesForSupplementaryViewOfKind (string elementKind, NSIndexPath indexPath);
		
		[Static][Export("layoutAttributesForDecorationViewWithReuseIdentifier:withIndexPath:")]
		NSObject LayoutAttributesForDecorationViewWithReuseIdentifier (string reuseIdentifier, NSIndexPath indexPath);
		
		// Extension Methods
		
		[Export("representedElementKind")]
		string RepresentedElementKind { get; }
		
		[Export("representedElementCategory")]
		PSCollectionViewItemType RepresentedElementCategory { get; }
		
		[Bind ("isDecorationView")]
		bool IsDecorationView ();
		
		[Bind ("isSupplementaryView")]
		bool IsSupplementaryView ();
		
		[Bind ("isCell")]
		bool IsCell ();
	}
	
	[BaseType (typeof (NSObject))]
	interface PSCollectionViewUpdateItem 
	{
		[Export("indexPathBeforeUpdate")]
		NSIndexPath IndexPathBeforeUpdate { get; }
		
		[Export("indexPathAfterUpdate")]
		NSIndexPath IndexPathAfterUpdate { get; }
		
		[Export("updateAction")]
		PSCollectionUpdateAction UpdateAction { get; }
	}
	
	[BaseType (typeof (NSObject))]
	interface PSCollectionViewLayout 
	{
		[Export("collectionView")]
		PSCollectionView CollectionView { get; }
		
		[Export ("registerClass:forDecorationViewWithReuseIdentifier:")] 
		void RegisterClass (Class c, NSString id);
		
		[Export ("registerNib:forDecorationViewWithReuseIdentifier:")] 
		void RegisterNib (UINib nib, NSString id);
		
		// Extension methods SubclassingHooks
		
		[Bind("prepareLayout")]
		void PrepareLayout();
		
		[Bind("layoutAttributesForElementsInRect:")]
		PSCollectionViewLayoutAttributes [] LayoutAttributesForElementsInRect(RectangleF rect);
		
		[Bind("layoutAttributesForItemAtIndexPath:")]
		PSCollectionViewLayoutAttributes LayoutAttributesForElementsInRect(NSIndexPath indexPath);
		
		[Bind("layoutAttributesForSupplementaryViewOfKind:atIndexPath:")]
		PSCollectionViewLayoutAttributes LayoutAttributesForElementsInRect(string kind, NSIndexPath indexPath);
		
		[Bind("layoutAttributesForDecorationViewWithReuseIdentifier:atIndexPath:")]
		PSCollectionViewLayoutAttributes LayoutAttributesForDecorationViewWithReuseIdentifier(string identifier, NSIndexPath indexPath);
		
		[Bind("shouldInvalidateLayoutForBoundsChange:")]
		bool ShouldInvalidateLayoutForBoundsChange(RectangleF newBounds);
		
		[Bind("targetContentOffsetForProposedContentOffset:withScrollingVelocity:")]
		PointF TargetContentOffsetForProposedContentOffset(PointF proposedContentOffset, PointF velocity);
		
		[Bind("collectionViewContentSize")]
		SizeF CollectionViewContentSize();
		
		// Extension methods UpdateSupportHooks
		
		[Bind("prepareForCollectionViewUpdates:")]
		void PrepareForCollectionViewUpdates(PSCollectionViewUpdateItem [] updateItems);
		
		[Bind("finalizeCollectionViewUpdates")]
		void FinalizeCollectionViewUpdates();
		
		[Bind("initialLayoutAttributesForInsertedItemAtIndexPath:")]
		PSCollectionViewLayoutAttributes InitialLayoutAttributesForInsertedItemAtIndexPath(NSIndexPath itemIndexPath);
		
		[Bind("finalLayoutAttributesForDeletedItemAtIndexPath:")]
		PSCollectionViewLayoutAttributes FinalLayoutAttributesForDeletedItemAtIndexPath(NSIndexPath itemIndexPath);
		
		[Bind("finalLayoutAttributesForDeletedSupplementaryElementOfKind:atIndexPath:")]
		PSCollectionViewLayoutAttributes FinalLayoutAttributesForDeletedSupplementaryElementOfKind(string elementKind, NSIndexPath elementIndexPath);
		
		// Extension methods UpdateSupportHooks
		
		[Bind("setCollectionViewBoundsSize:")]
		void SetCollectionViewBoundsSize(SizeF size);
	}
	
	//////////////////////////////////////////////
	////		PSPDFNoteAnnotation.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFAnnotation))]
	interface PSPDFNoteAnnotation 
	{
		[Export ("initWithAnnotationDictionary:inAnnotsArray:")] [Internal]
		IntPtr Constructor (IntPtr /*CGPDFDictionaryRef*/ annotDict, IntPtr /*CGPDFArrayRef*/ annotsArray);
		
		[Export("iconName")]
		string IconName { get; set; }
	}
	
	//////////////////////////////////////////////
	////		PSPDFLineAnnotation.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFAnnotation))]
	interface PSPDFLineAnnotation 
	{
		[Export("point1", ArgumentSemantic.Assign)]
		PointF Point1 { get; set; }
		
		[Export("point2", ArgumentSemantic.Assign)]
		PointF Point2 { get; set; }
		
		[Export("lineEnd1", ArgumentSemantic.Assign)]
		PSPDFLineEndType LineEnd1 { get; set; }
		
		[Export("lineEnd2", ArgumentSemantic.Assign)]
		PSPDFLineEndType LineEnd2 { get; set; }
	}
	
	//////////////////////////////////////////////
	////		PSPDFLinkAnnotation.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFAnnotation))] // Este es asi solo
	interface PSPDFLinkAnnotation 
	{
		[Export("linkType", ArgumentSemantic.Assign)]
		PSPDFLinkAnnotationType LinkType { get; set; }
		
		[Export("pageLinkTarget", ArgumentSemantic.Assign)] [NullAllowed]
		uint PageLinkTarget { get; set; }
		
		[Export("siteLinkTarget")]
		string SiteLinkTarget { get; set; }
		
		[Export("URL")]
		NSUrl Url { get; set; }
		
		[Export("rects")]
		NSArray Rects { get; set; }
		
		[Export("options")]
		NSDictionary Options { get; set; }
		
		[Export("modal", ArgumentSemantic.Assign)]
		bool Modal { [Bind("isModal")] get; set; }
		
		[Export("popover", ArgumentSemantic.Assign)]
		bool Popover { [Bind("isPopover")] get; set; }
		
		[Export("size", ArgumentSemantic.Assign)]
		SizeF Size { get; set; }
		
		[Export("pageRef", ArgumentSemantic.Assign)] [Internal]
		IntPtr /*CGPDFDictionaryRef*/ PageRef_ { get; set; }
		
		[Export("destinationName")]
		string DestinationName { get; set; }
		
		[Export("linkURL")]
		string LinkURL { get; set; }
	}
	
	//////////////////////////////////////////////
	////		PSPDFShapeAnnotation.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFAnnotation))] 
	interface PSPDFShapeAnnotation 
	{
		[Export("shapeType", ArgumentSemantic.Assign)]
		PSPDFShapeAnnotationType ShapeType { get; set; }
	}
	
	//////////////////////////////////////////////////////
	////		PSPDFLinkAnnotationBaseView.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (UIView))] 
	interface PSPDFLinkAnnotationBaseView : PSPDFAnnotationView
	{
		[Export("linkAnnotation")]
		PSPDFLinkAnnotation LinkAnnotation { get; }
	}
	
	//////////////////////////////////////////////////
	////		PSPDFLinkAnnotationView.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFLinkAnnotationBaseView))] 
	interface PSPDFLinkAnnotationView
	{
		[Export("flashBackground")]
		void FlashBackground ();
		
		[Export("borderColor")]
		UIColor BorderColor { get; set; }
		
		[Export("highlightBackgroundColor")]
		UIColor HighlightBackgroundColor { get; set; }
		
		[Export("cornerRadius", ArgumentSemantic.Assign)]
		float CornerRadius { get; set; }
		
		[Export("strokeWidth", ArgumentSemantic.Assign)]
		float StrokeWidth { get; set; }
		
		[Export("pressedColor")]
		UIColor PressedColor { get; set; }
		
		[Export("hideSmallLinks", ArgumentSemantic.Assign)]
		bool HideSmallLinks { [Bind("shouldHideSmallLinks")] get; set; }
		
		[Export("overspan", ArgumentSemantic.Assign)]
		SizeF Overspan { get; set; }
		
		[Export("touchUp")]
		void TouchUp ();
	}
	
	//////////////////////////////////////////////////////
	////		PSPDFHighlightAnnotationView.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFLinkAnnotationBaseView))] 
	interface PSPDFHighlightAnnotationView 
	{
		[Export("button")]
		UIButton Button { get; }
		
		[Export("touchDown")]
		void TouchDown ();
		
		[Export("touchUp")]
		void TouchUp ();
	}
	
	//////////////////////////////////////////////////
	////		PSPDFVideoAnnotationView.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFLinkAnnotationBaseView))] 
	interface PSPDFVideoAnnotationView 
	{
		[Export("URL")]
		NSUrl Url { get; set; }
		
		[Export("autostartEnabled", ArgumentSemantic.Assign)]
		bool AutostartEnabled { [Bind("isAutostartEnabled")] get; set; }
		
		[Export("useApplicationAudioSession", ArgumentSemantic.Assign)]
		bool UseApplicationAudioSession { get; set; }
		
		[Export("player")]
		MPMoviePlayerController Player { get; }
	}
	
	//////////////////////////////////////////////////
	////		PSPDFWebAnnotationView.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFLinkAnnotationBaseView))] 
	interface PSPDFWebAnnotationView
	{
		
		[Export("shadowsHidden", ArgumentSemantic.Assign)]
		bool ShadowsHidden { get; set; }
		
		[Export("webView")]
		UIWebView WebView { get; }
	}
	
	//////////////////////////////////////////////////
	////		PSPDFWebViewController.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFBaseViewController))] 
	interface PSPDFWebViewController
	{
		
		[Static][Export("modalWebViewWithURL:")]
		UINavigationController ModalWebViewWithURL (NSUrl url);
		
		[Export("initWithURL:")]
		IntPtr Constructor (NSUrl url);
		
		[Export("availableActions", ArgumentSemantic.Assign)]
		PSPDFWebViewControllerAvailableActions AvailableActions { get; set; }
		
		[Export("webView")]
		UIWebView WebView { get; }
		
		[Export("popoverController")]
		UIPopoverController PopoverController { get; set; }
	}
	
	//////////////////////////////////////////////
	////		PSPDFSelectionView.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFSelectionViewDelegate 
	{		
		[Export ("selectionView:shouldStartSelectionAtPoint:")]
		bool ShouldStartSelectionAtPoint (PSPDFSelectionView selectionView, PointF point);
		
		[Export ("selectionView:updateSelectedRect:")]
		void UpdateSelectedRect (PSPDFSelectionView selectionView, RectangleF rect);
		
		[Export ("selectionView:finishedWithSelectedRect:")]
		void FinishedWithSelectedRect (PSPDFSelectionView selectionView, RectangleF rect);
		
		[Export ("selectionView:cancelledWithSelectedRect:")]
		void CancelledWithSelectedRect (PSPDFSelectionView selectionView, RectangleF rect);
	}
	
	[BaseType (typeof (UIView))]
	interface PSPDFSelectionView 
	{
		[Export("initWithFrame:delegate:")]
		IntPtr Constructor (RectangleF frame, PSPDFSelectionViewDelegate Delegate);
		
		[Wrap ("WeakDelegate")]
		PSPDFSelectionViewDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }
	}
	
	//////////////////////////////////////
	////		PSPDFCache.h			//
	//////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFCacheDelegate 
	{		
		[Export ("didCachePageForDocument:page:image:size:")] [Abstract]
		void DidCachePageForDocument (PSPDFDocument document, uint page, UIImage cachedImage, PSPDFSize size);
		
		[Export ("didFinishCachingDocument:")]
		void DidFinishCachingDocument (PSPDFDocument document);
	}
	
	[BaseType (typeof (NSObject))]
	interface PSPDFCache 
	{
		[Static][Export("sharedCache")]
		PSPDFCache SharedCache ();
		
		[Export("isDocumentCached:size:")]
		bool IsDocumentCached (PSPDFDocument document, PSPDFSize size);
		
		[Export("isImageCachedForDocument:page:size:")]
		bool IsImageCachedForDocument (PSPDFDocument document, uint page, PSPDFSize size);
		
		[Export("cachedImageForDocument:page:size:")]
		UIImage CachedImageForDocument (PSPDFDocument document, uint page, PSPDFSize size);
		
		[Export("cachedImageForDocument:page:size:preload:")]
		UIImage CachedImageForDocument (PSPDFDocument document, uint page, PSPDFSize size, bool preload);
		
		[Export("cachedImageForDocument:page:size:pdfPage:")] [Internal]
		MonoTouch.UIKit.UIImage CachedImageForDocument_ (PSPDFDocument document, uint page, PSPDFSize size, IntPtr /*CGPDFPageRef*/ pdfPage);
		
		[Export("cacheDocument:startAtPage:size:")]
		void CacheDocument (PSPDFDocument document, uint startPage, PSPDFSize size);
		
		[Export("cacheThumbnailsForDocument:")]
		bool CacheThumbnailsForDocument (PSPDFDocument document);
		
		[Export("stopCachingDocument:")]
		void StopCachingDocument (PSPDFDocument document);
		
		[Export("pauseCachingForService:")]
		bool PauseCachingForService (NSObject service);
		
		[Export("resumeCachingForService:")]
		bool ResumeCachingForService (NSObject service);
		
		[Export("removeCacheForDocument:deleteDocument:waitUntilDone:")]
		void ResumeCachingForService (PSPDFDocument document, bool deleteDocument, bool wait);
		
		[Export("clearCache")]
		bool ClearCache ();
		
		[Export("addDelegate:")]
		void AddDelegate (PSPDFCacheDelegate Delegate);
		
		[Export("removeDelegate:")]
		bool RemoveDelegate (PSPDFCacheDelegate Delegate);
		
		[Export("strategy", ArgumentSemantic.Assign)]
		PSPDFCacheStrategy Strategy { get; set; }
		
		[Export("numberOfMaximumCachedDocuments", ArgumentSemantic.Assign)]
		uint NumberOfMaximumCachedDocuments { get; set; }
		
		[Export("numberOfNearCachedPages", ArgumentSemantic.Assign)]
		uint NumberOfNearCachedPages { get; set; }
		
		[Export("useJPGFormat", ArgumentSemantic.Assign)]
		bool UseJPGFormat { get; set; }
		
		[Export("JPGFormatCompression", ArgumentSemantic.Assign)]
		float JPGFormatCompression { get; set; }
		
		[Export("useJPGTurbo", ArgumentSemantic.Assign)]
		bool UseJPGTurbo { get; set; }
		
		[Export("downscaleInterpolationQuality", ArgumentSemantic.Assign)]
		CGInterpolationQuality DownscaleInterpolationQuality { get; set; }
		
		[Export("thumbnailSize", ArgumentSemantic.Assign)]
		SizeF ThumbnailSize { get; set; }
		
		[Export("tinySize", ArgumentSemantic.Assign)]
		SizeF TinySize { get; set; }
		
		[Export("cacheDirectory", ArgumentSemantic.Copy)]
		string CacheDirectory { get; set; }
		
		// Extensions
		
		[Bind("cacheImage:document:page:size:")]
		void CacheImage (UIImage image, PSPDFDocument document, uint page, PSPDFSize size);
		
		[Bind("imageForDocument:page:size:")]
		UIImage ImageForDocument (PSPDFDocument document, uint page, PSPDFSize size);
		
		[Bind("clearMemoryCache")]
		void ClearMemoryCache ();
		
		[Bind("registerObject:")]
		void RegisterObject (NSObject Object);
		
		[Bind("deregisterObject:")]
		void DeregisterObject (NSObject Object);
		
		[Bind("printStatus")]
		void PrintStatus ();
	}
	
	[BaseType (typeof (NSObject))]
	interface PSPDFCacheQueuedDocument 
	{
		[Static][Export("queuedDocumentWithDocument:page:size:")]
		PSPDFCacheQueuedDocument QueuedDocumentWithDocument (PSPDFDocument document, uint page, PSPDFSize size);
		
		[Export("document")]
		PSPDFDocument Document { get; set; }
		
		[Export("page", ArgumentSemantic.Assign)]
		uint Page { get; set; }
		
		[Export("size", ArgumentSemantic.Assign)]
		PSPDFSize Size { get; set; }
		
		[Export("pagesCached")]
		NSMutableSet PagesCached { get; set; }
		
		[Export("caching", ArgumentSemantic.Assign)]
		bool Caching { [Bind("isCaching")] get; set; }
	}
	
	//////////////////////////////////////////////////////
	////		PSPDFOutlineViewController.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFOutlineViewControllerDelegate 
	{		
		[Export ("outlineController:didTapAtElement:")] [Abstract]
		void DidTapAtElement (PSPDFOutlineViewController outlineController, PSPDFOutlineElement outlineElement);
	}
	
	[BaseType (typeof (UITableViewController))]
	interface PSPDFOutlineViewController
	{
		[Export("initWithDocument:delegate:")]
		IntPtr Constructor (PSPDFDocument document, PSPDFOutlineViewControllerDelegate Delegate);
		
		[Export("allowCopy", ArgumentSemantic.Assign)]
		bool AllowCopy { get; set; }
		
		[Export("maximumNumberOfLines", ArgumentSemantic.Assign)]
		uint MaximumNumberOfLines { get; set; }
		
		[Wrap ("WeakDelegate")]
		PSPDFOutlineViewControllerDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }
		
		[Export("document")]
		PSPDFDocument Document { get; set; }
		
		//Extensions
		
		[Bind("updatePopoverSize")]
		void UpdatePopoverSize ();
		
		[Bind("outlineCellDidTapDisclosureButton:")]
		void OutlineCellDidTapDisclosureButton (PSPDFOutlineCell cell);
	}
	
	///////////////////////////////////////////
	////		PSPDFOutlineCell.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFOutlineCellDelegate 
	{		
		[Export ("outlineCellDidTapDisclosureButton:")] [Abstract]
		void DidTapDisclosureButton (PSPDFOutlineCell outlineCell);
	}
	
	[BaseType (typeof (UITableViewCell))]
	interface PSPDFOutlineCell
	{
		[Static][Export("heightForCellWithOutlineElement:constrainedToSize:")]
		float HeightForCellWithOutlineElement (PSPDFOutlineElement outlineElement, SizeF constraintSize);
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }
		
		[Export("document")]
		PSPDFOutlineCellDelegate Document { get; set; }
		
		[Export("outlineElement")]
		PSPDFOutlineElement OutlineElement { get; set; }
		
		//Extensions
		
		[Export("disclosureButton")]
		UIButton DisclosureButton { get; set; }
		
		[Bind("updateOutlineButton")]
		void UpdateOutlineButton ();
		
		[Bind("expandOrCollapse")]
		void ExpandOrCollapse ();
	}
	
	//////////////////////////////////////////////////////
	////		PSCollectionViewFlowLayout.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (PSCollectionViewDelegate))]
	[Model]
	interface PSCollectionViewDelegateFlowLayout 
	{		
		[Export ("collectionView:layout:sizeForItemAtIndexPath:")]
		SizeF SizeForItemAtIndexPath (PSCollectionView collectionView, PSCollectionViewLayout collectionViewLayout, NSIndexPath indexPath);
		
		[Export ("collectionView:layout:insetForSectionAtIndex:")]
		UIEdgeInsets InsetForSectionAtIndex (PSCollectionView collectionView, PSCollectionViewLayout collectionViewLayout, int section);
		
		[Export ("collectionView:layout:minimumLineSpacingForSectionAtIndex:")]
		float MinimumLineSpacingForSectionAtIndex (PSCollectionView collectionView, PSCollectionViewLayout collectionViewLayout, int section);
		
		[Export ("collectionView:layout:minimumInteritemSpacingForSectionAtIndex:")]
		float MinimumInteritemSpacingForSectionAtIndex (PSCollectionView collectionView, PSCollectionViewLayout collectionViewLayout, int section);
		
		[Export ("collectionView:layout:referenceSizeForHeaderInSection:")]
		SizeF ReferenceSizeForHeaderInSection (PSCollectionView collectionView, PSCollectionViewLayout collectionViewLayout, int section);
		
		[Export ("collectionView:layout:referenceSizeForFooterInSection:")]
		SizeF ReferenceSizeForFooterInSection (PSCollectionView collectionView, PSCollectionViewLayout collectionViewLayout, int section);
		
	}
	
	[BaseType (typeof (PSCollectionViewLayout))]
	interface PSCollectionViewFlowLayout
	{
		[Field ("PSCollectionElementKindSectionHeader", "__Internal")]
		NSString PSCollectionElementKindSectionHeader { get; }
		
		[Field ("PSCollectionElementKindSectionFooter", "__Internal")]
		NSString PSCollectionElementKindSectionFooter { get; }
		
		[Export ("minimumLineSpacing")]
		float MinimumLineSpacing { get; set; }
		
		[Export ("minimumInteritemSpacing")]
		float MinimumInteritemSpacing { get; set; }
		
		[Export ("itemSize")]
		SizeF ItemSize { get; set; }
		
		[Export ("scrollDirection")]
		PSCollectionViewScrollDirection ScrollDirection { get; set; }
		
		[Export ("headerReferenceSize")]
		SizeF HeaderReferenceSize { get; set; }
		
		[Export ("footerReferenceSize")]
		SizeF FooterReferenceSize { get; set; }
		
		[Export ("sectionInset")]
		UIEdgeInsets SectionInset { get; set; }
		
		[Export ("rowAlignmentOptions")]
		NSDictionary RowAlignmentOptions { get; set; }
		
		// Extensions Private API
		
		[Field ("PSFlowLayoutCommonRowHorizontalAlignmentKey", "__Internal")]
		NSString PSFlowLayoutCommonRowHorizontalAlignmentKey { get; }
		
		[Field ("PSFlowLayoutLastRowHorizontalAlignmentKey", "__Internal")]
		NSString PSFlowLayoutLastRowHorizontalAlignmentKey { get; }
		
		[Field ("PSFlowLayoutRowVerticalAlignmentKey", "__Internal")]
		NSString PSFlowLayoutRowVerticalAlignmentKey { get; }
		
		[Bind("synchronizeLayout")]
		SizeF SynchronizeLayout ();
		
		[Bind("initialLayoutAttributesForFooterInInsertedSection:")]
		PSCollectionViewLayoutAttributes InitialLayoutAttributesForFooterInInsertedSection (int section);
		
		[Bind("initialLayoutAttributesForHeaderInInsertedSection:")]
		PSCollectionViewLayoutAttributes InitialLayoutAttributesForHeaderInInsertedSection (int section);
		
		[Bind("initialLayoutAttributesForInsertedItemAtIndexPath:")][New]
		PSCollectionViewLayoutAttributes InitialLayoutAttributesForInsertedItemAtIndexPath (NSIndexPath indexPath);
		
		[Bind("finalLayoutAttributesForFooterInDeletedSection:")]
		PSCollectionViewLayoutAttributes FinalLayoutAttributesForFooterInDeletedSection (int section);
		
		[Bind("finalLayoutAttributesForHeaderInDeletedSection:")]
		PSCollectionViewLayoutAttributes FinalLayoutAttributesForHeaderInDeletedSection (int section);
		
		[Bind("finalLayoutAttributesForDeletedItemAtIndexPath:")]
		PSCollectionViewLayoutAttributes FinalLayoutAttributesForHeaderInDeletedSection (NSIndexPath indexPath);
		
		[Bind("_updateItemsLayout")]
		void _UpdateItemsLayout ();
		
		[Bind("_getSizingInfos")]
		void _GetSizingInfos ();
		
		[Bind("_updateDelegateFlags")]
		void _UpdateDelegateFlags ();
		
		[Bind("layoutAttributesForFooterInSection:")]
		PSCollectionViewLayoutAttributes LayoutAttributesForFooterInSection (int section);
		
		[Bind("layoutAttributesForHeaderInSection:")]
		PSCollectionViewLayoutAttributes LayoutAttributesForHeaderInSection (int section);
		
		[Bind("layoutAttributesForItemAtIndexPath:usingData:")]
		PSCollectionViewLayoutAttributes LayoutAttributesForItemAtIndexPath (NSIndexPath indexPath, NSObject data);
		
		[Bind("layoutAttributesForFooterInSection:usingData:")]
		PSCollectionViewLayoutAttributes LayoutAttributesForFooterInSection (int section, NSObject data);
		
		[Bind("layoutAttributesForHeaderInSection:usingData:")]
		PSCollectionViewLayoutAttributes LayoutAttributesForHeaderInSection (int section, NSObject data);
		
		[Bind("indexesForSectionFootersInRect:")]
		NSObject IndexesForSectionFootersInRect (RectangleF rect);
		
		[Bind("indexesForSectionHeadersInRect:")]
		NSObject IndexesForSectionHeadersInRect (RectangleF rect);
		
		[Bind("indexPathsForItemsInRect:usingData:")]
		NSObject IndexPathsForItemsInRect (RectangleF rect, NSObject arg2);
		
		[Bind("indexesForSectionFootersInRect:usingData:")]
		NSObject IndexesForSectionFootersInRect (RectangleF rect, NSObject arg2);
		
		[Bind("indexesForSectionHeadersInRect:usingData:")]
		NSObject IndexesForSectionHeadersInRect (RectangleF arg1, NSObject arg2);
		
		[Bind("_frameForItemAtSection:andRow:usingData:")]
		RectangleF _FrameForItemAtSectionAndRow (int arg1, int arg2, NSObject arg3);
		
		[Bind("_frameForFooterInSection:usingData:")]
		RectangleF _FrameForFooterInSection (int arg1, NSObject arg2);
		
		[Bind("_frameForHeaderInSection:usingData:")]
		RectangleF _FrameForHeaderInSection (int arg1, NSObject arg2);
		
		[Bind("_invalidateLayout")]
		void _InvalidateLayout ();
		
		[Bind("indexPathForItemAtPoint:")]
		NSIndexPath IndexPathForItemAtPoint (PointF arg1);
		
		[Bind("_layoutAttributesForItemsInRect:")]
		PSCollectionViewLayoutAttributes _LayoutAttributesForItemsInRect (RectangleF arg1);
		
		[Bind("collectionViewContentSize")][New]
		SizeF CollectionViewContentSize ();
		
		[Bind("finalizeCollectionViewUpdates")][New]
		void FinalizeCollectionViewUpdates ();
		
		[Bind("layoutAttributesForSupplementaryViewOfKind:atIndexPath:")]
		PSCollectionViewLayoutAttributes LayoutAttributesForSupplementaryViewOfKind (string kind, NSIndexPath indexPath);
		
		[Bind("_invalidateButKeepDelegateInfo")]
		void _InvalidateButKeepDelegateInfo ();
		
		[Bind("_invalidateButKeepAllInfo")]
		void _InvalidateButKeepAllInfo ();
		
		[Bind("shouldInvalidateLayoutForBoundsChange:")][New]
		bool ShouldInvalidateLayoutForBoundsChange (RectangleF arg1);
		
		[Bind("layoutAttributesForElementsInRect:")][New]
		NSObject LayoutAttributesForElementsInRect (RectangleF arg1);
		
		[Bind("invalidateLayout")]
		void InvalidateLayout ();
		
		[Bind("layoutAttributesForItemAtIndexPath:")]
		NSObject LayoutAttributesForItemAtIndexPath (NSObject arg1);
	}
	
	//////////////////////////////////////////////////////
	////		PSPDFThumbnailGridViewCell.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (PSCollectionViewCell))]
	interface PSPDFThumbnailGridViewCell : PSPDFCacheDelegate
	{
		[Export("document")]
		PSPDFDocument Document { get; set; }
		
		[Export("page", ArgumentSemantic.Assign)]
		uint Page { get; set; }
		
		[Export("edgeInsets", ArgumentSemantic.Assign)]
		UIEdgeInsets EdgeInsets { get; set; }
		
		[Export("shadowEnabled", ArgumentSemantic.Assign)]
		bool ShadowEnabled { [Bind("isShadowEnabled")] get; set; }
		
		[Export("showingSiteLabel", ArgumentSemantic.Assign)]
		bool ShowingSiteLabel { [Bind("isShowingSiteLabel")] get; set; }
		
		[Export("updateCell")]
		void UpdateCell ();
		
		// Extensions
		
		[Export ("imageView")]
		UIImageView ImageView { get; set; }
		
		[Export ("siteLabel")]
		UILabel SiteLabel { get; set; }
		
		[Bind ("pathShadowForView:")]
		NSObject PathShadowForView (UIView imgView);
		
		[Bind ("setImage:animated:")]
		void SetImage (UIImage image, bool animated);
		
		[Bind ("setImageSize:")]
		void SetImageSize (SizeF imageSize);
		
		[Bind ("thumbnailQueue")][Static]
		NSOperationQueue ThumbnailQueue ();
		
		[Bind ("updateSiteLabel")]
		void UpdateSiteLabel ();
	}
	
	//////////////////////////////////////////
	////		PSPDFScrobbleBar.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (UIView))]
	interface PSPDFScrobbleBar : PSPDFCacheDelegate
	{
		[Export ("pdfController")]
		PSPDFViewController PdfController { get; set; }
		
		[Export ("updateToolbar")]
		void UpdateToolbar ();
		
		[Export ("updatePageMarker")]
		void UpdatePageMarker ();
		
		[Export ("page", ArgumentSemantic.Assign)]
		uint Page { get; set; }
		
		[Export ("toolbar")]
		UIToolbar Toolbar { get; set; }
	}
	
	//////////////////////////////////////////////////
	////		PSPDFSearchHighlightView.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (UIView))]
	interface PSPDFSearchHighlightView : PSPDFAnnotationView
	{
		[Export ("initWithSearchResult:")]
		IntPtr Constructor (PSPDFSearchResult searchResult);
		
		[Export ("popupAnimation")]
		void PopupAnimation ();
		
		[Export ("searchResult")]
		PSPDFSearchResult SearchResult { get; set; }
	}
	
	//////////////////////////////////////////////////
	////		PSPDFSearchViewController.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (UITableViewController))]
	interface PSPDFSearchViewController : UISearchDisplayDelegateProtocol, UISearchBarDelegateProtocol, PSPDFCacheDelegate, PSPDFSearchDelegate, PSPDFStatusBarStyleHint
	{
		[Export ("initWithDocument:pdfController:")]
		IntPtr Constructor (PSPDFDocument document, PSPDFViewController pdfController);
		
		[Export ("searchText", ArgumentSemantic.Copy)]
		string SearchText { get; set; }
		
		[Export ("showsCancelButton", ArgumentSemantic.Assign)]
		bool ShowsCancelButton { get; set; }
		
		[Export ("searchBar")]
		UISearchBar SearchBar { get; }
		
		[Export ("searchStatus", ArgumentSemantic.Assign)]
		PSPDFSearchStatus SearchStatus { get; }
		
		[Export ("clearHighlightsWhenClosed", ArgumentSemantic.Assign)]
		bool ClearHighlightsWhenClosed { get; set; }
		
		[Export ("updateResultCell:searchResult:")]
		void UpdateResultCell (UITableViewCell cell, PSPDFSearchResult searchResult);
	}
	
	//////////////////////////////////////////
	////		PSPDFActionSheet.h			//
	//////////////////////////////////////////
	
	delegate void PSPDFActionSheetCancelButtonWithTitleBlock ();
	
	delegate void PSPDFActionSheetDestructiveButtonWithTitleBlock ();
	
	delegate void PSPDFActionSheetAddButtonWithTitleBlock ();
	
	delegate void PSPDFActionSheetSetDestroyBlock ();
	
	[BaseType (typeof (UIActionSheet))]
	interface PSPDFActionSheet 
	{
		// Use this ActionSheet only if needed. But UIActionSheet should suffice due to it already has events
		// PSPDFActionSheet is only a Helper to add block features to UIActionSheet. (Same to events in C# that UIActionSheet has)
		
		[Export ("initWithTitle:")]
		IntPtr Constructor (string title);
		
		[Export ("setCancelButtonWithTitle:block:")]
		void SetCancelButtonWithTitle (string title, PSPDFActionSheetCancelButtonWithTitleBlock block);
		
		[Export ("setDestructiveButtonWithTitle:block:")]
		void SetDestructiveButtonWithTitle (string title, PSPDFActionSheetDestructiveButtonWithTitleBlock block);
		
		[Export ("addButtonWithTitle:block:")]
		void AddButtonWithTitle (string title, PSPDFActionSheetAddButtonWithTitleBlock block);
		
		[Export ("buttonCount")][New]
		uint ButtonCount { get; }
		
		[Export ("destroy")]
		void Destroy ();
		
		[Export ("setDestroyBlock:")]
		void SetDestroyBlock (PSPDFActionSheetSetDestroyBlock block);
	}
	
	//////////////////////////////////////////
	////		PSPDFAlertView.h			//
	//////////////////////////////////////////
	
	delegate void PSPDFAlertViewCancelButtonWithTitleBlock ();
	
	delegate void PSPDFAlertViewAddButtonWithTitleBlock ();
	
	[BaseType (typeof (UIAlertView))]
	interface PSPDFAlertView 
	{
		// Use this UIAlertView only if needed. But UIAlertView should suffice due to it already has events
		// PSPDFAlertView is only a Helper to add block features to UIAlertView. (Same to events in C# that UIActionSheet has)
		
		[Export ("initWithTitle:")]
		IntPtr Constructor (string title);
		
		[Export ("initWithTitle:message:")]
		IntPtr Constructor (string title, string message);
		
		[Export ("setCancelButtonWithTitle:block:")]
		void SetCancelButtonWithTitle (string title, PSPDFAlertViewCancelButtonWithTitleBlock block);
		
		[Export ("addButtonWithTitle:block:")]
		void AddButtonWithTitle (string title, PSPDFAlertViewAddButtonWithTitleBlock block);
	}
	
	//////////////////////////////////////////
	////		PSPDFPasswordView.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFPasswordViewDelegate 
	{		
		[Export ("passwordView:didUnlockWithPassword:")][Abstract]
		void DidUnlockWithPassword (PSPDFPasswordView passwordView, string password);
		
		[Export ("passwordView:didFailToUnlockWithPassword:")]
		void DidFailToUnlockWithPassword (PSPDFPasswordView passwordView, string password);
		
		[Export ("passwordView:shouldlUnlockWithPassword:")]
		bool ShouldlUnlockWithPassword (PSPDFPasswordView passwordView, string password);
		
		[Export ("passwordView:willUnlockWithPassword:")]
		void WillUnlockWithPassword (PSPDFPasswordView passwordView, string password);
	}
	
	[BaseType (typeof (UIView))] 
	interface PSPDFPasswordView : UITextFieldDelegateProtocol
	{
		[Export ("becomeFirstResponder")][New]
		bool BecomeFirstResponder ();
		
		[Export ("document")]
		PSPDFDocument Document { get; set; }
		
		[Wrap ("WeakDelegate")]
		PSPDFPasswordViewDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }
		
		[Export ("shakeOnError", ArgumentSemantic.Assign)]
		bool ShakeOnError { get; set; }
	}
	
	//////////////////////////////////////////
	////		PSPDFPageRenderer.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (NSObject))] // Lonely class
	interface PSPDFPageRenderer 
	{
		[Field ("kPSPDFIgnoreDisplaySettings", "__Internal")]
		NSString PSPDFIgnoreDisplaySettings { get; }
		
		[Field ("kPSPDFPageColor", "__Internal")]
		NSString PSPDFPageColor { get; }
		
		[Field ("kPSPDFContentOpacity", "__Internal")]
		NSString PSPDFContentOpacity { get; }
		
		[Field ("kPSPDFInvertRendering", "__Internal")]
		NSString PSPDFInvertRendering { get; }
		
		[Field ("kPSPDFInterpolationQuality", "__Internal")]
		NSString PSPDFInterpolationQuality { get; }
		
		[Export ("renderPageRef:inContext:inRectangle:pageInfo:withAnnotations:options:")][Static][Internal]
		RectangleF RenderPage_ (IntPtr /*CGPDFPageRef*/ page, IntPtr /*CGContextRef*/ context, RectangleF rectangle, PSPDFPageInfo pageInfo, PSPDFAnnotation [] annotations, NSDictionary options);
		
		[Export ("renderPage:inContext:atPoint:withZoom:pageInfo:withAnnotations:options:")][Static][Internal]
		SizeF RenderPage_ (IntPtr /*CGPDFPageRef*/ page, IntPtr /*CGContextRef*/ context, PointF point, float zoom, PSPDFPageInfo pageInfo, PSPDFAnnotation [] annotations, NSDictionary options);
	}
	
	//////////////////////////////////////////
	////		PSPDFPositionView.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (UIView))]
	interface PSPDFPositionView 
	{
		[Export ("label")]
		UILabel Label { get; }
		
		[Export ("labelMargin", ArgumentSemantic.Assign)]
		float LabelMargin { get; set; }
		
		[Export ("pdfController")]
		PSPDFViewController PdfController { get; set; }
	}
	
	//////////////////////////////////////////////
	////		PSPDFPagedScrollView.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFScrollView))]
	interface PSPDFPagedScrollView 
	{
		[Export ("initWithTransitionViewController:")]
		IntPtr Constructor (UIViewController viewController);
		
		[Export ("contentController")]
		UIViewController ContentController { get; }
	}
	
	//////////////////////////////////////////////////
	////		PSPDFPageViewController.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (UIPageViewController))]
	interface PSPDFPageViewController : PSPDFTransitionProtocol, PSPDFTransitionHelperDelegate, UIPageViewControllerDelegateProtocol, UIPageViewControllerDataSourceProtocol
	{
		[Export ("initWithPDFController:")]
		IntPtr Constructor (PSPDFViewController pdfController);
		
		[Export ("useSolidBackground", ArgumentSemantic.Assign)]
		bool UseSolidBackground { get; set; }
		
		[Export ("clipToPageBoundaries", ArgumentSemantic.Assign)]
		bool ClipToPageBoundaries { get; set; }
	}
	
	//////////////////////////////////////////////
	////		PSPDFTransitionHelper.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFTransitionHelperDelegate 
	{		
		//		[Export ("pdfController")][Abstract]
		//		PSPDFViewController PdfController ();
		
		[Export ("viewControllers")][Abstract]
		PSPDFViewController [] ViewControllers ();
		
		[Export ("transitionHelper:changedToPage:doublePageMode:forwardTransition:animated:")][Abstract]
		void TransitionHelperChangedToPage (PSPDFTransitionHelper transitionHelper, uint page, bool doublePageMode, bool forwardTransition, bool animated);
	}
	
	[BaseType (typeof (NSObject))]
	interface PSPDFTransitionHelper : PSPDFSinglePageViewControllerDelegate
	{
		[Export ("initWithDelegate:")]
		IntPtr Constructor (PSPDFTransitionHelperDelegate Delegate);
		
		[Export ("delegate")]
		PSPDFTransitionHelperDelegate Delegate { get; }
		
		[Export ("page", ArgumentSemantic.Assign)]
		uint Page { get; }
		
		[Export ("setPage:animated:")]
		void SetPage (uint page, bool animated);
		
		[Export ("visiblePageNumbers")]
		NSArray VisiblePageNumbers ();
		
		[Export ("pageViewForPage:")]
		PSPDFPageView PageViewForPage (uint page);
		
		// Extensions
		
		[Bind ("singlePageControllerForPage:")]
		PSPDFSinglePageViewController SinglePageControllerForPage (uint page);
		
		[Bind ("fixPageNumberForDoublePageMode:forceDoublePageMode:")]
		uint FixPageNumberForDoublePageMode (uint page, bool forceDualPageMode);
		
		[Bind ("viewControllerAfterViewController:")]
		PSPDFSinglePageViewController ViewControllerAfterViewController (UIViewController viewController);
		
		[Bind ("viewControllerBeforeViewController:")]
		PSPDFSinglePageViewController ViewControllerBeforeViewController (UIViewController viewController);
		
		[Bind ("setPageInternal:")]
		void SetPageInternal (uint page);
	}
	
	//////////////////////////////////////////////////
	////		PSPDFTransitionProtocol.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFTransitionProtocol 
	{
		[Export ("setPage:animated:")]
		void SetPage (uint page, bool animated);
		
		[Export ("visiblePageNumbers")]
		NSNumber [] VisiblePageNumbers ();
		
		[Export ("pageViewForPage:")][NullAllowed]
		PSPDFPageView PageViewForPage (uint page);
		
		[Export ("pdfController")]
		PSPDFViewController PdfController { get; set; }
		
		[Export ("scrollView")]
		PSPDFPagedScrollView ScrollView { get; set; }
		
		[Export ("visiblePageViews")]
		PSPDFPageView [] VisiblePageViews ();
	}
	
	//////////////////////////////////////////////////////
	////		PSPDFSinglePageViewController.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFSinglePageViewControllerDelegate 
	{		
		[Export ("pspdfSinglePageViewControllerReadyForReuse:")][Abstract]
		void PspdfSinglePageViewControllerReadyForReuse (PSPDFSinglePageViewController singlePageViewController);
		
		[Export ("pspdfSinglePageViewControllerWillDealloc:")][Abstract]
		void PspdfSinglePageViewControllerWillDealloc (PSPDFSinglePageViewController singlePageViewController);
	}
	
	
	[BaseType (typeof (PSPDFBaseViewController))] 
	interface PSPDFSinglePageViewController 
	{
		[Export ("initWithPDFController:page:")]
		IntPtr Constructor (PSPDFViewController pdfController, uint page);
		
		[Export ("prepareForReuse")]
		void PrepareForReuse ();
		
		[Export ("pdfController")]
		PSPDFViewController PdfController { get; set; }
		
		[Export ("pageView")]
		PSPDFPageView PageView { get; }
		
		[Export ("page", ArgumentSemantic.Assign)]
		uint Page { get; set; }
		
		[Export ("useSolidBackground", ArgumentSemantic.Assign)]
		bool UseSolidBackground { get; set; }
		
		[Wrap ("WeakDelegate")]
		PSPDFSinglePageViewControllerDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }
	}
	
	//////////////////////////////////////////////////
	////		PSPDFTabbedViewController.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFTabbedViewControllerDelegate 
	{		
		[Export ("tabbedPDFController:shouldChangeDocuments:")]
		bool ShouldChangeDocuments (PSPDFTabbedViewController tabbedPDFController, PSPDFDocument [] newDocuments);
		
		[Export ("tabbedPDFController:didChangeDocuments:")]
		void DidChangeDocuments (PSPDFTabbedViewController tabbedPDFController, PSPDFDocument [] oldDocuments);
		
		[Export ("tabbedPDFController:willChangeVisibleDocument:")]
		bool WillChangeVisibleDocument (PSPDFTabbedViewController tabbedPDFController, PSPDFDocument newDocument);
		
		[Export ("tabbedPDFController:didChangeVisibleDocument:")]
		bool DidChangeVisibleDocument (PSPDFTabbedViewController tabbedPDFController, PSPDFDocument oldDocument);
	}
	
	
	[BaseType (typeof (PSPDFBaseViewController))] 
	interface PSPDFTabbedViewController 
	{
		[Export ("initWithPDFViewController:")]
		IntPtr Constructor ( [NullAllowed] PSPDFViewController pdfViewController);
		
		[Export ("visibleDocument")]
		PSPDFDocument VisibleDocument { get; set; }
		
		[Export ("documents")]
		PSPDFDocument [] Documents { get; set; }
		
		[Export ("addDocuments:atIndex:animated:")]
		void AddDocuments (PSPDFDocument [] documents, uint index, bool animated);
		
		[Export ("removeDocuments:animated:")]
		void RemoveDocuments (PSPDFDocument [] documents, bool animated);
		
		[Wrap ("WeakDelegate")]
		PSPDFTabbedViewControllerDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }
		
		[Export ("enableAutomaticStatePersistance", ArgumentSemantic.Assign)]
		bool EnableAutomaticStatePersistance { get; set; }
		
		[Export ("persistState")]
		void PersistState ();
		
		[Export ("restoreState")]
		bool RestoreState ();
		
		[Export ("restoreStateAndMergeWithDocuments:")]
		bool RestoreStateAndMergeWithDocuments (PSPDFDocument [] documents);
		
		[Export ("statePersistanceKey", ArgumentSemantic.Copy)]
		string StatePersistanceKey { get; set; }
		
		[Export ("minTabWidth", ArgumentSemantic.Assign)]
		float MinTabWidth { get; set; }
		
		[Export ("pdfViewController")]
		PSPDFViewController PdfViewController { get; }
		
		[Export ("tabBar")]
		PSPDFTabBarView TabBar { get; }
	}
	
	//////////////////////////////////////////
	////		PSPDFTabBarView.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFTabBarViewDelegate 
	{		
		[Export ("tabBarView:didSelectTabAtIndex:")][Abstract]
		void DidSelectTabAtIndex (PSPDFTabBarView tabBarView, uint index);
		
		[Export ("tabBarView:didSelectCloseButtonOfTabAtIndex:")][Abstract]
		void DidSelectCloseButtonOfTabAtIndex (PSPDFTabBarView tabBarView, uint index);
	}
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFTabBarViewDataSource 
	{		
		[Export ("numberOfTabsInTabBarView:")][Abstract]
		int NumberOfTabsInTabBarView (PSPDFTabBarView tabBarView);
		
		[Export ("tabBarView:titleForTabAtIndex:")][Abstract]
		string TitleForTabAtIndex (PSPDFTabBarView tabBarView, uint index);
	}
	
	[BaseType (typeof (UIView))] 
	interface PSPDFTabBarView : UIScrollViewDelegateProtocol
	{
		[Export ("reloadData")]
		void ReloadData ();
		
		[Export ("selectTabAtIndex:animated:")]
		void SelectTabAtIndex (uint index, bool animated);
		
		[Export ("scrollToTabAtIndex:animated:")]
		void ScrollToTabAtIndex (uint index, bool animated);
		
		[Export ("selectedTabIndex")]
		uint SelectedTabIndex { get; }
		
		[Export ("minTabWidth", ArgumentSemantic.Assign)]
		float MinTabWidth { get; set; }
		
		[Wrap ("WeakDelegate")]
		PSPDFTabBarViewDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }
		
		[Wrap ("WeakDataSource")]
		PSPDFTabBarViewDelegate DataSource { get; set; }
		
		[Export ("dataSource", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDataSource { get; set; }
	}
	
	//////////////////////////////////////////////////
	////		PSPDFTransparentToolbar.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (UIToolbar))] // Lonely class
	interface PSPDFTransparentToolbar 
	{
		
	}
	
	//////////////////////////////////////////////////
	////		PSPDFFreeTextAnnotation.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFAnnotation))] // Lonely class
	interface PSPDFFreeTextAnnotation 
	{
		
	}
	
	//////////////////////////////////////
	////		PSPDFHUDView.h			//
	//////////////////////////////////////
	
	[BaseType (typeof (UIView))] // Lonely class
	interface PSPDFHUDView 
	{
		
	}
	
	//////////////////////////////////////////////////
	////		UIImage+PSPDFKitAdditions.h			//
	////	Could not attach to UIImage so created	//
	//// 			its own helper class 			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (UIImage))] // Extends UIImage Class
	interface UIImageExtension
	{
		
		[Bind("pspdf_imageToFitSize:method:honorScaleFactor:opaque:")]
		UIImage Pspdf_imageToFitSize (SizeF fitSize, PSPDFImageResizingMethod resizeMethod, bool honorScaleFactor, bool opaque);
		
		[Bind("pspdf_imageWithContentsOfResolutionIndependentFile:")][Static]
		UIImage Pspdf_imageWithContentsOfResolutionIndependentFile (string path);
		
		[Export("initWithContentsOfResolutionIndependentFile_pspdf:")]
		IntPtr Constructor (string pathToContentsOfResolutionIndependentFile);
		
		[Bind("pspdf_preloadedImageWithContentsOfFile:")][Static]
		UIImage Pspdf_preloadedImageWithContentsOfFile (string path);
		
		[Bind("pspdf_preloadedImage")]
		UIImage Pspdf_preloadedImage ();
		
		[Bind("pspdf_preloadedImageWithContentsOfFile:useJPGTurbo:")][Static]
		UIImage Pspdf_preloadedImageWithContentsOfFile (string imagePath, bool useJPGTurbo);
		
		[Bind("pspdf_preloadedImageWithData:useJPGTurbo:")][Static]
		UIImage Pspdf_preloadedImageWithData (NSData data, bool useJPGTurbo);
		
		[Bind("pspdf_imageNamed:bundle:")][Static]
		UIImage Pspdf_imageNamedBundle (string imageName, NSBundle bundle);
		
		[Bind("pdpdf_imageTintedWithColor:fraction:")]
		UIImage Pdpdf_imageTintedWithColor (UIColor color, float fraction);
		
		[Since (5,0)]
		[Bind("pspdf_animatedGIFWithPath:")][Static]
		UIImage Pspdf_animatedGIFWithPath (string path);
	}
	
	// Protocols
	
	interface UISearchDisplayDelegateProtocol 
	{
		[Export ("searchDisplayControllerWillBeginSearch:")]
		void SearchDisplayControllerWillBeginSearch (UISearchDisplayController controller);
		
		[Export ("searchDisplayControllerDidBeginSearch:")]
		void SearchDisplayControllerDidBeginSearch (UISearchDisplayController controller);
		
		[Export ("searchDisplayControllerWillEndSearch:")]
		void SearchDisplayControllerWillEndSearch (UISearchDisplayController controller);
		
		[Export ("searchDisplayControllerDidEndSearch:")]
		void SearchDisplayControllerDidEndSearch (UISearchDisplayController controller);
		
		[Export ("searchDisplayController:didLoadSearchResultsTableView:")]
		void SearchDisplayControllerDidLoadSearchResultsTableView (UISearchDisplayController controller, UITableView tableView);
		
		[Export ("searchDisplayController:willUnloadSearchResultsTableView:")]
		void SearchDisplayControllerWillUnloadSearchResultsTableView (UISearchDisplayController controller, UITableView tableView);
		
		[Export ("searchDisplayController:willShowSearchResultsTableView:")]
		void SearchDisplayControllerWillShowSearchResultsTableView (UISearchDisplayController controller, UITableView tableView);
		
		[Export ("searchDisplayController:didShowSearchResultsTableView:")]
		void SearchDisplayControllerDidShowSearchResultsTableView (UISearchDisplayController controller, UITableView tableView);
		
		[Export ("searchDisplayController:willHideSearchResultsTableView:")]
		void SearchDisplayControllerWillHideSearchResultsTableView (UISearchDisplayController controller, UITableView tableView);
		
		[Export ("searchDisplayController:didHideSearchResultsTableView:")]
		void SearchDisplayControllerDidHideSearchResultsTableView (UISearchDisplayController controller, UITableView tableView);
		
		[Export ("searchDisplayController:shouldReloadTableForSearchString:")]
		bool SearchDisplayControllerShouldReloadTableForSearchString (UISearchDisplayController controller, string searchString);
		
		[Export ("searchDisplayController:shouldReloadTableForSearchScope:")]
		bool SearchDisplayControllerShouldReloadTableForSearchScope (UISearchDisplayController controller, int searchOption);
	}
	
	interface UISearchBarDelegateProtocol 
	{
		[Export ("searchBarShouldBeginEditing:")]
		bool SearchBarShouldBeginEditing (UISearchBar searchBar);
		
		[Export ("searchBarTextDidBeginEditing:")]
		void SearchBarTextDidBeginEditing (UISearchBar searchBar);
		
		[Export ("searchBarShouldEndEditing:")]
		bool SearchBarShouldEndEditing (UISearchBar searchBar);
		
		[Export ("searchBarTextDidEndEditing:")]
		void SearchBarTextDidEndEditing (UISearchBar searchBar);
		
		[Export ("searchBar:textDidChange:")]
		void SearchBarTextDidChange (UISearchBar searchBar, string searchText);
		
		[Export ("searchBar:shouldChangeTextInRange:replacementText:")]
		bool SearchBarShouldChangeTextInRangeReplacementText (UISearchBar searchBar, NSRange range, string text);
		
		[Export ("searchBarSearchButtonClicked:")]
		void SearchBarSearchButtonClicked (UISearchBar searchBar);
		
		[Export ("searchBarBookmarkButtonClicked:")]
		void SearchBarBookmarkButtonClicked (UISearchBar searchBar);
		
		[Export ("searchBarCancelButtonClicked:")]
		void SearchBarCancelButtonClicked (UISearchBar searchBar);
		
		[Export ("searchBarResultsListButtonClicked:")]
		void SearchBarResultsListButtonClicked (UISearchBar searchBar);
		
		[Export ("searchBar:selectedScopeButtonIndexDidChange:")]
		void SearchBarSelectedScopeButtonIndexDidChange (UISearchBar searchBar, int selectedScope);
	}
	
	interface UITextFieldDelegateProtocol 
	{
		[Export ("textFieldShouldBeginEditing:")]
		bool TextFieldShouldBeginEditing (UITextField textField);
		
		[Export ("textFieldDidBeginEditing:")]
		void TextFieldDidBeginEditing (UITextField textField);
		
		[Export ("textFieldShouldEndEditing:")]
		bool TextFieldShouldEndEditing (UITextField textField);
		
		[Export ("textFieldDidEndEditing:")]
		void TextFieldDidEndEditing (UITextField textField);
		
		[Export ("textField:shouldChangeCharactersInRange:replacementString:")]
		bool TextFielShouldChangeCharactersInRange (UITextField textField, NSRange range, string text);
		
		[Export ("textFieldShouldClear:")]
		bool TextFieldShouldClear (UITextField textField);
		
		[Export ("textFieldShouldReturn:")]
		bool TextFieldShouldReturn (UITextField textField);
	}
	
	
	
	interface UIPageViewControllerDelegateProtocol 
	{
		[Export ("pageViewController:didFinishAnimating:previousViewControllers:transitionCompleted:")]
		void PageViewControllerDidFinishAnimating (UIPageViewController pageViewController, bool finished, UIViewController[] previousViewControllers, bool completed);
		
		[Export ("pageViewController:spineLocationForInterfaceOrientation:")]
		UIPageViewControllerSpineLocation PageViewControllerGetSpineLocation (UIPageViewController pageViewController, UIInterfaceOrientation orientation);
	}
	
	interface UIPageViewControllerDataSourceProtocol 
	{
		[Export ("pageViewController:viewControllerBeforeViewController:")][Abstract]
		void PageViewControllerViewControllerBeforeViewController (UIPageViewController pageViewController, UIViewController viewController);
		
		[Export ("pageViewController:viewControllerAfterViewController:")][Abstract]
		void PageViewControllerViewControllerAfterViewController (UIPageViewController pageViewController, UIViewController viewController);
	}
	
	interface UIScrollViewDelegateProtocol 
	{
		[Export ("scrollViewDidScroll:")]
		void ScrollViewDidScroll (UIScrollView scrollView);
		
		[Export ("scrollViewDidZoom:")]
		void ScrollViewDidZoom (UIScrollView scrollView);
		
		[Export ("scrollViewWillBeginDragging:")]
		void ScrollViewWillBeginDragging (UIScrollView scrollView);
		
		[Export ("scrollViewWillEndDragging:withVelocity:targetContentOffset:")]
		void ScrollViewWillEndDragging (UIScrollView scrollView, PointF velocity, ref PointF targetContentOffset);
		
		[Export ("scrollViewDidEndDragging:willDecelerate:")]
		void ScrollViewDidEndDragging (UIScrollView scrollView, bool decelerate);
		
		[Export ("scrollViewWillBeginDecelerating:")]
		void ScrollViewWillBeginDecelerating (UIScrollView scrollView);
		
		[Export ("scrollViewDidEndDecelerating:")]
		void ScrollViewDidEndDecelerating (UIScrollView scrollView);
		
		[Export ("scrollViewDidEndScrollingAnimation:")]
		void ScrollViewDidEndScrollingAnimation (UIScrollView scrollView);
		
		[Export ("viewForZoomingInScrollView:")][NullAllowed]
		UIView ViewForZoomingInScrollView (UIScrollView scrollView);
		
		[Export ("scrollViewWillBeginZooming:withView:")]
		void ScrollViewWillBeginZooming (UIScrollView scrollView, UIView view);
		
		[Export ("scrollViewDidEndZooming:withView:atScale:")]
		void ScrollViewDidEndZooming (UIScrollView scrollView, UIView view, float scale);
		
		[Export ("scrollViewShouldScrollToTop:")]
		bool ScrollViewShouldScrollToTop (UIScrollView scrollView);
		
		[Export ("scrollViewDidScrollToTop:")]
		void ScrollViewDidScrollToTop (UIScrollView scrollView);
	}	
}

