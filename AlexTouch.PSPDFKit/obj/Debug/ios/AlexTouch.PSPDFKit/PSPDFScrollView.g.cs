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
	[Register("PSPDFScrollView", true)]
	public unsafe partial class PSPDFScrollView : MonoTouch.UIKit.UIScrollView {
		static readonly IntPtr selPage = Selector.GetHandle ("page");
		static readonly IntPtr selSetPage_ = Selector.GetHandle ("setPage:");
		static readonly IntPtr selDocument = Selector.GetHandle ("document");
		static readonly IntPtr selPdfController = Selector.GetHandle ("pdfController");
		static readonly IntPtr selSetPdfController_ = Selector.GetHandle ("setPdfController:");
		static readonly IntPtr selLeftPage = Selector.GetHandle ("leftPage");
		static readonly IntPtr selRightPage = Selector.GetHandle ("rightPage");
		static readonly IntPtr selShadowStyle = Selector.GetHandle ("shadowStyle");
		static readonly IntPtr selSetShadowStyle_ = Selector.GetHandle ("setShadowStyle:");
		static readonly IntPtr selIsZoomingEnabled = Selector.GetHandle ("isZoomingEnabled");
		static readonly IntPtr selSetZoomingEnabled_ = Selector.GetHandle ("setZoomingEnabled:");
		static readonly IntPtr selIsDoublePageMode = Selector.GetHandle ("isDoublePageMode");
		static readonly IntPtr selSetDoublePageMode_ = Selector.GetHandle ("setDoublePageMode:");
		static readonly IntPtr selIsDoublePageModeOnFirstPage = Selector.GetHandle ("isDoublePageModeOnFirstPage");
		static readonly IntPtr selSetDoublePageModeOnFirstPage_ = Selector.GetHandle ("setDoublePageModeOnFirstPage:");
		static readonly IntPtr selIsZoomingSmallDocumentsEnabled = Selector.GetHandle ("isZoomingSmallDocumentsEnabled");
		static readonly IntPtr selSetZoomingSmallDocumentsEnabled_ = Selector.GetHandle ("setZoomingSmallDocumentsEnabled:");
		static readonly IntPtr selIsFitToWidthEnabled = Selector.GetHandle ("isFitToWidthEnabled");
		static readonly IntPtr selSetFitToWidthEnabled_ = Selector.GetHandle ("setFitToWidthEnabled:");
		static readonly IntPtr selIsShadowEnabled = Selector.GetHandle ("isShadowEnabled");
		static readonly IntPtr selSetShadowEnabled_ = Selector.GetHandle ("setShadowEnabled:");
		static readonly IntPtr selIsScrollOnTapPageEndEnabled = Selector.GetHandle ("isScrollOnTapPageEndEnabled");
		static readonly IntPtr selSetScrollOnTapPageEndEnabled_ = Selector.GetHandle ("setScrollOnTapPageEndEnabled:");
		static readonly IntPtr selSingleTapGesture = Selector.GetHandle ("singleTapGesture");
		static readonly IntPtr selDoubleTapGesture = Selector.GetHandle ("doubleTapGesture");
		static readonly IntPtr selLongPressGesture = Selector.GetHandle ("longPressGesture");
		static readonly IntPtr selCompoundView = Selector.GetHandle ("compoundView");
		static readonly IntPtr selIsRotationActive = Selector.GetHandle ("isRotationActive");
		static readonly IntPtr selSetRotationActive_ = Selector.GetHandle ("setRotationActive:");
		static readonly IntPtr selDisplayDocumentWithPage_ = Selector.GetHandle ("displayDocument:withPage:");
		static readonly IntPtr selReleaseDocument = Selector.GetHandle ("releaseDocument");
		static readonly IntPtr selSingleTapped_ = Selector.GetHandle ("singleTapped:");
		static readonly IntPtr selDoubleTapped_ = Selector.GetHandle ("doubleTapped:");
		static readonly IntPtr selLongPress_ = Selector.GetHandle ("longPress:");
		static readonly IntPtr selPathShadowForView_ = Selector.GetHandle ("pathShadowForView:");
		static readonly IntPtr selDidReceiveMemoryWarning = Selector.GetHandle ("didReceiveMemoryWarning");
		static readonly IntPtr selSwitchPages = Selector.GetHandle ("switchPages");
		static readonly IntPtr selPageViewForPoint_ = Selector.GetHandle ("pageViewForPoint:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFScrollView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFScrollView () : base (NSObjectFlag.Empty)
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
		public PSPDFScrollView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFScrollView (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFScrollView (IntPtr handle) : base (handle) {}

		[Export ("displayDocument:withPage:")]
		[CompilerGenerated]
		public virtual void DisplayDocumentWithPage (PSPDFDocument document, System.UInt32 page)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UInt32 (this.Handle, selDisplayDocumentWithPage_, document.Handle, page);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, selDisplayDocumentWithPage_, document.Handle, page);
			}
		}
		
		[Export ("releaseDocument")]
		[CompilerGenerated]
		public virtual void ReleaseDocument ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selReleaseDocument);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selReleaseDocument);
			}
		}
		
		[CompilerGenerated]
		public void SingleTapped (MonoTouch.UIKit.UITapGestureRecognizer recognizer)
		{
			if (recognizer == null)
				throw new ArgumentNullException ("recognizer");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSingleTapped_, recognizer.Handle);
		}
		
		[CompilerGenerated]
		public void DoubleTapped (MonoTouch.UIKit.UITapGestureRecognizer recognizer)
		{
			if (recognizer == null)
				throw new ArgumentNullException ("recognizer");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selDoubleTapped_, recognizer.Handle);
		}
		
		[CompilerGenerated]
		public void LongPress (MonoTouch.UIKit.UILongPressGestureRecognizer recognizer)
		{
			if (recognizer == null)
				throw new ArgumentNullException ("recognizer");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selLongPress_, recognizer.Handle);
		}
		
		[CompilerGenerated]
		public NSObject PathShadowForView (MonoTouch.UIKit.UIView imgView)
		{
			if (imgView == null)
				throw new ArgumentNullException ("imgView");
			return (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selPathShadowForView_, imgView.Handle));
		}
		
		[CompilerGenerated]
		public void DidReceiveMemoryWarning ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDidReceiveMemoryWarning);
		}
		
		[CompilerGenerated]
		public void SwitchPages ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSwitchPages);
		}
		
		[CompilerGenerated]
		public PSPDFPageView SwitchPages (System.Drawing.PointF point)
		{
			return (PSPDFPageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_PointF (this.Handle, selPageViewForPoint_, point));
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
		
		object __mt_LeftPage_var;
		[CompilerGenerated]
		public virtual PSPDFPageView LeftPage {
			[Export ("leftPage")]
			get {
				PSPDFPageView ret;
				if (IsDirectBinding) {
					ret = (PSPDFPageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLeftPage));
				} else {
					ret = (PSPDFPageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLeftPage));
				}
				MarkDirty ();
				__mt_LeftPage_var = ret;
				return ret;
			}
			
		}
		
		object __mt_RightPage_var;
		[CompilerGenerated]
		public virtual PSPDFPageView RightPage {
			[Export ("rightPage")]
			get {
				PSPDFPageView ret;
				if (IsDirectBinding) {
					ret = (PSPDFPageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRightPage));
				} else {
					ret = (PSPDFPageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRightPage));
				}
				MarkDirty ();
				__mt_RightPage_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFShadowStyle ShadowStyle {
			[Export ("shadowStyle", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFShadowStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selShadowStyle);
				} else {
					return (PSPDFShadowStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selShadowStyle);
				}
			}
			
			[Export ("setShadowStyle:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetShadowStyle_, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetShadowStyle_, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ZoomingEnabled {
			[Export ("isZoomingEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsZoomingEnabled);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsZoomingEnabled);
				}
			}
			
			[Export ("setZoomingEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetZoomingEnabled_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetZoomingEnabled_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool DoublePageMode {
			[Export ("isDoublePageMode", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDoublePageMode);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsDoublePageMode);
				}
			}
			
			[Export ("setDoublePageMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDoublePageMode_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetDoublePageMode_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool DoublePageModeOnFirstPage {
			[Export ("isDoublePageModeOnFirstPage", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDoublePageModeOnFirstPage);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsDoublePageModeOnFirstPage);
				}
			}
			
			[Export ("setDoublePageModeOnFirstPage:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDoublePageModeOnFirstPage_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetDoublePageModeOnFirstPage_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ZoomingSmallDocumentsEnabled {
			[Export ("isZoomingSmallDocumentsEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsZoomingSmallDocumentsEnabled);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsZoomingSmallDocumentsEnabled);
				}
			}
			
			[Export ("setZoomingSmallDocumentsEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetZoomingSmallDocumentsEnabled_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetZoomingSmallDocumentsEnabled_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool FitToWidthEnabled {
			[Export ("isFitToWidthEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFitToWidthEnabled);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsFitToWidthEnabled);
				}
			}
			
			[Export ("setFitToWidthEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetFitToWidthEnabled_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetFitToWidthEnabled_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShadowEnabled {
			[Export ("isShadowEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsShadowEnabled);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsShadowEnabled);
				}
			}
			
			[Export ("setShadowEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShadowEnabled_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShadowEnabled_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ScrollOnTapPageEndEnabled {
			[Export ("isScrollOnTapPageEndEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsScrollOnTapPageEndEnabled);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsScrollOnTapPageEndEnabled);
				}
			}
			
			[Export ("setScrollOnTapPageEndEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetScrollOnTapPageEndEnabled_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetScrollOnTapPageEndEnabled_, value);
				}
			}
		}
		
		object __mt_SingleTapGesture_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UITapGestureRecognizer SingleTapGesture {
			[Export ("singleTapGesture")]
			get {
				MonoTouch.UIKit.UITapGestureRecognizer ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UITapGestureRecognizer) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSingleTapGesture));
				} else {
					ret = (MonoTouch.UIKit.UITapGestureRecognizer) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSingleTapGesture));
				}
				MarkDirty ();
				__mt_SingleTapGesture_var = ret;
				return ret;
			}
			
		}
		
		object __mt_DoubleTapGesture_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UITapGestureRecognizer DoubleTapGesture {
			[Export ("doubleTapGesture")]
			get {
				MonoTouch.UIKit.UITapGestureRecognizer ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UITapGestureRecognizer) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDoubleTapGesture));
				} else {
					ret = (MonoTouch.UIKit.UITapGestureRecognizer) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDoubleTapGesture));
				}
				MarkDirty ();
				__mt_DoubleTapGesture_var = ret;
				return ret;
			}
			
		}
		
		object __mt_LongPressGesture_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UILongPressGestureRecognizer LongPressGesture {
			[Export ("longPressGesture")]
			get {
				MonoTouch.UIKit.UILongPressGestureRecognizer ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UILongPressGestureRecognizer) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLongPressGesture));
				} else {
					ret = (MonoTouch.UIKit.UILongPressGestureRecognizer) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLongPressGesture));
				}
				MarkDirty ();
				__mt_LongPressGesture_var = ret;
				return ret;
			}
			
		}
		
		object __mt_CompoundView_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIView CompoundView {
			[Export ("compoundView")]
			get {
				MonoTouch.UIKit.UIView ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCompoundView));
				} else {
					ret = (MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCompoundView));
				}
				MarkDirty ();
				__mt_CompoundView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool RotationActive {
			[Export ("isRotationActive", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsRotationActive);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsRotationActive);
				}
			}
			
			[Export ("setRotationActive:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetRotationActive_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetRotationActive_, value);
				}
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_Document_var = null;
			__mt_PdfController_var = null;
			__mt_LeftPage_var = null;
			__mt_RightPage_var = null;
			__mt_SingleTapGesture_var = null;
			__mt_DoubleTapGesture_var = null;
			__mt_LongPressGesture_var = null;
			__mt_CompoundView_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFScrollView */
}
