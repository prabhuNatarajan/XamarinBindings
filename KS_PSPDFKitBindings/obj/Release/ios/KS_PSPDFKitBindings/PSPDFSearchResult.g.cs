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
	[Register("PSPDFSearchResult", true)]
	public unsafe partial class PSPDFSearchResult : PSPDFModel {
		[CompilerGenerated]
		const string selPageIndex = "pageIndex";
		static readonly IntPtr selPageIndexHandle = Selector.GetHandle ("pageIndex");
		[CompilerGenerated]
		const string selSetPageIndex_ = "setPageIndex:";
		static readonly IntPtr selSetPageIndex_Handle = Selector.GetHandle ("setPageIndex:");
		[CompilerGenerated]
		const string selPreviewText = "previewText";
		static readonly IntPtr selPreviewTextHandle = Selector.GetHandle ("previewText");
		[CompilerGenerated]
		const string selSetPreviewText_ = "setPreviewText:";
		static readonly IntPtr selSetPreviewText_Handle = Selector.GetHandle ("setPreviewText:");
		[CompilerGenerated]
		const string selSelection = "selection";
		static readonly IntPtr selSelectionHandle = Selector.GetHandle ("selection");
		[CompilerGenerated]
		const string selSetSelection_ = "setSelection:";
		static readonly IntPtr selSetSelection_Handle = Selector.GetHandle ("setSelection:");
		[CompilerGenerated]
		const string selRange = "range";
		static readonly IntPtr selRangeHandle = Selector.GetHandle ("range");
		[CompilerGenerated]
		const string selSetRange_ = "setRange:";
		static readonly IntPtr selSetRange_Handle = Selector.GetHandle ("setRange:");
		[CompilerGenerated]
		const string selRangeInPreviewText = "rangeInPreviewText";
		static readonly IntPtr selRangeInPreviewTextHandle = Selector.GetHandle ("rangeInPreviewText");
		[CompilerGenerated]
		const string selSetRangeInPreviewText_ = "setRangeInPreviewText:";
		static readonly IntPtr selSetRangeInPreviewText_Handle = Selector.GetHandle ("setRangeInPreviewText:");
		[CompilerGenerated]
		const string selCachedOutlineTitle = "cachedOutlineTitle";
		static readonly IntPtr selCachedOutlineTitleHandle = Selector.GetHandle ("cachedOutlineTitle");
		[CompilerGenerated]
		const string selSetCachedOutlineTitle_ = "setCachedOutlineTitle:";
		static readonly IntPtr selSetCachedOutlineTitle_Handle = Selector.GetHandle ("setCachedOutlineTitle:");
		[CompilerGenerated]
		const string selDocument = "document";
		static readonly IntPtr selDocumentHandle = Selector.GetHandle ("document");
		[CompilerGenerated]
		const string selSetDocument_ = "setDocument:";
		static readonly IntPtr selSetDocument_Handle = Selector.GetHandle ("setDocument:");
		[CompilerGenerated]
		const string selIsEqualToSearchResult = "isEqualToSearchResult";
		static readonly IntPtr selIsEqualToSearchResultHandle = Selector.GetHandle ("isEqualToSearchResult");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSearchResult");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFSearchResult () : base (NSObjectFlag.Empty)
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
		public PSPDFSearchResult (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFSearchResult (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFSearchResult (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("isEqualToSearchResult")]
		[CompilerGenerated]
		public virtual bool IsEqualToSearchResult (PSPDFSearchResult otherSearchResult)
		{
			if (otherSearchResult == null)
				throw new ArgumentNullException ("otherSearchResult");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsEqualToSearchResultHandle, otherSearchResult.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selIsEqualToSearchResultHandle, otherSearchResult.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 PageIndex {
			[Export ("pageIndex", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPageIndexHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selPageIndexHandle);
				}
			}
			
			[Export ("setPageIndex:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetPageIndex_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetPageIndex_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string PreviewText {
			[Export ("previewText", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPreviewTextHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPreviewTextHandle));
				}
			}
			
			[Export ("setPreviewText:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPreviewText_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPreviewText_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_Selection_var;
		[CompilerGenerated]
		public virtual PSPDFTextBlock Selection {
			[Export ("selection")]
			get {
				PSPDFTextBlock ret;
				if (IsDirectBinding) {
					ret = (PSPDFTextBlock) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectionHandle));
				} else {
					ret = (PSPDFTextBlock) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSelectionHandle));
				}
				MarkDirty ();
				__mt_Selection_var = ret;
				return ret;
			}
			
			[Export ("setSelection:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSelection_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSelection_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Selection_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual NSRange Range {
			[Export ("range", ArgumentSemantic.Assign)]
			get {
				NSRange ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.NSRange_objc_msgSend_stret (out ret, this.Handle, selRangeHandle);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, selRangeHandle);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_stret (out ret, this.SuperHandle, selRangeHandle);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.NSRange_objc_msgSendSuper (this.SuperHandle, selRangeHandle);
					}
				}
				return ret;
			}
			
			[Export ("setRange:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selSetRange_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (this.SuperHandle, selSetRange_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSRange RangeInPreviewText {
			[Export ("rangeInPreviewText", ArgumentSemantic.Assign)]
			get {
				NSRange ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.NSRange_objc_msgSend_stret (out ret, this.Handle, selRangeInPreviewTextHandle);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, selRangeInPreviewTextHandle);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_stret (out ret, this.SuperHandle, selRangeInPreviewTextHandle);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.NSRange_objc_msgSendSuper (this.SuperHandle, selRangeInPreviewTextHandle);
					}
				}
				return ret;
			}
			
			[Export ("setRangeInPreviewText:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selSetRangeInPreviewText_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (this.SuperHandle, selSetRangeInPreviewText_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string CachedOutlineTitle {
			[Export ("cachedOutlineTitle", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCachedOutlineTitleHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCachedOutlineTitleHandle));
				}
			}
			
			[Export ("setCachedOutlineTitle:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCachedOutlineTitle_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCachedOutlineTitle_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_Document_var;
		[CompilerGenerated]
		public virtual PSPDFDocument Document {
			[Export ("document")]
			get {
				PSPDFDocument ret;
				if (IsDirectBinding) {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocumentHandle));
				} else {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocumentHandle));
				}
				MarkDirty ();
				__mt_Document_var = ret;
				return ret;
			}
			
			[Export ("setDocument:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDocument_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDocument_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Document_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Selection_var = null;
				__mt_Document_var = null;
			}
		}
	} /* class PSPDFSearchResult */
}
