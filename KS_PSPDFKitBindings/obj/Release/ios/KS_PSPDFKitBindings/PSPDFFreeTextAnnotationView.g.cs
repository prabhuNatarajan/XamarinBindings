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
	[Register("PSPDFFreeTextAnnotationView", true)]
	public unsafe partial class PSPDFFreeTextAnnotationView : PSPDFHostingAnnotationView {
		[CompilerGenerated]
		const string selTextView = "textView";
		static readonly IntPtr selTextViewHandle = Selector.GetHandle ("textView");
		[CompilerGenerated]
		const string selSetTextView_ = "setTextView:";
		static readonly IntPtr selSetTextView_Handle = Selector.GetHandle ("setTextView:");
		[CompilerGenerated]
		const string selResizableView = "resizableView";
		static readonly IntPtr selResizableViewHandle = Selector.GetHandle ("resizableView");
		[CompilerGenerated]
		const string selSetResizableView_ = "setResizableView:";
		static readonly IntPtr selSetResizableView_Handle = Selector.GetHandle ("setResizableView:");
		[CompilerGenerated]
		const string selInitWithAnnotation_ = "initWithAnnotation:";
		static readonly IntPtr selInitWithAnnotation_Handle = Selector.GetHandle ("initWithAnnotation:");
		[CompilerGenerated]
		const string selBeginEditing = "beginEditing";
		static readonly IntPtr selBeginEditingHandle = Selector.GetHandle ("beginEditing");
		[CompilerGenerated]
		const string selEndEditing = "endEditing";
		static readonly IntPtr selEndEditingHandle = Selector.GetHandle ("endEditing");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFFreeTextAnnotationView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFFreeTextAnnotationView () : base (NSObjectFlag.Empty)
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
		public PSPDFFreeTextAnnotationView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFFreeTextAnnotationView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFFreeTextAnnotationView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithAnnotation:")]
		[CompilerGenerated]
		public PSPDFFreeTextAnnotationView (PSPDFFreeTextAnnotation freeTextAnnotation)
			: base (NSObjectFlag.Empty)
		{
			if (freeTextAnnotation == null)
				throw new ArgumentNullException ("freeTextAnnotation");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithAnnotation_Handle, freeTextAnnotation.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithAnnotation_Handle, freeTextAnnotation.Handle);
			}
		}
		
		[Export ("beginEditing")]
		[CompilerGenerated]
		public virtual void BeginEditing ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selBeginEditingHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selBeginEditingHandle);
			}
		}
		
		[Export ("endEditing")]
		[CompilerGenerated]
		public virtual void EndEditing ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selEndEditingHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selEndEditingHandle);
			}
		}
		
		[CompilerGenerated]
		object __mt_TextView_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UITextView TextView {
			[Export ("textView")]
			get {
				global::MonoTouch.UIKit.UITextView ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UITextView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTextViewHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UITextView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTextViewHandle));
				}
				MarkDirty ();
				__mt_TextView_var = ret;
				return ret;
			}
			
			[Export ("setTextView:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTextView_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTextView_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_TextView_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_ResizableView_var;
		[CompilerGenerated]
		public virtual PSPDFResizableView ResizableView {
			[Export ("resizableView")]
			get {
				PSPDFResizableView ret;
				if (IsDirectBinding) {
					ret = (PSPDFResizableView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selResizableViewHandle));
				} else {
					ret = (PSPDFResizableView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selResizableViewHandle));
				}
				MarkDirty ();
				__mt_ResizableView_var = ret;
				return ret;
			}
			
			[Export ("setResizableView:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetResizableView_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetResizableView_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_ResizableView_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_TextView_var = null;
				__mt_ResizableView_var = null;
			}
		}
	} /* class PSPDFFreeTextAnnotationView */
}
