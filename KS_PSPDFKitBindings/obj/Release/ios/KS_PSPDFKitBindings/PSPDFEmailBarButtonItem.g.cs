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
	[Register("PSPDFEmailBarButtonItem", true)]
	public unsafe partial class PSPDFEmailBarButtonItem : PSPDFBarButtonItem {
		[CompilerGenerated]
		const string selSendOptions = "sendOptions";
		static readonly IntPtr selSendOptionsHandle = Selector.GetHandle ("sendOptions");
		[CompilerGenerated]
		const string selSetSendOptions_ = "setSendOptions:";
		static readonly IntPtr selSetSendOptions_Handle = Selector.GetHandle ("setSendOptions:");
		[CompilerGenerated]
		const string selActionSheet = "actionSheet";
		static readonly IntPtr selActionSheetHandle = Selector.GetHandle ("actionSheet");
		[CompilerGenerated]
		const string selSetActionSheet_ = "setActionSheet:";
		static readonly IntPtr selSetActionSheet_Handle = Selector.GetHandle ("setActionSheet:");
		[CompilerGenerated]
		const string selSetMailComposeViewControllerCustomizationBlock_ = "setMailComposeViewControllerCustomizationBlock:";
		static readonly IntPtr selSetMailComposeViewControllerCustomizationBlock_Handle = Selector.GetHandle ("setMailComposeViewControllerCustomizationBlock:");
		[CompilerGenerated]
		const string selSetActionSheetCustomizationBlock_ = "setActionSheetCustomizationBlock:";
		static readonly IntPtr selSetActionSheetCustomizationBlock_Handle = Selector.GetHandle ("setActionSheetCustomizationBlock:");
		[CompilerGenerated]
		const string selAttachDocumentToMailControllerWithModeCompletionBlock_ = "attachDocumentToMailController:withMode:completionBlock:";
		static readonly IntPtr selAttachDocumentToMailControllerWithModeCompletionBlock_Handle = Selector.GetHandle ("attachDocumentToMailController:withMode:completionBlock:");
		[CompilerGenerated]
		const string selShowEmailControllerWithSendOptionsSenderAnimated_ = "showEmailControllerWithSendOptions:sender:animated:";
		static readonly IntPtr selShowEmailControllerWithSendOptionsSenderAnimated_Handle = Selector.GetHandle ("showEmailControllerWithSendOptions:sender:animated:");
		[CompilerGenerated]
		const string selFileNameForPageSendOptions_ = "fileNameForPage:sendOptions:";
		static readonly IntPtr selFileNameForPageSendOptions_Handle = Selector.GetHandle ("fileNameForPage:sendOptions:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFEmailBarButtonItem");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFEmailBarButtonItem () : base (NSObjectFlag.Empty)
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
		public PSPDFEmailBarButtonItem (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFEmailBarButtonItem (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFEmailBarButtonItem (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setMailComposeViewControllerCustomizationBlock:")]
		[CompilerGenerated]
		public unsafe virtual void SetMailComposeViewControllerCustomizationHandler (PSPDFEmailBarButtonItemMailComposeViewControllerCustomizationHandler handler)
		{
			if (handler == null)
				throw new ArgumentNullException ("handler");
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlock (static_InnerPSPDFEmailBarButtonItemMailComposeViewControllerCustomizationHandler, handler);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMailComposeViewControllerCustomizationBlock_Handle, (IntPtr) block_ptr_handler);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetMailComposeViewControllerCustomizationBlock_Handle, (IntPtr) block_ptr_handler);
			}
			block_ptr_handler->CleanupBlock ();
			
		}
		
		[Export ("setActionSheetCustomizationBlock:")]
		[CompilerGenerated]
		public unsafe virtual void SetActionSheetCustomizationHandler (PSPDFEmailBarButtonItemActionSheetCustomizationHandler handler)
		{
			if (handler == null)
				throw new ArgumentNullException ("handler");
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlock (static_InnerPSPDFEmailBarButtonItemActionSheetCustomizationHandler, handler);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetActionSheetCustomizationBlock_Handle, (IntPtr) block_ptr_handler);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetActionSheetCustomizationBlock_Handle, (IntPtr) block_ptr_handler);
			}
			block_ptr_handler->CleanupBlock ();
			
		}
		
		[Export ("attachDocumentToMailController:withMode:completionBlock:")]
		[CompilerGenerated]
		public unsafe virtual void AttachDocumentToMailController (global::MonoTouch.MessageUI.MFMailComposeViewController mailViewController, PSPDFEmailSendOptions mode, PSPDFEmailBarButtonItemAttachDocumentToMailHandler handler)
		{
			if (mailViewController == null)
				throw new ArgumentNullException ("mailViewController");
			if (handler == null)
				throw new ArgumentNullException ("handler");
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlock (static_InnerPSPDFEmailBarButtonItemAttachDocumentToMailHandler, handler);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UInt32_IntPtr (this.Handle, selAttachDocumentToMailControllerWithModeCompletionBlock_Handle, mailViewController.Handle, (UInt32)mode, (IntPtr) block_ptr_handler);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UInt32_IntPtr (this.SuperHandle, selAttachDocumentToMailControllerWithModeCompletionBlock_Handle, mailViewController.Handle, (UInt32)mode, (IntPtr) block_ptr_handler);
			}
			block_ptr_handler->CleanupBlock ();
			
		}
		
		[Export ("showEmailControllerWithSendOptions:sender:animated:")]
		[CompilerGenerated]
		public virtual void ShowEmailControllerWithSendOptions (PSPDFEmailSendOptions sendOptions, NSObject sender, bool animated)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_UInt32_IntPtr_bool (this.Handle, selShowEmailControllerWithSendOptionsSenderAnimated_Handle, (UInt32)sendOptions, sender.Handle, animated);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32_IntPtr_bool (this.SuperHandle, selShowEmailControllerWithSendOptionsSenderAnimated_Handle, (UInt32)sendOptions, sender.Handle, animated);
			}
		}
		
		[Export ("fileNameForPage:sendOptions:")]
		[CompilerGenerated]
		public virtual string FileNameForPage (global::System.UInt32 pageIndex, PSPDFEmailSendOptions sendOptions)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_UInt32 (this.Handle, selFileNameForPageSendOptions_Handle, pageIndex, (UInt32)sendOptions));
			} else {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32_UInt32 (this.SuperHandle, selFileNameForPageSendOptions_Handle, pageIndex, (UInt32)sendOptions));
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFEmailSendOptions SendOptions {
			[Export ("sendOptions", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFEmailSendOptions) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selSendOptionsHandle);
				} else {
					return (PSPDFEmailSendOptions) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selSendOptionsHandle);
				}
			}
			
			[Export ("setSendOptions:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetSendOptions_Handle, (UInt32)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetSendOptions_Handle, (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_ActionSheet_var;
		[CompilerGenerated]
		public new virtual global::MonoTouch.UIKit.UIActionSheet ActionSheet {
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
		
		internal delegate void InnerPSPDFEmailBarButtonItemMailComposeViewControllerCustomizationHandler (IntPtr block, IntPtr mailComposerController);
		[CompilerGenerated]
		static readonly InnerPSPDFEmailBarButtonItemMailComposeViewControllerCustomizationHandler static_InnerPSPDFEmailBarButtonItemMailComposeViewControllerCustomizationHandler = TrampolinePSPDFEmailBarButtonItemMailComposeViewControllerCustomizationHandler;
		[MonoPInvokeCallback (typeof (InnerPSPDFEmailBarButtonItemMailComposeViewControllerCustomizationHandler))]
		static unsafe void TrampolinePSPDFEmailBarButtonItemMailComposeViewControllerCustomizationHandler (IntPtr block, IntPtr mailComposerController) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::KS_PSPDFKitBindings.PSPDFEmailBarButtonItemMailComposeViewControllerCustomizationHandler) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((MonoTouch.MessageUI.MFMailComposeViewController) Runtime.GetNSObject (mailComposerController));
		}
		
		internal delegate void InnerPSPDFEmailBarButtonItemActionSheetCustomizationHandler (IntPtr block, IntPtr sheet);
		[CompilerGenerated]
		static readonly InnerPSPDFEmailBarButtonItemActionSheetCustomizationHandler static_InnerPSPDFEmailBarButtonItemActionSheetCustomizationHandler = TrampolinePSPDFEmailBarButtonItemActionSheetCustomizationHandler;
		[MonoPInvokeCallback (typeof (InnerPSPDFEmailBarButtonItemActionSheetCustomizationHandler))]
		static unsafe void TrampolinePSPDFEmailBarButtonItemActionSheetCustomizationHandler (IntPtr block, IntPtr sheet) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::KS_PSPDFKitBindings.PSPDFEmailBarButtonItemActionSheetCustomizationHandler) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((KS_PSPDFKitBindings.PSPDFActionSheet) Runtime.GetNSObject (sheet));
		}
		
		internal delegate void InnerPSPDFEmailBarButtonItemAttachDocumentToMailHandler (IntPtr block, bool success);
		[CompilerGenerated]
		static readonly InnerPSPDFEmailBarButtonItemAttachDocumentToMailHandler static_InnerPSPDFEmailBarButtonItemAttachDocumentToMailHandler = TrampolinePSPDFEmailBarButtonItemAttachDocumentToMailHandler;
		[MonoPInvokeCallback (typeof (InnerPSPDFEmailBarButtonItemAttachDocumentToMailHandler))]
		static unsafe void TrampolinePSPDFEmailBarButtonItemAttachDocumentToMailHandler (IntPtr block, bool success) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::KS_PSPDFKitBindings.PSPDFEmailBarButtonItemAttachDocumentToMailHandler) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del (success);
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ActionSheet_var = null;
			}
		}
	} /* class PSPDFEmailBarButtonItem */
	public delegate void PSPDFEmailBarButtonItemMailComposeViewControllerCustomizationHandler (global::MonoTouch.MessageUI.MFMailComposeViewController mailComposerController);
	public delegate void PSPDFEmailBarButtonItemActionSheetCustomizationHandler (PSPDFActionSheet sheet);
	public delegate void PSPDFEmailBarButtonItemAttachDocumentToMailHandler (bool success);
}
