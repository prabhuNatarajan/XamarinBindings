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
	[Register("PSPDFAnnotationToolbar", true)]
	public unsafe partial class PSPDFAnnotationToolbar : global::MonoTouch.UIKit.UIToolbar {
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selPdfController = "pdfController";
		static readonly IntPtr selPdfControllerHandle = Selector.GetHandle ("pdfController");
		[CompilerGenerated]
		const string selSetPdfController_ = "setPdfController:";
		static readonly IntPtr selSetPdfController_Handle = Selector.GetHandle ("setPdfController:");
		[CompilerGenerated]
		const string selToolbarMode = "toolbarMode";
		static readonly IntPtr selToolbarModeHandle = Selector.GetHandle ("toolbarMode");
		[CompilerGenerated]
		const string selSetToolbarMode_ = "setToolbarMode:";
		static readonly IntPtr selSetToolbarMode_Handle = Selector.GetHandle ("setToolbarMode:");
		[CompilerGenerated]
		const string selDrawColor = "drawColor";
		static readonly IntPtr selDrawColorHandle = Selector.GetHandle ("drawColor");
		[CompilerGenerated]
		const string selSetDrawColor_ = "setDrawColor:";
		static readonly IntPtr selSetDrawColor_Handle = Selector.GetHandle ("setDrawColor:");
		[CompilerGenerated]
		const string selLineWidth = "lineWidth";
		static readonly IntPtr selLineWidthHandle = Selector.GetHandle ("lineWidth");
		[CompilerGenerated]
		const string selSetLineWidth_ = "setLineWidth:";
		static readonly IntPtr selSetLineWidth_Handle = Selector.GetHandle ("setLineWidth:");
		[CompilerGenerated]
		const string selHideAfterDrawingDidFinish = "hideAfterDrawingDidFinish";
		static readonly IntPtr selHideAfterDrawingDidFinishHandle = Selector.GetHandle ("hideAfterDrawingDidFinish");
		[CompilerGenerated]
		const string selSetHideAfterDrawingDidFinish_ = "setHideAfterDrawingDidFinish:";
		static readonly IntPtr selSetHideAfterDrawingDidFinish_Handle = Selector.GetHandle ("setHideAfterDrawingDidFinish:");
		[CompilerGenerated]
		const string selSaveAfterToolbarHiding = "saveAfterToolbarHiding";
		static readonly IntPtr selSaveAfterToolbarHidingHandle = Selector.GetHandle ("saveAfterToolbarHiding");
		[CompilerGenerated]
		const string selSetSaveAfterToolbarHiding_ = "setSaveAfterToolbarHiding:";
		static readonly IntPtr selSetSaveAfterToolbarHiding_Handle = Selector.GetHandle ("setSaveAfterToolbarHiding:");
		[CompilerGenerated]
		const string selFadeToolbar = "fadeToolbar";
		static readonly IntPtr selFadeToolbarHandle = Selector.GetHandle ("fadeToolbar");
		[CompilerGenerated]
		const string selSetFadeToolbar_ = "setFadeToolbar:";
		static readonly IntPtr selSetFadeToolbar_Handle = Selector.GetHandle ("setFadeToolbar:");
		[CompilerGenerated]
		const string selSlideToolbar = "SlideToolbar";
		static readonly IntPtr selSlideToolbarHandle = Selector.GetHandle ("SlideToolbar");
		[CompilerGenerated]
		const string selSetSlideToolbar_ = "setSlideToolbar:";
		static readonly IntPtr selSetSlideToolbar_Handle = Selector.GetHandle ("setSlideToolbar:");
		[CompilerGenerated]
		const string selAllowTwoFingerScrollPanDuringLock = "allowTwoFingerScrollPanDuringLock";
		static readonly IntPtr selAllowTwoFingerScrollPanDuringLockHandle = Selector.GetHandle ("allowTwoFingerScrollPanDuringLock");
		[CompilerGenerated]
		const string selSetAllowTwoFingerScrollPanDuringLock_ = "setAllowTwoFingerScrollPanDuringLock:";
		static readonly IntPtr selSetAllowTwoFingerScrollPanDuringLock_Handle = Selector.GetHandle ("setAllowTwoFingerScrollPanDuringLock:");
		[CompilerGenerated]
		const string selUndoItem = "undoItem";
		static readonly IntPtr selUndoItemHandle = Selector.GetHandle ("undoItem");
		[CompilerGenerated]
		const string selRedoItem = "redoItem";
		static readonly IntPtr selRedoItemHandle = Selector.GetHandle ("redoItem");
		[CompilerGenerated]
		const string selOriginalItems = "originalItems";
		static readonly IntPtr selOriginalItemsHandle = Selector.GetHandle ("originalItems");
		[CompilerGenerated]
		const string selEditableAnnotationTypes = "editableAnnotationTypes";
		static readonly IntPtr selEditableAnnotationTypesHandle = Selector.GetHandle ("editableAnnotationTypes");
		[CompilerGenerated]
		const string selSetEditableAnnotationTypes_ = "setEditableAnnotationTypes:";
		static readonly IntPtr selSetEditableAnnotationTypes_Handle = Selector.GetHandle ("setEditableAnnotationTypes:");
		[CompilerGenerated]
		const string selInitWithPDFController_ = "initWithPDFController:";
		static readonly IntPtr selInitWithPDFController_Handle = Selector.GetHandle ("initWithPDFController:");
		[CompilerGenerated]
		const string selShowToolbarInRectAnimated_ = "showToolbarInRect:animated:";
		static readonly IntPtr selShowToolbarInRectAnimated_Handle = Selector.GetHandle ("showToolbarInRect:animated:");
		[CompilerGenerated]
		const string selDummyhideToolbarAnimatedCompletion_ = "DummyhideToolbarAnimated:completion:";
		static readonly IntPtr selDummyhideToolbarAnimatedCompletion_Handle = Selector.GetHandle ("DummyhideToolbarAnimated:completion:");
		[CompilerGenerated]
		const string selFlashToolbar = "flashToolbar";
		static readonly IntPtr selFlashToolbarHandle = Selector.GetHandle ("flashToolbar");
		[CompilerGenerated]
		const string selUpdateToolbarItems = "updateToolbarItems";
		static readonly IntPtr selUpdateToolbarItemsHandle = Selector.GetHandle ("updateToolbarItems");
		[CompilerGenerated]
		const string selSetupWithMode_ = "setupWithMode:";
		static readonly IntPtr selSetupWithMode_Handle = Selector.GetHandle ("setupWithMode:");
		[CompilerGenerated]
		const string selNoteButtonPressed_ = "noteButtonPressed:";
		static readonly IntPtr selNoteButtonPressed_Handle = Selector.GetHandle ("noteButtonPressed:");
		[CompilerGenerated]
		const string selHighlightButtonPressed_ = "highlightButtonPressed:";
		static readonly IntPtr selHighlightButtonPressed_Handle = Selector.GetHandle ("highlightButtonPressed:");
		[CompilerGenerated]
		const string selStrikeOutButtonPressed_ = "strikeOutButtonPressed:";
		static readonly IntPtr selStrikeOutButtonPressed_Handle = Selector.GetHandle ("strikeOutButtonPressed:");
		[CompilerGenerated]
		const string selUnderlineButtonPressed_ = "underlineButtonPressed:";
		static readonly IntPtr selUnderlineButtonPressed_Handle = Selector.GetHandle ("underlineButtonPressed:");
		[CompilerGenerated]
		const string selDrawButtonPressed_ = "drawButtonPressed:";
		static readonly IntPtr selDrawButtonPressed_Handle = Selector.GetHandle ("drawButtonPressed:");
		[CompilerGenerated]
		const string selEllipseButtonPressed_ = "ellipseButtonPressed:";
		static readonly IntPtr selEllipseButtonPressed_Handle = Selector.GetHandle ("ellipseButtonPressed:");
		[CompilerGenerated]
		const string selLineButtonPressed_ = "lineButtonPressed:";
		static readonly IntPtr selLineButtonPressed_Handle = Selector.GetHandle ("lineButtonPressed:");
		[CompilerGenerated]
		const string selRectangleButtonPressed_ = "rectangleButtonPressed:";
		static readonly IntPtr selRectangleButtonPressed_Handle = Selector.GetHandle ("rectangleButtonPressed:");
		[CompilerGenerated]
		const string selFreeTextButtonPressed_ = "freeTextButtonPressed:";
		static readonly IntPtr selFreeTextButtonPressed_Handle = Selector.GetHandle ("freeTextButtonPressed:");
		[CompilerGenerated]
		const string selSignatureButtonPressed_ = "signatureButtonPressed:";
		static readonly IntPtr selSignatureButtonPressed_Handle = Selector.GetHandle ("signatureButtonPressed:");
		[CompilerGenerated]
		const string selStampButtonPressed_ = "stampButtonPressed:";
		static readonly IntPtr selStampButtonPressed_Handle = Selector.GetHandle ("stampButtonPressed:");
		[CompilerGenerated]
		const string selImageButtonPressed_ = "imageButtonPressed:";
		static readonly IntPtr selImageButtonPressed_Handle = Selector.GetHandle ("imageButtonPressed:");
		[CompilerGenerated]
		const string selDoneButtonPressed_ = "doneButtonPressed:";
		static readonly IntPtr selDoneButtonPressed_Handle = Selector.GetHandle ("doneButtonPressed:");
		[CompilerGenerated]
		const string selCancelDrawingAnimated_ = "cancelDrawingAnimated:";
		static readonly IntPtr selCancelDrawingAnimated_Handle = Selector.GetHandle ("cancelDrawingAnimated:");
		[CompilerGenerated]
		const string selDoneDrawingAnimated_ = "doneDrawingAnimated:";
		static readonly IntPtr selDoneDrawingAnimated_Handle = Selector.GetHandle ("doneDrawingAnimated:");
		[CompilerGenerated]
		const string selSelectStrokeColor_ = "selectStrokeColor:";
		static readonly IntPtr selSelectStrokeColor_Handle = Selector.GetHandle ("selectStrokeColor:");
		[CompilerGenerated]
		const string selUndoDrawing_ = "undoDrawing:";
		static readonly IntPtr selUndoDrawing_Handle = Selector.GetHandle ("undoDrawing:");
		[CompilerGenerated]
		const string selRedoDrawing_ = "redoDrawing:";
		static readonly IntPtr selRedoDrawing_Handle = Selector.GetHandle ("redoDrawing:");
		[CompilerGenerated]
		const string selUpdateDrawingToolbar = "updateDrawingToolbar";
		static readonly IntPtr selUpdateDrawingToolbarHandle = Selector.GetHandle ("updateDrawingToolbar");
		[CompilerGenerated]
		const string selSetLastUsedColorForAnnotationType_ = "setLastUsedColor:forAnnotationType:";
		static readonly IntPtr selSetLastUsedColorForAnnotationType_Handle = Selector.GetHandle ("setLastUsedColor:forAnnotationType:");
		[CompilerGenerated]
		const string selLastUsedColorForAnnotationTypeString_ = "lastUsedColorForAnnotationTypeString:";
		static readonly IntPtr selLastUsedColorForAnnotationTypeString_Handle = Selector.GetHandle ("lastUsedColorForAnnotationTypeString:");
		[CompilerGenerated]
		const string selFinishDrawingAnimatedAndSaveAnnotation_ = "finishDrawingAnimated:andSaveAnnotation:";
		static readonly IntPtr selFinishDrawingAnimatedAndSaveAnnotation_Handle = Selector.GetHandle ("finishDrawingAnimated:andSaveAnnotation:");
		[CompilerGenerated]
		const string selLockPDFControllerAnimated_ = "lockPDFControllerAnimated:";
		static readonly IntPtr selLockPDFControllerAnimated_Handle = Selector.GetHandle ("lockPDFControllerAnimated:");
		[CompilerGenerated]
		const string selUnlockPDFControllerAnimatedShowControlsEnsureToStayOnTop_ = "unlockPDFControllerAnimated:showControls:ensureToStayOnTop:";
		static readonly IntPtr selUnlockPDFControllerAnimatedShowControlsEnsureToStayOnTop_Handle = Selector.GetHandle ("unlockPDFControllerAnimated:showControls:ensureToStayOnTop:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFAnnotationToolbar");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFAnnotationToolbar () : base (NSObjectFlag.Empty)
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
		public PSPDFAnnotationToolbar (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFAnnotationToolbar (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFAnnotationToolbar (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithPDFController:")]
		[CompilerGenerated]
		public PSPDFAnnotationToolbar (PSPDFViewController pdfController)
			: base (NSObjectFlag.Empty)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithPDFController_Handle, pdfController.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithPDFController_Handle, pdfController.Handle);
			}
		}
		
		[Export ("showToolbarInRect:animated:")]
		[CompilerGenerated]
		public virtual void ShowToolbarInRect (global::System.Drawing.RectangleF rect, bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_RectangleF_bool (this.Handle, selShowToolbarInRectAnimated_Handle, rect, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_RectangleF_bool (this.SuperHandle, selShowToolbarInRectAnimated_Handle, rect, animated);
			}
		}
		
		[Export ("DummyhideToolbarAnimated:completion:")]
		[CompilerGenerated]
		internal unsafe virtual void DummyHideToolbar (bool animated, PSPDFAnnotationToolbarCompletionDel completionBlock)
		{
			if (completionBlock == null)
				throw new ArgumentNullException ("completionBlock");
			BlockLiteral *block_ptr_completionBlock;
			BlockLiteral block_completionBlock;
			block_completionBlock = new BlockLiteral ();
			block_ptr_completionBlock = &block_completionBlock;
			block_completionBlock.SetupBlock (static_InnerPSPDFAnnotationToolbarCompletionDel, completionBlock);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, selDummyhideToolbarAnimatedCompletion_Handle, animated, (IntPtr) block_ptr_completionBlock);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, selDummyhideToolbarAnimatedCompletion_Handle, animated, (IntPtr) block_ptr_completionBlock);
			}
			block_ptr_completionBlock->CleanupBlock ();
			
		}
		
		[Export ("flashToolbar")]
		[CompilerGenerated]
		public virtual void FlashToolbar ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selFlashToolbarHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selFlashToolbarHandle);
			}
		}
		
		[Export ("updateToolbarItems")]
		[CompilerGenerated]
		public virtual void UpdateToolbarItems ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateToolbarItemsHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selUpdateToolbarItemsHandle);
			}
		}
		
		[Export ("setupWithMode:")]
		[CompilerGenerated]
		public virtual void SetupWithMode (PSPDFAnnotationToolbarMode mode)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetupWithMode_Handle, (UInt32)mode);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetupWithMode_Handle, (UInt32)mode);
			}
		}
		
		[Export ("noteButtonPressed:")]
		[CompilerGenerated]
		public virtual void NoteButtonPressed (NSObject sender)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selNoteButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selNoteButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("highlightButtonPressed:")]
		[CompilerGenerated]
		public virtual void HighlightButtonPressed (NSObject sender)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selHighlightButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selHighlightButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("strikeOutButtonPressed:")]
		[CompilerGenerated]
		public virtual void StrikeOutButtonPressed (NSObject sender)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selStrikeOutButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selStrikeOutButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("underlineButtonPressed:")]
		[CompilerGenerated]
		public virtual void UnderlineButtonPressed (NSObject sender)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selUnderlineButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selUnderlineButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("drawButtonPressed:")]
		[CompilerGenerated]
		public virtual void DrawButtonPressed (NSObject sender)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selDrawButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selDrawButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("ellipseButtonPressed:")]
		[CompilerGenerated]
		public virtual void EllipseButtonPressed (NSObject sender)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selEllipseButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selEllipseButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("lineButtonPressed:")]
		[CompilerGenerated]
		public virtual void LineButtonPressed (NSObject sender)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selLineButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selLineButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("rectangleButtonPressed:")]
		[CompilerGenerated]
		public virtual void RectangleButtonPressed (NSObject sender)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRectangleButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selRectangleButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("freeTextButtonPressed:")]
		[CompilerGenerated]
		public virtual void FreeTextButtonPressed (NSObject sender)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selFreeTextButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selFreeTextButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("signatureButtonPressed:")]
		[CompilerGenerated]
		public virtual void SignatureButtonPressed (NSObject sender)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSignatureButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSignatureButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("stampButtonPressed:")]
		[CompilerGenerated]
		public virtual void StampButtonPressed (NSObject sender)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selStampButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selStampButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("imageButtonPressed:")]
		[CompilerGenerated]
		public virtual void ImageButtonPressed (NSObject sender)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selImageButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selImageButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("doneButtonPressed:")]
		[CompilerGenerated]
		public virtual void DoneButtonPressed (NSObject sender)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selDoneButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selDoneButtonPressed_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("cancelDrawingAnimated:")]
		[CompilerGenerated]
		public virtual void CancelDrawingAnimated (bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selCancelDrawingAnimated_Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selCancelDrawingAnimated_Handle, animated);
			}
		}
		
		[Export ("doneDrawingAnimated:")]
		[CompilerGenerated]
		public virtual void DoneDrawingAnimated (bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selDoneDrawingAnimated_Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selDoneDrawingAnimated_Handle, animated);
			}
		}
		
		[Export ("selectStrokeColor:")]
		[CompilerGenerated]
		public virtual void SelectStrokeColor (NSObject sender)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSelectStrokeColor_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSelectStrokeColor_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("undoDrawing:")]
		[CompilerGenerated]
		public virtual void UndoDrawing (NSObject sender)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selUndoDrawing_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selUndoDrawing_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("redoDrawing:")]
		[CompilerGenerated]
		public virtual void RedoDrawing (NSObject sender)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRedoDrawing_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selRedoDrawing_Handle, sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("updateDrawingToolbar")]
		[CompilerGenerated]
		public virtual void UpdateDrawingToolbar ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateDrawingToolbarHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selUpdateDrawingToolbarHandle);
			}
		}
		
		[Export ("setLastUsedColor:forAnnotationType:")]
		[CompilerGenerated]
		public virtual void SetLastUsedColor (global::MonoTouch.UIKit.UIColor lastUsedDrawColor, string annotationType)
		{
			if (lastUsedDrawColor == null)
				throw new ArgumentNullException ("lastUsedDrawColor");
			if (annotationType == null)
				throw new ArgumentNullException ("annotationType");
			var nsannotationType = NSString.CreateNative (annotationType);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSetLastUsedColorForAnnotationType_Handle, lastUsedDrawColor.Handle, nsannotationType);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSetLastUsedColorForAnnotationType_Handle, lastUsedDrawColor.Handle, nsannotationType);
			}
			NSString.ReleaseNative (nsannotationType);
			
		}
		
		[Export ("lastUsedColorForAnnotationTypeString:")]
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor LastUsedColorForAnnotationType (string annotationType)
		{
			if (annotationType == null)
				throw new ArgumentNullException ("annotationType");
			var nsannotationType = NSString.CreateNative (annotationType);
			
			global::MonoTouch.UIKit.UIColor ret;
			if (IsDirectBinding) {
				ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selLastUsedColorForAnnotationTypeString_Handle, nsannotationType));
			} else {
				ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selLastUsedColorForAnnotationTypeString_Handle, nsannotationType));
			}
			NSString.ReleaseNative (nsannotationType);
			
			return ret;
		}
		
		[Export ("finishDrawingAnimated:andSaveAnnotation:")]
		[CompilerGenerated]
		public virtual void FinishDrawingAnimated (bool animated, bool saveAnnotation)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool_bool (this.Handle, selFinishDrawingAnimatedAndSaveAnnotation_Handle, animated, saveAnnotation);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_bool (this.SuperHandle, selFinishDrawingAnimatedAndSaveAnnotation_Handle, animated, saveAnnotation);
			}
		}
		
		[Export ("lockPDFControllerAnimated:")]
		[CompilerGenerated]
		public virtual void LockPDFController (bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selLockPDFControllerAnimated_Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selLockPDFControllerAnimated_Handle, animated);
			}
		}
		
		[Export ("unlockPDFControllerAnimated:showControls:ensureToStayOnTop:")]
		[CompilerGenerated]
		public virtual void UnlockPDFController (bool animated, bool showControls, bool stayOnTop)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_bool_bool_bool (this.Handle, selUnlockPDFControllerAnimatedShowControlsEnsureToStayOnTop_Handle, animated, showControls, stayOnTop);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_bool_bool_bool (this.SuperHandle, selUnlockPDFControllerAnimatedShowControlsEnsureToStayOnTop_Handle, animated, showControls, stayOnTop);
			}
		}
		
		[CompilerGenerated]
		public PSPDFAnnotationToolbarDelegate Delegate {
			get {
				return WeakDelegate as PSPDFAnnotationToolbarDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
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
			
			[Export ("setPdfController:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPdfController_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPdfController_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_PdfController_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFAnnotationToolbarMode ToolbarMode {
			[Export ("toolbarMode", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFAnnotationToolbarMode) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selToolbarModeHandle);
				} else {
					return (PSPDFAnnotationToolbarMode) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selToolbarModeHandle);
				}
			}
			
			[Export ("setToolbarMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetToolbarMode_Handle, (UInt32)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetToolbarMode_Handle, (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_DrawColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor DrawColor {
			[Export ("drawColor")]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDrawColorHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDrawColorHandle));
				}
				MarkDirty ();
				__mt_DrawColor_var = ret;
				return ret;
			}
			
			[Export ("setDrawColor:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDrawColor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDrawColor_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_DrawColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual float LineWidth {
			[Export ("lineWidth", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selLineWidthHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selLineWidthHandle);
				}
			}
			
			[Export ("setLineWidth:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetLineWidth_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetLineWidth_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool HideAfterDrawingDidFinish {
			[Export ("hideAfterDrawingDidFinish", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHideAfterDrawingDidFinishHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selHideAfterDrawingDidFinishHandle);
				}
			}
			
			[Export ("setHideAfterDrawingDidFinish:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHideAfterDrawingDidFinish_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetHideAfterDrawingDidFinish_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool SaveAfterToolbarHiding {
			[Export ("saveAfterToolbarHiding", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSaveAfterToolbarHidingHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selSaveAfterToolbarHidingHandle);
				}
			}
			
			[Export ("setSaveAfterToolbarHiding:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSaveAfterToolbarHiding_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetSaveAfterToolbarHiding_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool FadeToolbar {
			[Export ("fadeToolbar", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selFadeToolbarHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selFadeToolbarHandle);
				}
			}
			
			[Export ("setFadeToolbar:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetFadeToolbar_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetFadeToolbar_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool SlideToolbar {
			[Export ("SlideToolbar", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSlideToolbarHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selSlideToolbarHandle);
				}
			}
			
			[Export ("setSlideToolbar:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSlideToolbar_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetSlideToolbar_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AllowTwoFingerScrollPanDuringLock {
			[Export ("allowTwoFingerScrollPanDuringLock", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowTwoFingerScrollPanDuringLockHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAllowTwoFingerScrollPanDuringLockHandle);
				}
			}
			
			[Export ("setAllowTwoFingerScrollPanDuringLock:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowTwoFingerScrollPanDuringLock_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAllowTwoFingerScrollPanDuringLock_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_UndoItem_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIBarButtonItem UndoItem {
			[Export ("undoItem")]
			get {
				global::MonoTouch.UIKit.UIBarButtonItem ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUndoItemHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUndoItemHandle));
				}
				MarkDirty ();
				__mt_UndoItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_RedoItem_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIBarButtonItem RedoItem {
			[Export ("redoItem")]
			get {
				global::MonoTouch.UIKit.UIBarButtonItem ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRedoItemHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRedoItemHandle));
				}
				MarkDirty ();
				__mt_RedoItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_OriginalItems_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIBarButtonItem[] OriginalItems {
			[Export ("originalItems", ArgumentSemantic.Copy)]
			get {
				global::MonoTouch.UIKit.UIBarButtonItem[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.UIKit.UIBarButtonItem>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOriginalItemsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.UIKit.UIBarButtonItem>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOriginalItemsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_OriginalItems_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.IntPtr EditableAnnotationTypes {
			[Export ("editableAnnotationTypes", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selEditableAnnotationTypesHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selEditableAnnotationTypesHandle);
				}
			}
			
			[Export ("setEditableAnnotationTypes:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetEditableAnnotationTypes_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetEditableAnnotationTypes_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		static readonly IntPtr __Internal_libraryHandle = Dlfcn.dlopen (null, 0);
		[CompilerGenerated]
		static NSString _PSPDFLastUsedDrawingWidth;
		public static NSString PSPDFLastUsedDrawingWidth {
			get {
				if (_PSPDFLastUsedDrawingWidth == null)
					_PSPDFLastUsedDrawingWidth = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFLastUsedDrawingWidth");
				return _PSPDFLastUsedDrawingWidth;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFLastUsedColorForAnnotationType;
		public static NSString PSPDFLastUsedColorForAnnotationType {
			get {
				if (_PSPDFLastUsedColorForAnnotationType == null)
					_PSPDFLastUsedColorForAnnotationType = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFLastUsedColorForAnnotationType");
				return _PSPDFLastUsedColorForAnnotationType;
			}
		}
		//
		// Events and properties from the delegate
		//
		
		_PSPDFAnnotationToolbarDelegate EnsurePSPDFAnnotationToolbarDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _PSPDFAnnotationToolbarDelegate))){
				del = new _PSPDFAnnotationToolbarDelegate ();
				WeakDelegate = del;
			}
			return (_PSPDFAnnotationToolbarDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _PSPDFAnnotationToolbarDelegate : KS_PSPDFKitBindings.PSPDFAnnotationToolbarDelegate { 
			public _PSPDFAnnotationToolbarDelegate () {}
			
			internal EventHandler didHide;
			[Preserve (Conditional = true)]
			public override void DidHide (KS_PSPDFKitBindings.PSPDFAnnotationToolbar annotationToolbar)
			{
				EventHandler handler = didHide;
				if (handler != null){
					handler (annotationToolbar, EventArgs.Empty);
				}
			}
			
			internal EventHandler<PSPDFAnnotationToolbarDidChangeModeEventArgs> didChangeMode;
			[Preserve (Conditional = true)]
			public override void DidChangeMode (KS_PSPDFKitBindings.PSPDFAnnotationToolbar annotationToolbar, KS_PSPDFKitBindings.PSPDFAnnotationToolbarMode newMode)
			{
				EventHandler<PSPDFAnnotationToolbarDidChangeModeEventArgs> handler = didChangeMode;
				if (handler != null){
					var args = new PSPDFAnnotationToolbarDidChangeModeEventArgs (newMode);
					handler (annotationToolbar, args);
				}
			}
			
		}
		#pragma warning restore 672
		
		public event EventHandler DidHide {
			add { EnsurePSPDFAnnotationToolbarDelegate ().didHide += value; }
			remove { EnsurePSPDFAnnotationToolbarDelegate ().didHide -= value; }
		}
		
		public event EventHandler<PSPDFAnnotationToolbarDidChangeModeEventArgs> DidChangeMode {
			add { EnsurePSPDFAnnotationToolbarDelegate ().didChangeMode += value; }
			remove { EnsurePSPDFAnnotationToolbarDelegate ().didChangeMode -= value; }
		}
		
		internal delegate void InnerPSPDFAnnotationToolbarCompletionDel (IntPtr block);
		[CompilerGenerated]
		static readonly InnerPSPDFAnnotationToolbarCompletionDel static_InnerPSPDFAnnotationToolbarCompletionDel = TrampolinePSPDFAnnotationToolbarCompletionDel;
		[MonoPInvokeCallback (typeof (InnerPSPDFAnnotationToolbarCompletionDel))]
		static unsafe void TrampolinePSPDFAnnotationToolbarCompletionDel (IntPtr block) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::KS_PSPDFKitBindings.PSPDFAnnotationToolbarCompletionDel) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ();
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
				__mt_PdfController_var = null;
				__mt_DrawColor_var = null;
				__mt_UndoItem_var = null;
				__mt_RedoItem_var = null;
				__mt_OriginalItems_var = null;
			}
		}
	} /* class PSPDFAnnotationToolbar */
	public delegate void PSPDFAnnotationToolbarCompletionDel ();
	
	
	//
	// EventArgs classes
	//
	public partial class PSPDFAnnotationToolbarDidChangeModeEventArgs : EventArgs {
		public PSPDFAnnotationToolbarDidChangeModeEventArgs (KS_PSPDFKitBindings.PSPDFAnnotationToolbarMode newMode)
		{
			this.NewMode = newMode;
		}
		public KS_PSPDFKitBindings.PSPDFAnnotationToolbarMode NewMode { get; set; }
	}
	
}
