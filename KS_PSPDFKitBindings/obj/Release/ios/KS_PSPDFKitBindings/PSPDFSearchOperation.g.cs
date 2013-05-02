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
	[Register("PSPDFSearchOperation", true)]
	public unsafe partial class PSPDFSearchOperation : NSOperation {
		[CompilerGenerated]
		const string selPageRanges = "pageRanges";
		static readonly IntPtr selPageRangesHandle = Selector.GetHandle ("pageRanges");
		[CompilerGenerated]
		const string selSetPageRanges_ = "setPageRanges:";
		static readonly IntPtr selSetPageRanges_Handle = Selector.GetHandle ("setPageRanges:");
		[CompilerGenerated]
		const string selShouldSearchAllPages = "shouldSearchAllPages";
		static readonly IntPtr selShouldSearchAllPagesHandle = Selector.GetHandle ("shouldSearchAllPages");
		[CompilerGenerated]
		const string selSetShouldSearchAllPages_ = "setShouldSearchAllPages:";
		static readonly IntPtr selSetShouldSearchAllPages_Handle = Selector.GetHandle ("setShouldSearchAllPages:");
		[CompilerGenerated]
		const string selSearchMode = "searchMode";
		static readonly IntPtr selSearchModeHandle = Selector.GetHandle ("searchMode");
		[CompilerGenerated]
		const string selSetSearchMode_ = "setSearchMode:";
		static readonly IntPtr selSetSearchMode_Handle = Selector.GetHandle ("setSearchMode:");
		[CompilerGenerated]
		const string selCompareOptions = "compareOptions";
		static readonly IntPtr selCompareOptionsHandle = Selector.GetHandle ("compareOptions");
		[CompilerGenerated]
		const string selSetCompareOptions_ = "setCompareOptions:";
		static readonly IntPtr selSetCompareOptions_Handle = Selector.GetHandle ("setCompareOptions:");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selSearchResults = "searchResults";
		static readonly IntPtr selSearchResultsHandle = Selector.GetHandle ("searchResults");
		[CompilerGenerated]
		const string selSearchTerm = "searchTerm";
		static readonly IntPtr selSearchTermHandle = Selector.GetHandle ("searchTerm");
		[CompilerGenerated]
		const string selDocument = "document";
		static readonly IntPtr selDocumentHandle = Selector.GetHandle ("document");
		[CompilerGenerated]
		const string selInitWithDocumentSearchTerm_ = "initWithDocument:searchTerm:";
		static readonly IntPtr selInitWithDocumentSearchTerm_Handle = Selector.GetHandle ("initWithDocument:searchTerm:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSearchOperation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFSearchOperation () : base (NSObjectFlag.Empty)
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
		public PSPDFSearchOperation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFSearchOperation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDocument:searchTerm:")]
		[CompilerGenerated]
		public PSPDFSearchOperation (PSPDFDocument document, string searchTerm)
			: base (NSObjectFlag.Empty)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (searchTerm == null)
				throw new ArgumentNullException ("searchTerm");
			var nssearchTerm = NSString.CreateNative (searchTerm);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithDocumentSearchTerm_Handle, document.Handle, nssearchTerm);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithDocumentSearchTerm_Handle, document.Handle, nssearchTerm);
			}
			NSString.ReleaseNative (nssearchTerm);
			
		}
		
		[CompilerGenerated]
		object __mt_PageRanges_var;
		[CompilerGenerated]
		public virtual NSIndexSet PageRanges {
			[Export ("pageRanges", ArgumentSemantic.Copy)]
			get {
				NSIndexSet ret;
				if (IsDirectBinding) {
					ret = (NSIndexSet) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPageRangesHandle));
				} else {
					ret = (NSIndexSet) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPageRangesHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PageRanges_var = ret;
				return ret;
			}
			
			[Export ("setPageRanges:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPageRanges_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPageRanges_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_PageRanges_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldSearchAllPages {
			[Export ("shouldSearchAllPages", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldSearchAllPagesHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShouldSearchAllPagesHandle);
				}
			}
			
			[Export ("setShouldSearchAllPages:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldSearchAllPages_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShouldSearchAllPages_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFSearchMode SearchMode {
			[Export ("searchMode", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFSearchMode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selSearchModeHandle);
				} else {
					return (PSPDFSearchMode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selSearchModeHandle);
				}
			}
			
			[Export ("setSearchMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetSearchMode_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetSearchMode_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSStringCompareOptions CompareOptions {
			[Export ("compareOptions", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (NSStringCompareOptions) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selCompareOptionsHandle);
				} else {
					return (NSStringCompareOptions) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selCompareOptionsHandle);
				}
			}
			
			[Export ("setCompareOptions:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetCompareOptions_Handle, (UInt32)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetCompareOptions_Handle, (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		public PSPDFSearchOperationDelegate Delegate {
			get {
				return WeakDelegate as PSPDFSearchOperationDelegate;
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
		object __mt_SearchResults_var;
		[CompilerGenerated]
		public virtual PSPDFSearchResult[] SearchResults {
			[Export ("searchResults", ArgumentSemantic.Copy)]
			get {
				PSPDFSearchResult[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFSearchResult>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSearchResultsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFSearchResult>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSearchResultsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SearchResults_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string SearchTerm {
			[Export ("searchTerm", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSearchTermHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSearchTermHandle));
				}
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
			
		}
		
		//
		// Events and properties from the delegate
		//
		
		_PSPDFSearchOperationDelegate EnsurePSPDFSearchOperationDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _PSPDFSearchOperationDelegate))){
				del = new _PSPDFSearchOperationDelegate ();
				WeakDelegate = del;
			}
			return (_PSPDFSearchOperationDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _PSPDFSearchOperationDelegate : KS_PSPDFKitBindings.PSPDFSearchOperationDelegate { 
			public _PSPDFSearchOperationDelegate () {}
			
			internal EventHandler<PSPDFSearchOperationDidUpdateSearchOperationEventArgs> didUpdateSearchOperation;
			[Preserve (Conditional = true)]
			public override void DidUpdateSearchOperation (KS_PSPDFKitBindings.PSPDFSearchOperation operation, string searchTerm, KS_PSPDFKitBindings.PSPDFSearchResult[] searchResults, uint page)
			{
				EventHandler<PSPDFSearchOperationDidUpdateSearchOperationEventArgs> handler = didUpdateSearchOperation;
				if (handler != null){
					var args = new PSPDFSearchOperationDidUpdateSearchOperationEventArgs (searchTerm, searchResults, page);
					handler (operation, args);
				}
			}
			
			internal EventHandler<PSPDFSearchOperationWillStartSearchOperationEventArgs> willStartSearchOperation;
			[Preserve (Conditional = true)]
			public override void WillStartSearchOperation (KS_PSPDFKitBindings.PSPDFSearchOperation operation, string searchTerm, bool isFullSearch)
			{
				EventHandler<PSPDFSearchOperationWillStartSearchOperationEventArgs> handler = willStartSearchOperation;
				if (handler != null){
					var args = new PSPDFSearchOperationWillStartSearchOperationEventArgs (searchTerm, isFullSearch);
					handler (operation, args);
				}
			}
			
		}
		#pragma warning restore 672
		
		public event EventHandler<PSPDFSearchOperationDidUpdateSearchOperationEventArgs> DidUpdateSearchOperation {
			add { EnsurePSPDFSearchOperationDelegate ().didUpdateSearchOperation += value; }
			remove { EnsurePSPDFSearchOperationDelegate ().didUpdateSearchOperation -= value; }
		}
		
		public event EventHandler<PSPDFSearchOperationWillStartSearchOperationEventArgs> WillStartSearchOperation {
			add { EnsurePSPDFSearchOperationDelegate ().willStartSearchOperation += value; }
			remove { EnsurePSPDFSearchOperationDelegate ().willStartSearchOperation -= value; }
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_PageRanges_var = null;
				__mt_WeakDelegate_var = null;
				__mt_SearchResults_var = null;
				__mt_Document_var = null;
			}
		}
	} /* class PSPDFSearchOperation */
	
	
	//
	// EventArgs classes
	//
	public partial class PSPDFSearchOperationDidUpdateSearchOperationEventArgs : EventArgs {
		public PSPDFSearchOperationDidUpdateSearchOperationEventArgs (string searchTerm, KS_PSPDFKitBindings.PSPDFSearchResult[] searchResults, uint page)
		{
			this.SearchTerm = searchTerm;
			this.SearchResults = searchResults;
			this.Page = page;
		}
		public string SearchTerm { get; set; }
		public KS_PSPDFKitBindings.PSPDFSearchResult[] SearchResults { get; set; }
		public uint Page { get; set; }
	}
	
	public partial class PSPDFSearchOperationWillStartSearchOperationEventArgs : EventArgs {
		public PSPDFSearchOperationWillStartSearchOperationEventArgs (string searchTerm, bool isFullSearch)
		{
			this.SearchTerm = searchTerm;
			this.IsFullSearch = isFullSearch;
		}
		public string SearchTerm { get; set; }
		public bool IsFullSearch { get; set; }
	}
	
}
