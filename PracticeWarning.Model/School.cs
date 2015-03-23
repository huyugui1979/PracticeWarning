using System;
using ServiceStack;
using System.Collections.Generic;

namespace PracticeWarning.Model
{

	public class GetSchoolResponse
	{
		public	List<School> Schools{ get; set; }
	}
		
	public class GetSchoolRequest:IReturn<GetSchoolResponse>
	{

	}
	public class School
	{
		public School ()
		{
		}
		public int Id{ get; set; }
		public string Name{get;set;}
	}
}

