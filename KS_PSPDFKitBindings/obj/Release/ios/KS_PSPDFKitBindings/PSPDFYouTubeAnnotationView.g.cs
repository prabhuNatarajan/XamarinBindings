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
	[Register("PSPDFYouTubeAnnotationView", true)]
	public unsafe partial class PSPDFYouTubeAnnotationView : PSPDFLinkAnnotationBaseView {
		[CompilerGenerated]
		const string selAnnotation = "annotation";
		static readonly IntPtr selAnnotationHandle = Selector.GetHandle ("annotation");
		[CompilerGenerated]
		const string selSetAnnotation_ = "setAnnotation:";
		static readonly IntPtr selSetAnnotation_Handle = Selector.GetHandle ("setAnnotation:");
		[CompilerGenerated]
		const string selYouTubeURL = "youTubeURL";
		static readonly IntPtr selYouTubeURLHandle = Selector.GetHandle ("youTubeURL");
		[CompilerGenerated]
		const string selError = "error";
		static readonly IntPtr selErrorHandle = Selector.GetHandle ("error");
		[CompilerGenerated]
		const string selIsAutoplayEnabled = "isAutoplayEnabled";
		static readonly IntPtr selIsAutoplayEnabledHandle = Selector.GetHandle ("isAutoplayEnabled");
		[CompilerGenerated]
		const string selSetAutoplayEnabled_ = "setAutoplayEnabled:";
		static readonly IntPtr selSetAutoplayEnabled_Handle = Selector.GetHandle ("setAutoplayEnabled:");
		[CompilerGenerated]
		const string selWebView = "webView";
		static readonly IntPtr selWebViewHandle = Selector.GetHandle ("webView");
		[CompilerGenerated]
		const string selSetWebView_ = "setWebView:";
		static readonly IntPtr selSetWebView_Handle = Selector.GetHandle ("setWebView:");
		[CompilerGenerated]
		const string selPlay = "play";
		static readonly IntPtr selPlayHandle = Selector.GetHandle ("play");
		[CompilerGenerated]
		const string selPause = "pause";
		static readonly IntPtr selPauseHandle = Selector.GetHandle ("pause");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFYouTubeAnnotationView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFYouTubeAnnotationView () : base (NSObjectFlag.Empty)
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
		public PSPDFYouTubeAnnotationView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFYouTubeAnnotationView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFYouTubeAnnotationView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("play")]
		[CompilerGenerated]
		public virtual void Play ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPlayHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selPlayHandle);
			}
		}
		
		[Export ("pause")]
		[CompilerGenerated]
		public virtual void Pause ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPauseHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selPauseHandle);
			}
		}
		
		[CompilerGenerated]
		object __mt_Annotation_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotation Annotation {
			[Export ("annotation")]
			get {
				PSPDFAnnotation ret;
				if (IsDirectBinding) {
					ret = (PSPDFAnnotation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAnnotationHandle));
				} else {
					ret = (PSPDFAnnotation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAnnotationHandle));
				}
				MarkDirty ();
				__mt_Annotation_var = ret;
				return ret;
			}
			
			[Export ("setAnnotation:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAnnotation_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAnnotation_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Annotation_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_YouTubeURL_var;
		[CompilerGenerated]
		public virtual NSUrl YouTubeURL {
			[Export ("youTubeURL")]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selYouTubeURLHandle));
				} else {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selYouTubeURLHandle));
				}
				MarkDirty ();
				__mt_YouTubeURL_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Error_var;
		[CompilerGenerated]
		public virtual NSError Error {
			[Export ("error")]
			get {
				NSError ret;
				if (IsDirectBinding) {
					ret = (NSError) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selErrorHandle));
				} else {
					ret = (NSError) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selErrorHandle));
				}
				MarkDirty ();
				__mt_Error_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool AutoplayEnabled {
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
		object __mt_WebView_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIWebView WebView {
			[Export ("webView", ArgumentSemantic.Assign)]
			get {
				global::MonoTouch.UIKit.UIWebView ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIWebView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selWebViewHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIWebView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selWebViewHandle));
				}
				MarkDirty ();
				__mt_WebView_var = ret;
				return ret;
			}
			
			[Export ("setWebView:", ArgumentSemantic.Assign)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetWebView_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetWebView_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_WebView_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Annotation_var = null;
				__mt_YouTubeURL_var = null;
				__mt_Error_var = null;
				__mt_WebView_var = null;
			}
		}
	} /* class PSPDFYouTubeAnnotationView */
}
