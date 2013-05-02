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
	[Register("PSPDFFontSelectorViewController", true)]
	public unsafe partial class PSPDFFontSelectorViewController : global::MonoTouch.UIKit.UITableViewController {
		[CompilerGenerated]
		const string selFontFamilyNames = "fontFamilyNames";
		static readonly IntPtr selFontFamilyNamesHandle = Selector.GetHandle ("fontFamilyNames");
		[CompilerGenerated]
		const string selSetFontFamilyNames_ = "setFontFamilyNames:";
		static readonly IntPtr selSetFontFamilyNames_Handle = Selector.GetHandle ("setFontFamilyNames:");
		[CompilerGenerated]
		const string selSelectedFont = "selectedFont";
		static readonly IntPtr selSelectedFontHandle = Selector.GetHandle ("selectedFont");
		[CompilerGenerated]
		const string selSetSelectedFont_ = "setSelectedFont:";
		static readonly IntPtr selSetSelectedFont_Handle = Selector.GetHandle ("setSelectedFont:");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFFontSelectorViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFFontSelectorViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFFontSelectorViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFFontSelectorViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFFontSelectorViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual global::System.String[] FontFamilyNames {
			[Export ("fontFamilyNames")]
			get {
				if (IsDirectBinding) {
					return NSArray.StringArrayFromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFontFamilyNamesHandle));
				} else {
					return NSArray.StringArrayFromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFontFamilyNamesHandle));
				}
			}
			
			[Export ("setFontFamilyNames:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromStrings (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFontFamilyNames_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFontFamilyNames_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
			}
		}
		
		[CompilerGenerated]
		object __mt_SelectedFont_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIFont SelectedFont {
			[Export ("selectedFont")]
			get {
				global::MonoTouch.UIKit.UIFont ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIFont) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectedFontHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIFont) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSelectedFontHandle));
				}
				MarkDirty ();
				__mt_SelectedFont_var = ret;
				return ret;
			}
			
			[Export ("setSelectedFont:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSelectedFont_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSelectedFont_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_SelectedFont_var = value;
			}
		}
		
		[CompilerGenerated]
		public PSPDFFontSelectorViewControllerDelegate Delegate {
			get {
				return WeakDelegate as PSPDFFontSelectorViewControllerDelegate;
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
		
		//
		// Events and properties from the delegate
		//
		
		_PSPDFFontSelectorViewControllerDelegate EnsurePSPDFFontSelectorViewControllerDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _PSPDFFontSelectorViewControllerDelegate))){
				del = new _PSPDFFontSelectorViewControllerDelegate ();
				WeakDelegate = del;
			}
			return (_PSPDFFontSelectorViewControllerDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _PSPDFFontSelectorViewControllerDelegate : KS_PSPDFKitBindings.PSPDFFontSelectorViewControllerDelegate { 
			public _PSPDFFontSelectorViewControllerDelegate () {}
			
			internal EventHandler<PSPDFFontSelectorViewControllerDelegateDidSelectFontEventArgs> didSelectFont;
			[Preserve (Conditional = true)]
			public override void DidSelectFont (KS_PSPDFKitBindings.PSPDFFontSelectorViewController fontSelectorViewController, UIFont selectedFont)
			{
				EventHandler<PSPDFFontSelectorViewControllerDelegateDidSelectFontEventArgs> handler = didSelectFont;
				if (handler != null){
					var args = new PSPDFFontSelectorViewControllerDelegateDidSelectFontEventArgs (selectedFont);
					handler (fontSelectorViewController, args);
				}
			}
			
		}
		#pragma warning restore 672
		
		public event EventHandler<PSPDFFontSelectorViewControllerDelegateDidSelectFontEventArgs> DidSelectFont {
			add { EnsurePSPDFFontSelectorViewControllerDelegate ().didSelectFont += value; }
			remove { EnsurePSPDFFontSelectorViewControllerDelegate ().didSelectFont -= value; }
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_SelectedFont_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class PSPDFFontSelectorViewController */
	
	
	//
	// EventArgs classes
	//
	public partial class PSPDFFontSelectorViewControllerDelegateDidSelectFontEventArgs : EventArgs {
		public PSPDFFontSelectorViewControllerDelegateDidSelectFontEventArgs (UIFont selectedFont)
		{
			this.SelectedFont = selectedFont;
		}
		public UIFont SelectedFont { get; set; }
	}
	
}
