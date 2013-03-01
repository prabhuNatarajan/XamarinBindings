using System;
using AlexTouch.PSPDFKit;
using System.Collections.Generic;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace PSPDFTest
{
	/// <summary>
	/// Delegate for the PSPDFViewController.
	/// </summary>
	public class PSPDFKitViewControllerDelegate : PSPDFViewControllerDelegate
	{
		public PSPDFKitViewControllerDelegate () : base()
		{

		}

		public override void DidLoadPageView (PSPDFViewController pdfController, PSPDFPageView pageView)
		{
			// Fixed in 2.6.4 bindings. Looping subviews no longer crashes.
			foreach(UIView oSubview in pageView.Subviews)
			{
				Console.WriteLine(oSubview.DebugDescription);
			}
		}
	}
}

