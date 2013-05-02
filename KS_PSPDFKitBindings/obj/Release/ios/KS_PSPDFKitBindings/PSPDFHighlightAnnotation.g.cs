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
	[Register("PSPDFHighlightAnnotation", true)]
	public unsafe partial class PSPDFHighlightAnnotation : PSPDFAnnotation {
		[CompilerGenerated]
		const string selHighlightType = "highlightType";
		static readonly IntPtr selHighlightTypeHandle = Selector.GetHandle ("highlightType");
		[CompilerGenerated]
		const string selSetHighlightType_ = "setHighlightType:";
		static readonly IntPtr selSetHighlightType_Handle = Selector.GetHandle ("setHighlightType:");
		[CompilerGenerated]
		const string selHighlightedString = "highlightedString";
		static readonly IntPtr selHighlightedStringHandle = Selector.GetHandle ("highlightedString");
		[CompilerGenerated]
		const string selInitWithHighlightType_ = "initWithHighlightType:";
		static readonly IntPtr selInitWithHighlightType_Handle = Selector.GetHandle ("initWithHighlightType:");
		[CompilerGenerated]
		const string selSetTypeWithDefaultColor_ = "setType:withDefaultColor:";
		static readonly IntPtr selSetTypeWithDefaultColor_Handle = Selector.GetHandle ("setType:withDefaultColor:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFHighlightAnnotation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFHighlightAnnotation () : base (NSObjectFlag.Empty)
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
		public PSPDFHighlightAnnotation (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFHighlightAnnotation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFHighlightAnnotation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithHighlightType:")]
		[CompilerGenerated]
		public PSPDFHighlightAnnotation (PSPDFHighlightAnnotationType annotationType)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int (this.Handle, selInitWithHighlightType_Handle, (int)annotationType);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, selInitWithHighlightType_Handle, (int)annotationType);
			}
		}
		
		[Export ("setType:withDefaultColor:")]
		[CompilerGenerated]
		public virtual void SetType (PSPDFHighlightAnnotationType annotationType, bool useDefaultColor)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int_bool (this.Handle, selSetTypeWithDefaultColor_Handle, (int)annotationType, useDefaultColor);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int_bool (this.SuperHandle, selSetTypeWithDefaultColor_Handle, (int)annotationType, useDefaultColor);
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFHighlightAnnotationType HighlightType {
			[Export ("highlightType", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFHighlightAnnotationType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selHighlightTypeHandle);
				} else {
					return (PSPDFHighlightAnnotationType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selHighlightTypeHandle);
				}
			}
			
			[Export ("setHighlightType:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetHighlightType_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetHighlightType_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string HighlightedString {
			[Export ("highlightedString")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selHighlightedStringHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selHighlightedStringHandle));
				}
			}
			
		}
		
	} /* class PSPDFHighlightAnnotation */
}
