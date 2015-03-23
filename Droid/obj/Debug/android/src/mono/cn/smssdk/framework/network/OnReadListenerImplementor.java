package mono.cn.smssdk.framework.network;


public class OnReadListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		cn.smssdk.framework.network.OnReadListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onRead:(J)V:GetOnRead_JHandler:CN.Smssdk.Framework.Network.IOnReadListenerInvoker, SmsSdkLib\n" +
			"";
		mono.android.Runtime.register ("CN.Smssdk.Framework.Network.IOnReadListenerImplementor, SmsSdkLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnReadListenerImplementor.class, __md_methods);
	}


	public OnReadListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OnReadListenerImplementor.class)
			mono.android.TypeManager.Activate ("CN.Smssdk.Framework.Network.IOnReadListenerImplementor, SmsSdkLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onRead (long p0)
	{
		n_onRead (p0);
	}

	private native void n_onRead (long p0);

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
