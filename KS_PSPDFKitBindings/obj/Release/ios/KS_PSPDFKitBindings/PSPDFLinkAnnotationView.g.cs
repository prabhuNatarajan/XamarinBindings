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
	[Register("PSPDFLinkAnnotationView", true)]
	public unsafe partial class PSPDFLinkAnnotationView : PSPDFLinkAnnotationBaseView {
		[CompilerGenerated]
		const string selBorderColor = "borderColor";
		static readonly IntPtr selBorderColorHandle = Selector.GetHandle ("borderColor");
		[CompilerGenerated]
		const string selSetBorderColor_ = "setBorderColor:";
		static readonly IntPtr selSetBorderColor_Handle = Selector.GetHandle ("setBorderColor:");
		[CompilerGenerated]
		const string selHighlightBackgroundColor = "highlightBackgroundColor";
		static readonly IntPtr selHighlightBackgroundColorHandle = Selector.GetHandle ("highlightBackgroundColor");
		[CompilerGenerated]
		const string selSetHighlightBackgroundColor_ = "setHighlightBackgroundColor:";
		static readonly IntPtr selSetHighlightBackgroundColor_Handle = Selector.GetHandle ("setHighlightBackgroundColor:");
		[CompilerGenerated]
		const string selCornerRadius = "cornerRadius";
		static readonly IntPtr selCornerRadiusHandle = Selector.GetHandle ("cornerRadius");
		[CompilerGenerated]
		const string selSetCornerRadius_ = "setCornerRadius:";
		static readonly IntPtr selSetCornerRadius_Handle = Selector.GetHandle ("setCornerRadius:");
		[CompilerGenerated]
		const string selStrokeWidth = "strokeWidth";
		static readonly IntPtr selStrokeWidthHandle = Selector.GetHandle ("strokeWidth");
		[CompilerGenerated]
		const string selSetStrokeWidth_ = "setStrokeWidth:";
		static readonly IntPtr selSetStrokeWidth_Handle = Selector.GetHandle ("setStrokeWidth:");
		[CompilerGenerated]
		const string selShouldHideSmallLinks = "shouldHideSmallLinks";
		static readonly IntPtr selShouldHideSmallLinksHandle = Selector.GetHandle ("shouldHideSmallLinks");
		[CompilerGenerated]
		const string selSetHideSmallLinks_ = "setHideSmallLinks:";
		static readonly IntPtr selSetHideSmallLinks_Handle = Selector.GetHandle ("setHideSmallLinks:");
		[CompilerGenerated]
		const string selOverspan = "overspan";
		static readonly IntPtr selOverspanHandle = Selector.GetHandle ("overspan");
		[CompilerGenerated]
		const string selSetOverspan_ = "setOverspan:";
		static readonly IntPtr selSetOverspan_Handle = Selector.GetHandle ("setOverspan:");
		[CompilerGenerated]
		const string selAllowToDisableRoundedCorners = "allowToDisableRoundedCorners";
		static readonly IntPtr selAllowToDisableRoundedCornersHandle = Selector.GetHandle ("allowToDisableRoundedCorners");
		[CompilerGenerated]
		const string selSetAllowToDisableRoundedCorners_ = "setAllowToDisableRoundedCorners:";
		static readonly IntPtr selSetAllowToDisableRoundedCorners_Handle = Selector.GetHandle ("setAllowToDisableRoundedCorners:");
		[CompilerGenerated]
		const string selDisableRoundedCorners = "disableRoundedCorners";
		static readonly IntPtr selDisableRoundedCornersHandle = Selector.GetHandle ("disableRoundedCorners");
		[CompilerGenerated]
		const string selSetDisableRoundedCorners_ = "setDisableRoundedCorners:";
		static readonly IntPtr selSetDisableRoundedCorners_Handle = Selector.GetHandle ("setDisableRoundedCorners:");
		[CompilerGenerated]
		const string selInitWithFrame_ = "initWithFrame:";
		static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle ("initWithFrame:");
		[CompilerGenerated]
		const string selFlashBackground = "flashBackground";
		static readonly IntPtr selFlashBackgroundHandle = Selector.GetHandle ("flashBackground");
		[CompilerGenerated]
		const string selTouchUp = "touchUp";
		static readonly IntPtr selTouchUpHandle = Selector.GetHandle ("touchUp");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFLinkAnnotationView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFLinkAnnotationView () : base (NSObjectFlag.Empty)
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
		public PSPDFLinkAnnotationView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFLinkAnnotationView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:")]
		[CompilerGenerated]
		public PSPDFLinkAnnotationView (global::System.Drawing.RectangleF frame)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_RectangleF (this.Handle, selInitWithFrame_Handle, frame);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_RectangleF (this.SuperHandle, selInitWithFrame_Handle, frame);
			}
		}
		
		[Export ("flashBackground")]
		[CompilerGenerated]
		public virtual void FlashBackground ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selFlashBackgroundHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selFlashBackgroundHandle);
			}
		}
		
		[Export ("touchUp")]
		[CompilerGenerated]
		public virtual void TouchUp ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selTouchUpHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selTouchUpHandle);
			}
		}
		
		[CompilerGenerated]
		object __mt_BorderColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor BorderColor {
			[Export ("borderColor")]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBorderColorHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBorderColorHandle));
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
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBorderColor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBorderColor_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_BorderColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_HighlightBackgroundColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor HighlightBackgroundColor {
			[Export ("highlightBackgroundColor")]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selHighlightBackgroundColorHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selHighlightBackgroundColorHandle));
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
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetHighlightBackgroundColor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetHighlightBackgroundColor_Handle, value.Handle);
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
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selCornerRadiusHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selCornerRadiusHandle);
				}
			}
			
			[Export ("setCornerRadius:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetCornerRadius_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetCornerRadius_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float StrokeWidth {
			[Export ("strokeWidth", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selStrokeWidthHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selStrokeWidthHandle);
				}
			}
			
			[Export ("setStrokeWidth:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetStrokeWidth_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetStrokeWidth_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool HideSmallLinks {
			[Export ("shouldHideSmallLinks", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldHideSmallLinksHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShouldHideSmallLinksHandle);
				}
			}
			
			[Export ("setHideSmallLinks:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHideSmallLinks_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetHideSmallLinks_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Drawing.SizeF Overspan {
			[Export ("overspan", ArgumentSemantic.Assign)]
			get {
				global::System.Drawing.SizeF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend_stret (out ret, this.Handle, selOverspanHandle);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend (this.Handle, selOverspanHandle);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selOverspanHandle);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper (this.SuperHandle, selOverspanHandle);
					}
				}
				return ret;
			}
			
			[Export ("setOverspan:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_SizeF (this.Handle, selSetOverspan_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_SizeF (this.SuperHandle, selSetOverspan_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AllowToDisableRoundedCorners {
			[Export ("allowToDisableRoundedCorners", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowToDisableRoundedCornersHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAllowToDisableRoundedCornersHandle);
				}
			}
			
			[Export ("setAllowToDisableRoundedCorners:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowToDisableRoundedCorners_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAllowToDisableRoundedCorners_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool DisableRoundedCorners {
			[Export ("disableRoundedCorners", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDisableRoundedCornersHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selDisableRoundedCornersHandle);
				}
			}
			
			[Export ("setDisableRoundedCorners:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDisableRoundedCorners_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetDisableRoundedCorners_Handle, value);
				}
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_BorderColor_var = null;
				__mt_HighlightBackgroundColor_var = null;
			}
		}
	} /* class PSPDFLinkAnnotationView */
}
