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
	[Register("PSPDFOutlineViewController", true)]
	public unsafe partial class PSPDFOutlineViewController : PSPDFEmptyTableViewController {
		[CompilerGenerated]
		const string selSearchEnabled = "searchEnabled";
		static readonly IntPtr selSearchEnabledHandle = Selector.GetHandle ("searchEnabled");
		[CompilerGenerated]
		const string selSetSearchEnabled_ = "setSearchEnabled:";
		static readonly IntPtr selSetSearchEnabled_Handle = Selector.GetHandle ("setSearchEnabled:");
		[CompilerGenerated]
		const string selAllowCopy = "allowCopy";
		static readonly IntPtr selAllowCopyHandle = Selector.GetHandle ("allowCopy");
		[CompilerGenerated]
		const string selSetAllowCopy_ = "setAllowCopy:";
		static readonly IntPtr selSetAllowCopy_Handle = Selector.GetHandle ("setAllowCopy:");
		[CompilerGenerated]
		const string selMaximumNumberOfLines = "maximumNumberOfLines";
		static readonly IntPtr selMaximumNumberOfLinesHandle = Selector.GetHandle ("maximumNumberOfLines");
		[CompilerGenerated]
		const string selSetMaximumNumberOfLines_ = "setMaximumNumberOfLines:";
		static readonly IntPtr selSetMaximumNumberOfLines_Handle = Selector.GetHandle ("setMaximumNumberOfLines:");
		[CompilerGenerated]
		const string selOutlineIntentLeftOffset = "outlineIntentLeftOffset";
		static readonly IntPtr selOutlineIntentLeftOffsetHandle = Selector.GetHandle ("outlineIntentLeftOffset");
		[CompilerGenerated]
		const string selSetOutlineIntentLeftOffset_ = "setOutlineIntentLeftOffset:";
		static readonly IntPtr selSetOutlineIntentLeftOffset_Handle = Selector.GetHandle ("setOutlineIntentLeftOffset:");
		[CompilerGenerated]
		const string selOutlineIndentMultiplier = "outlineIndentMultiplier";
		static readonly IntPtr selOutlineIndentMultiplierHandle = Selector.GetHandle ("outlineIndentMultiplier");
		[CompilerGenerated]
		const string selSetOutlineIndentMultiplier_ = "setOutlineIndentMultiplier:";
		static readonly IntPtr selSetOutlineIndentMultiplier_Handle = Selector.GetHandle ("setOutlineIndentMultiplier:");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selDocument = "document";
		static readonly IntPtr selDocumentHandle = Selector.GetHandle ("document");
		[CompilerGenerated]
		const string selSetDocument_ = "setDocument:";
		static readonly IntPtr selSetDocument_Handle = Selector.GetHandle ("setDocument:");
		[CompilerGenerated]
		const string selInitWithDocumentDelegate_ = "initWithDocument:delegate:";
		static readonly IntPtr selInitWithDocumentDelegate_Handle = Selector.GetHandle ("initWithDocument:delegate:");
		[CompilerGenerated]
		const string selUpdatePopoverSize = "updatePopoverSize";
		static readonly IntPtr selUpdatePopoverSizeHandle = Selector.GetHandle ("updatePopoverSize");
		[CompilerGenerated]
		const string selOutlineCellDidTapDisclosureButton_ = "outlineCellDidTapDisclosureButton:";
		static readonly IntPtr selOutlineCellDidTapDisclosureButton_Handle = Selector.GetHandle ("outlineCellDidTapDisclosureButton:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFOutlineViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFOutlineViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFOutlineViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFOutlineViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFOutlineViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDocument:delegate:")]
		[CompilerGenerated]
		public PSPDFOutlineViewController (PSPDFDocument document, PSPDFOutlineViewControllerDelegate Delegate)
			: base (NSObjectFlag.Empty)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithDocumentDelegate_Handle, document.Handle, Delegate == null ? IntPtr.Zero : Delegate.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithDocumentDelegate_Handle, document.Handle, Delegate == null ? IntPtr.Zero : Delegate.Handle);
			}
		}
		
		[Export ("initWithDocument:delegate:")]
		[CompilerGenerated]
		public PSPDFOutlineViewController (PSPDFDocument document, global::System.IntPtr Delegate)
			: base (NSObjectFlag.Empty)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithDocumentDelegate_Handle, document.Handle, Delegate);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithDocumentDelegate_Handle, document.Handle, Delegate);
			}
		}
		
		[Export ("updatePopoverSize")]
		[CompilerGenerated]
		public virtual void UpdatePopoverSize ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdatePopoverSizeHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selUpdatePopoverSizeHandle);
			}
		}
		
		[Export ("outlineCellDidTapDisclosureButton:")]
		[CompilerGenerated]
		public virtual void OutlineCellDidTapDisclosureButton (PSPDFOutlineCell cell)
		{
			if (cell == null)
				throw new ArgumentNullException ("cell");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selOutlineCellDidTapDisclosureButton_Handle, cell.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selOutlineCellDidTapDisclosureButton_Handle, cell.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual bool SearchEnabled {
			[Export ("searchEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSearchEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selSearchEnabledHandle);
				}
			}
			
			[Export ("setSearchEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSearchEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetSearchEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AllowCopy {
			[Export ("allowCopy", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowCopyHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAllowCopyHandle);
				}
			}
			
			[Export ("setAllowCopy:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowCopy_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAllowCopy_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 MaximumNumberOfLines {
			[Export ("maximumNumberOfLines", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selMaximumNumberOfLinesHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selMaximumNumberOfLinesHandle);
				}
			}
			
			[Export ("setMaximumNumberOfLines:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetMaximumNumberOfLines_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetMaximumNumberOfLines_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float OutlineIntentLeftOffset {
			[Export ("outlineIntentLeftOffset", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selOutlineIntentLeftOffsetHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selOutlineIntentLeftOffsetHandle);
				}
			}
			
			[Export ("setOutlineIntentLeftOffset:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetOutlineIntentLeftOffset_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetOutlineIntentLeftOffset_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float OutlineIndentMultiplier {
			[Export ("outlineIndentMultiplier", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selOutlineIndentMultiplierHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selOutlineIndentMultiplierHandle);
				}
			}
			
			[Export ("setOutlineIndentMultiplier:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetOutlineIndentMultiplier_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetOutlineIndentMultiplier_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public PSPDFOutlineViewControllerDelegate Delegate {
			get {
				return WeakDelegate as PSPDFOutlineViewControllerDelegate;
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
		object __mt_Document_var;
		[CompilerGenerated]
		public virtual PSPDFDocument Document {
			[Export ("document")]
			get {
				PSPDFDocument ret;
				if (IsDirectBinding) {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocumentHandle));
				} else {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocumentHandle));
				}
				MarkDirty ();
				__mt_Document_var = ret;
				return ret;
			}
			
			[Export ("setDocument:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDocument_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDocument_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Document_var = value;
			}
		}
		
		//
		// Events and properties from the delegate
		//
		
		_PSPDFOutlineViewControllerDelegate EnsurePSPDFOutlineViewControllerDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _PSPDFOutlineViewControllerDelegate))){
				del = new _PSPDFOutlineViewControllerDelegate ();
				WeakDelegate = del;
			}
			return (_PSPDFOutlineViewControllerDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _PSPDFOutlineViewControllerDelegate : KS_PSPDFKitBindings.PSPDFOutlineViewControllerDelegate { 
			public _PSPDFOutlineViewControllerDelegate () {}
			
			internal PSPDFOutlineViewControllerDidTapAtElement didTapAtElement;
			[Preserve (Conditional = true)]
			public override bool DidTapAtElement (KS_PSPDFKitBindings.PSPDFOutlineViewController outlineController, KS_PSPDFKitBindings.PSPDFOutlineElement outlineElement)
			{
				PSPDFOutlineViewControllerDidTapAtElement handler = didTapAtElement;
				if (handler != null)
					return handler (outlineController, outlineElement);
				return false;
			}
			
		}
		#pragma warning restore 672
		
		public PSPDFOutlineViewControllerDidTapAtElement DidTapAtElement {
			get { return EnsurePSPDFOutlineViewControllerDelegate ().didTapAtElement; }
			set { EnsurePSPDFOutlineViewControllerDelegate ().didTapAtElement = value; }
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
				__mt_Document_var = null;
			}
		}
	} /* class PSPDFOutlineViewController */
}
