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
using MonoTouch.CoreVideo;
using OpenTK;

namespace KS_PSPDFKitBindings {
	[Register("PSPDFScrollView", true)]
	public unsafe partial class PSPDFScrollView : PSPDFKeyboardAvoidingScrollView {
		[CompilerGenerated]
		const string selPage = "page";
		static readonly IntPtr selPageHandle = Selector.GetHandle ("page");
		[CompilerGenerated]
		const string selSetPage_ = "setPage:";
		static readonly IntPtr selSetPage_Handle = Selector.GetHandle ("setPage:");
		[CompilerGenerated]
		const string selDocument = "document";
		static readonly IntPtr selDocumentHandle = Selector.GetHandle ("document");
		[CompilerGenerated]
		const string selPdfController = "pdfController";
		static readonly IntPtr selPdfControllerHandle = Selector.GetHandle ("pdfController");
		[CompilerGenerated]
		const string selSetPdfController_ = "setPdfController:";
		static readonly IntPtr selSetPdfController_Handle = Selector.GetHandle ("setPdfController:");
		[CompilerGenerated]
		const string selLeftPage = "leftPage";
		static readonly IntPtr selLeftPageHandle = Selector.GetHandle ("leftPage");
		[CompilerGenerated]
		const string selRightPage = "rightPage";
		static readonly IntPtr selRightPageHandle = Selector.GetHandle ("rightPage");
		[CompilerGenerated]
		const string selShadowStyle = "shadowStyle";
		static readonly IntPtr selShadowStyleHandle = Selector.GetHandle ("shadowStyle");
		[CompilerGenerated]
		const string selSetShadowStyle_ = "setShadowStyle:";
		static readonly IntPtr selSetShadowStyle_Handle = Selector.GetHandle ("setShadowStyle:");
		[CompilerGenerated]
		const string selIsZoomingEnabled = "isZoomingEnabled";
		static readonly IntPtr selIsZoomingEnabledHandle = Selector.GetHandle ("isZoomingEnabled");
		[CompilerGenerated]
		const string selSetZoomingEnabled_ = "setZoomingEnabled:";
		static readonly IntPtr selSetZoomingEnabled_Handle = Selector.GetHandle ("setZoomingEnabled:");
		[CompilerGenerated]
		const string selIsDoublePageMode = "isDoublePageMode";
		static readonly IntPtr selIsDoublePageModeHandle = Selector.GetHandle ("isDoublePageMode");
		[CompilerGenerated]
		const string selSetDoublePageMode_ = "setDoublePageMode:";
		static readonly IntPtr selSetDoublePageMode_Handle = Selector.GetHandle ("setDoublePageMode:");
		[CompilerGenerated]
		const string selIsDoublePageModeOnFirstPage = "isDoublePageModeOnFirstPage";
		static readonly IntPtr selIsDoublePageModeOnFirstPageHandle = Selector.GetHandle ("isDoublePageModeOnFirstPage");
		[CompilerGenerated]
		const string selSetDoublePageModeOnFirstPage_ = "setDoublePageModeOnFirstPage:";
		static readonly IntPtr selSetDoublePageModeOnFirstPage_Handle = Selector.GetHandle ("setDoublePageModeOnFirstPage:");
		[CompilerGenerated]
		const string selIsZoomingSmallDocumentsEnabled = "isZoomingSmallDocumentsEnabled";
		static readonly IntPtr selIsZoomingSmallDocumentsEnabledHandle = Selector.GetHandle ("isZoomingSmallDocumentsEnabled");
		[CompilerGenerated]
		const string selSetZoomingSmallDocumentsEnabled_ = "setZoomingSmallDocumentsEnabled:";
		static readonly IntPtr selSetZoomingSmallDocumentsEnabled_Handle = Selector.GetHandle ("setZoomingSmallDocumentsEnabled:");
		[CompilerGenerated]
		const string selIsFitToWidthEnabled = "isFitToWidthEnabled";
		static readonly IntPtr selIsFitToWidthEnabledHandle = Selector.GetHandle ("isFitToWidthEnabled");
		[CompilerGenerated]
		const string selSetFitToWidthEnabled_ = "setFitToWidthEnabled:";
		static readonly IntPtr selSetFitToWidthEnabled_Handle = Selector.GetHandle ("setFitToWidthEnabled:");
		[CompilerGenerated]
		const string selIsShadowEnabled = "isShadowEnabled";
		static readonly IntPtr selIsShadowEnabledHandle = Selector.GetHandle ("isShadowEnabled");
		[CompilerGenerated]
		const string selSetShadowEnabled_ = "setShadowEnabled:";
		static readonly IntPtr selSetShadowEnabled_Handle = Selector.GetHandle ("setShadowEnabled:");
		[CompilerGenerated]
		const string selIsScrollOnTapPageEndEnabled = "isScrollOnTapPageEndEnabled";
		static readonly IntPtr selIsScrollOnTapPageEndEnabledHandle = Selector.GetHandle ("isScrollOnTapPageEndEnabled");
		[CompilerGenerated]
		const string selSetScrollOnTapPageEndEnabled_ = "setScrollOnTapPageEndEnabled:";
		static readonly IntPtr selSetScrollOnTapPageEndEnabled_Handle = Selector.GetHandle ("setScrollOnTapPageEndEnabled:");
		[CompilerGenerated]
		const string selSingleTapGesture = "singleTapGesture";
		static readonly IntPtr selSingleTapGestureHandle = Selector.GetHandle ("singleTapGesture");
		[CompilerGenerated]
		const string selDoubleTapGesture = "doubleTapGesture";
		static readonly IntPtr selDoubleTapGestureHandle = Selector.GetHandle ("doubleTapGesture");
		[CompilerGenerated]
		const string selLongPressGesture = "longPressGesture";
		static readonly IntPtr selLongPressGestureHandle = Selector.GetHandle ("longPressGesture");
		[CompilerGenerated]
		const string selCreateDoubleTapGesture = "createDoubleTapGesture";
		static readonly IntPtr selCreateDoubleTapGestureHandle = Selector.GetHandle ("createDoubleTapGesture");
		[CompilerGenerated]
		const string selCompoundView = "compoundView";
		static readonly IntPtr selCompoundViewHandle = Selector.GetHandle ("compoundView");
		[CompilerGenerated]
		const string selLoupeView = "loupeView";
		static readonly IntPtr selLoupeViewHandle = Selector.GetHandle ("loupeView");
		[CompilerGenerated]
		const string selIsRotationActive = "isRotationActive";
		static readonly IntPtr selIsRotationActiveHandle = Selector.GetHandle ("isRotationActive");
		[CompilerGenerated]
		const string selSetRotationActive_ = "setRotationActive:";
		static readonly IntPtr selSetRotationActive_Handle = Selector.GetHandle ("setRotationActive:");
		[CompilerGenerated]
		const string selIsAnimatingZoomIn = "isAnimatingZoomIn";
		static readonly IntPtr selIsAnimatingZoomInHandle = Selector.GetHandle ("isAnimatingZoomIn");
		[CompilerGenerated]
		const string selInitWithFrame_ = "initWithFrame:";
		static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle ("initWithFrame:");
		[CompilerGenerated]
		const string selDisplayDocumentWithPage_ = "displayDocument:withPage:";
		static readonly IntPtr selDisplayDocumentWithPage_Handle = Selector.GetHandle ("displayDocument:withPage:");
		[CompilerGenerated]
		const string selReleaseDocument = "releaseDocument";
		static readonly IntPtr selReleaseDocumentHandle = Selector.GetHandle ("releaseDocument");
		[CompilerGenerated]
		const string selSingleTapped_ = "singleTapped:";
		static readonly IntPtr selSingleTapped_Handle = Selector.GetHandle ("singleTapped:");
		[CompilerGenerated]
		const string selDoubleTapped_ = "doubleTapped:";
		static readonly IntPtr selDoubleTapped_Handle = Selector.GetHandle ("doubleTapped:");
		[CompilerGenerated]
		const string selLongPress_ = "longPress:";
		static readonly IntPtr selLongPress_Handle = Selector.GetHandle ("longPress:");
		[CompilerGenerated]
		const string selPathShadowForView_ = "pathShadowForView:";
		static readonly IntPtr selPathShadowForView_Handle = Selector.GetHandle ("pathShadowForView:");
		[CompilerGenerated]
		const string selSwitchPages = "switchPages";
		static readonly IntPtr selSwitchPagesHandle = Selector.GetHandle ("switchPages");
		[CompilerGenerated]
		const string selEnsureContentIsCentered = "ensureContentIsCentered";
		static readonly IntPtr selEnsureContentIsCenteredHandle = Selector.GetHandle ("ensureContentIsCentered");
		[CompilerGenerated]
		const string selPageViewForPoint_ = "pageViewForPoint:";
		static readonly IntPtr selPageViewForPoint_Handle = Selector.GetHandle ("pageViewForPoint:");
		[CompilerGenerated]
		const string selScrollViewDidScroll_ = "scrollViewDidScroll:";
		static readonly IntPtr selScrollViewDidScroll_Handle = Selector.GetHandle ("scrollViewDidScroll:");
		[CompilerGenerated]
		const string selScrollViewDidZoom_ = "scrollViewDidZoom:";
		static readonly IntPtr selScrollViewDidZoom_Handle = Selector.GetHandle ("scrollViewDidZoom:");
		[CompilerGenerated]
		const string selScrollViewWillBeginDragging_ = "scrollViewWillBeginDragging:";
		static readonly IntPtr selScrollViewWillBeginDragging_Handle = Selector.GetHandle ("scrollViewWillBeginDragging:");
		[CompilerGenerated]
		const string selScrollViewWillEndDraggingWithVelocityTargetContentOffset_ = "scrollViewWillEndDragging:withVelocity:targetContentOffset:";
		static readonly IntPtr selScrollViewWillEndDraggingWithVelocityTargetContentOffset_Handle = Selector.GetHandle ("scrollViewWillEndDragging:withVelocity:targetContentOffset:");
		[CompilerGenerated]
		const string selScrollViewDidEndDraggingWillDecelerate_ = "scrollViewDidEndDragging:willDecelerate:";
		static readonly IntPtr selScrollViewDidEndDraggingWillDecelerate_Handle = Selector.GetHandle ("scrollViewDidEndDragging:willDecelerate:");
		[CompilerGenerated]
		const string selScrollViewWillBeginDecelerating_ = "scrollViewWillBeginDecelerating:";
		static readonly IntPtr selScrollViewWillBeginDecelerating_Handle = Selector.GetHandle ("scrollViewWillBeginDecelerating:");
		[CompilerGenerated]
		const string selScrollViewDidEndDecelerating_ = "scrollViewDidEndDecelerating:";
		static readonly IntPtr selScrollViewDidEndDecelerating_Handle = Selector.GetHandle ("scrollViewDidEndDecelerating:");
		[CompilerGenerated]
		const string selScrollViewDidEndScrollingAnimation_ = "scrollViewDidEndScrollingAnimation:";
		static readonly IntPtr selScrollViewDidEndScrollingAnimation_Handle = Selector.GetHandle ("scrollViewDidEndScrollingAnimation:");
		[CompilerGenerated]
		const string selViewForZoomingInScrollView_ = "viewForZoomingInScrollView:";
		static readonly IntPtr selViewForZoomingInScrollView_Handle = Selector.GetHandle ("viewForZoomingInScrollView:");
		[CompilerGenerated]
		const string selScrollViewWillBeginZoomingWithView_ = "scrollViewWillBeginZooming:withView:";
		static readonly IntPtr selScrollViewWillBeginZoomingWithView_Handle = Selector.GetHandle ("scrollViewWillBeginZooming:withView:");
		[CompilerGenerated]
		const string selScrollViewDidEndZoomingWithViewAtScale_ = "scrollViewDidEndZooming:withView:atScale:";
		static readonly IntPtr selScrollViewDidEndZoomingWithViewAtScale_Handle = Selector.GetHandle ("scrollViewDidEndZooming:withView:atScale:");
		[CompilerGenerated]
		const string selScrollViewShouldScrollToTop_ = "scrollViewShouldScrollToTop:";
		static readonly IntPtr selScrollViewShouldScrollToTop_Handle = Selector.GetHandle ("scrollViewShouldScrollToTop:");
		[CompilerGenerated]
		const string selScrollViewDidScrollToTop_ = "scrollViewDidScrollToTop:";
		static readonly IntPtr selScrollViewDidScrollToTop_Handle = Selector.GetHandle ("scrollViewDidScrollToTop:");
		[CompilerGenerated]
		const string selPressRecognizerShouldHandlePressImmediately_ = "pressRecognizerShouldHandlePressImmediately:";
		static readonly IntPtr selPressRecognizerShouldHandlePressImmediately_Handle = Selector.GetHandle ("pressRecognizerShouldHandlePressImmediately:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFScrollView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFScrollView () : base (NSObjectFlag.Empty)
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
		public PSPDFScrollView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFScrollView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFScrollView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:")]
		[CompilerGenerated]
		public PSPDFScrollView (global::System.Drawing.RectangleF frame)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_RectangleF (this.Handle, selInitWithFrame_Handle, frame);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_RectangleF (this.SuperHandle, selInitWithFrame_Handle, frame);
			}
		}
		
