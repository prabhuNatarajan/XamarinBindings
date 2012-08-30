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
	[Register("PSPDFLinkAnnotation", true)]
	public unsafe partial class PSPDFLinkAnnotation : PSPDFAnnotation {
		static readonly IntPtr selLinkType = Selector.GetHandle ("linkType");
		static readonly IntPtr selSetLinkType_ = Selector.GetHandle ("setLinkType:");
		static readonly IntPtr selPageLinkTarget = Selector.GetHandle ("pageLinkTarget");
		static readonly IntPtr selSetPageLinkTarget_ = Selector.GetHandle ("setPageLinkTarget:");
		static readonly IntPtr selSiteLinkTarget = Selector.GetHandle ("siteLinkTarget");
		static readonly IntPtr selSetSiteLinkTarget_ = Selector.GetHandle ("setSiteLinkTarget:");
		static readonly IntPtr selURL = Selector.GetHandle ("URL");
		static readonly IntPtr selSetURL_ = Selector.GetHandle ("setURL:");
		static readonly IntPtr selRects = Selector.GetHandle ("rects");
		static readonly IntPtr selSetRects_ = Selector.GetHandle ("setRects:");
		static readonly IntPtr selOptions = Selector.GetHandle ("options");
		static readonly IntPtr selSetOptions_ = Selector.GetHandle ("setOptions:");
		static readonly IntPtr selIsModal = Selector.GetHandle ("isModal");
		static readonly IntPtr selSetModal_ = Selector.GetHandle ("setModal:");
		static readonly IntPtr selIsPopover = Selector.GetHandle ("isPopover");
		static readonly IntPtr selSetPopover_ = Selector.GetHandle ("setPopover:");
		static readonly IntPtr selSize = Selector.GetHandle ("size");
		static readonly IntPtr selSetSize_ = Selector.GetHandle ("setSize:");
		static readonly IntPtr selPageRef = Selector.GetHandle ("pageRef");
		static readonly IntPtr selSetPageRef_ = Selector.GetHandle ("setPageRef:");
		static readonly IntPtr selDestinationName = Selector.GetHandle ("destinationName");
		static readonly IntPtr selSetDestinationName_ = Selector.GetHandle ("setDestinationName:");
		static readonly IntPtr selLinkURL = Selector.GetHandle ("linkURL");
		static readonly IntPtr selSetLinkURL_ = Selector.GetHandle ("setLinkURL:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFLinkAnnotation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFLinkAnnotation () : base (NSObjectFlag.Empty)
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
		public PSPDFLinkAnnotation (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFLinkAnnotation (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFLinkAnnotation (IntPtr handle) : base (handle) {}

		[CompilerGenerated]
		public virtual PSPDFLinkAnnotationType LinkType {
			[Export ("linkType", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFLinkAnnotationType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selLinkType);
				} else {
					return (PSPDFLinkAnnotationType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selLinkType);
				}
			}
			
			[Export ("setLinkType:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetLinkType_, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetLinkType_, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual System.UInt32 PageLinkTarget {
			[Export ("pageLinkTarget", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPageLinkTarget);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selPageLinkTarget);
				}
			}
			
			[Export ("setPageLinkTarget:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetPageLinkTarget_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetPageLinkTarget_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string SiteLinkTarget {
			[Export ("siteLinkTarget")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSiteLinkTarget));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSiteLinkTarget));
				}
			}
			
			[Export ("setSiteLinkTarget:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSiteLinkTarget_, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSiteLinkTarget_, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		object __mt_Url_var;
		[CompilerGenerated]
		public virtual NSUrl Url {
			[Export ("URL")]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selURL));
				} else {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selURL));
				}
				MarkDirty ();
				__mt_Url_var = ret;
				return ret;
			}
			
			[Export ("setURL:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetURL_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetURL_, value.Handle);
				}
				MarkDirty ();
				__mt_Url_var = value;
			}
		}
		
		object __mt_Rects_var;
		[CompilerGenerated]
		public virtual NSArray Rects {
			[Export ("rects")]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRects));
				} else {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRects));
				}
				MarkDirty ();
				__mt_Rects_var = ret;
				return ret;
			}
			
			[Export ("setRects:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRects_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRects_, value.Handle);
				}
				MarkDirty ();
				__mt_Rects_var = value;
			}
		}
		
		object __mt_Options_var;
		[CompilerGenerated]
		public virtual NSDictionary Options {
			[Export ("options")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOptions));
				} else {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOptions));
				}
				MarkDirty ();
				__mt_Options_var = ret;
				return ret;
			}
			
			[Export ("setOptions:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetOptions_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetOptions_, value.Handle);
				}
				MarkDirty ();
				__mt_Options_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool Modal {
			[Export ("isModal", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsModal);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsModal);
				}
			}
			
			[Export ("setModal:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetModal_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetModal_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Popover {
			[Export ("isPopover", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPopover);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsPopover);
				}
			}
			
			[Export ("setPopover:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPopover_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetPopover_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual System.Drawing.SizeF Size {
			[Export ("size", ArgumentSemantic.Assign)]
			get {
				System.Drawing.SizeF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend_stret (out ret, this.Handle, selSize);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend (this.Handle, selSize);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selSize);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper (this.SuperHandle, selSize);
					}
				}
				return ret;
			}
			
			[Export ("setSize:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_SizeF (this.Handle, selSetSize_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_SizeF (this.SuperHandle, selSetSize_, value);
				}
			}
		}
		
		[CompilerGenerated]
		internal virtual System.IntPtr PageRef_ {
			[Export ("pageRef", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPageRef);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPageRef);
				}
			}
			
			[Export ("setPageRef:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPageRef_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPageRef_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string DestinationName {
			[Export ("destinationName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDestinationName));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDestinationName));
				}
			}
			
			[Export ("setDestinationName:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDestinationName_, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDestinationName_, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string LinkURL {
			[Export ("linkURL")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLinkURL));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLinkURL));
				}
			}
			
			[Export ("setLinkURL:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLinkURL_, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLinkURL_, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_Url_var = null;
			__mt_Rects_var = null;
			__mt_Options_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFLinkAnnotation */
}
