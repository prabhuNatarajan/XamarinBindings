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
	[Register("PSPDFBookmarkBarButtonItem", true)]
	public unsafe partial class PSPDFBookmarkBarButtonItem : PSPDFBarButtonItem {
		[CompilerGenerated]
		const string selShowBookmarkControllerOnLongPress = "showBookmarkControllerOnLongPress";
		static readonly IntPtr selShowBookmarkControllerOnLongPressHandle = Selector.GetHandle ("showBookmarkControllerOnLongPress");
		[CompilerGenerated]
		const string selSetShowBookmarkControllerOnLongPress_ = "setShowBookmarkControllerOnLongPress:";
		static readonly IntPtr selSetShowBookmarkControllerOnLongPress_Handle = Selector.GetHandle ("setShowBookmarkControllerOnLongPress:");
		[CompilerGenerated]
		const string selTapChangesBookmarkStatus = "tapChangesBookmarkStatus";
		static readonly IntPtr selTapChangesBookmarkStatusHandle = Selector.GetHandle ("tapChangesBookmarkStatus");
		[CompilerGenerated]
		const string selSetTapChangesBookmarkStatus_ = "setTapChangesBookmarkStatus:";
		static readonly IntPtr selSetTapChangesBookmarkStatus_Handle = Selector.GetHandle ("setTapChangesBookmarkStatus:");
		[CompilerGenerated]
		const string selBookmarkNumberForVisiblePages = "bookmarkNumberForVisiblePages";
		static readonly IntPtr selBookmarkNumberForVisiblePagesHandle = Selector.GetHandle ("bookmarkNumberForVisiblePages");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFBookmarkBarButtonItem");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFBookmarkBarButtonItem () : base (NSObjectFlag.Empty)
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
		public PSPDFBookmarkBarButtonItem (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFBookmarkBarButtonItem (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFBookmarkBarButtonItem (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("bookmarkNumberForVisiblePages")]
		[CompilerGenerated]
		public virtual NSNumber BookmarkNumberForVisiblePages ()
		{
			if (IsDirectBinding) {
				return (NSNumber) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBookmarkNumberForVisiblePagesHandle));
			} else {
				return (NSNumber) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBookmarkNumberForVisiblePagesHandle));
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowBookmarkControllerOnLongPress {
			[Export ("showBookmarkControllerOnLongPress", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowBookmarkControllerOnLongPressHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShowBookmarkControllerOnLongPressHandle);
				}
			}
			
			[Export ("setShowBookmarkControllerOnLongPress:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowBookmarkControllerOnLongPress_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShowBookmarkControllerOnLongPress_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool TapChangesBookmarkStatus {
			[Export ("tapChangesBookmarkStatus", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selTapChangesBookmarkStatusHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selTapChangesBookmarkStatusHandle);
				}
			}
			
			[Export ("setTapChangesBookmarkStatus:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetTapChangesBookmarkStatus_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetTapChangesBookmarkStatus_Handle, value);
				}
			}
		}
		
	} /* class PSPDFBookmarkBarButtonItem */
}
