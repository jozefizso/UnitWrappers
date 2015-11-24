
using System;
using System.Reflection;


namespace UnitWrappers.Wraperizer
{
	class Program
	{
		public static void Main(string[] args)
		{
			var t = typeof (string);
			var ti = t.GetTypeInfo();
			
			Console.WriteLine("Starting to reflect");			
			Type testType = typeof(global::System.Net.Mail.SmtpClient);
			var result = InstanceWraperizer.Generate(testType.GetTypeInfo());
			
			Console.Write(result);
			Console.ReadKey(true);
		}
	}
}