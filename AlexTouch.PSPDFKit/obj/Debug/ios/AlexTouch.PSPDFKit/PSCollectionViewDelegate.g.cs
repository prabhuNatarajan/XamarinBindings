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
	[Register("PSCollectionViewDelegate", true)]
	[Model]
	public unsafe partial class PSCollectionViewDelegate : MonoTouch.UIKit.UIScrollViewDelegate {
		
		static readonly IntPtr class_ptr = Class.GetHandle ("NSObject");
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSCollectionViewDelegate () : base (NSObjectFlag.Empty)
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
		public PSCollectionViewDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSCollectionViewDelegate (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSCollectionViewDelegate (IntPtr handle) : base (handle) {}

		[Export ("collectionView:shouldHighlightItemAtIndexPath:")]
		[CompilerGenerated]
		public virtual bool ShouldHighlightItem (PSCollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("collectionView:didHighlightItemAtIndexPath:")]
		[CompilerGenerated]
		public virtual void DidHighlightItem (PSCollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("collectionView:didUnhighlightItemAtIndexPath:")]
		[CompilerGenerated]
		public virtual void DidUnhighlightItem (PSCollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("collectionView:shouldSelectItemAtIndexPath:")]
		[CompilerGenerated]
		public virtual bool ShouldSelectItem (PSCollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("collectionView:shouldDeselectItemAtIndexPath:")]
		[CompilerGenerated]
		public virtual bool ShouldDeselectItem (PSCollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("collectionView:didSelectItemAtIndexPath:")]
		[CompilerGenerated]
		public virtual void DidSelectItem (PSCollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("collectionView:didDeselectItemAtIndexPath:")]
		[CompilerGenerated]
		public virtual void DidDeselectItem (PSCollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("collectionView:didEndDisplayingCell:forItemAtIndexPath:")]
		[CompilerGenerated]
		public virtual void DidEndDisplayingCell (PSCollectionView collectionView, PSCollectionViewCell cell, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("collectionView:didEndDisplayingSupplementaryView:forElementOfKind:atIndexPath:")]
		[CompilerGenerated]
		public virtual void DidEndDisplayingSupplementaryView (PSCollectionView collectionView, PSCollectionReusableView view, string elementKind, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("collectionView:shouldShowMenuForItemAtIndexPath:")]
		[CompilerGenerated]
		public virtual bool ShouldShowMenuForItem (PSCollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("collectionView:canPerformAction:forItemAtIndexPath:withSender")]
		[CompilerGenerated]
		public virtual bool CanPerformAction (PSCollectionView collectionView, Selector action, NSIndexPath indexPath, NSObject sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("collectionView:performAction:forItemAtIndexPath:withSender")]
		[CompilerGenerated]
		public virtual void PerformAction (PSCollectionView collectionView, Selector action, NSIndexPath indexPath, NSObject sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSCollectionViewDelegate */
}
