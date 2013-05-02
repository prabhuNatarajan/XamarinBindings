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
	[Register("PSPDFTextBlock", true)]
	public unsafe partial class PSPDFTextBlock : NSObject {
		[CompilerGenerated]
		const string selFrame = "frame";
		static readonly IntPtr selFrameHandle = Selector.GetHandle ("frame");
		[CompilerGenerated]
		const string selWords = "words";
		static readonly IntPtr selWordsHandle = Selector.GetHandle ("words");
		[CompilerGenerated]
		const string selGlyphs = "glyphs";
		static readonly IntPtr selGlyphsHandle = Selector.GetHandle ("glyphs");
		[CompilerGenerated]
		const string selSetGlyphs_ = "setGlyphs:";
		static readonly IntPtr selSetGlyphs_Handle = Selector.GetHandle ("setGlyphs:");
		[CompilerGenerated]
		const string selContent = "content";
		static readonly IntPtr selContentHandle = Selector.GetHandle ("content");
		[CompilerGenerated]
		const string selInitWithGlyphs_ = "initWithGlyphs:";
		static readonly IntPtr selInitWithGlyphs_Handle = Selector.GetHandle ("initWithGlyphs:");
		[CompilerGenerated]
		const string selIsEqualToTextBlock_ = "isEqualToTextBlock:";
		static readonly IntPtr selIsEqualToTextBlock_Handle = Selector.GetHandle ("isEqualToTextBlock:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFTextBlock");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFTextBlock () : base (NSObjectFlag.Empty)
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
		public PSPDFTextBlock (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFTextBlock (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFTextBlock (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithGlyphs:")]
		[CompilerGenerated]
		public PSPDFTextBlock (PSPDFGlyph[] glyps)
			: base (NSObjectFlag.Empty)
		{
			if (glyps == null)
				throw new ArgumentNullException ("glyps");
			var nsa_glyps = NSArray.FromNSObjects (glyps);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithGlyphs_Handle, nsa_glyps.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithGlyphs_Handle, nsa_glyps.Handle);
			}
			nsa_glyps.Dispose ();
			
		}
		
		[Export ("isEqualToTextBlock:")]
		[CompilerGenerated]
		public virtual bool IsEqualToTextBlock (PSPDFTextBlock otherBlock)
		{
			if (otherBlock == null)
				throw new ArgumentNullException ("otherBlock");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsEqualToTextBlock_Handle, otherBlock.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selIsEqualToTextBlock_Handle, otherBlock.Handle);
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
			
		}
		
		[CompilerGenerated]
		object __mt_Words_var;
		[CompilerGenerated]
		public virtual PSPDFWord[] Words {
			[Export ("words", ArgumentSemantic.Copy)]
			get {
				PSPDFWord[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFWord>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selWordsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFWord>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selWordsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Words_var = ret;
				return ret;
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
		public virtual string Content {
			[Export ("content", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selContentHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selContentHandle));
				}
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Words_var = null;
				__mt_Glyphs_var = null;
			}
		}
	} /* class PSPDFTextBlock */
}
