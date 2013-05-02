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
	public delegate bool PSPDFViewControllerShouldSetDocument (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFDocument document);
	public delegate bool PSPDFViewControllerShouldScrollToPage (KS_PSPDFKitBindings.PSPDFViewController pdfController, uint page);
	public delegate KS_PSPDFKitBindings.PSPDFDocument PSPDFViewControllerDocumentForRelativePath (KS_PSPDFKitBindings.PSPDFViewController pdfController, string relativePath);
	public delegate bool PSPDFViewControllerDidTapOnPageView (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFPageView pageView, PointF viewPoint);
	public delegate bool PSPDFViewControllerDidLongPressOnPageView (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFPageView pageView, PointF viewPoint, UILongPressGestureRecognizer gestureRecognizer);
	public delegate bool PSPDFViewControllerShouldSelectText (KS_PSPDFKitBindings.PSPDFViewController pdfController, string text, KS_PSPDFKitBindings.PSPDFGlyph[] glyphs, RectangleF rect, KS_PSPDFKitBindings.PSPDFPageView pageView);
	public delegate KS_PSPDFKitBindings.PSPDFMenuItem[] PSPDFViewControllerShouldShowMenuItemsForSelectedText (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFMenuItem[] menuItems, RectangleF rect, string selectedText, RectangleF textRect, KS_PSPDFKitBindings.PSPDFPageView pageView);
	public delegate KS_PSPDFKitBindings.PSPDFMenuItem[] PSPDFViewControllerShouldShowMenuItemsForSelectedImage (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFMenuItem[] menuItems, RectangleF rect, KS_PSPDFKitBindings.PSPDFImageInfo selectedImage, RectangleF textRect, KS_PSPDFKitBindings.PSPDFPageView pageView);
	public delegate KS_PSPDFKitBindings.PSPDFMenuItem[] PSPDFViewControllerShouldShowMenuItemsForSelectedAnnotation (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFMenuItem[] menuItems, RectangleF rect, KS_PSPDFKitBindings.PSPDFAnnotation annotation, RectangleF textRect, KS_PSPDFKitBindings.PSPDFPageView pageView);
	public delegate bool PSPDFViewControllerShouldDisplayAnnotation (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFAnnotation annotation, KS_PSPDFKitBindings.PSPDFPageView pageView);
	public delegate bool PSPDFViewControllerDidTapOnAnnotation (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFAnnotation annotation, PointF annotationPoint, KS_PSPDFKitBindings.PSPDFAnnotationViewProtocol annotationView, KS_PSPDFKitBindings.PSPDFPageView pageView, PointF viewPoint);
	public delegate bool PSPDFViewControllerShouldSelectAnnotation (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFAnnotation annotation, KS_PSPDFKitBindings.PSPDFPageView pageView);
	public delegate KS_PSPDFKitBindings.PSPDFAnnotationViewProtocol PSPDFViewControllerAnnotationViewForAnnotation (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFAnnotationViewProtocol annotationView, KS_PSPDFKitBindings.PSPDFAnnotation annotation, KS_PSPDFKitBindings.PSPDFPageView pageView);
	public delegate bool PSPDFViewControllerShouldShowController (KS_PSPDFKitBindings.PSPDFViewController pdfController, NSObject viewController, NSObject controller, bool animated);
	public delegate bool PSPDFViewControllerShouldShowHUD (KS_PSPDFKitBindings.PSPDFViewController pdfController, bool animated);
	public delegate bool PSPDFViewControllerShouldHideHUD (KS_PSPDFKitBindings.PSPDFViewController pdfController, bool animated);
	public delegate string PSPDFDocumentDelegateResolveCustomAnnotationPathToken (KS_PSPDFKitBindings.PSPDFDocument document, string pathToken);
	public delegate bool PSPDFDocumentProviderShouldAppendData (KS_PSPDFKitBindings.PSPDFDocumentProvider documentProvider, NSData data);
	public delegate bool PSPDFSelectionViewShouldStartSelectionAtPoint (KS_PSPDFKitBindings.PSPDFSelectionView selectionView, PointF point);
	public delegate bool PSPDFOutlineViewControllerDidTapAtElement (KS_PSPDFKitBindings.PSPDFOutlineViewController outlineController, KS_PSPDFKitBindings.PSPDFOutlineElement outlineElement);
	public delegate bool PSPDFPasswordViewDel (KS_PSPDFKitBindings.PSPDFPasswordView passwordView, string password);
	public delegate bool PSPDFTabbedViewControllerDocuments (KS_PSPDFKitBindings.PSPDFTabbedViewController tabbedPDFController, KS_PSPDFKitBindings.PSPDFDocument[] newDocuments);
	public delegate bool PSPDFTabbedViewControllerDocument (KS_PSPDFKitBindings.PSPDFTabbedViewController tabbedPDFController, KS_PSPDFKitBindings.PSPDFDocument newDocument);
	public delegate UIColor PSPDFColorSelectionViewControllerColor (UIViewController controller, IntPtr context);
	public delegate uint PSPDFBookmarkViewControllerDelegateCurrentPage (KS_PSPDFKitBindings.PSPDFBookmarkViewController bookmarkController);
}

