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
	[Register("PSPDFDocumentParser", true)]
	public unsafe partial class PSPDFDocumentParser : NSObject {
		[CompilerGenerated]
		const string selDocumentProvider = "documentProvider";
		static readonly IntPtr selDocumentProviderHandle = Selector.GetHandle ("documentProvider");
		[CompilerGenerated]
		const string selEncryptionFilter = "encryptionFilter";
		static readonly IntPtr selEncryptionFilterHandle = Selector.GetHandle ("encryptionFilter");
		[CompilerGenerated]
		const string selPageObjectNumbers = "pageObjectNumbers";
		static readonly IntPtr selPageObjectNumbersHandle = Selector.GetHandle ("pageObjectNumbers");
		[CompilerGenerated]
		const string selNumberForNewObject = "numberForNewObject";
		static readonly IntPtr selNumberForNewObjectHandle = Selector.GetHandle ("numberForNewObject");
		[CompilerGenerated]
		const string selInitWithDocumentProvider_ = "initWithDocumentProvider:";
		static readonly IntPtr selInitWithDocumentProvider_Handle = Selector.GetHandle ("initWithDocumentProvider:");
		[CompilerGenerated]
		const string selParseDocumentWithError_ = "parseDocumentWithError:";
		static readonly IntPtr selParseDocumentWithError_Handle = Selector.GetHandle ("parseDocumentWithError:");
		[CompilerGenerated]
		const string selSaveAnnotationsWithError_ = "saveAnnotations:withError:";
		static readonly IntPtr selSaveAnnotationsWithError_Handle = Selector.GetHandle ("saveAnnotations:withError:");
		[CompilerGenerated]
		const string selGenerateTrailerWithObjectsStartObjectNumber_ = "generateTrailerWithObjects:startObjectNumber:";
		static readonly IntPtr selGenerateTrailerWithObjectsStartObjectNumber_Handle = Selector.GetHandle ("generateTrailerWithObjects:startObjectNumber:");
		[CompilerGenerated]
		const string selIsObjectCompressedForPageIndex_ = "isObjectCompressedForPageIndex:";
		static readonly IntPtr selIsObjectCompressedForPageIndex_Handle = Selector.GetHandle ("isObjectCompressedForPageIndex:");
		[CompilerGenerated]
		const string selObjectNumberForPageIndex_ = "objectNumberForPageIndex:";
		static readonly IntPtr selObjectNumberForPageIndex_Handle = Selector.GetHandle ("objectNumberForPageIndex:");
		[CompilerGenerated]
		const string selObjectNumberForAnnotationIndexOnPageIndex_ = "objectNumberForAnnotationIndex:onPageIndex:";
		static readonly IntPtr selObjectNumberForAnnotationIndexOnPageIndex_Handle = Selector.GetHandle ("objectNumberForAnnotationIndex:onPageIndex:");
		[CompilerGenerated]
		const string selObjectDictionaryForPageIndex_ = "objectDictionaryForPageIndex:";
		static readonly IntPtr selObjectDictionaryForPageIndex_Handle = Selector.GetHandle ("objectDictionaryForPageIndex:");
		[CompilerGenerated]
		const string selObjectDictionaryForNumber_ = "objectDictionaryForNumber:";
		static readonly IntPtr selObjectDictionaryForNumber_Handle = Selector.GetHandle ("objectDictionaryForNumber:");
		[CompilerGenerated]
		const string selExtractAppearanceStreamFromDataWithRectFirstFreeObjectNumber_ = "extractAppearanceStreamFromData:withRect:firstFreeObjectNumber:";
		static readonly IntPtr selExtractAppearanceStreamFromDataWithRectFirstFreeObjectNumber_Handle = Selector.GetHandle ("extractAppearanceStreamFromData:withRect:firstFreeObjectNumber:");
		[CompilerGenerated]
		const string selPrintAllObjects = "printAllObjects";
		static readonly IntPtr selPrintAllObjectsHandle = Selector.GetHandle ("printAllObjects");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFDocumentParser");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFDocumentParser () : base (NSObjectFlag.Empty)
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
		public PSPDFDocumentParser (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFDocumentParser (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFDocumentParser (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDocumentProvider:")]
		[CompilerGenerated]
		public PSPDFDocumentParser (PSPDFDocumentProvider documentProvider)
			: base (NSObjectFlag.Empty)
		{
			if (documentProvider == null)
				throw new ArgumentNullException ("documentProvider");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithDocumentProvider_Handle, documentProvider.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithDocumentProvider_Handle, documentProvider.Handle);
			}
		}
		
		[Export ("parseDocumentWithError:")]
		[CompilerGenerated]
		public virtual bool ParseDocumentWithError (out NSError error)
		{
			IntPtr errorPtr = Marshal.AllocHGlobal(4);
			Marshal.WriteInt32(errorPtr, 0);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selParseDocumentWithError_Handle, errorPtr);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selParseDocumentWithError_Handle, errorPtr);
			}
			
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? (NSError)Runtime.GetNSObject(errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return ret;
		}
		
		[Export ("saveAnnotations:withError:")]
		[CompilerGenerated]
		public virtual bool SaveAnnotations (NSDictionary annotations, out NSError error)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			IntPtr errorPtr = Marshal.AllocHGlobal(4);
			Marshal.WriteInt32(errorPtr, 0);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, selSaveAnnotationsWithError_Handle, annotations.Handle, errorPtr);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSaveAnnotationsWithError_Handle, annotations.Handle, errorPtr);
			}
			
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? (NSError)Runtime.GetNSObject(errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return ret;
		}
		
		[Export ("generateTrailerWithObjects:startObjectNumber:")]
		[CompilerGenerated]
		public virtual NSMutableData GenerateTrailerWithObjects (NSDictionary updatedObjects, int numberForNewObject)
		{
			if (updatedObjects == null)
				throw new ArgumentNullException ("updatedObjects");
			if (IsDirectBinding) {
				return (NSMutableData) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_int (this.Handle, selGenerateTrailerWithObjectsStartObjectNumber_Handle, updatedObjects.Handle, numberForNewObject));
			} else {
				return (NSMutableData) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_int (this.SuperHandle, selGenerateTrailerWithObjectsStartObjectNumber_Handle, updatedObjects.Handle, numberForNewObject));
			}
		}
		
		[Export ("isObjectCompressedForPageIndex:")]
		[CompilerGenerated]
		public virtual bool IsObjectCompressedForPageIndex (global::System.UInt32 pageIndex)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_UInt32 (this.Handle, selIsObjectCompressedForPageIndex_Handle, pageIndex);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_UInt32 (this.SuperHandle, selIsObjectCompressedForPageIndex_Handle, pageIndex);
			}
		}
		
		[Export ("objectNumberForPageIndex:")]
		[CompilerGenerated]
		public virtual int ObjectNumberForPageIndex (global::System.UInt32 pageIndex)
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.int_objc_msgSend_UInt32 (this.Handle, selObjectNumberForPageIndex_Handle, pageIndex);
			} else {
				return ApiDefinition.Messaging.int_objc_msgSendSuper_UInt32 (this.SuperHandle, selObjectNumberForPageIndex_Handle, pageIndex);
			}
		}
		
		[Export ("objectNumberForAnnotationIndex:onPageIndex:")]
		[CompilerGenerated]
		public virtual global::System.UInt32 ObjectNumberForAnnotationIndex (global::System.UInt32 annotationIndex, global::System.UInt32 pageIndex)
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.UInt32_objc_msgSend_UInt32_UInt32 (this.Handle, selObjectNumberForAnnotationIndexOnPageIndex_Handle, annotationIndex, pageIndex);
			} else {
				return ApiDefinition.Messaging.UInt32_objc_msgSendSuper_UInt32_UInt32 (this.SuperHandle, selObjectNumberForAnnotationIndexOnPageIndex_Handle, annotationIndex, pageIndex);
			}
		}
		
		[Export ("objectDictionaryForPageIndex:")]
		[CompilerGenerated]
		public virtual string ObjectDictionaryForPageIndex (global::System.UInt32 pageIndex)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selObjectDictionaryForPageIndex_Handle, pageIndex));
			} else {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selObjectDictionaryForPageIndex_Handle, pageIndex));
			}
		}
		
		[Export ("objectDictionaryForNumber:")]
		[CompilerGenerated]
		public virtual string ObjectDictionaryForNumber (global::System.UInt32 number)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selObjectDictionaryForNumber_Handle, number));
			} else {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selObjectDictionaryForNumber_Handle, number));
			}
		}
		
		[Export ("extractAppearanceStreamFromData:withRect:firstFreeObjectNumber:")]
		[CompilerGenerated]
		public static NSData ExtractAppearanceStreamFromData (NSData pdfData, global::System.Drawing.RectangleF rect, global::System.UInt32 firstFreeObjectNumber)
		{
			if (pdfData == null)
				throw new ArgumentNullException ("pdfData");
			return (NSData) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_RectangleF_UInt32 (class_ptr, selExtractAppearanceStreamFromDataWithRectFirstFreeObjectNumber_Handle, pdfData.Handle, rect, firstFreeObjectNumber));
		}
		
		[Export ("printAllObjects")]
		[CompilerGenerated]
		public virtual void PrintAllObjects ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPrintAllObjectsHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selPrintAllObjectsHandle);
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
			
		}
		
		[CompilerGenerated]
		public virtual string EncryptionFilter {
			[Export ("encryptionFilter", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selEncryptionFilterHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selEncryptionFilterHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PageObjectNumbers_var;
		[CompilerGenerated]
		public virtual PSPDFXRefEntry[] PageObjectNumbers {
			[Export ("pageObjectNumbers", ArgumentSemantic.Copy)]
			get {
				PSPDFXRefEntry[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFXRefEntry>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPageObjectNumbersHandle));
				} else {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFXRefEntry>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPageObjectNumbersHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PageObjectNumbers_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual int NumberForNewObject {
			[Export ("numberForNewObject")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selNumberForNewObjectHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selNumberForNewObjectHandle);
				}
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_DocumentProvider_var = null;
				__mt_PageObjectNumbers_var = null;
			}
		}
	} /* class PSPDFDocumentParser */
}
