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
	[Register("PSPDFVideoAnnotationView", true)]
	public unsafe partial class PSPDFVideoAnnotationView : PSPDFLinkAnnotationBaseView {
		static readonly IntPtr selURL = Selector.GetHandle ("URL");
		static readonly IntPtr selSetURL_ = Selector.GetHandle ("setURL:");
		static readonly IntPtr selIsAutostartEnabled = Selector.GetHandle ("isAutostartEnabled");
		static readonly IntPtr selSetAutostartEnabled_ = Selector.GetHandle ("setAutostartEnabled:");
		static readonly IntPtr selUseApplicationAudioSession = Selector.GetHandle ("useApplicationAudioSession");
		static readonly IntPtr selSetUseApplicationAudioSession_ = Selector.GetHandle ("setUseApplicationAudioSession:");
		static readonly IntPtr selPlayer = Selector.GetHandle ("player");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFVideoAnnotationView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFVideoAnnotationView () : base (NSObjectFlag.Empty)
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
		public PSPDFVideoAnnotationView (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFVideoAnnotationView (IntPtr handle) : base (handle) {}

		object __mt_Url_var;
		[CompilerGenerated]
		public virtual NSUrl Url {
			[Export ("URL")]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selURL));
				} else {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selURL));
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
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetURL_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetURL_, value.Handle);
				}
				MarkDirty ();
				__mt_Url_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool AutostartEnabled {
			[Export ("isAutostartEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAutostartEnabled);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsAutostartEnabled);
				}
			}
			
			[Export ("setAutostartEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutostartEnabled_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAutostartEnabled_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool UseApplicationAudioSession {
			[Export ("useApplicationAudioSession", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUseApplicationAudioSession);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selUseApplicationAudioSession);
				}
			}
			
			[Export ("setUseApplicationAudioSession:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUseApplicationAudioSession_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetUseApplicationAudioSession_, value);
				}
			}
		}
		
		object __mt_Player_var;
		[CompilerGenerated]
		public virtual MonoTouch.MediaPlayer.MPMoviePlayerController Player {
			[Export ("player")]
			get {
				MonoTouch.MediaPlayer.MPMoviePlayerController ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.MediaPlayer.MPMoviePlayerController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPlayer));
				} else {
					ret = (MonoTouch.MediaPlayer.MPMoviePlayerController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPlayer));
				}
				MarkDirty ();
				__mt_Player_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_Url_var = null;
			__mt_Player_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFVideoAnnotationView */
}
