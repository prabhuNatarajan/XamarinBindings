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
	[Register("PSPDFSearchDelegate", true)]
	[Model]
	public unsafe partial class PSPDFSearchDelegate : NSObject {
		
		static readonly IntPtr class_ptr = Class.GetHandle ("NSObject");
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFSearchDelegate () : base (NSObjectFlag.Empty)
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
		public PSPDFSearchDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFSearchDelegate (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFSearchDelegate (IntPtr handle) : base (handle) {}

		[Export ("willStartSearchForString:isFullSearch:")]
		[CompilerGenerated]
		public virtual void WillStartSearch (string searchString, bool isFullSearch)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didUpdateSearchForString:newSearchResults:forPage:")]
		[CompilerGenerated]
		public virtual void DidUpdateSearch (string searchString, PSPDFSearchResult[] searchResults, System.UInt32 page)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didFinishSearchForString:searchResults:isFullSearch:")]
		[CompilerGenerated]
		public virtual void DidFinishSearch (string searchString, PSPDFSearchResult[] searchResults, bool isFullSearch)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didCancelSearchForString:isFullSearch:")]
		[CompilerGenerated]
		public virtual void DidCancelSearch (string searchString, bool isFullSearch)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFSearchDelegate */
}
