
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;
using System.Reflection;
using System.Linq;
using Microsoft.CSharp;



namespace UnitWrappers.Wraperizer
{
	
	
	/*
	 * TODO: add partial
	 * TODO: add conversion
	 * 
        public static implicit operator SmtpClientWrap(SmtpClient o)
        {
            return new SmtpClientWrap(o);
        }

        public static implicit operator SmtpClient(SmtpClientWrap o)
        {
            return o._underlyingObject;
        }
       TODO: add methods
       TODO: add properites
TODO: add events
TODO: add IDisposable
TODO: add depenencies wrapping (if return type or parameter are used and are wrapped then should build them before
TODO: add contol over events (threading, error handling)
TODO: add Component inheritance if needed
TODO: add custom interface hook
TODO: fix parallel hierarchies of inheritance

	 */
	 
	public static class InstanceWraperizer
	{
		
		public static string GenerateCSharpCode(CodeCompileUnit compileunit)
		{
			CSharpCodeProvider provider = new CSharpCodeProvider();
			var stream = new MemoryStream();
			using (var sw = new StreamWriter(stream))
			{
				
				var tw = new IndentedTextWriter(sw, "    ");
				provider.GenerateCodeFromCompileUnit(compileunit, tw, new CodeGeneratorOptions());
				
				sw.Flush();
				stream.Position =0;
				return new StreamReader(stream).ReadToEnd();
			}


		}
		
		public static string Generate(Type type)
		{
			var code = new CodeCompileUnit();
			var ns = new CodeNamespace("UnitWrappers."+type.Namespace);
			ns.Imports.Add(new CodeNamespaceImport("System"));
			ns.Imports.Add(new CodeNamespaceImport(type.Namespace));
			code.Namespaces.Add(ns);
			
			CodeTypeDeclaration wrap = new CodeTypeDeclaration(type.Name+"Wrap");
			wrap.IsClass = true;
			wrap.TypeAttributes = TypeAttributes.Public | TypeAttributes.Class;
			ns.Types.Add(wrap);
			
			
			EnrichWrapType(  wrap, type);

            CodeTypeDeclaration intf = new CodeTypeDeclaration("I"+type.Name);
			intf.IsClass = false;
			intf.TypeAttributes = TypeAttributes.Public | TypeAttributes.Interface;
			ns.Types.Add(intf);			
            			
			return GenerateCSharpCode(code);
		}



		static void EnrichWrapType(CodeTypeDeclaration wrap, Type type)
		{
			CodeTypeReference typeRef = new CodeTypeReference(type,CodeTypeReferenceOptions.GlobalReference);

			var iwrap = new CodeTypeReference("IWrap<" + "global::"+type.FullName + ">", CodeTypeReferenceOptions.GenericTypeParameter);
			wrap.BaseTypes.Add(iwrap);
			
			var intf = new CodeTypeReference("I" + type.Name);
			wrap.BaseTypes.Add(intf);
			
			var _underlyingObject = new CodeMemberField(typeRef, "_underlyingObject") { Attributes = MemberAttributes.Private };
			wrap.Members.Add(_underlyingObject);
			
			var this_underlyingObject = new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), _underlyingObject.Name);			
			
			AddConsuctors(type,typeRef, this_underlyingObject, wrap);
					
			
			CodeMemberProperty UnderlyingObject = new CodeMemberProperty();
			UnderlyingObject.Name = "UnderlyingObject";
			UnderlyingObject.HasGet = true;
			UnderlyingObject.HasSet = false;
			CodeMethodReturnStatement ret = new CodeMethodReturnStatement(this_underlyingObject);
			UnderlyingObject.GetStatements.Add(ret);
			UnderlyingObject.Attributes = MemberAttributes.Public;			
			UnderlyingObject.ImplementationTypes.Add(iwrap);
			UnderlyingObject.PrivateImplementationType = iwrap;
			UnderlyingObject.Type = typeRef;
			wrap.Members.Add(UnderlyingObject);		
			
		}

		static void AddConsuctors(Type type, CodeTypeReference typeRef, CodeFieldReferenceExpression this_underlyingObject, CodeTypeDeclaration wrap)
		{
			CodeConstructor ctor = new CodeConstructor();
			ctor.Attributes = MemberAttributes.Public;
			ctor.Parameters.Add(new CodeParameterDeclarationExpression(typeRef, "underlyingObject"));
			var right = new CodeVariableReferenceExpression("underlyingObject");
			var wrapped = new CodeAssignStatement(this_underlyingObject, right);
			ctor.Statements.Add(wrapped);
			wrap.Members.Add(ctor);
			
			
			foreach (var c in type.GetConstructors(BindingFlags.Public | BindingFlags.Instance | BindingFlags.CreateInstance))
			{
			   ctor = new CodeConstructor();
			   ctor.Attributes = MemberAttributes.Public;
			   foreach (var p in c.GetParameters())
			   {
			       	ctor.Parameters.Add(new CodeParameterDeclarationExpression(new CodeTypeReference(p.ParameterType),p.Name));		
			   }
			   var create = new CodeObjectCreateExpression(typeRef,ctor.Parameters.Cast<CodeParameterDeclarationExpression>().Select(x=> new CodeVariableReferenceExpression(x.Name)).ToArray());
			   wrapped = new CodeAssignStatement(this_underlyingObject, create);
			   ctor.Statements.Add(wrapped);
			   wrap.Members.Add(ctor);
			}
			
		}
	}
}
