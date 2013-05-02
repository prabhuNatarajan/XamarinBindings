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
	[Register("PSPDFColorPickerView", true)]
	public unsafe partial class PSPDFColorPickerView : global::MonoTouch.UIKit.UIControl {
		[CompilerGenerated]
		const string selSelection = "selection";
		static readonly IntPtr selSelectionHandle = Selector.GetHandle ("selection");
		[CompilerGenerated]
		const string selCropToCircle = "cropToCircle";
		static readonly IntPtr selCropToCircleHandle = Selector.GetHandle ("cropToCircle");
		[CompilerGenerated]
		const string selSetCropToCircle_ = "setCropToCircle:";
		static readonly IntPtr selSetCropToCircle_Handle = Selector.GetHandle ("setCropToCircle:");
		[CompilerGenerated]
		const string selIsOrthoganal = "isOrthoganal";
		static readonly IntPtr selIsOrthoganalHandle = Selector.GetHandle ("isOrthoganal");
		[CompilerGenerated]
		const string selSetIsOrthoganal_ = "setIsOrthoganal:";
		static readonly IntPtr selSetIsOrthoganal_Handle = Selector.GetHandle ("setIsOrthoganal:");
		[CompilerGenerated]
		const string selIsLoupeEnabled = "isLoupeEnabled";
		static readonly IntPtr selIsLoupeEnabledHandle = Selector.GetHandle ("isLoupeEnabled");
		[CompilerGenerated]
		const string selSetLoupeEnabled_ = "setLoupeEnabled:";
		static readonly IntPtr selSetLoupeEnabled_Handle = Selector.GetHandle ("setLoupeEnabled:");
		[CompilerGenerated]
		const string selSelectionColor = "selectionColor";
		static readonly IntPtr selSelectionColorHandle = Selector.GetHandle ("selectionColor");
		[CompilerGenerated]
		const string selSetSelectionColor_ = "setSelectionColor:";
		static readonly IntPtr selSetSelectionColor_Handle = Selector.GetHandle ("setSelectionColor:");
		[CompilerGenerated]
		const string selBrightness = "brightness";
		static readonly IntPtr selBrightnessHandle = Selector.GetHandle ("brightness");
		[CompilerGenerated]
		const string selSetBrightness_ = "setBrightness:";
		static readonly IntPtr selSetBrightness_Handle = Selector.GetHandle ("setBrightness:");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selBrightnessSlider = "brightnessSlider";
		static readonly IntPtr selBrightnessSliderHandle = Selector.GetHandle ("brightnessSlider");
		[CompilerGenerated]
		const string selSetBrightnessSlider_ = "setBrightnessSlider:";
		static readonly IntPtr selSetBrightnessSlider_Handle = Selector.GetHandle ("setBrightnessSlider:");
		[CompilerGenerated]
		const string selSelectionToHueSaturationBrightness_ = "selectionToHue:saturation:brightness:";
		static readonly IntPtr selSelectionToHueSaturationBrightness_Handle = Selector.GetHandle ("selectionToHue:saturation:brightness:");
		[CompilerGenerated]
		const string selColorAtPoint_ = "colorAtPoint:";
		static readonly IntPtr selColorAtPoint_Handle = Selector.GetHandle ("colorAtPoint:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFColorPickerView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFColorPickerView () : base (NSObjectFlag.Empty)
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
		public PSPDFColorPickerView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFColorPickerView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFColorPickerView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("selectionToHue:saturation:brightness:")]
		[CompilerGenerated]
		public virtual void SelectionToHue (float pHue, float saturation, float brightness)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_float_float_float (this.Handle, selSelectionToHueSaturationBrightness_Handle, pHue, saturation, brightness);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_float_float_float (this.SuperHandle, selSelectionToHueSaturationBrightness_Handle, pHue, saturation, brightness);
			}
		}
		
		[Export ("colorAtPoint:")]
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor ColorAtPoint (global::System.Drawing.PointF point)
		{
			if (IsDirectBinding) {
				return (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_PointF (this.Handle, selColorAtPoint_Handle, point));
			} else {
				return (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_PointF (this.SuperHandle, selColorAtPoint_Handle, point));
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Drawing.PointF Selection {
			[Export ("selection", ArgumentSemantic.Assign)]
			get {
				global::System.Drawing.PointF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSend_stret (out ret, this.Handle, selSelectionHandle);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSend (this.Handle, selSelectionHandle);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selSelectionHandle);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSendSuper (this.SuperHandle, selSelectionHandle);
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool CropToCircle {
			[Export ("cropToCircle", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCropToCircleHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selCropToCircleHandle);
				}
			}
			
			[Export ("setCropToCircle:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetCropToCircle_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetCropToCircle_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsOrthoganal {
			[Export ("isOrthoganal", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsOrthoganalHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsOrthoganalHandle);
				}
			}
			
			[Export ("setIsOrthoganal:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsOrthoganal_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIsOrthoganal_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool LoupeEnabled {
			[Export ("isLoupeEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsLoupeEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsLoupeEnabledHandle);
				}
			}
			
			[Export ("setLoupeEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetLoupeEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetLoupeEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_SelectionColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor SelectionColor {
			[Export ("selectionColor")]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectionColorHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSelectionColorHandle));
				}
				MarkDirty ();
				__mt_SelectionColor_var = ret;
				return ret;
			}
			
			[Export ("setSelectionColor:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSelectionColor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSelectionColor_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_SelectionColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual float Brightness {
			[Export ("brightness", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selBrightnessHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selBrightnessHandle);
				}
			}
			
			[Export ("setBrightness:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetBrightness_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetBrightness_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public PSPDFColorPickerViewDelegate Delegate {
			get {
				return WeakDelegate as PSPDFColorPickerViewDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_BrightnessSlider_var;
		[CompilerGenerated]
		public virtual PSPDFBrightnessSlider BrightnessSlider {
			[Export ("brightnessSlider")]
			get {
				PSPDFBrightnessSlider ret;
				if (IsDirectBinding) {
					ret = (PSPDFBrightnessSlider) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBrightnessSliderHandle));
				} else {
					ret = (PSPDFBrightnessSlider) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBrightnessSliderHandle));
				}
				MarkDirty ();
				__mt_BrightnessSlider_var = ret;
				return ret;
			}
			
			[Export ("setBrightnessSlider:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBrightnessSlider_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBrightnessSlider_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_BrightnessSlider_var = value;
			}
		}
		
		//
		// Events and properties from the delegate
		//
		
		_PSPDFColorPickerViewDelegate EnsurePSPDFColorPickerViewDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _PSPDFColorPickerViewDelegate))){
				del = new _PSPDFColorPickerViewDelegate ();
				WeakDelegate = del;
			}
			return (_PSPDFColorPickerViewDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _PSPDFColorPickerViewDelegate : KS_PSPDFKitBindings.PSPDFColorPickerViewDelegate { 
			public _PSPDFColorPickerViewDelegate () {}
			
			internal EventHandler didChangeSelection;
			[Preserve (Conditional = true)]
			public override void DidChangeSelection (KS_PSPDFKitBindings.PSPDFColorPickerView colorPicker)
			{
				EventHandler handler = didChangeSelection;
				if (handler != null){
					handler (colorPicker, EventArgs.Empty);
				}
			}
			
		}
		#pragma warning restore 672
		
		public event EventHandler DidChangeSelection {
			add { EnsurePSPDFColorPickerViewDelegate ().didChangeSelection += value; }
			remove { EnsurePSPDFColorPickerViewDelegate ().didChangeSelection -= value; }
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_SelectionColor_var = null;
				__mt_WeakDelegate_var = null;
				__mt_BrightnessSlider_var = null;
			}
		}
	} /* class PSPDFColorPickerView */
}
