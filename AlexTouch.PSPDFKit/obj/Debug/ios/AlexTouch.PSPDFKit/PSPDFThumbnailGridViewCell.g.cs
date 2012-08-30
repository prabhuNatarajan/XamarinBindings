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
	[Register("PSPDFThumbnailGridViewCell", true)]
	public unsafe partial class PSPDFThumbnailGridViewCell : PSCollectionViewCell {
		static readonly IntPtr selDocument = Selector.GetHandle ("document");
		static readonly IntPtr selSetDocument_ = Selector.GetHandle ("setDocument:");
		static readonly IntPtr selPage = Selector.GetHandle ("page");
		static readonly IntPtr selSetPage_ = Selector.GetHandle ("setPage:");
		static readonly IntPtr selEdgeInsets = Selector.GetHandle ("edgeInsets");
		static readonly IntPtr selSetEdgeInsets_ = Selector.GetHandle ("setEdgeInsets:");
		static readonly IntPtr selIsShadowEnabled = Selector.GetHandle ("isShadowEnabled");
		static readonly IntPtr selSetShadowEnabled_ = Selector.GetHandle ("setShadowEnabled:");
		static readonly IntPtr selIsShowingSiteLabel = Selector.GetHandle ("isShowingSiteLabel");
		static readonly IntPtr selSetShowingSiteLabel_ = Selector.GetHandle ("setShowingSiteLabel:");
		static readonly IntPtr selImageView = Selector.GetHandle ("imageView");
		static readonly IntPtr selSetImageView_ = Selector.GetHandle ("setImageView:");
		static readonly IntPtr selSiteLabel = Selector.GetHandle ("siteLabel");
		static readonly IntPtr selSetSiteLabel_ = Selector.GetHandle ("setSiteLabel:");
		static readonly IntPtr selUpdateCell = Selector.GetHandle ("updateCell");
		static readonly IntPtr selPathShadowForView_ = Selector.GetHandle ("pathShadowForView:");
		static readonly IntPtr selSetImageAnimated_ = Selector.GetHandle ("setImage:animated:");
		static readonly IntPtr selSetImageSize_ = Selector.GetHandle ("setImageSize:");
		static readonly IntPtr selThumbnailQueue = Selector.GetHandle ("thumbnailQueue");
		static readonly IntPtr selUpdateSiteLabel = Selector.GetHandle ("updateSiteLabel");
		static readonly IntPtr selDidCachePageForDocumentPageImageSize_ = Selector.GetHandle ("didCachePageForDocument:page:image:size:");
		static readonly IntPtr selDidFinishCachingDocument_ = Selector.GetHandle ("didFinishCachingDocument:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFThumbnailGridViewCell");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFThumbnailGridViewCell () : base (NSObjectFlag.Empty)
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
		public PSPDFThumbnailGridViewCell (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFThumbnailGridViewCell (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFThumbnailGridViewCell (IntPtr handle) : base (handle) {}

		[Export ("updateCell")]
		[CompilerGenerated]
		public virtual void UpdateCell ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateCell);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selUpdateCell);
			}
		}
		
		[CompilerGenerated]
		public NSObject PathShadowForView (MonoTouch.UIKit.UIView imgView)
		{
			if (imgView == null)
				throw new ArgumentNullException ("imgView");
			return (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selPathShadowForView_, imgView.Handle));
		}
		
		[CompilerGenerated]
		public void SetImage (MonoTouch.UIKit.UIImage image, bool animated)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selSetImageAnimated_, image.Handle, animated);
		}
		
		[CompilerGenerated]
		public void SetImageSize (System.Drawing.SizeF imageSize)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_SizeF (this.Handle, selSetImageSize_, imageSize);
		}
		
		[CompilerGenerated]
		public static NSOperationQueue ThumbnailQueue ()
		{
			return (NSOperationQueue) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selThumbnailQueue));
		}
		
		[CompilerGenerated]
		public void UpdateSiteLabel ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateSiteLabel);
		}
		
		[Export ("didCachePageForDocument:page:image:size:")]
		[CompilerGenerated]
		public virtual void DidCachePageForDocument (PSPDFDocument document, System.UInt32 page, MonoTouch.UIKit.UIImage cachedImage, PSPDFSize size)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (cachedImage == null)
				throw new ArgumentNullException ("cachedImage");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32_IntPtr_int (this.Handle, selDidCachePageForDocumentPageImageSize_, document.Handle, page, cachedImage.Handle, (int)size);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_UInt32_IntPtr_int (this.SuperHandle, selDidCachePageForDocumentPageImageSize_, document.Handle, page, cachedImage.Handle, (int)size);
			}
		}
		
		[Export ("didFinishCachingDocument:")]
		[CompilerGenerated]
		public virtual void DidFinishCachingDocument (PSPDFDocument document)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selDidFinishCachingDocument_, document.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selDidFinishCachingDocument_, document.Handle);
			}
		}
		
		object __mt_Document_var;
		[CompilerGenerated]
		public virtual PSPDFDocument Document {
			[Export ("document")]
			get {
				PSPDFDocument ret;
				if (IsDirectBinding) {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocument));
				} else {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocument));
				}
				MarkDirty ();
				__mt_Document_var = ret;
				return ret;
			}
			
			[Export ("setDocument:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDocument_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDocument_, value.Handle);
				}
				MarkDirty ();
				__mt_Document_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual System.UInt32 Page {
			[Export ("page", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPage);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selPage);
				}
			}
			
			[Export ("setPage:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetPage_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetPage_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIEdgeInsets EdgeInsets {
			[Export ("edgeInsets", ArgumentSemantic.Assign)]
			get {
				MonoTouch.UIKit.UIEdgeInsets ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, selEdgeInsets);
				} else {
					MonoTouch.ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, selEdgeInsets);
				}
				return ret;
			}
			
			[Export ("setEdgeInsets:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, selSetEdgeInsets_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UIEdgeInsets (this.SuperHandle, selSetEdgeInsets_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShadowEnabled {
			[Export ("isShadowEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsShadowEnabled);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsShadowEnabled);
				}
			}
			
			[Export ("setShadowEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShadowEnabled_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShadowEnabled_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowingSiteLabel {
			[Export ("isShowingSiteLabel", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsShowingSiteLabel);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsShowingSiteLabel);
				}
			}
			
			[Export ("setShowingSiteLabel:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowingSiteLabel_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShowingSiteLabel_, value);
				}
			}
		}
		
		object __mt_ImageView_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIImageView ImageView {
			[Export ("imageView")]
			get {
				MonoTouch.UIKit.UIImageView ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selImageView));
				} else {
					ret = (MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selImageView));
				}
				MarkDirty ();
				__mt_ImageView_var = ret;
				return ret;
			}
			
			[Export ("setImageView:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetImageView_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetImageView_, value.Handle);
				}
				MarkDirty ();
				__mt_ImageView_var = value;
			}
		}
		
		object __mt_SiteLabel_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UILabel SiteLabel {
			[Export ("siteLabel")]
			get {
				MonoTouch.UIKit.UILabel ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UILabel) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSiteLabel));
				} else {
					ret = (MonoTouch.UIKit.UILabel) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSiteLabel));
				}
				MarkDirty ();
				__mt_SiteLabel_var = ret;
				return ret;
			}
			
			[Export ("setSiteLabel:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSiteLabel_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSiteLabel_, value.Handle);
				}
				MarkDirty ();
				__mt_SiteLabel_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_Document_var = null;
			__mt_ImageView_var = null;
			__mt_SiteLabel_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFThumbnailGridViewCell */
}
