using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using NUnit.Framework;

namespace UnitWrappers.Research.Reflection.Portable
{
    public class GetTypeInfoTests
    {
	    [Test]
		public void Clr_Methods()
		{
			var ti = typeof(CUT).GetTypeInfo();
			
			//MethodInfo[] methods = ti.GetMethods();

			//Assert.AreEqual(5, methods.Count());

			IEnumerable<MethodInfo> declatedMethods = ti.DeclaredMethods;
			Assert.AreEqual(1, declatedMethods.Count());
		}
    }
}
