using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using  AlexTouch.PSPDFKit;

namespace PSPDFKitMonoTouchTest
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;

		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// Create a new window instance based on the screen size
			window = new UIWindow (UIScreen.MainScreen.Bounds);

			// Create the document
			PSPDFDocument document = new PSPDFDocument(NSUrl.FromFilename(Path.Combine(NSBundle.MainBundle.BundlePath, "hackermonthly12.pdf")));
			Console.WriteLine("Using document path: " + document.FileURL.Path);

			// Create the controller and encapsulate it into a UINavigationController for easier access.
			PSPDFViewController pdfController = new PSPDFViewController (document);
			UINavigationController navController = new UINavigationController (pdfController);
			
			// If you have defined a root view controller, set it here:
			window.RootViewController = navController;
			
			// make the window visible
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}

