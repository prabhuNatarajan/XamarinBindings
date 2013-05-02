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
	[Register("PSPDFColorView", true)]
	public unsafe partial class PSPDFColorView : global::MonoTouch.UIKit.UIControl {
		[CompilerGenerated]
		const string selColor = "color";
		static readonly IntPtr selColorHandle = Selector.GetHandle ("color");
		[CompilerGenerated]
		const string selSetColor_ = "setColor:";
		static readonly IntPtr selSetColor_Handle = Selector.GetHandle ("setColor:");
		[CompilerGenerated]
		const string selBorderStyle = "borderStyle";
		static readonly IntPtr selBorderStyleHandle = Selector.GetHandle ("borderStyle");
		[CompilerGenerated]
		const string selSetBorderStyle_ = "setBorderStyle:";
		static readonly IntPtr selSetBorderStyle_Handle = Selector.GetHandle ("setBorderStyle:");
		[CompilerGenerated]
		const string selColorViewWithColorBorderStyle_ = "colorViewWithColor:borderStyle:";
		static readonly IntPtr selColorViewWithColorBorderStyle_Handle = Selector.GetHandle ("colorViewWithColor:borderStyle:");
		[CompilerGenerated]
		const string selSetSelectedAnimated_ = "setSelected:animated:";
		static readonly IntPtr selSetSelectedAnimated_Handle = Selector.GetHandle ("setSelected:animated:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFColorView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFColorView () : base (NSObjectFlag.Empty)
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
		public PSPDFColorView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFColorView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFColorView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("colorViewWithColor:borderStyle:")]
		[CompilerGenerated]
		public static PSPDFColorView ColorViewWithColor (global::MonoTouch.UIKit.UIColor color, PSPDFColorViewBorderStyle borderStyle)
		{
			if (color == null)
				throw new ArgumentNullException ("color");
			return (PSPDFColorView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_int (class_ptr, selColorViewWithColorBorderStyle_Handle, color.Handle, (int)borderStyle));
		}
		
		[Export ("setSelected:animated:")]
		[CompilerGenerated]
		public virtual void SetSelected (bool selected, bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool_bool (this.Handle, selSetSelectedAnimated_Handle, selected, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_bool (this.SuperHandle, selSetSelectedAnimated_Handle, selected, animated);
			}
		}
		
		[CompilerGenerated]
		object __mt_Color_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor Color {
			[Export ("color")]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selColorHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selColorHandle));
				}
				MarkDirty ();
				__mt_Color_var = ret;
				return ret;
			}
			
			[Export ("setColor:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetColor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetColor_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Color_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFColorViewBorderStyle BorderStyle {
			[Export ("borderStyle", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFColorViewBorderStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selBorderStyleHandle);
				} else {
					return (PSPDFColorViewBorderStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selBorderStyleHandle);
				}
			}
			
			[Export ("setBorderStyle:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetBorderStyle_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetBorderStyle_Handle, (int)value);
				}
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Color_var = null;
			}
		}
	} /* class PSPDFColorView */
}
