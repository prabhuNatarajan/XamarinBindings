using System;
using MonoTouch.CoreGraphics;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using System.Drawing;
using MonoTouch.UIKit;
using System.Runtime.InteropServices;

namespace AlexTouch.PSPDFKit
{
	//////////////////////////////////////////
	////		PSPDFKitGlobal.h	//
	//////////////////////////////////////////
	public partial class PSPDFKitGlobal
	{
		private static PSPDFLogLevel _PSPDFLogLevel;
		
		public static PSPDFLogLevel LogLevel
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFLogLevel");
				_PSPDFLogLevel = (PSPDFLogLevel) Marshal.ReadInt32(ptr);
				
				return _PSPDFLogLevel;
			}
			set 
			{
				_PSPDFLogLevel = value;
				
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFLogLevel");
				Marshal.WriteInt32(ptr, (int)_PSPDFLogLevel);
			}
		}
		
		private static PSPDFAnimate _PSPDFAnimateOption;
		
		public static PSPDFAnimate AnimateOption
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFAnimateOption");
				_PSPDFAnimateOption = (PSPDFAnimate) Marshal.ReadInt32(ptr);
				
				return _PSPDFAnimateOption;
			}
			set 
			{
				_PSPDFAnimateOption = value;
				
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFAnimateOption");
				Marshal.WriteInt32(ptr, (int)_PSPDFAnimateOption);
			}
		}
	}


	//////////////////////////////////////////
	////		PSPDFAnnotation.h			//
	//////////////////////////////////////////
	public partial class PSPDFAnnotation : NSObject
	{
		
		public PSPDFAnnotation (CGPDFDictionary annotDict, CGPDFArray annotsArray) : this (annotDict.Handle, annotsArray.Handle)
		{
			
		}
		
		public PSPDFAnnotation (CGPDFDictionary annotDict, CGPDFArray annotsArray, PSPDFAnnotationType annotationType) : this(annotDict.Handle, annotsArray.Handle, annotationType)
		{
			
		}
		
		public RectangleF RectFromPDFArray (CGPDFArray array)
		{
			return RectFromPDFArray_(this.Handle);
		}
		
		public NSArray RectsFromQuadPointsInArray (CGPDFArray quadPointsArray)
		{
			return RectsFromQuadPointsInArray_(quadPointsArray.Handle);
		}
	}
	
	//////////////////////////////////////////////////
	////		PSPDFBaseViewController.h			//
	//////////////////////////////////////////////////
	
	public partial class PSPDFTextParser : NSObject
	{
		public static PSPDFTextParser initWithPDFPage (CGPDFPage page)
		{
			return initWithPDFPage_(page.Handle);
		}
	}
	
	//////////////////////////////////////////////
	////		PSPDFInkAnnotation.h			//
	//////////////////////////////////////////////
	
	public partial class PSPDFInkAnnotation : PSPDFAnnotation
	{
		public PSPDFInkAnnotation (CGPDFDictionary annotDict, CGPDFArray annotsArray) : this (annotDict.Handle, annotsArray.Handle)
		{
			
		}
	}
	
	//////////////////////////////////////////////////
	////		PSPDFHighlightAnnotation.h			//
	//////////////////////////////////////////////////
	
	public partial class PSPDFHighlightAnnotation : PSPDFAnnotation
	{
		public PSPDFHighlightAnnotation (CGPDFDictionary annotDict, CGPDFArray annotsArray) : this (annotDict.Handle, annotsArray.Handle)
		{
			
		}
	}
	
	//////////////////////////////////////////////////
	////		PSPDFBaseViewController.h			//
	//////////////////////////////////////////////////
	
	public partial class PSPDFFontInfo : NSObject
	{
		public PSPDFFontInfo InitWithFontDictionary (CGPDFDictionary font)
		{
			return InitWithFontDictionary_(font.Handle);
		}
	}
	
	//////////////////////////////
	////	PSPDFDocument.h		//
	//////////////////////////////
	
	public partial class PSPDFDocument : NSObject
	{
		public static PSPDFDocument PDFDocumentWithDataProvider (CGDataProvider dataProvider)
		{
			return PDFDocumentWithDataProvider_(dataProvider.Handle);
		}
		
		public PSPDFDocument InitWithDataProvider (CGDataProvider dataProvider)
		{
			return InitWithDataProvider_(dataProvider.Handle);
		}
		
		public PSPDFPageInfo PageInfoForPage (uint page, CGPDFPage pageRef)
		{
			return PageInfoForPage_ (page, pageRef.Handle);
		}
		
		public void RenderPage (uint page, CGContext /*CGContextRef*/ context, SizeF fullSize, RectangleF clipRect, PSPDFAnnotation [] annotations, NSDictionary options)
		{
			RenderPage_ (page, context.Handle, fullSize, clipRect, annotations, options);
		}
	}
	
	//////////////////////////////////////////////
	////		PSPDFDocumentProvider.h			//
	//////////////////////////////////////////////
	
	public partial class PSPDFDocumentProvider : NSObject
	{
		public PSPDFDocumentProvider (CGDataProvider dataProvider, PSPDFDocument document) : this (dataProvider.Handle, document)
		{
			
		}
		
		public CGPDFDocument RequestDocumentRef ()
		{
			return new CGPDFDocument(RequestDocumentRef_ ());
		}
		
		public void ReleaseDocumentRef (CGPDFDocument documentRef)
		{
			ReleaseDocumentRef_ (documentRef.Handle);
		}
		
		public void ReleasePageRef (CGPDFPage pageRef)
		{
			ReleasePageRef_ (pageRef.Handle);
		}
		
	}
	
	//////////////////////////////////////////////
	////		PSPDFDocumentProvider.h			//
	//////////////////////////////////////////////
	
	public partial class PSPDFOutlineParser : NSObject
	{
		public static NSDictionary ResolveDestNames (NSSet destNames, CGPDFDocument document)
		{
			return ResolveDestNames_ (destNames, document.Handle);
		}
		
	}
	
	//////////////////////////////////////////////
	////		PSPDFAnnotationParser.h			//
	//////////////////////////////////////////////
	
	public partial class PSPDFAnnotationParser : NSObject
	{
		
		public PSPDFAnnotation [] AnnotationsForPage (uint page, PSPDFAnnotationType type, CGPDFPage /*CGPDFPageRef*/ pageRef)
		{
			return AnnotationsForPage_ (page, type, pageRef.Handle);
		}
		
	}
	
	//////////////////////////////////////////////
	////		PSPDFNoteAnnotation.h			//
	//////////////////////////////////////////////
	
	public partial class PSPDFNoteAnnotation : PSPDFAnnotation
	{
		
		public PSPDFNoteAnnotation (CGPDFDictionary annotDict, CGPDFArray annotsArray) : this(annotDict.Handle, annotsArray.Handle)
		{
		}
		
	}
	
	//////////////////////////////////////////////
	////		PSPDFNoteAnnotation.h			//
	//////////////////////////////////////////////
	
	public partial class PSPDFLinkAnnotation : PSPDFAnnotation
	{
		public CGPDFDictionary PageRef
		{
			get 
			{
				return new CGPDFDictionary(PageRef_); 
			}
			set 
			{
				PageRef_ = PageRef.Handle; 
			}
		}
		
	}
	
	//////////////////////////////////////
	////		PSPDFCache.h			//
	//////////////////////////////////////
	
	public partial class PSPDFCache : NSObject
	{
		
		public MonoTouch.UIKit.UIImage CachedImageForDocument (PSPDFDocument document, uint page, PSPDFSize size, CGPDFPage /*CGPDFPageRef*/ pdfPage)
		{
			return CachedImageForDocument_ (document, page, size, pdfPage.Handle);
		}
		
	}
	
	//////////////////////////////////////////
	////		PSPDFPageRenderer.h			//
	//////////////////////////////////////////
	
	public partial class PSPDFPageRenderer : NSObject
	{
		
		public static RectangleF RenderPage (CGPDFPage page, CGContext context, RectangleF rectangle, PSPDFPageInfo pageInfo, PSPDFAnnotation[] annotations, NSDictionary options)
		{
			return RenderPage_ (page.Handle, context.Handle, rectangle, pageInfo, annotations, options);
		}
		
		public static SizeF RenderPage (CGPDFPage page, CGContext context, PointF point, float zoom, PSPDFPageInfo pageInfo, PSPDFAnnotation[] annotations, NSDictionary options)
		{
			return RenderPage_ (page.Handle, context.Handle, point, zoom, pageInfo, annotations, options);
		}
		
	}
	
	
	//////////////////////////////////////////
	////		UIImage+PSPDFKitAdditions	//
	//////////////////////////////////////////
	
	public partial class UIImageExtension : UIImage
	{
		
		public static UIImageExtension FromUIImage (UIImage img)
		{
			return (UIImageExtension) img;
		}
		
	}
	
	public static class UIImageExtensionExMethods
	{
		/// <summary>
		/// Converts from UIImageExtension to UIImage
		/// </summary>
		/// <returns>
		/// Returns UIImage from UIImageExtension.
		/// </returns>
		/// <param name='imgExt'>
		/// The UIImageExtension to conver to UIImage.
		/// </param>
		public static UIImage ToUIImage (this UIImageExtension imgExt)
		{
			return (UIImage) imgExt;
		}	
	}
	
	
	
}

