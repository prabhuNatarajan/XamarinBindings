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
	[Register("PSPDFTransitionProtocol", true)]
	public unsafe partial class PSPDFTransitionProtocol : NSObject {
		static readonly IntPtr selPdfController = Selector.GetHandle ("pdfController");
		static readonly IntPtr selSetPdfController_ = Selector.GetHandle ("setPdfController:");
		static readonly IntPtr selScrollView = Selector.GetHandle ("scrollView");
		static readonly IntPtr selSetScrollView_ = Selector.GetHandle ("setScrollView:");
		static readonly IntPtr selSetPageAnimated_ = Selector.GetHandle ("setPage:animated:");
		static readonly IntPtr selVisiblePageNumbers = Selector.GetHandle ("visiblePageNumbers");
		static readonly IntPtr selPageViewForPage_ = Selector.GetHandle ("pageViewForPage:");
		static readonly IntPtr selVisiblePageViews = Selector.GetHandle ("visiblePageViews");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFTransitionProtocol");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFTransitionProtocol () : base (NSObjectFlag.Empty)
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
		public PSPDFTransitionProtocol (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFTransitionProtocol (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFTransitionProtocol (IntPtr handle) : base (handle) {}

		[Export ("setPage:animated:")]
		[CompilerGenerated]
		public virtual void SetPage (System.UInt32 page, bool animated)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_UInt32_bool (this.Handle, selSetPageAnimated_, page, animated);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32_bool (this.SuperHandle, selSetPageAnimated_, page, animated);
			}
		}
		
		[Export ("visiblePageNumbers")]
		[CompilerGenerated]
		public virtual NSNumber[] VisiblePageNumbers ()
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<MonoTouch.Foundation.NSNumber>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selVisiblePageNumbers));
			} else {
				return NSArray.ArrayFromHandle<MonoTouch.Foundation.NSNumber>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selVisiblePageNumbers));
			}
		}
		
		[Export ("pageViewForPage:")]
		[CompilerGenerated]
		public virtual PSPDFPageView PageViewForPage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				return (PSPDFPageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selPageViewForPage_, page));
			} else {
				return (PSPDFPageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selPageViewForPage_, page));
			}
		}
		
		[Export ("visiblePageViews")]
		[CompilerGenerated]
		public virtual PSPDFPageView[] VisiblePageViews ()
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFPageView>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selVisiblePageViews));
			} else {
				return NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFPageView>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selVisiblePageViews));
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
		
		object __mt_ScrollView_var;
		[CompilerGenerated]
		public virtual PSPDFPagedScrollView ScrollView {
			[Export ("scrollView")]
			get {
				PSPDFPagedScrollView ret;
				if (IsDirectBinding) {
					ret = (PSPDFPagedScrollView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selScrollView));
				} else {
					ret = (PSPDFPagedScrollView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selScrollView));
				}
				MarkDirty ();
				__mt_ScrollView_var = ret;
				return ret;
			}
			
			[Export ("setScrollView:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetScrollView_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetScrollView_, value.Handle);
				}
				MarkDirty ();
				__mt_ScrollView_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_PdfController_var = null;
			__mt_ScrollView_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFTransitionProtocol */
}
