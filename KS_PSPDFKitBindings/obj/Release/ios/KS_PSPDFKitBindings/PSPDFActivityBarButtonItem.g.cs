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
	[Register("PSPDFActivityBarButtonItem", true)]
	public unsafe partial class PSPDFActivityBarButtonItem : PSPDFBarButtonItem {
		[CompilerGenerated]
		const string selApplicationActivities = "applicationActivities";
		static readonly IntPtr selApplicationActivitiesHandle = Selector.GetHandle ("applicationActivities");
		[CompilerGenerated]
		const string selSetApplicationActivities_ = "setApplicationActivities:";
		static readonly IntPtr selSetApplicationActivities_Handle = Selector.GetHandle ("setApplicationActivities:");
		[CompilerGenerated]
		const string selExcludedActivityTypes = "excludedActivityTypes";
		static readonly IntPtr selExcludedActivityTypesHandle = Selector.GetHandle ("excludedActivityTypes");
		[CompilerGenerated]
		const string selSetExcludedActivityTypes_ = "setExcludedActivityTypes:";
		static readonly IntPtr selSetExcludedActivityTypes_Handle = Selector.GetHandle ("setExcludedActivityTypes:");
		[CompilerGenerated]
		const string selActivityController = "activityController";
		static readonly IntPtr selActivityControllerHandle = Selector.GetHandle ("activityController");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFActivityBarButtonItem");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFActivityBarButtonItem () : base (NSObjectFlag.Empty)
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
		public PSPDFActivityBarButtonItem (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFActivityBarButtonItem (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFActivityBarButtonItem (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_ApplicationActivities_var;
		[CompilerGenerated]
		public virtual NSString[] ApplicationActivities {
			[Export ("applicationActivities", ArgumentSemantic.Copy)]
			get {
				NSString[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSString>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selApplicationActivitiesHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSString>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selApplicationActivitiesHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ApplicationActivities_var = ret;
				return ret;
			}
			
			[Export ("setApplicationActivities:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetApplicationActivities_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetApplicationActivities_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_ApplicationActivities_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_ExcludedActivityTypes_var;
		[CompilerGenerated]
		public virtual NSString[] ExcludedActivityTypes {
			[Export ("excludedActivityTypes", ArgumentSemantic.Copy)]
			get {
				NSString[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSString>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selExcludedActivityTypesHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSString>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selExcludedActivityTypesHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ExcludedActivityTypes_var = ret;
				return ret;
			}
			
			[Export ("setExcludedActivityTypes:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetExcludedActivityTypes_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetExcludedActivityTypes_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_ExcludedActivityTypes_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_ActivityController_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIActivityViewController ActivityController {
			[Export ("activityController")]
			get {
				global::MonoTouch.UIKit.UIActivityViewController ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIActivityViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selActivityControllerHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIActivityViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selActivityControllerHandle));
				}
				MarkDirty ();
				__mt_ActivityController_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ApplicationActivities_var = null;
				__mt_ExcludedActivityTypes_var = null;
				__mt_ActivityController_var = null;
			}
		}
	} /* class PSPDFActivityBarButtonItem */
}
