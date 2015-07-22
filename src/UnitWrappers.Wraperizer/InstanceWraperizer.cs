
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;
using System.Reflection;
using System.Linq;
using Microsoft.CSharp;



namespace UnitWrappers.Wraperizer
{


	public static class InstanceWraperizer
	{

		private static string generateCSharpCode(CodeCompileUnit compileunit)
		{
			var provider = new CSharpCodeProvider();
			var stream = new MemoryStream();
			using (var sw = new StreamWriter(stream))
			{
				var tw = new IndentedTextWriter(sw, "    ");
				provider.GenerateCodeFromCompileUnit(compileunit, tw, new CodeGeneratorOptions());
				sw.Flush();
				stream.Position = 0;
				return new StreamReader(stream).ReadToEnd();
			}
		}

		public static Tuple<string, string> Generate(TypeInfo type)
		{

			Func<string> wrapperString = () =>
			{
				var code = new CodeCompileUnit();
				var ns = createNamespace(type);
				code.Namespaces.Add(ns);
				var wrap = new CodeTypeDeclaration(type.Name + "Wrap");
				wrap.IsClass = true;
				wrap.TypeAttributes = TypeAttributes.Public | TypeAttributes.Class;
				ns.Types.Add(wrap);
				enrichWrapType(wrap, type.GetTypeInfo());

				return generateCSharpCode(code);
			};
			Func<string> interfaceString = () =>
			{
				var code = new CodeCompileUnit();
				var ns = createNamespace(type);
				code.Namespaces.Add(ns);
				var intf = new CodeTypeDeclaration("I" + type.Name);
				intf.IsClass = false;
				intf.TypeAttributes = TypeAttributes.Public | TypeAttributes.Interface;
				ns.Types.Add(intf);
				return generateCSharpCode(code);
			};
			
			return Tuple.Create(wrapperString(), interfaceString());
		}

		private static CodeNamespace createNamespace(Type type)
		{
			var ns = new CodeNamespace("UnitWrappers." + type.Namespace);
			ns.Imports.Add(new CodeNamespaceImport("System"));
			ns.Imports.Add(new CodeNamespaceImport(type.Namespace));
			return ns;
		}


		static void enrichWrapType(CodeTypeDeclaration wrap, TypeInfo type)
		{
			// implement IWrap<T>
			var typeRef = new CodeTypeReference(type, CodeTypeReferenceOptions.GlobalReference);
			var iwrap = new CodeTypeReference(typeof(IWrap<>).Name + "<" + "global::" + type.FullName + ">", CodeTypeReferenceOptions.GenericTypeParameter);
			wrap.BaseTypes.Add(iwrap);

			// implement interface with public members for  underlying object 
			var intf = new CodeTypeReference("I" + type.Name);
			wrap.BaseTypes.Add(intf);

			// create underlying object related stuff
			var _underlyingObject = new CodeMemberField(typeRef, "_underlyingObject") { Attributes = MemberAttributes.Private };
			wrap.Members.Add(_underlyingObject);
			var this_underlyingObject = new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), _underlyingObject.Name);
			var UnderlyingObject = new CodeMemberProperty();
			UnderlyingObject.Name = "UnderlyingObject";
			UnderlyingObject.HasGet = true;
			UnderlyingObject.HasSet = false;
			var ret = new CodeMethodReturnStatement(this_underlyingObject);
			UnderlyingObject.GetStatements.Add(ret);
			UnderlyingObject.Attributes = MemberAttributes.Public;
			UnderlyingObject.ImplementationTypes.Add(iwrap);
			UnderlyingObject.PrivateImplementationType = iwrap;
			UnderlyingObject.Type = typeRef;
			wrap.Members.Add(UnderlyingObject);

			addUnderlyingCtor(typeRef, this_underlyingObject, wrap);
			addCtors(type, typeRef, this_underlyingObject, wrap);
			addMethods(type, typeRef, this_underlyingObject, wrap);



		}

		private static void addMethods(TypeInfo type, CodeTypeReference typeRef, CodeFieldReferenceExpression this_underlyingObject,
			CodeTypeDeclaration wrap)
		{

			var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance & ~BindingFlags.SetProperty & ~BindingFlags.GetProperty).Where(x => x.Name != "GetType" && x.Name != "Equals" && x.Name != "ToString" && !x.Name.StartsWith("add_") && !x.Name.StartsWith("remove_"));
			foreach (var m in methods)
			{
				var method = new CodeMemberMethod();
				method.Attributes = MemberAttributes.Public ;
				if (!m.IsVirtual) method.Attributes |= MemberAttributes.Final;
				method.Name = m.Name;
				
				foreach (var p in m.GetParameters())
				{
					var param = new CodeParameterDeclarationExpression(new CodeTypeReference(p.ParameterType), p.Name);
					method.Parameters.Add(param);
				}
				var parameters = method.Parameters.Cast<CodeParameterDeclarationExpression>().Select(x => new CodeVariableReferenceExpression(x.Name)).ToArray();
				var call = new CodeMethodInvokeExpression(this_underlyingObject, m.Name, parameters);
				if (m.ReturnParameter.ParameterType != typeof(void))
				{
					var ret = new CodeMethodReturnStatement(call);
					method.ReturnType = new CodeTypeReference(m.ReturnParameter.ParameterType);
					method.Statements.Add(ret);
				}
				else
				{
					method.Statements.Add(call);
				}
				wrap.Members.Add(method);
			}
		}

		private static void addCtors(TypeInfo type, CodeTypeReference typeRef, CodeFieldReferenceExpression this_underlyingObject, CodeTypeDeclaration wrap)
		{
		
			var ctors = type.GetConstructors(BindingFlags.Public | BindingFlags.Instance | BindingFlags.CreateInstance);
			foreach (var c in ctors)
			{
				var ctor = new CodeConstructor();
				ctor.Attributes = MemberAttributes.Public;
				foreach (var p in c.GetParameters())
				{
					var param = new CodeParameterDeclarationExpression(new CodeTypeReference(p.ParameterType), p.Name);
					ctor.Parameters.Add(param);
				}
				var create = new CodeObjectCreateExpression(typeRef, ctor.Parameters.Cast<CodeParameterDeclarationExpression>().Select(x => new CodeVariableReferenceExpression(x.Name)).ToArray());
				var wrapped = new CodeAssignStatement(this_underlyingObject, create);
				ctor.Statements.Add(wrapped);
				wrap.Members.Add(ctor);
			}
		}

		private static void addUnderlyingCtor(CodeTypeReference typeRef, CodeFieldReferenceExpression this_underlyingObject,
			CodeTypeDeclaration wrap)
		{
			var ctor = new CodeConstructor();
			ctor.Attributes = MemberAttributes.Public;
			ctor.Parameters.Add(new CodeParameterDeclarationExpression(typeRef, "underlyingObject"));
			var right = new CodeVariableReferenceExpression("underlyingObject");
			var wrapped = new CodeAssignStatement(this_underlyingObject, right);
			ctor.Statements.Add(wrapped);
			wrap.Members.Add(ctor);
		}
	}
}
