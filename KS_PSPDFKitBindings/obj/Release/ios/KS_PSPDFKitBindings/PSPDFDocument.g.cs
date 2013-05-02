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
	[Register("PSPDFDocument", true)]
	public unsafe partial class PSPDFDocument : NSObject {
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selRenderAnnotationTypes = "renderAnnotationTypes";
		static readonly IntPtr selRenderAnnotationTypesHandle = Selector.GetHandle ("renderAnnotationTypes");
		[CompilerGenerated]
		const string selSetRenderAnnotationTypes_ = "setRenderAnnotationTypes:";
		static readonly IntPtr selSetRenderAnnotationTypes_Handle = Selector.GetHandle ("setRenderAnnotationTypes:");
		[CompilerGenerated]
		const string selFileNamesWithDataDictionary = "fileNamesWithDataDictionary";
		static readonly IntPtr selFileNamesWithDataDictionaryHandle = Selector.GetHandle ("fileNamesWithDataDictionary");
		[CompilerGenerated]
		const string selBasePath = "basePath";
		static readonly IntPtr selBasePathHandle = Selector.GetHandle ("basePath");
		[CompilerGenerated]
		const string selSetBasePath_ = "setBasePath:";
		static readonly IntPtr selSetBasePath_Handle = Selector.GetHandle ("setBasePath:");
		[CompilerGenerated]
		const string selFiles = "files";
		static readonly IntPtr selFilesHandle = Selector.GetHandle ("files");
		[CompilerGenerated]
		const string selSetFiles_ = "setFiles:";
		static readonly IntPtr selSetFiles_Handle = Selector.GetHandle ("setFiles:");
		[CompilerGenerated]
		const string selFileURL = "fileURL";
		static readonly IntPtr selFileURLHandle = Selector.GetHandle ("fileURL");
		[CompilerGenerated]
		const string selSetFileURL_ = "setFileURL:";
		static readonly IntPtr selSetFileURL_Handle = Selector.GetHandle ("setFileURL:");
		[CompilerGenerated]
		const string selData = "data";
		static readonly IntPtr selDataHandle = Selector.GetHandle ("data");
		[CompilerGenerated]
		const string selDataArray = "dataArray";
		static readonly IntPtr selDataArrayHandle = Selector.GetHandle ("dataArray");
		[CompilerGenerated]
		const string selDataProvider = "dataProvider";
		static readonly IntPtr selDataProviderHandle = Selector.GetHandle ("dataProvider");
		[CompilerGenerated]
		const string selTitle = "title";
		static readonly IntPtr selTitleHandle = Selector.GetHandle ("title");
		[CompilerGenerated]
		const string selSetTitle_ = "setTitle:";
		static readonly IntPtr selSetTitle_Handle = Selector.GetHandle ("setTitle:");
		[CompilerGenerated]
		const string selIsTitleLoaded = "isTitleLoaded";
		static readonly IntPtr selIsTitleLoadedHandle = Selector.GetHandle ("isTitleLoaded");
		[CompilerGenerated]
		const string selMetadata = "metadata";
		static readonly IntPtr selMetadataHandle = Selector.GetHandle ("metadata");
		[CompilerGenerated]
		const string selUID = "UID";
		static readonly IntPtr selUIDHandle = Selector.GetHandle ("UID");
		[CompilerGenerated]
		const string selSetUID_ = "setUID:";
		static readonly IntPtr selSetUID_Handle = Selector.GetHandle ("setUID:");
		[CompilerGenerated]
		const string selIsAnnotationsEnabled = "isAnnotationsEnabled";
		static readonly IntPtr selIsAnnotationsEnabledHandle = Selector.GetHandle ("isAnnotationsEnabled");
		[CompilerGenerated]
		const string selSetAnnotationsEnabled_ = "setAnnotationsEnabled:";
		static readonly IntPtr selSetAnnotationsEnabled_Handle = Selector.GetHandle ("setAnnotationsEnabled:");
		[CompilerGenerated]
		const string selEditableAnnotationTypes = "editableAnnotationTypes";
		static readonly IntPtr selEditableAnnotationTypesHandle = Selector.GetHandle ("editableAnnotationTypes");
		[CompilerGenerated]
		const string selSetEditableAnnotationTypes_ = "setEditableAnnotationTypes:";
		static readonly IntPtr selSetEditableAnnotationTypes_Handle = Selector.GetHandle ("setEditableAnnotationTypes:");
		[CompilerGenerated]
		const string selCanEmbedAnnotations = "canEmbedAnnotations";
		static readonly IntPtr selCanEmbedAnnotationsHandle = Selector.GetHandle ("canEmbedAnnotations");
		[CompilerGenerated]
		const string selAnnotationSaveMode = "annotationSaveMode";
		static readonly IntPtr selAnnotationSaveModeHandle = Selector.GetHandle ("annotationSaveMode");
		[CompilerGenerated]
		const string selSetAnnotationSaveMode_ = "setAnnotationSaveMode:";
		static readonly IntPtr selSetAnnotationSaveMode_Handle = Selector.GetHandle ("setAnnotationSaveMode:");
		[CompilerGenerated]
		const string selDefaultAnnotationUsername = "defaultAnnotationUsername";
		static readonly IntPtr selDefaultAnnotationUsernameHandle = Selector.GetHandle ("defaultAnnotationUsername");
		[CompilerGenerated]
		const string selSetDefaultAnnotationUsername_ = "setDefaultAnnotationUsername:";
		static readonly IntPtr selSetDefaultAnnotationUsername_Handle = Selector.GetHandle ("setDefaultAnnotationUsername:");
		[CompilerGenerated]
		const string selHasDirtyAnnotations = "hasDirtyAnnotations";
		static readonly IntPtr selHasDirtyAnnotationsHandle = Selector.GetHandle ("hasDirtyAnnotations");
		[CompilerGenerated]
		const string selAnnotationParser = "annotationParser";
		static readonly IntPtr selAnnotationParserHandle = Selector.GetHandle ("annotationParser");
		[CompilerGenerated]
		const string selPageCount = "pageCount";
		static readonly IntPtr selPageCountHandle = Selector.GetHandle ("pageCount");
		[CompilerGenerated]
		const string selPageRange = "pageRange";
		static readonly IntPtr selPageRangeHandle = Selector.GetHandle ("pageRange");
		[CompilerGenerated]
		const string selSetPageRange_ = "setPageRange:";
		static readonly IntPtr selSetPageRange_Handle = Selector.GetHandle ("setPageRange:");
		[CompilerGenerated]
		const string selPDFBox = "PDFBox";
		static readonly IntPtr selPDFBoxHandle = Selector.GetHandle ("PDFBox");
		[CompilerGenerated]
		const string selSetPDFBox_ = "setPDFBox:";
		static readonly IntPtr selSetPDFBox_Handle = Selector.GetHandle ("setPDFBox:");
		[CompilerGenerated]
		const string selCacheDirectory = "cacheDirectory";
		static readonly IntPtr selCacheDirectoryHandle = Selector.GetHandle ("cacheDirectory");
		[CompilerGenerated]
		const string selSetCacheDirectory_ = "setCacheDirectory:";
		static readonly IntPtr selSetCacheDirectory_Handle = Selector.GetHandle ("setCacheDirectory:");
		[CompilerGenerated]
		const string selCacheStrategy = "cacheStrategy";
		static readonly IntPtr selCacheStrategyHandle = Selector.GetHandle ("cacheStrategy");
		[CompilerGenerated]
		const string selSetCacheStrategy_ = "setCacheStrategy:";
		static readonly IntPtr selSetCacheStrategy_Handle = Selector.GetHandle ("setCacheStrategy:");
		[CompilerGenerated]
		const string selIsAspectRatioEqual = "isAspectRatioEqual";
		static readonly IntPtr selIsAspectRatioEqualHandle = Selector.GetHandle ("isAspectRatioEqual");
		[CompilerGenerated]
		const string selSetAspectRatioEqual_ = "setAspectRatioEqual:";
		static readonly IntPtr selSetAspectRatioEqual_Handle = Selector.GetHandle ("setAspectRatioEqual:");
		[CompilerGenerated]
		const string selDisplayingPdfController = "displayingPdfController";
		static readonly IntPtr selDisplayingPdfControllerHandle = Selector.GetHandle ("displayingPdfController");
		[CompilerGenerated]
		const string selSetDisplayingPdfController_ = "setDisplayingPdfController:";
		static readonly IntPtr selSetDisplayingPdfController_Handle = Selector.GetHandle ("setDisplayingPdfController:");
		[CompilerGenerated]
		const string selDisplayingPage = "displayingPage";
		static readonly IntPtr selDisplayingPageHandle = Selector.GetHandle ("displayingPage");
		[CompilerGenerated]
		const string selPassword = "password";
		static readonly IntPtr selPasswordHandle = Selector.GetHandle ("password");
		[CompilerGenerated]
		const string selSetPassword_ = "setPassword:";
		static readonly IntPtr selSetPassword_Handle = Selector.GetHandle ("setPassword:");
		[CompilerGenerated]
		const string selIsValid = "isValid";
		static readonly IntPtr selIsValidHandle = Selector.GetHandle ("isValid");
		[CompilerGenerated]
		const string selAllowsPrinting = "allowsPrinting";
		static readonly IntPtr selAllowsPrintingHandle = Selector.GetHandle ("allowsPrinting");
		[CompilerGenerated]
		const string selIsEncrypted = "isEncrypted";
		static readonly IntPtr selIsEncryptedHandle = Selector.GetHandle ("isEncrypted");
		[CompilerGenerated]
		const string selEncryptionFilter = "encryptionFilter";
		static readonly IntPtr selEncryptionFilterHandle = Selector.GetHandle ("encryptionFilter");
		[CompilerGenerated]
		const string selIsLocked = "isLocked";
		static readonly IntPtr selIsLockedHandle = Selector.GetHandle ("isLocked");
		[CompilerGenerated]
		const string selAllowsCopying = "allowsCopying";
		static readonly IntPtr selAllowsCopyingHandle = Selector.GetHandle ("allowsCopying");
		[CompilerGenerated]
		const string selSetAllowsCopying_ = "setAllowsCopying:";
		static readonly IntPtr selSetAllowsCopying_Handle = Selector.GetHandle ("setAllowsCopying:");
		[CompilerGenerated]
		const string selIsBookmarksEnabled = "isBookmarksEnabled";
		static readonly IntPtr selIsBookmarksEnabledHandle = Selector.GetHandle ("isBookmarksEnabled");
		[CompilerGenerated]
		const string selSetBookmarksEnabled_ = "setBookmarksEnabled:";
		static readonly IntPtr selSetBookmarksEnabled_Handle = Selector.GetHandle ("setBookmarksEnabled:");
		[CompilerGenerated]
		const string selPageLabelsEnabled = "pageLabelsEnabled";
		static readonly IntPtr selPageLabelsEnabledHandle = Selector.GetHandle ("pageLabelsEnabled");
		[CompilerGenerated]
		const string selSetPageLabelsEnabled_ = "setPageLabelsEnabled:";
		static readonly IntPtr selSetPageLabelsEnabled_Handle = Selector.GetHandle ("setPageLabelsEnabled:");
		[CompilerGenerated]
		const string selAllowedMenuActions = "allowedMenuActions";
		static readonly IntPtr selAllowedMenuActionsHandle = Selector.GetHandle ("allowedMenuActions");
		[CompilerGenerated]
		const string selSetAllowedMenuActions_ = "setAllowedMenuActions:";
		static readonly IntPtr selSetAllowedMenuActions_Handle = Selector.GetHandle ("setAllowedMenuActions:");
		[CompilerGenerated]
		const string selTextSearch = "textSearch";
		static readonly IntPtr selTextSearchHandle = Selector.GetHandle ("textSearch");
		[CompilerGenerated]
		const string selSetTextSearch_ = "setTextSearch:";
		static readonly IntPtr selSetTextSearch_Handle = Selector.GetHandle ("setTextSearch:");
		[CompilerGenerated]
		const string selOutlineParser = "outlineParser";
		static readonly IntPtr selOutlineParserHandle = Selector.GetHandle ("outlineParser");
		[CompilerGenerated]
		const string selBookmarkParser = "bookmarkParser";
		static readonly IntPtr selBookmarkParserHandle = Selector.GetHandle ("bookmarkParser");
		[CompilerGenerated]
		const string selSetBookmarkParser_ = "setBookmarkParser:";
		static readonly IntPtr selSetBookmarkParser_Handle = Selector.GetHandle ("setBookmarkParser:");
		[CompilerGenerated]
		const string selRenderOptions = "renderOptions";
		static readonly IntPtr selRenderOptionsHandle = Selector.GetHandle ("renderOptions");
		[CompilerGenerated]
		const string selSetRenderOptions_ = "setRenderOptions:";
		static readonly IntPtr selSetRenderOptions_Handle = Selector.GetHandle ("setRenderOptions:");
		[CompilerGenerated]
		const string selOverrideClassNames = "overrideClassNames";
		static readonly IntPtr selOverrideClassNamesHandle = Selector.GetHandle ("overrideClassNames");
		[CompilerGenerated]
		const string selSetOverrideClassNames_ = "setOverrideClassNames:";
		static readonly IntPtr selSetOverrideClassNames_Handle = Selector.GetHandle ("setOverrideClassNames:");
		[CompilerGenerated]
		const string selBackgroundColor = "backgroundColor";
		static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle ("backgroundColor");
		[CompilerGenerated]
		const string selSetBackgroundColor_ = "setBackgroundColor:";
		static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle ("setBackgroundColor:");
		[CompilerGenerated]
		const string selDocument = "document";
		static readonly IntPtr selDocumentHandle = Selector.GetHandle ("document");
		[CompilerGenerated]
		const string selDocumentWithURL_ = "documentWithURL:";
		static readonly IntPtr selDocumentWithURL_Handle = Selector.GetHandle ("documentWithURL:");
		[CompilerGenerated]
		const string selDocumentWithData_ = "documentWithData:";
		static readonly IntPtr selDocumentWithData_Handle = Selector.GetHandle ("documentWithData:");
		[CompilerGenerated]
		const string selDocumentWithDataArray_ = "documentWithDataArray:";
		static readonly IntPtr selDocumentWithDataArray_Handle = Selector.GetHandle ("documentWithDataArray:");
		[CompilerGenerated]
		const string selDocumentWithDataProvider_ = "documentWithDataProvider:";
		static readonly IntPtr selDocumentWithDataProvider_Handle = Selector.GetHandle ("documentWithDataProvider:");
		[CompilerGenerated]
		const string selDocumentWithBaseURLFiles_ = "documentWithBaseURL:files:";
		static readonly IntPtr selDocumentWithBaseURLFiles_Handle = Selector.GetHandle ("documentWithBaseURL:files:");
		[CompilerGenerated]
		const string selPDFDocumentWithBaseURLFileTemplateStartPageEndPage_ = "PDFDocumentWithBaseURL:fileTemplate:startPage:endPage:";
		static readonly IntPtr selPDFDocumentWithBaseURLFileTemplateStartPageEndPage_Handle = Selector.GetHandle ("PDFDocumentWithBaseURL:fileTemplate:startPage:endPage:");
		[CompilerGenerated]
		const string selInitWithURL_ = "initWithURL:";
		static readonly IntPtr selInitWithURL_Handle = Selector.GetHandle ("initWithURL:");
		[CompilerGenerated]
		const string selInitWithData_ = "initWithData:";
		static readonly IntPtr selInitWithData_Handle = Selector.GetHandle ("initWithData:");
		[CompilerGenerated]
		const string selInitWithDataArray_ = "initWithDataArray:";
		static readonly IntPtr selInitWithDataArray_Handle = Selector.GetHandle ("initWithDataArray:");
		[CompilerGenerated]
		const string selInitWithDataProvider_ = "initWithDataProvider:";
		static readonly IntPtr selInitWithDataProvider_Handle = Selector.GetHandle ("initWithDataProvider:");
		[CompilerGenerated]
		const string selInitWithBaseURLFiles_ = "initWithBaseURL:files:";
		static readonly IntPtr selInitWithBaseURLFiles_Handle = Selector.GetHandle ("initWithBaseURL:files:");
		[CompilerGenerated]
		const string selInitWithBaseURLFileTemplateStartPageEndPage_ = "initWithBaseURL:fileTemplate:startPage:endPage:";
		static readonly IntPtr selInitWithBaseURLFileTemplateStartPageEndPage_Handle = Selector.GetHandle ("initWithBaseURL:fileTemplate:startPage:endPage:");
		[CompilerGenerated]
		const string selIsEqualToDocument_ = "isEqualToDocument:";
		static readonly IntPtr selIsEqualToDocument_Handle = Selector.GetHandle ("isEqualToDocument:");
		[CompilerGenerated]
		const string selAppendFile_ = "appendFile:";
		static readonly IntPtr selAppendFile_Handle = Selector.GetHandle ("appendFile:");
		[CompilerGenerated]
		const string selPathForPage_ = "pathForPage:";
		static readonly IntPtr selPathForPage_Handle = Selector.GetHandle ("pathForPage:");
		[CompilerGenerated]
		const string selFileIndexForPage_ = "fileIndexForPage:";
		static readonly IntPtr selFileIndexForPage_Handle = Selector.GetHandle ("fileIndexForPage:");
		[CompilerGenerated]
		const string selURLForFileIndex_ = "URLForFileIndex:";
		static readonly IntPtr selURLForFileIndex_Handle = Selector.GetHandle ("URLForFileIndex:");
		[CompilerGenerated]
		const string selFilesWithBasePath = "filesWithBasePath";
		static readonly IntPtr selFilesWithBasePathHandle = Selector.GetHandle ("filesWithBasePath");
		[CompilerGenerated]
		const string selFileNameForPage_ = "fileNameForPage:";
		static readonly IntPtr selFileNameForPage_Handle = Selector.GetHandle ("fileNameForPage:");
		[CompilerGenerated]
		const string selFileName_ = "fileName:";
		static readonly IntPtr selFileName_Handle = Selector.GetHandle ("fileName:");
		[CompilerGenerated]
		const string selSaveChangedAnnotationsWithError_ = "saveChangedAnnotationsWithError:";
		static readonly IntPtr selSaveChangedAnnotationsWithError_Handle = Selector.GetHandle ("saveChangedAnnotationsWithError:");
		[CompilerGenerated]
		const string selAnnotationsForPageType_ = "annotationsForPage:type:";
		static readonly IntPtr selAnnotationsForPageType_Handle = Selector.GetHandle ("annotationsForPage:type:");
		[CompilerGenerated]
		const string selAddAnnotationsForPage_ = "addAnnotations:forPage:";
		static readonly IntPtr selAddAnnotationsForPage_Handle = Selector.GetHandle ("addAnnotations:forPage:");
		[CompilerGenerated]
		const string selAllAnnotationsOfType_ = "allAnnotationsOfType:";
		static readonly IntPtr selAllAnnotationsOfType_Handle = Selector.GetHandle ("allAnnotationsOfType:");
		[CompilerGenerated]
		const string selAnnotationParserForPage_ = "annotationParserForPage:";
		static readonly IntPtr selAnnotationParserForPage_Handle = Selector.GetHandle ("annotationParserForPage:");
		[CompilerGenerated]
		const string selPageNumberForPage_ = "pageNumberForPage:";
		static readonly IntPtr selPageNumberForPage_Handle = Selector.GetHandle ("pageNumberForPage:");
		[CompilerGenerated]
		const string selCompensatedPageForPage_ = "compensatedPageForPage:";
		static readonly IntPtr selCompensatedPageForPage_Handle = Selector.GetHandle ("compensatedPageForPage:");
		[CompilerGenerated]
		const string selPageInfoForPage_ = "pageInfoForPage:";
		static readonly IntPtr selPageInfoForPage_Handle = Selector.GetHandle ("pageInfoForPage:");
		[CompilerGenerated]
		const string selHasPageInfoForPage_ = "hasPageInfoForPage:";
		static readonly IntPtr selHasPageInfoForPage_Handle = Selector.GetHandle ("hasPageInfoForPage:");
		[CompilerGenerated]
		const string selNearestPageInfoForPage_ = "nearestPageInfoForPage:";
		static readonly IntPtr selNearestPageInfoForPage_Handle = Selector.GetHandle ("nearestPageInfoForPage:");
		[CompilerGenerated]
		const string selRectBoxForPage_ = "rectBoxForPage:";
		static readonly IntPtr selRectBoxForPage_Handle = Selector.GetHandle ("rectBoxForPage:");
		[CompilerGenerated]
		const string selRotationForPage_ = "rotationForPage:";
		static readonly IntPtr selRotationForPage_Handle = Selector.GetHandle ("rotationForPage:");
		[CompilerGenerated]
		const string selAspectRatioVariance = "aspectRatioVariance";
		static readonly IntPtr selAspectRatioVarianceHandle = Selector.GetHandle ("aspectRatioVariance");
		[CompilerGenerated]
		const string selClearCache = "clearCache";
		static readonly IntPtr selClearCacheHandle = Selector.GetHandle ("clearCache");
		[CompilerGenerated]
		const string selFillCache = "fillCache";
		static readonly IntPtr selFillCacheHandle = Selector.GetHandle ("fillCache");
		[CompilerGenerated]
		const string selFillPageInfoCache = "fillPageInfoCache";
		static readonly IntPtr selFillPageInfoCacheHandle = Selector.GetHandle ("fillPageInfoCache");
		[CompilerGenerated]
		const string selEnsureCacheDirectoryExistsWithError_ = "ensureCacheDirectoryExistsWithError:";
		static readonly IntPtr selEnsureCacheDirectoryExistsWithError_Handle = Selector.GetHandle ("ensureCacheDirectoryExistsWithError:");
		[CompilerGenerated]
		const string selUnlockWithPassword_ = "unlockWithPassword:";
		static readonly IntPtr selUnlockWithPassword_Handle = Selector.GetHandle ("unlockWithPassword:");
		[CompilerGenerated]
		const string selTextParserForPage_ = "textParserForPage:";
		static readonly IntPtr selTextParserForPage_Handle = Selector.GetHandle ("textParserForPage:");
		[CompilerGenerated]
		const string selHasLoadedTextParserForPage_ = "hasLoadedTextParserForPage:";
		static readonly IntPtr selHasLoadedTextParserForPage_Handle = Selector.GetHandle ("hasLoadedTextParserForPage:");
		[CompilerGenerated]
		const string selDocumentProviderForPage_ = "documentProviderForPage:";
		static readonly IntPtr selDocumentProviderForPage_Handle = Selector.GetHandle ("documentProviderForPage:");
		[CompilerGenerated]
		const string selPageOffsetForDocumentProvider_ = "pageOffsetForDocumentProvider:";
		static readonly IntPtr selPageOffsetForDocumentProvider_Handle = Selector.GetHandle ("pageOffsetForDocumentProvider:");
		[CompilerGenerated]
		const string selDocumentProviders_ = "documentProviders:";
		static readonly IntPtr selDocumentProviders_Handle = Selector.GetHandle ("documentProviders:");
		[CompilerGenerated]
		const string selDocumentParserForPage_ = "documentParserForPage:";
		static readonly IntPtr selDocumentParserForPage_Handle = Selector.GetHandle ("documentParserForPage:");
		[CompilerGenerated]
		const string selPageLabelForPageSubstituteWithPlainLabel_ = "pageLabelForPage:substituteWithPlainLabel:";
		static readonly IntPtr selPageLabelForPageSubstituteWithPlainLabel_Handle = Selector.GetHandle ("pageLabelForPage:substituteWithPlainLabel:");
		[CompilerGenerated]
		const string selPageForPageLabelPartialMatching_ = "pageForPageLabel:partialMatching:";
		static readonly IntPtr selPageForPageLabelPartialMatching_Handle = Selector.GetHandle ("pageForPageLabel:partialMatching:");
		[CompilerGenerated]
		const string selObjectsAtPDFPointPageOptions_ = "objectsAtPDFPoint:page:options:";
		static readonly IntPtr selObjectsAtPDFPointPageOptions_Handle = Selector.GetHandle ("objectsAtPDFPoint:page:options:");
		[CompilerGenerated]
		const string selObjectsAtPDFRectPageOptions_ = "objectsAtPDFRect:page:options:";
		static readonly IntPtr selObjectsAtPDFRectPageOptions_Handle = Selector.GetHandle ("objectsAtPDFRect:page:options:");
		[CompilerGenerated]
		const string selDidCreateDocumentProvider_ = "didCreateDocumentProvider:";
		static readonly IntPtr selDidCreateDocumentProvider_Handle = Selector.GetHandle ("didCreateDocumentProvider:");
		[CompilerGenerated]
		const string selSetDidCreateDocumentProviderBlock_ = "setDidCreateDocumentProviderBlock:";
		static readonly IntPtr selSetDidCreateDocumentProviderBlock_Handle = Selector.GetHandle ("setDidCreateDocumentProviderBlock:");
		[CompilerGenerated]
		const string selPageContentForPage_ = "pageContentForPage:";
		static readonly IntPtr selPageContentForPage_Handle = Selector.GetHandle ("pageContentForPage:");
		[CompilerGenerated]
		const string selBackgroundColorForPage_ = "backgroundColorForPage:";
		static readonly IntPtr selBackgroundColorForPage_Handle = Selector.GetHandle ("backgroundColorForPage:");
		[CompilerGenerated]
		const string selPageInfoForPagePageRef_ = "pageInfoForPage:pageRef:";
		static readonly IntPtr selPageInfoForPagePageRef_Handle = Selector.GetHandle ("pageInfoForPage:pageRef:");
		[CompilerGenerated]
		const string selDetectLinkTypesForPagesInRange_ = "detectLinkTypes:forPagesInRange:";
		static readonly IntPtr selDetectLinkTypesForPagesInRange_Handle = Selector.GetHandle ("detectLinkTypes:forPagesInRange:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFDocument");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFDocument () : base (NSObjectFlag.Empty)
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
		public PSPDFDocument (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFDocument (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFDocument (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("document")]
		[CompilerGenerated]
		public static PSPDFDocument Document ()
		{
			return (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selDocumentHandle));
		}
		
		[Export ("documentWithURL:")]
		[CompilerGenerated]
		public static PSPDFDocument DocumentWithURL (NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			return (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selDocumentWithURL_Handle, url.Handle));
		}
		
		[Export ("documentWithData:")]
		[CompilerGenerated]
		public static PSPDFDocument DocumentWithData (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			return (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selDocumentWithData_Handle, data.Handle));
		}
		
		[Export ("documentWithDataArray:")]
		[CompilerGenerated]
		public static PSPDFDocument DocumentWithDataArray (NSArray dataArray)
		{
			if (dataArray == null)
				throw new ArgumentNullException ("dataArray");
			return (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selDocumentWithDataArray_Handle, dataArray.Handle));
		}
		
		[Export ("documentWithDataArray:")]
		[CompilerGenerated]
		public static PSPDFDocument DocumentWithDataArray (NSObject[] dataArray)
		{
			if (dataArray == null)
				throw new ArgumentNullException ("dataArray");
			var nsa_dataArray = NSArray.FromNSObjects (dataArray);
			
			PSPDFDocument ret;
			ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selDocumentWithDataArray_Handle, nsa_dataArray.Handle));
			nsa_dataArray.Dispose ();
			
			return ret;
		}
		
		[Export ("documentWithDataProvider:")]
		[CompilerGenerated]
		internal static PSPDFDocument DocumentWithDataProvider_ (global::System.IntPtr dataProvider)
		{
			return (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selDocumentWithDataProvider_Handle, dataProvider));
		}
		
		[Export ("documentWithBaseURL:files:")]
		[CompilerGenerated]
		public static PSPDFDocument DocumentWithBaseURL (NSUrl baseURL, NSArray files)
		{
			if (baseURL == null)
				throw new ArgumentNullException ("baseURL");
			if (files == null)
				throw new ArgumentNullException ("files");
			return (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selDocumentWithBaseURLFiles_Handle, baseURL.Handle, files.Handle));
		}
		
		[Export ("documentWithBaseURL:files:")]
		[CompilerGenerated]
		public static PSPDFDocument DocumentWithBaseURL (NSUrl baseURL, NSObject[] files)
		{
			if (baseURL == null)
				throw new ArgumentNullException ("baseURL");
			if (files == null)
				throw new ArgumentNullException ("files");
			var nsa_files = NSArray.FromNSObjects (files);
			
			PSPDFDocument ret;
			ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selDocumentWithBaseURLFiles_Handle, baseURL.Handle, nsa_files.Handle));
			nsa_files.Dispose ();
			
			return ret;
		}
		
		[Export ("PDFDocumentWithBaseURL:fileTemplate:startPage:endPage:")]
		[CompilerGenerated]
		public static PSPDFDocument PDFDocumentWithBaseURL (NSUrl baseURL, string fileTemplate, int startPage, int endPage)
		{
			if (baseURL == null)
				throw new ArgumentNullException ("baseURL");
			if (fileTemplate == null)
				throw new ArgumentNullException ("fileTemplate");
			var nsfileTemplate = NSString.CreateNative (fileTemplate);
			
			PSPDFDocument ret;
			ret = (PSPDFDocument) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_int_int (class_ptr, selPDFDocumentWithBaseURLFileTemplateStartPageEndPage_Handle, baseURL.Handle, nsfileTemplate, startPage, endPage));
			NSString.ReleaseNative (nsfileTemplate);
			
			return ret;
		}
		
		[Export ("initWithURL:")]
		[CompilerGenerated]
		public PSPDFDocument (NSUrl url)
			: base (NSObjectFlag.Empty)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithURL_Handle, url.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithURL_Handle, url.Handle);
			}
		}
		
		[Export ("initWithData:")]
		[CompilerGenerated]
		public PSPDFDocument (NSData data)
			: base (NSObjectFlag.Empty)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithData_Handle, data.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithData_Handle, data.Handle);
			}
		}
		
		[Export ("initWithDataArray:")]
		[CompilerGenerated]
		public PSPDFDocument (NSArray data)
			: base (NSObjectFlag.Empty)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithDataArray_Handle, data.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithDataArray_Handle, data.Handle);
			}
		}
		
		[Export ("initWithDataArray:")]
		[CompilerGenerated]
		public PSPDFDocument (NSObject[] data)
			: base (NSObjectFlag.Empty)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsa_data = NSArray.FromNSObjects (data);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithDataArray_Handle, nsa_data.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithDataArray_Handle, nsa_data.Handle);
			}
			nsa_data.Dispose ();
			
		}
		
		[Export ("initWithDataProvider:")]
		[CompilerGenerated]
		internal virtual PSPDFDocument InitWithDataProvider_ (global::System.IntPtr dataProvider)
		{
			if (IsDirectBinding) {
				return (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithDataProvider_Handle, dataProvider));
			} else {
				return (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithDataProvider_Handle, dataProvider));
			}
		}
		
		[Export ("initWithBaseURL:files:")]
		[CompilerGenerated]
		public PSPDFDocument (NSUrl basePath, NSArray files)
			: base (NSObjectFlag.Empty)
		{
			if (basePath == null)
				throw new ArgumentNullException ("basePath");
			if (files == null)
				throw new ArgumentNullException ("files");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithBaseURLFiles_Handle, basePath.Handle, files.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithBaseURLFiles_Handle, basePath.Handle, files.Handle);
			}
		}
		
		[Export ("initWithBaseURL:files:")]
		[CompilerGenerated]
		public PSPDFDocument (NSUrl basePath, NSObject[] files)
			: base (NSObjectFlag.Empty)
		{
			if (basePath == null)
				throw new ArgumentNullException ("basePath");
			if (files == null)
				throw new ArgumentNullException ("files");
			var nsa_files = NSArray.FromNSObjects (files);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithBaseURLFiles_Handle, basePath.Handle, nsa_files.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithBaseURLFiles_Handle, basePath.Handle, nsa_files.Handle);
			}
			nsa_files.Dispose ();
			
		}
		
		[Export ("initWithBaseURL:fileTemplate:startPage:endPage:")]
		[CompilerGenerated]
		public PSPDFDocument (NSUrl baseURL, string fileTemplate, int startPage, int endPage)
			: base (NSObjectFlag.Empty)
		{
			if (baseURL == null)
				throw new ArgumentNullException ("baseURL");
			if (fileTemplate == null)
				throw new ArgumentNullException ("fileTemplate");
			var nsfileTemplate = NSString.CreateNative (fileTemplate);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_int_int (this.Handle, selInitWithBaseURLFileTemplateStartPageEndPage_Handle, baseURL.Handle, nsfileTemplate, startPage, endPage);
			} else {
				Handle = ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int_int (this.SuperHandle, selInitWithBaseURLFileTemplateStartPageEndPage_Handle, baseURL.Handle, nsfileTemplate, startPage, endPage);
			}
			NSString.ReleaseNative (nsfileTemplate);
			
		}
		
		[Export ("isEqualToDocument:")]
		[CompilerGenerated]
		public virtual bool IsEqualToDocument (PSPDFDocument otherDocument)
		{
			if (otherDocument == null)
				throw new ArgumentNullException ("otherDocument");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsEqualToDocument_Handle, otherDocument.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selIsEqualToDocument_Handle, otherDocument.Handle);
			}
		}
		
		[Export ("appendFile:")]
		[CompilerGenerated]
		public virtual void AppendFile (string file)
		{
			if (file == null)
				throw new ArgumentNullException ("file");
			var nsfile = NSString.CreateNative (file);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAppendFile_Handle, nsfile);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selAppendFile_Handle, nsfile);
			}
			NSString.ReleaseNative (nsfile);
			
		}
		
		[Export ("pathForPage:")]
		[CompilerGenerated]
		public virtual NSUrl PathForPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selPathForPage_Handle, page));
			} else {
				return (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selPathForPage_Handle, page));
			}
		}
		
		[Export ("fileIndexForPage:")]
		[CompilerGenerated]
		public virtual int FileIndexForPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.int_objc_msgSend_UInt32 (this.Handle, selFileIndexForPage_Handle, page);
			} else {
				return ApiDefinition.Messaging.int_objc_msgSendSuper_UInt32 (this.SuperHandle, selFileIndexForPage_Handle, page);
			}
		}
		
		[Export ("URLForFileIndex:")]
		[CompilerGenerated]
		public virtual NSUrl URLForFileIndex (int fileIndex)
		{
			if (IsDirectBinding) {
				return (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int (this.Handle, selURLForFileIndex_Handle, fileIndex));
			} else {
				return (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, selURLForFileIndex_Handle, fileIndex));
			}
		}
		
		[Export ("filesWithBasePath")]
		[CompilerGenerated]
		public virtual NSUrl[] FilesWithBasePath ()
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<MonoTouch.Foundation.NSUrl>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFilesWithBasePathHandle));
			} else {
				return NSArray.ArrayFromHandle<MonoTouch.Foundation.NSUrl>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFilesWithBasePathHandle));
			}
		}
		
		[Export ("fileNameForPage:")]
		[CompilerGenerated]
		public virtual string FileNameForPage (global::System.UInt32 pageIndex)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selFileNameForPage_Handle, pageIndex));
			} else {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selFileNameForPage_Handle, pageIndex));
			}
		}
		
		[Export ("fileName:")]
		[CompilerGenerated]
		public virtual string FileName ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFileName_Handle));
			} else {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFileName_Handle));
			}
		}
		
		[Export ("saveChangedAnnotationsWithError:")]
		[CompilerGenerated]
		public virtual bool SaveChangedAnnotationsWithError (out NSError error)
		{
			IntPtr errorPtr = Marshal.AllocHGlobal(4);
			Marshal.WriteInt32(errorPtr, 0);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selSaveChangedAnnotationsWithError_Handle, errorPtr);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selSaveChangedAnnotationsWithError_Handle, errorPtr);
			}
			
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? (NSError)Runtime.GetNSObject(errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return ret;
		}
		
		[Export ("annotationsForPage:type:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotation[] AnnotationsForPage (global::System.UInt32 page, PSPDFAnnotationType type)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFAnnotation>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_UInt32 (this.Handle, selAnnotationsForPageType_Handle, page, (UInt32)type));
			} else {
				return NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFAnnotation>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32_UInt32 (this.SuperHandle, selAnnotationsForPageType_Handle, page, (UInt32)type));
			}
		}
		
		[Export ("addAnnotations:forPage:")]
		[CompilerGenerated]
		public virtual void AddAnnotations (PSPDFAnnotation[] annotation, global::System.UInt32 page)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			var nsa_annotation = NSArray.FromNSObjects (annotation);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UInt32 (this.Handle, selAddAnnotationsForPage_Handle, nsa_annotation.Handle, page);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, selAddAnnotationsForPage_Handle, nsa_annotation.Handle, page);
			}
			nsa_annotation.Dispose ();
			
		}
		
		[Export ("allAnnotationsOfType:")]
		[CompilerGenerated]
		public virtual NSDictionary AllAnnotationsOfType (PSPDFAnnotationType annotationType)
		{
			if (IsDirectBinding) {
				return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selAllAnnotationsOfType_Handle, (UInt32)annotationType));
			} else {
				return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selAllAnnotationsOfType_Handle, (UInt32)annotationType));
			}
		}
		
		[Export ("annotationParserForPage:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotationParser AnnotationParserForPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return (PSPDFAnnotationParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selAnnotationParserForPage_Handle, page));
			} else {
				return (PSPDFAnnotationParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selAnnotationParserForPage_Handle, page));
			}
		}
		
		[Export ("pageNumberForPage:")]
		[CompilerGenerated]
		public virtual global::System.UInt32 PageNumberForPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend_UInt32 (this.Handle, selPageNumberForPage_Handle, page);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper_UInt32 (this.SuperHandle, selPageNumberForPage_Handle, page);
			}
		}
		
		[Export ("compensatedPageForPage:")]
		[CompilerGenerated]
		public virtual global::System.UInt32 CompensatedPageForPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend_UInt32 (this.Handle, selCompensatedPageForPage_Handle, page);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper_UInt32 (this.SuperHandle, selCompensatedPageForPage_Handle, page);
			}
		}
		
		[Export ("pageInfoForPage:")]
		[CompilerGenerated]
		public virtual PSPDFPageInfo PageInfoForPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return (PSPDFPageInfo) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selPageInfoForPage_Handle, page));
			} else {
				return (PSPDFPageInfo) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selPageInfoForPage_Handle, page));
			}
		}
		
		[Export ("hasPageInfoForPage:")]
		[CompilerGenerated]
		public virtual bool HasPageInfoForPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_UInt32 (this.Handle, selHasPageInfoForPage_Handle, page);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_UInt32 (this.SuperHandle, selHasPageInfoForPage_Handle, page);
			}
		}
		
		[Export ("nearestPageInfoForPage:")]
		[CompilerGenerated]
		public virtual PSPDFPageInfo NearestPageInfoForPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return (PSPDFPageInfo) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selNearestPageInfoForPage_Handle, page));
			} else {
				return (PSPDFPageInfo) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selNearestPageInfoForPage_Handle, page));
			}
		}
		
		[Export ("rectBoxForPage:")]
		[CompilerGenerated]
		public virtual global::System.Drawing.RectangleF RectBoxForPage (global::System.UInt32 page)
		{
			global::System.Drawing.RectangleF ret;
			if (IsDirectBinding) {
				ApiDefinition.Messaging.RectangleF_objc_msgSend_stret_UInt32 (out ret, this.Handle, selRectBoxForPage_Handle, page);
			} else {
				ApiDefinition.Messaging.RectangleF_objc_msgSendSuper_stret_UInt32 (out ret, this.SuperHandle, selRectBoxForPage_Handle, page);
			}
			return ret;
		}
		
		[Export ("rotationForPage:")]
		[CompilerGenerated]
		public virtual int RotationForPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.int_objc_msgSend_UInt32 (this.Handle, selRotationForPage_Handle, page);
			} else {
				return ApiDefinition.Messaging.int_objc_msgSendSuper_UInt32 (this.SuperHandle, selRotationForPage_Handle, page);
			}
		}
		
		[Export ("aspectRatioVariance")]
		[CompilerGenerated]
		public virtual float AspectRatioVariance ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selAspectRatioVarianceHandle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selAspectRatioVarianceHandle);
			}
		}
		
		[Export ("clearCache")]
		[CompilerGenerated]
		public virtual void ClearCache ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selClearCacheHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selClearCacheHandle);
			}
		}
		
		[Export ("fillCache")]
		[CompilerGenerated]
		public virtual void FillCache ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selFillCacheHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selFillCacheHandle);
			}
		}
		
		[Export ("fillPageInfoCache")]
		[CompilerGenerated]
		public virtual void FillPageInfoCache ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selFillPageInfoCacheHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selFillPageInfoCacheHandle);
			}
		}
		
		[Export ("ensureCacheDirectoryExistsWithError:")]
		[CompilerGenerated]
		public virtual bool EnsureCacheDirectoryExistsWithError (out NSError error)
		{
			IntPtr errorPtr = Marshal.AllocHGlobal(4);
			Marshal.WriteInt32(errorPtr, 0);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selEnsureCacheDirectoryExistsWithError_Handle, errorPtr);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selEnsureCacheDirectoryExistsWithError_Handle, errorPtr);
			}
			
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? (NSError)Runtime.GetNSObject(errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return ret;
		}
		
		[Export ("unlockWithPassword:")]
		[CompilerGenerated]
		public virtual bool UnlockWithPassword (string password)
		{
			if (password == null)
				throw new ArgumentNullException ("password");
			var nspassword = NSString.CreateNative (password);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selUnlockWithPassword_Handle, nspassword);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selUnlockWithPassword_Handle, nspassword);
			}
			NSString.ReleaseNative (nspassword);
			
			return ret;
		}
		
		[Export ("textParserForPage:")]
		[CompilerGenerated]
		public virtual PSPDFTextParser TextParserForPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return (PSPDFTextParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selTextParserForPage_Handle, page));
			} else {
				return (PSPDFTextParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selTextParserForPage_Handle, page));
			}
		}
		
		[Export ("hasLoadedTextParserForPage:")]
		[CompilerGenerated]
		public virtual bool HasLoadedTextParserForPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_UInt32 (this.Handle, selHasLoadedTextParserForPage_Handle, page);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_UInt32 (this.SuperHandle, selHasLoadedTextParserForPage_Handle, page);
			}
		}
		
		[Export ("documentProviderForPage:")]
		[CompilerGenerated]
		public virtual PSPDFDocumentProvider DocumentProviderForPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return (PSPDFDocumentProvider) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selDocumentProviderForPage_Handle, page));
			} else {
				return (PSPDFDocumentProvider) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selDocumentProviderForPage_Handle, page));
			}
		}
		
		[Export ("pageOffsetForDocumentProvider:")]
		[CompilerGenerated]
		public virtual global::System.UInt32 PageOffsetForDocumentProvider (PSPDFDocumentProvider documentProvider)
		{
			if (documentProvider == null)
				throw new ArgumentNullException ("documentProvider");
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr (this.Handle, selPageOffsetForDocumentProvider_Handle, documentProvider.Handle);
			} else {
				return ApiDefinition.Messaging.UInt32_objc_msgSendSuper_IntPtr (this.SuperHandle, selPageOffsetForDocumentProvider_Handle, documentProvider.Handle);
			}
		}
		
		[Export ("documentProviders:")]
		[CompilerGenerated]
		public virtual PSPDFDocumentProvider[] DocumentProviders ()
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFDocumentProvider>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocumentProviders_Handle));
			} else {
				return NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFDocumentProvider>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocumentProviders_Handle));
			}
		}
		
		[Export ("documentParserForPage:")]
		[CompilerGenerated]
		public virtual PSPDFDocumentParser DocumentParserForPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return (PSPDFDocumentParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selDocumentParserForPage_Handle, page));
			} else {
				return (PSPDFDocumentParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selDocumentParserForPage_Handle, page));
			}
		}
		
		[Export ("pageLabelForPage:substituteWithPlainLabel:")]
		[CompilerGenerated]
		public virtual string PageLabelForPage (global::System.UInt32 page, bool substitute)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_bool (this.Handle, selPageLabelForPageSubstituteWithPlainLabel_Handle, page, substitute));
			} else {
				return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32_bool (this.SuperHandle, selPageLabelForPageSubstituteWithPlainLabel_Handle, page, substitute));
			}
		}
		
		[Export ("pageForPageLabel:partialMatching:")]
		[CompilerGenerated]
		public virtual global::System.UInt32 PageForPageLabel (string pageLabel, bool partialMatching)
		{
			if (pageLabel == null)
				throw new ArgumentNullException ("pageLabel");
			var nspageLabel = NSString.CreateNative (pageLabel);
			
			global::System.UInt32 ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr_bool (this.Handle, selPageForPageLabelPartialMatching_Handle, nspageLabel, partialMatching);
			} else {
				ret = ApiDefinition.Messaging.UInt32_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selPageForPageLabelPartialMatching_Handle, nspageLabel, partialMatching);
			}
			NSString.ReleaseNative (nspageLabel);
			
			return ret;
		}
		
		[Export ("objectsAtPDFPoint:page:options:")]
		[CompilerGenerated]
		public virtual NSDictionary ObjectsAtPDFPoint (global::System.Drawing.PointF pdfPoint, global::System.UInt32 page, NSDictionary options)
		{
			if (IsDirectBinding) {
				return (NSDictionary) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_PointF_UInt32_IntPtr (this.Handle, selObjectsAtPDFPointPageOptions_Handle, pdfPoint, page, options == null ? IntPtr.Zero : options.Handle));
			} else {
				return (NSDictionary) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_PointF_UInt32_IntPtr (this.SuperHandle, selObjectsAtPDFPointPageOptions_Handle, pdfPoint, page, options == null ? IntPtr.Zero : options.Handle));
			}
		}
		
		[Export ("objectsAtPDFRect:page:options:")]
		[CompilerGenerated]
		public virtual NSDictionary ObjectsAtPDFRect (global::System.Drawing.RectangleF pdfRect, global::System.UInt32 page, NSDictionary options)
		{
			if (IsDirectBinding) {
				return (NSDictionary) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_RectangleF_UInt32_IntPtr (this.Handle, selObjectsAtPDFRectPageOptions_Handle, pdfRect, page, options == null ? IntPtr.Zero : options.Handle));
			} else {
				return (NSDictionary) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_RectangleF_UInt32_IntPtr (this.SuperHandle, selObjectsAtPDFRectPageOptions_Handle, pdfRect, page, options == null ? IntPtr.Zero : options.Handle));
			}
		}
		
		[Export ("didCreateDocumentProvider:")]
		[CompilerGenerated]
		public virtual PSPDFDocumentProvider DidCreateDocumentProvider (PSPDFDocumentProvider documentProvider)
		{
			if (documentProvider == null)
				throw new ArgumentNullException ("documentProvider");
			if (IsDirectBinding) {
				return (PSPDFDocumentProvider) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selDidCreateDocumentProvider_Handle, documentProvider.Handle));
			} else {
				return (PSPDFDocumentProvider) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selDidCreateDocumentProvider_Handle, documentProvider.Handle));
			}
		}
		
		[Export ("setDidCreateDocumentProviderBlock:")]
		[CompilerGenerated]
		public unsafe virtual void SetDidCreateDocumentProviderBlock (PSPDFDocumentDocumentProviderBlock documentProviderBlock)
		{
			if (documentProviderBlock == null)
				throw new ArgumentNullException ("documentProviderBlock");
			BlockLiteral *block_ptr_documentProviderBlock;
			BlockLiteral block_documentProviderBlock;
			block_documentProviderBlock = new BlockLiteral ();
			block_ptr_documentProviderBlock = &block_documentProviderBlock;
			block_documentProviderBlock.SetupBlock (static_InnerPSPDFDocumentDocumentProviderBlock, documentProviderBlock);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDidCreateDocumentProviderBlock_Handle, (IntPtr) block_ptr_documentProviderBlock);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDidCreateDocumentProviderBlock_Handle, (IntPtr) block_ptr_documentProviderBlock);
			}
			block_ptr_documentProviderBlock->CleanupBlock ();
			
		}
		
		[Export ("pageContentForPage:")]
		[CompilerGenerated]
		public virtual string PageContentForPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selPageContentForPage_Handle, page));
			} else {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selPageContentForPage_Handle, page));
			}
		}
		
		[Export ("backgroundColorForPage:")]
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor BackgroundColorForPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selBackgroundColorForPage_Handle, page));
			} else {
				return (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selBackgroundColorForPage_Handle, page));
			}
		}
		
		[Export ("pageInfoForPage:pageRef:")]
		[CompilerGenerated]
		internal virtual PSPDFPageInfo PageInfoForPage_ (global::System.UInt32 page, global::System.IntPtr pageRef)
		{
			if (IsDirectBinding) {
				return (PSPDFPageInfo) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (this.Handle, selPageInfoForPagePageRef_Handle, page, pageRef));
			} else {
				return (PSPDFPageInfo) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32_IntPtr (this.SuperHandle, selPageInfoForPagePageRef_Handle, page, pageRef));
			}
		}
		
		[Export ("detectLinkTypes:forPagesInRange:")]
		[CompilerGenerated]
		public virtual NSArray DetectLinkTypes (PSPDFTextCheckingType textLinkType, NSIndexSet pageRange)
		{
			if (pageRange == null)
				throw new ArgumentNullException ("pageRange");
			if (IsDirectBinding) {
				return (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (this.Handle, selDetectLinkTypesForPagesInRange_Handle, (UInt32)textLinkType, pageRange.Handle));
			} else {
				return (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32_IntPtr (this.SuperHandle, selDetectLinkTypesForPagesInRange_Handle, (UInt32)textLinkType, pageRange.Handle));
			}
		}
		
		[CompilerGenerated]
		public PSPDFDocumentDelegate Delegate {
			get {
				return WeakDelegate as PSPDFDocumentDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFAnnotationType RenderAnnotationTypes {
			[Export ("renderAnnotationTypes", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFAnnotationType) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selRenderAnnotationTypesHandle);
				} else {
					return (PSPDFAnnotationType) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selRenderAnnotationTypesHandle);
				}
			}
			
			[Export ("setRenderAnnotationTypes:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetRenderAnnotationTypes_Handle, (UInt32)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetRenderAnnotationTypes_Handle, (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_FileNamesWithDataDictionary_var;
		[CompilerGenerated]
		public virtual NSDictionary FileNamesWithDataDictionary {
			[Export ("fileNamesWithDataDictionary")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFileNamesWithDataDictionaryHandle));
				} else {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFileNamesWithDataDictionaryHandle));
				}
				MarkDirty ();
				__mt_FileNamesWithDataDictionary_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_BasePath_var;
		[CompilerGenerated]
		public virtual NSUrl BasePath {
			[Export ("basePath")]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBasePathHandle));
				} else {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBasePathHandle));
				}
				MarkDirty ();
				__mt_BasePath_var = ret;
				return ret;
			}
			
			[Export ("setBasePath:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBasePath_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBasePath_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_BasePath_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.String[] Files {
			[Export ("files", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSArray.StringArrayFromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFilesHandle));
				} else {
					return NSArray.StringArrayFromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFilesHandle));
				}
			}
			
			[Export ("setFiles:", ArgumentSemantic.Copy)]
			set {
				var nsa_value = value == null ? null : NSArray.FromStrings (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFiles_Handle, nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFiles_Handle, nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
			}
		}
		
		[CompilerGenerated]
		object __mt_FileURL_var;
		[CompilerGenerated]
		public virtual NSUrl FileURL {
			[Export ("fileURL")]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFileURLHandle));
				} else {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFileURLHandle));
				}
				MarkDirty ();
				__mt_FileURL_var = ret;
				return ret;
			}
			
			[Export ("setFileURL:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFileURL_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFileURL_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_FileURL_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Data_var;
		[CompilerGenerated]
		public virtual NSData Data {
			[Export ("data", ArgumentSemantic.Copy)]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret = (NSData) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDataHandle));
				} else {
					ret = (NSData) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDataHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Data_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_DataArray_var;
		[CompilerGenerated]
		public virtual NSData[] DataArray {
			[Export ("dataArray", ArgumentSemantic.Copy)]
			get {
				NSData[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSData>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDataArrayHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSData>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDataArrayHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DataArray_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		internal virtual global::System.IntPtr DataProvider_ {
			[Export ("dataProvider", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDataProviderHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDataProviderHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Title {
			[Export ("title", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTitleHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTitleHandle));
				}
			}
			
			[Export ("setTitle:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTitle_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTitle_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool TitleLoaded {
			[Export ("isTitleLoaded", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsTitleLoadedHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsTitleLoadedHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Metadata_var;
		[CompilerGenerated]
		public virtual NSDictionary Metadata {
			[Export ("metadata", ArgumentSemantic.Copy)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMetadataHandle));
				} else {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMetadataHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Metadata_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Uid {
			[Export ("UID", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUIDHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUIDHandle));
				}
			}
			
			[Export ("setUID:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUID_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUID_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool AnnotationsEnabled {
			[Export ("isAnnotationsEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAnnotationsEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsAnnotationsEnabledHandle);
				}
			}
			
			[Export ("setAnnotationsEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAnnotationsEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAnnotationsEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.IntPtr EditableAnnotationTypes {
			[Export ("editableAnnotationTypes", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selEditableAnnotationTypesHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selEditableAnnotationTypesHandle);
				}
			}
			
			[Export ("setEditableAnnotationTypes:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetEditableAnnotationTypes_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetEditableAnnotationTypes_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool CanEmbedAnnotations {
			[Export ("canEmbedAnnotations", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanEmbedAnnotationsHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selCanEmbedAnnotationsHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFAnnotationSaveMode AnnotationSaveMode {
			[Export ("annotationSaveMode", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFAnnotationSaveMode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selAnnotationSaveModeHandle);
				} else {
					return (PSPDFAnnotationSaveMode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selAnnotationSaveModeHandle);
				}
			}
			
			[Export ("setAnnotationSaveMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetAnnotationSaveMode_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetAnnotationSaveMode_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string DefaultAnnotationUsername {
			[Export ("defaultAnnotationUsername", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDefaultAnnotationUsernameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDefaultAnnotationUsernameHandle));
				}
			}
			
			[Export ("setDefaultAnnotationUsername:", ArgumentSemantic.Copy)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDefaultAnnotationUsername_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDefaultAnnotationUsername_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool HasDirtyAnnotations {
			[Export ("hasDirtyAnnotations")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasDirtyAnnotationsHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selHasDirtyAnnotationsHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_AnnotationParser_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotationParser AnnotationParser {
			[Export ("annotationParser")]
			get {
				PSPDFAnnotationParser ret;
				if (IsDirectBinding) {
					ret = (PSPDFAnnotationParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAnnotationParserHandle));
				} else {
					ret = (PSPDFAnnotationParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAnnotationParserHandle));
				}
				MarkDirty ();
				__mt_AnnotationParser_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 PageCount {
			[Export ("pageCount")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPageCountHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selPageCountHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PageRange_var;
		[CompilerGenerated]
		public virtual NSIndexSet PageRange {
			[Export ("pageRange", ArgumentSemantic.Copy)]
			get {
				NSIndexSet ret;
				if (IsDirectBinding) {
					ret = (NSIndexSet) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPageRangeHandle));
				} else {
					ret = (NSIndexSet) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPageRangeHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PageRange_var = ret;
				return ret;
			}
			
			[Export ("setPageRange:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPageRange_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPageRange_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_PageRange_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual CGPDFBox PDFBox {
			[Export ("PDFBox", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (CGPDFBox) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selPDFBoxHandle);
				} else {
					return (CGPDFBox) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selPDFBoxHandle);
				}
			}
			
			[Export ("setPDFBox:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetPDFBox_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetPDFBox_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string CacheDirectory {
			[Export ("cacheDirectory", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCacheDirectoryHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCacheDirectoryHandle));
				}
			}
			
			[Export ("setCacheDirectory:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCacheDirectory_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCacheDirectory_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFDiskCacheStrategy DiskCacheStrategy {
			[Export ("cacheStrategy", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFDiskCacheStrategy) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selCacheStrategyHandle);
				} else {
					return (PSPDFDiskCacheStrategy) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selCacheStrategyHandle);
				}
			}
			
			[Export ("setCacheStrategy:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetCacheStrategy_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetCacheStrategy_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AspectRatioEqual {
			[Export ("isAspectRatioEqual", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAspectRatioEqualHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsAspectRatioEqualHandle);
				}
			}
			
			[Export ("setAspectRatioEqual:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAspectRatioEqual_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAspectRatioEqual_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_DisplayingPdfController_var;
		[CompilerGenerated]
		public virtual PSPDFViewController DisplayingPdfController {
			[Export ("displayingPdfController")]
			get {
				PSPDFViewController ret;
				if (IsDirectBinding) {
					ret = (PSPDFViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDisplayingPdfControllerHandle));
				} else {
					ret = (PSPDFViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDisplayingPdfControllerHandle));
				}
				MarkDirty ();
				__mt_DisplayingPdfController_var = ret;
				return ret;
			}
			
			[Export ("setDisplayingPdfController:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDisplayingPdfController_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDisplayingPdfController_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_DisplayingPdfController_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 DisplayingPage {
			[Export ("displayingPage", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selDisplayingPageHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selDisplayingPageHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Password {
			[Export ("password", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPasswordHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPasswordHandle));
				}
			}
			
			[Export ("setPassword:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPassword_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPassword_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool Valid {
			[Export ("isValid", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsValidHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsValidHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool AllowsPrinting {
			[Export ("allowsPrinting", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsPrintingHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAllowsPrintingHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsEncrypted {
			[Export ("isEncrypted", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsEncryptedHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsEncryptedHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string EncryptionFilter {
			[Export ("encryptionFilter", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selEncryptionFilterHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selEncryptionFilterHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsLocked {
			[Export ("isLocked", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsLockedHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsLockedHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool AllowsCopying {
			[Export ("allowsCopying", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsCopyingHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAllowsCopyingHandle);
				}
			}
			
			[Export ("setAllowsCopying:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsCopying_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAllowsCopying_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool BookmarksEnabled {
			[Export ("isBookmarksEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsBookmarksEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsBookmarksEnabledHandle);
				}
			}
			
			[Export ("setBookmarksEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetBookmarksEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetBookmarksEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool PageLabelsEnabled {
			[Export ("pageLabelsEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selPageLabelsEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selPageLabelsEnabledHandle);
				}
			}
			
			[Export ("setPageLabelsEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPageLabelsEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetPageLabelsEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFDocumentMenuAction AllowedMenuActions {
			[Export ("allowedMenuActions", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFDocumentMenuAction) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selAllowedMenuActionsHandle);
				} else {
					return (PSPDFDocumentMenuAction) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selAllowedMenuActionsHandle);
				}
			}
			
			[Export ("setAllowedMenuActions:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetAllowedMenuActions_Handle, (UInt32)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetAllowedMenuActions_Handle, (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_TextSearch_var;
		[CompilerGenerated]
		public virtual PSPDFTextSearch TextSearch {
			[Export ("textSearch")]
			get {
				PSPDFTextSearch ret;
				if (IsDirectBinding) {
					ret = (PSPDFTextSearch) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTextSearchHandle));
				} else {
					ret = (PSPDFTextSearch) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTextSearchHandle));
				}
				MarkDirty ();
				__mt_TextSearch_var = ret;
				return ret;
			}
			
			[Export ("setTextSearch:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTextSearch_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTextSearch_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_TextSearch_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_OutlineParser_var;
		[CompilerGenerated]
		public virtual PSPDFOutlineParser OutlineParser {
			[Export ("outlineParser")]
			get {
				PSPDFOutlineParser ret;
				if (IsDirectBinding) {
					ret = (PSPDFOutlineParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOutlineParserHandle));
				} else {
					ret = (PSPDFOutlineParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOutlineParserHandle));
				}
				MarkDirty ();
				__mt_OutlineParser_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_BookmarkParser_var;
		[CompilerGenerated]
		public virtual PSPDFBookmarkParser BookmarkParser {
			[Export ("bookmarkParser")]
			get {
				PSPDFBookmarkParser ret;
				if (IsDirectBinding) {
					ret = (PSPDFBookmarkParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBookmarkParserHandle));
				} else {
					ret = (PSPDFBookmarkParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBookmarkParserHandle));
				}
				MarkDirty ();
				__mt_BookmarkParser_var = ret;
				return ret;
			}
			
			[Export ("setBookmarkParser:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBookmarkParser_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBookmarkParser_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_BookmarkParser_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_RenderOptions_var;
		[CompilerGenerated]
		public virtual NSDictionary RenderOptions {
			[Export ("renderOptions", ArgumentSemantic.Copy)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRenderOptionsHandle));
				} else {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRenderOptionsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RenderOptions_var = ret;
				return ret;
			}
			
			[Export ("setRenderOptions:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRenderOptions_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRenderOptions_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_RenderOptions_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_OverrideClassNames_var;
		[CompilerGenerated]
		public virtual NSDictionary OverrideClassNames {
			[Export ("overrideClassNames", ArgumentSemantic.Copy)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOverrideClassNamesHandle));
				} else {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOverrideClassNamesHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_OverrideClassNames_var = ret;
				return ret;
			}
			
			[Export ("setOverrideClassNames:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetOverrideClassNames_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetOverrideClassNames_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_OverrideClassNames_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_BackgroundColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor BackgroundColor {
			[Export ("backgroundColor")]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBackgroundColorHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBackgroundColorHandle));
				}
				MarkDirty ();
				__mt_BackgroundColor_var = ret;
				return ret;
			}
			
			[Export ("setBackgroundColor:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBackgroundColor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBackgroundColor_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_BackgroundColor_var = value;
			}
		}
		
		[CompilerGenerated]
		static readonly IntPtr __Internal_libraryHandle = Dlfcn.dlopen (null, 0);
		[CompilerGenerated]
		static NSString _PSPDFObjectsGlyphs;
		public static NSString PSPDFObjectsGlyphs {
			get {
				if (_PSPDFObjectsGlyphs == null)
					_PSPDFObjectsGlyphs = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFObjectsGlyphs");
				return _PSPDFObjectsGlyphs;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFObjectsText;
		public static NSString PSPDFObjectsText {
			get {
				if (_PSPDFObjectsText == null)
					_PSPDFObjectsText = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFObjectsText");
				return _PSPDFObjectsText;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFObjectsFullWords;
		public static NSString PSPDFObjectsFullWords {
			get {
				if (_PSPDFObjectsFullWords == null)
					_PSPDFObjectsFullWords = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFObjectsFullWords");
				return _PSPDFObjectsFullWords;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFObjectsTextBlocks;
		public static NSString PSPDFObjectsTextBlocks {
			get {
				if (_PSPDFObjectsTextBlocks == null)
					_PSPDFObjectsTextBlocks = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFObjectsTextBlocks");
				return _PSPDFObjectsTextBlocks;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFObjectsTextBlocksIgnoreLarge;
		public static NSString PSPDFObjectsTextBlocksIgnoreLarge {
			get {
				if (_PSPDFObjectsTextBlocksIgnoreLarge == null)
					_PSPDFObjectsTextBlocksIgnoreLarge = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFObjectsTextBlocksIgnoreLarge");
				return _PSPDFObjectsTextBlocksIgnoreLarge;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFObjectsAnnotationTypes;
		public static NSString PSPDFObjectsAnnotationTypes {
			get {
				if (_PSPDFObjectsAnnotationTypes == null)
					_PSPDFObjectsAnnotationTypes = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFObjectsAnnotationTypes");
				return _PSPDFObjectsAnnotationTypes;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFObjectsAnnotationPageBounds;
		public static NSString PSPDFObjectsAnnotationPageBounds {
			get {
				if (_PSPDFObjectsAnnotationPageBounds == null)
					_PSPDFObjectsAnnotationPageBounds = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFObjectsAnnotationPageBounds");
				return _PSPDFObjectsAnnotationPageBounds;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFObjectsImages;
		public static NSString PSPDFObjectsImages {
			get {
				if (_PSPDFObjectsImages == null)
					_PSPDFObjectsImages = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFObjectsImages");
				return _PSPDFObjectsImages;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFObjectsSmartSort;
		public static NSString PSPDFObjectsSmartSort {
			get {
				if (_PSPDFObjectsSmartSort == null)
					_PSPDFObjectsSmartSort = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFObjectsSmartSort");
				return _PSPDFObjectsSmartSort;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFObjectsTextFlow;
		public static NSString PSPDFObjectsTextFlow {
			get {
				if (_PSPDFObjectsTextFlow == null)
					_PSPDFObjectsTextFlow = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFObjectsTextFlow");
				return _PSPDFObjectsTextFlow;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFObjectsFindFirstOnly;
		public static NSString PSPDFObjectsFindFirstOnly {
			get {
				if (_PSPDFObjectsFindFirstOnly == null)
					_PSPDFObjectsFindFirstOnly = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFObjectsFindFirstOnly");
				return _PSPDFObjectsFindFirstOnly;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFObjectsTestIntersection;
		public static NSString PSPDFObjectsTestIntersection {
			get {
				if (_PSPDFObjectsTestIntersection == null)
					_PSPDFObjectsTestIntersection = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFObjectsTestIntersection");
				return _PSPDFObjectsTestIntersection;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFGlyphs;
		public static NSString PSPDFGlyphs {
			get {
				if (_PSPDFGlyphs == null)
					_PSPDFGlyphs = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFGlyphs");
				return _PSPDFGlyphs;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFWords;
		public static NSString PSPDFWords {
			get {
				if (_PSPDFWords == null)
					_PSPDFWords = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFWords");
				return _PSPDFWords;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFText;
		public static NSString PSPDFText {
			get {
				if (_PSPDFText == null)
					_PSPDFText = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFText");
				return _PSPDFText;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFTextBlocks;
		public static NSString PSPDFTextBlocks {
			get {
				if (_PSPDFTextBlocks == null)
					_PSPDFTextBlocks = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFTextBlocks");
				return _PSPDFTextBlocks;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFAnnotations;
		public static NSString PSPDFAnnotations {
			get {
				if (_PSPDFAnnotations == null)
					_PSPDFAnnotations = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFAnnotations");
				return _PSPDFAnnotations;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFImages;
		public static NSString PSPDFImages {
			get {
				if (_PSPDFImages == null)
					_PSPDFImages = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFImages");
				return _PSPDFImages;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFMetadataKeyTitle;
		public static NSString PSPDFMetadataKeyTitle {
			get {
				if (_PSPDFMetadataKeyTitle == null)
					_PSPDFMetadataKeyTitle = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFMetadataKeyTitle");
				return _PSPDFMetadataKeyTitle;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFMetadataKeyAuthor;
		public static NSString PSPDFMetadataKeyAuthor {
			get {
				if (_PSPDFMetadataKeyAuthor == null)
					_PSPDFMetadataKeyAuthor = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFMetadataKeyAuthor");
				return _PSPDFMetadataKeyAuthor;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFMetadataKeySubject;
		public static NSString PSPDFMetadataKeySubject {
			get {
				if (_PSPDFMetadataKeySubject == null)
					_PSPDFMetadataKeySubject = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFMetadataKeySubject");
				return _PSPDFMetadataKeySubject;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFMetadataKeyKeywords;
		public static NSString PSPDFMetadataKeyKeywords {
			get {
				if (_PSPDFMetadataKeyKeywords == null)
					_PSPDFMetadataKeyKeywords = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFMetadataKeyKeywords");
				return _PSPDFMetadataKeyKeywords;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFMetadataKeyCreator;
		public static NSString PSPDFMetadataKeyCreator {
			get {
				if (_PSPDFMetadataKeyCreator == null)
					_PSPDFMetadataKeyCreator = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFMetadataKeyCreator");
				return _PSPDFMetadataKeyCreator;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFMetadataKeyProducer;
		public static NSString PSPDFMetadataKeyProducer {
			get {
				if (_PSPDFMetadataKeyProducer == null)
					_PSPDFMetadataKeyProducer = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFMetadataKeyProducer");
				return _PSPDFMetadataKeyProducer;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFMetadataKeyCreationDate;
		public static NSString PSPDFMetadataKeyCreationDate {
			get {
				if (_PSPDFMetadataKeyCreationDate == null)
					_PSPDFMetadataKeyCreationDate = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFMetadataKeyCreationDate");
				return _PSPDFMetadataKeyCreationDate;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFMetadataKeyModDate;
		public static NSString PSPDFMetadataKeyModDate {
			get {
				if (_PSPDFMetadataKeyModDate == null)
					_PSPDFMetadataKeyModDate = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFMetadataKeyModDate");
				return _PSPDFMetadataKeyModDate;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFMetadataKeyTrapped;
		public static NSString PSPDFMetadataKeyTrapped {
			get {
				if (_PSPDFMetadataKeyTrapped == null)
					_PSPDFMetadataKeyTrapped = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFMetadataKeyTrapped");
				return _PSPDFMetadataKeyTrapped;
			}
		}
		//
		// Events and properties from the delegate
		//
		
		_PSPDFDocumentDelegate EnsurePSPDFDocumentDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _PSPDFDocumentDelegate))){
				del = new _PSPDFDocumentDelegate ();
				WeakDelegate = del;
			}
			return (_PSPDFDocumentDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _PSPDFDocumentDelegate : KS_PSPDFKitBindings.PSPDFDocumentDelegate { 
			public _PSPDFDocumentDelegate () {}
			
			internal PSPDFDocumentDelegateResolveCustomAnnotationPathToken resolveCustomAnnotationPathToken;
			[Preserve (Conditional = true)]
			public override string ResolveCustomAnnotationPathToken (KS_PSPDFKitBindings.PSPDFDocument document, string pathToken)
			{
				PSPDFDocumentDelegateResolveCustomAnnotationPathToken handler = resolveCustomAnnotationPathToken;
				if (handler != null)
					return handler (document, pathToken);
				return null;
			}
			
			internal EventHandler<PSPDFDocumentDelegateDidSaveAnnotationsEventArgs> didSaveAnnotations;
			[Preserve (Conditional = true)]
			public override void DidSaveAnnotations (KS_PSPDFKitBindings.PSPDFDocument document, KS_PSPDFKitBindings.PSPDFAnnotation[] annotations)
			{
				EventHandler<PSPDFDocumentDelegateDidSaveAnnotationsEventArgs> handler = didSaveAnnotations;
				if (handler != null){
					var args = new PSPDFDocumentDelegateDidSaveAnnotationsEventArgs (annotations);
					handler (document, args);
				}
			}
			
			internal EventHandler<PSPDFDocumentDelegateFailedToSaveAnnotationsEventArgs> failedToSaveAnnotations;
			[Preserve (Conditional = true)]
			public override void FailedToSaveAnnotations (KS_PSPDFKitBindings.PSPDFDocument document, KS_PSPDFKitBindings.PSPDFAnnotation[] annotations, NSError error)
			{
				EventHandler<PSPDFDocumentDelegateFailedToSaveAnnotationsEventArgs> handler = failedToSaveAnnotations;
				if (handler != null){
					var args = new PSPDFDocumentDelegateFailedToSaveAnnotationsEventArgs (annotations, error);
					handler (document, args);
				}
			}
			
		}
		#pragma warning restore 672
		
		public PSPDFDocumentDelegateResolveCustomAnnotationPathToken ResolveCustomAnnotationPathToken {
			get { return EnsurePSPDFDocumentDelegate ().resolveCustomAnnotationPathToken; }
			set { EnsurePSPDFDocumentDelegate ().resolveCustomAnnotationPathToken = value; }
		}
		
		public event EventHandler<PSPDFDocumentDelegateDidSaveAnnotationsEventArgs> DidSaveAnnotations {
			add { EnsurePSPDFDocumentDelegate ().didSaveAnnotations += value; }
			remove { EnsurePSPDFDocumentDelegate ().didSaveAnnotations -= value; }
		}
		
		public event EventHandler<PSPDFDocumentDelegateFailedToSaveAnnotationsEventArgs> FailedToSaveAnnotations {
			add { EnsurePSPDFDocumentDelegate ().failedToSaveAnnotations += value; }
			remove { EnsurePSPDFDocumentDelegate ().failedToSaveAnnotations -= value; }
		}
		
		internal delegate void InnerPSPDFDocumentDocumentProviderBlock (IntPtr block, IntPtr documentProvider);
		[CompilerGenerated]
		static readonly InnerPSPDFDocumentDocumentProviderBlock static_InnerPSPDFDocumentDocumentProviderBlock = TrampolinePSPDFDocumentDocumentProviderBlock;
		[MonoPInvokeCallback (typeof (InnerPSPDFDocumentDocumentProviderBlock))]
		static unsafe void TrampolinePSPDFDocumentDocumentProviderBlock (IntPtr block, IntPtr documentProvider) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::KS_PSPDFKitBindings.PSPDFDocumentDocumentProviderBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((KS_PSPDFKitBindings.PSPDFDocumentProvider) Runtime.GetNSObject (documentProvider));
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
				__mt_FileNamesWithDataDictionary_var = null;
				__mt_BasePath_var = null;
				__mt_FileURL_var = null;
				__mt_Data_var = null;
				__mt_DataArray_var = null;
				__mt_Metadata_var = null;
				__mt_AnnotationParser_var = null;
				__mt_PageRange_var = null;
				__mt_DisplayingPdfController_var = null;
				__mt_TextSearch_var = null;
				__mt_OutlineParser_var = null;
				__mt_BookmarkParser_var = null;
				__mt_RenderOptions_var = null;
				__mt_OverrideClassNames_var = null;
				__mt_BackgroundColor_var = null;
			}
		}
	} /* class PSPDFDocument */
	public delegate void PSPDFDocumentDocumentProviderBlock (PSPDFDocumentProvider documentProvider);
	
	
	//
	// EventArgs classes
	//
	public partial class PSPDFDocumentDelegateDidSaveAnnotationsEventArgs : EventArgs {
		public PSPDFDocumentDelegateDidSaveAnnotationsEventArgs (KS_PSPDFKitBindings.PSPDFAnnotation[] annotations)
		{
			this.Annotations = annotations;
		}
		public KS_PSPDFKitBindings.PSPDFAnnotation[] Annotations { get; set; }
	}
	
	public partial class PSPDFDocumentDelegateFailedToSaveAnnotationsEventArgs : EventArgs {
		public PSPDFDocumentDelegateFailedToSaveAnnotationsEventArgs (KS_PSPDFKitBindings.PSPDFAnnotation[] annotations, NSError error)
		{
			this.Annotations = annotations;
			this.Error = error;
		}
		public KS_PSPDFKitBindings.PSPDFAnnotation[] Annotations { get; set; }
		public NSError Error { get; set; }
	}
	
}
