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
	[Register("PSPDFNoteAnnotationView", true)]
	public unsafe partial class PSPDFNoteAnnotationView : PSPDFGenericAnnotationView {
		[CompilerGenerated]
		const string selAnnotationImageView = "annotationImageView";
		static readonly IntPtr selAnnotationImageViewHandle = Selector.GetHandle ("annotationImageView");
		[CompilerGenerated]
		const string selSetAnnotationImageView_ = "setAnnotationImageView:";
		static readonly IntPtr selSetAnnotationImageView_Handle = Selector.GetHandle ("setAnnotationImageView:");
		[CompilerGenerated]
		const string selInitWithAnnotation_ = "initWithAnnotation:";
		static readonly IntPtr selInitWithAnnotation_Handle = Selector.GetHandle ("initWithAnnotation:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFNoteAnnotationView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFNoteAnnotationView () : base (NSObjectFlag.Empty)
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
		public PSPDFNoteAnnotationView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFNoteAnnotationView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFNoteAnnotationView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithAnnotation:")]
		[CompilerGenerated]
		public PSPDFNoteAnnotationView (PSPDFNoteAnnotation noteAnnotation)
			: base (NSObjectFlag.Empty)
		{
			if (noteAnnotation == null)
				throw new ArgumentNullException ("noteAnnotation");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithAnnotation_Handle, noteAnnotation.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithAnnotation_Handle, noteAnnotation.Handle);
			}
		}
		
		[CompilerGenerated]
		object __mt_AnnotationImageView_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIImageView AnnotationImageView {
			[Export ("annotationImageView")]
			get {
				global::MonoTouch.UIKit.UIImageView ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAnnotationImageViewHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAnnotationImageViewHandle));
				}
				MarkDirty ();
				__mt_AnnotationImageView_var = ret;
				return ret;
			}
			
			[Export ("setAnnotationImageView:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAnnotationImageView_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAnnotationImageView_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_AnnotationImageView_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AnnotationImageView_var = null;
			}
		}
	} /* class PSPDFNoteAnnotationView */
}
