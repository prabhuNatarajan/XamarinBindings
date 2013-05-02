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
	[Register("PSPDFXRefEntry", true)]
	public unsafe partial class PSPDFXRefEntry : NSObject {
		[CompilerGenerated]
		const string selObjectNumber = "objectNumber";
		static readonly IntPtr selObjectNumberHandle = Selector.GetHandle ("objectNumber");
		[CompilerGenerated]
		const string selSetObjectNumber_ = "setObjectNumber:";
		static readonly IntPtr selSetObjectNumber_Handle = Selector.GetHandle ("setObjectNumber:");
		[CompilerGenerated]
		const string selByteOffset = "byteOffset";
		static readonly IntPtr selByteOffsetHandle = Selector.GetHandle ("byteOffset");
		[CompilerGenerated]
		const string selSetByteOffset_ = "setByteOffset:";
		static readonly IntPtr selSetByteOffset_Handle = Selector.GetHandle ("setByteOffset:");
		[CompilerGenerated]
		const string selIsCompressed = "isCompressed";
		static readonly IntPtr selIsCompressedHandle = Selector.GetHandle ("isCompressed");
		[CompilerGenerated]
		const string selSetIsCompressed_ = "setIsCompressed:";
		static readonly IntPtr selSetIsCompressed_Handle = Selector.GetHandle ("setIsCompressed:");
		[CompilerGenerated]
		const string selObjectStreamNumber = "objectStreamNumber";
		static readonly IntPtr selObjectStreamNumberHandle = Selector.GetHandle ("objectStreamNumber");
		[CompilerGenerated]
		const string selSetObjectStreamNumber_ = "setObjectStreamNumber:";
		static readonly IntPtr selSetObjectStreamNumber_Handle = Selector.GetHandle ("setObjectStreamNumber:");
		[CompilerGenerated]
		const string selIsDeleted = "isDeleted";
		static readonly IntPtr selIsDeletedHandle = Selector.GetHandle ("isDeleted");
		[CompilerGenerated]
		const string selSetIsDeleted_ = "setIsDeleted:";
		static readonly IntPtr selSetIsDeleted_Handle = Selector.GetHandle ("setIsDeleted:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFXRefEntry");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFXRefEntry () : base (NSObjectFlag.Empty)
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
		public PSPDFXRefEntry (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFXRefEntry (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFXRefEntry (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual int ObjectNumber {
			[Export ("objectNumber", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selObjectNumberHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selObjectNumberHandle);
				}
			}
			
			[Export ("setObjectNumber:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetObjectNumber_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetObjectNumber_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Int64 ByteOffset {
			[Export ("byteOffset", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.Int64_objc_msgSend (this.Handle, selByteOffsetHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, selByteOffsetHandle);
				}
			}
			
			[Export ("setByteOffset:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_Int64 (this.Handle, selSetByteOffset_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, selSetByteOffset_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsCompressed {
			[Export ("isCompressed", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsCompressedHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsCompressedHandle);
				}
			}
			
			[Export ("setIsCompressed:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsCompressed_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIsCompressed_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int ObjectStreamNumber {
			[Export ("objectStreamNumber", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selObjectStreamNumberHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selObjectStreamNumberHandle);
				}
			}
			
			[Export ("setObjectStreamNumber:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetObjectStreamNumber_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetObjectStreamNumber_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsDeleted {
			[Export ("isDeleted", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDeletedHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsDeletedHandle);
				}
			}
			
			[Export ("setIsDeleted:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsDeleted_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIsDeleted_Handle, value);
				}
			}
		}
		
	} /* class PSPDFXRefEntry */
}
