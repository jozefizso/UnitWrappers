using System;
using System.Runtime.InteropServices;
using SystemWrapper.Reflection;

namespace SystemWrapper
{
    /// <summary>
    /// Wrapper for <see cref="System.AppDomain"/> class.
    /// </summary>
    [ComVisible(true)] 
    [Serializable]
    public class AppDomainWrap : IAppDomain
	{
		#region Constructors and Initializers

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.AppDomainWrap"/> class. 
		/// </summary>
		/// <param name="appDomain">AppDomain object.</param>
		public AppDomainWrap(AppDomain appDomain)
		{
            AppDomainInstance = appDomain;
		}

    	#endregion Constructors and Initializers
		
		public AppDomain AppDomainInstance { get; private set; }
        
        public object GetData(string name)
        {
            return AppDomainInstance.GetData(name);
        }

        public IAssembly Load(IAssemblyName assemblyRef)
        {
            return new AssemblyWrap(AppDomainInstance.Load(assemblyRef.AssemblyNameInstance));
        }

        public void SetData(string name, object data)
        {
            AppDomainInstance.SetData(name, data);
        }

        public object CreateInstanceAndUnwrap(string assemblyName, string typeName)
        {
           return AppDomainInstance.CreateInstanceAndUnwrap(assemblyName, typeName);
        }


        event ResolveEventHandler IAppDomain.AssemblyResolve
        {
            add { AppDomainInstance.AssemblyResolve += value; }
            remove { AppDomainInstance.AssemblyResolve -= value; }
        }
    }
}