using System;
using AlexTouch.PSPDFKit;
using MonoTouch.Foundation;

namespace PSPDFTest
{
	[Register ("CustomFileAnnnotationsProvider")] public class CustomFileAnnnotationsProvider : PSPDFFileAnnotationProvider
	{
		[Export("initWithDocumentProvider:")]
		public CustomFileAnnnotationsProvider (PSPDFDocumentProvider documentProvider) : base(documentProvider)
		{
			Console.WriteLine ("CustomFileAnnnotationsProvider (PSPDFDocumentProvider documentProvider) ");
		}
	}

}

