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
	[Register("PSPDFWord", true)]
	public unsafe partial class PSPDFWord : NSObject {
		[CompilerGenerated]
		const string selStringValue = "stringValue";
		static readonly IntPtr selStringValueHandle = Selector.GetHandle ("stringValue");
		[CompilerGenerated]
		const string selFrame = "frame";
		static readonly IntPtr selFrameHandle = Selector.GetHandle ("frame");
		[CompilerGenerated]
		const string selSetFrame_ = "setFrame:";
		static readonly IntPtr selSetFrame_Handle = Selector.GetHandle ("setFrame:");
		[CompilerGenerated]
		const string selGlyphs = "glyphs";
		static readonly IntPtr selGlyphsHandle = Selector.GetHandle ("glyphs");
		[CompilerGenerated]
		const string selSetGlyphs_ = "setGlyphs:";
		static readonly IntPtr selSetGlyphs_Handle = Selector.GetHandle ("setGlyphs:");
		[CompilerGenerated]
		const string selLineBreaker = "lineBreaker";
		static readonly IntPtr selLineBreakerHandle = Selector.GetHandle ("lineBreaker");
		[CompilerGenerated]
		const string selSetLineBreaker_ = "setLineBreaker:";
		static readonly IntPtr selSetLineBreaker_Handle = Selector.GetHandle ("setLineBreaker:");
		[CompilerGenerated]
		const string selInitWithGlyphs_ = "initWithGlyphs:";
		static readonly IntPtr selInitWithGlyphs_Handle = Selector.GetHandle ("initWithGlyphs:");
		[CompilerGenerated]
		const string selInitWithFrame_ = "initWithFrame:";
		static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle ("initWithFrame:");
		[CompilerGenerated]
		const string selIsOnSameLineAs_ = "isOnSameLineAs:";
		static readonly IntPtr selIsOnSameLineAs_Handle = Selector.GetHandle ("isOnSameLineAs:");
		[CompilerGenerated]
		const string selCompareByLayout_ = "compareByLayout:";
		static readonly IntPtr selCompareByLayout_Handle = Selector.GetHandle ("compareByLayout:");
		[CompilerGenerated]
		const string selIsEqualToWord_ = "isEqualToWord:";
		static readonly IntPtr selIsEqualToWord_Handle = Selector.GetHandle ("isEqualToWord:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFWord");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFWord () : base (NSObjectFlag.Empty)
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
		public PSPDFWord (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFWord (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithGlyphs:")]
		[CompilerGenerated]
		public PSPDFWord (PSPDFGlyph[] wordGlyphs)
			: base (NSObjectFlag.Empty)
		{
			if (wordGlyphs == null)
				throw new ArgumentNullException ("wordGlyphs");
			var nsa_wordGlyphs = NSArray.FromNSObjects (wordGlyphs);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithGlyphs_Handle, nsa_wordGlyphs.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithGlyphs_Handle, nsa_wordGlyphs.Handle);
			}
			nsa_wordGlyphs.Dispose ();
			
		}
		
		[Export ("initWithFrame:")]
		[CompilerGenerated]
		public PSPDFWord (global::System.Drawing.RectangleF wordFrame)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_RectangleF (this.Handle, selInitWithFrame_Handle, wordFrame);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_RectangleF (this.SuperHandle, selInitWithFrame_Handle, wordFrame);
			}
		}
		
		[Export ("stringValue")]
		[CompilerGenerated]
		public virtual string StringValue ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStringValueHandle));
			} else {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selStringValueHandle));
			}
		}
		
		[Export ("isOnSameLineAs:")]
		[CompilerGenerated]
		public virtual bool IsOnSameLineAs (PSPDFWord word)
		{
			if (word == null)
				throw new ArgumentNullException ("word");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsOnSameLineAs_Handle, word.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selIsOnSameLineAs_Handle, word.Handle);
			}
		}
		
		[Export ("compareByLayout:")]
		[CompilerGenerated]
		public virtual NSComparisonResult CompareByLayout (PSPDFWord word)
		{
			if (word == null)
				throw new ArgumentNullException ("word");
			if (IsDirectBinding) {
				return (NSComparisonResult) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend_IntPtr (this.Handle, selCompareByLayout_Handle, word.Handle);
			} else {
				return (NSComparisonResult) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, selCompareByLayout_Handle, word.Handle);
			}
		}
		
		[Export ("isEqualToWord:")]
		[CompilerGenerated]
		public virtual bool IsEqualToWord (PSPDFWord otherWord)
		{
			if (otherWord == null)
				throw new ArgumentNullException ("otherWord");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsEqualToWord_Handle, otherWord.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selIsEqualToWord_Handle, otherWord.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual string Text {
			[Export ("stringValue")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStringValueHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selStringValueHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.Drawing.RectangleF Frame {
			[Export ("frame", ArgumentSemantic.Assign)]
			get {
				global::System.Drawing.RectangleF ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret (out ret, this.Handle, selFrameHandle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selFrameHandle);
				}
				return ret;
			}
			
			[Export ("setFrame:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_RectangleF (this.Handle, selSetFrame_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_RectangleF (this.SuperHandle, selSetFrame_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Glyphs_var;
		[CompilerGenerated]
		public virtual PSPDFGlyph[] Glyphs {
			[Export ("glyphs", ArgumentSemantic.Copy)]
			get {
				PSPDFGlyph[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFGlyph>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selGlyphsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFGlyph>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selGlyphsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Glyphs_var = ret;
				return ret;
			}
			
			[Export ("setGlyphs:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetGlyphs_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetGlyphs_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_Glyphs_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool LineBreaker {
			[Export ("lineBreaker", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selLineBreakerHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selLineBreakerHandle);
				}
			}
			
			[Export ("setLineBreaker:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetLineBreaker_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetLineBreaker_Handle, value);
				}
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Glyphs_var = null;
			}
		}
	} /* class PSPDFWord */
}
