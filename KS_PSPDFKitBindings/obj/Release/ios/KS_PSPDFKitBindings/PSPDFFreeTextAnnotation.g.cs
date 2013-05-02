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
	[Register("PSPDFFreeTextAnnotation", true)]
	public unsafe partial class PSPDFFreeTextAnnotation : PSPDFAnnotation {
		[CompilerGenerated]
		const string selFontName = "fontName";
		static readonly IntPtr selFontNameHandle = Selector.GetHandle ("fontName");
		[CompilerGenerated]
		const string selSetFontName_ = "setFontName:";
		static readonly IntPtr selSetFontName_Handle = Selector.GetHandle ("setFontName:");
		[CompilerGenerated]
		const string selFontSize = "fontSize";
		static readonly IntPtr selFontSizeHandle = Selector.GetHandle ("fontSize");
		[CompilerGenerated]
		const string selSetFontSize_ = "setFontSize:";
		static readonly IntPtr selSetFontSize_Handle = Selector.GetHandle ("setFontSize:");
		[CompilerGenerated]
		const string selDefaultFontSize = "defaultFontSize";
		static readonly IntPtr selDefaultFontSizeHandle = Selector.GetHandle ("defaultFontSize");
		[CompilerGenerated]
		const string selDefaultFontName = "defaultFontName";
		static readonly IntPtr selDefaultFontNameHandle = Selector.GetHandle ("defaultFontName");
		[CompilerGenerated]
		const string selDefaultFont = "defaultFont";
		static readonly IntPtr selDefaultFontHandle = Selector.GetHandle ("defaultFont");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFFreeTextAnnotation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFFreeTextAnnotation () : base (NSObjectFlag.Empty)
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
		public PSPDFFreeTextAnnotation (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFFreeTextAnnotation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFFreeTextAnnotation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual string FontName {
			[Export ("fontName", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFontNameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFontNameHandle));
				}
			}
			
			[Export ("setFontName:", ArgumentSemantic.Copy)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFontName_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFontName_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual float FontSize {
			[Export ("fontSize", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selFontSizeHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selFontSizeHandle);
				}
			}
			
			[Export ("setFontSize:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetFontSize_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetFontSize_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float DefaultFontSize {
			[Export ("defaultFontSize")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selDefaultFontSizeHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selDefaultFontSizeHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string DefaultFontName {
			[Export ("defaultFontName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDefaultFontNameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDefaultFontNameHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_DefaultFont_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIFont DefaultFont {
			[Export ("defaultFont")]
			get {
				global::MonoTouch.UIKit.UIFont ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIFont) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDefaultFontHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIFont) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDefaultFontHandle));
				}
				MarkDirty ();
				__mt_DefaultFont_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_DefaultFont_var = null;
			}
		}
	} /* class PSPDFFreeTextAnnotation */
}
