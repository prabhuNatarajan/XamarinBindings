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
	[Register("PSPDFAESCryptoDataProvider", true)]
	public unsafe partial class PSPDFAESCryptoDataProvider : NSObject {
		[CompilerGenerated]
		const string selIsAESCryptoFeatureAvailable = "isAESCryptoFeatureAvailable";
		static readonly IntPtr selIsAESCryptoFeatureAvailableHandle = Selector.GetHandle ("isAESCryptoFeatureAvailable");
		[CompilerGenerated]
		const string selInitWithURLPassphraseSalt_ = "initWithURL:passphrase:salt:";
		static readonly IntPtr selInitWithURLPassphraseSalt_Handle = Selector.GetHandle ("initWithURL:passphrase:salt:");
		[CompilerGenerated]
		const string selDataProviderRef = "dataProviderRef";
		static readonly IntPtr selDataProviderRefHandle = Selector.GetHandle ("dataProviderRef");
		[CompilerGenerated]
		const string selIsAESCryptoDataProvider_ = "isAESCryptoDataProvider:";
		static readonly IntPtr selIsAESCryptoDataProvider_Handle = Selector.GetHandle ("isAESCryptoDataProvider:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFAESCryptoDataProvider");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFAESCryptoDataProvider () : base (NSObjectFlag.Empty)
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
		public PSPDFAESCryptoDataProvider (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFAESCryptoDataProvider (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFAESCryptoDataProvider (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithURL:passphrase:salt:")]
		[CompilerGenerated]
		public PSPDFAESCryptoDataProvider (NSUrl url, string passphrase, string salt)
			: base (NSObjectFlag.Empty)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (passphrase == null)
				throw new ArgumentNullException ("passphrase");
			if (salt == null)
				throw new ArgumentNullException ("salt");
			var nspassphrase = NSString.CreateNative (passphrase);
			var nssalt = NSString.CreateNative (salt);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selInitWithURLPassphraseSalt_Handle, url.Handle, nspassphrase, nssalt);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selInitWithURLPassphraseSalt_Handle, url.Handle, nspassphrase, nssalt);
			}
			NSString.ReleaseNative (nspassphrase);
			NSString.ReleaseNative (nssalt);
			
		}
		
		[Export ("dataProviderRef")]
		[CompilerGenerated]
		internal virtual global::System.IntPtr DataProviderRef_ ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDataProviderRefHandle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDataProviderRefHandle);
			}
		}
		
		[Export ("isAESCryptoDataProvider:")]
		[CompilerGenerated]
		internal static bool IsAESCryptoDataProvider_ (global::System.IntPtr dataProviderRef)
		{
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (class_ptr, selIsAESCryptoDataProvider_Handle, dataProviderRef);
		}
		
		[CompilerGenerated]
		public static bool IsAESCryptoFeatureAvailable {
			[Export ("isAESCryptoFeatureAvailable")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsAESCryptoFeatureAvailableHandle);
			}
			
		}
		
	} /* class PSPDFAESCryptoDataProvider */
}
