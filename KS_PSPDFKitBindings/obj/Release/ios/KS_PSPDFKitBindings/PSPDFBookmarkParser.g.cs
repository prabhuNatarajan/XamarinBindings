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
	[Register("PSPDFBookmarkParser", true)]
	public unsafe partial class PSPDFBookmarkParser : NSObject {
		[CompilerGenerated]
		const string selBookmarks = "bookmarks";
		static readonly IntPtr selBookmarksHandle = Selector.GetHandle ("bookmarks");
		[CompilerGenerated]
		const string selSetBookmarks_ = "setBookmarks:";
		static readonly IntPtr selSetBookmarks_Handle = Selector.GetHandle ("setBookmarks:");
		[CompilerGenerated]
		const string selDocument = "document";
		static readonly IntPtr selDocumentHandle = Selector.GetHandle ("document");
		[CompilerGenerated]
		const string selSetDocument_ = "setDocument:";
		static readonly IntPtr selSetDocument_Handle = Selector.GetHandle ("setDocument:");
		[CompilerGenerated]
		const string selInitWithDocument_ = "initWithDocument:";
		static readonly IntPtr selInitWithDocument_Handle = Selector.GetHandle ("initWithDocument:");
		[CompilerGenerated]
		const string selAddBookmarkForPage_ = "addBookmarkForPage:";
		static readonly IntPtr selAddBookmarkForPage_Handle = Selector.GetHandle ("addBookmarkForPage:");
		[CompilerGenerated]
		const string selRemoveBookmarkForPage_ = "removeBookmarkForPage:";
		static readonly IntPtr selRemoveBookmarkForPage_Handle = Selector.GetHandle ("removeBookmarkForPage:");
		[CompilerGenerated]
		const string selClearAllBookmarksWithError_ = "clearAllBookmarksWithError:";
		static readonly IntPtr selClearAllBookmarksWithError_Handle = Selector.GetHandle ("clearAllBookmarksWithError:");
		[CompilerGenerated]
		const string selBookmarkForPage_ = "bookmarkForPage:";
		static readonly IntPtr selBookmarkForPage_Handle = Selector.GetHandle ("bookmarkForPage:");
		[CompilerGenerated]
		const string selCachePath = "cachePath";
		static readonly IntPtr selCachePathHandle = Selector.GetHandle ("cachePath");
		[CompilerGenerated]
		const string selBookmarkPath = "bookmarkPath";
		static readonly IntPtr selBookmarkPathHandle = Selector.GetHandle ("bookmarkPath");
		[CompilerGenerated]
		const string selLoadBookmarksWithError_ = "loadBookmarksWithError:";
		static readonly IntPtr selLoadBookmarksWithError_Handle = Selector.GetHandle ("loadBookmarksWithError:");
		[CompilerGenerated]
		const string selSaveBookmarksWithError_ = "saveBookmarksWithError:";
		static readonly IntPtr selSaveBookmarksWithError_Handle = Selector.GetHandle ("saveBookmarksWithError:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFBookmarkParser");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFBookmarkParser () : base (NSObjectFlag.Empty)
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
		public PSPDFBookmarkParser (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFBookmarkParser (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFBookmarkParser (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDocument:")]
		[CompilerGenerated]
		public PSPDFBookmarkParser (PSPDFDocument document)
			: base (NSObjectFlag.Empty)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithDocument_Handle, document.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithDocument_Handle, document.Handle);
			}
		}
		
		[Export ("addBookmarkForPage:")]
		[CompilerGenerated]
		public virtual bool AddBookmarkForPage (global::System.UInt32 page)
		{
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_UInt32 (this.Handle, selAddBookmarkForPage_Handle, page);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_UInt32 (this.SuperHandle, selAddBookmarkForPage_Handle, page);
			}
			#pragma warning disable 168
			var postget0 = Bookmarks;
			#pragma warning restore 168
			return ret;
		}
		
		[Export ("removeBookmarkForPage:")]
		[CompilerGenerated]
		public virtual bool RemoveBookmarkForPage (global::System.UInt32 page)
		{
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_UInt32 (this.Handle, selRemoveBookmarkForPage_Handle, page);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_UInt32 (this.SuperHandle, selRemoveBookmarkForPage_Handle, page);
			}
			#pragma warning disable 168
			var postget0 = Bookmarks;
			#pragma warning restore 168
			return ret;
		}
		
		[Export ("clearAllBookmarksWithError:")]
		[CompilerGenerated]
		public virtual bool ClearAllBookmarksWithError (out NSError error)
		{
			IntPtr errorPtr = Marshal.AllocHGlobal(4);
			Marshal.WriteInt32(errorPtr, 0);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selClearAllBookmarksWithError_Handle, errorPtr);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selClearAllBookmarksWithError_Handle, errorPtr);
			}
			#pragma warning disable 168
			var postget0 = Bookmarks;
			#pragma warning restore 168
			
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? (NSError)Runtime.GetNSObject(errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return ret;
		}
		
		[Export ("bookmarkForPage:")]
		[CompilerGenerated]
		public virtual PSPDFBookmark BookmarkForPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return (PSPDFBookmark) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selBookmarkForPage_Handle, page));
			} else {
				return (PSPDFBookmark) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selBookmarkForPage_Handle, page));
			}
		}
		
		[Export ("cachePath")]
		[CompilerGenerated]
		public virtual string CachePath ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCachePathHandle));
			} else {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCachePathHandle));
			}
		}
		
		[Export ("bookmarkPath")]
		[CompilerGenerated]
		public virtual string BookmarkPath ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBookmarkPathHandle));
			} else {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBookmarkPathHandle));
			}
		}
		
		[Export ("loadBookmarksWithError:")]
		[CompilerGenerated]
		public virtual PSPDFBookmark[] LoadBookmarksWithError (out NSError error)
		{
			IntPtr errorPtr = Marshal.AllocHGlobal(4);
			Marshal.WriteInt32(errorPtr, 0);
			
			PSPDFBookmark[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFBookmark>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selLoadBookmarksWithError_Handle, errorPtr));
			} else {
				ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFBookmark>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selLoadBookmarksWithError_Handle, errorPtr));
			}
			
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? (NSError)Runtime.GetNSObject(errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return ret;
		}
		
		[Export ("saveBookmarksWithError:")]
		[CompilerGenerated]
		public virtual bool SaveBookmarksWithError (global::System.IntPtr error)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selSaveBookmarksWithError_Handle, error);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selSaveBookmarksWithError_Handle, error);
			}
		}
		
		[CompilerGenerated]
		object __mt_Bookmarks_var;
		[CompilerGenerated]
		public virtual PSPDFBookmark[] Bookmarks {
			[Export ("bookmarks", ArgumentSemantic.Copy)]
			get {
				PSPDFBookmark[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFBookmark>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBookmarksHandle));
				} else {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFBookmark>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBookmarksHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Bookmarks_var = ret;
				return ret;
			}
			
			[Export ("setBookmarks:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBookmarks_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBookmarks_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_Bookmarks_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Document_var;
		[CompilerGenerated]
		public virtual PSPDFDocument Document {
			[Export ("document")]
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
			
			[Export ("setDocument:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDocument_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDocument_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Document_var = value;
			}
		}
		
		[CompilerGenerated]
		static readonly IntPtr __Internal_libraryHandle = Dlfcn.dlopen (null, 0);
		[CompilerGenerated]
		static NSString _PSPDFBookmarksChangedNotification;
		public static NSString PSPDFBookmarksChangedNotification {
			get {
				if (_PSPDFBookmarksChangedNotification == null)
					_PSPDFBookmarksChangedNotification = Dlfcn.GetStringConstant (__Internal_libraryHandle, "kPSPDFBookmarksChangedNotification");
				return _PSPDFBookmarksChangedNotification;
			}
		}
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Bookmarks_var = null;
				__mt_Document_var = null;
			}
		}
	} /* class PSPDFBookmarkParser */
}
