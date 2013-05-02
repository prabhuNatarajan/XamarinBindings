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
	[Register("PSPDFOutlineBarButtonItem", true)]
	public unsafe partial class PSPDFOutlineBarButtonItem : PSPDFBarButtonItem {
		[CompilerGenerated]
		const string selIsAvailableBlocking = "isAvailableBlocking";
		static readonly IntPtr selIsAvailableBlockingHandle = Selector.GetHandle ("isAvailableBlocking");
		[CompilerGenerated]
		const string selAvailableControllerOptions = "availableControllerOptions";
		static readonly IntPtr selAvailableControllerOptionsHandle = Selector.GetHandle ("availableControllerOptions");
		[CompilerGenerated]
		const string selSetAvailableControllerOptions_ = "setAvailableControllerOptions:";
		static readonly IntPtr selSetAvailableControllerOptions_Handle = Selector.GetHandle ("setAvailableControllerOptions:");
		[CompilerGenerated]
		const string selTitleForOption_ = "titleForOption:";
		static readonly IntPtr selTitleForOption_Handle = Selector.GetHandle ("titleForOption:");
		[CompilerGenerated]
		const string selControllerForOption_ = "controllerForOption:";
		static readonly IntPtr selControllerForOption_Handle = Selector.GetHandle ("controllerForOption:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFOutlineBarButtonItem");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFOutlineBarButtonItem () : base (NSObjectFlag.Empty)
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
		public PSPDFOutlineBarButtonItem (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFOutlineBarButtonItem (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFOutlineBarButtonItem (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("titleForOption:")]
		[CompilerGenerated]
		public virtual string TitleForOption (PSPDFOutlineBarButtonItemOption option)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selTitleForOption_Handle, (UInt32)option));
			} else {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selTitleForOption_Handle, (UInt32)option));
			}
		}
		
		[Export ("controllerForOption:")]
		[CompilerGenerated]
		public virtual string ControllerForOption (PSPDFOutlineBarButtonItemOption option)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selControllerForOption_Handle, (UInt32)option));
			} else {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selControllerForOption_Handle, (UInt32)option));
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsAvailableBlocking {
			[Export ("isAvailableBlocking")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAvailableBlockingHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsAvailableBlockingHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.IntPtr AvailableControllerOptions {
			[Export ("availableControllerOptions", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAvailableControllerOptionsHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAvailableControllerOptionsHandle);
				}
			}
			
			[Export ("setAvailableControllerOptions:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAvailableControllerOptions_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAvailableControllerOptions_Handle, value);
				}
			}
		}
		
	} /* class PSPDFOutlineBarButtonItem */
}
