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
	[Register("PSCollectionViewLayout", true)]
	public unsafe partial class PSCollectionViewLayout : NSObject {
		static readonly IntPtr selCollectionView = Selector.GetHandle ("collectionView");
		static readonly IntPtr selRegisterClassForDecorationViewWithReuseIdentifier_ = Selector.GetHandle ("registerClass:forDecorationViewWithReuseIdentifier:");
		static readonly IntPtr selRegisterNibForDecorationViewWithReuseIdentifier_ = Selector.GetHandle ("registerNib:forDecorationViewWithReuseIdentifier:");
		static readonly IntPtr selPrepareLayout = Selector.GetHandle ("prepareLayout");
		static readonly IntPtr selLayoutAttributesForElementsInRect_ = Selector.GetHandle ("layoutAttributesForElementsInRect:");
		static readonly IntPtr selLayoutAttributesForItemAtIndexPath_ = Selector.GetHandle ("layoutAttributesForItemAtIndexPath:");
		static readonly IntPtr selLayoutAttributesForSupplementaryViewOfKindAtIndexPath_ = Selector.GetHandle ("layoutAttributesForSupplementaryViewOfKind:atIndexPath:");
		static readonly IntPtr selLayoutAttributesForDecorationViewWithReuseIdentifierAtIndexPath_ = Selector.GetHandle ("layoutAttributesForDecorationViewWithReuseIdentifier:atIndexPath:");
		static readonly IntPtr selShouldInvalidateLayoutForBoundsChange_ = Selector.GetHandle ("shouldInvalidateLayoutForBoundsChange:");
		static readonly IntPtr selTargetContentOffsetForProposedContentOffsetWithScrollingVelocity_ = Selector.GetHandle ("targetContentOffsetForProposedContentOffset:withScrollingVelocity:");
		static readonly IntPtr selCollectionViewContentSize = Selector.GetHandle ("collectionViewContentSize");
		static readonly IntPtr selPrepareForCollectionViewUpdates_ = Selector.GetHandle ("prepareForCollectionViewUpdates:");
		static readonly IntPtr selFinalizeCollectionViewUpdates = Selector.GetHandle ("finalizeCollectionViewUpdates");
		static readonly IntPtr selInitialLayoutAttributesForInsertedItemAtIndexPath_ = Selector.GetHandle ("initialLayoutAttributesForInsertedItemAtIndexPath:");
		static readonly IntPtr selFinalLayoutAttributesForDeletedItemAtIndexPath_ = Selector.GetHandle ("finalLayoutAttributesForDeletedItemAtIndexPath:");
		static readonly IntPtr selFinalLayoutAttributesForDeletedSupplementaryElementOfKindAtIndexPath_ = Selector.GetHandle ("finalLayoutAttributesForDeletedSupplementaryElementOfKind:atIndexPath:");
		static readonly IntPtr selSetCollectionViewBoundsSize_ = Selector.GetHandle ("setCollectionViewBoundsSize:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSCollectionViewLayout");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSCollectionViewLayout () : base (NSObjectFlag.Empty)
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
		public PSCollectionViewLayout (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSCollectionViewLayout (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSCollectionViewLayout (IntPtr handle) : base (handle) {}

		[Export ("registerClass:forDecorationViewWithReuseIdentifier:")]
		[CompilerGenerated]
		public virtual void RegisterClass (Class c, NSString id)
		{
			if (c == null)
				throw new ArgumentNullException ("c");
			if (id == null)
				throw new ArgumentNullException ("id");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selRegisterClassForDecorationViewWithReuseIdentifier_, c.Handle, id.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selRegisterClassForDecorationViewWithReuseIdentifier_, c.Handle, id.Handle);
			}
		}
		
		[Export ("registerNib:forDecorationViewWithReuseIdentifier:")]
		[CompilerGenerated]
		public virtual void RegisterNib (MonoTouch.UIKit.UINib nib, NSString id)
		{
			if (nib == null)
				throw new ArgumentNullException ("nib");
			if (id == null)
				throw new ArgumentNullException ("id");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selRegisterNibForDecorationViewWithReuseIdentifier_, nib.Handle, id.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selRegisterNibForDecorationViewWithReuseIdentifier_, nib.Handle, id.Handle);
			}
		}
		
		[CompilerGenerated]
		public void PrepareLayout ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPrepareLayout);
		}
		
		[CompilerGenerated]
		public PSCollectionViewLayoutAttributes[] LayoutAttributesForElementsInRect (System.Drawing.RectangleF rect)
		{
			return NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSCollectionViewLayoutAttributes>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_RectangleF (this.Handle, selLayoutAttributesForElementsInRect_, rect));
		}
		
		[CompilerGenerated]
		public PSCollectionViewLayoutAttributes LayoutAttributesForElementsInRect (NSIndexPath indexPath)
		{
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			return (PSCollectionViewLayoutAttributes) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selLayoutAttributesForItemAtIndexPath_, indexPath.Handle));
		}
		
		[CompilerGenerated]
		public PSCollectionViewLayoutAttributes LayoutAttributesForElementsInRect (string kind, NSIndexPath indexPath)
		{
			if (kind == null)
				throw new ArgumentNullException ("kind");
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			var nskind = NSString.CreateNative (kind);
			
			PSCollectionViewLayoutAttributes ret;
			ret = (PSCollectionViewLayoutAttributes) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selLayoutAttributesForSupplementaryViewOfKindAtIndexPath_, nskind, indexPath.Handle));
			NSString.ReleaseNative (nskind);
			
			return ret;
		}
		
		[CompilerGenerated]
		public PSCollectionViewLayoutAttributes LayoutAttributesForDecorationViewWithReuseIdentifier (string identifier, NSIndexPath indexPath)
		{
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			var nsidentifier = NSString.CreateNative (identifier);
			
			PSCollectionViewLayoutAttributes ret;
			ret = (PSCollectionViewLayoutAttributes) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selLayoutAttributesForDecorationViewWithReuseIdentifierAtIndexPath_, nsidentifier, indexPath.Handle));
			NSString.ReleaseNative (nsidentifier);
			
			return ret;
		}
		
		[CompilerGenerated]
		public bool ShouldInvalidateLayoutForBoundsChange (System.Drawing.RectangleF newBounds)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend_RectangleF (this.Handle, selShouldInvalidateLayoutForBoundsChange_, newBounds);
		}
		
		[CompilerGenerated]
		public System.Drawing.PointF TargetContentOffsetForProposedContentOffset (System.Drawing.PointF proposedContentOffset, System.Drawing.PointF velocity)
		{
			System.Drawing.PointF ret;
			if (Runtime.Arch == Arch.DEVICE){
				ApiDefinition.Messaging.PointF_objc_msgSend_stret_PointF_PointF (out ret, this.Handle, selTargetContentOffsetForProposedContentOffsetWithScrollingVelocity_, proposedContentOffset, velocity);
			} else {
				ret = ApiDefinition.Messaging.PointF_objc_msgSend_PointF_PointF (this.Handle, selTargetContentOffsetForProposedContentOffsetWithScrollingVelocity_, proposedContentOffset, velocity);
			}
			return ret;
		}
		
		[CompilerGenerated]
		public System.Drawing.SizeF CollectionViewContentSize ()
		{
			System.Drawing.SizeF ret;
			if (Runtime.Arch == Arch.DEVICE){
				MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend_stret (out ret, this.Handle, selCollectionViewContentSize);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend (this.Handle, selCollectionViewContentSize);
			}
			return ret;
		}
		
		[CompilerGenerated]
		public void PrepareForCollectionViewUpdates (PSCollectionViewUpdateItem[] updateItems)
		{
			if (updateItems == null)
				throw new ArgumentNullException ("updateItems");
			var nsa_updateItems = NSArray.FromNSObjects (updateItems);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selPrepareForCollectionViewUpdates_, nsa_updateItems.Handle);
			nsa_updateItems.Dispose ();
			
		}
		
		[CompilerGenerated]
		public void FinalizeCollectionViewUpdates ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selFinalizeCollectionViewUpdates);
		}
		
		[CompilerGenerated]
		public PSCollectionViewLayoutAttributes InitialLayoutAttributesForInsertedItemAtIndexPath (NSIndexPath itemIndexPath)
		{
			if (itemIndexPath == null)
				throw new ArgumentNullException ("itemIndexPath");
			return (PSCollectionViewLayoutAttributes) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitialLayoutAttributesForInsertedItemAtIndexPath_, itemIndexPath.Handle));
		}
		
		[CompilerGenerated]
		public PSCollectionViewLayoutAttributes FinalLayoutAttributesForDeletedItemAtIndexPath (NSIndexPath itemIndexPath)
		{
			if (itemIndexPath == null)
				throw new ArgumentNullException ("itemIndexPath");
			return (PSCollectionViewLayoutAttributes) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selFinalLayoutAttributesForDeletedItemAtIndexPath_, itemIndexPath.Handle));
		}
		
		[CompilerGenerated]
		public PSCollectionViewLayoutAttributes FinalLayoutAttributesForDeletedSupplementaryElementOfKind (string elementKind, NSIndexPath elementIndexPath)
		{
			if (elementKind == null)
				throw new ArgumentNullException ("elementKind");
			if (elementIndexPath == null)
				throw new ArgumentNullException ("elementIndexPath");
			var nselementKind = NSString.CreateNative (elementKind);
			
			PSCollectionViewLayoutAttributes ret;
			ret = (PSCollectionViewLayoutAttributes) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selFinalLayoutAttributesForDeletedSupplementaryElementOfKindAtIndexPath_, nselementKind, elementIndexPath.Handle));
			NSString.ReleaseNative (nselementKind);
			
			return ret;
		}
		
		[CompilerGenerated]
		public void SetCollectionViewBoundsSize (System.Drawing.SizeF size)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_SizeF (this.Handle, selSetCollectionViewBoundsSize_, size);
		}
		
		object __mt_CollectionView_var;
		[CompilerGenerated]
		public virtual PSCollectionView CollectionView {
			[Export ("collectionView")]
			get {
				PSCollectionView ret;
				if (IsDirectBinding) {
					ret = (PSCollectionView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCollectionView));
				} else {
					ret = (PSCollectionView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCollectionView));
				}
				MarkDirty ();
				__mt_CollectionView_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_CollectionView_var = null;
			base.Dispose (disposing);
		}
	} /* class PSCollectionViewLayout */
}
