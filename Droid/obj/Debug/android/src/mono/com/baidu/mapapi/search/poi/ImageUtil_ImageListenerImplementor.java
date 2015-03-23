package mono.com.baidu.mapapi.search.poi;


public class ImageUtil_ImageListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.baidu.mapapi.search.poi.ImageUtil.ImageListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onError:(IILjava/lang/String;Ljava/lang/Object;)V:GetOnError_IILjava_lang_String_Ljava_lang_Object_Handler:Com.Baidu.Mapapi.Search.Poi.ImageUtil/IImageListenerInvoker, BaiduMap300Binding\n" +
			"n_onOk:(IILjava/lang/String;Ljava/lang/Object;)V:GetOnOk_IILjava_lang_String_Ljava_lang_Object_Handler:Com.Baidu.Mapapi.Search.Poi.ImageUtil/IImageListenerInvoker, BaiduMap300Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Baidu.Mapapi.Search.Poi.ImageUtil/IImageListenerImplementor, BaiduMap300Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ImageUtil_ImageListenerImplementor.class, __md_methods);
	}


	public ImageUtil_ImageListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ImageUtil_ImageListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Baidu.Mapapi.Search.Poi.ImageUtil/IImageListenerImplementor, BaiduMap300Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onError (int p0, int p1, java.lang.String p2, java.lang.Object p3)
	{
		n_onError (p0, p1, p2, p3);
	}

	private native void n_onError (int p0, int p1, java.lang.String p2, java.lang.Object p3);


	public void onOk (int p0, int p1, java.lang.String p2, java.lang.Object p3)
	{
		n_onOk (p0, p1, p2, p3);
	}

	private native void n_onOk (int p0, int p1, java.lang.String p2, java.lang.Object p3);

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
