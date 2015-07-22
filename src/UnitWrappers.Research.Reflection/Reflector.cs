using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Mono.Cecil;
using NUnit.Framework;

namespace UnitWrappers.Research.Reflection
{

	public class Reflector
    {
	

		[Test]
		public void Cecil_Methods()
		{
			var type = typeof (CUT);
			var path = type.Assembly.Location;
			var fullName = type.FullName;
			var assemblies = Directory.GetParent(typeof (object).Assembly.Location).FullName;
			var t = GetTypeInfo(path, fullName, assemblies);

			MethodInfo[] methods = t.GetMethods();
			Assert.AreEqual(5, methods.Count());

			IEnumerable<MethodInfo> declatedMethods = t.DeclaredMethods;
			Assert.AreEqual(1, declatedMethods.Count());
		}

		public CecilTypeInfo GetTypeInfo(string assemblyPath,string typeFullName,string referenceAssembliesPath)
		{
			var asm = AssemblyDefinition.ReadAssembly(assemblyPath);
			var il = asm.Modules[0].GetType(typeFullName);
			var t = getTypeInfo(il, asm, referenceAssembliesPath);
			return t;
		}

		private CecilTypeInfo getTypeInfo(TypeDefinition il, AssemblyDefinition asm, string referenceAssembliesPath)
		{
			return new CecilTypeInfo(il, asm, referenceAssembliesPath);
		}
    }
}
