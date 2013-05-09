
using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using KS_PSPDFKitBindings;
using MonoTouch.ObjCRuntime;
using System.Collections.Specialized;

namespace PSPDFKitDemoXamarin.iOS
{
	public partial class KSCatalogViewController : DialogViewController
	{
		const string DevelopersGuideFileName = "DevelopersGuide.pdf";
		const string PaperExampleFileName = "amazon-dynamo-sosp2007.pdf";
		const string PSPDFCatalog = "PSPDFKit.pdf";
		const string HackerMagazineExample = "hackermonthly12.pdf";
		const string AnnotTestExample = "Annotation Test.pdf";

		public bool clearCacheNeeded;

		public KSCatalogViewController () : base (UITableViewStyle.Grouped, null)
		{
			// Add some custom localization to ensure the bindings work.
			PSPDFKitGlobal.Localize("en", new NameValueCollection
			{
				{"Outline", "File Content"},
				{"Bookmarks", "Remember"}
			});

			// Call cache method to ensure the bindings for the cache work.
			var oPdfCache = PSPDFCache.SharedCache;
			oPdfCache.ClearCache ( );

			PSPDFKitGlobal.LogLevel = PSPDFLogLevel.Info;

			NSUrl samplesURL = NSBundle.MainBundle.ResourceUrl.Append ("Samples", true);
			NSUrl hackerMagURL = samplesURL.Append(HackerMagazineExample, false);
			NSUrl annotTestURL = samplesURL.Append(AnnotTestExample, false);


			this.Root = new RootElement ("KSCatalogViewController")
			{
				new Section ("Full example apps", "Can be used as a template for your own apps.")
				{
					// PDF playground.
					new StringElement ("PSPDFViewController playground", () =>
					{
						var doc = new PSPDFDocument(hackerMagURL);
						var kioskController = new KSKioskViewController(doc);

						kioskController.StatusBarStyleSetting = PSPDFStatusBarStyleSetting.Default;
						this.NavigationController.PushViewController(kioskController, true);
					}),
				},

				new Section("Customizing")
				{
					// Combines various view controllers in a tab bar controller.
					new StringElement("Combine search, TOC and bookmarks", () =>
					{
						var doc = new PSPDFDocument(hackerMagURL);

						// Don't use PSPDFVieController directly but a subclass that allows attaching to ViewDidDisappear in order to clear
						// the RightBarButtonItems property. Otherwise the tabBarBtn would keep a reference to the PSPDFViewController and the instances
						// would never be freed.

						//var controller = new PSPDFViewController(doc);
						var controller = new KSKioskViewController(doc);
						controller.ViewDisappeared += (sender, args) => controller.RightBarButtonItems = new PSPDFBarButtonItem[0];

						var tabBarController = new KSCombinedTabBarController(controller, doc);

						var tabBarBtn = new KSBarButtonItem(controller)
						{
							Title = "UITabBarController",
							Style = UIBarButtonItemStyle.Bordered
						};
						tabBarBtn.Clicked += (object sender, EventArgs e) => controller.PresentViewControllerModalOrPopover(tabBarController, true, false, true, tabBarBtn, null);

						controller.RightBarButtonItems = new PSPDFBarButtonItem[] { controller.AnnotationButtonItem, controller.BookmarkButtonItem, tabBarBtn };

						var classDic = new NSMutableDictionary();
						classDic.LowlevelSetObject( new Class(typeof(KSInkAnnotation)).Handle, new Class(typeof(PSPDFInkAnnotation)).Handle);
						classDic.LowlevelSetObject( new Class(typeof(KSNoteAnnotation)).Handle, new Class(typeof(PSPDFNoteAnnotation)).Handle);
						classDic.LowlevelSetObject( new Class(typeof(KSHighlightAnnotation)).Handle, new Class(typeof(PSPDFHighlightAnnotation)).Handle);
						doc.OverrideClassNames = classDic;

						this.NavigationController.PushViewController(controller, true);
					}),

					// Shows an alert when tapping a link annotation.
					new StringElement("Custom reaction on annotation links", () =>
					{
						var doc = new PSPDFDocument(hackerMagURL);
						var controller = new PSPDFViewController(doc);
						controller.Delegate = new KSCatchTappingLinkDelegate();
						// There are link annotations on page 2.
						controller.SetPageAnimated(1, false);
						this.NavigationController.PushViewController(controller, true);
					})
				},

				new Section ("Subclassing")
				{
					// Subclassing PSPDFAnnotationToolbar
					new StringElement ("Subclass annotation toolbar and drawing toolbar", () =>
					{
						var doc = new PSPDFDocument(hackerMagURL);
						var controller = new PSPDFViewController(doc);

						var barButtons = new List<PSPDFBarButtonItem>(controller.RightBarButtonItems);
						barButtons.Add(controller.AnnotationButtonItem);
						controller.RightBarButtonItems = barButtons.ToArray();
						
						var classDic = new NSMutableDictionary();
						classDic.LowlevelSetObject( new Class(typeof(KSAnnotationToolbar)).Handle, new Class(typeof(PSPDFAnnotationToolbar)).Handle);
						controller.OverrideClassNames = classDic;
						
						this.NavigationController.PushViewController(controller, true);
					}),

					// Demonstrates always visible vertical toolbar.
					new StringElement ("Vertical always-visible annotation bar", () =>
					{
						var doc = new PSPDFDocument(hackerMagURL);
						var controller = new KSExampleAnnotationViewController(doc);

						this.NavigationController.PushViewController(controller, true);
					}),

					// Tests potential binding issue when subclassing PSPDFViewController
					new StringElement ("PSPDFViewController with NULL document", () =>
					{
						var doc = new PSPDFDocument(hackerMagURL);
						var controller = new KSNoDocumentPDFViewController();
						controller.Document = doc;
						this.NavigationController.PushViewController(controller, true);
					}),

					// Demonstrates capturing bookmark set/remove.
					new StringElement ("Capture bookmarks", () =>
					{
						var doc = new PSPDFDocument(hackerMagURL);

						// Create an entry for overriding the default bookmark parser.
						var classDic = new NSMutableDictionary();
						classDic.LowlevelSetObject( new Class(typeof(KSBookmarkParser)).Handle, new Class(typeof(PSPDFBookmarkParser)).Handle);
						doc.OverrideClassNames = classDic;

						var controller = new PSPDFViewController(doc);
						controller.RightBarButtonItems = new PSPDFBarButtonItem[]
						{
							controller.BookmarkButtonItem,
							controller.SearchButtonItem,
							controller.OutlineButtonItem,
							controller.ViewModeButtonItem
						};
						this.NavigationController.PushViewController(controller, true);
					}),

					// Demonstrates custom annotation provider.
					new StringElement ("Custom Annotation Provider", () =>
					{
						var doc = new PSPDFDocument(hackerMagURL);
						doc.SetDidCreateDocumentProviderBlock(delegate(PSPDFDocumentProvider documentProvider)
						{
							documentProvider.AnnotationParser.AnnotationProviders = new NSObject[]
							{
								new KSCustomAnnotationProvider(),
								documentProvider.AnnotationParser.FileAnnotationProvider
							};
						});
					
						var controller = new PSPDFViewController(doc);
						this.NavigationController.PushViewController(controller, true);
					}),

					// Subclasses PDPFFileAnnotationProvider and injects additional annotations. 
					// This example demonstrates:
					// * Make all built in annotations (those embedded in the PDF) immutable.
					// * All annotations added by the user can be modified.
					// * Workaround for PSPDFKit bug where the text of a non-editable annotation can still be changed.
					// * Immediate callback if an annotation has been changed.
					new StringElement ("Subclass PSPDFFileAnnotationProvider", () =>
					{
						var controller = new PSPDFViewController();
						var barButtons = new List<PSPDFBarButtonItem>(controller.RightBarButtonItems);
						barButtons.Add(controller.AnnotationButtonItem);
						controller.RightBarButtonItems = barButtons.ToArray();
						controller.SetPageAnimated(2, false);

						controller.PageMode = PSPDFPageMode.Automatic;
						controller.PageTransition = PSPDFPageTransition.ScrollContinuous;
						controller.ScrollDirection = PSPDFScrollDirection.Horizontal;

						var classDic = new NSMutableDictionary();
						classDic.LowlevelSetObject(new Class(typeof(KSNoteAnnotationController)).Handle, new Class(typeof(PSPDFNoteAnnotationController)).Handle);
						controller.OverrideClassNames = classDic;

						this.NavigationController.PushViewController(controller, true);

						var doc = new KSPDFDocument(hackerMagURL);
						//var doc = new PSPDFDocument();
						//var doc = new PSPDFDocument(annotTestURL);
						
						// Create an entry for overriding the file annotation provider.
						classDic = new NSMutableDictionary();
						classDic.LowlevelSetObject( new Class(typeof(KSFileAnnotationProvider)).Handle, new Class(typeof(PSPDFFileAnnotationProvider)).Handle);
						classDic.LowlevelSetObject( new Class(typeof(KSInkAnnotation)).Handle, new Class(typeof(PSPDFInkAnnotation)).Handle);
						classDic.LowlevelSetObject( new Class(typeof(KSNoteAnnotation)).Handle, new Class(typeof(PSPDFNoteAnnotation)).Handle);
						classDic.LowlevelSetObject( new Class(typeof(KSHighlightAnnotation)).Handle, new Class(typeof(PSPDFHighlightAnnotation)).Handle);
						doc.OverrideClassNames = classDic;

						controller.Document = doc;
					}),

					// Set editable annotation types
					new StringElement ("Set editable annotation types", () =>
					{
						var doc = new PSPDFDocument(hackerMagURL);
						var controller = new PSPDFViewController(doc);
						controller.RightBarButtonItems = new PSPDFBarButtonItem[]
						{
							controller.AnnotationButtonItem
						};

						var set = new NSMutableSet();
						set.Add(PSPDFAnnotation.PSPDFAnnotationTypeStringInk);
						set.Add(PSPDFAnnotation.PSPDFAnnotationTypeStringNote);
						set.Add(PSPDFAnnotation.PSPDFAnnotationTypeStringUnderline);

						controller.AnnotationButtonItem.AnnotationToolbar.EditableAnnotationTypes = set.ToNSOrderedSet();
						this.NavigationController.PushViewController(controller, true);
					})
				}
			};
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			// Restore state as it was before.
			this.NavigationController.SetNavigationBarHidden(false, animated);
			UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.Default, animated);
			UIApplication.SharedApplication.SetStatusBarHidden(false, animated ? UIStatusBarAnimation.Fade : UIStatusBarAnimation.None);
			PSPDFKitGlobal.PSPDFFixNavigationBarForNavigationControllerAnimated(this.NavigationController, false);
			this.NavigationController.NavigationBar.BarStyle = UIBarStyle.Default;
			
			// clear cache (for night mode)
			if (this.clearCacheNeeded)
			{
				this.clearCacheNeeded = false;
				PSPDFCache.SharedCache.ClearCache();
			}
		}
		
		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
			PSPDFKitGlobal.PSPDFFixNavigationBarForNavigationControllerAnimated(this.NavigationController, animated);
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			return AppDelegate.PSIsIpad ? true : toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown;
		}
	}
}
