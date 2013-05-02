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
	[Register("PSPDFSignatureSelectorViewController", true)]
	public unsafe partial class PSPDFSignatureSelectorViewController : global::MonoTouch.UIKit.UITableViewController {
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
		const string selInitWithSignatures_ = "initWithSignatures:";
		static readonly IntPtr selInitWithSignatures_Handle = Selector.GetHandle ("initWithSignatures:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSignatureSelectorViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFSignatureSelectorViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFSignatureSelectorViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFSignatureSelectorViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFSignatureSelectorViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithSignatures:")]
		[CompilerGenerated]
		public PSPDFSignatureSelectorViewController (PSPDFInkAnnotation[] signatures)
			: base (NSObjectFlag.Empty)
		{
			if (signatures == null)
				throw new ArgumentNullException ("signatures");
			var nsa_signatures = NSArray.FromNSObjects (signatures);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithSignatures_Handle, nsa_signatures.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithSignatures_Handle, nsa_signatures.Handle);
			}
			nsa_signatures.Dispose ();
			
		}
		
		[CompilerGenerated]
		public PSPDFSignatureSelectorViewControllerDelegate Delegate {
			get {
				return WeakDelegate as PSPDFSignatureSelectorViewControllerDelegate;
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
		
		//
		// Events and properties from the delegate
		//
		
		_PSPDFSignatureSelectorViewControllerDelegate EnsurePSPDFSignatureSelectorViewControllerDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _PSPDFSignatureSelectorViewControllerDelegate))){
				del = new _PSPDFSignatureSelectorViewControllerDelegate ();
				WeakDelegate = del;
			}
			return (_PSPDFSignatureSelectorViewControllerDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _PSPDFSignatureSelectorViewControllerDelegate : KS_PSPDFKitBindings.PSPDFSignatureSelectorViewControllerDelegate { 
			public _PSPDFSignatureSelectorViewControllerDelegate () {}
			
			internal EventHandler<PSPDFSignatureSelectorViewControllerDelegateArgsEventArgs> didSelectSignature;
			[Preserve (Conditional = true)]
			public override void DidSelectSignature (KS_PSPDFKitBindings.PSPDFSignatureSelectorViewController signatureSelectorController, KS_PSPDFKitBindings.PSPDFInkAnnotation signature)
			{
				EventHandler<PSPDFSignatureSelectorViewControllerDelegateArgsEventArgs> handler = didSelectSignature;
				if (handler != null){
					var args = new PSPDFSignatureSelectorViewControllerDelegateArgsEventArgs (signature);
					handler (signatureSelectorController, args);
				}
			}
			
			internal EventHandler willCreateNewSignature;
			[Preserve (Conditional = true)]
			public override void WillCreateNewSignature (KS_PSPDFKitBindings.PSPDFSignatureSelectorViewController signatureSelectorController)
			{
				EventHandler handler = willCreateNewSignature;
				if (handler != null){
					handler (signatureSelectorController, EventArgs.Empty);
				}
			}
			
		}
		#pragma warning restore 672
		
		public event EventHandler<PSPDFSignatureSelectorViewControllerDelegateArgsEventArgs> DidSelectSignature {
			add { EnsurePSPDFSignatureSelectorViewControllerDelegate ().didSelectSignature += value; }
			remove { EnsurePSPDFSignatureSelectorViewControllerDelegate ().didSelectSignature -= value; }
		}
		
		public event EventHandler WillCreateNewSignature {
			add { EnsurePSPDFSignatureSelectorViewControllerDelegate ().willCreateNewSignature += value; }
			remove { EnsurePSPDFSignatureSelectorViewControllerDelegate ().willCreateNewSignature -= value; }
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
				__mt_UserInfo_var = null;
			}
		}
	} /* class PSPDFSignatureSelectorViewController */
	
	
	//
	// EventArgs classes
	//
	public partial class PSPDFSignatureSelectorViewControllerDelegateArgsEventArgs : EventArgs {
		public PSPDFSignatureSelectorViewControllerDelegateArgsEventArgs (KS_PSPDFKitBindings.PSPDFInkAnnotation signature)
		{
			this.Signature = signature;
		}
		public KS_PSPDFKitBindings.PSPDFInkAnnotation Signature { get; set; }
	}
	
}
