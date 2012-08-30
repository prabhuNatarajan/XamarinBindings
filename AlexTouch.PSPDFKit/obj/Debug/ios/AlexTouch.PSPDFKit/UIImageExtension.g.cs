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
	[Register("UIImageExtension", true)]
	public unsafe partial class UIImageExtension : MonoTouch.UIKit.UIImage {
		static readonly IntPtr selPspdf_imageToFitSizeMethodHonorScaleFactorOpaque_ = Selector.GetHandle ("pspdf_imageToFitSize:method:honorScaleFactor:opaque:");
		static readonly IntPtr selPspdf_imageWithContentsOfResolutionIndependentFile_ = Selector.GetHandle ("pspdf_imageWithContentsOfResolutionIndependentFile:");
		static readonly IntPtr selInitWithContentsOfResolutionIndependentFile_pspdf_ = Selector.GetHandle ("initWithContentsOfResolutionIndependentFile_pspdf:");
		static readonly IntPtr selPspdf_preloadedImageWithContentsOfFile_ = Selector.GetHandle ("pspdf_preloadedImageWithContentsOfFile:");
		static readonly IntPtr selPspdf_preloadedImage = Selector.GetHandle ("pspdf_preloadedImage");
		static readonly IntPtr selPspdf_preloadedImageWithContentsOfFileUseJPGTurbo_ = Selector.GetHandle ("pspdf_preloadedImageWithContentsOfFile:useJPGTurbo:");
		static readonly IntPtr selPspdf_preloadedImageWithDataUseJPGTurbo_ = Selector.GetHandle ("pspdf_preloadedImageWithData:useJPGTurbo:");
		static readonly IntPtr selPspdf_imageNamedBundle_ = Selector.GetHandle ("pspdf_imageNamed:bundle:");
		static readonly IntPtr selPdpdf_imageTintedWithColorFraction_ = Selector.GetHandle ("pdpdf_imageTintedWithColor:fraction:");
		static readonly IntPtr selPspdf_animatedGIFWithPath_ = Selector.GetHandle ("pspdf_animatedGIFWithPath:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("UIImageExtension");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  UIImageExtension () : base (NSObjectFlag.Empty)
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
		public UIImageExtension (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public UIImageExtension (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public UIImageExtension (IntPtr handle) : base (handle) {}

		[CompilerGenerated]
		public MonoTouch.UIKit.UIImage Pspdf_imageToFitSize (System.Drawing.SizeF fitSize, PSPDFImageResizingMethod resizeMethod, bool honorScaleFactor, bool opaque)
		{
			return (MonoTouch.UIKit.UIImage) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_SizeF_int_bool_bool (this.Handle, selPspdf_imageToFitSizeMethodHonorScaleFactorOpaque_, fitSize, (int)resizeMethod, honorScaleFactor, opaque));
		}
		
		[CompilerGenerated]
		public static MonoTouch.UIKit.UIImage Pspdf_imageWithContentsOfResolutionIndependentFile (string path)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspath = NSString.CreateNative (path);
			
			MonoTouch.UIKit.UIImage ret;
			ret = (MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selPspdf_imageWithContentsOfResolutionIndependentFile_, nspath));
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
		[Export ("initWithContentsOfResolutionIndependentFile_pspdf:")]
		[CompilerGenerated]
		public UIImageExtension (string pathToContentsOfResolutionIndependentFile) : base (NSObjectFlag.Empty)
		{
			if (pathToContentsOfResolutionIndependentFile == null)
				throw new ArgumentNullException ("pathToContentsOfResolutionIndependentFile");
			var nspathToContentsOfResolutionIndependentFile = NSString.CreateNative (pathToContentsOfResolutionIndependentFile);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithContentsOfResolutionIndependentFile_pspdf_, nspathToContentsOfResolutionIndependentFile);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithContentsOfResolutionIndependentFile_pspdf_, nspathToContentsOfResolutionIndependentFile);
			}
			NSString.ReleaseNative (nspathToContentsOfResolutionIndependentFile);
			
		}
		
		[CompilerGenerated]
		public static MonoTouch.UIKit.UIImage Pspdf_preloadedImageWithContentsOfFile (string path)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspath = NSString.CreateNative (path);
			
			MonoTouch.UIKit.UIImage ret;
			ret = (MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selPspdf_preloadedImageWithContentsOfFile_, nspath));
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
		[CompilerGenerated]
		public MonoTouch.UIKit.UIImage Pspdf_preloadedImage ()
		{
			return (MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPspdf_preloadedImage));
		}
		
		[CompilerGenerated]
		public static MonoTouch.UIKit.UIImage Pspdf_preloadedImageWithContentsOfFile (string imagePath, bool useJPGTurbo)
		{
			if (imagePath == null)
				throw new ArgumentNullException ("imagePath");
			var nsimagePath = NSString.CreateNative (imagePath);
			
			MonoTouch.UIKit.UIImage ret;
			ret = (MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_bool (class_ptr, selPspdf_preloadedImageWithContentsOfFileUseJPGTurbo_, nsimagePath, useJPGTurbo));
			NSString.ReleaseNative (nsimagePath);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static MonoTouch.UIKit.UIImage Pspdf_preloadedImageWithData (NSData data, bool useJPGTurbo)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			return (MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_bool (class_ptr, selPspdf_preloadedImageWithDataUseJPGTurbo_, data.Handle, useJPGTurbo));
		}
		
		[CompilerGenerated]
		public static MonoTouch.UIKit.UIImage Pspdf_imageNamedBundle (string imageName, NSBundle bundle)
		{
			if (imageName == null)
				throw new ArgumentNullException ("imageName");
			if (bundle == null)
				throw new ArgumentNullException ("bundle");
			var nsimageName = NSString.CreateNative (imageName);
			
			MonoTouch.UIKit.UIImage ret;
			ret = (MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selPspdf_imageNamedBundle_, nsimageName, bundle.Handle));
			NSString.ReleaseNative (nsimageName);
			
			return ret;
		}
		
		[CompilerGenerated]
		public MonoTouch.UIKit.UIImage Pdpdf_imageTintedWithColor (MonoTouch.UIKit.UIColor color, float fraction)
		{
			if (color == null)
				throw new ArgumentNullException ("color");
			return (MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_float (this.Handle, selPdpdf_imageTintedWithColorFraction_, color.Handle, fraction));
		}
		
		[CompilerGenerated]
		public static MonoTouch.UIKit.UIImage Pspdf_animatedGIFWithPath (string path)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspath = NSString.CreateNative (path);
			
			MonoTouch.UIKit.UIImage ret;
			ret = (MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selPspdf_animatedGIFWithPath_, nspath));
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
	} /* class UIImageExtension */
}
