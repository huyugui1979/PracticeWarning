using System;
using ServiceStack;

namespace PracticeWarning.Model
{
	public class CheckUserResponse
	{
		public	User UserInfo;
	}

	public class  CheckUserRequest:IReturn<CheckUserResponse>
	{
		public string Password{ get; set; }

		public string Number{ get; set; }

		public int    School{ get; set; }

		public string    UserType{ get; set; }

		public string DeviceId{ get; set; }
	}
	public class RegisterUserResponse
	{
		public	User UserInfo;
	}

	public class RegisterUserRequest:IReturn<RegisterUserResponse>
	{
		public string Number{ get; set; }

		public string  Phone{get;set;}

		public int  School{ get; set; }

		public string  Password{ get; set; }

		public string  DeviceId{ get; set; }
	}
	public class User
	{

		public string   UserType{ get; set; }

		public string   Number{ get; set; }

		public string Password{ get; set; }

		public string Image{ get; set; }

		public int      Id{ get; set; }
		public int SchoolId{get;set;}


	
	}
}

