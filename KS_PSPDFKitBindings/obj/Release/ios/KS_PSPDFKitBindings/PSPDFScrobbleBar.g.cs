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
	[Register("PSPDFScrobbleBar", true)]
	public unsafe partial class PSPDFScrobbleBar : global::MonoTouch.UIKit.UIView {
		[CompilerGenerated]
		const string selPdfController = "pdfController";
		static readonly IntPtr selPdfControllerHandle = Selector.GetHandle ("pdfController");
		[CompilerGenerated]
		const string selSetPdfController_ = "setPdfController:";
		static readonly IntPtr selSetPdfController_Handle = Selector.GetHandle ("setPdfController:");
		[CompilerGenerated]
		const string selPage = "page";
		static readonly IntPtr selPageHandle = Selector.GetHandle ("page");
		[CompilerGenerated]
		const string selSetPage_ = "setPage:";
		static readonly IntPtr selSetPage_Handle = Selector.GetHandle ("setPage:");
		[CompilerGenerated]
		const string selToolbar = "toolbar";
		static readonly IntPtr selToolbarHandle = Selector.GetHandle ("toolbar");
		[CompilerGenerated]
		const string selSetToolbar_ = "setToolbar:";
		static readonly IntPtr selSetToolbar_Handle = Selector.GetHandle ("setToolbar:");
		[CompilerGenerated]
		const string selLeftBorderMargin = "leftBorderMargin";
		static readonly IntPtr selLeftBorderMarginHandle = Selector.GetHandle ("leftBorderMargin");
		[CompilerGenerated]
		const string selSetLeftBorderMargin_ = "setLeftBorderMargin:";
		static readonly IntPtr selSetLeftBorderMargin_Handle = Selector.GetHandle ("setLeftBorderMargin:");
		[CompilerGenerated]
		const string selRightBorderMargin = "rightBorderMargin";
		static readonly IntPtr selRightBorderMarginHandle = Selector.GetHandle ("rightBorderMargin");
		[CompilerGenerated]
		const string selSetRightBorderMargin_ = "setRightBorderMargin:";
		static readonly IntPtr selSetRightBorderMargin_Handle = Selector.GetHandle ("setRightBorderMargin:");
		[CompilerGenerated]
		const string selAllowTapsOutsidePageArea = "allowTapsOutsidePageArea";
		static readonly IntPtr selAllowTapsOutsidePageAreaHandle = Selector.GetHandle ("allowTapsOutsidePageArea");
		[CompilerGenerated]
		const string selSetAllowTapsOutsidePageArea_ = "setAllowTapsOutsidePageArea:";
		static readonly IntPtr selSetAllowTapsOutsidePageArea_Handle = Selector.GetHandle ("setAllowTapsOutsidePageArea:");
		[CompilerGenerated]
		const string selIsViewLocked = "isViewLocked";
		static readonly IntPtr selIsViewLockedHandle = Selector.GetHandle ("isViewLocked");
		[CompilerGenerated]
		const string selSetViewLocked_ = "setViewLocked:";
		static readonly IntPtr selSetViewLocked_Handle = Selector.GetHandle ("setViewLocked:");
		[CompilerGenerated]
		const string selIsSmallToolbar = "isSmallToolbar";
		static readonly IntPtr selIsSmallToolbarHandle = Selector.GetHandle ("isSmallToolbar");
		[CompilerGenerated]
		const string selScrobbleBarHeight = "scrobbleBarHeight";
		static readonly IntPtr selScrobbleBarHeightHandle = Selector.GetHandle ("scrobbleBarHeight");
		[CompilerGenerated]
		const string selScrobbleBarThumbSize = "scrobbleBarThumbSize";
		static readonly IntPtr selScrobbleBarThumbSizeHandle = Selector.GetHandle ("scrobbleBarThumbSize");
		[CompilerGenerated]
		const string selThumbnailMargin = "thumbnailMargin";
		static readonly IntPtr selThumbnailMarginHandle = Selector.GetHandle ("thumbnailMargin");
		[CompilerGenerated]
		const string selSetThumbnailMargin_ = "setThumbnailMargin:";
		static readonly IntPtr selSetThumbnailMargin_Handle = Selector.GetHandle ("setThumbnailMargin:");
		[CompilerGenerated]
		const string selPageMarkerSizeMultiplier = "pageMarkerSizeMultiplier";
		static readonly IntPtr selPageMarkerSizeMultiplierHandle = Selector.GetHandle ("pageMarkerSizeMultiplier");
		[CompilerGenerated]
		const string selSetPageMarkerSizeMultiplier_ = "setPageMarkerSizeMultiplier:";
		static readonly IntPtr selSetPageMarkerSizeMultiplier_Handle = Selector.GetHandle ("setPageMarkerSizeMultiplier:");
		[CompilerGenerated]
		const string selUpdateToolbarPositionAnimated_ = "updateToolbarPositionAnimated:";
		static readonly IntPtr selUpdateToolbarPositionAnimated_Handle = Selector.GetHandle ("updateToolbarPositionAnimated:");
		[CompilerGenerated]
		const string selUpdateToolbarAnimated_ = "updateToolbarAnimated:";
		static readonly IntPtr selUpdateToolbarAnimated_Handle = Selector.GetHandle ("updateToolbarAnimated:");
		[CompilerGenerated]
		const string selUpdateToolbarForced = "updateToolbarForced";
		static readonly IntPtr selUpdateToolbarForcedHandle = Selector.GetHandle ("updateToolbarForced");
		[CompilerGenerated]
		const string selUpdatePageMarker = "updatePageMarker";
		static readonly IntPtr selUpdatePageMarkerHandle = Selector.GetHandle ("updatePageMarker");
		[CompilerGenerated]
		const string selSetToolbarFrameAndVisibilityAnimated_ = "setToolbarFrameAndVisibility:animated:";
		static readonly IntPtr selSetToolbarFrameAndVisibilityAnimated_Handle = Selector.GetHandle ("setToolbarFrameAndVisibility:animated:");
		[CompilerGenerated]
		const string selDidFinishCachingDocument_ = "didFinishCachingDocument:";
		static readonly IntPtr selDidFinishCachingDocument_Handle = Selector.GetHandle ("didFinishCachingDocument:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFScrobbleBar");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFScrobbleBar () : base (NSObjectFlag.Empty)
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
		public PSPDFScrobbleBar (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFScrobbleBar (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFScrobbleBar (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("updateToolbarPositionAnimated:")]
		[CompilerGenerated]
		public virtual void UpdateToolbarPosition (bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selUpdateToolbarPositionAnimated_Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selUpdateToolbarPositionAnimated_Handle, animated);
			}
		}
		
		[Export ("updateToolbarAnimated:")]
		[CompilerGenerated]
		public virtual void UpdateToolbar (bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selUpdateToolbarAnimated_Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selUpdateToolbarAnimated_Handle, animated);
			}
		}
		
		[Export ("updateToolbarForced")]
		[CompilerGenerated]
		public virtual void UpdateToolbarForced ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateToolbarForcedHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selUpdateToolbarForcedHandle);
			}
		}
		
		[Export ("updatePageMarker")]
		[CompilerGenerated]
		public virtual void UpdatePageMarker ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdatePageMarkerHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selUpdatePageMarkerHandle);
			}
		}
		
		[Export ("setToolbarFrameAndVisibility:animated:")]
		[CompilerGenerated]
		public virtual void SetToolbarFrameAndVisibility (bool shouldShow, bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool_bool (this.Handle, selSetToolbarFrameAndVisibilityAnimated_Handle, shouldShow, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_bool (this.SuperHandle, selSetToolbarFrameAndVisibilityAnimated_Handle, shouldShow, animated);
			}
		}
		
		[Export ("didFinishCachingDocument:")]
		[CompilerGenerated]
		public virtual void DidFinishCachingDocument (PSPDFDocument document)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selDidFinishCachingDocument_Handle, document.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selDidFinishCachingDocument_Handle, document.Handle);
			}
		}
		
		[CompilerGenerated]
		object __mt_PdfController_var;
		[CompilerGenerated]
		public virtual PSPDFViewController PdfController {
			[Export ("pdfController")]
			get {
				PSPDFViewController ret;
				if (IsDirectBinding) {
					ret = (PSPDFViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPdfControllerHandle));
				} else {
					ret = (PSPDFViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPdfControllerHandle));
				}
				MarkDirty ();
				__mt_PdfController_var = ret;
				return ret;
			}
			
			[Export ("setPdfController:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPdfController_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPdfController_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_PdfController_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 Page {
			[Export ("page", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPageHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selPageHandle);
				}
			}
			
			[Export ("setPage:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetPage_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetPage_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Toolbar_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIToolbar Toolbar {
			[Export ("toolbar")]
			get {
				global::MonoTouch.UIKit.UIToolbar ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIToolbar) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selToolbarHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIToolbar) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selToolbarHandle));
				}
				MarkDirty ();
				__mt_Toolbar_var = ret;
				return ret;
			}
			
			[Export ("setToolbar:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetToolbar_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetToolbar_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Toolbar_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual float LeftBorderMargin {
			[Export ("leftBorderMargin", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selLeftBorderMarginHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selLeftBorderMarginHandle);
				}
			}
			
			[Export ("setLeftBorderMargin:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetLeftBorderMargin_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetLeftBorderMargin_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float RightBorderMargin {
			[Export ("rightBorderMargin", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selRightBorderMarginHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selRightBorderMarginHandle);
				}
			}
			
			[Export ("setRightBorderMargin:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetRightBorderMargin_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetRightBorderMargin_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AllowTapsOutsidePageArea {
			[Export ("allowTapsOutsidePageArea", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowTapsOutsidePageAreaHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAllowTapsOutsidePageAreaHandle);
				}
			}
			
			[Export ("setAllowTapsOutsidePageArea:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowTapsOutsidePageArea_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAllowTapsOutsidePageArea_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ViewLocked {
			[Export ("isViewLocked")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsViewLockedHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsViewLockedHandle);
				}
			}
			
			[Export ("setViewLocked:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetViewLocked_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetViewLocked_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsSmallToolbar {
			[Export ("isSmallToolbar")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSmallToolbarHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsSmallToolbarHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual float ScrobbleBarHeight {
			[Export ("scrobbleBarHeight")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selScrobbleBarHeightHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selScrobbleBarHeightHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.Drawing.SizeF ScrobbleBarThumbSize {
			[Export ("scrobbleBarThumbSize")]
			get {
				global::System.Drawing.SizeF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend_stret (out ret, this.Handle, selScrobbleBarThumbSizeHandle);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend (this.Handle, selScrobbleBarThumbSizeHandle);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selScrobbleBarThumbSizeHandle);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper (this.SuperHandle, selScrobbleBarThumbSizeHandle);
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual float ThumbnailMargin {
			[Export ("thumbnailMargin", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selThumbnailMarginHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selThumbnailMarginHandle);
				}
			}
			
			[Export ("setThumbnailMargin:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetThumbnailMargin_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetThumbnailMargin_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float PageMarkerSizeMultiplier {
			[Export ("pageMarkerSizeMultiplier", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selPageMarkerSizeMultiplierHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selPageMarkerSizeMultiplierHandle);
				}
			}
			
			[Export ("setPageMarkerSizeMultiplier:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetPageMarkerSizeMultiplier_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetPageMarkerSizeMultiplier_Handle, value);
				}
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_PdfController_var = null;
				__mt_Toolbar_var = null;
			}
		}
	} /* class PSPDFScrobbleBar */
}
