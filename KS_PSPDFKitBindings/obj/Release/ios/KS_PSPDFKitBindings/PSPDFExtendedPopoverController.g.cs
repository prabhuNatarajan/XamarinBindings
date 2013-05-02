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
	[Register("PSPDFExtendedPopoverController", true)]
	public unsafe partial class PSPDFExtendedPopoverController : global::MonoTouch.UIKit.UIPopoverController {
		[CompilerGenerated]
		const string selSetPopoverWillDismissAction_ = "setPopoverWillDismissAction:";
		static readonly IntPtr selSetPopoverWillDismissAction_Handle = Selector.GetHandle ("setPopoverWillDismissAction:");
		[CompilerGenerated]
		const string selNotifyContentControllerAboutDismissalAnimated_ = "notifyContentControllerAboutDismissalAnimated:";
		static readonly IntPtr selNotifyContentControllerAboutDismissalAnimated_Handle = Selector.GetHandle ("notifyContentControllerAboutDismissalAnimated:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFExtendedPopoverController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFExtendedPopoverController () : base (NSObjectFlag.Empty)
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
		public PSPDFExtendedPopoverController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFExtendedPopoverController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFExtendedPopoverController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setPopoverWillDismissAction:")]
		[CompilerGenerated]
		public unsafe virtual void SetPopoverWillDismissAction (dispatch_block_t handler)
		{
			if (handler == null)
				throw new ArgumentNullException ("handler");
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlock (static_Innerdispatch_block_t, handler);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPopoverWillDismissAction_Handle, (IntPtr) block_ptr_handler);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPopoverWillDismissAction_Handle, (IntPtr) block_ptr_handler);
			}
			block_ptr_handler->CleanupBlock ();
			
		}
		
		[Export ("notifyContentControllerAboutDismissalAnimated:")]
		[CompilerGenerated]
		public virtual void NotifyContentControllerAboutDismissal (bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selNotifyContentControllerAboutDismissalAnimated_Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selNotifyContentControllerAboutDismissalAnimated_Handle, animated);
			}
		}
		
		internal delegate void Innerdispatch_block_t (IntPtr block);
		[CompilerGenerated]
		static readonly Innerdispatch_block_t static_Innerdispatch_block_t = Trampolinedispatch_block_t;
		[MonoPInvokeCallback (typeof (Innerdispatch_block_t))]
		static unsafe void Trampolinedispatch_block_t (IntPtr block) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::KS_PSPDFKitBindings.dispatch_block_t) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ();
		}
		
	} /* class PSPDFExtendedPopoverController */
	public delegate void dispatch_block_t ();
}
