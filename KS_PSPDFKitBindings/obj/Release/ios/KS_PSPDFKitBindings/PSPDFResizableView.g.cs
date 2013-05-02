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
	[Register("PSPDFResizableView", true)]
	public unsafe partial class PSPDFResizableView : global::MonoTouch.UIKit.UIView {
		[CompilerGenerated]
		const string selTrackedView = "trackedView";
		static readonly IntPtr selTrackedViewHandle = Selector.GetHandle ("trackedView");
		[CompilerGenerated]
		const string selSetTrackedView_ = "setTrackedView:";
		static readonly IntPtr selSetTrackedView_Handle = Selector.GetHandle ("setTrackedView:");
		[CompilerGenerated]
		const string selZoomScale = "zoomScale";
		static readonly IntPtr selZoomScaleHandle = Selector.GetHandle ("zoomScale");
		[CompilerGenerated]
		const string selSetZoomScale_ = "setZoomScale:";
		static readonly IntPtr selSetZoomScale_Handle = Selector.GetHandle ("setZoomScale:");
		[CompilerGenerated]
		const string selAllowEditing = "allowEditing";
		static readonly IntPtr selAllowEditingHandle = Selector.GetHandle ("allowEditing");
		[CompilerGenerated]
		const string selSetAllowEditing_ = "setAllowEditing:";
		static readonly IntPtr selSetAllowEditing_Handle = Selector.GetHandle ("setAllowEditing:");
		[CompilerGenerated]
		const string selAllowResizing = "allowResizing";
		static readonly IntPtr selAllowResizingHandle = Selector.GetHandle ("allowResizing");
		[CompilerGenerated]
		const string selSetAllowResizing_ = "setAllowResizing:";
		static readonly IntPtr selSetAllowResizing_Handle = Selector.GetHandle ("setAllowResizing:");
		[CompilerGenerated]
		const string selGuideSnapAllowance = "guideSnapAllowance";
		static readonly IntPtr selGuideSnapAllowanceHandle = Selector.GetHandle ("guideSnapAllowance");
		[CompilerGenerated]
		const string selSetGuideSnapAllowance_ = "setGuideSnapAllowance:";
		static readonly IntPtr selSetGuideSnapAllowance_Handle = Selector.GetHandle ("setGuideSnapAllowance:");
		[CompilerGenerated]
		const string selEnableResizingGuides = "enableResizingGuides";
		static readonly IntPtr selEnableResizingGuidesHandle = Selector.GetHandle ("enableResizingGuides");
		[CompilerGenerated]
		const string selSetEnableResizingGuides_ = "setEnableResizingGuides:";
		static readonly IntPtr selSetEnableResizingGuides_Handle = Selector.GetHandle ("setEnableResizingGuides:");
		[CompilerGenerated]
		const string selMinWidth = "minWidth";
		static readonly IntPtr selMinWidthHandle = Selector.GetHandle ("minWidth");
		[CompilerGenerated]
		const string selSetMinWidth_ = "setMinWidth:";
		static readonly IntPtr selSetMinWidth_Handle = Selector.GetHandle ("setMinWidth:");
		[CompilerGenerated]
		const string selMinHeight = "minHeight";
		static readonly IntPtr selMinHeightHandle = Selector.GetHandle ("minHeight");
		[CompilerGenerated]
		const string selSetMinHeight_ = "setMinHeight:";
		static readonly IntPtr selSetMinHeight_Handle = Selector.GetHandle ("setMinHeight:");
		[CompilerGenerated]
		const string selPreventsPositionOutsideSuperview = "preventsPositionOutsideSuperview";
		static readonly IntPtr selPreventsPositionOutsideSuperviewHandle = Selector.GetHandle ("preventsPositionOutsideSuperview");
		[CompilerGenerated]
		const string selSetPreventsPositionOutsideSuperview_ = "setPreventsPositionOutsideSuperview:";
		static readonly IntPtr selSetPreventsPositionOutsideSuperview_Handle = Selector.GetHandle ("setPreventsPositionOutsideSuperview:");
		[CompilerGenerated]
		const string selSelectionBorderColor = "selectionBorderColor";
		static readonly IntPtr selSelectionBorderColorHandle = Selector.GetHandle ("selectionBorderColor");
		[CompilerGenerated]
		const string selSetSelectionBorderColor_ = "setSelectionBorderColor:";
		static readonly IntPtr selSetSelectionBorderColor_Handle = Selector.GetHandle ("setSelectionBorderColor:");
		[CompilerGenerated]
		const string selActiveKnobType = "activeKnobType";
		static readonly IntPtr selActiveKnobTypeHandle = Selector.GetHandle ("activeKnobType");
		[CompilerGenerated]
		const string selSetActiveKnobType_ = "setActiveKnobType:";
		static readonly IntPtr selSetActiveKnobType_Handle = Selector.GetHandle ("setActiveKnobType:");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selKnobTopLeft = "knobTopLeft";
		static readonly IntPtr selKnobTopLeftHandle = Selector.GetHandle ("knobTopLeft");
		[CompilerGenerated]
		const string selKnobTopMiddle = "knobTopMiddle";
		static readonly IntPtr selKnobTopMiddleHandle = Selector.GetHandle ("knobTopMiddle");
		[CompilerGenerated]
		const string selKnobTopRight = "knobTopRight";
		static readonly IntPtr selKnobTopRightHandle = Selector.GetHandle ("knobTopRight");
		[CompilerGenerated]
		const string selKnobMiddleLeft = "knobMiddleLeft";
		static readonly IntPtr selKnobMiddleLeftHandle = Selector.GetHandle ("knobMiddleLeft");
		[CompilerGenerated]
		const string selKnobMiddleRight = "knobMiddleRight";
		static readonly IntPtr selKnobMiddleRightHandle = Selector.GetHandle ("knobMiddleRight");
		[CompilerGenerated]
		const string selKnobBottomLeft = "knobBottomLeft";
		static readonly IntPtr selKnobBottomLeftHandle = Selector.GetHandle ("knobBottomLeft");
		[CompilerGenerated]
		const string selKnobBottomMiddle = "knobBottomMiddle";
		static readonly IntPtr selKnobBottomMiddleHandle = Selector.GetHandle ("knobBottomMiddle");
		[CompilerGenerated]
		const string selKnobBottomRight = "knobBottomRight";
		static readonly IntPtr selKnobBottomRightHandle = Selector.GetHandle ("knobBottomRight");
		[CompilerGenerated]
		const string selInitWithTrackedView_ = "initWithTrackedView:";
		static readonly IntPtr selInitWithTrackedView_Handle = Selector.GetHandle ("initWithTrackedView:");
		[CompilerGenerated]
		const string selLongPress_ = "longPress:";
		static readonly IntPtr selLongPress_Handle = Selector.GetHandle ("longPress:");
		[CompilerGenerated]
		const string selPressRecognizerShouldHandlePressImmediately_ = "pressRecognizerShouldHandlePressImmediately:";
		static readonly IntPtr selPressRecognizerShouldHandlePressImmediately_Handle = Selector.GetHandle ("pressRecognizerShouldHandlePressImmediately:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFResizableView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFResizableView () : base (NSObjectFlag.Empty)
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
		public PSPDFResizableView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFResizableView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFResizableView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithTrackedView:")]
		[CompilerGenerated]
		public PSPDFResizableView (global::MonoTouch.UIKit.UIView trackedView)
			: base (NSObjectFlag.Empty)
		{
			if (trackedView == null)
				throw new ArgumentNullException ("trackedView");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithTrackedView_Handle, trackedView.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithTrackedView_Handle, trackedView.Handle);
			}
		}
		
		[Export ("longPress:")]
		[CompilerGenerated]
		public virtual bool LongPress (global::MonoTouch.UIKit.UILongPressGestureRecognizer recognizer)
		{
			if (recognizer == null)
				throw new ArgumentNullException ("recognizer");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selLongPress_Handle, recognizer.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selLongPress_Handle, recognizer.Handle);
			}
		}
		
		[Export ("pressRecognizerShouldHandlePressImmediately:")]
		[CompilerGenerated]
		public virtual bool PressRecognizerShouldHandlePressImmediately (PSPDFLongPressGestureRecognizer recognizer)
		{
			if (recognizer == null)
				throw new ArgumentNullException ("recognizer");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selPressRecognizerShouldHandlePressImmediately_Handle, recognizer.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selPressRecognizerShouldHandlePressImmediately_Handle, recognizer.Handle);
			}
		}
		
		[CompilerGenerated]
		object __mt_TrackedView_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIView TrackedView {
			[Export ("trackedView")]
			get {
				global::MonoTouch.UIKit.UIView ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTrackedViewHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTrackedViewHandle));
				}
				MarkDirty ();
				__mt_TrackedView_var = ret;
				return ret;
			}
			
			[Export ("setTrackedView:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTrackedView_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTrackedView_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_TrackedView_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual float ZoomScale {
			[Export ("zoomScale", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selZoomScaleHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selZoomScaleHandle);
				}
			}
			
			[Export ("setZoomScale:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetZoomScale_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetZoomScale_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AllowEditing {
			[Export ("allowEditing", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowEditingHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAllowEditingHandle);
				}
			}
			
			[Export ("setAllowEditing:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowEditing_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAllowEditing_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AllowResizing {
			[Export ("allowResizing", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowResizingHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAllowResizingHandle);
				}
			}
			
			[Export ("setAllowResizing:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowResizing_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAllowResizing_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool GuideSnapAllowance {
			[Export ("guideSnapAllowance", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selGuideSnapAllowanceHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selGuideSnapAllowanceHandle);
				}
			}
			
			[Export ("setGuideSnapAllowance:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetGuideSnapAllowance_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetGuideSnapAllowance_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool EnableResizingGuides {
			[Export ("enableResizingGuides", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selEnableResizingGuidesHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selEnableResizingGuidesHandle);
				}
			}
			
			[Export ("setEnableResizingGuides:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetEnableResizingGuides_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetEnableResizingGuides_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float MinWidth {
			[Export ("minWidth", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMinWidthHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selMinWidthHandle);
				}
			}
			
			[Export ("setMinWidth:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMinWidth_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetMinWidth_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float MinHeight {
			[Export ("minHeight", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMinHeightHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selMinHeightHandle);
				}
			}
			
			[Export ("setMinHeight:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMinHeight_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetMinHeight_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool PreventsPositionOutsideSuperview {
			[Export ("preventsPositionOutsideSuperview", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selPreventsPositionOutsideSuperviewHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selPreventsPositionOutsideSuperviewHandle);
				}
			}
			
			[Export ("setPreventsPositionOutsideSuperview:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPreventsPositionOutsideSuperview_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetPreventsPositionOutsideSuperview_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_SelectionBorderColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor SelectionBorderColor {
			[Export ("selectionBorderColor")]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectionBorderColorHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSelectionBorderColorHandle));
				}
				MarkDirty ();
				__mt_SelectionBorderColor_var = ret;
				return ret;
			}
			
			[Export ("setSelectionBorderColor:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSelectionBorderColor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSelectionBorderColor_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_SelectionBorderColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFSelectionBorderKnobType ActiveKnobType {
			[Export ("activeKnobType", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFSelectionBorderKnobType) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selActiveKnobTypeHandle);
				} else {
					return (PSPDFSelectionBorderKnobType) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selActiveKnobTypeHandle);
				}
			}
			
			[Export ("setActiveKnobType:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetActiveKnobType_Handle, (UInt32)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetActiveKnobType_Handle, (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		public PSPDFResizableViewDelegate Delegate {
			get {
				return WeakDelegate as PSPDFResizableViewDelegate;
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
		object __mt_KnobTopLeft_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIImageView KnobTopLeft {
			[Export ("knobTopLeft")]
			get {
				global::MonoTouch.UIKit.UIImageView ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selKnobTopLeftHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selKnobTopLeftHandle));
				}
				MarkDirty ();
				__mt_KnobTopLeft_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_KnobTopMiddle_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIImageView KnobTopMiddle {
			[Export ("knobTopMiddle")]
			get {
				global::MonoTouch.UIKit.UIImageView ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selKnobTopMiddleHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selKnobTopMiddleHandle));
				}
				MarkDirty ();
				__mt_KnobTopMiddle_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_KnobTopRight_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIImageView KnobTopRight {
			[Export ("knobTopRight")]
			get {
				global::MonoTouch.UIKit.UIImageView ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selKnobTopRightHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selKnobTopRightHandle));
				}
				MarkDirty ();
				__mt_KnobTopRight_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_KnobMiddleLeft_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIImageView KnobMiddleLeft {
			[Export ("knobMiddleLeft")]
			get {
				global::MonoTouch.UIKit.UIImageView ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selKnobMiddleLeftHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selKnobMiddleLeftHandle));
				}
				MarkDirty ();
				__mt_KnobMiddleLeft_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_KnobMiddleRight_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIImageView KnobMiddleRight {
			[Export ("knobMiddleRight")]
			get {
				global::MonoTouch.UIKit.UIImageView ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selKnobMiddleRightHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selKnobMiddleRightHandle));
				}
				MarkDirty ();
				__mt_KnobMiddleRight_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_KnobBottomLeft_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIImageView KnobBottomLeft {
			[Export ("knobBottomLeft")]
			get {
				global::MonoTouch.UIKit.UIImageView ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selKnobBottomLeftHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selKnobBottomLeftHandle));
				}
				MarkDirty ();
				__mt_KnobBottomLeft_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_KnobBottomMiddle_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIImageView KnobBottomMiddle {
			[Export ("knobBottomMiddle")]
			get {
				global::MonoTouch.UIKit.UIImageView ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selKnobBottomMiddleHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selKnobBottomMiddleHandle));
				}
				MarkDirty ();
				__mt_KnobBottomMiddle_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_KnobBottomRight_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIImageView KnobBottomRight {
			[Export ("knobBottomRight")]
			get {
				global::MonoTouch.UIKit.UIImageView ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selKnobBottomRightHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIImageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selKnobBottomRightHandle));
				}
				MarkDirty ();
				__mt_KnobBottomRight_var = ret;
				return ret;
			}
			
		}
		
		//
		// Events and properties from the delegate
		//
		
		_PSPDFResizableViewDelegate EnsurePSPDFResizableViewDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _PSPDFResizableViewDelegate))){
				del = new _PSPDFResizableViewDelegate ();
				WeakDelegate = del;
			}
			return (_PSPDFResizableViewDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _PSPDFResizableViewDelegate : KS_PSPDFKitBindings.PSPDFResizableViewDelegate { 
			public _PSPDFResizableViewDelegate () {}
			
			internal EventHandler didBeginEditing;
			[Preserve (Conditional = true)]
			public override void DidBeginEditing (KS_PSPDFKitBindings.PSPDFResizableView resizableView)
			{
				EventHandler handler = didBeginEditing;
				if (handler != null){
					handler (resizableView, EventArgs.Empty);
				}
			}
			
			internal EventHandler changedFrame;
			[Preserve (Conditional = true)]
			public override void ChangedFrame (KS_PSPDFKitBindings.PSPDFResizableView resizableView)
			{
				EventHandler handler = changedFrame;
				if (handler != null){
					handler (resizableView, EventArgs.Empty);
				}
			}
			
			internal EventHandler didEndEditing;
			[Preserve (Conditional = true)]
			public override void DidEndEditing (KS_PSPDFKitBindings.PSPDFResizableView resizableView)
			{
				EventHandler handler = didEndEditing;
				if (handler != null){
					handler (resizableView, EventArgs.Empty);
				}
			}
			
		}
		#pragma warning restore 672
		
		public event EventHandler DidBeginEditing {
			add { EnsurePSPDFResizableViewDelegate ().didBeginEditing += value; }
			remove { EnsurePSPDFResizableViewDelegate ().didBeginEditing -= value; }
		}
		
		public event EventHandler ChangedFrame {
			add { EnsurePSPDFResizableViewDelegate ().changedFrame += value; }
			remove { EnsurePSPDFResizableViewDelegate ().changedFrame -= value; }
		}
		
		public event EventHandler DidEndEditing {
			add { EnsurePSPDFResizableViewDelegate ().didEndEditing += value; }
			remove { EnsurePSPDFResizableViewDelegate ().didEndEditing -= value; }
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_TrackedView_var = null;
				__mt_SelectionBorderColor_var = null;
				__mt_WeakDelegate_var = null;
				__mt_KnobTopLeft_var = null;
				__mt_KnobTopMiddle_var = null;
				__mt_KnobTopRight_var = null;
				__mt_KnobMiddleLeft_var = null;
				__mt_KnobMiddleRight_var = null;
				__mt_KnobBottomLeft_var = null;
				__mt_KnobBottomMiddle_var = null;
				__mt_KnobBottomRight_var = null;
			}
		}
	} /* class PSPDFResizableView */
}
