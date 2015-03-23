using System;

using Xamarin.Forms;
using Xamarin.Forms.Labs.Mvvm;
using Xamarin.Forms.Labs.Services;
using Acr.XamForms.UserDialogs;
using Acr.XamForms.UserDialogs.Droid;

namespace PracticeWarning
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			Init ();

			MainPage =  ViewFactory.CreatePage<WelcomeModel> ((v, p) => (v as WelcomeModel).Init ());
		
		}
		void Init()
		{
			var resolverContainer = new SimpleContainer ();
			resolverContainer.Register<IPersistenceService,PersistenceService> ();
			resolverContainer.Register<IUserDialogService,UserDialogService> ();
			resolverContainer.Register<ISchoolService,SchoolService> ();
			resolverContainer.Register<IUserService,UserService> ();
			Resolver.SetResolver(resolverContainer.GetResolver());
			ViewFactory.Register<MyNaviPage,MyNaviModel> ();
			ViewFactory.Register<MyMapPage,MyMapModel> ();
			ViewFactory.Register<WelcomePage,WelcomeModel> ();
			ViewFactory.Register<LoginPage,LoginModel> ();
			ViewFactory.Register<MainPage,MainModel> ();
			ViewFactory.Register<RegisterPage,RegisterModel> ();

		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

