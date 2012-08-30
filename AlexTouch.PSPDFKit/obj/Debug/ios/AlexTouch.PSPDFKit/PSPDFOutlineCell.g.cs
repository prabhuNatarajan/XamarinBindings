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
	[Register("PSPDFOutlineCell", true)]
	public unsafe partial class PSPDFOutlineCell : MonoTouch.UIKit.UITableViewCell {
		static readonly IntPtr selDelegate = Selector.GetHandle ("delegate");
		static readonly IntPtr selSetDelegate_ = Selector.GetHandle ("setDelegate:");
		static readonly IntPtr selDocument = Selector.GetHandle ("document");
		static readonly IntPtr selSetDocument_ = Selector.GetHandle ("setDocument:");
		static readonly IntPtr selOutlineElement = Selector.GetHandle ("outlineElement");
		static readonly IntPtr selSetOutlineElement_ = Selector.GetHandle ("setOutlineElement:");
		static readonly IntPtr selDisclosureButton = Selector.GetHandle ("disclosureButton");
		static readonly IntPtr selSetDisclosureButton_ = Selector.GetHandle ("setDisclosureButton:");
		static readonly IntPtr selHeightForCellWithOutlineElementConstrainedToSize_ = Selector.GetHandle ("heightForCellWithOutlineElement:constrainedToSize:");
		static readonly IntPtr selUpdateOutlineButton = Selector.GetHandle ("updateOutlineButton");
		static readonly IntPtr selExpandOrCollapse = Selector.GetHandle ("expandOrCollapse");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFOutlineCell");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFOutlineCell () : base (NSObjectFlag.Empty)
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
		public PSPDFOutlineCell (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFOutlineCell (IntPtr handle) : base (handle) {}

		[Export ("heightForCellWithOutlineElement:constrainedToSize:")]
		[CompilerGenerated]
		public static float HeightForCellWithOutlineElement (PSPDFOutlineElement outlineElement, System.Drawing.SizeF constraintSize)
		{
			if (outlineElement == null)
				throw new ArgumentNullException ("outlineElement");
			return ApiDefinition.Messaging.float_objc_msgSend_IntPtr_SizeF (class_ptr, selHeightForCellWithOutlineElementConstrainedToSize_, outlineElement.Handle, constraintSize);
		}
		
		[CompilerGenerated]
		public void UpdateOutlineButton ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateOutlineButton);
		}
		
		[CompilerGenerated]
		public void ExpandOrCollapse ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selExpandOrCollapse);
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
		
		object __mt_Document_var;
		[CompilerGenerated]
		public virtual PSPDFOutlineCellDelegate Document {
			[Export ("document")]
			get {
				PSPDFOutlineCellDelegate ret;
				if (IsDirectBinding) {
					ret = (PSPDFOutlineCellDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocument));
				} else {
					ret = (PSPDFOutlineCellDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocument));
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
		
		object __mt_OutlineElement_var;
		[CompilerGenerated]
		public virtual PSPDFOutlineElement OutlineElement {
			[Export ("outlineElement")]
			get {
				PSPDFOutlineElement ret;
				if (IsDirectBinding) {
					ret = (PSPDFOutlineElement) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOutlineElement));
				} else {
					ret = (PSPDFOutlineElement) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOutlineElement));
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
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetOutlineElement_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetOutlineElement_, value.Handle);
				}
				MarkDirty ();
				__mt_OutlineElement_var = value;
			}
		}
		
		object __mt_DisclosureButton_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIButton DisclosureButton {
			[Export ("disclosureButton")]
			get {
				MonoTouch.UIKit.UIButton ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIButton) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDisclosureButton));
				} else {
					ret = (MonoTouch.UIKit.UIButton) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDisclosureButton));
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
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDisclosureButton_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDisclosureButton_, value.Handle);
				}
				MarkDirty ();
				__mt_DisclosureButton_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_WeakDelegate_var = null;
			__mt_Document_var = null;
			__mt_OutlineElement_var = null;
			__mt_DisclosureButton_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFOutlineCell */
}
