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
	[Register("PSPDFCache", true)]
	public unsafe partial class PSPDFCache : NSObject {
		static readonly IntPtr selStrategy = Selector.GetHandle ("strategy");
		static readonly IntPtr selSetStrategy_ = Selector.GetHandle ("setStrategy:");
		static readonly IntPtr selNumberOfMaximumCachedDocuments = Selector.GetHandle ("numberOfMaximumCachedDocuments");
		static readonly IntPtr selSetNumberOfMaximumCachedDocuments_ = Selector.GetHandle ("setNumberOfMaximumCachedDocuments:");
		static readonly IntPtr selNumberOfNearCachedPages = Selector.GetHandle ("numberOfNearCachedPages");
		static readonly IntPtr selSetNumberOfNearCachedPages_ = Selector.GetHandle ("setNumberOfNearCachedPages:");
		static readonly IntPtr selUseJPGFormat = Selector.GetHandle ("useJPGFormat");
		static readonly IntPtr selSetUseJPGFormat_ = Selector.GetHandle ("setUseJPGFormat:");
		static readonly IntPtr selJPGFormatCompression = Selector.GetHandle ("JPGFormatCompression");
		static readonly IntPtr selSetJPGFormatCompression_ = Selector.GetHandle ("setJPGFormatCompression:");
		static readonly IntPtr selUseJPGTurbo = Selector.GetHandle ("useJPGTurbo");
		static readonly IntPtr selSetUseJPGTurbo_ = Selector.GetHandle ("setUseJPGTurbo:");
		static readonly IntPtr selDownscaleInterpolationQuality = Selector.GetHandle ("downscaleInterpolationQuality");
		static readonly IntPtr selSetDownscaleInterpolationQuality_ = Selector.GetHandle ("setDownscaleInterpolationQuality:");
		static readonly IntPtr selThumbnailSize = Selector.GetHandle ("thumbnailSize");
		static readonly IntPtr selSetThumbnailSize_ = Selector.GetHandle ("setThumbnailSize:");
		static readonly IntPtr selTinySize = Selector.GetHandle ("tinySize");
		static readonly IntPtr selSetTinySize_ = Selector.GetHandle ("setTinySize:");
		static readonly IntPtr selCacheDirectory = Selector.GetHandle ("cacheDirectory");
		static readonly IntPtr selSetCacheDirectory_ = Selector.GetHandle ("setCacheDirectory:");
		static readonly IntPtr selSharedCache = Selector.GetHandle ("sharedCache");
		static readonly IntPtr selIsDocumentCachedSize_ = Selector.GetHandle ("isDocumentCached:size:");
		static readonly IntPtr selIsImageCachedForDocumentPageSize_ = Selector.GetHandle ("isImageCachedForDocument:page:size:");
		static readonly IntPtr selCachedImageForDocumentPageSize_ = Selector.GetHandle ("cachedImageForDocument:page:size:");
		static readonly IntPtr selCachedImageForDocumentPageSizePreload_ = Selector.GetHandle ("cachedImageForDocument:page:size:preload:");
		static readonly IntPtr selCachedImageForDocumentPageSizePdfPage_ = Selector.GetHandle ("cachedImageForDocument:page:size:pdfPage:");
		static readonly IntPtr selCacheDocumentStartAtPageSize_ = Selector.GetHandle ("cacheDocument:startAtPage:size:");
		static readonly IntPtr selCacheThumbnailsForDocument_ = Selector.GetHandle ("cacheThumbnailsForDocument:");
		static readonly IntPtr selStopCachingDocument_ = Selector.GetHandle ("stopCachingDocument:");
		static readonly IntPtr selPauseCachingForService_ = Selector.GetHandle ("pauseCachingForService:");
		static readonly IntPtr selResumeCachingForService_ = Selector.GetHandle ("resumeCachingForService:");
		static readonly IntPtr selRemoveCacheForDocumentDeleteDocumentWaitUntilDone_ = Selector.GetHandle ("removeCacheForDocument:deleteDocument:waitUntilDone:");
		static readonly IntPtr selClearCache = Selector.GetHandle ("clearCache");
		static readonly IntPtr selAddDelegate_ = Selector.GetHandle ("addDelegate:");
		static readonly IntPtr selRemoveDelegate_ = Selector.GetHandle ("removeDelegate:");
		static readonly IntPtr selCacheImageDocumentPageSize_ = Selector.GetHandle ("cacheImage:document:page:size:");
		static readonly IntPtr selImageForDocumentPageSize_ = Selector.GetHandle ("imageForDocument:page:size:");
		static readonly IntPtr selClearMemoryCache = Selector.GetHandle ("clearMemoryCache");
		static readonly IntPtr selRegisterObject_ = Selector.GetHandle ("registerObject:");
		static readonly IntPtr selDeregisterObject_ = Selector.GetHandle ("deregisterObject:");
		static readonly IntPtr selPrintStatus = Selector.GetHandle ("printStatus");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFCache");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFCache () : base (NSObjectFlag.Empty)
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
		public PSPDFCache (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFCache (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFCache (IntPtr handle) : base (handle) {}

		[Export ("sharedCache")]
		[CompilerGenerated]
		public static PSPDFCache SharedCache ()
		{
			return (PSPDFCache) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selSharedCache));
		}
		
		[Export ("isDocumentCached:size:")]
		[CompilerGenerated]
		public virtual bool IsDocumentCached (PSPDFDocument document, PSPDFSize size)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_int (this.Handle, selIsDocumentCachedSize_, document.Handle, (int)size);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_int (this.SuperHandle, selIsDocumentCachedSize_, document.Handle, (int)size);
			}
		}
		
		[Export ("isImageCachedForDocument:page:size:")]
		[CompilerGenerated]
		public virtual bool IsImageCachedForDocument (PSPDFDocument document, System.UInt32 page, PSPDFSize size)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_UInt32_int (this.Handle, selIsImageCachedForDocumentPageSize_, document.Handle, page, (int)size);
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_UInt32_int (this.SuperHandle, selIsImageCachedForDocumentPageSize_, document.Handle, page, (int)size);
			}
		}
		
		[Export ("cachedImageForDocument:page:size:")]
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIImage CachedImageForDocument (PSPDFDocument document, System.UInt32 page, PSPDFSize size)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (IsDirectBinding) {
				return (MonoTouch.UIKit.UIImage) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt32_int (this.Handle, selCachedImageForDocumentPageSize_, document.Handle, page, (int)size));
			} else {
				return (MonoTouch.UIKit.UIImage) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt32_int (this.SuperHandle, selCachedImageForDocumentPageSize_, document.Handle, page, (int)size));
			}
		}
		
		[Export ("cachedImageForDocument:page:size:preload:")]
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIImage CachedImageForDocument (PSPDFDocument document, System.UInt32 page, PSPDFSize size, bool preload)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (IsDirectBinding) {
				return (MonoTouch.UIKit.UIImage) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt32_int_bool (this.Handle, selCachedImageForDocumentPageSizePreload_, document.Handle, page, (int)size, preload));
			} else {
				return (MonoTouch.UIKit.UIImage) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt32_int_bool (this.SuperHandle, selCachedImageForDocumentPageSizePreload_, document.Handle, page, (int)size, preload));
			}
		}
		
		[Export ("cachedImageForDocument:page:size:pdfPage:")]
		[CompilerGenerated]
		internal virtual MonoTouch.UIKit.UIImage CachedImageForDocument_ (PSPDFDocument document, System.UInt32 page, PSPDFSize size, System.IntPtr pdfPage)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (IsDirectBinding) {
				return (MonoTouch.UIKit.UIImage) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt32_int_IntPtr (this.Handle, selCachedImageForDocumentPageSizePdfPage_, document.Handle, page, (int)size, pdfPage));
			} else {
				return (MonoTouch.UIKit.UIImage) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt32_int_IntPtr (this.SuperHandle, selCachedImageForDocumentPageSizePdfPage_, document.Handle, page, (int)size, pdfPage));
			}
		}
		
		[Export ("cacheDocument:startAtPage:size:")]
		[CompilerGenerated]
		public virtual void CacheDocument (PSPDFDocument document, System.UInt32 startPage, PSPDFSize size)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UInt32_int (this.Handle, selCacheDocumentStartAtPageSize_, document.Handle, startPage, (int)size);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UInt32_int (this.SuperHandle, selCacheDocumentStartAtPageSize_, document.Handle, startPage, (int)size);
			}
		}
		
		[Export ("cacheThumbnailsForDocument:")]
		[CompilerGenerated]
		public virtual bool CacheThumbnailsForDocument (PSPDFDocument document)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selCacheThumbnailsForDocument_, document.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selCacheThumbnailsForDocument_, document.Handle);
			}
		}
		
		[Export ("stopCachingDocument:")]
		[CompilerGenerated]
		public virtual void StopCachingDocument (PSPDFDocument document)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selStopCachingDocument_, document.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selStopCachingDocument_, document.Handle);
			}
		}
		
		[Export ("pauseCachingForService:")]
		[CompilerGenerated]
		public virtual bool PauseCachingForService (NSObject service)
		{
			if (service == null)
				throw new ArgumentNullException ("service");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selPauseCachingForService_, service.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selPauseCachingForService_, service.Handle);
			}
		}
		
		[Export ("resumeCachingForService:")]
		[CompilerGenerated]
		public virtual bool ResumeCachingForService (NSObject service)
		{
			if (service == null)
				throw new ArgumentNullException ("service");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selResumeCachingForService_, service.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selResumeCachingForService_, service.Handle);
			}
		}
		
		[Export ("removeCacheForDocument:deleteDocument:waitUntilDone:")]
		[CompilerGenerated]
		public virtual void ResumeCachingForService (PSPDFDocument document, bool deleteDocument, bool wait)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool_bool (this.Handle, selRemoveCacheForDocumentDeleteDocumentWaitUntilDone_, document.Handle, deleteDocument, wait);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool_bool (this.SuperHandle, selRemoveCacheForDocumentDeleteDocumentWaitUntilDone_, document.Handle, deleteDocument, wait);
			}
		}
		
		[Export ("clearCache")]
		[CompilerGenerated]
		public virtual bool ClearCache ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selClearCache);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selClearCache);
			}
		}
		
		[Export ("addDelegate:")]
		[CompilerGenerated]
		public virtual void AddDelegate (PSPDFCacheDelegate Delegate)
		{
			if (Delegate == null)
				throw new ArgumentNullException ("Delegate");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAddDelegate_, Delegate.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selAddDelegate_, Delegate.Handle);
			}
		}
		
		[Export ("removeDelegate:")]
		[CompilerGenerated]
		public virtual bool RemoveDelegate (PSPDFCacheDelegate Delegate)
		{
			if (Delegate == null)
				throw new ArgumentNullException ("Delegate");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selRemoveDelegate_, Delegate.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selRemoveDelegate_, Delegate.Handle);
			}
		}
		
		[CompilerGenerated]
		public void CacheImage (MonoTouch.UIKit.UIImage image, PSPDFDocument document, System.UInt32 page, PSPDFSize size)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			if (document == null)
				throw new ArgumentNullException ("document");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt32_int (this.Handle, selCacheImageDocumentPageSize_, image.Handle, document.Handle, page, (int)size);
		}
		
		[CompilerGenerated]
		public MonoTouch.UIKit.UIImage ImageForDocument (PSPDFDocument document, System.UInt32 page, PSPDFSize size)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			return (MonoTouch.UIKit.UIImage) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt32_int (this.Handle, selImageForDocumentPageSize_, document.Handle, page, (int)size));
		}
		
		[CompilerGenerated]
		public void ClearMemoryCache ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selClearMemoryCache);
		}
		
		[CompilerGenerated]
		public void RegisterObject (NSObject Object)
		{
			if (Object == null)
				throw new ArgumentNullException ("Object");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRegisterObject_, Object.Handle);
		}
		
		[CompilerGenerated]
		public void DeregisterObject (NSObject Object)
		{
			if (Object == null)
				throw new ArgumentNullException ("Object");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selDeregisterObject_, Object.Handle);
		}
		
		[CompilerGenerated]
		public void PrintStatus ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPrintStatus);
		}
		
		[CompilerGenerated]
		public virtual PSPDFCacheStrategy Strategy {
			[Export ("strategy", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFCacheStrategy) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selStrategy);
				} else {
					return (PSPDFCacheStrategy) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selStrategy);
				}
			}
			
			[Export ("setStrategy:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetStrategy_, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetStrategy_, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual System.UInt32 NumberOfMaximumCachedDocuments {
			[Export ("numberOfMaximumCachedDocuments", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selNumberOfMaximumCachedDocuments);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selNumberOfMaximumCachedDocuments);
				}
			}
			
			[Export ("setNumberOfMaximumCachedDocuments:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetNumberOfMaximumCachedDocuments_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetNumberOfMaximumCachedDocuments_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual System.UInt32 NumberOfNearCachedPages {
			[Export ("numberOfNearCachedPages", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selNumberOfNearCachedPages);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selNumberOfNearCachedPages);
				}
			}
			
			[Export ("setNumberOfNearCachedPages:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetNumberOfNearCachedPages_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetNumberOfNearCachedPages_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool UseJPGFormat {
			[Export ("useJPGFormat", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUseJPGFormat);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selUseJPGFormat);
				}
			}
			
			[Export ("setUseJPGFormat:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUseJPGFormat_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetUseJPGFormat_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float JPGFormatCompression {
			[Export ("JPGFormatCompression", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selJPGFormatCompression);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selJPGFormatCompression);
				}
			}
			
			[Export ("setJPGFormatCompression:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetJPGFormatCompression_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetJPGFormatCompression_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool UseJPGTurbo {
			[Export ("useJPGTurbo", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUseJPGTurbo);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selUseJPGTurbo);
				}
			}
			
			[Export ("setUseJPGTurbo:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUseJPGTurbo_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetUseJPGTurbo_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual CGInterpolationQuality DownscaleInterpolationQuality {
			[Export ("downscaleInterpolationQuality", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (CGInterpolationQuality) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selDownscaleInterpolationQuality);
				} else {
					return (CGInterpolationQuality) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selDownscaleInterpolationQuality);
				}
			}
			
			[Export ("setDownscaleInterpolationQuality:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetDownscaleInterpolationQuality_, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetDownscaleInterpolationQuality_, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual System.Drawing.SizeF ThumbnailSize {
			[Export ("thumbnailSize", ArgumentSemantic.Assign)]
			get {
				System.Drawing.SizeF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend_stret (out ret, this.Handle, selThumbnailSize);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend (this.Handle, selThumbnailSize);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selThumbnailSize);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper (this.SuperHandle, selThumbnailSize);
					}
				}
				return ret;
			}
			
			[Export ("setThumbnailSize:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_SizeF (this.Handle, selSetThumbnailSize_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_SizeF (this.SuperHandle, selSetThumbnailSize_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual System.Drawing.SizeF TinySize {
			[Export ("tinySize", ArgumentSemantic.Assign)]
			get {
				System.Drawing.SizeF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend_stret (out ret, this.Handle, selTinySize);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend (this.Handle, selTinySize);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selTinySize);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper (this.SuperHandle, selTinySize);
					}
				}
				return ret;
			}
			
			[Export ("setTinySize:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_SizeF (this.Handle, selSetTinySize_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_SizeF (this.SuperHandle, selSetTinySize_, value);
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
		
	} /* class PSPDFCache */
}
