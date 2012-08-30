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
	[Register("PSPDFSearchOperation", true)]
	public unsafe partial class PSPDFSearchOperation : NSOperation {
		static readonly IntPtr selSelectionSearchPages = Selector.GetHandle ("selectionSearchPages");
		static readonly IntPtr selSetSelectionSearchPages_ = Selector.GetHandle ("setSelectionSearchPages:");
		static readonly IntPtr selSearchPages = Selector.GetHandle ("searchPages");
		static readonly IntPtr selSetSearchPages_ = Selector.GetHandle ("setSearchPages:");
		static readonly IntPtr selSearchText = Selector.GetHandle ("searchText");
		static readonly IntPtr selPageTextDict = Selector.GetHandle ("pageTextDict");
		static readonly IntPtr selSetPageTextDict_ = Selector.GetHandle ("setPageTextDict:");
		static readonly IntPtr selSearchResults = Selector.GetHandle ("searchResults");
		static readonly IntPtr selDocument = Selector.GetHandle ("document");
		static readonly IntPtr selDelegate = Selector.GetHandle ("delegate");
		static readonly IntPtr selSetDelegate_ = Selector.GetHandle ("setDelegate:");
		static readonly IntPtr selSearchMode = Selector.GetHandle ("searchMode");
		static readonly IntPtr selSetSearchMode_ = Selector.GetHandle ("setSearchMode:");
		static readonly IntPtr selCompareOptions = Selector.GetHandle ("compareOptions");
		static readonly IntPtr selSetCompareOptions_ = Selector.GetHandle ("setCompareOptions:");
		static readonly IntPtr selInitWithDocumentSearchText_ = Selector.GetHandle ("initWithDocument:searchText:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSearchOperation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFSearchOperation () : base (NSObjectFlag.Empty)
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
		public PSPDFSearchOperation (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFSearchOperation (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFSearchOperation (IntPtr handle) : base (handle) {}

		[Export ("initWithDocument:searchText:")]
		[CompilerGenerated]
		public PSPDFSearchOperation (PSPDFDocument document, string searchText) : base (NSObjectFlag.Empty)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (searchText == null)
				throw new ArgumentNullException ("searchText");
			var nssearchText = NSString.CreateNative (searchText);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithDocumentSearchText_, document.Handle, nssearchText);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithDocumentSearchText_, document.Handle, nssearchText);
			}
			NSString.ReleaseNative (nssearchText);
			
		}
		
		object __mt_SelectionSearchPages_var;
		[CompilerGenerated]
		public virtual NSArray SelectionSearchPages {
			[Export ("selectionSearchPages", ArgumentSemantic.Copy)]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectionSearchPages));
				} else {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSelectionSearchPages));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SelectionSearchPages_var = ret;
				return ret;
			}
			
			[Export ("setSelectionSearchPages:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSelectionSearchPages_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSelectionSearchPages_, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_SelectionSearchPages_var = value;
			}
		}
		
		object __mt_SearchPages_var;
		[CompilerGenerated]
		public virtual NSArray SearchPages {
			[Export ("searchPages", ArgumentSemantic.Copy)]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSearchPages));
				} else {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSearchPages));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SearchPages_var = ret;
				return ret;
			}
			
			[Export ("setSearchPages:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSearchPages_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSearchPages_, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_SearchPages_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string SearchText {
			[Export ("searchText", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSearchText));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSearchText));
				}
			}
			
		}
		
		object __mt_PageTextDict_var;
		[CompilerGenerated]
		public virtual NSDictionary PageTextDict {
			[Export ("pageTextDict")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPageTextDict));
				} else {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPageTextDict));
				}
				MarkDirty ();
				__mt_PageTextDict_var = ret;
				return ret;
			}
			
			[Export ("setPageTextDict:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPageTextDict_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPageTextDict_, value.Handle);
				}
				MarkDirty ();
				__mt_PageTextDict_var = value;
			}
		}
		
		object __mt_SearchResults_var;
		[CompilerGenerated]
		public virtual PSPDFSearchResult[] SearchResults {
			[Export ("searchResults")]
			get {
				PSPDFSearchResult[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFSearchResult>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSearchResults));
				} else {
					ret = NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFSearchResult>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSearchResults));
				}
				MarkDirty ();
				__mt_SearchResults_var = ret;
				return ret;
			}
			
		}
		
		object __mt_Document_var;
		[CompilerGenerated]
		public virtual PSPDFDocument Document {
			[Export ("document")]
			get {
				PSPDFDocument ret;
				if (IsDirectBinding) {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocument));
				} else {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocument));
				}
				MarkDirty ();
				__mt_Document_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public PSPDFSearchOperationDelegate Delegate {
			get { return WeakDelegate as PSPDFSearchOperationDelegate; }
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
		public virtual PSPDFSearchMode SearchMode {
			[Export ("searchMode", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFSearchMode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selSearchMode);
				} else {
					return (PSPDFSearchMode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selSearchMode);
				}
			}
			
			[Export ("setSearchMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetSearchMode_, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetSearchMode_, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSStringCompareOptions CompareOptions {
			[Export ("compareOptions", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (NSStringCompareOptions) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selCompareOptions);
				} else {
					return (NSStringCompareOptions) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selCompareOptions);
				}
			}
			
			[Export ("setCompareOptions:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetCompareOptions_, (UInt32)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetCompareOptions_, (UInt32)value);
				}
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_SelectionSearchPages_var = null;
			__mt_SearchPages_var = null;
			__mt_PageTextDict_var = null;
			__mt_SearchResults_var = null;
			__mt_Document_var = null;
			__mt_WeakDelegate_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFSearchOperation */
}
