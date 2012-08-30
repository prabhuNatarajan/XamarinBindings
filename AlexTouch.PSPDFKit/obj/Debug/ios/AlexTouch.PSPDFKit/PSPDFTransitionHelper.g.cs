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
	[Register("PSPDFTransitionHelper", true)]
	public unsafe partial class PSPDFTransitionHelper : NSObject {
		static readonly IntPtr selDelegate = Selector.GetHandle ("delegate");
		static readonly IntPtr selPage = Selector.GetHandle ("page");
		static readonly IntPtr selInitWithDelegate_ = Selector.GetHandle ("initWithDelegate:");
		static readonly IntPtr selSetPageAnimated_ = Selector.GetHandle ("setPage:animated:");
		static readonly IntPtr selVisiblePageNumbers = Selector.GetHandle ("visiblePageNumbers");
		static readonly IntPtr selPageViewForPage_ = Selector.GetHandle ("pageViewForPage:");
		static readonly IntPtr selSinglePageControllerForPage_ = Selector.GetHandle ("singlePageControllerForPage:");
		static readonly IntPtr selFixPageNumberForDoublePageModeForceDoublePageMode_ = Selector.GetHandle ("fixPageNumberForDoublePageMode:forceDoublePageMode:");
		static readonly IntPtr selViewControllerAfterViewController_ = Selector.GetHandle ("viewControllerAfterViewController:");
		static readonly IntPtr selViewControllerBeforeViewController_ = Selector.GetHandle ("viewControllerBeforeViewController:");
		static readonly IntPtr selSetPageInternal_ = Selector.GetHandle ("setPageInternal:");
		static readonly IntPtr selPspdfSinglePageViewControllerReadyForReuse_ = Selector.GetHandle ("pspdfSinglePageViewControllerReadyForReuse:");
		static readonly IntPtr selPspdfSinglePageViewControllerWillDealloc_ = Selector.GetHandle ("pspdfSinglePageViewControllerWillDealloc:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFTransitionHelper");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFTransitionHelper () : base (NSObjectFlag.Empty)
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
		public PSPDFTransitionHelper (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFTransitionHelper (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFTransitionHelper (IntPtr handle) : base (handle) {}

		[Export ("initWithDelegate:")]
		[CompilerGenerated]
		public PSPDFTransitionHelper (PSPDFTransitionHelperDelegate Delegate) : base (NSObjectFlag.Empty)
		{
			if (Delegate == null)
				throw new ArgumentNullException ("Delegate");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithDelegate_, Delegate.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithDelegate_, Delegate.Handle);
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
		public virtual NSArray VisiblePageNumbers ()
		{
			if (IsDirectBinding) {
				return (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selVisiblePageNumbers));
			} else {
				return (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selVisiblePageNumbers));
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
		
		[CompilerGenerated]
		public PSPDFSinglePageViewController SinglePageControllerForPage (System.UInt32 page)
		{
			return (PSPDFSinglePageViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selSinglePageControllerForPage_, page));
		}
		
		[CompilerGenerated]
		public System.UInt32 FixPageNumberForDoublePageMode (System.UInt32 page, bool forceDualPageMode)
		{
			return ApiDefinition.Messaging.UInt32_objc_msgSend_UInt32_bool (this.Handle, selFixPageNumberForDoublePageModeForceDoublePageMode_, page, forceDualPageMode);
		}
		
		[CompilerGenerated]
		public PSPDFSinglePageViewController ViewControllerAfterViewController (MonoTouch.UIKit.UIViewController viewController)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			return (PSPDFSinglePageViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selViewControllerAfterViewController_, viewController.Handle));
		}
		
		[CompilerGenerated]
		public PSPDFSinglePageViewController ViewControllerBeforeViewController (MonoTouch.UIKit.UIViewController viewController)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			return (PSPDFSinglePageViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selViewControllerBeforeViewController_, viewController.Handle));
		}
		
		[CompilerGenerated]
		public void SetPageInternal (System.UInt32 page)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetPageInternal_, page);
		}
		
		[Export ("pspdfSinglePageViewControllerReadyForReuse:")]
		[CompilerGenerated]
		public virtual void PspdfSinglePageViewControllerReadyForReuse (PSPDFSinglePageViewController singlePageViewController)
		{
			if (singlePageViewController == null)
				throw new ArgumentNullException ("singlePageViewController");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selPspdfSinglePageViewControllerReadyForReuse_, singlePageViewController.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selPspdfSinglePageViewControllerReadyForReuse_, singlePageViewController.Handle);
			}
		}
		
		[Export ("pspdfSinglePageViewControllerWillDealloc:")]
		[CompilerGenerated]
		public virtual void PspdfSinglePageViewControllerWillDealloc (PSPDFSinglePageViewController singlePageViewController)
		{
			if (singlePageViewController == null)
				throw new ArgumentNullException ("singlePageViewController");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selPspdfSinglePageViewControllerWillDealloc_, singlePageViewController.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selPspdfSinglePageViewControllerWillDealloc_, singlePageViewController.Handle);
			}
		}
		
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual PSPDFTransitionHelperDelegate Delegate {
			[Export ("delegate")]
			get {
				PSPDFTransitionHelperDelegate ret;
				if (IsDirectBinding) {
					ret = (PSPDFTransitionHelperDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegate));
				} else {
					ret = (PSPDFTransitionHelperDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegate));
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret;
			}
			
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
		
		protected override void Dispose (bool disposing)
		{
			__mt_Delegate_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFTransitionHelper */
}
