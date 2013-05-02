using System;
using KS_PSPDFKitBindings;
using MonoTouch.UIKit;
using System.Drawing;

namespace PSPDFKitDemoXamarin.iOS
{
	public class KSCatchTappingLinkDelegate : PSPDFViewControllerDelegate
	{
		public KSCatchTappingLinkDelegate () : base()
		{
		}

		public override bool DidTapOnAnnotation (PSPDFViewController pdfController, PSPDFAnnotation annotation, System.Drawing.PointF annotationPoint, PSPDFAnnotationViewProtocol annotationView, PSPDFPageView pageView, System.Drawing.PointF viewPoint)
		{
			if(annotation is PSPDFLinkAnnotation)
			{
				var linkAnnot = (PSPDFLinkAnnotation)annotation;
				Console.WriteLine("Tapped a link annotation!");
				var alert = new UIAlertView("TapTap", "Tapped link annotation. Target: " + linkAnnot.SiteLinkTarget, null, null, "OK");
				alert.Show();
				return true;
			}
			return false;
		}
	}
}

