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
	[Register("PSPDFTransitionHelper", true)]
	public unsafe partial class PSPDFTransitionHelper : NSObject {
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selPage = "page";
		static readonly IntPtr selPageHandle = Selector.GetHandle ("page");
		[CompilerGenerated]
		const string selInitWithDelegate_ = "initWithDelegate:";
		static readonly IntPtr selInitWithDelegate_Handle = Selector.GetHandle ("initWithDelegate:");
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
		const string selSinglePageControllerForPage_ = "singlePageControllerForPage:";
		static readonly IntPtr selSinglePageControllerForPage_Handle = Selector.GetHandle ("singlePageControllerForPage:");
		[CompilerGenerated]
		const string selFixPageNumberForDoublePageModeForceDoublePageMode_ = "fixPageNumberForDoublePageMode:forceDoublePageMode:";
		static readonly IntPtr selFixPageNumberForDoublePageModeForceDoublePageMode_Handle = Selector.GetHandle ("fixPageNumberForDoublePageMode:forceDoublePageMode:");
		[CompilerGenerated]
		const string selViewControllerAfterViewController_ = "viewControllerAfterViewController:";
		static readonly IntPtr selViewControllerAfterViewController_Handle = Selector.GetHandle ("viewControllerAfterViewController:");
		[CompilerGenerated]
		const string selViewControllerBeforeViewController_ = "viewControllerBeforeViewController:";
		static readonly IntPtr selViewControllerBeforeViewController_Handle = Selector.GetHandle ("viewControllerBeforeViewController:");
		[CompilerGenerated]
		const string selSetPageInternal_ = "setPageInternal:";
		static readonly IntPtr selSetPageInternal_Handle = Selector.GetHandle ("setPageInternal:");
		[CompilerGenerated]
		const string selPspdfSinglePageViewControllerReadyForReuse_ = "pspdfSinglePageViewControllerReadyForReuse:";
		static readonly IntPtr selPspdfSinglePageViewControllerReadyForReuse_Handle = Selector.GetHandle ("pspdfSinglePageViewControllerReadyForReuse:");
		[CompilerGenerated]
		const string selPspdfSinglePageViewControllerWillDealloc_ = "pspdfSinglePageViewControllerWillDealloc:";
		static readonly IntPtr selPspdfSinglePageViewControllerWillDealloc_Handle = Selector.GetHandle ("pspdfSinglePageViewControllerWillDealloc:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFTransitionHelper");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFTransitionHelper () : base (NSObjectFlag.Empty)
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
		public PSPDFTransitionHelper (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFTransitionHelper (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDelegate:")]
		[CompilerGenerated]
		public PSPDFTransitionHelper (PSPDFTransitionHelperDelegate Delegate)
			: base (NSObjectFlag.Empty)
		{
			if (Delegate == null)
				throw new ArgumentNullException ("Delegate");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithDelegate_Handle, Delegate.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithDelegate_Handle, Delegate.Handle);
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
		
		[CompilerGenerated]
		public PSPDFSinglePageViewController SinglePageControllerForPage (global::System.UInt32 page)
		{
			return (PSPDFSinglePageViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selSinglePageControllerForPage_Handle, page));
		}
		
		[CompilerGenerated]
		public global::System.UInt32 FixPageNumberForDoublePageMode (global::System.UInt32 page, bool forceDualPageMode)
		{
			return ApiDefinition.Messaging.UInt32_objc_msgSend_UInt32_bool (this.Handle, selFixPageNumberForDoublePageModeForceDoublePageMode_Handle, page, forceDualPageMode);
		}
		
		[CompilerGenerated]
		public PSPDFSinglePageViewController ViewControllerAfterViewController (global::MonoTouch.UIKit.UIViewController viewController)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			return (PSPDFSinglePageViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selViewControllerAfterViewController_Handle, viewController.Handle));
		}
		
		[CompilerGenerated]
		public PSPDFSinglePageViewController ViewControllerBeforeViewController (global::MonoTouch.UIKit.UIViewController viewController)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			return (PSPDFSinglePageViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selViewControllerBeforeViewController_Handle, viewController.Handle));
		}
		
		[CompilerGenerated]
		public void SetPageInternal (global::System.UInt32 page)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetPageInternal_Handle, page);
		}
		
		[Export ("pspdfSinglePageViewControllerReadyForReuse:")]
		[CompilerGenerated]
		public virtual void PspdfSinglePageViewControllerReadyForReuse (PSPDFSinglePageViewController singlePageViewController)
		{
			if (singlePageViewController == null)
				throw new ArgumentNullException ("singlePageViewController");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selPspdfSinglePageViewControllerReadyForReuse_Handle, singlePageViewController.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selPspdfSinglePageViewControllerReadyForReuse_Handle, singlePageViewController.Handle);
			}
		}
		
		[Export ("pspdfSinglePageViewControllerWillDealloc:")]
		[CompilerGenerated]
		public virtual void PspdfSinglePageViewControllerWillDealloc (PSPDFSinglePageViewController singlePageViewController)
		{
			if (singlePageViewController == null)
				throw new ArgumentNullException ("singlePageViewController");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selPspdfSinglePageViewControllerWillDealloc_Handle, singlePageViewController.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selPspdfSinglePageViewControllerWillDealloc_Handle, singlePageViewController.Handle);
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual PSPDFTransitionHelperDelegate Delegate {
			[Export ("delegate")]
			get {
				PSPDFTransitionHelperDelegate ret;
				if (IsDirectBinding) {
					ret = (PSPDFTransitionHelperDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret = (PSPDFTransitionHelperDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret;
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
			
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
			}
		}
	} /* class PSPDFTransitionHelper */
}
