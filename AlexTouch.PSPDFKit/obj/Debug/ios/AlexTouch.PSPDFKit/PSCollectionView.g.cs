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
	[Register("PSCollectionView", true)]
	public unsafe partial class PSCollectionView : MonoTouch.UIKit.UIScrollView {
		static readonly IntPtr selCollectionViewLayout = Selector.GetHandle ("collectionViewLayout");
		static readonly IntPtr selSetCollectionViewLayout_ = Selector.GetHandle ("setCollectionViewLayout:");
		static readonly IntPtr selDelegate = Selector.GetHandle ("delegate");
		static readonly IntPtr selSetDelegate_ = Selector.GetHandle ("setDelegate:");
		static readonly IntPtr selDataSource = Selector.GetHandle ("dataSource");
		static readonly IntPtr selSetDataSource_ = Selector.GetHandle ("setDataSource:");
		static readonly IntPtr selBackgroundView = Selector.GetHandle ("backgroundView");
		static readonly IntPtr selSetBackgroundView_ = Selector.GetHandle ("setBackgroundView:");
		static readonly IntPtr selAllowsSelection = Selector.GetHandle ("allowsSelection");
		static readonly IntPtr selSetAllowsSelection_ = Selector.GetHandle ("setAllowsSelection:");
		static readonly IntPtr selAllowsMultipleSelection = Selector.GetHandle ("allowsMultipleSelection");
		static readonly IntPtr selSetAllowsMultipleSelection_ = Selector.GetHandle ("setAllowsMultipleSelection:");
		static readonly IntPtr selInitWithFrameCollectionViewLayout_ = Selector.GetHandle ("initWithFrame:collectionViewLayout:");
		static readonly IntPtr selRegisterClassForCellWithReuseIdentifier_ = Selector.GetHandle ("registerClass:forCellWithReuseIdentifier:");
		static readonly IntPtr selRegisterClassForSupplementaryViewOfKindWithReuseIdentifier_ = Selector.GetHandle ("registerClass:forSupplementaryViewOfKind:withReuseIdentifier:");
		static readonly IntPtr selDequeueReusableCellWithReuseIdentifierForIndexPath_ = Selector.GetHandle ("dequeueReusableCellWithReuseIdentifier:forIndexPath:");
		static readonly IntPtr selDequeueReusableSupplementaryViewOfKindWithReuseIdentifierForIndexPath_ = Selector.GetHandle ("dequeueReusableSupplementaryViewOfKind:withReuseIdentifier:forIndexPath:");
		static readonly IntPtr selIndexPathsForSelectedItems = Selector.GetHandle ("indexPathsForSelectedItems");
		static readonly IntPtr selSelectItemAtIndexPathAnimatedScrollPosition_ = Selector.GetHandle ("selectItemAtIndexPath:animated:scrollPosition:");
		static readonly IntPtr selDeselectItemAtIndexPathAnimated_ = Selector.GetHandle ("deselectItemAtIndexPath:animated:");
		static readonly IntPtr selReloadData = Selector.GetHandle ("reloadData");
		static readonly IntPtr selSetCollectionViewLayoutAnimated_ = Selector.GetHandle ("setCollectionViewLayout:animated:");
		static readonly IntPtr selNumberOfSections = Selector.GetHandle ("numberOfSections");
		static readonly IntPtr selNumberOfItemsInSection_ = Selector.GetHandle ("numberOfItemsInSection:");
		static readonly IntPtr selLayoutAttributesForItemAtIndexPath_ = Selector.GetHandle ("layoutAttributesForItemAtIndexPath:");
		static readonly IntPtr selLayoutAttributesForSupplementaryElementOfKindAtIndexPath_ = Selector.GetHandle ("layoutAttributesForSupplementaryElementOfKind:atIndexPath:");
		static readonly IntPtr selIndexPathForItemAtPoint_ = Selector.GetHandle ("indexPathForItemAtPoint:");
		static readonly IntPtr selIndexPathForCell_ = Selector.GetHandle ("indexPathForCell:");
		static readonly IntPtr selCellForItemAtIndexPath_ = Selector.GetHandle ("cellForItemAtIndexPath:");
		static readonly IntPtr selVisibleCells = Selector.GetHandle ("visibleCells");
		static readonly IntPtr selIndexPathsForVisibleItems = Selector.GetHandle ("indexPathsForVisibleItems");
		static readonly IntPtr selScrollToItemAtIndexPathAtScrollPositionAnimated_ = Selector.GetHandle ("scrollToItemAtIndexPath:atScrollPosition:animated:");
		static readonly IntPtr selInsertSections_ = Selector.GetHandle ("insertSections:");
		static readonly IntPtr selDeleteSections_ = Selector.GetHandle ("deleteSections:");
		static readonly IntPtr selReloadSections_ = Selector.GetHandle ("reloadSections:");
		static readonly IntPtr selMoveSectionToSection_ = Selector.GetHandle ("moveSection:toSection:");
		static readonly IntPtr selInsertItemsAtIndexPaths_ = Selector.GetHandle ("insertItemsAtIndexPaths:");
		static readonly IntPtr selDeleteItemsAtIndexPaths_ = Selector.GetHandle ("deleteItemsAtIndexPaths:");
		static readonly IntPtr selReloadItemsAtIndexPaths_ = Selector.GetHandle ("reloadItemsAtIndexPaths:");
		static readonly IntPtr selMoveItemAtIndexPathToIndexPath_ = Selector.GetHandle ("moveItemAtIndexPath:toIndexPath:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSCollectionView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSCollectionView () : base (NSObjectFlag.Empty)
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
		public PSCollectionView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSCollectionView (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSCollectionView (IntPtr handle) : base (handle) {}

		[Export ("initWithFrame:collectionViewLayout:")]
		[CompilerGenerated]
		public PSCollectionView (System.Drawing.RectangleF frame, PSCollectionViewLayout layout) : base (NSObjectFlag.Empty)
		{
			if (layout == null)
				throw new ArgumentNullException ("layout");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_RectangleF_IntPtr (this.Handle, selInitWithFrameCollectionViewLayout_, frame, layout.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_RectangleF_IntPtr (this.SuperHandle, selInitWithFrameCollectionViewLayout_, frame, layout.Handle);
			}
		}
		
		[Export ("registerClass:forCellWithReuseIdentifier:")]
		[CompilerGenerated]
		public virtual void RegisterClass (Class cellClass, string identifier)
		{
			if (cellClass == null)
				throw new ArgumentNullException ("cellClass");
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			var nsidentifier = NSString.CreateNative (identifier);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selRegisterClassForCellWithReuseIdentifier_, cellClass.Handle, nsidentifier);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selRegisterClassForCellWithReuseIdentifier_, cellClass.Handle, nsidentifier);
			}
			NSString.ReleaseNative (nsidentifier);
			
		}
		
		[Export ("registerClass:forSupplementaryViewOfKind:withReuseIdentifier:")]
		[CompilerGenerated]
		public virtual void RegisterClass (Class viewClass, string elementKind, string identifier)
		{
			if (viewClass == null)
				throw new ArgumentNullException ("viewClass");
			if (elementKind == null)
				throw new ArgumentNullException ("elementKind");
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			var nselementKind = NSString.CreateNative (elementKind);
			var nsidentifier = NSString.CreateNative (identifier);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selRegisterClassForSupplementaryViewOfKindWithReuseIdentifier_, viewClass.Handle, nselementKind, nsidentifier);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selRegisterClassForSupplementaryViewOfKindWithReuseIdentifier_, viewClass.Handle, nselementKind, nsidentifier);
			}
			NSString.ReleaseNative (nselementKind);
			NSString.ReleaseNative (nsidentifier);
			
		}
		
		[Export ("dequeueReusableCellWithReuseIdentifier:forIndexPath:")]
		[CompilerGenerated]
		public virtual NSObject DequeueReusableCell (string identifier, NSIndexPath indexPath)
		{
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			var nsidentifier = NSString.CreateNative (identifier);
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selDequeueReusableCellWithReuseIdentifierForIndexPath_, nsidentifier, indexPath.Handle));
			} else {
				ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selDequeueReusableCellWithReuseIdentifierForIndexPath_, nsidentifier, indexPath.Handle));
			}
			NSString.ReleaseNative (nsidentifier);
			
			return ret;
		}
		
		[Export ("dequeueReusableSupplementaryViewOfKind:withReuseIdentifier:forIndexPath:")]
		[CompilerGenerated]
		public virtual NSObject DequeueReusableSupplementaryView (string elementKind, string identifier, NSIndexPath indexPath)
		{
			if (elementKind == null)
				throw new ArgumentNullException ("elementKind");
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			var nselementKind = NSString.CreateNative (elementKind);
			var nsidentifier = NSString.CreateNative (identifier);
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selDequeueReusableSupplementaryViewOfKindWithReuseIdentifierForIndexPath_, nselementKind, nsidentifier, indexPath.Handle));
			} else {
				ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selDequeueReusableSupplementaryViewOfKindWithReuseIdentifierForIndexPath_, nselementKind, nsidentifier, indexPath.Handle));
			}
			NSString.ReleaseNative (nselementKind);
			NSString.ReleaseNative (nsidentifier);
			
			return ret;
		}
		
		[Export ("indexPathsForSelectedItems")]
		[CompilerGenerated]
		public virtual NSIndexPath[] IndexPathsForSelectedItems ()
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<MonoTouch.Foundation.NSIndexPath>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selIndexPathsForSelectedItems));
			} else {
				return NSArray.ArrayFromHandle<MonoTouch.Foundation.NSIndexPath>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selIndexPathsForSelectedItems));
			}
		}
		
		[Export ("selectItemAtIndexPath:animated:scrollPosition:")]
		[CompilerGenerated]
		public virtual void SelectItemAtIndexPath (NSIndexPath indexPath, bool animated, PSCollectionViewScrollPosition scrollPosition)
		{
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool_UInt32 (this.Handle, selSelectItemAtIndexPathAnimatedScrollPosition_, indexPath.Handle, animated, (UInt32)scrollPosition);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool_UInt32 (this.SuperHandle, selSelectItemAtIndexPathAnimatedScrollPosition_, indexPath.Handle, animated, (UInt32)scrollPosition);
			}
		}
		
		[Export ("deselectItemAtIndexPath:animated:")]
		[CompilerGenerated]
		public virtual void DeselectItemAtIndexPath (NSIndexPath indexPath, bool animated)
		{
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selDeselectItemAtIndexPathAnimated_, indexPath.Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selDeselectItemAtIndexPathAnimated_, indexPath.Handle, animated);
			}
		}
		
		[Export ("reloadData")]
		[CompilerGenerated]
		public virtual void ReloadData ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selReloadData);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selReloadData);
			}
		}
		
		[Export ("setCollectionViewLayout:animated:")]
		[CompilerGenerated]
		public virtual void SetCollectionViewLayout (PSCollectionViewLayout layout, bool animated)
		{
			if (layout == null)
				throw new ArgumentNullException ("layout");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selSetCollectionViewLayoutAnimated_, layout.Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selSetCollectionViewLayoutAnimated_, layout.Handle, animated);
			}
		}
		
		[Export ("numberOfSections")]
		[CompilerGenerated]
		public virtual int NumberOfSections ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selNumberOfSections);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selNumberOfSections);
			}
		}
		
		[Export ("numberOfItemsInSection:")]
		[CompilerGenerated]
		public virtual int NumberOfItemsInSection (int section)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend_int (this.Handle, selNumberOfItemsInSection_, section);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper_int (this.SuperHandle, selNumberOfItemsInSection_, section);
			}
		}
		
		[Export ("layoutAttributesForItemAtIndexPath:")]
		[CompilerGenerated]
		public virtual PSCollectionViewLayoutAttributes LayoutAttributesForItemAtIndexPath (NSIndexPath indexPath)
		{
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			if (IsDirectBinding) {
				return (PSCollectionViewLayoutAttributes) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selLayoutAttributesForItemAtIndexPath_, indexPath.Handle));
			} else {
				return (PSCollectionViewLayoutAttributes) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selLayoutAttributesForItemAtIndexPath_, indexPath.Handle));
			}
		}
		
		[Export ("layoutAttributesForSupplementaryElementOfKind:atIndexPath:")]
		[CompilerGenerated]
		public virtual PSCollectionViewLayoutAttributes LayoutAttributesForSupplementaryElementOfKind (string kind, NSIndexPath indexPath)
		{
			if (kind == null)
				throw new ArgumentNullException ("kind");
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			var nskind = NSString.CreateNative (kind);
			
			PSCollectionViewLayoutAttributes ret;
			if (IsDirectBinding) {
				ret = (PSCollectionViewLayoutAttributes) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selLayoutAttributesForSupplementaryElementOfKindAtIndexPath_, nskind, indexPath.Handle));
			} else {
				ret = (PSCollectionViewLayoutAttributes) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selLayoutAttributesForSupplementaryElementOfKindAtIndexPath_, nskind, indexPath.Handle));
			}
			NSString.ReleaseNative (nskind);
			
			return ret;
		}
		
		[Export ("indexPathForItemAtPoint:")]
		[CompilerGenerated]
		public virtual NSIndexPath IndexPathForItemAtPoint (System.Drawing.PointF point)
		{
			if (IsDirectBinding) {
				return (NSIndexPath) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_PointF (this.Handle, selIndexPathForItemAtPoint_, point));
			} else {
				return (NSIndexPath) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_PointF (this.SuperHandle, selIndexPathForItemAtPoint_, point));
			}
		}
		
		[Export ("indexPathForCell:")]
		[CompilerGenerated]
		public virtual NSIndexPath IndexPathForCell (PSCollectionViewCell cell)
		{
			if (cell == null)
				throw new ArgumentNullException ("cell");
			if (IsDirectBinding) {
				return (NSIndexPath) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selIndexPathForCell_, cell.Handle));
			} else {
				return (NSIndexPath) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selIndexPathForCell_, cell.Handle));
			}
		}
		
		[Export ("cellForItemAtIndexPath:")]
		[CompilerGenerated]
		public virtual PSCollectionViewCell CellForItemAtIndexPath (NSIndexPath indexPath)
		{
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			if (IsDirectBinding) {
				return (PSCollectionViewCell) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selCellForItemAtIndexPath_, indexPath.Handle));
			} else {
				return (PSCollectionViewCell) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selCellForItemAtIndexPath_, indexPath.Handle));
			}
		}
		
		[Export ("visibleCells")]
		[CompilerGenerated]
		public virtual NSArray VisibleCells ()
		{
			if (IsDirectBinding) {
				return (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selVisibleCells));
			} else {
				return (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selVisibleCells));
			}
		}
		
		[Export ("indexPathsForVisibleItems")]
		[CompilerGenerated]
		public virtual NSIndexPath[] IndexPathsForVisibleItems ()
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<MonoTouch.Foundation.NSIndexPath>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selIndexPathsForVisibleItems));
			} else {
				return NSArray.ArrayFromHandle<MonoTouch.Foundation.NSIndexPath>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selIndexPathsForVisibleItems));
			}
		}
		
		[Export ("scrollToItemAtIndexPath:atScrollPosition:animated:")]
		[CompilerGenerated]
		public virtual void ScrollToItemAtIndexPath (NSIndexPath indexPath, PSCollectionViewScrollPosition scrollPosition, bool animated)
		{
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UInt32_bool (this.Handle, selScrollToItemAtIndexPathAtScrollPositionAnimated_, indexPath.Handle, (UInt32)scrollPosition, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UInt32_bool (this.SuperHandle, selScrollToItemAtIndexPathAtScrollPositionAnimated_, indexPath.Handle, (UInt32)scrollPosition, animated);
			}
		}
		
		[Export ("insertSections:")]
		[CompilerGenerated]
		public virtual void InsertSections (NSIndexSet sections)
		{
			if (sections == null)
				throw new ArgumentNullException ("sections");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selInsertSections_, sections.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selInsertSections_, sections.Handle);
			}
		}
		
		[Export ("deleteSections:")]
		[CompilerGenerated]
		public virtual void DeleteSections (NSIndexSet sections)
		{
			if (sections == null)
				throw new ArgumentNullException ("sections");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selDeleteSections_, sections.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selDeleteSections_, sections.Handle);
			}
		}
		
		[Export ("reloadSections:")]
		[CompilerGenerated]
		public virtual void ReloadSections (NSIndexSet sections)
		{
			if (sections == null)
				throw new ArgumentNullException ("sections");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selReloadSections_, sections.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selReloadSections_, sections.Handle);
			}
		}
		
		[Export ("moveSection:toSection:")]
		[CompilerGenerated]
		public virtual void MoveSection (int section, int newSection)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int_int (this.Handle, selMoveSectionToSection_, section, newSection);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int_int (this.SuperHandle, selMoveSectionToSection_, section, newSection);
			}
		}
		
		[Export ("insertItemsAtIndexPaths:")]
		[CompilerGenerated]
		public virtual void InsertItemsAtIndexPaths (NSIndexPath[] indexPaths)
		{
			if (indexPaths == null)
				throw new ArgumentNullException ("indexPaths");
			var nsa_indexPaths = NSArray.FromNSObjects (indexPaths);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selInsertItemsAtIndexPaths_, nsa_indexPaths.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selInsertItemsAtIndexPaths_, nsa_indexPaths.Handle);
			}
			nsa_indexPaths.Dispose ();
			
		}
		
		[Export ("deleteItemsAtIndexPaths:")]
		[CompilerGenerated]
		public virtual void DeleteItemsAtIndexPaths (NSIndexPath[] indexPaths)
		{
			if (indexPaths == null)
				throw new ArgumentNullException ("indexPaths");
			var nsa_indexPaths = NSArray.FromNSObjects (indexPaths);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selDeleteItemsAtIndexPaths_, nsa_indexPaths.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selDeleteItemsAtIndexPaths_, nsa_indexPaths.Handle);
			}
			nsa_indexPaths.Dispose ();
			
		}
		
		[Export ("reloadItemsAtIndexPaths:")]
		[CompilerGenerated]
		public virtual void ReloadItemsAtIndexPaths (NSIndexPath[] indexPaths)
		{
			if (indexPaths == null)
				throw new ArgumentNullException ("indexPaths");
			var nsa_indexPaths = NSArray.FromNSObjects (indexPaths);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selReloadItemsAtIndexPaths_, nsa_indexPaths.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selReloadItemsAtIndexPaths_, nsa_indexPaths.Handle);
			}
			nsa_indexPaths.Dispose ();
			
		}
		
		[Export ("moveItemAtIndexPath:toIndexPath:")]
		[CompilerGenerated]
		public virtual void MoveItemAtIndexPath (NSIndexPath fromIndexPath, NSIndexPath toIndexPath)
		{
			if (fromIndexPath == null)
				throw new ArgumentNullException ("fromIndexPath");
			if (toIndexPath == null)
				throw new ArgumentNullException ("toIndexPath");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selMoveItemAtIndexPathToIndexPath_, fromIndexPath.Handle, toIndexPath.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selMoveItemAtIndexPathToIndexPath_, fromIndexPath.Handle, toIndexPath.Handle);
			}
		}
		
		object __mt_CollectionViewLayout_var;
		[CompilerGenerated]
		public virtual PSCollectionViewLayout CollectionViewLayout {
			[Export ("collectionViewLayout", ArgumentSemantic.Retain)]
			get {
				PSCollectionViewLayout ret;
				if (IsDirectBinding) {
					ret = (PSCollectionViewLayout) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCollectionViewLayout));
				} else {
					ret = (PSCollectionViewLayout) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCollectionViewLayout));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CollectionViewLayout_var = ret;
				return ret;
			}
			
			[Export ("setCollectionViewLayout:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCollectionViewLayout_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCollectionViewLayout_, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_CollectionViewLayout_var = value;
			}
		}
		
		[CompilerGenerated]
		public new PSCollectionViewDelegate Delegate {
			get { return WeakDelegate as PSCollectionViewDelegate; }
			set { WeakDelegate = value; }
		}
		
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public new virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegate));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegate));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public PSCollectionViewDataSource DataSource {
			get { return WeakDataSource as PSCollectionViewDataSource; }
			set { WeakDataSource = value; }
		}
		
		object __mt_WeakDataSource_var;
		[CompilerGenerated]
		public virtual NSObject WeakDataSource {
			[Export ("dataSource", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDataSource));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDataSource));
				}
				MarkDirty ();
				__mt_WeakDataSource_var = ret;
				return ret;
			}
			
			[Export ("setDataSource:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDataSource_, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDataSource_, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDataSource_var = value;
			}
		}
		
		object __mt_BackgroundView_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIView BackgroundView {
			[Export ("backgroundView", ArgumentSemantic.Retain)]
			get {
				MonoTouch.UIKit.UIView ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBackgroundView));
				} else {
					ret = (MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBackgroundView));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BackgroundView_var = ret;
				return ret;
			}
			
			[Export ("setBackgroundView:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBackgroundView_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBackgroundView_, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_BackgroundView_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool AllowsSelection {
			[Export ("allowsSelection")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsSelection);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAllowsSelection);
				}
			}
			
			[Export ("setAllowsSelection:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsSelection_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAllowsSelection_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AllowsMultipleSelection {
			[Export ("allowsMultipleSelection")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsMultipleSelection);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAllowsMultipleSelection);
				}
			}
			
			[Export ("setAllowsMultipleSelection:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsMultipleSelection_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAllowsMultipleSelection_, value);
				}
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_CollectionViewLayout_var = null;
			__mt_WeakDelegate_var = null;
			__mt_WeakDataSource_var = null;
			__mt_BackgroundView_var = null;
			base.Dispose (disposing);
		}
	} /* class PSCollectionView */
}
