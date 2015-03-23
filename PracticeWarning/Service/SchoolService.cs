using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using PracticeWarning.Model;
using ServiceStack;
using Xamarin.Forms.Labs.Services;

namespace PracticeWarning
{
	public interface ISchoolService
	{
		Task<GetSchoolResponse> GetSchoolAsync(GetSchoolRequest request);
	    Task  Init();
	}
	public class Config
	{
		public  static readonly string http="http://192.168.1.144:1337/";
	}
	public class SchoolService:ISchoolService
	{
		public SchoolService ()
		{
		}
	
		public  Task  Init()
		{
			var task = GetSchoolAsync (new GetSchoolRequest{ });
			return task.ContinueWith (r => {
				Resolver.Resolve<IPersistenceService> ().SetComplexValue<List<School>> ("Schools", r.Result.Schools);
				return ;
			});
		}
		//

		//
		public Task<GetSchoolResponse> GetSchoolAsync(GetSchoolRequest request)
		{
			//
			var client = new JsonServiceClient(Config.http);
			var task = client.GetAsync (request);
			return task;
			//
		}
	
		 
	}
}

