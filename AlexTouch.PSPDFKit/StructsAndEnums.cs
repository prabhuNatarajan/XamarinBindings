using System;
using System.Runtime.InteropServices;
using MonoTouch.ObjCRuntime;

namespace AlexTouch.PSPDFKit
{

	//////////////////////////////////////////
	////	PSPDFKitGlobal.h enums			//
	////	Start 							//
	//////////////////////////////////////////
	public enum PSPDFErrorCode
	{
		PageInvalid = 100,
		UnableToOpenPDF = 200,
		UnableToGetPageReference = 210,
		DocumentLocked = 300,
		FailedToLoadAnnotations = 400,
		FailedToWriteAnnotations = 410,
		OutlineParser = 500,
		UnableToConvertToDataRepresentation = 600,
		RemoveCacheError = 700,
		FailedToConvertToPDF = 800,
		Unknown = 900
	}

	public enum PSPDFLogLevel
	{
		Nothing = 0,
		Error,   
		Warning,
		Info,
		Verbose
	}

	public enum PSPDFAnimate
	{
		Never,
		ModernDevices,
		Everywhere
	}

	//////////////////////////////////////////
	////	PSPDFConverter.h enums			//
	////	Start 							//
	//////////////////////////////////////////

	public enum PSPDFRectAlignment
	{
		Center = 0,
		Top,
		TopLeft,
		TopRight,
		Left,
		Bottom,
		BottomLeft,
		BottomRight,
		Right
	}

	//////////////////////////////////////////
	////	PSPDFViewController.h enums 	//
	////	Start 							//
	//////////////////////////////////////////

	public enum PSPDFPageTransition
	{
		PerPage,      // default mode for iOS4. Has one scrollView per page.
		ScrollContinuous,   // Similar to UIWebView. Ignores PSPDFPageModeDouble.
		Curl                // replaces pageCurlEnabled. iOS5+ feature.ure.
	}

	public enum PSPDFViewMode
	{
		Document,
		Thumbnails
	}

	public enum PSPDFPageMode
	{
		Single,   // Default on iPhone.
		Double,
		Automatic // single in portrait, double in landscape if the document's height > width. Default on iPad.
	}

	public enum PSPDFScrollDirection
	{
		Horizontal, // default
		Vertical
	}

	public enum PSPDFStatusBarStyleSetting
	{
		Inherit,             /// Don't change status bar style, but show/hide statusbar on HUD events.
		SmartBlack,          /// UIStatusBarStyleBlackOpaque on iPad, UIStatusBarStyleBlackTranslucent on iPhone.
		SmartBlackHideOnIpad,/// Similar to PSPDFStatusBarSmartBlack, but also hides statusBar on iPad.
		BlackOpaque,         /// Opaque Black everywhere.
		Default,             /// Default statusbar (white on iPhone/black on iPad).
		Disable,             /// Never show status bar.
		Ignore = 256       /// Causes this class to ignore the statusbar entirely.
	}

	public enum PSPDFHUDViewMode
	{
		Always,                   /// Always show the HUD.
		Automatic,                /// Show HUD on touch and first/last page.
		AutomaticNoFirstLastPage, /// Show HUD on touch.
		Never                     /// Never show the HUD.
	}

	public enum PSPDFLinkAction
	{
		None,         /// Link actions are ignored.
		AlertView,    /// Link actions open an UIAlertView.
		OpenSafari,   /// Link actions directly open Safari.
		InlineBrowser /// Link actions open in an inline browser.
	}

	public enum PSPDFPageRenderingMode
	{
		ThumbailThenFullPage, // load cached page async
		FullPage,             // load cached page async, no upscaled thumb
		FullPageBlocking,     // load cached page directly
		ThumbnailThenRender,  // don't use cached page but thumb
		Render                // don't use cached page nor thumb
	}

	//////////////////////////////////////
	////	PSPDFDocument.h enums 		//
	////	Start 						//
	//////////////////////////////////////

	public enum PSPDFAnnotationSaveMode
	{
		Disabled,
		ExternalFile,
		Embedded,
		WithExternalFileAsFallback
	}

	//////////////////////////////////////////
	////	PSPDFAnnotation.h enums 		//
	////	Start 							//
	//////////////////////////////////////////

	[Flags]
	public enum PSPDFAnnotationType : uint
	{
		None      = 0,
		Link      = 2,
		Highlight = 4, // (Highlight, Underline, StrikeOut) - PSPDFHighlightAnnotationView
		Text      = 8,
		Ink       = 16,
		Shape     = 32, // Square, Circle
		Line      = 64,
		Note      = 128,
		Stamp     = 256,
		RichMedia = 1024, // Embedded PDF videos
		Screen    = 2048,
		Undefined = 2147483648, // any annotation whose type couldn't be recognized
		All       = uint.MaxValue
	}

	public enum PSPDFAnnotationBorderStyle : uint
	{
		None,
		Solid,
		Dashed,
		Belved,
		Inset,
		Underline,
		Unknown
	}

	//////////////////////////////////////////////////
	////	PSPDFHighlightAnnotation.h enums 		//
	////	Start 									//
	//////////////////////////////////////////////////

