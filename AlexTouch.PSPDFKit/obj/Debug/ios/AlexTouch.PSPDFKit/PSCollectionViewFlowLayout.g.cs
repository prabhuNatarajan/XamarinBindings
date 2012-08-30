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
	[Register("PSCollectionViewFlowLayout", true)]
	public unsafe partial class PSCollectionViewFlowLayout : PSCollectionViewLayout {
		static readonly IntPtr selMinimumLineSpacing = Selector.GetHandle ("minimumLineSpacing");
		static readonly IntPtr selSetMinimumLineSpacing_ = Selector.GetHandle ("setMinimumLineSpacing:");
		static readonly IntPtr selMinimumInteritemSpacing = Selector.GetHandle ("minimumInteritemSpacing");
		static readonly IntPtr selSetMinimumInteritemSpacing_ = Selector.GetHandle ("setMinimumInteritemSpacing:");
		static readonly IntPtr selItemSize = Selector.GetHandle ("itemSize");
		static readonly IntPtr selSetItemSize_ = Selector.GetHandle ("setItemSize:");
		static readonly IntPtr selScrollDirection = Selector.GetHandle ("scrollDirection");
		static readonly IntPtr selSetScrollDirection_ = Selector.GetHandle ("setScrollDirection:");
		static readonly IntPtr selHeaderReferenceSize = Selector.GetHandle ("headerReferenceSize");
		static readonly IntPtr selSetHeaderReferenceSize_ = Selector.GetHandle ("setHeaderReferenceSize:");
		static readonly IntPtr selFooterReferenceSize = Selector.GetHandle ("footerReferenceSize");
		static readonly IntPtr selSetFooterReferenceSize_ = Selector.GetHandle ("setFooterReferenceSize:");
		static readonly IntPtr selSectionInset = Selector.GetHandle ("sectionInset");
		static readonly IntPtr selSetSectionInset_ = Selector.GetHandle ("setSectionInset:");
		static readonly IntPtr selRowAlignmentOptions = Selector.GetHandle ("rowAlignmentOptions");
		static readonly IntPtr selSetRowAlignmentOptions_ = Selector.GetHandle ("setRowAlignmentOptions:");
		static readonly IntPtr selSynchronizeLayout = Selector.GetHandle ("synchronizeLayout");
		static readonly IntPtr selInitialLayoutAttributesForFooterInInsertedSection_ = Selector.GetHandle ("initialLayoutAttributesForFooterInInsertedSection:");
		static readonly IntPtr selInitialLayoutAttributesForHeaderInInsertedSection_ = Selector.GetHandle ("initialLayoutAttributesForHeaderInInsertedSection:");
		static readonly IntPtr selInitialLayoutAttributesForInsertedItemAtIndexPath_ = Selector.GetHandle ("initialLayoutAttributesForInsertedItemAtIndexPath:");
		static readonly IntPtr selFinalLayoutAttributesForFooterInDeletedSection_ = Selector.GetHandle ("finalLayoutAttributesForFooterInDeletedSection:");
		static readonly IntPtr selFinalLayoutAttributesForHeaderInDeletedSection_ = Selector.GetHandle ("finalLayoutAttributesForHeaderInDeletedSection:");
		static readonly IntPtr selFinalLayoutAttributesForDeletedItemAtIndexPath_ = Selector.GetHandle ("finalLayoutAttributesForDeletedItemAtIndexPath:");
		static readonly IntPtr sel_updateItemsLayout = Selector.GetHandle ("_updateItemsLayout");
		static readonly IntPtr sel_getSizingInfos = Selector.GetHandle ("_getSizingInfos");
		static readonly IntPtr sel_updateDelegateFlags = Selector.GetHandle ("_updateDelegateFlags");
		static readonly IntPtr selLayoutAttributesForFooterInSection_ = Selector.GetHandle ("layoutAttributesForFooterInSection:");
		static readonly IntPtr selLayoutAttributesForHeaderInSection_ = Selector.GetHandle ("layoutAttributesForHeaderInSection:");
		static readonly IntPtr selLayoutAttributesForItemAtIndexPathUsingData_ = Selector.GetHandle ("layoutAttributesForItemAtIndexPath:usingData:");
		static readonly IntPtr selLayoutAttributesForFooterInSectionUsingData_ = Selector.GetHandle ("layoutAttributesForFooterInSection:usingData:");
		static readonly IntPtr selLayoutAttributesForHeaderInSectionUsingData_ = Selector.GetHandle ("layoutAttributesForHeaderInSection:usingData:");
		static readonly IntPtr selIndexesForSectionFootersInRect_ = Selector.GetHandle ("indexesForSectionFootersInRect:");
		static readonly IntPtr selIndexesForSectionHeadersInRect_ = Selector.GetHandle ("indexesForSectionHeadersInRect:");
		static readonly IntPtr selIndexPathsForItemsInRectUsingData_ = Selector.GetHandle ("indexPathsForItemsInRect:usingData:");
		static readonly IntPtr selIndexesForSectionFootersInRectUsingData_ = Selector.GetHandle ("indexesForSectionFootersInRect:usingData:");
		static readonly IntPtr selIndexesForSectionHeadersInRectUsingData_ = Selector.GetHandle ("indexesForSectionHeadersInRect:usingData:");
		static readonly IntPtr sel_frameForItemAtSectionAndRowUsingData_ = Selector.GetHandle ("_frameForItemAtSection:andRow:usingData:");
		static readonly IntPtr sel_frameForFooterInSectionUsingData_ = Selector.GetHandle ("_frameForFooterInSection:usingData:");
		static readonly IntPtr sel_frameForHeaderInSectionUsingData_ = Selector.GetHandle ("_frameForHeaderInSection:usingData:");
		static readonly IntPtr sel_invalidateLayout = Selector.GetHandle ("_invalidateLayout");
		static readonly IntPtr selIndexPathForItemAtPoint_ = Selector.GetHandle ("indexPathForItemAtPoint:");
		static readonly IntPtr sel_layoutAttributesForItemsInRect_ = Selector.GetHandle ("_layoutAttributesForItemsInRect:");
		static readonly IntPtr selCollectionViewContentSize = Selector.GetHandle ("collectionViewContentSize");
		static readonly IntPtr selFinalizeCollectionViewUpdates = Selector.GetHandle ("finalizeCollectionViewUpdates");
		static readonly IntPtr selLayoutAttributesForSupplementaryViewOfKindAtIndexPath_ = Selector.GetHandle ("layoutAttributesForSupplementaryViewOfKind:atIndexPath:");
		static readonly IntPtr sel_invalidateButKeepDelegateInfo = Selector.GetHandle ("_invalidateButKeepDelegateInfo");
		static readonly IntPtr sel_invalidateButKeepAllInfo = Selector.GetHandle ("_invalidateButKeepAllInfo");
		static readonly IntPtr selShouldInvalidateLayoutForBoundsChange_ = Selector.GetHandle ("shouldInvalidateLayoutForBoundsChange:");
		static readonly IntPtr selLayoutAttributesForElementsInRect_ = Selector.GetHandle ("layoutAttributesForElementsInRect:");
		static readonly IntPtr selInvalidateLayout = Selector.GetHandle ("invalidateLayout");
		static readonly IntPtr selLayoutAttributesForItemAtIndexPath_ = Selector.GetHandle ("layoutAttributesForItemAtIndexPath:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSCollectionViewFlowLayout");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSCollectionViewFlowLayout () : base (NSObjectFlag.Empty)
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
		public PSCollectionViewFlowLayout (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSCollectionViewFlowLayout (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSCollectionViewFlowLayout (IntPtr handle) : base (handle) {}

		[CompilerGenerated]
		public System.Drawing.SizeF SynchronizeLayout ()
		{
			System.Drawing.SizeF ret;
			if (Runtime.Arch == Arch.DEVICE){
				MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend_stret (out ret, this.Handle, selSynchronizeLayout);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend (this.Handle, selSynchronizeLayout);
			}
			return ret;
		}
		
		[CompilerGenerated]
		public PSCollectionViewLayoutAttributes InitialLayoutAttributesForFooterInInsertedSection (int section)
		{
			return (PSCollectionViewLayoutAttributes) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int (this.Handle, selInitialLayoutAttributesForFooterInInsertedSection_, section));
		}
		
		[CompilerGenerated]
		public PSCollectionViewLayoutAttributes InitialLayoutAttributesForHeaderInInsertedSection (int section)
		{
			return (PSCollectionViewLayoutAttributes) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int (this.Handle, selInitialLayoutAttributesForHeaderInInsertedSection_, section));
		}
		
		[CompilerGenerated]
		public new PSCollectionViewLayoutAttributes InitialLayoutAttributesForInsertedItemAtIndexPath (NSIndexPath indexPath)
		{
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			return (PSCollectionViewLayoutAttributes) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitialLayoutAttributesForInsertedItemAtIndexPath_, indexPath.Handle));
		}
		
		[CompilerGenerated]
		public PSCollectionViewLayoutAttributes FinalLayoutAttributesForFooterInDeletedSection (int section)
		{
			return (PSCollectionViewLayoutAttributes) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int (this.Handle, selFinalLayoutAttributesForFooterInDeletedSection_, section));
		}
		
		[CompilerGenerated]
		public PSCollectionViewLayoutAttributes FinalLayoutAttributesForHeaderInDeletedSection (int section)
		{
			return (PSCollectionViewLayoutAttributes) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int (this.Handle, selFinalLayoutAttributesForHeaderInDeletedSection_, section));
		}
		
		[CompilerGenerated]
		public PSCollectionViewLayoutAttributes FinalLayoutAttributesForHeaderInDeletedSection (NSIndexPath indexPath)
		{
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			return (PSCollectionViewLayoutAttributes) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selFinalLayoutAttributesForDeletedItemAtIndexPath_, indexPath.Handle));
		}
		
		[CompilerGenerated]
		public void _UpdateItemsLayout ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, sel_updateItemsLayout);
		}
		
		[CompilerGenerated]
		public void _GetSizingInfos ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, sel_getSizingInfos);
		}
		
		[CompilerGenerated]
		public void _UpdateDelegateFlags ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, sel_updateDelegateFlags);
		}
		
		[CompilerGenerated]
		public PSCollectionViewLayoutAttributes LayoutAttributesForFooterInSection (int section)
		{
			return (PSCollectionViewLayoutAttributes) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int (this.Handle, selLayoutAttributesForFooterInSection_, section));
		}
		
		[CompilerGenerated]
		public PSCollectionViewLayoutAttributes LayoutAttributesForHeaderInSection (int section)
		{
			return (PSCollectionViewLayoutAttributes) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int (this.Handle, selLayoutAttributesForHeaderInSection_, section));
		}
		
		[CompilerGenerated]
		public PSCollectionViewLayoutAttributes LayoutAttributesForItemAtIndexPath (NSIndexPath indexPath, NSObject data)
		{
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			if (data == null)
				throw new ArgumentNullException ("data");
			return (PSCollectionViewLayoutAttributes) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selLayoutAttributesForItemAtIndexPathUsingData_, indexPath.Handle, data.Handle));
		}
		
		[CompilerGenerated]
		public PSCollectionViewLayoutAttributes LayoutAttributesForFooterInSection (int section, NSObject data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			return (PSCollectionViewLayoutAttributes) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int_IntPtr (this.Handle, selLayoutAttributesForFooterInSectionUsingData_, section, data.Handle));
		}
		
		[CompilerGenerated]
		public PSCollectionViewLayoutAttributes LayoutAttributesForHeaderInSection (int section, NSObject data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			return (PSCollectionViewLayoutAttributes) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int_IntPtr (this.Handle, selLayoutAttributesForHeaderInSectionUsingData_, section, data.Handle));
		}
		
		[CompilerGenerated]
		public NSObject IndexesForSectionFootersInRect (System.Drawing.RectangleF rect)
		{
			return (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_RectangleF (this.Handle, selIndexesForSectionFootersInRect_, rect));
		}
		
		[CompilerGenerated]
		public NSObject IndexesForSectionHeadersInRect (System.Drawing.RectangleF rect)
		{
			return (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_RectangleF (this.Handle, selIndexesForSectionHeadersInRect_, rect));
		}
		
		[CompilerGenerated]
		public NSObject IndexPathsForItemsInRect (System.Drawing.RectangleF rect, NSObject arg2)
		{
			if (arg2 == null)
				throw new ArgumentNullException ("arg2");
			return (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_RectangleF_IntPtr (this.Handle, selIndexPathsForItemsInRectUsingData_, rect, arg2.Handle));
		}
		
		[CompilerGenerated]
		public NSObject IndexesForSectionFootersInRect (System.Drawing.RectangleF rect, NSObject arg2)
		{
			if (arg2 == null)
				throw new ArgumentNullException ("arg2");
			return (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_RectangleF_IntPtr (this.Handle, selIndexesForSectionFootersInRectUsingData_, rect, arg2.Handle));
		}
		
		[CompilerGenerated]
		public NSObject IndexesForSectionHeadersInRect (System.Drawing.RectangleF arg1, NSObject arg2)
		{
			if (arg2 == null)
				throw new ArgumentNullException ("arg2");
			return (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_RectangleF_IntPtr (this.Handle, selIndexesForSectionHeadersInRectUsingData_, arg1, arg2.Handle));
		}
		
		[CompilerGenerated]
		public System.Drawing.RectangleF _FrameForItemAtSectionAndRow (int arg1, int arg2, NSObject arg3)
		{
			if (arg3 == null)
				throw new ArgumentNullException ("arg3");
			System.Drawing.RectangleF ret;
			ApiDefinition.Messaging.RectangleF_objc_msgSend_stret_int_int_IntPtr (out ret, this.Handle, sel_frameForItemAtSectionAndRowUsingData_, arg1, arg2, arg3.Handle);
			return ret;
		}
		
		[CompilerGenerated]
		public System.Drawing.RectangleF _FrameForFooterInSection (int arg1, NSObject arg2)
		{
			if (arg2 == null)
				throw new ArgumentNullException ("arg2");
			System.Drawing.RectangleF ret;
			ApiDefinition.Messaging.RectangleF_objc_msgSend_stret_int_IntPtr (out ret, this.Handle, sel_frameForFooterInSectionUsingData_, arg1, arg2.Handle);
			return ret;
		}
		
		[CompilerGenerated]
		public System.Drawing.RectangleF _FrameForHeaderInSection (int arg1, NSObject arg2)
		{
			if (arg2 == null)
				throw new ArgumentNullException ("arg2");
			System.Drawing.RectangleF ret;
			ApiDefinition.Messaging.RectangleF_objc_msgSend_stret_int_IntPtr (out ret, this.Handle, sel_frameForHeaderInSectionUsingData_, arg1, arg2.Handle);
			return ret;
		}
		
		[CompilerGenerated]
		public void _InvalidateLayout ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, sel_invalidateLayout);
		}
		
		[CompilerGenerated]
		public NSIndexPath IndexPathForItemAtPoint (System.Drawing.PointF arg1)
		{
			return (NSIndexPath) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_PointF (this.Handle, selIndexPathForItemAtPoint_, arg1));
		}
		
		[CompilerGenerated]
		public PSCollectionViewLayoutAttributes _LayoutAttributesForItemsInRect (System.Drawing.RectangleF arg1)
		{
			return (PSCollectionViewLayoutAttributes) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_RectangleF (this.Handle, sel_layoutAttributesForItemsInRect_, arg1));
		}
		
		[CompilerGenerated]
		public new System.Drawing.SizeF CollectionViewContentSize ()
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
		public new void FinalizeCollectionViewUpdates ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selFinalizeCollectionViewUpdates);
		}
		
		[CompilerGenerated]
		public PSCollectionViewLayoutAttributes LayoutAttributesForSupplementaryViewOfKind (string kind, NSIndexPath indexPath)
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
		public void _InvalidateButKeepDelegateInfo ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, sel_invalidateButKeepDelegateInfo);
		}
		
		[CompilerGenerated]
		public void _InvalidateButKeepAllInfo ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, sel_invalidateButKeepAllInfo);
		}
		
		[CompilerGenerated]
		public new bool ShouldInvalidateLayoutForBoundsChange (System.Drawing.RectangleF arg1)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend_RectangleF (this.Handle, selShouldInvalidateLayoutForBoundsChange_, arg1);
		}
		
		[CompilerGenerated]
		public new NSObject LayoutAttributesForElementsInRect (System.Drawing.RectangleF arg1)
		{
			return (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_RectangleF (this.Handle, selLayoutAttributesForElementsInRect_, arg1));
		}
		
		[CompilerGenerated]
		public void InvalidateLayout ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selInvalidateLayout);
		}
		
		[CompilerGenerated]
		public NSObject LayoutAttributesForItemAtIndexPath (NSObject arg1)
		{
			if (arg1 == null)
				throw new ArgumentNullException ("arg1");
			return (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selLayoutAttributesForItemAtIndexPath_, arg1.Handle));
		}
		
		[CompilerGenerated]
		public virtual float MinimumLineSpacing {
			[Export ("minimumLineSpacing")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMinimumLineSpacing);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selMinimumLineSpacing);
				}
			}
			
			[Export ("setMinimumLineSpacing:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMinimumLineSpacing_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetMinimumLineSpacing_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float MinimumInteritemSpacing {
			[Export ("minimumInteritemSpacing")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMinimumInteritemSpacing);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selMinimumInteritemSpacing);
				}
			}
			
			[Export ("setMinimumInteritemSpacing:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMinimumInteritemSpacing_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetMinimumInteritemSpacing_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual System.Drawing.SizeF ItemSize {
			[Export ("itemSize")]
			get {
				System.Drawing.SizeF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend_stret (out ret, this.Handle, selItemSize);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend (this.Handle, selItemSize);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selItemSize);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper (this.SuperHandle, selItemSize);
					}
				}
				return ret;
			}
			
			[Export ("setItemSize:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_SizeF (this.Handle, selSetItemSize_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_SizeF (this.SuperHandle, selSetItemSize_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSCollectionViewScrollDirection ScrollDirection {
			[Export ("scrollDirection")]
			get {
				if (IsDirectBinding) {
					return (PSCollectionViewScrollDirection) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selScrollDirection);
				} else {
					return (PSCollectionViewScrollDirection) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selScrollDirection);
				}
			}
			
			[Export ("setScrollDirection:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetScrollDirection_, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetScrollDirection_, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual System.Drawing.SizeF HeaderReferenceSize {
			[Export ("headerReferenceSize")]
			get {
				System.Drawing.SizeF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend_stret (out ret, this.Handle, selHeaderReferenceSize);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend (this.Handle, selHeaderReferenceSize);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selHeaderReferenceSize);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper (this.SuperHandle, selHeaderReferenceSize);
					}
				}
				return ret;
			}
			
			[Export ("setHeaderReferenceSize:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_SizeF (this.Handle, selSetHeaderReferenceSize_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_SizeF (this.SuperHandle, selSetHeaderReferenceSize_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual System.Drawing.SizeF FooterReferenceSize {
			[Export ("footerReferenceSize")]
			get {
				System.Drawing.SizeF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend_stret (out ret, this.Handle, selFooterReferenceSize);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend (this.Handle, selFooterReferenceSize);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selFooterReferenceSize);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper (this.SuperHandle, selFooterReferenceSize);
					}
				}
				return ret;
			}
			
			[Export ("setFooterReferenceSize:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_SizeF (this.Handle, selSetFooterReferenceSize_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_SizeF (this.SuperHandle, selSetFooterReferenceSize_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIEdgeInsets SectionInset {
			[Export ("sectionInset")]
			get {
				MonoTouch.UIKit.UIEdgeInsets ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, selSectionInset);
				} else {
					MonoTouch.ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, selSectionInset);
				}
				return ret;
			}
			
			[Export ("setSectionInset:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, selSetSectionInset_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UIEdgeInsets (this.SuperHandle, selSetSectionInset_, value);
				}
			}
		}
		
		object __mt_RowAlignmentOptions_var;
		[CompilerGenerated]
		public virtual NSDictionary RowAlignmentOptions {
			[Export ("rowAlignmentOptions")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRowAlignmentOptions));
				} else {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRowAlignmentOptions));
				}
				MarkDirty ();
				__mt_RowAlignmentOptions_var = ret;
				return ret;
			}
			
			[Export ("setRowAlignmentOptions:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRowAlignmentOptions_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRowAlignmentOptions_, value.Handle);
				}
				MarkDirty ();
				__mt_RowAlignmentOptions_var = value;
			}
		}
		
		static readonly IntPtr __Internal_libraryHandle = Dlfcn.dlopen (null, 0);
		static NSString _PSCollectionElementKindSectionHeader;
		public static NSString PSCollectionElementKindSectionHeader {
			get {
				if (_PSCollectionElementKindSectionHeader == null)
					_PSCollectionElementKindSectionHeader = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSCollectionElementKindSectionHeader");
				return _PSCollectionElementKindSectionHeader;
			}
		}
		static NSString _PSCollectionElementKindSectionFooter;
		public static NSString PSCollectionElementKindSectionFooter {
			get {
				if (_PSCollectionElementKindSectionFooter == null)
					_PSCollectionElementKindSectionFooter = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSCollectionElementKindSectionFooter");
				return _PSCollectionElementKindSectionFooter;
			}
		}
		static NSString _PSFlowLayoutCommonRowHorizontalAlignmentKey;
		public static NSString PSFlowLayoutCommonRowHorizontalAlignmentKey {
			get {
				if (_PSFlowLayoutCommonRowHorizontalAlignmentKey == null)
					_PSFlowLayoutCommonRowHorizontalAlignmentKey = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSFlowLayoutCommonRowHorizontalAlignmentKey");
				return _PSFlowLayoutCommonRowHorizontalAlignmentKey;
			}
		}
		static NSString _PSFlowLayoutLastRowHorizontalAlignmentKey;
		public static NSString PSFlowLayoutLastRowHorizontalAlignmentKey {
			get {
				if (_PSFlowLayoutLastRowHorizontalAlignmentKey == null)
					_PSFlowLayoutLastRowHorizontalAlignmentKey = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSFlowLayoutLastRowHorizontalAlignmentKey");
				return _PSFlowLayoutLastRowHorizontalAlignmentKey;
			}
		}
		static NSString _PSFlowLayoutRowVerticalAlignmentKey;
		public static NSString PSFlowLayoutRowVerticalAlignmentKey {
			get {
				if (_PSFlowLayoutRowVerticalAlignmentKey == null)
					_PSFlowLayoutRowVerticalAlignmentKey = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSFlowLayoutRowVerticalAlignmentKey");
				return _PSFlowLayoutRowVerticalAlignmentKey;
			}
		}
		protected override void Dispose (bool disposing)
		{
			__mt_RowAlignmentOptions_var = null;
			base.Dispose (disposing);
		}
	} /* class PSCollectionViewFlowLayout */
}
