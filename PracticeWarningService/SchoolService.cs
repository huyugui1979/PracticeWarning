using System;
using ServiceStack;
using PracticeWarning.Model;
using System.Collections.Generic;
using System.Data;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.MySql;

namespace PracticeWarningService
{
	public class SchoolService:BaseService
	{

		public object Get (GetSchoolRequest request)
		{
		
			OrmLiteConfig.DialectProvider = MySqlDialectProvider.Instance;

			IDbConnection db =
				_connectstring.OpenDbConnection ();

			List<School> schools = db.Select<School>(
			);
			db.Close ();
			GetSchoolResponse res = new  GetSchoolResponse(){Schools =schools};
			
			return res;
		
		}
	}
}

