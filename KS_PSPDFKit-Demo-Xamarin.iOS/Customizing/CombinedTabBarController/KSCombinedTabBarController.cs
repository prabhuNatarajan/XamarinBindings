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
			this.controller = controller;
			this.document = document;
			Console.WriteLine("CONTROLLER AND DOCUMENT!");
		}

		public KSCombinedTabBarController (string test) : base ()
		{
			string s = test;
			Console.WriteLine("STRING: " + s);
		}

		public KSCombinedTabBarController(IntPtr ptr) : base(ptr)
		{
			Console.WriteLine("INTPTR!");
		}

		public PSPDFViewController controller;
		public PSPDFDocument document;


		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

			var tocController = new PSPDFOutlineViewController (document, controller.Handle);
			tocController.Title = "TOC";
			
			var searchController = new PSPDFSearchViewController (document, IntPtr.Zero);
			searchController.Title = "Search";
			
			var bookmarksController = new PSPDFBookmarkViewController (document, null);
			// PSPDFViewController implements PSPDFOutlineViewControllerDelegate as a protocol.
			bookmarksController.WeakDelegate = controller;
			bookmarksController.Title = "Bookmarks";
			
			var annotsController = new KSAnnotationsListController(document, controller);
			annotsController.Title = "Annotations";
			
			this.SetViewControllers (new UIViewController[] {
				tocController,
				searchController,
				bookmarksController,
				annotsController
			}, false);

		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

		}
	}
}

