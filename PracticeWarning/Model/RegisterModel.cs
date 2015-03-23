using System;
using Xamarin.Forms.Labs.Mvvm;
using System.Windows.Input;
using Xamarin.Forms;
using Acr.XamForms.UserDialogs;
using Xamarin.Forms.Labs.Services;
using PracticeWarning.Model;
using ServiceStack;
using CN.Smssdk;
using System.Collections.Generic;

namespace PracticeWarning
{
	public class SMSHandler:CN.Smssdk.EventHandler
	{
		public override void AfterEvent (int p0, int p1, Java.Lang.Object p2)
		{
			if (p1 == SMSSDK.ResultComplete) {
				//回调完成
				if (p0 == SMSSDK.EventSubmitVerificationCode) {
					//提交验证码成功
					//
				} else if (p0 == SMSSDK.EventGetVerificationCode) {
					//获取验证码成功
					//
				} 
			} else {                                                                 
			
			}
			base.AfterEvent (p0, p1, p2);
		}
	}
	public class RegisterModel:ViewModel
	{
		public RegisterModel ()
		{

		}

		public string Number{ get; set; }

		public School SchoolType{ get; set; }

		public List<School> SchoolTypes{ get; set; }

		public string Password{ get; set; }

		public string Phone { get; set; }

		public string UserName{ get; set; }
		//
		public string VCode{ get; set; }
		//
		public ICommand GetVCodeCommand{
			get{
				return new Command (async () => {
					//
					SMSSDK.InitSDK (Forms.Context, "646213f280a0", "e24ced36f86c5a24e9fefe99faad5791");
					CN.Smssdk.EventHandler handler = new SMSHandler ();

					SMSSDK.RegisterEventHandler (handler);
					SMSSDK.GetVerificationCode("86","13726278181");

					//
				});
			}
		}
		public ICommand RegisterCommand {
			get { 
				return new Command (async () => {
					var dialog = Resolver.Resolve<IUserDialogService> ().Loading ("正在注册...");
					try {
						SMSSDK.SubmitVerificationCode("86",Phone,VCode);

						dialog.Show ();
						var res = await Resolver.Resolve<IUserService> ().RegisterUserAsync (new RegisterUserRequest {Password = Password,
							Phone = Phone,
							Number = Number,
						  School = SchoolType.Id
						});
						//
						Resolver.Resolve<IPersistenceService>().SetComplexValue<User>("LoginUser",res.UserInfo);
						Resolver.Resolve<IUserDialogService> ().Alert("注册成功");
						Navigation.PushAsync<MainModel>();
						//
					} catch (WebServiceException e) {
						Resolver.Resolve<IUserDialogService> ().AlertAsync (e.Message);
					} catch (Exception e) {
						//
						Resolver.Resolve<IUserDialogService> ().AlertAsync ("网络连接错误");
						//
					} finally {
						dialog.Hide ();
					}
				});
			}
		}
	}
}

