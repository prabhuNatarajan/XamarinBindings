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
	[Register("PSPDFSignatureViewController", true)]
	public unsafe partial class PSPDFSignatureViewController : PSPDFBaseViewController {
		[CompilerGenerated]
		const string selLines = "lines";
		static readonly IntPtr selLinesHandle = Selector.GetHandle ("lines");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selUserInfo = "userInfo";
		static readonly IntPtr selUserInfoHandle = Selector.GetHandle ("userInfo");
		[CompilerGenerated]
		const string selSetUserInfo_ = "setUserInfo:";
		static readonly IntPtr selSetUserInfo_Handle = Selector.GetHandle ("setUserInfo:");
		[CompilerGenerated]
		const string selCancel_ = "cancel:";
		static readonly IntPtr selCancel_Handle = Selector.GetHandle ("cancel:");
		[CompilerGenerated]
		const string selDone_ = "done:";
		static readonly IntPtr selDone_Handle = Selector.GetHandle ("done:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSignatureViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFSignatureViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFSignatureViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFSignatureViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFSignatureViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("cancel:")]
		[CompilerGenerated]
		public virtual void Cancel (NSObject sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selCancel_Handle, sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selCancel_Handle, sender.Handle);
			}
		}
		
		[Export ("done:")]
		[CompilerGenerated]
		public virtual void Done (NSObject sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selDone_Handle, sender.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selDone_Handle, sender.Handle);
			}
		}
		
		[CompilerGenerated]
		object __mt_Lines_var;
		[CompilerGenerated]
		public virtual NSArray Lines {
			[Export ("lines")]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLinesHandle));
				} else {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLinesHandle));
				}
				MarkDirty ();
				__mt_Lines_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public PSPDFSignatureViewControllerDelegate Delegate {
			get {
				return WeakDelegate as PSPDFSignatureViewControllerDelegate;
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
		object __mt_UserInfo_var;
		[CompilerGenerated]
		public virtual NSDictionary UserInfo {
			[Export ("userInfo", ArgumentSemantic.Copy)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserInfoHandle));
				} else {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUserInfoHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_UserInfo_var = ret;
				return ret;
			}
			
			[Export ("setUserInfo:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUserInfo_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUserInfo_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_UserInfo_var = value;
			}
		}
		
		[CompilerGenerated]
		static readonly IntPtr __Internal_libraryHandle = Dlfcn.dlopen (null, 0);
		[CompilerGenerated]
		static NSString _PSPDFSignatureControllerShouldSave;
		public static NSString PSPDFSignatureControllerShouldSave {
			get {
				if (_PSPDFSignatureControllerShouldSave == null)
					_PSPDFSignatureControllerShouldSave = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSPDFSignatureControllerShouldSave");
				return _PSPDFSignatureControllerShouldSave;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFSignatureControllerTargetPoint;
		public static NSString PSPDFSignatureControllerTargetPoint {
			get {
				if (_PSPDFSignatureControllerTargetPoint == null)
					_PSPDFSignatureControllerTargetPoint = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSPDFSignatureControllerTargetPoint");
				return _PSPDFSignatureControllerTargetPoint;
			}
		}
		//
		// Events and properties from the delegate
		//
		
		_PSPDFSignatureViewControllerDelegate EnsurePSPDFSignatureViewControllerDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _PSPDFSignatureViewControllerDelegate))){
				del = new _PSPDFSignatureViewControllerDelegate ();
				WeakDelegate = del;
			}
			return (_PSPDFSignatureViewControllerDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _PSPDFSignatureViewControllerDelegate : KS_PSPDFKitBindings.PSPDFSignatureViewControllerDelegate { 
			public _PSPDFSignatureViewControllerDelegate () {}
			
			internal EventHandler didCancel;
			[Preserve (Conditional = true)]
			public override void DidCancel (KS_PSPDFKitBindings.PSPDFSignatureViewController signatureController)
			{
				EventHandler handler = didCancel;
				if (handler != null){
					handler (signatureController, EventArgs.Empty);
				}
			}
			
			internal EventHandler didSave;
			[Preserve (Conditional = true)]
			public override void DidSave (KS_PSPDFKitBindings.PSPDFSignatureViewController signatureController)
			{
				EventHandler handler = didSave;
				if (handler != null){
					handler (signatureController, EventArgs.Empty);
				}
			}
			
		}
		#pragma warning restore 672
		
		public event EventHandler DidCancel {
			add { EnsurePSPDFSignatureViewControllerDelegate ().didCancel += value; }
			remove { EnsurePSPDFSignatureViewControllerDelegate ().didCancel -= value; }
		}
		
		public event EventHandler DidSave {
			add { EnsurePSPDFSignatureViewControllerDelegate ().didSave += value; }
			remove { EnsurePSPDFSignatureViewControllerDelegate ().didSave -= value; }
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Lines_var = null;
				__mt_WeakDelegate_var = null;
				__mt_UserInfo_var = null;
			}
		}
	} /* class PSPDFSignatureViewController */
}
