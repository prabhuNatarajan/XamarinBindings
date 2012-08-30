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
	[Register("PSCollectionReusableView", true)]
	public unsafe partial class PSCollectionReusableView : MonoTouch.UIKit.UIView {
		static readonly IntPtr selReuseIdentifier = Selector.GetHandle ("reuseIdentifier");
		static readonly IntPtr selPrepareForReuse = Selector.GetHandle ("prepareForReuse");
		static readonly IntPtr selApplyLayoutAttributes_ = Selector.GetHandle ("applyLayoutAttributes:");
		static readonly IntPtr selWillTransitionFromLayoutToLayout_ = Selector.GetHandle ("willTransitionFromLayout:toLayout:");
		static readonly IntPtr selDidTransitionFromLayoutToLayout_ = Selector.GetHandle ("didTransitionFromLayout:toLayout:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSCollectionReusableView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSCollectionReusableView () : base (NSObjectFlag.Empty)
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
		public PSCollectionReusableView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSCollectionReusableView (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSCollectionReusableView (IntPtr handle) : base (handle) {}

		[Export ("prepareForReuse")]
		[CompilerGenerated]
		public virtual void PrepareForReuse ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPrepareForReuse);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selPrepareForReuse);
			}
		}
		
		[Export ("applyLayoutAttributes:")]
		[CompilerGenerated]
		public virtual void ApplyLayoutAttributes (PSCollectionViewLayoutAttributes layoutAttributes)
		{
			if (layoutAttributes == null)
				throw new ArgumentNullException ("layoutAttributes");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selApplyLayoutAttributes_, layoutAttributes.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selApplyLayoutAttributes_, layoutAttributes.Handle);
			}
		}
		
		[Export ("willTransitionFromLayout:toLayout:")]
		[CompilerGenerated]
		public virtual void WillTransitionFromLayoutToLayout (PSCollectionViewLayout oldLayout, PSCollectionViewLayout newLayout)
		{
			if (oldLayout == null)
				throw new ArgumentNullException ("oldLayout");
			if (newLayout == null)
				throw new ArgumentNullException ("newLayout");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selWillTransitionFromLayoutToLayout_, oldLayout.Handle, newLayout.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selWillTransitionFromLayoutToLayout_, oldLayout.Handle, newLayout.Handle);
			}
		}
		
		[Export ("didTransitionFromLayout:toLayout:")]
		[CompilerGenerated]
		public virtual void DidTransitionFromLayoutToLayout (PSCollectionViewLayout oldLayout, PSCollectionViewLayout newLayout)
		{
			if (oldLayout == null)
				throw new ArgumentNullException ("oldLayout");
			if (newLayout == null)
				throw new ArgumentNullException ("newLayout");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selDidTransitionFromLayoutToLayout_, oldLayout.Handle, newLayout.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selDidTransitionFromLayoutToLayout_, oldLayout.Handle, newLayout.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual string ReuseIdentifier {
			[Export ("reuseIdentifier", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selReuseIdentifier));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selReuseIdentifier));
				}
			}
			
		}
		
	} /* class PSCollectionReusableView */
}
