package mono.com.sumsub.kyc.client.ui.picker;


public class PickerOnItemClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.sumsub.kyc.client.ui.picker.PickerOnItemClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Com.Sumsub.Kyc.Client.UI.Picker.IPickerOnItemClickListenerImplementor, SumSubSDK.Client.droid", PickerOnItemClickListenerImplementor.class, __md_methods);
	}


	public PickerOnItemClickListenerImplementor ()
	{
		super ();
		if (getClass () == PickerOnItemClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Sumsub.Kyc.Client.UI.Picker.IPickerOnItemClickListenerImplementor, SumSubSDK.Client.droid", "", this, new java.lang.Object[] {  });
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
