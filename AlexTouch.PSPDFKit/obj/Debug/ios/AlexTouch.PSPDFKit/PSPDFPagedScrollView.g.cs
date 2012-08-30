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
	[Register("PSPDFPagedScrollView", true)]
	public unsafe partial class PSPDFPagedScrollView : PSPDFScrollView {
		static readonly IntPtr selContentController = Selector.GetHandle ("contentController");
		static readonly IntPtr selInitWithTransitionViewController_ = Selector.GetHandle ("initWithTransitionViewController:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFPagedScrollView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFPagedScrollView () : base (NSObjectFlag.Empty)
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
		public PSPDFPagedScrollView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFPagedScrollView (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFPagedScrollView (IntPtr handle) : base (handle) {}

		[Export ("initWithTransitionViewController:")]
		[CompilerGenerated]
		public PSPDFPagedScrollView (MonoTouch.UIKit.UIViewController viewController) : base (NSObjectFlag.Empty)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithTransitionViewController_, viewController.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithTransitionViewController_, viewController.Handle);
			}
		}
		
		object __mt_ContentController_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIViewController ContentController {
			[Export ("contentController")]
			get {
				MonoTouch.UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selContentController));
				} else {
					ret = (MonoTouch.UIKit.UIViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selContentController));
				}
				MarkDirty ();
				__mt_ContentController_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_ContentController_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFPagedScrollView */
}
