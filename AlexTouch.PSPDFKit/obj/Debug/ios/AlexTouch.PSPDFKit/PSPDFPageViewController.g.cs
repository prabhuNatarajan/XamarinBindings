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
	[Register("PSPDFPageViewController", true)]
	public unsafe partial class PSPDFPageViewController : MonoTouch.UIKit.UIPageViewController {
		static readonly IntPtr selUseSolidBackground = Selector.GetHandle ("useSolidBackground");
		static readonly IntPtr selSetUseSolidBackground_ = Selector.GetHandle ("setUseSolidBackground:");
		static readonly IntPtr selClipToPageBoundaries = Selector.GetHandle ("clipToPageBoundaries");
		static readonly IntPtr selSetClipToPageBoundaries_ = Selector.GetHandle ("setClipToPageBoundaries:");
		static readonly IntPtr selPdfController = Selector.GetHandle ("pdfController");
		static readonly IntPtr selSetPdfController_ = Selector.GetHandle ("setPdfController:");
		static readonly IntPtr selScrollView = Selector.GetHandle ("scrollView");
		static readonly IntPtr selSetScrollView_ = Selector.GetHandle ("setScrollView:");
		static readonly IntPtr selInitWithPDFController_ = Selector.GetHandle ("initWithPDFController:");
		static readonly IntPtr selSetPageAnimated_ = Selector.GetHandle ("setPage:animated:");
		static readonly IntPtr selVisiblePageNumbers = Selector.GetHandle ("visiblePageNumbers");
		static readonly IntPtr selPageViewForPage_ = Selector.GetHandle ("pageViewForPage:");
		static readonly IntPtr selVisiblePageViews = Selector.GetHandle ("visiblePageViews");
		static readonly IntPtr selPageViewControllerDidFinishAnimatingPreviousViewControllersTransitionCompleted_ = Selector.GetHandle ("pageViewController:didFinishAnimating:previousViewControllers:transitionCompleted:");
		static readonly IntPtr selPageViewControllerSpineLocationForInterfaceOrientation_ = Selector.GetHandle ("pageViewController:spineLocationForInterfaceOrientation:");
		static readonly IntPtr selPageViewControllerViewControllerBeforeViewController_ = Selector.GetHandle ("pageViewController:viewControllerBeforeViewController:");
		static readonly IntPtr selPageViewControllerViewControllerAfterViewController_ = Selector.GetHandle ("pageViewController:viewControllerAfterViewController:");
		static readonly IntPtr selViewControllers = Selector.GetHandle ("viewControllers");
		static readonly IntPtr selTransitionHelperChangedToPageDoublePageModeForwardTransitionAnimated_ = Selector.GetHandle ("transitionHelper:changedToPage:doublePageMode:forwardTransition:animated:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFPageViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFPageViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFPageViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFPageViewController (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFPageViewController (IntPtr handle) : base (handle) {}

		[Export ("initWithPDFController:")]
		[CompilerGenerated]
		public PSPDFPageViewController (PSPDFViewController pdfController) : base (NSObjectFlag.Empty)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithPDFController_, pdfController.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithPDFController_, pdfController.Handle);
			}
		}
		
		[Export ("setPage:animated:")]
		[CompilerGenerated]
		public virtual void SetPage (System.UInt32 page, bool animated)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_UInt32_bool (this.Handle, selSetPageAnimated_, page, animated);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32_bool (this.SuperHandle, selSetPageAnimated_, page, animated);
			}
		}
		
		[Export ("visiblePageNumbers")]
		[CompilerGenerated]
		public virtual NSNumber[] VisiblePageNumbers ()
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<MonoTouch.Foundation.NSNumber>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selVisiblePageNumbers));
			} else {
				return NSArray.ArrayFromHandle<MonoTouch.Foundation.NSNumber>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selVisiblePageNumbers));
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
		
		[Export ("visiblePageViews")]
		[CompilerGenerated]
		public virtual PSPDFPageView[] VisiblePageViews ()
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFPageView>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selVisiblePageViews));
			} else {
				return NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFPageView>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selVisiblePageViews));
			}
		}
		
		[Export ("pageViewController:didFinishAnimating:previousViewControllers:transitionCompleted:")]
		[CompilerGenerated]
		public virtual void PageViewControllerDidFinishAnimating (MonoTouch.UIKit.UIPageViewController pageViewController, bool finished, MonoTouch.UIKit.UIViewController[] previousViewControllers, bool completed)
		{
			if (pageViewController == null)
				throw new ArgumentNullException ("pageViewController");
			if (previousViewControllers == null)
				throw new ArgumentNullException ("previousViewControllers");
			var nsa_previousViewControllers = NSArray.FromNSObjects (previousViewControllers);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool_IntPtr_bool (this.Handle, selPageViewControllerDidFinishAnimatingPreviousViewControllersTransitionCompleted_, pageViewController.Handle, finished, nsa_previousViewControllers.Handle, completed);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_bool_IntPtr_bool (this.SuperHandle, selPageViewControllerDidFinishAnimatingPreviousViewControllersTransitionCompleted_, pageViewController.Handle, finished, nsa_previousViewControllers.Handle, completed);
			}
			nsa_previousViewControllers.Dispose ();
			
		}
		
		[Export ("pageViewController:spineLocationForInterfaceOrientation:")]
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIPageViewControllerSpineLocation PageViewControllerGetSpineLocation (MonoTouch.UIKit.UIPageViewController pageViewController, MonoTouch.UIKit.UIInterfaceOrientation orientation)
		{
			if (pageViewController == null)
				throw new ArgumentNullException ("pageViewController");
			if (IsDirectBinding) {
				return (MonoTouch.UIKit.UIPageViewControllerSpineLocation) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend_IntPtr_int (this.Handle, selPageViewControllerSpineLocationForInterfaceOrientation_, pageViewController.Handle, (int)orientation);
			} else {
				return (MonoTouch.UIKit.UIPageViewControllerSpineLocation) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper_IntPtr_int (this.SuperHandle, selPageViewControllerSpineLocationForInterfaceOrientation_, pageViewController.Handle, (int)orientation);
			}
		}
		
		[Export ("pageViewController:viewControllerBeforeViewController:")]
		[CompilerGenerated]
		public virtual void PageViewControllerViewControllerBeforeViewController (MonoTouch.UIKit.UIPageViewController pageViewController, MonoTouch.UIKit.UIViewController viewController)
		{
			if (pageViewController == null)
				throw new ArgumentNullException ("pageViewController");
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selPageViewControllerViewControllerBeforeViewController_, pageViewController.Handle, viewController.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selPageViewControllerViewControllerBeforeViewController_, pageViewController.Handle, viewController.Handle);
			}
		}
		
		[Export ("pageViewController:viewControllerAfterViewController:")]
		[CompilerGenerated]
		public virtual void PageViewControllerViewControllerAfterViewController (MonoTouch.UIKit.UIPageViewController pageViewController, MonoTouch.UIKit.UIViewController viewController)
		{
			if (pageViewController == null)
				throw new ArgumentNullException ("pageViewController");
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selPageViewControllerViewControllerAfterViewController_, pageViewController.Handle, viewController.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selPageViewControllerViewControllerAfterViewController_, pageViewController.Handle, viewController.Handle);
			}
		}
		
		[Export ("viewControllers")]
		[CompilerGenerated]
		public virtual PSPDFViewController[] ViewControllers ()
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFViewController>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selViewControllers));
			} else {
				return NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFViewController>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selViewControllers));
			}
		}
		
		[Export ("transitionHelper:changedToPage:doublePageMode:forwardTransition:animated:")]
		[CompilerGenerated]
		public virtual void TransitionHelperChangedToPage (PSPDFTransitionHelper transitionHelper, System.UInt32 page, bool doublePageMode, bool forwardTransition, bool animated)
		{
			if (transitionHelper == null)
				throw new ArgumentNullException ("transitionHelper");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32_bool_bool_bool (this.Handle, selTransitionHelperChangedToPageDoublePageModeForwardTransitionAnimated_, transitionHelper.Handle, page, doublePageMode, forwardTransition, animated);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_UInt32_bool_bool_bool (this.SuperHandle, selTransitionHelperChangedToPageDoublePageModeForwardTransitionAnimated_, transitionHelper.Handle, page, doublePageMode, forwardTransition, animated);
			}
		}
		
		[CompilerGenerated]
		public virtual bool UseSolidBackground {
			[Export ("useSolidBackground", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUseSolidBackground);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selUseSolidBackground);
				}
			}
			
			[Export ("setUseSolidBackground:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUseSolidBackground_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetUseSolidBackground_, value);
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
		
		object __mt_PdfController_var;
		[CompilerGenerated]
		public virtual PSPDFViewController PdfController {
			[Export ("pdfController")]
			get {
				PSPDFViewController ret;
				if (IsDirectBinding) {
					ret = (PSPDFViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPdfController));
				} else {
					ret = (PSPDFViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPdfController));
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
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPdfController_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPdfController_, value.Handle);
				}
				MarkDirty ();
				__mt_PdfController_var = value;
			}
		}
		
		object __mt_ScrollView_var;
		[CompilerGenerated]
		public virtual PSPDFPagedScrollView ScrollView {
			[Export ("scrollView")]
			get {
				PSPDFPagedScrollView ret;
				if (IsDirectBinding) {
					ret = (PSPDFPagedScrollView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selScrollView));
				} else {
					ret = (PSPDFPagedScrollView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selScrollView));
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
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetScrollView_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetScrollView_, value.Handle);
				}
				MarkDirty ();
				__mt_ScrollView_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_PdfController_var = null;
			__mt_ScrollView_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFPageViewController */
}
