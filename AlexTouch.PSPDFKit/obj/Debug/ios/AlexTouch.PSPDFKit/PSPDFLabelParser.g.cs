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
	[Register("PSPDFLabelParser", true)]
	public unsafe partial class PSPDFLabelParser : NSObject {
		static readonly IntPtr selLabels = Selector.GetHandle ("labels");
		static readonly IntPtr selInitWithDocument_ = Selector.GetHandle ("initWithDocument:");
		static readonly IntPtr selParseDocument = Selector.GetHandle ("parseDocument");
		static readonly IntPtr selPageLabelForPage_ = Selector.GetHandle ("pageLabelForPage:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFLabelParser");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFLabelParser () : base (NSObjectFlag.Empty)
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
		public PSPDFLabelParser (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFLabelParser (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFLabelParser (IntPtr handle) : base (handle) {}

		[Export ("initWithDocument:")]
		[CompilerGenerated]
		public PSPDFLabelParser (PSPDFDocument document) : base (NSObjectFlag.Empty)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithDocument_, document.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithDocument_, document.Handle);
			}
		}
		
		[Export ("parseDocument")]
		[CompilerGenerated]
		public virtual NSDictionary ParseDocument ()
		{
			if (IsDirectBinding) {
				return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParseDocument));
			} else {
				return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParseDocument));
			}
		}
		
		[Export ("pageLabelForPage:")]
		[CompilerGenerated]
		public virtual string PageLabelForPage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selPageLabelForPage_, page));
			} else {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selPageLabelForPage_, page));
			}
		}
		
		object __mt_labels_var;
		[CompilerGenerated]
		public virtual NSDictionary labels {
			[Export ("labels")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLabels));
				} else {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLabels));
				}
				MarkDirty ();
				__mt_labels_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_labels_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFLabelParser */
}
