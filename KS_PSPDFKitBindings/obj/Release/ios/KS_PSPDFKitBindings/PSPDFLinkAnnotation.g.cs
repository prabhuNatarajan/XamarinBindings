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
	[Register("PSPDFLinkAnnotation", true)]
	public unsafe partial class PSPDFLinkAnnotation : PSPDFAnnotation {
		[CompilerGenerated]
		const string selAction = "action";
		static readonly IntPtr selActionHandle = Selector.GetHandle ("action");
		[CompilerGenerated]
		const string selSetAction_ = "setAction:";
		static readonly IntPtr selSetAction_Handle = Selector.GetHandle ("setAction:");
		[CompilerGenerated]
		const string selLinkType = "linkType";
		static readonly IntPtr selLinkTypeHandle = Selector.GetHandle ("linkType");
		[CompilerGenerated]
		const string selSetLinkType_ = "setLinkType:";
		static readonly IntPtr selSetLinkType_Handle = Selector.GetHandle ("setLinkType:");
		[CompilerGenerated]
		const string selShowAsLinkView = "showAsLinkView";
		static readonly IntPtr selShowAsLinkViewHandle = Selector.GetHandle ("showAsLinkView");
		[CompilerGenerated]
		const string selIsMultimediaExtension = "isMultimediaExtension";
		static readonly IntPtr selIsMultimediaExtensionHandle = Selector.GetHandle ("isMultimediaExtension");
		[CompilerGenerated]
		const string selSiteLinkTarget = "siteLinkTarget";
		static readonly IntPtr selSiteLinkTargetHandle = Selector.GetHandle ("siteLinkTarget");
		[CompilerGenerated]
		const string selSetSiteLinkTarget_ = "setSiteLinkTarget:";
		static readonly IntPtr selSetSiteLinkTarget_Handle = Selector.GetHandle ("setSiteLinkTarget:");
		[CompilerGenerated]
		const string selURL = "URL";
		static readonly IntPtr selURLHandle = Selector.GetHandle ("URL");
		[CompilerGenerated]
		const string selSetURL_ = "setURL:";
		static readonly IntPtr selSetURL_Handle = Selector.GetHandle ("setURL:");
		[CompilerGenerated]
		const string selTargetString = "targetString";
		static readonly IntPtr selTargetStringHandle = Selector.GetHandle ("targetString");
		[CompilerGenerated]
		const string selControlsEnabled = "controlsEnabled";
		static readonly IntPtr selControlsEnabledHandle = Selector.GetHandle ("controlsEnabled");
		[CompilerGenerated]
		const string selSetControlsEnabled_ = "setControlsEnabled:";
		static readonly IntPtr selSetControlsEnabled_Handle = Selector.GetHandle ("setControlsEnabled:");
		[CompilerGenerated]
		const string selIsAutoplayEnabled = "isAutoplayEnabled";
		static readonly IntPtr selIsAutoplayEnabledHandle = Selector.GetHandle ("isAutoplayEnabled");
		[CompilerGenerated]
		const string selSetAutoplayEnabled_ = "setAutoplayEnabled:";
		static readonly IntPtr selSetAutoplayEnabled_Handle = Selector.GetHandle ("setAutoplayEnabled:");
		[CompilerGenerated]
		const string selInitWithURL_ = "initWithURL:";
		static readonly IntPtr selInitWithURL_Handle = Selector.GetHandle ("initWithURL:");
		[CompilerGenerated]
		const string selInitWithURLString_ = "initWithURLString:";
		static readonly IntPtr selInitWithURLString_Handle = Selector.GetHandle ("initWithURLString:");
		[CompilerGenerated]
		const string selInitWithPage_ = "initWithPage:";
		static readonly IntPtr selInitWithPage_Handle = Selector.GetHandle ("initWithPage:");
		[CompilerGenerated]
		const string selURLAction = "URLAction";
		static readonly IntPtr selURLActionHandle = Selector.GetHandle ("URLAction");
		[CompilerGenerated]
		const string selInitWithLinkAnnotationType_ = "initWithLinkAnnotationType:";
		static readonly IntPtr selInitWithLinkAnnotationType_Handle = Selector.GetHandle ("initWithLinkAnnotationType:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFLinkAnnotation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFLinkAnnotation () : base (NSObjectFlag.Empty)
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
		public PSPDFLinkAnnotation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFLinkAnnotation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithURL:")]
		[CompilerGenerated]
		public PSPDFLinkAnnotation (NSUrl url)
			: base (NSObjectFlag.Empty)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithURL_Handle, url.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithURL_Handle, url.Handle);
			}
		}
		
		[Export ("initWithURLString:")]
		[CompilerGenerated]
		public PSPDFLinkAnnotation (string urlString)
			: base (NSObjectFlag.Empty)
		{
			if (urlString == null)
				throw new ArgumentNullException ("urlString");
			var nsurlString = NSString.CreateNative (urlString);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithURLString_Handle, nsurlString);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithURLString_Handle, nsurlString);
			}
			NSString.ReleaseNative (nsurlString);
			
		}
		
		[Export ("initWithPage:")]
		[CompilerGenerated]
		public PSPDFLinkAnnotation (global::System.UInt32 page)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selInitWithPage_Handle, page);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selInitWithPage_Handle, page);
			}
		}
		
		[Export ("URLAction")]
		[CompilerGenerated]
		public virtual global::System.IntPtr UrlAction ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selURLActionHandle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selURLActionHandle);
			}
		}
		
		[Export ("initWithLinkAnnotationType:")]
		[CompilerGenerated]
		public PSPDFLinkAnnotation (PSPDFLinkAnnotationType linkAnotationType)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int (this.Handle, selInitWithLinkAnnotationType_Handle, (int)linkAnotationType);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, selInitWithLinkAnnotationType_Handle, (int)linkAnotationType);
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.IntPtr Action {
			[Export ("action")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selActionHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selActionHandle);
				}
			}
			
			[Export ("setAction:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAction_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAction_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFLinkAnnotationType LinkType {
			[Export ("linkType", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFLinkAnnotationType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selLinkTypeHandle);
				} else {
					return (PSPDFLinkAnnotationType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selLinkTypeHandle);
				}
			}
			
			[Export ("setLinkType:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetLinkType_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetLinkType_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowAsLinkView {
			[Export ("showAsLinkView", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowAsLinkViewHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShowAsLinkViewHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool MultimediaExtension {
			[Export ("isMultimediaExtension", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsMultimediaExtensionHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsMultimediaExtensionHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string SiteLinkTarget {
			[Export ("siteLinkTarget", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSiteLinkTargetHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSiteLinkTargetHandle));
				}
			}
			
			[Export ("setSiteLinkTarget:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSiteLinkTarget_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSiteLinkTarget_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_Url_var;
		[CompilerGenerated]
		public virtual NSUrl Url {
			[Export ("URL")]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selURLHandle));
				} else {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selURLHandle));
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
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetURL_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetURL_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Url_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string TargetString {
			[Export ("targetString")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTargetStringHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTargetStringHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ControlsEnabled {
			[Export ("controlsEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selControlsEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selControlsEnabledHandle);
				}
			}
			
			[Export ("setControlsEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetControlsEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetControlsEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AutoplayEnabled {
			[Export ("isAutoplayEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAutoplayEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsAutoplayEnabledHandle);
				}
			}
			
			[Export ("setAutoplayEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutoplayEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAutoplayEnabled_Handle, value);
				}
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Url_var = null;
			}
		}
	} /* class PSPDFLinkAnnotation */
}
