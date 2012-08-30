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
	[Register("PSPDFDocumentProvider", true)]
	public unsafe partial class PSPDFDocumentProvider : NSObject {
		static readonly IntPtr selFileURL = Selector.GetHandle ("fileURL");
		static readonly IntPtr selData = Selector.GetHandle ("data");
		static readonly IntPtr selDataProvider = Selector.GetHandle ("dataProvider");
		static readonly IntPtr selDocument = Selector.GetHandle ("document");
		static readonly IntPtr selDelegate = Selector.GetHandle ("delegate");
		static readonly IntPtr selSetDelegate_ = Selector.GetHandle ("setDelegate:");
		static readonly IntPtr selPageCount = Selector.GetHandle ("pageCount");
		static readonly IntPtr selPassword = Selector.GetHandle ("password");
		static readonly IntPtr selSetPassword_ = Selector.GetHandle ("setPassword:");
		static readonly IntPtr selAllowsCopying = Selector.GetHandle ("allowsCopying");
		static readonly IntPtr selIsEncrypted = Selector.GetHandle ("isEncrypted");
		static readonly IntPtr selEncryptionFilter = Selector.GetHandle ("encryptionFilter");
		static readonly IntPtr selIsLocked = Selector.GetHandle ("isLocked");
		static readonly IntPtr selCanEmbedAnnotations = Selector.GetHandle ("canEmbedAnnotations");
		static readonly IntPtr selSetCanEmbedAnnotations_ = Selector.GetHandle ("setCanEmbedAnnotations:");
		static readonly IntPtr selMetadata = Selector.GetHandle ("metadata");
		static readonly IntPtr selIsMetadataLoaded = Selector.GetHandle ("isMetadataLoaded");
		static readonly IntPtr selTitle = Selector.GetHandle ("title");
		static readonly IntPtr selOutlineParser = Selector.GetHandle ("outlineParser");
		static readonly IntPtr selSetOutlineParser_ = Selector.GetHandle ("setOutlineParser:");
		static readonly IntPtr selDocumentParser = Selector.GetHandle ("documentParser");
		static readonly IntPtr selSetDocumentParser_ = Selector.GetHandle ("setDocumentParser:");
		static readonly IntPtr selAnnotationParser = Selector.GetHandle ("annotationParser");
		static readonly IntPtr selSetAnnotationParser_ = Selector.GetHandle ("setAnnotationParser:");
		static readonly IntPtr selLabelParser = Selector.GetHandle ("labelParser");
		static readonly IntPtr selSetLabelParser_ = Selector.GetHandle ("setLabelParser:");
		static readonly IntPtr selHasOpenDocumentRef = Selector.GetHandle ("hasOpenDocumentRef");
		static readonly IntPtr selInitWithFileURLDocument_ = Selector.GetHandle ("initWithFileURL:document:");
		static readonly IntPtr selInitWithDataDocument_ = Selector.GetHandle ("initWithData:document:");
		static readonly IntPtr selInitWithDataProviderDocument_ = Selector.GetHandle ("initWithDataProvider:document:");
		static readonly IntPtr selRequestDocumentRef = Selector.GetHandle ("requestDocumentRef");
		static readonly IntPtr selReleaseDocumentRef = Selector.GetHandle ("releaseDocumentRef");
		static readonly IntPtr selReleasePageRef_ = Selector.GetHandle ("releasePageRef:");
		static readonly IntPtr selUnlockWithPassword_ = Selector.GetHandle ("unlockWithPassword:");
		static readonly IntPtr selSaveChangedAnnotationsWithError_ = Selector.GetHandle ("saveChangedAnnotationsWithError:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFDocumentProvider");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFDocumentProvider () : base (NSObjectFlag.Empty)
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
		public PSPDFDocumentProvider (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFDocumentProvider (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFDocumentProvider (IntPtr handle) : base (handle) {}

		[Export ("initWithFileURL:document:")]
		[CompilerGenerated]
		public PSPDFDocumentProvider (NSUrl fileURL, PSPDFDocument document) : base (NSObjectFlag.Empty)
		{
			if (fileURL == null)
				throw new ArgumentNullException ("fileURL");
			if (document == null)
				throw new ArgumentNullException ("document");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithFileURLDocument_, fileURL.Handle, document.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithFileURLDocument_, fileURL.Handle, document.Handle);
			}
		}
		
		[Export ("initWithData:document:")]
		[CompilerGenerated]
		public PSPDFDocumentProvider (NSData data, PSPDFDocument document) : base (NSObjectFlag.Empty)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (document == null)
				throw new ArgumentNullException ("document");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithDataDocument_, data.Handle, document.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithDataDocument_, data.Handle, document.Handle);
			}
		}
		
		[Export ("initWithDataProvider:document:")]
		[CompilerGenerated]
		internal PSPDFDocumentProvider (System.IntPtr dataProvider, PSPDFDocument document) : base (NSObjectFlag.Empty)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithDataProviderDocument_, dataProvider, document.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithDataProviderDocument_, dataProvider, document.Handle);
			}
		}
		
		[Export ("requestDocumentRef")]
		[CompilerGenerated]
		internal virtual System.IntPtr RequestDocumentRef_ ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRequestDocumentRef);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRequestDocumentRef);
			}
		}
		
		[Export ("releaseDocumentRef")]
		[CompilerGenerated]
		internal virtual void ReleaseDocumentRef_ (System.IntPtr documentRef)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selReleaseDocumentRef, documentRef);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selReleaseDocumentRef, documentRef);
			}
		}
		
		[Export ("releasePageRef:")]
		[CompilerGenerated]
		internal virtual void ReleasePageRef_ (System.IntPtr pageRef)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selReleasePageRef_, pageRef);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selReleasePageRef_, pageRef);
			}
		}
		
		[Export ("unlockWithPassword:")]
		[CompilerGenerated]
		public virtual bool UnlockWithPassword (string password)
		{
			if (password == null)
				throw new ArgumentNullException ("password");
			var nspassword = NSString.CreateNative (password);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selUnlockWithPassword_, nspassword);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selUnlockWithPassword_, nspassword);
			}
			NSString.ReleaseNative (nspassword);
			
			return ret;
		}
		
		[Export ("saveChangedAnnotationsWithError:")]
		[CompilerGenerated]
		public virtual bool SaveChangedAnnotationsWithError (out NSError error)
		{
			IntPtr errorPtr = Marshal.AllocHGlobal(4);
			Marshal.WriteInt32(errorPtr, 0);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selSaveChangedAnnotationsWithError_, errorPtr);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selSaveChangedAnnotationsWithError_, errorPtr);
			}
			
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? (NSError)Runtime.GetNSObject(errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return ret;
		}
		
		object __mt_FileURL_var;
		[CompilerGenerated]
		public virtual NSUrl FileURL {
			[Export ("fileURL")]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFileURL));
				} else {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFileURL));
				}
				MarkDirty ();
				__mt_FileURL_var = ret;
				return ret;
			}
			
		}
		
		object __mt_Data_var;
		[CompilerGenerated]
		public virtual NSData Data {
			[Export ("data")]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret = (NSData) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selData));
				} else {
					ret = (NSData) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selData));
				}
				MarkDirty ();
				__mt_Data_var = ret;
				return ret;
			}
			
		}
		
		object __mt_DataProvider_var;
		[CompilerGenerated]
		public virtual NSObject DataProvider {
			[Export ("dataProvider")]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDataProvider));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDataProvider));
				}
				MarkDirty ();
				__mt_DataProvider_var = ret;
				return ret;
			}
			
		}
		
		object __mt_Document_var;
		[CompilerGenerated]
		public virtual PSPDFDocument Document {
			[Export ("document")]
			get {
				PSPDFDocument ret;
				if (IsDirectBinding) {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocument));
				} else {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocument));
				}
				MarkDirty ();
				__mt_Document_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public PSPDFDocumentProviderDelegate Delegate {
			get { return WeakDelegate as PSPDFDocumentProviderDelegate; }
			set { WeakDelegate = value; }
		}
		
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegate));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegate));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual System.UInt32 PageCount {
			[Export ("pageCount", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPageCount);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selPageCount);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Password {
			[Export ("password", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPassword));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPassword));
				}
			}
			
			[Export ("setPassword:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPassword_, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPassword_, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool AllowsCopying {
			[Export ("allowsCopying", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsCopying);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAllowsCopying);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsEncrypted {
			[Export ("isEncrypted", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsEncrypted);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsEncrypted);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string EncryptionFilter {
			[Export ("encryptionFilter", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selEncryptionFilter));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selEncryptionFilter));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsLocked {
			[Export ("isLocked", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsLocked);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsLocked);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool CanEmbedAnnotations {
			[Export ("canEmbedAnnotations", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanEmbedAnnotations);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selCanEmbedAnnotations);
				}
			}
			
			[Export ("setCanEmbedAnnotations:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetCanEmbedAnnotations_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetCanEmbedAnnotations_, value);
				}
			}
		}
		
		object __mt_Metadata_var;
		[CompilerGenerated]
		public virtual NSDictionary Metadata {
			[Export ("metadata")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMetadata));
				} else {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMetadata));
				}
				MarkDirty ();
				__mt_Metadata_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool MetadataLoaded {
			[Export ("isMetadataLoaded", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsMetadataLoaded);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsMetadataLoaded);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Title {
			[Export ("title", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTitle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTitle));
				}
			}
			
		}
		
		object __mt_OutlineParser_var;
		[CompilerGenerated]
		public virtual PSPDFOutlineParser OutlineParser {
			[Export ("outlineParser")]
			get {
				PSPDFOutlineParser ret;
				if (IsDirectBinding) {
					ret = (PSPDFOutlineParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOutlineParser));
				} else {
					ret = (PSPDFOutlineParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOutlineParser));
				}
				MarkDirty ();
				__mt_OutlineParser_var = ret;
				return ret;
			}
			
			[Export ("setOutlineParser:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetOutlineParser_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetOutlineParser_, value.Handle);
				}
				MarkDirty ();
				__mt_OutlineParser_var = value;
			}
		}
		
		object __mt_DocumentParser_var;
		[CompilerGenerated]
		public virtual PSPDFDocumentParser DocumentParser {
			[Export ("documentParser")]
			get {
				PSPDFDocumentParser ret;
				if (IsDirectBinding) {
					ret = (PSPDFDocumentParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocumentParser));
				} else {
					ret = (PSPDFDocumentParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocumentParser));
				}
				MarkDirty ();
				__mt_DocumentParser_var = ret;
				return ret;
			}
			
			[Export ("setDocumentParser:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDocumentParser_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDocumentParser_, value.Handle);
				}
				MarkDirty ();
				__mt_DocumentParser_var = value;
			}
		}
		
		object __mt_AnnotationParser_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotationParser AnnotationParser {
			[Export ("annotationParser")]
			get {
				PSPDFAnnotationParser ret;
				if (IsDirectBinding) {
					ret = (PSPDFAnnotationParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAnnotationParser));
				} else {
					ret = (PSPDFAnnotationParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAnnotationParser));
				}
				MarkDirty ();
				__mt_AnnotationParser_var = ret;
				return ret;
			}
			
			[Export ("setAnnotationParser:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAnnotationParser_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAnnotationParser_, value.Handle);
				}
				MarkDirty ();
				__mt_AnnotationParser_var = value;
			}
		}
		
		object __mt_LabelParser_var;
		[CompilerGenerated]
		public virtual PSPDFLabelParser LabelParser {
			[Export ("labelParser")]
			get {
				PSPDFLabelParser ret;
				if (IsDirectBinding) {
					ret = (PSPDFLabelParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLabelParser));
				} else {
					ret = (PSPDFLabelParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLabelParser));
				}
				MarkDirty ();
				__mt_LabelParser_var = ret;
				return ret;
			}
			
			[Export ("setLabelParser:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLabelParser_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLabelParser_, value.Handle);
				}
				MarkDirty ();
				__mt_LabelParser_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool HasOpenDocumentRef {
			[Export ("hasOpenDocumentRef", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasOpenDocumentRef);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selHasOpenDocumentRef);
				}
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_FileURL_var = null;
			__mt_Data_var = null;
			__mt_DataProvider_var = null;
			__mt_Document_var = null;
			__mt_WeakDelegate_var = null;
			__mt_Metadata_var = null;
			__mt_OutlineParser_var = null;
			__mt_DocumentParser_var = null;
			__mt_AnnotationParser_var = null;
			__mt_LabelParser_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFDocumentProvider */
}
