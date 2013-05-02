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
	[Register("PSPDFPasswordView", true)]
	public unsafe partial class PSPDFPasswordView : global::MonoTouch.UIKit.UIView {
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
		const string selShakeOnError = "shakeOnError";
		static readonly IntPtr selShakeOnErrorHandle = Selector.GetHandle ("shakeOnError");
		[CompilerGenerated]
		const string selSetShakeOnError_ = "setShakeOnError:";
		static readonly IntPtr selSetShakeOnError_Handle = Selector.GetHandle ("setShakeOnError:");
		[CompilerGenerated]
		const string selPasswordField = "passwordField";
		static readonly IntPtr selPasswordFieldHandle = Selector.GetHandle ("passwordField");
		[CompilerGenerated]
		const string selBecomeFirstResponder = "becomeFirstResponder";
		static readonly IntPtr selBecomeFirstResponderHandle = Selector.GetHandle ("becomeFirstResponder");
		[CompilerGenerated]
		const string selTextFieldShouldBeginEditing_ = "textFieldShouldBeginEditing:";
		static readonly IntPtr selTextFieldShouldBeginEditing_Handle = Selector.GetHandle ("textFieldShouldBeginEditing:");
		[CompilerGenerated]
		const string selTextFieldDidBeginEditing_ = "textFieldDidBeginEditing:";
		static readonly IntPtr selTextFieldDidBeginEditing_Handle = Selector.GetHandle ("textFieldDidBeginEditing:");
		[CompilerGenerated]
		const string selTextFieldShouldEndEditing_ = "textFieldShouldEndEditing:";
		static readonly IntPtr selTextFieldShouldEndEditing_Handle = Selector.GetHandle ("textFieldShouldEndEditing:");
		[CompilerGenerated]
		const string selTextFieldDidEndEditing_ = "textFieldDidEndEditing:";
		static readonly IntPtr selTextFieldDidEndEditing_Handle = Selector.GetHandle ("textFieldDidEndEditing:");
		[CompilerGenerated]
		const string selTextFieldShouldChangeCharactersInRangeReplacementString_ = "textField:shouldChangeCharactersInRange:replacementString:";
		static readonly IntPtr selTextFieldShouldChangeCharactersInRangeReplacementString_Handle = Selector.GetHandle ("textField:shouldChangeCharactersInRange:replacementString:");
		[CompilerGenerated]
		const string selTextFieldShouldClear_ = "textFieldShouldClear:";
		static readonly IntPtr selTextFieldShouldClear_Handle = Selector.GetHandle ("textFieldShouldClear:");
		[CompilerGenerated]
		const string selTextFieldShouldReturn_ = "textFieldShouldReturn:";
		static readonly IntPtr selTextFieldShouldReturn_Handle = Selector.GetHandle ("textFieldShouldReturn:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFPasswordView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFPasswordView () : base (NSObjectFlag.Empty)
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
		public PSPDFPasswordView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFPasswordView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFPasswordView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("becomeFirstResponder")]
		[CompilerGenerated]
		public new virtual bool BecomeFirstResponder ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selBecomeFirstResponderHandle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selBecomeFirstResponderHandle);
			}
		}
		
		[Export ("textFieldShouldBeginEditing:")]
		[CompilerGenerated]
		public virtual bool TextFieldShouldBeginEditing (global::MonoTouch.UIKit.UITextField textField)
		{
			if (textField == null)
				throw new ArgumentNullException ("textField");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selTextFieldShouldBeginEditing_Handle, textField.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selTextFieldShouldBeginEditing_Handle, textField.Handle);
			}
		}
		
		[Export ("textFieldDidBeginEditing:")]
		[CompilerGenerated]
		public virtual void TextFieldDidBeginEditing (global::MonoTouch.UIKit.UITextField textField)
		{
			if (textField == null)
				throw new ArgumentNullException ("textField");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selTextFieldDidBeginEditing_Handle, textField.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selTextFieldDidBeginEditing_Handle, textField.Handle);
			}
		}
		
		[Export ("textFieldShouldEndEditing:")]
		[CompilerGenerated]
		public virtual bool TextFieldShouldEndEditing (global::MonoTouch.UIKit.UITextField textField)
		{
			if (textField == null)
				throw new ArgumentNullException ("textField");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selTextFieldShouldEndEditing_Handle, textField.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selTextFieldShouldEndEditing_Handle, textField.Handle);
			}
		}
		
		[Export ("textFieldDidEndEditing:")]
		[CompilerGenerated]
		public virtual void TextFieldDidEndEditing (global::MonoTouch.UIKit.UITextField textField)
		{
			if (textField == null)
				throw new ArgumentNullException ("textField");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selTextFieldDidEndEditing_Handle, textField.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selTextFieldDidEndEditing_Handle, textField.Handle);
			}
		}
		
		[Export ("textField:shouldChangeCharactersInRange:replacementString:")]
		[CompilerGenerated]
		public virtual bool TextFielShouldChangeCharactersInRange (global::MonoTouch.UIKit.UITextField textField, NSRange range, string text)
		{
			if (textField == null)
				throw new ArgumentNullException ("textField");
			if (text == null)
				throw new ArgumentNullException ("text");
			var nstext = NSString.CreateNative (text);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_NSRange_IntPtr (this.Handle, selTextFieldShouldChangeCharactersInRangeReplacementString_Handle, textField.Handle, range, nstext);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_NSRange_IntPtr (this.SuperHandle, selTextFieldShouldChangeCharactersInRangeReplacementString_Handle, textField.Handle, range, nstext);
			}
			NSString.ReleaseNative (nstext);
			
			return ret;
		}
		
		[Export ("textFieldShouldClear:")]
		[CompilerGenerated]
		public virtual bool TextFieldShouldClear (global::MonoTouch.UIKit.UITextField textField)
		{
			if (textField == null)
				throw new ArgumentNullException ("textField");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selTextFieldShouldClear_Handle, textField.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selTextFieldShouldClear_Handle, textField.Handle);
			}
		}
		
		[Export ("textFieldShouldReturn:")]
		[CompilerGenerated]
		public virtual bool TextFieldShouldReturn (global::MonoTouch.UIKit.UITextField textField)
		{
			if (textField == null)
				throw new ArgumentNullException ("textField");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selTextFieldShouldReturn_Handle, textField.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selTextFieldShouldReturn_Handle, textField.Handle);
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
		public PSPDFPasswordViewDelegate Delegate {
			get {
				return WeakDelegate as PSPDFPasswordViewDelegate;
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
		public virtual bool ShakeOnError {
			[Export ("shakeOnError", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShakeOnErrorHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShakeOnErrorHandle);
				}
			}
			
			[Export ("setShakeOnError:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShakeOnError_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShakeOnError_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_PasswordField_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UITextField PasswordField {
			[Export ("passwordField")]
			get {
				global::MonoTouch.UIKit.UITextField ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UITextField) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPasswordFieldHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UITextField) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPasswordFieldHandle));
				}
				MarkDirty ();
				__mt_PasswordField_var = ret;
				return ret;
			}
			
		}
		
		//
		// Events and properties from the delegate
		//
		
		_PSPDFPasswordViewDelegate EnsurePSPDFPasswordViewDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _PSPDFPasswordViewDelegate))){
				del = new _PSPDFPasswordViewDelegate ();
				WeakDelegate = del;
			}
			return (_PSPDFPasswordViewDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _PSPDFPasswordViewDelegate : KS_PSPDFKitBindings.PSPDFPasswordViewDelegate { 
			public _PSPDFPasswordViewDelegate () {}
			
			internal EventHandler<PSPDFPasswordViewEventEventArgs> didUnlockWithPassword;
			[Preserve (Conditional = true)]
			public override void DidUnlockWithPassword (KS_PSPDFKitBindings.PSPDFPasswordView passwordView, string password)
			{
				EventHandler<PSPDFPasswordViewEventEventArgs> handler = didUnlockWithPassword;
				if (handler != null){
					var args = new PSPDFPasswordViewEventEventArgs (password);
					handler (passwordView, args);
				}
			}
			
			internal EventHandler<PSPDFPasswordViewEventEventArgs> didFailToUnlockWithPassword;
			[Preserve (Conditional = true)]
			public override void DidFailToUnlockWithPassword (KS_PSPDFKitBindings.PSPDFPasswordView passwordView, string password)
			{
				EventHandler<PSPDFPasswordViewEventEventArgs> handler = didFailToUnlockWithPassword;
				if (handler != null){
					var args = new PSPDFPasswordViewEventEventArgs (password);
					handler (passwordView, args);
				}
			}
			
			internal PSPDFPasswordViewDel shouldlUnlockWithPassword;
			[Preserve (Conditional = true)]
			public override bool ShouldlUnlockWithPassword (KS_PSPDFKitBindings.PSPDFPasswordView passwordView, string password)
			{
				PSPDFPasswordViewDel handler = shouldlUnlockWithPassword;
				if (handler != null)
					return handler (passwordView, password);
				return true;
			}
			
			internal EventHandler<PSPDFPasswordViewEventEventArgs> willUnlockWithPassword;
			[Preserve (Conditional = true)]
			public override void WillUnlockWithPassword (KS_PSPDFKitBindings.PSPDFPasswordView passwordView, string password)
			{
				EventHandler<PSPDFPasswordViewEventEventArgs> handler = willUnlockWithPassword;
				if (handler != null){
					var args = new PSPDFPasswordViewEventEventArgs (password);
					handler (passwordView, args);
				}
			}
			
		}
		#pragma warning restore 672
		
		public event EventHandler<PSPDFPasswordViewEventEventArgs> DidUnlockWithPassword {
			add { EnsurePSPDFPasswordViewDelegate ().didUnlockWithPassword += value; }
			remove { EnsurePSPDFPasswordViewDelegate ().didUnlockWithPassword -= value; }
		}
		
		public event EventHandler<PSPDFPasswordViewEventEventArgs> DidFailToUnlockWithPassword {
			add { EnsurePSPDFPasswordViewDelegate ().didFailToUnlockWithPassword += value; }
			remove { EnsurePSPDFPasswordViewDelegate ().didFailToUnlockWithPassword -= value; }
		}
		
		public PSPDFPasswordViewDel ShouldlUnlockWithPassword {
			get { return EnsurePSPDFPasswordViewDelegate ().shouldlUnlockWithPassword; }
			set { EnsurePSPDFPasswordViewDelegate ().shouldlUnlockWithPassword = value; }
		}
		
		public event EventHandler<PSPDFPasswordViewEventEventArgs> WillUnlockWithPassword {
			add { EnsurePSPDFPasswordViewDelegate ().willUnlockWithPassword += value; }
			remove { EnsurePSPDFPasswordViewDelegate ().willUnlockWithPassword -= value; }
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Document_var = null;
				__mt_WeakDelegate_var = null;
				__mt_PasswordField_var = null;
			}
		}
	} /* class PSPDFPasswordView */
	
	
	//
	// EventArgs classes
	//
	public partial class PSPDFPasswordViewEventEventArgs : EventArgs {
		public PSPDFPasswordViewEventEventArgs (string password)
		{
			this.Password = password;
		}
		public string Password { get; set; }
	}
	
}
