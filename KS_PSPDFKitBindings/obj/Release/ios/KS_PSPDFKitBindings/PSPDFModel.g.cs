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
	[Register("PSPDFModel", true)]
	public unsafe partial class PSPDFModel : NSObject {
		[CompilerGenerated]
		const string selDictionaryValue = "dictionaryValue";
		static readonly IntPtr selDictionaryValueHandle = Selector.GetHandle ("dictionaryValue");
		[CompilerGenerated]
		const string selModelVersion = "modelVersion";
		static readonly IntPtr selModelVersionHandle = Selector.GetHandle ("modelVersion");
		[CompilerGenerated]
		const string selHash = "hash";
		static readonly IntPtr selHashHandle = Selector.GetHandle ("hash");
		[CompilerGenerated]
		const string selModelWithDictionary_ = "modelWithDictionary:";
		static readonly IntPtr selModelWithDictionary_Handle = Selector.GetHandle ("modelWithDictionary:");
		[CompilerGenerated]
		const string selModelWithExternalRepresentationInFormat_ = "modelWithExternalRepresentation:inFormat:";
		static readonly IntPtr selModelWithExternalRepresentationInFormat_Handle = Selector.GetHandle ("modelWithExternalRepresentation:inFormat:");
		[CompilerGenerated]
		const string selInitWithDictionary_ = "initWithDictionary:";
		static readonly IntPtr selInitWithDictionary_Handle = Selector.GetHandle ("initWithDictionary:");
		[CompilerGenerated]
		const string selInitWithExternalRepresentationInFormat_ = "initWithExternalRepresentation:inFormat:";
		static readonly IntPtr selInitWithExternalRepresentationInFormat_Handle = Selector.GetHandle ("initWithExternalRepresentation:inFormat:");
		[CompilerGenerated]
		const string selDidLoadModelInstance = "didLoadModelInstance";
		static readonly IntPtr selDidLoadModelInstanceHandle = Selector.GetHandle ("didLoadModelInstance");
		[CompilerGenerated]
		const string selEncodeWithCoder_ = "encodeWithCoder:";
		static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle ("encodeWithCoder:");
		[CompilerGenerated]
		const string selKeyPathsByPropertyKeyForExternalRepresentationFormat_ = "keyPathsByPropertyKeyForExternalRepresentationFormat:";
		static readonly IntPtr selKeyPathsByPropertyKeyForExternalRepresentationFormat_Handle = Selector.GetHandle ("keyPathsByPropertyKeyForExternalRepresentationFormat:");
		[CompilerGenerated]
		const string selExternalRepresentationInFormat_ = "externalRepresentationInFormat:";
		static readonly IntPtr selExternalRepresentationInFormat_Handle = Selector.GetHandle ("externalRepresentationInFormat:");
		[CompilerGenerated]
		const string selMigrateExternalRepresentationInFormatFromVersion_ = "migrateExternalRepresentation:inFormat:fromVersion:";
		static readonly IntPtr selMigrateExternalRepresentationInFormatFromVersion_Handle = Selector.GetHandle ("migrateExternalRepresentation:inFormat:fromVersion:");
		[CompilerGenerated]
		const string selMergeValueForKeyFromModel_ = "mergeValueForKey:fromModel:";
		static readonly IntPtr selMergeValueForKeyFromModel_Handle = Selector.GetHandle ("mergeValueForKey:fromModel:");
		[CompilerGenerated]
		const string selMergeValuesForKeysFromModel_ = "mergeValuesForKeysFromModel:";
		static readonly IntPtr selMergeValuesForKeysFromModel_Handle = Selector.GetHandle ("mergeValuesForKeysFromModel:");
		[CompilerGenerated]
		const string selIsEqual_ = "isEqual:";
		static readonly IntPtr selIsEqual_Handle = Selector.GetHandle ("isEqual:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFModel");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFModel () : base (NSObjectFlag.Empty)
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
		public PSPDFModel (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFModel (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFModel (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("modelWithDictionary:")]
		[CompilerGenerated]
		public static PSPDFModel ModelWithDictionary (NSDictionary dictionaryValue)
		{
			return (PSPDFModel) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selModelWithDictionary_Handle, dictionaryValue == null ? IntPtr.Zero : dictionaryValue.Handle));
		}
		
		[Export ("modelWithExternalRepresentation:inFormat:")]
		[CompilerGenerated]
		public static PSPDFModel ModelWithExternalRepresentation (NSObject externalRepresentation, string externalRepresentationFormat)
		{
			if (externalRepresentation == null)
				throw new ArgumentNullException ("externalRepresentation");
			if (externalRepresentationFormat == null)
				throw new ArgumentNullException ("externalRepresentationFormat");
			var nsexternalRepresentationFormat = NSString.CreateNative (externalRepresentationFormat);
			
			PSPDFModel ret;
			ret = (PSPDFModel) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selModelWithExternalRepresentationInFormat_Handle, externalRepresentation.Handle, nsexternalRepresentationFormat));
			NSString.ReleaseNative (nsexternalRepresentationFormat);
			
			return ret;
		}
		
		[Export ("initWithDictionary:")]
		[CompilerGenerated]
		public PSPDFModel (NSDictionary dictionaryValue)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithDictionary_Handle, dictionaryValue == null ? IntPtr.Zero : dictionaryValue.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithDictionary_Handle, dictionaryValue == null ? IntPtr.Zero : dictionaryValue.Handle);
			}
		}
		
		[Export ("initWithExternalRepresentation:inFormat:")]
		[CompilerGenerated]
		public PSPDFModel (NSObject externalRepresentation, string externalRepresentationFormat)
			: base (NSObjectFlag.Empty)
		{
			if (externalRepresentation == null)
				throw new ArgumentNullException ("externalRepresentation");
			if (externalRepresentationFormat == null)
				throw new ArgumentNullException ("externalRepresentationFormat");
			var nsexternalRepresentationFormat = NSString.CreateNative (externalRepresentationFormat);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithExternalRepresentationInFormat_Handle, externalRepresentation.Handle, nsexternalRepresentationFormat);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithExternalRepresentationInFormat_Handle, externalRepresentation.Handle, nsexternalRepresentationFormat);
			}
			NSString.ReleaseNative (nsexternalRepresentationFormat);
			
		}
		
		[Export ("didLoadModelInstance")]
		[CompilerGenerated]
		public virtual void DidLoadModelInstance ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDidLoadModelInstanceHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selDidLoadModelInstanceHandle);
			}
		}
		
		[Export ("encodeWithCoder:")]
		[CompilerGenerated]
		public virtual void EncodeWithCoder (NSCoder coder)
		{
			if (coder == null)
				throw new ArgumentNullException ("coder");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selEncodeWithCoder_Handle, coder.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selEncodeWithCoder_Handle, coder.Handle);
			}
		}
		
		[Export ("keyPathsByPropertyKeyForExternalRepresentationFormat:")]
		[CompilerGenerated]
		public static NSDictionary KeyPathsByPropertyKeyForExternalRepresentationFormat (string externalRepresentationFormat)
		{
			if (externalRepresentationFormat == null)
				throw new ArgumentNullException ("externalRepresentationFormat");
			var nsexternalRepresentationFormat = NSString.CreateNative (externalRepresentationFormat);
			
			NSDictionary ret;
			ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selKeyPathsByPropertyKeyForExternalRepresentationFormat_Handle, nsexternalRepresentationFormat));
			NSString.ReleaseNative (nsexternalRepresentationFormat);
			
			return ret;
		}
		
		[Export ("externalRepresentationInFormat:")]
		[CompilerGenerated]
		public virtual NSObject externalRepresentationInFormat (string externalRepresentationFormat)
		{
			if (externalRepresentationFormat == null)
				throw new ArgumentNullException ("externalRepresentationFormat");
			var nsexternalRepresentationFormat = NSString.CreateNative (externalRepresentationFormat);
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selExternalRepresentationInFormat_Handle, nsexternalRepresentationFormat));
			} else {
				ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selExternalRepresentationInFormat_Handle, nsexternalRepresentationFormat));
			}
			NSString.ReleaseNative (nsexternalRepresentationFormat);
			
			return ret;
		}
		
		[Export ("migrateExternalRepresentation:inFormat:fromVersion:")]
		[CompilerGenerated]
		public static NSDictionary MigrateExternalRepresentation (NSObject externalRepresentation, string externalRepresentationFormat, global::System.UInt32 fromVersion)
		{
			if (externalRepresentation == null)
				throw new ArgumentNullException ("externalRepresentation");
			if (externalRepresentationFormat == null)
				throw new ArgumentNullException ("externalRepresentationFormat");
			var nsexternalRepresentationFormat = NSString.CreateNative (externalRepresentationFormat);
			
			NSDictionary ret;
			ret = (NSDictionary) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt32 (class_ptr, selMigrateExternalRepresentationInFormatFromVersion_Handle, externalRepresentation.Handle, nsexternalRepresentationFormat, fromVersion));
			NSString.ReleaseNative (nsexternalRepresentationFormat);
			
			return ret;
		}
		
		[Export ("mergeValueForKey:fromModel:")]
		[CompilerGenerated]
		public virtual void MergeValueForKey (string key, PSPDFModel model)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			if (model == null)
				throw new ArgumentNullException ("model");
			var nskey = NSString.CreateNative (key);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selMergeValueForKeyFromModel_Handle, nskey, model.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selMergeValueForKeyFromModel_Handle, nskey, model.Handle);
			}
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("mergeValuesForKeysFromModel:")]
		[CompilerGenerated]
		public virtual void MergeValuesForKeysFromModel (PSPDFModel model)
		{
			if (model == null)
				throw new ArgumentNullException ("model");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selMergeValuesForKeysFromModel_Handle, model.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selMergeValuesForKeysFromModel_Handle, model.Handle);
			}
		}
		
		[Export ("isEqual:")]
		[CompilerGenerated]
		public virtual bool IsEqual (PSPDFModel model)
		{
			if (model == null)
				throw new ArgumentNullException ("model");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsEqual_Handle, model.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selIsEqual_Handle, model.Handle);
			}
		}
		
		[CompilerGenerated]
		object __mt_DictionaryValue_var;
		[CompilerGenerated]
		public virtual NSDictionary DictionaryValue {
			[Export ("dictionaryValue", ArgumentSemantic.Copy)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDictionaryValueHandle));
				} else {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDictionaryValueHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DictionaryValue_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static global::System.UInt32 ModelVersion {
			[Export ("modelVersion")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (class_ptr, selModelVersionHandle);
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 Hash {
			[Export ("hash")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selHashHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selHashHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		static readonly IntPtr __Internal_libraryHandle = Dlfcn.dlopen (null, 0);
		[CompilerGenerated]
		static NSString _PSPDFModelKeyedArchiveFormat;
		public static NSString PSPDFModelKeyedArchiveFormat {
			get {
				if (_PSPDFModelKeyedArchiveFormat == null)
					_PSPDFModelKeyedArchiveFormat = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSPDFModelKeyedArchiveFormat");
				return _PSPDFModelKeyedArchiveFormat;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFModelJSONFormat;
		public static NSString PSPDFModelJSONFormat {
			get {
				if (_PSPDFModelJSONFormat == null)
					_PSPDFModelJSONFormat = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSPDFModelJSONFormat");
				return _PSPDFModelJSONFormat;
			}
		}
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_DictionaryValue_var = null;
			}
		}
	} /* class PSPDFModel */
}
