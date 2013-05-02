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
	[Register("PSPDFGradientView", true)]
	public unsafe partial class PSPDFGradientView : global::MonoTouch.UIKit.UIView {
		[CompilerGenerated]
		const string selDirection = "direction";
		static readonly IntPtr selDirectionHandle = Selector.GetHandle ("direction");
		[CompilerGenerated]
		const string selSetDirection_ = "setDirection:";
		static readonly IntPtr selSetDirection_Handle = Selector.GetHandle ("setDirection:");
		[CompilerGenerated]
		const string selColors = "colors";
		static readonly IntPtr selColorsHandle = Selector.GetHandle ("colors");
		[CompilerGenerated]
		const string selSetColors_ = "setColors:";
		static readonly IntPtr selSetColors_Handle = Selector.GetHandle ("setColors:");
		[CompilerGenerated]
		const string selLocations = "locations";
		static readonly IntPtr selLocationsHandle = Selector.GetHandle ("locations");
		[CompilerGenerated]
		const string selSetLocations_ = "setLocations:";
		static readonly IntPtr selSetLocations_Handle = Selector.GetHandle ("setLocations:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFGradientView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFGradientView () : base (NSObjectFlag.Empty)
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
		public PSPDFGradientView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFGradientView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFGradientView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual PSPDFGradientViewDirection Direction {
			[Export ("direction", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFGradientViewDirection) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selDirectionHandle);
				} else {
					return (PSPDFGradientViewDirection) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selDirectionHandle);
				}
			}
			
			[Export ("setDirection:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetDirection_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetDirection_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Colors_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor[] Colors {
			[Export ("colors", ArgumentSemantic.Copy)]
			get {
				global::MonoTouch.UIKit.UIColor[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.UIKit.UIColor>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selColorsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.UIKit.UIColor>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selColorsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Colors_var = ret;
				return ret;
			}
			
			[Export ("setColors:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetColors_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetColors_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_Colors_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Locations_var;
		[CompilerGenerated]
		public virtual NSNumber[] Locations {
			[Export ("locations", ArgumentSemantic.Copy)]
			get {
				NSNumber[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSNumber>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLocationsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSNumber>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLocationsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Locations_var = ret;
				return ret;
			}
			
			[Export ("setLocations:", ArgumentSemantic.Copy)]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLocations_Handle, nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLocations_Handle, nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_Locations_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Colors_var = null;
				__mt_Locations_var = null;
			}
		}
	} /* class PSPDFGradientView */
}
