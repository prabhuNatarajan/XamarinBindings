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
	[Register("PSPDFAlertView", true)]
	public unsafe partial class PSPDFAlertView : MonoTouch.UIKit.UIAlertView {
		static readonly IntPtr selInitWithTitle_ = Selector.GetHandle ("initWithTitle:");
		static readonly IntPtr selInitWithTitleMessage_ = Selector.GetHandle ("initWithTitle:message:");
		static readonly IntPtr selSetCancelButtonWithTitleBlock_ = Selector.GetHandle ("setCancelButtonWithTitle:block:");
		static readonly IntPtr selAddButtonWithTitleBlock_ = Selector.GetHandle ("addButtonWithTitle:block:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFAlertView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFAlertView () : base (NSObjectFlag.Empty)
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
		public PSPDFAlertView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFAlertView (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFAlertView (IntPtr handle) : base (handle) {}

		[Export ("initWithTitle:")]
		[CompilerGenerated]
		public PSPDFAlertView (string title) : base (NSObjectFlag.Empty)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			var nstitle = NSString.CreateNative (title);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithTitle_, nstitle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithTitle_, nstitle);
			}
			NSString.ReleaseNative (nstitle);
			
		}
		
		[Export ("initWithTitle:message:")]
		[CompilerGenerated]
		public PSPDFAlertView (string title, string message) : base (NSObjectFlag.Empty)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			if (message == null)
				throw new ArgumentNullException ("message");
			var nstitle = NSString.CreateNative (title);
			var nsmessage = NSString.CreateNative (message);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithTitleMessage_, nstitle, nsmessage);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithTitleMessage_, nstitle, nsmessage);
			}
			NSString.ReleaseNative (nstitle);
			NSString.ReleaseNative (nsmessage);
			
		}
		
		[Export ("setCancelButtonWithTitle:block:")]
		[CompilerGenerated]
		public unsafe virtual void SetCancelButtonWithTitle (string title, PSPDFAlertViewCancelButtonWithTitleBlock block)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			if (block == null)
				throw new ArgumentNullException ("block");
			var nstitle = NSString.CreateNative (title);
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlock (static_InnerPSPDFAlertViewCancelButtonWithTitleBlock, block);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSetCancelButtonWithTitleBlock_, nstitle, (IntPtr) block_ptr_block);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSetCancelButtonWithTitleBlock_, nstitle, (IntPtr) block_ptr_block);
			}
			NSString.ReleaseNative (nstitle);
			block_ptr_block->CleanupBlock ();
			
		}
		
		[Export ("addButtonWithTitle:block:")]
		[CompilerGenerated]
		public unsafe virtual void AddButtonWithTitle (string title, PSPDFAlertViewAddButtonWithTitleBlock block)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			if (block == null)
				throw new ArgumentNullException ("block");
			var nstitle = NSString.CreateNative (title);
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlock (static_InnerPSPDFAlertViewAddButtonWithTitleBlock, block);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selAddButtonWithTitleBlock_, nstitle, (IntPtr) block_ptr_block);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selAddButtonWithTitleBlock_, nstitle, (IntPtr) block_ptr_block);
			}
			NSString.ReleaseNative (nstitle);
			block_ptr_block->CleanupBlock ();
			
		}
		
		internal delegate void InnerPSPDFAlertViewCancelButtonWithTitleBlock (IntPtr block);
		static InnerPSPDFAlertViewCancelButtonWithTitleBlock static_InnerPSPDFAlertViewCancelButtonWithTitleBlock = new InnerPSPDFAlertViewCancelButtonWithTitleBlock (TrampolinePSPDFAlertViewCancelButtonWithTitleBlock);
		[MonoPInvokeCallback (typeof (InnerPSPDFAlertViewCancelButtonWithTitleBlock))]
		static unsafe void TrampolinePSPDFAlertViewCancelButtonWithTitleBlock (IntPtr block) {
			var descriptor = (BlockLiteral *) block;
			var del = (AlexTouch.PSPDFKit.PSPDFAlertViewCancelButtonWithTitleBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ();
		}
		
		internal delegate void InnerPSPDFAlertViewAddButtonWithTitleBlock (IntPtr block);
		static InnerPSPDFAlertViewAddButtonWithTitleBlock static_InnerPSPDFAlertViewAddButtonWithTitleBlock = new InnerPSPDFAlertViewAddButtonWithTitleBlock (TrampolinePSPDFAlertViewAddButtonWithTitleBlock);
		[MonoPInvokeCallback (typeof (InnerPSPDFAlertViewAddButtonWithTitleBlock))]
		static unsafe void TrampolinePSPDFAlertViewAddButtonWithTitleBlock (IntPtr block) {
			var descriptor = (BlockLiteral *) block;
			var del = (AlexTouch.PSPDFKit.PSPDFAlertViewAddButtonWithTitleBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ();
		}
		
	} /* class PSPDFAlertView */
	public delegate void PSPDFAlertViewCancelButtonWithTitleBlock ();
	public delegate void PSPDFAlertViewAddButtonWithTitleBlock ();
}
