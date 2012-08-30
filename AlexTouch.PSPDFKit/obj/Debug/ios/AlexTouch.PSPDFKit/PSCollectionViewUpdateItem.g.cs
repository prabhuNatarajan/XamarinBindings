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
	[Register("PSCollectionViewUpdateItem", true)]
	public unsafe partial class PSCollectionViewUpdateItem : NSObject {
		static readonly IntPtr selIndexPathBeforeUpdate = Selector.GetHandle ("indexPathBeforeUpdate");
		static readonly IntPtr selIndexPathAfterUpdate = Selector.GetHandle ("indexPathAfterUpdate");
		static readonly IntPtr selUpdateAction = Selector.GetHandle ("updateAction");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSCollectionViewUpdateItem");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSCollectionViewUpdateItem () : base (NSObjectFlag.Empty)
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
		public PSCollectionViewUpdateItem (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSCollectionViewUpdateItem (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSCollectionViewUpdateItem (IntPtr handle) : base (handle) {}

		object __mt_IndexPathBeforeUpdate_var;
		[CompilerGenerated]
		public virtual NSIndexPath IndexPathBeforeUpdate {
			[Export ("indexPathBeforeUpdate")]
			get {
				NSIndexPath ret;
				if (IsDirectBinding) {
					ret = (NSIndexPath) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selIndexPathBeforeUpdate));
				} else {
					ret = (NSIndexPath) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selIndexPathBeforeUpdate));
				}
				MarkDirty ();
				__mt_IndexPathBeforeUpdate_var = ret;
				return ret;
			}
			
		}
		
		object __mt_IndexPathAfterUpdate_var;
		[CompilerGenerated]
		public virtual NSIndexPath IndexPathAfterUpdate {
			[Export ("indexPathAfterUpdate")]
			get {
				NSIndexPath ret;
				if (IsDirectBinding) {
					ret = (NSIndexPath) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selIndexPathAfterUpdate));
				} else {
					ret = (NSIndexPath) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selIndexPathAfterUpdate));
				}
				MarkDirty ();
				__mt_IndexPathAfterUpdate_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSCollectionUpdateAction UpdateAction {
			[Export ("updateAction")]
			get {
				if (IsDirectBinding) {
					return (PSCollectionUpdateAction) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selUpdateAction);
				} else {
					return (PSCollectionUpdateAction) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selUpdateAction);
				}
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_IndexPathBeforeUpdate_var = null;
			__mt_IndexPathAfterUpdate_var = null;
			base.Dispose (disposing);
		}
	} /* class PSCollectionViewUpdateItem */
}
