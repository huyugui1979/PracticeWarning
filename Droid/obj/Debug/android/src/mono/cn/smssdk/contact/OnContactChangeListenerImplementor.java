package mono.cn.smssdk.contact;


public class OnContactChangeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		cn.smssdk.contact.OnContactChangeListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onContactChange:(Z)V:GetOnContactChange_ZHandler:CN.Smssdk.Contact.IOnContactChangeListenerInvoker, SmsSdkLib\n" +
			"";
		mono.android.Runtime.register ("CN.Smssdk.Contact.IOnContactChangeListenerImplementor, SmsSdkLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnContactChangeListenerImplementor.class, __md_methods);
	}


	public OnContactChangeListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OnContactChangeListenerImplementor.class)
			mono.android.TypeManager.Activate ("CN.Smssdk.Contact.IOnContactChangeListenerImplementor, SmsSdkLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onContactChange (boolean p0)
	{
		n_onContactChange (p0);
	}

	private native void n_onContactChange (boolean p0);

	java.util.ArrayList refList;
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
