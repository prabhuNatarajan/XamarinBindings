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
	[Register("PSPDFBarButtonItem", true)]
	public unsafe partial class PSPDFBarButtonItem : MonoTouch.UIKit.UIBarButtonItem {
		static readonly IntPtr selIsPopoverVisible = Selector.GetHandle ("isPopoverVisible");
		static readonly IntPtr selPdfController = Selector.GetHandle ("pdfController");
		static readonly IntPtr selIsAvailable = Selector.GetHandle ("isAvailable");
		static readonly IntPtr selDismissPopoverAnimated_ = Selector.GetHandle ("dismissPopoverAnimated:");
		static readonly IntPtr selInitWithPDFViewController_ = Selector.GetHandle ("initWithPDFViewController:");
		static readonly IntPtr selCustomView = Selector.GetHandle ("customView");
		static readonly IntPtr selImage = Selector.GetHandle ("image");
		static readonly IntPtr selSystemItem = Selector.GetHandle ("systemItem");
		static readonly IntPtr selLandscapeImagePhone = Selector.GetHandle ("landscapeImagePhone");
		static readonly IntPtr selActionName = Selector.GetHandle ("actionName");
		static readonly IntPtr selItemStyle = Selector.GetHandle ("itemStyle");
		static readonly IntPtr selUpdateBarButtonItem = Selector.GetHandle ("updateBarButtonItem");
		static readonly IntPtr selPresentAnimatedSender_ = Selector.GetHandle ("presentAnimated:sender:");
		static readonly IntPtr selDismissAnimated_ = Selector.GetHandle ("dismissAnimated:");
		static readonly IntPtr selDidDismiss = Selector.GetHandle ("didDismiss");
		static readonly IntPtr selPresentModalOrInPopoverSender_ = Selector.GetHandle ("presentModalOrInPopover:sender:");
		static readonly IntPtr selDismissModalOrPopoverAnimated_ = Selector.GetHandle ("dismissModalOrPopoverAnimated:");
		static readonly IntPtr selPopoverControllerForObject_ = Selector.GetHandle ("popoverControllerForObject:");
		static readonly IntPtr selAction_ = Selector.GetHandle ("action:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFBarButtonItem");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFBarButtonItem () : base (NSObjectFlag.Empty)
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
		public PSPDFBarButtonItem (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFBarButtonItem (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFBarButtonItem (IntPtr handle) : base (handle) {}

		[Export ("dismissPopoverAnimated:")]
		[CompilerGenerated]
		public static void DismissPopoverAnimated (bool animated)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (class_ptr, selDismissPopoverAnimated_, animated);
		}
		
		[Export ("initWithPDFViewController:")]
		[CompilerGenerated]
		public PSPDFBarButtonItem (PSPDFViewController pdfViewController) : base (NSObjectFlag.Empty)
		{
			if (pdfViewController == null)
				throw new ArgumentNullException ("pdfViewController");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithPDFViewController_, pdfViewController.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithPDFViewController_, pdfViewController.Handle);
			}
		}
		
		[Export ("customView")]
		[CompilerGenerated]
		public new virtual MonoTouch.UIKit.UIView CustomView ()
		{
			if (IsDirectBinding) {
				return (MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCustomView));
			} else {
				return (MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCustomView));
			}
		}
		
		[Export ("image")]
		[CompilerGenerated]
		public new virtual MonoTouch.UIKit.UIImage Image ()
		{
			if (IsDirectBinding) {
				return (MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selImage));
			} else {
				return (MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selImage));
			}
		}
		
		[Export ("systemItem")]
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIBarButtonSystemItem SystemItem ()
		{
			if (IsDirectBinding) {
				return (MonoTouch.UIKit.UIBarButtonSystemItem) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selSystemItem);
			} else {
				return (MonoTouch.UIKit.UIBarButtonSystemItem) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selSystemItem);
			}
		}
		
		[Export ("landscapeImagePhone")]
		[CompilerGenerated]
		public new virtual MonoTouch.UIKit.UIImage LandscapeImagePhone ()
		{
			if (IsDirectBinding) {
				return (MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLandscapeImagePhone));
			} else {
				return (MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLandscapeImagePhone));
			}
		}
		
		[Export ("actionName")]
		[CompilerGenerated]
		public virtual string ActionName ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selActionName));
			} else {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selActionName));
			}
		}
		
		[Export ("itemStyle")]
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIBarButtonItemStyle ItemStyle ()
		{
			if (IsDirectBinding) {
				return (MonoTouch.UIKit.UIBarButtonItemStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selItemStyle);
			} else {
				return (MonoTouch.UIKit.UIBarButtonItemStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selItemStyle);
			}
		}
		
		[Export ("updateBarButtonItem")]
		[CompilerGenerated]
		public virtual void UpdateBarButtonItem ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateBarButtonItem);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selUpdateBarButtonItem);
			}
		}
		
		[Export ("presentAnimated:sender:")]
		[CompilerGenerated]
		public virtual NSObject PresentAnimatedSender (bool animated, PSPDFBarButtonItem sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				return (NSObject) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_bool_IntPtr (this.Handle, selPresentAnimatedSender_, animated, sender.Handle));
			} else {
				return (NSObject) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, selPresentAnimatedSender_, animated, sender.Handle));
			}
		}
		
		[Export ("dismissAnimated:")]
		[CompilerGenerated]
		public virtual void DismissAnimated (bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selDismissAnimated_, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selDismissAnimated_, animated);
			}
		}
		
		[Export ("didDismiss")]
		[CompilerGenerated]
		public virtual void DidDismiss ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDidDismiss);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selDidDismiss);
			}
		}
		
		[Export ("presentModalOrInPopover:sender:")]
		[CompilerGenerated]
		public virtual NSObject PresentModalOrInPopoverSender (MonoTouch.UIKit.UIViewController viewController, NSObject sender)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				return (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selPresentModalOrInPopoverSender_, viewController.Handle, sender.Handle));
			} else {
				return (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selPresentModalOrInPopoverSender_, viewController.Handle, sender.Handle));
			}
		}
		
		[Export ("dismissModalOrPopoverAnimated:")]
		[CompilerGenerated]
		public virtual void DismissModalOrPopoverAnimated (bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selDismissModalOrPopoverAnimated_, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selDismissModalOrPopoverAnimated_, animated);
			}
		}
		
		[Export ("popoverControllerForObject:")]
		[CompilerGenerated]
		public static MonoTouch.UIKit.UIPopoverController PopoverControllerForObject (NSObject obj)
		{
			if (obj == null)
				throw new ArgumentNullException ("obj");
			return (MonoTouch.UIKit.UIPopoverController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selPopoverControllerForObject_, obj.Handle));
		}
		
		[Export ("action:")]
		[CompilerGenerated]
		public new virtual void Action (PSPDFBarButtonItem sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAction_, sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selAction_, sender.Handle);
			}
		}
		
		[CompilerGenerated]
		public static bool IsPopoverVisible {
			[Export ("isPopoverVisible")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsPopoverVisible);
			}
			
		}
		
		object __mt_PdfController_var;
		[CompilerGenerated]
		public virtual PSPDFViewController PdfController {
			[Export ("pdfController")]
			get {
				PSPDFViewController ret;
				if (IsDirectBinding) {
					ret = (PSPDFViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPdfController));
				} else {
					ret = (PSPDFViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPdfController));
				}
				MarkDirty ();
				__mt_PdfController_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsAvailable {
			[Export ("isAvailable")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAvailable);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsAvailable);
				}
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_PdfController_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFBarButtonItem */
}
