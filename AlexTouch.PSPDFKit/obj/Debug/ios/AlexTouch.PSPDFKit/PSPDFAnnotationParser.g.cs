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
	[Register("PSPDFAnnotationParser", true)]
	public unsafe partial class PSPDFAnnotationParser : NSObject {
		static readonly IntPtr selDocumentProvider = Selector.GetHandle ("documentProvider");
		static readonly IntPtr selProtocolString = Selector.GetHandle ("protocolString");
		static readonly IntPtr selInitWithDocumentProvider_ = Selector.GetHandle ("initWithDocumentProvider:");
		static readonly IntPtr selAnnotationsForPagePSPDFAnnotationType_ = Selector.GetHandle ("annotationsForPage:PSPDFAnnotationType:");
		static readonly IntPtr selParseAnnotationLinkTarget_ = Selector.GetHandle ("parseAnnotationLinkTarget:");
		static readonly IntPtr selHasLoadedAnnotationsForPage_ = Selector.GetHandle ("hasLoadedAnnotationsForPage:");
		static readonly IntPtr selAnnotationClassForAnnotation_ = Selector.GetHandle ("annotationClassForAnnotation:");
		static readonly IntPtr selCreateAnnotationViewForAnnotationFrame_ = Selector.GetHandle ("createAnnotationViewForAnnotation:frame:");
		static readonly IntPtr selSetAnnotationsForPage_ = Selector.GetHandle ("setAnnotations:forPage:");
		static readonly IntPtr selAddAnnotationsForPage_ = Selector.GetHandle ("addAnnotations:forPage:");
		static readonly IntPtr selDirtyAnnotations = Selector.GetHandle ("dirtyAnnotations");
		static readonly IntPtr selAnnotations = Selector.GetHandle ("annotations");
		static readonly IntPtr selRemoveDeletedAnnotations = Selector.GetHandle ("removeDeletedAnnotations");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFAnnotationParser");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFAnnotationParser () : base (NSObjectFlag.Empty)
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
		public PSPDFAnnotationParser (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFAnnotationParser (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFAnnotationParser (IntPtr handle) : base (handle) {}

		[Export ("initWithDocumentProvider:")]
		[CompilerGenerated]
		public PSPDFAnnotationParser (PSPDFDocumentProvider documentProvider) : base (NSObjectFlag.Empty)
		{
			if (documentProvider == null)
				throw new ArgumentNullException ("documentProvider");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithDocumentProvider_, documentProvider.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithDocumentProvider_, documentProvider.Handle);
			}
		}
		
		[Export ("annotationsForPage:PSPDFAnnotationType:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotation[] AnnotationsForPage (System.UInt32 page, PSPDFAnnotationType type)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFAnnotation>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_int (this.Handle, selAnnotationsForPagePSPDFAnnotationType_, page, (int)type));
			} else {
				return NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFAnnotation>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32_int (this.SuperHandle, selAnnotationsForPagePSPDFAnnotationType_, page, (int)type));
			}
		}
		
		[Export ("annotationsForPage:PSPDFAnnotationType:")]
		[CompilerGenerated]
		internal virtual PSPDFAnnotation[] AnnotationsForPage_ (System.UInt32 page, PSPDFAnnotationType type, System.IntPtr pageRef)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFAnnotation>(ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_int_IntPtr (this.Handle, selAnnotationsForPagePSPDFAnnotationType_, page, (int)type, pageRef));
			} else {
				return NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFAnnotation>(ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32_int_IntPtr (this.SuperHandle, selAnnotationsForPagePSPDFAnnotationType_, page, (int)type, pageRef));
			}
		}
		
		[Export ("parseAnnotationLinkTarget:")]
		[CompilerGenerated]
		public virtual void ParseAnnotationLinkTarget (PSPDFAnnotation annotation)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selParseAnnotationLinkTarget_, annotation.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selParseAnnotationLinkTarget_, annotation.Handle);
			}
		}
		
		[Export ("hasLoadedAnnotationsForPage:")]
		[CompilerGenerated]
		public virtual bool HasLoadedAnnotationsForPage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_UInt32 (this.Handle, selHasLoadedAnnotationsForPage_, page);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_UInt32 (this.SuperHandle, selHasLoadedAnnotationsForPage_, page);
			}
		}
		
		[Export ("annotationClassForAnnotation:")]
		[CompilerGenerated]
		public virtual Class AnnotationClassForAnnotation (PSPDFAnnotation annotation)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				return new Class (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selAnnotationClassForAnnotation_, annotation.Handle));
			} else {
				return new Class (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selAnnotationClassForAnnotation_, annotation.Handle));
			}
		}
		
		[Export ("createAnnotationViewForAnnotation:frame:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotationView CreateAnnotationViewForAnnotation (PSPDFAnnotation annotation, System.Drawing.RectangleF annotationRect)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				return (PSPDFAnnotationView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_RectangleF (this.Handle, selCreateAnnotationViewForAnnotationFrame_, annotation.Handle, annotationRect));
			} else {
				return (PSPDFAnnotationView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_RectangleF (this.SuperHandle, selCreateAnnotationViewForAnnotationFrame_, annotation.Handle, annotationRect));
			}
		}
		
		[Export ("setAnnotations:forPage:")]
		[CompilerGenerated]
		public virtual void SetAnnotations (PSPDFAnnotation[] annotation, System.UInt32 page)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			var nsa_annotation = NSArray.FromNSObjects (annotation);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UInt32 (this.Handle, selSetAnnotationsForPage_, nsa_annotation.Handle, page);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, selSetAnnotationsForPage_, nsa_annotation.Handle, page);
			}
			nsa_annotation.Dispose ();
			
		}
		
		[Export ("addAnnotations:forPage:")]
		[CompilerGenerated]
		public virtual void AddAnnotations (PSPDFAnnotation[] annotation, System.UInt32 page)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			var nsa_annotation = NSArray.FromNSObjects (annotation);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UInt32 (this.Handle, selAddAnnotationsForPage_, nsa_annotation.Handle, page);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, selAddAnnotationsForPage_, nsa_annotation.Handle, page);
			}
			nsa_annotation.Dispose ();
			
		}
		
		[Export ("dirtyAnnotations")]
		[CompilerGenerated]
		public virtual NSDictionary DirtyAnnotations ()
		{
			if (IsDirectBinding) {
				return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDirtyAnnotations));
			} else {
				return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDirtyAnnotations));
			}
		}
		
		[Export ("annotations")]
		[CompilerGenerated]
		public virtual NSDictionary Annotations ()
		{
			if (IsDirectBinding) {
				return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAnnotations));
			} else {
				return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAnnotations));
			}
		}
		
		[Export ("removeDeletedAnnotations")]
		[CompilerGenerated]
		public virtual System.UInt32 RemoveDeletedAnnotations ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selRemoveDeletedAnnotations);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selRemoveDeletedAnnotations);
			}
		}
		
		object __mt_DocumentProvider_var;
		[CompilerGenerated]
		public virtual PSPDFDocumentProvider DocumentProvider {
			[Export ("documentProvider")]
			get {
				PSPDFDocumentProvider ret;
				if (IsDirectBinding) {
					ret = (PSPDFDocumentProvider) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocumentProvider));
				} else {
					ret = (PSPDFDocumentProvider) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocumentProvider));
				}
				MarkDirty ();
				__mt_DocumentProvider_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string ProtocolString {
			[Export ("protocolString")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selProtocolString));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selProtocolString));
				}
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_DocumentProvider_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFAnnotationParser */
}
