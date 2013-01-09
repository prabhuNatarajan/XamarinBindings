using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.CoreAnimation;
using MonoTouch.MediaPlayer;
using MonoTouch.MessageUI;

namespace AlexTouch.PSPDFKit
{	
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

		[Export ("tryLockWithDocument:page:error:")][Internal]
		IntPtr /*CGPDFPage*/ TryLockWithDocumentPageError_ (PSPDFDocument document, uint page, out NSError error);
		
		[Export ("lockWithDocument:page:error:")] [Internal]
		IntPtr /*CGPDFPage*/ LockWithDocumentPageError_ (PSPDFDocument document, uint page, out NSError error);
		
		[Export ("freeWithPDFPageRef:")][Internal]
		void _FreeWithPDFPageRef(IntPtr /*CGPDFPage*/ pdfPage, bool unusedArg);
		
		[Export("lockGlobal")]
		void LockGlobal();
		
		[Export("unlockGlobal")]
		void UnlockGlobal();
		
		[Export("requestClearCacheAndWait:")]
		void RequestClearCacheAndWait(bool wait);

		[Export("hasOpenDocumentRef")]
		bool HasOpenDocumentRef { get; set; }
	}

	//////////////////////////////////
	////	PSPDFViewController.h	//
	//////////////////////////////////

	delegate void PSPDFViewControllerUpdateSettingsBlock (PSPDFViewController pdfController, UIInterfaceOrientation toInterfaceOrientation);
	
	[BaseType (typeof (PSPDFBaseViewController),
	Delegates=new string [] {"WeakDelegate"},
	Events=new Type [] { typeof (PSPDFViewControllerDelegate) })]
	interface PSPDFViewController
	{
		[Export ("initWithDocument:")]
		IntPtr Constructor (PSPDFDocument document);
		
		[Export ("page", ArgumentSemantic.Assign)]
		uint Page { get; set; }
		
		[Export("setPage:animated:")]
		bool SetPageAnimated(uint page, bool animated);
		
		[Export("scrollToNextPageAnimated:")]
		bool ScrollToNextPageAnimated(bool animated);
		
		[Export("scrollToPreviousPageAnimated:")]
		bool ScrollToPreviousPageAnimated(bool animated);

		[Export ("screenPage", ArgumentSemantic.Assign)]
		uint ScreenPage { get; }
		
		[Export("scrollRectToVisible:animated:")]
		void ScrollRectToVisibleAnimated(RectangleF rec, bool animated);
		
		[Export("zoomToRect:animated:")]
		void ZoomToRectAnimated (RectangleF rec, bool animated);

		[Export("setZoomScale:animated:")]
		void SetZoomScale (float scale, bool animated);
		
		[Export ("viewState")]
		PSPDFViewState ViewState { get; set; }
		
		[Export("setViewState:animated:")] [PostGet ("ViewState")]
		void SetViewStateAnimated(PSPDFViewState viewState, bool animated);

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

		[Export ("renderAnnotationTypes", ArgumentSemantic.Assign)]
		PSPDFAnnotationType RenderAnnotationTypes { get; set; }
		
		[Export ("HUDView")]
		PSPDFHUDView HUDView { get; }
		
		[Export ("HUDViewMode", ArgumentSemantic.Assign)]
		PSPDFHUDViewMode HUDViewMode { get; set; }
		
		[Export ("HUDVisible", ArgumentSemantic.Assign)]
		bool HUDVisible { [Bind ("isHUDVisible")] get; set; }
		
		[Export("setHUDVisible:animated:")] [PostGet ("HUDVisible")]
		bool SetHUDVisibleAnimated(bool show, bool animated);
		
		[Export("showControlsAnimated:")]
		bool ShowControls(bool animated);
		
		[Export("hideControlsAnimated:")]
		bool HideControls(bool animated);
		
		[Export("hideControlsAndPageElementsAnimated:")]
		bool HideControlsAndPageElements(bool animated);
		
		[Export("toggleControlsAnimated:")]
		bool ToggleControls(bool animated);
		
		[Export ("toolbarEnabled", ArgumentSemantic.Assign)]
		bool ToolbarEnabled { [Bind ("isToolbarEnabled")] get; set; }
		
		[Export ("scrobbleBarEnabled", ArgumentSemantic.Assign)]
		bool ScrobbleBarEnabled { [Bind ("isScrobbleBarEnabled")] get; set; }

		[Export ("pageLabelEnabled", ArgumentSemantic.Assign)]
		bool PageLabelEnabled { [Bind ("isPageLabelEnabled")] get; set; }

		[Export ("documentLabelEnabled", ArgumentSemantic.Assign)]
		bool DocumentLabelEnabled { [Bind ("isDocumentLabelEnabled")] get; set; }

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

		[Export ("scrollOnTapPageEndMargin", ArgumentSemantic.Assign)]
		float ScrollOnTapPageEndMargin { get; set; }

		[Export ("internalTapGesturesEnabled", ArgumentSemantic.Assign)]
		bool InternalTapGesturesEnabled { get; set; }

		[Export ("textSelectionEnabled", ArgumentSemantic.Assign)]
		bool TextSelectionEnabled { [Bind ("isTextSelectionEnabled")] get; set; }

		[Export ("imageSelectionEnabled", ArgumentSemantic.Assign)]
		bool ImageSelectionEnabled { [Bind ("isImageSelectionEnabled")] get; set; }

		[Export ("passwordDialogEnabled", ArgumentSemantic.Assign)]
		bool PasswordDialogEnabled { [Bind("isPasswordDialogEnabled")] get; set; }

		[Export ("useParentNavigationBar", ArgumentSemantic.Assign)]
		bool UseParentNavigationBar { get; set; }
		
		[Export ("linkAction", ArgumentSemantic.Assign)]
		PSPDFLinkAction LinkAction { get; set; }
		
		[Export ("closeButtonItem")]
		PSPDFCloseBarButtonItem CloseButtonItem { get; }
		
		[Export ("outlineButtonItem")]
		PSPDFOutlineBarButtonItem OutlineButtonItem { get; }
		
		[Export ("searchButtonItem")]
		PSPDFSearchBarButtonItem SearchButtonItem { get; }
		
		[Export ("viewModeButtonItem")]
		PSPDFViewModeBarButtonItem ViewModeButtonItem { get; }
		
		[Export ("printButtonItem")]
		PSPDFPrintBarButtonItem PrintButtonItem { get; }
		
		[Export ("openInButtonItem")]
		PSPDFOpenInBarButtonItem OpenInButtonItem { get; }
		
		[Export ("emailButtonItem")]
		PSPDFEmailBarButtonItem EmailButtonItem { get; }
		
		[Export ("annotationButtonItem")]
		PSPDFAnnotationBarButtonItem AnnotationButtonItem { get; }
		
		[Export ("bookmarkButtonItem")]
		PSPDFBookmarkBarButtonItem BookmarkButtonItem { get; }

		[Export ("brightnessButtonItem")]
		PSPDFBrightnessBarButtonItem BrightnessButtonItem { get; }

		[Export ("activityButtonItem")]
		PSPDFActivityBarButtonItem ActivityButtonItem { get; }

		[Export ("additionalActionsButtonItem")]
		PSPDFMoreBarButtonItem AdditionalActionsButtonItem { get; }
		
		[Export ("leftBarButtonItems", ArgumentSemantic.Copy)]
		PSPDFBarButtonItem [] LeftBarButtonItems { get; set; }
		
		[Export ("rightBarButtonItems", ArgumentSemantic.Copy)]
		PSPDFBarButtonItem [] RightBarButtonItems { get; set; }
		
		[Export ("additionalRightBarButtonItems", ArgumentSemantic.Copy)][NullAllowed]
		PSPDFBarButtonItem [] AdditionalRightBarButtonItems { get; set; }
		
		[Export ("barButtonItemsAlwaysEnabled", ArgumentSemantic.Copy)]
		UIBarButtonItem [] BarButtonItemsAlwaysEnabled { get; set; }
		
		[Export ("minLeftToolbarWidth", ArgumentSemantic.Assign)]
		float MinLeftToolbarWidth { get; set; }
		
		[Export ("minRightToolbarWidth", ArgumentSemantic.Assign)]
		float MinRightToolbarWidth { get; set; }

		[Export ("useBorderedToolbarStyle", ArgumentSemantic.Assign)]
		bool UseBorderedToolbarStyle { get; set; }

		[Export ("pageMode", ArgumentSemantic.Assign)]
		PSPDFPageMode PageMode { get; set; }
		
		[Export ("pageTransition", ArgumentSemantic.Assign)]
		PSPDFPageTransition PageTransition { get; set; }
		
		[Export ("scrollDirection", ArgumentSemantic.Assign)]
		PSPDFScrollDirection ScrollDirection { get; set; }
		
		[Export ("doublePageModeOnFirstPage", ArgumentSemantic.Assign)]
		bool DoublePageModeOnFirstPage { [Bind ("isDoublePageModeOnFirstPage")] get; set; }
		
		[Export ("zoomingSmallDocumentsEnabled", ArgumentSemantic.Assign)]
		bool ZoomingSmallDocumentsEnabled { [Bind ("isZoomingSmallDocumentsEnabled")] get; set; }
		
		[Export ("pageCurlDirectionLeftToRight", ArgumentSemantic.Assign)]
		bool PageCurlDirectionLeftToRight { [Bind ("isPageCurlDirectionLeftToRight")] get; set; }
		
		[Export ("fitToWidthEnabled", ArgumentSemantic.Assign)]
		bool FitToWidthEnabled { [Bind ("isFitToWidthEnabled")] get; set; }
		
		[Export ("fixedVerticalPositionForFitToWidthEnabledMode", ArgumentSemantic.Assign)]
		bool FixedVerticalPositionForfitToWidthEnabledMode { get; set; }
		
		[Export ("clipToPageBoundaries", ArgumentSemantic.Assign)]
		bool ClipToPageBoundaries { get; set; }

		[Export ("minimumZoomScale", ArgumentSemantic.Assign)]
		float MinimumZoomScale { get; set; }

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

		[Export ("shouldTintPopovers", ArgumentSemantic.Assign)]
		bool ShouldTintPopovers { get; set; }

		[Export ("shouldTintAlertView", ArgumentSemantic.Assign)]
		bool ShouldTintAlertView { get; set; }

		[Export ("alertViewTintColor")]
		UIColor AlertViewTintColor ();

		[Export ("isNavigationBarHidden", ArgumentSemantic.Assign)]
		bool NavigationBarHidden { get; }
		
		[Export ("annotationAnimationDuration", ArgumentSemantic.Assign)]
		float AnnotationAnimationDuration { get; set; }

		[Export ("createAnnotationMenuEnabled", ArgumentSemantic.Assign)]
		float CreateAnnotationMenuEnabled { [Bind("isCreateAnnotationMenuEnabled")] get; set; }
		
		[Export ("pageViewForPage:")][NullAllowed]
		PSPDFPageView PageViewForPage (uint page);
		
		[Export ("popoverController")][NullAllowed]
		UIPopoverController PopoverController { get; set; }
		
		[Export ("pagingScrollView")]
		UIScrollView PagingScrollView { get; }
		
		[Export ("viewMode", ArgumentSemantic.Assign)]
		PSPDFViewMode ViewMode { get; set; }
		
		[Export ("setViewMode:animated:")] [PostGet ("ViewMode")]
		void setViewModeAnimated (PSPDFViewMode viewMode, bool animated);
		
		[Export ("gridView")]
		NSObject GridView { get; }
		
		[Export ("thumbnailSize", ArgumentSemantic.Assign)]
		SizeF ThumbnailSize { get; set; }
		
		[Export ("iPhoneThumbnailSizeReductionFactor", ArgumentSemantic.Assign)]
		float IPhoneThumbnailSizeReductionFactor { get; set; }
		
		[Export ("isDoublePageMode")]
		bool IsDoublePageMode { get; }
		
		[Export ("isDoublePageModeForOrientation:")]
		bool IsDoublePageModeForOrientation (UIInterfaceOrientation interfaceOrientation);
		
		[Export ("isDoublePageModeForPage:")]
		bool IsDoublePageModeForPage (uint page);
		
		[Export ("isRightPageInDoublePageMode:")]
		bool IsRightPageInDoublePageMode (uint page);
		
		[Export ("presentModalViewController:embeddedInNavigationController:withCloseButton:animated:")]
		void PresentModalViewController (UIViewController controller, bool embedded, bool closeButton, bool animated);

		[Field ("PSPDFPresentOptionRect", "__Internal")]
		NSString PSPDFPresentOptionRect { get; }
		
		[Field ("PSPDFPresentOptionPopoverContentSize", "__Internal")]
		NSString PSPDFPresentOptionPopoverContentSize { get; }
		
		[Field ("PSPDFPresentOptionAllowedPopoverArrowDirections", "__Internal")]
		NSString PSPDFPresentOptionAllowedPopoverArrowDirections { get; }
		
		[Field ("PSPDFPresentOptionModalPresentationStyle", "__Internal")]
		NSString PSPDFPresentOptionModalPresentationStyle { get; }
		
		[Field ("PSPDFPresentOptionAlwaysModal", "__Internal")]
		NSString PSPDFPresentOptionAlwaysModal { get; }

		[Field ("PSPDFPresentOptionAlwaysPopover", "__Internal")]
		NSString PSPDFPresentOptionAlwaysPopover { get; }
		
		[Field ("PSPDFPresentOptionPassthroughViews", "__Internal")]
		NSString PSPDFPresentOptionPassthroughViews { get; }

		[Export ("presentViewControllerModalOrPopover:embeddedInNavigationController:withCloseButton:animated:sender:options:")]
		NSObject PresentViewControllerModalOrPopover (UIViewController controller, bool embedded, bool closeButton, bool animated, [NullAllowed]NSObject sender, [NullAllowed]NSDictionary options);

		[Export ("visiblePageNumbers")]
		NSNumber [] VisiblePageNumbers { get; }

		[Export ("visiblePageViews")]
		PSPDFPageView [] VisiblePageViews { get; }
		
		[Export ("isLastPage")]
		bool IsLastPage { get; }
		
		[Export ("isFirstPage")]
		bool IsFirstPage { get; }
		
		[Export ("masterViewController")]
		UIViewController MasterViewController ();
		
		//Extension methods SubclassingHooks

		[Bind ("commonInitWithDocument:")]
		void CommonInitWithDocument (PSPDFDocument document);
		
		[Export ("overrideClassNames", ArgumentSemantic.Copy)]
		NSDictionary OverrideClassNames { get; set; }
		
		[Bind ("createToolbarAnimated:")]
		bool CreateToolbarAnimated (bool animated);
		
		[Bind ("updateToolbarAnimated:")]
		bool UpdateToolbarAnimated (bool animated);
		
		[Bind ("updateBarButtonItem:animated:")]
		bool UpdateBarButtonItem (UIBarButtonItem barButtonItem, bool animated);
		
		[Bind ("updateGridForOrientation")]
		void UpdateGridForOrientation ();

		[Bind ("updateSettingsForRotation:")]
		void UpdateSettingsForRotation (UIInterfaceOrientation toInterfaceOrientation);

		[Bind ("setUpdateSettingsForRotationBlock:")]
		void SetUpdateSettingsForRotationBlock (PSPDFViewControllerUpdateSettingsBlock block);
		
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

		[Bind ("visibleAnnotationToolbar")]
		PSPDFAnnotationToolbar VisibleAnnotationToolbar ();

		[Bind ("applicationDidEnterBackground:")]
		void ApplicationDidEnterBackground (NSNotification notification);

		[Export ("pageLabel")]
		PSPDFPageLabelView PageLabel { get; set; }

		[Export ("documentLabel")]
		PSPDFDocumentLabelView DocumentLabel { get; set; }

		[Export ("annotationController")]
		PSPDFAnnotationController AnnotationController { get; }
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
		[Export ("pageIndex", ArgumentSemantic.Assign)]
		uint PageIndex { get; set; }
		
		[Export ("previewText", ArgumentSemantic.Copy)]
		string PreviewText { get; set; }
		
		[Export ("selection")]
		PSPDFTextBlock Selection { get; set; }
		
		[Export ("range", ArgumentSemantic.Assign)]
		NSRange Range { get; set; }

		[Export ("rangeInPreviewText", ArgumentSemantic.Assign)]
		NSRange RangeInPreviewText { get; set; }

		[Export ("cachedOutlineTitle", ArgumentSemantic.Copy)]
		string CachedOutlineTitle { get; set; }

		[Export ("document")]
		PSPDFDocument Document { get; set; }

		[Export ("isEqualToSearchResult")]
		bool IsEqualToSearchResult (PSPDFSearchResult otherSearchResult);
	}
	
	//////////////////////////////////
	////		PSPDFWord.h			//
	//////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFWord 
	{		
		[Export("initWithGlyphs:")]
		IntPtr Constructor (PSPDFGlyph [] wordGlyphs);
		
		[Export("initWithFrame:")]
		IntPtr Constructor (RectangleF wordFrame);
		
		[Export("stringValue")]
		string StringValue ();
		
		[Export("stringValue")]
		string Text { get; }

		[Export ("frame", ArgumentSemantic.Assign)]
		RectangleF Frame { get; set; }

		[Export ("glyphs", ArgumentSemantic.Copy)]
		PSPDFGlyph [] Glyphs { get; set; }

		[Export ("lineBreaker", ArgumentSemantic.Assign)]
		bool LineBreaker { get; set; }

		[Export("isOnSameLineAs:")]
		bool IsOnSameLineAs (PSPDFWord word);
		
		[Export("compareByLayout:")]
		NSComparisonResult CompareByLayout (PSPDFWord word);

		[Export("isEqualToWord:")]
		bool IsEqualToWord (PSPDFWord otherWord);
	}
	
	//////////////////////////////////////
	////		PSPDFGlyph.h			//
	//////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFGlyph 
	{
		[Export ("frame", ArgumentSemantic.Assign)]
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

		[Export ("cachedViewRect", ArgumentSemantic.Assign)]
		RectangleF CachedViewRect { get; set; }

		[Export ("isEqualToGlyph:")]
		bool IsEqualToGlyph (PSPDFGlyph otherGlyph);
	}
	
	//////////////////////////////////////
	////		PSPDFFontInfo.h			//
	//////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFFontInfo 
	{	
		[Export ("name", ArgumentSemantic.Copy)]
		string Name { get; }

		[Export ("ascent", ArgumentSemantic.Assign)]
		float Ascent { get; }
		
		[Export ("descent", ArgumentSemantic.Assign)]
		float Descent { get; }
		
		[Export ("encodingArray", ArgumentSemantic.Copy)]
		NSArray EncodingArray { get; }

		[Export ("toUnicodeMap",ArgumentSemantic.Copy)]
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

		[Static][Export ("isEqualToFontInfo:")]
		bool IsEqualToFontInfo (PSPDFFontInfo otherFontInfo);
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
		
		[Export ("pdfViewController:willDisplayDocument:"), EventArgs ("PSPDFViewControllerDocument")]
		void WillDisplayDocument (PSPDFViewController pdfController, PSPDFDocument document);
		
		[Export ("pdfViewController:didDisplayDocument:"), EventArgs ("PSPDFViewControllerDocument")]
		void DidDisplayDocument (PSPDFViewController pdfController, PSPDFDocument document);
		
		[Export ("pdfViewController:shouldScrollToPage:"), DelegateName ("PSPDFViewControllerShouldScrollToPage"), DefaultValue (true)]
		bool ShouldScrollToPage (PSPDFViewController pdfController, uint page);
		
		[Export ("pdfViewController:didShowPageView:"), EventArgs ("PSPDFViewControllerShowPageVieww")]
		void DidShowPageView (PSPDFViewController pdfController, PSPDFPageView pageView);
		
		[Export ("pdfViewController:didRenderPageView:"), EventArgs ("PSPDFViewControllerShowPageVieww")]
		void DidRenderPageView (PSPDFViewController pdfController, PSPDFPageView pageView);

		[Export ("pdfViewController:didLoadPageView:"), EventArgs ("PSPDFViewControllerDidLoadPageView")]
		void DidLoadPageView (PSPDFViewController pdfController, PSPDFPageView pageView);

		[Export ("pdfViewController:willUnloadPageView:"), EventArgs ("PSPDFViewControllerWillUnloadPageView")]
		void WillUnloadPageView (PSPDFViewController pdfController, PSPDFPageView pageView);

		[Export ("pdfViewController:didChangeViewMode:"), EventArgs ("PSPDFViewControllerDidChangeViewMode")]
		void DidChangeViewMode (PSPDFViewController pdfController, PSPDFViewMode viewMode);
		
		[Export ("pdfViewController:didEndPageDragging:willDecelerate:withVelocity:targetContentOffset:"), EventArgs ("PSPDFViewControllerDidEndPageDragging")]
		void DidEndPageDragging (PSPDFViewController pdfController, UIScrollView scrollView, bool decelerate, PointF velocity, ref PointF targetContentOffset);
		
		[Export ("pdfViewController:didEndPageScrollingAnimation:"), EventArgs ("PSPDFViewControllerDidEndPageScrollingAnimation")]
		void DidEndPageScrollingAnimation (PSPDFViewController pdfController, UIScrollView scrollView);

		[Export ("pdfViewController:didEndPageZooming:atScale:"), EventArgs ("PSPDFViewControllerDidEndPageZooming")]
		void DidEndPageZooming (PSPDFViewController pdfController, UIScrollView scrollView, float scale);

		//TODO: Change the context parameter from IntPtr to CGContext to avoid user casting

		[Export ("pdfViewController:didRenderPage:inContext:withSize:clippedToRect:withAnnotations:options:"), EventArgs ("PSPDFViewControllerDidRenderPage")] 
		void DidRenderPage (PSPDFViewController pdfController, uint page, IntPtr /*CGContext*/ context, SizeF fullsize, RectangleF clipRect, PSPDFAnnotation [] annotations, NSDictionary options);

		[Export ("pdfViewController:documentForRelativePath:"), DelegateName ("PSPDFViewControllerDocumentForRelativePath"), DefaultValue (null)]
		PSPDFDocument DocumentForRelativePath (PSPDFViewController pdfController, string relativePath);
		
		[Export ("pdfViewController:didTapOnPageView:atPoint:"), DelegateName ("PSPDFViewControllerDidTapOnPageView"), DefaultValue (false)]
		bool DidTapOnPageView (PSPDFViewController pdfController, PSPDFPageView pageView, PointF viewPoint);

		[Export ("pdfViewController:didLongPressOnPageView:atPoint:gestureRecognizer:"), DelegateName ("PSPDFViewControllerDidLongPressOnPageView"), DefaultValue (false)]
		bool DidLongPressOnPageView (PSPDFViewController pdfController, PSPDFPageView pageView, PointF viewPoint, UILongPressGestureRecognizer gestureRecognizer);

		[Export ("pdfViewController:shouldSelectText:withGlyphs:atRect:onPageView:"), DelegateName ("PSPDFViewControllerShouldSelectText"), DefaultValue (true)]
		bool ShouldSelectText (PSPDFViewController pdfController, string text, PSPDFGlyph [] glyphs, RectangleF rect, PSPDFPageView pageView);

		[Export ("pdfViewController:didSelectText:withGlyphs:atRect:onPageView:"), EventArgs ("PSPDFViewControllerDidSelectText")]
		void DidSelectText (PSPDFViewController pdfController, string text, PSPDFGlyph [] glyphs, RectangleF rect, PSPDFPageView pageView);

		[Export ("pdfViewController:shouldShowMenuItems:atSuggestedTargetRect:forSelectedText:inRect:onPageView:"), DelegateName ("PSPDFViewControllerShouldShowMenuItemsForSelectedText"), DefaultValueFromArgument ("menuItems")]
		PSPDFMenuItem [] ShouldShowMenuItemsForSelectedText (PSPDFViewController pdfController, PSPDFMenuItem [] menuItems, RectangleF rect, string selectedText, RectangleF textRect, PSPDFPageView pageView);

		[Export ("pdfViewController:shouldShowMenuItems:atSuggestedTargetRect:forSelectedImage:inRect:onPageView:"), DelegateName ("PSPDFViewControllerShouldShowMenuItemsForSelectedImage"), DefaultValueFromArgument ("menuItems")]
		PSPDFMenuItem [] ShouldShowMenuItemsForSelectedImage (PSPDFViewController pdfController, PSPDFMenuItem [] menuItems, RectangleF rect, PSPDFImageInfo selectedImage, RectangleF textRect, PSPDFPageView pageView);

		[Export ("pdfViewController:shouldDisplayAnnotation:onPageView:"), DelegateName ("PSPDFViewControllerShouldDisplayAnnotation"), DefaultValue (true)]
		bool ShouldDisplayAnnotation (PSPDFViewController pdfController, PSPDFAnnotation annotation, PSPDFPageView pageView);
		
		[Export ("pdfViewController:didTapOnAnnotation:annotationPoint:annotationView:pageView:viewPoint:"), DelegateName ("PSPDFViewControllerDidTapOnAnnotation"), DefaultValue (false)]
		bool DidTapOnAnnotation (PSPDFViewController pdfController, PSPDFAnnotation annotation, PointF annotationPoint, PSPDFAnnotationView annotationView, PSPDFPageView pageView, PointF viewPoint);

		[Export ("pdfViewController:ShouldSelectAnnotation:onPageView:"), DelegateName ("PSPDFViewControllerShouldSelectAnnotation"), DefaultValue (true)]
		bool ShouldSelectAnnotation (PSPDFViewController pdfController, PSPDFAnnotation annotation, PSPDFPageView pageView);

		[Export ("pdfViewController:didSelectAnnotation:onPageView:"), EventArgs ("PSPDFViewControllerDidSelectAnnotation")]
		void DidSelectAnnotation (PSPDFViewController pdfController, PSPDFAnnotation annotation, PSPDFPageView pageView);

		[Export ("pdfViewController:shouldShowMenuItems:atSuggestedTargetRect:forAnnotation:inRect:onPageView:"), DelegateName ("PSPDFViewControllerShouldShowMenuItemsforAnnotation"), DefaultValueFromArgument ("menuItems")]
		PSPDFMenuItem [] ShouldShowMenuItemsForAnnotation (PSPDFViewController pdfController, PSPDFMenuItem [] menuItems, RectangleF rect, PSPDFAnnotation annotation, RectangleF annotationRect, PSPDFPageView pageView);

		[Export ("pdfViewController:annotationView:forAnnotation:onPageView:"), DelegateName ("PSPDFViewControllerAnnotationViewForAnnotation"), DefaultValueFromArgument ("annotationView")]
		PSPDFAnnotationView AnnotationViewForAnnotation (PSPDFViewController pdfController, PSPDFAnnotationView annotationView, PSPDFAnnotation annotation, PSPDFPageView pageView);

		[Export ("pdfViewController:willShowAnnotationView:onPageView:"), EventArgs ("PSPDFViewControllerAnnotationView")]
		void WillShowAnnotationView (PSPDFViewController pdfController, PSPDFAnnotationView annotationView, PSPDFPageView pageView);
		
		[Export ("pdfViewController:didShowAnnotationView:onPageView:"), EventArgs ("PSPDFViewControllerAnnotationView")]
		void DidShowAnnotationView (PSPDFViewController pdfController, PSPDFAnnotationView annotationView, PSPDFPageView pageView);

		[Export ("pdfViewController:shouldShowController:embeddedInController:animated:"), DelegateName ("PSPDFViewControllerShouldShowController"), DefaultValue (true)]
		bool ShouldShowController (PSPDFViewController pdfController, NSObject viewController, NSObject controller, bool animated);

		[Export ("pdfViewController:didShowController:embeddedInController:animated:"), EventArgs ("PSPDFViewControllerDidShowController")]
		void DidShowController (PSPDFViewController pdfController, NSObject viewController, NSObject controller, bool animated);

		[Export ("pdfViewController:requestsUpdateForBarButtonItem:animated:"), EventArgs ("PSPDFViewControllerRequestsUpdateForBarButtonItem")]
		void RequestsUpdateForBarButtonItem (PSPDFViewController pdfController, UIBarButtonItem barButtonItem, bool animated);

		[Export ("pdfViewController:shouldShowHUD:"), DelegateName ("PSPDFViewControllerShouldShowHUD"), DefaultValue (true)]
		bool ShouldShowHUD (PSPDFViewController pdfController, bool animated);
		
		[Export ("pdfViewController:willShowHUD:"), EventArgs ("PSPDFViewControllerHUD")]
		void WillShowHUD (PSPDFViewController pdfController, bool animated);
		
		[Export ("pdfViewController:didShowHUD:"), EventArgs ("PSPDFViewControllerHUD")]
		void DidShowHUD (PSPDFViewController pdfController, bool animated);
		
		[Export ("pdfViewController:shouldHideHUD:"), DelegateName ("PSPDFViewControllerShouldHideHUD"), DefaultValue (true)]
		bool ShouldHideHUD (PSPDFViewController pdfController, bool animated);
		
		[Export ("pdfViewController:willHideHUD:"), EventArgs ("PSPDFViewControllerHUD")]
		void WillHideHUD (PSPDFViewController pdfController, bool animated);
		
		[Export ("pdfViewController:didHideHUD:"), EventArgs ("PSPDFViewControllerHUD")]
		void DidHideHUD (PSPDFViewController pdfController, bool animated);
	}

	//////////////////////////////
	////	PSPDFMenuItem.h		//
	//////////////////////////////

	delegate void PSPDFMenuItemInitWithTitleBlock ();

	[BaseType (typeof (UIMenuItem))]
	interface PSPDFMenuItem 
	{
		[Export("initWithTitle:block:")]
		IntPtr Constructor (string title, PSPDFMenuItemInitWithTitleBlock block);

		[Export("initWithTitle:block:identifier:")]
		IntPtr Constructor (string title, PSPDFMenuItemInitWithTitleBlock block, string identifier);

		[Export("enabled", ArgumentSemantic.Assign)]
		bool Enabled { [Bind("isEnabled")] get; set; }

		[Export("identifier", ArgumentSemantic.Copy)]
		string Identifier { [Bind("isEnabled")] get; set; }

		//Didn't bind Action block as a property due to there is no real use to get the block back
		[Export ("setBlock:", ArgumentSemantic.Copy)]
		void SetBlock (PSPDFMenuItemInitWithTitleBlock block);

		[Static][Export("installMenuHandlerForObject:")]
		void InstallMenuHandlerForObject (NSObject obj);
	}

	//////////////////////////////
	////	PSPDFDocument.h		//
	//////////////////////////////

	delegate void PSPDFDocumentDocumentProviderBlock (PSPDFDocumentProvider documentProvider);
	
	[BaseType (typeof (NSObject),
	Delegates=new string [] {"WeakDelegate"},
	Events=new Type [] { typeof (PSPDFDocumentDelegate) })]
	interface PSPDFDocument
	{
		[Static][Export("PDFDocument")]
		PSPDFDocument PDFDocument ();

		[Static][Export("PDFDocumentWithURL:")]
		PSPDFDocument PDFDocumentWithURL (NSUrl url);

		[Static][Export("PDFDocumentWithData:")]
		PSPDFDocument PDFDocumentWithData (NSData data);

		[Static][Export("PDFDocumentWithDataArray:")]
		PSPDFDocument PDFDocumentWithDataArray (NSArray dataArray);

		[Static][Export("PDFDocumentWithDataArray:")]
		PSPDFDocument PDFDocumentWithDataArray (NSObject [] dataArray);
		
		[Static][Export("PDFDocumentWithDataProvider:")][Internal]
		PSPDFDocument PDFDocumentWithDataProvider_ (IntPtr /*CGDataProvider*/ dataProvider);
		
		[Static][Export("PDFDocumentWithBaseURL:files:")]
		PSPDFDocument PDFDocumentWithBaseURL (NSUrl baseURL, NSArray files);

		[Static][Export("PDFDocumentWithBaseURL:files:")]
		PSPDFDocument PDFDocumentWithBaseURL (NSUrl baseURL, NSObject [] files);

		[Static][Export("PDFDocumentWithBaseURL:fileTemplate:startPage:endPage:")]
		PSPDFDocument PDFDocumentWithBaseURL (NSUrl baseURL, string fileTemplate, int startPage, int endPage);

		[Export("initWithURL:")]
		IntPtr Constructor (NSUrl url);

		[Export("initWithData:")]
		IntPtr Constructor (NSData data);

		[Export("initWithDataArray:")]
		IntPtr Constructor (NSArray data);

		[Export("initWithDataArray:")]
		IntPtr Constructor (NSObject [] data);
		
		[Export("initWithDataProvider:")][Internal]
		PSPDFDocument InitWithDataProvider_ (IntPtr /*CGDataProvider*/ dataProvider);

		[Export("initWithBaseURL:files:")]
		IntPtr Constructor (NSUrl basePath, NSArray files);

		[Export("initWithBaseURL:files:")]
		IntPtr Constructor (NSUrl basePath, NSObject [] files);

		[Export("initWithBaseURL:fileTemplate:startPage:endPage:")]
		IntPtr Constructor (NSUrl baseURL, string fileTemplate, int startPage, int endPage);

		[Export("isEqualToDocument:")]
		bool IsEqualToDocument (PSPDFDocument otherDocument);

		[Wrap ("WeakDelegate")]
		PSPDFDocumentDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }
		
		[Export("appendFile:")]
		void AppendFile (string file);
		
		[Export("pathForPage:")]
		NSUrl PathForPage (uint page);
		
		[Export("fileIndexForPage:")]
		int FileIndexForPage (uint page);
		
		[Export("URLForFileIndex:")]
		NSUrl URLForFileIndex (int fileIndex);
		
		[Export("filesWithBasePath")]
		NSUrl [] FilesWithBasePath ();
		
		[Export("fileNamesWithDataDictionary")][NullAllowed]
		NSDictionary FileNamesWithDataDictionary { get; }

		[Export("fileNameForPage:")]
		string FileNameForPage (uint pageIndex);

		[Export("basePath")][NullAllowed]
		NSUrl BasePath { get; set; }
		
		[Export("files", ArgumentSemantic.Copy)][NullAllowed]
		string [] Files { get; set; }
		
		[Export("fileURL")][NullAllowed]
		NSUrl FileURL { get; set; }
		
		[Export("data", ArgumentSemantic.Copy)][NullAllowed]
		NSData Data { get; }

		[Export("dataArray", ArgumentSemantic.Copy)][NullAllowed]
		NSData [] DataArray { get; }
		
		[Export("dataProvider", ArgumentSemantic.Assign)][Internal]
		IntPtr /*CGDataProviderRef*/ DataProvider_ { get; }
		
		[Export("title", ArgumentSemantic.Copy)]
		string Title { get; set; }
		
		[Export("titleLoaded", ArgumentSemantic.Assign)]
		bool TitleLoaded { [Bind("isTitleLoaded")] get; }
		
		[Export("metadata", ArgumentSemantic.Copy)]
		NSDictionary Metadata { get; }
		
		[Export("UID", ArgumentSemantic.Copy)]
		string Uid { get; set; }

		[Export("annotationsEnabled", ArgumentSemantic.Assign)]
		bool AnnotationsEnabled { [Bind("isAnnotationsEnabled")] get; set; }

		[Export("editableAnnotationTypes", ArgumentSemantic.Copy)]
		NSSet EditableAnnotationTypes { get; set; }

		[Export("canEmbedAnnotations", ArgumentSemantic.Assign)]
		bool CanEmbedAnnotations { get; }

		[Export("annotationSaveMode", ArgumentSemantic.Assign)]
		PSPDFAnnotationSaveMode AnnotationSaveMode { get; set; }

		[Export("defaultAnnotationUsername", ArgumentSemantic.Copy)]
		string DefaultAnnotationUsername { get; [NullAllowed] set; }

		[Export("saveChangedAnnotationsWithError:")]
		bool SaveChangedAnnotationsWithError (out NSError error);

		[Export("annotationParser")]
		PSPDFAnnotationParser AnnotationParser { get; }

		[Export("annotationsForPage:type:")]
		PSPDFAnnotation [] AnnotationsForPage (uint page, PSPDFAnnotationType type);

		[Export("addAnnotations:forPage:")]
		void AddAnnotations (PSPDFAnnotation [] annotation, uint page);

		[Export("annotationParserForPage:")]
		PSPDFAnnotationParser AnnotationParserForPage (uint page);

		[Export("pageCount")]
		uint PageCount { get; }

		[Export("pageNumberForPage:")]
		uint PageNumberForPage (uint page);

		[Export("compensatedPageForPage:")]
		uint CompensatedPageForPage (uint page);

		[Export("pageInfoForPage:")]
		PSPDFPageInfo PageInfoForPage (uint page);

		[Export("hasPageInfoForPage:")]
		bool HasPageInfoForPage (uint page);

		[Export("nearestPageInfoForPage:")]
		PSPDFPageInfo NearestPageInfoForPage (uint page);

		[Export("rectBoxForPage:")]
		RectangleF RectBoxForPage (uint page);

		[Export("rotationForPage:")]
		int RotationForPage (uint page);

		[Export("PDFBox", ArgumentSemantic.Assign)]
		CGPDFBox PDFBox { get; set; }

		[Export("aspectRatioVariance")]
		float AspectRatioVariance ();

		[Export("clearCache")]
		void ClearCache ();

		[Export("fillCache")]
		void FillCache ();

		[Export("fillPageInfoCache")]
		void FillPageInfoCache ();

		[Export("cacheDirectory", ArgumentSemantic.Copy)]
		string CacheDirectory { get; set; }

		[Export("ensureCacheDirectoryExistsWithError:")]
		bool EnsureCacheDirectoryExistsWithError (out NSError error);

		[Export("cacheStrategy", ArgumentSemantic.Assign)]
		PSPDFCacheStrategy CacheStrategy { get; set; }

		[Export("aspectRatioEqual", ArgumentSemantic.Assign)]
		bool AspectRatioEqual { [Bind("isAspectRatioEqual")] get; set; }

		[Export("displayingPdfController")][NullAllowed]
		PSPDFViewController DisplayingPdfController { get; set; }

		[Export("displayingPage", ArgumentSemantic.Assign)]
		uint DisplayingPage { get; }

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

		[Export("encryptionFilter", ArgumentSemantic.Copy)]
		string EncryptionFilter { get; }

		[Export("isLocked", ArgumentSemantic.Assign)]
		bool IsLocked { get; }

		[Export("allowsCopying", ArgumentSemantic.Assign)]
		bool AllowsCopying { get; set; }

		[Export("textParserForPage:")]
		PSPDFTextParser TextParserForPage (uint page);

		[Export("hasLoadedTextParserForPage:")]
		bool HasLoadedTextParserForPage (uint page);

		[Export("textSearch")]
		PSPDFTextSearch TextSearch { get; set; }

		[Export("documentProviderForPage:")]
		PSPDFDocumentProvider DocumentProviderForPage (uint page);

		[Export("pageOffsetForDocumentProvider:")]
		uint PageOffsetForDocumentProvider (PSPDFDocumentProvider documentProvider);

		[Export("documentProviders", ArgumentSemantic.Copy)]
		PSPDFDocumentProvider [] DocumentProviders { get; }

		[Export("documentParserForPage:")]
		PSPDFDocumentParser DocumentParserForPage (uint page);

		[Export("outlineParser")]
		PSPDFOutlineParser OutlineParser { get; }

		[Export("bookmarkParser")]
		PSPDFBookmarkParser BookmarkParser { get; set; }

		[Export("pageLabelForPage:substituteWithPlainLabel:")] [NullAllowed]
		string PageLabelForPage (uint page, bool substitute);

		[Export("pageForPageLabel:partialMatching:")]
		uint PageForPageLabel (string pageLabel, bool partialMatching);

		[Export("renderImageForPage:withSize:clippedToRect:withAnnotations:options:")] 
		UIImage RenderImageForPage (uint page, SizeF fullSize, RectangleF clipRect, [NullAllowed] PSPDFAnnotation [] annotations, NSDictionary options);

		[Export("renderPage:inContext:withSize:clippedToRect:withAnnotations:options:")] [Internal]
		void RenderPage_ (uint page, IntPtr /*CGContextRef*/ context, SizeF fullSize, RectangleF clipRect, [NullAllowed] PSPDFAnnotation [] annotations, NSDictionary options);

		[Export("renderOptions", ArgumentSemantic.Copy)]
		NSDictionary RenderOptions { get; set; }

		//Options
		[Field ("kPSPDFObjectsGlyphs", "__Internal")]
		NSString PSPDFObjectsGlyphs { get; }

		[Field ("kPSPDFObjectsText", "__Internal")]
		NSString PSPDFObjectsText { get; }

		[Field ("kPSPDFObjectsFullWords", "__Internal")]
		NSString PSPDFObjectsFullWords { get; }

		[Field ("kPSPDFObjectsTextBlocks", "__Internal")]
		NSString PSPDFObjectsTextBlocks { get; }

		[Field ("kPSPDFObjectsTextBlocksIgnoreLarge", "__Internal")]
		NSString PSPDFObjectsTextBlocksIgnoreLarge { get; }

		[Field ("kPSPDFObjectsAnnotationTypes", "__Internal")]
		NSString PSPDFObjectsAnnotationTypes { get; }

		[Field ("kPSPDFObjectsAnnotationPageBounds", "__Internal")]
		NSString PSPDFObjectsAnnotationPageBounds { get; }

		[Field ("kPSPDFObjectsImages", "__Internal")]
		NSString PSPDFObjectsImages { get; }

		[Field ("kPSPDFObjectsSmartSort", "__Internal")]
		NSString PSPDFObjectsSmartSort { get; }

		[Field ("kPSPDFObjectsTextFlow", "__Internal")]
		NSString PSPDFObjectsTextFlow { get; }

		[Field ("kPSPDFObjectsFindFirstOnly", "__Internal")]
		NSString PSPDFObjectsFindFirstOnly { get; }

		[Field ("kPSPDFObjectsTestIntersection", "__Internal")]
		NSString PSPDFObjectsTestIntersection { get; }

		//Output Categories

		[Field ("kPSPDFGlyphs", "__Internal")]
		NSString PSPDFGlyphs { get; }

		[Field ("kPSPDFWords", "__Internal")]
		NSString PSPDFWords { get; }

		[Field ("kPSPDFText", "__Internal")]
		NSString PSPDFText { get; }

		[Field ("kPSPDFTextBlocks", "__Internal")]
		NSString PSPDFTextBlocks { get; }

		[Field ("kPSPDFAnnotations", "__Internal")]
		NSString PSPDFAnnotations { get; }

		[Field ("kPSPDFImages", "__Internal")]
		NSString PSPDFImages { get; }

		[Export("objectsAtPDFPoint:page:options:")]
		NSDictionary ObjectsAtPDFPoint (PointF pdfPoint, uint page, [NullAllowed] NSDictionary options);
		
		[Export("objectsAtPDFRect:page:options:")]
		NSDictionary ObjectsAtPDFRect (RectangleF pdfRect, uint page, [NullAllowed] NSDictionary options);

		// SubClassing

		[Export("overrideClassNames", ArgumentSemantic.Copy)]
		NSDictionary OverrideClassNames { get; set; }
		
		[Export ("didCreateDocumentProvider:")]
		PSPDFDocumentProvider DidCreateDocumentProvider (PSPDFDocumentProvider documentProvider);

		[Bind ("setDidCreateDocumentProviderBlock:")]
		void SetDidCreateDocumentProviderBlock (PSPDFDocumentDocumentProviderBlock documentProviderBlock);

		[Bind ("cachedImageURLForPage:andSize:")] [NullAllowed]
		NSUrl CachedImageURLForPage (uint page, PSPDFSize size);
		
		[Bind ("pageContentForPage:")] [NullAllowed]
		string PageContentForPage (uint page);
		
		[Bind ("backgroundColorForPage:")]
		UIColor BackgroundColorForPage (uint page);

		[Export("backgroundColor")]
		UIColor BackgroundColor { get; set; }

		[Bind ("pageInfoForPage:pageRef:")] [Internal]
		PSPDFPageInfo PageInfoForPage_ (uint page, IntPtr /*CGPDFPage*/ pageRef);
		
		// Metadata Keys
		
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

	//////////////////////////////////////////////
	////		PSPDFDocumentDelegate.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFDocumentDelegate 
	{		
		[Export ("pdfDocument:resolveCustomAnnotationPathToken:"), DelegateName ("PSPDFDocumentDelegateResolveCustomAnnotationPathToken"), DefaultValue (null)]
		string ResolveCustomAnnotationPathToken (PSPDFDocument document, string pathToken);

		[Export ("pdfDocument:didSaveAnnotations:"), EventArgs ("PSPDFDocumentDelegateDidSaveAnnotations")]
		void DidSaveAnnotations (PSPDFDocument document, PSPDFAnnotation [] annotations);

		[Export ("pdfDocument:failedToSaveAnnotations:withError:"), EventArgs ("PSPDFDocumentDelegateFailedToSaveAnnotations")]
		void FailedToSaveAnnotations (PSPDFDocument document, PSPDFAnnotation [] annotations, NSError error);
	}

	//////////////////////////////////////////
	////		PSPDFBookmarkParser.h		//
	//////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFBookmarkParser 
	{
		[Field ("kPSPDFBookmarksChangedNotification", "__Internal")]
		NSString PSPDFBookmarksChangedNotification { get; }

		[Export("initWithDocument:")]
		IntPtr Constructor (PSPDFDocument document);
		
		[Export("bookmarks", ArgumentSemantic.Copy)]
		PSPDFBookmark [] Bookmarks { get; set; }

		[Export("document")]
		PSPDFDocument Document { get; set; }
		
		[Export("addBookmarkForPage:")] [PostGet("Bookmarks")]
		bool AddBookmarkForPage (uint page);

		[Export("removeBookmarkForPage:")] [PostGet("Bookmarks")]
		bool RemoveBookmarkForPage (uint page);

		[Export("clearAllBookmarksWithError:")] [PostGet("Bookmarks")]
		bool ClearAllBookmarksWithError (out NSError error);

		[Export("bookmarkForPage:")]
		PSPDFBookmark BookmarkForPage (uint page);

		[Bind("cachePath")]
		string CachePath ();

		[Bind("bookmarkPath")]
		string BookmarkPath ();

		[Bind("loadBookmarksWithError:")]
		PSPDFBookmark [] LoadBookmarksWithError (out NSError error);

		[Bind("saveBookmarksWithError:")]
		bool SaveBookmarksWithError (out NSError error);
	}
	
	//////////////////////////////////////////
	////		PSPDFTextSearch.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFTextSearchDelegate 
	{		
		[Export ("willStartSearch:forTerm:isFullSearch:"), EventArgs ("PSPDFTextSearchWillStartSearch")]
		void WillStartSearch (PSPDFTextSearch textSearch, string searchTerm, bool isFullSearch);
		
		[Export ("didUpdateSearch:forTerm:newSearchResults:forPage:"), EventArgs ("PSPDFTextSearchDidUpdateSearch")]
		void DidUpdateSearch (PSPDFTextSearch textSearch, string searchTerm, PSPDFSearchResult [] searchResults, uint page);
		
		[Export ("didFinishSearch:forTerm:searchResults:isFullSearch:"), EventArgs ("PSPDFTextSearchDidFinishSearch")]
		void DidFinishSearch (PSPDFTextSearch textSearch, string searchTerm,  PSPDFSearchResult [] searchResults, bool isFullSearch);
		
		[Export ("didCancelSearch:forTerm:isFullSearch:"), EventArgs ("PSPDFTextSearchDidCancelSearch")]
		void DidCancelSearch (PSPDFTextSearch textSearch, string searchTerm, bool isFullSearch);
	}
	
	[BaseType (typeof (NSObject),
	Delegates=new string [] {"WeakDelegate"},
	Events=new Type [] { typeof (PSPDFTextSearchDelegate) })]
	interface PSPDFTextSearch 
	{
		[Export("initWithDocument:")]
		IntPtr Constructor (PSPDFDocument document);
		
		[Export("searchForString:")]
		void SearchForString (string searchTerm);
		
		[Export("searchForString:inRanges:rangesOnly:")]
		void SearchForString (string searchTerm, NSIndexSet ranges, bool rangesOnly);

		[Export("cancelAllOperationsAndWait")]
		void CancelAllOperationsAndWait ();

		[Export("searchMode", ArgumentSemantic.Assign)]
		PSPDFSearchMode SearchMode { get; set; }

		[Export("compareOptions", ArgumentSemantic.Assign)]
		NSStringCompareOptions CompareOptions { get; set; }

		[Export("document")]
		PSPDFDocument Document { get; }

		[Wrap ("WeakDelegate")]
		PSPDFTextSearchDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }

		// SubclassingHooks

		[Export("searchQueue:")]
		NSOperationQueue SearchQueue { get; }
	}
	
	//////////////////////////////////////////////
	////		PSPDFSearchOperation.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFSearchOperationDelegate 
	{		
		[Export ("didUpdateSearchOperation:forString:newSearchResults:forPage:"), EventArgs ("PSPDFSearchOperationDidUpdateSearchOperation")] [Abstract]
		void DidUpdateSearchOperation (PSPDFSearchOperation operation, string searchTerm, PSPDFSearchResult [] searchResults, uint page);

		[Export ("willStartSearchOperation:forString:isFullSearch:"), EventArgs ("PSPDFSearchOperationWillStartSearchOperation")]
		void WillStartSearchOperation (PSPDFSearchOperation operation, string searchTerm, bool isFullSearch);
	}


	[BaseType (typeof (NSOperation),
	Delegates=new string [] {"WeakDelegate"},
	Events=new Type [] { typeof (PSPDFSearchOperationDelegate) })]
	interface PSPDFSearchOperation 
	{
		[Export("initWithDocument:searchTerm:")]
		IntPtr Constructor (PSPDFDocument document, string searchTerm);

		[Export("pageRanges", ArgumentSemantic.Copy)]
		NSIndexSet PageRanges { get; set; }

		[Export("shouldSearchAllPages", ArgumentSemantic.Assign)]
		bool ShouldSearchAllPages { get; set; }

		[Export("searchMode", ArgumentSemantic.Assign)]
		PSPDFSearchMode SearchMode { get; set; }

		[Export("compareOptions", ArgumentSemantic.Assign)]
		NSStringCompareOptions CompareOptions { get; set; }

		[Wrap ("WeakDelegate")]
		PSPDFSearchOperationDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Export("searchResults", ArgumentSemantic.Copy)]
		PSPDFSearchResult [] SearchResults { get; }

		[Export("searchTerm", ArgumentSemantic.Copy)]
		string SearchTerm { get; }

		[Export("document")]
		PSPDFDocument Document { get; }
	}
	
	//////////////////////////////////////////////
	////		PSPDFDocumentProvider.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFDocumentProviderDelegate 
	{		
		[Export ("documentProvider:shouldAppendData:"), DelegateName ("PSPDFDocumentProviderShouldAppendData"), DefaultValue (true)]
		bool ShouldAppendData (PSPDFDocumentProvider documentProvider, NSData data);
		
		[Export ("documentProvider:didAppendData:"), EventArgs ("PSPDFDocumentProviderDidAppendData")]
		void DidAppendData (PSPDFDocumentProvider documentProvider, NSData data);
	}

	delegate void PSPDFDocumentProviderPerformBlock (PSPDFDocumentProvider docProvider, IntPtr /*CGPDFDocumentRef*/ documentRefHandle);
	delegate void PSPDFDocumentProviderIterateOverPageRef (PSPDFDocumentProvider docProvider, IntPtr /*CGPDFDocumentRef*/ documentRefHandle, IntPtr /*CGPDFPageRef*/ pageRefHandle, uint pageNumber);

	[BaseType (typeof (NSObject),
	Delegates=new string [] {"WeakDelegate"},
	Events=new Type [] { typeof (PSPDFDocumentProviderDelegate) })]
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
		
		[Export("dataProvider", ArgumentSemantic.Assign)] [Internal]
		IntPtr /*CGDataProviderRef*/ DataProvider_ { get; }
		
		[Export("document")]
		PSPDFDocument Document { get; }
		
		[Wrap ("WeakDelegate")]
		PSPDFDocumentProviderDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }
		
		[Export("requestDocumentRefWithOwner:")][Internal]
		IntPtr RequestDocumentRefWithOwner_ (NSObject owner);
		
		[Export("releaseDocumentRef:withOwner:")][Internal]
		void ReleaseDocumentRef_ (IntPtr /*CGPDFDocumentRef*/ documentRef, NSObject owner);
		
		[Export("performBlock:")]
		void PerformBlock (PSPDFDocumentProviderPerformBlock documentRefBlock);

		[Export("iterateOverPageRef:")]
		void IterateOverPageRef (PSPDFDocumentProviderIterateOverPageRef pageRefBlock);

		[Export ("requestPageRefForPageNumber:error:")][Internal]
		IntPtr /*CGPDFPage*/ RequestPageRefForPageNumber_ (uint page, out NSError error);

		[Export ("requestPageRefForPageNumber:")][Internal]
		IntPtr /*CGPDFPage*/ RequestPageRefForPageNumber_ (uint page);

		[Export("releasePageRef:")][Internal]
		void ReleasePageRef_ (IntPtr /*CGPDFPageRef*/ pageRef);

		[Export("flushDocumentReference")]
		void FlushDocumentReference ();

		[Export("pageInfoForPage:")]
		PSPDFPageInfo PageInfoForPage (uint page);

		[Export("pageCount", ArgumentSemantic.Assign)]
		uint PageCount { get; }
		
		[Export("unlockWithPassword:")]
		bool UnlockWithPassword (string password);
		
		[Export("password", ArgumentSemantic.Copy)]
		string Password { get; set; }

		[Export("allowsPrinting", ArgumentSemantic.Assign)]
		bool AllowsPrinting { get; }

		[Export("allowsCopying", ArgumentSemantic.Assign)]
		bool AllowsCopying { get; set; }
		
		[Export("isEncrypted", ArgumentSemantic.Assign)]
		bool IsEncrypted { get; }
		
		[Export("encryptionFilter", ArgumentSemantic.Copy)]
		string EncryptionFilter { get; }
		
		[Export("isLocked", ArgumentSemantic.Assign)]
		bool IsLocked { get; }
		
		[Export("canEmbedAnnotations", ArgumentSemantic.Assign)]
		bool CanEmbedAnnotations { get; set; }
		
		[Export("saveChangedAnnotationsWithError:")]
		bool SaveChangedAnnotationsWithError (out NSError error);
		
		[Export("metadata", ArgumentSemantic.Copy)]
		NSDictionary Metadata { get; }
		
		[Export("metadataLoaded", ArgumentSemantic.Assign)]
		bool MetadataLoaded { [Bind("isMetadataLoaded")] get; }
		
		[Export("title", ArgumentSemantic.Copy)]
		string Title { get; }

		[Export("textParserForPage:")]
		PSPDFTextParser TextParserForPage (uint page);

		[Export("hasLoadedTextParserForPage:")]
		bool HasLoadedTextParserForPage (uint page);
		
		[Export("outlineParser")]
		PSPDFOutlineParser OutlineParser { get; set; }
		
		[Export("documentParser")]
		PSPDFDocumentParser DocumentParser { get; set; }

		[Export("isDocumentParserLoaded", ArgumentSemantic.Assign)]
		bool IsDocumentParserLoaded { [Bind("isDocumentParserLoaded")] get; }
		
		[Export("annotationParser")]
		PSPDFAnnotationParser AnnotationParser { get; set; }
		
		[Export("labelParser")]
		PSPDFLabelParser LabelParser { get; set; }
		
		// EXTENSIONS
		
		[Export("hasOpenDocumentRef", ArgumentSemantic.Assign)]
		bool HasOpenDocumentRef { get; }

		[Export("pageInfoForPageNoFetching:")]
		PSPDFPageInfo PageInfoForPageNoFetching (uint page);

		[Export("pageInfoForPage:pageRef:")] [Internal]
		PSPDFPageInfo PageInfoForPage_ (uint page, IntPtr /*CGPDFPage*/ pageRef);
		
	}
	
	//////////////////////////////////////////
	////		PSPDFLabelParser.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFLabelParser 
	{
		[Export("initWithDocumentProvider:")]
		IntPtr Constructor (PSPDFDocumentProvider documentProvider);

		[Export("documentProvider")]
		PSPDFDocumentProvider DocumentProvider { get; }
		
		[Export("parseDocument")]
		NSDictionary ParseDocument { get; }
		
		[Export("pageLabelForPage:")][NullAllowed]
		string PageLabelForPage (uint page);

		[Export("pageForPageLabel:partialMatching:")]
		uint PageForPageLabel (string pageLabel, bool partialMatching);

		[Export("labels", ArgumentSemantic.Copy)]
		NSDictionary Labels { get; }
	}
	
	//////////////////////////////////////////////
	////		PSPDFAnnotationParser.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFAnnotationParser 
	{
		[Export("initWithDocumentProvider:")]
		IntPtr Constructor ([NullAllowed] PSPDFDocumentProvider documentProvider);

		[Export("annotationProviders", ArgumentSemantic.Copy)]
		NSObject [] AnnotationProviders { get; set; }

		[Export("fileAnnotationProvider")]
		PSPDFFileAnnotationProvider FileAnnotationProvider { get; }
		
		[Export("annotationsForPage:PSPDFAnnotationType:")]
		PSPDFAnnotation [] AnnotationsForPage (uint page, PSPDFAnnotationType type);

		[Export("hasLoadedAnnotationsForPage:")]
		bool HasLoadedAnnotationsForPage (uint page);
		
		[Export("annotationClassForAnnotation:")][NullAllowed]
		Class AnnotationClassForAnnotation (PSPDFAnnotation annotation);
		
		[Export("addAnnotations:forPage:")]
		void AddAnnotations (PSPDFAnnotation [] annotation, uint page);

		[Export("didChangeAnnotation:originalAnnotation:keyPaths:options:")]
		void DidChangeAnnotation (PSPDFAnnotation annotation, PSPDFAnnotation originalAnnotation, NSObject [] keyPaths, NSDictionary options);

		[Export("saveAnnotationsWithError:")]
		bool SaveAnnotationsWithError (out NSError error);

		[Export("updateAnnotations:originalAnnotations:animated:")]
		void UpdateAnnotations (PSPDFAnnotation [] annotations, [NullAllowed] PSPDFAnnotation [] originalAnnotations, bool animated);

		[Export("documentProvider")]
		PSPDFDocumentProvider DocumentProvider { get; }

		// Subclassing

		[Export("annotationsForPage:PSPDFAnnotationType:")][Internal]
		PSPDFAnnotation [] AnnotationsForPage_ (uint page, PSPDFAnnotationType type, IntPtr /*CGPDFPageRef*/ pageRef);

		[Bind("dirtyAnnotations")]
		NSDictionary DirtyAnnotations ();
	}
	
	
	//////////////////////////////////////////////
	////		PSPDFDocumentParser.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFDocumentParser 
	{
		[Export("initWithDocumentProvider:")]
		IntPtr Constructor (PSPDFDocumentProvider documentProvider);
		
		[Export("parseDocumentWithError:")]
		bool ParseDocumentWithError (out NSError error);
		
		[Export("saveAnnotations:withError:")]
		bool SaveAnnotations (NSDictionary annotations, out NSError error);
		
		[Export("documentProvider")]
		PSPDFDocumentProvider DocumentProvider { get; }
		
		[Export("encryptionFilter", ArgumentSemantic.Copy)]
		string EncryptionFilter { get; }
		
		[Export("pageObjectNumbers", ArgumentSemantic.Copy)]
		PSPDFXRefEntry [] PageObjectNumbers { get; }
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

		[Export("outlineElementForPage:exactPageOnly:")]
		PSPDFOutlineElement OutlineElementForPage (uint page, bool exactPageOnly);
		
		[Export("outline")]
		PSPDFOutlineElement Outline { get; set; }
		
		[Export("outlineParsed", ArgumentSemantic.Assign)]
		bool OutlineParsed { [Bind("isOutlineParsed")] get; }
		
		[Export("outlineAvailable", ArgumentSemantic.Assign)]
		bool OutlineAvailable { [Bind("isOutlineAvailable")] get; }

		[Export("documentProvider")]
		PSPDFDocumentProvider DocumentProvider { get; }
		
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
		NSObject [] FlattenedChildren ();
		
		[Export("title", ArgumentSemantic.Copy)]
		string Title { get; set; }
		
		[Export("relativePath", ArgumentSemantic.Copy)]
		string RelativePath { get; set; }
		
		[Export("children", ArgumentSemantic.Copy)]
		NSObject [] Children { get; }
		
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

		[Export("name", ArgumentSemantic.Copy)]
		string Name { get; set; }

		[Export("pageOrNameString")]
		string PageOrNameString { get; }

		[Export("isEqualToBookmark:")]
		bool IsEqualToBookmark (PSPDFBookmark otherBookmark);
	}
	
	
	//////////////////////////////
	////	PSPDFPageView.h		//
	//////////////////////////////
	
	delegate void PSPDFPageViewUpdateShadowBlock (PSPDFPageView pageView);
	delegate void PSPDFPageViewUpdatePageAnnotationView (PSPDFAnnotation annotation);
	
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
		
		[Export ("cachedAnnotationViewForAnnotation:")]
		PSPDFAnnotationView CachedAnnotationViewForAnnotation (PSPDFAnnotation annotation);
		
		[Export ("contentView")]
		UIImageView ContentView { get; }
		
		[Export ("renderView")]
		UIImageView RenderView { get; }

		[Export ("annotationContainerView")]
		PSPDFAnnotationContainerView AnnotationContainerView { get; }
		
		[Export ("renderSize", ArgumentSemantic.Assign)]
		SizeF RenderSize { get; set; }
		
		[Export ("pdfScale")]
		float PdfScale { get; }
		
		[Export ("rendering", ArgumentSemantic.Assign)]
		bool Rendering { [Bind("isRendering")] get; }
		
		[Export ("visibleRect", ArgumentSemantic.Assign)]
		RectangleF VisibleRect { get; }
		
		[Export ("selectionView")]
		PSPDFTextSelectionView SelectionView { get; }
		
		[Export ("renderStatusView")]
		PSPDFRenderStatusView RenderStatusView { get; set; }

		[Export ("renderStatusViewOffset", ArgumentSemantic.Assign)]
		float RenderStatusViewOffset { get; set; }

		[Export ("centerRenderStatusView", ArgumentSemantic.Assign)]
		bool CenterRenderStatusView { get; set; }

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

		[Export ("convertGlyphRectToViewRect:")]
		RectangleF ConvertGlyphRectToViewRect (RectangleF glyphRect);

		[Export ("convertViewRectToGlyphRect:")]
		RectangleF ConvertViewRectToGlyphRect (RectangleF viewRect);

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
		
		[Export("page", ArgumentSemantic.Assign)]
		uint Page { get; }
		
		[Export("document")]
		PSPDFDocument Document { get; }
		
		[Export("pageInfo")]
		PSPDFPageInfo PageInfo { get; }
		
		[Export ("rightPage", ArgumentSemantic.Assign)]
		bool RightPage { [Bind("isRightPage")] get; }
		
		[Export ("shadowEnabled", ArgumentSemantic.Assign)]
		bool ShadowEnabled { [Bind("isShadowEnabled")] get; set; }
		
		[Export ("shadowOpacity", ArgumentSemantic.Assign)]
		float ShadowOpacity { get; set; }
		
		[Export("updateShadowAnimated:")]
		void UpdateShadowAnimated(bool animated);
		
		// Since it is not really useful to get "back" the block
		//@property(nonatomic, copy) void(^updateShadowBlock)(PSPDFPageView *pageView);
		[Export ("setUpdateShadowBlock:", ArgumentSemantic.Copy)]
		void SetUpdateShadowBlock (PSPDFPageViewUpdateShadowBlock ShadowBlock);
		
		//Extension Methods

		[Export("selectedAnnotation")]
		PSPDFAnnotation SelectedAnnotation { get; set; }
		
		[Export ("singleTapped:")]
		bool SingleTapped (UIGestureRecognizer recognizer);
		
		[Export ("longPress:")]
		bool LongPress (UILongPressGestureRecognizer recognizer);
		
		[Bind ("menuItemsForAnnotation:")]
		UIMenuItem [] MenuItemsForAnnotation (PSPDFAnnotation annotation);

		[Bind ("colorMenuItemsForAnnotation:")]
		UIMenuItem [] ColorMenuItemsForAnnotation (PSPDFAnnotation annotation);

		[Export ("colorOptions", ArgumentSemantic.Copy)]
		PSPDFOrderedDictionary ColorOptions { get; set; }
		
		[Bind ("showMenuForAnnotation:animated:")]
		void ShowMenuForAnnotation (PSPDFAnnotation annotation, bool animated);

		[Bind ("showNoteControllerForAnnotation:showKeyboard:animated:")]
		PSPDFNoteAnnotationController ShowNoteControllerForAnnotation (PSPDFAnnotation annotation, bool showKeyboard, bool animated);
		
		[Bind ("addAnnotation:animated:")]
		void AddAnnotation (PSPDFAnnotation annotation, bool animated);

		[Bind ("removeAnnotation:animated:")]
		bool RemoveAnnotation (PSPDFAnnotation annotation, bool animated);
		
		[Bind ("pspdf_scrollView:willZoomToScale:animated:")]
		void Pspdf_scrollView (UIScrollView scrollView, float scale, bool animated);

		[Bind ("loadPageAnnotationsAnimated:")]
		void LoadPageAnnotationsAnimated (bool animated);

		[Bind ("tappableAnnotationsAtPoint:")]
		PSPDFAnnotation [] TappableAnnotationsAtPoint (PointF viewPoint);

		[Bind ("singleTappedAtViewPoint:")]
		bool SingleTappedAtViewPoint (PointF viewPoint);

		[Bind ("showMenuIfSelectedAnimated:")]
		void ShowMenuIfSelectedAnimated (bool animated);

		[Bind ("renderOptionsDictWithZoomScale:")]
		NSDictionary RenderOptionsDictWithZoomScale (float zoomScale);

		[Export ("suspendUpdate", ArgumentSemantic.Assign)]
		bool SuspendUpdate { get; set; }

		[Bind ("removeAnnotationOnNextPageUpdate:")]
		bool RemoveAnnotationOnNextPageUpdate (PSPDFAnnotation annotation);

		[Bind ("updatePageAnnotationView:usingBlock:")]
		void UpdatePageAnnotationView (PSPDFAnnotationView annotationView, PSPDFPageViewUpdatePageAnnotationView block);

		[Export ("annotationSelectionView")]
		PSPDFResizableView AnnotationSelectionView { get; }

		[Export ("showLinkPreviewActionSheetForAnnotation:fromRect:animated:")]
		NSObject ShowLinkPreviewActionSheetForAnnotation (PSPDFLinkAnnotation annotation, RectangleF viewRect, bool animated);
	}

	[BaseType (typeof (UIImageView))]
	interface PSPDFRenderStatusView 
	{

	}

	[BaseType (typeof (PSPDFHUDView))]
	interface PSPDFAnnotationContainerView 
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
		bool IsAvailable ();

		[Export ("isLongPressActionAvailable")]
		bool IsLongPressActionAvailable ();
		
		[Export ("updateBarButtonItem")]
		void UpdateBarButtonItem ();

		[Export ("isLongPressActionActive")]
		void IsLongPressActionActive ();
		
		[Export ("presentAnimated:sender:")]
		NSObject PresentAnimatedSender (bool animated, PSPDFBarButtonItem sender);
		
		[Export ("dismissAnimated:")]
		void DismissAnimated (bool animated);
		
		[Export ("didDismiss")]
		void DidDismiss ();

		[Export ("setPresentedObject:sender:")]
		void SetPresentedObject (NSObject presentedObject, NSObject sender);
		
		[Export ("presentModalOrInPopover:sender:")]
		NSObject PresentModalOrInPopoverSender (UIViewController viewController, NSObject sender);
		
		[Export ("dismissModalOrPopoverAnimated:")]
		void DismissModalOrPopoverAnimated (bool animated);
		
		[Static][Export ("popoverControllerForObject:")]
		UIPopoverController PopoverControllerForObject (NSObject obj);
		
		[Export ("action:")]
		void ovrAction (PSPDFBarButtonItem sender);

		[Export ("longPressAction:")]
		void LongPressAction (PSPDFBarButtonItem sender);

		[Export ("actionSheet")]
		UIActionSheet ActionSheet { get; set; }

		[Export ("dismissingSheet", ArgumentSemantic.Assign)]
		UIActionSheet DismissingSheet { get; [Bind("isDismissingSheet")] set; }
	}

	[BaseType (typeof (UIBarButtonItem))]
	interface PSPDFCopiedBarButtonItem 
	{
		[Export ("originalBarButtonItem")]
		PSPDFBarButtonItem OriginalBarButtonItem { get; }
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
	interface PSPDFBaseViewController
	{
		
	}
	
	
	//////////////////////////////////
	////	PSPDFAnnotationView.h	//
	//////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFAnnotationView 
	{
		[Export ("annotation")]
		PSPDFAnnotation Annotation { get; set; }

		[Export ("zIndex", ArgumentSemantic.Assign)]
		uint ZIndex { get; set; }

		[Export ("zoomScale", ArgumentSemantic.Assign)]
		float ZoomScale { get; set; }
		
		[Export ("willShowPage:"), EventArgs ("PSPDFAnnotationViewWillShowPage")]
		void WillShowPage (uint page);
		
		[Export ("didShowPage:"), EventArgs ("PSPDFAnnotationViewDidShowPage")]
		void DidShowPage (uint page);
		
		[Export ("willHidePage:"), EventArgs ("PSPDFAnnotationViewWillHidePage")]
		void WillHidePage (uint page);
		
		[Export ("didHidePage:"), EventArgs ("PSPDFAnnotationViewDidHidePage")]
		void DidHidePage (uint page);
		
		[Export ("didChangePageFrame:"), EventArgs ("PSPDFAnnotationViewDidChangePageFrame")]
		void DidChangePageFrame (Rectangle frame);
	}
	
	//////////////////////////////////////////
	////		PSPDFAnnotation.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFAnnotation 
	{
		[Static][Export ("supportedTypes")]
		string [] SupportedTypes ();
		
		[Static][Export ("isWriteable")]
		bool IsWriteable { get; }
		
		[Export ("isMovable")]
		bool IsMovable { get; }

		[Export ("isResizable")]
		bool IsResizable { get; }
		
		[Export ("initWithType:")]
		IntPtr Constructor (PSPDFAnnotationType annotationType);
		
		[Export ("initWithAnnotationDictionary:inAnnotsArray:")][Internal]
		IntPtr Constructor (IntPtr /*CGPDFDictionary*/ annotDict, IntPtr /*CGPDFArray*/ annotsArray);
		
		[Export ("initWithAnnotationDictionary:inAnnotsArray:type:")][Internal]
		IntPtr Constructor (IntPtr /*CGPDFDictionary*/ annotDict, IntPtr /*CGPDFArray*/ annotsArray, PSPDFAnnotationType annotationType);
		
		[Export ("hitTest:")]
		bool HitTest (PointF point);
		
		[Export ("rectForPageRect:")]
		RectangleF RectForPageRect (RectangleF pageRect);
		
		[Export ("compareByPositionOnPage:")]
		NSComparisonResult CompareByPositionOnPage (PSPDFAnnotation otherAnnotation);
		
		[Export ("rectFromPDFArray:")][Internal]
		RectangleF RectFromPDFArray_ (IntPtr /* CGPDFArray */ array);
		
		[Export ("rectsFromQuadPointsInArray:")][Internal]
		NSArray RectsFromQuadPointsInArray_ (IntPtr /*CGPDFArray*/ quadPointsArray);
		
		[Export ("drawInContext:")]
		void DrawInContext (CGContext context);
		
		[Export ("prepareBorderStyleInContext:")]
		void PrepareBorderStyleInContext (CGContext context);
		
		[Export ("type", ArgumentSemantic.Assign)]
		PSPDFAnnotationType AnnotationType { get; }
		
		[Export ("overlay", ArgumentSemantic.Assign)]
		bool Overlay { [Bind("isOverlay")] get; [NullAllowed]set; }
		
		[Export ("editable", ArgumentSemantic.Assign)]
		bool Editable { [Bind("isEditable")] get; set; }
		
		[Export ("typeString", ArgumentSemantic.Copy)]
		string TypeString { get; [NullAllowed]set; }
		
		[Export ("alpha", ArgumentSemantic.Assign)]
		float Alpha { get; set; }
		
		[Export ("color")]
		UIColor Color { get; [NullAllowed]set; }
		
		[Export ("colorWithAlpha")]
		UIColor colorWithAlpha { get; }
		
		[Export ("fillColor")]
		UIColor FillColor { get; [NullAllowed] set; }

		[Export ("fillColorWithAlpha")]
		UIColor FillColorWithAlpha { get; }
		
		[Export ("contents", ArgumentSemantic.Copy)]
		string Contents { get; [NullAllowed]set; }

		[Export ("name", ArgumentSemantic.Copy)]
		string Name { get; [NullAllowed] set; }

		[Export ("lastModified")]
		NSDate LastModified { get; [NullAllowed] set; }
		
		[Export ("lineWidth", ArgumentSemantic.Assign)]
		float LineWidth { get; set; }
		
		[Export ("borderStyle", ArgumentSemantic.Assign)]
		PSPDFAnnotationBorderStyle BorderStyle { get; [NullAllowed]set; }
		
		[Export ("dashArray", ArgumentSemantic.Copy)]
		NSArray DashArray { get; [NullAllowed]set; }
		
		[Export ("deleted", ArgumentSemantic.Assign)]
		bool Deleted { [Bind ("isDeleted")] get; set; }
		
		[Export ("boundingBox", ArgumentSemantic.Assign)]
		RectangleF BoundingBox { get; set; }
		
		[Export ("user", ArgumentSemantic.Copy)]
		string User { get; [NullAllowed]set; }
		
		[Export ("page", ArgumentSemantic.Assign)]
		uint Page { get; set; }
		
		[Export ("absolutePage", ArgumentSemantic.Assign)]
		uint AbsolutePage { get; }
		
		[Export ("dirty", ArgumentSemantic.Assign)]
		bool Dirty { [Bind ("isDirty")] get; set; }
		
		[Export ("documentProvider")]
		PSPDFDocumentProvider DocumentProvider { get; [NullAllowed]set; }
		
		[Export ("document", ArgumentSemantic.Assign)]
		PSPDFDocument Document { get; }
		
		[Export ("rotation", ArgumentSemantic.Assign)]
		int Rotation { get; set; }
		
		[Export ("isEqualToAnnotation:")]
		int IsEqualToAnnotation (PSPDFAnnotation otherAnnotation);
		
		// Constants

		[Field ("PSPDFAnnotationTypeStringLink", "__Internal")]
		NSString PSPDFAnnotationTypeStringLink { get; }

		[Field ("PSPDFAnnotationTypeStringHighlight", "__Internal")]
		NSString PSPDFAnnotationTypeStringHighlight { get; }
		
		[Field ("PSPDFAnnotationTypeStringUnderline", "__Internal")]
		NSString PSPDFAnnotationTypeStringUnderline { get; }
		
		[Field ("PSPDFAnnotationTypeStringStrikeout", "__Internal")]
		NSString PSPDFAnnotationTypeStringStrikeout { get; }
		
		[Field ("PSPDFAnnotationTypeStringNote", "__Internal")]
		NSString PSPDFAnnotationTypeStringNote { get; }
		
		[Field ("PSPDFAnnotationTypeStringFreeText", "__Internal")]
		NSString PSPDFAnnotationTypeStringFreeText { get; }
		
		[Field ("PSPDFAnnotationTypeStringInk", "__Internal")]
		NSString PSPDFAnnotationTypeStringInk { get; }
		
		[Field ("PSPDFAnnotationTypeStringSquare", "__Internal")]
		NSString PSPDFAnnotationTypeStringSquare { get; }
		
		[Field ("PSPDFAnnotationTypeStringCircle", "__Internal")]
		NSString PSPDFAnnotationTypeStringCircle { get; }

		[Field ("PSPDFAnnotationTypeStringSignature", "__Internal")]
		NSString PSPDFAnnotationTypeStringSignature { get; }
		
		//Exstensions
		
		[Bind ("pdfRectString")]
		string PdfRectString ();
		
		[Bind ("pdfColorString")]
		string PdfColorString ();
		
		[Bind ("pdfFillColorString")]
		string PdfFillColorString ();
		
		[Bind ("pdfColorWithAlphaString")]
		string PdfColorWithAlphaString ();

		[Bind ("pdfBorderString")]
		string PdfBorderString ();
		
		[Bind ("appendEscapedContents:")]
		void AppendEscapedContents (NSMutableData pdfData);
		
		[Static][Bind ("stringsFromRectsArray:")]
		string [] StringsFromRectsArray (NSObject [] rects);
		
		[Static][Bind ("rectsFromStringsArray:")]
		NSObject [] RectsFromStringsArray (string [] rectStrings);
		
		[Bind ("pdfDataRepresentation")]
		NSData PdfDataRepresentation ();
		
		[Bind ("copyAndDeleteOriginalIfNeeded")]
		NSObject CopyAndDeleteOriginalIfNeeded ();
		
		[Export ("indexOnPage", ArgumentSemantic.Assign)]
		int IndexOnPage { get; set; }
		
		[Export ("popupIndex", ArgumentSemantic.Assign)]
		int PopupIndex { get; set; }
		
		[Export ("parse")]
		void Parse ();
	}

	//////////////////////////////////////////////////
	////		PSPDFTextSelectionView.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (UIView))]
	interface PSPDFTextSelectionView 
	{
		[Export ("selectedGlyphs", ArgumentSemantic.Copy)]
		PSPDFGlyph [] SelectedGlyphs { get; set; }
		
		[Export ("selectedText", ArgumentSemantic.Copy)]
		string SelectedText { get; set; }

		[Export ("selectedImage")]
		PSPDFImageInfo SelectedImage { get; set; }
		
		[Export ("trimmedSelectedText", ArgumentSemantic.Copy)]
		string TrimmedSelectedText { get; }

		[Export ("pageView")]
		PSPDFPageView PageView { get; set; }

		[Export ("firstLineRect", ArgumentSemantic.Assign)]
		RectangleF FirstLineRect { get; }

		[Export ("lastLineRect", ArgumentSemantic.Assign)]
		RectangleF LastLineRect { get; }

		[Export ("selectionRect", ArgumentSemantic.Assign)]
		RectangleF SelectionRect { get; }

		[Export ("updateMenuAnimated:")]
		bool UpdateMenuAnimated (bool animated);

		[Export ("updateSelection")]
		void UpdateSelection ();

		[Export ("discardSelection")]
		void DiscardSelection ();

		[Export ("hasSelection")]
		bool HasSelection { get; }

		[Export ("isTextSelectionFeatureAvailable")] [Static]
		bool IsTextSelectionFeatureAvailable { get; }

		// SubclassingHooks

		[Export ("loupeView")]
		PSPDFLoupeView LoupeView { get; set; }
		
		[Bind ("menuItemsForTextSelection:")]
		PSPDFMenuItem [] MenuItemsForTextSelection (string selectedText);

		[Bind ("menuItemsForImageSelection:")]
		PSPDFMenuItem [] MenuItemsForImageSelection (PSPDFImageInfo imageSelection);
		
		[Bind ("showTextFlowData:animated:")]
		void ShowTextFlowData (bool show, bool animated);

		[Bind ("longPress:")]
		bool LongPress (UILongPressGestureRecognizer recognizer);

		[Bind ("pressRecognizerShouldHandlePressImmediately:")]
		bool PressRecognizerShouldHandlePressImmediately (PSPDFLongPressGestureRecognizer recognizer);
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

		[Export ("prepareShow")]
		void PrepareShow ();

		[Export ("showLoupeAnimated:")]
		void ShowLoupeAnimated (bool animated);

		[Export ("hideLoupeAnimated:")]
		void HideLoupeAnimated (bool animated);

	}
	
	//////////////////////////////
	////	PSPDFTextParser.h	//
	//////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFTextParser 
	{		
		[Export ("initWithPDFPage:page:document:fontCache:hideGlyphsOutsidePageRect:PDFBox:")][Internal]
		IntPtr Constructor (IntPtr /*CGPDFPage*/ pageRef, uint page, PSPDFDocument document, [NullAllowed] NSMutableDictionary fontCache, bool hideGlyphsOutsidePageRect, CGPDFBox PDFBox);

		[Export ("text", ArgumentSemantic.Copy)][NullAllowed]
		string Text { get; set; }

		[Export ("textWithGlyphs:")]
		string TextWithGlyphs (PSPDFGlyph [] glyphs);
		
		[Export ("glyphs")]
		PSPDFGlyph [] Glyphs { get; }
		
		[Export ("words")]
		PSPDFWord [] Words { get; }

		[Export ("images")]
		PSPDFImageInfo [] Images { get; }
		
		[Export ("textBlocks", ArgumentSemantic.Copy)]
		PSPDFTextBlock [] TextBlocks { get; }

		[Export ("document")]
		PSPDFDocument Document { get; set;}
	}

	//////////////////////////////
	////	PSPDFTextBlock.h	//
	//////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFTextBlock 
	{	
		[Export ("initWithGlyphs:")]
		IntPtr Constructor (PSPDFGlyph [] glyps);

		[Export ("frame", ArgumentSemantic.Assign)]
		RectangleF Frame { get; }

		[Export ("words", ArgumentSemantic.Copy)]
		PSPDFWord [] Words { get; }

		[Export ("glyphs", ArgumentSemantic.Copy)]
		PSPDFGlyph [] Glyphs { get; set; }
		
		[Export ("content",ArgumentSemantic.Copy)]
		string Content { get; }

		[Export ("isEqualToTextBlock:")]
		bool IsEqualToTextBlock (PSPDFTextBlock otherBlock);
	}
	
	//////////////////////////////////////////////
	////		PSPDFInkAnnotation.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFAnnotation))]
	interface PSPDFInkAnnotation 
	{
		[Export ("lines")]
		NSArray Lines { get; [NullAllowed]set; }
		
		[Export ("paths")]
		UIBezierPath [] Paths { get; [NullAllowed]set; }

		[Export ("rebuildPaths")]
		void RebuildPaths ();
		
		[Export ("copyLinesByApplyingTransform:")]
		NSArray CopyLinesByApplyingTransform (CGAffineTransform transfrom);		
	}
	
	//////////////////////////////////////////////////
	////		PSPDFHighlightAnnotation.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFAnnotation))]
	interface PSPDFHighlightAnnotation 
	{
		[Export ("initWithHighlightType:")]
		IntPtr Constructor (PSPDFHighlightAnnotationType annotationType);

		[Export ("highlightType", ArgumentSemantic.Assign)]
		PSPDFHighlightAnnotationType HighlightType { get; set; }
		
		[Export ("rects")]
		NSArray Rects { get; [NullAllowed]set; }

		[Export ("highlightedString")]
		string HighlightedString { get; }

		[Export ("highlightTypeFromTypeString:")] [Static]
		PSPDFHighlightAnnotationType HighlightTypeFromTypeString (string typeString);
	}
	
	//////////////////////////////////////////
	////		PSPDFScrollView.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (UIScrollView))]
	interface PSPDFScrollView : UIScrollViewDelegateProtocol, PSPDFLongPressGestureRecognizerDelegate
	{
		[Export("initWithFrame:")]
		IntPtr Constructor (RectangleF frame);

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

		[Export("setCurrentTouchEventAsProcessed")]
		void SetCurrentTouchEventAsProcessed ();
		
		[Export("singleTapped:")]
		void SingleTapped (UITapGestureRecognizer recognizer);
		
		[Export("doubleTapped:")]
		void DoubleTapped (UITapGestureRecognizer recognizer);
		
		[Export("longPress:")]
		void LongPress (UILongPressGestureRecognizer recognizer);
		
		[Export("pathShadowForView:")]
		NSObject PathShadowForView (UIView imgView);
		
		// Obj-c Extension PSPDFInternal
		
		[Export("compoundView")]
		UIView CompoundView { get; }

		[Export("loupeView")]
		PSPDFLoupeView LoupeView { get; }
		
		[Export("rotationActive", ArgumentSemantic.Assign)]
		bool RotationActive { [Bind("isRotationActive")] get; set; }

		[Export("animatingZoomIn", ArgumentSemantic.Assign)]
		bool AnimatingZoomIn { [Bind("isAnimatingZoomIn")] get; }
		
		[Bind("switchPages")]
		void SwitchPages ();

		[Bind("ensureContentIsCentered")]
		void EnsureContentIsCentered ();
		
		[Bind("pageViewForPoint:")]
		PSPDFPageView PageViewForPoint (PointF point);
	}

	//////////////////////////////////////
	////		PSPDFPageInfo.h			//
	//////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFPageInfo 
	{
		[Export ("initWithPage:rect:rotation:documentProvider:")]
		IntPtr Constructor (uint page, RectangleF pageRect, int rotation, PSPDFDocumentProvider documentProvider);
		
		[Export("pageRect", ArgumentSemantic.Assign)]
		RectangleF PageRect { get; }
		
		[Export("rotatedPageRect", ArgumentSemantic.Assign)]
		RectangleF RotatedPageRect { get; }
		
		[Export("pageRotation", ArgumentSemantic.Assign)]
		uint PageRotation { get; set; }
		
		[Export("pageRotationTransform", ArgumentSemantic.Assign)]
		CGAffineTransform pageRotationTransform { get; }
		
		[Export("page", ArgumentSemantic.Assign)]
		uint Page { get; }
		
		[Export("documentProvider")]
		PSPDFDocumentProvider DocumentProvider { get; }

		[Export("isEqualToPageInfo:")]
		bool IsEqualToPageInfo (PSPDFPageInfo otherPageInfo);
	}
	
	//////////////////////////////////////////////
	////		PSTCollectionViewCell.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (UIView))]
	interface PSTCollectionReusableView 
	{
		[Export("reuseIdentifier", ArgumentSemantic.Copy)]
		string ReuseIdentifier { get; }
		
		[Export("prepareForReuse")]
		void PrepareForReuse ();
		
		[Export("applyLayoutAttributes:")]
		void ApplyLayoutAttributes (PSTCollectionViewLayoutAttributes layoutAttributes);
		
		[Export("willTransitionFromLayout:toLayout:")]
		void WillTransitionFromLayoutToLayout (PSTCollectionViewLayout oldLayout, PSTCollectionViewLayout newLayout);
		
		[Export("didTransitionFromLayout:toLayout:")]
		void DidTransitionFromLayoutToLayout (PSTCollectionViewLayout oldLayout, PSTCollectionViewLayout newLayout);
	}
	
	[BaseType (typeof (PSTCollectionReusableView))]
	interface PSTCollectionViewCell 
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

		// Extensions

		[Export("collectionView")]
		PSTCollectionView CollectionView { get; set; }

		[Export("reuseIdentifier")][New]
		string ReuseIdentifier { get; set; }

		[Export("layoutAttributes")]
		PSTCollectionViewLayoutAttributes LayoutAttributes { get; }
	}
	
	//////////////////////////////////////////////////
	////		PSTCollectionViewCommon.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSTCollectionViewDataSource 
	{
		[Abstract][Export ("collectionView:numberOfItemsInSection:")]
		int CollectionViewNumberOfItemsInSection (PSTCollectionView collectionView, int section);
		
		[Abstract][Export ("collectionView:cellForItemAtIndexPath:")]
		PSTCollectionViewCell CollectionViewCellForItemAtIndexPath (PSTCollectionView collectionView, NSIndexPath indexPath);
		
		[Export ("numberOfSectionsInCollectionView:")]
		int NumberOfSectionsInCollectionView (PSTCollectionView collectionView);
		
		[Export ("collectionView:viewForSupplementaryElementOfKind:atIndexPath:")]
		PSTCollectionReusableView CollectionViewViewForSupplementaryElementOfKind (PSTCollectionView collectionView, string kind, NSIndexPath indexPath);
	}
	
	[BaseType (typeof (UIScrollViewDelegate))]
	[Model]
	interface PSTCollectionViewDelegate 
	{
		[Export ("collectionView:shouldHighlightItemAtIndexPath:")]
		bool ShouldHighlightItem (PSTCollectionView collectionView, NSIndexPath indexPath);
		
		[Export ("collectionView:didHighlightItemAtIndexPath:")]
		void DidHighlightItem (PSTCollectionView collectionView, NSIndexPath indexPath);
		
		[Export ("collectionView:didUnhighlightItemAtIndexPath:")]
		void DidUnhighlightItem (PSTCollectionView collectionView, NSIndexPath indexPath);
		
		[Export ("collectionView:shouldSelectItemAtIndexPath:")]
		bool ShouldSelectItem (PSTCollectionView collectionView, NSIndexPath indexPath);
		
		[Export ("collectionView:shouldDeselectItemAtIndexPath:")]
		bool ShouldDeselectItem (PSTCollectionView collectionView, NSIndexPath indexPath);
		
		[Export ("collectionView:didSelectItemAtIndexPath:")]
		void DidSelectItem (PSTCollectionView collectionView, NSIndexPath indexPath);
		
		[Export ("collectionView:didDeselectItemAtIndexPath:")]
		void DidDeselectItem (PSTCollectionView collectionView, NSIndexPath indexPath);
		
		[Export ("collectionView:didEndDisplayingCell:forItemAtIndexPath:")]
		void DidEndDisplayingCell (PSTCollectionView collectionView, PSTCollectionViewCell cell, NSIndexPath indexPath);
		
		[Export ("collectionView:didEndDisplayingSupplementaryView:forElementOfKind:atIndexPath:")]
		void DidEndDisplayingSupplementaryView (PSTCollectionView collectionView, PSTCollectionReusableView view, string elementKind, NSIndexPath indexPath);
		
		[Export ("collectionView:shouldShowMenuForItemAtIndexPath:")]
		bool ShouldShowMenuForItem (PSTCollectionView collectionView, NSIndexPath indexPath);
		
		[Export ("collectionView:canPerformAction:forItemAtIndexPath:withSender")]
		bool CanPerformAction (PSTCollectionView collectionView, Selector action, NSIndexPath indexPath, NSObject sender);
		
		[Export ("collectionView:performAction:forItemAtIndexPath:withSender")]
		void PerformAction (PSTCollectionView collectionView, Selector action, NSIndexPath indexPath, NSObject sender);
	}	

	//////////////////////////////////////////
	////		PSTCollectionView.h			//
	//////////////////////////////////////////

	delegate void PSTCollectionViewPerformBatchUpdates();
	delegate void PSTCollectionViewCompletion(bool finished);

	[BaseType (typeof (UIScrollView))]
	interface PSTCollectionView 
	{
		[Export ("initWithFrame:collectionViewLayout:")]
		IntPtr Constructor (RectangleF frame, PSTCollectionViewLayout layout);
		
		[Export("collectionViewLayout", ArgumentSemantic.Retain)]
		PSTCollectionViewLayout CollectionViewLayout { get; set; }
		
		[Wrap ("WeakDelegate")][New]
		PSTCollectionViewDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed][New]
		NSObject WeakDelegate { get; set; }
		
		[Wrap ("WeakDataSource")]
		PSTCollectionViewDataSource DataSource { get; set; }
		
		[Export ("dataSource", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDataSource { get; set; }
		
		[Export("backgroundView", ArgumentSemantic.Retain)]
		UIView BackgroundView { get; set; }
		
		[Export ("registerClass:forCellWithReuseIdentifier:")]
		void RegisterClass (Class cellClass, string identifier);
		
		[Export ("registerClass:forSupplementaryViewOfKind:withReuseIdentifier:")]
		void RegisterClass (Class viewClass, string elementKind, string identifier);

		[Export ("registerNib:forCellWithReuseIdentifier:")]
		void RegisterNib (UINib nib, string identifier);

		[Export ("registerNib:forSupplementaryViewOfKind:withReuseIdentifier:")]
		void RegisterNib (UINib nib, string kind, string identifier);
		
		[Export ("dequeueReusableCellWithReuseIdentifier:forIndexPath:")]
		NSObject DequeueReusableCell (string identifier, NSIndexPath indexPath);
		
		[Export ("dequeueReusableSupplementaryViewOfKind:withReuseIdentifier:forIndexPath:")]
		NSObject DequeueReusableSupplementaryViewOfKind (string elementKind, string identifier, NSIndexPath indexPath);
		
		[Export("allowsSelection")]
		bool AllowsSelection { get; set; }
		
		[Export("allowsMultipleSelection")]
		bool AllowsMultipleSelection { get; set; }
		
		[Export("indexPathsForSelectedItems")][NullAllowed]
		NSIndexPath [] IndexPathsForSelectedItems();
		
		[Export("selectItemAtIndexPath:animated:scrollPosition:")]
		void SelectItemAtIndexPath(NSIndexPath indexPath, bool animated, PSTCollectionViewScrollPosition scrollPosition);
		
		[Export("deselectItemAtIndexPath:animated:")]
		void DeselectItemAtIndexPath(NSIndexPath indexPath, bool animated);
		
		[Export("reloadData")]
		void ReloadData();
		
		[Export("setCollectionViewLayout:animated:")]
		void SetCollectionViewLayout(PSTCollectionViewLayout layout, bool animated);
		
		[Export("numberOfSections")]
		int NumberOfSections();
		
		[Export("numberOfItemsInSection:")]
		int NumberOfItemsInSection(int section);
		
		[Export("layoutAttributesForItemAtIndexPath:")]
		PSTCollectionViewLayoutAttributes LayoutAttributesForItemAtIndexPath(NSIndexPath indexPath);
		
		[Export("layoutAttributesForSupplementaryElementOfKind:atIndexPath:")]
		PSTCollectionViewLayoutAttributes LayoutAttributesForSupplementaryElementOfKind(string kind, NSIndexPath indexPath);
		
		[Export("indexPathForItemAtPoint:")]
		NSIndexPath IndexPathForItemAtPoint(PointF point);
		
		[Export("indexPathForCell:")]
		NSIndexPath IndexPathForCell(PSTCollectionViewCell cell);
		
		[Export("cellForItemAtIndexPath:")]
		PSTCollectionViewCell CellForItemAtIndexPath(NSIndexPath indexPath);
		
		[Export("visibleCells")]
		NSObject [] VisibleCells();
		
		[Export("indexPathsForVisibleItems")]
		NSIndexPath [] IndexPathsForVisibleItems();
		
		[Export("scrollToItemAtIndexPath:atScrollPosition:animated:")]
		void ScrollToItemAtIndexPath(NSIndexPath indexPath, PSTCollectionViewScrollPosition scrollPosition, bool animated);
		
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
		
		[Export("performBatchUpdates:completion:")]
		void MoveItemAtIndexPath(PSTCollectionViewPerformBatchUpdates updates, PSTCollectionViewCompletion completion);	
	}

	[BaseType (typeof (PSTCollectionView))]
	interface PSUICollectionView 
	{
	}
	
	//////////////////////////////////////////////////
	////		PSTCollectionViewLayout.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSTCollectionViewLayoutAttributes 
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
		PSTCollectionViewItemType RepresentedElementCategory { get; }
		
		[Bind ("isDecorationView")]
		bool IsDecorationView ();
		
		[Bind ("isSupplementaryView")]
		bool IsSupplementaryView ();
		
		[Bind ("isCell")]
		bool IsCell ();
	}
	
	[BaseType (typeof (NSObject))]
	interface PSTCollectionViewLayout 
	{
		[Field ("PSTCollectionViewLayoutAwokeFromNib", "__Internal")]
		NSString PSTCollectionViewLayoutAwokeFromNib { get; }

		[Export("collectionView")]
		PSTCollectionView CollectionView { get; }

		[Export("invalidateLayout")]
		void InvalidateLayout();

		[Export ("registerClass:forDecorationViewWithReuseIdentifier:")] 
		void RegisterClass (Class c, NSString id);
		
		[Export ("registerNib:forDecorationViewWithReuseIdentifier:")] 
		void RegisterNib (UINib nib, NSString id);
		
		// Extension methods SubclassingHooks
		
		[Bind("prepareLayout")]
		void PrepareLayout();
		
		[Bind("layoutAttributesForElementsInRect:")]
		PSTCollectionViewLayoutAttributes [] LayoutAttributesForElementsInRect(RectangleF rect);
		
		[Bind("layoutAttributesForItemAtIndexPath:")]
		PSTCollectionViewLayoutAttributes LayoutAttributesForElementsInRect(NSIndexPath indexPath);
		
		[Bind("layoutAttributesForSupplementaryViewOfKind:atIndexPath:")]
		PSTCollectionViewLayoutAttributes LayoutAttributesForElementsInRect(string kind, NSIndexPath indexPath);
		
		[Bind("layoutAttributesForDecorationViewWithReuseIdentifier:atIndexPath:")]
		PSTCollectionViewLayoutAttributes LayoutAttributesForDecorationViewWithReuseIdentifier(string identifier, NSIndexPath indexPath);
		
		[Bind("shouldInvalidateLayoutForBoundsChange:")]
		bool ShouldInvalidateLayoutForBoundsChange(RectangleF newBounds);
		
		[Bind("targetContentOffsetForProposedContentOffset:withScrollingVelocity:")]
		PointF TargetContentOffsetForProposedContentOffset(PointF proposedContentOffset, PointF velocity);
		
		[Bind("collectionViewContentSize")]
		SizeF CollectionViewContentSize();
		
		// Extension methods UpdateSupportHooks
		
		[Bind("finalizeCollectionViewUpdates")]
		void FinalizeCollectionViewUpdates();
		
		[Bind("initialLayoutAttributesForInsertedItemAtIndexPath:")]
		PSTCollectionViewLayoutAttributes InitialLayoutAttributesForInsertedItemAtIndexPath(NSIndexPath itemIndexPath);
		
		[Bind("finalLayoutAttributesForDeletedItemAtIndexPath:")]
		PSTCollectionViewLayoutAttributes FinalLayoutAttributesForDeletedItemAtIndexPath(NSIndexPath itemIndexPath);

		[Bind("initialLayoutAttributesForInsertedSupplementaryElementOfKind:atIndexPath:")]
		PSTCollectionViewLayoutAttributes InitialLayoutAttributesForInsertedSupplementaryElementOfKind(string elementKind, NSIndexPath elementIndexPath);

		[Bind("finalLayoutAttributesForDeletedSupplementaryElementOfKind:atIndexPath:")]
		PSTCollectionViewLayoutAttributes FinalLayoutAttributesForDeletedSupplementaryElementOfKind(string elementKind, NSIndexPath elementIndexPath);
		
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
		[Export("iconName", ArgumentSemantic.Copy)]
		string IconName { get; set; }

		[Export ("hitTest:withViewBounds:")]
		bool HitTestWithViewBounds (PointF point, RectangleF bounds);

		[Export ("boundingBoxForPageViewBounds:")]
		RectangleF BoundingBoxForPageViewBounds (RectangleF pageBounds);
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
	
	[BaseType (typeof (PSPDFAnnotation))]
	interface PSPDFLinkAnnotation 
	{
		[Export ("initWithLinkAnnotationType:")]
		IntPtr Constructor (PSPDFLinkAnnotationType linkAnotationType);

		[Export ("initWithSiteLinkTarget:")]
		IntPtr Constructor (string siteLinkTarget);

		[Export("linkType", ArgumentSemantic.Assign)]
		PSPDFLinkAnnotationType LinkType { get; set; }

		[Export("showAsLinkView", ArgumentSemantic.Assign)]
		bool ShowAsLinkView { get; }
		
		[Export("pageLinkTarget", ArgumentSemantic.Assign)] [NullAllowed]
		uint PageLinkTarget { get; set; }

		[Export("multimediaExtension", ArgumentSemantic.Assign)]
		bool MultimediaExtension { [Bind("isMultimediaExtension")] get; }
		
		[Export("siteLinkTarget", ArgumentSemantic.Copy)]
		string SiteLinkTarget { get; set; }
		
		[Export("URL")]
		NSUrl Url { get; set; }

		[Export("targetString")]
		string TargetString ();
		
		[Export("rects", ArgumentSemantic.Copy)]
		NSObject [] Rects { get; set; }

		[Export("options", ArgumentSemantic.Copy)]
		NSDictionary Options { get; set; }
		
		[Export("modal", ArgumentSemantic.Assign)]
		bool Modal { [Bind("isModal")] get; set; }
		
		[Export("popover", ArgumentSemantic.Assign)]
		bool Popover { [Bind("isPopover")] get; set; }

		[Export("controlsEnabled", ArgumentSemantic.Assign)]
		bool ControlsEnabled { get; set; }

		[Export("autoplayEnabled", ArgumentSemantic.Assign)]
		bool AutoplayEnabled { [Bind("isAutoplayEnabled")] get; set; }

		[Export("offset", ArgumentSemantic.Assign)]
		float Offset { get; set; }

		[Export("size", ArgumentSemantic.Assign)]
		SizeF Size { get; set; }
	}
	
	//////////////////////////////////////////////
	////		PSPDFShapeAnnotation.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFAnnotation))] 
	interface PSPDFShapeAnnotation 
	{
		[Export ("initWithShapeType:")]
		IntPtr Constructor (PSPDFShapeAnnotationType shapeType);

		[Export("shapeType", ArgumentSemantic.Assign)]
		PSPDFShapeAnnotationType ShapeType { get; set; }
	}
	
	//////////////////////////////////////////////////////
	////		PSPDFLinkAnnotationBaseView.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (UIView))] 
	interface PSPDFLinkAnnotationBaseView : PSPDFAnnotationView
	{
		[Export("initWithFrame:")]
		IntPtr Constructor (RectangleF frame);

		[Export("linkAnnotation")]
		PSPDFLinkAnnotation LinkAnnotation { get; }

//		[Export("zIndex", ArgumentSemantic.Assign)] // Already inlined
//		uint ZIndex { get; set; }
	}
	
	//////////////////////////////////////////////////
	////		PSPDFLinkAnnotationView.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFLinkAnnotationBaseView))] 
	interface PSPDFLinkAnnotationView
	{
		[Export("initWithFrame:")]
		IntPtr Constructor (RectangleF frame);

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
		
		[Export("autoplayEnabled", ArgumentSemantic.Assign)]
		bool AutostartEnabled { [Bind("isAutoplayEnabled")] get; set; }
		
		[Export("useApplicationAudioSession", ArgumentSemantic.Assign)]
		bool UseApplicationAudioSession { get; set; }
		
		[Export("player")]
		MPMoviePlayerController Player { get; }

		[Export("coverView")]
		PSPDFVideoAnnotationCoverView CoverView { get; set; }

		[Export("zIndex", ArgumentSemantic.Assign)]
		uint ZIndex { get; set; }

		// SubclassingHooks

		[Bind ("coverURL")]
		NSUrl CoverURL ();

		[Bind ("addCoverView")]
		void AddCoverView ();
	}

	[BaseType (typeof (UIView))] 
	interface PSPDFVideoAnnotationCoverView 
	{
		[Export("coverImage")]
		UIImageView CoverImage { get; set; }

		[Export("playButton")]
		UIButton PlayButton { get; set; }
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

	delegate void PSPDFWebViewControllerCompletionHandler (PSPDFAlertView alert, uint buttonIndex);

	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFWebViewControllerDelegate 
	{
		[Export("masterViewController")][Abstract]
		UIViewController MasterViewController ();

//		TODO: Verify why delegate is not reaching when Model Attribute is Applied

//		[Export("handleExternalURL:buttonCompletionBlock:")]
//		bool HandleExternalURL (NSUrl url, PSPDFWebViewControllerCompletionHandler handler);
	}

	[BaseType (typeof (PSPDFBaseViewController))] 
	interface PSPDFWebViewController : PSPDFStyleable
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

		[Wrap ("WeakDelegate")]
		PSPDFWebViewControllerDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Export("updateGlobalActivityIndicator", ArgumentSemantic.Assign)]
		bool UpdateGlobalActivityIndicator { get; set; }

		[Bind ("setActivityIndicatorEnabled:")]
		void SetActivityIndicatorEnabled (bool enabled);
	}
	
	//////////////////////////////////////////////
	////		PSPDFSelectionView.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFSelectionViewDelegate 
	{		
		[Export ("selectionView:shouldStartSelectionAtPoint:"), DelegateName ("PSPDFSelectionViewShouldStartSelectionAtPoint"), DefaultValue (true)]
		bool ShouldStartSelectionAtPoint (PSPDFSelectionView selectionView, PointF point);
		
		[Export ("selectionView:updateSelectedRect:"), EventArgs ("PSPDFSelectionViewRect")]
		void UpdateSelectedRect (PSPDFSelectionView selectionView, RectangleF rect);
		
		[Export ("selectionView:finishedWithSelectedRect:"), EventArgs ("PSPDFSelectionViewRect")]
		void FinishedWithSelectedRect (PSPDFSelectionView selectionView, RectangleF rect);
		
		[Export ("selectionView:cancelledWithSelectedRect:"), EventArgs ("PSPDFSelectionViewRect")]
		void CancelledWithSelectedRect (PSPDFSelectionView selectionView, RectangleF rect);
	}
	
	[BaseType (typeof (UIView),
	Delegates=new string [] {"WeakDelegate"},
	Events=new Type [] { typeof (PSPDFSelectionViewDelegate) })]
	interface PSPDFSelectionView 
	{
		[Export("initWithFrame:delegate:")]
		IntPtr Constructor (RectangleF frame, PSPDFSelectionViewDelegate Delegate);
		
		[Wrap ("WeakDelegate")]
		PSPDFSelectionViewDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Export ("selectionColor")]
		UIColor SelectionColor { get; set; }

		[Export ("wordSelectionColor")]
		UIColor WordSelectionColor { get; set; }

		[Export ("rects")]
		NSArray Rects { get; set; }

		[Export ("setRawRects:count:")]
		void SetRawRects (RectangleF rawRects, uint count);
	}

	//////////////////////////////////////////////////////
	////		PSPDFNoteAnnotationController.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFNoteAnnotationControllerDelegate 
	{				
		[Export ("noteAnnotationController:didDeleteAnnotation:"), EventArgs ("PSPDFNoteAnnotationControllerAnnot")]
		void DidDeleteAnnotation (PSPDFNoteAnnotationController noteAnnotationController, PSPDFAnnotation annotation);
		
		[Export ("noteAnnotationController:didChangeAnnotation:originalAnnotation:"), EventArgs ("PSPDFNoteAnnotationControllerAnnotOrig")]
		void DidChangeAnnotation (PSPDFNoteAnnotationController noteAnnotationController, PSPDFAnnotation annotation, PSPDFAnnotation originalAnnotation);

		[Export ("noteAnnotationController:willDismissWithAnnotation:"), EventArgs ("PSPDFNoteAnnotationControllerAnnot")]
		void WillDismissWithAnnotation (PSPDFNoteAnnotationController noteAnnotationController, PSPDFAnnotation annotation);
	}
	
	[BaseType (typeof (PSPDFBaseViewController),
	Delegates=new string [] {"WeakDelegate"},
	Events=new Type [] { typeof (PSPDFNoteAnnotationControllerDelegate) })]
	interface PSPDFNoteAnnotationController : PSPDFStyleable
	{
		[Export("initWithAnnotation:editable:")]
		IntPtr Constructor (PSPDFAnnotation annotation, bool allowEditing);

		[Export("annotation")]
		PSPDFAnnotation Annotation { get; set; }

		[Export("allowEditing", ArgumentSemantic.Assign)]
		bool AllowEditing { get; }

		[Export("showColorAndIconOptions", ArgumentSemantic.Assign)]
		bool ShowColorAndIconOptions { get; set; }

		[Export("textView")]
		UITextView TextView { get; }
		
		[Wrap ("WeakDelegate")]
		PSPDFNoteAnnotationControllerDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }

		// SubclassingHooks

		[Export("deleteAnnotation:")]
		void DeleteAnnotation (UIBarButtonItem barButtonItem);

		[Export("deleteAnnotationActionTitle")]
		string DeleteAnnotationActionTitle ();

		[Export("backgroundView")]
		PSPDFGradientView BackgroundView { get; set; }

		[Export("optionsView")]
		UIView OptionsView { get; set; }
	}

	//////////////////////////////////////////////////
	////		PSPDFAnnotationToolbar.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFAnnotationToolbarDelegate 
	{		
		[Export ("annotationToolbarDidHide:finishedWithSelectedRect:"), EventArgs ("PSPDFAnnotationToolbarDidHide")]
		void DidHide (PSPDFAnnotationToolbar annotationToolbar);
		
		[Export ("annotationToolbar:didChangeMode:"), EventArgs ("PSPDFAnnotationToolbarDidChangeMode")]
		void DidChangeMode (PSPDFAnnotationToolbar annotationToolbar, PSPDFAnnotationToolbarMode newMode);
	}

	delegate void PSPDFAnnotationToolbarCompletionDel();

	[BaseType (typeof (UIToolbar),
	Delegates=new string [] {"WeakDelegate"},
	Events=new Type [] { typeof (PSPDFAnnotationToolbarDelegate) })]
	interface PSPDFAnnotationToolbar 
	{
		[Export("initWithPDFController:")]
		IntPtr Constructor (PSPDFViewController pdfController);

		[Export("showToolbarInRect:animated:")]
		void ShowToolbarInRect (RectangleF rect, bool animated);

		[Export("hideToolbarAnimated:completion:")]
		void ShowToolbarInRect (bool animated, PSPDFAnnotationToolbarCompletionDel completionBlock);

		[Export("flashToolbar")]
		void FlashToolbar ();

		[Wrap ("WeakDelegate")]
		PSPDFAnnotationToolbarDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Export ("pdfController")]
		PSPDFViewController PdfController { get; set; }

		[Export ("toolbarMode", ArgumentSemantic.Assign)]
		PSPDFAnnotationToolbarMode ToolbarMode { get; set; }

		[Export ("drawColor")]
		UIColor DrawColor { get; set; }

		[Export ("lineWidth", ArgumentSemantic.Assign)]
		float LineWidth { get; set; }

		[Export ("hideAfterDrawingDidFinish", ArgumentSemantic.Assign)]
		bool HideAfterDrawingDidFinish { get; set; }

		// PSPDFSubclassing

		[Export ("noteButtonPressed:")]
		void NoteButtonPressed (NSObject sender);

		[Export ("highlightButtonPressed:")]
		void HighlightButtonPressed (NSObject sender);

		[Export ("strikeOutButtonPressed:")]
		void StrikeOutButtonPressed (NSObject sender);

		[Export ("underlineButtonPressed:")]
		void UnderlineButtonPressed (NSObject sender);

		[Export ("drawButtonPressed:")]
		void DrawButtonPressed (NSObject sender);

		[Export ("freeTextButtonPressed:")]
		void FreeTextButtonPressed (NSObject sender);

		[Export ("signatureButtonPressed:")]
		void SignatureButtonPressed (NSObject sender);

		[Export ("doneButtonPressed:")]
		void DoneButtonPressed (NSObject sender);

		[Export ("cancelDrawingAnimated:")]
		void CancelDrawingAnimated (bool animated);

		[Export ("doneDrawingAnimated:")]
		void DoneDrawingAnimated (bool animated);

		[Export ("selectStrokeColor:")]
		void SelectStrokeColor (NSObject sender);

		[Export ("undoDrawing:")]
		void UndoDrawing (NSObject sender);

		[Export ("redoDrawing:")]
		void RedoDrawing (NSObject sender);

		[Export ("finishDrawingAnimated:andSaveAnnotation:")]
		void FinishDrawingAnimated (bool animated, bool saveAnnotation);

		[Bind ("LockPDFController")]
		void LockPDFController ();

		[Bind ("unlockPDFControllerAndEnsureToStayOnTop:")]
		void UnlockPDFControllerAndEnsureToStayOnTop (bool stayOnTop);

		// Constants

		[Field ("kPSPDFLastUsedDrawingWidth", "__Internal")]
		NSString PSPDFLastUsedDrawingWidth { get; }

		[Field ("kPSPDFLastUsedColorForAnnotationType", "__Internal")]
		NSString PSPDFLastUsedColorForAnnotationType { get; }
	}
	
	//////////////////////////////////////
	////		PSPDFCache.h			//
	//////////////////////////////////////

	delegate void PSPDFCacheDecryptFromPathHandler (PSPDFDocument document, string path);

	delegate void PSPDFCacheEncryptDataHandler (PSPDFDocument document, NSMutableData data);

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
		PSPDFCache SharedCache { get; }
		
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

		[Export("renderAndCacheImageForDocument:page:size:error:")]
		UIImage RenderAndCacheImageForDocument (PSPDFDocument document, uint page, PSPDFSize size, out NSError error);

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
		
		[Export("removeCacheForDocument:deleteDocument:error:")]
		bool RemoveCacheForDocument (PSPDFDocument document, bool deleteDocument, out NSError error);
		
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

		[Export("currentDiskUsage")]
		UInt64 CurrentDiskUsage { get; }

		[Export ("setDecryptFromPathBlock:")]
		void SetDecryptFromPathHandler (PSPDFCacheDecryptFromPathHandler handler);

		[Export ("setEncryptDataBlock:")]
		void SetEncryptDataHandler (PSPDFCacheEncryptDataHandler handler);

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
		[Export ("outlineController:didTapAtElement:"), DelegateName ("PSPDFOutlineViewControllerDidTapAtElement"), DefaultValue (true)] [Abstract]
		bool DidTapAtElement (PSPDFOutlineViewController outlineController, PSPDFOutlineElement outlineElement);
	}
	
	[BaseType (typeof (UITableViewController),
	Delegates=new string [] {"WeakDelegate"},
	Events=new Type [] { typeof (PSPDFOutlineViewControllerDelegate) })]
	interface PSPDFOutlineViewController
	{
		[Export("initWithDocument:delegate:")]
		IntPtr Constructor (PSPDFDocument document, PSPDFOutlineViewControllerDelegate Delegate);
		
		[Export("allowCopy", ArgumentSemantic.Assign)]
		bool AllowCopy { get; set; }
		
		[Export("maximumNumberOfLines", ArgumentSemantic.Assign)]
		uint MaximumNumberOfLines { get; set; }

		[Export("outlineIntentLeftOffset", ArgumentSemantic.Assign)]
		float OutlineIntentLeftOffset { get; set; }

		[Export("outlineIndentMultiplicator", ArgumentSemantic.Assign)]
		float OutlineIndentMultiplicator { get; set; }

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
		[Static][Export("heightForCellWithOutlineElement:constrainedToSize:outlineIntentLeftOffset:outlineIntentMultiplicator:")]
		float HeightForCellWithOutlineElement (PSPDFOutlineElement outlineElement, SizeF constraintSize, float leftOffset, float multiplicator);
		
		[Wrap ("WeakDelegate")]
		PSPDFOutlineCellDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }
		
		[Export("outlineElement")]
		PSPDFOutlineElement OutlineElement { get; set; }
		
		//Extensions
		
		[Export ("disclosureButton")]
		UIButton DisclosureButton { get; set; }

		[Bind ("fontForOutlineElement:")] [Static]
		UIFont FontForOutlineElement (PSPDFOutlineElement outlineElement);
		
		[Bind ("updateOutlineButton")]
		void UpdateOutlineButton ();
		
		[Bind ("expandOrCollapse")]
		void ExpandOrCollapse ();

		[Export ("outlineIntentLeftOffset", ArgumentSemantic.Assign)]
		float OutlineIntentLeftOffset { get; set; }

		[Export ("outlineIndentMultiplicator", ArgumentSemantic.Assign)]
		float OutlineIndentMultiplicator { get; set; }
	}
	
	//////////////////////////////////////////////////////
	////		PSTCollectionViewFlowLayout.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (PSTCollectionViewDelegate))]
	[Model]
	interface PSTCollectionViewDelegateFlowLayout 
	{		
		[Export ("collectionView:layout:sizeForItemAtIndexPath:")]
		SizeF SizeForItemAtIndexPath (PSTCollectionView collectionView, PSTCollectionViewLayout collectionViewLayout, NSIndexPath indexPath);
		
		[Export ("collectionView:layout:insetForSectionAtIndex:")]
		UIEdgeInsets InsetForSectionAtIndex (PSTCollectionView collectionView, PSTCollectionViewLayout collectionViewLayout, int section);
		
		[Export ("collectionView:layout:minimumLineSpacingForSectionAtIndex:")]
		float MinimumLineSpacingForSectionAtIndex (PSTCollectionView collectionView, PSTCollectionViewLayout collectionViewLayout, int section);
		
		[Export ("collectionView:layout:minimumInteritemSpacingForSectionAtIndex:")]
		float MinimumInteritemSpacingForSectionAtIndex (PSTCollectionView collectionView, PSTCollectionViewLayout collectionViewLayout, int section);
		
		[Export ("collectionView:layout:referenceSizeForHeaderInSection:")]
		SizeF ReferenceSizeForHeaderInSection (PSTCollectionView collectionView, PSTCollectionViewLayout collectionViewLayout, int section);
		
		[Export ("collectionView:layout:referenceSizeForFooterInSection:")]
		SizeF ReferenceSizeForFooterInSection (PSTCollectionView collectionView, PSTCollectionViewLayout collectionViewLayout, int section);
		
	}
	
	[BaseType (typeof (PSTCollectionViewLayout))]
	interface PSTCollectionViewFlowLayout
	{
		[Field ("PSTCollectionElementKindSectionHeader", "__Internal")]
		NSString PSTCollectionElementKindSectionHeader { get; }
		
		[Field ("PSTCollectionElementKindSectionFooter", "__Internal")]
		NSString PSTCollectionElementKindSectionFooter { get; }
		
		[Export ("minimumLineSpacing")]
		float MinimumLineSpacing { get; set; }
		
		[Export ("minimumInteritemSpacing")]
		float MinimumInteritemSpacing { get; set; }
		
		[Export ("itemSize")]
		SizeF ItemSize { get; set; }
		
		[Export ("scrollDirection")]
		PSTCollectionViewScrollDirection ScrollDirection { get; set; }
		
		[Export ("headerReferenceSize")]
		SizeF HeaderReferenceSize { get; set; }
		
		[Export ("footerReferenceSize")]
		SizeF FooterReferenceSize { get; set; }
		
		[Export ("sectionInset")]
		UIEdgeInsets SectionInset { get; set; }
		
		[Export ("rowAlignmentOptions")]
		NSDictionary RowAlignmentOptions { get; set; }
		
		// Extensions Private API
		
		[Field ("PSTFlowLayoutCommonRowHorizontalAlignmentKey", "__Internal")]
		NSString PSTFlowLayoutCommonRowHorizontalAlignmentKey { get; }
		
		[Field ("PSTFlowLayoutLastRowHorizontalAlignmentKey", "__Internal")]
		NSString PSTFlowLayoutLastRowHorizontalAlignmentKey { get; }
		
		[Field ("PSTFlowLayoutRowVerticalAlignmentKey", "__Internal")]
		NSString PSTFlowLayoutRowVerticalAlignmentKey { get; }

	}
	
	//////////////////////////////////////////////////////
	////		PSPDFThumbnailGridViewCell.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (PSTCollectionViewCell))]
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

		[Export ("updateToolbarForced")]
		void UpdateToolbarForced ();
		
		[Export ("updatePageMarker")]
		void UpdatePageMarker ();
		
		[Export ("page", ArgumentSemantic.Assign)]
		uint Page { get; set; }
		
		[Export ("toolbar")]
		UIToolbar Toolbar { get; set; }

		[Export ("leftBorderMargin", ArgumentSemantic.Assign)]
		float LeftBorderMargin { get; set; }

		[Export ("rightBorderMargin", ArgumentSemantic.Assign)]
		float RightBorderMargin { get; set; }
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

		[Export ("selectionBackgroundColor")]
		UIColor SelectionBackgroundColor { get; set; }
	}
	
	//////////////////////////////////////////////////
	////		PSPDFSearchViewController.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (UITableViewController))]
	interface PSPDFSearchViewController : UISearchDisplayDelegateProtocol, UISearchBarDelegateProtocol, PSPDFCacheDelegate, PSPDFTextSearchDelegate, PSPDFStatusBarStyleHint
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

		[Export ("maximumNumberOfSearchResultsDisplayed", ArgumentSemantic.Assign)]
		uint MaximumNumberOfSearchResultsDisplayed { get; set; }

		[Export ("searchVisiblePagesFirst", ArgumentSemantic.Assign)]
		bool SearchVisiblePagesFirst { get; set; }

		[Export ("textSearch")]
		PSPDFTextSearch TextSearch { get; }

		[Export ("pdfController")]
		PSPDFViewController PdfController { get; }
		
		[Export ("updateResultCell:searchResult:")]
		void UpdateResultCell (UITableViewCell cell, PSPDFSearchResult searchResult);

		// Extensions

		[Bind ("filterContentForSearchText:scope:")]
		void FilterContentForSearchText (string searchText, string scope);

		[Bind ("setSearchStatus:updateTable:")]
		void SetSearchStatus (PSPDFSearchStatus searchStatus, bool updateTable);

		[Bind ("searchResultsForIndexPath:")]
		PSPDFSearchResult SearchResultsForIndexPath (NSIndexPath indexPath);
	}
	
	//////////////////////////////////////////
	////		PSPDFActionSheet.h			//
	//////////////////////////////////////////
	
	delegate void PSPDFActionSheetCancelButtonWithTitleBlock ();

	delegate void PSPDFActionSheetCancelButtonWithTitleExtendedBlock (PSPDFActionSheet sheet, int buttonIndex);
	
	delegate void PSPDFActionSheetDestructiveButtonWithTitleBlock ();

	delegate void PSPDFActionSheetDestructiveButtonWithTitleExtendedBlock (PSPDFActionSheet sheet, int buttonIndex);
	
	delegate void PSPDFActionSheetAddButtonWithTitleBlock ();

	delegate void PSPDFActionSheetAddButtonWithTitleExtendedBlock (PSPDFActionSheet sheet, int buttonIndex);
	
	delegate void PSPDFActionSheetSetDestroyBlock (PSPDFActionSheet sheet, int buttonIndex);
	
	[BaseType (typeof (UIActionSheet))]
	interface PSPDFActionSheet 
	{
		// Use this ActionSheet only if needed. But UIActionSheet should suffice due to it already has events
		// PSPDFActionSheet is only a Helper to add block features to UIActionSheet. (Same to events in C# that UIActionSheet has)
		
		[Export ("initWithTitle:")]
		IntPtr Constructor (string title);
		
		[Export ("setCancelButtonWithTitle:block:")]
		void SetCancelButtonWithTitle (string title, PSPDFActionSheetCancelButtonWithTitleBlock block);

		[Export ("setCancelButtonWithTitle:extendedBlock:")]
		void SetCancelButtonWithTitle (string title, PSPDFActionSheetCancelButtonWithTitleExtendedBlock block);

		[Export ("setDestructiveButtonWithTitle:block:")]
		void SetDestructiveButtonWithTitle (string title, PSPDFActionSheetDestructiveButtonWithTitleBlock block);

		[Export ("setDestructiveButtonWithTitle:extendedBlock:")]
		void SetDestructiveButtonWithTitle (string title, PSPDFActionSheetDestructiveButtonWithTitleExtendedBlock block);
		
		[Export ("addButtonWithTitle:block:")]
		void AddButtonWithTitle (string title, PSPDFActionSheetAddButtonWithTitleBlock block);

		[Export ("addButtonWithTitle:extendedBlock:")]
		void AddButtonWithTitle (string title, PSPDFActionSheetAddButtonWithTitleExtendedBlock block);

		[Export ("buttonCount")][New]
		uint ButtonCount { get; }

		[Export ("showWithSender:fallbackView:animated:")]
		void ShowWithSender ([NullAllowed] NSObject sender, UIView view, bool animated);
		
		[Export ("destroy")]
		void Destroy ();
		
		[Export ("setDestroyBlock:")]
		void SetDestroyBlock (PSPDFActionSheetSetDestroyBlock block);
	}
	
	//////////////////////////////////////////
	////		PSPDFAlertView.h			//
	//////////////////////////////////////////
	
	delegate void PSPDFAlertViewCancelButtonWithTitleBlock ();

	delegate void PSPDFAlertViewCancelButtonWithTitleExtendedBlock (PSPDFAlertView alert, int buttonIndex);
	
	delegate void PSPDFAlertViewAddButtonWithTitleBlock ();

	delegate void PSPDFAlertViewAddButtonWithTitleExtendedBlock (PSPDFAlertView alert, int buttonIndex);
	
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

		[Export ("setCancelButtonWithTitle:extendedBlock:")]
		void SetCancelButtonWithTitle (string title, PSPDFAlertViewCancelButtonWithTitleExtendedBlock block);
		
		[Export ("addButtonWithTitle:block:")]
		void AddButtonWithTitle (string title, PSPDFAlertViewAddButtonWithTitleBlock block);

		[Export ("addButtonWithTitle:extendedBlock:")]
		void AddButtonWithTitle (string title, PSPDFAlertViewAddButtonWithTitleExtendedBlock block);

		[Export ("tintColor")]
		UIColor TintColor { get; [NullAllowed] set; }

		[Export ("showWithTintColor:")]
		void Show (UIColor tintColor);
	}
	
	//////////////////////////////////////////
	////		PSPDFPasswordView.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFPasswordViewDelegate 
	{		
		[Export ("passwordView:didUnlockWithPassword:"), EventArgs ("PSPDFPasswordViewEvent")][Abstract]
		void DidUnlockWithPassword (PSPDFPasswordView passwordView, string password);
		
		[Export ("passwordView:didFailToUnlockWithPassword:"), EventArgs ("PSPDFPasswordViewEvent")]
		void DidFailToUnlockWithPassword (PSPDFPasswordView passwordView, string password);
		
		[Export ("passwordView:shouldlUnlockWithPassword:"), DelegateName("PSPDFPasswordViewDel"), DefaultValue(true)]
		bool ShouldlUnlockWithPassword (PSPDFPasswordView passwordView, string password);
		
		[Export ("passwordView:willUnlockWithPassword:"), EventArgs ("PSPDFPasswordViewEvent")]
		void WillUnlockWithPassword (PSPDFPasswordView passwordView, string password);
	}
	
	[BaseType (typeof (UIView),
	Delegates=new string [] {"WeakDelegate"},
	Events=new Type [] { typeof (PSPDFPasswordViewDelegate) })] 
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

		//SubclassingHooks

		[Export ("passwordField")]
		UITextField PasswordField { get; }
	}
	
	//////////////////////////////////////////
	////		PSPDFPageRenderer.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
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

		[Field ("kPSPDFDisablePageRendering", "__Internal")]
		NSString PSPDFDisablePageRendering { get; }

		[Field ("kPSPDFRenderOverlayAnnotations", "__Internal")]
		NSString PSPDFRenderOverlayAnnotations { get; }

		[Field ("kPSPDFIgnorePageClip", "__Internal")]
		NSString PSPDFIgnorePageClip { get; }

		[Field ("kPSPDFAllowAntiAliasing", "__Internal")]
		NSString PSPDFAllowAntiAliasing { get; }

		[Field ("kPSPDFBackgroundFillColor", "__Internal")]
		NSString PSPDFBackgroundFillColor { get; }

		[Field ("kPSPDFPDFBox", "__Internal")]
		NSString PSPDFPDFBox { get; }

		[Export ("setupGraphicsContext:inRectangle:pageInfo:")][Static][Internal]
		void SetupGraphicsContext_ (IntPtr /*CGContextRef*/ context, RectangleF displayRectangle, PSPDFPageInfo pageInfo);

		[Export ("renderPageRef:inContext:inRectangle:pageInfo:withAnnotations:options:")][Static][Internal]
		RectangleF RenderPage_ (IntPtr /*CGPDFPageRef*/ page, IntPtr /*CGContextRef*/ context, RectangleF rectangle, PSPDFPageInfo pageInfo, PSPDFAnnotation [] annotations, NSDictionary options);
		
		[Export ("renderPage:inContext:atPoint:withZoom:pageInfo:withAnnotations:options:")][Static][Internal]
		SizeF RenderPage_ (IntPtr /*CGPDFPageRef*/ page, IntPtr /*CGContextRef*/ context, PointF point, float zoom, PSPDFPageInfo pageInfo, PSPDFAnnotation [] annotations, NSDictionary options);
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
		NSNumber [] VisiblePageNumbers ();
		
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
	[Model]
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
		PSPDFContentScrollView ScrollView { get; set; }
		
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

		[Bind ("layoutPage")]
		void LayoutPage ();
	}

	[BaseType (typeof (UIView))] 
	interface PSPDFSinglePageView 
	{
	}
	
	//////////////////////////////////////////////////
	////		PSPDFTabbedViewController.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFTabbedViewControllerDelegate 
	{		
		[Export ("tabbedPDFController:shouldChangeDocuments:"), DelegateName ("PSPDFTabbedViewControllerDocuments"), DefaultValue (true)]
		bool ShouldChangeDocuments (PSPDFTabbedViewController tabbedPDFController, PSPDFDocument [] newDocuments);
		
		[Export ("tabbedPDFController:didChangeDocuments:"), EventArgs("PSPDFTabbedViewControllerDocs")]
		void DidChangeDocuments (PSPDFTabbedViewController tabbedPDFController, PSPDFDocument [] oldDocuments);
		
		[Export ("tabbedPDFController:shouldChangeVisibleDocument:"), DelegateName ("PSPDFTabbedViewControllerDocument"), DefaultValue (true)]
		bool ShouldChangeVisibleDocument (PSPDFTabbedViewController tabbedPDFController, PSPDFDocument newDocument);
		
		[Export ("tabbedPDFController:didChangeVisibleDocument:"), EventArgs("PSPDFTabbedViewControllerDoc")]
		void DidChangeVisibleDocument (PSPDFTabbedViewController tabbedPDFController, PSPDFDocument oldDocument);

		[Export ("tabbedPDFController:shouldCloseDocument:"), DelegateName ("PSPDFTabbedViewControllerDocument"), DefaultValue (true)]
		bool ShouldCloseDocument (PSPDFTabbedViewController tabbedPDFController, PSPDFDocument closedDocument);

		[Export ("tabbedPDFController:didCloseDocument:"), EventArgs("PSPDFTabbedViewControllerDoc")]
		void DidCloseDocument (PSPDFTabbedViewController tabbedPDFController, PSPDFDocument closedDocument);
	}
	
	
	[BaseType (typeof (PSPDFBaseViewController),
	Delegates= new string [] {"WeakDelegate"},
	Events=new Type [] { typeof (PSPDFTabbedViewControllerDelegate) })] 
	interface PSPDFTabbedViewController 
	{
		[Export ("initWithPDFViewController:")]
		IntPtr Constructor ( [NullAllowed] PSPDFViewController pdfController);
		
		[Export ("visibleDocument")]
		PSPDFDocument VisibleDocument { get; set; }
		
		[Export ("documents", ArgumentSemantic.Copy)]
		PSPDFDocument [] Documents { get; set; }
		
		[Export ("addDocuments:atIndex:animated:")] [PostGet ("Documents")]
		void AddDocuments (PSPDFDocument [] documents, uint index, bool animated);
		
		[Export ("removeDocuments:animated:")] [PostGet ("Documents")]
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
		
		[Export ("restoreStateAndMergeWithDocuments:")] [PostGet ("Documents")]
		bool RestoreStateAndMergeWithDocuments (PSPDFDocument [] documents);
		
		[Export ("statePersistanceKey", ArgumentSemantic.Copy)]
		string StatePersistanceKey { get; set; }
		
		[Export ("minTabWidth", ArgumentSemantic.Assign)]
		float MinTabWidth { get; set; }
		
		[Export ("pdfController")]
		PSPDFViewController PdfController { get; }
		
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
		PSPDFTabBarViewDataSource DataSource { get; set; }
		
		[Export ("dataSource", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDataSource { get; set; }

		// Extensions

		[Export ("selectTabAtIndex:animated:callDelegate:")]
		void SelectTabAtIndex (uint index, bool animated, bool callDelegate);

		[Export ("scrollView")]
		UIScrollView ScrollView { get; }
	}

	//////////////////////////////////////////////////////
	////		PSPDFAESCryptoDataProvider.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFAESCryptoDataProvider 
	{
		[Export ("initWithURL:passphrase:salt:")]
		IntPtr Constructor (NSUrl url, string passphrase, string salt);

		[Export ("dataProviderRef")] [Internal]
		IntPtr DataProviderRef_ ();

		[Export ("isAESCryptoDataProvider:")] [Internal] [Static]
		bool IsAESCryptoDataProvider_ (IntPtr dataProviderRef);

		[Export ("isAESCryptoFeatureAvailable")]
		[Static]
		bool IsAESCryptoFeatureAvailable { [Bind("isAESCryptoFeatureAvailable")] get; }
	}

	//////////////////////////////////////////////////
	////		PSPDFTransparentToolbar.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (UIToolbar))]
	interface PSPDFTransparentToolbar 
	{
		
	}
	
	//////////////////////////////////////////////////
	////		PSPDFFreeTextAnnotation.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFAnnotation))]
	interface PSPDFFreeTextAnnotation 
	{
		[Export ("fontName", ArgumentSemantic.Copy)]
		string FontName { get; [NullAllowed]set; }

		[Export ("fontSize", ArgumentSemantic.Assign)]
		float FontSize { get; set; }
	}
	
	//////////////////////////////////////
	////		PSPDFHUDView.h			//
	//////////////////////////////////////
	
	[BaseType (typeof (UIView))]
	interface PSPDFHUDView 
	{
		
	}

	// New stuff Below

	//////////////////////////////////////////////////////
	////		PSPDFBrightnessViewController.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFBaseViewController))]
	interface PSPDFBrightnessViewController 
	{
		[Export ("wantsSoftwareDimming", ArgumentSemantic.Assign)]
		bool WantsSoftwareDimming { get; set; }

		[Export ("wantsAdditionalSoftwareDimming", ArgumentSemantic.Assign)]
		bool WantsAdditionalSoftwareDimming { get; set; }

		[Export ("additionalBrightnessDimmingFactor", ArgumentSemantic.Assign)]
		float AdditionalBrightnessDimmingFactor { get; set; }

		//Extensions

		[Export ("slider")]
		UISlider Slider { get; set; }

		[Export ("gradient")]
		PSPDFGradientView Gradient { get; set; }

		[Export ("dimmingView")]
		PSPDFDimmingView DimmingView { get; }

		[Bind ("addDimmingView")] [PostGet("DimmingView")]
		PSPDFDimmingView AddDimmingView ();

		[Bind ("removeDimmingView")] [PostGet("DimmingView")]
		void RemoveDimmingView ();
	}

	[BaseType (typeof (UIView))]
	interface PSPDFDimmingView 
	{		
		[Export ("additionalBrightnessDimmingFactor", ArgumentSemantic.Assign)]
		float AdditionalBrightnessDimmingFactor { get; set; }
	}

	//////////////////////////////////////////////////////////
	////		PSPDFLongPressGestureRecognizer.h			//
	//////////////////////////////////////////////////////////

	[BaseType (typeof (UILongPressGestureRecognizer))]
	interface PSPDFLongPressGestureRecognizer 
	{

	}

	[BaseType (typeof (UIGestureRecognizerDelegate))]
	[Model]
	interface PSPDFLongPressGestureRecognizerDelegate 
	{		
		[Export ("pressRecognizerShouldHandlePressImmediately:")][Abstract]
		bool PressRecognizerShouldHandlePressImmediately (PSPDFLongPressGestureRecognizer recognizer);
	}

	//////////////////////////////////////////////////////////
	////		PSPDFColorSelectionViewController.h			//
	//////////////////////////////////////////////////////////

	[BaseType (typeof (UIViewController),
	Delegates= new string [] {"WeakDelegate"},
	Events=new Type [] { typeof (PSPDFColorSelectionViewControllerDelegate) })]
	interface PSPDFColorSelectionViewController 
	{
		[Export ("defaultColorPickerWithTitle:delegate:")] [Static]
		PSPDFSimplePageViewController DefaultColorPickerWithTitle (string title, PSPDFColorSelectionViewControllerDelegate Delegate);

		[Export ("setDefaultColorPickerStyles:")] [Static]
		void SetDefaultColorPickerStyles (NSNumber [] colorPickerStyles);

		[Export ("monoChromeSelectionViewController")] [Static]
		PSPDFColorSelectionViewController MonoChromeSelectionViewController ();

		[Export ("modernColorsSelectionViewController")] [Static]
		PSPDFColorSelectionViewController ModernColorsSelectionViewController ();

		[Export ("vintageColorsSelectionViewController")] [Static]
		PSPDFColorSelectionViewController VintageColorsSelectionViewController ();

		[Export ("rainbowSelectionViewController")] [Static]
		PSPDFColorSelectionViewController RainbowSelectionViewController ();

		[Export ("colorSelectionViewControllerFromColors:addDarkenedVariants:")] [Static]
		PSPDFColorSelectionViewController ColorSelectionViewControllerFromColors (UIColor [] colorsArray, bool darkenedVariants);

		[Export ("colorsFromPalletURL:addDarkenedVariants:")] [Static]
		UIColor [] ColorSelectionViewControllerFromColors (NSUrl palletURL, bool darkenedVariants);

		[Export ("setDefaultColorArrays:")] [Static]
		void SetDefaultColorArrays ([NullAllowed] UIColor [] defaultColorArrays);

		[Export ("initWithColors:")]
		IntPtr Constructor(UIColor [] colors);

		[Export ("colors", ArgumentSemantic.Copy)]
		UIColor [] Colors { get; }

		[Wrap ("WeakDelegate")]
		PSPDFColorSelectionViewControllerDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }
	}

	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFColorSelectionViewControllerDelegate 
	{		
		[Export ("colorSelectionControllerSelectedColor:"), DelegateName ("PSPDFColorSelectionViewControllerColor"), DefaultValue (null) ][Abstract]
		UIColor ColorSelectionControllerSelectedColor (UIViewController controller);
		
		[Export ("colorSelectionController:didSelectedColor:"), EventArgs("PSPDFColorSelectionViewControllerDidSelectedColor")][Abstract]
		void DidSelectedColor (UIViewController controller, UIColor color);
	}

	//////////////////////////////////////////
	////		PSPDFColorView.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (UIControl))]
	interface PSPDFColorView 
	{
		[Export ("colorViewWithColor:borderStyle:")] [Static]
		PSPDFColorView ColorViewWithColor (UIColor color, PSPDFColorViewBorderStyle borderStyle);

		[Export ("color")]
		UIColor Color { get; set; }

		[Export ("borderStyle")]
		PSPDFColorViewBorderStyle BorderStyle { get; set; }

		[Export ("setSelected:animated:")]
		void SetSelected (bool selected, bool animated);
	}

	//////////////////////////////////////////////////
	////		PSPDFContentScrollView.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFScrollView))]
	interface PSPDFContentScrollView 
	{
		[Export ("initWithTransitionViewController:")]
		IntPtr Constructor (PSPDFTransitionProtocol viewController);
		
		[Export ("contentController")]
		PSPDFTransitionProtocol ContentController { get; }
	}

	//////////////////////////////////////////////////////////////
	////		PSPDFContinuousScrollViewController.h			//
	//////////////////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFBaseViewController))]
	interface PSPDFContinuousScrollViewController : PSPDFTransitionProtocol, UIScrollViewDelegateProtocol
	{
		[Export ("initWithPDFController:")]
		IntPtr Constructor (PSPDFViewController pdfController);
		
//		[Export ("pdfController")] [New]
//		PSPDFViewController PdfController { get; set; }

//		[Export ("scrollView")] [New]
//		PSPDFContentScrollView ScrollView { get; set; }

		[Export ("pagePadding", ArgumentSemantic.Assign)]
		float PagePadding { get; set; }

		[Export ("compensatedContentOffset")]
		PointF CompensatedContentOffset { get; }
	}

	//////////////////////////////////////////
	////		PSPDFGradientView.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (UIView))]
	interface PSPDFGradientView
	{
		[Export ("direction", ArgumentSemantic.Assign)]
		PSPDFGradientViewDirection Direction { get; set; }
		
		[Export ("colors", ArgumentSemantic.Copy)]
		UIColor [] Colors { get; set; }
		
		[Export ("locations", ArgumentSemantic.Copy)] [NullAllowed]
		NSNumber [] Locations { get; set; }
	}

	//////////////////////////////////////////////////
	////		PSPDFOrderedDictionary.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (NSMutableDictionary))]
	interface PSPDFOrderedDictionary
	{
		[Export ("keyArray")]
		NSMutableArray KeyArray { get; }
		
		[Export ("insertObject:forKey:atIndex:")] [PostGet("KeyArray")]
		void InsertObject (NSObject anObject, NSObject aKey, uint anIndex);

		[Export ("keyAtIndex:")]
		NSObject KeyAtIndex (uint anIndex);
		
		[Export ("reverseKeyEnumerator")]
		NSEnumerator ReverseKeyEnumerator { get; }
	}

	//////////////////////////////////////////////////////
	////		PSPDFPageScrollViewController.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFBaseViewController))]
	interface PSPDFPageScrollViewController : PSPDFTransitionProtocol, UIScrollViewDelegateProtocol
	{
		[Export ("initWithPDFController:")]
		IntPtr Constructor (PSPDFViewController pdfController);

//		[Export ("pdfController")] [New]
//		PSPDFViewController PdfController { get; set; }

		[Export ("pagingScrollView")]
		UIScrollView PagingScrollView { get; }

		[Export ("pagePadding", ArgumentSemantic.Assign)]
		float PagePadding { get; set; }

//		[Export ("visiblePageNumbers")] [New]
//		PSPDFPageView [] VisiblePageNumbers { get; }

//		[Export ("pageViewForPage:")] [New]
//		PSPDFPageView PageViewForPage (uint page);

//		[Export ("setPage:animated:")] [New]
//		void SetPage (uint page, bool animated);

		[Export ("reloadData")]
		void ReloadData ();

		// Extensions

		[Export ("targetPageAfterRotation", ArgumentSemantic.Assign)]
		uint TargetPageAfterRotation { get; set; }
	}

	[BaseType (typeof (UIScrollView))]
	interface PSPDFPagingScrollView
	{
	}

	//////////////////////////////////////////////////////
	////		PSPDFPopoverBackgroundView.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (UIPopoverBackgroundView))]
	interface PSPDFPopoverBackgroundView
	{
		[Export ("arrowOffset", ArgumentSemantic.Assign)]
		float ArrowOffset { get; set; }

		[Export ("arrowDirection", ArgumentSemantic.Assign)]
		UIPopoverArrowDirection ArrowDirection { get; set; }

		[Export ("setContentInset:")] [Static]
		void SetContentInset (float contentInset);

		[Export ("setTintColor:")] [Static]
		void SetTintColor ([NullAllowed] UIColor tintColor);

		[Export ("setShadowEnabled:")] [Static]
		void SetShadowEnabled (bool shadowEnabled);

		[Export ("setArrowBase:")] [Static]
		void SetArrowBase (float arrowBase);

		[Export ("setArrowHeight:")] [Static]
		void SetArrowHeight (float arrowHeight);

		[Export ("setBackgroundImage:top:right:bottom:left:")] [Static]
		void SetBackgroundImage (UIImage background, UIImage top, UIImage right, UIImage bottom, UIImage left);

		[Export ("rebuildArrowImages")] [Static]
		void RebuildArrowImages ();
	}

	//////////////////////////////////////////
	////		PSPDFProcessor.h			//
	//////////////////////////////////////////

	delegate void PSPDFProcessorCompletionBlockWithError (NSUrl fileUrl, NSError error);

	[BaseType (typeof (NSObject))]
	interface PSPDFProcessor
	{
		[Field ("kPSPDFProcessorAnnotationTypes", "__Internal")]
		NSString PSPDFProcessorAnnotationTypes { get; }

		[Field ("kPSPDFProcessorAnnotationDict", "__Internal")]
		NSString PSPDFProcessorAnnotationDict { get; }

		[Field ("kPSPDFProcessorPageRect", "__Internal")]
		NSString PSPDFProcessorPageRect { get; }

		[Field ("kPSPDFProcessorNumberOfPages", "__Internal")]
		NSString PSPDFProcessorNumberOfPages { get; }

		[Field ("kPSPDFProcessorPageBorderMargin", "__Internal")]
		NSString PSPDFProcessorPageBorderMargin { get; }

		[Field ("kPSPDFProcessorAdditionalDelay", "__Internal")]
		NSString PSPDFProcessorAdditionalDelay { get; }

		[Field ("kPSPDFProcessorDocumentTitle", "__Internal")]
		NSString PSPDFProcessorDocumentTitle { get; }

		[Export ("defaultProcessor")] [Static]
		PSPDFProcessor DefaultProcessor { get; }

		[Export ("generatePDFFromDocument:pageRange:outputFileURL:options:")]
		bool GeneratePDFFromDocumentToFile (PSPDFDocument document, NSIndexSet pageRange, NSUrl fileUrl, NSDictionary options);

		[Export ("generatePDFFromDocument:pageRange:options:")]
		NSData GeneratePDFFromDocumentToNSData (PSPDFDocument document, NSIndexSet pageRange, NSDictionary options);

		[Export ("generatePDFFromHTMLString:outputFileURL:options:")]
		bool GeneratePDFFromHTMLString (string html, NSUrl outputFileURL, NSDictionary options);

		[Export ("generatePDFFromURL:outputFileURL:options:completionBlock:")] [PostGet ("ConversionOperationQueue")]
		PSPDFConversionOperation GeneratePDFFromURL (NSUrl inputURL, NSUrl outputURL, NSDictionary options, PSPDFProcessorCompletionBlockWithError completionBlock);

		[Static] [Export ("conversionOperationQueue")]
		NSOperationQueue ConversionOperationQueue { get; }
	}

	[BaseType (typeof (NSOperation))]
	interface PSPDFConversionOperation
	{
		[Export ("initWithURL:outputFileURL:options:completionBlock:")]
		IntPtr Constructor (NSUrl inputURL, NSUrl outputFileURL, NSDictionary options, PSPDFProcessorCompletionBlockWithError completionBlock);

		[Export ("inputURL")]
		NSUrl InputURL { get; }

		[Export ("outputFileURL")]
		NSUrl OutputFileURL { get; }

		[Export ("options", ArgumentSemantic.Copy)]
		NSDictionary Options { get; }

		[Export ("error")]
		NSError Error { get; }
	}

	//////////////////////////////////////////
	////		PSPDFProgressHUD.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (UIView))]
	interface PSPDFProgressHUD
	{
		[Export ("show")] [Static]
		void Show ();

		[Export ("showWithMaskType:")] [Static]
		void Show (PSPDFProgressHUDMaskType maskType);

		[Export ("showWithStatus:")] [Static]
		void Show (string status);

		[Export ("showWithStatus:maskType:")] [Static]
		void Show (string status, PSPDFProgressHUDMaskType maskType);

		[Export ("showProgress:")] [Static]
		void ShowProgress (float progress);

		[Export ("showProgress:status:")] [Static]
		void ShowProgress (float progress, string status);

		[Export ("showProgress:status:maskType:")] [Static]
		void ShowProgress (float progress, string status, PSPDFProgressHUDMaskType maskType);

		[Export ("setStatus:")] [Static]
		void SetStatus (string status);

		[Export ("showSuccessWithStatus:")] [Static]
		void ShowSuccessWithStatus (string status);

		[Export ("showErrorWithStatus:")] [Static]
		void ShowErrorWithStatus (string status);

		[Export ("showImage:status:")] [Static]
		void ShowImage (UIImage image, string status);

		[Export ("dismiss")] [Static]
		void Dismiss ();

		[Export ("isVisible")] [Static]
		bool IsVisible { get; }
	}

	//////////////////////////////////////////////////////
	////		PSPDFSimplePageViewController.h			//
	//////////////////////////////////////////////////////

	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFSimplePageViewControllerDelegate 
	{
		[Export ("shouldDelayContentTouches")]
		bool ShouldDelayContentTouches ();
	}

	[BaseType (typeof (UIViewController))]
	interface PSPDFSimplePageViewController
	{		
		[Export ("initWithViewControllers:")]
		IntPtr Constructor (NSObject [] viewControllers);

		[Export ("page", ArgumentSemantic.Assign)]
		uint Page { get; set; }

		[Export ("setPage:animated:")]
		void ChangePage (uint page, bool animated);

		// SubclassingHooks

		[Export ("scrollView")]
		UIScrollView ScrollView { get; }

		[Export ("pageControl")]
		UIPageControl PageControl { get; }
	}

	//////////////////////////////////////////
	////		PSPDFStyleable.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFStyleable 
	{		
		[Export ("tintColor")]
		UIColor TintColor { get; [NullAllowed ]set; }

		[Export ("barStyle", ArgumentSemantic.Assign)]
		UIBarStyle BarStyle { get; set; }

		[Export ("isBarTranslucent", ArgumentSemantic.Assign)]
		bool IsBarTranslucent { get; set; }

		[Export ("isInPopover", ArgumentSemantic.Assign)]
		bool IsInPopover { get; set; }

		[Export ("shouldTintToolbarButtons", ArgumentSemantic.Assign)]
		bool ShouldTintToolbarButtons { get; set; }

		[Export ("shouldTintAlertView", ArgumentSemantic.Assign)]
		bool ShouldTintAlertView { get; set; }
	}

	//////////////////////////////////////////////////////
	////		PSTCollectionViewController.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (UIViewController))]
	interface PSTCollectionViewController : PSTCollectionViewDelegate, PSTCollectionViewDataSource
	{		
		[Export ("initWithCollectionViewLayout:")]
		IntPtr Constructor (PSTCollectionViewLayout layout);
		
		[Export ("collectionView")]
		PSTCollectionView CollectionView { get; set; }

		[Export ("clearsSelectionOnViewWillAppear", ArgumentSemantic.Assign)]
		bool ClearsSelectionOnViewWillAppear { get; set; }
	}
	
	//////////////////////////////////////////////////////
	////		PSPDFYouTubeAnnotationView.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFLinkAnnotationBaseView))]
	interface PSPDFYouTubeAnnotationView
	{		
		[Export ("annotation")]
		PSPDFAnnotation Annotation { get; set; }

		[Export ("youTubeURL")]
		NSUrl YouTubeURL { get; }

		[Export ("error")]
		NSError Error { get; }

		[Export ("autoplayEnabled", ArgumentSemantic.Assign)]
		bool AutoplayEnabled { [Bind ("isAutoplayEnabled")] get; set; }

		[Export ("webView", ArgumentSemantic.Assign)]
		UIWebView WebView { get; set; }

		[Export ("play")]
		void Play();

		[Export ("pause")]
		void Pause();
	}

	//////////////////////////////////////////
	////		PSPDFLabelView.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (PSPDFGradientView))]
	interface PSPDFLabelView 
	{
		[Export ("label")]
		UILabel Label { get; }

		[Export ("labelMargin", ArgumentSemantic.Assign)]
		float LabelMargin { get; set; }

		[Export ("labelStyle", ArgumentSemantic.Assign)]
		PSPDFLabelStyle LabelStyle { get; set; }

		[Export ("pdfController")]
		PSPDFViewController PdfController { get; set; }

		[Export ("updateAnimated:")]
		void UpdateAnimated (bool animated);

		// SubclassingHooks

		[Bind ("kvoValues")]
		NSArray KvoValues ();
	}

	//////////////////////////////////////////////////
	////		PSPDFDocumentLabelView.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFLabelView))]
	interface PSPDFDocumentLabelView 
	{
		
	}

	//////////////////////////////////////////////////
	////		PSPDFAnnotationProvider.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFAnnotationProvider 
	{
		[Export ("annotationsForPage:")] [Abstract]
		PSPDFAnnotation [] AnnotationsForPage (uint page);

		[Export ("hasLoadedAnnotationsForPage:")] 
		bool HasLoadedAnnotationsForPage (uint page);

		[Export ("annotationViewClassForAnnotation:")] 
		Class AnnotationViewClassForAnnotation (PSPDFAnnotation annotation);

		[Export ("addAnnotations:forPage:")] 
		bool AddAnnotations (PSPDFAnnotation [] annotations, uint page);

		[Export ("saveAnnotationsWithError:")] 
		bool SaveAnnotationsWithError (out NSError error);

		[Export ("dirtyAnnotations")] 
		NSDictionary DirtyAnnotations ();

		[Export ("didChangeAnnotation:originalAnnotation:keyPaths:options:")] 
		void DidChangeAnnotation (PSPDFAnnotation annotation, PSPDFAnnotation originalAnnotation, NSArray keyPaths, NSDictionary options);

		[Wrap ("WeakProviderDelegate")]
		PSPDFAnnotationProviderChangeNotifier ProviderDelegate { get; set; }
		
		[Export ("providerDelegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakProviderDelegate { get; set; }
	}

	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFAnnotationProviderChangeNotifier 
	{
		[Export ("updateAnnotations:originalAnnotations:animated:")] [Abstract]
		void UpdateAnnotations (PSPDFAnnotation [] annotations, PSPDFAnnotation [] originalAnnotations, bool animated);

		[Export ("parentDocumentProvider")] [Abstract]
		PSPDFDocumentProvider ParentDocumentProvider ();
	}

	//////////////////////////////////////////////////////
	////		PSPDFFileAnnotationProvider.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface PSPDFFileAnnotationProvider : PSPDFAnnotationProvider
	{
		[Export ("initWithDocumentProvider:")]
		IntPtr Constructor ([NullAllowed] PSPDFDocumentProvider documentProvider);

		[Export ("documentProvider")]
		PSPDFDocumentProvider DocumentProvider
		{
			get;
			[NullAllowed] set;
		}

		[Export ("defaultAnnotationUsername", ArgumentSemantic.Copy)]
		string DefaultAnnotationUsername
		{
			get;
			[NullAllowed] set;
		}

		[Export ("annotationsForPage:pageRef:")] [Internal]
		PSPDFAnnotation [] AnnotationsForPage_ (uint page, IntPtr /*CGPDFPage*/ pageRef);

		[Export ("setAnnotations:forPage:")]
		void SetAnnotations ([NullAllowed] PSPDFAnnotation [] annotations, uint page);

//		[Export ("addAnnotations:forPage:")] // Already inlined
//		bool AddAnnotations (PSPDFAnnotation [] annotations, uint page);

		[Export ("clearCache")]
		void ClearCache ();

		[Export ("tryLoadAnnotationsFromFileWithError:")]
		bool TryLoadAnnotationsFromFileWithError (out NSError error);

		[Export ("fileTypeTranslationTable", ArgumentSemantic.Copy)]
		NSDictionary FileTypeTranslationTable { get; set; }

		[Export ("protocolString", ArgumentSemantic.Copy)]
		string ProtocolString { get; set; }

		[Export ("annotationsPath", ArgumentSemantic.Copy)]
		string AnnotationsPath { get; set; }

		// SubclassingHooks

		[Export ("parseAnnotationsForPage:pageRef:")][Internal]
		PSPDFAnnotation [] ParseAnnotationsForPage_ (uint page, IntPtr /*CGPDFPageRef*/ pageRef);

//		[Bind ("saveAnnotationsWithError:")] // Already inlined
//		bool SaveAnnotationsWithError (out NSError error);

		[Export ("loadAnnotationsWithError:")]
		NSDictionary LoadAnnotationsWithError (out NSError error);

		[Export ("parseAnnotationLinkTarget:")]
		void ParseAnnotationLinkTarget (PSPDFLinkAnnotation linkAnnotation);

		[Bind ("resolvePath:forDocument:page:")] [Static]
		NSUrl ResolvePath (string path, PSPDFDocument document, uint page);

		[Export ("videoFileTypes")]
		NSArray VideoFileTypes ();

		[Export ("removeDeletedAnnotations")]
		uint RemoveDeletedAnnotations ();

		[Export ("updateAnnotationsPageAndDocumentReference:page:")]
		void UpdateAnnotationsPageAndDocumentReference (PSPDFAnnotation [] annotations, uint page);
	}

	//////////////////////////////////////////////
	////		PSPDFResizableView.h			//
	//////////////////////////////////////////////

	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFResizableViewDelegate 
	{
		[Export ("resizableViewDidBeginEditing:"), EventArgs("PSPDFResizableViewDelegateArgs")]
		void DidBeginEditing (PSPDFResizableView resizableView);
		
		[Export ("resizableViewChangedFrame:"), EventArgs("PSPDFResizableViewDelegateArgs")]
		void ChangedFrame (PSPDFResizableView resizableView);

		[Export ("resizableViewDidEndEditing:"), EventArgs("PSPDFResizableViewDelegateArgs")]
		void DidEndEditing (PSPDFResizableView resizableView);
	} 

	[BaseType (typeof (UIView),
	Delegates= new string [] {"WeakDelegate"},
	Events=new Type [] { typeof (PSPDFResizableViewDelegate) })]
	interface PSPDFResizableView : PSPDFLongPressGestureRecognizerDelegate
	{
		[Export("initWithTrackedView:")]
		IntPtr Constructor (UIView trackedView);

		[Export ("trackedView")]
		UIView TrackedView { get; set; }

		[Export ("zoomScale", ArgumentSemantic.Assign)]
		float ZoomScale { get; set; }

		[Export ("allowEditing", ArgumentSemantic.Assign)]
		bool AllowEditing { get; set; }

		[Export ("allowResizing", ArgumentSemantic.Assign)]
		bool AllowResizing { get; set; }

		[Export ("minWidth", ArgumentSemantic.Assign)]
		float MinWidth { get; set; }

		[Export ("minHeight", ArgumentSemantic.Assign)]
		float MinHeight { get; set; }

		[Export ("preventsPositionOutsideSuperview", ArgumentSemantic.Assign)]
		bool PreventsPositionOutsideSuperview { get; set; }

		[Export ("activeKnobType", ArgumentSemantic.Assign)]
		PSPDFSelectionBorderKnobType ActiveKnobType { get; set; }

		[Export ("longPress:", ArgumentSemantic.Assign)]
		bool LongPress (UILongPressGestureRecognizer recognizer);

		[Wrap ("WeakDelegate")]
		PSPDFResizableViewDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }
	}

	//////////////////////////////////////////////////////
	////		PSPDFActivityBarButtonItem.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFBarButtonItem))]
	interface PSPDFActivityBarButtonItem 
	{
		[Export ("applicationActivities", ArgumentSemantic.Copy)]
		NSString [] ApplicationActivities { get; set; }

		[Export ("excludedActivityTypes", ArgumentSemantic.Copy)]
		NSString [] ExcludedActivityTypes { get; set; }

		[Export ("activityController")]
		UIActivityViewController ActivityController { get; }
	}

	//////////////////////////////////////////////////////
	////		PSPDFAnnotationBarButtonItem.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFBarButtonItem))]
	interface PSPDFAnnotationBarButtonItem 
	{
		[Export ("isAvailableBlocking")]
		bool IsAvailableBlocking ();

		[Export ("targetToolbarForBarButtonItem:")]
		UIToolbar TargetToolbarForBarButtonItem (UIBarButtonItem barButtonItem);

		[Export ("annotationToolbar")]
		PSPDFAnnotationToolbar AnnotationToolbar { get; }
	}

	//////////////////////////////////////////////////
	////		PSPDFAnnotationController.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFAnnotationController 
	{
		[Export ("initWithPDFController:")]
		IntPtr Constructor (PSPDFViewController pdfController);

		[Export ("prepareAnnotationViewForAnnotation:frame:pageView:")]
		PSPDFAnnotationView PrepareAnnotationViewForAnnotation (PSPDFAnnotation annotation, RectangleF annotationRect, PSPDFPageView pageView);
		
		[Export ("handleTouchUpForAnnotationIgnoredByDelegate:")]
		void HandleTouchUpForAnnotationIgnoredByDelegate (PSPDFLinkAnnotationView annotationView);

		[Export ("recycleAnnotationView:")]
		void RecycleAnnotationView (PSPDFAnnotationView annotationView);
		
		[Export ("dequeueViewFromCacheForAnnotation:class:")]
		PSPDFAnnotationView DequeueViewFromCacheForAnnotation (PSPDFAnnotation annotation, Class annotationViewClass);

		[Export ("clearCache")]
		void ClearCache ();

		[Export ("pdfController")]
		PSPDFViewController PdfController { get; set; }

		//SubclassingHooks

		[Export ("createAnnotationViewForAnnotation:frame:")]
		PSPDFAnnotationView CreateAnnotationViewForAnnotation (PSPDFAnnotation annotation, RectangleF annotationRect);
	}

	//////////////////////////////////////////////////////
	////		PSPDFBookmarkBarButtonItem.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFBarButtonItem))]
	interface PSPDFBookmarkBarButtonItem 
	{
		[Export ("showBookmarkControllerOnLongPress", ArgumentSemantic.Assign)]
		bool ShowBookmarkControllerOnLongPress { get; set; }

		[Export ("tapChangesBookmarkStatus", ArgumentSemantic.Assign)]
		bool TapChangesBookmarkStatus { get; set; }

		// SubclassingHooks

		[Export ("bookmarkNumberForVisiblePages")]
		NSNumber BookmarkNumberForVisiblePages ();
	}

	//////////////////////////////////////////////////////
	////		PSPDFBookmarkViewController.h			//
	//////////////////////////////////////////////////////

	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFBookmarkViewControllerDelegate 
	{
		[Export ("currentPageForBookmarkViewController:"), DelegateName ("PSPDFBookmarkViewControllerDelegateCurrentPage"), DefaultValue (1)] [Abstract]
		uint CurrentPageForBookmarkViewController (PSPDFBookmarkViewController bookmarkController);
		
		[Export ("bookmarkViewController:didSelectBookmark:"), EventArgs ("PSPDFBookmarkViewControllerDelegateArgs")] [Abstract]
		void DidSelectBookmark (PSPDFBookmarkViewController bookmarkController, PSPDFBookmark bookmark);
	}

	[BaseType (typeof (UITableViewController),
	Delegates= new string [] {"WeakDelegate"},
	Events=new Type [] { typeof (PSPDFBookmarkViewControllerDelegate) })]
	interface PSPDFBookmarkViewController : PSPDFStyleable
	{
		[Export ("initWithDocument:")]
		IntPtr Constructor (PSPDFDocument document);

		[Export ("document")]
		PSPDFDocument Document { get; set; }

		[Wrap ("WeakDelegate")]
		PSPDFBookmarkViewControllerDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }

//		[Export ("isInPopover", ArgumentSemantic.Assign)]
//		bool IsInPopover { get; set; }
		
		// SubclassingHooks
		
		[Export ("createBarButtonItems")]
		void CreateBarButtonItems ();

		[Export ("updatePopoverSize")]
		void UpdatePopoverSize ();

		[Export ("updateBookmarkView")]
		void UpdateBookmarkView ();

		[Export ("addBookmarkAction:")]
		void AddBookmarkAction (NSObject sender);

		[Export ("doneAction:")]
		void DoneAction (NSObject sender);
	}

	[BaseType (typeof (UITableViewCell))]
	interface PSPDFBookmarkTableViewCell 
	{
		[Export ("textField")]
		UITextField textField { get; set; }

		[Export ("bookmark")]
		PSPDFBookmark Bookmark { get; set; }
	}

	//////////////////////////////////////////////////
	////		PSPDFEmailBarButtonItem.h			//
	//////////////////////////////////////////////////

	delegate void PSPDFEmailBarButtonItemAttachDocumentToMailHandler (bool success);

	[BaseType (typeof (PSPDFBarButtonItem))]
	interface PSPDFEmailBarButtonItem 
	{
		[Export ("sendOptions", ArgumentSemantic.Assign)]
		PSPDFEmailSendOptions SendOptions { get; set; }

		// SubclassingHooks

		[Export ("attachDocumentToMailController:withMode:completionBlock:")]
		void AttachDocumentToMailController (MFMailComposeViewController mailViewController, PSPDFEmailSendOptions mode, PSPDFEmailBarButtonItemAttachDocumentToMailHandler handler);

		[Export ("showEmailControllerWithSendOptions:sender:animated:")]
		void ShowEmailControllerWithSendOptions (PSPDFEmailSendOptions sendOptions, NSObject sender, bool animated);

		[Export ("fileNameForPage:sendOptions:")]
		string FileNameForPage (uint pageIndex, PSPDFEmailSendOptions sendOptions);

		[Export ("actionSheet")] [New]
		UIActionSheet ActionSheet { get; set; }
	}

	//////////////////////////////////////////////////////
	////		PSPDFGenericAnnotationView.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFAnnotationView))]
	interface PSPDFGenericAnnotationView 
	{
		[Export ("initWithAnnotation:")]
		IntPtr Constructor (PSPDFAnnotation annotation);

		// SubclassingHooks

		[Export ("annotationsChanged:")]
		void AnnotationsChanged (NSNotification notification);
	}

	//////////////////////////////////////////////////////
	////		PSPDFHostingAnnotationView.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFGenericAnnotationView))]
	interface PSPDFHostingAnnotationView : PSPDFRenderDelegate
	{
		
	}

	//////////////////////////////////////////////////////
	////		PSPDFBrightnessBarButtonItem.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFBarButtonItem))]
	interface PSPDFBrightnessBarButtonItem 
	{

	}

	//////////////////////////////////////////////////
	////		PSPDFCloseBarButtonItem.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFBarButtonItem))]
	interface PSPDFCloseBarButtonItem 
	{
		
	}

	//////////////////////////////////////////////////
	////		PSPDFPrintBarButtonItem.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFBarButtonItem))]
	interface PSPDFPrintBarButtonItem 
	{
		[Export("printOptions", ArgumentSemantic.Assign)]
		PSPDFPrintOptions printOptions { get; set; }
	}

	//////////////////////////////////////////////////
	////		PSPDFRichMediaAnnotation.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFLinkAnnotation))]
	interface PSPDFRichMediaAnnotation 
	{
		
	}

	//////////////////////////////////////////////
	////		PSPDFScreenAnnotation.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFLinkAnnotation))]
	interface PSPDFScreenAnnotation 
	{
		
	}

	//////////////////////////////////////////////////
	////		PSPDFSearchBarButtonItem.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFBarButtonItem))]
	interface PSPDFSearchBarButtonItem 
	{
		
	}

	//////////////////////////////////////////////////
	////		PSPDFTextAnnotationView.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFGenericAnnotationView))]
	interface PSPDFNoteAnnotationView 
	{
		[Export("initWithAnnotation:")]
		IntPtr Constructor (PSPDFNoteAnnotation noteAnnotation);

		[Export("annotationImageView")]
		UIImageView AnnotationImageView { get; set; }
	}

	//////////////////////////////////////////////////////
	////		PSPDFViewModeBarButtonItem.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFBarButtonItem))]
	interface PSPDFViewModeBarButtonItem 
	{
		[Export ("viewModeSegment")]
		UISegmentedControl ViewModeSegment { get; }
	}

	//////////////////////////////////////////////
	////		PSPDFStampAnnotation.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFAnnotation))]
	interface PSPDFStampAnnotation 
	{
		[Export ("subject", ArgumentSemantic.Copy)]
		string Subject { get; set; }

		[Export ("image")]
		UIImage Image { get; set; }
	}

	//////////////////////////////////////////
	////		PSPDFRenderQueue.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFRenderDelegate 
	{
		[Export ("renderQueue:jobDidFinish:")]
		void JobDidFinish (PSPDFRenderQueue renderQueue, PSPDFRenderJob job);
	} 
	
	[BaseType (typeof (NSObject))]
	interface PSPDFRenderQueue
	{		
		[Export ("sharedRenderQueue")] [Static]
		PSPDFRenderQueue SharedRenderQueue { get; }

		[Export ("requestRenderedImageForDocument:forPage:withSize:clippedToRect:withAnnotations:options:delegate:")]
		PSPDFRenderJob RequestRenderedImageForDocument (PSPDFDocument document, uint page, SizeF size, RectangleF clipRect, PSPDFAnnotation [] annotations, NSDictionary options, PSPDFRenderDelegate oDelegate);

		[Export ("cancelRenderingForDelegate:async:")]
		void CancelRenderingForDelegate (PSPDFRenderDelegate aDelegate, bool async);

		[Export ("hasRenderJobsForDelegate:")]
		bool HasRenderJobsForDelegate (PSPDFRenderDelegate aDelegate);

		[Export ("currentRenderJob")]
		PSPDFRenderJob CurrentRenderJob { get; }

		[Export ("numberOfQueuedJobs")]
		uint NumberOfQueuedJobs { get; }
	}

	[BaseType (typeof (NSObject))]
	interface PSPDFRenderJob
	{		
		[Export ("page", ArgumentSemantic.Assign)]
		uint Page { get; }
		
		[Export ("document")]
		PSPDFDocument Document { get; }

		[Export ("fullSize", ArgumentSemantic.Assign)]
		SizeF FullSize { get; }

		[Export ("clipRect", ArgumentSemantic.Assign)]
		SizeF ClipRect { get; }

		[Export ("zoomScale", ArgumentSemantic.Assign)]
		float ZoomScale { get; }

		[Export ("annotations", ArgumentSemantic.Copy)]
		PSPDFAnnotation [] Annotations { get; }

		[Export ("options", ArgumentSemantic.Copy)]
		NSDictionary Options { get; set; }

		[Wrap ("WeakDelegate")]
		PSPDFRenderDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Export ("renderedImage")]
		UIImage RenderedImage { get; set; }
	}

	//////////////////////////////////////////////////
	////		PSPDFMoreBarButtonItem.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFBarButtonItem))]
	interface PSPDFMoreBarButtonItem 
	{
		[Export ("actionSheet")][New]
		UIActionSheet ActionSheet { get; set; }
	}

	//////////////////////////////////////////////////
	////		PSPDFOpenInBarButtonItem.h			//
	//////////////////////////////////////////////////

	delegate void PSPDFOpenInBarButtonItemFileURLForDocumentHandler (NSUrl url);

	[BaseType (typeof (PSPDFBarButtonItem))]
	interface PSPDFOpenInBarButtonItem 
	{
		[Export ("allowFileMergingAndTempFiles", ArgumentSemantic.Assign)]
		bool AllowFileMergingAndTempFiles { get; set; }

		[Export ("openOptions", ArgumentSemantic.Assign)]
		PSPDFOpenInOptions OpenOptions { get; set; }

		[Export ("documentInteractionController")]
		UIDocumentInteractionController DocumentInteractionController { get; }

		//SubclassingHooks

		[Export ("fileURLForDocument:")]
		NSUrl FileURLForDocument (PSPDFDocument document);

		[Export ("interactionControllerWithURL:")]
		UIDocumentInteractionController InteractionControllerWithURL (NSUrl fileURL);

		[Export ("fileURLForDocument:withOptions:completionBlock:")]
		void FileURLForDocument (PSPDFDocument document, PSPDFOpenInOptions options, PSPDFOpenInBarButtonItemFileURLForDocumentHandler handler);

		[Export ("showOpenInControllerWithOptions:animated:sender:")]
		void ShowOpenInControllerWithOptions (PSPDFOpenInOptions options, bool animated, NSObject sender);
	}

	//////////////////////////////////////////////////
	////		PSPDFOutlineBarButtonItem.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFBarButtonItem))]
	interface PSPDFOutlineBarButtonItem 
	{
		[Export ("isAvailableBlocking")]
		bool IsAvailableBlocking { get; }
	}

	//////////////////////////////////////////////
	////		PSPDFPageLabelView.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFLabelView))]
	interface PSPDFPageLabelView 
	{
		[Export ("showThumbnailGridButton", ArgumentSemantic.Assign)]
		bool ShowThumbnailGridButton { get; set; }
	}

	//////////////////////////////////////////////
	////		PSPDFBrightnessSlider.h			//
	//////////////////////////////////////////////
	
	[BaseType (typeof (UISlider))]
	interface PSPDFBrightnessSlider 
	{
		[Export ("thumbImageStyle", ArgumentSemantic.Assign)]
		PSPDFThumbImageStyle ThumbImageStyle { get; set; }

		[Export ("backgroundStyle", ArgumentSemantic.Assign)]
		PSPDFSliderBackgroundStyle BackgroundStyle { get; set; }

		[Export ("colorPicker")]
		PSPDFColorPickerView ColorPicker { get; set; }

		[Export ("updateBackground")]
		void UpdateBackground ();
	}

	//////////////////////////////////////////////////////
	////		PSPDFHSVColorPickerController.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (PSPDFBaseViewController),
	Delegates= new string [] {"WeakDelegate"},
	Events=new Type [] { typeof (PSPDFColorSelectionViewControllerDelegate) })]
	interface PSPDFHSVColorPickerController 
	{
		[Export ("selectionColor")]
		UIColor SelectionColor { get; set; }

		[Export ("margin", ArgumentSemantic.Assign)]
		UIEdgeInsets Margin { get; set; }

		[Export ("colorPicker")]
		PSPDFColorPickerView ColorPicker { get; }

		[Export ("brightnessSlider")]
		PSPDFBrightnessSlider BrightnessSlider { get; }

		[Wrap ("WeakDelegate")]
		PSPDFColorSelectionViewControllerDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }
	}


	//////////////////////////////////////////////
	////		PSPDFColorPickerView.h			//
	//////////////////////////////////////////////

	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFColorPickerViewDelegate 
	{
		[Export ("colorPickerDidChangeSelection:"), EventArgs("PSPDFColorPickerViewDidChangeSelection")]
		void DidChangeSelection (PSPDFColorPickerView colorPicker);
	}

	[BaseType (typeof (UIControl),
	Delegates= new string [] {"WeakDelegate"},
	Events=new Type [] { typeof (PSPDFColorPickerViewDelegate) })]
	interface PSPDFColorPickerView 
	{
		[Export ("selection", ArgumentSemantic.Assign)]
		PointF Selection { get; }

		[Export ("cropToCircle", ArgumentSemantic.Assign)]
		bool CropToCircle { get; set; }

		[Export ("isOrthoganal", ArgumentSemantic.Assign)]
		bool IsOrthoganal { get; set; }
		
		[Export ("selectionColor")]
		UIColor SelectionColor { get; set; }

		[Export ("brightness", ArgumentSemantic.Assign)]
		float Brightness { get; set; }

		[Wrap ("WeakDelegate")]
		PSPDFColorPickerViewDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Export ("brightnessSlider")]
		PSPDFBrightnessSlider BrightnessSlider { get; set; }

		[Export ("selectionToHue:saturation:brightness:")]
		void SelectionToHue (float pHue, float saturation, float brightness);

		[Export ("colorAtPoint:")]
		UIColor ColorAtPoint (PointF point);
	}

	//////////////////////////////////////////////////////////
	////		PSPDFExtendedPopoverController.h			//
	//////////////////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFPopoverControllerDismissable 
	{
		[Export ("willDismissPopover:animated:"), EventArgs("PSPDFPopoverControllerDismissableWillDismissPopover")]
		void WillDismissPopover (UIPopoverController popover, bool animated);
	}
	
	[BaseType (typeof (UIPopoverController))]
	interface PSPDFExtendedPopoverController 
	{		
		[Export ("notifyContentControllerAboutDismissalAnimated:")]
		void NotifyContentControllerAboutDismissal (bool animated);
	}

	//////////////////////////////////////////////////////////
	////		PSPDFFontSelectorViewController.h			//
	//////////////////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFFontSelectorViewControllerDelegate 
	{
		[Export ("fontSelectorViewController:didSelectFont:"), EventArgs("PSPDFFontSelectorViewControllerDelegateDidSelectFont")]
		void DidSelectFont (PSPDFFontSelectorViewController fontSelectorViewController, UIFont selectedFont);
	}
	
	[BaseType (typeof (UITableViewController),
	Delegates= new string [] {"WeakDelegate"},
	Events=new Type [] { typeof (PSPDFFontSelectorViewControllerDelegate) })]
	interface PSPDFFontSelectorViewController 
	{		
		[Export ("fontFamilyNames")]
		string [] FontFamilyNames { get; set; }

		[Export ("selectedFont")]
		UIFont SelectedFont { get; set; }

		[Wrap ("WeakDelegate")]
		PSPDFFontSelectorViewControllerDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }
	}

	//////////////////////////////////////////////////////
	////		PSPDFFontStyleViewController.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFFontStyleViewControllerDelegate 
	{
		[Export ("fontStyleViewController:didSelectFont:"), EventArgs("PSPDFFontStyleViewControllerDelegateDidSelectFont")]
		void DidSelectFont (PSPDFFontStyleViewController fontStyleViewController, UIFont selectedFont);
	}
	
	[BaseType (typeof (UITableViewController),
	Delegates= new string [] {"WeakDelegate"},
	Events=new Type [] { typeof (PSPDFFontStyleViewControllerDelegate) })]
	interface PSPDFFontStyleViewController 
	{		
		[Export ("initWithFontFamilyName:")]
		IntPtr Constructor (string fontFamilyName);
		
		[Export ("fontFamilyName")]
		string FontFamilyName { get; set; }

		[Export ("fontNames")]
		string [] FontNames { get; set; }

		[Export ("selectedFont")]
		UIFont SelectedFont { get; set; }
		
		[Wrap ("WeakDelegate")]
		PSPDFFontStyleViewControllerDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }
	}

	//////////////////////////////////////////////////////
	////		PSPDFSignatureViewController.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface PSPDFSignatureViewControllerDelegate 
	{
		[Export ("signatureViewControllerDidCancel:"), EventArgs("PSPDFSignatureViewControllerDelegateArgs")]
		void DidCancel (PSPDFSignatureViewController signatureController);

		[Export ("signatureViewControllerDidSave:"), EventArgs("PSPDFSignatureViewControllerDelegateArgs")]
		void DidSave (PSPDFSignatureViewController signatureController);
	}
	
	[BaseType (typeof (PSPDFBaseViewController),
	Delegates= new string [] {"WeakDelegate"},
	Events=new Type [] { typeof (PSPDFSignatureViewControllerDelegate) })]
	interface PSPDFSignatureViewController 
	{		
		[Export ("lines")]
		NSArray Lines { get; }
		
		[Wrap ("WeakDelegate")]
		PSPDFSignatureViewControllerDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Export ("userInfo", ArgumentSemantic.Copy)]
		NSDictionary UserInfo { get; set; }
	}

	//////////////////////////////////////////////////////
	////		PSTCollectionViewUpdateItem.h			//
	//////////////////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSTCollectionViewUpdateItem
	{
		[Export ("indexPathBeforeUpdate")]
		NSIndexPath IndexPathBeforeUpdate { get; }

		[Export ("indexPathAfterUpdate")]
		NSIndexPath IndexPathAfterUpdate { get; }

		[Export ("updateAction", ArgumentSemantic.Assign)]
		PSTCollectionUpdateAction UpdateAction { get; }

		[Export ("initWithInitialIndexPath:finalIndexPath:updateAction:")]
		IntPtr Constructor (NSIndexPath initialIndexPath, NSIndexPath finalIndexPath, PSTCollectionUpdateAction updateAction);

		[Export ("initWithAction:forIndexPath:")]
		IntPtr Constructor (PSTCollectionUpdateAction action, NSIndexPath indexPath);

		[Export ("initWithOldIndexPath:newIndexPath:")]
		IntPtr Constructor (NSIndexPath arg1, NSIndexPath arg2);

		[Export ("compareIndexPaths:")]
		NSComparisonResult CompareIndexPaths (PSTCollectionViewUpdateItem otherItem);

		[Export ("inverseCompareIndexPaths:")]
		NSComparisonResult InverseCompareIndexPaths (PSTCollectionViewUpdateItem otherItem);
	}

	//////////////////////////////////////////
	////		PSPDFImageInfo.h			//
	//////////////////////////////////////////
	
	[BaseType (typeof (NSObject))]
	interface PSPDFImageInfo 
	{
		[Export ("imageID", ArgumentSemantic.Copy)]
		string ImageID { get; set; }

		[Export ("pixelWidth", ArgumentSemantic.Assign)]
		int PixelWidth { get; set; }

		[Export ("pixelHeight", ArgumentSemantic.Assign)]
		int PixelHeight { get; set; }

		[Export ("bitsPerComponent", ArgumentSemantic.Assign)]
		int BitsPerComponent { get; set; }

		[Export ("displayWidth", ArgumentSemantic.Assign)]
		double DisplayWidth { get; set; }

		[Export ("displayHeight", ArgumentSemantic.Assign)]
		double DisplayHeight { get; set; }

		[Export ("horizontalResolution", ArgumentSemantic.Assign)]
		double HorizontalResolution { get; set; }

		[Export ("verticalResolution", ArgumentSemantic.Assign)]
		double VerticalResolution { get; set; }

		[Export ("vertices", ArgumentSemantic.Assign)]
		PointF Vertices { get; }

		[Export ("document")]
		PSPDFDocument Document { get; set; }

		[Export ("page", ArgumentSemantic.Assign)]
		uint Page { get; set; }

		[Export ("isPointInImage:")]
		bool IsPointInImage (PointF point);

		[Export ("boundingBox")]
		RectangleF BoundingBox { get; }

		[Export ("image")]
		UIImage Image { get; }
	}

	//////////////////////////////////////////////////
	////		PSPDFPopoverController.h			//
	//////////////////////////////////////////////////
	
	[BaseType (typeof (UIPopoverController))]
	interface PSPDFPopoverController 
	{
		[Export("initWithContentViewController:")]
		IntPtr Constructor (UIViewController controller);

		[Export ("tintColor")]
		UIColor TintColor { get; set; }

		[Export ("notifyContentControllerAboutDismissalAnimated:")]
		void NotifyContentControllerAboutDismissalAnimated (bool animated);

		/* All this methods and Props are being Inherited 
		 * so no need to bind them Again

		[Wrap ("WeakDelegate")]
		UIPopoverControllerDelegate Delegate { get; set; }

		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Export ("contentViewController")]
		UIViewController ContentViewController { get; set; }

		[Export ("setContentViewController:animated:")]
		void SetContentViewController (UIViewController viewController, bool animated);

		[Export ("popoverContentSize")]
		SizeF PopoverContentSize { get; set; }

		[Export ("setPopoverContentSize:animated:")]
		void SetPopoverContentSize (SizeF size, bool animated);

		[Export ("popoverVisible")]
		bool PopoverVisible { [Bind("isPopoverVisible")] get; }

		[Export ("popoverArrowDirection", ArgumentSemantic.Assign)]
		UIPopoverArrowDirection PopoverArrowDirection { get; set; }

		[Export ("passthroughViews", ArgumentSemantic.Copy)]
		UIView [] PassthroughViews { get; set; }

		[Export ("presentPopoverFromBarButtonItem:permittedArrowDirections:animated:")]
		void PresentPopoverFromBarButtonItem (UIBarButtonItem item, UIPopoverArrowDirection arrowDirections, bool animated);

		[Export ("presentPopoverFromRect:inView:permittedArrowDirections:animated:")]
		void PresentPopoverFromRect (RectangleF rect, UIView view, UIPopoverArrowDirection arrowDirections, bool animated);

		[Export ("dismissPopoverAnimated:")]
		void DismissPopoverAnimated (bool animated);

		[Export ("popoverLayoutMargins")]
		UIEdgeInsets PopoverLayoutMargins { get; set; }

		[Export ("popoverBackgroundViewClass")]
		Class PopoverBackgroundViewClass { get; set; }
		*/
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
		
		[Bind("pspdf_preloadedImageWithData:")][Static]
		UIImage Pspdf_preloadedImageWithData (NSData data);
		
		[Bind("pspdf_imageNamed:bundle:")][Static]
		UIImage Pspdf_imageNamedBundle (string imageName, NSBundle bundle);
		
		[Bind("pdpdf_imageTintedWithColor:fraction:")]
		UIImage Pdpdf_imageTintedWithColor (UIColor color, float fraction);
		
		[Since (5,0)]
		[Bind("pspdf_animatedGIFWithPath:")][Static]
		UIImage Pspdf_animatedGIFWithPath (string path);
	}

	// Protocols

	interface PSPDFViewControllerDelegates //PSPDFViewControllerDelegates.h
	{
		[Export ("delegateShouldSetDocument:")]
		bool DelegateShouldSetDocument (PSPDFDocument document);

		[Export ("delegateWillDisplayDocument")]
		void DelegateWillDisplayDocument ();

		[Export ("delegateDidDisplayDocument")]
		void DelegateDidDisplayDocument ();

		[Export ("delegateDidShowPage:")]
		void DelegateDidShowPage (uint realPage);

		[Export ("delegateDidShowPageView:")]
		void DelegateDidShowPageView (PSPDFPageView pageView);

		[Export ("delegateDidRenderPageView:")]
		void DelegateDidRenderPageView (PSPDFPageView pageView);

		[Export ("delegateDidChangeViewMode:")]
		void DelegateDidChangeViewMode (PSPDFViewMode viewMode);

		[Export ("delegateShouldScrollToPage:")]
		bool DelegateShouldScrollToPage (uint page);

		[Export ("delegateDidTapOnPageView:atPoint:")]
		bool DelegateDidTapOnPageView (PSPDFPageView pageView, PointF viewPoint);

		[Export ("delegateDidLongPressOnPageView:atPoint:gestureRecognizer:")]
		bool DelegateDidLongPressOnPageView (PSPDFPageView pageView, PointF viewPoint, UILongPressGestureRecognizer gestureRecognizer);

		[Export ("delegateShouldSelectText:withGlyphs:atRect:onPageView:")]
		bool DelegateShouldSelectText (string text, PSPDFGlyph [] glyphs, RectangleF rect, PSPDFPageView pageView);

		[Export ("delegateDidSelectText:withGlyphs:atRect:onPageView:")]
		void DelegateDidSelectText (string text, PSPDFGlyph [] glyphs, RectangleF rect, PSPDFPageView pageView);

		[Export ("delegateShouldShowMenuItems:atSuggestedTargetRect:forSelectedText:inRect:onPageView:")]
		PSPDFMenuItem [] DelegateShouldShowMenuItems (PSPDFMenuItem [] menuItems, RectangleF rect, string selectedText, RectangleF textRect, PSPDFPageView pageView);

		[Export ("delegateDidTapOnAnnotation:annotationPoint:annotationView:pageView:viewPoint:")]
		bool DelegateDidTapOnAnnotation (PSPDFAnnotation annotation, PointF annotationPoint, PSPDFAnnotationView annotationView, PSPDFPageView pageView, PointF viewPoint);

		[Export ("delegateShouldSelectAnnotation:onPageView:")]
		bool DelegateShouldSelectAnnotation (PSPDFAnnotation annotation, PSPDFPageView pageView);

		[Export ("delegateDidSelectAnnotation:onPageView:")]
		void DelegateDidSelectAnnotation (PSPDFAnnotation annotation, PSPDFPageView pageView);

		[Export ("delegateShouldShowMenuItems:atSuggestedTargetRect:forAnnotation:inRect:onPageView:")]
		PSPDFMenuItem [] DelegateShouldShowMenuItems (PSPDFMenuItem [] menuItems, RectangleF rect, PSPDFAnnotation annotation, RectangleF textRect, PSPDFPageView pageView);

		[Export ("delegateShouldDisplayAnnotation:onPageView:")]
		bool DelegateShouldDisplayAnnotation (PSPDFAnnotation annotation, PSPDFPageView pageView);

		[Export ("delegateAnnotationView:forAnnotation:onPageView:")]
		PSPDFAnnotationView DelegateAnnotationView (PSPDFAnnotationView annotationView, PSPDFAnnotation annotation, PSPDFPageView pageView);

		[Export ("delegateWillShowAnnotationView:onPageView:")]
		void DelegateWillShowAnnotationView (PSPDFAnnotationView annotationView, PSPDFPageView pageView);

		[Export ("delegateDidShowAnnotationView:onPageView:")]
		void DelegateDidShowAnnotationView (PSPDFAnnotationView annotationView, PSPDFPageView pageView);

		[Export ("delegateDidEndPageScrollingAnimation:")]
		void DelegateDidEndPageScrollingAnimation (UIScrollView scrollView);

		[Export ("delegateDidEndZooming:withView:atScale:")]
		void DelegateDidEndZooming (UIScrollView scrollView, UIView view, float scale);

		[Export ("delegateDidEndPageDragging:willDecelerate:withVelocity:targetContentOffset:")]
		void DelegateDidEndPageDragging (UIScrollView scrollView, bool decelerate, PointF velocity, ref PointF targetContentOffset);

		[Export ("delegateDocumentForRelativePath:")]
		PSPDFDocument DelegateDocumentForRelativePath (string relativePath);

		[Export ("delegateDidLoadPageView:")]
		void DelegateDidLoadPageView (PSPDFPageView pageView);

		[Export ("delegateWillUnloadPageView:")]
		void DelegateWillUnloadPageView (PSPDFPageView pageView);

		[Export ("delegateShouldShowController:embeddedInController:animated:")]
		bool DelegateShouldShowController (NSObject viewController, NSObject controller, bool animated);

		[Export ("delegateDidShowController:embeddedInController:animated:")]
		bool DelegateDidShowController (NSObject viewController, NSObject controller, bool animated);

		[Export ("updateDelegateFlags")]
		void UpdateDelegateFlags ();
	}

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

