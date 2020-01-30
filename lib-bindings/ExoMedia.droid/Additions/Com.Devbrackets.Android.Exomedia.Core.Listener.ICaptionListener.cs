using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

using Com.Google.Android.Exoplayer2.Text;


namespace Com.Devbrackets.Android.Exomedia.Core.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.devbrackets.android.exomedia.core.listener']/interface[@name='CaptionListener']"
	[Register ("com/devbrackets/android/exomedia/core/listener/CaptionListener", "", "Com.Devbrackets.Android.Exomedia.Core.Listener.ICaptionListenerInvoker")]
	public partial interface ICaptionListener : IJavaObject {

        void onCues(List<Cue> cues);
    }

	[global::Android.Runtime.Register ("com/devbrackets/android/exomedia/core/listener/CaptionListener", DoNotGenerateAcw=true)]
	internal class ICaptionListenerInvoker : global::Java.Lang.Object, ICaptionListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/devbrackets/android/exomedia/core/listener/CaptionListener", typeof (ICaptionListenerInvoker));

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

		public static ICaptionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICaptionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.devbrackets.android.exomedia.core.listener.CaptionListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICaptionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

        public void onCues(List<Cue> cues)
        {
            // TODO: [alex-d] implement me
        }
    }

	[global::Android.Runtime.Register ("mono/com/devbrackets/android/exomedia/core/listener/CaptionListenerImplementor")]
	internal sealed partial class ICaptionListenerImplementor : global::Java.Lang.Object, ICaptionListener {

        public void onCues(List<Cue> cues)
        {
            // TODO: [alex-d] implement me
        }

        public ICaptionListenerImplementor ()
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/devbrackets/android/exomedia/core/listener/CaptionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
		}


		internal static bool __IsEmpty (ICaptionListenerImplementor value)
		{
			return true;
		}
	}

}
