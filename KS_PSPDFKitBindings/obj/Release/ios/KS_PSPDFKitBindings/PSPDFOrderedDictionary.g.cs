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
	[Register("PSPDFOrderedDictionary", true)]
	public unsafe partial class PSPDFOrderedDictionary : NSMutableDictionary {
		[CompilerGenerated]
		const string selKeyArray = "keyArray";
		static readonly IntPtr selKeyArrayHandle = Selector.GetHandle ("keyArray");
		[CompilerGenerated]
		const string selReverseKeyEnumerator = "reverseKeyEnumerator";
		static readonly IntPtr selReverseKeyEnumeratorHandle = Selector.GetHandle ("reverseKeyEnumerator");
		[CompilerGenerated]
		const string selInsertObjectForKeyAtIndex_ = "insertObject:forKey:atIndex:";
		static readonly IntPtr selInsertObjectForKeyAtIndex_Handle = Selector.GetHandle ("insertObject:forKey:atIndex:");
		[CompilerGenerated]
		const string selKeyAtIndex_ = "keyAtIndex:";
		static readonly IntPtr selKeyAtIndex_Handle = Selector.GetHandle ("keyAtIndex:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFOrderedDictionary");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFOrderedDictionary () : base (NSObjectFlag.Empty)
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
		public PSPDFOrderedDictionary (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFOrderedDictionary (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFOrderedDictionary (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("insertObject:forKey:atIndex:")]
		[CompilerGenerated]
		public virtual void InsertObject (NSObject anObject, NSObject aKey, global::System.UInt32 anIndex)
		{
			if (anObject == null)
				throw new ArgumentNullException ("anObject");
			if (aKey == null)
				throw new ArgumentNullException ("aKey");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt32 (this.Handle, selInsertObjectForKeyAtIndex_Handle, anObject.Handle, aKey.Handle, anIndex);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt32 (this.SuperHandle, selInsertObjectForKeyAtIndex_Handle, anObject.Handle, aKey.Handle, anIndex);
			}
			#pragma warning disable 168
			var postget0 = KeyArray;
			#pragma warning restore 168
		}
		
		[Export ("keyAtIndex:")]
		[CompilerGenerated]
		public virtual NSObject KeyAtIndex (global::System.UInt32 anIndex)
		{
			if (IsDirectBinding) {
				return (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selKeyAtIndex_Handle, anIndex));
			} else {
				return (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selKeyAtIndex_Handle, anIndex));
			}
		}
		
		[CompilerGenerated]
		object __mt_KeyArray_var;
		[CompilerGenerated]
		public virtual NSMutableArray KeyArray {
			[Export ("keyArray")]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret = (NSMutableArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selKeyArrayHandle));
				} else {
					ret = (NSMutableArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selKeyArrayHandle));
				}
				MarkDirty ();
				__mt_KeyArray_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ReverseKeyEnumerator_var;
		[CompilerGenerated]
		public virtual NSEnumerator ReverseKeyEnumerator {
			[Export ("reverseKeyEnumerator")]
			get {
				NSEnumerator ret;
				if (IsDirectBinding) {
					ret = (NSEnumerator) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selReverseKeyEnumeratorHandle));
				} else {
					ret = (NSEnumerator) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selReverseKeyEnumeratorHandle));
				}
				MarkDirty ();
				__mt_ReverseKeyEnumerator_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_KeyArray_var = null;
				__mt_ReverseKeyEnumerator_var = null;
			}
		}
	} /* class PSPDFOrderedDictionary */
}
