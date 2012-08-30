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
	[Register("PSCollectionViewLayoutAttributes", true)]
	public unsafe partial class PSCollectionViewLayoutAttributes : NSObject {
		static readonly IntPtr selFrame = Selector.GetHandle ("frame");
		static readonly IntPtr selSetFrame_ = Selector.GetHandle ("setFrame:");
		static readonly IntPtr selCenter = Selector.GetHandle ("center");
		static readonly IntPtr selSetCenter_ = Selector.GetHandle ("setCenter:");
		static readonly IntPtr selSize = Selector.GetHandle ("size");
		static readonly IntPtr selSetSize_ = Selector.GetHandle ("setSize:");
		static readonly IntPtr selTransform3D = Selector.GetHandle ("transform3D");
		static readonly IntPtr selSetTransform3D_ = Selector.GetHandle ("setTransform3D:");
		static readonly IntPtr selAlpha = Selector.GetHandle ("alpha");
		static readonly IntPtr selSetAlpha_ = Selector.GetHandle ("setAlpha:");
		static readonly IntPtr selZIndex = Selector.GetHandle ("zIndex");
		static readonly IntPtr selSetZIndex_ = Selector.GetHandle ("setZIndex:");
		static readonly IntPtr selIsHidden = Selector.GetHandle ("isHidden");
		static readonly IntPtr selSetHidden_ = Selector.GetHandle ("setHidden:");
		static readonly IntPtr selIndexPath = Selector.GetHandle ("indexPath");
		static readonly IntPtr selSetIndexPath_ = Selector.GetHandle ("setIndexPath:");
		static readonly IntPtr selRepresentedElementKind = Selector.GetHandle ("representedElementKind");
		static readonly IntPtr selRepresentedElementCategory = Selector.GetHandle ("representedElementCategory");
		static readonly IntPtr selLayoutAttributesForCellWithIndexPath_ = Selector.GetHandle ("layoutAttributesForCellWithIndexPath:");
		static readonly IntPtr selLayoutAttributesForSupplementaryViewOfKindWithIndexPath_ = Selector.GetHandle ("layoutAttributesForSupplementaryViewOfKind:withIndexPath:");
		static readonly IntPtr selLayoutAttributesForDecorationViewWithReuseIdentifierWithIndexPath_ = Selector.GetHandle ("layoutAttributesForDecorationViewWithReuseIdentifier:withIndexPath:");
		static readonly IntPtr selIsDecorationView = Selector.GetHandle ("isDecorationView");
		static readonly IntPtr selIsSupplementaryView = Selector.GetHandle ("isSupplementaryView");
		static readonly IntPtr selIsCell = Selector.GetHandle ("isCell");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSCollectionViewLayoutAttributes");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSCollectionViewLayoutAttributes () : base (NSObjectFlag.Empty)
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
		public PSCollectionViewLayoutAttributes (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSCollectionViewLayoutAttributes (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSCollectionViewLayoutAttributes (IntPtr handle) : base (handle) {}

		[Export ("layoutAttributesForCellWithIndexPath:")]
		[CompilerGenerated]
		public static NSObject LayoutAttributesForCellWithIndexPath (NSIndexPath indexPath)
		{
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			return (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selLayoutAttributesForCellWithIndexPath_, indexPath.Handle));
		}
		
		[Export ("layoutAttributesForSupplementaryViewOfKind:withIndexPath:")]
		[CompilerGenerated]
		public static NSObject LayoutAttributesForSupplementaryViewOfKind (string elementKind, NSIndexPath indexPath)
		{
			if (elementKind == null)
				throw new ArgumentNullException ("elementKind");
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			var nselementKind = NSString.CreateNative (elementKind);
			
			NSObject ret;
			ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selLayoutAttributesForSupplementaryViewOfKindWithIndexPath_, nselementKind, indexPath.Handle));
			NSString.ReleaseNative (nselementKind);
			
			return ret;
		}
		
		[Export ("layoutAttributesForDecorationViewWithReuseIdentifier:withIndexPath:")]
		[CompilerGenerated]
		public static NSObject LayoutAttributesForDecorationViewWithReuseIdentifier (string reuseIdentifier, NSIndexPath indexPath)
		{
			if (reuseIdentifier == null)
				throw new ArgumentNullException ("reuseIdentifier");
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			var nsreuseIdentifier = NSString.CreateNative (reuseIdentifier);
			
			NSObject ret;
			ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selLayoutAttributesForDecorationViewWithReuseIdentifierWithIndexPath_, nsreuseIdentifier, indexPath.Handle));
			NSString.ReleaseNative (nsreuseIdentifier);
			
			return ret;
		}
		
		[CompilerGenerated]
		public bool IsDecorationView ()
		{
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDecorationView);
		}
		
		[CompilerGenerated]
		public bool IsSupplementaryView ()
		{
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSupplementaryView);
		}
		
		[CompilerGenerated]
		public bool IsCell ()
		{
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsCell);
		}
		
		[CompilerGenerated]
		public virtual System.Drawing.RectangleF Frame {
			[Export ("frame")]
			get {
				System.Drawing.RectangleF ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret (out ret, this.Handle, selFrame);
				} else {
					MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selFrame);
				}
				return ret;
			}
			
			[Export ("setFrame:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_RectangleF (this.Handle, selSetFrame_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_RectangleF (this.SuperHandle, selSetFrame_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual System.Drawing.PointF Center {
			[Export ("center")]
			get {
				System.Drawing.PointF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSend_stret (out ret, this.Handle, selCenter);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSend (this.Handle, selCenter);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selCenter);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.PointF_objc_msgSendSuper (this.SuperHandle, selCenter);
					}
				}
				return ret;
			}
			
			[Export ("setCenter:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_PointF (this.Handle, selSetCenter_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_PointF (this.SuperHandle, selSetCenter_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual System.Drawing.SizeF Size {
			[Export ("size")]
			get {
				System.Drawing.SizeF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend_stret (out ret, this.Handle, selSize);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend (this.Handle, selSize);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selSize);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper (this.SuperHandle, selSize);
					}
				}
				return ret;
			}
			
			[Export ("setSize:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_SizeF (this.Handle, selSetSize_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_SizeF (this.SuperHandle, selSetSize_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual MonoTouch.CoreAnimation.CATransform3D Transform3D {
			[Export ("transform3D")]
			get {
				MonoTouch.CoreAnimation.CATransform3D ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.CATransform3D_objc_msgSend_stret (out ret, this.Handle, selTransform3D);
				} else {
					MonoTouch.ObjCRuntime.Messaging.CATransform3D_objc_msgSendSuper_stret (out ret, this.SuperHandle, selTransform3D);
				}
				return ret;
			}
			
			[Export ("setTransform3D:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_CATransform3D (this.Handle, selSetTransform3D_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_CATransform3D (this.SuperHandle, selSetTransform3D_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float Alpha {
			[Export ("alpha")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selAlpha);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selAlpha);
				}
			}
			
			[Export ("setAlpha:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetAlpha_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetAlpha_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int ZIndex {
			[Export ("zIndex")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selZIndex);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selZIndex);
				}
			}
			
			[Export ("setZIndex:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetZIndex_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetZIndex_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Hidden {
			[Export ("isHidden")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsHidden);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsHidden);
				}
			}
			
			[Export ("setHidden:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHidden_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetHidden_, value);
				}
			}
		}
		
		object __mt_IndexPath_var;
		[CompilerGenerated]
		public virtual NSIndexPath IndexPath {
			[Export ("indexPath")]
			get {
				NSIndexPath ret;
				if (IsDirectBinding) {
					ret = (NSIndexPath) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selIndexPath));
				} else {
					ret = (NSIndexPath) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selIndexPath));
				}
				MarkDirty ();
				__mt_IndexPath_var = ret;
				return ret;
			}
			
			[Export ("setIndexPath:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetIndexPath_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetIndexPath_, value.Handle);
				}
				MarkDirty ();
				__mt_IndexPath_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string RepresentedElementKind {
			[Export ("representedElementKind")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRepresentedElementKind));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRepresentedElementKind));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSCollectionViewItemType RepresentedElementCategory {
			[Export ("representedElementCategory")]
			get {
				if (IsDirectBinding) {
					return (PSCollectionViewItemType) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selRepresentedElementCategory);
				} else {
					return (PSCollectionViewItemType) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selRepresentedElementCategory);
				}
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_IndexPath_var = null;
			base.Dispose (disposing);
		}
	} /* class PSCollectionViewLayoutAttributes */
}
