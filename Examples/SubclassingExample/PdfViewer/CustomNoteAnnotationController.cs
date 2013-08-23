using System;
using System.Linq;
using AlexTouch.PSPDFKit;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace PSPDFTest
{
	[Register("CustomNoteAnnotationController")]
	public class CustomNoteAnnotationController : PSPDFNoteAnnotationController
	{
		public CustomNoteAnnotationController (PSPDFAnnotation annot, bool bAllowEditing) : base(annot, bAllowEditing)
		{
			Console.WriteLine("*** CustomNoteAnnotationController(PSPDFDocumentProvider)");
		}

		public CustomNoteAnnotationController (IntPtr handle) : base (handle)
		{
			Console.WriteLine("*** CustomNoteAnnotationController(IntPtr)");
		}

		public CustomNoteAnnotationController (NSObjectFlag t) : base (t)
		{
			Console.WriteLine("*** CustomNoteAnnotationController(NSObjectFlag)");
		}

		public CustomNoteAnnotationController (NSCoder coder) : base (coder)
		{
			Console.WriteLine("*** CustomNoteAnnotationController(NSCoder)");
		}

		public CustomNoteAnnotationController () : base ()
		{
			Console.WriteLine("*** CustomNoteAnnotationController()");
		}

		public override bool AllowEditing
		{
			get
			{
				return false;
				//return base.AllowEditing;
			}
		}

		public override void ViewWillAppear (bool animated)
		{
			Console.WriteLine(this.Annotation);
			base.ViewWillAppear (animated);
			if (!this.AllowEditing)
			{
				UITextView oTxtView = this.View.Subviews.FirstOrDefault (oSub => oSub is UITextView) as UITextView;
				oTxtView.Editable = false;
			}
		}

		public override bool ShowColorAndIconOptions
		{
			get
			{
				return false;
				//return base.ShowColorAndIconOptions;
			}
			set
			{
				base.ShowColorAndIconOptions = value;
			}
		}

		private UIColor _TintColor;
		public override MonoTouch.UIKit.UIColor TintColor
		{
			get
			{
				return _TintColor;
			}
			set
			{
				this._TintColor = value;
			}
		}
		
		private MonoTouch.UIKit.UIBarStyle _BarStyle;
		public override MonoTouch.UIKit.UIBarStyle BarStyle 
		{
			get {
				return _BarStyle;
			}
			set {
				_BarStyle = value;
			}
		}
		
		private bool _IsBarTranslucent;
		public override bool IsBarTranslucent {
			get {
				return _IsBarTranslucent;
			}
			set {
				_IsBarTranslucent = value;
			}
		}
		
		private bool _IsInPopover;
		public override bool IsInPopover {
			get {
				return _IsInPopover;
			}
			set {
				_IsInPopover = value;
			}
		}
	}
}

