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
	[Register("PSPDFBookmarkViewController", true)]
	public unsafe partial class PSPDFBookmarkViewController : global::MonoTouch.UIKit.UITableViewController {
		[CompilerGenerated]
		const string selDocument = "document";
		static readonly IntPtr selDocumentHandle = Selector.GetHandle ("document");
		[CompilerGenerated]
		const string selSetDocument_ = "setDocument:";
		static readonly IntPtr selSetDocument_Handle = Selector.GetHandle ("setDocument:");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selAllowCopy = "allowCopy";
		static readonly IntPtr selAllowCopyHandle = Selector.GetHandle ("allowCopy");
		[CompilerGenerated]
		const string selSetAllowCopy_ = "setAllowCopy:";
		static readonly IntPtr selSetAllowCopy_Handle = Selector.GetHandle ("setAllowCopy:");
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
		const string selInitWithDocumentDelegate_ = "initWithDocument:delegate:";
		static readonly IntPtr selInitWithDocumentDelegate_Handle = Selector.GetHandle ("initWithDocument:delegate:");
		[CompilerGenerated]
		const string selCreateBarButtonItems = "createBarButtonItems";
		static readonly IntPtr selCreateBarButtonItemsHandle = Selector.GetHandle ("createBarButtonItems");
		[CompilerGenerated]
		const string selUpdatePopoverSize = "updatePopoverSize";
		static readonly IntPtr selUpdatePopoverSizeHandle = Selector.GetHandle ("updatePopoverSize");
		[CompilerGenerated]
		const string selUpdateBookmarkView = "updateBookmarkView";
		static readonly IntPtr selUpdateBookmarkViewHandle = Selector.GetHandle ("updateBookmarkView");
		[CompilerGenerated]
		const string selAddBookmarkAction_ = "addBookmarkAction:";
		static readonly IntPtr selAddBookmarkAction_Handle = Selector.GetHandle ("addBookmarkAction:");
		[CompilerGenerated]
		const string selDoneAction_ = "doneAction:";
		static readonly IntPtr selDoneAction_Handle = Selector.GetHandle ("doneAction:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFBookmarkViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFBookmarkViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFBookmarkViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFBookmarkViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFBookmarkViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDocument:delegate:")]
		[CompilerGenerated]
		public PSPDFBookmarkViewController (PSPDFDocument document, PSPDFBookmarkViewControllerDelegate bookmarkDelegate)
			: base (NSObjectFlag.Empty)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithDocumentDelegate_Handle, document.Handle, bookmarkDelegate == null ? IntPtr.Zero : bookmarkDelegate.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithDocumentDelegate_Handle, document.Handle, bookmarkDelegate == null ? IntPtr.Zero : bookmarkDelegate.Handle);
			}
		}
		
		[Export ("createBarButtonItems")]
		[CompilerGenerated]
		public virtual void CreateBarButtonItems ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCreateBarButtonItemsHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selCreateBarButtonItemsHandle);
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
		
		[Export ("updateBookmarkView")]
		[CompilerGenerated]
		public virtual void UpdateBookmarkView ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateBookmarkViewHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selUpdateBookmarkViewHandle);
			}
		}
		
		[Export ("addBookmarkAction:")]
		[CompilerGenerated]
		public virtual void AddBookmarkAction (NSObject sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAddBookmarkAction_Handle, sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selAddBookmarkAction_Handle, sender.Handle);
			}
		}
		
		[Export ("doneAction:")]
		[CompilerGenerated]
		public virtual void DoneAction (NSObject sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selDoneAction_Handle, sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selDoneAction_Handle, sender.Handle);
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
		
		[CompilerGenerated]
		public PSPDFBookmarkViewControllerDelegate Delegate {
			get {
				return WeakDelegate as PSPDFBookmarkViewControllerDelegate;
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
		
		_PSPDFBookmarkViewControllerDelegate EnsurePSPDFBookmarkViewControllerDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _PSPDFBookmarkViewControllerDelegate))){
				del = new _PSPDFBookmarkViewControllerDelegate ();
				WeakDelegate = del;
			}
			return (_PSPDFBookmarkViewControllerDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _PSPDFBookmarkViewControllerDelegate : KS_PSPDFKitBindings.PSPDFBookmarkViewControllerDelegate { 
			public _PSPDFBookmarkViewControllerDelegate () {}
			
			internal PSPDFBookmarkViewControllerDelegateCurrentPage currentPageForBookmarkViewController;
			[Preserve (Conditional = true)]
			public override uint CurrentPageForBookmarkViewController (KS_PSPDFKitBindings.PSPDFBookmarkViewController bookmarkController)
			{
				PSPDFBookmarkViewControllerDelegateCurrentPage handler = currentPageForBookmarkViewController;
				if (handler != null)
					return handler (bookmarkController);
				return 1;
			}
			
			internal EventHandler<PSPDFBookmarkViewControllerDelegateArgsEventArgs> didSelectBookmark;
			[Preserve (Conditional = true)]
			public override void DidSelectBookmark (KS_PSPDFKitBindings.PSPDFBookmarkViewController bookmarkController, KS_PSPDFKitBindings.PSPDFBookmark bookmark)
			{
				EventHandler<PSPDFBookmarkViewControllerDelegateArgsEventArgs> handler = didSelectBookmark;
				if (handler != null){
					var args = new PSPDFBookmarkViewControllerDelegateArgsEventArgs (bookmark);
					handler (bookmarkController, args);
				}
			}
			
		}
		#pragma warning restore 672
		
		public PSPDFBookmarkViewControllerDelegateCurrentPage CurrentPageForBookmarkViewController {
			get { return EnsurePSPDFBookmarkViewControllerDelegate ().currentPageForBookmarkViewController; }
			set { EnsurePSPDFBookmarkViewControllerDelegate ().currentPageForBookmarkViewController = value; }
		}
		
		public event EventHandler<PSPDFBookmarkViewControllerDelegateArgsEventArgs> DidSelectBookmark {
			add { EnsurePSPDFBookmarkViewControllerDelegate ().didSelectBookmark += value; }
			remove { EnsurePSPDFBookmarkViewControllerDelegate ().didSelectBookmark -= value; }
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Document_var = null;
				__mt_WeakDelegate_var = null;
				__mt_TintColor_var = null;
			}
		}
	} /* class PSPDFBookmarkViewController */
	
	
	//
	// EventArgs classes
	//
	public partial class PSPDFBookmarkViewControllerDelegateArgsEventArgs : EventArgs {
		public PSPDFBookmarkViewControllerDelegateArgsEventArgs (KS_PSPDFKitBindings.PSPDFBookmark bookmark)
		{
			this.Bookmark = bookmark;
		}
		public KS_PSPDFKitBindings.PSPDFBookmark Bookmark { get; set; }
	}
	
}
