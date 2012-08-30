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
using OpenTK;

namespace AlexTouch.PSPDFKit {
	[Register("PSPDFPasswordView", true)]
	public unsafe partial class PSPDFPasswordView : MonoTouch.UIKit.UIView {
		static readonly IntPtr selDocument = Selector.GetHandle ("document");
		static readonly IntPtr selSetDocument_ = Selector.GetHandle ("setDocument:");
		static readonly IntPtr selDelegate = Selector.GetHandle ("delegate");
		static readonly IntPtr selSetDelegate_ = Selector.GetHandle ("setDelegate:");
		static readonly IntPtr selShakeOnError = Selector.GetHandle ("shakeOnError");
		static readonly IntPtr selSetShakeOnError_ = Selector.GetHandle ("setShakeOnError:");
		static readonly IntPtr selBecomeFirstResponder = Selector.GetHandle ("becomeFirstResponder");
		static readonly IntPtr selTextFieldShouldBeginEditing_ = Selector.GetHandle ("textFieldShouldBeginEditing:");
		static readonly IntPtr selTextFieldDidBeginEditing_ = Selector.GetHandle ("textFieldDidBeginEditing:");
		static readonly IntPtr selTextFieldShouldEndEditing_ = Selector.GetHandle ("textFieldShouldEndEditing:");
		static readonly IntPtr selTextFieldDidEndEditing_ = Selector.GetHandle ("textFieldDidEndEditing:");
		static readonly IntPtr selTextFieldShouldChangeCharactersInRangeReplacementString_ = Selector.GetHandle ("textField:shouldChangeCharactersInRange:replacementString:");
		static readonly IntPtr selTextFieldShouldClear_ = Selector.GetHandle ("textFieldShouldClear:");
		static readonly IntPtr selTextFieldShouldReturn_ = Selector.GetHandle ("textFieldShouldReturn:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFPasswordView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFPasswordView () : base (NSObjectFlag.Empty)
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
		public PSPDFPasswordView (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFPasswordView (IntPtr handle) : base (handle) {}

		[Export ("becomeFirstResponder")]
		[CompilerGenerated]
		public new virtual bool BecomeFirstResponder ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selBecomeFirstResponder);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selBecomeFirstResponder);
			}
		}
		
		[Export ("textFieldShouldBeginEditing:")]
		[CompilerGenerated]
		public virtual bool TextFieldShouldBeginEditing (MonoTouch.UIKit.UITextField textField)
		{
			if (textField == null)
				throw new ArgumentNullException ("textField");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selTextFieldShouldBeginEditing_, textField.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selTextFieldShouldBeginEditing_, textField.Handle);
			}
		}
		
		[Export ("textFieldDidBeginEditing:")]
		[CompilerGenerated]
		public virtual void TextFieldDidBeginEditing (MonoTouch.UIKit.UITextField textField)
		{
			if (textField == null)
				throw new ArgumentNullException ("textField");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selTextFieldDidBeginEditing_, textField.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selTextFieldDidBeginEditing_, textField.Handle);
			}
		}
		
		[Export ("textFieldShouldEndEditing:")]
		[CompilerGenerated]
		public virtual bool TextFieldShouldEndEditing (MonoTouch.UIKit.UITextField textField)
		{
			if (textField == null)
				throw new ArgumentNullException ("textField");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selTextFieldShouldEndEditing_, textField.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selTextFieldShouldEndEditing_, textField.Handle);
			}
		}
		
		[Export ("textFieldDidEndEditing:")]
		[CompilerGenerated]
		public virtual void TextFieldDidEndEditing (MonoTouch.UIKit.UITextField textField)
		{
			if (textField == null)
				throw new ArgumentNullException ("textField");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selTextFieldDidEndEditing_, textField.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selTextFieldDidEndEditing_, textField.Handle);
			}
		}
		
		[Export ("textField:shouldChangeCharactersInRange:replacementString:")]
		[CompilerGenerated]
		public virtual bool TextFielShouldChangeCharactersInRange (MonoTouch.UIKit.UITextField textField, NSRange range, string text)
		{
			if (textField == null)
				throw new ArgumentNullException ("textField");
			if (text == null)
				throw new ArgumentNullException ("text");
			var nstext = NSString.CreateNative (text);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_NSRange_IntPtr (this.Handle, selTextFieldShouldChangeCharactersInRangeReplacementString_, textField.Handle, range, nstext);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_NSRange_IntPtr (this.SuperHandle, selTextFieldShouldChangeCharactersInRangeReplacementString_, textField.Handle, range, nstext);
			}
			NSString.ReleaseNative (nstext);
			
			return ret;
		}
		
		[Export ("textFieldShouldClear:")]
		[CompilerGenerated]
		public virtual bool TextFieldShouldClear (MonoTouch.UIKit.UITextField textField)
		{
			if (textField == null)
				throw new ArgumentNullException ("textField");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selTextFieldShouldClear_, textField.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selTextFieldShouldClear_, textField.Handle);
			}
		}
		
		[Export ("textFieldShouldReturn:")]
		[CompilerGenerated]
		public virtual bool TextFieldShouldReturn (MonoTouch.UIKit.UITextField textField)
		{
			if (textField == null)
				throw new ArgumentNullException ("textField");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selTextFieldShouldReturn_, textField.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selTextFieldShouldReturn_, textField.Handle);
			}
		}
		
		object __mt_Document_var;
		[CompilerGenerated]
		public virtual PSPDFDocument Document {
			[Export ("document")]
			get {
				PSPDFDocument ret;
				if (IsDirectBinding) {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocument));
				} else {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocument));
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
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDocument_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDocument_, value.Handle);
				}
				MarkDirty ();
				__mt_Document_var = value;
			}
		}
		
		[CompilerGenerated]
		public PSPDFPasswordViewDelegate Delegate {
			get { return WeakDelegate as PSPDFPasswordViewDelegate; }
			set { WeakDelegate = value; }
		}
		
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegate));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegate));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_, value == null ? IntPtr.Zero : value.Handle);
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
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShakeOnError);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShakeOnError);
				}
			}
			
			[Export ("setShakeOnError:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShakeOnError_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShakeOnError_, value);
				}
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_Document_var = null;
			__mt_WeakDelegate_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFPasswordView */
}
