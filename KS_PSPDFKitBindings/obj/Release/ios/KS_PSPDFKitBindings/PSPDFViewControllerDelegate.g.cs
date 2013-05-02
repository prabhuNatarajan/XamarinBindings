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
	[Register("PSPDFViewControllerDelegate", true)]
	[Model]
	public unsafe partial class PSPDFViewControllerDelegate : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSObject");
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		public PSPDFViewControllerDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("pdfViewController:shouldSetDocument:")]
		[CompilerGenerated]
		public virtual bool ShouldSetDocument (PSPDFViewController pdfController, PSPDFDocument document)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:willDisplayDocument:")]
		[CompilerGenerated]
		public virtual void WillDisplayDocument (PSPDFViewController pdfController, PSPDFDocument document)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didDisplayDocument:")]
		[CompilerGenerated]
		public virtual void DidDisplayDocument (PSPDFViewController pdfController, PSPDFDocument document)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:shouldScrollToPage:")]
		[CompilerGenerated]
		public virtual bool ShouldScrollToPage (PSPDFViewController pdfController, global::System.UInt32 page)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didShowPageView:")]
		[CompilerGenerated]
		public virtual void DidShowPageView (PSPDFViewController pdfController, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didRenderPageView:")]
		[CompilerGenerated]
		public virtual void DidRenderPageView (PSPDFViewController pdfController, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didLoadPageView:")]
		[CompilerGenerated]
		public virtual void DidLoadPageView (PSPDFViewController pdfController, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:willUnloadPageView:")]
		[CompilerGenerated]
		public virtual void WillUnloadPageView (PSPDFViewController pdfController, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didChangeViewMode:")]
		[CompilerGenerated]
		public virtual void DidChangeViewMode (PSPDFViewController pdfController, PSPDFViewMode viewMode)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didEndPageDragging:willDecelerate:withVelocity:targetContentOffset:")]
		[CompilerGenerated]
		public virtual void DidEndPageDragging (PSPDFViewController pdfController, global::MonoTouch.UIKit.UIScrollView scrollView, bool decelerate, global::System.Drawing.PointF velocity, ref global::System.Drawing.PointF targetContentOffset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didEndPageScrollingAnimation:")]
		[CompilerGenerated]
		public virtual void DidEndPageScrollingAnimation (PSPDFViewController pdfController, global::MonoTouch.UIKit.UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didEndPageZooming:atScale:")]
		[CompilerGenerated]
		public virtual void DidEndPageZooming (PSPDFViewController pdfController, global::MonoTouch.UIKit.UIScrollView scrollView, float scale)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didRenderPage:inContext:withSize:clippedToRect:withAnnotations:options:")]
		[CompilerGenerated]
		public virtual void DidRenderPage (PSPDFViewController pdfController, global::System.UInt32 page, global::System.IntPtr context, global::System.Drawing.SizeF fullsize, global::System.Drawing.RectangleF clipRect, PSPDFAnnotation[] annotations, NSDictionary options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:documentForRelativePath:")]
		[CompilerGenerated]
		public virtual PSPDFDocument DocumentForRelativePath (PSPDFViewController pdfController, string relativePath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didTapOnPageView:atPoint:")]
		[CompilerGenerated]
		public virtual bool DidTapOnPageView (PSPDFViewController pdfController, PSPDFPageView pageView, global::System.Drawing.PointF viewPoint)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didLongPressOnPageView:atPoint:gestureRecognizer:")]
		[CompilerGenerated]
		public virtual bool DidLongPressOnPageView (PSPDFViewController pdfController, PSPDFPageView pageView, global::System.Drawing.PointF viewPoint, global::MonoTouch.UIKit.UILongPressGestureRecognizer gestureRecognizer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:shouldSelectText:withGlyphs:atRect:onPageView:")]
		[CompilerGenerated]
		public virtual bool ShouldSelectText (PSPDFViewController pdfController, string text, PSPDFGlyph[] glyphs, global::System.Drawing.RectangleF rect, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didSelectText:withGlyphs:atRect:onPageView:")]
		[CompilerGenerated]
		public virtual void DidSelectText (PSPDFViewController pdfController, string text, PSPDFGlyph[] glyphs, global::System.Drawing.RectangleF rect, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:shouldShowMenuItems:atSuggestedTargetRect:forSelectedText:inRect:onPageView:")]
		[CompilerGenerated]
		public virtual PSPDFMenuItem[] ShouldShowMenuItemsForSelectedText (PSPDFViewController pdfController, PSPDFMenuItem[] menuItems, global::System.Drawing.RectangleF rect, string selectedText, global::System.Drawing.RectangleF textRect, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:shouldShowMenuItems:atSuggestedTargetRect:forSelectedImage:inRect:onPageView:")]
		[CompilerGenerated]
		public virtual PSPDFMenuItem[] ShouldShowMenuItemsForSelectedImage (PSPDFViewController pdfController, PSPDFMenuItem[] menuItems, global::System.Drawing.RectangleF rect, PSPDFImageInfo selectedImage, global::System.Drawing.RectangleF textRect, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:shouldShowMenuItems:atSuggestedTargetRect:forAnnotation:inRect:onPageView:")]
		[CompilerGenerated]
		public virtual PSPDFMenuItem[] ShouldShowMenuItemsForAnnotation (PSPDFViewController pdfController, PSPDFMenuItem[] menuItems, global::System.Drawing.RectangleF rect, PSPDFAnnotation annotation, global::System.Drawing.RectangleF textRect, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:shouldDisplayAnnotation:onPageView:")]
		[CompilerGenerated]
		public virtual bool ShouldDisplayAnnotation (PSPDFViewController pdfController, PSPDFAnnotation annotation, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didTapOnAnnotation:annotationPoint:annotationView:pageView:viewPoint:")]
		[CompilerGenerated]
		public virtual bool DidTapOnAnnotation (PSPDFViewController pdfController, PSPDFAnnotation annotation, global::System.Drawing.PointF annotationPoint, PSPDFAnnotationViewProtocol annotationView, PSPDFPageView pageView, global::System.Drawing.PointF viewPoint)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:ShouldSelectAnnotation:onPageView:")]
		[CompilerGenerated]
		public virtual bool ShouldSelectAnnotation (PSPDFViewController pdfController, PSPDFAnnotation annotation, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didSelectAnnotation:onPageView:")]
		[CompilerGenerated]
		public virtual void DidSelectAnnotation (PSPDFViewController pdfController, PSPDFAnnotation annotation, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:annotationView:forAnnotation:onPageView:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotationViewProtocol AnnotationViewForAnnotation (PSPDFViewController pdfController, PSPDFAnnotationViewProtocol annotationView, PSPDFAnnotation annotation, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:willShowAnnotationView:onPageView:")]
		[CompilerGenerated]
		public virtual void WillShowAnnotationView (PSPDFViewController pdfController, PSPDFAnnotationViewProtocol annotationView, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didShowAnnotationView:onPageView:")]
		[CompilerGenerated]
		public virtual void DidShowAnnotationView (PSPDFViewController pdfController, PSPDFAnnotationViewProtocol annotationView, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:shouldShowController:embeddedInController:animated:")]
		[CompilerGenerated]
		public virtual bool ShouldShowController (PSPDFViewController pdfController, NSObject viewController, NSObject controller, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didShowController:embeddedInController:animated:")]
		[CompilerGenerated]
		public virtual void DidShowController (PSPDFViewController pdfController, NSObject viewController, NSObject controller, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:requestsUpdateForBarButtonItem:animated:")]
		[CompilerGenerated]
		public virtual void RequestsUpdateForBarButtonItem (PSPDFViewController pdfController, global::MonoTouch.UIKit.UIBarButtonItem barButtonItem, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:shouldShowHUD:")]
		[CompilerGenerated]
		public virtual bool ShouldShowHUD (PSPDFViewController pdfController, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:willShowHUD:")]
		[CompilerGenerated]
		public virtual void WillShowHUD (PSPDFViewController pdfController, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didShowHUD:")]
		[CompilerGenerated]
		public virtual void DidShowHUD (PSPDFViewController pdfController, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:shouldHideHUD:")]
		[CompilerGenerated]
		public virtual bool ShouldHideHUD (PSPDFViewController pdfController, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:willHideHUD:")]
		[CompilerGenerated]
		public virtual void WillHideHUD (PSPDFViewController pdfController, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didHideHUD:")]
		[CompilerGenerated]
		public virtual void DidHideHUD (PSPDFViewController pdfController, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFViewControllerDelegate */
}
