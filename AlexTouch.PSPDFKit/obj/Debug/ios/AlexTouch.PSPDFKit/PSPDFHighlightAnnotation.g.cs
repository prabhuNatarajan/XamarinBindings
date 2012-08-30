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
	[Register("PSPDFHighlightAnnotation", true)]
	public unsafe partial class PSPDFHighlightAnnotation : PSPDFAnnotation {
		static readonly IntPtr selHighlightType = Selector.GetHandle ("highlightType");
		static readonly IntPtr selSetHighlightType_ = Selector.GetHandle ("setHighlightType:");
		static readonly IntPtr selRects = Selector.GetHandle ("rects");
		static readonly IntPtr selSetRects_ = Selector.GetHandle ("setRects:");
		static readonly IntPtr selInitWithAnnotationDictionaryInAnnotsArray_ = Selector.GetHandle ("initWithAnnotationDictionary:inAnnotsArray:");
		static readonly IntPtr selInitWithType_ = Selector.GetHandle ("initWithType:");
		static readonly IntPtr selSetTypeWithDefaultColor_ = Selector.GetHandle ("setType:withDefaultColor:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFHighlightAnnotation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFHighlightAnnotation () : base (NSObjectFlag.Empty)
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
		public PSPDFHighlightAnnotation (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFHighlightAnnotation (IntPtr handle) : base (handle) {}

		[Export ("initWithAnnotationDictionary:inAnnotsArray:")]
		[CompilerGenerated]
		internal PSPDFHighlightAnnotation (System.IntPtr annotDict, System.IntPtr annotsArray) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithAnnotationDictionaryInAnnotsArray_, annotDict, annotsArray);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithAnnotationDictionaryInAnnotsArray_, annotDict, annotsArray);
			}
		}
		
		[Export ("initWithType:")]
		[CompilerGenerated]
		public PSPDFHighlightAnnotation (PSPDFHighlightAnnotationType annotationType) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int (this.Handle, selInitWithType_, (int)annotationType);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, selInitWithType_, (int)annotationType);
			}
		}
		
		[Export ("setType:withDefaultColor:")]
		[CompilerGenerated]
		public virtual void SetTypeWithDefaultColor (PSPDFHighlightAnnotationType annotationType, bool useDefaultColor)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int_bool (this.Handle, selSetTypeWithDefaultColor_, (int)annotationType, useDefaultColor);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int_bool (this.SuperHandle, selSetTypeWithDefaultColor_, (int)annotationType, useDefaultColor);
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFHighlightAnnotationType HighlightType {
			[Export ("highlightType", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFHighlightAnnotationType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selHighlightType);
				} else {
					return (PSPDFHighlightAnnotationType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selHighlightType);
				}
			}
			
			[Export ("setHighlightType:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetHighlightType_, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetHighlightType_, (int)value);
				}
			}
		}
		
		object __mt_Rects_var;
		[CompilerGenerated]
		public virtual NSArray Rects {
			[Export ("rects")]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRects));
				} else {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRects));
				}
				MarkDirty ();
				__mt_Rects_var = ret;
				return ret;
			}
			
			[Export ("setRects:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRects_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRects_, value.Handle);
				}
				MarkDirty ();
				__mt_Rects_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_Rects_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFHighlightAnnotation */
}
