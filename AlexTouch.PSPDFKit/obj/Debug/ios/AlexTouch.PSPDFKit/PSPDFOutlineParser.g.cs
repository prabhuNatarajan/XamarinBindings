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
	[Register("PSPDFOutlineParser", true)]
	public unsafe partial class PSPDFOutlineParser : NSObject {
		static readonly IntPtr selOutline = Selector.GetHandle ("outline");
		static readonly IntPtr selIsOutlineParsed = Selector.GetHandle ("isOutlineParsed");
		static readonly IntPtr selIsOutlineAvailable = Selector.GetHandle ("isOutlineAvailable");
		static readonly IntPtr selFirstVisibleElement = Selector.GetHandle ("firstVisibleElement");
		static readonly IntPtr selSetFirstVisibleElement_ = Selector.GetHandle ("setFirstVisibleElement:");
		static readonly IntPtr selInitWithDocumentProvider_ = Selector.GetHandle ("initWithDocumentProvider:");
		static readonly IntPtr selOutlineElementForPageExactPageOnly_ = Selector.GetHandle ("outlineElementForPage:exactPageOnly:");
		static readonly IntPtr selResolveDestNamesDocumentRef_ = Selector.GetHandle ("resolveDestNames:documentRef:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFOutlineParser");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFOutlineParser () : base (NSObjectFlag.Empty)
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
		public PSPDFOutlineParser (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFOutlineParser (IntPtr handle) : base (handle) {}

		[Export ("initWithDocumentProvider:")]
		[CompilerGenerated]
		public PSPDFOutlineParser (PSPDFDocumentProvider documentProvider) : base (NSObjectFlag.Empty)
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
		
		[Export ("outlineElementForPage:exactPageOnly:")]
		[CompilerGenerated]
		public virtual PSPDFOutlineElement OutlineElementForPage (System.UInt32 page, bool exactPageOnly)
		{
			if (IsDirectBinding) {
				return (PSPDFOutlineElement) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_bool (this.Handle, selOutlineElementForPageExactPageOnly_, page, exactPageOnly));
			} else {
				return (PSPDFOutlineElement) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32_bool (this.SuperHandle, selOutlineElementForPageExactPageOnly_, page, exactPageOnly));
			}
		}
		
		[Export ("resolveDestNames:documentRef:")]
		[CompilerGenerated]
		internal static NSDictionary ResolveDestNames_ (NSSet destNames, System.IntPtr documentRef)
		{
			if (destNames == null)
				throw new ArgumentNullException ("destNames");
			return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selResolveDestNamesDocumentRef_, destNames.Handle, documentRef));
		}
		
		object __mt_Outline_var;
		[CompilerGenerated]
		public virtual PSPDFOutlineElement Outline {
			[Export ("outline")]
			get {
				PSPDFOutlineElement ret;
				if (IsDirectBinding) {
					ret = (PSPDFOutlineElement) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOutline));
				} else {
					ret = (PSPDFOutlineElement) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOutline));
				}
				MarkDirty ();
				__mt_Outline_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool OutlineParsed {
			[Export ("isOutlineParsed", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsOutlineParsed);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsOutlineParsed);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool OutlineAvailable {
			[Export ("isOutlineAvailable", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsOutlineAvailable);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsOutlineAvailable);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual System.UInt32 FirstVisibleElement {
			[Export ("firstVisibleElement", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selFirstVisibleElement);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selFirstVisibleElement);
				}
			}
			
			[Export ("setFirstVisibleElement:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetFirstVisibleElement_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetFirstVisibleElement_, value);
				}
			}
		}
		
		static readonly IntPtr __Internal_libraryHandle = Dlfcn.dlopen (null, 0);
		static NSString _PSPDFOutlineParserErrorDomain;
		public static NSString PSPDFOutlineParserErrorDomain {
			get {
				if (_PSPDFOutlineParserErrorDomain == null)
					_PSPDFOutlineParserErrorDomain = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFOutlineParserErrorDomain");
				return _PSPDFOutlineParserErrorDomain;
			}
		}
		protected override void Dispose (bool disposing)
		{
			__mt_Outline_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFOutlineParser */
}
