using System;
using KS_PSPDFKitBindings;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace PSPDFKitDemoXamarin.iOS
{
	public class KSBookmarkParser : PSPDFBookmarkParser
	{
		public KSBookmarkParser(PSPDFDocument doc): base(doc)
		{
			Console.WriteLine("KSBookmarkParser(PSPDFDocument)");
		}

		public KSBookmarkParser (IntPtr handle) : base(handle)
		{
			Console.WriteLine("KSBookmarkParser(IntPtr)");
		}

		public override bool RemoveBookmarkForPage (uint page)
		{
			Console.WriteLine("Remove Bookmark: {0}", page);
			var b = base.RemoveBookmarkForPage (page);
			Console.WriteLine(this.Bookmarks.Length);
			return b;
		}

		public override bool AddBookmarkForPage (uint page)
		{
			Console.WriteLine("Add Bookmark: {0}", page);
			var b = base.AddBookmarkForPage (page);
			Console.WriteLine(this.Bookmarks.Length);
			return b;
		}
	}
}

