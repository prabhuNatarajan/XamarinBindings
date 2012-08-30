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
	[Register("PSPDFTextSelectionView", true)]
	public unsafe partial class PSPDFTextSelectionView : MonoTouch.UIKit.UIView {
		static readonly IntPtr selSelectedGlyphs = Selector.GetHandle ("selectedGlyphs");
		static readonly IntPtr selSetSelectedGlyphs_ = Selector.GetHandle ("setSelectedGlyphs:");
		static readonly IntPtr selSelectedText = Selector.GetHandle ("selectedText");
		static readonly IntPtr selSetSelectedText_ = Selector.GetHandle ("setSelectedText:");
		static readonly IntPtr selTrimmedSelectedText = Selector.GetHandle ("trimmedSelectedText");
		static readonly IntPtr selSelectedInk = Selector.GetHandle ("selectedInk");
		static readonly IntPtr selSetSelectedInk_ = Selector.GetHandle ("setSelectedInk:");
		static readonly IntPtr selSelectedAnnotation = Selector.GetHandle ("selectedAnnotation");
		static readonly IntPtr selSetSelectedAnnotation_ = Selector.GetHandle ("setSelectedAnnotation:");
		static readonly IntPtr selLoupeView = Selector.GetHandle ("loupeView");
		static readonly IntPtr selSetLoupeView_ = Selector.GetHandle ("setLoupeView:");
		static readonly IntPtr selPageView = Selector.GetHandle ("pageView");
		static readonly IntPtr selSetPageView_ = Selector.GetHandle ("setPageView:");
		static readonly IntPtr selHasSelection = Selector.GetHandle ("hasSelection");
		static readonly IntPtr selShowLoupe = Selector.GetHandle ("showLoupe");
		static readonly IntPtr selHideLoupe = Selector.GetHandle ("hideLoupe");
		static readonly IntPtr selDiscardSelection = Selector.GetHandle ("discardSelection");
		static readonly IntPtr selDiscardInkSelection = Selector.GetHandle ("discardInkSelection");
		static readonly IntPtr selLongPress_ = Selector.GetHandle ("longPress:");
		static readonly IntPtr selShouldHandleLongPressWithRecognizer_ = Selector.GetHandle ("shouldHandleLongPressWithRecognizer:");
		static readonly IntPtr selUpdateSelectionHandleSize = Selector.GetHandle ("updateSelectionHandleSize");
		static readonly IntPtr selShowTextFlowDataAnimated_ = Selector.GetHandle ("showTextFlowData:animated:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFTextSelectionView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFTextSelectionView () : base (NSObjectFlag.Empty)
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
		public PSPDFTextSelectionView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFTextSelectionView (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFTextSelectionView (IntPtr handle) : base (handle) {}

		[Export ("showLoupe")]
		[CompilerGenerated]
		public virtual void ShowLoupe ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selShowLoupe);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selShowLoupe);
			}
		}
		
		[Export ("hideLoupe")]
		[CompilerGenerated]
		public virtual void HideLoupe ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selHideLoupe);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selHideLoupe);
			}
		}
		
		[Export ("discardSelection")]
		[CompilerGenerated]
		public virtual void DiscardSelection ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDiscardSelection);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selDiscardSelection);
			}
		}
		
		[Export ("discardInkSelection")]
		[CompilerGenerated]
		public virtual void DiscardInkSelection ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDiscardInkSelection);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selDiscardInkSelection);
			}
		}
		
		[Export ("longPress:")]
		[CompilerGenerated]
		public virtual void LongPress (MonoTouch.UIKit.UILongPressGestureRecognizer recognizer)
		{
			if (recognizer == null)
				throw new ArgumentNullException ("recognizer");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selLongPress_, recognizer.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selLongPress_, recognizer.Handle);
			}
		}
		
		[Export ("shouldHandleLongPressWithRecognizer:")]
		[CompilerGenerated]
		public virtual bool ShouldHandleLongPressWithRecognizer (MonoTouch.UIKit.UILongPressGestureRecognizer recognizer)
		{
			if (recognizer == null)
				throw new ArgumentNullException ("recognizer");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selShouldHandleLongPressWithRecognizer_, recognizer.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selShouldHandleLongPressWithRecognizer_, recognizer.Handle);
			}
		}
		
		[Export ("updateSelectionHandleSize")]
		[CompilerGenerated]
		public virtual void UpdateSelectionHandleSize ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateSelectionHandleSize);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selUpdateSelectionHandleSize);
			}
		}
		
		[Export ("showTextFlowData:animated:")]
		[CompilerGenerated]
		public virtual void ShowTextFlowData (bool show, bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool_bool (this.Handle, selShowTextFlowDataAnimated_, show, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_bool (this.SuperHandle, selShowTextFlowDataAnimated_, show, animated);
			}
		}
		
		object __mt_SelectedGlyphs_var;
		[CompilerGenerated]
		public virtual PSPDFGlyph[] SelectedGlyphs {
			[Export ("selectedGlyphs")]
			get {
				PSPDFGlyph[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFGlyph>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectedGlyphs));
				} else {
					ret = NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFGlyph>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSelectedGlyphs));
				}
				MarkDirty ();
				__mt_SelectedGlyphs_var = ret;
				return ret;
			}
			
			[Export ("setSelectedGlyphs:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSelectedGlyphs_, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSelectedGlyphs_, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				MarkDirty ();
				__mt_SelectedGlyphs_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string SelectedText {
			[Export ("selectedText")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectedText));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSelectedText));
				}
			}
			
			[Export ("setSelectedText:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSelectedText_, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSelectedText_, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string TrimmedSelectedText {
			[Export ("trimmedSelectedText")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTrimmedSelectedText));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTrimmedSelectedText));
				}
			}
			
		}
		
		object __mt_SelectedInk_var;
		[CompilerGenerated]
		public virtual PSPDFInkAnnotation SelectedInk {
			[Export ("selectedInk")]
			get {
				PSPDFInkAnnotation ret;
				if (IsDirectBinding) {
					ret = (PSPDFInkAnnotation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectedInk));
				} else {
					ret = (PSPDFInkAnnotation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSelectedInk));
				}
				MarkDirty ();
				__mt_SelectedInk_var = ret;
				return ret;
			}
			
			[Export ("setSelectedInk:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSelectedInk_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSelectedInk_, value.Handle);
				}
				MarkDirty ();
				__mt_SelectedInk_var = value;
			}
		}
		
		object __mt_SelectedAnnotation_var;
		[CompilerGenerated]
		public virtual PSPDFHighlightAnnotation SelectedAnnotation {
			[Export ("selectedAnnotation")]
			get {
				PSPDFHighlightAnnotation ret;
				if (IsDirectBinding) {
					ret = (PSPDFHighlightAnnotation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectedAnnotation));
				} else {
					ret = (PSPDFHighlightAnnotation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSelectedAnnotation));
				}
				MarkDirty ();
				__mt_SelectedAnnotation_var = ret;
				return ret;
			}
			
			[Export ("setSelectedAnnotation:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSelectedAnnotation_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSelectedAnnotation_, value.Handle);
				}
				MarkDirty ();
				__mt_SelectedAnnotation_var = value;
			}
		}
		
		object __mt_LoupeView_var;
		[CompilerGenerated]
		public virtual PSPDFLoupeView LoupeView {
			[Export ("loupeView")]
			get {
				PSPDFLoupeView ret;
				if (IsDirectBinding) {
					ret = (PSPDFLoupeView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLoupeView));
				} else {
					ret = (PSPDFLoupeView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLoupeView));
				}
				MarkDirty ();
				__mt_LoupeView_var = ret;
				return ret;
			}
			
			[Export ("setLoupeView:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLoupeView_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLoupeView_, value.Handle);
				}
				MarkDirty ();
				__mt_LoupeView_var = value;
			}
		}
		
		object __mt_PageView_var;
		[CompilerGenerated]
		public virtual PSPDFPageView PageView {
			[Export ("pageView")]
			get {
				PSPDFPageView ret;
				if (IsDirectBinding) {
					ret = (PSPDFPageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPageView));
				} else {
					ret = (PSPDFPageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPageView));
				}
				MarkDirty ();
				__mt_PageView_var = ret;
				return ret;
			}
			
			[Export ("setPageView:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPageView_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPageView_, value.Handle);
				}
				MarkDirty ();
				__mt_PageView_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool HasSelection {
			[Export ("hasSelection")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasSelection);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selHasSelection);
				}
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_SelectedGlyphs_var = null;
			__mt_SelectedInk_var = null;
			__mt_SelectedAnnotation_var = null;
			__mt_LoupeView_var = null;
			__mt_PageView_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFTextSelectionView */
}
