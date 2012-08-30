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
	[Register("PSPDFViewControllerDelegate", true)]
	[Model]
	public unsafe partial class PSPDFViewControllerDelegate : NSObject {
		
		static readonly IntPtr class_ptr = Class.GetHandle ("NSObject");
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		public PSPDFViewControllerDelegate (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFViewControllerDelegate (IntPtr handle) : base (handle) {}

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
		public virtual bool ShouldScrollToPage (PSPDFViewController pdfController, System.UInt32 page)
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
		
		[Export ("pdfViewController:didChangeViewMode:")]
		[CompilerGenerated]
		public virtual void DidChangeViewMode (PSPDFViewController pdfController, PSPDFViewMode viewMode)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didEndPageDragging:willDecelerate:withVelocity:targetContentOffset:")]
		[CompilerGenerated]
		public virtual void DidEndPageDragging (PSPDFViewController pdfController, MonoTouch.UIKit.UIScrollView scrollView, bool decelerate, System.Drawing.PointF velocity, ref System.Drawing.PointF targetContentOffset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didEndPageScrollingAnimation:")]
		[CompilerGenerated]
		public virtual void DidEndPageScrollingAnimation (PSPDFViewController pdfController, MonoTouch.UIKit.UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didEndPageZooming:atScale:")]
		[CompilerGenerated]
		public virtual void DidEndPageZooming (PSPDFViewController pdfController, MonoTouch.UIKit.UIScrollView scrollView, float scale)
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
		public virtual bool DidTapOnPageView (PSPDFViewController pdfController, PSPDFPageView pageView, System.Drawing.PointF viewPoint)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didLongPressOnPageView:atPoint:gestureRecognizer:")]
		[CompilerGenerated]
		public virtual bool DidLongPressOnPageView (PSPDFViewController pdfController, PSPDFPageView pageView, System.Drawing.PointF viewPoint, MonoTouch.UIKit.UILongPressGestureRecognizer gestureRecognizer)
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
		public virtual bool DidTapOnAnnotation (PSPDFViewController pdfController, PSPDFAnnotation annotation, System.Drawing.PointF annotationPoint, PSPDFAnnotationView annotationView, PSPDFPageView pageView, System.Drawing.PointF viewPoint)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:annotationView:forAnnotation:onPageView:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotationView AnnotationViewForAnnotation (PSPDFViewController pdfController, PSPDFAnnotationView annotationView, PSPDFAnnotation annotation, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:resolveCustomAnnotationPathToken:")]
		[CompilerGenerated]
		public virtual string ResolveCustomAnnotationPathToken (PSPDFViewController pdfController, string pathToken)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:willShowAnnotationView:onPageView:")]
		[CompilerGenerated]
		public virtual void WillShowAnnotationView (PSPDFViewController pdfController, PSPDFAnnotationView annotationView, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didShowAnnotationView:onPageView:")]
		[CompilerGenerated]
		public virtual void DidShowAnnotationView (PSPDFViewController pdfController, PSPDFAnnotationView annotationView, PSPDFPageView pageView)
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
		
		[Export ("pdfViewController:willShowController:embeddedInController:animated:")]
		[CompilerGenerated]
		public virtual void WillShowController (PSPDFViewController pdfController, NSObject viewController, NSObject controller, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didShowController:embeddedInController:animated:")]
		[CompilerGenerated]
		public virtual void DidShowController (PSPDFViewController pdfController, NSObject viewController, NSObject controller, bool animated)
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
		public virtual void ShouldHideHUD (PSPDFViewController pdfController, bool animated)
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
