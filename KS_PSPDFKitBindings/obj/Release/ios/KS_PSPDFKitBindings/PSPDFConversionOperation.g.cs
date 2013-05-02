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
	[Register("PSPDFConversionOperation", true)]
	public unsafe partial class PSPDFConversionOperation : NSOperation {
		[CompilerGenerated]
		const string selInputURL = "inputURL";
		static readonly IntPtr selInputURLHandle = Selector.GetHandle ("inputURL");
		[CompilerGenerated]
		const string selOutputFileURL = "outputFileURL";
		static readonly IntPtr selOutputFileURLHandle = Selector.GetHandle ("outputFileURL");
		[CompilerGenerated]
		const string selOptions = "options";
		static readonly IntPtr selOptionsHandle = Selector.GetHandle ("options");
		[CompilerGenerated]
		const string selError = "error";
		static readonly IntPtr selErrorHandle = Selector.GetHandle ("error");
		[CompilerGenerated]
		const string selInitWithURLOutputFileURLOptionsCompletionBlock_ = "initWithURL:outputFileURL:options:completionBlock:";
		static readonly IntPtr selInitWithURLOutputFileURLOptionsCompletionBlock_Handle = Selector.GetHandle ("initWithURL:outputFileURL:options:completionBlock:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFConversionOperation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFConversionOperation () : base (NSObjectFlag.Empty)
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
		public PSPDFConversionOperation (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFConversionOperation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFConversionOperation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithURL:outputFileURL:options:completionBlock:")]
		[CompilerGenerated]
		public unsafe PSPDFConversionOperation (NSUrl inputURL, NSUrl outputFileURL, NSDictionary options, PSPDFProcessorCompletionBlockWithError completionBlock)
			: base (NSObjectFlag.Empty)
		{
			if (inputURL == null)
				throw new ArgumentNullException ("inputURL");
			if (outputFileURL == null)
				throw new ArgumentNullException ("outputFileURL");
			if (options == null)
				throw new ArgumentNullException ("options");
			if (completionBlock == null)
				throw new ArgumentNullException ("completionBlock");
			BlockLiteral *block_ptr_completionBlock;
			BlockLiteral block_completionBlock;
			block_completionBlock = new BlockLiteral ();
			block_ptr_completionBlock = &block_completionBlock;
			block_completionBlock.SetupBlock (static_InnerPSPDFProcessorCompletionBlockWithError, completionBlock);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, selInitWithURLOutputFileURLOptionsCompletionBlock_Handle, inputURL.Handle, outputFileURL.Handle, options.Handle, (IntPtr) block_ptr_completionBlock);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, selInitWithURLOutputFileURLOptionsCompletionBlock_Handle, inputURL.Handle, outputFileURL.Handle, options.Handle, (IntPtr) block_ptr_completionBlock);
			}
			block_ptr_completionBlock->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		object __mt_InputURL_var;
		[CompilerGenerated]
		public virtual NSUrl InputURL {
			[Export ("inputURL")]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selInputURLHandle));
				} else {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selInputURLHandle));
				}
				MarkDirty ();
				__mt_InputURL_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_OutputFileURL_var;
		[CompilerGenerated]
		public virtual NSUrl OutputFileURL {
			[Export ("outputFileURL")]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOutputFileURLHandle));
				} else {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOutputFileURLHandle));
				}
				MarkDirty ();
				__mt_OutputFileURL_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Options_var;
		[CompilerGenerated]
		public virtual NSDictionary Options {
			[Export ("options", ArgumentSemantic.Copy)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOptionsHandle));
				} else {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOptionsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Options_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Error_var;
		[CompilerGenerated]
		public virtual NSError Error {
			[Export ("error")]
			get {
				NSError ret;
				if (IsDirectBinding) {
					ret = (NSError) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selErrorHandle));
				} else {
					ret = (NSError) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selErrorHandle));
				}
				MarkDirty ();
				__mt_Error_var = ret;
				return ret;
			}
			
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
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_InputURL_var = null;
				__mt_OutputFileURL_var = null;
				__mt_Options_var = null;
				__mt_Error_var = null;
			}
		}
	} /* class PSPDFConversionOperation */
}
