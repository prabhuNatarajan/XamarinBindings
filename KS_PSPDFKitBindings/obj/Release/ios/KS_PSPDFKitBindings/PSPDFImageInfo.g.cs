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
	[Register("PSPDFImageInfo", true)]
	public unsafe partial class PSPDFImageInfo : NSObject {
		[CompilerGenerated]
		const string selImageID = "imageID";
		static readonly IntPtr selImageIDHandle = Selector.GetHandle ("imageID");
		[CompilerGenerated]
		const string selSetImageID_ = "setImageID:";
		static readonly IntPtr selSetImageID_Handle = Selector.GetHandle ("setImageID:");
		[CompilerGenerated]
		const string selPixelWidth = "pixelWidth";
		static readonly IntPtr selPixelWidthHandle = Selector.GetHandle ("pixelWidth");
		[CompilerGenerated]
		const string selSetPixelWidth_ = "setPixelWidth:";
		static readonly IntPtr selSetPixelWidth_Handle = Selector.GetHandle ("setPixelWidth:");
		[CompilerGenerated]
		const string selPixelHeight = "pixelHeight";
		static readonly IntPtr selPixelHeightHandle = Selector.GetHandle ("pixelHeight");
		[CompilerGenerated]
		const string selSetPixelHeight_ = "setPixelHeight:";
		static readonly IntPtr selSetPixelHeight_Handle = Selector.GetHandle ("setPixelHeight:");
		[CompilerGenerated]
		const string selBitsPerComponent = "bitsPerComponent";
		static readonly IntPtr selBitsPerComponentHandle = Selector.GetHandle ("bitsPerComponent");
		[CompilerGenerated]
		const string selSetBitsPerComponent_ = "setBitsPerComponent:";
		static readonly IntPtr selSetBitsPerComponent_Handle = Selector.GetHandle ("setBitsPerComponent:");
		[CompilerGenerated]
		const string selDisplayWidth = "displayWidth";
		static readonly IntPtr selDisplayWidthHandle = Selector.GetHandle ("displayWidth");
		[CompilerGenerated]
		const string selSetDisplayWidth_ = "setDisplayWidth:";
		static readonly IntPtr selSetDisplayWidth_Handle = Selector.GetHandle ("setDisplayWidth:");
		[CompilerGenerated]
		const string selDisplayHeight = "displayHeight";
		static readonly IntPtr selDisplayHeightHandle = Selector.GetHandle ("displayHeight");
		[CompilerGenerated]
		const string selSetDisplayHeight_ = "setDisplayHeight:";
		static readonly IntPtr selSetDisplayHeight_Handle = Selector.GetHandle ("setDisplayHeight:");
		[CompilerGenerated]
		const string selHorizontalResolution = "horizontalResolution";
		static readonly IntPtr selHorizontalResolutionHandle = Selector.GetHandle ("horizontalResolution");
		[CompilerGenerated]
		const string selSetHorizontalResolution_ = "setHorizontalResolution:";
		static readonly IntPtr selSetHorizontalResolution_Handle = Selector.GetHandle ("setHorizontalResolution:");
		[CompilerGenerated]
		const string selVerticalResolution = "verticalResolution";
		static readonly IntPtr selVerticalResolutionHandle = Selector.GetHandle ("verticalResolution");
		[CompilerGenerated]
		const string selSetVerticalResolution_ = "setVerticalResolution:";
		static readonly IntPtr selSetVerticalResolution_Handle = Selector.GetHandle ("setVerticalResolution:");
		[CompilerGenerated]
		const string selCtm = "ctm";
		static readonly IntPtr selCtmHandle = Selector.GetHandle ("ctm");
		[CompilerGenerated]
		const string selSetCtm_ = "setCtm:";
		static readonly IntPtr selSetCtm_Handle = Selector.GetHandle ("setCtm:");
		[CompilerGenerated]
		const string selVertices = "vertices";
		static readonly IntPtr selVerticesHandle = Selector.GetHandle ("vertices");
		[CompilerGenerated]
		const string selDocument = "document";
		static readonly IntPtr selDocumentHandle = Selector.GetHandle ("document");
		[CompilerGenerated]
		const string selSetDocument_ = "setDocument:";
		static readonly IntPtr selSetDocument_Handle = Selector.GetHandle ("setDocument:");
		[CompilerGenerated]
		const string selPage = "page";
		static readonly IntPtr selPageHandle = Selector.GetHandle ("page");
		[CompilerGenerated]
		const string selSetPage_ = "setPage:";
		static readonly IntPtr selSetPage_Handle = Selector.GetHandle ("setPage:");
		[CompilerGenerated]
		const string selBoundingBox = "boundingBox";
		static readonly IntPtr selBoundingBoxHandle = Selector.GetHandle ("boundingBox");
		[CompilerGenerated]
		const string selImage = "image";
		static readonly IntPtr selImageHandle = Selector.GetHandle ("image");
		[CompilerGenerated]
		const string selImageInRGBColorSpace = "imageInRGBColorSpace";
		static readonly IntPtr selImageInRGBColorSpaceHandle = Selector.GetHandle ("imageInRGBColorSpace");
		[CompilerGenerated]
		const string selIsPointInImage_ = "isPointInImage:";
		static readonly IntPtr selIsPointInImage_Handle = Selector.GetHandle ("isPointInImage:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFImageInfo");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFImageInfo () : base (NSObjectFlag.Empty)
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
		public PSPDFImageInfo (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFImageInfo (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFImageInfo (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("isPointInImage:")]
		[CompilerGenerated]
		public virtual bool IsPointInImage (global::System.Drawing.PointF point)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_PointF (this.Handle, selIsPointInImage_Handle, point);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_PointF (this.SuperHandle, selIsPointInImage_Handle, point);
			}
		}
		
		[CompilerGenerated]
		public virtual string ImageID {
			[Export ("imageID", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selImageIDHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selImageIDHandle));
				}
			}
			
			[Export ("setImageID:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetImageID_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetImageID_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual int PixelWidth {
			[Export ("pixelWidth", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selPixelWidthHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selPixelWidthHandle);
				}
			}
			
			[Export ("setPixelWidth:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetPixelWidth_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetPixelWidth_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int PixelHeight {
			[Export ("pixelHeight", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selPixelHeightHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selPixelHeightHandle);
				}
			}
			
			[Export ("setPixelHeight:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetPixelHeight_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetPixelHeight_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int BitsPerComponent {
			[Export ("bitsPerComponent", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selBitsPerComponentHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selBitsPerComponentHandle);
				}
			}
			
			[Export ("setBitsPerComponent:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetBitsPerComponent_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetBitsPerComponent_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double DisplayWidth {
			[Export ("displayWidth", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selDisplayWidthHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selDisplayWidthHandle);
				}
			}
			
			[Export ("setDisplayWidth:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetDisplayWidth_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, selSetDisplayWidth_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double DisplayHeight {
			[Export ("displayHeight", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selDisplayHeightHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selDisplayHeightHandle);
				}
			}
			
			[Export ("setDisplayHeight:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetDisplayHeight_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, selSetDisplayHeight_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double HorizontalResolution {
			[Export ("horizontalResolution", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selHorizontalResolutionHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selHorizontalResolutionHandle);
				}
			}
			
			[Export ("setHorizontalResolution:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetHorizontalResolution_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, selSetHorizontalResolution_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double VerticalResolution {
			[Export ("verticalResolution", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selVerticalResolutionHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selVerticalResolutionHandle);
				}
			}
			
			[Export ("setVerticalResolution:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetVerticalResolution_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, selSetVerticalResolution_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual CGAffineTransform Ctm {
			[Export ("ctm", ArgumentSemantic.Assign)]
			get {
				CGAffineTransform ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret (out ret, this.Handle, selCtmHandle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper_stret (out ret, this.SuperHandle, selCtmHandle);
				}
				return ret;
			}
			
			[Export ("setCtm:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_CGAffineTransform (this.Handle, selSetCtm_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_CGAffineTransform (this.SuperHandle, selSetCtm_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Drawing.PointF Vertices {
			[Export ("vertices", ArgumentSemantic.Assign)]
			get {
				global::System.Drawing.PointF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSend_stret (out ret, this.Handle, selVerticesHandle);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSend (this.Handle, selVerticesHandle);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selVerticesHandle);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSendSuper (this.SuperHandle, selVerticesHandle);
					}
				}
				return ret;
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
			
			[Export ("setDocument:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDocument_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDocument_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Document_var = value;
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
		public virtual global::System.Drawing.RectangleF BoundingBox {
			[Export ("boundingBox")]
			get {
				global::System.Drawing.RectangleF ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret (out ret, this.Handle, selBoundingBoxHandle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selBoundingBoxHandle);
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Image_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIImage Image {
			[Export ("image")]
			get {
				global::MonoTouch.UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selImageHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selImageHandle));
				}
				MarkDirty ();
				__mt_Image_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ImageInRGBColorSpace_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIImage ImageInRGBColorSpace {
			[Export ("imageInRGBColorSpace")]
			get {
				global::MonoTouch.UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selImageInRGBColorSpaceHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selImageInRGBColorSpaceHandle));
				}
				MarkDirty ();
				__mt_ImageInRGBColorSpace_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Document_var = null;
				__mt_Image_var = null;
				__mt_ImageInRGBColorSpace_var = null;
			}
		}
	} /* class PSPDFImageInfo */
}
