package practicewarning;


public class SMSHandler
	extends cn.smssdk.EventHandler
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_afterEvent:(IILjava/lang/Object;)V:GetAfterEvent_IILjava_lang_Object_Handler\n" +
			"";
		mono.android.Runtime.register ("PracticeWarning.SMSHandler, PracticeWarning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SMSHandler.class, __md_methods);
	}


	public SMSHandler () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SMSHandler.class)
			mono.android.TypeManager.Activate ("PracticeWarning.SMSHandler, PracticeWarning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void afterEvent (int p0, int p1, java.lang.Object p2)
	{
		n_afterEvent (p0, p1, p2);
	}

	private native void n_afterEvent (int p0, int p1, java.lang.Object p2);

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
