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
	[Register("PSPDFSimplePageViewController", true)]
	public unsafe partial class PSPDFSimplePageViewController : PSPDFBaseViewController {
		[CompilerGenerated]
		const string selPage = "page";
		static readonly IntPtr selPageHandle = Selector.GetHandle ("page");
		[CompilerGenerated]
		const string selSetPage_ = "setPage:";
		static readonly IntPtr selSetPage_Handle = Selector.GetHandle ("setPage:");
		[CompilerGenerated]
		const string selScrollView = "scrollView";
		static readonly IntPtr selScrollViewHandle = Selector.GetHandle ("scrollView");
		[CompilerGenerated]
		const string selPageControl = "pageControl";
		static readonly IntPtr selPageControlHandle = Selector.GetHandle ("pageControl");
		[CompilerGenerated]
		const string selInitWithViewControllers_ = "initWithViewControllers:";
		static readonly IntPtr selInitWithViewControllers_Handle = Selector.GetHandle ("initWithViewControllers:");
		[CompilerGenerated]
		const string selSetPageAnimated_ = "setPage:animated:";
		static readonly IntPtr selSetPageAnimated_Handle = Selector.GetHandle ("setPage:animated:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSimplePageViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFSimplePageViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFSimplePageViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFSimplePageViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFSimplePageViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithViewControllers:")]
		[CompilerGenerated]
		public PSPDFSimplePageViewController (NSObject[] viewControllers)
			: base (NSObjectFlag.Empty)
		{
			if (viewControllers == null)
				throw new ArgumentNullException ("viewControllers");
			var nsa_viewControllers = NSArray.FromNSObjects (viewControllers);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithViewControllers_Handle, nsa_viewControllers.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithViewControllers_Handle, nsa_viewControllers.Handle);
			}
			nsa_viewControllers.Dispose ();
			
		}
		
		[Export ("setPage:animated:")]
		[CompilerGenerated]
		public virtual void ChangePage (global::System.UInt32 page, bool animated)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_UInt32_bool (this.Handle, selSetPageAnimated_Handle, page, animated);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32_bool (this.SuperHandle, selSetPageAnimated_Handle, page, animated);
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
		object __mt_ScrollView_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIScrollView ScrollView {
			[Export ("scrollView")]
			get {
				global::MonoTouch.UIKit.UIScrollView ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIScrollView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selScrollViewHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIScrollView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selScrollViewHandle));
				}
				MarkDirty ();
				__mt_ScrollView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PageControl_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIPageControl PageControl {
			[Export ("pageControl")]
			get {
				global::MonoTouch.UIKit.UIPageControl ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIPageControl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPageControlHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIPageControl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPageControlHandle));
				}
				MarkDirty ();
				__mt_PageControl_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ScrollView_var = null;
				__mt_PageControl_var = null;
			}
		}
	} /* class PSPDFSimplePageViewController */
}
