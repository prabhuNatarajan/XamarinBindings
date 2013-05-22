using System;
using MonoTouch.Dialog;
using MonoTouch.UIKit;
using KS_PSPDFKitBindings;
using MonoTouch.Foundation;
using System.Drawing;

namespace PSPDFKitDemoXamarin.iOS
{
	public class KSAnnotationElement :  Element, IElementSizing 
	{
		
		private PSPDFAnnotation annot;
		
		UILabel labelName;
		UILabel lableDesc;
		
		public KSAnnotationElement (PSPDFAnnotation annot) : base( ""  ) 
		{
			this.annot = annot;
			this.oImgIcon = new UIImage ();
		}
		
		private string sIconName;
		private UIImage oImgIcon;
		private UIImageView oIconView;
		
		public string IconName
		{
			get
			{
				return this.sIconName;
			}
			set
			{
				this.sIconName = value;
				this.oIconView.Image = UIImage.FromBundle("ResourceData/VerticalToolbar/" + value) ;
			}
		}
		
		public event NSAction Tapped;
		
		private int iPadding = 60;
		
		public override UITableViewCell GetCell(UITableView oTableView)
		{
			
			var oCell = oTableView.DequeueReusableCell (CellKey);
			if (oCell == null) 
			{
				oCell = new UITableViewCell (UITableViewCellStyle.Default, CellKey);
				oCell.SelectionStyle = UITableViewCellSelectionStyle.None;
				
				float fWidth = oCell.ContentView.Bounds.Width ;
				
				this.labelName = new UILabel (new RectangleF ( iPadding,  5,  fWidth-50  -30, 25 ));
				this.lableDesc = new UILabel (new RectangleF ( iPadding,  30, fWidth-50  -30, 45 ));
				
				this.oIconView = new UIImageView (new RectangleF (0, 10, 40, 40));
				this.oIconView.Image = this.oImgIcon;
				this.oIconView.Frame = new RectangleF (new PointF (10, 10), this.oIconView.Bounds.Size);
				
				oCell.ContentView.AddSubview (this.labelName);
				oCell.ContentView.AddSubview (this.lableDesc);
				oCell.ContentView.AddSubview (this.oIconView);
			} 
			else 
			{
				RemoveTag (oCell, 1);
				
				//Reuse Cell
				this.labelName = (UILabel)oCell.ContentView.Subviews[0];
				this.lableDesc = (UILabel)oCell.ContentView.Subviews[1];
				this.oIconView =(UIImageView)oCell.ContentView.Subviews[2];
				
			}
			
			
			//Name
			labelName.Text = annot.AnnotationType.ToString();
			labelName.BackgroundColor = UIColor.Clear;
			
			//Desc
			lableDesc.Text = annot.Contents;
			lableDesc.LineBreakMode = UILineBreakMode.TailTruncation;
			lableDesc.TextColor = UIColor.DarkGray;
			lableDesc.BackgroundColor = UIColor.Clear;
			lableDesc.ClipsToBounds = true;
			lableDesc.Lines = 0;
			lableDesc.Font = UIFont.SystemFontOfSize (13);
			
			
			if (this.annot is KSInkAnnotation) 
			{
				this.IconName = "annot-ink-1";
			} 
			else if (this.annot is KSNoteAnnotation) 
			{
				this.IconName = "annot-note-1";
			} 
			else if (this.annot is KSHighlightAnnotation) 
			{
				this.IconName = "annot-highlight-1";
			} 
			else
			{
				this.IconName = "notKnown";
			}
			
			return oCell;
		}
		
		public override void Selected (DialogViewController dvc, UITableView tableView, NSIndexPath path)
		{
			if (Tapped != null)
				Tapped ();
			tableView.DeselectRow (path, true);
		}
		
		#region IElementSizing implementation
		
		public float GetHeight (UITableView tableView, NSIndexPath indexPath)
		{
			return 80;
		}
		
		#endregion
	}
}

