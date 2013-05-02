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
	[Register("PSPDFAnnotationController", true)]
	public unsafe partial class PSPDFAnnotationController : NSObject {
		[CompilerGenerated]
		const string selPdfController = "pdfController";
		static readonly IntPtr selPdfControllerHandle = Selector.GetHandle ("pdfController");
		[CompilerGenerated]
		const string selSetPdfController_ = "setPdfController:";
		static readonly IntPtr selSetPdfController_Handle = Selector.GetHandle ("setPdfController:");
		[CompilerGenerated]
		const string selInitWithPDFController_ = "initWithPDFController:";
		static readonly IntPtr selInitWithPDFController_Handle = Selector.GetHandle ("initWithPDFController:");
		[CompilerGenerated]
		const string selPrepareAnnotationViewForAnnotationFramePageView_ = "prepareAnnotationViewForAnnotation:frame:pageView:";
		static readonly IntPtr selPrepareAnnotationViewForAnnotationFramePageView_Handle = Selector.GetHandle ("prepareAnnotationViewForAnnotation:frame:pageView:");
		[CompilerGenerated]
		const string selHandleTouchUpForAnnotationIgnoredByDelegate_ = "handleTouchUpForAnnotationIgnoredByDelegate:";
		static readonly IntPtr selHandleTouchUpForAnnotationIgnoredByDelegate_Handle = Selector.GetHandle ("handleTouchUpForAnnotationIgnoredByDelegate:");
		[CompilerGenerated]
		const string selRecycleAnnotationView_ = "recycleAnnotationView:";
		static readonly IntPtr selRecycleAnnotationView_Handle = Selector.GetHandle ("recycleAnnotationView:");
		[CompilerGenerated]
		const string selDequeueViewFromCacheForAnnotationClass_ = "dequeueViewFromCacheForAnnotation:class:";
		static readonly IntPtr selDequeueViewFromCacheForAnnotationClass_Handle = Selector.GetHandle ("dequeueViewFromCacheForAnnotation:class:");
		[CompilerGenerated]
		const string selClearCache = "clearCache";
		static readonly IntPtr selClearCacheHandle = Selector.GetHandle ("clearCache");
		[CompilerGenerated]
		const string selCreateAnnotationViewForAnnotationFrame_ = "createAnnotationViewForAnnotation:frame:";
		static readonly IntPtr selCreateAnnotationViewForAnnotationFrame_Handle = Selector.GetHandle ("createAnnotationViewForAnnotation:frame:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFAnnotationController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFAnnotationController () : base (NSObjectFlag.Empty)
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
		public PSPDFAnnotationController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFAnnotationController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFAnnotationController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithPDFController:")]
		[CompilerGenerated]
		public PSPDFAnnotationController (PSPDFViewController pdfController)
			: base (NSObjectFlag.Empty)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithPDFController_Handle, pdfController.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithPDFController_Handle, pdfController.Handle);
			}
		}
		
		[Export ("prepareAnnotationViewForAnnotation:frame:pageView:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotationViewProtocol PrepareAnnotationViewForAnnotation (PSPDFAnnotation annotation, global::System.Drawing.RectangleF annotationRect, PSPDFPageView pageView)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			if (IsDirectBinding) {
				return (PSPDFAnnotationViewProtocol) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_RectangleF_IntPtr (this.Handle, selPrepareAnnotationViewForAnnotationFramePageView_Handle, annotation.Handle, annotationRect, pageView.Handle));
			} else {
				return (PSPDFAnnotationViewProtocol) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_RectangleF_IntPtr (this.SuperHandle, selPrepareAnnotationViewForAnnotationFramePageView_Handle, annotation.Handle, annotationRect, pageView.Handle));
			}
		}
		
		[Export ("handleTouchUpForAnnotationIgnoredByDelegate:")]
		[CompilerGenerated]
		public virtual void HandleTouchUpForAnnotationIgnoredByDelegate (PSPDFLinkAnnotationView annotationView)
		{
			if (annotationView == null)
				throw new ArgumentNullException ("annotationView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selHandleTouchUpForAnnotationIgnoredByDelegate_Handle, annotationView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selHandleTouchUpForAnnotationIgnoredByDelegate_Handle, annotationView.Handle);
			}
		}
		
		[Export ("recycleAnnotationView:")]
		[CompilerGenerated]
		public virtual void RecycleAnnotationView (PSPDFAnnotationViewProtocol annotationView)
		{
			if (annotationView == null)
				throw new ArgumentNullException ("annotationView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRecycleAnnotationView_Handle, annotationView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selRecycleAnnotationView_Handle, annotationView.Handle);
			}
		}
		
		[Export ("dequeueViewFromCacheForAnnotation:class:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotationViewProtocol DequeueViewFromCacheForAnnotation (PSPDFAnnotation annotation, Class annotationViewClass)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (annotationViewClass == null)
				throw new ArgumentNullException ("annotationViewClass");
			if (IsDirectBinding) {
				return (PSPDFAnnotationViewProtocol) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selDequeueViewFromCacheForAnnotationClass_Handle, annotation.Handle, annotationViewClass.Handle));
			} else {
				return (PSPDFAnnotationViewProtocol) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selDequeueViewFromCacheForAnnotationClass_Handle, annotation.Handle, annotationViewClass.Handle));
			}
		}
		
		[Export ("clearCache")]
		[CompilerGenerated]
		public virtual void ClearCache ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selClearCacheHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selClearCacheHandle);
			}
		}
		
		[Export ("createAnnotationViewForAnnotation:frame:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotationViewProtocol CreateAnnotationViewForAnnotation (PSPDFAnnotation annotation, global::System.Drawing.RectangleF annotationRect)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				return (PSPDFAnnotationViewProtocol) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_RectangleF (this.Handle, selCreateAnnotationViewForAnnotationFrame_Handle, annotation.Handle, annotationRect));
			} else {
				return (PSPDFAnnotationViewProtocol) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_RectangleF (this.SuperHandle, selCreateAnnotationViewForAnnotationFrame_Handle, annotation.Handle, annotationRect));
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
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_PdfController_var = null;
			}
		}
	} /* class PSPDFAnnotationController */
}
