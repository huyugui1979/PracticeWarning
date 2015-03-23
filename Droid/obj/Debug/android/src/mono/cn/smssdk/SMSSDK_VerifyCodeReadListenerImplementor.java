package mono.cn.smssdk;


public class SMSSDK_VerifyCodeReadListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		cn.smssdk.SMSSDK.VerifyCodeReadListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onReadVerifyCode:(Ljava/lang/String;)V:GetOnReadVerifyCode_Ljava_lang_String_Handler:CN.Smssdk.SMSSDK/IVerifyCodeReadListenerInvoker, SmsSdkLib\n" +
			"";
		mono.android.Runtime.register ("CN.Smssdk.SMSSDK/IVerifyCodeReadListenerImplementor, SmsSdkLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SMSSDK_VerifyCodeReadListenerImplementor.class, __md_methods);
	}


	public SMSSDK_VerifyCodeReadListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SMSSDK_VerifyCodeReadListenerImplementor.class)
			mono.android.TypeManager.Activate ("CN.Smssdk.SMSSDK/IVerifyCodeReadListenerImplementor, SmsSdkLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onReadVerifyCode (java.lang.String p0)
	{
		n_onReadVerifyCode (p0);
	}

	private native void n_onReadVerifyCode (java.lang.String p0);

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
