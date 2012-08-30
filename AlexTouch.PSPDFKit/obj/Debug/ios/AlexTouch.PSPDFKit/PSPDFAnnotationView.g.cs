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
	[Register("PSPDFAnnotationView", true)]
	public unsafe partial class PSPDFAnnotationView : NSObject {
		static readonly IntPtr selAnnotation = Selector.GetHandle ("annotation");
		static readonly IntPtr selSetAnnotation_ = Selector.GetHandle ("setAnnotation:");
		static readonly IntPtr selWillShowPage_ = Selector.GetHandle ("willShowPage:");
		static readonly IntPtr selDidShowPage_ = Selector.GetHandle ("didShowPage:");
		static readonly IntPtr selWillHidePage_ = Selector.GetHandle ("willHidePage:");
		static readonly IntPtr selDidHidePage_ = Selector.GetHandle ("didHidePage:");
		static readonly IntPtr selDidChangePageFrame_ = Selector.GetHandle ("didChangePageFrame:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFAnnotationView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFAnnotationView () : base (NSObjectFlag.Empty)
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
		public PSPDFAnnotationView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFAnnotationView (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFAnnotationView (IntPtr handle) : base (handle) {}

		[Export ("willShowPage:")]
		[CompilerGenerated]
		public virtual void WillShowPage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selWillShowPage_, page);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selWillShowPage_, page);
			}
		}
		
		[Export ("didShowPage:")]
		[CompilerGenerated]
		public virtual void DidShowPage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selDidShowPage_, page);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selDidShowPage_, page);
			}
		}
		
		[Export ("willHidePage:")]
		[CompilerGenerated]
		public virtual void WillHidePage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selWillHidePage_, page);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selWillHidePage_, page);
			}
		}
		
		[Export ("didHidePage:")]
		[CompilerGenerated]
		public virtual void DidHidePage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selDidHidePage_, page);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selDidHidePage_, page);
			}
		}
		
		[Export ("didChangePageFrame:")]
		[CompilerGenerated]
		public virtual void DidChangePageFrame (System.Drawing.Rectangle frame)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_Rectangle (this.Handle, selDidChangePageFrame_, frame);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_Rectangle (this.SuperHandle, selDidChangePageFrame_, frame);
			}
		}
		
		object __mt_Annotation_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotation Annotation {
			[Export ("annotation")]
			get {
				PSPDFAnnotation ret;
				if (IsDirectBinding) {
					ret = (PSPDFAnnotation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAnnotation));
				} else {
					ret = (PSPDFAnnotation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAnnotation));
				}
				MarkDirty ();
				__mt_Annotation_var = ret;
				return ret;
			}
			
			[Export ("setAnnotation:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAnnotation_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAnnotation_, value.Handle);
				}
				MarkDirty ();
				__mt_Annotation_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_Annotation_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFAnnotationView */
}
