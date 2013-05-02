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
	[Register("PSPDFAnnotationBarButtonItem", true)]
	public unsafe partial class PSPDFAnnotationBarButtonItem : PSPDFBarButtonItem {
		[CompilerGenerated]
		const string selAnnotationToolbar = "annotationToolbar";
		static readonly IntPtr selAnnotationToolbarHandle = Selector.GetHandle ("annotationToolbar");
		[CompilerGenerated]
		const string selIsAvailableBlocking = "isAvailableBlocking";
		static readonly IntPtr selIsAvailableBlockingHandle = Selector.GetHandle ("isAvailableBlocking");
		[CompilerGenerated]
		const string selTargetToolbarForBarButtonItem_ = "targetToolbarForBarButtonItem:";
		static readonly IntPtr selTargetToolbarForBarButtonItem_Handle = Selector.GetHandle ("targetToolbarForBarButtonItem:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFAnnotationBarButtonItem");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFAnnotationBarButtonItem () : base (NSObjectFlag.Empty)
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
		public PSPDFAnnotationBarButtonItem (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFAnnotationBarButtonItem (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFAnnotationBarButtonItem (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("isAvailableBlocking")]
		[CompilerGenerated]
		public virtual bool IsAvailableBlocking ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAvailableBlockingHandle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsAvailableBlockingHandle);
			}
		}
		
		[Export ("targetToolbarForBarButtonItem:")]
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIView TargetToolbarForBarButtonItem (global::MonoTouch.UIKit.UIBarButtonItem barButtonItem)
		{
			if (barButtonItem == null)
				throw new ArgumentNullException ("barButtonItem");
			if (IsDirectBinding) {
				return (global::MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selTargetToolbarForBarButtonItem_Handle, barButtonItem.Handle));
			} else {
				return (global::MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selTargetToolbarForBarButtonItem_Handle, barButtonItem.Handle));
			}
		}
		
		[CompilerGenerated]
		object __mt_AnnotationToolbar_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotationToolbar AnnotationToolbar {
			[Export ("annotationToolbar")]
			get {
				PSPDFAnnotationToolbar ret;
				if (IsDirectBinding) {
					ret = (PSPDFAnnotationToolbar) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAnnotationToolbarHandle));
				} else {
					ret = (PSPDFAnnotationToolbar) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAnnotationToolbarHandle));
				}
				MarkDirty ();
				__mt_AnnotationToolbar_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AnnotationToolbar_var = null;
			}
		}
	} /* class PSPDFAnnotationBarButtonItem */
}
