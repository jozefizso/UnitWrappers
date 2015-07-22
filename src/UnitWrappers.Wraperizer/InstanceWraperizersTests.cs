
using System;
using System.Reflection;
using System.Text.RegularExpressions;
using NUnit;
using NUnit.Framework;

namespace UnitWrappers.Wraperizer
{
	

	
	[TestFixture]
	public class InstanceWraperizersTests
	{
		private Type testType = typeof(global::System.Net.Mail.SmtpClient).GetTypeInfo();
		
		
		[Test]
		public void Generate_containsWrapedNamespace()
		{
			var result = InstanceWraperizer.Generate(testType);
			StringAssert.Contains(testType.Namespace,result.Item1);
		}
		
		[Test]
		public void Generate_containsClassWithWrapSuffix()
		{
			var result = InstanceWraperizer.Generate(testType);
			StringAssert.Contains(testType.Name + "Wrap", result.Item1);
		}
		
		[Test]
		public void Generate_containsIWrapImplementation()
		{
			var result = InstanceWraperizer.Generate(testType);
			StringAssert.Contains("IWrap", result.Item1);			
		}
		
		[Test]
		public void Generate_containsInterfaceImplementation()
		{
			var result = InstanceWraperizer.Generate(testType);
			StringAssert.Contains("I" + testType.Name, result.Item1);			
		}
		
		[Test]
		public void Generate_containsAtLeastOneGet()
		{
			var result = InstanceWraperizer.Generate(testType);
			StringAssert.Contains("get", result.Item1);			
		}
		
		
		[Test]
		public void Generate_containsInterfaceDeclaration()
		{
			var result = InstanceWraperizer.Generate(testType);
			StringAssert.Contains("interface I" + testType.Name, result.Item2);			
		}
		
		
		[Test]
		public void Generate_containsAtLeastOneConstuctor()
		{
			var result = InstanceWraperizer.Generate(testType);
			StringAssert.Contains(testType.Name + "Wrap(", result.Item1);			
		}
	
		[Test]
		public void Generate_containsAllConstuctorsOfWrapped()
		{
			var result = InstanceWraperizer.Generate(testType);
			var ctor = "public "+testType.Name+"Wrap[(]";
			Assert.AreEqual(testType.GetConstructors().Length + 1, Regex.Matches(result.Item1, ctor).Count);
		}


		
	}
}
