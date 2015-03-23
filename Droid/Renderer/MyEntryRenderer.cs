using System;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;
using Xamarin.Forms;


[assembly:ExportRenderer(typeof(PracticeWarning.MyEntry), typeof(PracticeWarning.Droid.MyEntryRenderer))]

namespace PracticeWarning.Droid
{
	public class MyEntryRenderer:EntryRenderer
	{
		public MyEntryRenderer ()
		{

		}
		protected async override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Entry> e)
		{
			base.OnElementChanged (e);
			this.Control.SetBackgroundDrawable (null);

		}
	}
}

