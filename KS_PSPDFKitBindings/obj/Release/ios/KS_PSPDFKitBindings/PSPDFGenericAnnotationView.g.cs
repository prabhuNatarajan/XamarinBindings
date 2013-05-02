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
	[Register("PSPDFGenericAnnotationView", true)]
	public unsafe partial class PSPDFGenericAnnotationView : global::MonoTouch.UIKit.UIView {
		[CompilerGenerated]
		const string selAnnotation = "annotation";
		static readonly IntPtr selAnnotationHandle = Selector.GetHandle ("annotation");
		[CompilerGenerated]
		const string selInitWithAnnotation_ = "initWithAnnotation:";
		static readonly IntPtr selInitWithAnnotation_Handle = Selector.GetHandle ("initWithAnnotation:");
		[CompilerGenerated]
		const string selAnnotationsChanged_ = "annotationsChanged:";
		static readonly IntPtr selAnnotationsChanged_Handle = Selector.GetHandle ("annotationsChanged:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFGenericAnnotationView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFGenericAnnotationView () : base (NSObjectFlag.Empty)
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
		public PSPDFGenericAnnotationView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFGenericAnnotationView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFGenericAnnotationView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithAnnotation:")]
		[CompilerGenerated]
		public PSPDFGenericAnnotationView (PSPDFAnnotation annotation)
			: base (NSObjectFlag.Empty)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithAnnotation_Handle, annotation.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithAnnotation_Handle, annotation.Handle);
			}
		}
		
		[Export ("annotationsChanged:")]
		[CompilerGenerated]
		public virtual void AnnotationsChanged (NSNotification notification)
		{
			if (notification == null)
				throw new ArgumentNullException ("notification");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAnnotationsChanged_Handle, notification.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selAnnotationsChanged_Handle, notification.Handle);
			}
		}
		
		[CompilerGenerated]
		object __mt_Annotation_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotation Annotation {
			[Export ("annotation")]
			get {
				PSPDFAnnotation ret;
				if (IsDirectBinding) {
					ret = (PSPDFAnnotation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAnnotationHandle));
				} else {
					ret = (PSPDFAnnotation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAnnotationHandle));
				}
				MarkDirty ();
				__mt_Annotation_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Annotation_var = null;
			}
		}
	} /* class PSPDFGenericAnnotationView */
}
