using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Policy;
using UnitWrappers.System.IO;
using System.IO;

namespace UnitWrappers.System.Reflection
{
    /// <summary>
    /// Wrapper for <see cref="Assembly"/> class.
    /// </summary>
    [Serializable]
    [ComVisible(true)]
    public class AssemblyWrap : IAssembly,IWrap<Assembly>
    {
        private Assembly _obj;

        
        public static implicit operator AssemblyWrap(Assembly o)
        {
            return new AssemblyWrap(o);
        }

        public static implicit operator Assembly(AssemblyWrap o)
        {
            return o._obj;
        }
        
        
		/// <summary>
		/// Initializes a new instance of the <see cref="T:UnitWrappers.System.Reflection.AssemblyWrap"/> class. 
		/// </summary>
		/// <param name="assembly">Assembly object.</param>
		public AssemblyWrap(Assembly assembly)
		{
            _obj = assembly;
		}
        
		 Assembly IWrap<Assembly>.UnderlyingObject
        {
            get
            {
                if (_obj == null)
                    throw new ArgumentNullException();
                return _obj;
            }
        }

        public string CodeBase
        {
            get { return _obj.CodeBase; }
        }

        public MethodInfo EntryPoint
        {
            get { return _obj.EntryPoint; }
        }

        public string EscapedCodeBase
        {
            get { return _obj.EscapedCodeBase; }
        }

        public Evidence Evidence
        {
            get { return _obj.Evidence; }
        }

        public string FullName
        {
            get { return _obj.FullName; }
        }

        public bool GlobalAssemblyCache
        {
            get { return _obj.GlobalAssemblyCache; }
        }

        public long HostContext
        {
            get { return _obj.HostContext; }
        }

        public string ImageRuntimeVersion
        {
            get { return _obj.ImageRuntimeVersion; }
        }

        public string Location
        {
            get { return _obj.Location; }
        }

        public Module ManifestModule
        {
            get { return _obj.ManifestModule; }
        }

        public bool ReflectionOnly
        {
            get { return _obj.ReflectionOnly; }
        }

        public object CreateInstance(string typeName)
        {
            return _obj.CreateInstance(typeName);
        }

        public object CreateInstance(string typeName, bool ignoreCase)
        {
            return _obj.CreateInstance(typeName, ignoreCase);
        }

        public object CreateInstance(string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
        {
            return _obj.CreateInstance(typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes);
        }


        public override bool Equals(object obj)
        {
            return _obj.Equals(obj);
        }

 

        public virtual object[] GetCustomAttributes(bool inherit)
        {
            return _obj.GetCustomAttributes(inherit);
        }

        public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
            return _obj.GetCustomAttributes(attributeType, inherit);
        }



        public virtual Type[] GetExportedTypes()
        {
            return _obj.GetExportedTypes();
        }

        public FileStreamBase GetFile(string name)
        {
            return new FileStreamWrap(_obj.GetFile(name));
        }

        public virtual FileStreamBase[] GetFiles()
        {
            return _obj.GetFiles().Select(x=>new FileStreamWrap(x)).ToArray();
        }

        public FileStreamBase[] GetFiles(bool getResourceModules)
        {
            return _obj.GetFiles(getResourceModules).Select(x => new FileStreamWrap(x)).ToArray(); ;
        }

        public override int GetHashCode()
        {
            return _obj.GetHashCode();
        }

        public IAssemblyName GetName()
        {
            return new AssemblyNameWrap(_obj.GetName());
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            _obj.GetObjectData(info, context);
        }

        public IAssemblyName[] GetReferencedAssemblies()
        {
            AssemblyName[] assemblyNames = _obj.GetReferencedAssemblies();
            return AssemblyNameWrap.ConvertFileInfoArrayIntoIFileInfoWrapArray(assemblyNames);
        }

        public bool IsDefined(Type attributeType, bool inherit)
        {
            return _obj.IsDefined(attributeType, inherit);
        }


    	

    	
		public Type GetType(string name)
		{
			return _obj.GetType(name);
		}
    	
		public Type GetType(string name, bool throwOnError)
		{
					return _obj.GetType(name,throwOnError);
		}
    	
		public Type GetType(string name, bool throwOnError, bool ignoreCase)
		{
							return _obj.GetType(name,throwOnError,ignoreCase);
		}
    	
		public Stream GetManifestResourceStream(Type type, string name)
		{
			return _obj.GetManifestResourceStream(type,name);
		}
    	
		public IAssemblyName GetName(bool copiedName)
		{
			return new AssemblyNameWrap( _obj.GetName(copiedName));
		}
    	
		public Type[] GetTypes()
		{
			return _obj.GetTypes();
		}
    	
		public IAssembly GetSatelliteAssembly(CultureInfo culture)
		{
		return	new AssemblyWrap(_obj.GetSatelliteAssembly(culture));
		}
    	
		public IAssembly GetSatelliteAssembly(CultureInfo culture, Version version)
		{
		 return	new AssemblyWrap(_obj.GetSatelliteAssembly(culture,version));
		}
    	
		public Stream GetManifestResourceStream(string name)
		{
			return _obj.GetManifestResourceStream(name);
		}
    	
	
		public string[] GetManifestResourceNames()
		{
			return _obj.GetManifestResourceNames();
		}
    }
}