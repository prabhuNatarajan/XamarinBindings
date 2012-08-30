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
	[Register("PSPDFOutlineElement", true)]
	public unsafe partial class PSPDFOutlineElement : PSPDFBookmark {
		static readonly IntPtr selTitle = Selector.GetHandle ("title");
		static readonly IntPtr selSetTitle_ = Selector.GetHandle ("setTitle:");
		static readonly IntPtr selRelativePath = Selector.GetHandle ("relativePath");
		static readonly IntPtr selSetRelativePath_ = Selector.GetHandle ("setRelativePath:");
		static readonly IntPtr selChildren = Selector.GetHandle ("children");
		static readonly IntPtr selLevel = Selector.GetHandle ("level");
		static readonly IntPtr selSetLevel_ = Selector.GetHandle ("setLevel:");
		static readonly IntPtr selIsExpanded = Selector.GetHandle ("isExpanded");
		static readonly IntPtr selSetExpanded_ = Selector.GetHandle ("setExpanded:");
		static readonly IntPtr selInitWithTitlePageRelativePathChildrenLevel_ = Selector.GetHandle ("initWithTitle:page:relativePath:children:level:");
		static readonly IntPtr selFlattenedChildren = Selector.GetHandle ("flattenedChildren");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFOutlineElement");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFOutlineElement () : base (NSObjectFlag.Empty)
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
		public PSPDFOutlineElement (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFOutlineElement (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFOutlineElement (IntPtr handle) : base (handle) {}

		[Export ("initWithTitle:page:relativePath:children:level:")]
		[CompilerGenerated]
		public PSPDFOutlineElement (string title, System.UInt32 page, string relativePath, NSArray children, System.UInt32 level) : base (NSObjectFlag.Empty)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			if (relativePath == null)
				throw new ArgumentNullException ("relativePath");
			if (children == null)
				throw new ArgumentNullException ("children");
			var nstitle = NSString.CreateNative (title);
			var nsrelativePath = NSString.CreateNative (relativePath);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt32_IntPtr_IntPtr_UInt32 (this.Handle, selInitWithTitlePageRelativePathChildrenLevel_, nstitle, page, nsrelativePath, children.Handle, level);
			} else {
				Handle = ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt32_IntPtr_IntPtr_UInt32 (this.SuperHandle, selInitWithTitlePageRelativePathChildrenLevel_, nstitle, page, nsrelativePath, children.Handle, level);
			}
			NSString.ReleaseNative (nstitle);
			NSString.ReleaseNative (nsrelativePath);
			
		}
		
		[Export ("flattenedChildren")]
		[CompilerGenerated]
		public virtual NSArray FlattenedChildren ()
		{
			if (IsDirectBinding) {
				return (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFlattenedChildren));
			} else {
				return (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFlattenedChildren));
			}
		}
		
		[CompilerGenerated]
		public virtual string Title {
			[Export ("title")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTitle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTitle));
				}
			}
			
			[Export ("setTitle:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTitle_, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTitle_, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string RelativePath {
			[Export ("relativePath", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRelativePath));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRelativePath));
				}
			}
			
			[Export ("setRelativePath:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRelativePath_, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRelativePath_, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		object __mt_Children_var;
		[CompilerGenerated]
		public virtual NSArray Children {
			[Export ("children")]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selChildren));
				} else {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selChildren));
				}
				MarkDirty ();
				__mt_Children_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual System.UInt32 Level {
			[Export ("level", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selLevel);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selLevel);
				}
			}
			
			[Export ("setLevel:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetLevel_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetLevel_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Expanded {
			[Export ("isExpanded", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsExpanded);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsExpanded);
				}
			}
			
			[Export ("setExpanded:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetExpanded_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetExpanded_, value);
				}
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_Children_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFOutlineElement */
}
