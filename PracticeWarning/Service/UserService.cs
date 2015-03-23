using System;
using System.Threading.Tasks;
using ServiceStack;
using PracticeWarning.Model;

namespace PracticeWarning
{
	public interface IUserService
	{
		Task<CheckUserResponse> CheckUserAsync (CheckUserRequest request);
	    Task<RegisterUserResponse> RegisterUserAsync(RegisterUserRequest request);
	}
	public class UserService:IUserService
	{
		public UserService ()
		{
		}
		public Task<RegisterUserResponse> RegisterUserAsync(RegisterUserRequest request)
		{
			var client = new JsonServiceClient(Config.http);
			var task = client.GetAsync (request);
			return task;
		}
		public Task<CheckUserResponse> CheckUserAsync(CheckUserRequest request)
		{
			//
			var client = new JsonServiceClient(Config.http);
			var task = client.GetAsync (request);
			return task;
			//
		}
	}
}

