using System;
using Xamarin.Forms;
using Xamarin.Forms.Labs.Mvvm;
using Xamarin.Forms.Labs.Services;
using System.Windows.Input;
using Acr.XamForms.UserDialogs;
using ServiceStack;
using System.Collections.Generic;
using System.Linq;
using PracticeWarning.Model;


namespace PracticeWarning
{
	public class LoginModel : ViewModel
	{
		public string Number{get;set;}
		public string Password{get;set;}
		public string    UserType{ get; set; }
		public string    SchoolType{get;set;}
		public List<string> SchoolTypes{ get; set; }
		public List<string> UserTypes{ get; set; }
		public LoginModel()
		{
			UserTypes = new List<string>{ "学生", "老师", };

			//
			var schools = Resolver.Resolve<IPersistenceService> ().GetComplexValue<List<School>> ("Schools");
			SchoolTypes = (from s in schools
				select s.Name).ToList ();

		}
		public ICommand LoginCommand {
			get { 
				return new Command (async () => {
					var dialog =  Resolver.Resolve<IUserDialogService> ().Loading("正在登录...");
					try {
						dialog.Show();
						var user = await	Resolver.Resolve<IUserService> ().CheckUserAsync ( new CheckUserRequest{Number=Number,Password=Password,
						UserType=UserType,
						School=SchoolTypes.IndexOf(SchoolType)
							});
						Resolver.Resolve<IPersistenceService>().SetComplexValue<User>("LoginUser",user.UserInfo);
						Resolver.Resolve<IUserDialogService> ().Alert("登录成功");
						Navigation.PushAsync<MainModel>();
						//
					} catch (WebServiceException e) {
						Resolver.Resolve<IUserDialogService> ().AlertAsync (e.Message);
					} catch (Exception e) {
						//
						Resolver.Resolve<IUserDialogService> ().AlertAsync ("网络连接错误");
						//
					}finally{
						dialog.Hide();
					}
				});
			}
		}

		public ICommand RegisterCommand {
			get { 
				return new Command (() => {
					Navigation.PushAsync<RegisterModel> ();
				});
			}
		}

		public ICommand ForgetCommand {
			get { 
				return new Command (() => {
					Navigation.PushAsync<ForgetModel> ();
				});
			}
		}
	}

}

