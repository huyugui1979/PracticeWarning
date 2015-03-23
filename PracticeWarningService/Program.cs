using System;
using ServiceStack;

namespace PracticeWarningService
{
	public class AppHost : AppSelfHostBase
	{
		public AppHost () 
			: base ("HttpListener Self-Host", typeof(SchoolService).Assembly)
		{
		}

		public override void Configure (Funq.Container container)
		{

		}
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			var listeningOn = args.Length == 0 ? "http://*:1337/" : args [0];
			var appHost = new AppHost ()
				.Init ()
				.Start (listeningOn);

			Console.WriteLine ("AppHost Created at {0}, listening on {1}", 
				DateTime.Now, listeningOn);

			Console.ReadKey ();
		}
	}
}
