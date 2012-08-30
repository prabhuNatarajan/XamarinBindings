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
	[Register("PSPDFTextParser", true)]
	public unsafe partial class PSPDFTextParser : NSObject {
		static readonly IntPtr selText = Selector.GetHandle ("text");
		static readonly IntPtr selSetText_ = Selector.GetHandle ("setText:");
		static readonly IntPtr selGlyphs = Selector.GetHandle ("glyphs");
		static readonly IntPtr selSetGlyphs_ = Selector.GetHandle ("setGlyphs:");
		static readonly IntPtr selWords = Selector.GetHandle ("words");
		static readonly IntPtr selSetWords_ = Selector.GetHandle ("setWords:");
		static readonly IntPtr selTextBlocks = Selector.GetHandle ("textBlocks");
		static readonly IntPtr selSetTextBlocks_ = Selector.GetHandle ("setTextBlocks:");
		static readonly IntPtr selInitWithPDFPage_ = Selector.GetHandle ("initWithPDFPage:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFTextParser");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFTextParser () : base (NSObjectFlag.Empty)
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
		public PSPDFTextParser (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFTextParser (IntPtr handle) : base (handle) {}

		[Export ("initWithPDFPage:")]
		[CompilerGenerated]
		internal static PSPDFTextParser initWithPDFPage_ (System.IntPtr page)
		{
			return (PSPDFTextParser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selInitWithPDFPage_, page));
		}
		
		[CompilerGenerated]
		public virtual string Text {
			[Export ("text")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selText));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selText));
				}
			}
			
			[Export ("setText:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetText_, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetText_, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		object __mt_Glyphs_var;
		[CompilerGenerated]
		public virtual NSMutableArray Glyphs {
			[Export ("glyphs")]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret = (NSMutableArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selGlyphs));
				} else {
					ret = (NSMutableArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selGlyphs));
				}
				MarkDirty ();
				__mt_Glyphs_var = ret;
				return ret;
			}
			
			[Export ("setGlyphs:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetGlyphs_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetGlyphs_, value.Handle);
				}
				MarkDirty ();
				__mt_Glyphs_var = value;
			}
		}
		
		object __mt_Words_var;
		[CompilerGenerated]
		public virtual NSMutableArray Words {
			[Export ("words")]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret = (NSMutableArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selWords));
				} else {
					ret = (NSMutableArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selWords));
				}
				MarkDirty ();
				__mt_Words_var = ret;
				return ret;
			}
			
			[Export ("setWords:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetWords_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetWords_, value.Handle);
				}
				MarkDirty ();
				__mt_Words_var = value;
			}
		}
		
		object __mt_TextBlocks_var;
		[CompilerGenerated]
		public virtual NSArray TextBlocks {
			[Export ("textBlocks")]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTextBlocks));
				} else {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTextBlocks));
				}
				MarkDirty ();
				__mt_TextBlocks_var = ret;
				return ret;
			}
			
			[Export ("setTextBlocks:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTextBlocks_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTextBlocks_, value.Handle);
				}
				MarkDirty ();
				__mt_TextBlocks_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_Glyphs_var = null;
			__mt_Words_var = null;
			__mt_TextBlocks_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFTextParser */
}
