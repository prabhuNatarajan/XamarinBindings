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
	[Register("PSPDFSearchViewController", true)]
	public unsafe partial class PSPDFSearchViewController : MonoTouch.UIKit.UITableViewController {
		static readonly IntPtr selSearchText = Selector.GetHandle ("searchText");
		static readonly IntPtr selSetSearchText_ = Selector.GetHandle ("setSearchText:");
		static readonly IntPtr selShowsCancelButton = Selector.GetHandle ("showsCancelButton");
		static readonly IntPtr selSetShowsCancelButton_ = Selector.GetHandle ("setShowsCancelButton:");
		static readonly IntPtr selSearchBar = Selector.GetHandle ("searchBar");
		static readonly IntPtr selSearchStatus = Selector.GetHandle ("searchStatus");
		static readonly IntPtr selClearHighlightsWhenClosed = Selector.GetHandle ("clearHighlightsWhenClosed");
		static readonly IntPtr selSetClearHighlightsWhenClosed_ = Selector.GetHandle ("setClearHighlightsWhenClosed:");
		static readonly IntPtr selInitWithDocumentPdfController_ = Selector.GetHandle ("initWithDocument:pdfController:");
		static readonly IntPtr selUpdateResultCellSearchResult_ = Selector.GetHandle ("updateResultCell:searchResult:");
		static readonly IntPtr selDidCachePageForDocumentPageImageSize_ = Selector.GetHandle ("didCachePageForDocument:page:image:size:");
		static readonly IntPtr selDidFinishCachingDocument_ = Selector.GetHandle ("didFinishCachingDocument:");
		static readonly IntPtr selSearchDisplayControllerWillBeginSearch_ = Selector.GetHandle ("searchDisplayControllerWillBeginSearch:");
		static readonly IntPtr selSearchDisplayControllerDidBeginSearch_ = Selector.GetHandle ("searchDisplayControllerDidBeginSearch:");
		static readonly IntPtr selSearchDisplayControllerWillEndSearch_ = Selector.GetHandle ("searchDisplayControllerWillEndSearch:");
		static readonly IntPtr selSearchDisplayControllerDidEndSearch_ = Selector.GetHandle ("searchDisplayControllerDidEndSearch:");
		static readonly IntPtr selSearchDisplayControllerDidLoadSearchResultsTableView_ = Selector.GetHandle ("searchDisplayController:didLoadSearchResultsTableView:");
		static readonly IntPtr selSearchDisplayControllerWillUnloadSearchResultsTableView_ = Selector.GetHandle ("searchDisplayController:willUnloadSearchResultsTableView:");
		static readonly IntPtr selSearchDisplayControllerWillShowSearchResultsTableView_ = Selector.GetHandle ("searchDisplayController:willShowSearchResultsTableView:");
		static readonly IntPtr selSearchDisplayControllerDidShowSearchResultsTableView_ = Selector.GetHandle ("searchDisplayController:didShowSearchResultsTableView:");
		static readonly IntPtr selSearchDisplayControllerWillHideSearchResultsTableView_ = Selector.GetHandle ("searchDisplayController:willHideSearchResultsTableView:");
		static readonly IntPtr selSearchDisplayControllerDidHideSearchResultsTableView_ = Selector.GetHandle ("searchDisplayController:didHideSearchResultsTableView:");
		static readonly IntPtr selSearchDisplayControllerShouldReloadTableForSearchString_ = Selector.GetHandle ("searchDisplayController:shouldReloadTableForSearchString:");
		static readonly IntPtr selSearchDisplayControllerShouldReloadTableForSearchScope_ = Selector.GetHandle ("searchDisplayController:shouldReloadTableForSearchScope:");
		static readonly IntPtr selWillStartSearchForStringIsFullSearch_ = Selector.GetHandle ("willStartSearchForString:isFullSearch:");
		static readonly IntPtr selDidUpdateSearchForStringNewSearchResultsForPage_ = Selector.GetHandle ("didUpdateSearchForString:newSearchResults:forPage:");
		static readonly IntPtr selDidFinishSearchForStringSearchResultsIsFullSearch_ = Selector.GetHandle ("didFinishSearchForString:searchResults:isFullSearch:");
		static readonly IntPtr selDidCancelSearchForStringIsFullSearch_ = Selector.GetHandle ("didCancelSearchForString:isFullSearch:");
		static readonly IntPtr selPreferredStatusBarStyle = Selector.GetHandle ("preferredStatusBarStyle");
		static readonly IntPtr selSearchBarShouldBeginEditing_ = Selector.GetHandle ("searchBarShouldBeginEditing:");
		static readonly IntPtr selSearchBarTextDidBeginEditing_ = Selector.GetHandle ("searchBarTextDidBeginEditing:");
		static readonly IntPtr selSearchBarShouldEndEditing_ = Selector.GetHandle ("searchBarShouldEndEditing:");
		static readonly IntPtr selSearchBarTextDidEndEditing_ = Selector.GetHandle ("searchBarTextDidEndEditing:");
		static readonly IntPtr selSearchBarTextDidChange_ = Selector.GetHandle ("searchBar:textDidChange:");
		static readonly IntPtr selSearchBarShouldChangeTextInRangeReplacementText_ = Selector.GetHandle ("searchBar:shouldChangeTextInRange:replacementText:");
		static readonly IntPtr selSearchBarSearchButtonClicked_ = Selector.GetHandle ("searchBarSearchButtonClicked:");
		static readonly IntPtr selSearchBarBookmarkButtonClicked_ = Selector.GetHandle ("searchBarBookmarkButtonClicked:");
		static readonly IntPtr selSearchBarCancelButtonClicked_ = Selector.GetHandle ("searchBarCancelButtonClicked:");
		static readonly IntPtr selSearchBarResultsListButtonClicked_ = Selector.GetHandle ("searchBarResultsListButtonClicked:");
		static readonly IntPtr selSearchBarSelectedScopeButtonIndexDidChange_ = Selector.GetHandle ("searchBar:selectedScopeButtonIndexDidChange:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSearchViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFSearchViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFSearchViewController (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFSearchViewController (IntPtr handle) : base (handle) {}

		[Export ("initWithDocument:pdfController:")]
		[CompilerGenerated]
		public PSPDFSearchViewController (PSPDFDocument document, PSPDFViewController pdfController) : base (NSObjectFlag.Empty)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithDocumentPdfController_, document.Handle, pdfController.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithDocumentPdfController_, document.Handle, pdfController.Handle);
			}
		}
		
		[Export ("updateResultCell:searchResult:")]
		[CompilerGenerated]
		public virtual void UpdateResultCell (MonoTouch.UIKit.UITableViewCell cell, PSPDFSearchResult searchResult)
		{
			if (cell == null)
				throw new ArgumentNullException ("cell");
			if (searchResult == null)
				throw new ArgumentNullException ("searchResult");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selUpdateResultCellSearchResult_, cell.Handle, searchResult.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selUpdateResultCellSearchResult_, cell.Handle, searchResult.Handle);
			}
		}
		
		[Export ("didCachePageForDocument:page:image:size:")]
		[CompilerGenerated]
		public virtual void DidCachePageForDocument (PSPDFDocument document, System.UInt32 page, MonoTouch.UIKit.UIImage cachedImage, PSPDFSize size)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (cachedImage == null)
				throw new ArgumentNullException ("cachedImage");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32_IntPtr_int (this.Handle, selDidCachePageForDocumentPageImageSize_, document.Handle, page, cachedImage.Handle, (int)size);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_UInt32_IntPtr_int (this.SuperHandle, selDidCachePageForDocumentPageImageSize_, document.Handle, page, cachedImage.Handle, (int)size);
			}
		}
		
		[Export ("didFinishCachingDocument:")]
		[CompilerGenerated]
		public virtual void DidFinishCachingDocument (PSPDFDocument document)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selDidFinishCachingDocument_, document.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selDidFinishCachingDocument_, document.Handle);
			}
		}
		
		[Export ("searchDisplayControllerWillBeginSearch:")]
		[CompilerGenerated]
		public virtual void SearchDisplayControllerWillBeginSearch (MonoTouch.UIKit.UISearchDisplayController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSearchDisplayControllerWillBeginSearch_, controller.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchDisplayControllerWillBeginSearch_, controller.Handle);
			}
		}
		
		[Export ("searchDisplayControllerDidBeginSearch:")]
		[CompilerGenerated]
		public virtual void SearchDisplayControllerDidBeginSearch (MonoTouch.UIKit.UISearchDisplayController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSearchDisplayControllerDidBeginSearch_, controller.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchDisplayControllerDidBeginSearch_, controller.Handle);
			}
		}
		
		[Export ("searchDisplayControllerWillEndSearch:")]
		[CompilerGenerated]
		public virtual void SearchDisplayControllerWillEndSearch (MonoTouch.UIKit.UISearchDisplayController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSearchDisplayControllerWillEndSearch_, controller.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchDisplayControllerWillEndSearch_, controller.Handle);
			}
		}
		
		[Export ("searchDisplayControllerDidEndSearch:")]
		[CompilerGenerated]
		public virtual void SearchDisplayControllerDidEndSearch (MonoTouch.UIKit.UISearchDisplayController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSearchDisplayControllerDidEndSearch_, controller.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchDisplayControllerDidEndSearch_, controller.Handle);
			}
		}
		
		[Export ("searchDisplayController:didLoadSearchResultsTableView:")]
		[CompilerGenerated]
		public virtual void SearchDisplayControllerDidLoadSearchResultsTableView (MonoTouch.UIKit.UISearchDisplayController controller, MonoTouch.UIKit.UITableView tableView)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (tableView == null)
				throw new ArgumentNullException ("tableView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSearchDisplayControllerDidLoadSearchResultsTableView_, controller.Handle, tableView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSearchDisplayControllerDidLoadSearchResultsTableView_, controller.Handle, tableView.Handle);
			}
		}
		
		[Export ("searchDisplayController:willUnloadSearchResultsTableView:")]
		[CompilerGenerated]
		public virtual void SearchDisplayControllerWillUnloadSearchResultsTableView (MonoTouch.UIKit.UISearchDisplayController controller, MonoTouch.UIKit.UITableView tableView)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (tableView == null)
				throw new ArgumentNullException ("tableView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSearchDisplayControllerWillUnloadSearchResultsTableView_, controller.Handle, tableView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSearchDisplayControllerWillUnloadSearchResultsTableView_, controller.Handle, tableView.Handle);
			}
		}
		
		[Export ("searchDisplayController:willShowSearchResultsTableView:")]
		[CompilerGenerated]
		public virtual void SearchDisplayControllerWillShowSearchResultsTableView (MonoTouch.UIKit.UISearchDisplayController controller, MonoTouch.UIKit.UITableView tableView)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (tableView == null)
				throw new ArgumentNullException ("tableView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSearchDisplayControllerWillShowSearchResultsTableView_, controller.Handle, tableView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSearchDisplayControllerWillShowSearchResultsTableView_, controller.Handle, tableView.Handle);
			}
		}
		
		[Export ("searchDisplayController:didShowSearchResultsTableView:")]
		[CompilerGenerated]
		public virtual void SearchDisplayControllerDidShowSearchResultsTableView (MonoTouch.UIKit.UISearchDisplayController controller, MonoTouch.UIKit.UITableView tableView)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (tableView == null)
				throw new ArgumentNullException ("tableView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSearchDisplayControllerDidShowSearchResultsTableView_, controller.Handle, tableView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSearchDisplayControllerDidShowSearchResultsTableView_, controller.Handle, tableView.Handle);
			}
		}
		
		[Export ("searchDisplayController:willHideSearchResultsTableView:")]
		[CompilerGenerated]
		public virtual void SearchDisplayControllerWillHideSearchResultsTableView (MonoTouch.UIKit.UISearchDisplayController controller, MonoTouch.UIKit.UITableView tableView)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (tableView == null)
				throw new ArgumentNullException ("tableView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSearchDisplayControllerWillHideSearchResultsTableView_, controller.Handle, tableView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSearchDisplayControllerWillHideSearchResultsTableView_, controller.Handle, tableView.Handle);
			}
		}
		
		[Export ("searchDisplayController:didHideSearchResultsTableView:")]
		[CompilerGenerated]
		public virtual void SearchDisplayControllerDidHideSearchResultsTableView (MonoTouch.UIKit.UISearchDisplayController controller, MonoTouch.UIKit.UITableView tableView)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (tableView == null)
				throw new ArgumentNullException ("tableView");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSearchDisplayControllerDidHideSearchResultsTableView_, controller.Handle, tableView.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSearchDisplayControllerDidHideSearchResultsTableView_, controller.Handle, tableView.Handle);
			}
		}
		
		[Export ("searchDisplayController:shouldReloadTableForSearchString:")]
		[CompilerGenerated]
		public virtual bool SearchDisplayControllerShouldReloadTableForSearchString (MonoTouch.UIKit.UISearchDisplayController controller, string searchString)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (searchString == null)
				throw new ArgumentNullException ("searchString");
			var nssearchString = NSString.CreateNative (searchString);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, selSearchDisplayControllerShouldReloadTableForSearchString_, controller.Handle, nssearchString);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSearchDisplayControllerShouldReloadTableForSearchString_, controller.Handle, nssearchString);
			}
			NSString.ReleaseNative (nssearchString);
			
			return ret;
		}
		
		[Export ("searchDisplayController:shouldReloadTableForSearchScope:")]
		[CompilerGenerated]
		public virtual bool SearchDisplayControllerShouldReloadTableForSearchScope (MonoTouch.UIKit.UISearchDisplayController controller, int searchOption)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_int (this.Handle, selSearchDisplayControllerShouldReloadTableForSearchScope_, controller.Handle, searchOption);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_int (this.SuperHandle, selSearchDisplayControllerShouldReloadTableForSearchScope_, controller.Handle, searchOption);
			}
		}
		
		[Export ("willStartSearchForString:isFullSearch:")]
		[CompilerGenerated]
		public virtual void WillStartSearch (string searchString, bool isFullSearch)
		{
			if (searchString == null)
				throw new ArgumentNullException ("searchString");
			var nssearchString = NSString.CreateNative (searchString);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selWillStartSearchForStringIsFullSearch_, nssearchString, isFullSearch);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selWillStartSearchForStringIsFullSearch_, nssearchString, isFullSearch);
			}
			NSString.ReleaseNative (nssearchString);
			
		}
		
		[Export ("didUpdateSearchForString:newSearchResults:forPage:")]
		[CompilerGenerated]
		public virtual void DidUpdateSearch (string searchString, PSPDFSearchResult[] searchResults, System.UInt32 page)
		{
			if (searchString == null)
				throw new ArgumentNullException ("searchString");
			if (searchResults == null)
				throw new ArgumentNullException ("searchResults");
			var nssearchString = NSString.CreateNative (searchString);
			var nsa_searchResults = NSArray.FromNSObjects (searchResults);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt32 (this.Handle, selDidUpdateSearchForStringNewSearchResultsForPage_, nssearchString, nsa_searchResults.Handle, page);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt32 (this.SuperHandle, selDidUpdateSearchForStringNewSearchResultsForPage_, nssearchString, nsa_searchResults.Handle, page);
			}
			NSString.ReleaseNative (nssearchString);
			nsa_searchResults.Dispose ();
			
		}
		
		[Export ("didFinishSearchForString:searchResults:isFullSearch:")]
		[CompilerGenerated]
		public virtual void DidFinishSearch (string searchString, PSPDFSearchResult[] searchResults, bool isFullSearch)
		{
			if (searchString == null)
				throw new ArgumentNullException ("searchString");
			if (searchResults == null)
				throw new ArgumentNullException ("searchResults");
			var nssearchString = NSString.CreateNative (searchString);
			var nsa_searchResults = NSArray.FromNSObjects (searchResults);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_bool (this.Handle, selDidFinishSearchForStringSearchResultsIsFullSearch_, nssearchString, nsa_searchResults.Handle, isFullSearch);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_bool (this.SuperHandle, selDidFinishSearchForStringSearchResultsIsFullSearch_, nssearchString, nsa_searchResults.Handle, isFullSearch);
			}
			NSString.ReleaseNative (nssearchString);
			nsa_searchResults.Dispose ();
			
		}
		
		[Export ("didCancelSearchForString:isFullSearch:")]
		[CompilerGenerated]
		public virtual void DidCancelSearch (string searchString, bool isFullSearch)
		{
			if (searchString == null)
				throw new ArgumentNullException ("searchString");
			var nssearchString = NSString.CreateNative (searchString);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selDidCancelSearchForStringIsFullSearch_, nssearchString, isFullSearch);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selDidCancelSearchForStringIsFullSearch_, nssearchString, isFullSearch);
			}
			NSString.ReleaseNative (nssearchString);
			
		}
		
		[Export ("preferredStatusBarStyle")]
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIStatusBarStyle PreferredStatusBarStyle ()
		{
			if (IsDirectBinding) {
				return (MonoTouch.UIKit.UIStatusBarStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selPreferredStatusBarStyle);
			} else {
				return (MonoTouch.UIKit.UIStatusBarStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selPreferredStatusBarStyle);
			}
		}
		
		[Export ("searchBarShouldBeginEditing:")]
		[CompilerGenerated]
		public virtual bool SearchBarShouldBeginEditing (MonoTouch.UIKit.UISearchBar searchBar)
		{
			if (searchBar == null)
				throw new ArgumentNullException ("searchBar");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selSearchBarShouldBeginEditing_, searchBar.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchBarShouldBeginEditing_, searchBar.Handle);
			}
		}
		
		[Export ("searchBarTextDidBeginEditing:")]
		[CompilerGenerated]
		public virtual void SearchBarTextDidBeginEditing (MonoTouch.UIKit.UISearchBar searchBar)
		{
			if (searchBar == null)
				throw new ArgumentNullException ("searchBar");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSearchBarTextDidBeginEditing_, searchBar.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchBarTextDidBeginEditing_, searchBar.Handle);
			}
		}
		
		[Export ("searchBarShouldEndEditing:")]
		[CompilerGenerated]
		public virtual bool SearchBarShouldEndEditing (MonoTouch.UIKit.UISearchBar searchBar)
		{
			if (searchBar == null)
				throw new ArgumentNullException ("searchBar");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selSearchBarShouldEndEditing_, searchBar.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchBarShouldEndEditing_, searchBar.Handle);
			}
		}
		
		[Export ("searchBarTextDidEndEditing:")]
		[CompilerGenerated]
		public virtual void SearchBarTextDidEndEditing (MonoTouch.UIKit.UISearchBar searchBar)
		{
			if (searchBar == null)
				throw new ArgumentNullException ("searchBar");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSearchBarTextDidEndEditing_, searchBar.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchBarTextDidEndEditing_, searchBar.Handle);
			}
		}
		
		[Export ("searchBar:textDidChange:")]
		[CompilerGenerated]
		public virtual void SearchBarTextDidChange (MonoTouch.UIKit.UISearchBar searchBar, string searchText)
		{
			if (searchBar == null)
				throw new ArgumentNullException ("searchBar");
			if (searchText == null)
				throw new ArgumentNullException ("searchText");
			var nssearchText = NSString.CreateNative (searchText);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSearchBarTextDidChange_, searchBar.Handle, nssearchText);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSearchBarTextDidChange_, searchBar.Handle, nssearchText);
			}
			NSString.ReleaseNative (nssearchText);
			
		}
		
		[Export ("searchBar:shouldChangeTextInRange:replacementText:")]
		[CompilerGenerated]
		public virtual bool SearchBarShouldChangeTextInRangeReplacementText (MonoTouch.UIKit.UISearchBar searchBar, NSRange range, string text)
		{
			if (searchBar == null)
				throw new ArgumentNullException ("searchBar");
			if (text == null)
				throw new ArgumentNullException ("text");
			var nstext = NSString.CreateNative (text);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_NSRange_IntPtr (this.Handle, selSearchBarShouldChangeTextInRangeReplacementText_, searchBar.Handle, range, nstext);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_NSRange_IntPtr (this.SuperHandle, selSearchBarShouldChangeTextInRangeReplacementText_, searchBar.Handle, range, nstext);
			}
			NSString.ReleaseNative (nstext);
			
			return ret;
		}
		
		[Export ("searchBarSearchButtonClicked:")]
		[CompilerGenerated]
		public virtual void SearchBarSearchButtonClicked (MonoTouch.UIKit.UISearchBar searchBar)
		{
			if (searchBar == null)
				throw new ArgumentNullException ("searchBar");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSearchBarSearchButtonClicked_, searchBar.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchBarSearchButtonClicked_, searchBar.Handle);
			}
		}
		
		[Export ("searchBarBookmarkButtonClicked:")]
		[CompilerGenerated]
		public virtual void SearchBarBookmarkButtonClicked (MonoTouch.UIKit.UISearchBar searchBar)
		{
			if (searchBar == null)
				throw new ArgumentNullException ("searchBar");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSearchBarBookmarkButtonClicked_, searchBar.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchBarBookmarkButtonClicked_, searchBar.Handle);
			}
		}
		
		[Export ("searchBarCancelButtonClicked:")]
		[CompilerGenerated]
		public virtual void SearchBarCancelButtonClicked (MonoTouch.UIKit.UISearchBar searchBar)
		{
			if (searchBar == null)
				throw new ArgumentNullException ("searchBar");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSearchBarCancelButtonClicked_, searchBar.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchBarCancelButtonClicked_, searchBar.Handle);
			}
		}
		
		[Export ("searchBarResultsListButtonClicked:")]
		[CompilerGenerated]
		public virtual void SearchBarResultsListButtonClicked (MonoTouch.UIKit.UISearchBar searchBar)
		{
			if (searchBar == null)
				throw new ArgumentNullException ("searchBar");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSearchBarResultsListButtonClicked_, searchBar.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchBarResultsListButtonClicked_, searchBar.Handle);
			}
		}
		
		[Export ("searchBar:selectedScopeButtonIndexDidChange:")]
		[CompilerGenerated]
		public virtual void SearchBarSelectedScopeButtonIndexDidChange (MonoTouch.UIKit.UISearchBar searchBar, int selectedScope)
		{
			if (searchBar == null)
				throw new ArgumentNullException ("searchBar");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_int (this.Handle, selSearchBarSelectedScopeButtonIndexDidChange_, searchBar.Handle, selectedScope);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_int (this.SuperHandle, selSearchBarSelectedScopeButtonIndexDidChange_, searchBar.Handle, selectedScope);
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
			
			[Export ("setSearchText:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSearchText_, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSearchText_, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowsCancelButton {
			[Export ("showsCancelButton", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsCancelButton);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShowsCancelButton);
				}
			}
			
			[Export ("setShowsCancelButton:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsCancelButton_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShowsCancelButton_, value);
				}
			}
		}
		
		object __mt_SearchBar_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UISearchBar SearchBar {
			[Export ("searchBar")]
			get {
				MonoTouch.UIKit.UISearchBar ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UISearchBar) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSearchBar));
				} else {
					ret = (MonoTouch.UIKit.UISearchBar) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSearchBar));
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
					return (PSPDFSearchStatus) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selSearchStatus);
				} else {
					return (PSPDFSearchStatus) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selSearchStatus);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ClearHighlightsWhenClosed {
			[Export ("clearHighlightsWhenClosed", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selClearHighlightsWhenClosed);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selClearHighlightsWhenClosed);
				}
			}
			
			[Export ("setClearHighlightsWhenClosed:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetClearHighlightsWhenClosed_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetClearHighlightsWhenClosed_, value);
				}
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_SearchBar_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFSearchViewController */
}
