using System;
using MonoTouch.CoreGraphics;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using System.Drawing;
using MonoTouch.UIKit;
using System.Runtime.InteropServices;
using MonoTouch.CoreAnimation;
using System.Collections.Generic;

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

		private static bool kPSPDFLowMemoryMode;
		
		public static bool PSPDFLowMemoryMode
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFLowMemoryMode");
				
				kPSPDFLowMemoryMode = Convert.ToBoolean(Marshal.ReadByte(ptr));
				
				return kPSPDFLowMemoryMode;
			}
			set 
			{
				kPSPDFLowMemoryMode = value;
				
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFLowMemoryMode");
				
				Marshal.WriteByte(ptr, Convert.ToByte(kPSPDFLowMemoryMode));
			}
		}

		private static float kPSPDFAnimationDuration;
		
		public static float AnimationDuration
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				kPSPDFAnimationDuration = Dlfcn.GetFloat(RTLD_MAIN_ONLY, "kPSPDFAnimationDuration");
				return kPSPDFAnimationDuration;
			}
			set 
			{
				kPSPDFAnimationDuration = value;
				
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFAnimationDuration");

				unsafe 
				{
					float m = kPSPDFAnimationDuration;
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

		//Removed kPSPDFKitDebugScrollViews on version 2.3.1
//		private static bool kPSPDFKitDebugScrollViews;
//
//		public static bool DebugScrollViews
//		{
//			get 
//			{
//				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
//				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFKitDebugScrollViews");
//
//				kPSPDFKitDebugScrollViews = Convert.ToBoolean(Marshal.ReadByte(ptr));
//				
//				return kPSPDFKitDebugScrollViews;
//			}
//			set 
//			{
//				kPSPDFKitDebugScrollViews = value;
//				
//				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
//				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFKitDebugScrollViews");
//
//				Marshal.WriteByte(ptr, Convert.ToByte(kPSPDFKitDebugScrollViews));
//			}
//		}
//
//		private static bool kPSPDFKitDebugMemory;
//		
//		public static bool DebugMemory
//		{
//			get 
//			{
//				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
//				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFKitDebugMemory");
//				
//				kPSPDFKitDebugMemory = Convert.ToBoolean(Marshal.ReadByte(ptr));
//				
//				return kPSPDFKitDebugMemory;
//			}
//			set 
//			{
//				kPSPDFKitDebugMemory = value;
//				
//				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
//				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFKitDebugMemory");
//				
//				Marshal.WriteByte(ptr, Convert.ToByte(kPSPDFKitDebugMemory));
//			}
//		}

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

		[DllImportAttribute("__Internal", EntryPoint = "PSPDFSimulatorAnimationDragCoefficient")]
		private static extern IntPtr _SimulatorAnimationDragCoefficient();
		
		public static float SimulatorAnimationDragCoefficient
		{
			get 
			{
				IntPtr intPtr = _SimulatorAnimationDragCoefficient();

				unsafe {
					float* ptr = (float*)((void*)intPtr);
					return *ptr;
				}

			}
		}

		[DllImportAttribute("__Internal", EntryPoint = "PSPDFFadeTransition")]
		private static extern IntPtr _FadeTransition();
		
		public static CATransition FadeTransition
		{
			get 
			{
				IntPtr intPtr = _SimulatorAnimationDragCoefficient();
				
				CATransition t = (CATransition) Runtime.GetNSObject(intPtr);

				return t;
			}
		}

		[DllImportAttribute("__Internal", EntryPoint = "PSPDFFadeTransitionWithDuration")]
		private static extern IntPtr _FadeTransitionWithDuration(IntPtr duration);
		
		public static CATransition FadeTransitionWithDuration(float duration)
		{
			unsafe 
			{
				float m = duration;
				IntPtr intPtr = _FadeTransitionWithDuration(*(IntPtr*)&m);

				CATransition t = (CATransition) Runtime.GetNSObject(intPtr);
				return t;
			}
		}

		[DllImportAttribute("__Internal", EntryPoint = "PSPDPFActionSheetStyleForBarButtonStyle")]
		private static extern int _ActionSheetStyleForBarButtonStyle(int barStyle, byte translucent);
		
		public static UIActionSheetStyle ActionSheetStyleForBarButtonStyle(UIBarStyle barStyle, bool translucent)
		{
			return (UIActionSheetStyle) _ActionSheetStyleForBarButtonStyle((int) barStyle, Convert.ToByte(translucent));
		}

		[DllImportAttribute("__Internal", EntryPoint = "PSPDFToolbarHeightForOrientation")]
		private static extern IntPtr _ToolbarHeightForOrientation(int orientation);
		
		public static float ToolbarHeightForOrientation(UIInterfaceOrientation orientation)
		{

			IntPtr intPtr = _ToolbarHeightForOrientation((int)orientation);
			
			unsafe {
				float* ptr = (float*)((void*)intPtr);
				return *ptr;
			}
		}

		[DllImportAttribute("__Internal", EntryPoint = "PSPDFToolbarHeight")]
		private static extern IntPtr _ToolbarHeight(byte isSmall);
		
		public static float ToolbarHeight(bool isSmall)
		{
			
			IntPtr intPtr = _ToolbarHeight(Convert.ToByte(isSmall));
			
			unsafe {
				float* ptr = (float*)((void*)intPtr);
				return *ptr;
			}
		}

		[DllImportAttribute("__Internal", EntryPoint = "psrangef")]
		private static extern IntPtr _psrangef(IntPtr minRange, IntPtr value, IntPtr maxRange);
		
		public static float PSRangeF(float minRange, float value, float maxRange)
		{
			
			unsafe 
			{
				float _minRange = minRange;
				float _value = value;
				float _maxRange = maxRange;

				IntPtr pointer = _psrangef(*(IntPtr*)&_minRange, *(IntPtr*)&_value, *(IntPtr*)&_maxRange);

				float* ptr = (float*)((void*)pointer);
				return *ptr;
			}
		}

		[DllImportAttribute("__Internal", EntryPoint = "PSPDFTrimString")]
		private static extern IntPtr _TrimString(IntPtr theString);
		
		public static string TrimString(string theString)
		{
			if (string.IsNullOrEmpty(theString)) 
				return string.Empty;
			
			IntPtr ptr = _TrimString( new NSString(theString).Handle );
			
			string val = (string) (NSString) Runtime.GetNSObject(ptr);
			
			return val;
		}


		[DllImportAttribute("__Internal", EntryPoint = "PSPDFIsControllerClassInPopover")]
		private static extern IntPtr _IsControllerClassInPopover(IntPtr popoverController, IntPtr controllerClass);
		
		public static bool IsControllerClassInPopover(UIPopoverController popoverController, Class controllerClass)
		{
			IntPtr ptr = _IsControllerClassInPopover(popoverController.Handle, controllerClass.Handle);
			return Convert.ToBoolean(Marshal.ReadByte(ptr));
		}

		[DllImportAttribute("__Internal", EntryPoint = "PSPDFIndexSetFromArray")]
		private static extern IntPtr _IndexSetFromArray(IntPtr array);
		
		public static NSIndexSet IndexSetFromArray(NSNumber [] array)
		{
			List<NSObject> obj = new List<NSObject>();

			foreach (var item in array)
				obj.Add(item);

			NSArray arr = NSArray.FromNSObjects(obj.ToArray());

			return new NSIndexSet(_IndexSetFromArray(arr.Handle));
		}

		[DllImportAttribute("__Internal", EntryPoint = "PSPDFCacheKeyboard")]
		private static extern void _CacheKeyboard();
		
		public static void CacheKeyboard()
		{
			_CacheKeyboard();
		}

		[DllImportAttribute("__Internal", EntryPoint = "PSPDFIsRotationLocked")]
		[return: MarshalAsAttribute(UnmanagedType.Bool)]
		private static extern bool _IsRotationLocked();

		[Since(6,0)]
		public static bool IsRotationLocked
		{
			get 
			{
				return _IsRotationLocked();
			}
		}

		[DllImportAttribute("__Internal", EntryPoint = "PSPDFLockRotation")]
		private static extern void _LockRotation();

		[Since(6,0)]
		public static void LockRotation()
		{
			_LockRotation();
		}

		[DllImportAttribute("__Internal", EntryPoint = "PSPDFUnlockRotation")]
		private static extern void _UnlockRotation();
		
		[Since(6,0)]
		public static void UnlockRotation()
		{
			_UnlockRotation();
		}

		[DllImportAttribute("__Internal", EntryPoint = "PSPDFTempFileURLWithPathExtension")]
		private static extern IntPtr PSPDFTempFileURLWithPathExtension(IntPtr prefix, IntPtr pathExtension);
		
		public static NSUrl TempFileURLWithPathExtension(string prefix, string pathExtension)
		{
			NSString pref = new NSString(prefix);
			NSString path = new NSString(pathExtension);

			NSUrl url = new NSUrl(PSPDFTempFileURLWithPathExtension(pref.Handle, path.Handle));
			
			return url;
		}
	}

	//////////////////////////////////////////
	////		PSPDFGlobalLock.h			//
	//////////////////////////////////////////
	public partial class PSPDFGlobalLock : NSObject
	{
		public CGPDFPage TryLockWithDocumentPageError (PSPDFDocument document, uint page, out NSError error)
		{
			IntPtr ptr = TryLockWithDocumentPageError_ (document, page, out error);
			return new CGPDFPage(ptr);
		}

		public CGPDFPage LockWithDocumentPageError (PSPDFDocument document, uint page, out NSError error)
		{
			IntPtr ptr = LockWithDocumentPageError_ (document, page, out error);
			return new CGPDFPage(ptr);
		}

		public void FreeWithPDFPageRef (CGPDFPage pdfPage)
		{
			_FreeWithPDFPageRef(pdfPage.Handle, true);
		}
	}

	//////////////////////////////////////
	////		PSPDFGlyph.h			//
	//////////////////////////////////////
	public partial class PSPDFGlyph : NSObject
	{
		[DllImportAttribute("__Internal", EntryPoint = "PSPDFRectsFromGlyphs")]
		private static extern RectangleF [] _RectsFromGlyphs(IntPtr glyphs, CGAffineTransform t, RectangleF boundingBox);
		
		public static RectangleF [] RectsFromGlyphs(PSPDFGlyph [] glyphs, CGAffineTransform t, RectangleF boundingBox)
		{
			var objs = new List<NSObject>();

			foreach (var glyph in glyphs)
				objs.Add(glyph);

			NSArray arry = NSArray.FromNSObjects(objs.ToArray());
			return _RectsFromGlyphs(arry.Handle, t, boundingBox);
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

		[DllImportAttribute("__Internal", EntryPoint = "PSPDFTypeStringFromAnnotationType")]
		private static extern IntPtr _StringFromAnnotationType(PSPDFAnnotationType annotationType);
		
		public static string StringFromAnnotationType(PSPDFAnnotationType annotationType)
		{			
			IntPtr ptr = _StringFromAnnotationType(annotationType);
			
			string val = (string) (NSString) Runtime.GetNSObject(ptr);
			
			return val;
		}
	}
	
	//////////////////////////////////////////
	////		PSPDFTextParser.h			//
	//////////////////////////////////////////
	
	public partial class PSPDFTextParser : NSObject
	{
		public PSPDFTextParser (CGPDFPage pageRef, uint page, PSPDFDocument document, NSMutableDictionary fontCache, bool hideGlyphsOutsidePageRect, CGPDFBox PDFBox) : this(pageRef.Handle, page, document, fontCache, hideGlyphsOutsidePageRect, PDFBox)
		{
		}

		//Removed on version 2.3.1
//		private static bool kPSPDFTextParserDebugLogEnabled;
//		
//		public static bool DebugLogEnabled
//		{
//			get 
//			{
//				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
//				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFTextParserDebugLogEnabled");
//				
//				kPSPDFTextParserDebugLogEnabled = Convert.ToBoolean(Marshal.ReadByte(ptr));
//				
//				return kPSPDFTextParserDebugLogEnabled;
//			}
//			set 
//			{
//				kPSPDFTextParserDebugLogEnabled = value;
//				
//				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
//				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFTextParserDebugLogEnabled");
//				
//				Marshal.WriteByte(ptr, Convert.ToByte(kPSPDFTextParserDebugLogEnabled));
//			}
//		}
	}
	
	//////////////////////////////////////////////
	////		PSPDFInkAnnotation.h			//
	//////////////////////////////////////////////
	
	public partial class PSPDFInkAnnotation : PSPDFAnnotation
	{
		[DllImportAttribute("__Internal", EntryPoint = "PSPDFBezierPathGetPoints")]
		private static extern  IntPtr _PSPDFBezierPathGetPoints(IntPtr path);
		
		public static NSArray PSPDFBezierPathGetPoints(UIBezierPath path)
		{
			return new NSArray(_PSPDFBezierPathGetPoints(path.Handle));
		}
	}
	
	//////////////////////////////////////////////////
	////		PSPDFHighlightAnnotation.h			//
	//////////////////////////////////////////////////
	
	public partial class PSPDFHighlightAnnotation : PSPDFAnnotation
	{

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

		public CGDataProvider DataProvider
		{
			get 
			{
				IntPtr ptr = this.DataProvider_;
				return new CGDataProvider(ptr);
			}
		}

		// Replaced with [Fields] now this are const
//		private static string kPSPDFObjectsText;
//		
//		public static string ObjectsText
//		{
//			get 
//			{
//				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
//				kPSPDFObjectsText = (string) Dlfcn.GetStringConstant (RTLD_MAIN_ONLY, "kPSPDFObjectsText");
//				
//				return kPSPDFObjectsText;
//			}
//		}
//
//		private static string kPSPDFObjectsFullWords;
//		
//		public static string ObjectsFullWords
//		{
//			get 
//			{
//				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
//				kPSPDFObjectsFullWords = (string) Dlfcn.GetStringConstant (RTLD_MAIN_ONLY, "kPSPDFObjectsFullWords");
//				
//				return kPSPDFObjectsFullWords;
//			}
//		}
//
//		private static string kPSPDFObjectsRespectTextBlocks;
//		
//		public static string ObjectsRespectTextBlocks
//		{
//			get 
//			{
//				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
//				kPSPDFObjectsRespectTextBlocks = (string) Dlfcn.GetStringConstant (RTLD_MAIN_ONLY, "kPSPDFObjectsRespectTextBlocks");
//				
//				return kPSPDFObjectsRespectTextBlocks;
//			}
//		}
//
//		private static string kPSPDFObjectsAnnotations;
//		
//		public static string ObjectsAnnotations
//		{
//			get 
//			{
//				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
//				kPSPDFObjectsAnnotations = (string) Dlfcn.GetStringConstant (RTLD_MAIN_ONLY, "kPSPDFObjectsAnnotations");
//				
//				return kPSPDFObjectsAnnotations;
//			}
//			set 
//			{
//				kPSPDFObjectsAnnotations = value;
//				
//				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
//				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFObjectsAnnotations");
//				
//				Marshal.WriteIntPtr(ptr, new NSString(kPSPDFObjectsAnnotations).Handle);
//				
//			}
//		}
//
//		private static string kPSPDFGlyphs;
//		
//		public static string Glyphs
//		{
//			get 
//			{
//				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
//				kPSPDFGlyphs = (string) Dlfcn.GetStringConstant (RTLD_MAIN_ONLY, "kPSPDFGlyphs");
//				
//				return kPSPDFGlyphs;
//			}
//			set 
//			{
//				kPSPDFGlyphs = value;
//				
//				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
//				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFGlyphs");
//				
//				Marshal.WriteIntPtr(ptr, new NSString(kPSPDFGlyphs).Handle);
//				
//			}
//		}
//
//		private static string kPSPDFWords;
//		
//		public static string Words
//		{
//			get 
//			{
//				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
//				kPSPDFWords = (string) Dlfcn.GetStringConstant (RTLD_MAIN_ONLY, "kPSPDFWords");
//				
//				return kPSPDFWords;
//			}
//			set 
//			{
//				kPSPDFWords = value;
//				
//				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
//				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFWords");
//				
//				Marshal.WriteIntPtr(ptr, new NSString(kPSPDFWords).Handle);
//				
//			}
//		}
//
//		private static string kPSPDFTextBlocks;
//		
//		public static string TextBlocks
//		{
//			get 
//			{
//				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
//				kPSPDFTextBlocks = (string) Dlfcn.GetStringConstant (RTLD_MAIN_ONLY, "kPSPDFTextBlocks");
//				
//				return kPSPDFTextBlocks;
//			}
//			set 
//			{
//				kPSPDFTextBlocks = value;
//				
//				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
//				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFTextBlocks");
//				
//				Marshal.WriteIntPtr(ptr, new NSString(kPSPDFTextBlocks).Handle);
//				
//			}
//		}
//
//		private static string kPSPDFAnnotations;
//		
//		public static string Annotations
//		{
//			get 
//			{
//				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
//				kPSPDFAnnotations = (string) Dlfcn.GetStringConstant (RTLD_MAIN_ONLY, "kPSPDFAnnotations");
//				
//				return kPSPDFAnnotations;
//			}
//			set 
//			{
//				kPSPDFAnnotations = value;
//				
//				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
//				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFAnnotations");
//				
//				Marshal.WriteIntPtr(ptr, new NSString(kPSPDFAnnotations).Handle);
//				
//			}
//		}
	}
	
	//////////////////////////////////////////////
	////		PSPDFDocumentProvider.h			//
	//////////////////////////////////////////////
	
	public partial class PSPDFDocumentProvider : NSObject
	{
		public PSPDFDocumentProvider (CGDataProvider dataProvider, PSPDFDocument document) : this (dataProvider.Handle, document)
		{
			
		}
		
		public CGPDFDocument RequestDocumentRefWithOwner (NSObject owner)
		{
			return new CGPDFDocument(RequestDocumentRefWithOwner_ (owner));
		}
		
		public void ReleaseDocumentRef (CGPDFDocument documentRef, NSObject owner)
		{
			ReleaseDocumentRef_ (documentRef.Handle, owner);
		}
		
		public void ReleasePageRef (CGPDFPage pageRef)
		{
			ReleasePageRef_ (pageRef.Handle);
		}

		public CGPDFPage RequestPageRefForPageNumber (uint page, out NSError error)
		{
			IntPtr ptr = RequestPageRefForPageNumber_ (page, out error);
			return new CGPDFPage(ptr);
		}	

		public CGPDFPage RequestPageRefForPageNumber (uint page)
		{
			IntPtr ptr = RequestPageRefForPageNumber_ (page);
			return new CGPDFPage(ptr);
		}	

		public CGDataProvider DataProvider
		{
			get 
			{
				IntPtr ptr = this.DataProvider_;
				return new CGDataProvider(ptr);
			}
		}

		PSPDFPageInfo PageInfoForPage (uint page, CGPDFPage pageRef)
		{
			return PageInfoForPage_ (page, pageRef.Handle);
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
		private static SizeF kPSPDFNoteAnnotationViewFixedSize;
		
		public static SizeF PSPDFNoteAnnotationViewFixedSize
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				kPSPDFNoteAnnotationViewFixedSize = Dlfcn.GetSizeF(RTLD_MAIN_ONLY, "kPSPDFNoteAnnotationViewFixedSize");
				
				return kPSPDFNoteAnnotationViewFixedSize;
			}
			set 
			{
				kPSPDFNoteAnnotationViewFixedSize = value;

				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym(RTLD_MAIN_ONLY, "kPSPDFNoteAnnotationViewFixedSize");
				Marshal.StructureToPtr((object) kPSPDFNoteAnnotationViewFixedSize, ptr, true);
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

		private static string kPSPDFCachedRenderRequest;
		
		public static string CachedRenderRequest
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				kPSPDFCachedRenderRequest = (string) Dlfcn.GetStringConstant (RTLD_MAIN_ONLY, "kPSPDFCachedRenderRequest");
				
				return kPSPDFCachedRenderRequest;
			}
			set 
			{
				kPSPDFCachedRenderRequest = value;
				
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFCachedRenderRequest");
				
				Marshal.WriteIntPtr(ptr, new NSString(kPSPDFCachedRenderRequest).Handle);	
			}
		}
	}

	//////////////////////////////////////////
	////		PSPDFRenderQueue.h			//
	//////////////////////////////////////////
	
	public partial class PSPDFRenderQueue : NSObject
	{	
		private static string kPSPDFAnnotationAutoFetchTypes;
		
		public static string PSPDFAnnotationAutoFetchTypes
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				kPSPDFAnnotationAutoFetchTypes = (string) Dlfcn.GetStringConstant (RTLD_MAIN_ONLY, "kPSPDFAnnotationAutoFetchTypes");
				
				return kPSPDFAnnotationAutoFetchTypes;
			}
			set 
			{
				kPSPDFAnnotationAutoFetchTypes = value;
				
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFAnnotationAutoFetchTypes");
				
				Marshal.WriteIntPtr(ptr, new NSString(kPSPDFAnnotationAutoFetchTypes).Handle);	
			}
		}
	}
	
	//////////////////////////////////////////
	////		PSPDFPageRenderer.h			//
	//////////////////////////////////////////
	
	public partial class PSPDFPageRenderer : NSObject
	{

		public static void SetupGraphicsContext (CGContext context, RectangleF displayRectangle, PSPDFPageInfo pageInfo)
		{
			SetupGraphicsContext_ (context.Handle, displayRectangle, pageInfo);
		}

		public static RectangleF RenderPage (CGPDFPage page, CGContext context, RectangleF rectangle, PSPDFPageInfo pageInfo, PSPDFAnnotation[] annotations, NSDictionary options)
		{
			return RenderPage_ (page.Handle, context.Handle, rectangle, pageInfo, annotations, options);
		}
		
		public static SizeF RenderPage (CGPDFPage page, CGContext context, PointF point, float zoom, PSPDFPageInfo pageInfo, PSPDFAnnotation[] annotations, NSDictionary options)
		{
			return RenderPage_ (page.Handle, context.Handle, point, zoom, pageInfo, annotations, options);
		}
	}

	//////////////////////////////////////////////////
	////		PSPDFWebViewController.h			//
	//////////////////////////////////////////////////
	
	public partial class PSPDFWebViewController : PSPDFBaseViewController
	{
		private static bool PSPDFHonorBlackAndTranslucentSettingsOnWebViewController;
		
		public static bool HonorBlackAndTranslucentSettingsOnWebViewController
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "PSPDFHonorBlackAndTranslucentSettingsOnWebViewController");
				
				PSPDFHonorBlackAndTranslucentSettingsOnWebViewController = Convert.ToBoolean(Marshal.ReadByte(ptr));
				
				return PSPDFHonorBlackAndTranslucentSettingsOnWebViewController;
			}
			set 
			{
				PSPDFHonorBlackAndTranslucentSettingsOnWebViewController = value;
				
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "PSPDFHonorBlackAndTranslucentSettingsOnWebViewController");
				
				Marshal.WriteByte(ptr, Convert.ToByte(PSPDFHonorBlackAndTranslucentSettingsOnWebViewController));
			}
		}	
	}

	//////////////////////////////////////////////////
	////		PSPDFSearchViewController.h			//
	//////////////////////////////////////////////////
	
	public partial class PSPDFSearchViewController : UITableViewController
	{
		private static uint kPSPDFMinimumSearchLength;
		
		public static uint MinimumSearchLength
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFMinimumSearchLength");
				kPSPDFMinimumSearchLength = (uint)Marshal.PtrToStructure(ptr, typeof(uint));

				return kPSPDFMinimumSearchLength;
			}
			set 
			{
				kPSPDFMinimumSearchLength = value;

				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFMinimumSearchLength");
				byte [] data = BitConverter.GetBytes(kPSPDFMinimumSearchLength);
				Marshal.Copy(data, 0, ptr, data.Length); 
			}
		}
	}

	//////////////////////////////////////////////////////
	////		PSPDFAESCryptoDataProvider.h			//
	//////////////////////////////////////////////////////
	
	public partial class PSPDFAESCryptoDataProvider : NSObject
	{
		public CGDataProvider DataProvider {
			get 
			{
				return new CGDataProvider(DataProviderRef_());
			}
		}

		public bool isAESCryptoDataProvider (CGDataProvider dataProvider)
		{
			return IsAESCryptoDataProvider_ (dataProvider.Handle);
		}
	}

	//////////////////////////////////////////////////////
	////		PSPDFFileAnnotationProvider.h			//
	//////////////////////////////////////////////////////
	
	public partial class PSPDFFileAnnotationProvider : NSObject
	{		
<<<<<<< OURS
		// rr: This should be virtual in order to be able to override it.
=======
>>>>>>> THEIRS
		public virtual PSPDFAnnotation [] AnnotationsForPage (uint page, CGPDFPage pageRef)
		{
			return AnnotationsForPage_ (page, pageRef.Handle);
		}
	}

	//////////////////////////////////////////////////
	////		PSPDFOpenInBarButtonItem.h			//
	//////////////////////////////////////////////////
	
	public partial class PSPDFOpenInBarButtonItem : PSPDFBarButtonItem
	{		
		private static bool kPSPDFCheckIfCompatibleAppsAreInstalled;
		
		public static bool CheckIfCompatibleAppsAreInstalled
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFCheckIfCompatibleAppsAreInstalled");
				
				kPSPDFCheckIfCompatibleAppsAreInstalled = Convert.ToBoolean(Marshal.ReadByte(ptr));
				
				return kPSPDFCheckIfCompatibleAppsAreInstalled;
			}
			set 
			{
				kPSPDFCheckIfCompatibleAppsAreInstalled = value;
				
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kPSPDFCheckIfCompatibleAppsAreInstalled");
				
				Marshal.WriteByte(ptr, Convert.ToByte(kPSPDFCheckIfCompatibleAppsAreInstalled));
			}
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

