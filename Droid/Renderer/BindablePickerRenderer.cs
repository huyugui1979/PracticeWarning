using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;

[assembly:ExportRenderer(typeof(PracticeWarning.BindablePicker), typeof(PracticeWarning.Droid.BindablePickerRenderer))]
namespace PracticeWarning.Droid
{
	public class BindablePickerRenderer:PickerRenderer
	{
		public BindablePickerRenderer ()
		{
		}
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Picker> e)
		{
			base.OnElementChanged (e);
			//
			this.Control.SetBackgroundDrawable (null);
			//
		}
	}
}

