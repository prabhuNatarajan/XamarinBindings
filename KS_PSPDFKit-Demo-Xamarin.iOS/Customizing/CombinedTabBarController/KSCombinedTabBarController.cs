using System;
using MonoTouch.UIKit;
using KS_PSPDFKitBindings;

namespace PSPDFKitDemoXamarin.iOS
{
	/// <summary>
	/// UITabBarController implementation that hosts the TOC, search and the Bookmarks controller.
	/// </summary>
	public class KSCombinedTabBarController : UITabBarController
	{
		public KSCombinedTabBarController (PSPDFViewController controller, PSPDFDocument document) : base ()
		{
			var tocController = new PSPDFOutlineViewController (document, controller.Handle);
			tocController.Title = "TOC";

			var searchController = new PSPDFSearchViewController (document, controller);
			searchController.Title = "Search";

			var bookmarksController = new PSPDFBookmarkViewController (document, null);
			// PSPDFViewController implements PSPDFOutlineViewControllerDelegate as a protocol.
			bookmarksController.WeakDelegate = controller;
			bookmarksController.Title = "Bookmarks";

			var annotsController = new KSAnnotationsListController(document, controller);
			annotsController.Title = "Annotations";

			this.SetViewControllers (new UIViewController[] { tocController, searchController, bookmarksController, annotsController }, false);
		}
	}
}

