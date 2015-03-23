using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;
using Com.Baidu.Mapapi;

namespace PracticeWarning.Droid
{
	[Activity (Label = "实训通", Icon = "@drawable/icon",  ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// 在使用 SDK 各组间之前初始化 context 信息，传入 ApplicationContext
			SDKInitializer.Initialize(Android.App.Application.Context);
			global::Xamarin.Forms.Forms.Init (this, bundle);

			LoadApplication (new App ());
		}

		protected override void OnDestroy ()
		{
			MessagingCenter.Send<MainActivity> (this, "OnDestroy");
			base.OnDestroy ();
		}

		protected override void OnResume ()
		{
			MessagingCenter.Send<MainActivity> (this, "OnResume");
			base.OnResume ();
		}

		protected override void OnPause ()
		{
			MessagingCenter.Send<MainActivity> (this, "OnPause");
			base.OnPause ();
		}
	}
}

