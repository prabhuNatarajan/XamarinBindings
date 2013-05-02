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
	[Register("PSPDFTabBarView", true)]
	public unsafe partial class PSPDFTabBarView : global::MonoTouch.UIKit.UIView {
		[CompilerGenerated]
		const string selSelectedTabIndex = "selectedTabIndex";
		static readonly IntPtr selSelectedTabIndexHandle = Selector.GetHandle ("selectedTabIndex");
		[CompilerGenerated]
		const string selMinTabWidth = "minTabWidth";
		static readonly IntPtr selMinTabWidthHandle = Selector.GetHandle ("minTabWidth");
		[CompilerGenerated]
		const string selSetMinTabWidth_ = "setMinTabWidth:";
		static readonly IntPtr selSetMinTabWidth_Handle = Selector.GetHandle ("setMinTabWidth:");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selDataSource = "dataSource";
		static readonly IntPtr selDataSourceHandle = Selector.GetHandle ("dataSource");
		[CompilerGenerated]
		const string selSetDataSource_ = "setDataSource:";
		static readonly IntPtr selSetDataSource_Handle = Selector.GetHandle ("setDataSource:");
		[CompilerGenerated]
		const string selScrollView = "scrollView";
		static readonly IntPtr selScrollViewHandle = Selector.GetHandle ("scrollView");
		[CompilerGenerated]
		const string selReloadData = "reloadData";
		static readonly IntPtr selReloadDataHandle = Selector.GetHandle ("reloadData");
		[CompilerGenerated]
		const string selSelectTabAtIndexAnimated_ = "selectTabAtIndex:animated:";
		static readonly IntPtr selSelectTabAtIndexAnimated_Handle = Selector.GetHandle ("selectTabAtIndex:animated:");
		[CompilerGenerated]
		const string selScrollToTabAtIndexAnimated_ = "scrollToTabAtIndex:animated:";
		static readonly IntPtr selScrollToTabAtIndexAnimated_Handle = Selector.GetHandle ("scrollToTabAtIndex:animated:");
		[CompilerGenerated]
		const string selSelectTabAtIndexAnimatedCallDelegate_ = "selectTabAtIndex:animated:callDelegate:";
		static readonly IntPtr selSelectTabAtIndexAnimatedCallDelegate_Handle = Selector.GetHandle ("selectTabAtIndex:animated:callDelegate:");
		[CompilerGenerated]
		const string selScrollViewDidScroll_ = "scrollViewDidScroll:";
		static readonly IntPtr selScrollViewDidScroll_Handle = Selector.GetHandle ("scrollViewDidScroll:");
		[CompilerGenerated]
		const string selScrollViewDidZoom_ = "scrollViewDidZoom:";
		static readonly IntPtr selScrollViewDidZoom_Handle = Selector.GetHandle ("scrollViewDidZoom:");
		[CompilerGenerated]
		const string selScrollViewWillBeginDragging_ = "scrollViewWillBeginDragging:";
		static readonly IntPtr selScrollViewWillBeginDragging_Handle = Selector.GetHandle ("scrollViewWillBeginDragging:");
		[CompilerGenerated]
		const string selScrollViewWillEndDraggingWithVelocityTargetContentOffset_ = "scrollViewWillEndDragging:withVelocity:targetContentOffset:";
		static readonly IntPtr selScrollViewWillEndDraggingWithVelocityTargetContentOffset_Handle = Selector.GetHandle ("scrollViewWillEndDragging:withVelocity:targetContentOffset:");
		[CompilerGenerated]
		const string selScrollViewDidEndDraggingWillDecelerate_ = "scrollViewDidEndDragging:willDecelerate:";
		static readonly IntPtr selScrollViewDidEndDraggingWillDecelerate_Handle = Selector.GetHandle ("scrollViewDidEndDragging:willDecelerate:");
		[CompilerGenerated]
		const string selScrollViewWillBeginDecelerating_ = "scrollViewWillBeginDecelerating:";
		static readonly IntPtr selScrollViewWillBeginDecelerating_Handle = Selector.GetHandle ("scrollViewWillBeginDecelerating:");
		[CompilerGenerated]
		const string selScrollViewDidEndDecelerating_ = "scrollViewDidEndDecelerating:";
		static readonly IntPtr selScrollViewDidEndDecelerating_Handle = Selector.GetHandle ("scrollViewDidEndDecelerating:");
		[CompilerGenerated]
		const string selScrollViewDidEndScrollingAnimation_ = "scrollViewDidEndScrollingAnimation:";
		static readonly IntPtr selScrollViewDidEndScrollingAnimation_Handle = Selector.GetHandle ("scrollViewDidEndScrollingAnimation:");
		[CompilerGenerated]
		const string selViewForZoomingInScrollView_ = "viewForZoomingInScrollView:";
		static readonly IntPtr selViewForZoomingInScrollView_Handle = Selector.GetHandle ("viewForZoomingInScrollView:");
		[CompilerGenerated]
		const string selScrollViewWillBeginZoomingWithView_ = "scrollViewWillBeginZooming:withView:";
		static readonly IntPtr selScrollViewWillBeginZoomingWithView_Handle = Selector.GetHandle ("scrollViewWillBeginZooming:withView:");
		[CompilerGenerated]
		const string selScrollViewDidEndZoomingWithViewAtScale_ = "scrollViewDidEndZooming:withView:atScale:";
		static readonly IntPtr selScrollViewDidEndZoomingWithViewAtScale_Handle = Selector.GetHandle ("scrollViewDidEndZooming:withView:atScale:");
		[CompilerGenerated]
		const string selScrollViewShouldScrollToTop_ = "scrollViewShouldScrollToTop:";
		static readonly IntPtr selScrollViewShouldScrollToTop_Handle = Selector.GetHandle ("scrollViewShouldScrollToTop:");
		[CompilerGenerated]
		const string selScrollViewDidScrollToTop_ = "scrollViewDidScrollToTop:";
		static readonly IntPtr selScrollViewDidScrollToTop_Handle = Selector.GetHandle ("scrollViewDidScrollToTop:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFTabBarView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFTabBarView () : base (NSObjectFlag.Empty)
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
		public PSPDFTabBarView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFTabBarView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("reloadData")]
		[CompilerGenerated]
		public virtual void ReloadData ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selReloadDataHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selReloadDataHandle);
			}
		}
		
		[Export ("selectTabAtIndex:animated:")]
		[CompilerGenerated]
		public virtual void SelectTabAtIndex (global::System.UInt32 index, bool animated)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_UInt32_bool (this.Handle, selSelectTabAtIndexAnimated_Handle, index, animated);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32_bool (this.SuperHandle, selSelectTabAtIndexAnimated_Handle, index, animated);
			}
		}
		
		[Export ("scrollToTabAtIndex:animated:")]
		[CompilerGenerated]
		public virtual void ScrollToTabAtIndex (global::System.UInt32 index, bool animated)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_UInt32_bool (this.Handle, selScrollToTabAtIndexAnimated_Handle, index, animated);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32_bool (this.SuperHandle, selScrollToTabAtIndexAnimated_Handle, index, animated);
			}
		}
		
		[Export ("selectTabAtIndex:animated:callDelegate:")]
		[CompilerGenerated]
		public virtual void SelectTabAtIndex (global::System.UInt32 index, bool animated, bool callDelegate)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_UInt32_bool_bool (this.Handle, selSelectTabAtIndexAnimatedCallDelegate_Handle, index, animated, callDelegate);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32_bool_bool (this.SuperHandle, selSelectTabAtIndexAnimatedCallDelegate_Handle, index, animated, callDelegate);
			}
		}
		
		[Export ("scrollViewDidScroll:")]
		[CompilerGenerated]
		public virtual void ScrollViewDidScroll (global::MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScrollViewDidScroll_Handle, scrollView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selScrollViewDidScroll_Handle, scrollView.Handle);
			}
		}
		
		[Export ("scrollViewDidZoom:")]
		[CompilerGenerated]
		public virtual void ScrollViewDidZoom (global::MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScrollViewDidZoom_Handle, scrollView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selScrollViewDidZoom_Handle, scrollView.Handle);
			}
		}
		
		[Export ("scrollViewWillBeginDragging:")]
		[CompilerGenerated]
		public virtual void ScrollViewWillBeginDragging (global::MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScrollViewWillBeginDragging_Handle, scrollView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selScrollViewWillBeginDragging_Handle, scrollView.Handle);
			}
		}
		
		[Export ("scrollViewWillEndDragging:withVelocity:targetContentOffset:")]
		[CompilerGenerated]
		public virtual void ScrollViewWillEndDragging (global::MonoTouch.UIKit.UIScrollView scrollView, global::System.Drawing.PointF velocity, ref global::System.Drawing.PointF targetContentOffset)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_PointF_out_PointF (this.Handle, selScrollViewWillEndDraggingWithVelocityTargetContentOffset_Handle, scrollView.Handle, velocity, out targetContentOffset);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_PointF_out_PointF (this.SuperHandle, selScrollViewWillEndDraggingWithVelocityTargetContentOffset_Handle, scrollView.Handle, velocity, out targetContentOffset);
			}
		}
		
		[Export ("scrollViewDidEndDragging:willDecelerate:")]
		[CompilerGenerated]
		public virtual void ScrollViewDidEndDragging (global::MonoTouch.UIKit.UIScrollView scrollView, bool decelerate)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selScrollViewDidEndDraggingWillDecelerate_Handle, scrollView.Handle, decelerate);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selScrollViewDidEndDraggingWillDecelerate_Handle, scrollView.Handle, decelerate);
			}
		}
		
		[Export ("scrollViewWillBeginDecelerating:")]
		[CompilerGenerated]
		public virtual void ScrollViewWillBeginDecelerating (global::MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScrollViewWillBeginDecelerating_Handle, scrollView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selScrollViewWillBeginDecelerating_Handle, scrollView.Handle);
			}
		}
		
		[Export ("scrollViewDidEndDecelerating:")]
		[CompilerGenerated]
		public virtual void ScrollViewDidEndDecelerating (global::MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScrollViewDidEndDecelerating_Handle, scrollView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selScrollViewDidEndDecelerating_Handle, scrollView.Handle);
			}
		}
		
		[Export ("scrollViewDidEndScrollingAnimation:")]
		[CompilerGenerated]
		public virtual void ScrollViewDidEndScrollingAnimation (global::MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScrollViewDidEndScrollingAnimation_Handle, scrollView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selScrollViewDidEndScrollingAnimation_Handle, scrollView.Handle);
			}
		}
		
		[Export ("viewForZoomingInScrollView:")]
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIView ViewForZoomingInScrollView (global::MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				return (global::MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selViewForZoomingInScrollView_Handle, scrollView.Handle));
			} else {
				return (global::MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selViewForZoomingInScrollView_Handle, scrollView.Handle));
			}
		}
		
		[Export ("scrollViewWillBeginZooming:withView:")]
		[CompilerGenerated]
		public virtual void ScrollViewWillBeginZooming (global::MonoTouch.UIKit.UIScrollView scrollView, global::MonoTouch.UIKit.UIView view)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (view == null)
				throw new ArgumentNullException ("view");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selScrollViewWillBeginZoomingWithView_Handle, scrollView.Handle, view.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selScrollViewWillBeginZoomingWithView_Handle, scrollView.Handle, view.Handle);
			}
		}
		
		[Export ("scrollViewDidEndZooming:withView:atScale:")]
		[CompilerGenerated]
		public virtual void ScrollViewDidEndZooming (global::MonoTouch.UIKit.UIScrollView scrollView, global::MonoTouch.UIKit.UIView view, float scale)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (view == null)
				throw new ArgumentNullException ("view");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_float (this.Handle, selScrollViewDidEndZoomingWithViewAtScale_Handle, scrollView.Handle, view.Handle, scale);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_float (this.SuperHandle, selScrollViewDidEndZoomingWithViewAtScale_Handle, scrollView.Handle, view.Handle, scale);
			}
		}
		
		[Export ("scrollViewShouldScrollToTop:")]
		[CompilerGenerated]
		public virtual bool ScrollViewShouldScrollToTop (global::MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selScrollViewShouldScrollToTop_Handle, scrollView.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selScrollViewShouldScrollToTop_Handle, scrollView.Handle);
			}
		}
		
		[Export ("scrollViewDidScrollToTop:")]
		[CompilerGenerated]
		public virtual void ScrollViewDidScrollToTop (global::MonoTouch.UIKit.UIScrollView scrollView)
		{
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScrollViewDidScrollToTop_Handle, scrollView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selScrollViewDidScrollToTop_Handle, scrollView.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 SelectedTabIndex {
			[Export ("selectedTabIndex")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selSelectedTabIndexHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selSelectedTabIndexHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual float MinTabWidth {
			[Export ("minTabWidth", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMinTabWidthHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selMinTabWidthHandle);
				}
			}
			
			[Export ("setMinTabWidth:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMinTabWidth_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetMinTabWidth_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public PSPDFTabBarViewDelegate Delegate {
			get {
				return WeakDelegate as PSPDFTabBarViewDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public PSPDFTabBarViewDataSource DataSource {
			get {
				return WeakDataSource as PSPDFTabBarViewDataSource;
			}
			set {
				WeakDataSource = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDataSource_var;
		[CompilerGenerated]
		public virtual NSObject WeakDataSource {
			[Export ("dataSource", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDataSourceHandle));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDataSourceHandle));
				}
				MarkDirty ();
				__mt_WeakDataSource_var = ret;
				return ret;
			}
			
			[Export ("setDataSource:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDataSource_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDataSource_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDataSource_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_ScrollView_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIScrollView ScrollView {
			[Export ("scrollView")]
			get {
				global::MonoTouch.UIKit.UIScrollView ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIScrollView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selScrollViewHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIScrollView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selScrollViewHandle));
				}
				MarkDirty ();
				__mt_ScrollView_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
				__mt_WeakDataSource_var = null;
				__mt_ScrollView_var = null;
			}
		}
	} /* class PSPDFTabBarView */
}
