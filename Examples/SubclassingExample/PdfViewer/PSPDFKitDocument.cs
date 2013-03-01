using System;
using AlexTouch.PSPDFKit;
using MonoTouch.Foundation;

namespace PSPDFTest
{
	public class PSPDFKitDocument : PSPDFDocument
	{
		public PSPDFKitDocument (NSUrl oUrl, bool bAllowsCopying, bool bAllowsPrinting) : base(oUrl)
		{
			this.AllowsCopying = bAllowsCopying;
			this.bAllowsPrinting = bAllowsPrinting;

			// Don't cache. We're dealing with secure documents.
			this.CacheStrategy = PSPDFCacheStrategy.Nothing;

			// Limit annotation types to the ones that API3 supports.
//			this.EditableAnnotationTypes = new NSSet(
//				new string[]
//				{
//					PSPDFAnnotation.PSPDFAnnotationTypeStringNote,
//					PSPDFAnnotation.PSPDFAnnotationTypeStringFreeText,
//					PSPDFAnnotation.PSPDFAnnotationTypeStringHighlight,
//					PSPDFAnnotation.PSPDFAnnotationTypeStringInk
//				}
//			);
		}

		public override bool AllowsPrinting
		{
			get
			{
				return this.bAllowsPrinting;
			}
		}
		private bool bAllowsPrinting;

		PSPDFDocumentProvider oprov;
		/*
		public override PSPDFDocumentProvider DidCreateDocumentProvider (PSPDFDocumentProvider documentProvider)
		{
			this.oprov = base.DidCreateDocumentProvider (documentProvider);
			this.oprov.AnnotationParser.AnnotationProviders = new NSObject[] { new CustomAnnotationProvider(), this.oprov.AnnotationParser.FileAnnotationProvider };
			return this.oprov;
		}
		*/
	}
}

