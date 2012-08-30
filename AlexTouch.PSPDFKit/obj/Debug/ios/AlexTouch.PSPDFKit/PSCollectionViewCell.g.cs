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
	[Register("PSCollectionViewCell", true)]
	public unsafe partial class PSCollectionViewCell : PSCollectionReusableView {
		static readonly IntPtr selContentView = Selector.GetHandle ("contentView");
		static readonly IntPtr selIsSelected = Selector.GetHandle ("isSelected");
		static readonly IntPtr selSetSelected_ = Selector.GetHandle ("setSelected:");
		static readonly IntPtr selIsHighlighted = Selector.GetHandle ("isHighlighted");
		static readonly IntPtr selSetHighlighted_ = Selector.GetHandle ("setHighlighted:");
		static readonly IntPtr selBackgroundView = Selector.GetHandle ("backgroundView");
		static readonly IntPtr selSetBackgroundView_ = Selector.GetHandle ("setBackgroundView:");
		static readonly IntPtr selSelectedBackgroundView = Selector.GetHandle ("selectedBackgroundView");
		static readonly IntPtr selSetSelectedBackgroundView_ = Selector.GetHandle ("setSelectedBackgroundView:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSCollectionViewCell");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSCollectionViewCell () : base (NSObjectFlag.Empty)
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
		public PSCollectionViewCell (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSCollectionViewCell (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSCollectionViewCell (IntPtr handle) : base (handle) {}

		object __mt_ContentView_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIView ContentView {
			[Export ("contentView")]
			get {
				MonoTouch.UIKit.UIView ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selContentView));
				} else {
					ret = (MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selContentView));
				}
				MarkDirty ();
				__mt_ContentView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool Selected {
			[Export ("isSelected")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSelected);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsSelected);
				}
			}
			
			[Export ("setSelected:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSelected_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetSelected_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Highlighted {
			[Export ("isHighlighted")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsHighlighted);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsHighlighted);
				}
			}
			
			[Export ("setHighlighted:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHighlighted_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetHighlighted_, value);
				}
			}
		}
		
		object __mt_BackgroundView_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIView BackgroundView {
			[Export ("backgroundView")]
			get {
				MonoTouch.UIKit.UIView ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBackgroundView));
				} else {
					ret = (MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBackgroundView));
				}
				MarkDirty ();
				__mt_BackgroundView_var = ret;
				return ret;
			}
			
			[Export ("setBackgroundView:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBackgroundView_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBackgroundView_, value.Handle);
				}
				MarkDirty ();
				__mt_BackgroundView_var = value;
			}
		}
		
		object __mt_SelectedBackgroundView_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIView SelectedBackgroundView {
			[Export ("selectedBackgroundView")]
			get {
				MonoTouch.UIKit.UIView ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectedBackgroundView));
				} else {
					ret = (MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSelectedBackgroundView));
				}
				MarkDirty ();
				__mt_SelectedBackgroundView_var = ret;
				return ret;
			}
			
			[Export ("setSelectedBackgroundView:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSelectedBackgroundView_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSelectedBackgroundView_, value.Handle);
				}
				MarkDirty ();
				__mt_SelectedBackgroundView_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_ContentView_var = null;
			__mt_BackgroundView_var = null;
			__mt_SelectedBackgroundView_var = null;
			base.Dispose (disposing);
		}
	} /* class PSCollectionViewCell */
}