		[Export ("displayDocument:withPage:")]
		[CompilerGenerated]
		public virtual void DisplayDocumentWithPage (PSPDFDocument document, global::System.UInt32 page)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UInt32 (this.Handle, selDisplayDocumentWithPage_Handle, document.Handle, page);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, selDisplayDocumentWithPage_Handle, document.Handle, page);
			}
		}
		
		[Export ("releaseDocument")]
		[CompilerGenerated]
		public virtual void ReleaseDocument ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selReleaseDocumentHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selReleaseDocumentHandle);
			}
		}
		
		[Export ("singleTapped:")]
		[CompilerGenerated]
		public virtual void SingleTapped (global::MonoTouch.UIKit.UITapGestureRecognizer recognizer)
		{
			if (recognizer == null)
				throw new ArgumentNullException ("recognizer");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSingleTapped_Handle, recognizer.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSingleTapped_Handle, recognizer.Handle);
			}
		}
		
		[Export ("doubleTapped:")]
		[CompilerGenerated]
		public virtual void DoubleTapped (global::MonoTouch.UIKit.UITapGestureRecognizer recognizer)
		{
			if (recognizer == null)
				throw new ArgumentNullException ("recognizer");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selDoubleTapped_Handle, recognizer.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selDoubleTapped_Handle, recognizer.Handle);
			}
		}
		
		[Export ("longPress:")]
		[CompilerGenerated]
		public virtual void LongPress (global::MonoTouch.UIKit.UILongPressGestureRecognizer recognizer)
		{
			if (recognizer == null)
				throw new ArgumentNullException ("recognizer");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selLongPress_Handle, recognizer.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selLongPress_Handle, recognizer.Handle);
			}
		}
		
		[Export ("pathShadowForView:")]
		[CompilerGenerated]
		public virtual NSObject PathShadowForView (global::MonoTouch.UIKit.UIView imgView)
		{
			if (imgView == null)
				throw new ArgumentNullException ("imgView");
			if (IsDirectBinding) {
				return (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selPathShadowForView_Handle, imgView.Handle));
			} else {
				return (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selPathShadowForView_Handle, imgView.Handle));
			}
		}
		
		[Export ("switchPages")]
		[CompilerGenerated]
		public virtual void SwitchPages ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSwitchPagesHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selSwitchPagesHandle);
			}
		}
		
		[Export ("ensureContentIsCentered")]
		[CompilerGenerated]
		public virtual void EnsureContentIsCentered ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selEnsureContentIsCenteredHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selEnsureContentIsCenteredHandle);
			}
		}
		
		[Export ("pageViewForPoint:")]
		[CompilerGenerated]
		public virtual PSPDFPageView PageViewForPoint (global::System.Drawing.PointF point)
		{
			if (IsDirectBinding) {
				return (PSPDFPageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_PointF (this.Handle, selPageViewForPoint_Handle, point));
			} else {
				return (PSPDFPageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_PointF (this.SuperHandle, selPageViewForPoint_Handle, point));
			}
		}
		
		[Export ("scrollViewDidScroll:")]
		[CompilerGenerated]
		public virtual void ScrollViewDidScroll (global::MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScrollViewDidScroll_Handle, scrollView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selScrollViewDidScroll_Handle, scrollView.Handle);
			}
		}
		
		[Export ("scrollViewDidZoom:")]
		[CompilerGenerated]
		public virtual void ScrollViewDidZoom (global::MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScrollViewDidZoom_Handle, scrollView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selScrollViewDidZoom_Handle, scrollView.Handle);
			}
		}
		
		[Export ("scrollViewWillBeginDragging:")]
		[CompilerGenerated]
		public virtual void ScrollViewWillBeginDragging (global::MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScrollViewWillBeginDragging_Handle, scrollView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selScrollViewWillBeginDragging_Handle, scrollView.Handle);
			}
		}
		
		[Export ("scrollViewWillEndDragging:withVelocity:targetContentOffset:")]
		[CompilerGenerated]
		public virtual void ScrollViewWillEndDragging (global::MonoTouch.UIKit.UIScrollView scrollView, global::System.Drawing.PointF velocity, ref global::System.Drawing.PointF targetContentOffset)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_PointF_out_PointF (this.Handle, selScrollViewWillEndDraggingWithVelocityTargetContentOffset_Handle, scrollView.Handle, velocity, out targetContentOffset);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_PointF_out_PointF (this.SuperHandle, selScrollViewWillEndDraggingWithVelocityTargetContentOffset_Handle, scrollView.Handle, velocity, out targetContentOffset);
			}
		}
		
		[Export ("scrollViewDidEndDragging:willDecelerate:")]
		[CompilerGenerated]
		public virtual void ScrollViewDidEndDragging (global::MonoTouch.UIKit.UIScrollView scrollView, bool decelerate)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selScrollViewDidEndDraggingWillDecelerate_Handle, scrollView.Handle, decelerate);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selScrollViewDidEndDraggingWillDecelerate_Handle, scrollView.Handle, decelerate);
			}
		}
		
		[Export ("scrollViewWillBeginDecelerating:")]
		[CompilerGenerated]
		public virtual void ScrollViewWillBeginDecelerating (global::MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScrollViewWillBeginDecelerating_Handle, scrollView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selScrollViewWillBeginDecelerating_Handle, scrollView.Handle);
			}
		}
		
		[Export ("scrollViewDidEndDecelerating:")]
		[CompilerGenerated]
		public virtual void ScrollViewDidEndDecelerating (global::MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScrollViewDidEndDecelerating_Handle, scrollView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selScrollViewDidEndDecelerating_Handle, scrollView.Handle);
			}
		}
		
		[Export ("scrollViewDidEndScrollingAnimation:")]
		[CompilerGenerated]
		public virtual void ScrollViewDidEndScrollingAnimation (global::MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScrollViewDidEndScrollingAnimation_Handle, scrollView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selScrollViewDidEndScrollingAnimation_Handle, scrollView.Handle);
			}
		}
		
		[Export ("viewForZoomingInScrollView:")]
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIView ViewForZoomingInScrollView (global::MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				return (global::MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selViewForZoomingInScrollView_Handle, scrollView.Handle));
			} else {
				return (global::MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selViewForZoomingInScrollView_Handle, scrollView.Handle));
			}
		}
		
		[Export ("scrollViewWillBeginZooming:withView:")]
		[CompilerGenerated]
		public virtual void ScrollViewWillBeginZooming (global::MonoTouch.UIKit.UIScrollView scrollView, global::MonoTouch.UIKit.UIView view)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (view == null)
				throw new ArgumentNullException ("view");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selScrollViewWillBeginZoomingWithView_Handle, scrollView.Handle, view.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selScrollViewWillBeginZoomingWithView_Handle, scrollView.Handle, view.Handle);
			}
		}
		
		[Export ("scrollViewDidEndZooming:withView:atScale:")]
		[CompilerGenerated]
		public virtual void ScrollViewDidEndZooming (global::MonoTouch.UIKit.UIScrollView scrollView, global::MonoTouch.UIKit.UIView view, float scale)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (view == null)
				throw new ArgumentNullException ("view");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_float (this.Handle, selScrollViewDidEndZoomingWithViewAtScale_Handle, scrollView.Handle, view.Handle, scale);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_float (this.SuperHandle, selScrollViewDidEndZoomingWithViewAtScale_Handle, scrollView.Handle, view.Handle, scale);
			}
		}
		
		[Export ("scrollViewShouldScrollToTop:")]
		[CompilerGenerated]
		public virtual bool ScrollViewShouldScrollToTop (global::MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selScrollViewShouldScrollToTop_Handle, scrollView.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selScrollViewShouldScrollToTop_Handle, scrollView.Handle);
			}
		}
		
		[Export ("scrollViewDidScrollToTop:")]
		[CompilerGenerated]
		public virtual void ScrollViewDidScrollToTop (global::MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScrollViewDidScrollToTop_Handle, scrollView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selScrollViewDidScrollToTop_Handle, scrollView.Handle);
			}
		}
		
		[Export ("pressRecognizerShouldHandlePressImmediately:")]
		[CompilerGenerated]
		public virtual bool PressRecognizerShouldHandlePressImmediately (PSPDFLongPressGestureRecognizer recognizer)
		{
			if (recognizer == null)
				throw new ArgumentNullException ("recognizer");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selPressRecognizerShouldHandlePressImmediately_Handle, recognizer.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selPressRecognizerShouldHandlePressImmediately_Handle, recognizer.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 Page {
			[Export ("page", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPageHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selPageHandle);
				}
			}
			
			[Export ("setPage:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetPage_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetPage_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Document_var;
		[CompilerGenerated]
		public virtual PSPDFDocument Document {
			[Export ("document")]
			get {
				PSPDFDocument ret;
				if (IsDirectBinding) {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocumentHandle));
				} else {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocumentHandle));
				}
				MarkDirty ();
				__mt_Document_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PdfController_var;
		[CompilerGenerated]
		public virtual PSPDFViewController PdfController {
			[Export ("pdfController")]
			get {
				PSPDFViewController ret;
				if (IsDirectBinding) {
					ret = (PSPDFViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPdfControllerHandle));
				} else {
					ret = (PSPDFViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPdfControllerHandle));
				}
				MarkDirty ();
				__mt_PdfController_var = ret;
				return ret;
			}
			
			[Export ("setPdfController:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPdfController_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPdfController_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_PdfController_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_LeftPage_var;
		[CompilerGenerated]
		public virtual PSPDFPageView LeftPage {
			[Export ("leftPage")]
			get {
				PSPDFPageView ret;
				if (IsDirectBinding) {
					ret = (PSPDFPageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLeftPageHandle));
				} else {
					ret = (PSPDFPageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLeftPageHandle));
				}
				MarkDirty ();
				__mt_LeftPage_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_RightPage_var;
		[CompilerGenerated]
		public virtual PSPDFPageView RightPage {
			[Export ("rightPage")]
			get {
				PSPDFPageView ret;
				if (IsDirectBinding) {
					ret = (PSPDFPageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRightPageHandle));
				} else {
					ret = (PSPDFPageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRightPageHandle));
				}
				MarkDirty ();
				__mt_RightPage_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFShadowStyle ShadowStyle {
			[Export ("shadowStyle", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFShadowStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selShadowStyleHandle);
				} else {
					return (PSPDFShadowStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selShadowStyleHandle);
				}
			}
			
			[Export ("setShadowStyle:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetShadowStyle_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetShadowStyle_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ZoomingEnabled {
			[Export ("isZoomingEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsZoomingEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsZoomingEnabledHandle);
				}
			}
			
			[Export ("setZoomingEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetZoomingEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetZoomingEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool DoublePageMode {
			[Export ("isDoublePageMode", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDoublePageModeHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsDoublePageModeHandle);
				}
			}
			
			[Export ("setDoublePageMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDoublePageMode_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetDoublePageMode_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool DoublePageModeOnFirstPage {
			[Export ("isDoublePageModeOnFirstPage", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDoublePageModeOnFirstPageHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsDoublePageModeOnFirstPageHandle);
				}
			}
			
			[Export ("setDoublePageModeOnFirstPage:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDoublePageModeOnFirstPage_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetDoublePageModeOnFirstPage_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ZoomingSmallDocumentsEnabled {
			[Export ("isZoomingSmallDocumentsEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsZoomingSmallDocumentsEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsZoomingSmallDocumentsEnabledHandle);
				}
			}
			
			[Export ("setZoomingSmallDocumentsEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetZoomingSmallDocumentsEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetZoomingSmallDocumentsEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool FitToWidthEnabled {
			[Export ("isFitToWidthEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFitToWidthEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsFitToWidthEnabledHandle);
				}
			}
			
			[Export ("setFitToWidthEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetFitToWidthEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetFitToWidthEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShadowEnabled {
			[Export ("isShadowEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsShadowEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsShadowEnabledHandle);
				}
			}
			
			[Export ("setShadowEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShadowEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShadowEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ScrollOnTapPageEndEnabled {
			[Export ("isScrollOnTapPageEndEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsScrollOnTapPageEndEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsScrollOnTapPageEndEnabledHandle);
				}
			}
			
			[Export ("setScrollOnTapPageEndEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetScrollOnTapPageEndEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetScrollOnTapPageEndEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_SingleTapGesture_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UITapGestureRecognizer SingleTapGesture {
			[Export ("singleTapGesture")]
			get {
				global::MonoTouch.UIKit.UITapGestureRecognizer ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UITapGestureRecognizer) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSingleTapGestureHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UITapGestureRecognizer) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSingleTapGestureHandle));
				}
				MarkDirty ();
				__mt_SingleTapGesture_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_DoubleTapGesture_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UITapGestureRecognizer DoubleTapGesture {
			[Export ("doubleTapGesture")]
			get {
				global::MonoTouch.UIKit.UITapGestureRecognizer ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UITapGestureRecognizer) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDoubleTapGestureHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UITapGestureRecognizer) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDoubleTapGestureHandle));
				}
				MarkDirty ();
				__mt_DoubleTapGesture_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_LongPressGesture_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UILongPressGestureRecognizer LongPressGesture {
			[Export ("longPressGesture")]
			get {
				global::MonoTouch.UIKit.UILongPressGestureRecognizer ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UILongPressGestureRecognizer) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLongPressGestureHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UILongPressGestureRecognizer) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLongPressGestureHandle));
				}
				MarkDirty ();
				__mt_LongPressGesture_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_CreateDoubleTapGesture_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UITapGestureRecognizer CreateDoubleTapGesture {
			[Export ("createDoubleTapGesture")]
			get {
				global::MonoTouch.UIKit.UITapGestureRecognizer ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UITapGestureRecognizer) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCreateDoubleTapGestureHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UITapGestureRecognizer) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCreateDoubleTapGestureHandle));
				}
				MarkDirty ();
				__mt_CreateDoubleTapGesture_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_CompoundView_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIView CompoundView {
			[Export ("compoundView")]
			get {
				global::MonoTouch.UIKit.UIView ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCompoundViewHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCompoundViewHandle));
				}
				MarkDirty ();
				__mt_CompoundView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_LoupeView_var;
		[CompilerGenerated]
		public virtual PSPDFLoupeView LoupeView {
			[Export ("loupeView")]
			get {
				PSPDFLoupeView ret;
				if (IsDirectBinding) {
					ret = (PSPDFLoupeView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLoupeViewHandle));
				} else {
					ret = (PSPDFLoupeView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLoupeViewHandle));
				}
				MarkDirty ();
				__mt_LoupeView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool RotationActive {
			[Export ("isRotationActive", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsRotationActiveHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsRotationActiveHandle);
				}
			}
			
			[Export ("setRotationActive:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetRotationActive_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetRotationActive_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AnimatingZoomIn {
			[Export ("isAnimatingZoomIn", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAnimatingZoomInHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsAnimatingZoomInHandle);
				}
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Document_var = null;
				__mt_PdfController_var = null;
				__mt_LeftPage_var = null;
				__mt_RightPage_var = null;
				__mt_SingleTapGesture_var = null;
				__mt_DoubleTapGesture_var = null;
				__mt_LongPressGesture_var = null;
				__mt_CreateDoubleTapGesture_var = null;
				__mt_CompoundView_var = null;
				__mt_LoupeView_var = null;
			}
		}
	} /* class PSPDFScrollView */
}
