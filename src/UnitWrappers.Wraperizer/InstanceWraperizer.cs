
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;
using System.Reflection;
using Microsoft.CSharp;

namespace UnitWrappers.Wraperizer
{
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
		    ns.Imports.Add(new CodeNamespaceImport("UnitWrappers"));
		    ns.Imports.Add(new CodeNamespaceImport("System"));
		    ns.Imports.Add(new CodeNamespaceImport(type.Namespace));
		    code.Namespaces.Add(ns);
			CodeTypeDeclaration wrap = new CodeTypeDeclaration(type.Name+"Wrap");
			wrap.IsClass = true;
			wrap.TypeAttributes = TypeAttributes.Public | TypeAttributes.Class;
			ns.Types.Add(wrap);
			
			CodeTypeReference typeRef = new CodeTypeReference(type);
			
			CodeMemberField underlyingObject = new CodeMemberField(typeRef,"_underlyingObject"){ Attributes = MemberAttributes.Private };
			wrap.Members.Add(underlyingObject);
			
			CodeMemberProperty UnderlyingObject = new CodeMemberProperty();
			UnderlyingObject.Name = "UnderlyingObject";
			UnderlyingObject.HasGet = true;
			UnderlyingObject.HasSet = false;
			CodeMethodReturnStatement ret = new CodeMethodReturnStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(),underlyingObject.Name));
			UnderlyingObject.GetStatements.Add(ret);
			UnderlyingObject.Attributes = MemberAttributes.Public;
			wrap.Members.Add(UnderlyingObject);
			var iwrap = new CodeTypeReference("IWrap<"+type.Name+">",CodeTypeReferenceOptions.GenericTypeParameter);
			wrap.BaseTypes.Add(iwrap);
			return GenerateCSharpCode(code);
		}
	}
}
