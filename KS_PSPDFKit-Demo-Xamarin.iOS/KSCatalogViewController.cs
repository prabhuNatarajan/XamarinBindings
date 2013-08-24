
using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using KS_PSPDFKitBindings;
using MonoTouch.ObjCRuntime;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace PSPDFKitDemoXamarin.iOS
{
	public partial class KSCatalogViewController : DialogViewController
	{
		const string DevelopersGuideFileName = "DevelopersGuide.pdf";
		const string PaperExampleFileName = "amazon-dynamo-sosp2007.pdf";
		const string PSPDFCatalog = "PSPDFKit.pdf";
		const string HackerMagazineExample = "hackermonthly12.pdf";
		const string AesEncryptedDoc = "aes-encrypted.pdf.aes";
		const string AnnotTestExample = "Annotation Test.pdf";

		public bool clearCacheNeeded;

		public KSCatalogViewController () : base (UITableViewStyle.Grouped, null)
		{
			PSPDFKitGlobal.LogLevel = PSPDFLogLevel.Verbose;

			// Add some custom localization to ensure the bindings work.
			PSPDFKitGlobal.Localize("en", new NameValueCollection
			{
				{"Outline", "File Content"},
				{"Bookmarks", "Remember"}
			});

			// Call cache method to ensure the bindings for the cache work.
			var oPdfCache = PSPDFCache.SharedCache;
			oPdfCache.ClearCache ( );

			PSPDFKitGlobal.LogLevel = PSPDFLogLevel.Info;

			NSUrl samplesURL = NSBundle.MainBundle.ResourceUrl.Append ("Samples", true);
			NSUrl hackerMagURL = samplesURL.Append(HackerMagazineExample, false);
			NSUrl aesEncryptedURL = samplesURL.Append(AesEncryptedDoc, false);


			this.Root = new RootElement ("KSCatalogViewController")
			{
				new Section ("Full example apps", "Can be used as a template for your own apps.")
				{
					// PDF playground.
					new StringElement ("PSPDFViewController playground", () =>
					{
						var doc = new PSPDFDocument(hackerMagURL);
						var kioskController = new KSKioskViewController(doc);

						kioskController.StatusBarStyleSetting = PSPDFStatusBarStyleSetting.Default;
						this.NavigationController.PushViewController(kioskController, true);
					}),
				},

				new Section("Customizing")
				{
					// Combines various view controllers in a tab bar controller.
					new StringElement("Combine search, TOC and bookmarks", () =>
					{
						var doc = new PSPDFDocument(hackerMagURL);

						// Don't use PSPDFVieController directly but a subclass that allows attaching to ViewDidDisappear in order to clear
						// the RightBarButtonItems property. Otherwise the tabBarBtn would keep a reference to the PSPDFViewController and the instances
						// would never be freed.

						//var controller = new PSPDFViewController(doc);
						var controller = new KSKioskViewController(doc);
						//controller.ViewDisappeared += (sender, args) => controller.RightBarButtonItems = new PSPDFBarButtonItem[0];

						var tabBarController = new KSCombinedTabBarController(controller, doc);

						var tabBarBtn = new KSBarButtonItem(controller)
						{
							Title = "UITabBarController",
							Style = UIBarButtonItemStyle.Bordered
						};
						tabBarBtn.Clicked += (object sender, EventArgs e) => controller.PresentViewControllerModalOrPopover(tabBarController, true, false, true, tabBarBtn, null);

						controller.RightBarButtonItems = new PSPDFBarButtonItem[] { controller.AnnotationButtonItem, controller.BookmarkButtonItem, tabBarBtn };

						var classDic = new NSMutableDictionary();
						classDic.LowlevelSetObject( new Class(typeof(KSInkAnnotation)).Handle, new Class(typeof(PSPDFInkAnnotation)).Handle);
						classDic.LowlevelSetObject( new Class(typeof(KSNoteAnnotation)).Handle, new Class(typeof(PSPDFNoteAnnotation)).Handle);
						classDic.LowlevelSetObject( new Class(typeof(KSHighlightAnnotation)).Handle, new Class(typeof(PSPDFHighlightAnnotation)).Handle);
						doc.OverrideClassNames = classDic;

						this.NavigationController.PushViewController(controller, true);
					}),

					// Shows an alert when tapping a link annotation.
					new StringElement("Custom reaction on annotation links", () =>
					{
						var doc = new PSPDFDocument(hackerMagURL);
						var controller = new PSPDFViewController(doc);
						controller.Delegate = new KSCatchTappingLinkDelegate();
						// There are link annotations on page 2.
						controller.SetPageAnimated(1, false);
						this.NavigationController.PushViewController(controller, true);
					})
				},

				new Section ("Subclassing")
				{
					// Subclassing PSPDFAnnotationToolbar
					new StringElement ("Subclass annotation toolbar and drawing toolbar", () =>
					{
						var doc = new PSPDFDocument(hackerMagURL);
						var controller = new PSPDFViewController(doc);

						var barButtons = new List<PSPDFBarButtonItem>(controller.RightBarButtonItems);
						barButtons.Add(controller.AnnotationButtonItem);
						controller.RightBarButtonItems = barButtons.ToArray();
						
						var classDic = new NSMutableDictionary();
						classDic.LowlevelSetObject( new Class(typeof(KSAnnotationToolbar)).Handle, new Class(typeof(PSPDFAnnotationToolbar)).Handle);
						controller.OverrideClassNames = classDic;
						
						this.NavigationController.PushViewController(controller, true);
					}),

					// Demonstrates always visible vertical toolbar.
					new StringElement ("Vertical always-visible annotation bar", () =>
					{
						var doc = new PSPDFDocument(hackerMagURL);
						var controller = new KSExampleAnnotationViewController(doc);

						this.NavigationController.PushViewController(controller, true);
					}),

					// Tests potential binding issue when subclassing PSPDFViewController
					new StringElement ("PSPDFViewController with NULL document", () =>
					{
						var doc = new PSPDFDocument(hackerMagURL);
						var controller = new KSNoDocumentPDFViewController();
						controller.Document = doc;
						this.NavigationController.PushViewController(controller, true);
					}),

					// Demonstrates capturing bookmark set/remove.
					new StringElement ("Capture bookmarks", () =>
					{
						var doc = new PSPDFDocument(hackerMagURL);

						// Create an entry for overriding the default bookmark parser.
						var classDic = new NSMutableDictionary();
						classDic.LowlevelSetObject( new Class(typeof(KSBookmarkParser)).Handle, new Class(typeof(PSPDFBookmarkParser)).Handle);
						doc.OverrideClassNames = classDic;

						var controller = new PSPDFViewController(doc);
						controller.RightBarButtonItems = new PSPDFBarButtonItem[]
						{
							controller.BookmarkButtonItem,
							controller.SearchButtonItem,
							controller.OutlineButtonItem,
							controller.ViewModeButtonItem
						};
						this.NavigationController.PushViewController(controller, true);
					}),

					// Demonstrates custom annotation provider.
					new StringElement ("Custom Annotation Provider", () =>
					{
						var doc = new PSPDFDocument(hackerMagURL);
						doc.SetDidCreateDocumentProviderBlock(delegate(PSPDFDocumentProvider documentProvider)
						{
							documentProvider.AnnotationParser.AnnotationProviders = new NSObject[]
							{
								new KSCustomAnnotationProvider(),
								documentProvider.AnnotationParser.FileAnnotationProvider
							};
						});
					
						var controller = new PSPDFViewController(doc);
						this.NavigationController.PushViewController(controller, true);
					}),

					// Subclasses PDPFFileAnnotationProvider and injects additional annotations. 
					// This example demonstrates:
					// * Make all built in annotations (those embedded in the PDF) immutable.
					// * All annotations added by the user can be modified.
					// * Workaround for PSPDFKit bug where the text of a non-editable annotation can still be changed.
					// * Immediate callback if an annotation has been changed.
					new StringElement ("Subclass PSPDFFileAnnotationProvider", () =>
					{
						var controller = new PSPDFViewController();
						var barButtons = new List<PSPDFBarButtonItem>(controller.RightBarButtonItems);
						barButtons.Add(controller.AnnotationButtonItem);
						controller.RightBarButtonItems = barButtons.ToArray();
						controller.SetPageAnimated(2, false);

						controller.PageMode = PSPDFPageMode.Automatic;
						controller.PageTransition = PSPDFPageTransition.ScrollContinuous;
						controller.ScrollDirection = PSPDFScrollDirection.Horizontal;

						var classDic = new NSMutableDictionary();
						classDic.LowlevelSetObject(new Class(typeof(KSNoteAnnotationController)).Handle, new Class(typeof(PSPDFNoteAnnotationController)).Handle);
						controller.OverrideClassNames = classDic;

						this.NavigationController.PushViewController(controller, true);

						var doc = new KSPDFDocument(hackerMagURL);
						//var doc = new PSPDFDocument();
						//var doc = new PSPDFDocument(annotTestURL);
						
						// Create an entry for overriding the file annotation provider.
						classDic = new NSMutableDictionary();
						classDic.LowlevelSetObject( new Class(typeof(KSFileAnnotationProvider)).Handle, new Class(typeof(PSPDFFileAnnotationProvider)).Handle);
						classDic.LowlevelSetObject( new Class(typeof(KSInkAnnotation)).Handle, new Class(typeof(PSPDFInkAnnotation)).Handle);
						classDic.LowlevelSetObject( new Class(typeof(KSNoteAnnotation)).Handle, new Class(typeof(PSPDFNoteAnnotation)).Handle);
						classDic.LowlevelSetObject( new Class(typeof(KSHighlightAnnotation)).Handle, new Class(typeof(PSPDFHighlightAnnotation)).Handle);
						doc.OverrideClassNames = classDic;

						controller.Document = doc;
					}),

					// Set editable annotation types
					new StringElement ("Set editable annotation types", () =>
					{
						var doc = new PSPDFDocument(hackerMagURL);
						var controller = new PSPDFViewController(doc);
						controller.RightBarButtonItems = new PSPDFBarButtonItem[]
						{
							controller.AnnotationButtonItem
						};

						var set = new NSMutableSet();
						set.Add(PSPDFAnnotation.PSPDFAnnotationTypeStringInk);
						set.Add(PSPDFAnnotation.PSPDFAnnotationTypeStringNote);
						set.Add(PSPDFAnnotation.PSPDFAnnotationTypeStringUnderline);

						controller.AnnotationButtonItem.AnnotationToolbar.EditableAnnotationTypes = set.ToNSOrderedSet();
						this.NavigationController.PushViewController(controller, true);
					})
				},

				new Section("Security")
				{
					// This shows and tests decryption and viewing of a pre-encrypted document.
					new StringElement("Read AES encrypted document", () => {
						// Note: For shipping apps, you need to protect this string better, making it harder for hacker to simply disassemble and receive the key from the binary. Or add an internet service that fetches the key from an SSL-API. But then there's still the slight risk of memory dumping with an attached gdb. Or screenshots. Security is never 100% perfect; but using AES makes it way harder to get the PDF. You can even combine AES and a PDF password.
						string passphrase = @"afghadöghdgdhfgöhapvuenröaoeruhföaeiruaerub";
						string salt = @"ducrXn9WaRdpaBfMjDTJVjUf3FApA6gtim0e61LeSGWV9sTxB0r26mPs59Lbcexn";

						var cryptoWrapper = new PSPDFAESCryptoDataProvider(aesEncryptedURL, passphrase, salt);

						var provider = cryptoWrapper.DataProvider;
						var document = PSPDFDocument.PDFDocumentWithDataProvider(provider);
						document.Uid = AesEncryptedDoc; // manually set an UID for encrypted documents.

						// When PSPDFAESCryptoDataProvider is used, the cacheStrategy of PSPDFDocument is *automatically* set to PSPDFCacheNothing.
						// If you use your custom crypto solution, don't forget to set this to not leak out encrypted data as cached images.
						// document.cacheStrategy = PSPDFCacheNothing;

						var controller = new PSPDFViewController(document);
						this.NavigationController.PushViewController(controller, true);
					}),

					// This encrypts a PDF, saves it and then opens it.
					new StringElement("Encrypt a PDF and decrypt it again", () => {
						var targetFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "encrypted.pdf.aes");

						// The passphrase is a secret! Keep it secret!
						string passphrase = "Hello World, I'm the secret!";

						// The salt has to be at least 8 bytes. It should change for every encrypted document, just like the IV.
						// You can store it in cleartext together with your encrypted record, it's not a secret but used to prevent that
						// two identical passwords generate the same hash.
						// The salt should NOT be "12345678"! This is just for testing! Use something random.
						string salt = "132456789";

						// PSPDFKit v2 does not allow passing the key directly. Instead it regegenerates the key using native PBKDF2.
						// PSPDFKit v3 will have different API where you can use the key directly.
						// Also note that PSPDFKit internally uses 50000 hashing iterations, so we have to use exactly the same algorithm.
						// Rfc2898DeriveBytes only supports SHA1, so we have a flexible version of it here where you can specify the hashing alogorithm.
						var deriveBytes = new Rfc2898DeriveBytesFlexible(passphrase, Encoding.UTF8.GetBytes(salt), 50000, new HMACSHA256());

						// Encrypt the PDF.
						using (var rijndael = new RijndaelManaged())
						{
							rijndael.KeySize = 256;

							rijndael.Key = deriveBytes.GetBytes ( rijndael.KeySize / 8 );
							rijndael.IV = deriveBytes.GetBytes ( rijndael.BlockSize / 8 ); 

							using(var readStream = File.Open("./Samples/" + HackerMagazineExample, FileMode.Open))
							using(var writeStream = File.Open(targetFilePath, FileMode.Create))
							using(var cryptoTrans = rijndael.CreateEncryptor ())
							using(var encryptedStream = new CryptoStream (writeStream, cryptoTrans, CryptoStreamMode.Write))
							{
								// Write the IV unencrypted first.
								writeStream.Write(rijndael.IV, 0, rijndael.IV.Length);
								// Then the encrypted PDF.
								readStream.CopyTo(encryptedStream);
							}
						}

						// Decrypt the just encrypted file and view it.
						var cryptoWrapper = new PSPDFAESCryptoDataProvider(NSUrl.FromFilename(targetFilePath), passphrase, salt);

						var provider = cryptoWrapper.DataProvider;
						var document = PSPDFDocument.PDFDocumentWithDataProvider(provider);
						document.Uid = AesEncryptedDoc; // manually set an UID for encrypted documents.

						// When PSPDFAESCryptoDataProvider is used, the cacheStrategy of PSPDFDocument is *automatically* set to PSPDFCacheNothing.
						// If you use your custom crypto solution, don't forget to set this to not leak out encrypted data as cached images.
						// document.cacheStrategy = PSPDFCacheNothing;

						var controller = new PSPDFViewController(document);
						this.NavigationController.PushViewController(controller, true);
					})
				}
			};
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			// Restore state as it was before.
			this.NavigationController.SetNavigationBarHidden(false, animated);
			UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.Default, animated);
			UIApplication.SharedApplication.SetStatusBarHidden(false, animated ? UIStatusBarAnimation.Fade : UIStatusBarAnimation.None);
			PSPDFKitGlobal.PSPDFFixNavigationBarForNavigationControllerAnimated(this.NavigationController, false);
			this.NavigationController.NavigationBar.BarStyle = UIBarStyle.Default;
			
			// clear cache (for night mode)
			if (this.clearCacheNeeded)
			{
				this.clearCacheNeeded = false;
				PSPDFCache.SharedCache.ClearCache();
			}
		}
		
		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
			PSPDFKitGlobal.PSPDFFixNavigationBarForNavigationControllerAnimated(this.NavigationController, animated);
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			return AppDelegate.PSIsIpad ? true : toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown;
		}
	}
}