	public enum PSPDFHighlightAnnotationType
	{
		Unknown = 0,
		Highlight,
		Underline,
		StrikeOut
	}

	//////////////////////////////////////////
	////	PSPDFScrollView.h enums 		//
	////	Start 							//
	//////////////////////////////////////////

	public enum PSPDFShadowStyle
	{
		Flat,   // flat  shadow style (Default)
		Curl   // curled shadow style
	}

	//////////////////////////////////////////////////////////
	////	PSTCollectionViewScrollPosition.h enums 		//
	////	Start 											//
	//////////////////////////////////////////////////////////

	[Since (6,0)]
	[Flags]
	public enum PSTCollectionViewScrollPosition : uint
	{
		None                 = 0,
		
		// The vertical positions are mutually exclusive to each other, but are bitwise or-able with the horizontal scroll positions.
		// Combining positions from the same grouping (horizontal or vertical) will result in an NSInvalidArgumentException.
		Top                  = 1,
		CenteredVertically   = 2,
		Bottom               = 4,
		
		// Likewise, the horizontal positions are mutually exclusive to each other.
		Left                 = 8,
		CenteredHorizontally = 16,
		Right                = 32
	}

	[Flags]
	public enum UICollectionViewScrollPosition : uint
	{
		None                 = 0,
		
		// The vertical positions are mutually exclusive to each other, but are bitwise or-able with the horizontal scroll positions.
		// Combining positions from the same grouping (horizontal or vertical) will result in an NSInvalidArgumentException.
		Top                  = 1,
		CenteredVertically   = 2,
		Bottom               = 4,
		
		// Likewise, the horizontal positions are mutually exclusive to each other.
		Left                 = 8,
		CenteredHorizontally = 16,
		Right                = 32
	}

	//////////////////////////////////////////////////
	////	PSTCollectionViewLayout.h enums 		//
	////	Start 									//
	//////////////////////////////////////////////////

	public enum PSTCollectionViewItemType : uint
	{
		Cell,
		SupplementaryView,
		DecorationView
	}

	//////////////////////////////////////////////
	////	PSPDFSearchOperation.h enums 		//
	////	Start 								//
	//////////////////////////////////////////////

	public enum PSPDFSearchMode
	{
		Basic,
		Highlighting
	}

	//////////////////////////////////////////////
	////	PSPDFLineAnnotation.h enums 		//
	////	Start 								//
	//////////////////////////////////////////////

	public enum PSPDFLineEndType
	{
		None,
		Square,
		Circle,
		Diamond,
		OpenArrow,
		ClosedArrow,
		Butt,
		ReverseOpenArrow,
		ReverseClosedArrow,
		Slash
	}

	//////////////////////////////////////////////
	////	PSPDFLinkAnnotation.h enums 		//
	////	Start 								//
	//////////////////////////////////////////////

	public enum PSPDFLinkAnnotationType
	{
		Page = 0,
		WebURL,  // 1
		Document,// 2
		Video,   // 3
		YouTube, // 4
		Audio,   // 5
		Image,   // 6
		Browser, // 7
		Custom  /// any annotation format that is not recognized is custom, calling the delegate viewForAnnotation:
	}

	//////////////////////////////////////////////
	////	PSPDFShapeAnnotation.h enums 		//
	////	Start 								//
	//////////////////////////////////////////////

	public enum PSPDFShapeAnnotationType
	{
		Unknown,
		Square,
		Circle
	}

	//////////////////////////////////////////////
	////	PSPDFWebViewController.h enums 		//
	////	Start 								//
	//////////////////////////////////////////////

	[Flags]
	public enum PSPDFWebViewControllerAvailableActions : uint
	{
		None             = 0,
		OpenInSafari     = 1,
		MailLink         = 2,
		CopyLink         = 4,
		Print            = 8,
		StopReload       = 16,
		Back             = 32,
		Forward          = 64,
		All              = 16777215
	}

	//////////////////////////////////
	////	PSPDFCache.h enums 		//
	////	Start					//
	//////////////////////////////////

	public enum PSPDFCacheStrategy
	{
		Nothing,                    // no files are saved. (slowest)
		Thumbnails,                 // only thumbnails.
		ThumbnailsAndNearPages,     // only a few files are saved.
		Opportunistic               // the whole PDF document is converted to images and saved. (fastest)
	}

	public enum PSPDFSize
	{
		Native,     /// single page portrait device screen size
		Thumbnail,  /// defined as above in kPSPDFThumbnailSize
		Tiny        /// tiny is memory-only
	}

	//////////////////////////////////////////////////
	////	PSCollectionViewFlowLayout.h enums 		//
	////	Start	 								//
	//////////////////////////////////////////////////

	[Since(6,0)]
	public enum PSTCollectionViewScrollDirection
	{
		Vertical,
		Horizontal
	}

	public enum UICollectionViewScrollDirection
	{
		Vertical,
		Horizontal
	}

	public enum PSTFlowLayoutHorizontalAlignment
	{
		Left,
		Centered,
		Right,
		Justify // 3; default except for the last row
	}

