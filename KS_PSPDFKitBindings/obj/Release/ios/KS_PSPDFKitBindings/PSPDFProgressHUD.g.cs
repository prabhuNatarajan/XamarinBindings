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
	[Register("PSPDFProgressHUD", true)]
	public unsafe partial class PSPDFProgressHUD : global::MonoTouch.UIKit.UIView {
		[CompilerGenerated]
		const string selIsVisible = "isVisible";
		static readonly IntPtr selIsVisibleHandle = Selector.GetHandle ("isVisible");
		[CompilerGenerated]
		const string selShow = "show";
		static readonly IntPtr selShowHandle = Selector.GetHandle ("show");
		[CompilerGenerated]
		const string selShowWithMaskType_ = "showWithMaskType:";
		static readonly IntPtr selShowWithMaskType_Handle = Selector.GetHandle ("showWithMaskType:");
		[CompilerGenerated]
		const string selShowWithStatus_ = "showWithStatus:";
		static readonly IntPtr selShowWithStatus_Handle = Selector.GetHandle ("showWithStatus:");
		[CompilerGenerated]
		const string selShowWithStatusMaskType_ = "showWithStatus:maskType:";
		static readonly IntPtr selShowWithStatusMaskType_Handle = Selector.GetHandle ("showWithStatus:maskType:");
		[CompilerGenerated]
		const string selShowProgress_ = "showProgress:";
		static readonly IntPtr selShowProgress_Handle = Selector.GetHandle ("showProgress:");
		[CompilerGenerated]
		const string selShowProgressStatus_ = "showProgress:status:";
		static readonly IntPtr selShowProgressStatus_Handle = Selector.GetHandle ("showProgress:status:");
		[CompilerGenerated]
		const string selShowProgressStatusMaskType_ = "showProgress:status:maskType:";
		static readonly IntPtr selShowProgressStatusMaskType_Handle = Selector.GetHandle ("showProgress:status:maskType:");
		[CompilerGenerated]
		const string selSetStatus_ = "setStatus:";
		static readonly IntPtr selSetStatus_Handle = Selector.GetHandle ("setStatus:");
		[CompilerGenerated]
		const string selShowSuccessWithStatus_ = "showSuccessWithStatus:";
		static readonly IntPtr selShowSuccessWithStatus_Handle = Selector.GetHandle ("showSuccessWithStatus:");
		[CompilerGenerated]
		const string selShowErrorWithStatus_ = "showErrorWithStatus:";
		static readonly IntPtr selShowErrorWithStatus_Handle = Selector.GetHandle ("showErrorWithStatus:");
		[CompilerGenerated]
		const string selShowImageStatus_ = "showImage:status:";
		static readonly IntPtr selShowImageStatus_Handle = Selector.GetHandle ("showImage:status:");
		[CompilerGenerated]
		const string selDismiss = "dismiss";
		static readonly IntPtr selDismissHandle = Selector.GetHandle ("dismiss");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFProgressHUD");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFProgressHUD () : base (NSObjectFlag.Empty)
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
		public PSPDFProgressHUD (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFProgressHUD (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFProgressHUD (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("show")]
		[CompilerGenerated]
		public static void Show ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (class_ptr, selShowHandle);
		}
		
		[Export ("showWithMaskType:")]
		[CompilerGenerated]
		public static void Show (PSPDFProgressHUDMaskType maskType)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (class_ptr, selShowWithMaskType_Handle, (UInt32)maskType);
		}
		
		[Export ("showWithStatus:")]
		[CompilerGenerated]
		public static void Show (string status)
		{
			if (status == null)
				throw new ArgumentNullException ("status");
			var nsstatus = NSString.CreateNative (status);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selShowWithStatus_Handle, nsstatus);
			NSString.ReleaseNative (nsstatus);
			
		}
		
		[Export ("showWithStatus:maskType:")]
		[CompilerGenerated]
		public static void Show (string status, PSPDFProgressHUDMaskType maskType)
		{
			if (status == null)
				throw new ArgumentNullException ("status");
			var nsstatus = NSString.CreateNative (status);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UInt32 (class_ptr, selShowWithStatusMaskType_Handle, nsstatus, (UInt32)maskType);
			NSString.ReleaseNative (nsstatus);
			
		}
		
		[Export ("showProgress:")]
		[CompilerGenerated]
		public static void ShowProgress (float progress)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (class_ptr, selShowProgress_Handle, progress);
		}
		
		[Export ("showProgress:status:")]
		[CompilerGenerated]
		public static void ShowProgress (float progress, string status)
		{
			if (status == null)
				throw new ArgumentNullException ("status");
			var nsstatus = NSString.CreateNative (status);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float_IntPtr (class_ptr, selShowProgressStatus_Handle, progress, nsstatus);
			NSString.ReleaseNative (nsstatus);
			
		}
		
		[Export ("showProgress:status:maskType:")]
		[CompilerGenerated]
		public static void ShowProgress (float progress, string status, PSPDFProgressHUDMaskType maskType)
		{
			if (status == null)
				throw new ArgumentNullException ("status");
			var nsstatus = NSString.CreateNative (status);
			
			ApiDefinition.Messaging.void_objc_msgSend_float_IntPtr_UInt32 (class_ptr, selShowProgressStatusMaskType_Handle, progress, nsstatus, (UInt32)maskType);
			NSString.ReleaseNative (nsstatus);
			
		}
		
		[Export ("setStatus:")]
		[CompilerGenerated]
		public static void SetStatus (string status)
		{
			if (status == null)
				throw new ArgumentNullException ("status");
			var nsstatus = NSString.CreateNative (status);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selSetStatus_Handle, nsstatus);
			NSString.ReleaseNative (nsstatus);
			
		}
		
		[Export ("showSuccessWithStatus:")]
		[CompilerGenerated]
		public static void ShowSuccessWithStatus (string status)
		{
			if (status == null)
				throw new ArgumentNullException ("status");
			var nsstatus = NSString.CreateNative (status);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selShowSuccessWithStatus_Handle, nsstatus);
			NSString.ReleaseNative (nsstatus);
			
		}
		
		[Export ("showErrorWithStatus:")]
		[CompilerGenerated]
		public static void ShowErrorWithStatus (string status)
		{
			if (status == null)
				throw new ArgumentNullException ("status");
			var nsstatus = NSString.CreateNative (status);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selShowErrorWithStatus_Handle, nsstatus);
			NSString.ReleaseNative (nsstatus);
			
		}
		
		[Export ("showImage:status:")]
		[CompilerGenerated]
		public static void ShowImage (global::MonoTouch.UIKit.UIImage image, string status)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			if (status == null)
				throw new ArgumentNullException ("status");
			var nsstatus = NSString.CreateNative (status);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, selShowImageStatus_Handle, image.Handle, nsstatus);
			NSString.ReleaseNative (nsstatus);
			
		}
		
		[Export ("dismiss")]
		[CompilerGenerated]
		public static void Dismiss ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (class_ptr, selDismissHandle);
		}
		
		[CompilerGenerated]
		public static bool IsVisible {
			[Export ("isVisible")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsVisibleHandle);
			}
			
		}
		
	} /* class PSPDFProgressHUD */
}
