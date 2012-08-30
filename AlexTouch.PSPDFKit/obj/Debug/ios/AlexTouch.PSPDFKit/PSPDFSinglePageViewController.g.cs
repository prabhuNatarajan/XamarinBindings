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
	[Register("PSPDFSinglePageViewController", true)]
	public unsafe partial class PSPDFSinglePageViewController : PSPDFBaseViewController {
		static readonly IntPtr selPdfController = Selector.GetHandle ("pdfController");
		static readonly IntPtr selSetPdfController_ = Selector.GetHandle ("setPdfController:");
		static readonly IntPtr selPageView = Selector.GetHandle ("pageView");
		static readonly IntPtr selPage = Selector.GetHandle ("page");
		static readonly IntPtr selSetPage_ = Selector.GetHandle ("setPage:");
		static readonly IntPtr selUseSolidBackground = Selector.GetHandle ("useSolidBackground");
		static readonly IntPtr selSetUseSolidBackground_ = Selector.GetHandle ("setUseSolidBackground:");
		static readonly IntPtr selDelegate = Selector.GetHandle ("delegate");
		static readonly IntPtr selSetDelegate_ = Selector.GetHandle ("setDelegate:");
		static readonly IntPtr selInitWithPDFControllerPage_ = Selector.GetHandle ("initWithPDFController:page:");
		static readonly IntPtr selPrepareForReuse = Selector.GetHandle ("prepareForReuse");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSinglePageViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFSinglePageViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFSinglePageViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFSinglePageViewController (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFSinglePageViewController (IntPtr handle) : base (handle) {}

		[Export ("initWithPDFController:page:")]
		[CompilerGenerated]
		public PSPDFSinglePageViewController (PSPDFViewController pdfController, System.UInt32 page) : base (NSObjectFlag.Empty)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_UInt32 (this.Handle, selInitWithPDFControllerPage_, pdfController.Handle, page);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, selInitWithPDFControllerPage_, pdfController.Handle, page);
			}
		}
		
		[Export ("prepareForReuse")]
		[CompilerGenerated]
		public virtual void PrepareForReuse ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPrepareForReuse);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selPrepareForReuse);
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
		
		object __mt_PageView_var;
		[CompilerGenerated]
		public virtual PSPDFPageView PageView {
			[Export ("pageView")]
			get {
				PSPDFPageView ret;
				if (IsDirectBinding) {
					ret = (PSPDFPageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPageView));
				} else {
					ret = (PSPDFPageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPageView));
				}
				MarkDirty ();
				__mt_PageView_var = ret;
				return ret;
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
		public virtual bool UseSolidBackground {
			[Export ("useSolidBackground", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUseSolidBackground);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selUseSolidBackground);
				}
			}
			
			[Export ("setUseSolidBackground:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUseSolidBackground_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetUseSolidBackground_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public PSPDFSinglePageViewControllerDelegate Delegate {
			get { return WeakDelegate as PSPDFSinglePageViewControllerDelegate; }
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
		
		protected override void Dispose (bool disposing)
		{
			__mt_PdfController_var = null;
			__mt_PageView_var = null;
			__mt_WeakDelegate_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFSinglePageViewController */
}
