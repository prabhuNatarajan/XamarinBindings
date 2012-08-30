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
	[Register("PSPDFTabbedViewController", true)]
	public unsafe partial class PSPDFTabbedViewController : PSPDFBaseViewController {
		static readonly IntPtr selVisibleDocument = Selector.GetHandle ("visibleDocument");
		static readonly IntPtr selSetVisibleDocument_ = Selector.GetHandle ("setVisibleDocument:");
		static readonly IntPtr selDocuments = Selector.GetHandle ("documents");
		static readonly IntPtr selSetDocuments_ = Selector.GetHandle ("setDocuments:");
		static readonly IntPtr selDelegate = Selector.GetHandle ("delegate");
		static readonly IntPtr selSetDelegate_ = Selector.GetHandle ("setDelegate:");
		static readonly IntPtr selEnableAutomaticStatePersistance = Selector.GetHandle ("enableAutomaticStatePersistance");
		static readonly IntPtr selSetEnableAutomaticStatePersistance_ = Selector.GetHandle ("setEnableAutomaticStatePersistance:");
		static readonly IntPtr selStatePersistanceKey = Selector.GetHandle ("statePersistanceKey");
		static readonly IntPtr selSetStatePersistanceKey_ = Selector.GetHandle ("setStatePersistanceKey:");
		static readonly IntPtr selMinTabWidth = Selector.GetHandle ("minTabWidth");
		static readonly IntPtr selSetMinTabWidth_ = Selector.GetHandle ("setMinTabWidth:");
		static readonly IntPtr selPdfViewController = Selector.GetHandle ("pdfViewController");
		static readonly IntPtr selTabBar = Selector.GetHandle ("tabBar");
		static readonly IntPtr selInitWithPDFViewController_ = Selector.GetHandle ("initWithPDFViewController:");
		static readonly IntPtr selAddDocumentsAtIndexAnimated_ = Selector.GetHandle ("addDocuments:atIndex:animated:");
		static readonly IntPtr selRemoveDocumentsAnimated_ = Selector.GetHandle ("removeDocuments:animated:");
		static readonly IntPtr selPersistState = Selector.GetHandle ("persistState");
		static readonly IntPtr selRestoreState = Selector.GetHandle ("restoreState");
		static readonly IntPtr selRestoreStateAndMergeWithDocuments_ = Selector.GetHandle ("restoreStateAndMergeWithDocuments:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFTabbedViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFTabbedViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFTabbedViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFTabbedViewController (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFTabbedViewController (IntPtr handle) : base (handle) {}

		[Export ("initWithPDFViewController:")]
		[CompilerGenerated]
		public PSPDFTabbedViewController (PSPDFViewController pdfViewController) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithPDFViewController_, pdfViewController == null ? IntPtr.Zero : pdfViewController.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithPDFViewController_, pdfViewController == null ? IntPtr.Zero : pdfViewController.Handle);
			}
		}
		
		[Export ("addDocuments:atIndex:animated:")]
		[CompilerGenerated]
		public virtual void AddDocuments (PSPDFDocument[] documents, System.UInt32 index, bool animated)
		{
			if (documents == null)
				throw new ArgumentNullException ("documents");
			var nsa_documents = NSArray.FromNSObjects (documents);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UInt32_bool (this.Handle, selAddDocumentsAtIndexAnimated_, nsa_documents.Handle, index, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UInt32_bool (this.SuperHandle, selAddDocumentsAtIndexAnimated_, nsa_documents.Handle, index, animated);
			}
			nsa_documents.Dispose ();
			
		}
		
		[Export ("removeDocuments:animated:")]
		[CompilerGenerated]
		public virtual void RemoveDocuments (PSPDFDocument[] documents, bool animated)
		{
			if (documents == null)
				throw new ArgumentNullException ("documents");
			var nsa_documents = NSArray.FromNSObjects (documents);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selRemoveDocumentsAnimated_, nsa_documents.Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selRemoveDocumentsAnimated_, nsa_documents.Handle, animated);
			}
			nsa_documents.Dispose ();
			
		}
		
		[Export ("persistState")]
		[CompilerGenerated]
		public virtual void PersistState ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPersistState);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selPersistState);
			}
		}
		
		[Export ("restoreState")]
		[CompilerGenerated]
		public virtual bool RestoreState ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selRestoreState);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selRestoreState);
			}
		}
		
		[Export ("restoreStateAndMergeWithDocuments:")]
		[CompilerGenerated]
		public virtual bool RestoreStateAndMergeWithDocuments (PSPDFDocument[] documents)
		{
			if (documents == null)
				throw new ArgumentNullException ("documents");
			var nsa_documents = NSArray.FromNSObjects (documents);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selRestoreStateAndMergeWithDocuments_, nsa_documents.Handle);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selRestoreStateAndMergeWithDocuments_, nsa_documents.Handle);
			}
			nsa_documents.Dispose ();
			
			return ret;
		}
		
		object __mt_VisibleDocument_var;
		[CompilerGenerated]
		public virtual PSPDFDocument VisibleDocument {
			[Export ("visibleDocument")]
			get {
				PSPDFDocument ret;
				if (IsDirectBinding) {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selVisibleDocument));
				} else {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selVisibleDocument));
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
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetVisibleDocument_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetVisibleDocument_, value.Handle);
				}
				MarkDirty ();
				__mt_VisibleDocument_var = value;
			}
		}
		
		object __mt_Documents_var;
		[CompilerGenerated]
		public virtual PSPDFDocument[] Documents {
			[Export ("documents")]
			get {
				PSPDFDocument[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFDocument>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocuments));
				} else {
					ret = NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFDocument>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocuments));
				}
				MarkDirty ();
				__mt_Documents_var = ret;
				return ret;
			}
			
			[Export ("setDocuments:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDocuments_, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDocuments_, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				MarkDirty ();
				__mt_Documents_var = value;
			}
		}
		
		[CompilerGenerated]
		public PSPDFTabbedViewControllerDelegate Delegate {
			get { return WeakDelegate as PSPDFTabbedViewControllerDelegate; }
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
		public virtual bool EnableAutomaticStatePersistance {
			[Export ("enableAutomaticStatePersistance", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selEnableAutomaticStatePersistance);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selEnableAutomaticStatePersistance);
				}
			}
			
			[Export ("setEnableAutomaticStatePersistance:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetEnableAutomaticStatePersistance_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetEnableAutomaticStatePersistance_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string StatePersistanceKey {
			[Export ("statePersistanceKey", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStatePersistanceKey));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selStatePersistanceKey));
				}
			}
			
			[Export ("setStatePersistanceKey:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetStatePersistanceKey_, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetStatePersistanceKey_, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual float MinTabWidth {
			[Export ("minTabWidth", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMinTabWidth);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selMinTabWidth);
				}
			}
			
			[Export ("setMinTabWidth:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMinTabWidth_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetMinTabWidth_, value);
				}
			}
		}
		
		object __mt_PdfViewController_var;
		[CompilerGenerated]
		public virtual PSPDFViewController PdfViewController {
			[Export ("pdfViewController")]
			get {
				PSPDFViewController ret;
				if (IsDirectBinding) {
					ret = (PSPDFViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPdfViewController));
				} else {
					ret = (PSPDFViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPdfViewController));
				}
				MarkDirty ();
				__mt_PdfViewController_var = ret;
				return ret;
			}
			
		}
		
		object __mt_TabBar_var;
		[CompilerGenerated]
		public virtual PSPDFTabBarView TabBar {
			[Export ("tabBar")]
			get {
				PSPDFTabBarView ret;
				if (IsDirectBinding) {
					ret = (PSPDFTabBarView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTabBar));
				} else {
					ret = (PSPDFTabBarView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTabBar));
				}
				MarkDirty ();
				__mt_TabBar_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_VisibleDocument_var = null;
			__mt_Documents_var = null;
			__mt_WeakDelegate_var = null;
			__mt_PdfViewController_var = null;
			__mt_TabBar_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFTabbedViewController */
}
