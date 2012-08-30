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
	[Register("PSPDFPageRenderer", true)]
	public unsafe partial class PSPDFPageRenderer : NSObject {
		static readonly IntPtr selRenderPageRefInContextInRectanglePageInfoWithAnnotationsOptions_ = Selector.GetHandle ("renderPageRef:inContext:inRectangle:pageInfo:withAnnotations:options:");
		static readonly IntPtr selRenderPageInContextAtPointWithZoomPageInfoWithAnnotationsOptions_ = Selector.GetHandle ("renderPage:inContext:atPoint:withZoom:pageInfo:withAnnotations:options:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFPageRenderer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFPageRenderer () : base (NSObjectFlag.Empty)
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
		public PSPDFPageRenderer (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFPageRenderer (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFPageRenderer (IntPtr handle) : base (handle) {}

		[Export ("renderPageRef:inContext:inRectangle:pageInfo:withAnnotations:options:")]
		[CompilerGenerated]
		internal static System.Drawing.RectangleF RenderPage_ (System.IntPtr page, System.IntPtr context, System.Drawing.RectangleF rectangle, PSPDFPageInfo pageInfo, PSPDFAnnotation[] annotations, NSDictionary options)
		{
			if (pageInfo == null)
				throw new ArgumentNullException ("pageInfo");
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			if (options == null)
				throw new ArgumentNullException ("options");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			System.Drawing.RectangleF ret;
			ApiDefinition.Messaging.RectangleF_objc_msgSend_stret_IntPtr_IntPtr_RectangleF_IntPtr_IntPtr_IntPtr (out ret, class_ptr, selRenderPageRefInContextInRectanglePageInfoWithAnnotationsOptions_, page, context, rectangle, pageInfo.Handle, nsa_annotations.Handle, options.Handle);
			nsa_annotations.Dispose ();
			
			return ret;
		}
		
		[Export ("renderPage:inContext:atPoint:withZoom:pageInfo:withAnnotations:options:")]
		[CompilerGenerated]
		internal static System.Drawing.SizeF RenderPage_ (System.IntPtr page, System.IntPtr context, System.Drawing.PointF point, float zoom, PSPDFPageInfo pageInfo, PSPDFAnnotation[] annotations, NSDictionary options)
		{
			if (pageInfo == null)
				throw new ArgumentNullException ("pageInfo");
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			if (options == null)
				throw new ArgumentNullException ("options");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			System.Drawing.SizeF ret;
			if (Runtime.Arch == Arch.DEVICE){
				ApiDefinition.Messaging.SizeF_objc_msgSend_stret_IntPtr_IntPtr_PointF_float_IntPtr_IntPtr_IntPtr (out ret, class_ptr, selRenderPageInContextAtPointWithZoomPageInfoWithAnnotationsOptions_, page, context, point, zoom, pageInfo.Handle, nsa_annotations.Handle, options.Handle);
			} else {
				ret = ApiDefinition.Messaging.SizeF_objc_msgSend_IntPtr_IntPtr_PointF_float_IntPtr_IntPtr_IntPtr (class_ptr, selRenderPageInContextAtPointWithZoomPageInfoWithAnnotationsOptions_, page, context, point, zoom, pageInfo.Handle, nsa_annotations.Handle, options.Handle);
			}
			nsa_annotations.Dispose ();
			
			return ret;
		}
		
		static readonly IntPtr __Internal_libraryHandle = Dlfcn.dlopen (null, 0);
		static NSString _PSPDFIgnoreDisplaySettings;
		public static NSString PSPDFIgnoreDisplaySettings {
			get {
				if (_PSPDFIgnoreDisplaySettings == null)
					_PSPDFIgnoreDisplaySettings = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFIgnoreDisplaySettings");
				return _PSPDFIgnoreDisplaySettings;
			}
		}
		static NSString _PSPDFPageColor;
		public static NSString PSPDFPageColor {
			get {
				if (_PSPDFPageColor == null)
					_PSPDFPageColor = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFPageColor");
				return _PSPDFPageColor;
			}
		}
		static NSString _PSPDFContentOpacity;
		public static NSString PSPDFContentOpacity {
			get {
				if (_PSPDFContentOpacity == null)
					_PSPDFContentOpacity = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFContentOpacity");
				return _PSPDFContentOpacity;
			}
		}
		static NSString _PSPDFInvertRendering;
		public static NSString PSPDFInvertRendering {
			get {
				if (_PSPDFInvertRendering == null)
					_PSPDFInvertRendering = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFInvertRendering");
				return _PSPDFInvertRendering;
			}
		}
		static NSString _PSPDFInterpolationQuality;
		public static NSString PSPDFInterpolationQuality {
			get {
				if (_PSPDFInterpolationQuality == null)
					_PSPDFInterpolationQuality = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFInterpolationQuality");
				return _PSPDFInterpolationQuality;
			}
		}
	} /* class PSPDFPageRenderer */
}
