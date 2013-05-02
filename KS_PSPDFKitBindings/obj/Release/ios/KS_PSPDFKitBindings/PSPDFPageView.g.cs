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
	[Register("PSPDFPageView", true)]
	public unsafe partial class PSPDFPageView : global::MonoTouch.UIKit.UIView {
		[CompilerGenerated]
		const string selContentView = "contentView";
		static readonly IntPtr selContentViewHandle = Selector.GetHandle ("contentView");
		[CompilerGenerated]
		const string selRenderView = "renderView";
		static readonly IntPtr selRenderViewHandle = Selector.GetHandle ("renderView");
		[CompilerGenerated]
		const string selAnnotationContainerView = "annotationContainerView";
		static readonly IntPtr selAnnotationContainerViewHandle = Selector.GetHandle ("annotationContainerView");
		[CompilerGenerated]
		const string selRenderSize = "renderSize";
		static readonly IntPtr selRenderSizeHandle = Selector.GetHandle ("renderSize");
		[CompilerGenerated]
		const string selSetRenderSize_ = "setRenderSize:";
		static readonly IntPtr selSetRenderSize_Handle = Selector.GetHandle ("setRenderSize:");
		[CompilerGenerated]
		const string selPDFScale = "PDFScale";
		static readonly IntPtr selPDFScaleHandle = Selector.GetHandle ("PDFScale");
		[CompilerGenerated]
		const string selIsRendering = "isRendering";
		static readonly IntPtr selIsRenderingHandle = Selector.GetHandle ("isRendering");
		[CompilerGenerated]
		const string selVisibleRect = "visibleRect";
		static readonly IntPtr selVisibleRectHandle = Selector.GetHandle ("visibleRect");
		[CompilerGenerated]
		const string selSelectionView = "selectionView";
		static readonly IntPtr selSelectionViewHandle = Selector.GetHandle ("selectionView");
		[CompilerGenerated]
		const string selRenderStatusView = "renderStatusView";
		static readonly IntPtr selRenderStatusViewHandle = Selector.GetHandle ("renderStatusView");
		[CompilerGenerated]
		const string selSetRenderStatusView_ = "setRenderStatusView:";
		static readonly IntPtr selSetRenderStatusView_Handle = Selector.GetHandle ("setRenderStatusView:");
		[CompilerGenerated]
		const string selRenderStatusViewOffset = "renderStatusViewOffset";
		static readonly IntPtr selRenderStatusViewOffsetHandle = Selector.GetHandle ("renderStatusViewOffset");
		[CompilerGenerated]
		const string selSetRenderStatusViewOffset_ = "setRenderStatusViewOffset:";
		static readonly IntPtr selSetRenderStatusViewOffset_Handle = Selector.GetHandle ("setRenderStatusViewOffset:");
		[CompilerGenerated]
		const string selCenterRenderStatusView = "centerRenderStatusView";
		static readonly IntPtr selCenterRenderStatusViewHandle = Selector.GetHandle ("centerRenderStatusView");
		[CompilerGenerated]
		const string selSetCenterRenderStatusView_ = "setCenterRenderStatusView:";
		static readonly IntPtr selSetCenterRenderStatusView_Handle = Selector.GetHandle ("setCenterRenderStatusView:");
		[CompilerGenerated]
		const string selTextParser = "textParser";
		static readonly IntPtr selTextParserHandle = Selector.GetHandle ("textParser");
		[CompilerGenerated]
		const string selScrollView = "scrollView";
		static readonly IntPtr selScrollViewHandle = Selector.GetHandle ("scrollView");
		[CompilerGenerated]
		const string selVisibleAnnotationViews = "visibleAnnotationViews";
		static readonly IntPtr selVisibleAnnotationViewsHandle = Selector.GetHandle ("visibleAnnotationViews");
		[CompilerGenerated]
		const string selPdfController = "pdfController";
		static readonly IntPtr selPdfControllerHandle = Selector.GetHandle ("pdfController");
		[CompilerGenerated]
		const string selPage = "page";
		static readonly IntPtr selPageHandle = Selector.GetHandle ("page");
		[CompilerGenerated]
		const string selDocument = "document";
		static readonly IntPtr selDocumentHandle = Selector.GetHandle ("document");
		[CompilerGenerated]
		const string selPageInfo = "pageInfo";
		static readonly IntPtr selPageInfoHandle = Selector.GetHandle ("pageInfo");
		[CompilerGenerated]
		const string selIsRightPage = "isRightPage";
		static readonly IntPtr selIsRightPageHandle = Selector.GetHandle ("isRightPage");
		[CompilerGenerated]
		const string selIsShadowEnabled = "isShadowEnabled";
		static readonly IntPtr selIsShadowEnabledHandle = Selector.GetHandle ("isShadowEnabled");
		[CompilerGenerated]
		const string selSetShadowEnabled_ = "setShadowEnabled:";
		static readonly IntPtr selSetShadowEnabled_Handle = Selector.GetHandle ("setShadowEnabled:");
		[CompilerGenerated]
		const string selShadowOpacity = "shadowOpacity";
		static readonly IntPtr selShadowOpacityHandle = Selector.GetHandle ("shadowOpacity");
		[CompilerGenerated]
		const string selSetShadowOpacity_ = "setShadowOpacity:";
		static readonly IntPtr selSetShadowOpacity_Handle = Selector.GetHandle ("setShadowOpacity:");
		[CompilerGenerated]
		const string selSelectedAnnotation = "selectedAnnotation";
		static readonly IntPtr selSelectedAnnotationHandle = Selector.GetHandle ("selectedAnnotation");
		[CompilerGenerated]
		const string selSetSelectedAnnotation_ = "setSelectedAnnotation:";
		static readonly IntPtr selSetSelectedAnnotation_Handle = Selector.GetHandle ("setSelectedAnnotation:");
		[CompilerGenerated]
		const string selSuspendUpdate = "suspendUpdate";
		static readonly IntPtr selSuspendUpdateHandle = Selector.GetHandle ("suspendUpdate");
		[CompilerGenerated]
		const string selSetSuspendUpdate_ = "setSuspendUpdate:";
		static readonly IntPtr selSetSuspendUpdate_Handle = Selector.GetHandle ("setSuspendUpdate:");
		[CompilerGenerated]
		const string selAnnotationSelectionView = "annotationSelectionView";
		static readonly IntPtr selAnnotationSelectionViewHandle = Selector.GetHandle ("annotationSelectionView");
		[CompilerGenerated]
		const string selInitWithFrameOverrideClassNames_ = "initWithFrame:overrideClassNames:";
		static readonly IntPtr selInitWithFrameOverrideClassNames_Handle = Selector.GetHandle ("initWithFrame:overrideClassNames:");
		[CompilerGenerated]
		const string selDisplayDocumentPagePageRectScaleDelayPageAnnotationsPdfController_ = "displayDocument:page:pageRect:scale:delayPageAnnotations:pdfController:";
		static readonly IntPtr selDisplayDocumentPagePageRectScaleDelayPageAnnotationsPdfController_Handle = Selector.GetHandle ("displayDocument:page:pageRect:scale:delayPageAnnotations:pdfController:");
		[CompilerGenerated]
		const string selPrepareForReuse = "prepareForReuse";
		static readonly IntPtr selPrepareForReuseHandle = Selector.GetHandle ("prepareForReuse");
		[CompilerGenerated]
		const string selUpdateRenderView = "updateRenderView";
		static readonly IntPtr selUpdateRenderViewHandle = Selector.GetHandle ("updateRenderView");
		[CompilerGenerated]
		const string selUpdateView = "updateView";
		static readonly IntPtr selUpdateViewHandle = Selector.GetHandle ("updateView");
		[CompilerGenerated]
		const string selCachedAnnotationViewForAnnotation_ = "cachedAnnotationViewForAnnotation:";
		static readonly IntPtr selCachedAnnotationViewForAnnotation_Handle = Selector.GetHandle ("cachedAnnotationViewForAnnotation:");
		[CompilerGenerated]
		const string selConvertViewPointToPDFPoint_ = "convertViewPointToPDFPoint:";
		static readonly IntPtr selConvertViewPointToPDFPoint_Handle = Selector.GetHandle ("convertViewPointToPDFPoint:");
		[CompilerGenerated]
		const string selConvertPDFPointToViewPoint_ = "convertPDFPointToViewPoint:";
		static readonly IntPtr selConvertPDFPointToViewPoint_Handle = Selector.GetHandle ("convertPDFPointToViewPoint:");
		[CompilerGenerated]
		const string selConvertViewRectToPDFRect_ = "convertViewRectToPDFRect:";
		static readonly IntPtr selConvertViewRectToPDFRect_Handle = Selector.GetHandle ("convertViewRectToPDFRect:");
		[CompilerGenerated]
		const string selConvertPDFRectToViewRect_ = "convertPDFRectToViewRect:";
		static readonly IntPtr selConvertPDFRectToViewRect_Handle = Selector.GetHandle ("convertPDFRectToViewRect:");
		[CompilerGenerated]
		const string selConvertGlyphRectToViewRect_ = "convertGlyphRectToViewRect:";
		static readonly IntPtr selConvertGlyphRectToViewRect_Handle = Selector.GetHandle ("convertGlyphRectToViewRect:");
		[CompilerGenerated]
		const string selConvertViewRectToGlyphRect_ = "convertViewRectToGlyphRect:";
		static readonly IntPtr selConvertViewRectToGlyphRect_Handle = Selector.GetHandle ("convertViewRectToGlyphRect:");
		[CompilerGenerated]
		const string selObjectsAtPointOptions_ = "objectsAtPoint:options:";
		static readonly IntPtr selObjectsAtPointOptions_Handle = Selector.GetHandle ("objectsAtPoint:options:");
		[CompilerGenerated]
		const string selObjectsAtRectOptions_ = "objectsAtRect:options:";
		static readonly IntPtr selObjectsAtRectOptions_Handle = Selector.GetHandle ("objectsAtRect:options:");
		[CompilerGenerated]
		const string selUpdateShadowAnimated_ = "updateShadowAnimated:";
		static readonly IntPtr selUpdateShadowAnimated_Handle = Selector.GetHandle ("updateShadowAnimated:");
		[CompilerGenerated]
		const string selSetUpdateShadowBlock_ = "setUpdateShadowBlock:";
		static readonly IntPtr selSetUpdateShadowBlock_Handle = Selector.GetHandle ("setUpdateShadowBlock:");
		[CompilerGenerated]
		const string selSingleTapped_ = "singleTapped:";
		static readonly IntPtr selSingleTapped_Handle = Selector.GetHandle ("singleTapped:");
		[CompilerGenerated]
		const string selLongPress_ = "longPress:";
		static readonly IntPtr selLongPress_Handle = Selector.GetHandle ("longPress:");
		[CompilerGenerated]
		const string selAddAnnotationAnimated_ = "addAnnotation:animated:";
		static readonly IntPtr selAddAnnotationAnimated_Handle = Selector.GetHandle ("addAnnotation:animated:");
		[CompilerGenerated]
		const string selRemoveAnnotationAnimated_ = "removeAnnotation:animated:";
		static readonly IntPtr selRemoveAnnotationAnimated_Handle = Selector.GetHandle ("removeAnnotation:animated:");
		[CompilerGenerated]
		const string selPspdf_scrollViewWillZoomToScaleAnimated_ = "pspdf_scrollView:willZoomToScale:animated:";
		static readonly IntPtr selPspdf_scrollViewWillZoomToScaleAnimated_Handle = Selector.GetHandle ("pspdf_scrollView:willZoomToScale:animated:");
		[CompilerGenerated]
		const string selLoadPageAnnotationsAnimatedBlockWhileParsing_ = "loadPageAnnotationsAnimated:blockWhileParsing:";
		static readonly IntPtr selLoadPageAnnotationsAnimatedBlockWhileParsing_Handle = Selector.GetHandle ("loadPageAnnotationsAnimated:blockWhileParsing:");
		[CompilerGenerated]
		const string selTappableAnnotationsAtPoint_ = "tappableAnnotationsAtPoint:";
		static readonly IntPtr selTappableAnnotationsAtPoint_Handle = Selector.GetHandle ("tappableAnnotationsAtPoint:");
		[CompilerGenerated]
		const string selSingleTappedAtViewPoint_ = "singleTappedAtViewPoint:";
		static readonly IntPtr selSingleTappedAtViewPoint_Handle = Selector.GetHandle ("singleTappedAtViewPoint:");
		[CompilerGenerated]
		const string selShowMenuIfSelectedAnimated_ = "showMenuIfSelectedAnimated:";
		static readonly IntPtr selShowMenuIfSelectedAnimated_Handle = Selector.GetHandle ("showMenuIfSelectedAnimated:");
		[CompilerGenerated]
		const string selShowNewSignatureMenuAtPoint_ = "showNewSignatureMenuAtPoint:";
		static readonly IntPtr selShowNewSignatureMenuAtPoint_Handle = Selector.GetHandle ("showNewSignatureMenuAtPoint:");
		[CompilerGenerated]
		const string selShowNewImageMenuAtPoint_ = "showNewImageMenuAtPoint:";
		static readonly IntPtr selShowNewImageMenuAtPoint_Handle = Selector.GetHandle ("showNewImageMenuAtPoint:");
		[CompilerGenerated]
		const string selDefaultColorOptionsForAnnotationType_ = "defaultColorOptionsForAnnotationType:";
		static readonly IntPtr selDefaultColorOptionsForAnnotationType_Handle = Selector.GetHandle ("defaultColorOptionsForAnnotationType:");
		[CompilerGenerated]
		const string selRenderOptionsDictWithZoomScale_ = "renderOptionsDictWithZoomScale:";
		static readonly IntPtr selRenderOptionsDictWithZoomScale_Handle = Selector.GetHandle ("renderOptionsDictWithZoomScale:");
		[CompilerGenerated]
		const string selRemoveAnnotationOnNextPageUpdate_ = "removeAnnotationOnNextPageUpdate:";
		static readonly IntPtr selRemoveAnnotationOnNextPageUpdate_Handle = Selector.GetHandle ("removeAnnotationOnNextPageUpdate:");
		[CompilerGenerated]
		const string selRemoveViewOnNextPageUpdate_ = "removeViewOnNextPageUpdate:";
		static readonly IntPtr selRemoveViewOnNextPageUpdate_Handle = Selector.GetHandle ("removeViewOnNextPageUpdate:");
		[CompilerGenerated]
		const string selShowLinkPreviewActionSheetForAnnotationFromRectAnimated_ = "showLinkPreviewActionSheetForAnnotation:fromRect:animated:";
		static readonly IntPtr selShowLinkPreviewActionSheetForAnnotationFromRectAnimated_Handle = Selector.GetHandle ("showLinkPreviewActionSheetForAnnotation:fromRect:animated:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFPageView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFPageView () : base (NSObjectFlag.Empty)
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
		public PSPDFPageView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFPageView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFPageView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:overrideClassNames:")]
		[CompilerGenerated]
		public PSPDFPageView (global::System.Drawing.RectangleF frame, NSDictionary overrideClassNames)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_RectangleF_IntPtr (this.Handle, selInitWithFrameOverrideClassNames_Handle, frame, overrideClassNames == null ? IntPtr.Zero : overrideClassNames.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_RectangleF_IntPtr (this.SuperHandle, selInitWithFrameOverrideClassNames_Handle, frame, overrideClassNames == null ? IntPtr.Zero : overrideClassNames.Handle);
			}
		}
		
		[Export ("displayDocument:page:pageRect:scale:delayPageAnnotations:pdfController:")]
		[CompilerGenerated]
		public virtual void DisplayDocument (PSPDFDocument document, global::System.UInt32 page, global::System.Drawing.RectangleF pageRect, float scale, bool delayPageAnnotations, PSPDFViewController pdfController)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32_RectangleF_float_bool_IntPtr (this.Handle, selDisplayDocumentPagePageRectScaleDelayPageAnnotationsPdfController_Handle, document.Handle, page, pageRect, scale, delayPageAnnotations, pdfController.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_UInt32_RectangleF_float_bool_IntPtr (this.SuperHandle, selDisplayDocumentPagePageRectScaleDelayPageAnnotationsPdfController_Handle, document.Handle, page, pageRect, scale, delayPageAnnotations, pdfController.Handle);
			}
		}
		
		[Export ("prepareForReuse")]
		[CompilerGenerated]
		public virtual void PrepareForReuse ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPrepareForReuseHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selPrepareForReuseHandle);
			}
		}
		
		[Export ("updateRenderView")]
		[CompilerGenerated]
		public virtual void UpdateRenderView ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateRenderViewHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selUpdateRenderViewHandle);
			}
		}
		
		[Export ("updateView")]
		[CompilerGenerated]
		public virtual void UpdateView ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateViewHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selUpdateViewHandle);
			}
		}
		
		[Export ("cachedAnnotationViewForAnnotation:")]
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIView CachedAnnotationViewForAnnotation (PSPDFAnnotation annotation)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				return (global::MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selCachedAnnotationViewForAnnotation_Handle, annotation.Handle));
			} else {
				return (global::MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selCachedAnnotationViewForAnnotation_Handle, annotation.Handle));
			}
		}
		
		[Export ("convertViewPointToPDFPoint:")]
		[CompilerGenerated]
		public virtual global::System.Drawing.PointF ConvertViewPointToPDFPoint (global::System.Drawing.PointF viewPoint)
		{
			global::System.Drawing.PointF ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE){
					MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSend_stret_PointF (out ret, this.Handle, selConvertViewPointToPDFPoint_Handle, viewPoint);
				} else {
					ret = MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSend_PointF (this.Handle, selConvertViewPointToPDFPoint_Handle, viewPoint);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE){
					MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSendSuper_stret_PointF (out ret, this.SuperHandle, selConvertViewPointToPDFPoint_Handle, viewPoint);
				} else {
					ret = MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSendSuper_PointF (this.SuperHandle, selConvertViewPointToPDFPoint_Handle, viewPoint);
				}
			}
			return ret;
		}
		
		[Export ("convertPDFPointToViewPoint:")]
		[CompilerGenerated]
		public virtual global::System.Drawing.PointF ConvertPDFPointToViewPoint (global::System.Drawing.PointF pdfPoint)
		{
			global::System.Drawing.PointF ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE){
					MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSend_stret_PointF (out ret, this.Handle, selConvertPDFPointToViewPoint_Handle, pdfPoint);
				} else {
					ret = MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSend_PointF (this.Handle, selConvertPDFPointToViewPoint_Handle, pdfPoint);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE){
					MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSendSuper_stret_PointF (out ret, this.SuperHandle, selConvertPDFPointToViewPoint_Handle, pdfPoint);
				} else {
					ret = MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSendSuper_PointF (this.SuperHandle, selConvertPDFPointToViewPoint_Handle, pdfPoint);
				}
			}
			return ret;
		}
		
		[Export ("convertViewRectToPDFRect:")]
		[CompilerGenerated]
		public virtual global::System.Drawing.RectangleF ConvertViewRectToPDFRect (global::System.Drawing.RectangleF viewRect)
		{
			global::System.Drawing.RectangleF ret;
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret_RectangleF (out ret, this.Handle, selConvertViewRectToPDFRect_Handle, viewRect);
			} else {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret_RectangleF (out ret, this.SuperHandle, selConvertViewRectToPDFRect_Handle, viewRect);
			}
			return ret;
		}
		
		[Export ("convertPDFRectToViewRect:")]
		[CompilerGenerated]
		public virtual global::System.Drawing.RectangleF ConvertPDFRectToViewRect (global::System.Drawing.RectangleF pdfRect)
		{
			global::System.Drawing.RectangleF ret;
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret_RectangleF (out ret, this.Handle, selConvertPDFRectToViewRect_Handle, pdfRect);
			} else {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret_RectangleF (out ret, this.SuperHandle, selConvertPDFRectToViewRect_Handle, pdfRect);
			}
			return ret;
		}
		
		[Export ("convertGlyphRectToViewRect:")]
		[CompilerGenerated]
		public virtual global::System.Drawing.RectangleF ConvertGlyphRectToViewRect (global::System.Drawing.RectangleF glyphRect)
		{
			global::System.Drawing.RectangleF ret;
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret_RectangleF (out ret, this.Handle, selConvertGlyphRectToViewRect_Handle, glyphRect);
			} else {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret_RectangleF (out ret, this.SuperHandle, selConvertGlyphRectToViewRect_Handle, glyphRect);
			}
			return ret;
		}
		
		[Export ("convertViewRectToGlyphRect:")]
		[CompilerGenerated]
		public virtual global::System.Drawing.RectangleF ConvertViewRectToGlyphRect (global::System.Drawing.RectangleF viewRect)
		{
			global::System.Drawing.RectangleF ret;
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret_RectangleF (out ret, this.Handle, selConvertViewRectToGlyphRect_Handle, viewRect);
			} else {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret_RectangleF (out ret, this.SuperHandle, selConvertViewRectToGlyphRect_Handle, viewRect);
			}
			return ret;
		}
		
		[Export ("objectsAtPoint:options:")]
		[CompilerGenerated]
		public virtual NSDictionary ObjectsAtPointOptions (global::System.Drawing.PointF viewPoint, NSDictionary options)
		{
			if (options == null)
				throw new ArgumentNullException ("options");
			if (IsDirectBinding) {
				return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_PointF_IntPtr (this.Handle, selObjectsAtPointOptions_Handle, viewPoint, options.Handle));
			} else {
				return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_PointF_IntPtr (this.SuperHandle, selObjectsAtPointOptions_Handle, viewPoint, options.Handle));
			}
		}
		
		[Export ("objectsAtRect:options:")]
		[CompilerGenerated]
		public virtual NSDictionary ObjectsAtRectOptions (global::System.Drawing.RectangleF viewRect, NSDictionary options)
		{
			if (options == null)
				throw new ArgumentNullException ("options");
			if (IsDirectBinding) {
				return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_RectangleF_IntPtr (this.Handle, selObjectsAtRectOptions_Handle, viewRect, options.Handle));
			} else {
				return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_RectangleF_IntPtr (this.SuperHandle, selObjectsAtRectOptions_Handle, viewRect, options.Handle));
			}
		}
		
		[Export ("updateShadowAnimated:")]
		[CompilerGenerated]
		public virtual void UpdateShadowAnimated (bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selUpdateShadowAnimated_Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selUpdateShadowAnimated_Handle, animated);
			}
		}
		
		[Export ("setUpdateShadowBlock:")]
		[CompilerGenerated]
		public unsafe virtual void SetUpdateShadowBlock (PSPDFPageViewUpdateShadowBlock ShadowBlock)
		{
			if (ShadowBlock == null)
				throw new ArgumentNullException ("ShadowBlock");
			BlockLiteral *block_ptr_ShadowBlock;
			BlockLiteral block_ShadowBlock;
			block_ShadowBlock = new BlockLiteral ();
			block_ptr_ShadowBlock = &block_ShadowBlock;
			block_ShadowBlock.SetupBlock (static_InnerPSPDFPageViewUpdateShadowBlock, ShadowBlock);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUpdateShadowBlock_Handle, (IntPtr) block_ptr_ShadowBlock);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUpdateShadowBlock_Handle, (IntPtr) block_ptr_ShadowBlock);
			}
			block_ptr_ShadowBlock->CleanupBlock ();
			
		}
		
		[Export ("singleTapped:")]
		[CompilerGenerated]
		public virtual bool SingleTapped (global::MonoTouch.UIKit.UIGestureRecognizer recognizer)
		{
			if (recognizer == null)
				throw new ArgumentNullException ("recognizer");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selSingleTapped_Handle, recognizer.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selSingleTapped_Handle, recognizer.Handle);
			}
		}
		
		[Export ("longPress:")]
		[CompilerGenerated]
		public virtual bool LongPress (global::MonoTouch.UIKit.UILongPressGestureRecognizer recognizer)
		{
			if (recognizer == null)
				throw new ArgumentNullException ("recognizer");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selLongPress_Handle, recognizer.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selLongPress_Handle, recognizer.Handle);
			}
		}
		
		[CompilerGenerated]
		public void AddAnnotation (PSPDFAnnotation annotation, bool animated)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selAddAnnotationAnimated_Handle, annotation.Handle, animated);
		}
		
		[CompilerGenerated]
		public bool RemoveAnnotation (PSPDFAnnotation annotation, bool animated)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_bool (this.Handle, selRemoveAnnotationAnimated_Handle, annotation.Handle, animated);
		}
		
		[CompilerGenerated]
		public void Pspdf_scrollView (global::MonoTouch.UIKit.UIScrollView scrollView, float scale, bool animated)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_float_bool (this.Handle, selPspdf_scrollViewWillZoomToScaleAnimated_Handle, scrollView.Handle, scale, animated);
		}
		
		[Export ("loadPageAnnotationsAnimated:blockWhileParsing:")]
		[CompilerGenerated]
		public virtual void LoadPageAnnotationsAnimated (bool animated, bool blockWhileParsing)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool_bool (this.Handle, selLoadPageAnnotationsAnimatedBlockWhileParsing_Handle, animated, blockWhileParsing);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_bool (this.SuperHandle, selLoadPageAnnotationsAnimatedBlockWhileParsing_Handle, animated, blockWhileParsing);
			}
		}
		
		[Export ("tappableAnnotationsAtPoint:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotation[] TappableAnnotationsAtPoint (global::System.Drawing.PointF viewPoint)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFAnnotation>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_PointF (this.Handle, selTappableAnnotationsAtPoint_Handle, viewPoint));
			} else {
				return NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFAnnotation>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_PointF (this.SuperHandle, selTappableAnnotationsAtPoint_Handle, viewPoint));
			}
		}
		
		[Export ("singleTappedAtViewPoint:")]
		[CompilerGenerated]
		public virtual bool SingleTappedAtViewPoint (global::System.Drawing.PointF viewPoint)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_PointF (this.Handle, selSingleTappedAtViewPoint_Handle, viewPoint);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_PointF (this.SuperHandle, selSingleTappedAtViewPoint_Handle, viewPoint);
			}
		}
		
		[Export ("showMenuIfSelectedAnimated:")]
		[CompilerGenerated]
		public virtual void ShowMenuIfSelectedAnimated (bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selShowMenuIfSelectedAnimated_Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selShowMenuIfSelectedAnimated_Handle, animated);
			}
		}
		
		[Export ("showNewSignatureMenuAtPoint:")]
		[CompilerGenerated]
		public virtual void ShowNewSignatureMenuAtPoint (global::System.Drawing.PointF point)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_PointF (this.Handle, selShowNewSignatureMenuAtPoint_Handle, point);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_PointF (this.SuperHandle, selShowNewSignatureMenuAtPoint_Handle, point);
			}
		}
		
		[Export ("showNewImageMenuAtPoint:")]
		[CompilerGenerated]
		public virtual void ShowNewImageMenuAtPoint (global::System.Drawing.PointF point)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_PointF (this.Handle, selShowNewImageMenuAtPoint_Handle, point);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_PointF (this.SuperHandle, selShowNewImageMenuAtPoint_Handle, point);
			}
		}
		
		[Export ("defaultColorOptionsForAnnotationType:")]
		[CompilerGenerated]
		public virtual PSPDFOrderedDictionary DefaultColorOptionsForAnnotationType (PSPDFAnnotationType annotationType)
		{
			if (IsDirectBinding) {
				return (PSPDFOrderedDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selDefaultColorOptionsForAnnotationType_Handle, (UInt32)annotationType));
			} else {
				return (PSPDFOrderedDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selDefaultColorOptionsForAnnotationType_Handle, (UInt32)annotationType));
			}
		}
		
		[Export ("renderOptionsDictWithZoomScale:")]
		[CompilerGenerated]
		public virtual NSDictionary RenderOptionsDictWithZoomScale (float zoomScale)
		{
			if (IsDirectBinding) {
				return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_float (this.Handle, selRenderOptionsDictWithZoomScale_Handle, zoomScale));
			} else {
				return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_float (this.SuperHandle, selRenderOptionsDictWithZoomScale_Handle, zoomScale));
			}
		}
		
		[Export ("removeAnnotationOnNextPageUpdate:")]
		[CompilerGenerated]
		public virtual bool RemoveAnnotationOnNextPageUpdate (PSPDFAnnotation annotation)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selRemoveAnnotationOnNextPageUpdate_Handle, annotation.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selRemoveAnnotationOnNextPageUpdate_Handle, annotation.Handle);
			}
		}
		
		[Export ("removeViewOnNextPageUpdate:")]
		[CompilerGenerated]
		public virtual void RemoveViewOnNextPageUpdate (global::MonoTouch.UIKit.UIView view)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRemoveViewOnNextPageUpdate_Handle, view.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selRemoveViewOnNextPageUpdate_Handle, view.Handle);
			}
		}
		
		[Export ("showLinkPreviewActionSheetForAnnotation:fromRect:animated:")]
		[CompilerGenerated]
		public virtual NSObject ShowLinkPreviewActionSheetForAnnotation (PSPDFLinkAnnotation annotation, global::System.Drawing.RectangleF viewRect, bool animated)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				return (NSObject) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_RectangleF_bool (this.Handle, selShowLinkPreviewActionSheetForAnnotationFromRectAnimated_Handle, annotation.Handle, viewRect, animated));
			} else {
				return (NSObject) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_RectangleF_bool (this.SuperHandle, selShowLinkPreviewActionSheetForAnnotationFromRectAnimated_Handle, annotation.Handle, viewRect, animated));
			}
		}
		
		[CompilerGenerated]
		object __mt_ContentView_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIImageView ContentView {
			[Export ("contentView")]
			get {
				global::MonoTouch.UIKit.UIImageView ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selContentViewHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selContentViewHandle));
				}
				MarkDirty ();
				__mt_ContentView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_RenderView_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIImageView RenderView {
			[Export ("renderView")]
			get {
				global::MonoTouch.UIKit.UIImageView ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRenderViewHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRenderViewHandle));
				}
				MarkDirty ();
				__mt_RenderView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_AnnotationContainerView_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotationContainerView AnnotationContainerView {
			[Export ("annotationContainerView")]
			get {
				PSPDFAnnotationContainerView ret;
				if (IsDirectBinding) {
					ret = (PSPDFAnnotationContainerView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAnnotationContainerViewHandle));
				} else {
					ret = (PSPDFAnnotationContainerView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAnnotationContainerViewHandle));
				}
				MarkDirty ();
				__mt_AnnotationContainerView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.Drawing.SizeF RenderSize {
			[Export ("renderSize", ArgumentSemantic.Assign)]
			get {
				global::System.Drawing.SizeF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend_stret (out ret, this.Handle, selRenderSizeHandle);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend (this.Handle, selRenderSizeHandle);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selRenderSizeHandle);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper (this.SuperHandle, selRenderSizeHandle);
					}
				}
				return ret;
			}
			
			[Export ("setRenderSize:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_SizeF (this.Handle, selSetRenderSize_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_SizeF (this.SuperHandle, selSetRenderSize_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float PDFScale {
			[Export ("PDFScale")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selPDFScaleHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selPDFScaleHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool Rendering {
			[Export ("isRendering", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsRenderingHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsRenderingHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.Drawing.RectangleF VisibleRect {
			[Export ("visibleRect", ArgumentSemantic.Assign)]
			get {
				global::System.Drawing.RectangleF ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret (out ret, this.Handle, selVisibleRectHandle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selVisibleRectHandle);
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_SelectionView_var;
		[CompilerGenerated]
		public virtual PSPDFTextSelectionView SelectionView {
			[Export ("selectionView")]
			get {
				PSPDFTextSelectionView ret;
				if (IsDirectBinding) {
					ret = (PSPDFTextSelectionView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectionViewHandle));
				} else {
					ret = (PSPDFTextSelectionView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSelectionViewHandle));
				}
				MarkDirty ();
				__mt_SelectionView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_RenderStatusView_var;
		[CompilerGenerated]
		public virtual PSPDFRenderStatusView RenderStatusView {
			[Export ("renderStatusView")]
			get {
				PSPDFRenderStatusView ret;
				if (IsDirectBinding) {
					ret = (PSPDFRenderStatusView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRenderStatusViewHandle));
				} else {
					ret = (PSPDFRenderStatusView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRenderStatusViewHandle));
				}
				MarkDirty ();
				__mt_RenderStatusView_var = ret;
				return ret;
			}
			
			[Export ("setRenderStatusView:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRenderStatusView_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRenderStatusView_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_RenderStatusView_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual float RenderStatusViewOffset {
			[Export ("renderStatusViewOffset", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selRenderStatusViewOffsetHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selRenderStatusViewOffsetHandle);
				}
			}
			
			[Export ("setRenderStatusViewOffset:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetRenderStatusViewOffset_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetRenderStatusViewOffset_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool CenterRenderStatusView {
			[Export ("centerRenderStatusView", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCenterRenderStatusViewHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selCenterRenderStatusViewHandle);
				}
			}
			
			[Export ("setCenterRenderStatusView:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetCenterRenderStatusView_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetCenterRenderStatusView_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_TextParser_var;
		[CompilerGenerated]
		public virtual PSPDFTextParser TextParser {
			[Export ("textParser")]
			get {
				PSPDFTextParser ret;
				if (IsDirectBinding) {
					ret = (PSPDFTextParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTextParserHandle));
				} else {
					ret = (PSPDFTextParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTextParserHandle));
				}
				MarkDirty ();
				__mt_TextParser_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ScrollView_var;
		[CompilerGenerated]
		public virtual PSPDFScrollView ScrollView {
			[Export ("scrollView")]
			get {
				PSPDFScrollView ret;
				if (IsDirectBinding) {
					ret = (PSPDFScrollView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selScrollViewHandle));
				} else {
					ret = (PSPDFScrollView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selScrollViewHandle));
				}
				MarkDirty ();
				__mt_ScrollView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_VisibleAnnotationViews_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotationViewProtocol[] VisibleAnnotationViews {
			[Export ("visibleAnnotationViews")]
			get {
				PSPDFAnnotationViewProtocol[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFAnnotationViewProtocol>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selVisibleAnnotationViewsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFAnnotationViewProtocol>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selVisibleAnnotationViewsHandle));
				}
				MarkDirty ();
				__mt_VisibleAnnotationViews_var = ret;
				return ret;
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
		public virtual global::System.UInt32 Page {
			[Export ("page", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPageHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selPageHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Document_var;
		[CompilerGenerated]
		public virtual PSPDFDocument Document {
			[Export ("document")]
			get {
				PSPDFDocument ret;
				if (IsDirectBinding) {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocumentHandle));
				} else {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocumentHandle));
				}
				MarkDirty ();
				__mt_Document_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PageInfo_var;
		[CompilerGenerated]
		public virtual PSPDFPageInfo PageInfo {
			[Export ("pageInfo")]
			get {
				PSPDFPageInfo ret;
				if (IsDirectBinding) {
					ret = (PSPDFPageInfo) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPageInfoHandle));
				} else {
					ret = (PSPDFPageInfo) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPageInfoHandle));
				}
				MarkDirty ();
				__mt_PageInfo_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool RightPage {
			[Export ("isRightPage", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsRightPageHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsRightPageHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ShadowEnabled {
			[Export ("isShadowEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsShadowEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsShadowEnabledHandle);
				}
			}
			
			[Export ("setShadowEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShadowEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShadowEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float ShadowOpacity {
			[Export ("shadowOpacity", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selShadowOpacityHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selShadowOpacityHandle);
				}
			}
			
			[Export ("setShadowOpacity:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetShadowOpacity_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetShadowOpacity_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_SelectedAnnotation_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotation SelectedAnnotation {
			[Export ("selectedAnnotation")]
			get {
				PSPDFAnnotation ret;
				if (IsDirectBinding) {
					ret = (PSPDFAnnotation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectedAnnotationHandle));
				} else {
					ret = (PSPDFAnnotation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSelectedAnnotationHandle));
				}
				MarkDirty ();
				__mt_SelectedAnnotation_var = ret;
				return ret;
			}
			
			[Export ("setSelectedAnnotation:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSelectedAnnotation_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSelectedAnnotation_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_SelectedAnnotation_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool SuspendUpdate {
			[Export ("suspendUpdate", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSuspendUpdateHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selSuspendUpdateHandle);
				}
			}
			
			[Export ("setSuspendUpdate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSuspendUpdate_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetSuspendUpdate_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_AnnotationSelectionView_var;
		[CompilerGenerated]
		public virtual PSPDFResizableView AnnotationSelectionView {
			[Export ("annotationSelectionView")]
			get {
				PSPDFResizableView ret;
				if (IsDirectBinding) {
					ret = (PSPDFResizableView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAnnotationSelectionViewHandle));
				} else {
					ret = (PSPDFResizableView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAnnotationSelectionViewHandle));
				}
				MarkDirty ();
				__mt_AnnotationSelectionView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		static readonly IntPtr __Internal_libraryHandle = Dlfcn.dlopen (null, 0);
		[CompilerGenerated]
		static NSString _PSPDFHidePageHUDElements;
		public static NSString PSPDFHidePageHUDElements {
			get {
				if (_PSPDFHidePageHUDElements == null)
					_PSPDFHidePageHUDElements = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFHidePageHUDElements");
				return _PSPDFHidePageHUDElements;
			}
		}
		internal delegate void InnerPSPDFPageViewUpdateShadowBlock (IntPtr block, IntPtr pageView);
		[CompilerGenerated]
		static readonly InnerPSPDFPageViewUpdateShadowBlock static_InnerPSPDFPageViewUpdateShadowBlock = TrampolinePSPDFPageViewUpdateShadowBlock;
		[MonoPInvokeCallback (typeof (InnerPSPDFPageViewUpdateShadowBlock))]
		static unsafe void TrampolinePSPDFPageViewUpdateShadowBlock (IntPtr block, IntPtr pageView) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::KS_PSPDFKitBindings.PSPDFPageViewUpdateShadowBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((KS_PSPDFKitBindings.PSPDFPageView) Runtime.GetNSObject (pageView));
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ContentView_var = null;
				__mt_RenderView_var = null;
				__mt_AnnotationContainerView_var = null;
				__mt_SelectionView_var = null;
				__mt_RenderStatusView_var = null;
				__mt_TextParser_var = null;
				__mt_ScrollView_var = null;
				__mt_VisibleAnnotationViews_var = null;
				__mt_PdfController_var = null;
				__mt_Document_var = null;
				__mt_PageInfo_var = null;
				__mt_SelectedAnnotation_var = null;
				__mt_AnnotationSelectionView_var = null;
			}
		}
	} /* class PSPDFPageView */
	public delegate void PSPDFPageViewUpdateShadowBlock (PSPDFPageView pageView);
}
