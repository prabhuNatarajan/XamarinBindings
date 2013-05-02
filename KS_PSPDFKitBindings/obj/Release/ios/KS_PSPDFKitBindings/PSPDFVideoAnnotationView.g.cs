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
	[Register("PSPDFVideoAnnotationView", true)]
	public unsafe partial class PSPDFVideoAnnotationView : PSPDFLinkAnnotationBaseView {
		[CompilerGenerated]
		const string selURL = "URL";
		static readonly IntPtr selURLHandle = Selector.GetHandle ("URL");
		[CompilerGenerated]
		const string selSetURL_ = "setURL:";
		static readonly IntPtr selSetURL_Handle = Selector.GetHandle ("setURL:");
		[CompilerGenerated]
		const string selIsAutoplayEnabled = "isAutoplayEnabled";
		static readonly IntPtr selIsAutoplayEnabledHandle = Selector.GetHandle ("isAutoplayEnabled");
		[CompilerGenerated]
		const string selSetAutoplayEnabled_ = "setAutoplayEnabled:";
		static readonly IntPtr selSetAutoplayEnabled_Handle = Selector.GetHandle ("setAutoplayEnabled:");
		[CompilerGenerated]
		const string selPlayer = "player";
		static readonly IntPtr selPlayerHandle = Selector.GetHandle ("player");
		[CompilerGenerated]
		const string selCoverView = "coverView";
		static readonly IntPtr selCoverViewHandle = Selector.GetHandle ("coverView");
		[CompilerGenerated]
		const string selSetCoverView_ = "setCoverView:";
		static readonly IntPtr selSetCoverView_Handle = Selector.GetHandle ("setCoverView:");
		[CompilerGenerated]
		const string selZIndex = "zIndex";
		static readonly IntPtr selZIndexHandle = Selector.GetHandle ("zIndex");
		[CompilerGenerated]
		const string selSetZIndex_ = "setZIndex:";
		static readonly IntPtr selSetZIndex_Handle = Selector.GetHandle ("setZIndex:");
		[CompilerGenerated]
		const string selCoverURL = "coverURL";
		static readonly IntPtr selCoverURLHandle = Selector.GetHandle ("coverURL");
		[CompilerGenerated]
		const string selAddCoverView = "addCoverView";
		static readonly IntPtr selAddCoverViewHandle = Selector.GetHandle ("addCoverView");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFVideoAnnotationView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFVideoAnnotationView () : base (NSObjectFlag.Empty)
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
		public PSPDFVideoAnnotationView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFVideoAnnotationView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFVideoAnnotationView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public NSUrl CoverURL ()
		{
			return (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCoverURLHandle));
		}
		
		[CompilerGenerated]
		public void AddCoverView ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selAddCoverViewHandle);
		}
		
		[CompilerGenerated]
		object __mt_Url_var;
		[CompilerGenerated]
		public virtual NSUrl Url {
			[Export ("URL")]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selURLHandle));
				} else {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selURLHandle));
				}
				MarkDirty ();
				__mt_Url_var = ret;
				return ret;
			}
			
			[Export ("setURL:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetURL_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetURL_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Url_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool AutostartEnabled {
			[Export ("isAutoplayEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAutoplayEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsAutoplayEnabledHandle);
				}
			}
			
			[Export ("setAutoplayEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutoplayEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAutoplayEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Player_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.MediaPlayer.MPMoviePlayerController Player {
			[Export ("player")]
			get {
				global::MonoTouch.MediaPlayer.MPMoviePlayerController ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.MediaPlayer.MPMoviePlayerController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPlayerHandle));
				} else {
					ret = (global::MonoTouch.MediaPlayer.MPMoviePlayerController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPlayerHandle));
				}
				MarkDirty ();
				__mt_Player_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_CoverView_var;
		[CompilerGenerated]
		public virtual PSPDFVideoAnnotationCoverView CoverView {
			[Export ("coverView")]
			get {
				PSPDFVideoAnnotationCoverView ret;
				if (IsDirectBinding) {
					ret = (PSPDFVideoAnnotationCoverView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCoverViewHandle));
				} else {
					ret = (PSPDFVideoAnnotationCoverView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCoverViewHandle));
				}
				MarkDirty ();
				__mt_CoverView_var = ret;
				return ret;
			}
			
			[Export ("setCoverView:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCoverView_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCoverView_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_CoverView_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 ZIndex {
			[Export ("zIndex", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selZIndexHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selZIndexHandle);
				}
			}
			
			[Export ("setZIndex:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetZIndex_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetZIndex_Handle, value);
				}
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Url_var = null;
				__mt_Player_var = null;
				__mt_CoverView_var = null;
			}
		}
	} /* class PSPDFVideoAnnotationView */
}
