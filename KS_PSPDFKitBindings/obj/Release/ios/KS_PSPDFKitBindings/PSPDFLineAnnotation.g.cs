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
	[Register("PSPDFLineAnnotation", true)]
	public unsafe partial class PSPDFLineAnnotation : PSPDFAnnotation {
		[CompilerGenerated]
		const string selPoint1 = "point1";
		static readonly IntPtr selPoint1Handle = Selector.GetHandle ("point1");
		[CompilerGenerated]
		const string selSetPoint1_ = "setPoint1:";
		static readonly IntPtr selSetPoint1_Handle = Selector.GetHandle ("setPoint1:");
		[CompilerGenerated]
		const string selPoint2 = "point2";
		static readonly IntPtr selPoint2Handle = Selector.GetHandle ("point2");
		[CompilerGenerated]
		const string selSetPoint2_ = "setPoint2:";
		static readonly IntPtr selSetPoint2_Handle = Selector.GetHandle ("setPoint2:");
		[CompilerGenerated]
		const string selLineEnd1 = "lineEnd1";
		static readonly IntPtr selLineEnd1Handle = Selector.GetHandle ("lineEnd1");
		[CompilerGenerated]
		const string selSetLineEnd1_ = "setLineEnd1:";
		static readonly IntPtr selSetLineEnd1_Handle = Selector.GetHandle ("setLineEnd1:");
		[CompilerGenerated]
		const string selLineEnd2 = "lineEnd2";
		static readonly IntPtr selLineEnd2Handle = Selector.GetHandle ("lineEnd2");
		[CompilerGenerated]
		const string selSetLineEnd2_ = "setLineEnd2:";
		static readonly IntPtr selSetLineEnd2_Handle = Selector.GetHandle ("setLineEnd2:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFLineAnnotation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFLineAnnotation () : base (NSObjectFlag.Empty)
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
		public PSPDFLineAnnotation (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFLineAnnotation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFLineAnnotation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual global::System.Drawing.PointF Point1 {
			[Export ("point1", ArgumentSemantic.Assign)]
			get {
				global::System.Drawing.PointF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSend_stret (out ret, this.Handle, selPoint1Handle);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSend (this.Handle, selPoint1Handle);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selPoint1Handle);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSendSuper (this.SuperHandle, selPoint1Handle);
					}
				}
				return ret;
			}
			
			[Export ("setPoint1:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_PointF (this.Handle, selSetPoint1_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_PointF (this.SuperHandle, selSetPoint1_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Drawing.PointF Point2 {
			[Export ("point2", ArgumentSemantic.Assign)]
			get {
				global::System.Drawing.PointF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSend_stret (out ret, this.Handle, selPoint2Handle);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSend (this.Handle, selPoint2Handle);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selPoint2Handle);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSendSuper (this.SuperHandle, selPoint2Handle);
					}
				}
				return ret;
			}
			
			[Export ("setPoint2:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_PointF (this.Handle, selSetPoint2_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_PointF (this.SuperHandle, selSetPoint2_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFLineEndType LineEnd1 {
			[Export ("lineEnd1", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFLineEndType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selLineEnd1Handle);
				} else {
					return (PSPDFLineEndType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selLineEnd1Handle);
				}
			}
			
			[Export ("setLineEnd1:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetLineEnd1_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetLineEnd1_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFLineEndType LineEnd2 {
			[Export ("lineEnd2", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFLineEndType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selLineEnd2Handle);
				} else {
					return (PSPDFLineEndType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selLineEnd2Handle);
				}
			}
			
			[Export ("setLineEnd2:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetLineEnd2_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetLineEnd2_Handle, (int)value);
				}
			}
		}
		
	} /* class PSPDFLineAnnotation */
}
