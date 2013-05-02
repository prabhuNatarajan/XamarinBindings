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
	[Register("PSPDFProcessor", true)]
	public unsafe partial class PSPDFProcessor : NSObject {
		[CompilerGenerated]
		const string selDefaultProcessor = "defaultProcessor";
		static readonly IntPtr selDefaultProcessorHandle = Selector.GetHandle ("defaultProcessor");
		[CompilerGenerated]
		const string selConversionOperationQueue = "conversionOperationQueue";
		static readonly IntPtr selConversionOperationQueueHandle = Selector.GetHandle ("conversionOperationQueue");
		[CompilerGenerated]
		const string selGeneratePDFFromDocumentPageRangeOutputFileURLOptionsProgressBlockError_ = "generatePDFFromDocument:pageRange:outputFileURL:options:progressBlock:error:";
		static readonly IntPtr selGeneratePDFFromDocumentPageRangeOutputFileURLOptionsProgressBlockError_Handle = Selector.GetHandle ("generatePDFFromDocument:pageRange:outputFileURL:options:progressBlock:error:");
		[CompilerGenerated]
		const string selGeneratePDFFromDocumentPageRangeOptionsProgressBlockError_ = "generatePDFFromDocument:pageRange:options:progressBlock:error:";
		static readonly IntPtr selGeneratePDFFromDocumentPageRangeOptionsProgressBlockError_Handle = Selector.GetHandle ("generatePDFFromDocument:pageRange:options:progressBlock:error:");
		[CompilerGenerated]
		const string selGeneratePDFFromHTMLStringOutputFileURLOptions_ = "generatePDFFromHTMLString:outputFileURL:options:";
		static readonly IntPtr selGeneratePDFFromHTMLStringOutputFileURLOptions_Handle = Selector.GetHandle ("generatePDFFromHTMLString:outputFileURL:options:");
		[CompilerGenerated]
		const string selGeneratePDFFromURLOutputFileURLOptionsCompletionBlock_ = "generatePDFFromURL:outputFileURL:options:completionBlock:";
		static readonly IntPtr selGeneratePDFFromURLOutputFileURLOptionsCompletionBlock_Handle = Selector.GetHandle ("generatePDFFromURL:outputFileURL:options:completionBlock:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFProcessor");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFProcessor () : base (NSObjectFlag.Empty)
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
		public PSPDFProcessor (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFProcessor (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFProcessor (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("generatePDFFromDocument:pageRange:outputFileURL:options:progressBlock:error:")]
		[CompilerGenerated]
		public unsafe virtual bool GeneratePDFFromDocumentToFile (PSPDFDocument document, NSIndexSet pageRange, NSUrl fileUrl, NSDictionary options, PSPDFProgressBlock progressBlock, out NSError error)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (pageRange == null)
				throw new ArgumentNullException ("pageRange");
			if (fileUrl == null)
				throw new ArgumentNullException ("fileUrl");
			if (options == null)
				throw new ArgumentNullException ("options");
			if (progressBlock == null)
				throw new ArgumentNullException ("progressBlock");
			IntPtr errorPtr = Marshal.AllocHGlobal(4);
			Marshal.WriteInt32(errorPtr, 0);
			
			BlockLiteral *block_ptr_progressBlock;
			BlockLiteral block_progressBlock;
			block_progressBlock = new BlockLiteral ();
			block_ptr_progressBlock = &block_progressBlock;
			block_progressBlock.SetupBlock (static_InnerPSPDFProgressBlock, progressBlock);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, selGeneratePDFFromDocumentPageRangeOutputFileURLOptionsProgressBlockError_Handle, document.Handle, pageRange.Handle, fileUrl.Handle, options.Handle, (IntPtr) block_ptr_progressBlock, errorPtr);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, selGeneratePDFFromDocumentPageRangeOutputFileURLOptionsProgressBlockError_Handle, document.Handle, pageRange.Handle, fileUrl.Handle, options.Handle, (IntPtr) block_ptr_progressBlock, errorPtr);
			}
			block_ptr_progressBlock->CleanupBlock ();
			
			
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? (NSError)Runtime.GetNSObject(errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return ret;
		}
		
		[Export ("generatePDFFromDocument:pageRange:options:progressBlock:error:")]
		[CompilerGenerated]
		public unsafe virtual NSData GeneratePDFFromDocumentToNSData (PSPDFDocument document, NSIndexSet pageRange, NSDictionary options, PSPDFProgressBlock progressBlock, out NSError error)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (pageRange == null)
				throw new ArgumentNullException ("pageRange");
			if (options == null)
				throw new ArgumentNullException ("options");
			if (progressBlock == null)
				throw new ArgumentNullException ("progressBlock");
			IntPtr errorPtr = Marshal.AllocHGlobal(4);
			Marshal.WriteInt32(errorPtr, 0);
			
			BlockLiteral *block_ptr_progressBlock;
			BlockLiteral block_progressBlock;
			block_progressBlock = new BlockLiteral ();
			block_ptr_progressBlock = &block_progressBlock;
			block_progressBlock.SetupBlock (static_InnerPSPDFProgressBlock, progressBlock);
			
			NSData ret;
			if (IsDirectBinding) {
				ret = (NSData) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, selGeneratePDFFromDocumentPageRangeOptionsProgressBlockError_Handle, document.Handle, pageRange.Handle, options.Handle, (IntPtr) block_ptr_progressBlock, errorPtr));
			} else {
				ret = (NSData) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, selGeneratePDFFromDocumentPageRangeOptionsProgressBlockError_Handle, document.Handle, pageRange.Handle, options.Handle, (IntPtr) block_ptr_progressBlock, errorPtr));
			}
			block_ptr_progressBlock->CleanupBlock ();
			
			
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? (NSError)Runtime.GetNSObject(errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return ret;
		}
		
		[Export ("generatePDFFromHTMLString:outputFileURL:options:")]
		[CompilerGenerated]
		public virtual bool GeneratePDFFromHTMLString (string html, NSUrl outputFileURL, NSDictionary options)
		{
			if (html == null)
				throw new ArgumentNullException ("html");
			if (outputFileURL == null)
				throw new ArgumentNullException ("outputFileURL");
			if (options == null)
				throw new ArgumentNullException ("options");
			var nshtml = NSString.CreateNative (html);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selGeneratePDFFromHTMLStringOutputFileURLOptions_Handle, nshtml, outputFileURL.Handle, options.Handle);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selGeneratePDFFromHTMLStringOutputFileURLOptions_Handle, nshtml, outputFileURL.Handle, options.Handle);
			}
			NSString.ReleaseNative (nshtml);
			
			return ret;
		}
		
		[Export ("generatePDFFromURL:outputFileURL:options:completionBlock:")]
		[CompilerGenerated]
		public unsafe virtual PSPDFConversionOperation GeneratePDFFromURL (NSUrl inputURL, NSUrl outputURL, NSDictionary options, PSPDFProcessorCompletionBlockWithError completionBlock)
		{
			if (inputURL == null)
				throw new ArgumentNullException ("inputURL");
			if (outputURL == null)
				throw new ArgumentNullException ("outputURL");
			if (options == null)
				throw new ArgumentNullException ("options");
			if (completionBlock == null)
				throw new ArgumentNullException ("completionBlock");
			BlockLiteral *block_ptr_completionBlock;
			BlockLiteral block_completionBlock;
			block_completionBlock = new BlockLiteral ();
			block_ptr_completionBlock = &block_completionBlock;
			block_completionBlock.SetupBlock (static_InnerPSPDFProcessorCompletionBlockWithError, completionBlock);
			
			PSPDFConversionOperation ret;
			if (IsDirectBinding) {
				ret = (PSPDFConversionOperation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, selGeneratePDFFromURLOutputFileURLOptionsCompletionBlock_Handle, inputURL.Handle, outputURL.Handle, options.Handle, (IntPtr) block_ptr_completionBlock));
			} else {
				ret = (PSPDFConversionOperation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, selGeneratePDFFromURLOutputFileURLOptionsCompletionBlock_Handle, inputURL.Handle, outputURL.Handle, options.Handle, (IntPtr) block_ptr_completionBlock));
			}
			block_ptr_completionBlock->CleanupBlock ();
			
			#pragma warning disable 168
			var postget0 = ConversionOperationQueue;
			#pragma warning restore 168
			return ret;
		}
		
		[CompilerGenerated]
		static object __mt_DefaultProcessor_var_static;
		[CompilerGenerated]
		public static PSPDFProcessor DefaultProcessor {
			[Export ("defaultProcessor")]
			get {
				PSPDFProcessor ret;
				ret = (PSPDFProcessor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selDefaultProcessorHandle));
				__mt_DefaultProcessor_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		static object __mt_ConversionOperationQueue_var_static;
		[CompilerGenerated]
		public static NSOperationQueue ConversionOperationQueue {
			[Export ("conversionOperationQueue")]
			get {
				NSOperationQueue ret;
				ret = (NSOperationQueue) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selConversionOperationQueueHandle));
				__mt_ConversionOperationQueue_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		static readonly IntPtr __Internal_libraryHandle = Dlfcn.dlopen (null, 0);
		[CompilerGenerated]
		static NSString _PSPDFProcessorAnnotationTypes;
		public static NSString PSPDFProcessorAnnotationTypes {
			get {
				if (_PSPDFProcessorAnnotationTypes == null)
					_PSPDFProcessorAnnotationTypes = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFProcessorAnnotationTypes");
				return _PSPDFProcessorAnnotationTypes;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFProcessorAnnotationDict;
		public static NSString PSPDFProcessorAnnotationDict {
			get {
				if (_PSPDFProcessorAnnotationDict == null)
					_PSPDFProcessorAnnotationDict = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFProcessorAnnotationDict");
				return _PSPDFProcessorAnnotationDict;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFProcessorAnnotationAsDictionary;
		public static NSString PSPDFProcessorAnnotationAsDictionary {
			get {
				if (_PSPDFProcessorAnnotationAsDictionary == null)
					_PSPDFProcessorAnnotationAsDictionary = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFProcessorAnnotationAsDictionary");
				return _PSPDFProcessorAnnotationAsDictionary;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFProcessorPageRect;
		public static NSString PSPDFProcessorPageRect {
			get {
				if (_PSPDFProcessorPageRect == null)
					_PSPDFProcessorPageRect = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFProcessorPageRect");
				return _PSPDFProcessorPageRect;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFProcessorNumberOfPages;
		public static NSString PSPDFProcessorNumberOfPages {
			get {
				if (_PSPDFProcessorNumberOfPages == null)
					_PSPDFProcessorNumberOfPages = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFProcessorNumberOfPages");
				return _PSPDFProcessorNumberOfPages;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFProcessorPageBorderMargin;
		public static NSString PSPDFProcessorPageBorderMargin {
			get {
				if (_PSPDFProcessorPageBorderMargin == null)
					_PSPDFProcessorPageBorderMargin = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFProcessorPageBorderMargin");
				return _PSPDFProcessorPageBorderMargin;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFProcessorAdditionalDelay;
		public static NSString PSPDFProcessorAdditionalDelay {
			get {
				if (_PSPDFProcessorAdditionalDelay == null)
					_PSPDFProcessorAdditionalDelay = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFProcessorAdditionalDelay");
				return _PSPDFProcessorAdditionalDelay;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFProcessorDocumentTitle;
		public static NSString PSPDFProcessorDocumentTitle {
			get {
				if (_PSPDFProcessorDocumentTitle == null)
					_PSPDFProcessorDocumentTitle = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFProcessorDocumentTitle");
				return _PSPDFProcessorDocumentTitle;
			}
		}
		internal delegate void InnerPSPDFProgressBlock (IntPtr block, global::System.UInt32 currentPage, global::System.UInt32 processedPages, global::System.UInt32 totalPages);
		[CompilerGenerated]
		static readonly InnerPSPDFProgressBlock static_InnerPSPDFProgressBlock = TrampolinePSPDFProgressBlock;
		[MonoPInvokeCallback (typeof (InnerPSPDFProgressBlock))]
		static unsafe void TrampolinePSPDFProgressBlock (IntPtr block, global::System.UInt32 currentPage, global::System.UInt32 processedPages, global::System.UInt32 totalPages) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::KS_PSPDFKitBindings.PSPDFProgressBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del (currentPage, processedPages, totalPages);
		}
		
		internal delegate void InnerPSPDFProcessorCompletionBlockWithError (IntPtr block, IntPtr fileUrl, IntPtr error);
		[CompilerGenerated]
		static readonly InnerPSPDFProcessorCompletionBlockWithError static_InnerPSPDFProcessorCompletionBlockWithError = TrampolinePSPDFProcessorCompletionBlockWithError;
		[MonoPInvokeCallback (typeof (InnerPSPDFProcessorCompletionBlockWithError))]
		static unsafe void TrampolinePSPDFProcessorCompletionBlockWithError (IntPtr block, IntPtr fileUrl, IntPtr error) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::KS_PSPDFKitBindings.PSPDFProcessorCompletionBlockWithError) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((MonoTouch.Foundation.NSUrl) Runtime.GetNSObject (fileUrl), (MonoTouch.Foundation.NSError) Runtime.GetNSObject (error));
		}
		
	} /* class PSPDFProcessor */
	public delegate void PSPDFProgressBlock (global::System.UInt32 currentPage, global::System.UInt32 processedPages, global::System.UInt32 totalPages);
	public delegate void PSPDFProcessorCompletionBlockWithError (NSUrl fileUrl, NSError error);
}