	//////////////////////////////////////////////////
	////	PSCollectionViewFlowLayout.h enums 		//
	////	Start	 								//
	//////////////////////////////////////////////////

	public enum PSPDFImageResizingMethod
	{
		Crop,	// analogous to UIViewContentModeScaleAspectFill, i.e. "best fit" with no space around.
		CropStart,
		CropEnd,
		Scale	// analogous to UIViewContentModeScaleAspectFit, i.e. scale down to fit, leaving space around if necessary.
	}

	//////////////////////////////////////////////////
	////	PSPDFSearchViewController.h enums 		//
	////	Start									//
	//////////////////////////////////////////////////

	public enum PSPDFSearchStatus
	{
		Idle,
		Active,
		Finished,
		Cancelled
	}

	//////////////////////////////////////////////////
	////	PSPDFAnnotationToolbar.h enums	 		//
	////	Start									//
	//////////////////////////////////////////////////
	
	public enum PSPDFAnnotationToolbarMode : uint
	{
		None,
		Note,
		Highlight,
		StrikeOut,
		Underline,
		FreeText,
		Draw
	}

	//////////////////////////////////////
	////	PSPDFLoupeView.h enums 		//
	////	Start						//
	//////////////////////////////////////

	public enum PSPDFLoupeViewMode
	{
		Circular,
		DetailTop,
		DetailBottom
	}

	//////////////////////////////////////
	////	PSPDFColorView.h enums 		//
	////	Start						//
	//////////////////////////////////////

	public enum PSPDFColorViewBorderStyle
	{
		Single = 0,
		Top, 
		Middle, 
		Bottom
	}

	//////////////////////////////////////
	////	PSPDFColorView.h enums 		//
	////	Start						//
	//////////////////////////////////////
	
	public enum PSPDFGradientViewDirection
	{
		Horizontal,
		Vertical
	}

	//////////////////////////////////////
	////	PSPDFColorView.h enums 		//
	////	Start						//
	//////////////////////////////////////
	
	public enum PSPDFProgressHUDMaskType : uint
	{
		None = 1, // allow user interactions while HUD is displayed
		Clear, // don't allow
		Black, // don't allow and dim the UI in the back of the HUD
		Gradient // don't allow and dim the UI with a a-la-alert-view bg gradient
	}

	//////////////////////////////////////
	////	PSPDFLabelView.h enums 		//
	////	Start						//
	//////////////////////////////////////
	
	public enum PSPDFLabelStyle : uint
	{
		Flat,
		Bordered
	}

	//////////////////////////////////////////////////
	////	PSPDFEmailBarButtonItem.h enums 		//
	////	Start									//
	//////////////////////////////////////////////////

	[Flags]
	public enum PSPDFEmailSendOptions : uint
	{
		CurrentPageOnly              = 1,
		CurrentPageOnlyFlattened     = 2,
		VisiblePages                 = 4,
		VisiblePagesFlattened        = 8,
		MergedFilesIfNeeded          = 16,
		MergedFilesIfNeededFlattened = 32,
		OriginalDocumentFiles        = 64
	}

	//////////////////////////////////////////
	////	PSPDFResizableView.h enums 		//
	////	Start							//
	//////////////////////////////////////////

	public enum PSPDFSelectionBorderKnobType : uint
	{
		None,
		Move,
		TopLeft,
		TopMiddle,
		TopRight,
		MiddleLeft,
		MiddleRight,
		BottomLeft,
		BottomMiddle,
		BottomRight
	}

	//////////////////////////////////////////////////////
	////	PSPDFViewControllerDelegates.h enums 		//
	////	Start										//
	//////////////////////////////////////////////////////

//	[StructLayout(LayoutKind.Sequential)]
//	public struct PSPDFDelegateFlags
//	{
//		uint delegateShouldSetDocument;
//		uint delegateWillDisplayDocument;
//		uint delegateDidDisplayDocument;
//		uint delegateDidShowPageView;
//		uint delegateDidRenderPageView;
//		uint delegateDidChangeViewMode;
//		uint delegateDidTapOnPageView;
//		uint delegateDidLongPressOnPageView;
//		uint delegateShouldSelectText;
//		uint delegateDidSelectText;
//		uint delegateShouldShowMenuItemsForSelectedText;
//		uint delegateShouldSelectAnnotation;
//		uint delegateDidSelectAnnotation;
//		uint delegateShouldShowMenuItemsForAnnotation;
//		uint delegateDidTapOnAnnotation;
//		uint delegateShouldDisplayAnnotation;
//		uint delegateShouldScrollToPage;
//		uint delegateAnnotationViewForAnnotation;
//		uint delegateWillShowAnnotationView;
//		uint delegateDidShowAnnotationView;
//		uint delegateDidLoadPageView;
//		uint delegateWillUnloadPageView;
//		uint delegateDidEndPageDraggingWillDecelerate;
//		uint delegateDidEndPageScrollingAnimation;
//		uint delegateDidEndZoomingAtScale;
//		uint delegateShouldShowControllerAnimated;
//		uint delegateDidShowControllerAnimated;
//		uint delegateDocumentForRelativePath;
//	}
}

