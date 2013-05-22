using System;
using MonoTouch.Dialog;
using KS_PSPDFKitBindings;
using System.Threading.Tasks;
using MonoTouch.UIKit;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Drawing;
using MonoTouch.Foundation;

namespace PSPDFKitDemoXamarin.iOS
{
	/// <summary>
	/// Displays a list of annotations.
	/// </summary>
	public class KSAnnotationsListController: DialogViewController 
	{
		PSPDFDocument document;
		PSPDFViewController controller;

		//Seperate Task to get the annotations
		Task taskGetAnnotations;

		ActivityElement activeElem;
		Section sectionActive;

		public KSAnnotationsListController (PSPDFDocument document, PSPDFViewController controller) :base (UITableViewStyle.Plain, null)
		{
			this.Title = "Annotations";
			this.document = document;
			this.controller = controller;
			this.Root = new RootElement (string.Empty);

			//First cell is "loading..." cell and then it is larger cells
			this.Root.UnevenRows = true;

		}


		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);

			sectionActive = new Section ();
			activeElem = new ActivityElement ()
			{
				Animating = true
			};

			activeElem.Caption = "Loading...";
			activeElem.Animating = true;
			sectionActive.Add (activeElem);

			this.Root.Clear ();
			this.Root.Add (sectionActive);
			
			this.RefreshSource();
		}



		private void RefreshSource()
		{
			if (this.taskGetAnnotations != null && taskGetAnnotations.Status == TaskStatus.Running) 
			{
				return;
			}

			//Threaded as could take a while if a big document or lots of annotations
			this.taskGetAnnotations = Task.Factory.StartNew( () => this.PopulateAnnotationSource());
			
		}
		
		
		private void PopulateAnnotationSource()
		{
			List<Section> sections = new List<Section> ();
			
			//Thread.Sleep (6000);
			//For every page get custom annotations and add to source
			for (uint page =0; page < this.document.PageCount; page++) 
			{

				List<PSPDFAnnotation> annots = new List<PSPDFAnnotation> ();

				var annotsForPage = this.document.AnnotationParser.FileAnnotationProvider.AnnotationsForPage(page);
				
				if(annotsForPage.Length < 1)
				{
					continue;
				}
				
				//loop and add only custom
				foreach (var annot in annotsForPage)
				{

					if( !(annot is IKSAnnotation) )
					{
						//Only want annotations we made ..
						continue;
					}

					annots.Add(annot);	
					  
				}

				if(annots.Count < 1)
				{
					//no point continuing
					continue;
				}

				//Sort by Type
				annots.Sort ( (x, y) => 
			    {
					//Sort by Page and then Type
					return  String.Compare( x.TypeString , y.TypeString );
				
				});


				//Create Sections
				Section section = new Section("Page " + (page + 1).ToString() );
				sections.Add(section);
				foreach(var annot in annots)
				{
					PSPDFAnnotation annotCapture = annot;
					var tabElem = new KSAnnotationElement ( annot );
					tabElem.Tapped += () => 
					{
						this.controller.SetPageAnimated(annotCapture.Page,true);

						//Close Modal
						this.controller.PopoverController.Dismiss(true);
						this.controller.PopoverController = null;
					};


					section.Add(tabElem);
				}

			}

			//Now Completed , Now Remove the Activity Indicator and load the sections
			InvokeOnMainThread (() => 
			{
				//Remove Activity Indicator
				this.Root.Remove(this.Root.ElementAt(0), UITableViewRowAnimation.Automatic);
				
				//Insert Sections (Pages number with Annotations)
				this.Root.Insert(0, UITableViewRowAnimation.Bottom, sections.ToArray());
		
			});


		}
	}
}

