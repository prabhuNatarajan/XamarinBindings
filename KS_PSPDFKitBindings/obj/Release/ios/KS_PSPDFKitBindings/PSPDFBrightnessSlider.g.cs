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
	[Register("PSPDFBrightnessSlider", true)]
	public unsafe partial class PSPDFBrightnessSlider : global::MonoTouch.UIKit.UISlider {
		[CompilerGenerated]
		const string selThumbImageStyle = "thumbImageStyle";
		static readonly IntPtr selThumbImageStyleHandle = Selector.GetHandle ("thumbImageStyle");
		[CompilerGenerated]
		const string selSetThumbImageStyle_ = "setThumbImageStyle:";
		static readonly IntPtr selSetThumbImageStyle_Handle = Selector.GetHandle ("setThumbImageStyle:");
		[CompilerGenerated]
		const string selBackgroundStyle = "backgroundStyle";
		static readonly IntPtr selBackgroundStyleHandle = Selector.GetHandle ("backgroundStyle");
		[CompilerGenerated]
		const string selSetBackgroundStyle_ = "setBackgroundStyle:";
		static readonly IntPtr selSetBackgroundStyle_Handle = Selector.GetHandle ("setBackgroundStyle:");
		[CompilerGenerated]
		const string selColorPicker = "colorPicker";
		static readonly IntPtr selColorPickerHandle = Selector.GetHandle ("colorPicker");
		[CompilerGenerated]
		const string selSetColorPicker_ = "setColorPicker:";
		static readonly IntPtr selSetColorPicker_Handle = Selector.GetHandle ("setColorPicker:");
		[CompilerGenerated]
		const string selUpdateBackground = "updateBackground";
		static readonly IntPtr selUpdateBackgroundHandle = Selector.GetHandle ("updateBackground");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFBrightnessSlider");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFBrightnessSlider () : base (NSObjectFlag.Empty)
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
		public PSPDFBrightnessSlider (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFBrightnessSlider (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFBrightnessSlider (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("updateBackground")]
		[CompilerGenerated]
		public virtual void UpdateBackground ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateBackgroundHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selUpdateBackgroundHandle);
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFThumbImageStyle ThumbImageStyle {
			[Export ("thumbImageStyle", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFThumbImageStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selThumbImageStyleHandle);
				} else {
					return (PSPDFThumbImageStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selThumbImageStyleHandle);
				}
			}
			
			[Export ("setThumbImageStyle:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetThumbImageStyle_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetThumbImageStyle_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFSliderBackgroundStyle BackgroundStyle {
			[Export ("backgroundStyle", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFSliderBackgroundStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selBackgroundStyleHandle);
				} else {
					return (PSPDFSliderBackgroundStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selBackgroundStyleHandle);
				}
			}
			
			[Export ("setBackgroundStyle:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetBackgroundStyle_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetBackgroundStyle_Handle, (int)value);
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
			
			[Export ("setColorPicker:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetColorPicker_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetColorPicker_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_ColorPicker_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ColorPicker_var = null;
			}
		}
	} /* class PSPDFBrightnessSlider */
}
