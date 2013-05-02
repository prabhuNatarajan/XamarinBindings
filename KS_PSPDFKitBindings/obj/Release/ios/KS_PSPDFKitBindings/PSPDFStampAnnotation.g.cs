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
	[Register("PSPDFStampAnnotation", true)]
	public unsafe partial class PSPDFStampAnnotation : PSPDFAnnotation {
		[CompilerGenerated]
		const string selSubject = "subject";
		static readonly IntPtr selSubjectHandle = Selector.GetHandle ("subject");
		[CompilerGenerated]
		const string selSetSubject_ = "setSubject:";
		static readonly IntPtr selSetSubject_Handle = Selector.GetHandle ("setSubject:");
		[CompilerGenerated]
		const string selSubtext = "subtext";
		static readonly IntPtr selSubtextHandle = Selector.GetHandle ("subtext");
		[CompilerGenerated]
		const string selSetSubtext_ = "setSubtext:";
		static readonly IntPtr selSetSubtext_Handle = Selector.GetHandle ("setSubtext:");
		[CompilerGenerated]
		const string selImage = "image";
		static readonly IntPtr selImageHandle = Selector.GetHandle ("image");
		[CompilerGenerated]
		const string selSetImage_ = "setImage:";
		static readonly IntPtr selSetImage_Handle = Selector.GetHandle ("setImage:");
		[CompilerGenerated]
		const string selLoadImage = "loadImage";
		static readonly IntPtr selLoadImageHandle = Selector.GetHandle ("loadImage");
		[CompilerGenerated]
		const string selImageTransform = "imageTransform";
		static readonly IntPtr selImageTransformHandle = Selector.GetHandle ("imageTransform");
		[CompilerGenerated]
		const string selSetImageTransform_ = "setImageTransform:";
		static readonly IntPtr selSetImageTransform_Handle = Selector.GetHandle ("setImageTransform:");
		[CompilerGenerated]
		const string selStampColorForSubject_ = "stampColorForSubject:";
		static readonly IntPtr selStampColorForSubject_Handle = Selector.GetHandle ("stampColorForSubject:");
		[CompilerGenerated]
		const string selInitWithSubject_ = "initWithSubject:";
		static readonly IntPtr selInitWithSubject_Handle = Selector.GetHandle ("initWithSubject:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFStampAnnotation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFStampAnnotation () : base (NSObjectFlag.Empty)
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
		public PSPDFStampAnnotation (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFStampAnnotation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFStampAnnotation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("stampColorForSubject:")]
		[CompilerGenerated]
		public static global::MonoTouch.UIKit.UIColor StampColorForSubject (string subject)
		{
			if (subject == null)
				throw new ArgumentNullException ("subject");
			var nssubject = NSString.CreateNative (subject);
			
			global::MonoTouch.UIKit.UIColor ret;
			ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selStampColorForSubject_Handle, nssubject));
			NSString.ReleaseNative (nssubject);
			
			return ret;
		}
		
		[Export ("initWithSubject:")]
		[CompilerGenerated]
		public PSPDFStampAnnotation (string subject)
			: base (NSObjectFlag.Empty)
		{
			if (subject == null)
				throw new ArgumentNullException ("subject");
			var nssubject = NSString.CreateNative (subject);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithSubject_Handle, nssubject);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithSubject_Handle, nssubject);
			}
			NSString.ReleaseNative (nssubject);
			
		}
		
		[CompilerGenerated]
		public virtual string Subject {
			[Export ("subject", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSubjectHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSubjectHandle));
				}
			}
			
			[Export ("setSubject:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSubject_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSubject_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string Subtext {
			[Export ("subtext", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSubtextHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSubtextHandle));
				}
			}
			
			[Export ("setSubtext:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSubtext_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSubtext_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
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
			
			[Export ("setImage:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetImage_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetImage_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Image_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_LoadImage_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIImage LoadImage {
			[Export ("loadImage")]
			get {
				global::MonoTouch.UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLoadImageHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLoadImageHandle));
				}
				MarkDirty ();
				__mt_LoadImage_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual CGAffineTransform ImageTransform {
			[Export ("imageTransform", ArgumentSemantic.Assign)]
			get {
				CGAffineTransform ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret (out ret, this.Handle, selImageTransformHandle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper_stret (out ret, this.SuperHandle, selImageTransformHandle);
				}
				return ret;
			}
			
			[Export ("setImageTransform:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_CGAffineTransform (this.Handle, selSetImageTransform_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_CGAffineTransform (this.SuperHandle, selSetImageTransform_Handle, value);
				}
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Image_var = null;
				__mt_LoadImage_var = null;
			}
		}
	} /* class PSPDFStampAnnotation */
}
