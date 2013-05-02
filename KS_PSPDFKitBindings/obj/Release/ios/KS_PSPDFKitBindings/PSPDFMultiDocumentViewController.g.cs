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
	[Register("PSPDFMultiDocumentViewController", true)]
	public unsafe partial class PSPDFMultiDocumentViewController : PSPDFBaseViewController {
		[CompilerGenerated]
		const string selVisibleDocument = "visibleDocument";
		static readonly IntPtr selVisibleDocumentHandle = Selector.GetHandle ("visibleDocument");
		[CompilerGenerated]
		const string selSetVisibleDocument_ = "setVisibleDocument:";
		static readonly IntPtr selSetVisibleDocument_Handle = Selector.GetHandle ("setVisibleDocument:");
		[CompilerGenerated]
		const string selDocuments = "documents";
		static readonly IntPtr selDocumentsHandle = Selector.GetHandle ("documents");
		[CompilerGenerated]
		const string selSetDocuments_ = "setDocuments:";
		static readonly IntPtr selSetDocuments_Handle = Selector.GetHandle ("setDocuments:");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selEnableAutomaticStatePersistance = "enableAutomaticStatePersistance";
		static readonly IntPtr selEnableAutomaticStatePersistanceHandle = Selector.GetHandle ("enableAutomaticStatePersistance");
		[CompilerGenerated]
		const string selSetEnableAutomaticStatePersistance_ = "setEnableAutomaticStatePersistance:";
		static readonly IntPtr selSetEnableAutomaticStatePersistance_Handle = Selector.GetHandle ("setEnableAutomaticStatePersistance:");
		[CompilerGenerated]
		const string selStatePersistanceKey = "statePersistanceKey";
		static readonly IntPtr selStatePersistanceKeyHandle = Selector.GetHandle ("statePersistanceKey");
		[CompilerGenerated]
		const string selSetStatePersistanceKey_ = "setStatePersistanceKey:";
		static readonly IntPtr selSetStatePersistanceKey_Handle = Selector.GetHandle ("setStatePersistanceKey:");
		[CompilerGenerated]
		const string selPdfController = "pdfController";
		static readonly IntPtr selPdfControllerHandle = Selector.GetHandle ("pdfController");
		[CompilerGenerated]
		const string selChangeDocumentOnTapPageEndMargin = "changeDocumentOnTapPageEndMargin";
		static readonly IntPtr selChangeDocumentOnTapPageEndMarginHandle = Selector.GetHandle ("changeDocumentOnTapPageEndMargin");
		[CompilerGenerated]
		const string selSetChangeDocumentOnTapPageEndMargin_ = "setChangeDocumentOnTapPageEndMargin:";
		static readonly IntPtr selSetChangeDocumentOnTapPageEndMargin_Handle = Selector.GetHandle ("setChangeDocumentOnTapPageEndMargin:");
		[CompilerGenerated]
		const string selShowTitle = "showTitle";
		static readonly IntPtr selShowTitleHandle = Selector.GetHandle ("showTitle");
		[CompilerGenerated]
		const string selSetShowTitle_ = "setShowTitle:";
		static readonly IntPtr selSetShowTitle_Handle = Selector.GetHandle ("setShowTitle:");
		[CompilerGenerated]
		const string selInitWithPDFViewController_ = "initWithPDFViewController:";
		static readonly IntPtr selInitWithPDFViewController_Handle = Selector.GetHandle ("initWithPDFViewController:");
		[CompilerGenerated]
		const string selAddDocumentsAtIndex_ = "addDocuments:atIndex:";
		static readonly IntPtr selAddDocumentsAtIndex_Handle = Selector.GetHandle ("addDocuments:atIndex:");
		[CompilerGenerated]
		const string selRemoveDocuments_ = "removeDocuments:";
		static readonly IntPtr selRemoveDocuments_Handle = Selector.GetHandle ("removeDocuments:");
		[CompilerGenerated]
		const string selPersistState = "persistState";
		static readonly IntPtr selPersistStateHandle = Selector.GetHandle ("persistState");
		[CompilerGenerated]
		const string selRestoreState = "restoreState";
		static readonly IntPtr selRestoreStateHandle = Selector.GetHandle ("restoreState");
		[CompilerGenerated]
		const string selRestoreStateAndMergeWithDocuments = "restoreStateAndMergeWithDocuments";
		static readonly IntPtr selRestoreStateAndMergeWithDocumentsHandle = Selector.GetHandle ("restoreStateAndMergeWithDocuments");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFMultiDocumentViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFMultiDocumentViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFMultiDocumentViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFMultiDocumentViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFMultiDocumentViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithPDFViewController:")]
		[CompilerGenerated]
		public PSPDFMultiDocumentViewController (PSPDFViewController pdfController)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithPDFViewController_Handle, pdfController == null ? IntPtr.Zero : pdfController.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithPDFViewController_Handle, pdfController == null ? IntPtr.Zero : pdfController.Handle);
			}
		}
		
		[Export ("addDocuments:atIndex:")]
		[CompilerGenerated]
		public virtual void AddDocuments (PSPDFDocument[] documents, global::System.UInt32 index)
		{
			if (documents == null)
				throw new ArgumentNullException ("documents");
			var nsa_documents = NSArray.FromNSObjects (documents);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UInt32 (this.Handle, selAddDocumentsAtIndex_Handle, nsa_documents.Handle, index);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, selAddDocumentsAtIndex_Handle, nsa_documents.Handle, index);
			}
			nsa_documents.Dispose ();
			
		}
		
		[Export ("removeDocuments:")]
		[CompilerGenerated]
		public virtual void RemoveDocuments (PSPDFDocument[] documents)
		{
			if (documents == null)
				throw new ArgumentNullException ("documents");
			var nsa_documents = NSArray.FromNSObjects (documents);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRemoveDocuments_Handle, nsa_documents.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selRemoveDocuments_Handle, nsa_documents.Handle);
			}
			nsa_documents.Dispose ();
			
		}
		
		[Export ("persistState")]
		[CompilerGenerated]
		public virtual void PersistState ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPersistStateHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selPersistStateHandle);
			}
		}
		
		[Export ("restoreState")]
		[CompilerGenerated]
		public virtual bool RestoreState ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selRestoreStateHandle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selRestoreStateHandle);
			}
		}
		
		[Export ("restoreStateAndMergeWithDocuments")]
		[CompilerGenerated]
		public virtual bool RestoreStateAndMergeWithDocuments (PSPDFDocument[] documents)
		{
			if (documents == null)
				throw new ArgumentNullException ("documents");
			var nsa_documents = NSArray.FromNSObjects (documents);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selRestoreStateAndMergeWithDocumentsHandle, nsa_documents.Handle);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selRestoreStateAndMergeWithDocumentsHandle, nsa_documents.Handle);
			}
			nsa_documents.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		object __mt_VisibleDocument_var;
		[CompilerGenerated]
		public virtual PSPDFDocument VisibleDocument {
			[Export ("visibleDocument")]
			get {
				PSPDFDocument ret;
				if (IsDirectBinding) {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selVisibleDocumentHandle));
				} else {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selVisibleDocumentHandle));
				}
				MarkDirty ();
				__mt_VisibleDocument_var = ret;
				return ret;
			}
			
			[Export ("setVisibleDocument:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetVisibleDocument_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetVisibleDocument_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_VisibleDocument_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Documents_var;
		[CompilerGenerated]
		public virtual PSPDFDocument[] Documents {
			[Export ("documents", ArgumentSemantic.Copy)]
			get {
				PSPDFDocument[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFDocument>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocumentsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFDocument>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocumentsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Documents_var = ret;
				return ret;
			}
			
			[Export ("setDocuments:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDocuments_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDocuments_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_Documents_var = value;
			}
		}
		
		[CompilerGenerated]
		public PSPDFMultiDocumentViewControllerDelegate Delegate {
			get {
				return WeakDelegate as PSPDFMultiDocumentViewControllerDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool EnableAutomaticStatePersistance {
			[Export ("enableAutomaticStatePersistance", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selEnableAutomaticStatePersistanceHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selEnableAutomaticStatePersistanceHandle);
				}
			}
			
			[Export ("setEnableAutomaticStatePersistance:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetEnableAutomaticStatePersistance_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetEnableAutomaticStatePersistance_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string StatePersistanceKey {
			[Export ("statePersistanceKey", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStatePersistanceKeyHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selStatePersistanceKeyHandle));
				}
			}
			
			[Export ("setStatePersistanceKey:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetStatePersistanceKey_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetStatePersistanceKey_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
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
			
		}
		
		[CompilerGenerated]
		public virtual string ChangeDocumentOnTapPageEndMargin {
			[Export ("changeDocumentOnTapPageEndMargin", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selChangeDocumentOnTapPageEndMarginHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selChangeDocumentOnTapPageEndMarginHandle));
				}
			}
			
			[Export ("setChangeDocumentOnTapPageEndMargin:", ArgumentSemantic.Assign)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetChangeDocumentOnTapPageEndMargin_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetChangeDocumentOnTapPageEndMargin_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowTitle {
			[Export ("showTitle", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowTitleHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShowTitleHandle);
				}
			}
			
			[Export ("setShowTitle:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowTitle_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShowTitle_Handle, value);
				}
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_VisibleDocument_var = null;
				__mt_Documents_var = null;
				__mt_WeakDelegate_var = null;
				__mt_PdfController_var = null;
			}
		}
	} /* class PSPDFMultiDocumentViewController */
}
