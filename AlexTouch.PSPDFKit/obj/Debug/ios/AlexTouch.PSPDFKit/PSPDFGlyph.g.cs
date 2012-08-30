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
	[Register("PSPDFGlyph", true)]
	public unsafe partial class PSPDFGlyph : NSObject {
		static readonly IntPtr selFrame = Selector.GetHandle ("frame");
		static readonly IntPtr selSetFrame_ = Selector.GetHandle ("setFrame:");
		static readonly IntPtr selContent = Selector.GetHandle ("content");
		static readonly IntPtr selSetContent_ = Selector.GetHandle ("setContent:");
		static readonly IntPtr selFont = Selector.GetHandle ("font");
		static readonly IntPtr selSetFont_ = Selector.GetHandle ("setFont:");
		static readonly IntPtr selLineBreaker = Selector.GetHandle ("lineBreaker");
		static readonly IntPtr selSetLineBreaker_ = Selector.GetHandle ("setLineBreaker:");
		static readonly IntPtr selIndexOnPage = Selector.GetHandle ("indexOnPage");
		static readonly IntPtr selSetIndexOnPage_ = Selector.GetHandle ("setIndexOnPage:");
		static readonly IntPtr selFontHeight = Selector.GetHandle ("fontHeight");
		static readonly IntPtr selCompareByXPosition_ = Selector.GetHandle ("compareByXPosition:");
		static readonly IntPtr selIsOnSameLineAs_ = Selector.GetHandle ("isOnSameLineAs:");
		static readonly IntPtr selIsOnSameLineSegmentAs_ = Selector.GetHandle ("isOnSameLineSegmentAs:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFGlyph");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFGlyph () : base (NSObjectFlag.Empty)
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
		public PSPDFGlyph (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFGlyph (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFGlyph (IntPtr handle) : base (handle) {}

		[Export ("compareByXPosition:")]
		[CompilerGenerated]
		public virtual NSComparisonResult CompareByXPosition (PSPDFGlyph glyph)
		{
			if (glyph == null)
				throw new ArgumentNullException ("glyph");
			if (IsDirectBinding) {
				return (NSComparisonResult) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend_IntPtr (this.Handle, selCompareByXPosition_, glyph.Handle);
			} else {
				return (NSComparisonResult) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, selCompareByXPosition_, glyph.Handle);
			}
		}
		
		[Export ("isOnSameLineAs:")]
		[CompilerGenerated]
		public virtual bool IsOnSameLineAs (PSPDFGlyph glyph)
		{
			if (glyph == null)
				throw new ArgumentNullException ("glyph");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsOnSameLineAs_, glyph.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selIsOnSameLineAs_, glyph.Handle);
			}
		}
		
		[Export ("isOnSameLineSegmentAs:")]
		[CompilerGenerated]
		public virtual bool IsOnSameLineSegmentAs (PSPDFGlyph glyph)
		{
			if (glyph == null)
				throw new ArgumentNullException ("glyph");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsOnSameLineSegmentAs_, glyph.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selIsOnSameLineSegmentAs_, glyph.Handle);
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
		
		[CompilerGenerated]
		public virtual string Content {
			[Export ("content")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selContent));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selContent));
				}
			}
			
			[Export ("setContent:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetContent_, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetContent_, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		object __mt_Font_var;
		[CompilerGenerated]
		public virtual PSPDFFontInfo Font {
			[Export ("font")]
			get {
				PSPDFFontInfo ret;
				if (IsDirectBinding) {
					ret = (PSPDFFontInfo) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFont));
				} else {
					ret = (PSPDFFontInfo) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFont));
				}
				MarkDirty ();
				__mt_Font_var = ret;
				return ret;
			}
			
			[Export ("setFont:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFont_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFont_, value.Handle);
				}
				MarkDirty ();
				__mt_Font_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool LineBreaker {
			[Export ("lineBreaker", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selLineBreaker);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selLineBreaker);
				}
			}
			
			[Export ("setLineBreaker:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetLineBreaker_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetLineBreaker_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int IndexOnPage {
			[Export ("indexOnPage", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selIndexOnPage);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selIndexOnPage);
				}
			}
			
			[Export ("setIndexOnPage:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetIndexOnPage_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetIndexOnPage_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float FontHeight {
			[Export ("fontHeight", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selFontHeight);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selFontHeight);
				}
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_Font_var = null;
			base.Dispose (disposing);
		}
	} /* class PSPDFGlyph */
}
