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
	[Register("PSPDFDocument", true)]
	public unsafe partial class PSPDFDocument : NSObject {
		static readonly IntPtr selBasePath = Selector.GetHandle ("basePath");
		static readonly IntPtr selSetBasePath_ = Selector.GetHandle ("setBasePath:");
		static readonly IntPtr selFiles = Selector.GetHandle ("files");
		static readonly IntPtr selSetFiles_ = Selector.GetHandle ("setFiles:");
		static readonly IntPtr selFileURL = Selector.GetHandle ("fileURL");
		static readonly IntPtr selSetFileURL_ = Selector.GetHandle ("setFileURL:");
		static readonly IntPtr selData = Selector.GetHandle ("data");
		static readonly IntPtr selDataProvider = Selector.GetHandle ("dataProvider");
		static readonly IntPtr selTitle = Selector.GetHandle ("title");
		static readonly IntPtr selSetTitle_ = Selector.GetHandle ("setTitle:");
		static readonly IntPtr selIsTitleLoaded = Selector.GetHandle ("isTitleLoaded");
		static readonly IntPtr selMetadata = Selector.GetHandle ("metadata");
		static readonly IntPtr selUid = Selector.GetHandle ("uid");
		static readonly IntPtr selSetUid_ = Selector.GetHandle ("setUid:");
		static readonly IntPtr selBookmarks = Selector.GetHandle ("bookmarks");
		static readonly IntPtr selSetBookmarks_ = Selector.GetHandle ("setBookmarks:");
		static readonly IntPtr selCanEmbedAnnotations = Selector.GetHandle ("canEmbedAnnotations");
		static readonly IntPtr selPageCount = Selector.GetHandle ("pageCount");
		static readonly IntPtr selCacheDirectory = Selector.GetHandle ("cacheDirectory");
		static readonly IntPtr selSetCacheDirectory_ = Selector.GetHandle ("setCacheDirectory:");
		static readonly IntPtr selIsAspectRatioEqual = Selector.GetHandle ("isAspectRatioEqual");
		static readonly IntPtr selSetAspectRatioEqual_ = Selector.GetHandle ("setAspectRatioEqual:");
		static readonly IntPtr selIsAnnotationsEnabled = Selector.GetHandle ("isAnnotationsEnabled");
		static readonly IntPtr selSetAnnotationsEnabled_ = Selector.GetHandle ("setAnnotationsEnabled:");
		static readonly IntPtr selDisplayingPdfController = Selector.GetHandle ("displayingPdfController");
		static readonly IntPtr selSetDisplayingPdfController_ = Selector.GetHandle ("setDisplayingPdfController:");
		static readonly IntPtr selPassword = Selector.GetHandle ("password");
		static readonly IntPtr selSetPassword_ = Selector.GetHandle ("setPassword:");
		static readonly IntPtr selIsValid = Selector.GetHandle ("isValid");
		static readonly IntPtr selAllowsPrinting = Selector.GetHandle ("allowsPrinting");
		static readonly IntPtr selIsEncrypted = Selector.GetHandle ("isEncrypted");
		static readonly IntPtr selEncryptionFilter = Selector.GetHandle ("encryptionFilter");
		static readonly IntPtr selIsLocked = Selector.GetHandle ("isLocked");
		static readonly IntPtr selAllowsCopying = Selector.GetHandle ("allowsCopying");
		static readonly IntPtr selTextSearch = Selector.GetHandle ("textSearch");
		static readonly IntPtr selSetTextSearch_ = Selector.GetHandle ("setTextSearch:");
		static readonly IntPtr selDocumentProviders = Selector.GetHandle ("documentProviders");
		static readonly IntPtr selOutlineParser = Selector.GetHandle ("outlineParser");
		static readonly IntPtr selAnnotationParser = Selector.GetHandle ("annotationParser");
		static readonly IntPtr selOverrideClassNames = Selector.GetHandle ("overrideClassNames");
		static readonly IntPtr selSetOverrideClassNames_ = Selector.GetHandle ("setOverrideClassNames:");
		static readonly IntPtr selPDFDocument = Selector.GetHandle ("PDFDocument");
		static readonly IntPtr selPDFDocumentWithData_ = Selector.GetHandle ("PDFDocumentWithData:");
		static readonly IntPtr selPDFDocumentWithDataProvider_ = Selector.GetHandle ("PDFDocumentWithDataProvider:");
		static readonly IntPtr selPDFDocumentWithBaseURLFiles_ = Selector.GetHandle ("PDFDocumentWithBaseURL:files:");
		static readonly IntPtr selPDFDocumentWithURL_ = Selector.GetHandle ("PDFDocumentWithURL:");
		static readonly IntPtr selInitWithData_ = Selector.GetHandle ("initWithData:");
		static readonly IntPtr selInitWithDataProvider_ = Selector.GetHandle ("initWithDataProvider:");
		static readonly IntPtr selInitWithURL_ = Selector.GetHandle ("initWithURL:");
		static readonly IntPtr selInitWithBaseURLFiles_ = Selector.GetHandle ("initWithBaseURL:files:");
		static readonly IntPtr selAppendFile_ = Selector.GetHandle ("appendFile:");
		static readonly IntPtr selPathForPage_ = Selector.GetHandle ("pathForPage:");
		static readonly IntPtr selFileIndexForPage_ = Selector.GetHandle ("fileIndexForPage:");
		static readonly IntPtr selURLForFileIndex_ = Selector.GetHandle ("URLForFileIndex:");
		static readonly IntPtr selFilesWithBasePath = Selector.GetHandle ("filesWithBasePath");
		static readonly IntPtr selAddBookmarkForPage_ = Selector.GetHandle ("addBookmarkForPage:");
		static readonly IntPtr selRemoveBookmarkForPage_ = Selector.GetHandle ("removeBookmarkForPage:");
		static readonly IntPtr selBookmarkForPage_ = Selector.GetHandle ("bookmarkForPage:");
		static readonly IntPtr selSaveChangedAnnotationsWithError_ = Selector.GetHandle ("saveChangedAnnotationsWithError:");
		static readonly IntPtr selPageNumberForPage_ = Selector.GetHandle ("pageNumberForPage:");
		static readonly IntPtr selCompensatedPageForPage_ = Selector.GetHandle ("compensatedPageForPage:");
		static readonly IntPtr selHasPageInfoForPage_ = Selector.GetHandle ("hasPageInfoForPage:");
		static readonly IntPtr selPageInfoForPage_ = Selector.GetHandle ("pageInfoForPage:");
		static readonly IntPtr selNearestPageInfoForPage_ = Selector.GetHandle ("nearestPageInfoForPage:");
		static readonly IntPtr selRectBoxForPage_ = Selector.GetHandle ("rectBoxForPage:");
		static readonly IntPtr selRotationForPage_ = Selector.GetHandle ("rotationForPage:");
		static readonly IntPtr selAspectRatioVariance = Selector.GetHandle ("aspectRatioVariance");
		static readonly IntPtr selClearCache = Selector.GetHandle ("clearCache");
		static readonly IntPtr selFillCache = Selector.GetHandle ("fillCache");
		static readonly IntPtr selUnlockWithPassword_ = Selector.GetHandle ("unlockWithPassword:");
		static readonly IntPtr selTextParserForPage_ = Selector.GetHandle ("textParserForPage:");
		static readonly IntPtr selDocumentProviderForPage_ = Selector.GetHandle ("documentProviderForPage:");
		static readonly IntPtr selDocumentParserForPage_ = Selector.GetHandle ("documentParserForPage:");
		static readonly IntPtr selAnnotationParserForPage_ = Selector.GetHandle ("annotationParserForPage:");
		static readonly IntPtr selPageLabelForPageSubstituteWithPlainLabel_ = Selector.GetHandle ("pageLabelForPage:substituteWithPlainLabel:");
		static readonly IntPtr selRenderImageForPageWithSizeClippedToRectWithAnnotationsOptions_ = Selector.GetHandle ("renderImageForPage:withSize:clippedToRect:withAnnotations:options:");
		static readonly IntPtr selRenderPageInContextWithSizeClippedToRectWithAnnotationsOptions_ = Selector.GetHandle ("renderPage:inContext:withSize:clippedToRect:withAnnotations:options:");
		static readonly IntPtr selObjectsAtPDFPointPageOptions_ = Selector.GetHandle ("objectsAtPDFPoint:page:options:");
		static readonly IntPtr selObjectsAtPDFRectPageOptions_ = Selector.GetHandle ("objectsAtPDFRect:page:options:");
		static readonly IntPtr selDidCreateDocumentProvider_ = Selector.GetHandle ("didCreateDocumentProvider:");
		static readonly IntPtr selThumbnailPathForPage_ = Selector.GetHandle ("thumbnailPathForPage:");
		static readonly IntPtr selPageContentForPage_ = Selector.GetHandle ("pageContentForPage:");
		static readonly IntPtr selBackgroundColorForPage_ = Selector.GetHandle ("backgroundColorForPage:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFDocument");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFDocument () : base (NSObjectFlag.Empty)
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
		public PSPDFDocument (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFDocument (IntPtr handle) : base (handle) {}

		[Export ("PDFDocument")]
		[CompilerGenerated]
		public static PSPDFDocument PDFDocument ()
		{
			return (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selPDFDocument));
		}
		
		[Export ("PDFDocumentWithData:")]
		[CompilerGenerated]
		public static PSPDFDocument PDFDocument (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			return (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selPDFDocumentWithData_, data.Handle));
		}
		
		[Export ("PDFDocumentWithDataProvider:")]
		[CompilerGenerated]
		internal static PSPDFDocument PDFDocumentWithDataProvider_ (System.IntPtr dataProvider)
		{
			return (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selPDFDocumentWithDataProvider_, dataProvider));
		}
		
		[Export ("PDFDocumentWithBaseURL:files:")]
		[CompilerGenerated]
		public static PSPDFDocument PDFDocumentWithBaseURL (NSUrl baseURL, NSArray files)
		{
			if (baseURL == null)
				throw new ArgumentNullException ("baseURL");
			if (files == null)
				throw new ArgumentNullException ("files");
			return (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selPDFDocumentWithBaseURLFiles_, baseURL.Handle, files.Handle));
		}
		
		[Export ("PDFDocumentWithURL:")]
		[CompilerGenerated]
		public static PSPDFDocument PDFDocumentWithURL (NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			return (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selPDFDocumentWithURL_, url.Handle));
		}
		
		[Export ("initWithData:")]
		[CompilerGenerated]
		public PSPDFDocument (NSData data) : base (NSObjectFlag.Empty)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithData_, data.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithData_, data.Handle);
			}
		}
		
		[Export ("initWithDataProvider:")]
		[CompilerGenerated]
		internal virtual PSPDFDocument InitWithDataProvider_ (System.IntPtr dataProvider)
		{
			if (IsDirectBinding) {
				return (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithDataProvider_, dataProvider));
			} else {
				return (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithDataProvider_, dataProvider));
			}
		}
		
		[Export ("initWithURL:")]
		[CompilerGenerated]
		public PSPDFDocument (NSUrl url) : base (NSObjectFlag.Empty)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithURL_, url.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithURL_, url.Handle);
			}
		}
		
		[Export ("initWithBaseURL:files:")]
		[CompilerGenerated]
		public PSPDFDocument (NSUrl basePath, NSArray files) : base (NSObjectFlag.Empty)
		{
			if (basePath == null)
				throw new ArgumentNullException ("basePath");
			if (files == null)
				throw new ArgumentNullException ("files");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithBaseURLFiles_, basePath.Handle, files.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithBaseURLFiles_, basePath.Handle, files.Handle);
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
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAppendFile_, nsfile);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selAppendFile_, nsfile);
			}
			NSString.ReleaseNative (nsfile);
			
		}
		
		[Export ("pathForPage:")]
		[CompilerGenerated]
		public virtual NSUrl PathForPage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				return (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selPathForPage_, page));
			} else {
				return (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selPathForPage_, page));
			}
		}
		
		[Export ("fileIndexForPage:")]
		[CompilerGenerated]
		public virtual int FileIndexForPage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.int_objc_msgSend_UInt32 (this.Handle, selFileIndexForPage_, page);
			} else {
				return ApiDefinition.Messaging.int_objc_msgSendSuper_UInt32 (this.SuperHandle, selFileIndexForPage_, page);
			}
		}
		
		[Export ("URLForFileIndex:")]
		[CompilerGenerated]
		public virtual NSUrl URLForFileIndex (int fileIndex)
		{
			if (IsDirectBinding) {
				return (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int (this.Handle, selURLForFileIndex_, fileIndex));
			} else {
				return (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, selURLForFileIndex_, fileIndex));
			}
		}
		
		[Export ("filesWithBasePath")]
		[CompilerGenerated]
		public virtual NSArray FilesWithBasePath ()
		{
			if (IsDirectBinding) {
				return (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFilesWithBasePath));
			} else {
				return (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFilesWithBasePath));
			}
		}
		
		[Export ("addBookmarkForPage:")]
		[CompilerGenerated]
		public virtual bool AddBookmarkForPage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_UInt32 (this.Handle, selAddBookmarkForPage_, page);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_UInt32 (this.SuperHandle, selAddBookmarkForPage_, page);
			}
		}
		
		[Export ("removeBookmarkForPage:")]
		[CompilerGenerated]
		public virtual bool RemoveBookmarkForPage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_UInt32 (this.Handle, selRemoveBookmarkForPage_, page);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_UInt32 (this.SuperHandle, selRemoveBookmarkForPage_, page);
			}
		}
		
		[Export ("bookmarkForPage:")]
		[CompilerGenerated]
		public virtual PSPDFBookmark BookmarkForPage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				return (PSPDFBookmark) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selBookmarkForPage_, page));
			} else {
				return (PSPDFBookmark) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selBookmarkForPage_, page));
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
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selSaveChangedAnnotationsWithError_, errorPtr);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selSaveChangedAnnotationsWithError_, errorPtr);
			}
			
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? (NSError)Runtime.GetNSObject(errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return ret;
		}
		
		[Export ("pageNumberForPage:")]
		[CompilerGenerated]
		public virtual System.UInt32 PageNumberForPage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend_UInt32 (this.Handle, selPageNumberForPage_, page);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper_UInt32 (this.SuperHandle, selPageNumberForPage_, page);
			}
		}
		
		[Export ("compensatedPageForPage:")]
		[CompilerGenerated]
		public virtual System.UInt32 CompensatedPageForPage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend_UInt32 (this.Handle, selCompensatedPageForPage_, page);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper_UInt32 (this.SuperHandle, selCompensatedPageForPage_, page);
			}
		}
		
		[Export ("hasPageInfoForPage:")]
		[CompilerGenerated]
		public virtual bool HasPageInfoForPage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_UInt32 (this.Handle, selHasPageInfoForPage_, page);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_UInt32 (this.SuperHandle, selHasPageInfoForPage_, page);
			}
		}
		
		[Export ("pageInfoForPage:")]
		[CompilerGenerated]
		public virtual PSPDFPageInfo PageInfoForPage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				return (PSPDFPageInfo) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selPageInfoForPage_, page));
			} else {
				return (PSPDFPageInfo) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selPageInfoForPage_, page));
			}
		}
		
		[Export ("pageInfoForPage:")]
		[CompilerGenerated]
		internal virtual PSPDFPageInfo PageInfoForPage_ (System.UInt32 page, System.IntPtr pageRef)
		{
			if (IsDirectBinding) {
				return (PSPDFPageInfo) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (this.Handle, selPageInfoForPage_, page, pageRef));
			} else {
				return (PSPDFPageInfo) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32_IntPtr (this.SuperHandle, selPageInfoForPage_, page, pageRef));
			}
		}
		
		[Export ("nearestPageInfoForPage:")]
		[CompilerGenerated]
		public virtual PSPDFPageInfo NearestPageInfoForPage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				return (PSPDFPageInfo) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selNearestPageInfoForPage_, page));
			} else {
				return (PSPDFPageInfo) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selNearestPageInfoForPage_, page));
			}
		}
		
		[Export ("rectBoxForPage:")]
		[CompilerGenerated]
		public virtual System.Drawing.RectangleF RectBoxForPage (System.UInt32 page)
		{
			System.Drawing.RectangleF ret;
			if (IsDirectBinding) {
				ApiDefinition.Messaging.RectangleF_objc_msgSend_stret_UInt32 (out ret, this.Handle, selRectBoxForPage_, page);
			} else {
				ApiDefinition.Messaging.RectangleF_objc_msgSendSuper_stret_UInt32 (out ret, this.SuperHandle, selRectBoxForPage_, page);
			}
			return ret;
		}
		
		[Export ("rotationForPage:")]
		[CompilerGenerated]
		public virtual int RotationForPage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.int_objc_msgSend_UInt32 (this.Handle, selRotationForPage_, page);
			} else {
				return ApiDefinition.Messaging.int_objc_msgSendSuper_UInt32 (this.SuperHandle, selRotationForPage_, page);
			}
		}
		
		[Export ("aspectRatioVariance")]
		[CompilerGenerated]
		public virtual float AspectRatioVariance ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selAspectRatioVariance);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selAspectRatioVariance);
			}
		}
		
		[Export ("clearCache")]
		[CompilerGenerated]
		public virtual void ClearCache ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selClearCache);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selClearCache);
			}
		}
		
		[Export ("fillCache")]
		[CompilerGenerated]
		public virtual void FillCache ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selFillCache);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selFillCache);
			}
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
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selUnlockWithPassword_, nspassword);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selUnlockWithPassword_, nspassword);
			}
			NSString.ReleaseNative (nspassword);
			
			return ret;
		}
		
		[Export ("textParserForPage:")]
		[CompilerGenerated]
		public virtual PSPDFTextParser TextParserForPage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				return (PSPDFTextParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selTextParserForPage_, page));
			} else {
				return (PSPDFTextParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selTextParserForPage_, page));
			}
		}
		
		[Export ("documentProviderForPage:")]
		[CompilerGenerated]
		public virtual PSPDFDocumentProvider DocumentProviderForPage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				return (PSPDFDocumentProvider) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selDocumentProviderForPage_, page));
			} else {
				return (PSPDFDocumentProvider) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selDocumentProviderForPage_, page));
			}
		}
		
		[Export ("documentParserForPage:")]
		[CompilerGenerated]
		public virtual PSPDFDocumentParser DocumentParserForPage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				return (PSPDFDocumentParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selDocumentParserForPage_, page));
			} else {
				return (PSPDFDocumentParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selDocumentParserForPage_, page));
			}
		}
		
		[Export ("annotationParserForPage:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotationParser AnnotationParserForPage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				return (PSPDFAnnotationParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selAnnotationParserForPage_, page));
			} else {
				return (PSPDFAnnotationParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selAnnotationParserForPage_, page));
			}
		}
		
		[Export ("pageLabelForPage:substituteWithPlainLabel:")]
		[CompilerGenerated]
		public virtual string PageLabelForPage (System.UInt32 page, bool substitute)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_bool (this.Handle, selPageLabelForPageSubstituteWithPlainLabel_, page, substitute));
			} else {
				return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32_bool (this.SuperHandle, selPageLabelForPageSubstituteWithPlainLabel_, page, substitute));
			}
		}
		
		[Export ("renderImageForPage:withSize:clippedToRect:withAnnotations:options:")]
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIImage RenderImageForPage (System.UInt32 page, System.Drawing.SizeF fullSize, System.Drawing.RectangleF clipRect, PSPDFAnnotation[] annotations, NSDictionary options)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			if (options == null)
				throw new ArgumentNullException ("options");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			MonoTouch.UIKit.UIImage ret;
			if (IsDirectBinding) {
				ret = (MonoTouch.UIKit.UIImage) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_SizeF_RectangleF_IntPtr_IntPtr (this.Handle, selRenderImageForPageWithSizeClippedToRectWithAnnotationsOptions_, page, fullSize, clipRect, nsa_annotations.Handle, options.Handle));
			} else {
				ret = (MonoTouch.UIKit.UIImage) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32_SizeF_RectangleF_IntPtr_IntPtr (this.SuperHandle, selRenderImageForPageWithSizeClippedToRectWithAnnotationsOptions_, page, fullSize, clipRect, nsa_annotations.Handle, options.Handle));
			}
			nsa_annotations.Dispose ();
			
			return ret;
		}
		
		[Export ("renderPage:inContext:withSize:clippedToRect:withAnnotations:options:")]
		[CompilerGenerated]
		internal virtual void RenderPage_ (System.UInt32 page, System.IntPtr context, System.Drawing.SizeF fullSize, System.Drawing.RectangleF clipRect, PSPDFAnnotation[] annotations, NSDictionary options)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			if (options == null)
				throw new ArgumentNullException ("options");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_UInt32_IntPtr_SizeF_RectangleF_IntPtr_IntPtr (this.Handle, selRenderPageInContextWithSizeClippedToRectWithAnnotationsOptions_, page, context, fullSize, clipRect, nsa_annotations.Handle, options.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32_IntPtr_SizeF_RectangleF_IntPtr_IntPtr (this.SuperHandle, selRenderPageInContextWithSizeClippedToRectWithAnnotationsOptions_, page, context, fullSize, clipRect, nsa_annotations.Handle, options.Handle);
			}
			nsa_annotations.Dispose ();
			
		}
		
		[Export ("objectsAtPDFPoint:page:options:")]
		[CompilerGenerated]
		public virtual NSDictionary ObjectsAtPDFPoint (System.Drawing.PointF pdfPoint, System.UInt32 page, NSDictionary options)
		{
			if (options == null)
				throw new ArgumentNullException ("options");
			if (IsDirectBinding) {
				return (NSDictionary) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_PointF_UInt32_IntPtr (this.Handle, selObjectsAtPDFPointPageOptions_, pdfPoint, page, options.Handle));
			} else {
				return (NSDictionary) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_PointF_UInt32_IntPtr (this.SuperHandle, selObjectsAtPDFPointPageOptions_, pdfPoint, page, options.Handle));
			}
		}
		
		[Export ("objectsAtPDFRect:page:options:")]
		[CompilerGenerated]
		public virtual NSDictionary ObjectsAtPDFRect (System.Drawing.RectangleF pdfRect, System.UInt32 page, NSDictionary options)
		{
			if (options == null)
				throw new ArgumentNullException ("options");
			if (IsDirectBinding) {
				return (NSDictionary) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_RectangleF_UInt32_IntPtr (this.Handle, selObjectsAtPDFRectPageOptions_, pdfRect, page, options.Handle));
			} else {
				return (NSDictionary) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_RectangleF_UInt32_IntPtr (this.SuperHandle, selObjectsAtPDFRectPageOptions_, pdfRect, page, options.Handle));
			}
		}
		
		[CompilerGenerated]
		public PSPDFDocumentProvider DidCreateDocumentProvider (PSPDFDocumentProvider documentProvider)
		{
			if (documentProvider == null)
				throw new ArgumentNullException ("documentProvider");
			return (PSPDFDocumentProvider) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selDidCreateDocumentProvider_, documentProvider.Handle));
		}
		
		[CompilerGenerated]
		public NSUrl ThumbnailPathForPage (System.UInt32 page)
		{
			return (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selThumbnailPathForPage_, page));
		}
		
		[CompilerGenerated]
		public string PageContentForPage (System.UInt32 page)
		{
			return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selPageContentForPage_, page));
		}
		
		[CompilerGenerated]
		public MonoTouch.UIKit.UIColor BackgroundColorForPage (System.UInt32 page)
		{
			return (MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selBackgroundColorForPage_, page));
		}
		
		object __mt_BasePath_var;
		[CompilerGenerated]
		public virtual NSUrl BasePath {
			[Export ("basePath")]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBasePath));
				} else {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBasePath));
				}
				MarkDirty ();
				__mt_BasePath_var = ret;
				return ret;
			}
			
			[Export ("setBasePath:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBasePath_, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBasePath_, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_BasePath_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual System.String[] Files {
			[Export ("files", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSArray.StringArrayFromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFiles));
				} else {
					return NSArray.StringArrayFromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFiles));
				}
			}
			
			[Export ("setFiles:", ArgumentSemantic.Copy)]
			set {
				var nsa_value = value == null ? null : NSArray.FromStrings (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFiles_, nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFiles_, nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
			}
		}
		
		object __mt_FileURL_var;
		[CompilerGenerated]
		public virtual NSUrl FileURL {
			[Export ("fileURL")]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFileURL));
				} else {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFileURL));
				}
				MarkDirty ();
				__mt_FileURL_var = ret;
				return ret;
			}
			
			[Export ("setFileURL:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFileURL_, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFileURL_, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_FileURL_var = value;
			}
		}
		
		object __mt_Data_var;
		[CompilerGenerated]
		public virtual NSData Data {
			[Export ("data")]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret = (NSData) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selData));
				} else {
					ret = (NSData) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selData));
				}
				MarkDirty ();
				__mt_Data_var = ret;
				return ret;
			}
			
		}
		
		object __mt_DataProvider_var;
		[CompilerGenerated]
		public virtual NSObject DataProvider {
			[Export ("dataProvider")]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDataProvider));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDataProvider));
				}
				MarkDirty ();
				__mt_DataProvider_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Title {
			[Export ("title", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTitle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTitle));
				}
			}
			
			[Export ("setTitle:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTitle_, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTitle_, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool TitleLoaded {
			[Export ("isTitleLoaded", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsTitleLoaded);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsTitleLoaded);
				}
			}
			
		}
		
		object __mt_Metadata_var;
		[CompilerGenerated]
		public virtual NSDictionary Metadata {
			[Export ("metadata")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMetadata));
				} else {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMetadata));
				}
				MarkDirty ();
				__mt_Metadata_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Uid {
			[Export ("uid", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUid));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUid));
				}
			}
			
			[Export ("setUid:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUid_, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUid_, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		object __mt_Bookmarks_var;
		[CompilerGenerated]
		public virtual PSPDFBookmark[] Bookmarks {
			[Export ("bookmarks", ArgumentSemantic.Copy)]
			get {
				PSPDFBookmark[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFBookmark>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBookmarks));
				} else {
					ret = NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFBookmark>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBookmarks));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Bookmarks_var = ret;
				return ret;
			}
			
			[Export ("setBookmarks:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBookmarks_, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBookmarks_, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_Bookmarks_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool CanEmbedAnnotations {
			[Export ("canEmbedAnnotations", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanEmbedAnnotations);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selCanEmbedAnnotations);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual System.UInt32 PageCount {
			[Export ("pageCount")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPageCount);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selPageCount);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string CacheDirectory {
			[Export ("cacheDirectory", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCacheDirectory));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCacheDirectory));
				}
			}
			
			[Export ("setCacheDirectory:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCacheDirectory_, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCacheDirectory_, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool AspectRatioEqual {
			[Export ("isAspectRatioEqual", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAspectRatioEqual);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsAspectRatioEqual);
				}
			}
			
			[Export ("setAspectRatioEqual:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAspectRatioEqual_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAspectRatioEqual_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AnnotationsEnabled {
			[Export ("isAnnotationsEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAnnotationsEnabled);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsAnnotationsEnabled);
				}
			}
			
			[Export ("setAnnotationsEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAnnotationsEnabled_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAnnotationsEnabled_, value);
				}
			}
		}
		
		object __mt_DisplayingPdfController_var;
		[CompilerGenerated]
		public virtual PSPDFViewController DisplayingPdfController {
			[Export ("displayingPdfController")]
			get {
				PSPDFViewController ret;
				if (IsDirectBinding) {
					ret = (PSPDFViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDisplayingPdfController));
				} else {
					ret = (PSPDFViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDisplayingPdfController));
				}
				MarkDirty ();
				__mt_DisplayingPdfController_var = ret;
				return ret;
			}
			
			[Export ("setDisplayingPdfController:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDisplayingPdfController_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDisplayingPdfController_, value.Handle);
				}
				MarkDirty ();
				__mt_DisplayingPdfController_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string Password {
			[Export ("password", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPassword));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPassword));
				}
			}
			
			[Export ("setPassword:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPassword_, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPassword_, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool Valid {
			[Export ("isValid", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsValid);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsValid);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool AllowsPrinting {
			[Export ("allowsPrinting", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsPrinting);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAllowsPrinting);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsEncrypted {
			[Export ("isEncrypted", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsEncrypted);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsEncrypted);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string EncryptionFilter {
			[Export ("encryptionFilter", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selEncryptionFilter));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selEncryptionFilter));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsLocked {
			[Export ("isLocked", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsLocked);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsLocked);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool AllowsCopying {
			[Export ("allowsCopying", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsCopying);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAllowsCopying);
				}
			}
			
		}
		
		object __mt_TextSearch_var;
		[CompilerGenerated]
		public virtual PSPDFTextSearch TextSearch {
			[Export ("textSearch")]
			get {
				PSPDFTextSearch ret;
				if (IsDirectBinding) {
					ret = (PSPDFTextSearch) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTextSearch));
				} else {
					ret = (PSPDFTextSearch) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTextSearch));
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
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTextSearch_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTextSearch_, value.Handle);
				}
				MarkDirty ();
				__mt_TextSearch_var = value;
			}
		}
		
		object __mt_DocumentProviders_var;
		[CompilerGenerated]
		public virtual PSPDFDocumentProvider[] DocumentProviders {
			[Export ("documentProviders")]
			get {
				PSPDFDocumentProvider[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFDocumentProvider>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocumentProviders));
				} else {
					ret = NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFDocumentProvider>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocumentProviders));
				}
				MarkDirty ();
				__mt_DocumentProviders_var = ret;
				return ret;
			}
			
		}
		
		object __mt_OutlineParser_var;
		[CompilerGenerated]
		public virtual PSPDFOutlineParser OutlineParser {
			[Export ("outlineParser")]
			get {
				PSPDFOutlineParser ret;
				if (IsDirectBinding) {
					ret = (PSPDFOutlineParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOutlineParser));
				} else {
					ret = (PSPDFOutlineParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOutlineParser));
				}
				MarkDirty ();
				__mt_OutlineParser_var = ret;
				return ret;
			}
			
		}
		
		object __mt_AnnotationParser_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotationParser AnnotationParser {
			[Export ("annotationParser")]
			get {
				PSPDFAnnotationParser ret;
				if (IsDirectBinding) {
					ret = (PSPDFAnnotationParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAnnotationParser));
				} else {
					ret = (PSPDFAnnotationParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAnnotationParser));
				}
				MarkDirty ();
				__mt_AnnotationParser_var = ret;
				return ret;
			}
			
		}
		
		object __mt_OverrideClassNames_var;
		[CompilerGenerated]
		public virtual NSDictionary OverrideClassNames {
			[Export ("overrideClassNames")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOverrideClassNames));
				} else {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOverrideClassNames));
				}
				MarkDirty ();
				__mt_OverrideClassNames_var = ret;
				return ret;
			}
			
			[Export ("setOverrideClassNames:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetOverrideClassNames_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetOverrideClassNames_, value.Handle);
				}
				MarkDirty ();
				__mt_OverrideClassNames_var = value;
			}
		}
		
		static readonly IntPtr __Internal_libraryHandle = Dlfcn.dlopen (null, 0);
		static NSString _PSPDFObjectsText;
		public static NSString PSPDFObjectsText {
			get {
				if (_PSPDFObjectsText == null)
					_PSPDFObjectsText = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFObjectsText");
				return _PSPDFObjectsText;
			}
		}
		static NSString _PSPDFObjectsFullWords;
		public static NSString PSPDFObjectsFullWords {
			get {
				if (_PSPDFObjectsFullWords == null)
					_PSPDFObjectsFullWords = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFObjectsFullWords");
				return _PSPDFObjectsFullWords;
			}
		}
		static NSString _PSPDFObjectsRespectTextBlocks;
		public static NSString PSPDFObjectsRespectTextBlocks {
			get {
				if (_PSPDFObjectsRespectTextBlocks == null)
					_PSPDFObjectsRespectTextBlocks = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFObjectsRespectTextBlocks");
				return _PSPDFObjectsRespectTextBlocks;
			}
		}
		static NSString _PSPDFObjectsAnnotations;
		public static NSString PSPDFObjectsAnnotations {
			get {
				if (_PSPDFObjectsAnnotations == null)
					_PSPDFObjectsAnnotations = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFObjectsAnnotations");
				return _PSPDFObjectsAnnotations;
			}
		}
		static NSString _PSPDFGlyphs;
		public static NSString PSPDFGlyphs {
			get {
				if (_PSPDFGlyphs == null)
					_PSPDFGlyphs = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFGlyphs");
				return _PSPDFGlyphs;
			}
		}
		static NSString _PSPDFWords;
		public static NSString PSPDFWords {
			get {
				if (_PSPDFWords == null)
					_PSPDFWords = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFWords");
				return _PSPDFWords;
			}
		}
		static NSString _PSPDFTextBlocks;
		public static NSString PSPDFTextBlocks {
			get {
				if (_PSPDFTextBlocks == null)
					_PSPDFTextBlocks = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFTextBlocks");
				return _PSPDFTextBlocks;
			}
		}
		static NSString _PSPDFAnnotations;
		public static NSString PSPDFAnnotations {
			get {
				if (_PSPDFAnnotations == null)
					_PSPDFAnnotations = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFAnnotations");
				return _PSPDFAnnotations;
			}
		}
		static NSString _PSPDFMetadataKeyTitle;
		public static NSString PSPDFMetadataKeyTitle {
			get {
				if (_PSPDFMetadataKeyTitle == null)
					_PSPDFMetadataKeyTitle = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFMetadataKeyTitle");
				return _PSPDFMetadataKeyTitle;
			}
		}
		static NSString _PSPDFMetadataKeyAuthor;
		public static NSString PSPDFMetadataKeyAuthor {
			get {
				if (_PSPDFMetadataKeyAuthor == null)
					_PSPDFMetadataKeyAuthor = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFMetadataKeyAuthor");
				return _PSPDFMetadataKeyAuthor;
			}
		}
		static NSString _PSPDFMetadataKeySubject;
		public static NSString PSPDFMetadataKeySubject {
			get {
				if (_PSPDFMetadataKeySubject == null)
					_PSPDFMetadataKeySubject = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFMetadataKeySubject");
				return _PSPDFMetadataKeySubject;
			}
		}
		static NSString _PSPDFMetadataKeyKeywords;
		public static NSString PSPDFMetadataKeyKeywords {
			get {
				if (_PSPDFMetadataKeyKeywords == null)
					_PSPDFMetadataKeyKeywords = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFMetadataKeyKeywords");
				return _PSPDFMetadataKeyKeywords;
			}
		}
		static NSString _PSPDFMetadataKeyCreator;
		public static NSString PSPDFMetadataKeyCreator {
			get {
				if (_PSPDFMetadataKeyCreator == null)
					_PSPDFMetadataKeyCreator = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFMetadataKeyCreator");
				return _PSPDFMetadataKeyCreator;
			}
		}
		static NSString _PSPDFMetadataKeyProducer;
		public static NSString PSPDFMetadataKeyProducer {
			get {
				if (_PSPDFMetadataKeyProducer == null)
					_PSPDFMetadataKeyProducer = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFMetadataKeyProducer");
				return _PSPDFMetadataKeyProducer;
			}
		}
		static NSString _PSPDFMetadataKeyCreationDate;
		public static NSString PSPDFMetadataKeyCreationDate {
			get {
				if (_PSPDFMetadataKeyCreationDate == null)
					_PSPDFMetadataKeyCreationDate = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFMetadataKeyCreationDate");
				return _PSPDFMetadataKeyCreationDate;
			}
		}
		static NSString _PSPDFMetadataKeyModDate;
		public static NSString PSPDFMetadataKeyModDate {
			get {
				if (_PSPDFMetadataKeyModDate == null)
					_PSPDFMetadataKeyModDate = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFMetadataKeyModDate");
				return _PSPDFMetadataKeyModDate;
			}
		}
		static NSString _PSPDFMetadataKeyTrapped;
		public static NSString PSPDFMetadataKeyTrapped {
			get {
				if (_PSPDFMetadataKeyTrapped == null)
					_PSPDFMetadataKeyTrapped = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFMetadataKeyTrapped");
				return _PSPDFMetadataKeyTrapped;
			}
		}
		protected override void Dispose (bool disposing)
		{
			__mt_BasePath_var = null;
			__mt_FileURL_var = null;
			__mt_Data_var = null;
			__mt_DataProvider_var = null;
			__mt_Metadata_var = null;
			__mt_Bookmarks_var = null;
			__mt_DisplayingPdfController_var = null;
			__mt_TextSearch_var = null;
			__mt_DocumentProviders_var = null;
			__mt_OutlineParser_var = null;
			__mt_AnnotationParser_var = null;
			__mt_OverrideClassNames_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFDocument */
}
