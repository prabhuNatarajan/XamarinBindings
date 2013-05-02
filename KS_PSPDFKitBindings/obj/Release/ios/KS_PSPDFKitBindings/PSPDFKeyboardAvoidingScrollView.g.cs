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
	[Register("PSPDFKeyboardAvoidingScrollView", true)]
	public unsafe partial class PSPDFKeyboardAvoidingScrollView : global::MonoTouch.UIKit.UIScrollView {
		[CompilerGenerated]
		const string selIsKeyboardVisible = "isKeyboardVisible";
		static readonly IntPtr selIsKeyboardVisibleHandle = Selector.GetHandle ("isKeyboardVisible");
		[CompilerGenerated]
		const string selFirstResponderIsTextInput = "firstResponderIsTextInput";
		static readonly IntPtr selFirstResponderIsTextInputHandle = Selector.GetHandle ("firstResponderIsTextInput");
		[CompilerGenerated]
		const string selEnableKeyboardAvoidance = "enableKeyboardAvoidance";
		static readonly IntPtr selEnableKeyboardAvoidanceHandle = Selector.GetHandle ("enableKeyboardAvoidance");
		[CompilerGenerated]
		const string selSetEnableKeyboardAvoidance_ = "setEnableKeyboardAvoidance:";
		static readonly IntPtr selSetEnableKeyboardAvoidance_Handle = Selector.GetHandle ("setEnableKeyboardAvoidance:");
		[CompilerGenerated]
		const string selResignFirstResponderIfInsideView = "resignFirstResponderIfInsideView";
		static readonly IntPtr selResignFirstResponderIfInsideViewHandle = Selector.GetHandle ("resignFirstResponderIfInsideView");
		[CompilerGenerated]
		const string selSetKeyboardWillShowBlock_ = "setKeyboardWillShowBlock:";
		static readonly IntPtr selSetKeyboardWillShowBlock_Handle = Selector.GetHandle ("setKeyboardWillShowBlock:");
		[CompilerGenerated]
		const string selSetKeyboardWillHideBlock_ = "setKeyboardWillHideBlock:";
		static readonly IntPtr selSetKeyboardWillHideBlock_Handle = Selector.GetHandle ("setKeyboardWillHideBlock:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFKeyboardAvoidingScrollView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFKeyboardAvoidingScrollView () : base (NSObjectFlag.Empty)
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
		public PSPDFKeyboardAvoidingScrollView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFKeyboardAvoidingScrollView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFKeyboardAvoidingScrollView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("resignFirstResponderIfInsideView")]
		[CompilerGenerated]
		public virtual bool ResignFirstResponderIfInsideView ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selResignFirstResponderIfInsideViewHandle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selResignFirstResponderIfInsideViewHandle);
			}
		}
		
		[Export ("setKeyboardWillShowBlock:")]
		[CompilerGenerated]
		public unsafe virtual bool SetKeyboardWillShowHandler (PSPDFKeyboardAvoidingScrollViewKeyboardWillShowHandler handler)
		{
			if (handler == null)
				throw new ArgumentNullException ("handler");
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlock (static_InnerPSPDFKeyboardAvoidingScrollViewKeyboardWillShowHandler, handler);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selSetKeyboardWillShowBlock_Handle, (IntPtr) block_ptr_handler);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetKeyboardWillShowBlock_Handle, (IntPtr) block_ptr_handler);
			}
			block_ptr_handler->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("setKeyboardWillHideBlock:")]
		[CompilerGenerated]
		public unsafe virtual bool SetKeyboardWillHideHandler (PSPDFKeyboardAvoidingScrollViewKeyboardWillShowHandler handler)
		{
			if (handler == null)
				throw new ArgumentNullException ("handler");
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlock (static_InnerPSPDFKeyboardAvoidingScrollViewKeyboardWillShowHandler, handler);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selSetKeyboardWillHideBlock_Handle, (IntPtr) block_ptr_handler);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetKeyboardWillHideBlock_Handle, (IntPtr) block_ptr_handler);
			}
			block_ptr_handler->CleanupBlock ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public virtual bool KeyboardVisible {
			[Export ("isKeyboardVisible", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsKeyboardVisibleHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsKeyboardVisibleHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool FirstResponderIsTextInput {
			[Export ("firstResponderIsTextInput", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selFirstResponderIsTextInputHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selFirstResponderIsTextInputHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool EnableKeyboardAvoidance {
			[Export ("enableKeyboardAvoidance", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selEnableKeyboardAvoidanceHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selEnableKeyboardAvoidanceHandle);
				}
			}
			
			[Export ("setEnableKeyboardAvoidance:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetEnableKeyboardAvoidance_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetEnableKeyboardAvoidance_Handle, value);
				}
			}
		}
		
		internal delegate void InnerPSPDFKeyboardAvoidingScrollViewKeyboardWillShowHandler (IntPtr block, IntPtr keyboard, IntPtr notification);
		[CompilerGenerated]
		static readonly InnerPSPDFKeyboardAvoidingScrollViewKeyboardWillShowHandler static_InnerPSPDFKeyboardAvoidingScrollViewKeyboardWillShowHandler = TrampolinePSPDFKeyboardAvoidingScrollViewKeyboardWillShowHandler;
		[MonoPInvokeCallback (typeof (InnerPSPDFKeyboardAvoidingScrollViewKeyboardWillShowHandler))]
		static unsafe void TrampolinePSPDFKeyboardAvoidingScrollViewKeyboardWillShowHandler (IntPtr block, IntPtr keyboard, IntPtr notification) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::KS_PSPDFKitBindings.PSPDFKeyboardAvoidingScrollViewKeyboardWillShowHandler) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((KS_PSPDFKitBindings.PSPDFKeyboardAvoidingScrollView) Runtime.GetNSObject (keyboard), (MonoTouch.Foundation.NSNotification) Runtime.GetNSObject (notification));
		}
		
	} /* class PSPDFKeyboardAvoidingScrollView */
	public delegate void PSPDFKeyboardAvoidingScrollViewKeyboardWillShowHandler (PSPDFKeyboardAvoidingScrollView keyboard, NSNotification notification);
}
