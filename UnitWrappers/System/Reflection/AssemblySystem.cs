using System;
using System.Configuration.Assemblies;
using System.Reflection;
using System.Security;

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

        public IAssembly GetExecutingAssembly()
        {
            return new AssemblyWrap(Assembly.GetExecutingAssembly());
        }

        public IAssembly GetEntryAssembly()
        {
            return new AssemblyWrap(Assembly.GetEntryAssembly());
        }

        public string CreateQualifiedName(string assemblyName, string typeName)
        {
            return Assembly.CreateQualifiedName(assemblyName, typeName);
        }

        public IAssembly LoadFrom(string assemblyFile)
        {
            return new AssemblyWrap(Assembly.LoadFrom(assemblyFile));
        }

        public IAssembly Load(IAssemblyName assemblyRef)
        {
            return new AssemblyWrap(Assembly.Load(assemblyRef.AssemblyNameInstance));
        }

        public IAssembly Load(byte[] rawAssembly)
        {
            return new AssemblyWrap(Assembly.Load(rawAssembly));
        }

        public IAssembly Load(string assemblyString)
        {
            return new AssemblyWrap(Assembly.Load(assemblyString));
        }

        public IAssembly Load(byte[] rawAssembly, byte[] rawSymbolStore)
        {
            return new AssemblyWrap(Assembly.Load(rawAssembly, rawSymbolStore));
        }

        public IAssembly LoadFile(string path)
        {
            return new AssemblyWrap(Assembly.LoadFile(path));
        }



        public IAssembly ReflectionOnlyLoad(byte[] rawAssembly)
        {
            return new AssemblyWrap(Assembly.ReflectionOnlyLoad(rawAssembly));
        }

        public IAssembly ReflectionOnlyLoadFrom(string assemblyFile)
        {
            return new AssemblyWrap(Assembly.ReflectionOnlyLoadFrom(assemblyFile));
        }


#if !NET35
        public IAssembly Load(byte[] rawAssembly, byte[] rawSymbolStore, SecurityContextSource securityContextSource)
        {
            return new AssemblyWrap(Assembly.Load(rawAssembly, rawSymbolStore, securityContextSource));
        }

        public IAssembly UnsafeLoadFrom(string assemblyFile)
        {
            return new AssemblyWrap(Assembly.UnsafeLoadFrom(assemblyFile));
        }

        public IAssembly LoadFrom(string assemblyFile, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm)
        {
            return new AssemblyWrap(Assembly.LoadFrom(assemblyFile,hashValue,hashAlgorithm));
        }
#endif
        public IAssembly GetAssembly(Type type)
        {
            return new AssemblyWrap(Assembly.GetAssembly(type));
        }
    }
}