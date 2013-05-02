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
	[Register("PSPDFPageInfo", true)]
	public unsafe partial class PSPDFPageInfo : NSObject {
		[CompilerGenerated]
		const string selPageRect = "pageRect";
		static readonly IntPtr selPageRectHandle = Selector.GetHandle ("pageRect");
		[CompilerGenerated]
		const string selSetPageRect_ = "setPageRect:";
		static readonly IntPtr selSetPageRect_Handle = Selector.GetHandle ("setPageRect:");
		[CompilerGenerated]
		const string selRotatedPageRect = "rotatedPageRect";
		static readonly IntPtr selRotatedPageRectHandle = Selector.GetHandle ("rotatedPageRect");
		[CompilerGenerated]
		const string selPageRotation = "pageRotation";
		static readonly IntPtr selPageRotationHandle = Selector.GetHandle ("pageRotation");
		[CompilerGenerated]
		const string selSetPageRotation_ = "setPageRotation:";
		static readonly IntPtr selSetPageRotation_Handle = Selector.GetHandle ("setPageRotation:");
		[CompilerGenerated]
		const string selPageRotationTransform = "pageRotationTransform";
		static readonly IntPtr selPageRotationTransformHandle = Selector.GetHandle ("pageRotationTransform");
		[CompilerGenerated]
		const string selPage = "page";
		static readonly IntPtr selPageHandle = Selector.GetHandle ("page");
		[CompilerGenerated]
		const string selDocumentProvider = "documentProvider";
		static readonly IntPtr selDocumentProviderHandle = Selector.GetHandle ("documentProvider");
		[CompilerGenerated]
		const string selInitWithPageRectRotationDocumentProvider_ = "initWithPage:rect:rotation:documentProvider:";
		static readonly IntPtr selInitWithPageRectRotationDocumentProvider_Handle = Selector.GetHandle ("initWithPage:rect:rotation:documentProvider:");
		[CompilerGenerated]
		const string selIsEqualToPageInfo_ = "isEqualToPageInfo:";
		static readonly IntPtr selIsEqualToPageInfo_Handle = Selector.GetHandle ("isEqualToPageInfo:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFPageInfo");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFPageInfo () : base (NSObjectFlag.Empty)
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
		public PSPDFPageInfo (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFPageInfo (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFPageInfo (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithPage:rect:rotation:documentProvider:")]
		[CompilerGenerated]
		public PSPDFPageInfo (global::System.UInt32 page, global::System.Drawing.RectangleF pageRect, int rotation, PSPDFDocumentProvider documentProvider)
			: base (NSObjectFlag.Empty)
		{
			if (documentProvider == null)
				throw new ArgumentNullException ("documentProvider");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_RectangleF_int_IntPtr (this.Handle, selInitWithPageRectRotationDocumentProvider_Handle, page, pageRect, rotation, documentProvider.Handle);
			} else {
				Handle = ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32_RectangleF_int_IntPtr (this.SuperHandle, selInitWithPageRectRotationDocumentProvider_Handle, page, pageRect, rotation, documentProvider.Handle);
			}
		}
		
		[Export ("isEqualToPageInfo:")]
		[CompilerGenerated]
		public virtual bool IsEqualToPageInfo (PSPDFPageInfo otherPageInfo)
		{
			if (otherPageInfo == null)
				throw new ArgumentNullException ("otherPageInfo");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsEqualToPageInfo_Handle, otherPageInfo.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selIsEqualToPageInfo_Handle, otherPageInfo.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Drawing.RectangleF PageRect {
			[Export ("pageRect", ArgumentSemantic.Assign)]
			get {
				global::System.Drawing.RectangleF ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret (out ret, this.Handle, selPageRectHandle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selPageRectHandle);
				}
				return ret;
			}
			
			[Export ("setPageRect:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_RectangleF (this.Handle, selSetPageRect_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_RectangleF (this.SuperHandle, selSetPageRect_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Drawing.RectangleF RotatedPageRect {
			[Export ("rotatedPageRect", ArgumentSemantic.Assign)]
			get {
				global::System.Drawing.RectangleF ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret (out ret, this.Handle, selRotatedPageRectHandle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selRotatedPageRectHandle);
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 PageRotation {
			[Export ("pageRotation", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPageRotationHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selPageRotationHandle);
				}
			}
			
			[Export ("setPageRotation:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetPageRotation_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetPageRotation_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual CGAffineTransform pageRotationTransform {
			[Export ("pageRotationTransform", ArgumentSemantic.Assign)]
			get {
				CGAffineTransform ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret (out ret, this.Handle, selPageRotationTransformHandle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper_stret (out ret, this.SuperHandle, selPageRotationTransformHandle);
				}
				return ret;
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
			
		}
		
		[CompilerGenerated]
		object __mt_DocumentProvider_var;
		[CompilerGenerated]
		public virtual PSPDFDocumentProvider DocumentProvider {
			[Export ("documentProvider")]
			get {
				PSPDFDocumentProvider ret;
				if (IsDirectBinding) {
					ret = (PSPDFDocumentProvider) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocumentProviderHandle));
				} else {
					ret = (PSPDFDocumentProvider) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocumentProviderHandle));
				}
				MarkDirty ();
				__mt_DocumentProvider_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_DocumentProvider_var = null;
			}
		}
	} /* class PSPDFPageInfo */
}
