using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Com.Baidu.Mapapi.Map;
using Com.Baidu.Location;
using Acr.XamForms.UserDialogs;
using Xamarin.Forms.Labs.Services;
using Com.Baidu.Mapapi.Model;

[assembly : Xamarin.Forms.ExportRenderer (typeof(PracticeWarning.MyBaiduMap), typeof(PracticeWarning.Droid.MyBaiduMapRenderer))]
namespace PracticeWarning.Droid
{
	public class MyBaiduMapRenderer:ViewRenderer<MyBaiduMap,MapView>,IBDLocationListener
	{
		void IBDLocationListener.OnReceiveLocation (BDLocation location)
		{
			if (location == null)
				return;
			//Resolver.Resolve<IUserDialogService> ().Alert ("receive dialog");
			MyLocationData locData = new MyLocationData.Builder()
				.Accuracy(location.Radius)
				// 此处设置开发者获取到的方向信息，顺时针0-360
				.Direction(100).Latitude(location.Latitude)
				.Longitude(location.Longitude).Build();
			mBaiduMap.SetMyLocationData(locData);
			LatLng cenpt =  new LatLng(location.Latitude,location.Longitude);  
			//定义地图状态 
			MapStatus mMapStatus = new MapStatus.Builder() 
				.Target(cenpt) 
				.Zoom(14) 
				.Build(); 
			//定义MapStatusUpdate对象，以便描述地图状态将要发生的变化 
			//
			MapStatusUpdate mMapStatusUpdate = MapStatusUpdateFactory.NewMapStatus(mMapStatus); 
			//改变地图状态 
			mBaiduMap.SetMapStatus(mMapStatusUpdate);

		}
		void IBDLocationListener.OnReceivePoi (BDLocation p0)
		{

		}

		LocationClient mLocClient;
	
		private MyLocationConfigeration.LocationMode mCurrentMode;
		BitmapDescriptor mCurrentMarker;

		public MyBaiduMapRenderer ()
		{
			MessagingCenter.Subscribe<MainActivity> (this, "OnPause", main => {
				mMapView.OnPause ();
			});
			MessagingCenter.Subscribe<MainActivity> (this, "OnDestroy", main => {
				mMapView.OnDestroy ();
			});
			MessagingCenter.Subscribe<MainActivity> (this, "OnResume", main => {
				mMapView.OnResume ();
			});
		}

		MapView mMapView;
		BaiduMap mBaiduMap;

		protected override void OnElementChanged (ElementChangedEventArgs<MyBaiduMap> e)
		{
			base.OnElementChanged (e);
			if (e.OldElement == null) {
				mMapView = new MapView (Forms.Context, new BaiduMapOptions ());
						
				mBaiduMap = mMapView.Map;
				this.SetNativeControl (mMapView);
				mBaiduMap.MyLocationEnabled = true;
				// 定位初始化
				mLocClient = new LocationClient(Forms.Context);
				mLocClient.RegisterLocationListener(this);
				LocationClientOption option = new LocationClientOption();
				option.OpenGps = true;// 打开gps
				option.CoorType = "bd09ll"; // 设置坐标类型
				option.ScanSpan = 1000;
				mLocClient.LocOption = option;
				mLocClient.Start();
			}

		}
		protected override void OnLayout (bool changed, int l, int t, int r, int b)
		{
			mMapView.Layout (l, t, r, b);
			base.OnLayout (changed, l, t, r, b);
		}

	}
}

