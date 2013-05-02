using System;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace PSPDFKitDemoXamarin.iOS
{
	public static class KSExtensions
	{
		/// <summary>
		/// Converts an NSSet into an NSOrderedSet. NSOrderedSet is not bound in Xamarin.iOS, so we have to do some magic.
		/// And no, NSOrderedSet is NOT a subclass of NSSet. God knows why...
		/// </summary>
		/// <returns>The NSOrderedSet</returns>
		/// <param name="set">Set to be converted.</param>
		public static IntPtr ToNSOrderedSet(this NSSet set)
		{
			return Messaging.IntPtr_objc_msgSend_IntPtr(Class.GetHandle("NSOrderedSet"), Selector.GetHandle("orderedSetWithSet:"), set.Handle);
		}
	}
}

