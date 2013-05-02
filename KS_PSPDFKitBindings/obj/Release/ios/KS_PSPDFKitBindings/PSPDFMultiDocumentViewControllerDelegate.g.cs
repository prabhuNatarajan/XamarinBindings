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
	[Register("PSPDFMultiDocumentViewControllerDelegate", true)]
	[Model]
	public unsafe partial class PSPDFMultiDocumentViewControllerDelegate : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSObject");
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFMultiDocumentViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		public PSPDFMultiDocumentViewControllerDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFMultiDocumentViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFMultiDocumentViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("multiPDFController:shouldChangeDocuments:")]
		[CompilerGenerated]
		public virtual bool ShouldChangeDocuments (PSPDFMultiDocumentViewController multiPDFController, PSPDFDocument[] newDocuments)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("multiPDFController:didChangeDocuments:")]
		[CompilerGenerated]
		public virtual void DidChangeDocuments (PSPDFMultiDocumentViewController multiPDFController, PSPDFDocument[] oldDocuments)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("multiPDFController:shouldChangeVisibleDocument:")]
		[CompilerGenerated]
		public virtual bool ShouldChangeVisibleDocument (PSPDFMultiDocumentViewController multiPDFController, PSPDFDocument newDocument)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("multiPDFController:didChangeVisibleDocument:")]
		[CompilerGenerated]
		public virtual void DidChangeVisibleDocument (PSPDFMultiDocumentViewController multiPDFController, PSPDFDocument oldDocument)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFMultiDocumentViewControllerDelegate */
}
