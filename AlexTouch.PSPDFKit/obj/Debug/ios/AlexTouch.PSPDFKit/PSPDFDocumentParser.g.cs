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
	[Register("PSPDFDocumentParser", true)]
	public unsafe partial class PSPDFDocumentParser : NSObject {
		static readonly IntPtr selDocumentProvider = Selector.GetHandle ("documentProvider");
		static readonly IntPtr selEncryptionFilter = Selector.GetHandle ("encryptionFilter");
		static readonly IntPtr selPageObjectNumbers = Selector.GetHandle ("pageObjectNumbers");
		static readonly IntPtr selInitWithDocumentProvider_ = Selector.GetHandle ("initWithDocumentProvider:");
		static readonly IntPtr selParseDocument = Selector.GetHandle ("parseDocument");
		static readonly IntPtr selSaveAnnotationsWithError_ = Selector.GetHandle ("saveAnnotations:withError:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFDocumentParser");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFDocumentParser () : base (NSObjectFlag.Empty)
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
		public PSPDFDocumentParser (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFDocumentParser (IntPtr handle) : base (handle) {}

		[Export ("initWithDocumentProvider:")]
		[CompilerGenerated]
		public PSPDFDocumentParser (PSPDFDocumentProvider documentProvider) : base (NSObjectFlag.Empty)
		{
			if (documentProvider == null)
				throw new ArgumentNullException ("documentProvider");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithDocumentProvider_, documentProvider.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithDocumentProvider_, documentProvider.Handle);
			}
		}
		
		[Export ("parseDocument")]
		[CompilerGenerated]
		public virtual void ParseDocument ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selParseDocument);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selParseDocument);
			}
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
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, selSaveAnnotationsWithError_, annotations.Handle, errorPtr);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSaveAnnotationsWithError_, annotations.Handle, errorPtr);
			}
			
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? (NSError)Runtime.GetNSObject(errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return ret;
		}
		
		object __mt_DocumentProvider_var;
		[CompilerGenerated]
		public virtual PSPDFDocumentProvider DocumentProvider {
			[Export ("documentProvider")]
			get {
				PSPDFDocumentProvider ret;
				if (IsDirectBinding) {
					ret = (PSPDFDocumentProvider) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocumentProvider));
				} else {
					ret = (PSPDFDocumentProvider) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocumentProvider));
				}
				MarkDirty ();
				__mt_DocumentProvider_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string EncryptionFilter {
			[Export ("encryptionFilter")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selEncryptionFilter));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selEncryptionFilter));
				}
			}
			
		}
		
		object __mt_PageObjectNumbers_var;
		[CompilerGenerated]
		public virtual NSArray PageObjectNumbers {
			[Export ("pageObjectNumbers")]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPageObjectNumbers));
				} else {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPageObjectNumbers));
				}
				MarkDirty ();
				__mt_PageObjectNumbers_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_DocumentProvider_var = null;
			__mt_PageObjectNumbers_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFDocumentParser */
}
