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
	[Register("PSPDFViewState", true)]
	public unsafe partial class PSPDFViewState : NSObject {
		static readonly IntPtr selZoomScale = Selector.GetHandle ("zoomScale");
		static readonly IntPtr selSetZoomScale_ = Selector.GetHandle ("setZoomScale:");
		static readonly IntPtr selContentOffset = Selector.GetHandle ("contentOffset");
		static readonly IntPtr selSetContentOffset_ = Selector.GetHandle ("setContentOffset:");
		static readonly IntPtr selPage = Selector.GetHandle ("page");
		static readonly IntPtr selSetPage_ = Selector.GetHandle ("setPage:");
		static readonly IntPtr selIsHUDVisible = Selector.GetHandle ("isHUDVisible");
		static readonly IntPtr selSetHUDVisible_ = Selector.GetHandle ("setHUDVisible:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFViewState");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFViewState () : base (NSObjectFlag.Empty)
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
		public PSPDFViewState (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFViewState (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFViewState (IntPtr handle) : base (handle) {}

		[CompilerGenerated]
		public virtual float ZoomScale {
			[Export ("zoomScale", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selZoomScale);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selZoomScale);
				}
			}
			
			[Export ("setZoomScale:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetZoomScale_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetZoomScale_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual System.Drawing.PointF ContentOffset {
			[Export ("contentOffset", ArgumentSemantic.Assign)]
			get {
				System.Drawing.PointF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSend_stret (out ret, this.Handle, selContentOffset);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSend (this.Handle, selContentOffset);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selContentOffset);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSendSuper (this.SuperHandle, selContentOffset);
					}
				}
				return ret;
			}
			
			[Export ("setContentOffset:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_PointF (this.Handle, selSetContentOffset_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_PointF (this.SuperHandle, selSetContentOffset_, value);
				}
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
			
			[Export ("setPage:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetPage_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetPage_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool HUDVisible {
			[Export ("isHUDVisible", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsHUDVisible);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsHUDVisible);
				}
			}
			
			[Export ("setHUDVisible:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHUDVisible_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetHUDVisible_, value);
				}
			}
		}
		
	} /* class PSPDFViewState */
}
