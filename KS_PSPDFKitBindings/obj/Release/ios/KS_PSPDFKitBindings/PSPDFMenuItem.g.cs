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
	[Register("PSPDFMenuItem", true)]
	public unsafe partial class PSPDFMenuItem : global::MonoTouch.UIKit.UIMenuItem {
		[CompilerGenerated]
		const string selIsEnabled = "isEnabled";
		static readonly IntPtr selIsEnabledHandle = Selector.GetHandle ("isEnabled");
		[CompilerGenerated]
		const string selSetEnabled_ = "setEnabled:";
		static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle ("setEnabled:");
		[CompilerGenerated]
		const string selIdentifier = "identifier";
		static readonly IntPtr selIdentifierHandle = Selector.GetHandle ("identifier");
		[CompilerGenerated]
		const string selSetIdentifier_ = "setIdentifier:";
		static readonly IntPtr selSetIdentifier_Handle = Selector.GetHandle ("setIdentifier:");
		[CompilerGenerated]
		const string selTitle = "title";
		static readonly IntPtr selTitleHandle = Selector.GetHandle ("title");
		[CompilerGenerated]
		const string selSetTitle_ = "setTitle:";
		static readonly IntPtr selSetTitle_Handle = Selector.GetHandle ("setTitle:");
		[CompilerGenerated]
		const string selPs_image = "ps_image";
		static readonly IntPtr selPs_imageHandle = Selector.GetHandle ("ps_image");
		[CompilerGenerated]
		const string selSetPs_image_ = "setPs_image:";
		static readonly IntPtr selSetPs_image_Handle = Selector.GetHandle ("setPs_image:");
		[CompilerGenerated]
		const string selInitWithTitleBlock_ = "initWithTitle:block:";
		static readonly IntPtr selInitWithTitleBlock_Handle = Selector.GetHandle ("initWithTitle:block:");
		[CompilerGenerated]
		const string selInitWithTitleBlockIdentifier_ = "initWithTitle:block:identifier:";
		static readonly IntPtr selInitWithTitleBlockIdentifier_Handle = Selector.GetHandle ("initWithTitle:block:identifier:");
		[CompilerGenerated]
		const string selInitWithTitleImageBlockIdentifier_ = "initWithTitle:image:block:identifier:";
		static readonly IntPtr selInitWithTitleImageBlockIdentifier_Handle = Selector.GetHandle ("initWithTitle:image:block:identifier:");
		[CompilerGenerated]
		const string selInitWithTitleImageBlockIdentifierAllowImageColors_ = "initWithTitle:image:block:identifier:allowImageColors:";
		static readonly IntPtr selInitWithTitleImageBlockIdentifierAllowImageColors_Handle = Selector.GetHandle ("initWithTitle:image:block:identifier:allowImageColors:");
		[CompilerGenerated]
		const string selSetBlock_ = "setBlock:";
		static readonly IntPtr selSetBlock_Handle = Selector.GetHandle ("setBlock:");
		[CompilerGenerated]
		const string selInstallMenuHandlerForObject_ = "installMenuHandlerForObject:";
		static readonly IntPtr selInstallMenuHandlerForObject_Handle = Selector.GetHandle ("installMenuHandlerForObject:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFMenuItem");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFMenuItem () : base (NSObjectFlag.Empty)
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
		public PSPDFMenuItem (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFMenuItem (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFMenuItem (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithTitle:block:")]
		[CompilerGenerated]
		public unsafe PSPDFMenuItem (string title, PSPDFMenuItemInitWithTitleHandler handler)
			: base (NSObjectFlag.Empty)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			if (handler == null)
				throw new ArgumentNullException ("handler");
			var nstitle = NSString.CreateNative (title);
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlock (static_InnerPSPDFMenuItemInitWithTitleHandler, handler);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithTitleBlock_Handle, nstitle, (IntPtr) block_ptr_handler);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithTitleBlock_Handle, nstitle, (IntPtr) block_ptr_handler);
			}
			NSString.ReleaseNative (nstitle);
			block_ptr_handler->CleanupBlock ();
			
		}
		
		[Export ("initWithTitle:block:identifier:")]
		[CompilerGenerated]
		public unsafe PSPDFMenuItem (string title, PSPDFMenuItemInitWithTitleHandler handler, string identifier)
			: base (NSObjectFlag.Empty)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			if (handler == null)
				throw new ArgumentNullException ("handler");
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			var nstitle = NSString.CreateNative (title);
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlock (static_InnerPSPDFMenuItemInitWithTitleHandler, handler);
			var nsidentifier = NSString.CreateNative (identifier);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selInitWithTitleBlockIdentifier_Handle, nstitle, (IntPtr) block_ptr_handler, nsidentifier);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selInitWithTitleBlockIdentifier_Handle, nstitle, (IntPtr) block_ptr_handler, nsidentifier);
			}
			NSString.ReleaseNative (nstitle);
			block_ptr_handler->CleanupBlock ();
			NSString.ReleaseNative (nsidentifier);
			
		}
		
		[Export ("initWithTitle:image:block:identifier:")]
		[CompilerGenerated]
		public unsafe PSPDFMenuItem (string title, global::MonoTouch.UIKit.UIImage image, PSPDFMenuItemInitWithTitleHandler handler, string identifier)
			: base (NSObjectFlag.Empty)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			if (image == null)
				throw new ArgumentNullException ("image");
			if (handler == null)
				throw new ArgumentNullException ("handler");
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			var nstitle = NSString.CreateNative (title);
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlock (static_InnerPSPDFMenuItemInitWithTitleHandler, handler);
			var nsidentifier = NSString.CreateNative (identifier);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, selInitWithTitleImageBlockIdentifier_Handle, nstitle, image.Handle, (IntPtr) block_ptr_handler, nsidentifier);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, selInitWithTitleImageBlockIdentifier_Handle, nstitle, image.Handle, (IntPtr) block_ptr_handler, nsidentifier);
			}
			NSString.ReleaseNative (nstitle);
			block_ptr_handler->CleanupBlock ();
			NSString.ReleaseNative (nsidentifier);
			
		}
		
		[Export ("initWithTitle:image:block:identifier:allowImageColors:")]
		[CompilerGenerated]
		public unsafe PSPDFMenuItem (string title, global::MonoTouch.UIKit.UIImage image, PSPDFMenuItemInitWithTitleHandler handler, string identifier, bool allowImageColors)
			: base (NSObjectFlag.Empty)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			if (image == null)
				throw new ArgumentNullException ("image");
			if (handler == null)
				throw new ArgumentNullException ("handler");
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			var nstitle = NSString.CreateNative (title);
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlock (static_InnerPSPDFMenuItemInitWithTitleHandler, handler);
			var nsidentifier = NSString.CreateNative (identifier);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_bool (this.Handle, selInitWithTitleImageBlockIdentifierAllowImageColors_Handle, nstitle, image.Handle, (IntPtr) block_ptr_handler, nsidentifier, allowImageColors);
			} else {
				Handle = ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_bool (this.SuperHandle, selInitWithTitleImageBlockIdentifierAllowImageColors_Handle, nstitle, image.Handle, (IntPtr) block_ptr_handler, nsidentifier, allowImageColors);
			}
			NSString.ReleaseNative (nstitle);
			block_ptr_handler->CleanupBlock ();
			NSString.ReleaseNative (nsidentifier);
			
		}
		
		[Export ("setBlock:")]
		[CompilerGenerated]
		public unsafe virtual void SetBlock (PSPDFMenuItemInitWithTitleHandler handler)
		{
			if (handler == null)
				throw new ArgumentNullException ("handler");
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlock (static_InnerPSPDFMenuItemInitWithTitleHandler, handler);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBlock_Handle, (IntPtr) block_ptr_handler);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBlock_Handle, (IntPtr) block_ptr_handler);
			}
			block_ptr_handler->CleanupBlock ();
			
		}
		
		[Export ("installMenuHandlerForObject:")]
		[CompilerGenerated]
		public static void InstallMenuHandlerForObject (NSObject obj)
		{
			if (obj == null)
				throw new ArgumentNullException ("obj");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selInstallMenuHandlerForObject_Handle, obj.Handle);
		}
		
		[CompilerGenerated]
		public virtual bool Enabled {
			[Export ("isEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsEnabledHandle);
				}
			}
			
			[Export ("setEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Identifier {
			[Export ("identifier", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selIdentifierHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selIdentifierHandle));
				}
			}
			
			[Export ("setIdentifier:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetIdentifier_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetIdentifier_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string Title {
			[Export ("title", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTitleHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTitleHandle));
				}
			}
			
			[Export ("setTitle:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTitle_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTitle_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_Ps_Image_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIImage Ps_Image {
			[Export ("ps_image", ArgumentSemantic.Copy)]
			get {
				global::MonoTouch.UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPs_imageHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPs_imageHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Ps_Image_var = ret;
				return ret;
			}
			
			[Export ("setPs_image:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPs_image_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPs_image_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Ps_Image_var = value;
			}
		}
		
		internal delegate void InnerPSPDFMenuItemInitWithTitleHandler (IntPtr block);
		[CompilerGenerated]
		static readonly InnerPSPDFMenuItemInitWithTitleHandler static_InnerPSPDFMenuItemInitWithTitleHandler = TrampolinePSPDFMenuItemInitWithTitleHandler;
		[MonoPInvokeCallback (typeof (InnerPSPDFMenuItemInitWithTitleHandler))]
		static unsafe void TrampolinePSPDFMenuItemInitWithTitleHandler (IntPtr block) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::KS_PSPDFKitBindings.PSPDFMenuItemInitWithTitleHandler) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ();
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Ps_Image_var = null;
			}
		}
	} /* class PSPDFMenuItem */
	public delegate void PSPDFMenuItemInitWithTitleHandler ();
}
