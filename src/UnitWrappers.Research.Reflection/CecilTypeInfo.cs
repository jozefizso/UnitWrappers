using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Mono.Cecil;
using Mono.Cecil.Rocks;
using ICustomAttributeProvider = System.Reflection.ICustomAttributeProvider;
using MethodAttributes = System.Reflection.MethodAttributes;
using MethodImplAttributes = System.Reflection.MethodImplAttributes;

namespace UnitWrappers.Research.Reflection
{
	public class CecilTypeInfo
	{
		private TypeDefinition _il;
		private readonly AssemblyDefinition _asm;
		private readonly string _referenceAssembliesPath;

		public CecilTypeInfo(TypeDefinition il, AssemblyDefinition asm, string referenceAssembliesPath)
		{
			_il = il;
			_asm = asm;
			_referenceAssembliesPath = referenceAssembliesPath;
		}

		public IEnumerable<MethodInfo> DeclaredMethods
		{
			get {  return _il.GetMethods().Select(x => new MethodInfoDefinition(x)); }
		}


		public MethodInfo[] GetMethods()
		{
			var declared = _il.GetMethods();
			var baseType = _il.BaseType;
			var assembly = baseType.Scope;
			var referencePath = Path.Combine(_referenceAssembliesPath, assembly.Name+".dll");
			var reference = AssemblyDefinition.ReadAssembly(referencePath);
			var fullName = baseType.FullName;
			var baseTypeIl = reference.Modules[0].GetType(fullName);
			var baseTypeMethods = baseTypeIl.GetMethods().Where(x=>!x.IsStatic && x.IsPublic);
			return declared.Concat(baseTypeMethods).Select(x => new MethodInfoDefinition(x)).ToArray();
		}

		private class MethodInfoDefinition:MethodInfo
		{
			private MethodDefinition _il;
			public MethodInfoDefinition(MethodDefinition il)
			{
				_il = il;
			}

			public override object[] GetCustomAttributes(bool inherit)
			{
				throw new NotImplementedException();
			}

			public override bool IsDefined(Type attributeType, bool inherit)
			{
				throw new NotImplementedException();
			}

			public override ParameterInfo[] GetParameters()
			{
				throw new NotImplementedException();
			}

			public override MethodImplAttributes GetMethodImplementationFlags()
			{
				throw new NotImplementedException();
			}

			public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
			{
				throw new NotImplementedException();
			}

			public override MethodInfo GetBaseDefinition()
			{
				throw new NotImplementedException();
			}

			public override ICustomAttributeProvider ReturnTypeCustomAttributes
			{
				get { throw new NotImplementedException(); }
			}

			public override string Name
			{
				get { throw new NotImplementedException(); }
			}

			public override Type DeclaringType
			{
				get { throw new NotImplementedException(); }
			}

			public override Type ReflectedType
			{
				get { throw new NotImplementedException(); }
			}

			public override RuntimeMethodHandle MethodHandle
			{
				get { throw new NotImplementedException(); }
			}

			public override MethodAttributes Attributes
			{
				get { throw new NotImplementedException(); }
			}

			public override object[] GetCustomAttributes(Type attributeType, bool inherit)
			{
				throw new NotImplementedException();
			}
		}
	}
}
