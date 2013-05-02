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
	[Register("PSPDFPageScrollViewController", true)]
	public unsafe partial class PSPDFPageScrollViewController : PSPDFBaseViewController {
		[CompilerGenerated]
		const string selPagingScrollView = "pagingScrollView";
		static readonly IntPtr selPagingScrollViewHandle = Selector.GetHandle ("pagingScrollView");
		[CompilerGenerated]
		const string selPagePadding = "pagePadding";
		static readonly IntPtr selPagePaddingHandle = Selector.GetHandle ("pagePadding");
		[CompilerGenerated]
		const string selSetPagePadding_ = "setPagePadding:";
		static readonly IntPtr selSetPagePadding_Handle = Selector.GetHandle ("setPagePadding:");
		[CompilerGenerated]
		const string selTargetPageAfterRotation = "targetPageAfterRotation";
		static readonly IntPtr selTargetPageAfterRotationHandle = Selector.GetHandle ("targetPageAfterRotation");
		[CompilerGenerated]
		const string selSetTargetPageAfterRotation_ = "setTargetPageAfterRotation:";
		static readonly IntPtr selSetTargetPageAfterRotation_Handle = Selector.GetHandle ("setTargetPageAfterRotation:");
		[CompilerGenerated]
		const string selPdfController = "pdfController";
		static readonly IntPtr selPdfControllerHandle = Selector.GetHandle ("pdfController");
		[CompilerGenerated]
		const string selSetPdfController_ = "setPdfController:";
		static readonly IntPtr selSetPdfController_Handle = Selector.GetHandle ("setPdfController:");
		[CompilerGenerated]
		const string selScrollView = "scrollView";
		static readonly IntPtr selScrollViewHandle = Selector.GetHandle ("scrollView");
		[CompilerGenerated]
		const string selSetScrollView_ = "setScrollView:";
		static readonly IntPtr selSetScrollView_Handle = Selector.GetHandle ("setScrollView:");
		[CompilerGenerated]
		const string selInitWithPDFController_ = "initWithPDFController:";
		static readonly IntPtr selInitWithPDFController_Handle = Selector.GetHandle ("initWithPDFController:");
		[CompilerGenerated]
		const string selReloadData = "reloadData";
		static readonly IntPtr selReloadDataHandle = Selector.GetHandle ("reloadData");
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
		const string selSetPageAnimated_ = "setPage:animated:";
		static readonly IntPtr selSetPageAnimated_Handle = Selector.GetHandle ("setPage:animated:");
		[CompilerGenerated]
		const string selVisiblePageNumbers = "visiblePageNumbers";
		static readonly IntPtr selVisiblePageNumbersHandle = Selector.GetHandle ("visiblePageNumbers");
		[CompilerGenerated]
		const string selPageViewForPage_ = "pageViewForPage:";
		static readonly IntPtr selPageViewForPage_Handle = Selector.GetHandle ("pageViewForPage:");
		[CompilerGenerated]
		const string selVisiblePageViews = "visiblePageViews";
		static readonly IntPtr selVisiblePageViewsHandle = Selector.GetHandle ("visiblePageViews");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFPageScrollViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFPageScrollViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFPageScrollViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFPageScrollViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFPageScrollViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithPDFController:")]
		[CompilerGenerated]
		public PSPDFPageScrollViewController (PSPDFViewController pdfController)
			: base (NSObjectFlag.Empty)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithPDFController_Handle, pdfController.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithPDFController_Handle, pdfController.Handle);
			}
		}
		
		[Export ("reloadData")]
		[CompilerGenerated]
		public virtual void ReloadData ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selReloadDataHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selReloadDataHandle);
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
		
		[Export ("setPage:animated:")]
		[CompilerGenerated]
		public virtual void SetPage (global::System.UInt32 page, bool animated)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_UInt32_bool (this.Handle, selSetPageAnimated_Handle, page, animated);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32_bool (this.SuperHandle, selSetPageAnimated_Handle, page, animated);
			}
		}
		
		[Export ("visiblePageNumbers")]
		[CompilerGenerated]
		public virtual NSNumber[] VisiblePageNumbers ()
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<MonoTouch.Foundation.NSNumber>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selVisiblePageNumbersHandle));
			} else {
				return NSArray.ArrayFromHandle<MonoTouch.Foundation.NSNumber>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selVisiblePageNumbersHandle));
			}
		}
		
		[Export ("pageViewForPage:")]
		[CompilerGenerated]
		public virtual PSPDFPageView PageViewForPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return (PSPDFPageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selPageViewForPage_Handle, page));
			} else {
				return (PSPDFPageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selPageViewForPage_Handle, page));
			}
		}
		
		[Export ("visiblePageViews")]
		[CompilerGenerated]
		public virtual PSPDFPageView[] VisiblePageViews ()
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFPageView>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selVisiblePageViewsHandle));
			} else {
				return NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFPageView>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selVisiblePageViewsHandle));
			}
		}
		
		[CompilerGenerated]
		object __mt_PagingScrollView_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIScrollView PagingScrollView {
			[Export ("pagingScrollView")]
			get {
				global::MonoTouch.UIKit.UIScrollView ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIScrollView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPagingScrollViewHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIScrollView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPagingScrollViewHandle));
				}
				MarkDirty ();
				__mt_PagingScrollView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual float PagePadding {
			[Export ("pagePadding", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selPagePaddingHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selPagePaddingHandle);
				}
			}
			
			[Export ("setPagePadding:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetPagePadding_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetPagePadding_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 TargetPageAfterRotation {
			[Export ("targetPageAfterRotation", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selTargetPageAfterRotationHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selTargetPageAfterRotationHandle);
				}
			}
			
			[Export ("setTargetPageAfterRotation:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetTargetPageAfterRotation_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetTargetPageAfterRotation_Handle, value);
				}
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
		object __mt_ScrollView_var;
		[CompilerGenerated]
		public virtual PSPDFContentScrollView ScrollView {
			[Export ("scrollView")]
			get {
				PSPDFContentScrollView ret;
				if (IsDirectBinding) {
					ret = (PSPDFContentScrollView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selScrollViewHandle));
				} else {
					ret = (PSPDFContentScrollView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selScrollViewHandle));
				}
				MarkDirty ();
				__mt_ScrollView_var = ret;
				return ret;
			}
			
			[Export ("setScrollView:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetScrollView_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetScrollView_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_ScrollView_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_PagingScrollView_var = null;
				__mt_PdfController_var = null;
				__mt_ScrollView_var = null;
			}
		}
	} /* class PSPDFPageScrollViewController */
}
