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
	[Register("PSPDFInkAnnotation", true)]
	public unsafe partial class PSPDFInkAnnotation : PSPDFAnnotation {
		static readonly IntPtr selLines = Selector.GetHandle ("lines");
		static readonly IntPtr selSetLines_ = Selector.GetHandle ("setLines:");
		static readonly IntPtr selPaths = Selector.GetHandle ("paths");
		static readonly IntPtr selSetPaths_ = Selector.GetHandle ("setPaths:");
		static readonly IntPtr selInitWithAnnotationDictionaryInAnnotsArray_ = Selector.GetHandle ("initWithAnnotationDictionary:inAnnotsArray:");
		static readonly IntPtr selRebuildPaths = Selector.GetHandle ("rebuildPaths");
		static readonly IntPtr selClearAllData = Selector.GetHandle ("clearAllData");
		static readonly IntPtr selClearCachedPaths = Selector.GetHandle ("clearCachedPaths");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFInkAnnotation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFInkAnnotation () : base (NSObjectFlag.Empty)
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
		public PSPDFInkAnnotation (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFInkAnnotation (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFInkAnnotation (IntPtr handle) : base (handle) {}

		[Export ("initWithAnnotationDictionary:inAnnotsArray:")]
		[CompilerGenerated]
		internal PSPDFInkAnnotation (System.IntPtr annotDict, System.IntPtr annotsArray) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithAnnotationDictionaryInAnnotsArray_, annotDict, annotsArray);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithAnnotationDictionaryInAnnotsArray_, annotDict, annotsArray);
			}
		}
		
		[Export ("rebuildPaths")]
		[CompilerGenerated]
		public virtual void RebuildPaths ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRebuildPaths);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selRebuildPaths);
			}
		}
		
		[Export ("clearAllData")]
		[CompilerGenerated]
		public virtual void ClearAllData ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selClearAllData);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selClearAllData);
			}
		}
		
		[Export ("clearCachedPaths")]
		[CompilerGenerated]
		public virtual void ClearCachedPaths ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selClearCachedPaths);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selClearCachedPaths);
			}
		}
		
		object __mt_Lines_var;
		[CompilerGenerated]
		public virtual NSArray Lines {
			[Export ("lines")]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLines));
				} else {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLines));
				}
				MarkDirty ();
				__mt_Lines_var = ret;
				return ret;
			}
			
			[Export ("setLines:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLines_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLines_, value.Handle);
				}
				MarkDirty ();
				__mt_Lines_var = value;
			}
		}
		
		object __mt_Paths_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIBezierPath[] Paths {
			[Export ("paths")]
			get {
				MonoTouch.UIKit.UIBezierPath[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.UIKit.UIBezierPath>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPaths));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.UIKit.UIBezierPath>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPaths));
				}
				MarkDirty ();
				__mt_Paths_var = ret;
				return ret;
			}
			
			[Export ("setPaths:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPaths_, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPaths_, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				MarkDirty ();
				__mt_Paths_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_Lines_var = null;
			__mt_Paths_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFInkAnnotation */
}
