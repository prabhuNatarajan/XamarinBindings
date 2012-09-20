using System;

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
		DocumentLocked = 300,
		FailedToLoadAnnotations = 400,
		FailedToWriteAnnotations = 410,
		OutlineParser = 500,
		UnableToConvertToDataRepresentation = 600,
		Unknown = 900,
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
		ScrollPerPageTransition = 0,     // default mode for iOS4. Has one scrollView per page.
		CurlTransition = 2               // replaces pageCurlEnabled. iOS5+ feature.
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
		Inherit,            /// Don't change status bar style, but show/hide statusbar on HUD events
		SmartBlack,         /// Use UIStatusBarStyleBlackOpaque on iPad, UIStatusBarStyleBlackTranslucent on iPhone.
		BlackOpaque,        /// Opaque Black everywhere
		Default,            /// Default statusbar (white on iPhone/black on iPad)
		Disable,            /// Never show status bar
		Ignore = 0x100      /// Causes this class to ignore the statusbar entirely.
	}

	public enum PSPDFHUDViewMode
	{
		Always,               /// Always show the HUD.
		Automatic,            /// Show HUD on touch and first/last page.
		Never                 /// Never show the HUD.
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

	public enum PSPDFAnnotationType : uint
	{
		Undefined = 0,      // any annotation whose type couldn't be recognized.
		Link      = 1 << 1,
		Highlight = 1 << 2, // (Highlight, Underline, StrikeOut) - PSPDFHighlightAnnotationView
		Text      = 1 << 5,
		Ink       = 1 << 6,
		Shape     = 1 << 7, // Square, Circle
		Line      = 1 << 8,
		Note      = 1 << 9,
		All       = 4294967295
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

	//////////////////////////////////////////
	////	PSCollectionView.h enums 		//
	////	Start 							//
	//////////////////////////////////////////

	public enum PSCollectionViewScrollPosition : uint
	{
		None                 = 0,
		
		// The vertical positions are mutually exclusive to each other, but are bitwise or-able with the horizontal scroll positions.
		// Combining positions from the same grouping (horizontal or vertical) will result in an NSInvalidArgumentException.
		Top                  = 1 << 0,
		CenteredVertically   = 1 << 1,
		Bottom               = 1 << 2,
		
		// Likewise, the horizontal positions are mutually exclusive to each other.
		Left                 = 1 << 3,
		CenteredHorizontally = 1 << 4,
		Right                = 1 << 5
	}

	//////////////////////////////////////////////
	////	PSCollectionViewLayout.h enums 		//
	////	Start 								//
	//////////////////////////////////////////////

	public enum PSCollectionViewItemType : uint
	{
		Cell,
		DecorationView,
		SupplementaryView
	}

	public enum PSCollectionUpdateAction
	{
		Insert,
		Delete,
		Reload,
		Move,
		None
	}

	//////////////////////////////////////////////
	////	PSPDFSearchOperation.h enums 		//
	////	Start 								//
	//////////////////////////////////////////////

	public enum PSPDFSearchMode
	{
		BasicSearch,
		SearchWithHighlighting
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
		WebURL,
		Video,
		YouTube,
		Audio,
		Image,
		Browser,
		Custom
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

	public enum PSPDFWebViewControllerAvailableActions : uint
	{
		None             = 0,
		OpenInSafari     = 1 << 0,
		MailLink         = 1 << 1,
		CopyLink         = 1 << 2,
		Print            = 1 << 3
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

	public enum PSCollectionViewScrollDirection
	{
		Vertical,
		Horizontal
	}

	public enum PSFlowLayoutHorizontalAlignment
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
}

