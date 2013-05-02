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
	[Register("PSPDFSearchViewController", true)]
	public unsafe partial class PSPDFSearchViewController : global::MonoTouch.UIKit.UITableViewController {
		[CompilerGenerated]
		const string selSearchText = "searchText";
		static readonly IntPtr selSearchTextHandle = Selector.GetHandle ("searchText");
		[CompilerGenerated]
		const string selSetSearchText_ = "setSearchText:";
		static readonly IntPtr selSetSearchText_Handle = Selector.GetHandle ("setSearchText:");
		[CompilerGenerated]
		const string selShowsCancelButton = "showsCancelButton";
		static readonly IntPtr selShowsCancelButtonHandle = Selector.GetHandle ("showsCancelButton");
		[CompilerGenerated]
		const string selSetShowsCancelButton_ = "setShowsCancelButton:";
		static readonly IntPtr selSetShowsCancelButton_Handle = Selector.GetHandle ("setShowsCancelButton:");
		[CompilerGenerated]
		const string selSearchBar = "searchBar";
		static readonly IntPtr selSearchBarHandle = Selector.GetHandle ("searchBar");
		[CompilerGenerated]
		const string selSearchStatus = "searchStatus";
		static readonly IntPtr selSearchStatusHandle = Selector.GetHandle ("searchStatus");
		[CompilerGenerated]
		const string selClearHighlightsWhenClosed = "clearHighlightsWhenClosed";
		static readonly IntPtr selClearHighlightsWhenClosedHandle = Selector.GetHandle ("clearHighlightsWhenClosed");
		[CompilerGenerated]
		const string selSetClearHighlightsWhenClosed_ = "setClearHighlightsWhenClosed:";
		static readonly IntPtr selSetClearHighlightsWhenClosed_Handle = Selector.GetHandle ("setClearHighlightsWhenClosed:");
		[CompilerGenerated]
		const string selMaximumNumberOfSearchResultsDisplayed = "maximumNumberOfSearchResultsDisplayed";
		static readonly IntPtr selMaximumNumberOfSearchResultsDisplayedHandle = Selector.GetHandle ("maximumNumberOfSearchResultsDisplayed");
		[CompilerGenerated]
		const string selSetMaximumNumberOfSearchResultsDisplayed_ = "setMaximumNumberOfSearchResultsDisplayed:";
		static readonly IntPtr selSetMaximumNumberOfSearchResultsDisplayed_Handle = Selector.GetHandle ("setMaximumNumberOfSearchResultsDisplayed:");
		[CompilerGenerated]
		const string selSearchVisiblePagesFirst = "searchVisiblePagesFirst";
		static readonly IntPtr selSearchVisiblePagesFirstHandle = Selector.GetHandle ("searchVisiblePagesFirst");
		[CompilerGenerated]
		const string selSetSearchVisiblePagesFirst_ = "setSearchVisiblePagesFirst:";
		static readonly IntPtr selSetSearchVisiblePagesFirst_Handle = Selector.GetHandle ("setSearchVisiblePagesFirst:");
		[CompilerGenerated]
		const string selTextSearch = "textSearch";
		static readonly IntPtr selTextSearchHandle = Selector.GetHandle ("textSearch");
		[CompilerGenerated]
		const string selPdfController = "pdfController";
		static readonly IntPtr selPdfControllerHandle = Selector.GetHandle ("pdfController");
		[CompilerGenerated]
		const string selInitWithDocumentPdfController_ = "initWithDocument:pdfController:";
		static readonly IntPtr selInitWithDocumentPdfController_Handle = Selector.GetHandle ("initWithDocument:pdfController:");
		[CompilerGenerated]
		const string selUpdateResultCellSearchResult_ = "updateResultCell:searchResult:";
		static readonly IntPtr selUpdateResultCellSearchResult_Handle = Selector.GetHandle ("updateResultCell:searchResult:");
		[CompilerGenerated]
		const string selFilterContentForSearchTextScope_ = "filterContentForSearchText:scope:";
		static readonly IntPtr selFilterContentForSearchTextScope_Handle = Selector.GetHandle ("filterContentForSearchText:scope:");
		[CompilerGenerated]
		const string selSetSearchStatusUpdateTable_ = "setSearchStatus:updateTable:";
		static readonly IntPtr selSetSearchStatusUpdateTable_Handle = Selector.GetHandle ("setSearchStatus:updateTable:");
		[CompilerGenerated]
		const string selSearchResultsForIndexPath_ = "searchResultsForIndexPath:";
		static readonly IntPtr selSearchResultsForIndexPath_Handle = Selector.GetHandle ("searchResultsForIndexPath:");
		[CompilerGenerated]
		const string selDidFinishCachingDocument_ = "didFinishCachingDocument:";
		static readonly IntPtr selDidFinishCachingDocument_Handle = Selector.GetHandle ("didFinishCachingDocument:");
		[CompilerGenerated]
		const string selSearchDisplayControllerWillBeginSearch_ = "searchDisplayControllerWillBeginSearch:";
		static readonly IntPtr selSearchDisplayControllerWillBeginSearch_Handle = Selector.GetHandle ("searchDisplayControllerWillBeginSearch:");
		[CompilerGenerated]
		const string selSearchDisplayControllerDidBeginSearch_ = "searchDisplayControllerDidBeginSearch:";
		static readonly IntPtr selSearchDisplayControllerDidBeginSearch_Handle = Selector.GetHandle ("searchDisplayControllerDidBeginSearch:");
		[CompilerGenerated]
		const string selSearchDisplayControllerWillEndSearch_ = "searchDisplayControllerWillEndSearch:";
		static readonly IntPtr selSearchDisplayControllerWillEndSearch_Handle = Selector.GetHandle ("searchDisplayControllerWillEndSearch:");
		[CompilerGenerated]
		const string selSearchDisplayControllerDidEndSearch_ = "searchDisplayControllerDidEndSearch:";
		static readonly IntPtr selSearchDisplayControllerDidEndSearch_Handle = Selector.GetHandle ("searchDisplayControllerDidEndSearch:");
		[CompilerGenerated]
		const string selSearchDisplayControllerDidLoadSearchResultsTableView_ = "searchDisplayController:didLoadSearchResultsTableView:";
		static readonly IntPtr selSearchDisplayControllerDidLoadSearchResultsTableView_Handle = Selector.GetHandle ("searchDisplayController:didLoadSearchResultsTableView:");
		[CompilerGenerated]
		const string selSearchDisplayControllerWillUnloadSearchResultsTableView_ = "searchDisplayController:willUnloadSearchResultsTableView:";
		static readonly IntPtr selSearchDisplayControllerWillUnloadSearchResultsTableView_Handle = Selector.GetHandle ("searchDisplayController:willUnloadSearchResultsTableView:");
		[CompilerGenerated]
		const string selSearchDisplayControllerWillShowSearchResultsTableView_ = "searchDisplayController:willShowSearchResultsTableView:";
		static readonly IntPtr selSearchDisplayControllerWillShowSearchResultsTableView_Handle = Selector.GetHandle ("searchDisplayController:willShowSearchResultsTableView:");
		[CompilerGenerated]
		const string selSearchDisplayControllerDidShowSearchResultsTableView_ = "searchDisplayController:didShowSearchResultsTableView:";
		static readonly IntPtr selSearchDisplayControllerDidShowSearchResultsTableView_Handle = Selector.GetHandle ("searchDisplayController:didShowSearchResultsTableView:");
		[CompilerGenerated]
		const string selSearchDisplayControllerWillHideSearchResultsTableView_ = "searchDisplayController:willHideSearchResultsTableView:";
		static readonly IntPtr selSearchDisplayControllerWillHideSearchResultsTableView_Handle = Selector.GetHandle ("searchDisplayController:willHideSearchResultsTableView:");
		[CompilerGenerated]
		const string selSearchDisplayControllerDidHideSearchResultsTableView_ = "searchDisplayController:didHideSearchResultsTableView:";
		static readonly IntPtr selSearchDisplayControllerDidHideSearchResultsTableView_Handle = Selector.GetHandle ("searchDisplayController:didHideSearchResultsTableView:");
		[CompilerGenerated]
		const string selSearchDisplayControllerShouldReloadTableForSearchString_ = "searchDisplayController:shouldReloadTableForSearchString:";
		static readonly IntPtr selSearchDisplayControllerShouldReloadTableForSearchString_Handle = Selector.GetHandle ("searchDisplayController:shouldReloadTableForSearchString:");
		[CompilerGenerated]
		const string selSearchDisplayControllerShouldReloadTableForSearchScope_ = "searchDisplayController:shouldReloadTableForSearchScope:";
		static readonly IntPtr selSearchDisplayControllerShouldReloadTableForSearchScope_Handle = Selector.GetHandle ("searchDisplayController:shouldReloadTableForSearchScope:");
		[CompilerGenerated]
		const string selSearchBarShouldBeginEditing_ = "searchBarShouldBeginEditing:";
		static readonly IntPtr selSearchBarShouldBeginEditing_Handle = Selector.GetHandle ("searchBarShouldBeginEditing:");
		[CompilerGenerated]
		const string selSearchBarTextDidBeginEditing_ = "searchBarTextDidBeginEditing:";
		static readonly IntPtr selSearchBarTextDidBeginEditing_Handle = Selector.GetHandle ("searchBarTextDidBeginEditing:");
		[CompilerGenerated]
		const string selSearchBarShouldEndEditing_ = "searchBarShouldEndEditing:";
		static readonly IntPtr selSearchBarShouldEndEditing_Handle = Selector.GetHandle ("searchBarShouldEndEditing:");
		[CompilerGenerated]
		const string selSearchBarTextDidEndEditing_ = "searchBarTextDidEndEditing:";
		static readonly IntPtr selSearchBarTextDidEndEditing_Handle = Selector.GetHandle ("searchBarTextDidEndEditing:");
		[CompilerGenerated]
		const string selSearchBarTextDidChange_ = "searchBar:textDidChange:";
		static readonly IntPtr selSearchBarTextDidChange_Handle = Selector.GetHandle ("searchBar:textDidChange:");
		[CompilerGenerated]
		const string selSearchBarShouldChangeTextInRangeReplacementText_ = "searchBar:shouldChangeTextInRange:replacementText:";
		static readonly IntPtr selSearchBarShouldChangeTextInRangeReplacementText_Handle = Selector.GetHandle ("searchBar:shouldChangeTextInRange:replacementText:");
		[CompilerGenerated]
		const string selSearchBarSearchButtonClicked_ = "searchBarSearchButtonClicked:";
		static readonly IntPtr selSearchBarSearchButtonClicked_Handle = Selector.GetHandle ("searchBarSearchButtonClicked:");
		[CompilerGenerated]
		const string selSearchBarBookmarkButtonClicked_ = "searchBarBookmarkButtonClicked:";
		static readonly IntPtr selSearchBarBookmarkButtonClicked_Handle = Selector.GetHandle ("searchBarBookmarkButtonClicked:");
		[CompilerGenerated]
		const string selSearchBarCancelButtonClicked_ = "searchBarCancelButtonClicked:";
		static readonly IntPtr selSearchBarCancelButtonClicked_Handle = Selector.GetHandle ("searchBarCancelButtonClicked:");
		[CompilerGenerated]
		const string selSearchBarResultsListButtonClicked_ = "searchBarResultsListButtonClicked:";
		static readonly IntPtr selSearchBarResultsListButtonClicked_Handle = Selector.GetHandle ("searchBarResultsListButtonClicked:");
		[CompilerGenerated]
		const string selSearchBarSelectedScopeButtonIndexDidChange_ = "searchBar:selectedScopeButtonIndexDidChange:";
		static readonly IntPtr selSearchBarSelectedScopeButtonIndexDidChange_Handle = Selector.GetHandle ("searchBar:selectedScopeButtonIndexDidChange:");
		[CompilerGenerated]
		const string selWillStartSearchForTermIsFullSearch_ = "willStartSearch:forTerm:isFullSearch:";
		static readonly IntPtr selWillStartSearchForTermIsFullSearch_Handle = Selector.GetHandle ("willStartSearch:forTerm:isFullSearch:");
		[CompilerGenerated]
		const string selDidUpdateSearchForTermNewSearchResultsForPage_ = "didUpdateSearch:forTerm:newSearchResults:forPage:";
		static readonly IntPtr selDidUpdateSearchForTermNewSearchResultsForPage_Handle = Selector.GetHandle ("didUpdateSearch:forTerm:newSearchResults:forPage:");
		[CompilerGenerated]
		const string selDidFinishSearchForTermSearchResultsIsFullSearch_ = "didFinishSearch:forTerm:searchResults:isFullSearch:";
		static readonly IntPtr selDidFinishSearchForTermSearchResultsIsFullSearch_Handle = Selector.GetHandle ("didFinishSearch:forTerm:searchResults:isFullSearch:");
		[CompilerGenerated]
		const string selDidCancelSearchForTermIsFullSearch_ = "didCancelSearch:forTerm:isFullSearch:";
		static readonly IntPtr selDidCancelSearchForTermIsFullSearch_Handle = Selector.GetHandle ("didCancelSearch:forTerm:isFullSearch:");
		[CompilerGenerated]
		const string selPreferredStatusBarStyle = "preferredStatusBarStyle";
		static readonly IntPtr selPreferredStatusBarStyleHandle = Selector.GetHandle ("preferredStatusBarStyle");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSearchViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFSearchViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFSearchViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFSearchViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFSearchViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDocument:pdfController:")]
		[CompilerGenerated]
		public PSPDFSearchViewController (PSPDFDocument document, PSPDFViewController pdfController)
			: base (NSObjectFlag.Empty)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithDocumentPdfController_Handle, document.Handle, pdfController.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithDocumentPdfController_Handle, document.Handle, pdfController.Handle);
			}
		}
		
		[Export ("updateResultCell:searchResult:")]
		[CompilerGenerated]
		public virtual void UpdateResultCell (global::MonoTouch.UIKit.UITableViewCell cell, PSPDFSearchResult searchResult)
		{
			if (cell == null)
				throw new ArgumentNullException ("cell");
			if (searchResult == null)
				throw new ArgumentNullException ("searchResult");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selUpdateResultCellSearchResult_Handle, cell.Handle, searchResult.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selUpdateResultCellSearchResult_Handle, cell.Handle, searchResult.Handle);
			}
		}
		
		[CompilerGenerated]
		public void FilterContentForSearchText (string searchText, string scope)
		{
			if (searchText == null)
				throw new ArgumentNullException ("searchText");
			if (scope == null)
				throw new ArgumentNullException ("scope");
			var nssearchText = NSString.CreateNative (searchText);
			var nsscope = NSString.CreateNative (scope);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selFilterContentForSearchTextScope_Handle, nssearchText, nsscope);
			NSString.ReleaseNative (nssearchText);
			NSString.ReleaseNative (nsscope);
			
		}
		
		[CompilerGenerated]
		public void SetSearchStatus (PSPDFSearchStatus searchStatus, bool updateTable)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int_bool (this.Handle, selSetSearchStatusUpdateTable_Handle, (int)searchStatus, updateTable);
		}
		
		[CompilerGenerated]
		public PSPDFSearchResult SearchResultsForIndexPath (NSIndexPath indexPath)
		{
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			return (PSPDFSearchResult) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selSearchResultsForIndexPath_Handle, indexPath.Handle));
		}
		
		[Export ("didFinishCachingDocument:")]
		[CompilerGenerated]
		public virtual void DidFinishCachingDocument (PSPDFDocument document)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selDidFinishCachingDocument_Handle, document.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selDidFinishCachingDocument_Handle, document.Handle);
			}
		}
		
		[Export ("searchDisplayControllerWillBeginSearch:")]
		[CompilerGenerated]
		public virtual void SearchDisplayControllerWillBeginSearch (global::MonoTouch.UIKit.UISearchDisplayController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSearchDisplayControllerWillBeginSearch_Handle, controller.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchDisplayControllerWillBeginSearch_Handle, controller.Handle);
			}
		}
		
		[Export ("searchDisplayControllerDidBeginSearch:")]
		[CompilerGenerated]
		public virtual void SearchDisplayControllerDidBeginSearch (global::MonoTouch.UIKit.UISearchDisplayController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSearchDisplayControllerDidBeginSearch_Handle, controller.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchDisplayControllerDidBeginSearch_Handle, controller.Handle);
			}
		}
		
		[Export ("searchDisplayControllerWillEndSearch:")]
		[CompilerGenerated]
		public virtual void SearchDisplayControllerWillEndSearch (global::MonoTouch.UIKit.UISearchDisplayController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSearchDisplayControllerWillEndSearch_Handle, controller.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchDisplayControllerWillEndSearch_Handle, controller.Handle);
			}
		}
		
		[Export ("searchDisplayControllerDidEndSearch:")]
		[CompilerGenerated]
		public virtual void SearchDisplayControllerDidEndSearch (global::MonoTouch.UIKit.UISearchDisplayController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSearchDisplayControllerDidEndSearch_Handle, controller.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchDisplayControllerDidEndSearch_Handle, controller.Handle);
			}
		}
		
		[Export ("searchDisplayController:didLoadSearchResultsTableView:")]
		[CompilerGenerated]
		public virtual void SearchDisplayControllerDidLoadSearchResultsTableView (global::MonoTouch.UIKit.UISearchDisplayController controller, global::MonoTouch.UIKit.UITableView tableView)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (tableView == null)
				throw new ArgumentNullException ("tableView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSearchDisplayControllerDidLoadSearchResultsTableView_Handle, controller.Handle, tableView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSearchDisplayControllerDidLoadSearchResultsTableView_Handle, controller.Handle, tableView.Handle);
			}
		}
		
		[Export ("searchDisplayController:willUnloadSearchResultsTableView:")]
		[CompilerGenerated]
		public virtual void SearchDisplayControllerWillUnloadSearchResultsTableView (global::MonoTouch.UIKit.UISearchDisplayController controller, global::MonoTouch.UIKit.UITableView tableView)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (tableView == null)
				throw new ArgumentNullException ("tableView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSearchDisplayControllerWillUnloadSearchResultsTableView_Handle, controller.Handle, tableView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSearchDisplayControllerWillUnloadSearchResultsTableView_Handle, controller.Handle, tableView.Handle);
			}
		}
		
		[Export ("searchDisplayController:willShowSearchResultsTableView:")]
		[CompilerGenerated]
		public virtual void SearchDisplayControllerWillShowSearchResultsTableView (global::MonoTouch.UIKit.UISearchDisplayController controller, global::MonoTouch.UIKit.UITableView tableView)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (tableView == null)
				throw new ArgumentNullException ("tableView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSearchDisplayControllerWillShowSearchResultsTableView_Handle, controller.Handle, tableView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSearchDisplayControllerWillShowSearchResultsTableView_Handle, controller.Handle, tableView.Handle);
			}
		}
		
		[Export ("searchDisplayController:didShowSearchResultsTableView:")]
		[CompilerGenerated]
		public virtual void SearchDisplayControllerDidShowSearchResultsTableView (global::MonoTouch.UIKit.UISearchDisplayController controller, global::MonoTouch.UIKit.UITableView tableView)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (tableView == null)
				throw new ArgumentNullException ("tableView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSearchDisplayControllerDidShowSearchResultsTableView_Handle, controller.Handle, tableView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSearchDisplayControllerDidShowSearchResultsTableView_Handle, controller.Handle, tableView.Handle);
			}
		}
		
		[Export ("searchDisplayController:willHideSearchResultsTableView:")]
		[CompilerGenerated]
		public virtual void SearchDisplayControllerWillHideSearchResultsTableView (global::MonoTouch.UIKit.UISearchDisplayController controller, global::MonoTouch.UIKit.UITableView tableView)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (tableView == null)
				throw new ArgumentNullException ("tableView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSearchDisplayControllerWillHideSearchResultsTableView_Handle, controller.Handle, tableView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSearchDisplayControllerWillHideSearchResultsTableView_Handle, controller.Handle, tableView.Handle);
			}
		}
		
		[Export ("searchDisplayController:didHideSearchResultsTableView:")]
		[CompilerGenerated]
		public virtual void SearchDisplayControllerDidHideSearchResultsTableView (global::MonoTouch.UIKit.UISearchDisplayController controller, global::MonoTouch.UIKit.UITableView tableView)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (tableView == null)
				throw new ArgumentNullException ("tableView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSearchDisplayControllerDidHideSearchResultsTableView_Handle, controller.Handle, tableView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSearchDisplayControllerDidHideSearchResultsTableView_Handle, controller.Handle, tableView.Handle);
			}
		}
		
		[Export ("searchDisplayController:shouldReloadTableForSearchString:")]
		[CompilerGenerated]
		public virtual bool SearchDisplayControllerShouldReloadTableForSearchString (global::MonoTouch.UIKit.UISearchDisplayController controller, string searchString)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (searchString == null)
				throw new ArgumentNullException ("searchString");
			var nssearchString = NSString.CreateNative (searchString);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, selSearchDisplayControllerShouldReloadTableForSearchString_Handle, controller.Handle, nssearchString);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSearchDisplayControllerShouldReloadTableForSearchString_Handle, controller.Handle, nssearchString);
			}
			NSString.ReleaseNative (nssearchString);
			
			return ret;
		}
		
		[Export ("searchDisplayController:shouldReloadTableForSearchScope:")]
		[CompilerGenerated]
		public virtual bool SearchDisplayControllerShouldReloadTableForSearchScope (global::MonoTouch.UIKit.UISearchDisplayController controller, int searchOption)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_int (this.Handle, selSearchDisplayControllerShouldReloadTableForSearchScope_Handle, controller.Handle, searchOption);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_int (this.SuperHandle, selSearchDisplayControllerShouldReloadTableForSearchScope_Handle, controller.Handle, searchOption);
			}
		}
		
		[Export ("searchBarShouldBeginEditing:")]
		[CompilerGenerated]
		public virtual bool SearchBarShouldBeginEditing (global::MonoTouch.UIKit.UISearchBar searchBar)
		{
			if (searchBar == null)
				throw new ArgumentNullException ("searchBar");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selSearchBarShouldBeginEditing_Handle, searchBar.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchBarShouldBeginEditing_Handle, searchBar.Handle);
			}
		}
		
		[Export ("searchBarTextDidBeginEditing:")]
		[CompilerGenerated]
		public virtual void SearchBarTextDidBeginEditing (global::MonoTouch.UIKit.UISearchBar searchBar)
		{
			if (searchBar == null)
				throw new ArgumentNullException ("searchBar");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSearchBarTextDidBeginEditing_Handle, searchBar.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchBarTextDidBeginEditing_Handle, searchBar.Handle);
			}
		}
		
		[Export ("searchBarShouldEndEditing:")]
		[CompilerGenerated]
		public virtual bool SearchBarShouldEndEditing (global::MonoTouch.UIKit.UISearchBar searchBar)
		{
			if (searchBar == null)
				throw new ArgumentNullException ("searchBar");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selSearchBarShouldEndEditing_Handle, searchBar.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchBarShouldEndEditing_Handle, searchBar.Handle);
			}
		}
		
		[Export ("searchBarTextDidEndEditing:")]
		[CompilerGenerated]
		public virtual void SearchBarTextDidEndEditing (global::MonoTouch.UIKit.UISearchBar searchBar)
		{
			if (searchBar == null)
				throw new ArgumentNullException ("searchBar");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSearchBarTextDidEndEditing_Handle, searchBar.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchBarTextDidEndEditing_Handle, searchBar.Handle);
			}
		}
		
		[Export ("searchBar:textDidChange:")]
		[CompilerGenerated]
		public virtual void SearchBarTextDidChange (global::MonoTouch.UIKit.UISearchBar searchBar, string searchText)
		{
			if (searchBar == null)
				throw new ArgumentNullException ("searchBar");
			if (searchText == null)
				throw new ArgumentNullException ("searchText");
			var nssearchText = NSString.CreateNative (searchText);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSearchBarTextDidChange_Handle, searchBar.Handle, nssearchText);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSearchBarTextDidChange_Handle, searchBar.Handle, nssearchText);
			}
			NSString.ReleaseNative (nssearchText);
			
		}
		
		[Export ("searchBar:shouldChangeTextInRange:replacementText:")]
		[CompilerGenerated]
		public virtual bool SearchBarShouldChangeTextInRangeReplacementText (global::MonoTouch.UIKit.UISearchBar searchBar, NSRange range, string text)
		{
			if (searchBar == null)
				throw new ArgumentNullException ("searchBar");
			if (text == null)
				throw new ArgumentNullException ("text");
			var nstext = NSString.CreateNative (text);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_NSRange_IntPtr (this.Handle, selSearchBarShouldChangeTextInRangeReplacementText_Handle, searchBar.Handle, range, nstext);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_NSRange_IntPtr (this.SuperHandle, selSearchBarShouldChangeTextInRangeReplacementText_Handle, searchBar.Handle, range, nstext);
			}
			NSString.ReleaseNative (nstext);
			
			return ret;
		}
		
		[Export ("searchBarSearchButtonClicked:")]
		[CompilerGenerated]
		public virtual void SearchBarSearchButtonClicked (global::MonoTouch.UIKit.UISearchBar searchBar)
		{
			if (searchBar == null)
				throw new ArgumentNullException ("searchBar");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSearchBarSearchButtonClicked_Handle, searchBar.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchBarSearchButtonClicked_Handle, searchBar.Handle);
			}
		}
		
		[Export ("searchBarBookmarkButtonClicked:")]
		[CompilerGenerated]
		public virtual void SearchBarBookmarkButtonClicked (global::MonoTouch.UIKit.UISearchBar searchBar)
		{
			if (searchBar == null)
				throw new ArgumentNullException ("searchBar");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSearchBarBookmarkButtonClicked_Handle, searchBar.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchBarBookmarkButtonClicked_Handle, searchBar.Handle);
			}
		}
		
		[Export ("searchBarCancelButtonClicked:")]
		[CompilerGenerated]
		public virtual void SearchBarCancelButtonClicked (global::MonoTouch.UIKit.UISearchBar searchBar)
		{
			if (searchBar == null)
				throw new ArgumentNullException ("searchBar");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSearchBarCancelButtonClicked_Handle, searchBar.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchBarCancelButtonClicked_Handle, searchBar.Handle);
			}
		}
		
		[Export ("searchBarResultsListButtonClicked:")]
		[CompilerGenerated]
		public virtual void SearchBarResultsListButtonClicked (global::MonoTouch.UIKit.UISearchBar searchBar)
		{
			if (searchBar == null)
				throw new ArgumentNullException ("searchBar");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSearchBarResultsListButtonClicked_Handle, searchBar.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchBarResultsListButtonClicked_Handle, searchBar.Handle);
			}
		}
		
		[Export ("searchBar:selectedScopeButtonIndexDidChange:")]
		[CompilerGenerated]
		public virtual void SearchBarSelectedScopeButtonIndexDidChange (global::MonoTouch.UIKit.UISearchBar searchBar, int selectedScope)
		{
			if (searchBar == null)
				throw new ArgumentNullException ("searchBar");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_int (this.Handle, selSearchBarSelectedScopeButtonIndexDidChange_Handle, searchBar.Handle, selectedScope);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_int (this.SuperHandle, selSearchBarSelectedScopeButtonIndexDidChange_Handle, searchBar.Handle, selectedScope);
			}
		}
		
		[Export ("willStartSearch:forTerm:isFullSearch:")]
		[CompilerGenerated]
		public virtual void WillStartSearch (PSPDFTextSearch textSearch, string searchTerm, bool isFullSearch)
		{
			if (textSearch == null)
				throw new ArgumentNullException ("textSearch");
			if (searchTerm == null)
				throw new ArgumentNullException ("searchTerm");
			var nssearchTerm = NSString.CreateNative (searchTerm);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_bool (this.Handle, selWillStartSearchForTermIsFullSearch_Handle, textSearch.Handle, nssearchTerm, isFullSearch);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_bool (this.SuperHandle, selWillStartSearchForTermIsFullSearch_Handle, textSearch.Handle, nssearchTerm, isFullSearch);
			}
			NSString.ReleaseNative (nssearchTerm);
			
		}
		
		[Export ("didUpdateSearch:forTerm:newSearchResults:forPage:")]
		[CompilerGenerated]
		public virtual void DidUpdateSearch (PSPDFTextSearch textSearch, string searchTerm, PSPDFSearchResult[] searchResults, global::System.UInt32 page)
		{
			if (textSearch == null)
				throw new ArgumentNullException ("textSearch");
			if (searchTerm == null)
				throw new ArgumentNullException ("searchTerm");
			if (searchResults == null)
				throw new ArgumentNullException ("searchResults");
			var nssearchTerm = NSString.CreateNative (searchTerm);
			var nsa_searchResults = NSArray.FromNSObjects (searchResults);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt32 (this.Handle, selDidUpdateSearchForTermNewSearchResultsForPage_Handle, textSearch.Handle, nssearchTerm, nsa_searchResults.Handle, page);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt32 (this.SuperHandle, selDidUpdateSearchForTermNewSearchResultsForPage_Handle, textSearch.Handle, nssearchTerm, nsa_searchResults.Handle, page);
			}
			NSString.ReleaseNative (nssearchTerm);
			nsa_searchResults.Dispose ();
			
		}
		
		[Export ("didFinishSearch:forTerm:searchResults:isFullSearch:")]
		[CompilerGenerated]
		public virtual void DidFinishSearch (PSPDFTextSearch textSearch, string searchTerm, PSPDFSearchResult[] searchResults, bool isFullSearch)
		{
			if (textSearch == null)
				throw new ArgumentNullException ("textSearch");
			if (searchTerm == null)
				throw new ArgumentNullException ("searchTerm");
			if (searchResults == null)
				throw new ArgumentNullException ("searchResults");
			var nssearchTerm = NSString.CreateNative (searchTerm);
			var nsa_searchResults = NSArray.FromNSObjects (searchResults);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool (this.Handle, selDidFinishSearchForTermSearchResultsIsFullSearch_Handle, textSearch.Handle, nssearchTerm, nsa_searchResults.Handle, isFullSearch);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool (this.SuperHandle, selDidFinishSearchForTermSearchResultsIsFullSearch_Handle, textSearch.Handle, nssearchTerm, nsa_searchResults.Handle, isFullSearch);
			}
			NSString.ReleaseNative (nssearchTerm);
			nsa_searchResults.Dispose ();
			
		}
		
		[Export ("didCancelSearch:forTerm:isFullSearch:")]
		[CompilerGenerated]
		public virtual void DidCancelSearch (PSPDFTextSearch textSearch, string searchTerm, bool isFullSearch)
		{
			if (textSearch == null)
				throw new ArgumentNullException ("textSearch");
			if (searchTerm == null)
				throw new ArgumentNullException ("searchTerm");
			var nssearchTerm = NSString.CreateNative (searchTerm);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_bool (this.Handle, selDidCancelSearchForTermIsFullSearch_Handle, textSearch.Handle, nssearchTerm, isFullSearch);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_bool (this.SuperHandle, selDidCancelSearchForTermIsFullSearch_Handle, textSearch.Handle, nssearchTerm, isFullSearch);
			}
			NSString.ReleaseNative (nssearchTerm);
			
		}
		
		[Export ("preferredStatusBarStyle")]
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIStatusBarStyle PreferredStatusBarStyle ()
		{
			if (IsDirectBinding) {
				return (global::MonoTouch.UIKit.UIStatusBarStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selPreferredStatusBarStyleHandle);
			} else {
				return (global::MonoTouch.UIKit.UIStatusBarStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selPreferredStatusBarStyleHandle);
			}
		}
		
		[CompilerGenerated]
		public virtual string SearchText {
			[Export ("searchText", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSearchTextHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSearchTextHandle));
				}
			}
			
			[Export ("setSearchText:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSearchText_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSearchText_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowsCancelButton {
			[Export ("showsCancelButton", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsCancelButtonHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShowsCancelButtonHandle);
				}
			}
			
			[Export ("setShowsCancelButton:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsCancelButton_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShowsCancelButton_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_SearchBar_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UISearchBar SearchBar {
			[Export ("searchBar")]
			get {
				global::MonoTouch.UIKit.UISearchBar ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UISearchBar) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSearchBarHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UISearchBar) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSearchBarHandle));
				}
				MarkDirty ();
				__mt_SearchBar_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFSearchStatus SearchStatus {
			[Export ("searchStatus", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFSearchStatus) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selSearchStatusHandle);
				} else {
					return (PSPDFSearchStatus) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selSearchStatusHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ClearHighlightsWhenClosed {
			[Export ("clearHighlightsWhenClosed", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selClearHighlightsWhenClosedHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selClearHighlightsWhenClosedHandle);
				}
			}
			
			[Export ("setClearHighlightsWhenClosed:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetClearHighlightsWhenClosed_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetClearHighlightsWhenClosed_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 MaximumNumberOfSearchResultsDisplayed {
			[Export ("maximumNumberOfSearchResultsDisplayed", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selMaximumNumberOfSearchResultsDisplayedHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selMaximumNumberOfSearchResultsDisplayedHandle);
				}
			}
			
			[Export ("setMaximumNumberOfSearchResultsDisplayed:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetMaximumNumberOfSearchResultsDisplayed_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetMaximumNumberOfSearchResultsDisplayed_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool SearchVisiblePagesFirst {
			[Export ("searchVisiblePagesFirst", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSearchVisiblePagesFirstHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selSearchVisiblePagesFirstHandle);
				}
			}
			
			[Export ("setSearchVisiblePagesFirst:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSearchVisiblePagesFirst_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetSearchVisiblePagesFirst_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_TextSearch_var;
		[CompilerGenerated]
		public virtual PSPDFTextSearch TextSearch {
			[Export ("textSearch")]
			get {
				PSPDFTextSearch ret;
				if (IsDirectBinding) {
					ret = (PSPDFTextSearch) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTextSearchHandle));
				} else {
					ret = (PSPDFTextSearch) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTextSearchHandle));
				}
				MarkDirty ();
				__mt_TextSearch_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PdfController_var;
		[CompilerGenerated]
		public virtual PSPDFViewController PdfController {
			[Export ("pdfController")]
			get {
				PSPDFViewController ret;
				if (IsDirectBinding) {
					ret = (PSPDFViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPdfControllerHandle));
				} else {
					ret = (PSPDFViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPdfControllerHandle));
				}
				MarkDirty ();
				__mt_PdfController_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_SearchBar_var = null;
				__mt_TextSearch_var = null;
				__mt_PdfController_var = null;
			}
		}
	} /* class PSPDFSearchViewController */
}
