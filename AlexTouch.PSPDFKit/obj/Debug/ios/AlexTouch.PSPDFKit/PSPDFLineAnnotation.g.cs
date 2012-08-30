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
	[Register("PSPDFLineAnnotation", true)]
	public unsafe partial class PSPDFLineAnnotation : PSPDFAnnotation {
		static readonly IntPtr selPoint1 = Selector.GetHandle ("point1");
		static readonly IntPtr selSetPoint1_ = Selector.GetHandle ("setPoint1:");
		static readonly IntPtr selPoint2 = Selector.GetHandle ("point2");
		static readonly IntPtr selSetPoint2_ = Selector.GetHandle ("setPoint2:");
		static readonly IntPtr selLineEnd1 = Selector.GetHandle ("lineEnd1");
		static readonly IntPtr selSetLineEnd1_ = Selector.GetHandle ("setLineEnd1:");
		static readonly IntPtr selLineEnd2 = Selector.GetHandle ("lineEnd2");
		static readonly IntPtr selSetLineEnd2_ = Selector.GetHandle ("setLineEnd2:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFLineAnnotation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFLineAnnotation () : base (NSObjectFlag.Empty)
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
		public PSPDFLineAnnotation (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFLineAnnotation (IntPtr handle) : base (handle) {}

		[CompilerGenerated]
		public virtual System.Drawing.PointF Point1 {
			[Export ("point1", ArgumentSemantic.Assign)]
			get {
				System.Drawing.PointF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSend_stret (out ret, this.Handle, selPoint1);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSend (this.Handle, selPoint1);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selPoint1);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSendSuper (this.SuperHandle, selPoint1);
					}
				}
				return ret;
			}
			
			[Export ("setPoint1:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_PointF (this.Handle, selSetPoint1_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_PointF (this.SuperHandle, selSetPoint1_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual System.Drawing.PointF Point2 {
			[Export ("point2", ArgumentSemantic.Assign)]
			get {
				System.Drawing.PointF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSend_stret (out ret, this.Handle, selPoint2);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSend (this.Handle, selPoint2);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selPoint2);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSendSuper (this.SuperHandle, selPoint2);
					}
				}
				return ret;
			}
			
			[Export ("setPoint2:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_PointF (this.Handle, selSetPoint2_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_PointF (this.SuperHandle, selSetPoint2_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFLineEndType LineEnd1 {
			[Export ("lineEnd1", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFLineEndType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selLineEnd1);
				} else {
					return (PSPDFLineEndType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selLineEnd1);
				}
			}
			
			[Export ("setLineEnd1:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetLineEnd1_, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetLineEnd1_, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFLineEndType LineEnd2 {
			[Export ("lineEnd2", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFLineEndType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selLineEnd2);
				} else {
					return (PSPDFLineEndType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selLineEnd2);
				}
			}
			
			[Export ("setLineEnd2:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetLineEnd2_, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetLineEnd2_, (int)value);
				}
			}
		}
		
	} /* class PSPDFLineAnnotation */
}
