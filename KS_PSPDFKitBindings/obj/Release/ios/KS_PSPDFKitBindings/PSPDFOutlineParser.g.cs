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
	[Register("PSPDFOutlineParser", true)]
	public unsafe partial class PSPDFOutlineParser : NSObject {
		[CompilerGenerated]
		const string selOutline = "outline";
		static readonly IntPtr selOutlineHandle = Selector.GetHandle ("outline");
		[CompilerGenerated]
		const string selSetOutline_ = "setOutline:";
		static readonly IntPtr selSetOutline_Handle = Selector.GetHandle ("setOutline:");
		[CompilerGenerated]
		const string selIsOutlineParsed = "isOutlineParsed";
		static readonly IntPtr selIsOutlineParsedHandle = Selector.GetHandle ("isOutlineParsed");
		[CompilerGenerated]
		const string selIsOutlineAvailable = "isOutlineAvailable";
		static readonly IntPtr selIsOutlineAvailableHandle = Selector.GetHandle ("isOutlineAvailable");
		[CompilerGenerated]
		const string selDocumentProvider = "documentProvider";
		static readonly IntPtr selDocumentProviderHandle = Selector.GetHandle ("documentProvider");
		[CompilerGenerated]
		const string selFirstVisibleElement = "firstVisibleElement";
		static readonly IntPtr selFirstVisibleElementHandle = Selector.GetHandle ("firstVisibleElement");
		[CompilerGenerated]
		const string selSetFirstVisibleElement_ = "setFirstVisibleElement:";
		static readonly IntPtr selSetFirstVisibleElement_Handle = Selector.GetHandle ("setFirstVisibleElement:");
		[CompilerGenerated]
		const string selNamedDestinationResolveThreshold = "namedDestinationResolveThreshold";
		static readonly IntPtr selNamedDestinationResolveThresholdHandle = Selector.GetHandle ("namedDestinationResolveThreshold");
		[CompilerGenerated]
		const string selSetNamedDestinationResolveThreshold_ = "setNamedDestinationResolveThreshold:";
		static readonly IntPtr selSetNamedDestinationResolveThreshold_Handle = Selector.GetHandle ("setNamedDestinationResolveThreshold:");
		[CompilerGenerated]
		const string selInitWithDocumentProvider_ = "initWithDocumentProvider:";
		static readonly IntPtr selInitWithDocumentProvider_Handle = Selector.GetHandle ("initWithDocumentProvider:");
		[CompilerGenerated]
		const string selOutlineElementForPageExactPageOnly_ = "outlineElementForPage:exactPageOnly:";
		static readonly IntPtr selOutlineElementForPageExactPageOnly_Handle = Selector.GetHandle ("outlineElementForPage:exactPageOnly:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFOutlineParser");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFOutlineParser () : base (NSObjectFlag.Empty)
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
		public PSPDFOutlineParser (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFOutlineParser (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFOutlineParser (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDocumentProvider:")]
		[CompilerGenerated]
		public PSPDFOutlineParser (PSPDFDocumentProvider documentProvider)
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
		
		[Export ("outlineElementForPage:exactPageOnly:")]
		[CompilerGenerated]
		public virtual PSPDFOutlineElement OutlineElementForPage (global::System.UInt32 page, bool exactPageOnly)
		{
			if (IsDirectBinding) {
				return (PSPDFOutlineElement) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_bool (this.Handle, selOutlineElementForPageExactPageOnly_Handle, page, exactPageOnly));
			} else {
				return (PSPDFOutlineElement) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32_bool (this.SuperHandle, selOutlineElementForPageExactPageOnly_Handle, page, exactPageOnly));
			}
		}
		
		[CompilerGenerated]
		object __mt_Outline_var;
		[CompilerGenerated]
		public virtual PSPDFOutlineElement Outline {
			[Export ("outline")]
			get {
				PSPDFOutlineElement ret;
				if (IsDirectBinding) {
					ret = (PSPDFOutlineElement) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOutlineHandle));
				} else {
					ret = (PSPDFOutlineElement) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOutlineHandle));
				}
				MarkDirty ();
				__mt_Outline_var = ret;
				return ret;
			}
			
			[Export ("setOutline:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetOutline_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetOutline_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Outline_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool OutlineParsed {
			[Export ("isOutlineParsed", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsOutlineParsedHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsOutlineParsedHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool OutlineAvailable {
			[Export ("isOutlineAvailable", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsOutlineAvailableHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsOutlineAvailableHandle);
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
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 FirstVisibleElement {
			[Export ("firstVisibleElement", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selFirstVisibleElementHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selFirstVisibleElementHandle);
				}
			}
			
			[Export ("setFirstVisibleElement:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetFirstVisibleElement_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetFirstVisibleElement_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 NamedDestinationResolveThreshold {
			[Export ("namedDestinationResolveThreshold", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selNamedDestinationResolveThresholdHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selNamedDestinationResolveThresholdHandle);
				}
			}
			
			[Export ("setNamedDestinationResolveThreshold:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetNamedDestinationResolveThreshold_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetNamedDestinationResolveThreshold_Handle, value);
				}
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Outline_var = null;
				__mt_DocumentProvider_var = null;
			}
		}
	} /* class PSPDFOutlineParser */
}
