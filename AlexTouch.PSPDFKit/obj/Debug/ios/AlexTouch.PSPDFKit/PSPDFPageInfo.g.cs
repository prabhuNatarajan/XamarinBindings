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
	[Register("PSPDFPageInfo", true)]
	public unsafe partial class PSPDFPageInfo : NSObject {
		static readonly IntPtr selPageRect = Selector.GetHandle ("pageRect");
		static readonly IntPtr selRotatedPageRect = Selector.GetHandle ("rotatedPageRect");
		static readonly IntPtr selPageRotation = Selector.GetHandle ("pageRotation");
		static readonly IntPtr selPageRotationTransform = Selector.GetHandle ("pageRotationTransform");
		static readonly IntPtr selPage = Selector.GetHandle ("page");
		static readonly IntPtr selDocument = Selector.GetHandle ("document");
		static readonly IntPtr selInitWithPageRectRotationDocument_ = Selector.GetHandle ("initWithPage:rect:rotation:document:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFPageInfo");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFPageInfo () : base (NSObjectFlag.Empty)
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
		public PSPDFPageInfo (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFPageInfo (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFPageInfo (IntPtr handle) : base (handle) {}

		[Export ("initWithPage:rect:rotation:document:")]
		[CompilerGenerated]
		public PSPDFPageInfo (System.UInt32 page, System.Drawing.RectangleF pageRect, int rotation, PSPDFDocument document) : base (NSObjectFlag.Empty)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_RectangleF_int_IntPtr (this.Handle, selInitWithPageRectRotationDocument_, page, pageRect, rotation, document.Handle);
			} else {
				Handle = ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32_RectangleF_int_IntPtr (this.SuperHandle, selInitWithPageRectRotationDocument_, page, pageRect, rotation, document.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual System.Drawing.RectangleF PageRect {
			[Export ("pageRect", ArgumentSemantic.Assign)]
			get {
				System.Drawing.RectangleF ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret (out ret, this.Handle, selPageRect);
				} else {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selPageRect);
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual System.Drawing.RectangleF RotatedPageRect {
			[Export ("rotatedPageRect", ArgumentSemantic.Assign)]
			get {
				System.Drawing.RectangleF ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret (out ret, this.Handle, selRotatedPageRect);
				} else {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selRotatedPageRect);
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual System.UInt32 PageRotation {
			[Export ("pageRotation", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPageRotation);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selPageRotation);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual CGAffineTransform pageRotationTransform {
			[Export ("pageRotationTransform", ArgumentSemantic.Assign)]
			get {
				CGAffineTransform ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret (out ret, this.Handle, selPageRotationTransform);
				} else {
					MonoTouch.ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper_stret (out ret, this.SuperHandle, selPageRotationTransform);
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual System.UInt32 Page {
			[Export ("page", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPage);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selPage);
				}
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
			
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_Document_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFPageInfo */
}
