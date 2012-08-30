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
	[Register("PSPDFTextSearch", true)]
	public unsafe partial class PSPDFTextSearch : NSObject {
		static readonly IntPtr selSearchMode = Selector.GetHandle ("searchMode");
		static readonly IntPtr selSetSearchMode_ = Selector.GetHandle ("setSearchMode:");
		static readonly IntPtr selCompareOptions = Selector.GetHandle ("compareOptions");
		static readonly IntPtr selSetCompareOptions_ = Selector.GetHandle ("setCompareOptions:");
		static readonly IntPtr selDocument = Selector.GetHandle ("document");
		static readonly IntPtr selDelegate = Selector.GetHandle ("delegate");
		static readonly IntPtr selSetDelegate_ = Selector.GetHandle ("setDelegate:");
		static readonly IntPtr selInitWithDocument_ = Selector.GetHandle ("initWithDocument:");
		static readonly IntPtr selSearchForString_ = Selector.GetHandle ("searchForString:");
		static readonly IntPtr selSearchForStringVisiblePagesOnlyVisible_ = Selector.GetHandle ("searchForString:visiblePages:onlyVisible:");
		static readonly IntPtr selHasTextForPage_ = Selector.GetHandle ("hasTextForPage:");
		static readonly IntPtr selTextForPage_ = Selector.GetHandle ("textForPage:");
		static readonly IntPtr selCancelAllOperationsAndWait = Selector.GetHandle ("cancelAllOperationsAndWait");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFTextSearch");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFTextSearch () : base (NSObjectFlag.Empty)
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
		public PSPDFTextSearch (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFTextSearch (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFTextSearch (IntPtr handle) : base (handle) {}

		[Export ("initWithDocument:")]
		[CompilerGenerated]
		public PSPDFTextSearch (PSPDFDocument document) : base (NSObjectFlag.Empty)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithDocument_, document.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithDocument_, document.Handle);
			}
		}
		
		[Export ("searchForString:")]
		[CompilerGenerated]
		public virtual void SearchForString (string searchText)
		{
			if (searchText == null)
				throw new ArgumentNullException ("searchText");
			var nssearchText = NSString.CreateNative (searchText);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSearchForString_, nssearchText);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSearchForString_, nssearchText);
			}
			NSString.ReleaseNative (nssearchText);
			
		}
		
		[Export ("searchForString:visiblePages:onlyVisible:")]
		[CompilerGenerated]
		public virtual void SearchForString (string searchText, NSArray visiblePages, bool onlyVisible)
		{
			if (searchText == null)
				throw new ArgumentNullException ("searchText");
			if (visiblePages == null)
				throw new ArgumentNullException ("visiblePages");
			var nssearchText = NSString.CreateNative (searchText);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_bool (this.Handle, selSearchForStringVisiblePagesOnlyVisible_, nssearchText, visiblePages.Handle, onlyVisible);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_bool (this.SuperHandle, selSearchForStringVisiblePagesOnlyVisible_, nssearchText, visiblePages.Handle, onlyVisible);
			}
			NSString.ReleaseNative (nssearchText);
			
		}
		
		[Export ("hasTextForPage:")]
		[CompilerGenerated]
		public virtual bool HasTextForPage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_UInt32 (this.Handle, selHasTextForPage_, page);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_UInt32 (this.SuperHandle, selHasTextForPage_, page);
			}
		}
		
		[Export ("textForPage:")]
		[CompilerGenerated]
		public virtual string TextForPage (System.UInt32 page)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selTextForPage_, page));
			} else {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selTextForPage_, page));
			}
		}
		
		[Export ("cancelAllOperationsAndWait")]
		[CompilerGenerated]
		public virtual void CancelAllOperationsAndWait ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCancelAllOperationsAndWait);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selCancelAllOperationsAndWait);
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFSearchMode SearchMode {
			[Export ("searchMode", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFSearchMode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selSearchMode);
				} else {
					return (PSPDFSearchMode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selSearchMode);
				}
			}
			
			[Export ("setSearchMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetSearchMode_, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetSearchMode_, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSStringCompareOptions CompareOptions {
			[Export ("compareOptions", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (NSStringCompareOptions) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selCompareOptions);
				} else {
					return (NSStringCompareOptions) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selCompareOptions);
				}
			}
			
			[Export ("setCompareOptions:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetCompareOptions_, (UInt32)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetCompareOptions_, (UInt32)value);
				}
			}
		}
		
		object __mt_Document_var;
		[CompilerGenerated]
		public virtual PSPDFDocument Document {
			[Export ("document")]
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
			
		}
		
		[CompilerGenerated]
		public PSPDFSearchDelegate Delegate {
			get { return WeakDelegate as PSPDFSearchDelegate; }
			set { WeakDelegate = value; }
		}
		
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegate));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegate));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_Document_var = null;
			__mt_WeakDelegate_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFTextSearch */
}
