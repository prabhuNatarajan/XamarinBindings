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
	[Register("PSPDFCache", true)]
	public unsafe partial class PSPDFCache : NSObject {
		[CompilerGenerated]
		const string selSharedCache = "sharedCache";
		static readonly IntPtr selSharedCacheHandle = Selector.GetHandle ("sharedCache");
		[CompilerGenerated]
		const string selDiskCacheStrategy = "diskCacheStrategy";
		static readonly IntPtr selDiskCacheStrategyHandle = Selector.GetHandle ("diskCacheStrategy");
		[CompilerGenerated]
		const string selSetDiskCacheStrategy_ = "setDiskCacheStrategy:";
		static readonly IntPtr selSetDiskCacheStrategy_Handle = Selector.GetHandle ("setDiskCacheStrategy:");
		[CompilerGenerated]
		const string selCacheDirectory = "cacheDirectory";
		static readonly IntPtr selCacheDirectoryHandle = Selector.GetHandle ("cacheDirectory");
		[CompilerGenerated]
		const string selSetCacheDirectory_ = "setCacheDirectory:";
		static readonly IntPtr selSetCacheDirectory_Handle = Selector.GetHandle ("setCacheDirectory:");
		[CompilerGenerated]
		const string selStopCachingDocument_ = "stopCachingDocument:";
		static readonly IntPtr selStopCachingDocument_Handle = Selector.GetHandle ("stopCachingDocument:");
		[CompilerGenerated]
		const string selClearCache = "clearCache";
		static readonly IntPtr selClearCacheHandle = Selector.GetHandle ("clearCache");
		[CompilerGenerated]
		const string selPrintStatus = "printStatus";
		static readonly IntPtr selPrintStatusHandle = Selector.GetHandle ("printStatus");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFCache");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFCache () : base (NSObjectFlag.Empty)
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
		public PSPDFCache (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFCache (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFCache (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("stopCachingDocument:")]
		[CompilerGenerated]
		public virtual void StopCachingDocument (PSPDFDocument document)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selStopCachingDocument_Handle, document.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selStopCachingDocument_Handle, document.Handle);
			}
		}
		
		[Export ("clearCache")]
		[CompilerGenerated]
		public virtual bool ClearCache ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selClearCacheHandle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selClearCacheHandle);
			}
		}
		
		[CompilerGenerated]
		public void PrintStatus ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPrintStatusHandle);
		}
		
		[CompilerGenerated]
		static object __mt_SharedCache_var_static;
		[CompilerGenerated]
		public static PSPDFCache SharedCache {
			[Export ("sharedCache")]
			get {
				PSPDFCache ret;
				ret = (PSPDFCache) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selSharedCacheHandle));
				__mt_SharedCache_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFDiskCacheStrategy Strategy {
			[Export ("diskCacheStrategy", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFDiskCacheStrategy) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selDiskCacheStrategyHandle);
				} else {
					return (PSPDFDiskCacheStrategy) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selDiskCacheStrategyHandle);
				}
			}
			
			[Export ("setDiskCacheStrategy:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetDiskCacheStrategy_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetDiskCacheStrategy_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string CacheDirectory {
			[Export ("cacheDirectory", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCacheDirectoryHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCacheDirectoryHandle));
				}
			}
			
			[Export ("setCacheDirectory:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCacheDirectory_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCacheDirectory_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
	} /* class PSPDFCache */
}
