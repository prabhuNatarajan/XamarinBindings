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
	[Register("PSPDFNoteAnnotation", true)]
	public unsafe partial class PSPDFNoteAnnotation : PSPDFAnnotation {
		[CompilerGenerated]
		const string selIconName = "iconName";
		static readonly IntPtr selIconNameHandle = Selector.GetHandle ("iconName");
		[CompilerGenerated]
		const string selSetIconName_ = "setIconName:";
		static readonly IntPtr selSetIconName_Handle = Selector.GetHandle ("setIconName:");
		[CompilerGenerated]
		const string selHitTestWithViewBounds_ = "hitTest:withViewBounds:";
		static readonly IntPtr selHitTestWithViewBounds_Handle = Selector.GetHandle ("hitTest:withViewBounds:");
		[CompilerGenerated]
		const string selBoundingBoxForPageViewBounds_ = "boundingBoxForPageViewBounds:";
		static readonly IntPtr selBoundingBoxForPageViewBounds_Handle = Selector.GetHandle ("boundingBoxForPageViewBounds:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFNoteAnnotation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFNoteAnnotation () : base (NSObjectFlag.Empty)
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
		public PSPDFNoteAnnotation (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFNoteAnnotation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFNoteAnnotation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("hitTest:withViewBounds:")]
		[CompilerGenerated]
		public virtual bool HitTestWithViewBounds (global::System.Drawing.PointF point, global::System.Drawing.RectangleF bounds)
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend_PointF_RectangleF (this.Handle, selHitTestWithViewBounds_Handle, point, bounds);
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper_PointF_RectangleF (this.SuperHandle, selHitTestWithViewBounds_Handle, point, bounds);
			}
		}
		
		[Export ("boundingBoxForPageViewBounds:")]
		[CompilerGenerated]
		public virtual global::System.Drawing.RectangleF BoundingBoxForPageViewBounds (global::System.Drawing.RectangleF pageBounds)
		{
			global::System.Drawing.RectangleF ret;
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret_RectangleF (out ret, this.Handle, selBoundingBoxForPageViewBounds_Handle, pageBounds);
			} else {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret_RectangleF (out ret, this.SuperHandle, selBoundingBoxForPageViewBounds_Handle, pageBounds);
			}
			return ret;
		}
		
		[CompilerGenerated]
		public virtual string IconName {
			[Export ("iconName", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selIconNameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selIconNameHandle));
				}
			}
			
			[Export ("setIconName:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetIconName_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetIconName_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
	} /* class PSPDFNoteAnnotation */
}
