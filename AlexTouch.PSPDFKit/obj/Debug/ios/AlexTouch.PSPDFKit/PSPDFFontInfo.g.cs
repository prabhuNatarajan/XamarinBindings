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
	[Register("PSPDFFontInfo", true)]
	public unsafe partial class PSPDFFontInfo : NSObject {
		static readonly IntPtr selAscent = Selector.GetHandle ("ascent");
		static readonly IntPtr selSetAscent_ = Selector.GetHandle ("setAscent:");
		static readonly IntPtr selDescent = Selector.GetHandle ("descent");
		static readonly IntPtr selSetDescent_ = Selector.GetHandle ("setDescent:");
		static readonly IntPtr selName = Selector.GetHandle ("name");
		static readonly IntPtr selSetName_ = Selector.GetHandle ("setName:");
		static readonly IntPtr selEncodingArray = Selector.GetHandle ("encodingArray");
		static readonly IntPtr selSetEncodingArray_ = Selector.GetHandle ("setEncodingArray:");
		static readonly IntPtr selToUnicodeMap = Selector.GetHandle ("toUnicodeMap");
		static readonly IntPtr selSetToUnicodeMap_ = Selector.GetHandle ("setToUnicodeMap:");
		static readonly IntPtr selIsMultiByteFont = Selector.GetHandle ("isMultiByteFont");
		static readonly IntPtr selInitWithFontDictionary_ = Selector.GetHandle ("initWithFontDictionary:");
		static readonly IntPtr selWidthForCharacter_ = Selector.GetHandle ("widthForCharacter:");
		static readonly IntPtr selParseToUnicodeMapWithString_ = Selector.GetHandle ("parseToUnicodeMapWithString:");
		static readonly IntPtr selGlyphNames = Selector.GetHandle ("glyphNames");
		static readonly IntPtr selStandardFontWidths = Selector.GetHandle ("standardFontWidths");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFFontInfo");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFFontInfo () : base (NSObjectFlag.Empty)
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
		public PSPDFFontInfo (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFFontInfo (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFFontInfo (IntPtr handle) : base (handle) {}

		[Export ("initWithFontDictionary:")]
		[CompilerGenerated]
		internal virtual PSPDFFontInfo InitWithFontDictionary_ (System.IntPtr font)
		{
			if (IsDirectBinding) {
				return (PSPDFFontInfo) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithFontDictionary_, font));
			} else {
				return (PSPDFFontInfo) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithFontDictionary_, font));
			}
		}
		
		[Export ("widthForCharacter:")]
		[CompilerGenerated]
		public virtual float WidthForCharacter (System.UInt16 c)
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.float_objc_msgSend_UInt16 (this.Handle, selWidthForCharacter_, c);
			} else {
				return ApiDefinition.Messaging.float_objc_msgSendSuper_UInt16 (this.SuperHandle, selWidthForCharacter_, c);
			}
		}
		
		[Export ("parseToUnicodeMapWithString:")]
		[CompilerGenerated]
		public virtual void ParseToUnicodeMapWithString (string cmapString)
		{
			if (cmapString == null)
				throw new ArgumentNullException ("cmapString");
			var nscmapString = NSString.CreateNative (cmapString);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selParseToUnicodeMapWithString_, nscmapString);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selParseToUnicodeMapWithString_, nscmapString);
			}
			NSString.ReleaseNative (nscmapString);
			
		}
		
		[Export ("glyphNames")]
		[CompilerGenerated]
		public static NSDictionary GlyphNames ()
		{
			return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selGlyphNames));
		}
		
		[Export ("standardFontWidths")]
		[CompilerGenerated]
		public static NSDictionary StandardFontWidths ()
		{
			return (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selStandardFontWidths));
		}
		
		[CompilerGenerated]
		public virtual float Ascent {
			[Export ("ascent", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selAscent);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selAscent);
				}
			}
			
			[Export ("setAscent:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetAscent_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetAscent_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float Descent {
			[Export ("descent", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selDescent);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selDescent);
				}
			}
			
			[Export ("setDescent:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetDescent_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetDescent_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Name {
			[Export ("name")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selName));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selName));
				}
			}
			
			[Export ("setName:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetName_, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetName_, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		object __mt_EncodingArray_var;
		[CompilerGenerated]
		public virtual NSArray EncodingArray {
			[Export ("encodingArray")]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selEncodingArray));
				} else {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selEncodingArray));
				}
				MarkDirty ();
				__mt_EncodingArray_var = ret;
				return ret;
			}
			
			[Export ("setEncodingArray:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetEncodingArray_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetEncodingArray_, value.Handle);
				}
				MarkDirty ();
				__mt_EncodingArray_var = value;
			}
		}
		
		object __mt_ToUnicodeMap_var;
		[CompilerGenerated]
		public virtual NSMutableDictionary ToUnicodeMap {
			[Export ("toUnicodeMap")]
			get {
				NSMutableDictionary ret;
				if (IsDirectBinding) {
					ret = (NSMutableDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selToUnicodeMap));
				} else {
					ret = (NSMutableDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selToUnicodeMap));
				}
				MarkDirty ();
				__mt_ToUnicodeMap_var = ret;
				return ret;
			}
			
			[Export ("setToUnicodeMap:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetToUnicodeMap_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetToUnicodeMap_, value.Handle);
				}
				MarkDirty ();
				__mt_ToUnicodeMap_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsMultiByteFont {
			[Export ("isMultiByteFont")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsMultiByteFont);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsMultiByteFont);
				}
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_EncodingArray_var = null;
			__mt_ToUnicodeMap_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFFontInfo */
}
