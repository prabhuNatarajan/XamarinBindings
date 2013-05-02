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
	[Register("PSPDFLabelParser", true)]
	public unsafe partial class PSPDFLabelParser : NSObject {
		[CompilerGenerated]
		const string selDocumentProvider = "documentProvider";
		static readonly IntPtr selDocumentProviderHandle = Selector.GetHandle ("documentProvider");
		[CompilerGenerated]
		const string selParseDocument = "parseDocument";
		static readonly IntPtr selParseDocumentHandle = Selector.GetHandle ("parseDocument");
		[CompilerGenerated]
		const string selLabels = "labels";
		static readonly IntPtr selLabelsHandle = Selector.GetHandle ("labels");
		[CompilerGenerated]
		const string selInitWithDocumentProvider_ = "initWithDocumentProvider:";
		static readonly IntPtr selInitWithDocumentProvider_Handle = Selector.GetHandle ("initWithDocumentProvider:");
		[CompilerGenerated]
		const string selPageLabelForPage_ = "pageLabelForPage:";
		static readonly IntPtr selPageLabelForPage_Handle = Selector.GetHandle ("pageLabelForPage:");
		[CompilerGenerated]
		const string selPageForPageLabelPartialMatching_ = "pageForPageLabel:partialMatching:";
		static readonly IntPtr selPageForPageLabelPartialMatching_Handle = Selector.GetHandle ("pageForPageLabel:partialMatching:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFLabelParser");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFLabelParser () : base (NSObjectFlag.Empty)
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
		public PSPDFLabelParser (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFLabelParser (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFLabelParser (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDocumentProvider:")]
		[CompilerGenerated]
		public PSPDFLabelParser (PSPDFDocumentProvider documentProvider)
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
		
		[Export ("pageLabelForPage:")]
		[CompilerGenerated]
		public virtual string PageLabelForPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selPageLabelForPage_Handle, page));
			} else {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selPageLabelForPage_Handle, page));
			}
		}
		
		[Export ("pageForPageLabel:partialMatching:")]
		[CompilerGenerated]
		public virtual global::System.UInt32 PageForPageLabel (string pageLabel, bool partialMatching)
		{
			if (pageLabel == null)
				throw new ArgumentNullException ("pageLabel");
			var nspageLabel = NSString.CreateNative (pageLabel);
			
			global::System.UInt32 ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr_bool (this.Handle, selPageForPageLabelPartialMatching_Handle, nspageLabel, partialMatching);
			} else {
				ret = ApiDefinition.Messaging.UInt32_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selPageForPageLabelPartialMatching_Handle, nspageLabel, partialMatching);
			}
			NSString.ReleaseNative (nspageLabel);
			
			return ret;
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
		object __mt_ParseDocument_var;
		[CompilerGenerated]
		public virtual NSDictionary ParseDocument {
			[Export ("parseDocument")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParseDocumentHandle));
				} else {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParseDocumentHandle));
				}
				MarkDirty ();
				__mt_ParseDocument_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Labels_var;
		[CompilerGenerated]
		public virtual NSDictionary Labels {
			[Export ("labels", ArgumentSemantic.Copy)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLabelsHandle));
				} else {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLabelsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Labels_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_DocumentProvider_var = null;
				__mt_ParseDocument_var = null;
				__mt_Labels_var = null;
			}
		}
	} /* class PSPDFLabelParser */
}
