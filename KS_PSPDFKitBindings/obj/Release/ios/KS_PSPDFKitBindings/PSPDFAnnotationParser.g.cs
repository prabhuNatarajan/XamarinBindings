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
	[Register("PSPDFAnnotationParser", true)]
	public unsafe partial class PSPDFAnnotationParser : NSObject {
		[CompilerGenerated]
		const string selAnnotationProviders = "annotationProviders";
		static readonly IntPtr selAnnotationProvidersHandle = Selector.GetHandle ("annotationProviders");
		[CompilerGenerated]
		const string selSetAnnotationProviders_ = "setAnnotationProviders:";
		static readonly IntPtr selSetAnnotationProviders_Handle = Selector.GetHandle ("setAnnotationProviders:");
		[CompilerGenerated]
		const string selFileAnnotationProvider = "fileAnnotationProvider";
		static readonly IntPtr selFileAnnotationProviderHandle = Selector.GetHandle ("fileAnnotationProvider");
		[CompilerGenerated]
		const string selDocumentProvider = "documentProvider";
		static readonly IntPtr selDocumentProviderHandle = Selector.GetHandle ("documentProvider");
		[CompilerGenerated]
		const string selInitWithDocumentProvider_ = "initWithDocumentProvider:";
		static readonly IntPtr selInitWithDocumentProvider_Handle = Selector.GetHandle ("initWithDocumentProvider:");
		[CompilerGenerated]
		const string selAnnotationsForPagePSPDFAnnotationType_ = "annotationsForPage:PSPDFAnnotationType:";
		static readonly IntPtr selAnnotationsForPagePSPDFAnnotationType_Handle = Selector.GetHandle ("annotationsForPage:PSPDFAnnotationType:");
		[CompilerGenerated]
		const string selAllAnnotationsOfType_ = "allAnnotationsOfType:";
		static readonly IntPtr selAllAnnotationsOfType_Handle = Selector.GetHandle ("allAnnotationsOfType:");
		[CompilerGenerated]
		const string selHasLoadedAnnotationsForPage_ = "hasLoadedAnnotationsForPage:";
		static readonly IntPtr selHasLoadedAnnotationsForPage_Handle = Selector.GetHandle ("hasLoadedAnnotationsForPage:");
		[CompilerGenerated]
		const string selAnnotationClassForAnnotation_ = "annotationClassForAnnotation:";
		static readonly IntPtr selAnnotationClassForAnnotation_Handle = Selector.GetHandle ("annotationClassForAnnotation:");
		[CompilerGenerated]
		const string selAddAnnotationsForPage_ = "addAnnotations:forPage:";
		static readonly IntPtr selAddAnnotationsForPage_Handle = Selector.GetHandle ("addAnnotations:forPage:");
		[CompilerGenerated]
		const string selDidChangeAnnotationOriginalAnnotationKeyPathsOptions_ = "didChangeAnnotation:originalAnnotation:keyPaths:options:";
		static readonly IntPtr selDidChangeAnnotationOriginalAnnotationKeyPathsOptions_Handle = Selector.GetHandle ("didChangeAnnotation:originalAnnotation:keyPaths:options:");
		[CompilerGenerated]
		const string selSaveAnnotationsWithError_ = "saveAnnotationsWithError:";
		static readonly IntPtr selSaveAnnotationsWithError_Handle = Selector.GetHandle ("saveAnnotationsWithError:");
		[CompilerGenerated]
		const string selUpdateAnnotationsOriginalAnnotationsAnimated_ = "updateAnnotations:originalAnnotations:animated:";
		static readonly IntPtr selUpdateAnnotationsOriginalAnnotationsAnimated_Handle = Selector.GetHandle ("updateAnnotations:originalAnnotations:animated:");
		[CompilerGenerated]
		const string selDirtyAnnotations = "dirtyAnnotations";
		static readonly IntPtr selDirtyAnnotationsHandle = Selector.GetHandle ("dirtyAnnotations");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFAnnotationParser");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFAnnotationParser () : base (NSObjectFlag.Empty)
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
		public PSPDFAnnotationParser (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFAnnotationParser (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDocumentProvider:")]
		[CompilerGenerated]
		public PSPDFAnnotationParser (PSPDFDocumentProvider documentProvider)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithDocumentProvider_Handle, documentProvider == null ? IntPtr.Zero : documentProvider.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithDocumentProvider_Handle, documentProvider == null ? IntPtr.Zero : documentProvider.Handle);
			}
		}
		
		[Export ("annotationsForPage:PSPDFAnnotationType:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotation[] AnnotationsForPage (global::System.UInt32 page, PSPDFAnnotationType type)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFAnnotation>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_UInt32 (this.Handle, selAnnotationsForPagePSPDFAnnotationType_Handle, page, (UInt32)type));
			} else {
				return NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFAnnotation>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32_UInt32 (this.SuperHandle, selAnnotationsForPagePSPDFAnnotationType_Handle, page, (UInt32)type));
			}
		}
		
		[Export ("allAnnotationsOfType:")]
		[CompilerGenerated]
		public virtual NSDictionary AllAnnotationsOfType (PSPDFAnnotationType type)
		{
			if (IsDirectBinding) {
				return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selAllAnnotationsOfType_Handle, (UInt32)type));
			} else {
				return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selAllAnnotationsOfType_Handle, (UInt32)type));
			}
		}
		
		[Export ("hasLoadedAnnotationsForPage:")]
		[CompilerGenerated]
		public virtual bool HasLoadedAnnotationsForPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_UInt32 (this.Handle, selHasLoadedAnnotationsForPage_Handle, page);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_UInt32 (this.SuperHandle, selHasLoadedAnnotationsForPage_Handle, page);
			}
		}
		
		[Export ("annotationClassForAnnotation:")]
		[CompilerGenerated]
		public virtual Class AnnotationClassForAnnotation (PSPDFAnnotation annotation)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				return new Class (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selAnnotationClassForAnnotation_Handle, annotation.Handle));
			} else {
				return new Class (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selAnnotationClassForAnnotation_Handle, annotation.Handle));
			}
		}
		
		[Export ("addAnnotations:forPage:")]
		[CompilerGenerated]
		public virtual void AddAnnotations (PSPDFAnnotation[] annotation, global::System.UInt32 page)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			var nsa_annotation = NSArray.FromNSObjects (annotation);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UInt32 (this.Handle, selAddAnnotationsForPage_Handle, nsa_annotation.Handle, page);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, selAddAnnotationsForPage_Handle, nsa_annotation.Handle, page);
			}
			nsa_annotation.Dispose ();
			
		}
		
		[Export ("didChangeAnnotation:originalAnnotation:keyPaths:options:")]
		[CompilerGenerated]
		public virtual void DidChangeAnnotation (PSPDFAnnotation annotation, PSPDFAnnotation originalAnnotation, NSObject[] keyPaths, NSDictionary options)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (originalAnnotation == null)
				throw new ArgumentNullException ("originalAnnotation");
			if (keyPaths == null)
				throw new ArgumentNullException ("keyPaths");
			if (options == null)
				throw new ArgumentNullException ("options");
			var nsa_keyPaths = NSArray.FromNSObjects (keyPaths);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, selDidChangeAnnotationOriginalAnnotationKeyPathsOptions_Handle, annotation.Handle, originalAnnotation.Handle, nsa_keyPaths.Handle, options.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, selDidChangeAnnotationOriginalAnnotationKeyPathsOptions_Handle, annotation.Handle, originalAnnotation.Handle, nsa_keyPaths.Handle, options.Handle);
			}
			nsa_keyPaths.Dispose ();
			
		}
		
		[Export ("saveAnnotationsWithError:")]
		[CompilerGenerated]
		public virtual bool SaveAnnotationsWithError (out NSError error)
		{
			IntPtr errorPtr = Marshal.AllocHGlobal(4);
			Marshal.WriteInt32(errorPtr, 0);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selSaveAnnotationsWithError_Handle, errorPtr);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selSaveAnnotationsWithError_Handle, errorPtr);
			}
			
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? (NSError)Runtime.GetNSObject(errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return ret;
		}
		
		[Export ("updateAnnotations:originalAnnotations:animated:")]
		[CompilerGenerated]
		public virtual void UpdateAnnotations (PSPDFAnnotation[] annotations, PSPDFAnnotation[] originalAnnotations, bool animated)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			var nsa_originalAnnotations = originalAnnotations == null ? null : NSArray.FromNSObjects (originalAnnotations);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_bool (this.Handle, selUpdateAnnotationsOriginalAnnotationsAnimated_Handle, nsa_annotations.Handle, nsa_originalAnnotations == null ? IntPtr.Zero : nsa_originalAnnotations.Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_bool (this.SuperHandle, selUpdateAnnotationsOriginalAnnotationsAnimated_Handle, nsa_annotations.Handle, nsa_originalAnnotations == null ? IntPtr.Zero : nsa_originalAnnotations.Handle, animated);
			}
			nsa_annotations.Dispose ();
			if (nsa_originalAnnotations != null)
				nsa_originalAnnotations.Dispose ();
			
		}
		
		[CompilerGenerated]
		public NSDictionary DirtyAnnotations ()
		{
			return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDirtyAnnotationsHandle));
		}
		
		[CompilerGenerated]
		object __mt_AnnotationProviders_var;
		[CompilerGenerated]
		public virtual NSObject[] AnnotationProviders {
			[Export ("annotationProviders", ArgumentSemantic.Copy)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAnnotationProvidersHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAnnotationProvidersHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AnnotationProviders_var = ret;
				return ret;
			}
			
			[Export ("setAnnotationProviders:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAnnotationProviders_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAnnotationProviders_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_AnnotationProviders_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_FileAnnotationProvider_var;
		[CompilerGenerated]
		public virtual PSPDFFileAnnotationProvider FileAnnotationProvider {
			[Export ("fileAnnotationProvider")]
			get {
				PSPDFFileAnnotationProvider ret;
				if (IsDirectBinding) {
					ret = (PSPDFFileAnnotationProvider) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFileAnnotationProviderHandle));
				} else {
					ret = (PSPDFFileAnnotationProvider) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFileAnnotationProviderHandle));
				}
				MarkDirty ();
				__mt_FileAnnotationProvider_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_DocumentProvider_var;
		[CompilerGenerated]
		public virtual PSPDFDocumentProvider DocumentProvider {
			[Export ("documentProvider")]
			get {
				PSPDFDocumentProvider ret;
				if (IsDirectBinding) {
					ret = (PSPDFDocumentProvider) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocumentProviderHandle));
				} else {
					ret = (PSPDFDocumentProvider) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocumentProviderHandle));
				}
				MarkDirty ();
				__mt_DocumentProvider_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AnnotationProviders_var = null;
				__mt_FileAnnotationProvider_var = null;
				__mt_DocumentProvider_var = null;
			}
		}
	} /* class PSPDFAnnotationParser */
}
