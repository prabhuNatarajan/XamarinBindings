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
	[Register("PSPDFTextSelectionView", true)]
	public unsafe partial class PSPDFTextSelectionView : global::MonoTouch.UIKit.UIView {
		[CompilerGenerated]
		const string selSelectedGlyphs = "selectedGlyphs";
		static readonly IntPtr selSelectedGlyphsHandle = Selector.GetHandle ("selectedGlyphs");
		[CompilerGenerated]
		const string selSetSelectedGlyphs_ = "setSelectedGlyphs:";
		static readonly IntPtr selSetSelectedGlyphs_Handle = Selector.GetHandle ("setSelectedGlyphs:");
		[CompilerGenerated]
		const string selSelectedText = "selectedText";
		static readonly IntPtr selSelectedTextHandle = Selector.GetHandle ("selectedText");
		[CompilerGenerated]
		const string selSetSelectedText_ = "setSelectedText:";
		static readonly IntPtr selSetSelectedText_Handle = Selector.GetHandle ("setSelectedText:");
		[CompilerGenerated]
		const string selSelectedImage = "selectedImage";
		static readonly IntPtr selSelectedImageHandle = Selector.GetHandle ("selectedImage");
		[CompilerGenerated]
		const string selSetSelectedImage_ = "setSelectedImage:";
		static readonly IntPtr selSetSelectedImage_Handle = Selector.GetHandle ("setSelectedImage:");
		[CompilerGenerated]
		const string selTrimmedSelectedText = "trimmedSelectedText";
		static readonly IntPtr selTrimmedSelectedTextHandle = Selector.GetHandle ("trimmedSelectedText");
		[CompilerGenerated]
		const string selPageView = "pageView";
		static readonly IntPtr selPageViewHandle = Selector.GetHandle ("pageView");
		[CompilerGenerated]
		const string selSetPageView_ = "setPageView:";
		static readonly IntPtr selSetPageView_Handle = Selector.GetHandle ("setPageView:");
		[CompilerGenerated]
		const string selFirstLineRect = "firstLineRect";
		static readonly IntPtr selFirstLineRectHandle = Selector.GetHandle ("firstLineRect");
		[CompilerGenerated]
		const string selLastLineRect = "lastLineRect";
		static readonly IntPtr selLastLineRectHandle = Selector.GetHandle ("lastLineRect");
		[CompilerGenerated]
		const string selSelectionRect = "selectionRect";
		static readonly IntPtr selSelectionRectHandle = Selector.GetHandle ("selectionRect");
		[CompilerGenerated]
		const string selHasSelection = "hasSelection";
		static readonly IntPtr selHasSelectionHandle = Selector.GetHandle ("hasSelection");
		[CompilerGenerated]
		const string selIsTextSelectionFeatureAvailable = "isTextSelectionFeatureAvailable";
		static readonly IntPtr selIsTextSelectionFeatureAvailableHandle = Selector.GetHandle ("isTextSelectionFeatureAvailable");
		[CompilerGenerated]
		const string selUpdateMenuAnimated_ = "updateMenuAnimated:";
		static readonly IntPtr selUpdateMenuAnimated_Handle = Selector.GetHandle ("updateMenuAnimated:");
		[CompilerGenerated]
		const string selUpdateSelection = "updateSelection";
		static readonly IntPtr selUpdateSelectionHandle = Selector.GetHandle ("updateSelection");
		[CompilerGenerated]
		const string selDiscardSelection = "discardSelection";
		static readonly IntPtr selDiscardSelectionHandle = Selector.GetHandle ("discardSelection");
		[CompilerGenerated]
		const string selMenuItemsForTextSelection_ = "menuItemsForTextSelection:";
		static readonly IntPtr selMenuItemsForTextSelection_Handle = Selector.GetHandle ("menuItemsForTextSelection:");
		[CompilerGenerated]
		const string selMenuItemsForImageSelection_ = "menuItemsForImageSelection:";
		static readonly IntPtr selMenuItemsForImageSelection_Handle = Selector.GetHandle ("menuItemsForImageSelection:");
		[CompilerGenerated]
		const string selShowTextFlowDataAnimated_ = "showTextFlowData:animated:";
		static readonly IntPtr selShowTextFlowDataAnimated_Handle = Selector.GetHandle ("showTextFlowData:animated:");
		[CompilerGenerated]
		const string selLongPress_ = "longPress:";
		static readonly IntPtr selLongPress_Handle = Selector.GetHandle ("longPress:");
		[CompilerGenerated]
		const string selPressRecognizerShouldHandlePressImmediately_ = "pressRecognizerShouldHandlePressImmediately:";
		static readonly IntPtr selPressRecognizerShouldHandlePressImmediately_Handle = Selector.GetHandle ("pressRecognizerShouldHandlePressImmediately:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFTextSelectionView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFTextSelectionView () : base (NSObjectFlag.Empty)
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
		public PSPDFTextSelectionView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFTextSelectionView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("updateMenuAnimated:")]
		[CompilerGenerated]
		public virtual bool UpdateMenuAnimated (bool animated)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_bool (this.Handle, selUpdateMenuAnimated_Handle, animated);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_bool (this.SuperHandle, selUpdateMenuAnimated_Handle, animated);
			}
		}
		
		[Export ("updateSelection")]
		[CompilerGenerated]
		public virtual void UpdateSelection ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateSelectionHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selUpdateSelectionHandle);
			}
		}
		
		[Export ("discardSelection")]
		[CompilerGenerated]
		public virtual void DiscardSelection ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDiscardSelectionHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selDiscardSelectionHandle);
			}
		}
		
		[CompilerGenerated]
		public PSPDFMenuItem[] MenuItemsForTextSelection (string selectedText)
		{
			if (selectedText == null)
				throw new ArgumentNullException ("selectedText");
			var nsselectedText = NSString.CreateNative (selectedText);
			
			PSPDFMenuItem[] ret;
			ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFMenuItem>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selMenuItemsForTextSelection_Handle, nsselectedText));
			NSString.ReleaseNative (nsselectedText);
			
			return ret;
		}
		
		[CompilerGenerated]
		public PSPDFMenuItem[] MenuItemsForImageSelection (PSPDFImageInfo imageSelection)
		{
			if (imageSelection == null)
				throw new ArgumentNullException ("imageSelection");
			return NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFMenuItem>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selMenuItemsForImageSelection_Handle, imageSelection.Handle));
		}
		
		[CompilerGenerated]
		public void ShowTextFlowData (bool show, bool animated)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool_bool (this.Handle, selShowTextFlowDataAnimated_Handle, show, animated);
		}
		
		[CompilerGenerated]
		public bool LongPress (global::MonoTouch.UIKit.UILongPressGestureRecognizer recognizer)
		{
			if (recognizer == null)
				throw new ArgumentNullException ("recognizer");
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selLongPress_Handle, recognizer.Handle);
		}
		
		[CompilerGenerated]
		public bool PressRecognizerShouldHandlePressImmediately (PSPDFLongPressGestureRecognizer recognizer)
		{
			if (recognizer == null)
				throw new ArgumentNullException ("recognizer");
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selPressRecognizerShouldHandlePressImmediately_Handle, recognizer.Handle);
		}
		
		[CompilerGenerated]
		object __mt_SelectedGlyphs_var;
		[CompilerGenerated]
		public virtual PSPDFGlyph[] SelectedGlyphs {
			[Export ("selectedGlyphs", ArgumentSemantic.Copy)]
			get {
				PSPDFGlyph[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFGlyph>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectedGlyphsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFGlyph>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSelectedGlyphsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SelectedGlyphs_var = ret;
				return ret;
			}
			
			[Export ("setSelectedGlyphs:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSelectedGlyphs_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSelectedGlyphs_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_SelectedGlyphs_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string SelectedText {
			[Export ("selectedText", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectedTextHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSelectedTextHandle));
				}
			}
			
			[Export ("setSelectedText:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSelectedText_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSelectedText_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_SelectedImage_var;
		[CompilerGenerated]
		public virtual PSPDFImageInfo SelectedImage {
			[Export ("selectedImage")]
			get {
				PSPDFImageInfo ret;
				if (IsDirectBinding) {
					ret = (PSPDFImageInfo) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectedImageHandle));
				} else {
					ret = (PSPDFImageInfo) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSelectedImageHandle));
				}
				MarkDirty ();
				__mt_SelectedImage_var = ret;
				return ret;
			}
			
			[Export ("setSelectedImage:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSelectedImage_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSelectedImage_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_SelectedImage_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string TrimmedSelectedText {
			[Export ("trimmedSelectedText", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTrimmedSelectedTextHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTrimmedSelectedTextHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PageView_var;
		[CompilerGenerated]
		public virtual PSPDFPageView PageView {
			[Export ("pageView")]
			get {
				PSPDFPageView ret;
				if (IsDirectBinding) {
					ret = (PSPDFPageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPageViewHandle));
				} else {
					ret = (PSPDFPageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPageViewHandle));
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
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPageView_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPageView_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_PageView_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Drawing.RectangleF FirstLineRect {
			[Export ("firstLineRect", ArgumentSemantic.Assign)]
			get {
				global::System.Drawing.RectangleF ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret (out ret, this.Handle, selFirstLineRectHandle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selFirstLineRectHandle);
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.Drawing.RectangleF LastLineRect {
			[Export ("lastLineRect", ArgumentSemantic.Assign)]
			get {
				global::System.Drawing.RectangleF ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret (out ret, this.Handle, selLastLineRectHandle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selLastLineRectHandle);
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.Drawing.RectangleF SelectionRect {
			[Export ("selectionRect", ArgumentSemantic.Assign)]
			get {
				global::System.Drawing.RectangleF ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret (out ret, this.Handle, selSelectionRectHandle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selSelectionRectHandle);
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool HasSelection {
			[Export ("hasSelection")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasSelectionHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selHasSelectionHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public static bool IsTextSelectionFeatureAvailable {
			[Export ("isTextSelectionFeatureAvailable")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsTextSelectionFeatureAvailableHandle);
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_SelectedGlyphs_var = null;
				__mt_SelectedImage_var = null;
				__mt_PageView_var = null;
			}
		}
	} /* class PSPDFTextSelectionView */
}
