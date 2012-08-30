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
	[Register("PSPDFCacheQueuedDocument", true)]
	public unsafe partial class PSPDFCacheQueuedDocument : NSObject {
		static readonly IntPtr selDocument = Selector.GetHandle ("document");
		static readonly IntPtr selSetDocument_ = Selector.GetHandle ("setDocument:");
		static readonly IntPtr selPage = Selector.GetHandle ("page");
		static readonly IntPtr selSetPage_ = Selector.GetHandle ("setPage:");
		static readonly IntPtr selSize = Selector.GetHandle ("size");
		static readonly IntPtr selSetSize_ = Selector.GetHandle ("setSize:");
		static readonly IntPtr selPagesCached = Selector.GetHandle ("pagesCached");
		static readonly IntPtr selSetPagesCached_ = Selector.GetHandle ("setPagesCached:");
		static readonly IntPtr selIsCaching = Selector.GetHandle ("isCaching");
		static readonly IntPtr selSetCaching_ = Selector.GetHandle ("setCaching:");
		static readonly IntPtr selQueuedDocumentWithDocumentPageSize_ = Selector.GetHandle ("queuedDocumentWithDocument:page:size:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFCacheQueuedDocument");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFCacheQueuedDocument () : base (NSObjectFlag.Empty)
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
		public PSPDFCacheQueuedDocument (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFCacheQueuedDocument (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFCacheQueuedDocument (IntPtr handle) : base (handle) {}

		[Export ("queuedDocumentWithDocument:page:size:")]
		[CompilerGenerated]
		public static PSPDFCacheQueuedDocument QueuedDocumentWithDocument (PSPDFDocument document, System.UInt32 page, PSPDFSize size)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			return (PSPDFCacheQueuedDocument) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt32_int (class_ptr, selQueuedDocumentWithDocumentPageSize_, document.Handle, page, (int)size));
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
			
			[Export ("setDocument:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDocument_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDocument_, value.Handle);
				}
				MarkDirty ();
				__mt_Document_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual System.UInt32 Page {
			[Export ("page", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPage);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selPage);
				}
			}
			
			[Export ("setPage:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetPage_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetPage_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFSize Size {
			[Export ("size", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFSize) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selSize);
				} else {
					return (PSPDFSize) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selSize);
				}
			}
			
			[Export ("setSize:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetSize_, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetSize_, (int)value);
				}
			}
		}
		
		object __mt_PagesCached_var;
		[CompilerGenerated]
		public virtual NSMutableSet PagesCached {
			[Export ("pagesCached")]
			get {
				NSMutableSet ret;
				if (IsDirectBinding) {
					ret = (NSMutableSet) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPagesCached));
				} else {
					ret = (NSMutableSet) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPagesCached));
				}
				MarkDirty ();
				__mt_PagesCached_var = ret;
				return ret;
			}
			
			[Export ("setPagesCached:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPagesCached_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPagesCached_, value.Handle);
				}
				MarkDirty ();
				__mt_PagesCached_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool Caching {
			[Export ("isCaching", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsCaching);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsCaching);
				}
			}
			
			[Export ("setCaching:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetCaching_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetCaching_, value);
				}
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_Document_var = null;
			__mt_PagesCached_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFCacheQueuedDocument */
}
