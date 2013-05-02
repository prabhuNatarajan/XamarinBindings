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
	[Register("PSPDFInkAnnotation", true)]
	public unsafe partial class PSPDFInkAnnotation : PSPDFAnnotation {
		[CompilerGenerated]
		const string selLines = "lines";
		static readonly IntPtr selLinesHandle = Selector.GetHandle ("lines");
		[CompilerGenerated]
		const string selSetLines_ = "setLines:";
		static readonly IntPtr selSetLines_Handle = Selector.GetHandle ("setLines:");
		[CompilerGenerated]
		const string selPaths = "paths";
		static readonly IntPtr selPathsHandle = Selector.GetHandle ("paths");
		[CompilerGenerated]
		const string selSetBoundingBoxTransformLines_ = "setBoundingBox:transformLines:";
		static readonly IntPtr selSetBoundingBoxTransformLines_Handle = Selector.GetHandle ("setBoundingBox:transformLines:");
		[CompilerGenerated]
		const string selCopyLinesByApplyingTransform_ = "copyLinesByApplyingTransform:";
		static readonly IntPtr selCopyLinesByApplyingTransform_Handle = Selector.GetHandle ("copyLinesByApplyingTransform:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFInkAnnotation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFInkAnnotation () : base (NSObjectFlag.Empty)
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
		public PSPDFInkAnnotation (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFInkAnnotation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFInkAnnotation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setBoundingBox:transformLines:")]
		[CompilerGenerated]
		public virtual void SetBoundingBox (global::System.Drawing.RectangleF boundingBox, bool transformLines)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_RectangleF_bool (this.Handle, selSetBoundingBoxTransformLines_Handle, boundingBox, transformLines);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_RectangleF_bool (this.SuperHandle, selSetBoundingBoxTransformLines_Handle, boundingBox, transformLines);
			}
		}
		
		[Export ("copyLinesByApplyingTransform:")]
		[CompilerGenerated]
		public virtual NSArray CopyLinesByApplyingTransform (CGAffineTransform transfrom)
		{
			if (IsDirectBinding) {
				return (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGAffineTransform (this.Handle, selCopyLinesByApplyingTransform_Handle, transfrom));
			} else {
				return (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGAffineTransform (this.SuperHandle, selCopyLinesByApplyingTransform_Handle, transfrom));
			}
		}
		
		[CompilerGenerated]
		object __mt_Lines_var;
		[CompilerGenerated]
		public virtual NSArray Lines {
			[Export ("lines", ArgumentSemantic.Copy)]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLinesHandle));
				} else {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLinesHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Lines_var = ret;
				return ret;
			}
			
			[Export ("setLines:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLines_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLines_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Lines_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Paths_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIBezierPath[] Paths {
			[Export ("paths")]
			get {
				global::MonoTouch.UIKit.UIBezierPath[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.UIKit.UIBezierPath>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPathsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.UIKit.UIBezierPath>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPathsHandle));
				}
				MarkDirty ();
				__mt_Paths_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Lines_var = null;
				__mt_Paths_var = null;
			}
		}
	} /* class PSPDFInkAnnotation */
}
