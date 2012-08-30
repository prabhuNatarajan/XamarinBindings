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
	[Register("PSPDFLinkAnnotationView", true)]
	public unsafe partial class PSPDFLinkAnnotationView : PSPDFLinkAnnotationBaseView {
		static readonly IntPtr selBorderColor = Selector.GetHandle ("borderColor");
		static readonly IntPtr selSetBorderColor_ = Selector.GetHandle ("setBorderColor:");
		static readonly IntPtr selHighlightBackgroundColor = Selector.GetHandle ("highlightBackgroundColor");
		static readonly IntPtr selSetHighlightBackgroundColor_ = Selector.GetHandle ("setHighlightBackgroundColor:");
		static readonly IntPtr selCornerRadius = Selector.GetHandle ("cornerRadius");
		static readonly IntPtr selSetCornerRadius_ = Selector.GetHandle ("setCornerRadius:");
		static readonly IntPtr selStrokeWidth = Selector.GetHandle ("strokeWidth");
		static readonly IntPtr selSetStrokeWidth_ = Selector.GetHandle ("setStrokeWidth:");
		static readonly IntPtr selPressedColor = Selector.GetHandle ("pressedColor");
		static readonly IntPtr selSetPressedColor_ = Selector.GetHandle ("setPressedColor:");
		static readonly IntPtr selShouldHideSmallLinks = Selector.GetHandle ("shouldHideSmallLinks");
		static readonly IntPtr selSetHideSmallLinks_ = Selector.GetHandle ("setHideSmallLinks:");
		static readonly IntPtr selOverspan = Selector.GetHandle ("overspan");
		static readonly IntPtr selSetOverspan_ = Selector.GetHandle ("setOverspan:");
		static readonly IntPtr selFlashBackground = Selector.GetHandle ("flashBackground");
		static readonly IntPtr selTouchUp = Selector.GetHandle ("touchUp");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFLinkAnnotationView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFLinkAnnotationView () : base (NSObjectFlag.Empty)
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
		public PSPDFLinkAnnotationView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFLinkAnnotationView (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFLinkAnnotationView (IntPtr handle) : base (handle) {}

		[Export ("flashBackground")]
		[CompilerGenerated]
		public virtual void FlashBackground ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selFlashBackground);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selFlashBackground);
			}
		}
		
		[Export ("touchUp")]
		[CompilerGenerated]
		public virtual void TouchUp ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selTouchUp);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selTouchUp);
			}
		}
		
		object __mt_BorderColor_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIColor BorderColor {
			[Export ("borderColor")]
			get {
				MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBorderColor));
				} else {
					ret = (MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBorderColor));
				}
				MarkDirty ();
				__mt_BorderColor_var = ret;
				return ret;
			}
			
			[Export ("setBorderColor:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBorderColor_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBorderColor_, value.Handle);
				}
				MarkDirty ();
				__mt_BorderColor_var = value;
			}
		}
		
		object __mt_HighlightBackgroundColor_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIColor HighlightBackgroundColor {
			[Export ("highlightBackgroundColor")]
			get {
				MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selHighlightBackgroundColor));
				} else {
					ret = (MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selHighlightBackgroundColor));
				}
				MarkDirty ();
				__mt_HighlightBackgroundColor_var = ret;
				return ret;
			}
			
			[Export ("setHighlightBackgroundColor:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetHighlightBackgroundColor_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetHighlightBackgroundColor_, value.Handle);
				}
				MarkDirty ();
				__mt_HighlightBackgroundColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual float CornerRadius {
			[Export ("cornerRadius", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selCornerRadius);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selCornerRadius);
				}
			}
			
			[Export ("setCornerRadius:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetCornerRadius_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetCornerRadius_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float StrokeWidth {
			[Export ("strokeWidth", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selStrokeWidth);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selStrokeWidth);
				}
			}
			
			[Export ("setStrokeWidth:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetStrokeWidth_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetStrokeWidth_, value);
				}
			}
		}
		
		object __mt_PressedColor_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIColor PressedColor {
			[Export ("pressedColor")]
			get {
				MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPressedColor));
				} else {
					ret = (MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPressedColor));
				}
				MarkDirty ();
				__mt_PressedColor_var = ret;
				return ret;
			}
			
			[Export ("setPressedColor:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPressedColor_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPressedColor_, value.Handle);
				}
				MarkDirty ();
				__mt_PressedColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool HideSmallLinks {
			[Export ("shouldHideSmallLinks", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldHideSmallLinks);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShouldHideSmallLinks);
				}
			}
			
			[Export ("setHideSmallLinks:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHideSmallLinks_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetHideSmallLinks_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual System.Drawing.SizeF Overspan {
			[Export ("overspan", ArgumentSemantic.Assign)]
			get {
				System.Drawing.SizeF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend_stret (out ret, this.Handle, selOverspan);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend (this.Handle, selOverspan);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selOverspan);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper (this.SuperHandle, selOverspan);
					}
				}
				return ret;
			}
			
			[Export ("setOverspan:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_SizeF (this.Handle, selSetOverspan_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_SizeF (this.SuperHandle, selSetOverspan_, value);
				}
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_BorderColor_var = null;
			__mt_HighlightBackgroundColor_var = null;
			__mt_PressedColor_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFLinkAnnotationView */
}
