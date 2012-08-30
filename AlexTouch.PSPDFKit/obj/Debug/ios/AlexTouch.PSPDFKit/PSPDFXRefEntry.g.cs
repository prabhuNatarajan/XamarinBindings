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
	[Register("PSPDFXRefEntry", true)]
	public unsafe partial class PSPDFXRefEntry : NSObject {
		static readonly IntPtr selObjectNumber = Selector.GetHandle ("objectNumber");
		static readonly IntPtr selSetObjectNumber_ = Selector.GetHandle ("setObjectNumber:");
		static readonly IntPtr selByteOffset = Selector.GetHandle ("byteOffset");
		static readonly IntPtr selSetByteOffset_ = Selector.GetHandle ("setByteOffset:");
		static readonly IntPtr selIsCompressed = Selector.GetHandle ("isCompressed");
		static readonly IntPtr selSetIsCompressed_ = Selector.GetHandle ("setIsCompressed:");
		static readonly IntPtr selObjectStreamNumber = Selector.GetHandle ("objectStreamNumber");
		static readonly IntPtr selSetObjectStreamNumber_ = Selector.GetHandle ("setObjectStreamNumber:");
		static readonly IntPtr selIsDeleted = Selector.GetHandle ("isDeleted");
		static readonly IntPtr selSetIsDeleted_ = Selector.GetHandle ("setIsDeleted:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFXRefEntry");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFXRefEntry () : base (NSObjectFlag.Empty)
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
		public PSPDFXRefEntry (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFXRefEntry (IntPtr handle) : base (handle) {}

		[CompilerGenerated]
		public virtual int ObjectNumber {
			[Export ("objectNumber", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selObjectNumber);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selObjectNumber);
				}
			}
			
			[Export ("setObjectNumber:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetObjectNumber_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetObjectNumber_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual System.Int64 ByteOffset {
			[Export ("byteOffset", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.Int64_objc_msgSend (this.Handle, selByteOffset);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, selByteOffset);
				}
			}
			
			[Export ("setByteOffset:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_Int64 (this.Handle, selSetByteOffset_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, selSetByteOffset_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsCompressed {
			[Export ("isCompressed", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsCompressed);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsCompressed);
				}
			}
			
			[Export ("setIsCompressed:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsCompressed_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIsCompressed_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int ObjectStreamNumber {
			[Export ("objectStreamNumber", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selObjectStreamNumber);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selObjectStreamNumber);
				}
			}
			
			[Export ("setObjectStreamNumber:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetObjectStreamNumber_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetObjectStreamNumber_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsDeleted {
			[Export ("isDeleted", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDeleted);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsDeleted);
				}
			}
			
			[Export ("setIsDeleted:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsDeleted_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIsDeleted_, value);
				}
			}
		}
		
	} /* class PSPDFXRefEntry */
}
