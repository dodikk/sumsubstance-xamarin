package mono.com.devbrackets.android.exomedia.core.listener;


public class CaptionListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.devbrackets.android.exomedia.core.listener.CaptionListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Com.Devbrackets.Android.Exomedia.Core.Listener.ICaptionListenerImplementor, ExoMedia.droid", CaptionListenerImplementor.class, __md_methods);
	}


	public CaptionListenerImplementor ()
	{
		super ();
		if (getClass () == CaptionListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Devbrackets.Android.Exomedia.Core.Listener.ICaptionListenerImplementor, ExoMedia.droid", "", this, new java.lang.Object[] {  });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
