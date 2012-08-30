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
	[Register("PSPDFWord", true)]
	public unsafe partial class PSPDFWord : NSObject {
		static readonly IntPtr selFrame = Selector.GetHandle ("frame");
		static readonly IntPtr selSetFrame_ = Selector.GetHandle ("setFrame:");
		static readonly IntPtr selGlyphs = Selector.GetHandle ("glyphs");
		static readonly IntPtr selSetGlyphs_ = Selector.GetHandle ("setGlyphs:");
		static readonly IntPtr selStringValue = Selector.GetHandle ("stringValue");
		static readonly IntPtr selInitWithGlyphs_ = Selector.GetHandle ("initWithGlyphs:");
		static readonly IntPtr selInitWithFrame_ = Selector.GetHandle ("initWithFrame:");
		static readonly IntPtr selIsOnSameLineAs_ = Selector.GetHandle ("isOnSameLineAs:");
		static readonly IntPtr selCompareByLayout_ = Selector.GetHandle ("compareByLayout:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFWord");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFWord () : base (NSObjectFlag.Empty)
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
		public PSPDFWord (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFWord (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFWord (IntPtr handle) : base (handle) {}

		[Export ("initWithGlyphs:")]
		[CompilerGenerated]
		public PSPDFWord (PSPDFGlyph[] wordGlyphs) : base (NSObjectFlag.Empty)
		{
			if (wordGlyphs == null)
				throw new ArgumentNullException ("wordGlyphs");
			var nsa_wordGlyphs = NSArray.FromNSObjects (wordGlyphs);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithGlyphs_, nsa_wordGlyphs.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithGlyphs_, nsa_wordGlyphs.Handle);
			}
			nsa_wordGlyphs.Dispose ();
			
		}
		
		[Export ("initWithFrame:")]
		[CompilerGenerated]
		public PSPDFWord (System.Drawing.RectangleF wordFrame) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_RectangleF (this.Handle, selInitWithFrame_, wordFrame);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_RectangleF (this.SuperHandle, selInitWithFrame_, wordFrame);
			}
		}
		
		[Export ("stringValue")]
		[CompilerGenerated]
		public virtual string StringValue ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStringValue));
			} else {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selStringValue));
			}
		}
		
		[Export ("isOnSameLineAs:")]
		[CompilerGenerated]
		public virtual bool IsOnSameLineAs (PSPDFWord word)
		{
			if (word == null)
				throw new ArgumentNullException ("word");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsOnSameLineAs_, word.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selIsOnSameLineAs_, word.Handle);
			}
		}
		
		[Export ("compareByLayout:")]
		[CompilerGenerated]
		public virtual NSComparisonResult CompareByLayout (PSPDFWord word)
		{
			if (word == null)
				throw new ArgumentNullException ("word");
			if (IsDirectBinding) {
				return (NSComparisonResult) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend_IntPtr (this.Handle, selCompareByLayout_, word.Handle);
			} else {
				return (NSComparisonResult) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, selCompareByLayout_, word.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual System.Drawing.RectangleF Frame {
			[Export ("frame", ArgumentSemantic.Retain)]
			get {
				System.Drawing.RectangleF ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret (out ret, this.Handle, selFrame);
				} else {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selFrame);
				}
				return ret;
			}
			
			[Export ("setFrame:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_RectangleF (this.Handle, selSetFrame_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_RectangleF (this.SuperHandle, selSetFrame_, value);
				}
			}
		}
		
		object __mt_Glyphs_var;
		[CompilerGenerated]
		public virtual PSPDFGlyph[] Glyphs {
			[Export ("glyphs")]
			get {
				PSPDFGlyph[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFGlyph>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selGlyphs));
				} else {
					ret = NSArray.ArrayFromHandle<AlexTouch.PSPDFKit.PSPDFGlyph>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selGlyphs));
				}
				MarkDirty ();
				__mt_Glyphs_var = ret;
				return ret;
			}
			
			[Export ("setGlyphs:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetGlyphs_, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetGlyphs_, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				MarkDirty ();
				__mt_Glyphs_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string Text {
			[Export ("stringValue")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStringValue));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selStringValue));
				}
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_Glyphs_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFWord */
}
