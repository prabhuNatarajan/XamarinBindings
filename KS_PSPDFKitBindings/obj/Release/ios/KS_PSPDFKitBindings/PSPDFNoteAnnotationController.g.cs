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
	[Register("PSPDFNoteAnnotationController", true)]
	public unsafe partial class PSPDFNoteAnnotationController : PSPDFBaseViewController {
		[CompilerGenerated]
		const string selAnnotation = "annotation";
		static readonly IntPtr selAnnotationHandle = Selector.GetHandle ("annotation");
		[CompilerGenerated]
		const string selSetAnnotation_ = "setAnnotation:";
		static readonly IntPtr selSetAnnotation_Handle = Selector.GetHandle ("setAnnotation:");
		[CompilerGenerated]
		const string selAllowEditing = "allowEditing";
		static readonly IntPtr selAllowEditingHandle = Selector.GetHandle ("allowEditing");
		[CompilerGenerated]
		const string selShowColorAndIconOptions = "showColorAndIconOptions";
		static readonly IntPtr selShowColorAndIconOptionsHandle = Selector.GetHandle ("showColorAndIconOptions");
		[CompilerGenerated]
		const string selSetShowColorAndIconOptions_ = "setShowColorAndIconOptions:";
		static readonly IntPtr selSetShowColorAndIconOptions_Handle = Selector.GetHandle ("setShowColorAndIconOptions:");
		[CompilerGenerated]
		const string selTextView = "textView";
		static readonly IntPtr selTextViewHandle = Selector.GetHandle ("textView");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selDeleteAnnotationActionTitle = "deleteAnnotationActionTitle";
		static readonly IntPtr selDeleteAnnotationActionTitleHandle = Selector.GetHandle ("deleteAnnotationActionTitle");
		[CompilerGenerated]
		const string selBackgroundView = "backgroundView";
		static readonly IntPtr selBackgroundViewHandle = Selector.GetHandle ("backgroundView");
		[CompilerGenerated]
		const string selSetBackgroundView_ = "setBackgroundView:";
		static readonly IntPtr selSetBackgroundView_Handle = Selector.GetHandle ("setBackgroundView:");
		[CompilerGenerated]
		const string selOptionsView = "optionsView";
		static readonly IntPtr selOptionsViewHandle = Selector.GetHandle ("optionsView");
		[CompilerGenerated]
		const string selSetOptionsView_ = "setOptionsView:";
		static readonly IntPtr selSetOptionsView_Handle = Selector.GetHandle ("setOptionsView:");
		[CompilerGenerated]
		const string selTintColor = "tintColor";
		static readonly IntPtr selTintColorHandle = Selector.GetHandle ("tintColor");
		[CompilerGenerated]
		const string selSetTintColor_ = "setTintColor:";
		static readonly IntPtr selSetTintColor_Handle = Selector.GetHandle ("setTintColor:");
		[CompilerGenerated]
		const string selBarStyle = "barStyle";
		static readonly IntPtr selBarStyleHandle = Selector.GetHandle ("barStyle");
		[CompilerGenerated]
		const string selSetBarStyle_ = "setBarStyle:";
		static readonly IntPtr selSetBarStyle_Handle = Selector.GetHandle ("setBarStyle:");
		[CompilerGenerated]
		const string selIsBarTranslucent = "isBarTranslucent";
		static readonly IntPtr selIsBarTranslucentHandle = Selector.GetHandle ("isBarTranslucent");
		[CompilerGenerated]
		const string selSetIsBarTranslucent_ = "setIsBarTranslucent:";
		static readonly IntPtr selSetIsBarTranslucent_Handle = Selector.GetHandle ("setIsBarTranslucent:");
		[CompilerGenerated]
		const string selIsInPopover = "isInPopover";
		static readonly IntPtr selIsInPopoverHandle = Selector.GetHandle ("isInPopover");
		[CompilerGenerated]
		const string selSetIsInPopover_ = "setIsInPopover:";
		static readonly IntPtr selSetIsInPopover_Handle = Selector.GetHandle ("setIsInPopover:");
		[CompilerGenerated]
		const string selShouldTintToolbarButtons = "shouldTintToolbarButtons";
		static readonly IntPtr selShouldTintToolbarButtonsHandle = Selector.GetHandle ("shouldTintToolbarButtons");
		[CompilerGenerated]
		const string selSetShouldTintToolbarButtons_ = "setShouldTintToolbarButtons:";
		static readonly IntPtr selSetShouldTintToolbarButtons_Handle = Selector.GetHandle ("setShouldTintToolbarButtons:");
		[CompilerGenerated]
		const string selShouldTintAlertView = "shouldTintAlertView";
		static readonly IntPtr selShouldTintAlertViewHandle = Selector.GetHandle ("shouldTintAlertView");
		[CompilerGenerated]
		const string selSetShouldTintAlertView_ = "setShouldTintAlertView:";
		static readonly IntPtr selSetShouldTintAlertView_Handle = Selector.GetHandle ("setShouldTintAlertView:");
		[CompilerGenerated]
		const string selInitWithAnnotationEditable_ = "initWithAnnotation:editable:";
		static readonly IntPtr selInitWithAnnotationEditable_Handle = Selector.GetHandle ("initWithAnnotation:editable:");
		[CompilerGenerated]
		const string selInitWithAnnotation_ = "initWithAnnotation:";
		static readonly IntPtr selInitWithAnnotation_Handle = Selector.GetHandle ("initWithAnnotation:");
		[CompilerGenerated]
		const string selSetTextViewCustomizationBlock_ = "setTextViewCustomizationBlock:";
		static readonly IntPtr selSetTextViewCustomizationBlock_Handle = Selector.GetHandle ("setTextViewCustomizationBlock:");
		[CompilerGenerated]
		const string selDeleteAnnotation_ = "deleteAnnotation:";
		static readonly IntPtr selDeleteAnnotation_Handle = Selector.GetHandle ("deleteAnnotation:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFNoteAnnotationController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFNoteAnnotationController () : base (NSObjectFlag.Empty)
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
		public PSPDFNoteAnnotationController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFNoteAnnotationController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFNoteAnnotationController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithAnnotation:editable:")]
		[CompilerGenerated]
		public PSPDFNoteAnnotationController (PSPDFAnnotation annotation, bool allowEditing)
			: base (NSObjectFlag.Empty)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_bool (this.Handle, selInitWithAnnotationEditable_Handle, annotation.Handle, allowEditing);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selInitWithAnnotationEditable_Handle, annotation.Handle, allowEditing);
			}
		}
		
		[Export ("initWithAnnotation:")]
		[CompilerGenerated]
		public PSPDFNoteAnnotationController (PSPDFAnnotation annotation)
			: base (NSObjectFlag.Empty)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithAnnotation_Handle, annotation.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithAnnotation_Handle, annotation.Handle);
			}
		}
		
		[Export ("setTextViewCustomizationBlock:")]
		[CompilerGenerated]
		public unsafe static void SetTextViewCustomizationHandler (PSPDFNoteAnnotationControllerTextViewCustomizationHandler handler)
		{
			if (handler == null)
				throw new ArgumentNullException ("handler");
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlock (static_InnerPSPDFNoteAnnotationControllerTextViewCustomizationHandler, handler);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selSetTextViewCustomizationBlock_Handle, (IntPtr) block_ptr_handler);
			block_ptr_handler->CleanupBlock ();
			
		}
		
		[Export ("deleteAnnotation:")]
		[CompilerGenerated]
		public virtual void DeleteAnnotation (global::MonoTouch.UIKit.UIBarButtonItem barButtonItem)
		{
			if (barButtonItem == null)
				throw new ArgumentNullException ("barButtonItem");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selDeleteAnnotation_Handle, barButtonItem.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selDeleteAnnotation_Handle, barButtonItem.Handle);
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
		public virtual bool AllowEditing {
			[Export ("allowEditing", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowEditingHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAllowEditingHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ShowColorAndIconOptions {
			[Export ("showColorAndIconOptions", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowColorAndIconOptionsHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShowColorAndIconOptionsHandle);
				}
			}
			
			[Export ("setShowColorAndIconOptions:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowColorAndIconOptions_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShowColorAndIconOptions_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_TextView_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UITextView TextView {
			[Export ("textView")]
			get {
				global::MonoTouch.UIKit.UITextView ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UITextView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTextViewHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UITextView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTextViewHandle));
				}
				MarkDirty ();
				__mt_TextView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public PSPDFNoteAnnotationControllerDelegate Delegate {
			get {
				return WeakDelegate as PSPDFNoteAnnotationControllerDelegate;
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
		public virtual string DeleteAnnotationActionTitle {
			[Export ("deleteAnnotationActionTitle")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDeleteAnnotationActionTitleHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDeleteAnnotationActionTitleHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_BackgroundView_var;
		[CompilerGenerated]
		public virtual PSPDFGradientView BackgroundView {
			[Export ("backgroundView")]
			get {
				PSPDFGradientView ret;
				if (IsDirectBinding) {
					ret = (PSPDFGradientView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBackgroundViewHandle));
				} else {
					ret = (PSPDFGradientView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBackgroundViewHandle));
				}
				MarkDirty ();
				__mt_BackgroundView_var = ret;
				return ret;
			}
			
			[Export ("setBackgroundView:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBackgroundView_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBackgroundView_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_BackgroundView_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_OptionsView_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIView OptionsView {
			[Export ("optionsView")]
			get {
				global::MonoTouch.UIKit.UIView ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOptionsViewHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOptionsViewHandle));
				}
				MarkDirty ();
				__mt_OptionsView_var = ret;
				return ret;
			}
			
			[Export ("setOptionsView:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetOptionsView_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetOptionsView_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_OptionsView_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_TintColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor TintColor {
			[Export ("tintColor")]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTintColorHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTintColorHandle));
				}
				MarkDirty ();
				__mt_TintColor_var = ret;
				return ret;
			}
			
			[Export ("setTintColor:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTintColor_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTintColor_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_TintColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIBarStyle BarStyle {
			[Export ("barStyle", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (global::MonoTouch.UIKit.UIBarStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selBarStyleHandle);
				} else {
					return (global::MonoTouch.UIKit.UIBarStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selBarStyleHandle);
				}
			}
			
			[Export ("setBarStyle:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetBarStyle_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetBarStyle_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsBarTranslucent {
			[Export ("isBarTranslucent", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsBarTranslucentHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsBarTranslucentHandle);
				}
			}
			
			[Export ("setIsBarTranslucent:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsBarTranslucent_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIsBarTranslucent_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsInPopover {
			[Export ("isInPopover", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsInPopoverHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsInPopoverHandle);
				}
			}
			
			[Export ("setIsInPopover:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsInPopover_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIsInPopover_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldTintToolbarButtons {
			[Export ("shouldTintToolbarButtons", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldTintToolbarButtonsHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShouldTintToolbarButtonsHandle);
				}
			}
			
			[Export ("setShouldTintToolbarButtons:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldTintToolbarButtons_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShouldTintToolbarButtons_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldTintAlertView {
			[Export ("shouldTintAlertView", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldTintAlertViewHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShouldTintAlertViewHandle);
				}
			}
			
			[Export ("setShouldTintAlertView:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldTintAlertView_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShouldTintAlertView_Handle, value);
				}
			}
		}
		
		//
		// Events and properties from the delegate
		//
		
		_PSPDFNoteAnnotationControllerDelegate EnsurePSPDFNoteAnnotationControllerDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _PSPDFNoteAnnotationControllerDelegate))){
				del = new _PSPDFNoteAnnotationControllerDelegate ();
				WeakDelegate = del;
			}
			return (_PSPDFNoteAnnotationControllerDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _PSPDFNoteAnnotationControllerDelegate : KS_PSPDFKitBindings.PSPDFNoteAnnotationControllerDelegate { 
			public _PSPDFNoteAnnotationControllerDelegate () {}
			
			internal EventHandler<PSPDFNoteAnnotationControllerAnnotEventArgs> didDeleteAnnotation;
			[Preserve (Conditional = true)]
			public override void DidDeleteAnnotation (KS_PSPDFKitBindings.PSPDFNoteAnnotationController noteAnnotationController, KS_PSPDFKitBindings.PSPDFAnnotation annotation)
			{
				EventHandler<PSPDFNoteAnnotationControllerAnnotEventArgs> handler = didDeleteAnnotation;
				if (handler != null){
					var args = new PSPDFNoteAnnotationControllerAnnotEventArgs (annotation);
					handler (noteAnnotationController, args);
				}
			}
			
			internal EventHandler<PSPDFNoteAnnotationControllerAnnotOrigEventArgs> didChangeAnnotation;
			[Preserve (Conditional = true)]
			public override void DidChangeAnnotation (KS_PSPDFKitBindings.PSPDFNoteAnnotationController noteAnnotationController, KS_PSPDFKitBindings.PSPDFAnnotation annotation, KS_PSPDFKitBindings.PSPDFAnnotation originalAnnotation)
			{
				EventHandler<PSPDFNoteAnnotationControllerAnnotOrigEventArgs> handler = didChangeAnnotation;
				if (handler != null){
					var args = new PSPDFNoteAnnotationControllerAnnotOrigEventArgs (annotation, originalAnnotation);
					handler (noteAnnotationController, args);
				}
			}
			
			internal EventHandler<PSPDFNoteAnnotationControllerAnnotEventArgs> willDismissWithAnnotation;
			[Preserve (Conditional = true)]
			public override void WillDismissWithAnnotation (KS_PSPDFKitBindings.PSPDFNoteAnnotationController noteAnnotationController, KS_PSPDFKitBindings.PSPDFAnnotation annotation)
			{
				EventHandler<PSPDFNoteAnnotationControllerAnnotEventArgs> handler = willDismissWithAnnotation;
				if (handler != null){
					var args = new PSPDFNoteAnnotationControllerAnnotEventArgs (annotation);
					handler (noteAnnotationController, args);
				}
			}
			
		}
		#pragma warning restore 672
		
		public event EventHandler<PSPDFNoteAnnotationControllerAnnotEventArgs> DidDeleteAnnotation {
			add { EnsurePSPDFNoteAnnotationControllerDelegate ().didDeleteAnnotation += value; }
			remove { EnsurePSPDFNoteAnnotationControllerDelegate ().didDeleteAnnotation -= value; }
		}
		
		public event EventHandler<PSPDFNoteAnnotationControllerAnnotOrigEventArgs> DidChangeAnnotation {
			add { EnsurePSPDFNoteAnnotationControllerDelegate ().didChangeAnnotation += value; }
			remove { EnsurePSPDFNoteAnnotationControllerDelegate ().didChangeAnnotation -= value; }
		}
		
		public event EventHandler<PSPDFNoteAnnotationControllerAnnotEventArgs> WillDismissWithAnnotation {
			add { EnsurePSPDFNoteAnnotationControllerDelegate ().willDismissWithAnnotation += value; }
			remove { EnsurePSPDFNoteAnnotationControllerDelegate ().willDismissWithAnnotation -= value; }
		}
		
		internal delegate void InnerPSPDFNoteAnnotationControllerTextViewCustomizationHandler (IntPtr block, IntPtr controller);
		[CompilerGenerated]
		static readonly InnerPSPDFNoteAnnotationControllerTextViewCustomizationHandler static_InnerPSPDFNoteAnnotationControllerTextViewCustomizationHandler = TrampolinePSPDFNoteAnnotationControllerTextViewCustomizationHandler;
		[MonoPInvokeCallback (typeof (InnerPSPDFNoteAnnotationControllerTextViewCustomizationHandler))]
		static unsafe void TrampolinePSPDFNoteAnnotationControllerTextViewCustomizationHandler (IntPtr block, IntPtr controller) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::KS_PSPDFKitBindings.PSPDFNoteAnnotationControllerTextViewCustomizationHandler) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((KS_PSPDFKitBindings.PSPDFNoteAnnotationController) Runtime.GetNSObject (controller));
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Annotation_var = null;
				__mt_TextView_var = null;
				__mt_WeakDelegate_var = null;
				__mt_BackgroundView_var = null;
				__mt_OptionsView_var = null;
				__mt_TintColor_var = null;
			}
		}
	} /* class PSPDFNoteAnnotationController */
	public delegate void PSPDFNoteAnnotationControllerTextViewCustomizationHandler (PSPDFNoteAnnotationController controller);
	
	
	//
	// EventArgs classes
	//
	public partial class PSPDFNoteAnnotationControllerAnnotEventArgs : EventArgs {
		public PSPDFNoteAnnotationControllerAnnotEventArgs (KS_PSPDFKitBindings.PSPDFAnnotation annotation)
		{
			this.Annotation = annotation;
		}
		public KS_PSPDFKitBindings.PSPDFAnnotation Annotation { get; set; }
	}
	
	public partial class PSPDFNoteAnnotationControllerAnnotOrigEventArgs : EventArgs {
		public PSPDFNoteAnnotationControllerAnnotOrigEventArgs (KS_PSPDFKitBindings.PSPDFAnnotation annotation, KS_PSPDFKitBindings.PSPDFAnnotation originalAnnotation)
		{
			this.Annotation = annotation;
			this.OriginalAnnotation = originalAnnotation;
		}
		public KS_PSPDFKitBindings.PSPDFAnnotation Annotation { get; set; }
		public KS_PSPDFKitBindings.PSPDFAnnotation OriginalAnnotation { get; set; }
	}
	
}
