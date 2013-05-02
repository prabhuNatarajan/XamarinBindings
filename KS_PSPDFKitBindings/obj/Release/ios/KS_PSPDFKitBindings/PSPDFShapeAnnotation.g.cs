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
	[Register("PSPDFShapeAnnotation", true)]
	public unsafe partial class PSPDFShapeAnnotation : PSPDFAnnotation {
		[CompilerGenerated]
		const string selShapeType = "shapeType";
		static readonly IntPtr selShapeTypeHandle = Selector.GetHandle ("shapeType");
		[CompilerGenerated]
		const string selSetShapeType_ = "setShapeType:";
		static readonly IntPtr selSetShapeType_Handle = Selector.GetHandle ("setShapeType:");
		[CompilerGenerated]
		const string selInitWithShapeType_ = "initWithShapeType:";
		static readonly IntPtr selInitWithShapeType_Handle = Selector.GetHandle ("initWithShapeType:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFShapeAnnotation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFShapeAnnotation () : base (NSObjectFlag.Empty)
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
		public PSPDFShapeAnnotation (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFShapeAnnotation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFShapeAnnotation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithShapeType:")]
		[CompilerGenerated]
		public PSPDFShapeAnnotation (PSPDFShapeAnnotationType shapeType)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int (this.Handle, selInitWithShapeType_Handle, (int)shapeType);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, selInitWithShapeType_Handle, (int)shapeType);
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFShapeAnnotationType ShapeType {
			[Export ("shapeType", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFShapeAnnotationType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selShapeTypeHandle);
				} else {
					return (PSPDFShapeAnnotationType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selShapeTypeHandle);
				}
			}
			
			[Export ("setShapeType:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetShapeType_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetShapeType_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		static readonly IntPtr __Internal_libraryHandle = Dlfcn.dlopen (null, 0);
		[CompilerGenerated]
		static NSString _PSPDFGenerateAPForShape;
		public static NSString PSPDFGenerateAPForShape {
			get {
				if (_PSPDFGenerateAPForShape == null)
					_PSPDFGenerateAPForShape = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFGenerateAPForShape");
				return _PSPDFGenerateAPForShape;
			}
		}
	} /* class PSPDFShapeAnnotation */
}
