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
	[Register("PSPDFAnnotationProvider", true)]
	[Model]
	public unsafe abstract partial class PSPDFAnnotationProvider : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSObject");
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFAnnotationProvider () : base (NSObjectFlag.Empty)
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
		public PSPDFAnnotationProvider (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFAnnotationProvider (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFAnnotationProvider (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("annotationsForPage:")]
		[CompilerGenerated]
		public abstract PSPDFAnnotation[] AnnotationsForPage (global::System.UInt32 page);
		[Export ("hasLoadedAnnotationsForPage:")]
		[CompilerGenerated]
		public virtual bool HasLoadedAnnotationsForPage (global::System.UInt32 page)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("addAnnotations:forPage:")]
		[CompilerGenerated]
		public virtual bool AddAnnotations (PSPDFAnnotation[] annotations, global::System.UInt32 page)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("saveAnnotationsWithError:")]
		[CompilerGenerated]
		public virtual bool SaveAnnotationsWithError (out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("dirtyAnnotations")]
		[CompilerGenerated]
		public virtual NSDictionary DirtyAnnotations ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didChangeAnnotation:originalAnnotation:keyPaths:options:")]
		[CompilerGenerated]
		public virtual void DidChangeAnnotation (PSPDFAnnotation annotation, PSPDFAnnotation originalAnnotation, NSArray keyPaths, NSDictionary options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public PSPDFAnnotationProviderChangeNotifier ProviderDelegate {
			get {
				return WeakProviderDelegate as PSPDFAnnotationProviderChangeNotifier;
			}
			set {
				WeakProviderDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual NSObject WeakProviderDelegate {
			[Export ("providerDelegate", ArgumentSemantic.Assign)]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setProviderDelegate:", ArgumentSemantic.Assign)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
	} /* class PSPDFAnnotationProvider */
}
