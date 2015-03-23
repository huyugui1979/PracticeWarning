package practicewarning.droid;


public class MyBaiduMapRenderer
	extends xamarin.forms.platform.android.ViewRenderer_2
	implements
		mono.android.IGCUserPeer,
		com.baidu.location.BDLocationListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onLayout:(ZIIII)V:GetOnLayout_ZIIIIHandler\n" +
			"n_onReceiveLocation:(Lcom/baidu/location/BDLocation;)V:GetOnReceiveLocation_Lcom_baidu_location_BDLocation_Handler:Com.Baidu.Location.IBDLocationListenerInvoker, BaiduMap300Binding\n" +
			"n_onReceivePoi:(Lcom/baidu/location/BDLocation;)V:GetOnReceivePoi_Lcom_baidu_location_BDLocation_Handler:Com.Baidu.Location.IBDLocationListenerInvoker, BaiduMap300Binding\n" +
			"";
		mono.android.Runtime.register ("PracticeWarning.Droid.MyBaiduMapRenderer, PracticeWarning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MyBaiduMapRenderer.class, __md_methods);
	}


	public MyBaiduMapRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == MyBaiduMapRenderer.class)
			mono.android.TypeManager.Activate ("PracticeWarning.Droid.MyBaiduMapRenderer, PracticeWarning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public MyBaiduMapRenderer (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == MyBaiduMapRenderer.class)
			mono.android.TypeManager.Activate ("PracticeWarning.Droid.MyBaiduMapRenderer, PracticeWarning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public MyBaiduMapRenderer (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == MyBaiduMapRenderer.class)
			mono.android.TypeManager.Activate ("PracticeWarning.Droid.MyBaiduMapRenderer, PracticeWarning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public void onLayout (boolean p0, int p1, int p2, int p3, int p4)
	{
		n_onLayout (p0, p1, p2, p3, p4);
	}

	private native void n_onLayout (boolean p0, int p1, int p2, int p3, int p4);


	public void onReceiveLocation (com.baidu.location.BDLocation p0)
	{
		n_onReceiveLocation (p0);
	}

	private native void n_onReceiveLocation (com.baidu.location.BDLocation p0);


	public void onReceivePoi (com.baidu.location.BDLocation p0)
	{
		n_onReceivePoi (p0);
	}

	private native void n_onReceivePoi (com.baidu.location.BDLocation p0);

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
