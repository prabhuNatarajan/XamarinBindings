using System;
using AlexTouch.PSPDFKit;
using System.Drawing;

namespace PSPDFTest
{
	public class CustomAnnotationProvider : PSPDFAnnotationProvider
	{
		public CustomAnnotationProvider () : base()
		{
		}

		public CustomAnnotationProvider (IntPtr handle) : base(handle)
		{
		}

		public override PSPDFAnnotation[] AnnotationsForPage (uint page)
		{
			Console.WriteLine("*** CustomAnnotationProvider.AnnotationsForPage()");
			var oPSPDFAnnot = new CustomNoteAnnotation()
			{
				Page = page,
				BoundingBox = new RectangleF(70, 750, 32, 32),
				Contents = "A Sticky",
				Editable = true
			};
			return new PSPDFAnnotation[] { oPSPDFAnnot };
		}
	}
}

