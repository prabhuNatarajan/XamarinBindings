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
	[Register("PSPDFWebViewController", true)]
	public unsafe partial class PSPDFWebViewController : PSPDFBaseViewController {
		static readonly IntPtr selAvailableActions = Selector.GetHandle ("availableActions");
		static readonly IntPtr selSetAvailableActions_ = Selector.GetHandle ("setAvailableActions:");
		static readonly IntPtr selWebView = Selector.GetHandle ("webView");
		static readonly IntPtr selPopoverController = Selector.GetHandle ("popoverController");
		static readonly IntPtr selSetPopoverController_ = Selector.GetHandle ("setPopoverController:");
		static readonly IntPtr selModalWebViewWithURL_ = Selector.GetHandle ("modalWebViewWithURL:");
		static readonly IntPtr selInitWithURL_ = Selector.GetHandle ("initWithURL:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFWebViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFWebViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFWebViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFWebViewController (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFWebViewController (IntPtr handle) : base (handle) {}

		[Export ("modalWebViewWithURL:")]
		[CompilerGenerated]
		public static MonoTouch.UIKit.UINavigationController ModalWebViewWithURL (NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			return (MonoTouch.UIKit.UINavigationController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selModalWebViewWithURL_, url.Handle));
		}
		
		[Export ("initWithURL:")]
		[CompilerGenerated]
		public PSPDFWebViewController (NSUrl url) : base (NSObjectFlag.Empty)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithURL_, url.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithURL_, url.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFWebViewControllerAvailableActions AvailableActions {
			[Export ("availableActions", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFWebViewControllerAvailableActions) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selAvailableActions);
				} else {
					return (PSPDFWebViewControllerAvailableActions) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selAvailableActions);
				}
			}
			
			[Export ("setAvailableActions:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetAvailableActions_, (UInt32)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetAvailableActions_, (UInt32)value);
				}
			}
		}
		
		object __mt_WebView_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIWebView WebView {
			[Export ("webView")]
			get {
				MonoTouch.UIKit.UIWebView ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIWebView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selWebView));
				} else {
					ret = (MonoTouch.UIKit.UIWebView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selWebView));
				}
				MarkDirty ();
				__mt_WebView_var = ret;
				return ret;
			}
			
		}
		
		object __mt_PopoverController_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIPopoverController PopoverController {
			[Export ("popoverController")]
			get {
				MonoTouch.UIKit.UIPopoverController ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIPopoverController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPopoverController));
				} else {
					ret = (MonoTouch.UIKit.UIPopoverController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPopoverController));
				}
				MarkDirty ();
				__mt_PopoverController_var = ret;
				return ret;
			}
			
			[Export ("setPopoverController:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPopoverController_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPopoverController_, value.Handle);
				}
				MarkDirty ();
				__mt_PopoverController_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_WebView_var = null;
			__mt_PopoverController_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFWebViewController */
}
