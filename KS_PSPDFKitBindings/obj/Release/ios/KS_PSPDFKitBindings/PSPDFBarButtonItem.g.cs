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
	[Register("PSPDFBarButtonItem", true)]
	public unsafe partial class PSPDFBarButtonItem : global::MonoTouch.UIKit.UIBarButtonItem {
		[CompilerGenerated]
		const string selIsPopoverVisible = "isPopoverVisible";
		static readonly IntPtr selIsPopoverVisibleHandle = Selector.GetHandle ("isPopoverVisible");
		[CompilerGenerated]
		const string selPdfController = "pdfController";
		static readonly IntPtr selPdfControllerHandle = Selector.GetHandle ("pdfController");
		[CompilerGenerated]
		const string selActionSheet = "actionSheet";
		static readonly IntPtr selActionSheetHandle = Selector.GetHandle ("actionSheet");
		[CompilerGenerated]
		const string selSetActionSheet_ = "setActionSheet:";
		static readonly IntPtr selSetActionSheet_Handle = Selector.GetHandle ("setActionSheet:");
		[CompilerGenerated]
		const string selDismissingSheet = "dismissingSheet";
		static readonly IntPtr selDismissingSheetHandle = Selector.GetHandle ("dismissingSheet");
		[CompilerGenerated]
		const string selIsDismissingSheet = "isDismissingSheet";
		static readonly IntPtr selIsDismissingSheetHandle = Selector.GetHandle ("isDismissingSheet");
		[CompilerGenerated]
		const string selDismissPopoverAnimated_ = "dismissPopoverAnimated:";
		static readonly IntPtr selDismissPopoverAnimated_Handle = Selector.GetHandle ("dismissPopoverAnimated:");
		[CompilerGenerated]
		const string selInitWithPDFViewController_ = "initWithPDFViewController:";
		static readonly IntPtr selInitWithPDFViewController_Handle = Selector.GetHandle ("initWithPDFViewController:");
		[CompilerGenerated]
		const string selCustomView = "customView";
		static readonly IntPtr selCustomViewHandle = Selector.GetHandle ("customView");
		[CompilerGenerated]
		const string selImage = "image";
		static readonly IntPtr selImageHandle = Selector.GetHandle ("image");
		[CompilerGenerated]
		const string selSystemItem = "systemItem";
		static readonly IntPtr selSystemItemHandle = Selector.GetHandle ("systemItem");
		[CompilerGenerated]
		const string selLandscapeImagePhone = "landscapeImagePhone";
		static readonly IntPtr selLandscapeImagePhoneHandle = Selector.GetHandle ("landscapeImagePhone");
		[CompilerGenerated]
		const string selActionName = "actionName";
		static readonly IntPtr selActionNameHandle = Selector.GetHandle ("actionName");
		[CompilerGenerated]
		const string selItemStyle = "itemStyle";
		static readonly IntPtr selItemStyleHandle = Selector.GetHandle ("itemStyle");
		[CompilerGenerated]
		const string selIsAvailable = "isAvailable";
		static readonly IntPtr selIsAvailableHandle = Selector.GetHandle ("isAvailable");
		[CompilerGenerated]
		const string selIsLongPressActionAvailable = "isLongPressActionAvailable";
		static readonly IntPtr selIsLongPressActionAvailableHandle = Selector.GetHandle ("isLongPressActionAvailable");
		[CompilerGenerated]
		const string selUpdateBarButtonItem = "updateBarButtonItem";
		static readonly IntPtr selUpdateBarButtonItemHandle = Selector.GetHandle ("updateBarButtonItem");
		[CompilerGenerated]
		const string selIsLongPressActionActive = "isLongPressActionActive";
		static readonly IntPtr selIsLongPressActionActiveHandle = Selector.GetHandle ("isLongPressActionActive");
		[CompilerGenerated]
		const string selPresentAnimatedSender_ = "presentAnimated:sender:";
		static readonly IntPtr selPresentAnimatedSender_Handle = Selector.GetHandle ("presentAnimated:sender:");
		[CompilerGenerated]
		const string selDismissAnimated_ = "dismissAnimated:";
		static readonly IntPtr selDismissAnimated_Handle = Selector.GetHandle ("dismissAnimated:");
		[CompilerGenerated]
		const string selDidDismiss = "didDismiss";
		static readonly IntPtr selDidDismissHandle = Selector.GetHandle ("didDismiss");
		[CompilerGenerated]
		const string selSetPresentedObjectSender_ = "setPresentedObject:sender:";
		static readonly IntPtr selSetPresentedObjectSender_Handle = Selector.GetHandle ("setPresentedObject:sender:");
		[CompilerGenerated]
		const string selPresentModalOrInPopoverSender_ = "presentModalOrInPopover:sender:";
		static readonly IntPtr selPresentModalOrInPopoverSender_Handle = Selector.GetHandle ("presentModalOrInPopover:sender:");
		[CompilerGenerated]
		const string selDismissModalOrPopoverAnimated_ = "dismissModalOrPopoverAnimated:";
		static readonly IntPtr selDismissModalOrPopoverAnimated_Handle = Selector.GetHandle ("dismissModalOrPopoverAnimated:");
		[CompilerGenerated]
		const string selPopoverControllerForObject_ = "popoverControllerForObject:";
		static readonly IntPtr selPopoverControllerForObject_Handle = Selector.GetHandle ("popoverControllerForObject:");
		[CompilerGenerated]
		const string selAction_ = "action:";
		static readonly IntPtr selAction_Handle = Selector.GetHandle ("action:");
		[CompilerGenerated]
		const string selLongPressAction_ = "longPressAction:";
		static readonly IntPtr selLongPressAction_Handle = Selector.GetHandle ("longPressAction:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFBarButtonItem");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFBarButtonItem () : base (NSObjectFlag.Empty)
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
		public PSPDFBarButtonItem (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFBarButtonItem (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("dismissPopoverAnimated:")]
		[CompilerGenerated]
		public static void DismissPopoverAnimated (bool animated)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (class_ptr, selDismissPopoverAnimated_Handle, animated);
		}
		
		[Export ("initWithPDFViewController:")]
		[CompilerGenerated]
		public PSPDFBarButtonItem (PSPDFViewController pdfViewController)
			: base (NSObjectFlag.Empty)
		{
			if (pdfViewController == null)
				throw new ArgumentNullException ("pdfViewController");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithPDFViewController_Handle, pdfViewController.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithPDFViewController_Handle, pdfViewController.Handle);
			}
		}
		
		[Export ("customView")]
		[CompilerGenerated]
		public new virtual global::MonoTouch.UIKit.UIView CustomView ()
		{
			if (IsDirectBinding) {
				return (global::MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCustomViewHandle));
			} else {
				return (global::MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCustomViewHandle));
			}
		}
		
		[Export ("image")]
		[CompilerGenerated]
		public new virtual global::MonoTouch.UIKit.UIImage Image ()
		{
			if (IsDirectBinding) {
				return (global::MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selImageHandle));
			} else {
				return (global::MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selImageHandle));
			}
		}
		
		[Export ("systemItem")]
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIBarButtonSystemItem SystemItem ()
		{
			if (IsDirectBinding) {
				return (global::MonoTouch.UIKit.UIBarButtonSystemItem) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selSystemItemHandle);
			} else {
				return (global::MonoTouch.UIKit.UIBarButtonSystemItem) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selSystemItemHandle);
			}
		}
		
		[Export ("landscapeImagePhone")]
		[CompilerGenerated]
		public new virtual global::MonoTouch.UIKit.UIImage LandscapeImagePhone ()
		{
			if (IsDirectBinding) {
				return (global::MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLandscapeImagePhoneHandle));
			} else {
				return (global::MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLandscapeImagePhoneHandle));
			}
		}
		
		[Export ("actionName")]
		[CompilerGenerated]
		public virtual string ActionName ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selActionNameHandle));
			} else {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selActionNameHandle));
			}
		}
		
		[Export ("itemStyle")]
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIBarButtonItemStyle ItemStyle ()
		{
			if (IsDirectBinding) {
				return (global::MonoTouch.UIKit.UIBarButtonItemStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selItemStyleHandle);
			} else {
				return (global::MonoTouch.UIKit.UIBarButtonItemStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selItemStyleHandle);
			}
		}
		
		[Export ("isAvailable")]
		[CompilerGenerated]
		public virtual bool IsAvailable ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAvailableHandle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsAvailableHandle);
			}
		}
		
		[Export ("isLongPressActionAvailable")]
		[CompilerGenerated]
		public virtual bool IsLongPressActionAvailable ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsLongPressActionAvailableHandle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsLongPressActionAvailableHandle);
			}
		}
		
		[Export ("updateBarButtonItem")]
		[CompilerGenerated]
		public virtual void UpdateBarButtonItem ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateBarButtonItemHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selUpdateBarButtonItemHandle);
			}
		}
		
		[Export ("isLongPressActionActive")]
		[CompilerGenerated]
		public virtual void IsLongPressActionActive ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selIsLongPressActionActiveHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selIsLongPressActionActiveHandle);
			}
		}
		
		[Export ("presentAnimated:sender:")]
		[CompilerGenerated]
		public virtual NSObject PresentAnimatedSender (bool animated, PSPDFBarButtonItem sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				return (NSObject) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_bool_IntPtr (this.Handle, selPresentAnimatedSender_Handle, animated, sender.Handle));
			} else {
				return (NSObject) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, selPresentAnimatedSender_Handle, animated, sender.Handle));
			}
		}
		
		[Export ("dismissAnimated:")]
		[CompilerGenerated]
		public virtual void DismissAnimated (bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selDismissAnimated_Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selDismissAnimated_Handle, animated);
			}
		}
		
		[Export ("didDismiss")]
		[CompilerGenerated]
		public virtual void DidDismiss ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDidDismissHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selDidDismissHandle);
			}
		}
		
		[Export ("setPresentedObject:sender:")]
		[CompilerGenerated]
		public virtual void SetPresentedObject (NSObject presentedObject, NSObject sender)
		{
			if (presentedObject == null)
				throw new ArgumentNullException ("presentedObject");
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSetPresentedObjectSender_Handle, presentedObject.Handle, sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSetPresentedObjectSender_Handle, presentedObject.Handle, sender.Handle);
			}
		}
		
		[Export ("presentModalOrInPopover:sender:")]
		[CompilerGenerated]
		public virtual NSObject PresentModalOrInPopoverSender (global::MonoTouch.UIKit.UIViewController viewController, NSObject sender)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				return (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selPresentModalOrInPopoverSender_Handle, viewController.Handle, sender.Handle));
			} else {
				return (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selPresentModalOrInPopoverSender_Handle, viewController.Handle, sender.Handle));
			}
		}
		
		[Export ("dismissModalOrPopoverAnimated:")]
		[CompilerGenerated]
		public virtual void DismissModalOrPopoverAnimated (bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selDismissModalOrPopoverAnimated_Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selDismissModalOrPopoverAnimated_Handle, animated);
			}
		}
		
		[Export ("popoverControllerForObject:")]
		[CompilerGenerated]
		public static global::MonoTouch.UIKit.UIPopoverController PopoverControllerForObject (NSObject obj)
		{
			if (obj == null)
				throw new ArgumentNullException ("obj");
			return (global::MonoTouch.UIKit.UIPopoverController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selPopoverControllerForObject_Handle, obj.Handle));
		}
		
		[Export ("action:")]
		[CompilerGenerated]
		public virtual void ovrAction (NSObject sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAction_Handle, sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selAction_Handle, sender.Handle);
			}
		}
		
		[Export ("longPressAction:")]
		[CompilerGenerated]
		public virtual void LongPressAction (PSPDFBarButtonItem sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selLongPressAction_Handle, sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selLongPressAction_Handle, sender.Handle);
			}
		}
		
		[CompilerGenerated]
		public static bool IsPopoverVisible {
			[Export ("isPopoverVisible")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsPopoverVisibleHandle);
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PdfController_var;
		[CompilerGenerated]
		public virtual PSPDFViewController PdfController {
			[Export ("pdfController")]
			get {
				PSPDFViewController ret;
				if (IsDirectBinding) {
					ret = (PSPDFViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPdfControllerHandle));
				} else {
					ret = (PSPDFViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPdfControllerHandle));
				}
				MarkDirty ();
				__mt_PdfController_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ActionSheet_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIActionSheet ActionSheet {
			[Export ("actionSheet")]
			get {
				global::MonoTouch.UIKit.UIActionSheet ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIActionSheet) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selActionSheetHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIActionSheet) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selActionSheetHandle));
				}
				MarkDirty ();
				__mt_ActionSheet_var = ret;
				return ret;
			}
			
			[Export ("setActionSheet:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetActionSheet_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetActionSheet_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_ActionSheet_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_DismissingSheet_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIActionSheet DismissingSheet {
			[Export ("dismissingSheet", ArgumentSemantic.Assign)]
			get {
				global::MonoTouch.UIKit.UIActionSheet ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIActionSheet) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDismissingSheetHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIActionSheet) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDismissingSheetHandle));
				}
				MarkDirty ();
				__mt_DismissingSheet_var = ret;
				return ret;
			}
			
			[Export ("isDismissingSheet", ArgumentSemantic.Assign)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selIsDismissingSheetHandle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selIsDismissingSheetHandle, value.Handle);
				}
				MarkDirty ();
				__mt_DismissingSheet_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_PdfController_var = null;
				__mt_ActionSheet_var = null;
				__mt_DismissingSheet_var = null;
			}
		}
	} /* class PSPDFBarButtonItem */
}
