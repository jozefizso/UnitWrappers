using System;
using System.Reflection;

namespace UnitWrappers.System.Reflection
{
    /// <summary>
    /// Wraps static members of <see cref="Assembly"/>
    /// </summary>
    public class AssemblySystem : IAssemblySystem
    {


        public IAssembly GetCallingAssembly()
        {
            return new AssemblyWrap(Assembly.GetCallingAssembly());
        }

        public IAssembly GetEntryAssembly()
        {
            return new AssemblyWrap(Assembly.GetEntryAssembly());
        }

        public IAssembly GetExecutingAssembly()
        {
            return new AssemblyWrap(Assembly.GetExecutingAssembly());
        }

        public string CreateQualifiedName(string assemblyName, string typeName)
        {
            return Assembly.CreateQualifiedName(assemblyName, typeName);
        }

        public IAssembly LoadFrom(string assemblyFile)
        {
            return new AssemblyWrap(Assembly.LoadFrom(assemblyFile));
        }

        public IAssembly GetAssembly(Type type)
        {
            return new AssemblyWrap(Assembly.GetAssembly(type));
        }
    }
}