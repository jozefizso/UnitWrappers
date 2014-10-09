
using System;

using NUnit;
using NUnit.Framework;

namespace UnitWrappers.Wraperizer
{
	

	
	[TestFixture]
	public class InstanceWraperizersTests
	{
		private Type testType = typeof(System.Net.Mail.SmtpClient);
		
		
		[Test]
		public void Generate_containsWrapedNamespace()
		{
			String result = InstanceWraperizer.Generate(testType);
			StringAssert.Contains(testType.Namespace,result);
		}
		
		[Test]
		public void Generate_containsClassWithWrapSuffix()
		{
			String result = InstanceWraperizer.Generate(testType);
			StringAssert.Contains(testType.Name+"Wrap",result);
		}
		
		[Test]
		public void Generate_containsIWrapImplementation()
		{
			String result = InstanceWraperizer.Generate(testType);
			StringAssert.Contains("IWrap",result);			
		}
		
		[Test]
		public void Generate_containsAtLeastOneGet()
		{
			String result = InstanceWraperizer.Generate(testType);
			StringAssert.Contains("get",result);			
		}
		
	
		
	}
}
