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
	////		PSPDFKitGlobal.h			//
	//////////////////////////////////////////
	public partial class PSPDFKitGlobal
	{
		private static PSPDFLogLevel kPSPDFLogLevel;
		
		public static PSPDFLogLevel LogLevel
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFLogLevel");
				kPSPDFLogLevel = (PSPDFLogLevel) Marshal.ReadInt32(ptr);
				
				return kPSPDFLogLevel;
			}
			set 
			{
				kPSPDFLogLevel = value;
				
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFLogLevel");
				Marshal.WriteInt32(ptr, (int)kPSPDFLogLevel);
			}
		}

		private static PSPDFAnimate kPSPDFAnimateOption;
		
		public static PSPDFAnimate AnimateOption
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFAnimateOption");
				kPSPDFAnimateOption = (PSPDFAnimate) Marshal.ReadInt32(ptr);
			
				return kPSPDFAnimateOption;
			}
			set 
			{
				kPSPDFAnimateOption = value;
				
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFAnimateOption");
				Marshal.WriteInt32(ptr, (int)kPSPDFAnimateOption);
			}
		}

		private static float kPSPDFKitPDFAnimationDuration;
		
		public static float AnimationDuration
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				kPSPDFKitPDFAnimationDuration = Dlfcn.GetFloat(RTLD_MAIN_ONLY, "kPSPDFKitPDFAnimationDuration");
				return kPSPDFKitPDFAnimationDuration;
			}
			set 
			{
				kPSPDFKitPDFAnimationDuration = value;
				
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFKitPDFAnimationDuration");

				unsafe 
				{
					float m = kPSPDFKitPDFAnimationDuration;
					Marshal.WriteIntPtr(ptr, *(IntPtr*)&m);
				}
			}
		}

		[DllImportAttribute("__Internal", EntryPoint = "PSPDFShouldAnimate")]
		[return: MarshalAsAttribute(UnmanagedType.Bool)]
		private static extern bool _ShouldAnimate();

		public static bool ShouldAnimate
		{
			get 
			{
				return _ShouldAnimate();
			}
		}

		private static bool kPSPDFKitDebugScrollViews;

		public static bool DebugScrollViews
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFKitDebugScrollViews");

				kPSPDFKitDebugScrollViews = Convert.ToBoolean(Marshal.ReadByte(ptr));
				
				return kPSPDFKitDebugScrollViews;
			}
			set 
			{
				kPSPDFKitDebugScrollViews = value;
				
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFKitDebugScrollViews");

				Marshal.WriteByte(ptr, Convert.ToByte(kPSPDFKitDebugScrollViews));
			}
		}

		private static bool kPSPDFKitDebugMemory;
		
		public static bool DebugMemory
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFKitDebugMemory");
				
				kPSPDFKitDebugMemory = Convert.ToBoolean(Marshal.ReadByte(ptr));
				
				return kPSPDFKitDebugMemory;
			}
			set 
			{
				kPSPDFKitDebugMemory = value;
				
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFKitDebugMemory");
				
				Marshal.WriteByte(ptr, Convert.ToByte(kPSPDFKitDebugMemory));
			}
		}

		private static float kPSPDFInitialAnnotationLoadDelay;
		
		public static float InitialAnnotationLoadDelay
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				kPSPDFInitialAnnotationLoadDelay = Dlfcn.GetFloat(RTLD_MAIN_ONLY, "kPSPDFInitialAnnotationLoadDelay");
				return kPSPDFInitialAnnotationLoadDelay;
			}
			set 
			{
				kPSPDFInitialAnnotationLoadDelay = value;
				
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFInitialAnnotationLoadDelay");
				
				unsafe 
				{
					float m = kPSPDFInitialAnnotationLoadDelay;
					Marshal.WriteIntPtr(ptr, *(IntPtr*)&m);
				}
			}
		}

		[DllImportAttribute("__Internal", EntryPoint = "PSPDFIsCrappyDevice")]
		[return: MarshalAsAttribute(UnmanagedType.Bool)]
		private static extern bool _IsCrappyDevice();
		
		public static bool IsCrappyDevice
		{
			get 
			{
				return _IsCrappyDevice();
			}
		}

		private static string kPSPDFCacheClassName;
		
		public static string CacheClassName
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				kPSPDFCacheClassName = (string) Dlfcn.GetStringConstant (RTLD_MAIN_ONLY, "kPSPDFCacheClassName");

				return kPSPDFCacheClassName;
			}
			set 
			{
				kPSPDFCacheClassName = value;
				
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFCacheClassName");

				Marshal.WriteIntPtr(ptr, new NSString(kPSPDFCacheClassName).Handle);

			}
		}

		private static string kPSPDFIconGeneratorClassName;
		
		public static string IconGeneratorClassName
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				kPSPDFIconGeneratorClassName = (string) Dlfcn.GetStringConstant (RTLD_MAIN_ONLY, "kPSPDFIconGeneratorClassName");
				
				return kPSPDFIconGeneratorClassName;
			}
			set 
			{
				kPSPDFIconGeneratorClassName = value;
				
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFIconGeneratorClassName");
				
				Marshal.WriteIntPtr(ptr, new NSString(kPSPDFIconGeneratorClassName).Handle);
				
			}
		}

		[DllImportAttribute("__Internal", EntryPoint = "PSPDFVersionString")]
		private static extern IntPtr _VersionString();
		
		public static string VersionString
		{
			get 
			{
				IntPtr ptr = _VersionString();

				string val = (string) (NSString) Runtime.GetNSObject(ptr);

				return val;
			}
		}

		[DllImportAttribute("__Internal", EntryPoint = "PSPDFKitBundle")]
		private static extern IntPtr _PSPDFKitBundle();
		
		public static NSBundle Bundle
		{
			get 
			{
				IntPtr ptr = _PSPDFKitBundle();
				
				NSBundle bundle = (NSBundle) Runtime.GetNSObject(ptr);
				
				return bundle;
			}
		}

		[DllImportAttribute("__Internal", EntryPoint = "PSPDFLocalize")]
		private static extern IntPtr _Localize(IntPtr stringToken);
		
		public static string Localize (string stringToken)
		{
			var strToken = new NSString(stringToken);

			IntPtr ptr = _Localize(strToken.Handle);
			
			string val = (string) (NSString) Runtime.GetNSObject(ptr);
			
			return val;
		}

		[DllImportAttribute("__Internal", EntryPoint = "PSPDFSetLocalizationDictionary")]
		private static extern void _SetLocalizationDictionary(IntPtr localizationDict);
		
		public static void SetLocalizationDictionary (NSDictionary localizationDict)
		{
			_SetLocalizationDictionary(localizationDict.Handle);
		}

		[DllImportAttribute("__Internal", EntryPoint = "PSPDFResolvePathNames")]
		private static extern IntPtr _ResolvePathNames(IntPtr path, IntPtr fallbackPath);
		
		public static string ResolvePathNames (string path, string fallbackPath)
		{
			if(string.IsNullOrEmpty(path))
				throw new ArgumentNullException(path);

			var argPath = new NSString(path);

			IntPtr ptr;

			if (string.IsNullOrEmpty(fallbackPath)) 
				ptr = _ResolvePathNames(argPath.Handle, IntPtr.Zero);

			else
			{
				var argfallbackPath = new NSString(fallbackPath);
				ptr = _ResolvePathNames(argPath.Handle, argfallbackPath.Handle);
			}
			
			string val = (string) (NSString) Runtime.GetNSObject(ptr);
			 
			return val;
		}

		// This needs some extra work since NSMutableString is not bound in monotouch due to it is not needed well until now xD
		//extern BOOL PSPDFResolvePathNamesInMutableString(NSMutableString *mutableString, NSString *fallbackPath, NSString *(^resolveUnknownPathBlock)(NSString *unknownPath));

		private static bool PSPDFResolvePathNamesEnableLegacyBehavior;
		
		public static bool ResolvePathNamesEnableLegacyBehavior
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "PSPDFResolvePathNamesEnableLegacyBehavior");
				
				PSPDFResolvePathNamesEnableLegacyBehavior = Convert.ToBoolean(Marshal.ReadByte(ptr));
				
				return PSPDFResolvePathNamesEnableLegacyBehavior;
			}
			set 
			{
				PSPDFResolvePathNamesEnableLegacyBehavior = value;
				
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "PSPDFResolvePathNamesEnableLegacyBehavior");
				
				Marshal.WriteByte(ptr, Convert.ToByte(PSPDFResolvePathNamesEnableLegacyBehavior));
			}
		}

		[DllImportAttribute("__Internal", EntryPoint = "PSPDFStripPDFFileType")]
		private static extern IntPtr _StripPDFFileType(IntPtr pdfFileName);
		
		public static string StripPDFFileType(string pdfFileName)
		{
			if (string.IsNullOrEmpty(pdfFileName)) 
				return string.Empty;

			IntPtr ptr = _StripPDFFileType( new NSString(pdfFileName).Handle );
			
			string val = (string) (NSString) Runtime.GetNSObject(ptr);
			
			return val;
		}

		[DllImportAttribute("__Internal", EntryPoint = "PSPDFGetViewInsideView")]
		private static extern IntPtr _GetViewInsideView(IntPtr view, IntPtr classNamePrefix);
		
		public static UIView GetViewInsideView(UIView view, string classNamePrefix)
		{
			if (string.IsNullOrEmpty(classNamePrefix)) 
				throw new ArgumentException("Agument classNamePrefix cannot be null or Empty");

			if(view == null)
				throw new ArgumentNullException("view");

			
			IntPtr ptr = _GetViewInsideView(view.Handle, new NSString(classNamePrefix).Handle );
			
			UIView val = (UIView) Runtime.GetNSObject(ptr);
			
			return val;
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

