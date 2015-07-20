
using System;


namespace UnitWrappers.Wraperizer
{
	class Program
	{
		public static void Main(string[] args)
		{
						
			Console.WriteLine("Starting to reflect");			
			Type testType = typeof(global::System.Net.Mail.SmtpClient);
			var result = InstanceWraperizer.Generate(testType);
			
			Console.Write(result);
			Console.ReadKey(true);
		}
	}
}