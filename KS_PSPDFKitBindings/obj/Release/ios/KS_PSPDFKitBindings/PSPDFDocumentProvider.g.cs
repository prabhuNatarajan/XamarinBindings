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
	[Register("PSPDFDocumentProvider", true)]
	public unsafe partial class PSPDFDocumentProvider : NSObject {
		[CompilerGenerated]
		const string selFileURL = "fileURL";
		static readonly IntPtr selFileURLHandle = Selector.GetHandle ("fileURL");
		[CompilerGenerated]
		const string selData = "data";
		static readonly IntPtr selDataHandle = Selector.GetHandle ("data");
		[CompilerGenerated]
		const string selDataProvider = "dataProvider";
		static readonly IntPtr selDataProviderHandle = Selector.GetHandle ("dataProvider");
		[CompilerGenerated]
		const string selFileSize = "fileSize";
		static readonly IntPtr selFileSizeHandle = Selector.GetHandle ("fileSize");
		[CompilerGenerated]
		const string selDocument = "document";
		static readonly IntPtr selDocumentHandle = Selector.GetHandle ("document");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selPageCount = "pageCount";
		static readonly IntPtr selPageCountHandle = Selector.GetHandle ("pageCount");
		[CompilerGenerated]
		const string selPageCountUnfiltered = "pageCountUnfiltered";
		static readonly IntPtr selPageCountUnfilteredHandle = Selector.GetHandle ("pageCountUnfiltered");
		[CompilerGenerated]
		const string selFirstPageIndex = "firstPageIndex";
		static readonly IntPtr selFirstPageIndexHandle = Selector.GetHandle ("firstPageIndex");
		[CompilerGenerated]
		const string selPageRange = "pageRange";
		static readonly IntPtr selPageRangeHandle = Selector.GetHandle ("pageRange");
		[CompilerGenerated]
		const string selSetPageRange_ = "setPageRange:";
		static readonly IntPtr selSetPageRange_Handle = Selector.GetHandle ("setPageRange:");
		[CompilerGenerated]
		const string selPassword = "password";
		static readonly IntPtr selPasswordHandle = Selector.GetHandle ("password");
		[CompilerGenerated]
		const string selSetPassword_ = "setPassword:";
		static readonly IntPtr selSetPassword_Handle = Selector.GetHandle ("setPassword:");
		[CompilerGenerated]
		const string selAllowsPrinting = "allowsPrinting";
		static readonly IntPtr selAllowsPrintingHandle = Selector.GetHandle ("allowsPrinting");
		[CompilerGenerated]
		const string selAllowsCopying = "allowsCopying";
		static readonly IntPtr selAllowsCopyingHandle = Selector.GetHandle ("allowsCopying");
		[CompilerGenerated]
		const string selSetAllowsCopying_ = "setAllowsCopying:";
		static readonly IntPtr selSetAllowsCopying_Handle = Selector.GetHandle ("setAllowsCopying:");
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
		const string selCanEmbedAnnotations = "canEmbedAnnotations";
		static readonly IntPtr selCanEmbedAnnotationsHandle = Selector.GetHandle ("canEmbedAnnotations");
		[CompilerGenerated]
		const string selSetCanEmbedAnnotations_ = "setCanEmbedAnnotations:";
		static readonly IntPtr selSetCanEmbedAnnotations_Handle = Selector.GetHandle ("setCanEmbedAnnotations:");
		[CompilerGenerated]
		const string selMetadata = "metadata";
		static readonly IntPtr selMetadataHandle = Selector.GetHandle ("metadata");
		[CompilerGenerated]
		const string selIsMetadataLoaded = "isMetadataLoaded";
		static readonly IntPtr selIsMetadataLoadedHandle = Selector.GetHandle ("isMetadataLoaded");
		[CompilerGenerated]
		const string selTitle = "title";
		static readonly IntPtr selTitleHandle = Selector.GetHandle ("title");
		[CompilerGenerated]
		const string selOutlineParser = "outlineParser";
		static readonly IntPtr selOutlineParserHandle = Selector.GetHandle ("outlineParser");
		[CompilerGenerated]
		const string selSetOutlineParser_ = "setOutlineParser:";
		static readonly IntPtr selSetOutlineParser_Handle = Selector.GetHandle ("setOutlineParser:");
		[CompilerGenerated]
		const string selDocumentParser = "documentParser";
		static readonly IntPtr selDocumentParserHandle = Selector.GetHandle ("documentParser");
		[CompilerGenerated]
		const string selSetDocumentParser_ = "setDocumentParser:";
		static readonly IntPtr selSetDocumentParser_Handle = Selector.GetHandle ("setDocumentParser:");
		[CompilerGenerated]
		const string selIsDocumentParserLoaded = "isDocumentParserLoaded";
		static readonly IntPtr selIsDocumentParserLoadedHandle = Selector.GetHandle ("isDocumentParserLoaded");
		[CompilerGenerated]
		const string selAnnotationParser = "annotationParser";
		static readonly IntPtr selAnnotationParserHandle = Selector.GetHandle ("annotationParser");
		[CompilerGenerated]
		const string selSetAnnotationParser_ = "setAnnotationParser:";
		static readonly IntPtr selSetAnnotationParser_Handle = Selector.GetHandle ("setAnnotationParser:");
		[CompilerGenerated]
		const string selLabelParser = "labelParser";
		static readonly IntPtr selLabelParserHandle = Selector.GetHandle ("labelParser");
		[CompilerGenerated]
		const string selSetLabelParser_ = "setLabelParser:";
		static readonly IntPtr selSetLabelParser_Handle = Selector.GetHandle ("setLabelParser:");
		[CompilerGenerated]
		const string selHasOpenDocumentRef = "hasOpenDocumentRef";
		static readonly IntPtr selHasOpenDocumentRefHandle = Selector.GetHandle ("hasOpenDocumentRef");
		[CompilerGenerated]
		const string selInitWithFileURLDocument_ = "initWithFileURL:document:";
		static readonly IntPtr selInitWithFileURLDocument_Handle = Selector.GetHandle ("initWithFileURL:document:");
		[CompilerGenerated]
		const string selInitWithDataDocument_ = "initWithData:document:";
		static readonly IntPtr selInitWithDataDocument_Handle = Selector.GetHandle ("initWithData:document:");
		[CompilerGenerated]
		const string selInitWithDataProviderDocument_ = "initWithDataProvider:document:";
		static readonly IntPtr selInitWithDataProviderDocument_Handle = Selector.GetHandle ("initWithDataProvider:document:");
		[CompilerGenerated]
		const string selDataRepresentationWithError_ = "dataRepresentationWithError:";
		static readonly IntPtr selDataRepresentationWithError_Handle = Selector.GetHandle ("dataRepresentationWithError:");
		[CompilerGenerated]
		const string selRequestDocumentRefWithOwner_ = "requestDocumentRefWithOwner:";
		static readonly IntPtr selRequestDocumentRefWithOwner_Handle = Selector.GetHandle ("requestDocumentRefWithOwner:");
		[CompilerGenerated]
		const string selReleaseDocumentRefWithOwner_ = "releaseDocumentRef:withOwner:";
		static readonly IntPtr selReleaseDocumentRefWithOwner_Handle = Selector.GetHandle ("releaseDocumentRef:withOwner:");
		[CompilerGenerated]
		const string selPerformBlock_ = "performBlock:";
		static readonly IntPtr selPerformBlock_Handle = Selector.GetHandle ("performBlock:");
		[CompilerGenerated]
		const string selIterateOverPageRef_ = "iterateOverPageRef:";
		static readonly IntPtr selIterateOverPageRef_Handle = Selector.GetHandle ("iterateOverPageRef:");
		[CompilerGenerated]
		const string selRequestPageRefForPageNumberError_ = "requestPageRefForPageNumber:error:";
		static readonly IntPtr selRequestPageRefForPageNumberError_Handle = Selector.GetHandle ("requestPageRefForPageNumber:error:");
		[CompilerGenerated]
		const string selRequestPageRefForPageNumber_ = "requestPageRefForPageNumber:";
		static readonly IntPtr selRequestPageRefForPageNumber_Handle = Selector.GetHandle ("requestPageRefForPageNumber:");
		[CompilerGenerated]
		const string selReleasePageRef_ = "releasePageRef:";
		static readonly IntPtr selReleasePageRef_Handle = Selector.GetHandle ("releasePageRef:");
		[CompilerGenerated]
		const string selFlushDocumentReference = "flushDocumentReference";
		static readonly IntPtr selFlushDocumentReferenceHandle = Selector.GetHandle ("flushDocumentReference");
		[CompilerGenerated]
		const string selPageInfoForPage_ = "pageInfoForPage:";
		static readonly IntPtr selPageInfoForPage_Handle = Selector.GetHandle ("pageInfoForPage:");
		[CompilerGenerated]
		const string selTranslateCappedPageToRealPage_ = "translateCappedPageToRealPage:";
		static readonly IntPtr selTranslateCappedPageToRealPage_Handle = Selector.GetHandle ("translateCappedPageToRealPage:");
		[CompilerGenerated]
		const string selTranslateRealPageToCappedPage_ = "translateRealPageToCappedPage:";
		static readonly IntPtr selTranslateRealPageToCappedPage_Handle = Selector.GetHandle ("translateRealPageToCappedPage:");
		[CompilerGenerated]
		const string selUnlockWithPassword_ = "unlockWithPassword:";
		static readonly IntPtr selUnlockWithPassword_Handle = Selector.GetHandle ("unlockWithPassword:");
		[CompilerGenerated]
		const string selSaveChangedAnnotationsWithError_ = "saveChangedAnnotationsWithError:";
		static readonly IntPtr selSaveChangedAnnotationsWithError_Handle = Selector.GetHandle ("saveChangedAnnotationsWithError:");
		[CompilerGenerated]
		const string selTextParserForPage_ = "textParserForPage:";
		static readonly IntPtr selTextParserForPage_Handle = Selector.GetHandle ("textParserForPage:");
		[CompilerGenerated]
		const string selHasLoadedTextParserForPage_ = "hasLoadedTextParserForPage:";
		static readonly IntPtr selHasLoadedTextParserForPage_Handle = Selector.GetHandle ("hasLoadedTextParserForPage:");
		[CompilerGenerated]
		const string selPageInfoForPageNoFetching_ = "pageInfoForPageNoFetching:";
		static readonly IntPtr selPageInfoForPageNoFetching_Handle = Selector.GetHandle ("pageInfoForPageNoFetching:");
		[CompilerGenerated]
		const string selPageInfoForPagePageRef_ = "pageInfoForPage:pageRef:";
		static readonly IntPtr selPageInfoForPagePageRef_Handle = Selector.GetHandle ("pageInfoForPage:pageRef:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFDocumentProvider");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFDocumentProvider () : base (NSObjectFlag.Empty)
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
		public PSPDFDocumentProvider (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFDocumentProvider (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFDocumentProvider (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFileURL:document:")]
		[CompilerGenerated]
		public PSPDFDocumentProvider (NSUrl fileURL, PSPDFDocument document)
			: base (NSObjectFlag.Empty)
		{
			if (fileURL == null)
				throw new ArgumentNullException ("fileURL");
			if (document == null)
				throw new ArgumentNullException ("document");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithFileURLDocument_Handle, fileURL.Handle, document.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithFileURLDocument_Handle, fileURL.Handle, document.Handle);
			}
		}
		
		[Export ("initWithData:document:")]
		[CompilerGenerated]
		public PSPDFDocumentProvider (NSData data, PSPDFDocument document)
			: base (NSObjectFlag.Empty)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (document == null)
				throw new ArgumentNullException ("document");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithDataDocument_Handle, data.Handle, document.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithDataDocument_Handle, data.Handle, document.Handle);
			}
		}
		
		[Export ("initWithDataProvider:document:")]
		[CompilerGenerated]
		internal PSPDFDocumentProvider (global::System.IntPtr dataProvider, PSPDFDocument document)
			: base (NSObjectFlag.Empty)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithDataProviderDocument_Handle, dataProvider, document.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithDataProviderDocument_Handle, dataProvider, document.Handle);
			}
		}
		
		[Export ("dataRepresentationWithError:")]
		[CompilerGenerated]
		public virtual NSData DataRepresentationWithError (out NSError error)
		{
			IntPtr errorPtr = Marshal.AllocHGlobal(4);
			Marshal.WriteInt32(errorPtr, 0);
			
			NSData ret;
			if (IsDirectBinding) {
				ret = (NSData) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selDataRepresentationWithError_Handle, errorPtr));
			} else {
				ret = (NSData) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selDataRepresentationWithError_Handle, errorPtr));
			}
			
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? (NSError)Runtime.GetNSObject(errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return ret;
		}
		
		[Export ("requestDocumentRefWithOwner:")]
		[CompilerGenerated]
		internal virtual global::System.IntPtr RequestDocumentRefWithOwner_ (NSObject owner)
		{
			if (owner == null)
				throw new ArgumentNullException ("owner");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selRequestDocumentRefWithOwner_Handle, owner.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selRequestDocumentRefWithOwner_Handle, owner.Handle);
			}
		}
		
		[Export ("releaseDocumentRef:withOwner:")]
		[CompilerGenerated]
		internal virtual void ReleaseDocumentRef_ (global::System.IntPtr documentRef, NSObject owner)
		{
			if (owner == null)
				throw new ArgumentNullException ("owner");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selReleaseDocumentRefWithOwner_Handle, documentRef, owner.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selReleaseDocumentRefWithOwner_Handle, documentRef, owner.Handle);
			}
		}
		
		[Export ("performBlock:")]
		[CompilerGenerated]
		public unsafe virtual void PerformBlock (PSPDFDocumentProviderPerformBlock documentRefBlock)
		{
			if (documentRefBlock == null)
				throw new ArgumentNullException ("documentRefBlock");
			BlockLiteral *block_ptr_documentRefBlock;
			BlockLiteral block_documentRefBlock;
			block_documentRefBlock = new BlockLiteral ();
			block_ptr_documentRefBlock = &block_documentRefBlock;
			block_documentRefBlock.SetupBlock (static_InnerPSPDFDocumentProviderPerformBlock, documentRefBlock);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selPerformBlock_Handle, (IntPtr) block_ptr_documentRefBlock);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selPerformBlock_Handle, (IntPtr) block_ptr_documentRefBlock);
			}
			block_ptr_documentRefBlock->CleanupBlock ();
			
		}
		
		[Export ("iterateOverPageRef:")]
		[CompilerGenerated]
		public unsafe virtual void IterateOverPageRef (PSPDFDocumentProviderIterateOverPageRef pageRefBlock)
		{
			if (pageRefBlock == null)
				throw new ArgumentNullException ("pageRefBlock");
			BlockLiteral *block_ptr_pageRefBlock;
			BlockLiteral block_pageRefBlock;
			block_pageRefBlock = new BlockLiteral ();
			block_ptr_pageRefBlock = &block_pageRefBlock;
			block_pageRefBlock.SetupBlock (static_InnerPSPDFDocumentProviderIterateOverPageRef, pageRefBlock);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selIterateOverPageRef_Handle, (IntPtr) block_ptr_pageRefBlock);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selIterateOverPageRef_Handle, (IntPtr) block_ptr_pageRefBlock);
			}
			block_ptr_pageRefBlock->CleanupBlock ();
			
		}
		
		[Export ("requestPageRefForPageNumber:error:")]
		[CompilerGenerated]
		internal virtual global::System.IntPtr RequestPageRefForPageNumber_ (global::System.UInt32 page, out NSError error)
		{
			IntPtr errorPtr = Marshal.AllocHGlobal(4);
			Marshal.WriteInt32(errorPtr, 0);
			
			global::System.IntPtr ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (this.Handle, selRequestPageRefForPageNumberError_Handle, page, errorPtr);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32_IntPtr (this.SuperHandle, selRequestPageRefForPageNumberError_Handle, page, errorPtr);
			}
			
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? (NSError)Runtime.GetNSObject(errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return ret;
		}
		
		[Export ("requestPageRefForPageNumber:")]
		[CompilerGenerated]
		internal virtual global::System.IntPtr RequestPageRefForPageNumber_ (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selRequestPageRefForPageNumber_Handle, page);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selRequestPageRefForPageNumber_Handle, page);
			}
		}
		
		[Export ("releasePageRef:")]
		[CompilerGenerated]
		internal virtual void ReleasePageRef_ (global::System.IntPtr pageRef)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selReleasePageRef_Handle, pageRef);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selReleasePageRef_Handle, pageRef);
			}
		}
		
		[Export ("flushDocumentReference")]
		[CompilerGenerated]
		public virtual bool FlushDocumentReference ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selFlushDocumentReferenceHandle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selFlushDocumentReferenceHandle);
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
		
		[Export ("translateCappedPageToRealPage:")]
		[CompilerGenerated]
		public virtual global::System.UInt32 TranslateCappedPageToRealPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend_UInt32 (this.Handle, selTranslateCappedPageToRealPage_Handle, page);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper_UInt32 (this.SuperHandle, selTranslateCappedPageToRealPage_Handle, page);
			}
		}
		
		[Export ("translateRealPageToCappedPage:")]
		[CompilerGenerated]
		public virtual global::System.UInt32 TranslateRealPageToCappedPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend_UInt32 (this.Handle, selTranslateRealPageToCappedPage_Handle, page);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper_UInt32 (this.SuperHandle, selTranslateRealPageToCappedPage_Handle, page);
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
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selUnlockWithPassword_Handle, nspassword);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selUnlockWithPassword_Handle, nspassword);
			}
			NSString.ReleaseNative (nspassword);
			
			return ret;
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
		
		[Export ("pageInfoForPageNoFetching:")]
		[CompilerGenerated]
		public virtual PSPDFPageInfo PageInfoForPageNoFetching (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return (PSPDFPageInfo) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selPageInfoForPageNoFetching_Handle, page));
			} else {
				return (PSPDFPageInfo) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selPageInfoForPageNoFetching_Handle, page));
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
			
		}
		
		[CompilerGenerated]
		object __mt_Data_var;
		[CompilerGenerated]
		public virtual NSData Data {
			[Export ("data")]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret = (NSData) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDataHandle));
				} else {
					ret = (NSData) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDataHandle));
				}
				MarkDirty ();
				__mt_Data_var = ret;
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
		public virtual global::System.UInt64 FileSize {
			[Export ("fileSize")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selFileSizeHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, selFileSizeHandle);
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
		public PSPDFDocumentProviderDelegate Delegate {
			get {
				return WeakDelegate as PSPDFDocumentProviderDelegate;
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
		public virtual global::System.UInt32 PageCount {
			[Export ("pageCount", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPageCountHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selPageCountHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 PageCountUnfiltered {
			[Export ("pageCountUnfiltered", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPageCountUnfilteredHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selPageCountUnfilteredHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 FirstPageIndex {
			[Export ("firstPageIndex", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selFirstPageIndexHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selFirstPageIndexHandle);
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
		public virtual bool CanEmbedAnnotations {
			[Export ("canEmbedAnnotations", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanEmbedAnnotationsHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selCanEmbedAnnotationsHandle);
				}
			}
			
			[Export ("setCanEmbedAnnotations:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetCanEmbedAnnotations_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetCanEmbedAnnotations_Handle, value);
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
		public virtual bool MetadataLoaded {
			[Export ("isMetadataLoaded", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsMetadataLoadedHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsMetadataLoadedHandle);
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
			
			[Export ("setOutlineParser:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetOutlineParser_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetOutlineParser_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_OutlineParser_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_DocumentParser_var;
		[CompilerGenerated]
		public virtual PSPDFDocumentParser DocumentParser {
			[Export ("documentParser")]
			get {
				PSPDFDocumentParser ret;
				if (IsDirectBinding) {
					ret = (PSPDFDocumentParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocumentParserHandle));
				} else {
					ret = (PSPDFDocumentParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocumentParserHandle));
				}
				MarkDirty ();
				__mt_DocumentParser_var = ret;
				return ret;
			}
			
			[Export ("setDocumentParser:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDocumentParser_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDocumentParser_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_DocumentParser_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsDocumentParserLoaded {
			[Export ("isDocumentParserLoaded", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDocumentParserLoadedHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsDocumentParserLoadedHandle);
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
			
			[Export ("setAnnotationParser:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAnnotationParser_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAnnotationParser_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_AnnotationParser_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_LabelParser_var;
		[CompilerGenerated]
		public virtual PSPDFLabelParser LabelParser {
			[Export ("labelParser")]
			get {
				PSPDFLabelParser ret;
				if (IsDirectBinding) {
					ret = (PSPDFLabelParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLabelParserHandle));
				} else {
					ret = (PSPDFLabelParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLabelParserHandle));
				}
				MarkDirty ();
				__mt_LabelParser_var = ret;
				return ret;
			}
			
			[Export ("setLabelParser:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLabelParser_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLabelParser_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_LabelParser_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool HasOpenDocumentRef {
			[Export ("hasOpenDocumentRef", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasOpenDocumentRefHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selHasOpenDocumentRefHandle);
				}
			}
			
		}
		
		//
		// Events and properties from the delegate
		//
		
		_PSPDFDocumentProviderDelegate EnsurePSPDFDocumentProviderDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _PSPDFDocumentProviderDelegate))){
				del = new _PSPDFDocumentProviderDelegate ();
				WeakDelegate = del;
			}
			return (_PSPDFDocumentProviderDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _PSPDFDocumentProviderDelegate : KS_PSPDFKitBindings.PSPDFDocumentProviderDelegate { 
			public _PSPDFDocumentProviderDelegate () {}
			
			internal PSPDFDocumentProviderShouldAppendData shouldAppendData;
			[Preserve (Conditional = true)]
			public override bool ShouldAppendData (KS_PSPDFKitBindings.PSPDFDocumentProvider documentProvider, NSData data)
			{
				PSPDFDocumentProviderShouldAppendData handler = shouldAppendData;
				if (handler != null)
					return handler (documentProvider, data);
				return true;
			}
			
			internal EventHandler<PSPDFDocumentProviderDidAppendDataEventArgs> didAppendData;
			[Preserve (Conditional = true)]
			public override void DidAppendData (KS_PSPDFKitBindings.PSPDFDocumentProvider documentProvider, NSData data)
			{
				EventHandler<PSPDFDocumentProviderDidAppendDataEventArgs> handler = didAppendData;
				if (handler != null){
					var args = new PSPDFDocumentProviderDidAppendDataEventArgs (data);
					handler (documentProvider, args);
				}
			}
			
		}
		#pragma warning restore 672
		
		public PSPDFDocumentProviderShouldAppendData ShouldAppendData {
			get { return EnsurePSPDFDocumentProviderDelegate ().shouldAppendData; }
			set { EnsurePSPDFDocumentProviderDelegate ().shouldAppendData = value; }
		}
		
		public event EventHandler<PSPDFDocumentProviderDidAppendDataEventArgs> DidAppendData {
			add { EnsurePSPDFDocumentProviderDelegate ().didAppendData += value; }
			remove { EnsurePSPDFDocumentProviderDelegate ().didAppendData -= value; }
		}
		
		internal delegate void InnerPSPDFDocumentProviderPerformBlock (IntPtr block, IntPtr docProvider, global::System.IntPtr documentRefHandle);
		[CompilerGenerated]
		static readonly InnerPSPDFDocumentProviderPerformBlock static_InnerPSPDFDocumentProviderPerformBlock = TrampolinePSPDFDocumentProviderPerformBlock;
		[MonoPInvokeCallback (typeof (InnerPSPDFDocumentProviderPerformBlock))]
		static unsafe void TrampolinePSPDFDocumentProviderPerformBlock (IntPtr block, IntPtr docProvider, global::System.IntPtr documentRefHandle) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::KS_PSPDFKitBindings.PSPDFDocumentProviderPerformBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((KS_PSPDFKitBindings.PSPDFDocumentProvider) Runtime.GetNSObject (docProvider), documentRefHandle);
		}
		
		internal delegate void InnerPSPDFDocumentProviderIterateOverPageRef (IntPtr block, IntPtr docProvider, global::System.IntPtr documentRefHandle, global::System.IntPtr pageRefHandle, global::System.UInt32 pageNumber);
		[CompilerGenerated]
		static readonly InnerPSPDFDocumentProviderIterateOverPageRef static_InnerPSPDFDocumentProviderIterateOverPageRef = TrampolinePSPDFDocumentProviderIterateOverPageRef;
		[MonoPInvokeCallback (typeof (InnerPSPDFDocumentProviderIterateOverPageRef))]
		static unsafe void TrampolinePSPDFDocumentProviderIterateOverPageRef (IntPtr block, IntPtr docProvider, global::System.IntPtr documentRefHandle, global::System.IntPtr pageRefHandle, global::System.UInt32 pageNumber) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::KS_PSPDFKitBindings.PSPDFDocumentProviderIterateOverPageRef) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((KS_PSPDFKitBindings.PSPDFDocumentProvider) Runtime.GetNSObject (docProvider), documentRefHandle, pageRefHandle, pageNumber);
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_FileURL_var = null;
				__mt_Data_var = null;
				__mt_Document_var = null;
				__mt_WeakDelegate_var = null;
				__mt_PageRange_var = null;
				__mt_Metadata_var = null;
				__mt_OutlineParser_var = null;
				__mt_DocumentParser_var = null;
				__mt_AnnotationParser_var = null;
				__mt_LabelParser_var = null;
			}
		}
	} /* class PSPDFDocumentProvider */
	public delegate void PSPDFDocumentProviderPerformBlock (PSPDFDocumentProvider docProvider, global::System.IntPtr documentRefHandle);
	public delegate void PSPDFDocumentProviderIterateOverPageRef (PSPDFDocumentProvider docProvider, global::System.IntPtr documentRefHandle, global::System.IntPtr pageRefHandle, global::System.UInt32 pageNumber);
	
	
	//
	// EventArgs classes
	//
	public partial class PSPDFDocumentProviderDidAppendDataEventArgs : EventArgs {
		public PSPDFDocumentProviderDidAppendDataEventArgs (NSData data)
		{
			this.Data = data;
		}
		public NSData Data { get; set; }
	}
	
}
