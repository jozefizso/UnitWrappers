using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Policy;
using UnitWrappers.System.IO;

namespace UnitWrappers.System.Reflection
{
    /// <summary>
    /// Wrapper for <see cref="Assembly"/> class.
    /// </summary>
    [Serializable]
    [ComVisible(true)]
    public class AssemblyWrap : IAssembly
    {
        private Assembly _assembly;

		#region Constructors and Initializers

		/// <summary>
		/// Initializes a new instance of the <see cref="T:UnitWrappers.System.Reflection.AssemblyWrap"/> class. 
		/// </summary>
		/// <param name="assembly">Assembly object.</param>
		public AssemblyWrap(Assembly assembly)
		{
            _assembly = assembly;
		}
        
		#endregion Constructors and Initializers
		
		public Assembly AssemblyInstance
        {
            get
            {
                if (_assembly == null)
                    throw new ArgumentNullException();
                return _assembly;
            }
        }

        public string CodeBase
        {
            get { return AssemblyInstance.CodeBase; }
        }

        public MethodInfo EntryPoint
        {
            get { return AssemblyInstance.EntryPoint; }
        }

        public string EscapedCodeBase
        {
            get { return AssemblyInstance.EscapedCodeBase; }
        }

        public Evidence Evidence
        {
            get { return AssemblyInstance.Evidence; }
        }

        public string FullName
        {
            get { return AssemblyInstance.FullName; }
        }

        public bool GlobalAssemblyCache
        {
            get { return AssemblyInstance.GlobalAssemblyCache; }
        }

        public long HostContext
        {
            get { return AssemblyInstance.HostContext; }
        }

        public string ImageRuntimeVersion
        {
            get { return AssemblyInstance.ImageRuntimeVersion; }
        }

        public string Location
        {
            get { return AssemblyInstance.Location; }
        }

        public Module ManifestModule
        {
            get { return AssemblyInstance.ManifestModule; }
        }

        public bool ReflectionOnly
        {
            get { return AssemblyInstance.ReflectionOnly; }
        }

        public object CreateInstance(string typeName)
        {
            return AssemblyInstance.CreateInstance(typeName);
        }

        public object CreateInstance(string typeName, bool ignoreCase)
        {
            return AssemblyInstance.CreateInstance(typeName, ignoreCase);
        }

        public object CreateInstance(string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
        {
            return AssemblyInstance.CreateInstance(typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes);
        }


        public override bool Equals(object obj)
        {
            return AssemblyInstance.Equals(obj);
        }

 

        public virtual object[] GetCustomAttributes(bool inherit)
        {
            return AssemblyInstance.GetCustomAttributes(inherit);
        }

        public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
            return AssemblyInstance.GetCustomAttributes(attributeType, inherit);
        }



        public virtual Type[] GetExportedTypes()
        {
            return AssemblyInstance.GetExportedTypes();
        }

        public IFileStream GetFile(string name)
        {
            return new FileStreamWrap(AssemblyInstance.GetFile(name));
        }

        public virtual IFileStream[] GetFiles()
        {
            return FileStreamWrap.ConvertFileStreamArrayIntoIFileStreamWrapArray(AssemblyInstance.GetFiles());
        }

        public IFileStream[] GetFiles(bool getResourceModules)
        {
            return FileStreamWrap.ConvertFileStreamArrayIntoIFileStreamWrapArray(AssemblyInstance.GetFiles(getResourceModules));
        }

        public override int GetHashCode()
        {
            return AssemblyInstance.GetHashCode();
        }

        public IAssemblyName GetName()
        {
            return new AssemblyNameWrap(AssemblyInstance.GetName());
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            AssemblyInstance.GetObjectData(info, context);
        }

        public IAssemblyName[] GetReferencedAssemblies()
        {
            AssemblyName[] assemblyNames = AssemblyInstance.GetReferencedAssemblies();
            return AssemblyNameWrap.ConvertFileInfoArrayIntoIFileInfoWrapArray(assemblyNames);
        }

        public bool IsDefined(Type attributeType, bool inherit)
        {
            return AssemblyInstance.IsDefined(attributeType, inherit);
        }


    }
}