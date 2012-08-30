//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using MonoTouch;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreMedia;
using MonoTouch.CoreMotion;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.NewsstandKit;
using MonoTouch.GLKit;
using OpenTK;

namespace AlexTouch.PSPDFKit {
	[Register("PSPDFViewController", true)]
	public unsafe partial class PSPDFViewController : PSPDFBaseViewController {
		static readonly IntPtr selPage = Selector.GetHandle ("page");
		static readonly IntPtr selRealPage = Selector.GetHandle ("realPage");
		static readonly IntPtr selViewState = Selector.GetHandle ("viewState");
		static readonly IntPtr selSetViewState_ = Selector.GetHandle ("setViewState:");
		static readonly IntPtr selRenderContentOpacity = Selector.GetHandle ("renderContentOpacity");
		static readonly IntPtr selSetRenderContentOpacity_ = Selector.GetHandle ("setRenderContentOpacity:");
		static readonly IntPtr selRenderBackgroundColor = Selector.GetHandle ("renderBackgroundColor");
		static readonly IntPtr selSetRenderBackgroundColor_ = Selector.GetHandle ("setRenderBackgroundColor:");
		static readonly IntPtr selRenderInvertEnabled = Selector.GetHandle ("renderInvertEnabled");
		static readonly IntPtr selSetRenderInvertEnabled_ = Selector.GetHandle ("setRenderInvertEnabled:");
		static readonly IntPtr selHUDView = Selector.GetHandle ("HUDView");
		static readonly IntPtr selHUDViewMode = Selector.GetHandle ("HUDViewMode");
		static readonly IntPtr selSetHUDViewMode_ = Selector.GetHandle ("setHUDViewMode:");
		static readonly IntPtr selIsHUDVisible = Selector.GetHandle ("isHUDVisible");
		static readonly IntPtr selSetHUDVisible_ = Selector.GetHandle ("setHUDVisible:");
		static readonly IntPtr selIsToolbarEnabled = Selector.GetHandle ("isToolbarEnabled");
		static readonly IntPtr selSetToolbarEnabled_ = Selector.GetHandle ("setToolbarEnabled:");
		static readonly IntPtr selIsScrobbleBarEnabled = Selector.GetHandle ("isScrobbleBarEnabled");
		static readonly IntPtr selSetScrobbleBarEnabled_ = Selector.GetHandle ("setScrobbleBarEnabled:");
		static readonly IntPtr selIsPositionViewEnabled = Selector.GetHandle ("isPositionViewEnabled");
		static readonly IntPtr selSetPositionViewEnabled_ = Selector.GetHandle ("setPositionViewEnabled:");
		static readonly IntPtr selIsRenderAnimationEnabled = Selector.GetHandle ("isRenderAnimationEnabled");
		static readonly IntPtr selSetRenderAnimationEnabled_ = Selector.GetHandle ("setRenderAnimationEnabled:");
		static readonly IntPtr selContentView = Selector.GetHandle ("contentView");
		static readonly IntPtr selDelegate = Selector.GetHandle ("delegate");
		static readonly IntPtr selSetDelegate_ = Selector.GetHandle ("setDelegate:");
		static readonly IntPtr selDocument = Selector.GetHandle ("document");
		static readonly IntPtr selSetDocument_ = Selector.GetHandle ("setDocument:");
		static readonly IntPtr selMargin = Selector.GetHandle ("margin");
		static readonly IntPtr selSetMargin_ = Selector.GetHandle ("setMargin:");
		static readonly IntPtr selPadding = Selector.GetHandle ("padding");
		static readonly IntPtr selSetPadding_ = Selector.GetHandle ("setPadding:");
		static readonly IntPtr selRenderingMode = Selector.GetHandle ("renderingMode");
		static readonly IntPtr selSetRenderingMode_ = Selector.GetHandle ("setRenderingMode:");
		static readonly IntPtr selIsSmartZoomEnabled = Selector.GetHandle ("isSmartZoomEnabled");
		static readonly IntPtr selSetSmartZoomEnabled_ = Selector.GetHandle ("setSmartZoomEnabled:");
		static readonly IntPtr selIsScrollingEnabled = Selector.GetHandle ("isScrollingEnabled");
		static readonly IntPtr selSetScrollingEnabled_ = Selector.GetHandle ("setScrollingEnabled:");
		static readonly IntPtr selIsViewLockEnabled = Selector.GetHandle ("isViewLockEnabled");
		static readonly IntPtr selSetViewLockEnabled_ = Selector.GetHandle ("setViewLockEnabled:");
		static readonly IntPtr selIsRotationLockEnabled = Selector.GetHandle ("isRotationLockEnabled");
		static readonly IntPtr selSetRotationLockEnabled_ = Selector.GetHandle ("setRotationLockEnabled:");
		static readonly IntPtr selIsScrollOnTapPageEndEnabled = Selector.GetHandle ("isScrollOnTapPageEndEnabled");
		static readonly IntPtr selSetScrollOnTapPageEndEnabled_ = Selector.GetHandle ("setScrollOnTapPageEndEnabled:");
		static readonly IntPtr selIsTextSelectionEnabled = Selector.GetHandle ("isTextSelectionEnabled");
		static readonly IntPtr selSetTextSelectionEnabled_ = Selector.GetHandle ("setTextSelectionEnabled:");
		static readonly IntPtr selUseParentNavigationBar = Selector.GetHandle ("useParentNavigationBar");
		static readonly IntPtr selSetUseParentNavigationBar_ = Selector.GetHandle ("setUseParentNavigationBar:");
		static readonly IntPtr selLinkAction = Selector.GetHandle ("linkAction");
		static readonly IntPtr selSetLinkAction_ = Selector.GetHandle ("setLinkAction:");
		static readonly IntPtr selCloseButtonItem = Selector.GetHandle ("closeButtonItem");
		static readonly IntPtr selOutlineButtonItem = Selector.GetHandle ("outlineButtonItem");
		static readonly IntPtr selSearchButtonItem = Selector.GetHandle ("searchButtonItem");
		static readonly IntPtr selViewModeButtonItem = Selector.GetHandle ("viewModeButtonItem");
		static readonly IntPtr selPrintButtonItem = Selector.GetHandle ("printButtonItem");
		static readonly IntPtr selOpenInButtonItem = Selector.GetHandle ("openInButtonItem");
		static readonly IntPtr selEmailButtonItem = Selector.GetHandle ("emailButtonItem");
		static readonly IntPtr selAnnotationButtonItem = Selector.GetHandle ("annotationButtonItem");
		static readonly IntPtr selBookmarkButtonItem = Selector.GetHandle ("bookmarkButtonItem");
		static readonly IntPtr selLeftBarButtonItems = Selector.GetHandle ("leftBarButtonItems");
		static readonly IntPtr selSetLeftBarButtonItems_ = Selector.GetHandle ("setLeftBarButtonItems:");
		static readonly IntPtr selRightBarButtonItems = Selector.GetHandle ("rightBarButtonItems");
		static readonly IntPtr selSetRightBarButtonItems_ = Selector.GetHandle ("setRightBarButtonItems:");
		static readonly IntPtr selAdditionalRightBarButtonItems = Selector.GetHandle ("additionalRightBarButtonItems");
		static readonly IntPtr selSetAdditionalRightBarButtonItems_ = Selector.GetHandle ("setAdditionalRightBarButtonItems:");
		static readonly IntPtr selBarButtonItemsAlwaysEnabled = Selector.GetHandle ("barButtonItemsAlwaysEnabled");
		static readonly IntPtr selSetBarButtonItemsAlwaysEnabled_ = Selector.GetHandle ("setBarButtonItemsAlwaysEnabled:");
		static readonly IntPtr selMinLeftToolbarWidth = Selector.GetHandle ("minLeftToolbarWidth");
		static readonly IntPtr selSetMinLeftToolbarWidth_ = Selector.GetHandle ("setMinLeftToolbarWidth:");
		static readonly IntPtr selMinRightToolbarWidth = Selector.GetHandle ("minRightToolbarWidth");
		static readonly IntPtr selSetMinRightToolbarWidth_ = Selector.GetHandle ("setMinRightToolbarWidth:");
		static readonly IntPtr selPageMode = Selector.GetHandle ("pageMode");
		static readonly IntPtr selSetPageMode_ = Selector.GetHandle ("setPageMode:");
		static readonly IntPtr selPageTransition = Selector.GetHandle ("pageTransition");
		static readonly IntPtr selSetPageTransition_ = Selector.GetHandle ("setPageTransition:");
		static readonly IntPtr selPageScrolling = Selector.GetHandle ("pageScrolling");
		static readonly IntPtr selSetPageScrolling_ = Selector.GetHandle ("setPageScrolling:");
		static readonly IntPtr selIsDoublePageModeOnFirstPage = Selector.GetHandle ("isDoublePageModeOnFirstPage");
		static readonly IntPtr selSetDoublePageModeOnFirstPage_ = Selector.GetHandle ("setDoublePageModeOnFirstPage:");
		static readonly IntPtr selIsZoomingSmallDocumentsEnabled = Selector.GetHandle ("isZoomingSmallDocumentsEnabled");
		static readonly IntPtr selSetZoomingSmallDocumentsEnabled_ = Selector.GetHandle ("setZoomingSmallDocumentsEnabled:");
		static readonly IntPtr selIsPageCurlDirectionLeftToRight = Selector.GetHandle ("isPageCurlDirectionLeftToRight");
		static readonly IntPtr selSetPageCurlDirectionLeftToRight_ = Selector.GetHandle ("setPageCurlDirectionLeftToRight:");
		static readonly IntPtr selIsFitToWidthEnabled = Selector.GetHandle ("isFitToWidthEnabled");
		static readonly IntPtr selSetFitToWidthEnabled_ = Selector.GetHandle ("setFitToWidthEnabled:");
		static readonly IntPtr selFixedVerticalPositionForfitToWidthEnabledMode = Selector.GetHandle ("fixedVerticalPositionForfitToWidthEnabledMode");
		static readonly IntPtr selSetFixedVerticalPositionForfitToWidthEnabledMode_ = Selector.GetHandle ("setFixedVerticalPositionForfitToWidthEnabledMode:");
		static readonly IntPtr selClipToPageBoundaries = Selector.GetHandle ("clipToPageBoundaries");
		static readonly IntPtr selSetClipToPageBoundaries_ = Selector.GetHandle ("setClipToPageBoundaries:");
		static readonly IntPtr selMaximumZoomScale = Selector.GetHandle ("maximumZoomScale");
		static readonly IntPtr selSetMaximumZoomScale_ = Selector.GetHandle ("setMaximumZoomScale:");
		static readonly IntPtr selPagePadding = Selector.GetHandle ("pagePadding");
		static readonly IntPtr selSetPagePadding_ = Selector.GetHandle ("setPagePadding:");
		static readonly IntPtr selIsShadowEnabled = Selector.GetHandle ("isShadowEnabled");
		static readonly IntPtr selSetShadowEnabled_ = Selector.GetHandle ("setShadowEnabled:");
		static readonly IntPtr selStatusBarStyleSetting = Selector.GetHandle ("statusBarStyleSetting");
		static readonly IntPtr selSetStatusBarStyleSetting_ = Selector.GetHandle ("setStatusBarStyleSetting:");
		static readonly IntPtr selBackgroundColor = Selector.GetHandle ("backgroundColor");
		static readonly IntPtr selSetBackgroundColor_ = Selector.GetHandle ("setBackgroundColor:");
		static readonly IntPtr selTintColor = Selector.GetHandle ("tintColor");
		static readonly IntPtr selSetTintColor_ = Selector.GetHandle ("setTintColor:");
		static readonly IntPtr selIsNavigationBarHidden = Selector.GetHandle ("isNavigationBarHidden");
		static readonly IntPtr selAnnotationAnimationDuration = Selector.GetHandle ("annotationAnimationDuration");
		static readonly IntPtr selSetAnnotationAnimationDuration_ = Selector.GetHandle ("setAnnotationAnimationDuration:");
		static readonly IntPtr selPopoverController = Selector.GetHandle ("popoverController");
		static readonly IntPtr selSetPopoverController_ = Selector.GetHandle ("setPopoverController:");
		static readonly IntPtr selPagingScrollView = Selector.GetHandle ("pagingScrollView");
		static readonly IntPtr selViewMode = Selector.GetHandle ("viewMode");
		static readonly IntPtr selSetViewMode_ = Selector.GetHandle ("setViewMode:");
		static readonly IntPtr selGridView = Selector.GetHandle ("gridView");
		static readonly IntPtr selThumbnailSize = Selector.GetHandle ("thumbnailSize");
		static readonly IntPtr selSetThumbnailSize_ = Selector.GetHandle ("setThumbnailSize:");
		static readonly IntPtr selIPhoneThumbnailSizeReductionFactor = Selector.GetHandle ("iPhoneThumbnailSizeReductionFactor");
		static readonly IntPtr selSetIPhoneThumbnailSizeReductionFactor_ = Selector.GetHandle ("setIPhoneThumbnailSizeReductionFactor:");
		static readonly IntPtr selVisiblePageNumbers = Selector.GetHandle ("visiblePageNumbers");
		static readonly IntPtr selIsLastPage = Selector.GetHandle ("isLastPage");
		static readonly IntPtr selIsFirstPage = Selector.GetHandle ("isFirstPage");
		static readonly IntPtr selOverrideClassNames = Selector.GetHandle ("overrideClassNames");
		static readonly IntPtr selSetOverrideClassNames_ = Selector.GetHandle ("setOverrideClassNames:");
		static readonly IntPtr selPageTransitionController = Selector.GetHandle ("pageTransitionController");
		static readonly IntPtr selInitWithDocument_ = Selector.GetHandle ("initWithDocument:");
		static readonly IntPtr selSetPageAnimated_ = Selector.GetHandle ("setPage:animated:");
		static readonly IntPtr selScrollToNextPageAnimated_ = Selector.GetHandle ("scrollToNextPageAnimated:");
		static readonly IntPtr selScrollToPreviousPageAnimated_ = Selector.GetHandle ("scrollToPreviousPageAnimated:");
		static readonly IntPtr selScrollRectToVisibleAnimated_ = Selector.GetHandle ("scrollRectToVisible:animated:");
		static readonly IntPtr selZoomToRectAnimated_ = Selector.GetHandle ("zoomToRect:animated:");
		static readonly IntPtr selSetViewStateAnimated_ = Selector.GetHandle ("setViewState:animated:");
		static readonly IntPtr selReloadData = Selector.GetHandle ("reloadData");
		static readonly IntPtr selSearchForStringAnimated_ = Selector.GetHandle ("searchForString:animated:");
		static readonly IntPtr selSetHUDVisibleAnimated_ = Selector.GetHandle ("setHUDVisible:animated:");
		static readonly IntPtr selShowControls = Selector.GetHandle ("showControls");
		static readonly IntPtr selHideControls = Selector.GetHandle ("hideControls");
		static readonly IntPtr selHideControlsAndPageElements = Selector.GetHandle ("hideControlsAndPageElements");
		static readonly IntPtr selToggleControls = Selector.GetHandle ("toggleControls");
		static readonly IntPtr selPageViewForPage_ = Selector.GetHandle ("pageViewForPage:");
		static readonly IntPtr selSetViewModeAnimated_ = Selector.GetHandle ("setViewMode:animated:");
		static readonly IntPtr selIsDoublePageMode = Selector.GetHandle ("isDoublePageMode");
		static readonly IntPtr selIsDoublePageModeForOrientation_ = Selector.GetHandle ("isDoublePageModeForOrientation:");
		static readonly IntPtr selIsDoublePageModeForPage_ = Selector.GetHandle ("isDoublePageModeForPage:");
		static readonly IntPtr selIsRightPageInDoublePageMode_ = Selector.GetHandle ("isRightPageInDoublePageMode:");
		static readonly IntPtr selPresentModalViewControllerEmbeddedInNavigationControllerWithCloseButtonAnimated_ = Selector.GetHandle ("presentModalViewController:embeddedInNavigationController:withCloseButton:animated:");
		static readonly IntPtr selMasterViewController_ = Selector.GetHandle ("masterViewController:");
		static readonly IntPtr selCreateToolbarAnimated_ = Selector.GetHandle ("createToolbarAnimated:");
		static readonly IntPtr selUpdateToolbarAnimated_ = Selector.GetHandle ("updateToolbarAnimated:");
		static readonly IntPtr selUpdateBarButtonItemAnimated_ = Selector.GetHandle ("updateBarButtonItem:animated:");
		static readonly IntPtr selUpdateGridForOrientation = Selector.GetHandle ("updateGridForOrientation");
		static readonly IntPtr selStatusBarStyle = Selector.GetHandle ("statusBarStyle");
		static readonly IntPtr selClearHighlightedSearchResults = Selector.GetHandle ("clearHighlightedSearchResults");
		static readonly IntPtr selAddHighlightSearchResults_ = Selector.GetHandle ("addHighlightSearchResults:");
		static readonly IntPtr selAnimateSearchHighlight_ = Selector.GetHandle ("animateSearchHighlight:");
		static readonly IntPtr selContentRect = Selector.GetHandle ("contentRect");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFViewController () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFViewController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFViewController (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFViewController (IntPtr handle) : base (handle) {}

		[Export ("initWithDocument:")]
		[CompilerGenerated]
		public PSPDFViewController (PSPDFDocument document) : base (NSObjectFlag.Empty)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithDocument_, document.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithDocument_, document.Handle);
			}
		}
		
		[Export ("setPage:animated:")]
		[CompilerGenerated]
		public virtual bool SetPageAnimated (System.UInt32 page, bool animated)
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend_UInt32_bool (this.Handle, selSetPageAnimated_, page, animated);
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper_UInt32_bool (this.SuperHandle, selSetPageAnimated_, page, animated);
			}
		}
		
		[Export ("scrollToNextPageAnimated:")]
		[CompilerGenerated]
		public virtual bool ScrollToNextPageAnimated (bool animated)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_bool (this.Handle, selScrollToNextPageAnimated_, animated);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_bool (this.SuperHandle, selScrollToNextPageAnimated_, animated);
			}
		}
		
		[Export ("scrollToPreviousPageAnimated:")]
		[CompilerGenerated]
		public virtual bool ScrollToPreviousPageAnimated (bool animated)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_bool (this.Handle, selScrollToPreviousPageAnimated_, animated);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_bool (this.SuperHandle, selScrollToPreviousPageAnimated_, animated);
			}
		}
		
		[Export ("scrollRectToVisible:animated:")]
		[CompilerGenerated]
		public virtual void ScrollRectToVisibleAnimated (System.Drawing.RectangleF rec, bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_RectangleF_bool (this.Handle, selScrollRectToVisibleAnimated_, rec, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_RectangleF_bool (this.SuperHandle, selScrollRectToVisibleAnimated_, rec, animated);
			}
		}
		
		[Export ("zoomToRect:animated:")]
		[CompilerGenerated]
		public virtual void ZoomToRectAnimated (System.Drawing.RectangleF rec, bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_RectangleF_bool (this.Handle, selZoomToRectAnimated_, rec, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_RectangleF_bool (this.SuperHandle, selZoomToRectAnimated_, rec, animated);
			}
		}
		
		[Export ("setViewState:animated:")]
		[CompilerGenerated]
		public virtual void SetViewStateAnimated (PSPDFViewState viewState, bool animated)
		{
			if (viewState == null)
				throw new ArgumentNullException ("viewState");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selSetViewStateAnimated_, viewState.Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selSetViewStateAnimated_, viewState.Handle, animated);
			}
		}
		
		[Export ("reloadData")]
		[CompilerGenerated]
		public virtual void ReloadData ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selReloadData);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selReloadData);
			}
		}
		
		[Export ("searchForString:animated:")]
		[CompilerGenerated]
		public virtual void SearchForStringAnimated (string searchText, bool animated)
		{
			if (searchText == null)
				throw new ArgumentNullException ("searchText");
			var nssearchText = NSString.CreateNative (searchText);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selSearchForStringAnimated_, nssearchText, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selSearchForStringAnimated_, nssearchText, animated);
			}
			NSString.ReleaseNative (nssearchText);
			
		}
		
		[Export ("setHUDVisible:animated:")]
		[CompilerGenerated]
		public virtual void SetHUDVisibleAnimated (bool show, bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool_bool (this.Handle, selSetHUDVisibleAnimated_, show, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_bool (this.SuperHandle, selSetHUDVisibleAnimated_, show, animated);
			}
		}
		
		[Export ("showControls")]
		[CompilerGenerated]
		public virtual void ShowControls ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selShowControls);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selShowControls);
			}
		}
		
		[Export ("hideControls")]
		[CompilerGenerated]
		public virtual void HideControls ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selHideControls);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selHideControls);
			}
		}
		
		[Export ("hideControlsAndPageElements")]
		[CompilerGenerated]
		public virtual void HideControlsAndPageElements ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selHideControlsAndPageElements);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selHideControlsAndPageElements);
			}
		}
		
		[Export ("toggleControls")]
		[CompilerGenerated]
		public virtual void ToggleControls ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selToggleControls);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selToggleControls);
			}
		}
		
		[Export ("pageViewForPage:")]
		[CompilerGenerated]
		public virtual PSPDFPageView PageViewForPage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				return (PSPDFPageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selPageViewForPage_, page));
			} else {
				return (PSPDFPageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selPageViewForPage_, page));
			}
		}
		
		[Export ("setViewMode:animated:")]
		[CompilerGenerated]
		public virtual void setViewModeAnimated (PSPDFViewMode viewMode, bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int_bool (this.Handle, selSetViewModeAnimated_, (int)viewMode, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int_bool (this.SuperHandle, selSetViewModeAnimated_, (int)viewMode, animated);
			}
		}
		
		[Export ("isDoublePageMode")]
		[CompilerGenerated]
		public virtual bool IsDoublePageMode ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDoublePageMode);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsDoublePageMode);
			}
		}
		
		[Export ("isDoublePageModeForOrientation:")]
		[CompilerGenerated]
		public virtual bool IsDoublePageModeForOrientation (MonoTouch.UIKit.UIInterfaceOrientation interfaceOrientation)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_int (this.Handle, selIsDoublePageModeForOrientation_, (int)interfaceOrientation);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_int (this.SuperHandle, selIsDoublePageModeForOrientation_, (int)interfaceOrientation);
			}
		}
		
		[Export ("isDoublePageModeForPage:")]
		[CompilerGenerated]
		public virtual bool IsDoublePageModeForPage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_UInt32 (this.Handle, selIsDoublePageModeForPage_, page);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_UInt32 (this.SuperHandle, selIsDoublePageModeForPage_, page);
			}
		}
		
		[Export ("isRightPageInDoublePageMode:")]
		[CompilerGenerated]
		public virtual bool IsRightPageInDoublePageMode (System.UInt32 page)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_UInt32 (this.Handle, selIsRightPageInDoublePageMode_, page);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_UInt32 (this.SuperHandle, selIsRightPageInDoublePageMode_, page);
			}
		}
		
		[Export ("presentModalViewController:embeddedInNavigationController:withCloseButton:animated:")]
		[CompilerGenerated]
		public virtual void PresentModalViewController (MonoTouch.UIKit.UIViewController controller, bool embedded, bool closeButton, bool animated)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool_bool_bool (this.Handle, selPresentModalViewControllerEmbeddedInNavigationControllerWithCloseButtonAnimated_, controller.Handle, embedded, closeButton, animated);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool_bool_bool (this.SuperHandle, selPresentModalViewControllerEmbeddedInNavigationControllerWithCloseButtonAnimated_, controller.Handle, embedded, closeButton, animated);
			}
		}
		
		[Export ("masterViewController:")]
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIViewController MasterViewController ()
		{
			if (IsDirectBinding) {
				return (MonoTouch.UIKit.UIViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMasterViewController_));
			} else {
				return (MonoTouch.UIKit.UIViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMasterViewController_));
			}
		}
		
		[CompilerGenerated]
		public bool CreateToolbarAnimated (bool animated)
		{
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_bool (this.Handle, selCreateToolbarAnimated_, animated);
		}
		
		[CompilerGenerated]
		public bool UpdateToolbarAnimated (bool animated)
		{
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_bool (this.Handle, selUpdateToolbarAnimated_, animated);
		}
		
		[CompilerGenerated]
		public bool UpdateBarButtonItem (MonoTouch.UIKit.UIBarButtonItem barButtonItem, bool animated)
		{
			if (barButtonItem == null)
				throw new ArgumentNullException ("barButtonItem");
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_bool (this.Handle, selUpdateBarButtonItemAnimated_, barButtonItem.Handle, animated);
		}
		
		[CompilerGenerated]
		public void UpdateGridForOrientation (bool animated)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selUpdateGridForOrientation, animated);
		}
		
		[CompilerGenerated]
		public MonoTouch.UIKit.UIStatusBarStyle statusBarStyle ()
		{
			return (MonoTouch.UIKit.UIStatusBarStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selStatusBarStyle);
		}
		
		[CompilerGenerated]
		public void ClearHighlightedSearchResults ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selClearHighlightedSearchResults);
		}
		
		[CompilerGenerated]
		public void AddHighlightSearchResults (PSPDFSearchResult[] searchResults)
		{
			if (searchResults == null)
				throw new ArgumentNullException ("searchResults");
			var nsa_searchResults = NSArray.FromNSObjects (searchResults);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAddHighlightSearchResults_, nsa_searchResults.Handle);
			nsa_searchResults.Dispose ();
			
		}
		
		[CompilerGenerated]
		public void AnimateSearchHighlight (PSPDFSearchResult searchResult)
		{
			if (searchResult == null)
				throw new ArgumentNullException ("searchResult");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAnimateSearchHighlight_, searchResult.Handle);
		}
		
		[CompilerGenerated]
		public System.Drawing.RectangleF ContentRect ()
		{
			System.Drawing.RectangleF ret;
			MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret (out ret, this.Handle, selContentRect);
			return ret;
		}
		
		[CompilerGenerated]
		public virtual System.UInt32 Page {
			[Export ("page", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPage);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selPage);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual System.UInt32 RealPage {
			[Export ("realPage", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selRealPage);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selRealPage);
				}
			}
			
		}
		
		object __mt_ViewState_var;
		[CompilerGenerated]
		public virtual PSPDFViewState ViewState {
			[Export ("viewState")]
			get {
				PSPDFViewState ret;
				if (IsDirectBinding) {
					ret = (PSPDFViewState) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selViewState));
				} else {
					ret = (PSPDFViewState) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selViewState));
				}
				MarkDirty ();
				__mt_ViewState_var = ret;
				return ret;
			}
			
			[Export ("setViewState:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetViewState_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetViewState_, value.Handle);
				}
				MarkDirty ();
				__mt_ViewState_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual float RenderContentOpacity {
			[Export ("renderContentOpacity", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selRenderContentOpacity);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selRenderContentOpacity);
				}
			}
			
			[Export ("setRenderContentOpacity:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetRenderContentOpacity_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetRenderContentOpacity_, value);
				}
			}
		}
		
		object __mt_RenderBackgroundColor_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIColor RenderBackgroundColor {
			[Export ("renderBackgroundColor")]
			get {
				MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRenderBackgroundColor));
				} else {
					ret = (MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRenderBackgroundColor));
				}
				MarkDirty ();
				__mt_RenderBackgroundColor_var = ret;
				return ret;
			}
			
			[Export ("setRenderBackgroundColor:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRenderBackgroundColor_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRenderBackgroundColor_, value.Handle);
				}
				MarkDirty ();
				__mt_RenderBackgroundColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool RenderInvertEnabled {
			[Export ("renderInvertEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selRenderInvertEnabled);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selRenderInvertEnabled);
				}
			}
			
			[Export ("setRenderInvertEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetRenderInvertEnabled_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetRenderInvertEnabled_, value);
				}
			}
		}
		
		object __mt_HUDView_var;
		[CompilerGenerated]
		public virtual PSPDFHUDView HUDView {
			[Export ("HUDView")]
			get {
				PSPDFHUDView ret;
				if (IsDirectBinding) {
					ret = (PSPDFHUDView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selHUDView));
				} else {
					ret = (PSPDFHUDView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selHUDView));
				}
				MarkDirty ();
				__mt_HUDView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFHUDViewMode HUDViewMode {
			[Export ("HUDViewMode", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFHUDViewMode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selHUDViewMode);
				} else {
					return (PSPDFHUDViewMode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selHUDViewMode);
				}
			}
			
			[Export ("setHUDViewMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetHUDViewMode_, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetHUDViewMode_, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool HUDVisible {
			[Export ("isHUDVisible", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsHUDVisible);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsHUDVisible);
				}
			}
			
			[Export ("setHUDVisible:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHUDVisible_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetHUDVisible_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ToolbarEnabled {
			[Export ("isToolbarEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsToolbarEnabled);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsToolbarEnabled);
				}
			}
			
			[Export ("setToolbarEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetToolbarEnabled_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetToolbarEnabled_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ScrobbleBarEnabled {
			[Export ("isScrobbleBarEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsScrobbleBarEnabled);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsScrobbleBarEnabled);
				}
			}
			
			[Export ("setScrobbleBarEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetScrobbleBarEnabled_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetScrobbleBarEnabled_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool PositionViewEnabled {
			[Export ("isPositionViewEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPositionViewEnabled);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsPositionViewEnabled);
				}
			}
			
			[Export ("setPositionViewEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPositionViewEnabled_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetPositionViewEnabled_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool RenderAnimationEnabled {
			[Export ("isRenderAnimationEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsRenderAnimationEnabled);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsRenderAnimationEnabled);
				}
			}
			
			[Export ("setRenderAnimationEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetRenderAnimationEnabled_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetRenderAnimationEnabled_, value);
				}
			}
		}
		
		object __mt_ContentView_var;
		[CompilerGenerated]
		public virtual PSPDFHUDView ContentView {
			[Export ("contentView")]
			get {
				PSPDFHUDView ret;
				if (IsDirectBinding) {
					ret = (PSPDFHUDView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selContentView));
				} else {
					ret = (PSPDFHUDView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selContentView));
				}
				MarkDirty ();
				__mt_ContentView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public PSPDFViewControllerDelegate Delegate {
			get { return WeakDelegate as PSPDFViewControllerDelegate; }
			set { WeakDelegate = value; }
		}
		
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegate));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegate));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		object __mt_Document_var;
		[CompilerGenerated]
		public virtual PSPDFDocument Document {
			[Export ("document")]
			get {
				PSPDFDocument ret;
				if (IsDirectBinding) {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocument));
				} else {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocument));
				}
				MarkDirty ();
				__mt_Document_var = ret;
				return ret;
			}
			
			[Export ("setDocument:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDocument_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDocument_, value.Handle);
				}
				MarkDirty ();
				__mt_Document_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIEdgeInsets Margin {
			[Export ("margin", ArgumentSemantic.Assign)]
			get {
				MonoTouch.UIKit.UIEdgeInsets ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, selMargin);
				} else {
					MonoTouch.ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, selMargin);
				}
				return ret;
			}
			
			[Export ("setMargin:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, selSetMargin_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UIEdgeInsets (this.SuperHandle, selSetMargin_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual System.Drawing.SizeF Padding {
			[Export ("padding", ArgumentSemantic.Assign)]
			get {
				System.Drawing.SizeF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend_stret (out ret, this.Handle, selPadding);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend (this.Handle, selPadding);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selPadding);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper (this.SuperHandle, selPadding);
					}
				}
				return ret;
			}
			
			[Export ("setPadding:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_SizeF (this.Handle, selSetPadding_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_SizeF (this.SuperHandle, selSetPadding_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFPageRenderingMode RenderingMode {
			[Export ("renderingMode", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFPageRenderingMode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selRenderingMode);
				} else {
					return (PSPDFPageRenderingMode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selRenderingMode);
				}
			}
			
			[Export ("setRenderingMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetRenderingMode_, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetRenderingMode_, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool SmartZoomEnabled {
			[Export ("isSmartZoomEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSmartZoomEnabled);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsSmartZoomEnabled);
				}
			}
			
			[Export ("setSmartZoomEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSmartZoomEnabled_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetSmartZoomEnabled_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ScrollingEnabled {
			[Export ("isScrollingEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsScrollingEnabled);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsScrollingEnabled);
				}
			}
			
			[Export ("setScrollingEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetScrollingEnabled_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetScrollingEnabled_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ViewLockEnabled {
			[Export ("isViewLockEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsViewLockEnabled);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsViewLockEnabled);
				}
			}
			
			[Export ("setViewLockEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetViewLockEnabled_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetViewLockEnabled_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool RotationLockEnabled {
			[Export ("isRotationLockEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsRotationLockEnabled);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsRotationLockEnabled);
				}
			}
			
			[Export ("setRotationLockEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetRotationLockEnabled_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetRotationLockEnabled_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ScrollOnTapPageEndEnabled {
			[Export ("isScrollOnTapPageEndEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsScrollOnTapPageEndEnabled);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsScrollOnTapPageEndEnabled);
				}
			}
			
			[Export ("setScrollOnTapPageEndEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetScrollOnTapPageEndEnabled_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetScrollOnTapPageEndEnabled_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool TextSelectionEnabled {
			[Export ("isTextSelectionEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsTextSelectionEnabled);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsTextSelectionEnabled);
				}
			}
			
			[Export ("setTextSelectionEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetTextSelectionEnabled_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetTextSelectionEnabled_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool UseParentNavigationBar {
			[Export ("useParentNavigationBar", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUseParentNavigationBar);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selUseParentNavigationBar);
				}
			}
			
			[Export ("setUseParentNavigationBar:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUseParentNavigationBar_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetUseParentNavigationBar_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFLinkAction LinkAction {
			[Export ("linkAction", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFLinkAction) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selLinkAction);
				} else {
					return (PSPDFLinkAction) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selLinkAction);
				}
			}
			
			[Export ("setLinkAction:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetLinkAction_, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetLinkAction_, (int)value);
				}
			}
		}
		
		object __mt_CloseButtonItem_var;
		[CompilerGenerated]
		public virtual PSPDFBarButtonItem CloseButtonItem {
			[Export ("closeButtonItem")]
			get {
				PSPDFBarButtonItem ret;
				if (IsDirectBinding) {
					ret = (PSPDFBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCloseButtonItem));
				} else {
					ret = (PSPDFBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCloseButtonItem));
				}
				MarkDirty ();
				__mt_CloseButtonItem_var = ret;
				return ret;
			}
			
		}
		
		object __mt_OutlineButtonItem_var;
		[CompilerGenerated]
		public virtual PSPDFBarButtonItem OutlineButtonItem {
			[Export ("outlineButtonItem")]
			get {
				PSPDFBarButtonItem ret;
				if (IsDirectBinding) {
					ret = (PSPDFBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOutlineButtonItem));
				} else {
					ret = (PSPDFBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOutlineButtonItem));
				}
				MarkDirty ();
				__mt_OutlineButtonItem_var = ret;
				return ret;
			}
			
		}
		
		object __mt_searchButtonItem_var;
		[CompilerGenerated]
		public virtual PSPDFBarButtonItem searchButtonItem {
			[Export ("searchButtonItem")]
			get {
				PSPDFBarButtonItem ret;
				if (IsDirectBinding) {
					ret = (PSPDFBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSearchButtonItem));
				} else {
					ret = (PSPDFBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSearchButtonItem));
				}
				MarkDirty ();
				__mt_searchButtonItem_var = ret;
				return ret;
			}
			
		}
		
		object __mt_ViewModeButtonItem_var;
		[CompilerGenerated]
		public virtual PSPDFBarButtonItem ViewModeButtonItem {
			[Export ("viewModeButtonItem")]
			get {
				PSPDFBarButtonItem ret;
				if (IsDirectBinding) {
					ret = (PSPDFBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selViewModeButtonItem));
				} else {
					ret = (PSPDFBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selViewModeButtonItem));
				}
				MarkDirty ();
				__mt_ViewModeButtonItem_var = ret;
				return ret;
			}
			
		}
		
		object __mt_PrintButtonItem_var;
		[CompilerGenerated]
		public virtual PSPDFBarButtonItem PrintButtonItem {
			[Export ("printButtonItem")]
			get {
				PSPDFBarButtonItem ret;
				if (IsDirectBinding) {
					ret = (PSPDFBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPrintButtonItem));
				} else {
					ret = (PSPDFBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPrintButtonItem));
				}
				MarkDirty ();
				__mt_PrintButtonItem_var = ret;
				return ret;
			}
			
		}
		
		object __mt_OpenInButtonItem_var;
		[CompilerGenerated]
		public virtual PSPDFBarButtonItem OpenInButtonItem {
			[Export ("openInButtonItem")]
			get {
				PSPDFBarButtonItem ret;
				if (IsDirectBinding) {
					ret = (PSPDFBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOpenInButtonItem));
				} else {
					ret = (PSPDFBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOpenInButtonItem));
				}
				MarkDirty ();
				__mt_OpenInButtonItem_var = ret;
				return ret;
			}
			
		}
		
		object __mt_EmailButtonItem_var;
		[CompilerGenerated]
		public virtual PSPDFBarButtonItem EmailButtonItem {
			[Export ("emailButtonItem")]
			get {
				PSPDFBarButtonItem ret;
				if (IsDirectBinding) {
					ret = (PSPDFBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selEmailButtonItem));
				} else {
					ret = (PSPDFBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selEmailButtonItem));
				}
				MarkDirty ();
				__mt_EmailButtonItem_var = ret;
				return ret;
			}
			
		}
		
		object __mt_AnnotationButtonItem_var;
		[CompilerGenerated]
		public virtual PSPDFBarButtonItem AnnotationButtonItem {
			[Export ("annotationButtonItem")]
			get {
				PSPDFBarButtonItem ret;
				if (IsDirectBinding) {
					ret = (PSPDFBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAnnotationButtonItem));
				} else {
					ret = (PSPDFBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAnnotationButtonItem));
				}
				MarkDirty ();
				__mt_AnnotationButtonItem_var = ret;
				return ret;
			}
			
		}
		
		object __mt_BookmarkButtonItem_var;
		[CompilerGenerated]
		public virtual PSPDFBarButtonItem BookmarkButtonItem {
			[Export ("bookmarkButtonItem")]
			get {
				PSPDFBarButtonItem ret;
				if (IsDirectBinding) {
					ret = (PSPDFBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBookmarkButtonItem));
				} else {
					ret = (PSPDFBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBookmarkButtonItem));
				}
				MarkDirty ();
				__mt_BookmarkButtonItem_var = ret;
				return ret;
			}
			
		}
		
		object __mt_LeftBarButtonItems_var;
		[CompilerGenerated]
		public virtual PSPDFBarButtonItem[] LeftBarButtonItems {
			[Export ("leftBarButtonItems")]
			get {
				PSPDFBarButtonItem[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFBarButtonItem>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLeftBarButtonItems));
				} else {
					ret = NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFBarButtonItem>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLeftBarButtonItems));
				}
				MarkDirty ();
				__mt_LeftBarButtonItems_var = ret;
				return ret;
			}
			
			[Export ("setLeftBarButtonItems:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLeftBarButtonItems_, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLeftBarButtonItems_, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				MarkDirty ();
				__mt_LeftBarButtonItems_var = value;
			}
		}
		
		object __mt_RightBarButtonItems_var;
		[CompilerGenerated]
		public virtual PSPDFBarButtonItem[] RightBarButtonItems {
			[Export ("rightBarButtonItems")]
			get {
				PSPDFBarButtonItem[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFBarButtonItem>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRightBarButtonItems));
				} else {
					ret = NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFBarButtonItem>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRightBarButtonItems));
				}
				MarkDirty ();
				__mt_RightBarButtonItems_var = ret;
				return ret;
			}
			
			[Export ("setRightBarButtonItems:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRightBarButtonItems_, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRightBarButtonItems_, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				MarkDirty ();
				__mt_RightBarButtonItems_var = value;
			}
		}
		
		object __mt_AdditionalRightBarButtonItems_var;
		[CompilerGenerated]
		public virtual PSPDFBarButtonItem[] AdditionalRightBarButtonItems {
			[Export ("additionalRightBarButtonItems")]
			get {
				PSPDFBarButtonItem[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFBarButtonItem>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAdditionalRightBarButtonItems));
				} else {
					ret = NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFBarButtonItem>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAdditionalRightBarButtonItems));
				}
				MarkDirty ();
				__mt_AdditionalRightBarButtonItems_var = ret;
				return ret;
			}
			
			[Export ("setAdditionalRightBarButtonItems:")]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAdditionalRightBarButtonItems_, nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAdditionalRightBarButtonItems_, nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
				MarkDirty ();
				__mt_AdditionalRightBarButtonItems_var = value;
			}
		}
		
		object __mt_BarButtonItemsAlwaysEnabled_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIBarButtonItem[] BarButtonItemsAlwaysEnabled {
			[Export ("barButtonItemsAlwaysEnabled")]
			get {
				MonoTouch.UIKit.UIBarButtonItem[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.UIKit.UIBarButtonItem>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBarButtonItemsAlwaysEnabled));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.UIKit.UIBarButtonItem>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBarButtonItemsAlwaysEnabled));
				}
				MarkDirty ();
				__mt_BarButtonItemsAlwaysEnabled_var = ret;
				return ret;
			}
			
			[Export ("setBarButtonItemsAlwaysEnabled:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBarButtonItemsAlwaysEnabled_, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBarButtonItemsAlwaysEnabled_, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				MarkDirty ();
				__mt_BarButtonItemsAlwaysEnabled_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual float MinLeftToolbarWidth {
			[Export ("minLeftToolbarWidth", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMinLeftToolbarWidth);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selMinLeftToolbarWidth);
				}
			}
			
			[Export ("setMinLeftToolbarWidth:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMinLeftToolbarWidth_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetMinLeftToolbarWidth_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float MinRightToolbarWidth {
			[Export ("minRightToolbarWidth", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMinRightToolbarWidth);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selMinRightToolbarWidth);
				}
			}
			
			[Export ("setMinRightToolbarWidth:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMinRightToolbarWidth_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetMinRightToolbarWidth_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFPageMode PageMode {
			[Export ("pageMode", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFPageMode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selPageMode);
				} else {
					return (PSPDFPageMode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selPageMode);
				}
			}
			
			[Export ("setPageMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetPageMode_, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetPageMode_, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFPageTransition PageTransition {
			[Export ("pageTransition", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFPageTransition) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selPageTransition);
				} else {
					return (PSPDFPageTransition) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selPageTransition);
				}
			}
			
			[Export ("setPageTransition:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetPageTransition_, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetPageTransition_, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFScrollDirection PageScrolling {
			[Export ("pageScrolling", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFScrollDirection) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selPageScrolling);
				} else {
					return (PSPDFScrollDirection) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selPageScrolling);
				}
			}
			
			[Export ("setPageScrolling:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetPageScrolling_, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetPageScrolling_, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool DoublePageModeOnFirstPage {
			[Export ("isDoublePageModeOnFirstPage", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDoublePageModeOnFirstPage);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsDoublePageModeOnFirstPage);
				}
			}
			
			[Export ("setDoublePageModeOnFirstPage:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDoublePageModeOnFirstPage_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetDoublePageModeOnFirstPage_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ZoomingSmallDocumentsEnabled {
			[Export ("isZoomingSmallDocumentsEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsZoomingSmallDocumentsEnabled);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsZoomingSmallDocumentsEnabled);
				}
			}
			
			[Export ("setZoomingSmallDocumentsEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetZoomingSmallDocumentsEnabled_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetZoomingSmallDocumentsEnabled_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool PageCurlDirectionLeftToRight {
			[Export ("isPageCurlDirectionLeftToRight", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPageCurlDirectionLeftToRight);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsPageCurlDirectionLeftToRight);
				}
			}
			
			[Export ("setPageCurlDirectionLeftToRight:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPageCurlDirectionLeftToRight_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetPageCurlDirectionLeftToRight_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool FitToWidthEnabled {
			[Export ("isFitToWidthEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFitToWidthEnabled);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsFitToWidthEnabled);
				}
			}
			
			[Export ("setFitToWidthEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetFitToWidthEnabled_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetFitToWidthEnabled_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool FixedVerticalPositionForfitToWidthEnabledMode {
			[Export ("fixedVerticalPositionForfitToWidthEnabledMode", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selFixedVerticalPositionForfitToWidthEnabledMode);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selFixedVerticalPositionForfitToWidthEnabledMode);
				}
			}
			
			[Export ("setFixedVerticalPositionForfitToWidthEnabledMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetFixedVerticalPositionForfitToWidthEnabledMode_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetFixedVerticalPositionForfitToWidthEnabledMode_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ClipToPageBoundaries {
			[Export ("clipToPageBoundaries", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selClipToPageBoundaries);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selClipToPageBoundaries);
				}
			}
			
			[Export ("setClipToPageBoundaries:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetClipToPageBoundaries_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetClipToPageBoundaries_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float MaximumZoomScale {
			[Export ("maximumZoomScale", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMaximumZoomScale);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selMaximumZoomScale);
				}
			}
			
			[Export ("setMaximumZoomScale:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMaximumZoomScale_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetMaximumZoomScale_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float PagePadding {
			[Export ("pagePadding", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selPagePadding);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selPagePadding);
				}
			}
			
			[Export ("setPagePadding:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetPagePadding_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetPagePadding_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShadowEnabled {
			[Export ("isShadowEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsShadowEnabled);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsShadowEnabled);
				}
			}
			
			[Export ("setShadowEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShadowEnabled_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShadowEnabled_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFStatusBarStyleSetting StatusBarStyleSetting {
			[Export ("statusBarStyleSetting", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFStatusBarStyleSetting) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selStatusBarStyleSetting);
				} else {
					return (PSPDFStatusBarStyleSetting) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selStatusBarStyleSetting);
				}
			}
			
			[Export ("setStatusBarStyleSetting:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetStatusBarStyleSetting_, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetStatusBarStyleSetting_, (int)value);
				}
			}
		}
		
		object __mt_BackgroundColor_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIColor BackgroundColor {
			[Export ("backgroundColor")]
			get {
				MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBackgroundColor));
				} else {
					ret = (MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBackgroundColor));
				}
				MarkDirty ();
				__mt_BackgroundColor_var = ret;
				return ret;
			}
			
			[Export ("setBackgroundColor:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBackgroundColor_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBackgroundColor_, value.Handle);
				}
				MarkDirty ();
				__mt_BackgroundColor_var = value;
			}
		}
		
		object __mt_TintColor_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIColor TintColor {
			[Export ("tintColor")]
			get {
				MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTintColor));
				} else {
					ret = (MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTintColor));
				}
				MarkDirty ();
				__mt_TintColor_var = ret;
				return ret;
			}
			
			[Export ("setTintColor:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTintColor_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTintColor_, value.Handle);
				}
				MarkDirty ();
				__mt_TintColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool NavigationBarHidden {
			[Export ("isNavigationBarHidden", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsNavigationBarHidden);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsNavigationBarHidden);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual float AnnotationAnimationDuration {
			[Export ("annotationAnimationDuration", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selAnnotationAnimationDuration);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selAnnotationAnimationDuration);
				}
			}
			
			[Export ("setAnnotationAnimationDuration:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetAnnotationAnimationDuration_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetAnnotationAnimationDuration_, value);
				}
			}
		}
		
		object __mt_PopoverController_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIPopoverController PopoverController {
			[Export ("popoverController")]
			get {
				MonoTouch.UIKit.UIPopoverController ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIPopoverController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPopoverController));
				} else {
					ret = (MonoTouch.UIKit.UIPopoverController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPopoverController));
				}
				MarkDirty ();
				__mt_PopoverController_var = ret;
				return ret;
			}
			
			[Export ("setPopoverController:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPopoverController_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPopoverController_, value.Handle);
				}
				MarkDirty ();
				__mt_PopoverController_var = value;
			}
		}
		
		object __mt_PagingScrollView_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIScrollView PagingScrollView {
			[Export ("pagingScrollView")]
			get {
				MonoTouch.UIKit.UIScrollView ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIScrollView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPagingScrollView));
				} else {
					ret = (MonoTouch.UIKit.UIScrollView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPagingScrollView));
				}
				MarkDirty ();
				__mt_PagingScrollView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFViewMode ViewMode {
			[Export ("viewMode", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFViewMode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selViewMode);
				} else {
					return (PSPDFViewMode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selViewMode);
				}
			}
			
			[Export ("setViewMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetViewMode_, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetViewMode_, (int)value);
				}
			}
		}
		
		object __mt_GridView_var;
		[CompilerGenerated]
		public virtual PSCollectionView GridView {
			[Export ("gridView")]
			get {
				PSCollectionView ret;
				if (IsDirectBinding) {
					ret = (PSCollectionView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selGridView));
				} else {
					ret = (PSCollectionView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selGridView));
				}
				MarkDirty ();
				__mt_GridView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual System.Drawing.SizeF ThumbnailSize {
			[Export ("thumbnailSize", ArgumentSemantic.Assign)]
			get {
				System.Drawing.SizeF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend_stret (out ret, this.Handle, selThumbnailSize);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend (this.Handle, selThumbnailSize);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selThumbnailSize);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper (this.SuperHandle, selThumbnailSize);
					}
				}
				return ret;
			}
			
			[Export ("setThumbnailSize:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_SizeF (this.Handle, selSetThumbnailSize_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_SizeF (this.SuperHandle, selSetThumbnailSize_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float IPhoneThumbnailSizeReductionFactor {
			[Export ("iPhoneThumbnailSizeReductionFactor", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selIPhoneThumbnailSizeReductionFactor);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selIPhoneThumbnailSizeReductionFactor);
				}
			}
			
			[Export ("setIPhoneThumbnailSizeReductionFactor:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetIPhoneThumbnailSizeReductionFactor_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetIPhoneThumbnailSizeReductionFactor_, value);
				}
			}
		}
		
		object __mt_VisiblePageNumbers_var;
		[CompilerGenerated]
		public virtual NSNumber[] VisiblePageNumbers {
			[Export ("visiblePageNumbers")]
			get {
				NSNumber[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSNumber>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selVisiblePageNumbers));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSNumber>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selVisiblePageNumbers));
				}
				MarkDirty ();
				__mt_VisiblePageNumbers_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsLastPage {
			[Export ("isLastPage")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsLastPage);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsLastPage);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsFirstPage {
			[Export ("isFirstPage")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFirstPage);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsFirstPage);
				}
			}
			
		}
		
		object __mt_OverrideClassNames_var;
		[CompilerGenerated]
		public virtual NSDictionary OverrideClassNames {
			[Export ("overrideClassNames")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOverrideClassNames));
				} else {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOverrideClassNames));
				}
				MarkDirty ();
				__mt_OverrideClassNames_var = ret;
				return ret;
			}
			
			[Export ("setOverrideClassNames:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetOverrideClassNames_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetOverrideClassNames_, value.Handle);
				}
				MarkDirty ();
				__mt_OverrideClassNames_var = value;
			}
		}
		
		object __mt_PageTransitionController_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIViewController PageTransitionController {
			[Export ("pageTransitionController")]
			get {
				MonoTouch.UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPageTransitionController));
				} else {
					ret = (MonoTouch.UIKit.UIViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPageTransitionController));
				}
				MarkDirty ();
				__mt_PageTransitionController_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_ViewState_var = null;
			__mt_RenderBackgroundColor_var = null;
			__mt_HUDView_var = null;
			__mt_ContentView_var = null;
			__mt_WeakDelegate_var = null;
			__mt_Document_var = null;
			__mt_CloseButtonItem_var = null;
			__mt_OutlineButtonItem_var = null;
			__mt_searchButtonItem_var = null;
			__mt_ViewModeButtonItem_var = null;
			__mt_PrintButtonItem_var = null;
			__mt_OpenInButtonItem_var = null;
			__mt_EmailButtonItem_var = null;
			__mt_AnnotationButtonItem_var = null;
			__mt_BookmarkButtonItem_var = null;
			__mt_LeftBarButtonItems_var = null;
			__mt_RightBarButtonItems_var = null;
			__mt_AdditionalRightBarButtonItems_var = null;
			__mt_BarButtonItemsAlwaysEnabled_var = null;
			__mt_BackgroundColor_var = null;
			__mt_TintColor_var = null;
			__mt_PopoverController_var = null;
			__mt_PagingScrollView_var = null;
			__mt_GridView_var = null;
			__mt_VisiblePageNumbers_var = null;
			__mt_OverrideClassNames_var = null;
			__mt_PageTransitionController_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFViewController */
}
