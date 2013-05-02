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
	[Register("PSPDFPopoverBackgroundView", true)]
	public unsafe partial class PSPDFPopoverBackgroundView : global::MonoTouch.UIKit.UIPopoverBackgroundView {
		[CompilerGenerated]
		const string selArrowOffset = "arrowOffset";
		static readonly IntPtr selArrowOffsetHandle = Selector.GetHandle ("arrowOffset");
		[CompilerGenerated]
		const string selSetArrowOffset_ = "setArrowOffset:";
		static readonly IntPtr selSetArrowOffset_Handle = Selector.GetHandle ("setArrowOffset:");
		[CompilerGenerated]
		const string selArrowDirection = "arrowDirection";
		static readonly IntPtr selArrowDirectionHandle = Selector.GetHandle ("arrowDirection");
		[CompilerGenerated]
		const string selSetArrowDirection_ = "setArrowDirection:";
		static readonly IntPtr selSetArrowDirection_Handle = Selector.GetHandle ("setArrowDirection:");
		[CompilerGenerated]
		const string selSetContentInset_ = "setContentInset:";
		static readonly IntPtr selSetContentInset_Handle = Selector.GetHandle ("setContentInset:");
		[CompilerGenerated]
		const string selSetTintColor_ = "setTintColor:";
		static readonly IntPtr selSetTintColor_Handle = Selector.GetHandle ("setTintColor:");
		[CompilerGenerated]
		const string selSetShadowEnabled_ = "setShadowEnabled:";
		static readonly IntPtr selSetShadowEnabled_Handle = Selector.GetHandle ("setShadowEnabled:");
		[CompilerGenerated]
		const string selSetArrowBase_ = "setArrowBase:";
		static readonly IntPtr selSetArrowBase_Handle = Selector.GetHandle ("setArrowBase:");
		[CompilerGenerated]
		const string selSetArrowHeight_ = "setArrowHeight:";
		static readonly IntPtr selSetArrowHeight_Handle = Selector.GetHandle ("setArrowHeight:");
		[CompilerGenerated]
		const string selSetBackgroundImageTopRightBottomLeft_ = "setBackgroundImage:top:right:bottom:left:";
		static readonly IntPtr selSetBackgroundImageTopRightBottomLeft_Handle = Selector.GetHandle ("setBackgroundImage:top:right:bottom:left:");
		[CompilerGenerated]
		const string selRebuildArrowImages = "rebuildArrowImages";
		static readonly IntPtr selRebuildArrowImagesHandle = Selector.GetHandle ("rebuildArrowImages");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFPopoverBackgroundView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFPopoverBackgroundView () : base (NSObjectFlag.Empty)
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
		public PSPDFPopoverBackgroundView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFPopoverBackgroundView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFPopoverBackgroundView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setContentInset:")]
		[CompilerGenerated]
		public static void SetContentInset (float contentInset)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (class_ptr, selSetContentInset_Handle, contentInset);
		}
		
		[Export ("setTintColor:")]
		[CompilerGenerated]
		public static void SetTintColor (global::MonoTouch.UIKit.UIColor tintColor)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selSetTintColor_Handle, tintColor == null ? IntPtr.Zero : tintColor.Handle);
		}
		
		[Export ("setShadowEnabled:")]
		[CompilerGenerated]
		public static void SetShadowEnabled (bool shadowEnabled)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (class_ptr, selSetShadowEnabled_Handle, shadowEnabled);
		}
		
		[Export ("setArrowBase:")]
		[CompilerGenerated]
		public static void SetArrowBase (float arrowBase)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (class_ptr, selSetArrowBase_Handle, arrowBase);
		}
		
		[Export ("setArrowHeight:")]
		[CompilerGenerated]
		public static void SetArrowHeight (float arrowHeight)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (class_ptr, selSetArrowHeight_Handle, arrowHeight);
		}
		
		[Export ("setBackgroundImage:top:right:bottom:left:")]
		[CompilerGenerated]
		public static void SetBackgroundImage (global::MonoTouch.UIKit.UIImage background, global::MonoTouch.UIKit.UIImage top, global::MonoTouch.UIKit.UIImage right, global::MonoTouch.UIKit.UIImage bottom, global::MonoTouch.UIKit.UIImage left)
		{
			if (background == null)
				throw new ArgumentNullException ("background");
			if (top == null)
				throw new ArgumentNullException ("top");
			if (right == null)
				throw new ArgumentNullException ("right");
			if (bottom == null)
				throw new ArgumentNullException ("bottom");
			if (left == null)
				throw new ArgumentNullException ("left");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selSetBackgroundImageTopRightBottomLeft_Handle, background.Handle, top.Handle, right.Handle, bottom.Handle, left.Handle);
		}
		
		[Export ("rebuildArrowImages")]
		[CompilerGenerated]
		public static void RebuildArrowImages ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (class_ptr, selRebuildArrowImagesHandle);
		}
		
		[CompilerGenerated]
		public virtual float ArrowOffset {
			[Export ("arrowOffset", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selArrowOffsetHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selArrowOffsetHandle);
				}
			}
			
			[Export ("setArrowOffset:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetArrowOffset_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetArrowOffset_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIPopoverArrowDirection ArrowDirection {
			[Export ("arrowDirection", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (global::MonoTouch.UIKit.UIPopoverArrowDirection) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selArrowDirectionHandle);
				} else {
					return (global::MonoTouch.UIKit.UIPopoverArrowDirection) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selArrowDirectionHandle);
				}
			}
			
			[Export ("setArrowDirection:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetArrowDirection_Handle, (UInt32)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetArrowDirection_Handle, (UInt32)value);
				}
			}
		}
		
	} /* class PSPDFPopoverBackgroundView */
}
