using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Devbrackets.Android.Exomedia.Core.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.devbrackets.android.exomedia.core.listener']/interface[@name='MetadataListener']"
	[Register ("com/devbrackets/android/exomedia/core/listener/MetadataListener", "", "Com.Devbrackets.Android.Exomedia.Core.Listener.IMetadataListenerInvoker")]
	public partial interface IMetadataListener : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/devbrackets/android/exomedia/core/listener/MetadataListener", DoNotGenerateAcw=true)]
	internal class IMetadataListenerInvoker : global::Java.Lang.Object, IMetadataListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/devbrackets/android/exomedia/core/listener/MetadataListener", typeof (IMetadataListenerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IMetadataListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMetadataListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.devbrackets.android.exomedia.core.listener.MetadataListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMetadataListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

	[global::Android.Runtime.Register ("mono/com/devbrackets/android/exomedia/core/listener/MetadataListenerImplementor")]
	internal sealed partial class IMetadataListenerImplementor : global::Java.Lang.Object, IMetadataListener {

		public IMetadataListenerImplementor ()
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/devbrackets/android/exomedia/core/listener/MetadataListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
		}


		internal static bool __IsEmpty (IMetadataListenerImplementor value)
		{
			return true;
		}
	}

}
