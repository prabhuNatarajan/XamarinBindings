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
	[Register("PSPDFBrightnessViewController", true)]
	public unsafe partial class PSPDFBrightnessViewController : PSPDFBaseViewController {
		[CompilerGenerated]
		const string selWantsSoftwareDimming = "wantsSoftwareDimming";
		static readonly IntPtr selWantsSoftwareDimmingHandle = Selector.GetHandle ("wantsSoftwareDimming");
		[CompilerGenerated]
		const string selSetWantsSoftwareDimming_ = "setWantsSoftwareDimming:";
		static readonly IntPtr selSetWantsSoftwareDimming_Handle = Selector.GetHandle ("setWantsSoftwareDimming:");
		[CompilerGenerated]
		const string selWantsAdditionalSoftwareDimming = "wantsAdditionalSoftwareDimming";
		static readonly IntPtr selWantsAdditionalSoftwareDimmingHandle = Selector.GetHandle ("wantsAdditionalSoftwareDimming");
		[CompilerGenerated]
		const string selSetWantsAdditionalSoftwareDimming_ = "setWantsAdditionalSoftwareDimming:";
		static readonly IntPtr selSetWantsAdditionalSoftwareDimming_Handle = Selector.GetHandle ("setWantsAdditionalSoftwareDimming:");
		[CompilerGenerated]
		const string selAdditionalBrightnessDimmingFactor = "additionalBrightnessDimmingFactor";
		static readonly IntPtr selAdditionalBrightnessDimmingFactorHandle = Selector.GetHandle ("additionalBrightnessDimmingFactor");
		[CompilerGenerated]
		const string selSetAdditionalBrightnessDimmingFactor_ = "setAdditionalBrightnessDimmingFactor:";
		static readonly IntPtr selSetAdditionalBrightnessDimmingFactor_Handle = Selector.GetHandle ("setAdditionalBrightnessDimmingFactor:");
		[CompilerGenerated]
		const string selMaximumAdditionalBrightnessDimmingFactor = "maximumAdditionalBrightnessDimmingFactor";
		static readonly IntPtr selMaximumAdditionalBrightnessDimmingFactorHandle = Selector.GetHandle ("maximumAdditionalBrightnessDimmingFactor");
		[CompilerGenerated]
		const string selSetMaximumAdditionalBrightnessDimmingFactor_ = "setMaximumAdditionalBrightnessDimmingFactor:";
		static readonly IntPtr selSetMaximumAdditionalBrightnessDimmingFactor_Handle = Selector.GetHandle ("setMaximumAdditionalBrightnessDimmingFactor:");
		[CompilerGenerated]
		const string selSlider = "slider";
		static readonly IntPtr selSliderHandle = Selector.GetHandle ("slider");
		[CompilerGenerated]
		const string selSetSlider_ = "setSlider:";
		static readonly IntPtr selSetSlider_Handle = Selector.GetHandle ("setSlider:");
		[CompilerGenerated]
		const string selGradient = "gradient";
		static readonly IntPtr selGradientHandle = Selector.GetHandle ("gradient");
		[CompilerGenerated]
		const string selSetGradient_ = "setGradient:";
		static readonly IntPtr selSetGradient_Handle = Selector.GetHandle ("setGradient:");
		[CompilerGenerated]
		const string selDimmingView = "dimmingView";
		static readonly IntPtr selDimmingViewHandle = Selector.GetHandle ("dimmingView");
		[CompilerGenerated]
		const string selAddDimmingView = "addDimmingView";
		static readonly IntPtr selAddDimmingViewHandle = Selector.GetHandle ("addDimmingView");
		[CompilerGenerated]
		const string selRemoveDimmingView = "removeDimmingView";
		static readonly IntPtr selRemoveDimmingViewHandle = Selector.GetHandle ("removeDimmingView");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFBrightnessViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFBrightnessViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFBrightnessViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFBrightnessViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFBrightnessViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public PSPDFDimmingView AddDimmingView ()
		{
			PSPDFDimmingView ret;
			ret = (PSPDFDimmingView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAddDimmingViewHandle));
			#pragma warning disable 168
			var postget0 = DimmingView;
			#pragma warning restore 168
			return ret;
		}
		
		[CompilerGenerated]
		public void RemoveDimmingView ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveDimmingViewHandle);
			#pragma warning disable 168
			var postget0 = DimmingView;
			#pragma warning restore 168
		}
		
		[CompilerGenerated]
		public virtual bool WantsSoftwareDimming {
			[Export ("wantsSoftwareDimming", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selWantsSoftwareDimmingHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selWantsSoftwareDimmingHandle);
				}
			}
			
			[Export ("setWantsSoftwareDimming:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetWantsSoftwareDimming_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetWantsSoftwareDimming_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool WantsAdditionalSoftwareDimming {
			[Export ("wantsAdditionalSoftwareDimming", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selWantsAdditionalSoftwareDimmingHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selWantsAdditionalSoftwareDimmingHandle);
				}
			}
			
			[Export ("setWantsAdditionalSoftwareDimming:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetWantsAdditionalSoftwareDimming_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetWantsAdditionalSoftwareDimming_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float AdditionalBrightnessDimmingFactor {
			[Export ("additionalBrightnessDimmingFactor", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selAdditionalBrightnessDimmingFactorHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selAdditionalBrightnessDimmingFactorHandle);
				}
			}
			
			[Export ("setAdditionalBrightnessDimmingFactor:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetAdditionalBrightnessDimmingFactor_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetAdditionalBrightnessDimmingFactor_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float MaximumAdditionalBrightnessDimmingFactor {
			[Export ("maximumAdditionalBrightnessDimmingFactor", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMaximumAdditionalBrightnessDimmingFactorHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selMaximumAdditionalBrightnessDimmingFactorHandle);
				}
			}
			
			[Export ("setMaximumAdditionalBrightnessDimmingFactor:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMaximumAdditionalBrightnessDimmingFactor_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetMaximumAdditionalBrightnessDimmingFactor_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Slider_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UISlider Slider {
			[Export ("slider")]
			get {
				global::MonoTouch.UIKit.UISlider ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UISlider) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSliderHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UISlider) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSliderHandle));
				}
				MarkDirty ();
				__mt_Slider_var = ret;
				return ret;
			}
			
			[Export ("setSlider:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSlider_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSlider_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Slider_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Gradient_var;
		[CompilerGenerated]
		public virtual PSPDFGradientView Gradient {
			[Export ("gradient")]
			get {
				PSPDFGradientView ret;
				if (IsDirectBinding) {
					ret = (PSPDFGradientView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selGradientHandle));
				} else {
					ret = (PSPDFGradientView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selGradientHandle));
				}
				MarkDirty ();
				__mt_Gradient_var = ret;
				return ret;
			}
			
			[Export ("setGradient:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetGradient_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetGradient_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Gradient_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_DimmingView_var;
		[CompilerGenerated]
		public virtual PSPDFDimmingView DimmingView {
			[Export ("dimmingView")]
			get {
				PSPDFDimmingView ret;
				if (IsDirectBinding) {
					ret = (PSPDFDimmingView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDimmingViewHandle));
				} else {
					ret = (PSPDFDimmingView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDimmingViewHandle));
				}
				MarkDirty ();
				__mt_DimmingView_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Slider_var = null;
				__mt_Gradient_var = null;
				__mt_DimmingView_var = null;
			}
		}
	} /* class PSPDFBrightnessViewController */
}
