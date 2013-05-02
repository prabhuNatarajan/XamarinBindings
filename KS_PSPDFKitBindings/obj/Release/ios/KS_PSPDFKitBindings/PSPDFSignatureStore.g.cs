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
	[Register("PSPDFSignatureStore", true)]
	public unsafe partial class PSPDFSignatureStore : NSObject {
		[CompilerGenerated]
		const string selSharedSignatureStore = "sharedSignatureStore";
		static readonly IntPtr selSharedSignatureStoreHandle = Selector.GetHandle ("sharedSignatureStore");
		[CompilerGenerated]
		const string selSignatures = "signatures";
		static readonly IntPtr selSignaturesHandle = Selector.GetHandle ("signatures");
		[CompilerGenerated]
		const string selSetSignatures_ = "setSignatures:";
		static readonly IntPtr selSetSignatures_Handle = Selector.GetHandle ("setSignatures:");
		[CompilerGenerated]
		const string selSignatureSavingEnabled = "signatureSavingEnabled";
		static readonly IntPtr selSignatureSavingEnabledHandle = Selector.GetHandle ("signatureSavingEnabled");
		[CompilerGenerated]
		const string selSetSignatureSavingEnabled_ = "setSignatureSavingEnabled:";
		static readonly IntPtr selSetSignatureSavingEnabled_Handle = Selector.GetHandle ("setSignatureSavingEnabled:");
		[CompilerGenerated]
		const string selCustomerSignatureFeatureEnabled = "customerSignatureFeatureEnabled";
		static readonly IntPtr selCustomerSignatureFeatureEnabledHandle = Selector.GetHandle ("customerSignatureFeatureEnabled");
		[CompilerGenerated]
		const string selSetCustomerSignatureFeatureEnabled_ = "setCustomerSignatureFeatureEnabled:";
		static readonly IntPtr selSetCustomerSignatureFeatureEnabled_Handle = Selector.GetHandle ("setCustomerSignatureFeatureEnabled:");
		[CompilerGenerated]
		const string selAddSignature_ = "addSignature:";
		static readonly IntPtr selAddSignature_Handle = Selector.GetHandle ("addSignature:");
		[CompilerGenerated]
		const string selRemoveSignature_ = "removeSignature:";
		static readonly IntPtr selRemoveSignature_Handle = Selector.GetHandle ("removeSignature:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSignatureStore");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFSignatureStore () : base (NSObjectFlag.Empty)
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
		public PSPDFSignatureStore (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFSignatureStore (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFSignatureStore (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addSignature:")]
		[CompilerGenerated]
		public virtual void AddSignature (PSPDFInkAnnotation signature)
		{
			if (signature == null)
				throw new ArgumentNullException ("signature");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAddSignature_Handle, signature.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selAddSignature_Handle, signature.Handle);
			}
		}
		
		[Export ("removeSignature:")]
		[CompilerGenerated]
		public virtual bool RemoveSignature (PSPDFInkAnnotation signature)
		{
			if (signature == null)
				throw new ArgumentNullException ("signature");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selRemoveSignature_Handle, signature.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selRemoveSignature_Handle, signature.Handle);
			}
		}
		
		[CompilerGenerated]
		static object __mt_SharedSignatureStore_var_static;
		[CompilerGenerated]
		public static PSPDFSignatureStore SharedSignatureStore {
			[Export ("sharedSignatureStore")]
			get {
				PSPDFSignatureStore ret;
				ret = (PSPDFSignatureStore) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selSharedSignatureStoreHandle));
				__mt_SharedSignatureStore_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Signatures_var;
		[CompilerGenerated]
		public virtual PSPDFInkAnnotation[] Signatures {
			[Export ("signatures", ArgumentSemantic.Copy)]
			get {
				PSPDFInkAnnotation[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFInkAnnotation>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSignaturesHandle));
				} else {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFInkAnnotation>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSignaturesHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Signatures_var = ret;
				return ret;
			}
			
			[Export ("setSignatures:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSignatures_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSignatures_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_Signatures_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool SignatureSavingEnabled {
			[Export ("signatureSavingEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSignatureSavingEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selSignatureSavingEnabledHandle);
				}
			}
			
			[Export ("setSignatureSavingEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSignatureSavingEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetSignatureSavingEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool CustomerSignatureFeatureEnabled {
			[Export ("customerSignatureFeatureEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCustomerSignatureFeatureEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selCustomerSignatureFeatureEnabledHandle);
				}
			}
			
			[Export ("setCustomerSignatureFeatureEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetCustomerSignatureFeatureEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetCustomerSignatureFeatureEnabled_Handle, value);
				}
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Signatures_var = null;
			}
		}
	} /* class PSPDFSignatureStore */
}
