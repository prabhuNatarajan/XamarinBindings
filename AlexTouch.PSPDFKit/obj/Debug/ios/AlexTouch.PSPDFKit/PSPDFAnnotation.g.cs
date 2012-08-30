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
using OpenTK;

namespace AlexTouch.PSPDFKit {
	[Register("PSPDFAnnotation", true)]
	public unsafe partial class PSPDFAnnotation : NSObject {
		static readonly IntPtr selSupportedTypes = Selector.GetHandle ("supportedTypes");
		static readonly IntPtr selType = Selector.GetHandle ("type");
		static readonly IntPtr selTypeString = Selector.GetHandle ("typeString");
		static readonly IntPtr selSetTypeString_ = Selector.GetHandle ("setTypeString:");
		static readonly IntPtr selAlpha = Selector.GetHandle ("alpha");
		static readonly IntPtr selSetAlpha_ = Selector.GetHandle ("setAlpha:");
		static readonly IntPtr selColor = Selector.GetHandle ("color");
		static readonly IntPtr selSetColor_ = Selector.GetHandle ("setColor:");
		static readonly IntPtr selColorWithAlpha = Selector.GetHandle ("colorWithAlpha");
		static readonly IntPtr selContents = Selector.GetHandle ("contents");
		static readonly IntPtr selSetContents_ = Selector.GetHandle ("setContents:");
		static readonly IntPtr selLineWidth = Selector.GetHandle ("lineWidth");
		static readonly IntPtr selSetLineWidth_ = Selector.GetHandle ("setLineWidth:");
		static readonly IntPtr selIndexOnPage = Selector.GetHandle ("indexOnPage");
		static readonly IntPtr selSetIndexOnPage_ = Selector.GetHandle ("setIndexOnPage:");
		static readonly IntPtr selPopupIndex = Selector.GetHandle ("popupIndex");
		static readonly IntPtr selSetPopupIndex_ = Selector.GetHandle ("setPopupIndex:");
		static readonly IntPtr selIsDeleted = Selector.GetHandle ("isDeleted");
		static readonly IntPtr selSetDeleted_ = Selector.GetHandle ("setDeleted:");
		static readonly IntPtr selBoundingBox = Selector.GetHandle ("boundingBox");
		static readonly IntPtr selSetBoundingBox_ = Selector.GetHandle ("setBoundingBox:");
		static readonly IntPtr selPage = Selector.GetHandle ("page");
		static readonly IntPtr selSetPage_ = Selector.GetHandle ("setPage:");
		static readonly IntPtr selIsDirty = Selector.GetHandle ("isDirty");
		static readonly IntPtr selSetDirty_ = Selector.GetHandle ("setDirty:");
		static readonly IntPtr selDocument = Selector.GetHandle ("document");
		static readonly IntPtr selSetDocument_ = Selector.GetHandle ("setDocument:");
		static readonly IntPtr selPdfRectString = Selector.GetHandle ("pdfRectString");
		static readonly IntPtr selPdfColorString = Selector.GetHandle ("pdfColorString");
		static readonly IntPtr selPdfColorWithAlphaString = Selector.GetHandle ("pdfColorWithAlphaString");
		static readonly IntPtr selInitWithType_ = Selector.GetHandle ("initWithType:");
		static readonly IntPtr selInitWithAnnotationDictionaryInAnnotsArray_ = Selector.GetHandle ("initWithAnnotationDictionary:inAnnotsArray:");
		static readonly IntPtr selInitWithAnnotationDictionaryInAnnotsArrayType_ = Selector.GetHandle ("initWithAnnotationDictionary:inAnnotsArray:type:");
		static readonly IntPtr selCopyAndDeleteOriginalIfNeeded = Selector.GetHandle ("copyAndDeleteOriginalIfNeeded");
		static readonly IntPtr selHitTest_ = Selector.GetHandle ("hitTest:");
		static readonly IntPtr selRectForPageRect_ = Selector.GetHandle ("rectForPageRect:");
		static readonly IntPtr selCompareByPositionOnPage_ = Selector.GetHandle ("compareByPositionOnPage:");
		static readonly IntPtr selRectFromPDFArray_ = Selector.GetHandle ("rectFromPDFArray:");
		static readonly IntPtr selRectsFromQuadPointsInArray_ = Selector.GetHandle ("rectsFromQuadPointsInArray:");
		static readonly IntPtr selDrawInContext_ = Selector.GetHandle ("drawInContext:");
		static readonly IntPtr selPdfDataRepresentation = Selector.GetHandle ("pdfDataRepresentation");
		static readonly IntPtr selAppendEscapedContents_ = Selector.GetHandle ("appendEscapedContents:");
		static readonly IntPtr selStringsFromRectsArray_ = Selector.GetHandle ("stringsFromRectsArray:");
		static readonly IntPtr selRectsFromStringsArray_ = Selector.GetHandle ("rectsFromStringsArray:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFAnnotation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFAnnotation () : base (NSObjectFlag.Empty)
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
		public PSPDFAnnotation (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFAnnotation (IntPtr handle) : base (handle) {}

		[Export ("initWithType:")]
		[CompilerGenerated]
		public PSPDFAnnotation (PSPDFAnnotationType annotationType) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int (this.Handle, selInitWithType_, (int)annotationType);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, selInitWithType_, (int)annotationType);
			}
		}
		
