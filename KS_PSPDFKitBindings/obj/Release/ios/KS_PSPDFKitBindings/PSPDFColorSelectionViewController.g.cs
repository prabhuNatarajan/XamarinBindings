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
	[Register("PSPDFColorSelectionViewController", true)]
	public unsafe partial class PSPDFColorSelectionViewController : global::MonoTouch.UIKit.UIViewController {
		[CompilerGenerated]
		const string selColors = "colors";
		static readonly IntPtr selColorsHandle = Selector.GetHandle ("colors");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selDefaultColorPickerWithTitleDelegateContext_ = "defaultColorPickerWithTitle:delegate:context:";
		static readonly IntPtr selDefaultColorPickerWithTitleDelegateContext_Handle = Selector.GetHandle ("defaultColorPickerWithTitle:delegate:context:");
		[CompilerGenerated]
		const string selSetDefaultColorPickerStyles_ = "setDefaultColorPickerStyles:";
		static readonly IntPtr selSetDefaultColorPickerStyles_Handle = Selector.GetHandle ("setDefaultColorPickerStyles:");
		[CompilerGenerated]
		const string selMonoChromeSelectionViewController = "monoChromeSelectionViewController";
		static readonly IntPtr selMonoChromeSelectionViewControllerHandle = Selector.GetHandle ("monoChromeSelectionViewController");
		[CompilerGenerated]
		const string selModernColorsSelectionViewController = "modernColorsSelectionViewController";
		static readonly IntPtr selModernColorsSelectionViewControllerHandle = Selector.GetHandle ("modernColorsSelectionViewController");
		[CompilerGenerated]
		const string selVintageColorsSelectionViewController = "vintageColorsSelectionViewController";
		static readonly IntPtr selVintageColorsSelectionViewControllerHandle = Selector.GetHandle ("vintageColorsSelectionViewController");
		[CompilerGenerated]
		const string selRainbowSelectionViewController = "rainbowSelectionViewController";
		static readonly IntPtr selRainbowSelectionViewControllerHandle = Selector.GetHandle ("rainbowSelectionViewController");
		[CompilerGenerated]
		const string selColorSelectionViewControllerFromColorsAddDarkenedVariants_ = "colorSelectionViewControllerFromColors:addDarkenedVariants:";
		static readonly IntPtr selColorSelectionViewControllerFromColorsAddDarkenedVariants_Handle = Selector.GetHandle ("colorSelectionViewControllerFromColors:addDarkenedVariants:");
		[CompilerGenerated]
		const string selColorsFromPalletURLAddDarkenedVariants_ = "colorsFromPalletURL:addDarkenedVariants:";
		static readonly IntPtr selColorsFromPalletURLAddDarkenedVariants_Handle = Selector.GetHandle ("colorsFromPalletURL:addDarkenedVariants:");
		[CompilerGenerated]
		const string selSetDefaultColorArrays_ = "setDefaultColorArrays:";
		static readonly IntPtr selSetDefaultColorArrays_Handle = Selector.GetHandle ("setDefaultColorArrays:");
		[CompilerGenerated]
		const string selInitWithColors_ = "initWithColors:";
		static readonly IntPtr selInitWithColors_Handle = Selector.GetHandle ("initWithColors:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFColorSelectionViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFColorSelectionViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFColorSelectionViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFColorSelectionViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFColorSelectionViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("defaultColorPickerWithTitle:delegate:context:")]
		[CompilerGenerated]
		public static PSPDFSimplePageViewController DefaultColorPickerWithTitle (string title, PSPDFColorSelectionViewControllerDelegate colorSelDelegate, global::System.IntPtr context)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			if (colorSelDelegate == null)
				throw new ArgumentNullException ("colorSelDelegate");
			var nstitle = NSString.CreateNative (title);
			
			PSPDFSimplePageViewController ret;
			ret = (PSPDFSimplePageViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selDefaultColorPickerWithTitleDelegateContext_Handle, nstitle, colorSelDelegate.Handle, context));
			NSString.ReleaseNative (nstitle);
			
			return ret;
		}
		
		[Export ("setDefaultColorPickerStyles:")]
		[CompilerGenerated]
		public static void SetDefaultColorPickerStyles (NSNumber[] colorPickerStyles)
		{
			if (colorPickerStyles == null)
				throw new ArgumentNullException ("colorPickerStyles");
			var nsa_colorPickerStyles = NSArray.FromNSObjects (colorPickerStyles);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selSetDefaultColorPickerStyles_Handle, nsa_colorPickerStyles.Handle);
			nsa_colorPickerStyles.Dispose ();
			
		}
		
		[Export ("monoChromeSelectionViewController")]
		[CompilerGenerated]
		public static PSPDFColorSelectionViewController MonoChromeSelectionViewController ()
		{
			return (PSPDFColorSelectionViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selMonoChromeSelectionViewControllerHandle));
		}
		
		[Export ("modernColorsSelectionViewController")]
		[CompilerGenerated]
		public static PSPDFColorSelectionViewController ModernColorsSelectionViewController ()
		{
			return (PSPDFColorSelectionViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selModernColorsSelectionViewControllerHandle));
		}
		
		[Export ("vintageColorsSelectionViewController")]
		[CompilerGenerated]
		public static PSPDFColorSelectionViewController VintageColorsSelectionViewController ()
		{
			return (PSPDFColorSelectionViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selVintageColorsSelectionViewControllerHandle));
		}
		
		[Export ("rainbowSelectionViewController")]
		[CompilerGenerated]
		public static PSPDFColorSelectionViewController RainbowSelectionViewController ()
		{
			return (PSPDFColorSelectionViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selRainbowSelectionViewControllerHandle));
		}
		
		[Export ("colorSelectionViewControllerFromColors:addDarkenedVariants:")]
		[CompilerGenerated]
		public static PSPDFColorSelectionViewController ColorSelectionViewControllerFromColors (global::MonoTouch.UIKit.UIColor[] colorsArray, bool darkenedVariants)
		{
			if (colorsArray == null)
				throw new ArgumentNullException ("colorsArray");
			var nsa_colorsArray = NSArray.FromNSObjects (colorsArray);
			
			PSPDFColorSelectionViewController ret;
			ret = (PSPDFColorSelectionViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_bool (class_ptr, selColorSelectionViewControllerFromColorsAddDarkenedVariants_Handle, nsa_colorsArray.Handle, darkenedVariants));
			nsa_colorsArray.Dispose ();
			
			return ret;
		}
		
		[Export ("colorsFromPalletURL:addDarkenedVariants:")]
		[CompilerGenerated]
		public static global::MonoTouch.UIKit.UIColor[] ColorSelectionViewControllerFromColors (NSUrl palletURL, bool darkenedVariants)
		{
			if (palletURL == null)
				throw new ArgumentNullException ("palletURL");
			return NSArray.ArrayFromHandle<MonoTouch.UIKit.UIColor>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_bool (class_ptr, selColorsFromPalletURLAddDarkenedVariants_Handle, palletURL.Handle, darkenedVariants));
		}
		
		[Export ("setDefaultColorArrays:")]
		[CompilerGenerated]
		public static void SetDefaultColorArrays (global::MonoTouch.UIKit.UIColor[] defaultColorArrays)
		{
			var nsa_defaultColorArrays = defaultColorArrays == null ? null : NSArray.FromNSObjects (defaultColorArrays);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selSetDefaultColorArrays_Handle, nsa_defaultColorArrays == null ? IntPtr.Zero : nsa_defaultColorArrays.Handle);
			if (nsa_defaultColorArrays != null)
				nsa_defaultColorArrays.Dispose ();
			
		}
		
		[Export ("initWithColors:")]
		[CompilerGenerated]
		public PSPDFColorSelectionViewController (global::MonoTouch.UIKit.UIColor[] colors)
			: base (NSObjectFlag.Empty)
		{
			if (colors == null)
				throw new ArgumentNullException ("colors");
			var nsa_colors = NSArray.FromNSObjects (colors);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithColors_Handle, nsa_colors.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithColors_Handle, nsa_colors.Handle);
			}
			nsa_colors.Dispose ();
			
		}
		
		[CompilerGenerated]
		object __mt_Colors_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor[] Colors {
			[Export ("colors", ArgumentSemantic.Copy)]
			get {
				global::MonoTouch.UIKit.UIColor[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.UIKit.UIColor>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selColorsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.UIKit.UIColor>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selColorsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Colors_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public PSPDFColorSelectionViewControllerDelegate Delegate {
			get {
				return WeakDelegate as PSPDFColorSelectionViewControllerDelegate;
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
		
		_PSPDFColorSelectionViewControllerDelegate EnsurePSPDFColorSelectionViewControllerDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _PSPDFColorSelectionViewControllerDelegate))){
				del = new _PSPDFColorSelectionViewControllerDelegate ();
				WeakDelegate = del;
			}
			return (_PSPDFColorSelectionViewControllerDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _PSPDFColorSelectionViewControllerDelegate : KS_PSPDFKitBindings.PSPDFColorSelectionViewControllerDelegate { 
			public _PSPDFColorSelectionViewControllerDelegate () {}
			
			internal PSPDFColorSelectionViewControllerColor colorSelectionControllerSelectedColor;
			[Preserve (Conditional = true)]
			public override UIColor ColorSelectionControllerSelectedColor (UIViewController controller, IntPtr context)
			{
				PSPDFColorSelectionViewControllerColor handler = colorSelectionControllerSelectedColor;
				if (handler != null)
					return handler (controller, context);
				return null;
			}
			
			internal EventHandler<PSPDFColorSelectionViewControllerDidSelectedColorEventArgs> didSelectedColor;
			[Preserve (Conditional = true)]
			public override void DidSelectedColor (UIViewController controller, UIColor color, bool finished, IntPtr context)
			{
				EventHandler<PSPDFColorSelectionViewControllerDidSelectedColorEventArgs> handler = didSelectedColor;
				if (handler != null){
					var args = new PSPDFColorSelectionViewControllerDidSelectedColorEventArgs (color, finished, context);
					handler (controller, args);
				}
			}
			
		}
		#pragma warning restore 672
		
		public PSPDFColorSelectionViewControllerColor ColorSelectionControllerSelectedColor {
			get { return EnsurePSPDFColorSelectionViewControllerDelegate ().colorSelectionControllerSelectedColor; }
			set { EnsurePSPDFColorSelectionViewControllerDelegate ().colorSelectionControllerSelectedColor = value; }
		}
		
		public event EventHandler<PSPDFColorSelectionViewControllerDidSelectedColorEventArgs> DidSelectedColor {
			add { EnsurePSPDFColorSelectionViewControllerDelegate ().didSelectedColor += value; }
			remove { EnsurePSPDFColorSelectionViewControllerDelegate ().didSelectedColor -= value; }
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Colors_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class PSPDFColorSelectionViewController */
	
	
	//
	// EventArgs classes
	//
	public partial class PSPDFColorSelectionViewControllerDidSelectedColorEventArgs : EventArgs {
		public PSPDFColorSelectionViewControllerDidSelectedColorEventArgs (UIColor color, bool finished, IntPtr context)
		{
			this.Color = color;
			this.Finished = finished;
			this.Context = context;
		}
		public UIColor Color { get; set; }
		public bool Finished { get; set; }
		public IntPtr Context { get; set; }
	}
	
}
