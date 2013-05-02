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
	[Register("PSPDFVideoAnnotationCoverView", true)]
	public unsafe partial class PSPDFVideoAnnotationCoverView : global::MonoTouch.UIKit.UIView {
		[CompilerGenerated]
		const string selCoverImage = "coverImage";
		static readonly IntPtr selCoverImageHandle = Selector.GetHandle ("coverImage");
		[CompilerGenerated]
		const string selSetCoverImage_ = "setCoverImage:";
		static readonly IntPtr selSetCoverImage_Handle = Selector.GetHandle ("setCoverImage:");
		[CompilerGenerated]
		const string selPlayButton = "playButton";
		static readonly IntPtr selPlayButtonHandle = Selector.GetHandle ("playButton");
		[CompilerGenerated]
		const string selSetPlayButton_ = "setPlayButton:";
		static readonly IntPtr selSetPlayButton_Handle = Selector.GetHandle ("setPlayButton:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFVideoAnnotationCoverView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFVideoAnnotationCoverView () : base (NSObjectFlag.Empty)
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
		public PSPDFVideoAnnotationCoverView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFVideoAnnotationCoverView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFVideoAnnotationCoverView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_CoverImage_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIImageView CoverImage {
			[Export ("coverImage")]
			get {
				global::MonoTouch.UIKit.UIImageView ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCoverImageHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCoverImageHandle));
				}
				MarkDirty ();
				__mt_CoverImage_var = ret;
				return ret;
			}
			
			[Export ("setCoverImage:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCoverImage_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCoverImage_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_CoverImage_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_PlayButton_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIButton PlayButton {
			[Export ("playButton")]
			get {
				global::MonoTouch.UIKit.UIButton ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIButton) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPlayButtonHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIButton) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPlayButtonHandle));
				}
				MarkDirty ();
				__mt_PlayButton_var = ret;
				return ret;
			}
			
			[Export ("setPlayButton:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPlayButton_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPlayButton_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_PlayButton_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_CoverImage_var = null;
				__mt_PlayButton_var = null;
			}
		}
	} /* class PSPDFVideoAnnotationCoverView */
}