		[Export ("initWithAnnotationDictionary:inAnnotsArray:")]
		[CompilerGenerated]
		internal PSPDFAnnotation (System.IntPtr annotDict, System.IntPtr annotsArray) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithAnnotationDictionaryInAnnotsArray_, annotDict, annotsArray);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithAnnotationDictionaryInAnnotsArray_, annotDict, annotsArray);
			}
		}
		
		[Export ("initWithAnnotationDictionary:inAnnotsArray:type:")]
		[CompilerGenerated]
		internal PSPDFAnnotation (System.IntPtr annotDict, System.IntPtr annotsArray, PSPDFAnnotationType annotationType) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_int (this.Handle, selInitWithAnnotationDictionaryInAnnotsArrayType_, annotDict, annotsArray, (int)annotationType);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int (this.SuperHandle, selInitWithAnnotationDictionaryInAnnotsArrayType_, annotDict, annotsArray, (int)annotationType);
			}
		}
		
		[Export ("copyAndDeleteOriginalIfNeeded")]
		[CompilerGenerated]
		public virtual PSPDFAnnotation copyAndDeleteOriginalIfNeeded ()
		{
			if (IsDirectBinding) {
				return (PSPDFAnnotation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCopyAndDeleteOriginalIfNeeded));
			} else {
				return (PSPDFAnnotation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCopyAndDeleteOriginalIfNeeded));
			}
		}
		
		[Export ("hitTest:")]
		[CompilerGenerated]
		public virtual bool HitTest (System.Drawing.PointF point)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_PointF (this.Handle, selHitTest_, point);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_PointF (this.SuperHandle, selHitTest_, point);
			}
		}
		
		[Export ("rectForPageRect:")]
		[CompilerGenerated]
		public virtual System.Drawing.RectangleF RectForPageRect (System.Drawing.RectangleF pageRect)
		{
			System.Drawing.RectangleF ret;
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret_RectangleF (out ret, this.Handle, selRectForPageRect_, pageRect);
			} else {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret_RectangleF (out ret, this.SuperHandle, selRectForPageRect_, pageRect);
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
				return (NSComparisonResult) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend_IntPtr (this.Handle, selCompareByPositionOnPage_, otherAnnotation.Handle);
			} else {
				return (NSComparisonResult) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, selCompareByPositionOnPage_, otherAnnotation.Handle);
			}
		}
		
		[Export ("rectFromPDFArray:")]
		[CompilerGenerated]
		internal virtual System.Drawing.RectangleF RectFromPDFArray_ (System.IntPtr array)
		{
			System.Drawing.RectangleF ret;
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret_IntPtr (out ret, this.Handle, selRectFromPDFArray_, array);
			} else {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret_IntPtr (out ret, this.SuperHandle, selRectFromPDFArray_, array);
			}
			return ret;
		}
		
		[Export ("rectsFromQuadPointsInArray:")]
		[CompilerGenerated]
		internal virtual NSArray RectsFromQuadPointsInArray_ (System.IntPtr quadPointsArray)
		{
			if (IsDirectBinding) {
				return (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selRectsFromQuadPointsInArray_, quadPointsArray));
			} else {
				return (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selRectsFromQuadPointsInArray_, quadPointsArray));
			}
		}
		
		[Export ("drawInContext:")]
		[CompilerGenerated]
		public virtual void DrawInContext (CGContext context)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selDrawInContext_, context.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selDrawInContext_, context.Handle);
			}
		}
		
		[Export ("pdfDataRepresentation")]
		[CompilerGenerated]
		public virtual NSData PdfDataRepresentation ()
		{
			if (IsDirectBinding) {
				return (NSData) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPdfDataRepresentation));
			} else {
				return (NSData) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPdfDataRepresentation));
			}
		}
		
		[Export ("appendEscapedContents:")]
		[CompilerGenerated]
		public virtual void AppendEscapedContents (NSMutableData pdfData)
		{
			if (pdfData == null)
				throw new ArgumentNullException ("pdfData");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAppendEscapedContents_, pdfData.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selAppendEscapedContents_, pdfData.Handle);
			}
		}
		
		[Export ("stringsFromRectsArray:")]
		[CompilerGenerated]
		public static System.String[] StringsFromRectsArray (NSArray rects)
		{
			if (rects == null)
				throw new ArgumentNullException ("rects");
			return NSArray.StringArrayFromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selStringsFromRectsArray_, rects.Handle));
		}
		
		[Export ("rectsFromStringsArray:")]
		[CompilerGenerated]
		public static NSArray RectsFromStringsArray (System.String[] rectStrings)
		{
			if (rectStrings == null)
				throw new ArgumentNullException ("rectStrings");
			var nsa_rectStrings = NSArray.FromStrings (rectStrings);
			
			NSArray ret;
			ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selRectsFromStringsArray_, nsa_rectStrings.Handle));
			nsa_rectStrings.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public static System.String[] SupportedTypes {
			[Export ("supportedTypes")]
			get {
				return NSArray.StringArrayFromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selSupportedTypes));
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFAnnotationType AnnotationType {
			[Export ("type", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFAnnotationType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selType);
				} else {
					return (PSPDFAnnotationType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selType);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string TypeString {
			[Export ("typeString", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTypeString));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTypeString));
				}
			}
			
			[Export ("setTypeString:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTypeString_, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTypeString_, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual float Alpha {
			[Export ("alpha", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selAlpha);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selAlpha);
				}
			}
			
			[Export ("setAlpha:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetAlpha_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetAlpha_, value);
				}
			}
		}
		
		object __mt_Color_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIColor Color {
			[Export ("color")]
			get {
				MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selColor));
				} else {
					ret = (MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selColor));
				}
				MarkDirty ();
				__mt_Color_var = ret;
				return ret;
			}
			
			[Export ("setColor:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetColor_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetColor_, value.Handle);
				}
				MarkDirty ();
				__mt_Color_var = value;
			}
		}
		
		object __mt_colorWithAlpha_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIColor colorWithAlpha {
			[Export ("colorWithAlpha")]
			get {
				MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selColorWithAlpha));
				} else {
					ret = (MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selColorWithAlpha));
				}
				MarkDirty ();
				__mt_colorWithAlpha_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Contents {
			[Export ("contents")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selContents));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selContents));
				}
			}
			
			[Export ("setContents:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetContents_, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetContents_, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual float LineWidth {
			[Export ("lineWidth", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selLineWidth);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selLineWidth);
				}
			}
			
			[Export ("setLineWidth:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetLineWidth_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetLineWidth_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int IndexOnPage {
			[Export ("indexOnPage", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selIndexOnPage);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selIndexOnPage);
				}
			}
			
			[Export ("setIndexOnPage:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetIndexOnPage_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetIndexOnPage_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int PopupIndex {
			[Export ("popupIndex", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selPopupIndex);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selPopupIndex);
				}
			}
			
			[Export ("setPopupIndex:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetPopupIndex_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetPopupIndex_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Deleted {
			[Export ("isDeleted", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDeleted);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsDeleted);
				}
			}
			
			[Export ("setDeleted:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDeleted_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetDeleted_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual System.Drawing.RectangleF BoundingBox {
			[Export ("boundingBox", ArgumentSemantic.Assign)]
			get {
				System.Drawing.RectangleF ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret (out ret, this.Handle, selBoundingBox);
				} else {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selBoundingBox);
				}
				return ret;
			}
			
			[Export ("setBoundingBox:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_RectangleF (this.Handle, selSetBoundingBox_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_RectangleF (this.SuperHandle, selSetBoundingBox_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual System.UInt32 Page {
			[Export ("page", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPage);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selPage);
				}
			}
			
			[Export ("setPage:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetPage_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetPage_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Dirty {
			[Export ("isDirty", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDirty);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsDirty);
				}
			}
			
			[Export ("setDirty:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDirty_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetDirty_, value);
				}
			}
		}
		
		object __mt_Document_var;
		[CompilerGenerated]
		public virtual PSPDFDocument Document {
			[Export ("document", ArgumentSemantic.Assign)]
			get {
				PSPDFDocument ret;
				if (IsDirectBinding) {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocument));
				} else {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocument));
				}
				MarkDirty ();
				__mt_Document_var = ret;
				return ret;
			}
			
			[Export ("setDocument:", ArgumentSemantic.Assign)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDocument_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDocument_, value.Handle);
				}
				MarkDirty ();
				__mt_Document_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string PdfRectString {
			[Export ("pdfRectString")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPdfRectString));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPdfRectString));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string PdfColorString {
			[Export ("pdfColorString")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPdfColorString));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPdfColorString));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string pdfColorWithAlphaString {
			[Export ("pdfColorWithAlphaString")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPdfColorWithAlphaString));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPdfColorWithAlphaString));
				}
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_Color_var = null;
			__mt_colorWithAlpha_var = null;
			__mt_Document_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFAnnotation */
}
