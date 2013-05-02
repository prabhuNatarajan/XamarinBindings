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
	[Register("PSPDFSelectionView", true)]
	public unsafe partial class PSPDFSelectionView : global::MonoTouch.UIKit.UIView {
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selSelectionColor = "selectionColor";
		static readonly IntPtr selSelectionColorHandle = Selector.GetHandle ("selectionColor");
		[CompilerGenerated]
		const string selSetSelectionColor_ = "setSelectionColor:";
		static readonly IntPtr selSetSelectionColor_Handle = Selector.GetHandle ("setSelectionColor:");
		[CompilerGenerated]
		const string selWordSelectionColor = "wordSelectionColor";
		static readonly IntPtr selWordSelectionColorHandle = Selector.GetHandle ("wordSelectionColor");
		[CompilerGenerated]
		const string selSetWordSelectionColor_ = "setWordSelectionColor:";
		static readonly IntPtr selSetWordSelectionColor_Handle = Selector.GetHandle ("setWordSelectionColor:");
		[CompilerGenerated]
		const string selRects = "rects";
		static readonly IntPtr selRectsHandle = Selector.GetHandle ("rects");
		[CompilerGenerated]
		const string selSetRects_ = "setRects:";
		static readonly IntPtr selSetRects_Handle = Selector.GetHandle ("setRects:");
		[CompilerGenerated]
		const string selInitWithFrameDelegate_ = "initWithFrame:delegate:";
		static readonly IntPtr selInitWithFrameDelegate_Handle = Selector.GetHandle ("initWithFrame:delegate:");
		[CompilerGenerated]
		const string selSetRawRectsCount_ = "setRawRects:count:";
		static readonly IntPtr selSetRawRectsCount_Handle = Selector.GetHandle ("setRawRects:count:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSelectionView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFSelectionView () : base (NSObjectFlag.Empty)
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
		public PSPDFSelectionView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFSelectionView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFSelectionView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:delegate:")]
		[CompilerGenerated]
		public PSPDFSelectionView (global::System.Drawing.RectangleF frame, PSPDFSelectionViewDelegate Delegate)
			: base (NSObjectFlag.Empty)
		{
			if (Delegate == null)
				throw new ArgumentNullException ("Delegate");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_RectangleF_IntPtr (this.Handle, selInitWithFrameDelegate_Handle, frame, Delegate.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_RectangleF_IntPtr (this.SuperHandle, selInitWithFrameDelegate_Handle, frame, Delegate.Handle);
			}
		}
		
		[Export ("setRawRects:count:")]
		[CompilerGenerated]
		public virtual void SetRawRects (global::System.Drawing.RectangleF rawRects, global::System.UInt32 count)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_RectangleF_UInt32 (this.Handle, selSetRawRectsCount_Handle, rawRects, count);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_RectangleF_UInt32 (this.SuperHandle, selSetRawRectsCount_Handle, rawRects, count);
			}
		}
		
		[CompilerGenerated]
		public PSPDFSelectionViewDelegate Delegate {
			get {
				return WeakDelegate as PSPDFSelectionViewDelegate;
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
		object __mt_SelectionColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor SelectionColor {
			[Export ("selectionColor")]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectionColorHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSelectionColorHandle));
				}
				MarkDirty ();
				__mt_SelectionColor_var = ret;
				return ret;
			}
			
			[Export ("setSelectionColor:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSelectionColor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSelectionColor_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_SelectionColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_WordSelectionColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor WordSelectionColor {
			[Export ("wordSelectionColor")]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selWordSelectionColorHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selWordSelectionColorHandle));
				}
				MarkDirty ();
				__mt_WordSelectionColor_var = ret;
				return ret;
			}
			
			[Export ("setWordSelectionColor:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetWordSelectionColor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetWordSelectionColor_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_WordSelectionColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Rects_var;
		[CompilerGenerated]
		public virtual NSArray Rects {
			[Export ("rects")]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRectsHandle));
				} else {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRectsHandle));
				}
				MarkDirty ();
				__mt_Rects_var = ret;
				return ret;
			}
			
			[Export ("setRects:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRects_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRects_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_Rects_var = value;
			}
		}
		
		//
		// Events and properties from the delegate
		//
		
		_PSPDFSelectionViewDelegate EnsurePSPDFSelectionViewDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _PSPDFSelectionViewDelegate))){
				del = new _PSPDFSelectionViewDelegate ();
				WeakDelegate = del;
			}
			return (_PSPDFSelectionViewDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _PSPDFSelectionViewDelegate : KS_PSPDFKitBindings.PSPDFSelectionViewDelegate { 
			public _PSPDFSelectionViewDelegate () {}
			
			internal PSPDFSelectionViewShouldStartSelectionAtPoint shouldStartSelectionAtPoint;
			[Preserve (Conditional = true)]
			public override bool ShouldStartSelectionAtPoint (KS_PSPDFKitBindings.PSPDFSelectionView selectionView, PointF point)
			{
				PSPDFSelectionViewShouldStartSelectionAtPoint handler = shouldStartSelectionAtPoint;
				if (handler != null)
					return handler (selectionView, point);
				return true;
			}
			
			internal EventHandler<PSPDFSelectionViewRectEventArgs> updateSelectedRect;
			[Preserve (Conditional = true)]
			public override void UpdateSelectedRect (KS_PSPDFKitBindings.PSPDFSelectionView selectionView, RectangleF rect)
			{
				EventHandler<PSPDFSelectionViewRectEventArgs> handler = updateSelectedRect;
				if (handler != null){
					var args = new PSPDFSelectionViewRectEventArgs (rect);
					handler (selectionView, args);
				}
			}
			
			internal EventHandler<PSPDFSelectionViewRectEventArgs> finishedWithSelectedRect;
			[Preserve (Conditional = true)]
			public override void FinishedWithSelectedRect (KS_PSPDFKitBindings.PSPDFSelectionView selectionView, RectangleF rect)
			{
				EventHandler<PSPDFSelectionViewRectEventArgs> handler = finishedWithSelectedRect;
				if (handler != null){
					var args = new PSPDFSelectionViewRectEventArgs (rect);
					handler (selectionView, args);
				}
			}
			
			internal EventHandler<PSPDFSelectionViewRectEventArgs> cancelledWithSelectedRect;
			[Preserve (Conditional = true)]
			public override void CancelledWithSelectedRect (KS_PSPDFKitBindings.PSPDFSelectionView selectionView, RectangleF rect)
			{
				EventHandler<PSPDFSelectionViewRectEventArgs> handler = cancelledWithSelectedRect;
				if (handler != null){
					var args = new PSPDFSelectionViewRectEventArgs (rect);
					handler (selectionView, args);
				}
			}
			
			internal EventHandler<PSPDFSelectionViewGestureEventArgs> singleTappedWithGestureRecognizer;
			[Preserve (Conditional = true)]
			public override void SingleTappedWithGestureRecognizer (KS_PSPDFKitBindings.PSPDFSelectionView selectionView, UITapGestureRecognizer recgestureRecognizert)
			{
				EventHandler<PSPDFSelectionViewGestureEventArgs> handler = singleTappedWithGestureRecognizer;
				if (handler != null){
					var args = new PSPDFSelectionViewGestureEventArgs (recgestureRecognizert);
					handler (selectionView, args);
				}
			}
			
		}
		#pragma warning restore 672
		
		public PSPDFSelectionViewShouldStartSelectionAtPoint ShouldStartSelectionAtPoint {
			get { return EnsurePSPDFSelectionViewDelegate ().shouldStartSelectionAtPoint; }
			set { EnsurePSPDFSelectionViewDelegate ().shouldStartSelectionAtPoint = value; }
		}
		
		public event EventHandler<PSPDFSelectionViewRectEventArgs> UpdateSelectedRect {
			add { EnsurePSPDFSelectionViewDelegate ().updateSelectedRect += value; }
			remove { EnsurePSPDFSelectionViewDelegate ().updateSelectedRect -= value; }
		}
		
		public event EventHandler<PSPDFSelectionViewRectEventArgs> FinishedWithSelectedRect {
			add { EnsurePSPDFSelectionViewDelegate ().finishedWithSelectedRect += value; }
			remove { EnsurePSPDFSelectionViewDelegate ().finishedWithSelectedRect -= value; }
		}
		
		public event EventHandler<PSPDFSelectionViewRectEventArgs> CancelledWithSelectedRect {
			add { EnsurePSPDFSelectionViewDelegate ().cancelledWithSelectedRect += value; }
			remove { EnsurePSPDFSelectionViewDelegate ().cancelledWithSelectedRect -= value; }
		}
		
		public event EventHandler<PSPDFSelectionViewGestureEventArgs> SingleTappedWithGestureRecognizer {
			add { EnsurePSPDFSelectionViewDelegate ().singleTappedWithGestureRecognizer += value; }
			remove { EnsurePSPDFSelectionViewDelegate ().singleTappedWithGestureRecognizer -= value; }
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
				__mt_SelectionColor_var = null;
				__mt_WordSelectionColor_var = null;
				__mt_Rects_var = null;
			}
		}
	} /* class PSPDFSelectionView */
	
	
	//
	// EventArgs classes
	//
	public partial class PSPDFSelectionViewRectEventArgs : EventArgs {
		public PSPDFSelectionViewRectEventArgs (RectangleF rect)
		{
			this.Rect = rect;
		}
		public RectangleF Rect { get; set; }
	}
	
	public partial class PSPDFSelectionViewGestureEventArgs : EventArgs {
		public PSPDFSelectionViewGestureEventArgs (UITapGestureRecognizer recgestureRecognizert)
		{
			this.RecgestureRecognizert = recgestureRecognizert;
		}
		public UITapGestureRecognizer RecgestureRecognizert { get; set; }
	}
	
}
