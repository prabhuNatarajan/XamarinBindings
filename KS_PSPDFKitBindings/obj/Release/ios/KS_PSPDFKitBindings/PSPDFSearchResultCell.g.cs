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
	[Register("PSPDFSearchResultCell", true)]
	public unsafe partial class PSPDFSearchResultCell : global::MonoTouch.UIKit.UITableViewCell {
		[CompilerGenerated]
		const string selRotatedPageRect = "rotatedPageRect";
		static readonly IntPtr selRotatedPageRectHandle = Selector.GetHandle ("rotatedPageRect");
		[CompilerGenerated]
		const string selSetRotatedPageRect_ = "setRotatedPageRect:";
		static readonly IntPtr selSetRotatedPageRect_Handle = Selector.GetHandle ("setRotatedPageRect:");
		[CompilerGenerated]
		const string selPagePreviewImage = "pagePreviewImage";
		static readonly IntPtr selPagePreviewImageHandle = Selector.GetHandle ("pagePreviewImage");
		[CompilerGenerated]
		const string selSetPagePreviewImage_ = "setPagePreviewImage:";
		static readonly IntPtr selSetPagePreviewImage_Handle = Selector.GetHandle ("setPagePreviewImage:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSearchResultCell");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFSearchResultCell () : base (NSObjectFlag.Empty)
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
		public PSPDFSearchResultCell (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFSearchResultCell (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFSearchResultCell (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
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
			
			[Export ("setRotatedPageRect:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_RectangleF (this.Handle, selSetRotatedPageRect_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_RectangleF (this.SuperHandle, selSetRotatedPageRect_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_PagePreviewImage_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIImage PagePreviewImage {
			[Export ("pagePreviewImage")]
			get {
				global::MonoTouch.UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPagePreviewImageHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPagePreviewImageHandle));
				}
				MarkDirty ();
				__mt_PagePreviewImage_var = ret;
				return ret;
			}
			
			[Export ("setPagePreviewImage:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPagePreviewImage_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPagePreviewImage_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_PagePreviewImage_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_PagePreviewImage_var = null;
			}
		}
	} /* class PSPDFSearchResultCell */
}
