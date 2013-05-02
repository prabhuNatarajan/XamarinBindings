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
	[Register("PSPDFFileAnnotationProvider", true)]
	public unsafe partial class PSPDFFileAnnotationProvider : NSObject {
		[CompilerGenerated]
		const string selDocumentProvider = "documentProvider";
		static readonly IntPtr selDocumentProviderHandle = Selector.GetHandle ("documentProvider");
		[CompilerGenerated]
		const string selSetDocumentProvider_ = "setDocumentProvider:";
		static readonly IntPtr selSetDocumentProvider_Handle = Selector.GetHandle ("setDocumentProvider:");
		[CompilerGenerated]
		const string selDefaultAnnotationUsername = "defaultAnnotationUsername";
		static readonly IntPtr selDefaultAnnotationUsernameHandle = Selector.GetHandle ("defaultAnnotationUsername");
		[CompilerGenerated]
		const string selSetDefaultAnnotationUsername_ = "setDefaultAnnotationUsername:";
		static readonly IntPtr selSetDefaultAnnotationUsername_Handle = Selector.GetHandle ("setDefaultAnnotationUsername:");
		[CompilerGenerated]
		const string selAnnotationsPath = "annotationsPath";
		static readonly IntPtr selAnnotationsPathHandle = Selector.GetHandle ("annotationsPath");
		[CompilerGenerated]
		const string selSetAnnotationsPath_ = "setAnnotationsPath:";
		static readonly IntPtr selSetAnnotationsPath_Handle = Selector.GetHandle ("setAnnotationsPath:");
		[CompilerGenerated]
		const string selProviderDelegate = "providerDelegate";
		static readonly IntPtr selProviderDelegateHandle = Selector.GetHandle ("providerDelegate");
		[CompilerGenerated]
		const string selSetProviderDelegate_ = "setProviderDelegate:";
		static readonly IntPtr selSetProviderDelegate_Handle = Selector.GetHandle ("setProviderDelegate:");
		[CompilerGenerated]
		const string selInitWithDocumentProvider_ = "initWithDocumentProvider:";
		static readonly IntPtr selInitWithDocumentProvider_Handle = Selector.GetHandle ("initWithDocumentProvider:");
		[CompilerGenerated]
		const string selAnnotationsForPagePageRef_ = "annotationsForPage:pageRef:";
		static readonly IntPtr selAnnotationsForPagePageRef_Handle = Selector.GetHandle ("annotationsForPage:pageRef:");
		[CompilerGenerated]
		const string selSetAnnotationsForPage_ = "setAnnotations:forPage:";
		static readonly IntPtr selSetAnnotationsForPage_Handle = Selector.GetHandle ("setAnnotations:forPage:");
		[CompilerGenerated]
		const string selClearCache = "clearCache";
		static readonly IntPtr selClearCacheHandle = Selector.GetHandle ("clearCache");
		[CompilerGenerated]
		const string selTryLoadAnnotationsFromFileWithError_ = "tryLoadAnnotationsFromFileWithError:";
		static readonly IntPtr selTryLoadAnnotationsFromFileWithError_Handle = Selector.GetHandle ("tryLoadAnnotationsFromFileWithError:");
		[CompilerGenerated]
		const string selParseAnnotationsForPagePageRef_ = "parseAnnotationsForPage:pageRef:";
		static readonly IntPtr selParseAnnotationsForPagePageRef_Handle = Selector.GetHandle ("parseAnnotationsForPage:pageRef:");
		[CompilerGenerated]
		const string selLoadAnnotationsWithError_ = "loadAnnotationsWithError:";
		static readonly IntPtr selLoadAnnotationsWithError_Handle = Selector.GetHandle ("loadAnnotationsWithError:");
		[CompilerGenerated]
		const string selParseAnnotationLinkTarget_ = "parseAnnotationLinkTarget:";
		static readonly IntPtr selParseAnnotationLinkTarget_Handle = Selector.GetHandle ("parseAnnotationLinkTarget:");
		[CompilerGenerated]
		const string selResolvePathForDocumentPage_ = "resolvePath:forDocument:page:";
		static readonly IntPtr selResolvePathForDocumentPage_Handle = Selector.GetHandle ("resolvePath:forDocument:page:");
		[CompilerGenerated]
		const string selRemoveDeletedAnnotations = "removeDeletedAnnotations";
		static readonly IntPtr selRemoveDeletedAnnotationsHandle = Selector.GetHandle ("removeDeletedAnnotations");
		[CompilerGenerated]
		const string selUpdateAnnotationsPageAndDocumentReferencePage_ = "updateAnnotationsPageAndDocumentReference:page:";
		static readonly IntPtr selUpdateAnnotationsPageAndDocumentReferencePage_Handle = Selector.GetHandle ("updateAnnotationsPageAndDocumentReference:page:");
		[CompilerGenerated]
		const string selAnnotationsForPage_ = "annotationsForPage:";
		static readonly IntPtr selAnnotationsForPage_Handle = Selector.GetHandle ("annotationsForPage:");
		[CompilerGenerated]
		const string selHasLoadedAnnotationsForPage_ = "hasLoadedAnnotationsForPage:";
		static readonly IntPtr selHasLoadedAnnotationsForPage_Handle = Selector.GetHandle ("hasLoadedAnnotationsForPage:");
		[CompilerGenerated]
		const string selAddAnnotationsForPage_ = "addAnnotations:forPage:";
		static readonly IntPtr selAddAnnotationsForPage_Handle = Selector.GetHandle ("addAnnotations:forPage:");
		[CompilerGenerated]
		const string selSaveAnnotationsWithError_ = "saveAnnotationsWithError:";
		static readonly IntPtr selSaveAnnotationsWithError_Handle = Selector.GetHandle ("saveAnnotationsWithError:");
		[CompilerGenerated]
		const string selDirtyAnnotations = "dirtyAnnotations";
		static readonly IntPtr selDirtyAnnotationsHandle = Selector.GetHandle ("dirtyAnnotations");
		[CompilerGenerated]
		const string selDidChangeAnnotationOriginalAnnotationKeyPathsOptions_ = "didChangeAnnotation:originalAnnotation:keyPaths:options:";
		static readonly IntPtr selDidChangeAnnotationOriginalAnnotationKeyPathsOptions_Handle = Selector.GetHandle ("didChangeAnnotation:originalAnnotation:keyPaths:options:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFFileAnnotationProvider");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFFileAnnotationProvider () : base (NSObjectFlag.Empty)
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
		public PSPDFFileAnnotationProvider (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFFileAnnotationProvider (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFFileAnnotationProvider (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDocumentProvider:")]
		[CompilerGenerated]
		public PSPDFFileAnnotationProvider (PSPDFDocumentProvider documentProvider)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithDocumentProvider_Handle, documentProvider == null ? IntPtr.Zero : documentProvider.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithDocumentProvider_Handle, documentProvider == null ? IntPtr.Zero : documentProvider.Handle);
			}
		}
		
		[Export ("annotationsForPage:pageRef:")]
		[CompilerGenerated]
		internal virtual PSPDFAnnotation[] AnnotationsForPage_ (global::System.UInt32 page, global::System.IntPtr pageRef)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFAnnotation>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (this.Handle, selAnnotationsForPagePageRef_Handle, page, pageRef));
			} else {
				return NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFAnnotation>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32_IntPtr (this.SuperHandle, selAnnotationsForPagePageRef_Handle, page, pageRef));
			}
		}
		
		[Export ("setAnnotations:forPage:")]
		[CompilerGenerated]
		public virtual void SetAnnotations (PSPDFAnnotation[] annotations, global::System.UInt32 page)
		{
			var nsa_annotations = annotations == null ? null : NSArray.FromNSObjects (annotations);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UInt32 (this.Handle, selSetAnnotationsForPage_Handle, nsa_annotations == null ? IntPtr.Zero : nsa_annotations.Handle, page);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, selSetAnnotationsForPage_Handle, nsa_annotations == null ? IntPtr.Zero : nsa_annotations.Handle, page);
			}
			if (nsa_annotations != null)
				nsa_annotations.Dispose ();
			
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
		
		[Export ("tryLoadAnnotationsFromFileWithError:")]
		[CompilerGenerated]
		internal virtual bool _TryLoadAnnotationsFromFileWithError (global::System.IntPtr error)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selTryLoadAnnotationsFromFileWithError_Handle, error);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selTryLoadAnnotationsFromFileWithError_Handle, error);
			}
		}
		
		[Export ("parseAnnotationsForPage:pageRef:")]
		[CompilerGenerated]
		internal virtual PSPDFAnnotation[] ParseAnnotationsForPage_ (global::System.UInt32 page, global::System.IntPtr pageRef)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFAnnotation>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (this.Handle, selParseAnnotationsForPagePageRef_Handle, page, pageRef));
			} else {
				return NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFAnnotation>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32_IntPtr (this.SuperHandle, selParseAnnotationsForPagePageRef_Handle, page, pageRef));
			}
		}
		
		[Export ("loadAnnotationsWithError:")]
		[CompilerGenerated]
		public virtual NSDictionary LoadAnnotationsWithError (out NSError error)
		{
			IntPtr errorPtr = Marshal.AllocHGlobal(4);
			Marshal.WriteInt32(errorPtr, 0);
			
			NSDictionary ret;
			if (IsDirectBinding) {
				ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selLoadAnnotationsWithError_Handle, errorPtr));
			} else {
				ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selLoadAnnotationsWithError_Handle, errorPtr));
			}
			
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? (NSError)Runtime.GetNSObject(errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return ret;
		}
		
		[Export ("parseAnnotationLinkTarget:")]
		[CompilerGenerated]
		public virtual void ParseAnnotationLinkTarget (PSPDFLinkAnnotation linkAnnotation)
		{
			if (linkAnnotation == null)
				throw new ArgumentNullException ("linkAnnotation");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selParseAnnotationLinkTarget_Handle, linkAnnotation.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selParseAnnotationLinkTarget_Handle, linkAnnotation.Handle);
			}
		}
		
		[CompilerGenerated]
		public static NSUrl ResolvePath (string path, PSPDFDocument document, global::System.UInt32 page)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			if (document == null)
				throw new ArgumentNullException ("document");
			var nspath = NSString.CreateNative (path);
			
			NSUrl ret;
			ret = (NSUrl) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt32 (class_ptr, selResolvePathForDocumentPage_Handle, nspath, document.Handle, page));
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
		[Export ("removeDeletedAnnotations")]
		[CompilerGenerated]
		public virtual global::System.UInt32 RemoveDeletedAnnotations ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selRemoveDeletedAnnotationsHandle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selRemoveDeletedAnnotationsHandle);
			}
		}
		
		[Export ("updateAnnotationsPageAndDocumentReference:page:")]
		[CompilerGenerated]
		public virtual void UpdateAnnotationsPageAndDocumentReference (PSPDFAnnotation[] annotations, global::System.UInt32 page)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UInt32 (this.Handle, selUpdateAnnotationsPageAndDocumentReferencePage_Handle, nsa_annotations.Handle, page);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, selUpdateAnnotationsPageAndDocumentReferencePage_Handle, nsa_annotations.Handle, page);
			}
			nsa_annotations.Dispose ();
			
		}
		
		[Export ("annotationsForPage:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotation[] AnnotationsForPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFAnnotation>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selAnnotationsForPage_Handle, page));
			} else {
				return NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFAnnotation>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selAnnotationsForPage_Handle, page));
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
		
		[Export ("addAnnotations:forPage:")]
		[CompilerGenerated]
		public virtual bool AddAnnotations (PSPDFAnnotation[] annotations, global::System.UInt32 page)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_UInt32 (this.Handle, selAddAnnotationsForPage_Handle, nsa_annotations.Handle, page);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, selAddAnnotationsForPage_Handle, nsa_annotations.Handle, page);
			}
			nsa_annotations.Dispose ();
			
			return ret;
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
		
		[Export ("dirtyAnnotations")]
		[CompilerGenerated]
		public virtual NSDictionary DirtyAnnotations ()
		{
			if (IsDirectBinding) {
				return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDirtyAnnotationsHandle));
			} else {
				return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDirtyAnnotationsHandle));
			}
		}
		
		[Export ("didChangeAnnotation:originalAnnotation:keyPaths:options:")]
		[CompilerGenerated]
		public virtual void DidChangeAnnotation (PSPDFAnnotation annotation, PSPDFAnnotation originalAnnotation, NSArray keyPaths, NSDictionary options)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (originalAnnotation == null)
				throw new ArgumentNullException ("originalAnnotation");
			if (keyPaths == null)
				throw new ArgumentNullException ("keyPaths");
			if (options == null)
				throw new ArgumentNullException ("options");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, selDidChangeAnnotationOriginalAnnotationKeyPathsOptions_Handle, annotation.Handle, originalAnnotation.Handle, keyPaths.Handle, options.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, selDidChangeAnnotationOriginalAnnotationKeyPathsOptions_Handle, annotation.Handle, originalAnnotation.Handle, keyPaths.Handle, options.Handle);
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
			
			[Export ("setDocumentProvider:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDocumentProvider_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDocumentProvider_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_DocumentProvider_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string DefaultAnnotationUsername {
			[Export ("defaultAnnotationUsername", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDefaultAnnotationUsernameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDefaultAnnotationUsernameHandle));
				}
			}
			
			[Export ("setDefaultAnnotationUsername:", ArgumentSemantic.Copy)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDefaultAnnotationUsername_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDefaultAnnotationUsername_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string AnnotationsPath {
			[Export ("annotationsPath", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAnnotationsPathHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAnnotationsPathHandle));
				}
			}
			
			[Export ("setAnnotationsPath:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAnnotationsPath_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAnnotationsPath_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public PSPDFAnnotationProviderChangeNotifier ProviderDelegate {
			get {
				return WeakProviderDelegate as PSPDFAnnotationProviderChangeNotifier;
			}
			set {
				WeakProviderDelegate = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakProviderDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakProviderDelegate {
			[Export ("providerDelegate", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selProviderDelegateHandle));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selProviderDelegateHandle));
				}
				MarkDirty ();
				__mt_WeakProviderDelegate_var = ret;
				return ret;
			}
			
			[Export ("setProviderDelegate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetProviderDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetProviderDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakProviderDelegate_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_DocumentProvider_var = null;
				__mt_WeakProviderDelegate_var = null;
			}
		}
	} /* class PSPDFFileAnnotationProvider */
}
