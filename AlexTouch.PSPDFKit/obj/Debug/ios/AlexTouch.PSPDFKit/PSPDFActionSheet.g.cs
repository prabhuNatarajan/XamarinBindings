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
	[Register("PSPDFActionSheet", true)]
	public unsafe partial class PSPDFActionSheet : MonoTouch.UIKit.UIActionSheet {
		static readonly IntPtr selButtonCount = Selector.GetHandle ("buttonCount");
		static readonly IntPtr selInitWithTitle_ = Selector.GetHandle ("initWithTitle:");
		static readonly IntPtr selSetCancelButtonWithTitleBlock_ = Selector.GetHandle ("setCancelButtonWithTitle:block:");
		static readonly IntPtr selSetDestructiveButtonWithTitleBlock_ = Selector.GetHandle ("setDestructiveButtonWithTitle:block:");
		static readonly IntPtr selAddButtonWithTitleBlock_ = Selector.GetHandle ("addButtonWithTitle:block:");
		static readonly IntPtr selDestroy = Selector.GetHandle ("destroy");
		static readonly IntPtr selSetDestroyBlock_ = Selector.GetHandle ("setDestroyBlock:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFActionSheet");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFActionSheet () : base (NSObjectFlag.Empty)
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
		public PSPDFActionSheet (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFActionSheet (IntPtr handle) : base (handle) {}

		[Export ("initWithTitle:")]
		[CompilerGenerated]
		public PSPDFActionSheet (string title) : base (NSObjectFlag.Empty)
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
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSetCancelButtonWithTitleBlock_, nstitle, (IntPtr) block_ptr_block);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSetCancelButtonWithTitleBlock_, nstitle, (IntPtr) block_ptr_block);
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
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSetDestructiveButtonWithTitleBlock_, nstitle, (IntPtr) block_ptr_block);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSetDestructiveButtonWithTitleBlock_, nstitle, (IntPtr) block_ptr_block);
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
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selAddButtonWithTitleBlock_, nstitle, (IntPtr) block_ptr_block);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selAddButtonWithTitleBlock_, nstitle, (IntPtr) block_ptr_block);
			}
			NSString.ReleaseNative (nstitle);
			block_ptr_block->CleanupBlock ();
			
		}
		
		[Export ("destroy")]
		[CompilerGenerated]
		public virtual void Destroy ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDestroy);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selDestroy);
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
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDestroyBlock_, (IntPtr) block_ptr_block);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDestroyBlock_, (IntPtr) block_ptr_block);
			}
			block_ptr_block->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public new virtual System.UInt32 ButtonCount {
			[Export ("buttonCount")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selButtonCount);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selButtonCount);
				}
			}
			
		}
		
		internal delegate void InnerPSPDFActionSheetCancelButtonWithTitleBlock (IntPtr block);
		static InnerPSPDFActionSheetCancelButtonWithTitleBlock static_InnerPSPDFActionSheetCancelButtonWithTitleBlock = new InnerPSPDFActionSheetCancelButtonWithTitleBlock (TrampolinePSPDFActionSheetCancelButtonWithTitleBlock);
		[MonoPInvokeCallback (typeof (InnerPSPDFActionSheetCancelButtonWithTitleBlock))]
		static unsafe void TrampolinePSPDFActionSheetCancelButtonWithTitleBlock (IntPtr block) {
			var descriptor = (BlockLiteral *) block;
			var del = (AlexTouch.PSPDFKit.PSPDFActionSheetCancelButtonWithTitleBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ();
		}
		
		internal delegate void InnerPSPDFActionSheetDestructiveButtonWithTitleBlock (IntPtr block);
		static InnerPSPDFActionSheetDestructiveButtonWithTitleBlock static_InnerPSPDFActionSheetDestructiveButtonWithTitleBlock = new InnerPSPDFActionSheetDestructiveButtonWithTitleBlock (TrampolinePSPDFActionSheetDestructiveButtonWithTitleBlock);
		[MonoPInvokeCallback (typeof (InnerPSPDFActionSheetDestructiveButtonWithTitleBlock))]
		static unsafe void TrampolinePSPDFActionSheetDestructiveButtonWithTitleBlock (IntPtr block) {
			var descriptor = (BlockLiteral *) block;
			var del = (AlexTouch.PSPDFKit.PSPDFActionSheetDestructiveButtonWithTitleBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ();
		}
		
		internal delegate void InnerPSPDFActionSheetAddButtonWithTitleBlock (IntPtr block);
		static InnerPSPDFActionSheetAddButtonWithTitleBlock static_InnerPSPDFActionSheetAddButtonWithTitleBlock = new InnerPSPDFActionSheetAddButtonWithTitleBlock (TrampolinePSPDFActionSheetAddButtonWithTitleBlock);
		[MonoPInvokeCallback (typeof (InnerPSPDFActionSheetAddButtonWithTitleBlock))]
		static unsafe void TrampolinePSPDFActionSheetAddButtonWithTitleBlock (IntPtr block) {
			var descriptor = (BlockLiteral *) block;
			var del = (AlexTouch.PSPDFKit.PSPDFActionSheetAddButtonWithTitleBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ();
		}
		
		internal delegate void InnerPSPDFActionSheetSetDestroyBlock (IntPtr block);
		static InnerPSPDFActionSheetSetDestroyBlock static_InnerPSPDFActionSheetSetDestroyBlock = new InnerPSPDFActionSheetSetDestroyBlock (TrampolinePSPDFActionSheetSetDestroyBlock);
		[MonoPInvokeCallback (typeof (InnerPSPDFActionSheetSetDestroyBlock))]
		static unsafe void TrampolinePSPDFActionSheetSetDestroyBlock (IntPtr block) {
			var descriptor = (BlockLiteral *) block;
			var del = (AlexTouch.PSPDFKit.PSPDFActionSheetSetDestroyBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ();
		}
		
	} /* class PSPDFActionSheet */
	public delegate void PSPDFActionSheetCancelButtonWithTitleBlock ();
	public delegate void PSPDFActionSheetDestructiveButtonWithTitleBlock ();
	public delegate void PSPDFActionSheetAddButtonWithTitleBlock ();
	public delegate void PSPDFActionSheetSetDestroyBlock ();
}
