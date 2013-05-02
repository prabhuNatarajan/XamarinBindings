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
	[Register("PSPDFOpenInBarButtonItem", true)]
	public unsafe partial class PSPDFOpenInBarButtonItem : PSPDFBarButtonItem {
		[CompilerGenerated]
		const string selAllowFileMergingAndTempFiles = "allowFileMergingAndTempFiles";
		static readonly IntPtr selAllowFileMergingAndTempFilesHandle = Selector.GetHandle ("allowFileMergingAndTempFiles");
		[CompilerGenerated]
		const string selSetAllowFileMergingAndTempFiles_ = "setAllowFileMergingAndTempFiles:";
		static readonly IntPtr selSetAllowFileMergingAndTempFiles_Handle = Selector.GetHandle ("setAllowFileMergingAndTempFiles:");
		[CompilerGenerated]
		const string selOpenOptions = "openOptions";
		static readonly IntPtr selOpenOptionsHandle = Selector.GetHandle ("openOptions");
		[CompilerGenerated]
		const string selSetOpenOptions_ = "setOpenOptions:";
		static readonly IntPtr selSetOpenOptions_Handle = Selector.GetHandle ("setOpenOptions:");
		[CompilerGenerated]
		const string selDocumentInteractionController = "documentInteractionController";
		static readonly IntPtr selDocumentInteractionControllerHandle = Selector.GetHandle ("documentInteractionController");
		[CompilerGenerated]
		const string selShowPrintAction = "showPrintAction";
		static readonly IntPtr selShowPrintActionHandle = Selector.GetHandle ("showPrintAction");
		[CompilerGenerated]
		const string selSetShowPrintAction_ = "setShowPrintAction:";
		static readonly IntPtr selSetShowPrintAction_Handle = Selector.GetHandle ("setShowPrintAction:");
		[CompilerGenerated]
		const string selFileURLForDocument_ = "fileURLForDocument:";
		static readonly IntPtr selFileURLForDocument_Handle = Selector.GetHandle ("fileURLForDocument:");
		[CompilerGenerated]
		const string selInteractionControllerWithURL_ = "interactionControllerWithURL:";
		static readonly IntPtr selInteractionControllerWithURL_Handle = Selector.GetHandle ("interactionControllerWithURL:");
		[CompilerGenerated]
		const string selFileURLForDocumentWithOptionsCompletionBlock_ = "fileURLForDocument:withOptions:completionBlock:";
		static readonly IntPtr selFileURLForDocumentWithOptionsCompletionBlock_Handle = Selector.GetHandle ("fileURLForDocument:withOptions:completionBlock:");
		[CompilerGenerated]
		const string selShowOpenInControllerWithOptionsAnimatedSender_ = "showOpenInControllerWithOptions:animated:sender:";
		static readonly IntPtr selShowOpenInControllerWithOptionsAnimatedSender_Handle = Selector.GetHandle ("showOpenInControllerWithOptions:animated:sender:");
		[CompilerGenerated]
		const string selPresentOpenInMenuFromBarButtonItemAnimated_ = "presentOpenInMenuFromBarButtonItem:animated:";
		static readonly IntPtr selPresentOpenInMenuFromBarButtonItemAnimated_Handle = Selector.GetHandle ("presentOpenInMenuFromBarButtonItem:animated:");
		[CompilerGenerated]
		const string selPresentOpenInMenuFromRectInViewAnimated_ = "presentOpenInMenuFromRect:inView:animated:";
		static readonly IntPtr selPresentOpenInMenuFromRectInViewAnimated_Handle = Selector.GetHandle ("presentOpenInMenuFromRect:inView:animated:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFOpenInBarButtonItem");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFOpenInBarButtonItem () : base (NSObjectFlag.Empty)
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
		public PSPDFOpenInBarButtonItem (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFOpenInBarButtonItem (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFOpenInBarButtonItem (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("fileURLForDocument:")]
		[CompilerGenerated]
		public virtual NSUrl FileURLForDocument (PSPDFDocument document)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (IsDirectBinding) {
				return (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selFileURLForDocument_Handle, document.Handle));
			} else {
				return (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selFileURLForDocument_Handle, document.Handle));
			}
		}
		
		[Export ("interactionControllerWithURL:")]
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIDocumentInteractionController InteractionControllerWithURL (NSUrl fileURL)
		{
			if (fileURL == null)
				throw new ArgumentNullException ("fileURL");
			if (IsDirectBinding) {
				return (global::MonoTouch.UIKit.UIDocumentInteractionController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInteractionControllerWithURL_Handle, fileURL.Handle));
			} else {
				return (global::MonoTouch.UIKit.UIDocumentInteractionController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInteractionControllerWithURL_Handle, fileURL.Handle));
			}
		}
		
		[Export ("fileURLForDocument:withOptions:completionBlock:")]
		[CompilerGenerated]
		public unsafe virtual void FileURLForDocument (PSPDFDocument document, PSPDFOpenInOptions options, PSPDFOpenInBarButtonItemFileURLForDocumentHandler handler)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (handler == null)
				throw new ArgumentNullException ("handler");
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlock (static_InnerPSPDFOpenInBarButtonItemFileURLForDocumentHandler, handler);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UInt32_IntPtr (this.Handle, selFileURLForDocumentWithOptionsCompletionBlock_Handle, document.Handle, (UInt32)options, (IntPtr) block_ptr_handler);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UInt32_IntPtr (this.SuperHandle, selFileURLForDocumentWithOptionsCompletionBlock_Handle, document.Handle, (UInt32)options, (IntPtr) block_ptr_handler);
			}
			block_ptr_handler->CleanupBlock ();
			
		}
		
		[Export ("showOpenInControllerWithOptions:animated:sender:")]
		[CompilerGenerated]
		public virtual void ShowOpenInControllerWithOptions (PSPDFOpenInOptions options, bool animated, NSObject sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_UInt32_bool_IntPtr (this.Handle, selShowOpenInControllerWithOptionsAnimatedSender_Handle, (UInt32)options, animated, sender.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32_bool_IntPtr (this.SuperHandle, selShowOpenInControllerWithOptionsAnimatedSender_Handle, (UInt32)options, animated, sender.Handle);
			}
		}
		
		[Export ("presentOpenInMenuFromBarButtonItem:animated:")]
		[CompilerGenerated]
		public virtual bool PresentOpenInMenuFromBarButtonItem (NSObject sender, bool animated)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_bool (this.Handle, selPresentOpenInMenuFromBarButtonItemAnimated_Handle, sender.Handle, animated);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selPresentOpenInMenuFromBarButtonItemAnimated_Handle, sender.Handle, animated);
			}
		}
		
		[Export ("presentOpenInMenuFromRect:inView:animated:")]
		[CompilerGenerated]
		public virtual bool PresentOpenInMenuFromRect (global::System.Drawing.RectangleF senderRect, NSObject sender, bool animated)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_RectangleF_IntPtr_bool (this.Handle, selPresentOpenInMenuFromRectInViewAnimated_Handle, senderRect, sender.Handle, animated);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_RectangleF_IntPtr_bool (this.SuperHandle, selPresentOpenInMenuFromRectInViewAnimated_Handle, senderRect, sender.Handle, animated);
			}
		}
		
		[CompilerGenerated]
		public virtual bool AllowFileMergingAndTempFiles {
			[Export ("allowFileMergingAndTempFiles", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowFileMergingAndTempFilesHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAllowFileMergingAndTempFilesHandle);
				}
			}
			
			[Export ("setAllowFileMergingAndTempFiles:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowFileMergingAndTempFiles_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAllowFileMergingAndTempFiles_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFOpenInOptions OpenOptions {
			[Export ("openOptions", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFOpenInOptions) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selOpenOptionsHandle);
				} else {
					return (PSPDFOpenInOptions) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selOpenOptionsHandle);
				}
			}
			
			[Export ("setOpenOptions:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetOpenOptions_Handle, (UInt32)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetOpenOptions_Handle, (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_DocumentInteractionController_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIDocumentInteractionController DocumentInteractionController {
			[Export ("documentInteractionController")]
			get {
				global::MonoTouch.UIKit.UIDocumentInteractionController ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIDocumentInteractionController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocumentInteractionControllerHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIDocumentInteractionController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocumentInteractionControllerHandle));
				}
				MarkDirty ();
				__mt_DocumentInteractionController_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ShowPrintAction {
			[Export ("showPrintAction", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowPrintActionHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShowPrintActionHandle);
				}
			}
			
			[Export ("setShowPrintAction:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowPrintAction_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShowPrintAction_Handle, value);
				}
			}
		}
		
		internal delegate void InnerPSPDFOpenInBarButtonItemFileURLForDocumentHandler (IntPtr block, IntPtr url);
		[CompilerGenerated]
		static readonly InnerPSPDFOpenInBarButtonItemFileURLForDocumentHandler static_InnerPSPDFOpenInBarButtonItemFileURLForDocumentHandler = TrampolinePSPDFOpenInBarButtonItemFileURLForDocumentHandler;
		[MonoPInvokeCallback (typeof (InnerPSPDFOpenInBarButtonItemFileURLForDocumentHandler))]
		static unsafe void TrampolinePSPDFOpenInBarButtonItemFileURLForDocumentHandler (IntPtr block, IntPtr url) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::KS_PSPDFKitBindings.PSPDFOpenInBarButtonItemFileURLForDocumentHandler) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((MonoTouch.Foundation.NSUrl) Runtime.GetNSObject (url));
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_DocumentInteractionController_var = null;
			}
		}
	} /* class PSPDFOpenInBarButtonItem */
	public delegate void PSPDFOpenInBarButtonItemFileURLForDocumentHandler (NSUrl url);
}
