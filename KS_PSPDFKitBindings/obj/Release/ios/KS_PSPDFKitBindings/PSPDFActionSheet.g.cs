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
	[Register("PSPDFActionSheet", true)]
	public unsafe partial class PSPDFActionSheet : global::MonoTouch.UIKit.UIActionSheet {
		[CompilerGenerated]
		const string selButtonCount = "buttonCount";
		static readonly IntPtr selButtonCountHandle = Selector.GetHandle ("buttonCount");
		[CompilerGenerated]
		const string selInitWithTitle_ = "initWithTitle:";
		static readonly IntPtr selInitWithTitle_Handle = Selector.GetHandle ("initWithTitle:");
		[CompilerGenerated]
		const string selSetCancelButtonWithTitleBlock_ = "setCancelButtonWithTitle:block:";
		static readonly IntPtr selSetCancelButtonWithTitleBlock_Handle = Selector.GetHandle ("setCancelButtonWithTitle:block:");
		[CompilerGenerated]
		const string selSetCancelButtonWithTitleExtendedBlock_ = "setCancelButtonWithTitle:extendedBlock:";
		static readonly IntPtr selSetCancelButtonWithTitleExtendedBlock_Handle = Selector.GetHandle ("setCancelButtonWithTitle:extendedBlock:");
		[CompilerGenerated]
		const string selSetDestructiveButtonWithTitleBlock_ = "setDestructiveButtonWithTitle:block:";
		static readonly IntPtr selSetDestructiveButtonWithTitleBlock_Handle = Selector.GetHandle ("setDestructiveButtonWithTitle:block:");
		[CompilerGenerated]
		const string selSetDestructiveButtonWithTitleExtendedBlock_ = "setDestructiveButtonWithTitle:extendedBlock:";
		static readonly IntPtr selSetDestructiveButtonWithTitleExtendedBlock_Handle = Selector.GetHandle ("setDestructiveButtonWithTitle:extendedBlock:");
		[CompilerGenerated]
		const string selAddButtonWithTitleBlock_ = "addButtonWithTitle:block:";
		static readonly IntPtr selAddButtonWithTitleBlock_Handle = Selector.GetHandle ("addButtonWithTitle:block:");
		[CompilerGenerated]
		const string selAddButtonWithTitleExtendedBlock_ = "addButtonWithTitle:extendedBlock:";
		static readonly IntPtr selAddButtonWithTitleExtendedBlock_Handle = Selector.GetHandle ("addButtonWithTitle:extendedBlock:");
		[CompilerGenerated]
		const string selShowWithSenderFallbackViewAnimated_ = "showWithSender:fallbackView:animated:";
		static readonly IntPtr selShowWithSenderFallbackViewAnimated_Handle = Selector.GetHandle ("showWithSender:fallbackView:animated:");
		[CompilerGenerated]
		const string selDestroy = "destroy";
		static readonly IntPtr selDestroyHandle = Selector.GetHandle ("destroy");
		[CompilerGenerated]
		const string selSetDestroyBlock_ = "setDestroyBlock:";
		static readonly IntPtr selSetDestroyBlock_Handle = Selector.GetHandle ("setDestroyBlock:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFActionSheet");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFActionSheet () : base (NSObjectFlag.Empty)
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
		public PSPDFActionSheet (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFActionSheet (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFActionSheet (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithTitle:")]
		[CompilerGenerated]
		public PSPDFActionSheet (string title)
			: base (NSObjectFlag.Empty)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			var nstitle = NSString.CreateNative (title);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithTitle_Handle, nstitle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithTitle_Handle, nstitle);
			}
			NSString.ReleaseNative (nstitle);
			
		}
		
		[Export ("setCancelButtonWithTitle:block:")]
		[CompilerGenerated]
		public unsafe virtual void SetCancelButtonWithTitle (string title, PSPDFActionSheetCancelButtonWithTitleBlock block)
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
			block_block.SetupBlock (static_InnerPSPDFActionSheetCancelButtonWithTitleBlock, block);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSetCancelButtonWithTitleBlock_Handle, nstitle, (IntPtr) block_ptr_block);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSetCancelButtonWithTitleBlock_Handle, nstitle, (IntPtr) block_ptr_block);
			}
			NSString.ReleaseNative (nstitle);
			block_ptr_block->CleanupBlock ();
			
		}
		
		[Export ("setCancelButtonWithTitle:extendedBlock:")]
		[CompilerGenerated]
		public unsafe virtual void SetCancelButtonWithTitle (string title, PSPDFActionSheetCancelButtonWithTitleExtendedBlock block)
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
			block_block.SetupBlock (static_InnerPSPDFActionSheetCancelButtonWithTitleExtendedBlock, block);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSetCancelButtonWithTitleExtendedBlock_Handle, nstitle, (IntPtr) block_ptr_block);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSetCancelButtonWithTitleExtendedBlock_Handle, nstitle, (IntPtr) block_ptr_block);
			}
			NSString.ReleaseNative (nstitle);
			block_ptr_block->CleanupBlock ();
			
		}
		
		[Export ("setDestructiveButtonWithTitle:block:")]
		[CompilerGenerated]
		public unsafe virtual void SetDestructiveButtonWithTitle (string title, PSPDFActionSheetDestructiveButtonWithTitleBlock block)
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
			block_block.SetupBlock (static_InnerPSPDFActionSheetDestructiveButtonWithTitleBlock, block);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSetDestructiveButtonWithTitleBlock_Handle, nstitle, (IntPtr) block_ptr_block);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSetDestructiveButtonWithTitleBlock_Handle, nstitle, (IntPtr) block_ptr_block);
			}
			NSString.ReleaseNative (nstitle);
			block_ptr_block->CleanupBlock ();
			
		}
		
		[Export ("setDestructiveButtonWithTitle:extendedBlock:")]
		[CompilerGenerated]
		public unsafe virtual void SetDestructiveButtonWithTitle (string title, PSPDFActionSheetDestructiveButtonWithTitleExtendedBlock block)
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
			block_block.SetupBlock (static_InnerPSPDFActionSheetDestructiveButtonWithTitleExtendedBlock, block);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSetDestructiveButtonWithTitleExtendedBlock_Handle, nstitle, (IntPtr) block_ptr_block);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSetDestructiveButtonWithTitleExtendedBlock_Handle, nstitle, (IntPtr) block_ptr_block);
			}
			NSString.ReleaseNative (nstitle);
			block_ptr_block->CleanupBlock ();
			
		}
		
		[Export ("addButtonWithTitle:block:")]
		[CompilerGenerated]
		public unsafe virtual void AddButtonWithTitle (string title, PSPDFActionSheetAddButtonWithTitleBlock block)
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
			block_block.SetupBlock (static_InnerPSPDFActionSheetAddButtonWithTitleBlock, block);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selAddButtonWithTitleBlock_Handle, nstitle, (IntPtr) block_ptr_block);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selAddButtonWithTitleBlock_Handle, nstitle, (IntPtr) block_ptr_block);
			}
			NSString.ReleaseNative (nstitle);
			block_ptr_block->CleanupBlock ();
			
		}
		
		[Export ("addButtonWithTitle:extendedBlock:")]
		[CompilerGenerated]
		public unsafe virtual void AddButtonWithTitle (string title, PSPDFActionSheetAddButtonWithTitleExtendedBlock block)
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
			block_block.SetupBlock (static_InnerPSPDFActionSheetAddButtonWithTitleExtendedBlock, block);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selAddButtonWithTitleExtendedBlock_Handle, nstitle, (IntPtr) block_ptr_block);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selAddButtonWithTitleExtendedBlock_Handle, nstitle, (IntPtr) block_ptr_block);
			}
			NSString.ReleaseNative (nstitle);
			block_ptr_block->CleanupBlock ();
			
		}
		
		[Export ("showWithSender:fallbackView:animated:")]
		[CompilerGenerated]
		public virtual void ShowWithSender (NSObject sender, global::MonoTouch.UIKit.UIView view, bool animated)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_bool (this.Handle, selShowWithSenderFallbackViewAnimated_Handle, sender == null ? IntPtr.Zero : sender.Handle, view.Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_bool (this.SuperHandle, selShowWithSenderFallbackViewAnimated_Handle, sender == null ? IntPtr.Zero : sender.Handle, view.Handle, animated);
			}
		}
		
		[Export ("destroy")]
		[CompilerGenerated]
		public virtual void Destroy ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDestroyHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selDestroyHandle);
			}
		}
		
		[Export ("setDestroyBlock:")]
		[CompilerGenerated]
		public unsafe virtual void SetDestroyBlock (PSPDFActionSheetSetDestroyBlock block)
		{
			if (block == null)
				throw new ArgumentNullException ("block");
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlock (static_InnerPSPDFActionSheetSetDestroyBlock, block);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDestroyBlock_Handle, (IntPtr) block_ptr_block);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDestroyBlock_Handle, (IntPtr) block_ptr_block);
			}
			block_ptr_block->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public new virtual global::System.UInt32 ButtonCount {
			[Export ("buttonCount")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selButtonCountHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selButtonCountHandle);
				}
			}
			
		}
		
		internal delegate void InnerPSPDFActionSheetCancelButtonWithTitleBlock (IntPtr block);
		[CompilerGenerated]
		static readonly InnerPSPDFActionSheetCancelButtonWithTitleBlock static_InnerPSPDFActionSheetCancelButtonWithTitleBlock = TrampolinePSPDFActionSheetCancelButtonWithTitleBlock;
		[MonoPInvokeCallback (typeof (InnerPSPDFActionSheetCancelButtonWithTitleBlock))]
		static unsafe void TrampolinePSPDFActionSheetCancelButtonWithTitleBlock (IntPtr block) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::KS_PSPDFKitBindings.PSPDFActionSheetCancelButtonWithTitleBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ();
		}
		
		internal delegate void InnerPSPDFActionSheetCancelButtonWithTitleExtendedBlock (IntPtr block, IntPtr sheet, int buttonIndex);
		[CompilerGenerated]
		static readonly InnerPSPDFActionSheetCancelButtonWithTitleExtendedBlock static_InnerPSPDFActionSheetCancelButtonWithTitleExtendedBlock = TrampolinePSPDFActionSheetCancelButtonWithTitleExtendedBlock;
		[MonoPInvokeCallback (typeof (InnerPSPDFActionSheetCancelButtonWithTitleExtendedBlock))]
		static unsafe void TrampolinePSPDFActionSheetCancelButtonWithTitleExtendedBlock (IntPtr block, IntPtr sheet, int buttonIndex) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::KS_PSPDFKitBindings.PSPDFActionSheetCancelButtonWithTitleExtendedBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((KS_PSPDFKitBindings.PSPDFActionSheet) Runtime.GetNSObject (sheet), buttonIndex);
		}
		
		internal delegate void InnerPSPDFActionSheetDestructiveButtonWithTitleBlock (IntPtr block);
		[CompilerGenerated]
		static readonly InnerPSPDFActionSheetDestructiveButtonWithTitleBlock static_InnerPSPDFActionSheetDestructiveButtonWithTitleBlock = TrampolinePSPDFActionSheetDestructiveButtonWithTitleBlock;
		[MonoPInvokeCallback (typeof (InnerPSPDFActionSheetDestructiveButtonWithTitleBlock))]
		static unsafe void TrampolinePSPDFActionSheetDestructiveButtonWithTitleBlock (IntPtr block) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::KS_PSPDFKitBindings.PSPDFActionSheetDestructiveButtonWithTitleBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ();
		}
		
		internal delegate void InnerPSPDFActionSheetDestructiveButtonWithTitleExtendedBlock (IntPtr block, IntPtr sheet, int buttonIndex);
		[CompilerGenerated]
		static readonly InnerPSPDFActionSheetDestructiveButtonWithTitleExtendedBlock static_InnerPSPDFActionSheetDestructiveButtonWithTitleExtendedBlock = TrampolinePSPDFActionSheetDestructiveButtonWithTitleExtendedBlock;
		[MonoPInvokeCallback (typeof (InnerPSPDFActionSheetDestructiveButtonWithTitleExtendedBlock))]
		static unsafe void TrampolinePSPDFActionSheetDestructiveButtonWithTitleExtendedBlock (IntPtr block, IntPtr sheet, int buttonIndex) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::KS_PSPDFKitBindings.PSPDFActionSheetDestructiveButtonWithTitleExtendedBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((KS_PSPDFKitBindings.PSPDFActionSheet) Runtime.GetNSObject (sheet), buttonIndex);
		}
		
		internal delegate void InnerPSPDFActionSheetAddButtonWithTitleBlock (IntPtr block);
		[CompilerGenerated]
		static readonly InnerPSPDFActionSheetAddButtonWithTitleBlock static_InnerPSPDFActionSheetAddButtonWithTitleBlock = TrampolinePSPDFActionSheetAddButtonWithTitleBlock;
		[MonoPInvokeCallback (typeof (InnerPSPDFActionSheetAddButtonWithTitleBlock))]
		static unsafe void TrampolinePSPDFActionSheetAddButtonWithTitleBlock (IntPtr block) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::KS_PSPDFKitBindings.PSPDFActionSheetAddButtonWithTitleBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ();
		}
		
		internal delegate void InnerPSPDFActionSheetAddButtonWithTitleExtendedBlock (IntPtr block, IntPtr sheet, int buttonIndex);
		[CompilerGenerated]
		static readonly InnerPSPDFActionSheetAddButtonWithTitleExtendedBlock static_InnerPSPDFActionSheetAddButtonWithTitleExtendedBlock = TrampolinePSPDFActionSheetAddButtonWithTitleExtendedBlock;
		[MonoPInvokeCallback (typeof (InnerPSPDFActionSheetAddButtonWithTitleExtendedBlock))]
		static unsafe void TrampolinePSPDFActionSheetAddButtonWithTitleExtendedBlock (IntPtr block, IntPtr sheet, int buttonIndex) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::KS_PSPDFKitBindings.PSPDFActionSheetAddButtonWithTitleExtendedBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((KS_PSPDFKitBindings.PSPDFActionSheet) Runtime.GetNSObject (sheet), buttonIndex);
		}
		
		internal delegate void InnerPSPDFActionSheetSetDestroyBlock (IntPtr block, IntPtr sheet, int buttonIndex);
		[CompilerGenerated]
		static readonly InnerPSPDFActionSheetSetDestroyBlock static_InnerPSPDFActionSheetSetDestroyBlock = TrampolinePSPDFActionSheetSetDestroyBlock;
		[MonoPInvokeCallback (typeof (InnerPSPDFActionSheetSetDestroyBlock))]
		static unsafe void TrampolinePSPDFActionSheetSetDestroyBlock (IntPtr block, IntPtr sheet, int buttonIndex) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::KS_PSPDFKitBindings.PSPDFActionSheetSetDestroyBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((KS_PSPDFKitBindings.PSPDFActionSheet) Runtime.GetNSObject (sheet), buttonIndex);
		}
		
	} /* class PSPDFActionSheet */
	public delegate void PSPDFActionSheetCancelButtonWithTitleBlock ();
	public delegate void PSPDFActionSheetCancelButtonWithTitleExtendedBlock (PSPDFActionSheet sheet, int buttonIndex);
	public delegate void PSPDFActionSheetDestructiveButtonWithTitleBlock ();
	public delegate void PSPDFActionSheetDestructiveButtonWithTitleExtendedBlock (PSPDFActionSheet sheet, int buttonIndex);
	public delegate void PSPDFActionSheetAddButtonWithTitleBlock ();
	public delegate void PSPDFActionSheetAddButtonWithTitleExtendedBlock (PSPDFActionSheet sheet, int buttonIndex);
	public delegate void PSPDFActionSheetSetDestroyBlock (PSPDFActionSheet sheet, int buttonIndex);
}
