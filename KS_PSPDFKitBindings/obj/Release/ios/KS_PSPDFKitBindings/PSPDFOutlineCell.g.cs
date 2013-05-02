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
	[Register("PSPDFOutlineCell", true)]
	public unsafe partial class PSPDFOutlineCell : global::MonoTouch.UIKit.UITableViewCell {
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selOutlineElement = "outlineElement";
		static readonly IntPtr selOutlineElementHandle = Selector.GetHandle ("outlineElement");
		[CompilerGenerated]
		const string selSetOutlineElement_ = "setOutlineElement:";
		static readonly IntPtr selSetOutlineElement_Handle = Selector.GetHandle ("setOutlineElement:");
		[CompilerGenerated]
		const string selDisclosureButton = "disclosureButton";
		static readonly IntPtr selDisclosureButtonHandle = Selector.GetHandle ("disclosureButton");
		[CompilerGenerated]
		const string selSetDisclosureButton_ = "setDisclosureButton:";
		static readonly IntPtr selSetDisclosureButton_Handle = Selector.GetHandle ("setDisclosureButton:");
		[CompilerGenerated]
		const string selOutlineIntentLeftOffset = "outlineIntentLeftOffset";
		static readonly IntPtr selOutlineIntentLeftOffsetHandle = Selector.GetHandle ("outlineIntentLeftOffset");
		[CompilerGenerated]
		const string selSetOutlineIntentLeftOffset_ = "setOutlineIntentLeftOffset:";
		static readonly IntPtr selSetOutlineIntentLeftOffset_Handle = Selector.GetHandle ("setOutlineIntentLeftOffset:");
		[CompilerGenerated]
		const string selOutlineIndentMultiplier = "outlineIndentMultiplier";
		static readonly IntPtr selOutlineIndentMultiplierHandle = Selector.GetHandle ("outlineIndentMultiplier");
		[CompilerGenerated]
		const string selSetOutlineIndentMultiplier_ = "setOutlineIndentMultiplier:";
		static readonly IntPtr selSetOutlineIndentMultiplier_Handle = Selector.GetHandle ("setOutlineIndentMultiplier:");
		[CompilerGenerated]
		const string selHeightForCellWithOutlineElementConstrainedToSizeOutlineIntentLeftOffsetOutlineIntentMultiplier_ = "heightForCellWithOutlineElement:constrainedToSize:outlineIntentLeftOffset:outlineIntentMultiplier:";
		static readonly IntPtr selHeightForCellWithOutlineElementConstrainedToSizeOutlineIntentLeftOffsetOutlineIntentMultiplier_Handle = Selector.GetHandle ("heightForCellWithOutlineElement:constrainedToSize:outlineIntentLeftOffset:outlineIntentMultiplier:");
		[CompilerGenerated]
		const string selFontForOutlineElement_ = "fontForOutlineElement:";
		static readonly IntPtr selFontForOutlineElement_Handle = Selector.GetHandle ("fontForOutlineElement:");
		[CompilerGenerated]
		const string selUpdateOutlineButton = "updateOutlineButton";
		static readonly IntPtr selUpdateOutlineButtonHandle = Selector.GetHandle ("updateOutlineButton");
		[CompilerGenerated]
		const string selExpandOrCollapse = "expandOrCollapse";
		static readonly IntPtr selExpandOrCollapseHandle = Selector.GetHandle ("expandOrCollapse");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFOutlineCell");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFOutlineCell () : base (NSObjectFlag.Empty)
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
		public PSPDFOutlineCell (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFOutlineCell (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFOutlineCell (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("heightForCellWithOutlineElement:constrainedToSize:outlineIntentLeftOffset:outlineIntentMultiplier:")]
		[CompilerGenerated]
		public static float HeightForCellWithOutlineElement (PSPDFOutlineElement outlineElement, global::System.Drawing.SizeF constraintSize, float leftOffset, float multiplier)
		{
			if (outlineElement == null)
				throw new ArgumentNullException ("outlineElement");
			return ApiDefinition.Messaging.float_objc_msgSend_IntPtr_SizeF_float_float (class_ptr, selHeightForCellWithOutlineElementConstrainedToSizeOutlineIntentLeftOffsetOutlineIntentMultiplier_Handle, outlineElement.Handle, constraintSize, leftOffset, multiplier);
		}
		
		[Export ("fontForOutlineElement:")]
		[CompilerGenerated]
		public static global::MonoTouch.UIKit.UIFont FontForOutlineElement (PSPDFOutlineElement outlineElement)
		{
			if (outlineElement == null)
				throw new ArgumentNullException ("outlineElement");
			return (global::MonoTouch.UIKit.UIFont) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selFontForOutlineElement_Handle, outlineElement.Handle));
		}
		
		[Export ("updateOutlineButton")]
		[CompilerGenerated]
		public virtual void UpdateOutlineButton ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateOutlineButtonHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selUpdateOutlineButtonHandle);
			}
		}
		
		[Export ("expandOrCollapse")]
		[CompilerGenerated]
		public virtual void ExpandOrCollapse ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selExpandOrCollapseHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selExpandOrCollapseHandle);
			}
		}
		
		[CompilerGenerated]
		public PSPDFOutlineCellDelegate Delegate {
			get {
				return WeakDelegate as PSPDFOutlineCellDelegate;
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
		object __mt_OutlineElement_var;
		[CompilerGenerated]
		public virtual PSPDFOutlineElement OutlineElement {
			[Export ("outlineElement")]
			get {
				PSPDFOutlineElement ret;
				if (IsDirectBinding) {
					ret = (PSPDFOutlineElement) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOutlineElementHandle));
				} else {
					ret = (PSPDFOutlineElement) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOutlineElementHandle));
				}
				MarkDirty ();
				__mt_OutlineElement_var = ret;
				return ret;
			}
			
			[Export ("setOutlineElement:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetOutlineElement_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetOutlineElement_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_OutlineElement_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_DisclosureButton_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIButton DisclosureButton {
			[Export ("disclosureButton")]
			get {
				global::MonoTouch.UIKit.UIButton ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIButton) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDisclosureButtonHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIButton) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDisclosureButtonHandle));
				}
				MarkDirty ();
				__mt_DisclosureButton_var = ret;
				return ret;
			}
			
			[Export ("setDisclosureButton:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDisclosureButton_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDisclosureButton_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_DisclosureButton_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual float OutlineIntentLeftOffset {
			[Export ("outlineIntentLeftOffset", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selOutlineIntentLeftOffsetHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selOutlineIntentLeftOffsetHandle);
				}
			}
			
			[Export ("setOutlineIntentLeftOffset:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetOutlineIntentLeftOffset_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetOutlineIntentLeftOffset_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float OutlineIndentMultiplier {
			[Export ("outlineIndentMultiplier", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selOutlineIndentMultiplierHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selOutlineIndentMultiplierHandle);
				}
			}
			
			[Export ("setOutlineIndentMultiplier:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetOutlineIndentMultiplier_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetOutlineIndentMultiplier_Handle, value);
				}
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
				__mt_OutlineElement_var = null;
				__mt_DisclosureButton_var = null;
			}
		}
	} /* class PSPDFOutlineCell */
}
