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
	[Register("PSPDFPageView", true)]
	public unsafe partial class PSPDFPageView : MonoTouch.UIKit.UIView {
		static readonly IntPtr selContentView = Selector.GetHandle ("contentView");
		static readonly IntPtr selRenderView = Selector.GetHandle ("renderView");
		static readonly IntPtr selRenderSize = Selector.GetHandle ("renderSize");
		static readonly IntPtr selSetRenderSize_ = Selector.GetHandle ("setRenderSize:");
		static readonly IntPtr selPdfScale = Selector.GetHandle ("pdfScale");
		static readonly IntPtr selSuspendUpdate = Selector.GetHandle ("suspendUpdate");
		static readonly IntPtr selSetSuspendUpdate_ = Selector.GetHandle ("setSuspendUpdate:");
		static readonly IntPtr selIsRendering = Selector.GetHandle ("isRendering");
		static readonly IntPtr selVisibleRect = Selector.GetHandle ("visibleRect");
		static readonly IntPtr selSelectionView = Selector.GetHandle ("selectionView");
		static readonly IntPtr selTextParser = Selector.GetHandle ("textParser");
		static readonly IntPtr selScrollView = Selector.GetHandle ("scrollView");
		static readonly IntPtr selVisibleAnnotationViews = Selector.GetHandle ("visibleAnnotationViews");
		static readonly IntPtr selPdfController = Selector.GetHandle ("pdfController");
		static readonly IntPtr selPage = Selector.GetHandle ("page");
		static readonly IntPtr selDocument = Selector.GetHandle ("document");
		static readonly IntPtr selPageInfo = Selector.GetHandle ("pageInfo");
		static readonly IntPtr selIsRightPage = Selector.GetHandle ("isRightPage");
		static readonly IntPtr selIsShadowEnabled = Selector.GetHandle ("isShadowEnabled");
		static readonly IntPtr selSetShadowEnabled_ = Selector.GetHandle ("setShadowEnabled:");
		static readonly IntPtr selShadowOpacity = Selector.GetHandle ("shadowOpacity");
		static readonly IntPtr selSetShadowOpacity_ = Selector.GetHandle ("setShadowOpacity:");
		static readonly IntPtr selSelectedAnnotation = Selector.GetHandle ("selectedAnnotation");
		static readonly IntPtr selInitWithFramePdfController_ = Selector.GetHandle ("initWithFrame:pdfController:");
		static readonly IntPtr selDisplayDocumentPagePageRectScaleDelayPageAnnotationsPdfController_ = Selector.GetHandle ("displayDocument:page:pageRect:scale:delayPageAnnotations:pdfController:");
		static readonly IntPtr selPrepareForReuse = Selector.GetHandle ("prepareForReuse");
		static readonly IntPtr selUpdateRenderView = Selector.GetHandle ("updateRenderView");
		static readonly IntPtr selUpdateView = Selector.GetHandle ("updateView");
		static readonly IntPtr selLoadPageAnnotationsAnimated_ = Selector.GetHandle ("loadPageAnnotationsAnimated:");
		static readonly IntPtr selAnnotationViewForAnnotation_ = Selector.GetHandle ("annotationViewForAnnotation:");
		static readonly IntPtr selConvertViewPointToPDFPoint_ = Selector.GetHandle ("convertViewPointToPDFPoint:");
		static readonly IntPtr selConvertPDFPointToViewPoint_ = Selector.GetHandle ("convertPDFPointToViewPoint:");
		static readonly IntPtr selConvertViewRectToPDFRect_ = Selector.GetHandle ("convertViewRectToPDFRect:");
		static readonly IntPtr selConvertPDFRectToViewRect_ = Selector.GetHandle ("convertPDFRectToViewRect:");
		static readonly IntPtr selObjectsAtPointOptions_ = Selector.GetHandle ("objectsAtPoint:options:");
		static readonly IntPtr selObjectsAtRectOptions_ = Selector.GetHandle ("objectsAtRect:options:");
		static readonly IntPtr selUpdateShadow = Selector.GetHandle ("updateShadow");
		static readonly IntPtr selSetUpdateShadowBlock_ = Selector.GetHandle ("setUpdateShadowBlock:");
		static readonly IntPtr selSingleTap_ = Selector.GetHandle ("singleTap:");
		static readonly IntPtr selLongPress_ = Selector.GetHandle ("longPress:");
		static readonly IntPtr selMenuItemsForAnnotation_ = Selector.GetHandle ("menuItemsForAnnotation:");
		static readonly IntPtr selShowMenuForAnnotation_ = Selector.GetHandle ("showMenuForAnnotation:");
		static readonly IntPtr selLoadPageAnnotationAnimated_ = Selector.GetHandle ("loadPageAnnotation:animated:");
		static readonly IntPtr selPspdf_scrollViewWillZoomToScaleAnimated_ = Selector.GetHandle ("pspdf_scrollView:willZoomToScale:animated:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFPageView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFPageView () : base (NSObjectFlag.Empty)
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
		public PSPDFPageView (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFPageView (IntPtr handle) : base (handle) {}

		[Export ("initWithFrame:pdfController:")]
		[CompilerGenerated]
		public PSPDFPageView (System.Drawing.RectangleF frame, PSPDFViewController pdfController) : base (NSObjectFlag.Empty)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_RectangleF_IntPtr (this.Handle, selInitWithFramePdfController_, frame, pdfController.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_RectangleF_IntPtr (this.SuperHandle, selInitWithFramePdfController_, frame, pdfController.Handle);
			}
		}
		
		[Export ("displayDocument:page:pageRect:scale:delayPageAnnotations:pdfController:")]
		[CompilerGenerated]
		public virtual void DisplayDocument (PSPDFDocument document, System.UInt32 page, System.Drawing.RectangleF pageRect, float scale, bool delayPageAnnotations, PSPDFViewController pdfController)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32_RectangleF_float_bool_IntPtr (this.Handle, selDisplayDocumentPagePageRectScaleDelayPageAnnotationsPdfController_, document.Handle, page, pageRect, scale, delayPageAnnotations, pdfController.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_UInt32_RectangleF_float_bool_IntPtr (this.SuperHandle, selDisplayDocumentPagePageRectScaleDelayPageAnnotationsPdfController_, document.Handle, page, pageRect, scale, delayPageAnnotations, pdfController.Handle);
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
		
		[Export ("updateRenderView")]
		[CompilerGenerated]
		public virtual void UpdateRenderView ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateRenderView);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selUpdateRenderView);
			}
		}
		
		[Export ("updateView")]
		[CompilerGenerated]
		public virtual void UpdateView ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateView);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selUpdateView);
			}
		}
		
		[Export ("loadPageAnnotationsAnimated:")]
		[CompilerGenerated]
		public virtual void LoadPageAnnotationsAnimated (bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selLoadPageAnnotationsAnimated_, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selLoadPageAnnotationsAnimated_, animated);
			}
		}
		
		[Export ("annotationViewForAnnotation:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotationView AnnotationViewForAnnotation (PSPDFAnnotation annotation)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				return (PSPDFAnnotationView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selAnnotationViewForAnnotation_, annotation.Handle));
			} else {
				return (PSPDFAnnotationView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selAnnotationViewForAnnotation_, annotation.Handle));
			}
		}
		
		[Export ("convertViewPointToPDFPoint:")]
		[CompilerGenerated]
		public virtual System.Drawing.PointF ConvertViewPointToPDFPoint (System.Drawing.PointF viewPoint)
		{
			System.Drawing.PointF ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE){
					ApiDefinition.Messaging.PointF_objc_msgSend_stret_PointF (out ret, this.Handle, selConvertViewPointToPDFPoint_, viewPoint);
				} else {
					ret = ApiDefinition.Messaging.PointF_objc_msgSend_PointF (this.Handle, selConvertViewPointToPDFPoint_, viewPoint);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE){
					ApiDefinition.Messaging.PointF_objc_msgSendSuper_stret_PointF (out ret, this.SuperHandle, selConvertViewPointToPDFPoint_, viewPoint);
				} else {
					ret = ApiDefinition.Messaging.PointF_objc_msgSendSuper_PointF (this.SuperHandle, selConvertViewPointToPDFPoint_, viewPoint);
				}
			}
			return ret;
		}
		
		[Export ("convertPDFPointToViewPoint:")]
		[CompilerGenerated]
		public virtual System.Drawing.PointF ConvertPDFPointToViewPoint (System.Drawing.PointF pdfPoint)
		{
			System.Drawing.PointF ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE){
					ApiDefinition.Messaging.PointF_objc_msgSend_stret_PointF (out ret, this.Handle, selConvertPDFPointToViewPoint_, pdfPoint);
				} else {
					ret = ApiDefinition.Messaging.PointF_objc_msgSend_PointF (this.Handle, selConvertPDFPointToViewPoint_, pdfPoint);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE){
					ApiDefinition.Messaging.PointF_objc_msgSendSuper_stret_PointF (out ret, this.SuperHandle, selConvertPDFPointToViewPoint_, pdfPoint);
				} else {
					ret = ApiDefinition.Messaging.PointF_objc_msgSendSuper_PointF (this.SuperHandle, selConvertPDFPointToViewPoint_, pdfPoint);
				}
			}
			return ret;
		}
		
		[Export ("convertViewRectToPDFRect:")]
		[CompilerGenerated]
		public virtual System.Drawing.RectangleF ConvertViewRectToPDFRect (System.Drawing.RectangleF viewRect)
		{
			System.Drawing.RectangleF ret;
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret_RectangleF (out ret, this.Handle, selConvertViewRectToPDFRect_, viewRect);
			} else {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret_RectangleF (out ret, this.SuperHandle, selConvertViewRectToPDFRect_, viewRect);
			}
			return ret;
		}
		
		[Export ("convertPDFRectToViewRect:")]
		[CompilerGenerated]
		public virtual System.Drawing.RectangleF ConvertPDFRectToViewRect (System.Drawing.RectangleF pdfRect)
		{
			System.Drawing.RectangleF ret;
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret_RectangleF (out ret, this.Handle, selConvertPDFRectToViewRect_, pdfRect);
			} else {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret_RectangleF (out ret, this.SuperHandle, selConvertPDFRectToViewRect_, pdfRect);
			}
			return ret;
		}
		
		[Export ("objectsAtPoint:options:")]
		[CompilerGenerated]
		public virtual NSDictionary ObjectsAtPointOptions (System.Drawing.PointF pdfPoint, NSDictionary options)
		{
			if (options == null)
				throw new ArgumentNullException ("options");
			if (IsDirectBinding) {
				return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_PointF_IntPtr (this.Handle, selObjectsAtPointOptions_, pdfPoint, options.Handle));
			} else {
				return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_PointF_IntPtr (this.SuperHandle, selObjectsAtPointOptions_, pdfPoint, options.Handle));
			}
		}
		
		[Export ("objectsAtRect:options:")]
		[CompilerGenerated]
		public virtual NSDictionary ObjectsAtRectOptions (System.Drawing.RectangleF pdfRect, NSDictionary options)
		{
			if (options == null)
				throw new ArgumentNullException ("options");
			if (IsDirectBinding) {
				return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_RectangleF_IntPtr (this.Handle, selObjectsAtRectOptions_, pdfRect, options.Handle));
			} else {
				return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_RectangleF_IntPtr (this.SuperHandle, selObjectsAtRectOptions_, pdfRect, options.Handle));
			}
		}
		
		[Export ("updateShadow")]
		[CompilerGenerated]
		public virtual void UpdateShadow ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateShadow);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selUpdateShadow);
			}
		}
		
		[Export ("setUpdateShadowBlock:")]
		[CompilerGenerated]
		public unsafe virtual void SetUpdateShadowBlock (UpdateShadowBlock ShadowBlock)
		{
			if (ShadowBlock == null)
				throw new ArgumentNullException ("ShadowBlock");
			BlockLiteral *block_ptr_ShadowBlock;
			BlockLiteral block_ShadowBlock;
			block_ShadowBlock = new BlockLiteral ();
			block_ptr_ShadowBlock = &block_ShadowBlock;
			block_ShadowBlock.SetupBlock (static_InnerUpdateShadowBlock, ShadowBlock);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUpdateShadowBlock_, (IntPtr) block_ptr_ShadowBlock);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUpdateShadowBlock_, (IntPtr) block_ptr_ShadowBlock);
			}
			block_ptr_ShadowBlock->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public bool SingleTap (MonoTouch.UIKit.UIGestureRecognizer recognizer)
		{
			if (recognizer == null)
				throw new ArgumentNullException ("recognizer");
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selSingleTap_, recognizer.Handle);
		}
		
		[CompilerGenerated]
		public bool LongPress (MonoTouch.UIKit.UILongPressGestureRecognizer recognizer)
		{
			if (recognizer == null)
				throw new ArgumentNullException ("recognizer");
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selLongPress_, recognizer.Handle);
		}
		
		[CompilerGenerated]
		public MonoTouch.UIKit.UIMenuItem[] MenuItemsForAnnotation (PSPDFAnnotation annotation)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			return NSArray.ArrayFromHandle<MonoTouch.UIKit.UIMenuItem>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selMenuItemsForAnnotation_, annotation.Handle));
		}
		
		[CompilerGenerated]
		public void ShowMenuForAnnotation (PSPDFAnnotation annotation)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selShowMenuForAnnotation_, annotation.Handle);
		}
		
		[CompilerGenerated]
		public void LoadPageAnnotationAnimated (PSPDFAnnotation annotation, bool animated)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selLoadPageAnnotationAnimated_, annotation.Handle, animated);
		}
		
		[CompilerGenerated]
		public void Pspdf_scrollView (MonoTouch.UIKit.UIScrollView scrollView, float scale, bool animated)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_float_bool (this.Handle, selPspdf_scrollViewWillZoomToScaleAnimated_, scrollView.Handle, scale, animated);
		}
		
		object __mt_ContentView_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIImageView ContentView {
			[Export ("contentView")]
			get {
				MonoTouch.UIKit.UIImageView ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selContentView));
				} else {
					ret = (MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selContentView));
				}
				MarkDirty ();
				__mt_ContentView_var = ret;
				return ret;
			}
			
		}
		
		object __mt_RenderView_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIImageView RenderView {
			[Export ("renderView")]
			get {
				MonoTouch.UIKit.UIImageView ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRenderView));
				} else {
					ret = (MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRenderView));
				}
				MarkDirty ();
				__mt_RenderView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual System.Drawing.SizeF RenderSize {
			[Export ("renderSize", ArgumentSemantic.Assign)]
			get {
				System.Drawing.SizeF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend_stret (out ret, this.Handle, selRenderSize);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend (this.Handle, selRenderSize);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selRenderSize);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper (this.SuperHandle, selRenderSize);
					}
				}
				return ret;
			}
			
			[Export ("setRenderSize:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_SizeF (this.Handle, selSetRenderSize_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_SizeF (this.SuperHandle, selSetRenderSize_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float PdfScale {
			[Export ("pdfScale")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selPdfScale);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selPdfScale);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool SuspendUpdate {
			[Export ("suspendUpdate", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSuspendUpdate);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selSuspendUpdate);
				}
			}
			
			[Export ("setSuspendUpdate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSuspendUpdate_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetSuspendUpdate_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Rendering {
			[Export ("isRendering", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsRendering);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsRendering);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual System.Drawing.RectangleF VisibleRect {
			[Export ("visibleRect", ArgumentSemantic.Assign)]
			get {
				System.Drawing.RectangleF ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret (out ret, this.Handle, selVisibleRect);
				} else {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selVisibleRect);
				}
				return ret;
			}
			
		}
		
		object __mt_SelectionView_var;
		[CompilerGenerated]
		public virtual PSPDFTextSelectionView SelectionView {
			[Export ("selectionView")]
			get {
				PSPDFTextSelectionView ret;
				if (IsDirectBinding) {
					ret = (PSPDFTextSelectionView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectionView));
				} else {
					ret = (PSPDFTextSelectionView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSelectionView));
				}
				MarkDirty ();
				__mt_SelectionView_var = ret;
				return ret;
			}
			
		}
		
		object __mt_TextParser_var;
		[CompilerGenerated]
		public virtual PSPDFTextParser TextParser {
			[Export ("textParser")]
			get {
				PSPDFTextParser ret;
				if (IsDirectBinding) {
					ret = (PSPDFTextParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTextParser));
				} else {
					ret = (PSPDFTextParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTextParser));
				}
				MarkDirty ();
				__mt_TextParser_var = ret;
				return ret;
			}
			
		}
		
		object __mt_ScrollView_var;
		[CompilerGenerated]
		public virtual PSPDFScrollView ScrollView {
			[Export ("scrollView")]
			get {
				PSPDFScrollView ret;
				if (IsDirectBinding) {
					ret = (PSPDFScrollView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selScrollView));
				} else {
					ret = (PSPDFScrollView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selScrollView));
				}
				MarkDirty ();
				__mt_ScrollView_var = ret;
				return ret;
			}
			
		}
		
		object __mt_VisibleAnnotationViews_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotationView[] VisibleAnnotationViews {
			[Export ("visibleAnnotationViews")]
			get {
				PSPDFAnnotationView[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFAnnotationView>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selVisibleAnnotationViews));
				} else {
					ret = NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFAnnotationView>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selVisibleAnnotationViews));
				}
				MarkDirty ();
				__mt_VisibleAnnotationViews_var = ret;
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
			
		}
		
		[CompilerGenerated]
		public virtual System.UInt32 Page {
			[Export ("page")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPage);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selPage);
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
		
		object __mt_PageInfo_var;
		[CompilerGenerated]
		public virtual PSPDFPageInfo PageInfo {
			[Export ("pageInfo", ArgumentSemantic.Assign)]
			get {
				PSPDFPageInfo ret;
				if (IsDirectBinding) {
					ret = (PSPDFPageInfo) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPageInfo));
				} else {
					ret = (PSPDFPageInfo) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPageInfo));
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
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsRightPage);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsRightPage);
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
		public virtual float ShadowOpacity {
			[Export ("shadowOpacity", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selShadowOpacity);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selShadowOpacity);
				}
			}
			
			[Export ("setShadowOpacity:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetShadowOpacity_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetShadowOpacity_, value);
				}
			}
		}
		
		object __mt_SelectedAnnotation_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotation SelectedAnnotation {
			[Export ("selectedAnnotation")]
			get {
				PSPDFAnnotation ret;
				if (IsDirectBinding) {
					ret = (PSPDFAnnotation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectedAnnotation));
				} else {
					ret = (PSPDFAnnotation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSelectedAnnotation));
				}
				MarkDirty ();
				__mt_SelectedAnnotation_var = ret;
				return ret;
			}
			
		}
		
		static readonly IntPtr __Internal_libraryHandle = Dlfcn.dlopen (null, 0);
		static NSString _PSPDFHidePageHUDElements;
		public static NSString PSPDFHidePageHUDElements {
			get {
				if (_PSPDFHidePageHUDElements == null)
					_PSPDFHidePageHUDElements = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFHidePageHUDElements");
				return _PSPDFHidePageHUDElements;
			}
		}
		internal delegate void InnerUpdateShadowBlock (IntPtr block, IntPtr pageView);
		static InnerUpdateShadowBlock static_InnerUpdateShadowBlock = new InnerUpdateShadowBlock (TrampolineUpdateShadowBlock);
		[MonoPInvokeCallback (typeof (InnerUpdateShadowBlock))]
		static unsafe void TrampolineUpdateShadowBlock (IntPtr block, IntPtr pageView) {
			var descriptor = (BlockLiteral *) block;
			var del = (AlexTouch.PSPDFKit.UpdateShadowBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((AlexTouch.PSPDFKit.PSPDFPageView) Runtime.GetNSObject (pageView));
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_ContentView_var = null;
			__mt_RenderView_var = null;
			__mt_SelectionView_var = null;
			__mt_TextParser_var = null;
			__mt_ScrollView_var = null;
			__mt_VisibleAnnotationViews_var = null;
			__mt_PdfController_var = null;
			__mt_Document_var = null;
			__mt_PageInfo_var = null;
			__mt_SelectedAnnotation_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFPageView */
	public delegate void UpdateShadowBlock (PSPDFPageView pageView);
}
