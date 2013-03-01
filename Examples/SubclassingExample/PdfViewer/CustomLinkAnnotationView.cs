using System;
using AlexTouch.PSPDFKit;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace PSPDFTest
{
	public class CustomLinkAnnotationView : PSPDFLinkAnnotationView
	{
		public CustomLinkAnnotationView (IntPtr handle) : base(handle)
		{
			Console.WriteLine("*** CustomLinkAnnotationView(IntPtr)");
		}

		public override void DidShowPage (uint page)
		{
			this.BorderColor = new UIColor(1f, 0f, 0f, 0.5f);
			this.HighlightBackgroundColor = new UIColor(1f ,0f ,0f, 0.5f);
		}

		public override void WillHidePage (uint page)
		{
		}

		public override void WillShowPage (uint page)
		{
		}

		public override void DidHidePage (uint page)
		{
		}
	}

}

