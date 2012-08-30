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
	[Register("PSCollectionViewDelegateFlowLayout", true)]
	[Model]
	public unsafe partial class PSCollectionViewDelegateFlowLayout : PSCollectionViewDelegate {
		
		static readonly IntPtr class_ptr = Class.GetHandle ("NSObject");
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSCollectionViewDelegateFlowLayout () : base (NSObjectFlag.Empty)
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
		public PSCollectionViewDelegateFlowLayout (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSCollectionViewDelegateFlowLayout (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSCollectionViewDelegateFlowLayout (IntPtr handle) : base (handle) {}

		[Export ("collectionView:layout:sizeForItemAtIndexPath:")]
		[CompilerGenerated]
		public virtual System.Drawing.SizeF SizeForItemAtIndexPath (PSCollectionView collectionView, PSCollectionViewLayout collectionViewLayout, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("collectionView:layout:insetForSectionAtIndex:")]
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIEdgeInsets InsetForSectionAtIndex (PSCollectionView collectionView, PSCollectionViewLayout collectionViewLayout, int section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("collectionView:layout:minimumLineSpacingForSectionAtIndex:")]
		[CompilerGenerated]
		public virtual float MinimumLineSpacingForSectionAtIndex (PSCollectionView collectionView, PSCollectionViewLayout collectionViewLayout, int section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("collectionView:layout:minimumInteritemSpacingForSectionAtIndex:")]
		[CompilerGenerated]
		public virtual float MinimumInteritemSpacingForSectionAtIndex (PSCollectionView collectionView, PSCollectionViewLayout collectionViewLayout, int section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("collectionView:layout:referenceSizeForHeaderInSection:")]
		[CompilerGenerated]
		public virtual System.Drawing.SizeF ReferenceSizeForHeaderInSection (PSCollectionView collectionView, PSCollectionViewLayout collectionViewLayout, int section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("collectionView:layout:referenceSizeForFooterInSection:")]
		[CompilerGenerated]
		public virtual System.Drawing.SizeF ReferenceSizeForFooterInSection (PSCollectionView collectionView, PSCollectionViewLayout collectionViewLayout, int section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSCollectionViewDelegateFlowLayout */
}
