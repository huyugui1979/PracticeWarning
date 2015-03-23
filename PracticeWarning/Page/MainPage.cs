using System;
using Xamarin.Forms;
using Xamarin.Forms.Labs.Mvvm;
using Xamarin.Forms.Labs.Services;
using PracticeWarning.Model;

namespace PracticeWarning
{
	public class MainPage:MasterDetailPage
	{
		public MainPage ()
		{
			this.Master = ViewFactory.CreatePage<MyNaviModel> ();
			var navi = new NavigationPage ();
			this.Detail = navi;
			var user = Resolver.Resolve<IPersistenceService> ().GetComplexValue<User>("LoginUser");
			if (user == null) {
				navi.PushAsync(ViewFactory.CreatePage<LoginModel> ());
			} else {
				if (user.UserType == "学生") {
					//
				} else {

				}
			}

			//

		}
	}
}

