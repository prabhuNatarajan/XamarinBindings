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
	[Register("PSPDFPageViewController", true)]
	public unsafe partial class PSPDFPageViewController : global::MonoTouch.UIKit.UIPageViewController {
		[CompilerGenerated]
		const string selUseSolidBackground = "useSolidBackground";
		static readonly IntPtr selUseSolidBackgroundHandle = Selector.GetHandle ("useSolidBackground");
		[CompilerGenerated]
		const string selSetUseSolidBackground_ = "setUseSolidBackground:";
		static readonly IntPtr selSetUseSolidBackground_Handle = Selector.GetHandle ("setUseSolidBackground:");
		[CompilerGenerated]
		const string selClipToPageBoundaries = "clipToPageBoundaries";
		static readonly IntPtr selClipToPageBoundariesHandle = Selector.GetHandle ("clipToPageBoundaries");
		[CompilerGenerated]
		const string selSetClipToPageBoundaries_ = "setClipToPageBoundaries:";
		static readonly IntPtr selSetClipToPageBoundaries_Handle = Selector.GetHandle ("setClipToPageBoundaries:");
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
		const string selPageViewControllerViewControllerBeforeViewController_ = "pageViewController:viewControllerBeforeViewController:";
		static readonly IntPtr selPageViewControllerViewControllerBeforeViewController_Handle = Selector.GetHandle ("pageViewController:viewControllerBeforeViewController:");
		[CompilerGenerated]
		const string selPageViewControllerViewControllerAfterViewController_ = "pageViewController:viewControllerAfterViewController:";
		static readonly IntPtr selPageViewControllerViewControllerAfterViewController_Handle = Selector.GetHandle ("pageViewController:viewControllerAfterViewController:");
		[CompilerGenerated]
		const string selViewControllers = "viewControllers";
		static readonly IntPtr selViewControllersHandle = Selector.GetHandle ("viewControllers");
		[CompilerGenerated]
		const string selTransitionHelperChangedToPageDoublePageModeForwardTransitionAnimated_ = "transitionHelper:changedToPage:doublePageMode:forwardTransition:animated:";
		static readonly IntPtr selTransitionHelperChangedToPageDoublePageModeForwardTransitionAnimated_Handle = Selector.GetHandle ("transitionHelper:changedToPage:doublePageMode:forwardTransition:animated:");
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
		const string selPageViewControllerDidFinishAnimatingPreviousViewControllersTransitionCompleted_ = "pageViewController:didFinishAnimating:previousViewControllers:transitionCompleted:";
		static readonly IntPtr selPageViewControllerDidFinishAnimatingPreviousViewControllersTransitionCompleted_Handle = Selector.GetHandle ("pageViewController:didFinishAnimating:previousViewControllers:transitionCompleted:");
		[CompilerGenerated]
		const string selPageViewControllerSpineLocationForInterfaceOrientation_ = "pageViewController:spineLocationForInterfaceOrientation:";
		static readonly IntPtr selPageViewControllerSpineLocationForInterfaceOrientation_Handle = Selector.GetHandle ("pageViewController:spineLocationForInterfaceOrientation:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFPageViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFPageViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFPageViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFPageViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithPDFController:")]
		[CompilerGenerated]
		public PSPDFPageViewController (PSPDFViewController pdfController)
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
		
		[Export ("pageViewController:viewControllerBeforeViewController:")]
		[CompilerGenerated]
		public virtual void PageViewControllerViewControllerBeforeViewController (global::MonoTouch.UIKit.UIPageViewController pageViewController, global::MonoTouch.UIKit.UIViewController viewController)
		{
			if (pageViewController == null)
				throw new ArgumentNullException ("pageViewController");
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selPageViewControllerViewControllerBeforeViewController_Handle, pageViewController.Handle, viewController.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selPageViewControllerViewControllerBeforeViewController_Handle, pageViewController.Handle, viewController.Handle);
			}
		}
		
		[Export ("pageViewController:viewControllerAfterViewController:")]
		[CompilerGenerated]
		public virtual void PageViewControllerViewControllerAfterViewController (global::MonoTouch.UIKit.UIPageViewController pageViewController, global::MonoTouch.UIKit.UIViewController viewController)
		{
			if (pageViewController == null)
				throw new ArgumentNullException ("pageViewController");
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selPageViewControllerViewControllerAfterViewController_Handle, pageViewController.Handle, viewController.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selPageViewControllerViewControllerAfterViewController_Handle, pageViewController.Handle, viewController.Handle);
			}
		}
		
		[Export ("viewControllers")]
		[CompilerGenerated]
		public virtual PSPDFViewController[] ViewControllers ()
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFViewController>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selViewControllersHandle));
			} else {
				return NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFViewController>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selViewControllersHandle));
			}
		}
		
		[Export ("transitionHelper:changedToPage:doublePageMode:forwardTransition:animated:")]
		[CompilerGenerated]
		public virtual void TransitionHelperChangedToPage (PSPDFTransitionHelper transitionHelper, global::System.UInt32 page, bool doublePageMode, bool forwardTransition, bool animated)
		{
			if (transitionHelper == null)
				throw new ArgumentNullException ("transitionHelper");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32_bool_bool_bool (this.Handle, selTransitionHelperChangedToPageDoublePageModeForwardTransitionAnimated_Handle, transitionHelper.Handle, page, doublePageMode, forwardTransition, animated);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_UInt32_bool_bool_bool (this.SuperHandle, selTransitionHelperChangedToPageDoublePageModeForwardTransitionAnimated_Handle, transitionHelper.Handle, page, doublePageMode, forwardTransition, animated);
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
		
		[Export ("pageViewController:didFinishAnimating:previousViewControllers:transitionCompleted:")]
		[CompilerGenerated]
		public virtual void PageViewControllerDidFinishAnimating (global::MonoTouch.UIKit.UIPageViewController pageViewController, bool finished, global::MonoTouch.UIKit.UIViewController[] previousViewControllers, bool completed)
		{
			if (pageViewController == null)
				throw new ArgumentNullException ("pageViewController");
			if (previousViewControllers == null)
				throw new ArgumentNullException ("previousViewControllers");
			var nsa_previousViewControllers = NSArray.FromNSObjects (previousViewControllers);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool_IntPtr_bool (this.Handle, selPageViewControllerDidFinishAnimatingPreviousViewControllersTransitionCompleted_Handle, pageViewController.Handle, finished, nsa_previousViewControllers.Handle, completed);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_bool_IntPtr_bool (this.SuperHandle, selPageViewControllerDidFinishAnimatingPreviousViewControllersTransitionCompleted_Handle, pageViewController.Handle, finished, nsa_previousViewControllers.Handle, completed);
			}
			nsa_previousViewControllers.Dispose ();
			
		}
		
		[Export ("pageViewController:spineLocationForInterfaceOrientation:")]
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIPageViewControllerSpineLocation PageViewControllerGetSpineLocation (global::MonoTouch.UIKit.UIPageViewController pageViewController, global::MonoTouch.UIKit.UIInterfaceOrientation orientation)
		{
			if (pageViewController == null)
				throw new ArgumentNullException ("pageViewController");
			if (IsDirectBinding) {
				return (global::MonoTouch.UIKit.UIPageViewControllerSpineLocation) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend_IntPtr_int (this.Handle, selPageViewControllerSpineLocationForInterfaceOrientation_Handle, pageViewController.Handle, (int)orientation);
			} else {
				return (global::MonoTouch.UIKit.UIPageViewControllerSpineLocation) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper_IntPtr_int (this.SuperHandle, selPageViewControllerSpineLocationForInterfaceOrientation_Handle, pageViewController.Handle, (int)orientation);
			}
		}
		
		[CompilerGenerated]
		public virtual bool UseSolidBackground {
			[Export ("useSolidBackground", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUseSolidBackgroundHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selUseSolidBackgroundHandle);
				}
			}
			
			[Export ("setUseSolidBackground:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUseSolidBackground_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetUseSolidBackground_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ClipToPageBoundaries {
			[Export ("clipToPageBoundaries", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selClipToPageBoundariesHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selClipToPageBoundariesHandle);
				}
			}
			
			[Export ("setClipToPageBoundaries:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetClipToPageBoundaries_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetClipToPageBoundaries_Handle, value);
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
				__mt_PdfController_var = null;
				__mt_ScrollView_var = null;
			}
		}
	} /* class PSPDFPageViewController */
}
