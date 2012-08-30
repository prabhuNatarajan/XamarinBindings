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
	[Register("PSPDFScrobbleBar", true)]
	public unsafe partial class PSPDFScrobbleBar : MonoTouch.UIKit.UIView {
		static readonly IntPtr selPdfController = Selector.GetHandle ("pdfController");
		static readonly IntPtr selSetPdfController_ = Selector.GetHandle ("setPdfController:");
		static readonly IntPtr selPage = Selector.GetHandle ("page");
		static readonly IntPtr selSetPage_ = Selector.GetHandle ("setPage:");
		static readonly IntPtr selToolbar = Selector.GetHandle ("toolbar");
		static readonly IntPtr selSetToolbar_ = Selector.GetHandle ("setToolbar:");
		static readonly IntPtr selUpdateToolbar = Selector.GetHandle ("updateToolbar");
		static readonly IntPtr selUpdatePageMarker = Selector.GetHandle ("updatePageMarker");
		static readonly IntPtr selDidCachePageForDocumentPageImageSize_ = Selector.GetHandle ("didCachePageForDocument:page:image:size:");
		static readonly IntPtr selDidFinishCachingDocument_ = Selector.GetHandle ("didFinishCachingDocument:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFScrobbleBar");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFScrobbleBar () : base (NSObjectFlag.Empty)
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
		public PSPDFScrobbleBar (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFScrobbleBar (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFScrobbleBar (IntPtr handle) : base (handle) {}

		[Export ("updateToolbar")]
		[CompilerGenerated]
		public virtual void UpdateToolbar ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateToolbar);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selUpdateToolbar);
			}
		}
		
		[Export ("updatePageMarker")]
		[CompilerGenerated]
		public virtual void UpdatePageMarker ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdatePageMarker);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selUpdatePageMarker);
			}
		}
		
		[Export ("didCachePageForDocument:page:image:size:")]
		[CompilerGenerated]
		public virtual void DidCachePageForDocument (PSPDFDocument document, System.UInt32 page, MonoTouch.UIKit.UIImage cachedImage, PSPDFSize size)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (cachedImage == null)
				throw new ArgumentNullException ("cachedImage");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32_IntPtr_int (this.Handle, selDidCachePageForDocumentPageImageSize_, document.Handle, page, cachedImage.Handle, (int)size);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_UInt32_IntPtr_int (this.SuperHandle, selDidCachePageForDocumentPageImageSize_, document.Handle, page, cachedImage.Handle, (int)size);
			}
		}
		
		[Export ("didFinishCachingDocument:")]
		[CompilerGenerated]
		public virtual void DidFinishCachingDocument (PSPDFDocument document)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selDidFinishCachingDocument_, document.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selDidFinishCachingDocument_, document.Handle);
			}
		}
		
		object __mt_PdfController_var;
		[CompilerGenerated]
		public virtual PSPDFViewController PdfController {
			[Export ("pdfController")]
			get {
				PSPDFViewController ret;
				if (IsDirectBinding) {
					ret = (PSPDFViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPdfController));
				} else {
					ret = (PSPDFViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPdfController));
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
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPdfController_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPdfController_, value.Handle);
				}
				MarkDirty ();
				__mt_PdfController_var = value;
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
		
		object __mt_Toolbar_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIToolbar Toolbar {
			[Export ("toolbar")]
			get {
				MonoTouch.UIKit.UIToolbar ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIToolbar) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selToolbar));
				} else {
					ret = (MonoTouch.UIKit.UIToolbar) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selToolbar));
				}
				MarkDirty ();
				__mt_Toolbar_var = ret;
				return ret;
			}
			
			[Export ("setToolbar:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetToolbar_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetToolbar_, value.Handle);
				}
				MarkDirty ();
				__mt_Toolbar_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_PdfController_var = null;
			__mt_Toolbar_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFScrobbleBar */
}
