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
	[Register("PSPDFHSVColorPickerController", true)]
	public unsafe partial class PSPDFHSVColorPickerController : PSPDFBaseViewController {
		[CompilerGenerated]
		const string selSelectionColor = "selectionColor";
		static readonly IntPtr selSelectionColorHandle = Selector.GetHandle ("selectionColor");
		[CompilerGenerated]
		const string selSetSelectionColor_ = "setSelectionColor:";
		static readonly IntPtr selSetSelectionColor_Handle = Selector.GetHandle ("setSelectionColor:");
		[CompilerGenerated]
		const string selMargin = "margin";
		static readonly IntPtr selMarginHandle = Selector.GetHandle ("margin");
		[CompilerGenerated]
		const string selSetMargin_ = "setMargin:";
		static readonly IntPtr selSetMargin_Handle = Selector.GetHandle ("setMargin:");
		[CompilerGenerated]
		const string selColorPicker = "colorPicker";
		static readonly IntPtr selColorPickerHandle = Selector.GetHandle ("colorPicker");
		[CompilerGenerated]
		const string selBrightnessSlider = "brightnessSlider";
		static readonly IntPtr selBrightnessSliderHandle = Selector.GetHandle ("brightnessSlider");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFHSVColorPickerController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFHSVColorPickerController () : base (NSObjectFlag.Empty)
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
		public PSPDFHSVColorPickerController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFHSVColorPickerController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFHSVColorPickerController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
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
		public virtual global::MonoTouch.UIKit.UIEdgeInsets Margin {
			[Export ("margin", ArgumentSemantic.Assign)]
			get {
				global::MonoTouch.UIKit.UIEdgeInsets ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, selMarginHandle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, selMarginHandle);
				}
				return ret;
			}
			
			[Export ("setMargin:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, selSetMargin_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UIEdgeInsets (this.SuperHandle, selSetMargin_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_ColorPicker_var;
		[CompilerGenerated]
		public virtual PSPDFColorPickerView ColorPicker {
			[Export ("colorPicker")]
			get {
				PSPDFColorPickerView ret;
				if (IsDirectBinding) {
					ret = (PSPDFColorPickerView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selColorPickerHandle));
				} else {
					ret = (PSPDFColorPickerView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selColorPickerHandle));
				}
				MarkDirty ();
				__mt_ColorPicker_var = ret;
				return ret;
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
			
		}
		
		[CompilerGenerated]
		public PSPDFColorSelectionViewControllerDelegate Delegate {
			get {
				return WeakDelegate as PSPDFColorSelectionViewControllerDelegate;
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
		
		//
		// Events and properties from the delegate
		//
		
		_PSPDFColorSelectionViewControllerDelegate EnsurePSPDFColorSelectionViewControllerDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _PSPDFColorSelectionViewControllerDelegate))){
				del = new _PSPDFColorSelectionViewControllerDelegate ();
				WeakDelegate = del;
			}
			return (_PSPDFColorSelectionViewControllerDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _PSPDFColorSelectionViewControllerDelegate : KS_PSPDFKitBindings.PSPDFColorSelectionViewControllerDelegate { 
			public _PSPDFColorSelectionViewControllerDelegate () {}
			
			internal PSPDFColorSelectionViewControllerColor colorSelectionControllerSelectedColor;
			[Preserve (Conditional = true)]
			public override UIColor ColorSelectionControllerSelectedColor (UIViewController controller, IntPtr context)
			{
				PSPDFColorSelectionViewControllerColor handler = colorSelectionControllerSelectedColor;
				if (handler != null)
					return handler (controller, context);
				return null;
			}
			
			internal EventHandler<PSPDFColorSelectionViewControllerDidSelectedColorEventArgs> didSelectedColor;
			[Preserve (Conditional = true)]
			public override void DidSelectedColor (UIViewController controller, UIColor color, bool finished, IntPtr context)
			{
				EventHandler<PSPDFColorSelectionViewControllerDidSelectedColorEventArgs> handler = didSelectedColor;
				if (handler != null){
					var args = new PSPDFColorSelectionViewControllerDidSelectedColorEventArgs (color, finished, context);
					handler (controller, args);
				}
			}
			
		}
		#pragma warning restore 672
		
		public PSPDFColorSelectionViewControllerColor ColorSelectionControllerSelectedColor {
			get { return EnsurePSPDFColorSelectionViewControllerDelegate ().colorSelectionControllerSelectedColor; }
			set { EnsurePSPDFColorSelectionViewControllerDelegate ().colorSelectionControllerSelectedColor = value; }
		}
		
		public event EventHandler<PSPDFColorSelectionViewControllerDidSelectedColorEventArgs> DidSelectedColor {
			add { EnsurePSPDFColorSelectionViewControllerDelegate ().didSelectedColor += value; }
			remove { EnsurePSPDFColorSelectionViewControllerDelegate ().didSelectedColor -= value; }
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_SelectionColor_var = null;
				__mt_ColorPicker_var = null;
				__mt_BrightnessSlider_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class PSPDFHSVColorPickerController */
}
