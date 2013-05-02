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
	[Register("PSPDFSearchHighlightView", true)]
	public unsafe partial class PSPDFSearchHighlightView : global::MonoTouch.UIKit.UIView {
		[CompilerGenerated]
		const string selSearchResult = "searchResult";
		static readonly IntPtr selSearchResultHandle = Selector.GetHandle ("searchResult");
		[CompilerGenerated]
		const string selSetSearchResult_ = "setSearchResult:";
		static readonly IntPtr selSetSearchResult_Handle = Selector.GetHandle ("setSearchResult:");
		[CompilerGenerated]
		const string selSelectionBackgroundColor = "selectionBackgroundColor";
		static readonly IntPtr selSelectionBackgroundColorHandle = Selector.GetHandle ("selectionBackgroundColor");
		[CompilerGenerated]
		const string selSetSelectionBackgroundColor_ = "setSelectionBackgroundColor:";
		static readonly IntPtr selSetSelectionBackgroundColor_Handle = Selector.GetHandle ("setSelectionBackgroundColor:");
		[CompilerGenerated]
		const string selAnnotation = "annotation";
		static readonly IntPtr selAnnotationHandle = Selector.GetHandle ("annotation");
		[CompilerGenerated]
		const string selSetAnnotation_ = "setAnnotation:";
		static readonly IntPtr selSetAnnotation_Handle = Selector.GetHandle ("setAnnotation:");
		[CompilerGenerated]
		const string selInitWithSearchResult_ = "initWithSearchResult:";
		static readonly IntPtr selInitWithSearchResult_Handle = Selector.GetHandle ("initWithSearchResult:");
		[CompilerGenerated]
		const string selPopupAnimation = "popupAnimation";
		static readonly IntPtr selPopupAnimationHandle = Selector.GetHandle ("popupAnimation");
		[CompilerGenerated]
		const string selWillShowPage_ = "willShowPage:";
		static readonly IntPtr selWillShowPage_Handle = Selector.GetHandle ("willShowPage:");
		[CompilerGenerated]
		const string selDidShowPage_ = "didShowPage:";
		static readonly IntPtr selDidShowPage_Handle = Selector.GetHandle ("didShowPage:");
		[CompilerGenerated]
		const string selWillHidePage_ = "willHidePage:";
		static readonly IntPtr selWillHidePage_Handle = Selector.GetHandle ("willHidePage:");
		[CompilerGenerated]
		const string selDidHidePage_ = "didHidePage:";
		static readonly IntPtr selDidHidePage_Handle = Selector.GetHandle ("didHidePage:");
		[CompilerGenerated]
		const string selDidChangePageFrame_ = "didChangePageFrame:";
		static readonly IntPtr selDidChangePageFrame_Handle = Selector.GetHandle ("didChangePageFrame:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSearchHighlightView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFSearchHighlightView () : base (NSObjectFlag.Empty)
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
		public PSPDFSearchHighlightView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFSearchHighlightView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFSearchHighlightView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithSearchResult:")]
		[CompilerGenerated]
		public PSPDFSearchHighlightView (PSPDFSearchResult searchResult)
			: base (NSObjectFlag.Empty)
		{
			if (searchResult == null)
				throw new ArgumentNullException ("searchResult");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithSearchResult_Handle, searchResult.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithSearchResult_Handle, searchResult.Handle);
			}
		}
		
		[Export ("popupAnimation")]
		[CompilerGenerated]
		public virtual void PopupAnimation ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPopupAnimationHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selPopupAnimationHandle);
			}
		}
		
		[Export ("willShowPage:")]
		[CompilerGenerated]
		public virtual void WillShowPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selWillShowPage_Handle, page);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selWillShowPage_Handle, page);
			}
		}
		
		[Export ("didShowPage:")]
		[CompilerGenerated]
		public virtual void DidShowPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selDidShowPage_Handle, page);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selDidShowPage_Handle, page);
			}
		}
		
		[Export ("willHidePage:")]
		[CompilerGenerated]
		public virtual void WillHidePage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selWillHidePage_Handle, page);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selWillHidePage_Handle, page);
			}
		}
		
		[Export ("didHidePage:")]
		[CompilerGenerated]
		public virtual void DidHidePage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selDidHidePage_Handle, page);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selDidHidePage_Handle, page);
			}
		}
		
		[Export ("didChangePageFrame:")]
		[CompilerGenerated]
		public virtual void DidChangePageFrame (global::System.Drawing.Rectangle frame)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_Rectangle (this.Handle, selDidChangePageFrame_Handle, frame);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_Rectangle (this.SuperHandle, selDidChangePageFrame_Handle, frame);
			}
		}
		
		[CompilerGenerated]
		object __mt_SearchResult_var;
		[CompilerGenerated]
		public virtual PSPDFSearchResult SearchResult {
			[Export ("searchResult")]
			get {
				PSPDFSearchResult ret;
				if (IsDirectBinding) {
					ret = (PSPDFSearchResult) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSearchResultHandle));
				} else {
					ret = (PSPDFSearchResult) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSearchResultHandle));
				}
				MarkDirty ();
				__mt_SearchResult_var = ret;
				return ret;
			}
			
			[Export ("setSearchResult:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSearchResult_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSearchResult_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_SearchResult_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_SelectionBackgroundColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor SelectionBackgroundColor {
			[Export ("selectionBackgroundColor")]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectionBackgroundColorHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSelectionBackgroundColorHandle));
				}
				MarkDirty ();
				__mt_SelectionBackgroundColor_var = ret;
				return ret;
			}
			
			[Export ("setSelectionBackgroundColor:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSelectionBackgroundColor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSelectionBackgroundColor_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_SelectionBackgroundColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Annotation_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotation Annotation {
			[Export ("annotation")]
			get {
				PSPDFAnnotation ret;
				if (IsDirectBinding) {
					ret = (PSPDFAnnotation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAnnotationHandle));
				} else {
					ret = (PSPDFAnnotation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAnnotationHandle));
				}
				MarkDirty ();
				__mt_Annotation_var = ret;
				return ret;
			}
			
			[Export ("setAnnotation:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAnnotation_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAnnotation_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Annotation_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_SearchResult_var = null;
				__mt_SelectionBackgroundColor_var = null;
				__mt_Annotation_var = null;
			}
		}
	} /* class PSPDFSearchHighlightView */
}
