//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using MonoTouch;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreMedia;
using MonoTouch.CoreMotion;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.NewsstandKit;
using MonoTouch.GLKit;
using MonoTouch.CoreVideo;
using OpenTK;

namespace KS_PSPDFKitBindings {
	[Register("PSPDFAnnotation", true)]
	public unsafe partial class PSPDFAnnotation : PSPDFModel {
		[CompilerGenerated]
		const string selIsWriteable = "isWriteable";
		static readonly IntPtr selIsWriteableHandle = Selector.GetHandle ("isWriteable");
		[CompilerGenerated]
		const string selIsMovable = "isMovable";
		static readonly IntPtr selIsMovableHandle = Selector.GetHandle ("isMovable");
		[CompilerGenerated]
		const string selIsResizable = "isResizable";
		static readonly IntPtr selIsResizableHandle = Selector.GetHandle ("isResizable");
		[CompilerGenerated]
		const string selType = "type";
		static readonly IntPtr selTypeHandle = Selector.GetHandle ("type");
		[CompilerGenerated]
		const string selIsOverlay = "isOverlay";
		static readonly IntPtr selIsOverlayHandle = Selector.GetHandle ("isOverlay");
		[CompilerGenerated]
		const string selSetOverlay_ = "setOverlay:";
		static readonly IntPtr selSetOverlay_Handle = Selector.GetHandle ("setOverlay:");
		[CompilerGenerated]
		const string selIsEditable = "isEditable";
		static readonly IntPtr selIsEditableHandle = Selector.GetHandle ("isEditable");
		[CompilerGenerated]
		const string selSetEditable_ = "setEditable:";
		static readonly IntPtr selSetEditable_Handle = Selector.GetHandle ("setEditable:");
		[CompilerGenerated]
		const string selTypeString = "typeString";
		static readonly IntPtr selTypeStringHandle = Selector.GetHandle ("typeString");
		[CompilerGenerated]
		const string selSetTypeString_ = "setTypeString:";
		static readonly IntPtr selSetTypeString_Handle = Selector.GetHandle ("setTypeString:");
		[CompilerGenerated]
		const string selAlpha = "alpha";
		static readonly IntPtr selAlphaHandle = Selector.GetHandle ("alpha");
		[CompilerGenerated]
		const string selSetAlpha_ = "setAlpha:";
		static readonly IntPtr selSetAlpha_Handle = Selector.GetHandle ("setAlpha:");
		[CompilerGenerated]
		const string selColor = "color";
		static readonly IntPtr selColorHandle = Selector.GetHandle ("color");
		[CompilerGenerated]
		const string selSetColor_ = "setColor:";
		static readonly IntPtr selSetColor_Handle = Selector.GetHandle ("setColor:");
		[CompilerGenerated]
		const string selColorWithAlpha = "colorWithAlpha";
		static readonly IntPtr selColorWithAlphaHandle = Selector.GetHandle ("colorWithAlpha");
		[CompilerGenerated]
		const string selFillColor = "fillColor";
		static readonly IntPtr selFillColorHandle = Selector.GetHandle ("fillColor");
		[CompilerGenerated]
		const string selSetFillColor_ = "setFillColor:";
		static readonly IntPtr selSetFillColor_Handle = Selector.GetHandle ("setFillColor:");
		[CompilerGenerated]
		const string selFillColorWithAlpha = "fillColorWithAlpha";
		static readonly IntPtr selFillColorWithAlphaHandle = Selector.GetHandle ("fillColorWithAlpha");
		[CompilerGenerated]
		const string selContents = "contents";
		static readonly IntPtr selContentsHandle = Selector.GetHandle ("contents");
		[CompilerGenerated]
		const string selSetContents_ = "setContents:";
		static readonly IntPtr selSetContents_Handle = Selector.GetHandle ("setContents:");
		[CompilerGenerated]
		const string selName = "name";
		static readonly IntPtr selNameHandle = Selector.GetHandle ("name");
		[CompilerGenerated]
		const string selSetName_ = "setName:";
		static readonly IntPtr selSetName_Handle = Selector.GetHandle ("setName:");
		[CompilerGenerated]
		const string selLastModified = "lastModified";
		static readonly IntPtr selLastModifiedHandle = Selector.GetHandle ("lastModified");
		[CompilerGenerated]
		const string selSetLastModified_ = "setLastModified:";
		static readonly IntPtr selSetLastModified_Handle = Selector.GetHandle ("setLastModified:");
		[CompilerGenerated]
		const string selCreationDate = "creationDate";
		static readonly IntPtr selCreationDateHandle = Selector.GetHandle ("creationDate");
		[CompilerGenerated]
		const string selSetCreationDate_ = "setCreationDate:";
		static readonly IntPtr selSetCreationDate_Handle = Selector.GetHandle ("setCreationDate:");
		[CompilerGenerated]
		const string selLineWidth = "lineWidth";
		static readonly IntPtr selLineWidthHandle = Selector.GetHandle ("lineWidth");
		[CompilerGenerated]
		const string selSetLineWidth_ = "setLineWidth:";
		static readonly IntPtr selSetLineWidth_Handle = Selector.GetHandle ("setLineWidth:");
		[CompilerGenerated]
		const string selBorderStyle = "borderStyle";
		static readonly IntPtr selBorderStyleHandle = Selector.GetHandle ("borderStyle");
		[CompilerGenerated]
		const string selSetBorderStyle_ = "setBorderStyle:";
		static readonly IntPtr selSetBorderStyle_Handle = Selector.GetHandle ("setBorderStyle:");
		[CompilerGenerated]
		const string selDashArray = "dashArray";
		static readonly IntPtr selDashArrayHandle = Selector.GetHandle ("dashArray");
		[CompilerGenerated]
		const string selSetDashArray_ = "setDashArray:";
		static readonly IntPtr selSetDashArray_Handle = Selector.GetHandle ("setDashArray:");
		[CompilerGenerated]
		const string selIsDeleted = "isDeleted";
		static readonly IntPtr selIsDeletedHandle = Selector.GetHandle ("isDeleted");
		[CompilerGenerated]
		const string selSetDeleted_ = "setDeleted:";
		static readonly IntPtr selSetDeleted_Handle = Selector.GetHandle ("setDeleted:");
		[CompilerGenerated]
		const string selBoundingBox = "boundingBox";
		static readonly IntPtr selBoundingBoxHandle = Selector.GetHandle ("boundingBox");
		[CompilerGenerated]
		const string selSetBoundingBox_ = "setBoundingBox:";
		static readonly IntPtr selSetBoundingBox_Handle = Selector.GetHandle ("setBoundingBox:");
		[CompilerGenerated]
		const string selRotation = "rotation";
		static readonly IntPtr selRotationHandle = Selector.GetHandle ("rotation");
		[CompilerGenerated]
		const string selSetRotation_ = "setRotation:";
		static readonly IntPtr selSetRotation_Handle = Selector.GetHandle ("setRotation:");
		[CompilerGenerated]
		const string selRects = "rects";
		static readonly IntPtr selRectsHandle = Selector.GetHandle ("rects");
		[CompilerGenerated]
		const string selSetRects_ = "setRects:";
		static readonly IntPtr selSetRects_Handle = Selector.GetHandle ("setRects:");
		[CompilerGenerated]
		const string selPoints = "points";
		static readonly IntPtr selPointsHandle = Selector.GetHandle ("points");
		[CompilerGenerated]
		const string selSetPoints_ = "setPoints:";
		static readonly IntPtr selSetPoints_Handle = Selector.GetHandle ("setPoints:");
		[CompilerGenerated]
		const string selUser = "user";
		static readonly IntPtr selUserHandle = Selector.GetHandle ("user");
		[CompilerGenerated]
		const string selSetUser_ = "setUser:";
		static readonly IntPtr selSetUser_Handle = Selector.GetHandle ("setUser:");
		[CompilerGenerated]
		const string selPage = "page";
		static readonly IntPtr selPageHandle = Selector.GetHandle ("page");
		[CompilerGenerated]
		const string selSetPage_ = "setPage:";
		static readonly IntPtr selSetPage_Handle = Selector.GetHandle ("setPage:");
		[CompilerGenerated]
		const string selAbsolutePage = "absolutePage";
		static readonly IntPtr selAbsolutePageHandle = Selector.GetHandle ("absolutePage");
		[CompilerGenerated]
		const string selSetAbsolutePage_ = "setAbsolutePage:";
		static readonly IntPtr selSetAbsolutePage_Handle = Selector.GetHandle ("setAbsolutePage:");
		[CompilerGenerated]
		const string selIsDirty = "isDirty";
		static readonly IntPtr selIsDirtyHandle = Selector.GetHandle ("isDirty");
		[CompilerGenerated]
		const string selSetDirty_ = "setDirty:";
		static readonly IntPtr selSetDirty_Handle = Selector.GetHandle ("setDirty:");
		[CompilerGenerated]
		const string selDocumentProvider = "documentProvider";
		static readonly IntPtr selDocumentProviderHandle = Selector.GetHandle ("documentProvider");
		[CompilerGenerated]
		const string selSetDocumentProvider_ = "setDocumentProvider:";
		static readonly IntPtr selSetDocumentProvider_Handle = Selector.GetHandle ("setDocumentProvider:");
		[CompilerGenerated]
		const string selDocument = "document";
		static readonly IntPtr selDocumentHandle = Selector.GetHandle ("document");
		[CompilerGenerated]
		const string selPageRotation = "pageRotation";
		static readonly IntPtr selPageRotationHandle = Selector.GetHandle ("pageRotation");
		[CompilerGenerated]
		const string selSetPageRotation_ = "setPageRotation:";
		static readonly IntPtr selSetPageRotation_Handle = Selector.GetHandle ("setPageRotation:");
		[CompilerGenerated]
		const string selHasAppearanceStream = "hasAppearanceStream";
		static readonly IntPtr selHasAppearanceStreamHandle = Selector.GetHandle ("hasAppearanceStream");
		[CompilerGenerated]
		const string selUserInfo = "userInfo";
		static readonly IntPtr selUserInfoHandle = Selector.GetHandle ("userInfo");
		[CompilerGenerated]
		const string selSetUserInfo_ = "setUserInfo:";
		static readonly IntPtr selSetUserInfo_Handle = Selector.GetHandle ("setUserInfo:");
		[CompilerGenerated]
		const string selInfoDescription = "infoDescription";
		static readonly IntPtr selInfoDescriptionHandle = Selector.GetHandle ("infoDescription");
		[CompilerGenerated]
		const string selIndexOnPage = "indexOnPage";
		static readonly IntPtr selIndexOnPageHandle = Selector.GetHandle ("indexOnPage");
		[CompilerGenerated]
		const string selSetIndexOnPage_ = "setIndexOnPage:";
		static readonly IntPtr selSetIndexOnPage_Handle = Selector.GetHandle ("setIndexOnPage:");
		[CompilerGenerated]
		const string selPopupIndex = "popupIndex";
		static readonly IntPtr selPopupIndexHandle = Selector.GetHandle ("popupIndex");
		[CompilerGenerated]
		const string selSetPopupIndex_ = "setPopupIndex:";
		static readonly IntPtr selSetPopupIndex_Handle = Selector.GetHandle ("setPopupIndex:");
		[CompilerGenerated]
		const string selSupportedTypes = "supportedTypes";
		static readonly IntPtr selSupportedTypesHandle = Selector.GetHandle ("supportedTypes");
		[CompilerGenerated]
		const string selInitWithType_ = "initWithType:";
		static readonly IntPtr selInitWithType_Handle = Selector.GetHandle ("initWithType:");
		[CompilerGenerated]
		const string selInitWithAnnotationDictionaryInAnnotsArray_ = "initWithAnnotationDictionary:inAnnotsArray:";
		static readonly IntPtr selInitWithAnnotationDictionaryInAnnotsArray_Handle = Selector.GetHandle ("initWithAnnotationDictionary:inAnnotsArray:");
		[CompilerGenerated]
		const string selInitWithAnnotationDictionaryInAnnotsArrayType_ = "initWithAnnotationDictionary:inAnnotsArray:type:";
		static readonly IntPtr selInitWithAnnotationDictionaryInAnnotsArrayType_Handle = Selector.GetHandle ("initWithAnnotationDictionary:inAnnotsArray:type:");
		[CompilerGenerated]
		const string selHitTest_ = "hitTest:";
		static readonly IntPtr selHitTest_Handle = Selector.GetHandle ("hitTest:");
		[CompilerGenerated]
		const string selRectForPageRect_ = "rectForPageRect:";
		static readonly IntPtr selRectForPageRect_Handle = Selector.GetHandle ("rectForPageRect:");
		[CompilerGenerated]
		const string selCompareByPositionOnPage_ = "compareByPositionOnPage:";
		static readonly IntPtr selCompareByPositionOnPage_Handle = Selector.GetHandle ("compareByPositionOnPage:");
		[CompilerGenerated]
		const string selRectFromPDFArray_ = "rectFromPDFArray:";
		static readonly IntPtr selRectFromPDFArray_Handle = Selector.GetHandle ("rectFromPDFArray:");
		[CompilerGenerated]
		const string selRectsFromQuadPointsInArray_ = "rectsFromQuadPointsInArray:";
		static readonly IntPtr selRectsFromQuadPointsInArray_Handle = Selector.GetHandle ("rectsFromQuadPointsInArray:");
		[CompilerGenerated]
		const string selDrawInContext_ = "drawInContext:";
		static readonly IntPtr selDrawInContext_Handle = Selector.GetHandle ("drawInContext:");
		[CompilerGenerated]
		const string selDrawInContextWithOptions_ = "drawInContext:withOptions:";
		static readonly IntPtr selDrawInContextWithOptions_Handle = Selector.GetHandle ("drawInContext:withOptions:");
		[CompilerGenerated]
		const string selImageWithSizeWithOptions_ = "imageWithSize:withOptions:";
		static readonly IntPtr selImageWithSizeWithOptions_Handle = Selector.GetHandle ("imageWithSize:withOptions:");
		[CompilerGenerated]
		const string selPrepareBorderStyleInContext_ = "prepareBorderStyleInContext:";
		static readonly IntPtr selPrepareBorderStyleInContext_Handle = Selector.GetHandle ("prepareBorderStyleInContext:");
		[CompilerGenerated]
		const string selIsEqualToAnnotation_ = "isEqualToAnnotation:";
		static readonly IntPtr selIsEqualToAnnotation_Handle = Selector.GetHandle ("isEqualToAnnotation:");
		[CompilerGenerated]
		const string selPdfRectString = "pdfRectString";
		static readonly IntPtr selPdfRectStringHandle = Selector.GetHandle ("pdfRectString");
		[CompilerGenerated]
		const string selPdfColorString = "pdfColorString";
		static readonly IntPtr selPdfColorStringHandle = Selector.GetHandle ("pdfColorString");
		[CompilerGenerated]
		const string selPdfFillColorString = "pdfFillColorString";
		static readonly IntPtr selPdfFillColorStringHandle = Selector.GetHandle ("pdfFillColorString");
		[CompilerGenerated]
		const string selPdfFillColorStringWithKeyAndColor_ = "pdfFillColorStringWithKey:andColor:";
		static readonly IntPtr selPdfFillColorStringWithKeyAndColor_Handle = Selector.GetHandle ("pdfFillColorStringWithKey:andColor:");
		[CompilerGenerated]
		const string selPdfColorWithAlphaString = "pdfColorWithAlphaString";
		static readonly IntPtr selPdfColorWithAlphaStringHandle = Selector.GetHandle ("pdfColorWithAlphaString");
		[CompilerGenerated]
		const string selPdfBorderString = "pdfBorderString";
		static readonly IntPtr selPdfBorderStringHandle = Selector.GetHandle ("pdfBorderString");
		[CompilerGenerated]
		const string selPdfQuadPointsString = "pdfQuadPointsString";
		static readonly IntPtr selPdfQuadPointsStringHandle = Selector.GetHandle ("pdfQuadPointsString");
		[CompilerGenerated]
		const string selAppendEscapedContentsWithStreamOptions_ = "appendEscapedContents:withStreamOptions:";
		static readonly IntPtr selAppendEscapedContentsWithStreamOptions_Handle = Selector.GetHandle ("appendEscapedContents:withStreamOptions:");
		[CompilerGenerated]
		const string selStringsFromRectsArray_ = "stringsFromRectsArray:";
		static readonly IntPtr selStringsFromRectsArray_Handle = Selector.GetHandle ("stringsFromRectsArray:");
		[CompilerGenerated]
		const string selRectsFromStringsArray_ = "rectsFromStringsArray:";
		static readonly IntPtr selRectsFromStringsArray_Handle = Selector.GetHandle ("rectsFromStringsArray:");
		[CompilerGenerated]
		const string selPdfDataRepresentation = "pdfDataRepresentation";
		static readonly IntPtr selPdfDataRepresentationHandle = Selector.GetHandle ("pdfDataRepresentation");
		[CompilerGenerated]
		const string selCopyAndDeleteOriginalIfNeeded = "copyAndDeleteOriginalIfNeeded";
		static readonly IntPtr selCopyAndDeleteOriginalIfNeededHandle = Selector.GetHandle ("copyAndDeleteOriginalIfNeeded");
		[CompilerGenerated]
		const string selParse = "parse";
		static readonly IntPtr selParseHandle = Selector.GetHandle ("parse");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFAnnotation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFAnnotation () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFAnnotation (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFAnnotation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFAnnotation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("supportedTypes")]
		[CompilerGenerated]
		public static global::System.String[] SupportedTypes ()
		{
			return NSArray.StringArrayFromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selSupportedTypesHandle));
		}
		
		[Export ("initWithType:")]
		[CompilerGenerated]
		public PSPDFAnnotation (PSPDFAnnotationType annotationType)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selInitWithType_Handle, (UInt32)annotationType);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selInitWithType_Handle, (UInt32)annotationType);
			}
		}
		
		[Export ("initWithAnnotationDictionary:inAnnotsArray:")]
		[CompilerGenerated]
		internal PSPDFAnnotation (global::System.IntPtr annotDict, global::System.IntPtr annotsArray)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithAnnotationDictionaryInAnnotsArray_Handle, annotDict, annotsArray);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithAnnotationDictionaryInAnnotsArray_Handle, annotDict, annotsArray);
			}
		}
		
		[Export ("initWithAnnotationDictionary:inAnnotsArray:type:")]
		[CompilerGenerated]
		internal PSPDFAnnotation (global::System.IntPtr annotDict, global::System.IntPtr annotsArray, PSPDFAnnotationType annotationType)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt32 (this.Handle, selInitWithAnnotationDictionaryInAnnotsArrayType_Handle, annotDict, annotsArray, (UInt32)annotationType);
			} else {
				Handle = ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt32 (this.SuperHandle, selInitWithAnnotationDictionaryInAnnotsArrayType_Handle, annotDict, annotsArray, (UInt32)annotationType);
			}
		}
		
		[Export ("hitTest:")]
		[CompilerGenerated]
		public virtual bool HitTest (global::System.Drawing.PointF point)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_PointF (this.Handle, selHitTest_Handle, point);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_PointF (this.SuperHandle, selHitTest_Handle, point);
			}
		}
		
		[Export ("rectForPageRect:")]
		[CompilerGenerated]
		public virtual global::System.Drawing.RectangleF RectForPageRect (global::System.Drawing.RectangleF pageRect)
		{
			global::System.Drawing.RectangleF ret;
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret_RectangleF (out ret, this.Handle, selRectForPageRect_Handle, pageRect);
			} else {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret_RectangleF (out ret, this.SuperHandle, selRectForPageRect_Handle, pageRect);
			}
			return ret;
		}
		
		[Export ("compareByPositionOnPage:")]
		[CompilerGenerated]
		public virtual NSComparisonResult CompareByPositionOnPage (PSPDFAnnotation otherAnnotation)
		{
			if (otherAnnotation == null)
				throw new ArgumentNullException ("otherAnnotation");
			if (IsDirectBinding) {
				return (NSComparisonResult) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend_IntPtr (this.Handle, selCompareByPositionOnPage_Handle, otherAnnotation.Handle);
			} else {
				return (NSComparisonResult) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, selCompareByPositionOnPage_Handle, otherAnnotation.Handle);
			}
		}
		
		[Export ("rectFromPDFArray:")]
		[CompilerGenerated]
		internal virtual global::System.Drawing.RectangleF RectFromPDFArray_ (global::System.IntPtr array)
		{
			global::System.Drawing.RectangleF ret;
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret_IntPtr (out ret, this.Handle, selRectFromPDFArray_Handle, array);
			} else {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret_IntPtr (out ret, this.SuperHandle, selRectFromPDFArray_Handle, array);
			}
			return ret;
		}
		
		[Export ("rectsFromQuadPointsInArray:")]
		[CompilerGenerated]
		internal virtual NSArray RectsFromQuadPointsInArray_ (global::System.IntPtr quadPointsArray)
		{
			if (IsDirectBinding) {
				return (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selRectsFromQuadPointsInArray_Handle, quadPointsArray));
			} else {
				return (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selRectsFromQuadPointsInArray_Handle, quadPointsArray));
			}
		}
		
		[Export ("drawInContext:")]
		[CompilerGenerated]
		public virtual void DrawInContext (CGContext context)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selDrawInContext_Handle, context.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selDrawInContext_Handle, context.Handle);
			}
		}
		
		[Export ("drawInContext:withOptions:")]
		[CompilerGenerated]
		public virtual void DrawInContext (CGContext context, NSDictionary options)
		{
			if (options == null)
				throw new ArgumentNullException ("options");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selDrawInContextWithOptions_Handle, context.Handle, options.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selDrawInContextWithOptions_Handle, context.Handle, options.Handle);
			}
		}
		
		[Export ("imageWithSize:withOptions:")]
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIImage ImageWithSize (global::System.Drawing.SizeF size, NSDictionary options)
		{
			if (options == null)
				throw new ArgumentNullException ("options");
			if (IsDirectBinding) {
				return (global::MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_SizeF_IntPtr (this.Handle, selImageWithSizeWithOptions_Handle, size, options.Handle));
			} else {
				return (global::MonoTouch.UIKit.UIImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_SizeF_IntPtr (this.SuperHandle, selImageWithSizeWithOptions_Handle, size, options.Handle));
			}
		}
		
		[Export ("prepareBorderStyleInContext:")]
		[CompilerGenerated]
		public virtual void PrepareBorderStyleInContext (CGContext context)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selPrepareBorderStyleInContext_Handle, context.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selPrepareBorderStyleInContext_Handle, context.Handle);
			}
		}
		
		[Export ("isEqualToAnnotation:")]
		[CompilerGenerated]
		public virtual bool IsEqualToAnnotation (PSPDFAnnotation otherAnnotation)
		{
			if (otherAnnotation == null)
				throw new ArgumentNullException ("otherAnnotation");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsEqualToAnnotation_Handle, otherAnnotation.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selIsEqualToAnnotation_Handle, otherAnnotation.Handle);
			}
		}
		
		[CompilerGenerated]
		public string PdfRectString ()
		{
			return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPdfRectStringHandle));
		}
		
		[CompilerGenerated]
		public string PdfColorString ()
		{
			return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPdfColorStringHandle));
		}
		
		[CompilerGenerated]
		public string PdfFillColorString ()
		{
			return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPdfFillColorStringHandle));
		}
		
		[CompilerGenerated]
		public string PdfFillColorStringWithKeyAndColor ()
		{
			return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPdfFillColorStringWithKeyAndColor_Handle));
		}
		
		[CompilerGenerated]
		public string PdfColorWithAlphaString ()
		{
			return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPdfColorWithAlphaStringHandle));
		}
		
		[CompilerGenerated]
		public string PdfBorderString ()
		{
			return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPdfBorderStringHandle));
		}
		
		[CompilerGenerated]
		public string PdfQuadPointsString ()
		{
			return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPdfQuadPointsStringHandle));
		}
		
		[CompilerGenerated]
		public void AppendEscapedContents (NSMutableData pdfData, NSDictionary streamOptions)
		{
			if (pdfData == null)
				throw new ArgumentNullException ("pdfData");
			if (streamOptions == null)
				throw new ArgumentNullException ("streamOptions");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selAppendEscapedContentsWithStreamOptions_Handle, pdfData.Handle, streamOptions.Handle);
		}
		
		[CompilerGenerated]
		public static global::System.String[] StringsFromRectsArray (NSObject[] rects)
		{
			if (rects == null)
				throw new ArgumentNullException ("rects");
			var nsa_rects = NSArray.FromNSObjects (rects);
			
			global::System.String[] ret;
			ret = NSArray.StringArrayFromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selStringsFromRectsArray_Handle, nsa_rects.Handle));
			nsa_rects.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public static NSObject[] RectsFromStringsArray (global::System.String[] rectStrings)
		{
			if (rectStrings == null)
				throw new ArgumentNullException ("rectStrings");
			var nsa_rectStrings = NSArray.FromStrings (rectStrings);
			
			NSObject[] ret;
			ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selRectsFromStringsArray_Handle, nsa_rectStrings.Handle));
			nsa_rectStrings.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public NSData PdfDataRepresentation ()
		{
			return (NSData) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPdfDataRepresentationHandle));
		}
		
		[CompilerGenerated]
		public NSObject CopyAndDeleteOriginalIfNeeded ()
		{
			return (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCopyAndDeleteOriginalIfNeededHandle));
		}
		
		[Export ("parse")]
		[CompilerGenerated]
		public virtual void Parse ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selParseHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selParseHandle);
			}
		}
		
		[CompilerGenerated]
		public static bool IsWriteable {
			[Export ("isWriteable")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsWriteableHandle);
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsMovable {
			[Export ("isMovable")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsMovableHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsMovableHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsResizable {
			[Export ("isResizable")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsResizableHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsResizableHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFAnnotationType AnnotationType {
			[Export ("type", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFAnnotationType) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selTypeHandle);
				} else {
					return (PSPDFAnnotationType) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selTypeHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool Overlay {
			[Export ("isOverlay", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsOverlayHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsOverlayHandle);
				}
			}
			
			[Export ("setOverlay:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetOverlay_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetOverlay_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Editable {
			[Export ("isEditable", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsEditableHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsEditableHandle);
				}
			}
			
			[Export ("setEditable:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetEditable_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetEditable_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string TypeString {
			[Export ("typeString", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTypeStringHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTypeStringHandle));
				}
			}
			
			[Export ("setTypeString:", ArgumentSemantic.Copy)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTypeString_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTypeString_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual float Alpha {
			[Export ("alpha", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selAlphaHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selAlphaHandle);
				}
			}
			
			[Export ("setAlpha:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetAlpha_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetAlpha_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Color_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor Color {
			[Export ("color")]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selColorHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selColorHandle));
				}
				MarkDirty ();
				__mt_Color_var = ret;
				return ret;
			}
			
			[Export ("setColor:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetColor_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetColor_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_Color_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_colorWithAlpha_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor colorWithAlpha {
			[Export ("colorWithAlpha")]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selColorWithAlphaHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selColorWithAlphaHandle));
				}
				MarkDirty ();
				__mt_colorWithAlpha_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_FillColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor FillColor {
			[Export ("fillColor")]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFillColorHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFillColorHandle));
				}
				MarkDirty ();
				__mt_FillColor_var = ret;
				return ret;
			}
			
			[Export ("setFillColor:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFillColor_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFillColor_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_FillColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_FillColorWithAlpha_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor FillColorWithAlpha {
			[Export ("fillColorWithAlpha")]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFillColorWithAlphaHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFillColorWithAlphaHandle));
				}
				MarkDirty ();
				__mt_FillColorWithAlpha_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Contents {
			[Export ("contents", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selContentsHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selContentsHandle));
				}
			}
			
			[Export ("setContents:", ArgumentSemantic.Copy)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetContents_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetContents_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string Name {
			[Export ("name", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selNameHandle));
				}
			}
			
			[Export ("setName:", ArgumentSemantic.Copy)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetName_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetName_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_LastModified_var;
		[CompilerGenerated]
		public virtual NSDate LastModified {
			[Export ("lastModified")]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret = (NSDate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLastModifiedHandle));
				} else {
					ret = (NSDate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLastModifiedHandle));
				}
				MarkDirty ();
				__mt_LastModified_var = ret;
				return ret;
			}
			
			[Export ("setLastModified:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLastModified_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLastModified_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_LastModified_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_CreationDate_var;
		[CompilerGenerated]
		public virtual NSDate CreationDate {
			[Export ("creationDate")]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret = (NSDate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCreationDateHandle));
				} else {
					ret = (NSDate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCreationDateHandle));
				}
				MarkDirty ();
				__mt_CreationDate_var = ret;
				return ret;
			}
			
			[Export ("setCreationDate:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCreationDate_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCreationDate_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_CreationDate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual float LineWidth {
			[Export ("lineWidth", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selLineWidthHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selLineWidthHandle);
				}
			}
			
			[Export ("setLineWidth:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetLineWidth_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetLineWidth_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFAnnotationBorderStyle BorderStyle {
			[Export ("borderStyle", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFAnnotationBorderStyle) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selBorderStyleHandle);
				} else {
					return (PSPDFAnnotationBorderStyle) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selBorderStyleHandle);
				}
			}
			
			[Export ("setBorderStyle:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetBorderStyle_Handle, (UInt32)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetBorderStyle_Handle, (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_DashArray_var;
		[CompilerGenerated]
		public virtual NSArray DashArray {
			[Export ("dashArray", ArgumentSemantic.Copy)]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDashArrayHandle));
				} else {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDashArrayHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DashArray_var = ret;
				return ret;
			}
			
			[Export ("setDashArray:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDashArray_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDashArray_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_DashArray_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool Deleted {
			[Export ("isDeleted", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDeletedHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsDeletedHandle);
				}
			}
			
			[Export ("setDeleted:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDeleted_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetDeleted_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Drawing.RectangleF BoundingBox {
			[Export ("boundingBox", ArgumentSemantic.Assign)]
			get {
				global::System.Drawing.RectangleF ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret (out ret, this.Handle, selBoundingBoxHandle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selBoundingBoxHandle);
				}
				return ret;
			}
			
			[Export ("setBoundingBox:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_RectangleF (this.Handle, selSetBoundingBox_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_RectangleF (this.SuperHandle, selSetBoundingBox_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 Rotation {
			[Export ("rotation", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selRotationHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selRotationHandle);
				}
			}
			
			[Export ("setRotation:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetRotation_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetRotation_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Rects_var;
		[CompilerGenerated]
		public virtual NSObject[] Rects {
			[Export ("rects", ArgumentSemantic.Copy)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRectsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRectsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Rects_var = ret;
				return ret;
			}
			
			[Export ("setRects:", ArgumentSemantic.Copy)]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRects_Handle, nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRects_Handle, nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_Rects_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Points_var;
		[CompilerGenerated]
		public virtual NSObject[] Points {
			[Export ("points", ArgumentSemantic.Copy)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPointsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPointsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Points_var = ret;
				return ret;
			}
			
			[Export ("setPoints:", ArgumentSemantic.Copy)]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPoints_Handle, nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPoints_Handle, nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_Points_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string User {
			[Export ("user", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUserHandle));
				}
			}
			
			[Export ("setUser:", ArgumentSemantic.Copy)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUser_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUser_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 Page {
			[Export ("page", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPageHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selPageHandle);
				}
			}
			
			[Export ("setPage:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetPage_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetPage_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 AbsolutePage {
			[Export ("absolutePage", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selAbsolutePageHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selAbsolutePageHandle);
				}
			}
			
			[Export ("setAbsolutePage:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetAbsolutePage_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetAbsolutePage_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Dirty {
			[Export ("isDirty", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDirtyHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsDirtyHandle);
				}
			}
			
			[Export ("setDirty:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDirty_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetDirty_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_DocumentProvider_var;
		[CompilerGenerated]
		public virtual PSPDFDocumentProvider DocumentProvider {
			[Export ("documentProvider")]
			get {
				PSPDFDocumentProvider ret;
				if (IsDirectBinding) {
					ret = (PSPDFDocumentProvider) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocumentProviderHandle));
				} else {
					ret = (PSPDFDocumentProvider) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocumentProviderHandle));
				}
				MarkDirty ();
				__mt_DocumentProvider_var = ret;
				return ret;
			}
			
			[Export ("setDocumentProvider:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDocumentProvider_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDocumentProvider_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_DocumentProvider_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Document_var;
		[CompilerGenerated]
		public virtual PSPDFDocument Document {
			[Export ("document", ArgumentSemantic.Assign)]
			get {
				PSPDFDocument ret;
				if (IsDirectBinding) {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocumentHandle));
				} else {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocumentHandle));
				}
				MarkDirty ();
				__mt_Document_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual int PageRotation {
			[Export ("pageRotation", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selPageRotationHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selPageRotationHandle);
				}
			}
			
			[Export ("setPageRotation:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetPageRotation_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetPageRotation_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool HasAppearanceStream {
			[Export ("hasAppearanceStream", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasAppearanceStreamHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selHasAppearanceStreamHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_UserInfo_var;
		[CompilerGenerated]
		public virtual NSDictionary UserInfo {
			[Export ("userInfo", ArgumentSemantic.Copy)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserInfoHandle));
				} else {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUserInfoHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_UserInfo_var = ret;
				return ret;
			}
			
			[Export ("setUserInfo:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUserInfo_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUserInfo_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_UserInfo_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string InfoDescription {
			[Export ("infoDescription")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selInfoDescriptionHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selInfoDescriptionHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int IndexOnPage {
			[Export ("indexOnPage", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selIndexOnPageHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selIndexOnPageHandle);
				}
			}
			
			[Export ("setIndexOnPage:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetIndexOnPage_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetIndexOnPage_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int PopupIndex {
			[Export ("popupIndex", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selPopupIndexHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selPopupIndexHandle);
				}
			}
			
			[Export ("setPopupIndex:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetPopupIndex_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetPopupIndex_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		static readonly IntPtr __Internal_libraryHandle = Dlfcn.dlopen (null, 0);
		[CompilerGenerated]
		static NSString _PSPDFAnnotationDrawFlattened;
		public static NSString PSPDFAnnotationDrawFlattened {
			get {
				if (_PSPDFAnnotationDrawFlattened == null)
					_PSPDFAnnotationDrawFlattened = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFAnnotationDrawFlattened");
				return _PSPDFAnnotationDrawFlattened;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFAnnotationDrawCentered;
		public static NSString PSPDFAnnotationDrawCentered {
			get {
				if (_PSPDFAnnotationDrawCentered == null)
					_PSPDFAnnotationDrawCentered = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFAnnotationDrawCentered");
				return _PSPDFAnnotationDrawCentered;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFAnnotationMargin;
		public static NSString PSPDFAnnotationMargin {
			get {
				if (_PSPDFAnnotationMargin == null)
					_PSPDFAnnotationMargin = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFAnnotationMargin");
				return _PSPDFAnnotationMargin;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFAnnotationTypeStringLink;
		public static NSString PSPDFAnnotationTypeStringLink {
			get {
				if (_PSPDFAnnotationTypeStringLink == null)
					_PSPDFAnnotationTypeStringLink = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSPDFAnnotationTypeStringLink");
				return _PSPDFAnnotationTypeStringLink;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFAnnotationTypeStringHighlight;
		public static NSString PSPDFAnnotationTypeStringHighlight {
			get {
				if (_PSPDFAnnotationTypeStringHighlight == null)
					_PSPDFAnnotationTypeStringHighlight = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSPDFAnnotationTypeStringHighlight");
				return _PSPDFAnnotationTypeStringHighlight;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFAnnotationTypeStringUnderline;
		public static NSString PSPDFAnnotationTypeStringUnderline {
			get {
				if (_PSPDFAnnotationTypeStringUnderline == null)
					_PSPDFAnnotationTypeStringUnderline = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSPDFAnnotationTypeStringUnderline");
				return _PSPDFAnnotationTypeStringUnderline;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFAnnotationTypeStringStrikeout;
		public static NSString PSPDFAnnotationTypeStringStrikeout {
			get {
				if (_PSPDFAnnotationTypeStringStrikeout == null)
					_PSPDFAnnotationTypeStringStrikeout = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSPDFAnnotationTypeStringStrikeout");
				return _PSPDFAnnotationTypeStringStrikeout;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFAnnotationTypeStringNote;
		public static NSString PSPDFAnnotationTypeStringNote {
			get {
				if (_PSPDFAnnotationTypeStringNote == null)
					_PSPDFAnnotationTypeStringNote = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSPDFAnnotationTypeStringNote");
				return _PSPDFAnnotationTypeStringNote;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFAnnotationTypeStringFreeText;
		public static NSString PSPDFAnnotationTypeStringFreeText {
			get {
				if (_PSPDFAnnotationTypeStringFreeText == null)
					_PSPDFAnnotationTypeStringFreeText = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSPDFAnnotationTypeStringFreeText");
				return _PSPDFAnnotationTypeStringFreeText;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFAnnotationTypeStringInk;
		public static NSString PSPDFAnnotationTypeStringInk {
			get {
				if (_PSPDFAnnotationTypeStringInk == null)
					_PSPDFAnnotationTypeStringInk = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSPDFAnnotationTypeStringInk");
				return _PSPDFAnnotationTypeStringInk;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFAnnotationTypeStringSquare;
		public static NSString PSPDFAnnotationTypeStringSquare {
			get {
				if (_PSPDFAnnotationTypeStringSquare == null)
					_PSPDFAnnotationTypeStringSquare = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSPDFAnnotationTypeStringSquare");
				return _PSPDFAnnotationTypeStringSquare;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFAnnotationTypeStringCircle;
		public static NSString PSPDFAnnotationTypeStringCircle {
			get {
				if (_PSPDFAnnotationTypeStringCircle == null)
					_PSPDFAnnotationTypeStringCircle = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSPDFAnnotationTypeStringCircle");
				return _PSPDFAnnotationTypeStringCircle;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFAnnotationTypeStringLine;
		public static NSString PSPDFAnnotationTypeStringLine {
			get {
				if (_PSPDFAnnotationTypeStringLine == null)
					_PSPDFAnnotationTypeStringLine = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSPDFAnnotationTypeStringLine");
				return _PSPDFAnnotationTypeStringLine;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFAnnotationTypeStringSignature;
		public static NSString PSPDFAnnotationTypeStringSignature {
			get {
				if (_PSPDFAnnotationTypeStringSignature == null)
					_PSPDFAnnotationTypeStringSignature = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSPDFAnnotationTypeStringSignature");
				return _PSPDFAnnotationTypeStringSignature;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFAnnotationTypeStringStamp;
		public static NSString PSPDFAnnotationTypeStringStamp {
			get {
				if (_PSPDFAnnotationTypeStringStamp == null)
					_PSPDFAnnotationTypeStringStamp = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSPDFAnnotationTypeStringStamp");
				return _PSPDFAnnotationTypeStringStamp;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFAnnotationTypeStringCaret;
		public static NSString PSPDFAnnotationTypeStringCaret {
			get {
				if (_PSPDFAnnotationTypeStringCaret == null)
					_PSPDFAnnotationTypeStringCaret = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSPDFAnnotationTypeStringCaret");
				return _PSPDFAnnotationTypeStringCaret;
			}
		}
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Color_var = null;
				__mt_colorWithAlpha_var = null;
				__mt_FillColor_var = null;
				__mt_FillColorWithAlpha_var = null;
				__mt_LastModified_var = null;
				__mt_CreationDate_var = null;
				__mt_DashArray_var = null;
				__mt_Rects_var = null;
				__mt_Points_var = null;
				__mt_DocumentProvider_var = null;
				__mt_Document_var = null;
				__mt_UserInfo_var = null;
			}
		}
	} /* class PSPDFAnnotation */
}
