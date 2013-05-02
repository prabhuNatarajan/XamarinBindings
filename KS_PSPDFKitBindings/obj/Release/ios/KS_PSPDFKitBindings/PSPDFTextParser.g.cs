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
	[Register("PSPDFTextParser", true)]
	public unsafe partial class PSPDFTextParser : NSObject {
		[CompilerGenerated]
		const string selText = "text";
		static readonly IntPtr selTextHandle = Selector.GetHandle ("text");
		[CompilerGenerated]
		const string selSetText_ = "setText:";
		static readonly IntPtr selSetText_Handle = Selector.GetHandle ("setText:");
		[CompilerGenerated]
		const string selGlyphs = "glyphs";
		static readonly IntPtr selGlyphsHandle = Selector.GetHandle ("glyphs");
		[CompilerGenerated]
		const string selWords = "words";
		static readonly IntPtr selWordsHandle = Selector.GetHandle ("words");
		[CompilerGenerated]
		const string selImages = "images";
		static readonly IntPtr selImagesHandle = Selector.GetHandle ("images");
		[CompilerGenerated]
		const string selTextBlocks = "textBlocks";
		static readonly IntPtr selTextBlocksHandle = Selector.GetHandle ("textBlocks");
		[CompilerGenerated]
		const string selDocument = "document";
		static readonly IntPtr selDocumentHandle = Selector.GetHandle ("document");
		[CompilerGenerated]
		const string selSetDocument_ = "setDocument:";
		static readonly IntPtr selSetDocument_Handle = Selector.GetHandle ("setDocument:");
		[CompilerGenerated]
		const string selInitWithPDFPagePageDocumentFontCacheHideGlyphsOutsidePageRectPDFBox_ = "initWithPDFPage:page:document:fontCache:hideGlyphsOutsidePageRect:PDFBox:";
		static readonly IntPtr selInitWithPDFPagePageDocumentFontCacheHideGlyphsOutsidePageRectPDFBox_Handle = Selector.GetHandle ("initWithPDFPage:page:document:fontCache:hideGlyphsOutsidePageRect:PDFBox:");
		[CompilerGenerated]
		const string selInitWithStream_ = "initWithStream:";
		static readonly IntPtr selInitWithStream_Handle = Selector.GetHandle ("initWithStream:");
		[CompilerGenerated]
		const string selTextWithGlyphs_ = "textWithGlyphs:";
		static readonly IntPtr selTextWithGlyphs_Handle = Selector.GetHandle ("textWithGlyphs:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFTextParser");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFTextParser () : base (NSObjectFlag.Empty)
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
		public PSPDFTextParser (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFTextParser (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFTextParser (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithPDFPage:page:document:fontCache:hideGlyphsOutsidePageRect:PDFBox:")]
		[CompilerGenerated]
		internal PSPDFTextParser (global::System.IntPtr pageRef, global::System.UInt32 page, PSPDFDocument document, NSMutableDictionary fontCache, bool hideGlyphsOutsidePageRect, CGPDFBox PDFBox)
			: base (NSObjectFlag.Empty)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt32_IntPtr_IntPtr_bool_int (this.Handle, selInitWithPDFPagePageDocumentFontCacheHideGlyphsOutsidePageRectPDFBox_Handle, pageRef, page, document.Handle, fontCache == null ? IntPtr.Zero : fontCache.Handle, hideGlyphsOutsidePageRect, (int)PDFBox);
			} else {
				Handle = ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt32_IntPtr_IntPtr_bool_int (this.SuperHandle, selInitWithPDFPagePageDocumentFontCacheHideGlyphsOutsidePageRectPDFBox_Handle, pageRef, page, document.Handle, fontCache == null ? IntPtr.Zero : fontCache.Handle, hideGlyphsOutsidePageRect, (int)PDFBox);
			}
		}
		
		[Export ("initWithStream:")]
		[CompilerGenerated]
		internal PSPDFTextParser (global::System.IntPtr stream, bool fakearg)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_bool (this.Handle, selInitWithStream_Handle, stream, fakearg);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selInitWithStream_Handle, stream, fakearg);
			}
		}
		
		[Export ("textWithGlyphs:")]
		[CompilerGenerated]
		public virtual string TextWithGlyphs (PSPDFGlyph[] glyphs)
		{
			if (glyphs == null)
				throw new ArgumentNullException ("glyphs");
			var nsa_glyphs = NSArray.FromNSObjects (glyphs);
			
			string ret;
			if (IsDirectBinding) {
				ret = NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selTextWithGlyphs_Handle, nsa_glyphs.Handle));
			} else {
				ret = NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selTextWithGlyphs_Handle, nsa_glyphs.Handle));
			}
			nsa_glyphs.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public virtual string Text {
			[Export ("text")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTextHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTextHandle));
				}
			}
			
			[Export ("setText:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetText_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetText_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_Glyphs_var;
		[CompilerGenerated]
		public virtual PSPDFGlyph[] Glyphs {
			[Export ("glyphs")]
			get {
				PSPDFGlyph[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFGlyph>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selGlyphsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFGlyph>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selGlyphsHandle));
				}
				MarkDirty ();
				__mt_Glyphs_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Words_var;
		[CompilerGenerated]
		public virtual PSPDFWord[] Words {
			[Export ("words")]
			get {
				PSPDFWord[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFWord>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selWordsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFWord>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selWordsHandle));
				}
				MarkDirty ();
				__mt_Words_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Images_var;
		[CompilerGenerated]
		public virtual PSPDFImageInfo[] Images {
			[Export ("images")]
			get {
				PSPDFImageInfo[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFImageInfo>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selImagesHandle));
				} else {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFImageInfo>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selImagesHandle));
				}
				MarkDirty ();
				__mt_Images_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_TextBlocks_var;
		[CompilerGenerated]
		public virtual PSPDFTextBlock[] TextBlocks {
			[Export ("textBlocks")]
			get {
				PSPDFTextBlock[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFTextBlock>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTextBlocksHandle));
				} else {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFTextBlock>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTextBlocksHandle));
				}
				MarkDirty ();
				__mt_TextBlocks_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Document_var;
		[CompilerGenerated]
		public virtual PSPDFDocument Document {
			[Export ("document")]
			get {
				PSPDFDocument ret;
				if (IsDirectBinding) {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocumentHandle));
				} else {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocumentHandle));
				}
				MarkDirty ();
				__mt_Document_var = ret;
				return ret;
			}
			
			[Export ("setDocument:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDocument_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDocument_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Document_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Glyphs_var = null;
				__mt_Words_var = null;
				__mt_Images_var = null;
				__mt_TextBlocks_var = null;
				__mt_Document_var = null;
			}
		}
	} /* class PSPDFTextParser */
}
