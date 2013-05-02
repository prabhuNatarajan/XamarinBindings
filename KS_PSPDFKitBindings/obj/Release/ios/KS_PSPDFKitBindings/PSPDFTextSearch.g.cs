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
	[Register("PSPDFTextSearch", true)]
	public unsafe partial class PSPDFTextSearch : NSObject {
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
		const string selDocument = "document";
		static readonly IntPtr selDocumentHandle = Selector.GetHandle ("document");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selSearchQueue_ = "searchQueue:";
		static readonly IntPtr selSearchQueue_Handle = Selector.GetHandle ("searchQueue:");
		[CompilerGenerated]
		const string selInitWithDocument_ = "initWithDocument:";
		static readonly IntPtr selInitWithDocument_Handle = Selector.GetHandle ("initWithDocument:");
		[CompilerGenerated]
		const string selSearchForString_ = "searchForString:";
		static readonly IntPtr selSearchForString_Handle = Selector.GetHandle ("searchForString:");
		[CompilerGenerated]
		const string selSearchForStringInRangesRangesOnly_ = "searchForString:inRanges:rangesOnly:";
		static readonly IntPtr selSearchForStringInRangesRangesOnly_Handle = Selector.GetHandle ("searchForString:inRanges:rangesOnly:");
		[CompilerGenerated]
		const string selCancelAllOperationsAndWait = "cancelAllOperationsAndWait";
		static readonly IntPtr selCancelAllOperationsAndWaitHandle = Selector.GetHandle ("cancelAllOperationsAndWait");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFTextSearch");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFTextSearch () : base (NSObjectFlag.Empty)
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
		public PSPDFTextSearch (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFTextSearch (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFTextSearch (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDocument:")]
		[CompilerGenerated]
		public PSPDFTextSearch (PSPDFDocument document)
			: base (NSObjectFlag.Empty)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithDocument_Handle, document.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithDocument_Handle, document.Handle);
			}
		}
		
		[Export ("searchForString:")]
		[CompilerGenerated]
		public virtual void SearchForString (string searchTerm)
		{
			if (searchTerm == null)
				throw new ArgumentNullException ("searchTerm");
			var nssearchTerm = NSString.CreateNative (searchTerm);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSearchForString_Handle, nssearchTerm);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchForString_Handle, nssearchTerm);
			}
			NSString.ReleaseNative (nssearchTerm);
			
		}
		
		[Export ("searchForString:inRanges:rangesOnly:")]
		[CompilerGenerated]
		public virtual void SearchForString (string searchTerm, NSIndexSet ranges, bool rangesOnly)
		{
			if (searchTerm == null)
				throw new ArgumentNullException ("searchTerm");
			if (ranges == null)
				throw new ArgumentNullException ("ranges");
			var nssearchTerm = NSString.CreateNative (searchTerm);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_bool (this.Handle, selSearchForStringInRangesRangesOnly_Handle, nssearchTerm, ranges.Handle, rangesOnly);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_bool (this.SuperHandle, selSearchForStringInRangesRangesOnly_Handle, nssearchTerm, ranges.Handle, rangesOnly);
			}
			NSString.ReleaseNative (nssearchTerm);
			
		}
		
		[Export ("cancelAllOperationsAndWait")]
		[CompilerGenerated]
		public virtual void CancelAllOperationsAndWait ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCancelAllOperationsAndWaitHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selCancelAllOperationsAndWaitHandle);
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
		
		[CompilerGenerated]
		public PSPDFTextSearchDelegate Delegate {
			get {
				return WeakDelegate as PSPDFTextSearchDelegate;
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
		object __mt_SearchQueue_var;
		[CompilerGenerated]
		public virtual NSOperationQueue SearchQueue {
			[Export ("searchQueue:")]
			get {
				NSOperationQueue ret;
				if (IsDirectBinding) {
					ret = (NSOperationQueue) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSearchQueue_Handle));
				} else {
					ret = (NSOperationQueue) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSearchQueue_Handle));
				}
				MarkDirty ();
				__mt_SearchQueue_var = ret;
				return ret;
			}
			
		}
		
		//
		// Events and properties from the delegate
		//
		
		_PSPDFTextSearchDelegate EnsurePSPDFTextSearchDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _PSPDFTextSearchDelegate))){
				del = new _PSPDFTextSearchDelegate ();
				WeakDelegate = del;
			}
			return (_PSPDFTextSearchDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _PSPDFTextSearchDelegate : KS_PSPDFKitBindings.PSPDFTextSearchDelegate { 
			public _PSPDFTextSearchDelegate () {}
			
			internal EventHandler<PSPDFTextSearchWillStartSearchEventArgs> willStartSearch;
			[Preserve (Conditional = true)]
			public override void WillStartSearch (KS_PSPDFKitBindings.PSPDFTextSearch textSearch, string searchTerm, bool isFullSearch)
			{
				EventHandler<PSPDFTextSearchWillStartSearchEventArgs> handler = willStartSearch;
				if (handler != null){
					var args = new PSPDFTextSearchWillStartSearchEventArgs (searchTerm, isFullSearch);
					handler (textSearch, args);
				}
			}
			
			internal EventHandler<PSPDFTextSearchDidUpdateSearchEventArgs> didUpdateSearch;
			[Preserve (Conditional = true)]
			public override void DidUpdateSearch (KS_PSPDFKitBindings.PSPDFTextSearch textSearch, string searchTerm, KS_PSPDFKitBindings.PSPDFSearchResult[] searchResults, uint page)
			{
				EventHandler<PSPDFTextSearchDidUpdateSearchEventArgs> handler = didUpdateSearch;
				if (handler != null){
					var args = new PSPDFTextSearchDidUpdateSearchEventArgs (searchTerm, searchResults, page);
					handler (textSearch, args);
				}
			}
			
			internal EventHandler<PSPDFTextSearchDidFinishSearchEventArgs> didFinishSearch;
			[Preserve (Conditional = true)]
			public override void DidFinishSearch (KS_PSPDFKitBindings.PSPDFTextSearch textSearch, string searchTerm, KS_PSPDFKitBindings.PSPDFSearchResult[] searchResults, bool isFullSearch)
			{
				EventHandler<PSPDFTextSearchDidFinishSearchEventArgs> handler = didFinishSearch;
				if (handler != null){
					var args = new PSPDFTextSearchDidFinishSearchEventArgs (searchTerm, searchResults, isFullSearch);
					handler (textSearch, args);
				}
			}
			
			internal EventHandler<PSPDFTextSearchDidCancelSearchEventArgs> didCancelSearch;
			[Preserve (Conditional = true)]
			public override void DidCancelSearch (KS_PSPDFKitBindings.PSPDFTextSearch textSearch, string searchTerm, bool isFullSearch)
			{
				EventHandler<PSPDFTextSearchDidCancelSearchEventArgs> handler = didCancelSearch;
				if (handler != null){
					var args = new PSPDFTextSearchDidCancelSearchEventArgs (searchTerm, isFullSearch);
					handler (textSearch, args);
				}
			}
			
		}
		#pragma warning restore 672
		
		public event EventHandler<PSPDFTextSearchWillStartSearchEventArgs> WillStartSearch {
			add { EnsurePSPDFTextSearchDelegate ().willStartSearch += value; }
			remove { EnsurePSPDFTextSearchDelegate ().willStartSearch -= value; }
		}
		
		public event EventHandler<PSPDFTextSearchDidUpdateSearchEventArgs> DidUpdateSearch {
			add { EnsurePSPDFTextSearchDelegate ().didUpdateSearch += value; }
			remove { EnsurePSPDFTextSearchDelegate ().didUpdateSearch -= value; }
		}
		
		public event EventHandler<PSPDFTextSearchDidFinishSearchEventArgs> DidFinishSearch {
			add { EnsurePSPDFTextSearchDelegate ().didFinishSearch += value; }
			remove { EnsurePSPDFTextSearchDelegate ().didFinishSearch -= value; }
		}
		
		public event EventHandler<PSPDFTextSearchDidCancelSearchEventArgs> DidCancelSearch {
			add { EnsurePSPDFTextSearchDelegate ().didCancelSearch += value; }
			remove { EnsurePSPDFTextSearchDelegate ().didCancelSearch -= value; }
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Document_var = null;
				__mt_WeakDelegate_var = null;
				__mt_SearchQueue_var = null;
			}
		}
	} /* class PSPDFTextSearch */
	
	
	//
	// EventArgs classes
	//
	public partial class PSPDFTextSearchWillStartSearchEventArgs : EventArgs {
		public PSPDFTextSearchWillStartSearchEventArgs (string searchTerm, bool isFullSearch)
		{
			this.SearchTerm = searchTerm;
			this.IsFullSearch = isFullSearch;
		}
		public string SearchTerm { get; set; }
		public bool IsFullSearch { get; set; }
	}
	
	public partial class PSPDFTextSearchDidUpdateSearchEventArgs : EventArgs {
		public PSPDFTextSearchDidUpdateSearchEventArgs (string searchTerm, KS_PSPDFKitBindings.PSPDFSearchResult[] searchResults, uint page)
		{
			this.SearchTerm = searchTerm;
			this.SearchResults = searchResults;
			this.Page = page;
		}
		public string SearchTerm { get; set; }
		public KS_PSPDFKitBindings.PSPDFSearchResult[] SearchResults { get; set; }
		public uint Page { get; set; }
	}
	
	public partial class PSPDFTextSearchDidFinishSearchEventArgs : EventArgs {
		public PSPDFTextSearchDidFinishSearchEventArgs (string searchTerm, KS_PSPDFKitBindings.PSPDFSearchResult[] searchResults, bool isFullSearch)
		{
			this.SearchTerm = searchTerm;
			this.SearchResults = searchResults;
			this.IsFullSearch = isFullSearch;
		}
		public string SearchTerm { get; set; }
		public KS_PSPDFKitBindings.PSPDFSearchResult[] SearchResults { get; set; }
		public bool IsFullSearch { get; set; }
	}
	
	public partial class PSPDFTextSearchDidCancelSearchEventArgs : EventArgs {
		public PSPDFTextSearchDidCancelSearchEventArgs (string searchTerm, bool isFullSearch)
		{
			this.SearchTerm = searchTerm;
			this.IsFullSearch = isFullSearch;
		}
		public string SearchTerm { get; set; }
		public bool IsFullSearch { get; set; }
	}
	
}
