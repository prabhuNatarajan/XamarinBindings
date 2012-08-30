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
	[Register("PSPDFTabBarView", true)]
	public unsafe partial class PSPDFTabBarView : MonoTouch.UIKit.UIView {
		static readonly IntPtr selSelectedTabIndex = Selector.GetHandle ("selectedTabIndex");
		static readonly IntPtr selMinTabWidth = Selector.GetHandle ("minTabWidth");
		static readonly IntPtr selSetMinTabWidth_ = Selector.GetHandle ("setMinTabWidth:");
		static readonly IntPtr selDelegate = Selector.GetHandle ("delegate");
		static readonly IntPtr selSetDelegate_ = Selector.GetHandle ("setDelegate:");
		static readonly IntPtr selDataSource = Selector.GetHandle ("dataSource");
		static readonly IntPtr selSetDataSource_ = Selector.GetHandle ("setDataSource:");
		static readonly IntPtr selReloadData = Selector.GetHandle ("reloadData");
		static readonly IntPtr selSelectTabAtIndexAnimated_ = Selector.GetHandle ("selectTabAtIndex:animated:");
		static readonly IntPtr selScrollToTabAtIndexAnimated_ = Selector.GetHandle ("scrollToTabAtIndex:animated:");
		static readonly IntPtr selScrollViewDidScroll_ = Selector.GetHandle ("scrollViewDidScroll:");
		static readonly IntPtr selScrollViewDidZoom_ = Selector.GetHandle ("scrollViewDidZoom:");
		static readonly IntPtr selScrollViewWillBeginDragging_ = Selector.GetHandle ("scrollViewWillBeginDragging:");
		static readonly IntPtr selScrollViewWillEndDraggingWithVelocityTargetContentOffset_ = Selector.GetHandle ("scrollViewWillEndDragging:withVelocity:targetContentOffset:");
		static readonly IntPtr selScrollViewDidEndDraggingWillDecelerate_ = Selector.GetHandle ("scrollViewDidEndDragging:willDecelerate:");
		static readonly IntPtr selScrollViewWillBeginDecelerating_ = Selector.GetHandle ("scrollViewWillBeginDecelerating:");
		static readonly IntPtr selScrollViewDidEndDecelerating_ = Selector.GetHandle ("scrollViewDidEndDecelerating:");
		static readonly IntPtr selScrollViewDidEndScrollingAnimation_ = Selector.GetHandle ("scrollViewDidEndScrollingAnimation:");
		static readonly IntPtr selViewForZoomingInScrollView_ = Selector.GetHandle ("viewForZoomingInScrollView:");
		static readonly IntPtr selScrollViewWillBeginZoomingWithView_ = Selector.GetHandle ("scrollViewWillBeginZooming:withView:");
		static readonly IntPtr selScrollViewDidEndZoomingWithViewAtScale_ = Selector.GetHandle ("scrollViewDidEndZooming:withView:atScale:");
		static readonly IntPtr selScrollViewShouldScrollToTop_ = Selector.GetHandle ("scrollViewShouldScrollToTop:");
		static readonly IntPtr selScrollViewDidScrollToTop_ = Selector.GetHandle ("scrollViewDidScrollToTop:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFTabBarView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFTabBarView () : base (NSObjectFlag.Empty)
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
		public PSPDFTabBarView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFTabBarView (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFTabBarView (IntPtr handle) : base (handle) {}

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
		
		[Export ("selectTabAtIndex:animated:")]
		[CompilerGenerated]
		public virtual void SelectTabAtIndex (System.UInt32 index, bool animated)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_UInt32_bool (this.Handle, selSelectTabAtIndexAnimated_, index, animated);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32_bool (this.SuperHandle, selSelectTabAtIndexAnimated_, index, animated);
			}
		}
		
		[Export ("scrollToTabAtIndex:animated:")]
		[CompilerGenerated]
		public virtual void ScrollToTabAtIndex (System.UInt32 index, bool animated)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_UInt32_bool (this.Handle, selScrollToTabAtIndexAnimated_, index, animated);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32_bool (this.SuperHandle, selScrollToTabAtIndexAnimated_, index, animated);
			}
		}
		
		[Export ("scrollViewDidScroll:")]
		[CompilerGenerated]
		public virtual void ScrollViewDidScroll (MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScrollViewDidScroll_, scrollView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selScrollViewDidScroll_, scrollView.Handle);
			}
		}
		
		[Export ("scrollViewDidZoom:")]
		[CompilerGenerated]
		public virtual void ScrollViewDidZoom (MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScrollViewDidZoom_, scrollView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selScrollViewDidZoom_, scrollView.Handle);
			}
		}
		
		[Export ("scrollViewWillBeginDragging:")]
		[CompilerGenerated]
		public virtual void ScrollViewWillBeginDragging (MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScrollViewWillBeginDragging_, scrollView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selScrollViewWillBeginDragging_, scrollView.Handle);
			}
		}
		
		[Export ("scrollViewWillEndDragging:withVelocity:targetContentOffset:")]
		[CompilerGenerated]
		public virtual void ScrollViewWillEndDragging (MonoTouch.UIKit.UIScrollView scrollView, System.Drawing.PointF velocity, ref System.Drawing.PointF targetContentOffset)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_PointF_out_PointF (this.Handle, selScrollViewWillEndDraggingWithVelocityTargetContentOffset_, scrollView.Handle, velocity, out targetContentOffset);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_PointF_out_PointF (this.SuperHandle, selScrollViewWillEndDraggingWithVelocityTargetContentOffset_, scrollView.Handle, velocity, out targetContentOffset);
			}
		}
		
		[Export ("scrollViewDidEndDragging:willDecelerate:")]
		[CompilerGenerated]
		public virtual void ScrollViewDidEndDragging (MonoTouch.UIKit.UIScrollView scrollView, bool decelerate)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selScrollViewDidEndDraggingWillDecelerate_, scrollView.Handle, decelerate);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selScrollViewDidEndDraggingWillDecelerate_, scrollView.Handle, decelerate);
			}
		}
		
		[Export ("scrollViewWillBeginDecelerating:")]
		[CompilerGenerated]
		public virtual void ScrollViewWillBeginDecelerating (MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScrollViewWillBeginDecelerating_, scrollView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selScrollViewWillBeginDecelerating_, scrollView.Handle);
			}
		}
		
		[Export ("scrollViewDidEndDecelerating:")]
		[CompilerGenerated]
		public virtual void ScrollViewDidEndDecelerating (MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScrollViewDidEndDecelerating_, scrollView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selScrollViewDidEndDecelerating_, scrollView.Handle);
			}
		}
		
		[Export ("scrollViewDidEndScrollingAnimation:")]
		[CompilerGenerated]
		public virtual void ScrollViewDidEndScrollingAnimation (MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScrollViewDidEndScrollingAnimation_, scrollView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selScrollViewDidEndScrollingAnimation_, scrollView.Handle);
			}
		}
		
		[Export ("viewForZoomingInScrollView:")]
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIView ViewForZoomingInScrollView (MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				return (MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selViewForZoomingInScrollView_, scrollView.Handle));
			} else {
				return (MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selViewForZoomingInScrollView_, scrollView.Handle));
			}
		}
		
		[Export ("scrollViewWillBeginZooming:withView:")]
		[CompilerGenerated]
		public virtual void ScrollViewWillBeginZooming (MonoTouch.UIKit.UIScrollView scrollView, MonoTouch.UIKit.UIView view)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (view == null)
				throw new ArgumentNullException ("view");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selScrollViewWillBeginZoomingWithView_, scrollView.Handle, view.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selScrollViewWillBeginZoomingWithView_, scrollView.Handle, view.Handle);
			}
		}
		
		[Export ("scrollViewDidEndZooming:withView:atScale:")]
		[CompilerGenerated]
		public virtual void ScrollViewDidEndZooming (MonoTouch.UIKit.UIScrollView scrollView, MonoTouch.UIKit.UIView view, float scale)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (view == null)
				throw new ArgumentNullException ("view");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_float (this.Handle, selScrollViewDidEndZoomingWithViewAtScale_, scrollView.Handle, view.Handle, scale);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_float (this.SuperHandle, selScrollViewDidEndZoomingWithViewAtScale_, scrollView.Handle, view.Handle, scale);
			}
		}
		
		[Export ("scrollViewShouldScrollToTop:")]
		[CompilerGenerated]
		public virtual bool ScrollViewShouldScrollToTop (MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selScrollViewShouldScrollToTop_, scrollView.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selScrollViewShouldScrollToTop_, scrollView.Handle);
			}
		}
		
		[Export ("scrollViewDidScrollToTop:")]
		[CompilerGenerated]
		public virtual void ScrollViewDidScrollToTop (MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScrollViewDidScrollToTop_, scrollView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selScrollViewDidScrollToTop_, scrollView.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual System.UInt32 SelectedTabIndex {
			[Export ("selectedTabIndex")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selSelectedTabIndex);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selSelectedTabIndex);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual float MinTabWidth {
			[Export ("minTabWidth", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMinTabWidth);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selMinTabWidth);
				}
			}
			
			[Export ("setMinTabWidth:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMinTabWidth_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetMinTabWidth_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public PSPDFTabBarViewDelegate Delegate {
			get { return WeakDelegate as PSPDFTabBarViewDelegate; }
			set { WeakDelegate = value; }
		}
		
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
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
		public PSPDFTabBarViewDelegate DataSource {
			get { return WeakDataSource as PSPDFTabBarViewDelegate; }
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
		
		protected override void Dispose (bool disposing)
		{
			__mt_WeakDelegate_var = null;
			__mt_WeakDataSource_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFTabBarView */
}
