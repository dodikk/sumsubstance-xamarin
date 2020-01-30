package mono.com.sumsub.kyc.client.ui.chat;


public class ChatListClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.sumsub.kyc.client.ui.chat.ChatListClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCloseButtonClick:()V:GetOnCloseButtonClickHandler:Com.Sumsub.Kyc.Client.UI.Chat.IChatListClickListenerInvoker, SumSubSDK.Client.droid\n" +
			"n_onLinkClick:(Ljava/lang/String;Ljava/lang/String;)V:GetOnLinkClick_Ljava_lang_String_Ljava_lang_String_Handler:Com.Sumsub.Kyc.Client.UI.Chat.IChatListClickListenerInvoker, SumSubSDK.Client.droid\n" +
			"";
		mono.android.Runtime.register ("Com.Sumsub.Kyc.Client.UI.Chat.IChatListClickListenerImplementor, SumSubSDK.Client.droid", ChatListClickListenerImplementor.class, __md_methods);
	}


	public ChatListClickListenerImplementor ()
	{
		super ();
		if (getClass () == ChatListClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Sumsub.Kyc.Client.UI.Chat.IChatListClickListenerImplementor, SumSubSDK.Client.droid", "", this, new java.lang.Object[] {  });
	}


	public void onCloseButtonClick ()
	{
		n_onCloseButtonClick ();
	}

	private native void n_onCloseButtonClick ();


	public void onLinkClick (java.lang.String p0, java.lang.String p1)
	{
		n_onLinkClick (p0, p1);
	}

	private native void n_onLinkClick (java.lang.String p0, java.lang.String p1);

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
