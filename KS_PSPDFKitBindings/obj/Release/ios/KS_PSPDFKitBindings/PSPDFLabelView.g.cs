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
	[Register("PSPDFLabelView", true)]
	public unsafe partial class PSPDFLabelView : PSPDFGradientView {
		[CompilerGenerated]
		const string selLabel = "label";
		static readonly IntPtr selLabelHandle = Selector.GetHandle ("label");
		[CompilerGenerated]
		const string selLabelMargin = "labelMargin";
		static readonly IntPtr selLabelMarginHandle = Selector.GetHandle ("labelMargin");
		[CompilerGenerated]
		const string selSetLabelMargin_ = "setLabelMargin:";
		static readonly IntPtr selSetLabelMargin_Handle = Selector.GetHandle ("setLabelMargin:");
		[CompilerGenerated]
		const string selLabelStyle = "labelStyle";
		static readonly IntPtr selLabelStyleHandle = Selector.GetHandle ("labelStyle");
		[CompilerGenerated]
		const string selSetLabelStyle_ = "setLabelStyle:";
		static readonly IntPtr selSetLabelStyle_Handle = Selector.GetHandle ("setLabelStyle:");
		[CompilerGenerated]
		const string selPdfController = "pdfController";
		static readonly IntPtr selPdfControllerHandle = Selector.GetHandle ("pdfController");
		[CompilerGenerated]
		const string selSetPdfController_ = "setPdfController:";
		static readonly IntPtr selSetPdfController_Handle = Selector.GetHandle ("setPdfController:");
		[CompilerGenerated]
		const string selKVOValues = "KVOValues";
		static readonly IntPtr selKVOValuesHandle = Selector.GetHandle ("KVOValues");
		[CompilerGenerated]
		const string selUpdateAnimated_ = "updateAnimated:";
		static readonly IntPtr selUpdateAnimated_Handle = Selector.GetHandle ("updateAnimated:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFLabelView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFLabelView () : base (NSObjectFlag.Empty)
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
		public PSPDFLabelView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFLabelView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFLabelView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("updateAnimated:")]
		[CompilerGenerated]
		public virtual void UpdateAnimated (bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selUpdateAnimated_Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selUpdateAnimated_Handle, animated);
			}
		}
		
		[CompilerGenerated]
		object __mt_Label_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UILabel Label {
			[Export ("label")]
			get {
				global::MonoTouch.UIKit.UILabel ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UILabel) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLabelHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UILabel) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLabelHandle));
				}
				MarkDirty ();
				__mt_Label_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual float LabelMargin {
			[Export ("labelMargin", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selLabelMarginHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selLabelMarginHandle);
				}
			}
			
			[Export ("setLabelMargin:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetLabelMargin_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetLabelMargin_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFLabelStyle LabelStyle {
			[Export ("labelStyle", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFLabelStyle) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selLabelStyleHandle);
				} else {
					return (PSPDFLabelStyle) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selLabelStyleHandle);
				}
			}
			
			[Export ("setLabelStyle:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetLabelStyle_Handle, (UInt32)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetLabelStyle_Handle, (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_PdfController_var;
		[CompilerGenerated]
		public virtual PSPDFViewController PdfController {
			[Export ("pdfController")]
			get {
				PSPDFViewController ret;
				if (IsDirectBinding) {
					ret = (PSPDFViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPdfControllerHandle));
				} else {
					ret = (PSPDFViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPdfControllerHandle));
				}
				MarkDirty ();
				__mt_PdfController_var = ret;
				return ret;
			}
			
			[Export ("setPdfController:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPdfController_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPdfController_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_PdfController_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_KVOValues_var;
		[CompilerGenerated]
		public virtual NSArray KVOValues {
			[Export ("KVOValues")]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selKVOValuesHandle));
				} else {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selKVOValuesHandle));
				}
				MarkDirty ();
				__mt_KVOValues_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Label_var = null;
				__mt_PdfController_var = null;
				__mt_KVOValues_var = null;
			}
		}
	} /* class PSPDFLabelView */
}
