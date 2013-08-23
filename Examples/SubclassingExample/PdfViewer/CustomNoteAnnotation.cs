using System;
using AlexTouch.PSPDFKit;

namespace PSPDFTest
{
	public class CustomNoteAnnotation : PSPDFNoteAnnotation
	{
		public CustomNoteAnnotation () : base()
		{
		}

		public CustomNoteAnnotation (IntPtr handle) : base(handle)
		{
		}
	}
}

