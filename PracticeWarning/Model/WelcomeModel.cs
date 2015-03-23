using System;
using Xamarin.Forms.Labs.Mvvm;
using System.Threading;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms.Labs.Services;
using Acr.XamForms.UserDialogs.Droid;
using ServiceStack;
using Acr.XamForms.UserDialogs;
using PracticeWarning.Model;
using Xamarin.Forms;

namespace PracticeWarning
{

	public class WelcomeModel:ViewModel
	{
	
		public async void Init()
		{
		
			var dialog =Resolver.Resolve<IUserDialogService> ().Loading("初始化...");
			try{
				dialog.Show();
				await Resolver.Resolve<ISchoolService> ().Init ();
				var user = Resolver.Resolve<IPersistenceService> ().GetComplexValue<User>("LoginUser");
				if(user == null)
					App.Current.MainPage =  new NavigationPage(ViewFactory.CreatePage<LoginModel>());
				else
					App.Current.MainPage = new NavigationPage( ViewFactory.CreatePage<MainModel>());
			}catch(WebServiceException e) {
				Resolver.Resolve<IUserDialogService> ().AlertAsync (e.Message);
			}catch(Exception e) {
				await Resolver.Resolve<IUserDialogService> ().AlertAsync ("网络错误");

			}finally{
				dialog.Hide ();
			}
			//
		}
	}
}

