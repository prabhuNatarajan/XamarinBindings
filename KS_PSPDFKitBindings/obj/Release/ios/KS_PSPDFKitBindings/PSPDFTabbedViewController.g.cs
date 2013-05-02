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
	[Register("PSPDFTabbedViewController", true)]
	public unsafe partial class PSPDFTabbedViewController : PSPDFMultiDocumentViewController {
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selEnableAutomaticStatePersistance = "enableAutomaticStatePersistance";
		static readonly IntPtr selEnableAutomaticStatePersistanceHandle = Selector.GetHandle ("enableAutomaticStatePersistance");
		[CompilerGenerated]
		const string selSetEnableAutomaticStatePersistance_ = "setEnableAutomaticStatePersistance:";
		static readonly IntPtr selSetEnableAutomaticStatePersistance_Handle = Selector.GetHandle ("setEnableAutomaticStatePersistance:");
		[CompilerGenerated]
		const string selStatePersistanceKey = "statePersistanceKey";
		static readonly IntPtr selStatePersistanceKeyHandle = Selector.GetHandle ("statePersistanceKey");
		[CompilerGenerated]
		const string selSetStatePersistanceKey_ = "setStatePersistanceKey:";
		static readonly IntPtr selSetStatePersistanceKey_Handle = Selector.GetHandle ("setStatePersistanceKey:");
		[CompilerGenerated]
		const string selMinTabWidth = "minTabWidth";
		static readonly IntPtr selMinTabWidthHandle = Selector.GetHandle ("minTabWidth");
		[CompilerGenerated]
		const string selSetMinTabWidth_ = "setMinTabWidth:";
		static readonly IntPtr selSetMinTabWidth_Handle = Selector.GetHandle ("setMinTabWidth:");
		[CompilerGenerated]
		const string selTabBar = "tabBar";
		static readonly IntPtr selTabBarHandle = Selector.GetHandle ("tabBar");
		[CompilerGenerated]
		const string selInitWithPDFViewController_ = "initWithPDFViewController:";
		static readonly IntPtr selInitWithPDFViewController_Handle = Selector.GetHandle ("initWithPDFViewController:");
		[CompilerGenerated]
		const string selAddDocumentsAtIndexAnimated_ = "addDocuments:atIndex:animated:";
		static readonly IntPtr selAddDocumentsAtIndexAnimated_Handle = Selector.GetHandle ("addDocuments:atIndex:animated:");
		[CompilerGenerated]
		const string selRemoveDocumentsAnimated_ = "removeDocuments:animated:";
		static readonly IntPtr selRemoveDocumentsAnimated_Handle = Selector.GetHandle ("removeDocuments:animated:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFTabbedViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFTabbedViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFTabbedViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFTabbedViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFTabbedViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithPDFViewController:")]
		[CompilerGenerated]
		public PSPDFTabbedViewController (PSPDFViewController pdfController)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithPDFViewController_Handle, pdfController == null ? IntPtr.Zero : pdfController.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithPDFViewController_Handle, pdfController == null ? IntPtr.Zero : pdfController.Handle);
			}
		}
		
		[Export ("addDocuments:atIndex:animated:")]
		[CompilerGenerated]
		public virtual void AddDocuments (PSPDFDocument[] documents, global::System.UInt32 index, bool animated)
		{
			if (documents == null)
				throw new ArgumentNullException ("documents");
			var nsa_documents = NSArray.FromNSObjects (documents);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UInt32_bool (this.Handle, selAddDocumentsAtIndexAnimated_Handle, nsa_documents.Handle, index, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UInt32_bool (this.SuperHandle, selAddDocumentsAtIndexAnimated_Handle, nsa_documents.Handle, index, animated);
			}
			nsa_documents.Dispose ();
			
			#pragma warning disable 168
			var postget0 = Documents;
			#pragma warning restore 168
		}
		
		[Export ("removeDocuments:animated:")]
		[CompilerGenerated]
		public virtual void RemoveDocuments (PSPDFDocument[] documents, bool animated)
		{
			if (documents == null)
				throw new ArgumentNullException ("documents");
			var nsa_documents = NSArray.FromNSObjects (documents);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selRemoveDocumentsAnimated_Handle, nsa_documents.Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selRemoveDocumentsAnimated_Handle, nsa_documents.Handle, animated);
			}
			nsa_documents.Dispose ();
			
			#pragma warning disable 168
			var postget0 = Documents;
			#pragma warning restore 168
		}
		
		[CompilerGenerated]
		public PSPDFTabbedViewControllerDelegate Delegate {
			get {
				return WeakDelegate as PSPDFTabbedViewControllerDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool EnableAutomaticStatePersistance {
			[Export ("enableAutomaticStatePersistance", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selEnableAutomaticStatePersistanceHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selEnableAutomaticStatePersistanceHandle);
				}
			}
			
			[Export ("setEnableAutomaticStatePersistance:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetEnableAutomaticStatePersistance_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetEnableAutomaticStatePersistance_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string StatePersistanceKey {
			[Export ("statePersistanceKey", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStatePersistanceKeyHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selStatePersistanceKeyHandle));
				}
			}
			
			[Export ("setStatePersistanceKey:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetStatePersistanceKey_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetStatePersistanceKey_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual float MinTabWidth {
			[Export ("minTabWidth", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMinTabWidthHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selMinTabWidthHandle);
				}
			}
			
			[Export ("setMinTabWidth:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMinTabWidth_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetMinTabWidth_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_TabBar_var;
		[CompilerGenerated]
		public virtual PSPDFTabBarView TabBar {
			[Export ("tabBar")]
			get {
				PSPDFTabBarView ret;
				if (IsDirectBinding) {
					ret = (PSPDFTabBarView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTabBarHandle));
				} else {
					ret = (PSPDFTabBarView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTabBarHandle));
				}
				MarkDirty ();
				__mt_TabBar_var = ret;
				return ret;
			}
			
		}
		
		//
		// Events and properties from the delegate
		//
		
		_PSPDFTabbedViewControllerDelegate EnsurePSPDFTabbedViewControllerDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _PSPDFTabbedViewControllerDelegate))){
				del = new _PSPDFTabbedViewControllerDelegate ();
				WeakDelegate = del;
			}
			return (_PSPDFTabbedViewControllerDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _PSPDFTabbedViewControllerDelegate : KS_PSPDFKitBindings.PSPDFTabbedViewControllerDelegate { 
			public _PSPDFTabbedViewControllerDelegate () {}
			
			internal PSPDFTabbedViewControllerDocuments shouldChangeDocuments;
			[Preserve (Conditional = true)]
			public override bool ShouldChangeDocuments (KS_PSPDFKitBindings.PSPDFTabbedViewController tabbedPDFController, KS_PSPDFKitBindings.PSPDFDocument[] newDocuments)
			{
				PSPDFTabbedViewControllerDocuments handler = shouldChangeDocuments;
				if (handler != null)
					return handler (tabbedPDFController, newDocuments);
				return true;
			}
			
			internal EventHandler<PSPDFTabbedViewControllerDocsEventArgs> didChangeDocuments;
			[Preserve (Conditional = true)]
			public override void DidChangeDocuments (KS_PSPDFKitBindings.PSPDFTabbedViewController tabbedPDFController, KS_PSPDFKitBindings.PSPDFDocument[] oldDocuments)
			{
				EventHandler<PSPDFTabbedViewControllerDocsEventArgs> handler = didChangeDocuments;
				if (handler != null){
					var args = new PSPDFTabbedViewControllerDocsEventArgs (oldDocuments);
					handler (tabbedPDFController, args);
				}
			}
			
			internal PSPDFTabbedViewControllerDocument shouldChangeVisibleDocument;
			[Preserve (Conditional = true)]
			public override bool ShouldChangeVisibleDocument (KS_PSPDFKitBindings.PSPDFTabbedViewController tabbedPDFController, KS_PSPDFKitBindings.PSPDFDocument newDocument)
			{
				PSPDFTabbedViewControllerDocument handler = shouldChangeVisibleDocument;
				if (handler != null)
					return handler (tabbedPDFController, newDocument);
				return true;
			}
			
			internal EventHandler<PSPDFTabbedViewControllerDocEventArgs> didChangeVisibleDocument;
			[Preserve (Conditional = true)]
			public override void DidChangeVisibleDocument (KS_PSPDFKitBindings.PSPDFTabbedViewController tabbedPDFController, KS_PSPDFKitBindings.PSPDFDocument oldDocument)
			{
				EventHandler<PSPDFTabbedViewControllerDocEventArgs> handler = didChangeVisibleDocument;
				if (handler != null){
					var args = new PSPDFTabbedViewControllerDocEventArgs (oldDocument);
					handler (tabbedPDFController, args);
				}
			}
			
			internal PSPDFTabbedViewControllerDocument shouldCloseDocument;
			[Preserve (Conditional = true)]
			public override bool ShouldCloseDocument (KS_PSPDFKitBindings.PSPDFTabbedViewController tabbedPDFController, KS_PSPDFKitBindings.PSPDFDocument closedDocument)
			{
				PSPDFTabbedViewControllerDocument handler = shouldCloseDocument;
				if (handler != null)
					return handler (tabbedPDFController, closedDocument);
				return true;
			}
			
			internal EventHandler<PSPDFTabbedViewControllerDocEventArgs> didCloseDocument;
			[Preserve (Conditional = true)]
			public override void DidCloseDocument (KS_PSPDFKitBindings.PSPDFTabbedViewController tabbedPDFController, KS_PSPDFKitBindings.PSPDFDocument closedDocument)
			{
				EventHandler<PSPDFTabbedViewControllerDocEventArgs> handler = didCloseDocument;
				if (handler != null){
					var args = new PSPDFTabbedViewControllerDocEventArgs (closedDocument);
					handler (tabbedPDFController, args);
				}
			}
			
		}
		#pragma warning restore 672
		
		public PSPDFTabbedViewControllerDocuments ShouldChangeDocuments {
			get { return EnsurePSPDFTabbedViewControllerDelegate ().shouldChangeDocuments; }
			set { EnsurePSPDFTabbedViewControllerDelegate ().shouldChangeDocuments = value; }
		}
		
		public event EventHandler<PSPDFTabbedViewControllerDocsEventArgs> DidChangeDocuments {
			add { EnsurePSPDFTabbedViewControllerDelegate ().didChangeDocuments += value; }
			remove { EnsurePSPDFTabbedViewControllerDelegate ().didChangeDocuments -= value; }
		}
		
		public PSPDFTabbedViewControllerDocument ShouldChangeVisibleDocument {
			get { return EnsurePSPDFTabbedViewControllerDelegate ().shouldChangeVisibleDocument; }
			set { EnsurePSPDFTabbedViewControllerDelegate ().shouldChangeVisibleDocument = value; }
		}
		
		public event EventHandler<PSPDFTabbedViewControllerDocEventArgs> DidChangeVisibleDocument {
			add { EnsurePSPDFTabbedViewControllerDelegate ().didChangeVisibleDocument += value; }
			remove { EnsurePSPDFTabbedViewControllerDelegate ().didChangeVisibleDocument -= value; }
		}
		
		public PSPDFTabbedViewControllerDocument ShouldCloseDocument {
			get { return EnsurePSPDFTabbedViewControllerDelegate ().shouldCloseDocument; }
			set { EnsurePSPDFTabbedViewControllerDelegate ().shouldCloseDocument = value; }
		}
		
		public event EventHandler<PSPDFTabbedViewControllerDocEventArgs> DidCloseDocument {
			add { EnsurePSPDFTabbedViewControllerDelegate ().didCloseDocument += value; }
			remove { EnsurePSPDFTabbedViewControllerDelegate ().didCloseDocument -= value; }
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
				__mt_TabBar_var = null;
			}
		}
	} /* class PSPDFTabbedViewController */
	
	
	//
	// EventArgs classes
	//
	public partial class PSPDFTabbedViewControllerDocsEventArgs : EventArgs {
		public PSPDFTabbedViewControllerDocsEventArgs (KS_PSPDFKitBindings.PSPDFDocument[] oldDocuments)
		{
			this.OldDocuments = oldDocuments;
		}
		public KS_PSPDFKitBindings.PSPDFDocument[] OldDocuments { get; set; }
	}
	
	public partial class PSPDFTabbedViewControllerDocEventArgs : EventArgs {
		public PSPDFTabbedViewControllerDocEventArgs (KS_PSPDFKitBindings.PSPDFDocument oldDocument)
		{
			this.OldDocument = oldDocument;
		}
		public KS_PSPDFKitBindings.PSPDFDocument OldDocument { get; set; }
	}
	
}
