using System;
using AlexTouch.PSPDFKit;
using MonoTouch.Foundation;
using System.Collections.Generic;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;

namespace PSPDFTest
{
	/// <summary>
	/// Helper class for all tasks related to PSPDFKit, the PDF library we use.
	/// </summary>
	public static class PSPDFKitHelper
	{
		/// <summary>
		/// Creates an instance of the PDF viewer.
		/// </summary>
		/// <returns>
		/// The PDF viewer.
		/// </returns>
		/// <param name='sFilename'>
		/// Name of the PDF to open.
		/// </param>
		/// <param name='iInitialPage'>
		/// The initial pae number to go to.
		/// </param>
		/// <param name='bAllowsPrinting'>
		/// True to enable the print menu.
		/// </param>
		/// <param name='bAllowsExport'>
		/// True to allow exporting the document to other apps.
		/// </param>
		public static PSPDFViewController CreatePDFViewer(string sFilename, uint iInitialPage, bool bAllowsPrinting, bool bAllowsExport)
		{
			// Use PSPDFKit to view PDFs.
			var document = new PSPDFKitDocument(NSUrl.FromFilename(sFilename), bAllowsExport && bAllowsPrinting, bAllowsExport && bAllowsPrinting);
	
			var oClassDic = new NSMutableDictionary();
			//oClassDic [new NSString("PSPDFFileAnnotationProvider")] = new NSString("CustomFileAnnnotationsProvider");
			oClassDic.LowlevelSetObject(new Class(typeof(CustomFileAnnnotationsProvider)).Handle, new Class(typeof(PSPDFFileAnnotationProvider)).Handle);
			document.OverrideClassNames = oClassDic;

			// Read PDF properties from config.
			PSPDFPageTransition ePageTransition = PSPDFPageTransition.Curl;
			PSPDFPageMode ePageMode = PSPDFPageMode.Automatic;
			PSPDFScrollDirection eScrollDirection = PSPDFScrollDirection.Horizontal;

			var oPdfViewer = new PSPDFViewController(document)
			{
				ModalPresentationStyle = MonoTouch.UIKit.UIModalPresentationStyle.FullScreen,
				ModalTransitionStyle = MonoTouch.UIKit.UIModalTransitionStyle.CoverVertical,
				LinkAction = PSPDFLinkAction.OpenSafari,
				PageTransition = ePageTransition,
				PageMode = ePageMode,
				ScrollDirection = eScrollDirection,
				RenderAnnotationTypes = PSPDFAnnotationType.Highlight | PSPDFAnnotationType.Ink | PSPDFAnnotationType.Note | PSPDFAnnotationType.Text | PSPDFAnnotationType.Link,
				Delegate = new PSPDFKitViewControllerDelegate()
			};

			var oControllerClassDic = new NSMutableDictionary();
			oControllerClassDic.LowlevelSetObject(new Class(typeof(CustomNoteAnnotationController)).Handle, new Class(typeof(PSPDFNoteAnnotationController)).Handle);
			oControllerClassDic.LowlevelSetObject(new Class(typeof(CustomLinkAnnotationView)).Handle, new Class(typeof(PSPDFLinkAnnotationView)).Handle);
			oPdfViewer.OverrideClassNames = oControllerClassDic;
			
			List<PSPDFBarButtonItem> aButtons = new List<PSPDFBarButtonItem>()
			{
				oPdfViewer.AnnotationButtonItem,
				oPdfViewer.BookmarkButtonItem,
				oPdfViewer.SearchButtonItem,
				oPdfViewer.OutlineButtonItem
			};
			
			if(bAllowsPrinting && bAllowsExport)
			{
				//aButtons.Add(this.oPdfViewer.EmailButtonItem);
				aButtons.Add(oPdfViewer.PrintButtonItem);
				aButtons.Add(oPdfViewer.OpenInButtonItem);
			}
			
			aButtons.Add(oPdfViewer.ViewModeButtonItem);
			
			oPdfViewer.RightBarButtonItems = aButtons.ToArray();
			aButtons = null;
			
			oPdfViewer.SetPageAnimated(iInitialPage, false);

			return oPdfViewer;
		}
	}
}

