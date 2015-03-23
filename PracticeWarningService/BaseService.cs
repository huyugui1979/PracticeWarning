using System;
using ServiceStack;

namespace PracticeWarningService
{
	public class BaseService:Service
	{
		protected string _connectstring="Server = 127.0.0.1;Database = practicewarning; Uid = root; Pwd =hyg&1qaz2wsx";
		public BaseService ()
		{
		}
	}
}

