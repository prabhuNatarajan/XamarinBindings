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
	[Register("PSPDFFontStyleViewController", true)]
	public unsafe partial class PSPDFFontStyleViewController : global::MonoTouch.UIKit.UITableViewController {
		[CompilerGenerated]
		const string selFontFamilyName = "fontFamilyName";
		static readonly IntPtr selFontFamilyNameHandle = Selector.GetHandle ("fontFamilyName");
		[CompilerGenerated]
		const string selSetFontFamilyName_ = "setFontFamilyName:";
		static readonly IntPtr selSetFontFamilyName_Handle = Selector.GetHandle ("setFontFamilyName:");
		[CompilerGenerated]
		const string selFontNames = "fontNames";
		static readonly IntPtr selFontNamesHandle = Selector.GetHandle ("fontNames");
		[CompilerGenerated]
		const string selSetFontNames_ = "setFontNames:";
		static readonly IntPtr selSetFontNames_Handle = Selector.GetHandle ("setFontNames:");
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
		const string selInitWithFontFamilyName_ = "initWithFontFamilyName:";
		static readonly IntPtr selInitWithFontFamilyName_Handle = Selector.GetHandle ("initWithFontFamilyName:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFFontStyleViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFFontStyleViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFFontStyleViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFFontStyleViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFFontStyleViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFontFamilyName:")]
		[CompilerGenerated]
		public PSPDFFontStyleViewController (string fontFamilyName)
			: base (NSObjectFlag.Empty)
		{
			if (fontFamilyName == null)
				throw new ArgumentNullException ("fontFamilyName");
			var nsfontFamilyName = NSString.CreateNative (fontFamilyName);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithFontFamilyName_Handle, nsfontFamilyName);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithFontFamilyName_Handle, nsfontFamilyName);
			}
			NSString.ReleaseNative (nsfontFamilyName);
			
		}
		
		[CompilerGenerated]
		public virtual string FontFamilyName {
			[Export ("fontFamilyName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFontFamilyNameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFontFamilyNameHandle));
				}
			}
			
			[Export ("setFontFamilyName:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFontFamilyName_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFontFamilyName_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.String[] FontNames {
			[Export ("fontNames")]
			get {
				if (IsDirectBinding) {
					return NSArray.StringArrayFromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFontNamesHandle));
				} else {
					return NSArray.StringArrayFromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFontNamesHandle));
				}
			}
			
			[Export ("setFontNames:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromStrings (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFontNames_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFontNames_Handle, nsa_value.Handle);
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
		public PSPDFFontStyleViewControllerDelegate Delegate {
			get {
				return WeakDelegate as PSPDFFontStyleViewControllerDelegate;
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
		
		_PSPDFFontStyleViewControllerDelegate EnsurePSPDFFontStyleViewControllerDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _PSPDFFontStyleViewControllerDelegate))){
				del = new _PSPDFFontStyleViewControllerDelegate ();
				WeakDelegate = del;
			}
			return (_PSPDFFontStyleViewControllerDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _PSPDFFontStyleViewControllerDelegate : KS_PSPDFKitBindings.PSPDFFontStyleViewControllerDelegate { 
			public _PSPDFFontStyleViewControllerDelegate () {}
			
			internal EventHandler<PSPDFFontStyleViewControllerDelegateDidSelectFontEventArgs> didSelectFont;
			[Preserve (Conditional = true)]
			public override void DidSelectFont (KS_PSPDFKitBindings.PSPDFFontStyleViewController fontStyleViewController, UIFont selectedFont)
			{
				EventHandler<PSPDFFontStyleViewControllerDelegateDidSelectFontEventArgs> handler = didSelectFont;
				if (handler != null){
					var args = new PSPDFFontStyleViewControllerDelegateDidSelectFontEventArgs (selectedFont);
					handler (fontStyleViewController, args);
				}
			}
			
		}
		#pragma warning restore 672
		
		public event EventHandler<PSPDFFontStyleViewControllerDelegateDidSelectFontEventArgs> DidSelectFont {
			add { EnsurePSPDFFontStyleViewControllerDelegate ().didSelectFont += value; }
			remove { EnsurePSPDFFontStyleViewControllerDelegate ().didSelectFont -= value; }
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_SelectedFont_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class PSPDFFontStyleViewController */
	
	
	//
	// EventArgs classes
	//
	public partial class PSPDFFontStyleViewControllerDelegateDidSelectFontEventArgs : EventArgs {
		public PSPDFFontStyleViewControllerDelegateDidSelectFontEventArgs (UIFont selectedFont)
		{
			this.SelectedFont = selectedFont;
		}
		public UIFont SelectedFont { get; set; }
	}
	
}
