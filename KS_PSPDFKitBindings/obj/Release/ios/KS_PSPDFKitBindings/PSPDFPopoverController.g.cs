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
	[Register("PSPDFPopoverController", true)]
	public unsafe partial class PSPDFPopoverController : global::MonoTouch.UIKit.UIPopoverController {
		[CompilerGenerated]
		const string selTintColor = "tintColor";
		static readonly IntPtr selTintColorHandle = Selector.GetHandle ("tintColor");
		[CompilerGenerated]
		const string selSetTintColor_ = "setTintColor:";
		static readonly IntPtr selSetTintColor_Handle = Selector.GetHandle ("setTintColor:");
		[CompilerGenerated]
		const string selInitWithContentViewController_ = "initWithContentViewController:";
		static readonly IntPtr selInitWithContentViewController_Handle = Selector.GetHandle ("initWithContentViewController:");
		[CompilerGenerated]
		const string selNotifyContentControllerAboutDismissalAnimated_ = "notifyContentControllerAboutDismissalAnimated:";
		static readonly IntPtr selNotifyContentControllerAboutDismissalAnimated_Handle = Selector.GetHandle ("notifyContentControllerAboutDismissalAnimated:");
		[CompilerGenerated]
		const string selSetPopoverWillDismissAction_ = "setPopoverWillDismissAction:";
		static readonly IntPtr selSetPopoverWillDismissAction_Handle = Selector.GetHandle ("setPopoverWillDismissAction:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFPopoverController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFPopoverController () : base (NSObjectFlag.Empty)
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
		public PSPDFPopoverController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFPopoverController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFPopoverController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithContentViewController:")]
		[CompilerGenerated]
		public PSPDFPopoverController (global::MonoTouch.UIKit.UIViewController controller)
			: base (NSObjectFlag.Empty)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithContentViewController_Handle, controller.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithContentViewController_Handle, controller.Handle);
			}
		}
		
		[Export ("notifyContentControllerAboutDismissalAnimated:")]
		[CompilerGenerated]
		public virtual void NotifyContentControllerAboutDismissalAnimated (bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selNotifyContentControllerAboutDismissalAnimated_Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selNotifyContentControllerAboutDismissalAnimated_Handle, animated);
			}
		}
		
		[Export ("setPopoverWillDismissAction:")]
		[CompilerGenerated]
		public unsafe virtual void SetPopoverWillDismissAction (dispatch_callback_t popoverWillDismissAction)
		{
			if (popoverWillDismissAction == null)
				throw new ArgumentNullException ("popoverWillDismissAction");
			BlockLiteral *block_ptr_popoverWillDismissAction;
			BlockLiteral block_popoverWillDismissAction;
			block_popoverWillDismissAction = new BlockLiteral ();
			block_ptr_popoverWillDismissAction = &block_popoverWillDismissAction;
			block_popoverWillDismissAction.SetupBlock (static_Innerdispatch_callback_t, popoverWillDismissAction);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPopoverWillDismissAction_Handle, (IntPtr) block_ptr_popoverWillDismissAction);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPopoverWillDismissAction_Handle, (IntPtr) block_ptr_popoverWillDismissAction);
			}
			block_ptr_popoverWillDismissAction->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		object __mt_TintColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor TintColor {
			[Export ("tintColor")]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTintColorHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTintColorHandle));
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
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTintColor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTintColor_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_TintColor_var = value;
			}
		}
		
		internal delegate void Innerdispatch_callback_t (IntPtr block);
		[CompilerGenerated]
		static readonly Innerdispatch_callback_t static_Innerdispatch_callback_t = Trampolinedispatch_callback_t;
		[MonoPInvokeCallback (typeof (Innerdispatch_callback_t))]
		static unsafe void Trampolinedispatch_callback_t (IntPtr block) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::KS_PSPDFKitBindings.dispatch_callback_t) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ();
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_TintColor_var = null;
			}
		}
	} /* class PSPDFPopoverController */
	public delegate void dispatch_callback_t ();
}
