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
	[Register("PSPDFOutlineViewController", true)]
	public unsafe partial class PSPDFOutlineViewController : MonoTouch.UIKit.UITableViewController {
		static readonly IntPtr selAllowCopy = Selector.GetHandle ("allowCopy");
		static readonly IntPtr selSetAllowCopy_ = Selector.GetHandle ("setAllowCopy:");
		static readonly IntPtr selMaximumNumberOfLines = Selector.GetHandle ("maximumNumberOfLines");
		static readonly IntPtr selSetMaximumNumberOfLines_ = Selector.GetHandle ("setMaximumNumberOfLines:");
		static readonly IntPtr selDelegate = Selector.GetHandle ("delegate");
		static readonly IntPtr selSetDelegate_ = Selector.GetHandle ("setDelegate:");
		static readonly IntPtr selDocument = Selector.GetHandle ("document");
		static readonly IntPtr selSetDocument_ = Selector.GetHandle ("setDocument:");
		static readonly IntPtr selInitWithDocumentDelegate_ = Selector.GetHandle ("initWithDocument:delegate:");
		static readonly IntPtr selUpdatePopoverSize = Selector.GetHandle ("updatePopoverSize");
		static readonly IntPtr selOutlineCellDidTapDisclosureButton_ = Selector.GetHandle ("outlineCellDidTapDisclosureButton:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFOutlineViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFOutlineViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFOutlineViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFOutlineViewController (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFOutlineViewController (IntPtr handle) : base (handle) {}

		[Export ("initWithDocument:delegate:")]
		[CompilerGenerated]
		public PSPDFOutlineViewController (PSPDFDocument document, PSPDFOutlineViewControllerDelegate Delegate) : base (NSObjectFlag.Empty)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (Delegate == null)
				throw new ArgumentNullException ("Delegate");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithDocumentDelegate_, document.Handle, Delegate.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithDocumentDelegate_, document.Handle, Delegate.Handle);
			}
		}
		
		[CompilerGenerated]
		public void UpdatePopoverSize ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdatePopoverSize);
		}
		
		[CompilerGenerated]
		public void OutlineCellDidTapDisclosureButton (PSPDFOutlineCell cell)
		{
			if (cell == null)
				throw new ArgumentNullException ("cell");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selOutlineCellDidTapDisclosureButton_, cell.Handle);
		}
		
		[CompilerGenerated]
		public virtual bool AllowCopy {
			[Export ("allowCopy", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowCopy);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAllowCopy);
				}
			}
			
			[Export ("setAllowCopy:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowCopy_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAllowCopy_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual System.UInt32 MaximumNumberOfLines {
			[Export ("maximumNumberOfLines", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selMaximumNumberOfLines);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selMaximumNumberOfLines);
				}
			}
			
			[Export ("setMaximumNumberOfLines:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetMaximumNumberOfLines_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetMaximumNumberOfLines_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public PSPDFOutlineViewControllerDelegate Delegate {
			get { return WeakDelegate as PSPDFOutlineViewControllerDelegate; }
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
		
		protected override void Dispose (bool disposing)
		{
			__mt_WeakDelegate_var = null;
			__mt_Document_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFOutlineViewController */
}
