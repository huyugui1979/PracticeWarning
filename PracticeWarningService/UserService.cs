using System;
using PracticeWarning.Model;
using System.Collections.Generic;
using ServiceStack;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.MySql;
using System.Data;

namespace PracticeWarningService
{
	public class UserService:BaseService
	{
		public UserService ()
		{
		}
		public object Get(RegisterUserRequest request)
		{
			//
			OrmLiteConfig.DialectProvider = MySqlDialectProvider.Instance;

			IDbConnection db =
				_connectstring.OpenDbConnection ();
			if (request.Number == "" || request.Password == "" || request.School == 0 || request.Phone== "")
				throw new ServiceStack.ServiceResponseException ("请输入完整参数");

			var user = db.Single<User> (r => r.Number == request.Number && r.SchoolId== request.School);
			if (user == null)
				throw new ServiceResponseException ("选择学校不存在此用户");
				
			var stu = db.Single<Student> (s => s.StudentId == user.Id);
			stu.DeviceId = request.DeviceId;
			stu.IsRegistered = true;
			db.Update<Student> (stu);
			//
			CheckUserResponse ponse = new CheckUserResponse (){ UserInfo = user };
			return ponse;
			//
		}
		public object Get(CheckUserRequest request)
		{
			OrmLiteConfig.DialectProvider = MySqlDialectProvider.Instance;

			IDbConnection db =
				_connectstring.OpenDbConnection ();
			if (request.Number == "" || request.Password == "" || request.School == 0 || request.UserType == "")
				throw new ServiceStack.ServiceResponseException ("请输入完整参数");
			var user = db.Single<User> (r => r.Number == request.Number && r.SchoolId== request.School);
			if (user == null)
				throw new ServiceResponseException ("选择学校不存在此用户");
			if (user.Password != request.Password) {
				throw new ServiceResponseException ("请输入正确的密码");
			}
			if (user.UserType == "学生") {
				var stu = db.Single<Student> (s => s.StudentId == user.Id);
				if (stu == null) {
					throw new ServiceResponseException ("不存在此学生");
				}
				if (stu.IsRegistered == false)
					throw new ServiceResponseException ("你没有注册");

				if (stu.DeviceId != request.DeviceId)
					throw new ServiceResponseException ("请在你注册的手机登录");
			}
			//
			CheckUserResponse ponse = new CheckUserResponse (){ UserInfo = user };
			return ponse;

		}
	}
}

