using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using UnitWrappers.System.Reflection;

namespace UnitWrappers.System
{
    /// <summary>
    /// Wrapper for <see cref="AppDomain"/> class.
    /// </summary>
    [ComVisible(true)]
    [Serializable]
    public class AppDomainWrap : IAppDomain
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.AppDomainWrap"/> class. 
        /// </summary>
        /// <param name="appDomain">AppDomain object.</param>
        public AppDomainWrap(AppDomain appDomain)
        {
            AppDomainInstance = appDomain;
        }

        public AppDomain AppDomainInstance { get; private set; }

        public object GetData(string name)
        {
            return AppDomainInstance.GetData(name);
        }

        public override string ToString()
        {
            return AppDomainInstance.ToString();
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

        public object CreateInstanceAndUnwrap(string assemblyName, string typeName, object[] activationAttributes)
        {
            return AppDomainInstance.CreateInstanceAndUnwrap(assemblyName, typeName, activationAttributes);
        }

        public object CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
        {
            return AppDomainInstance.CreateInstanceAndUnwrap(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityAttributes);
        }

        public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName)
        {
            return AppDomainInstance.CreateInstanceFromAndUnwrap(assemblyName, typeName);
        }

        public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, object[] activationAttributes)
        {
            return AppDomainInstance.CreateInstanceFromAndUnwrap(assemblyName, typeName, activationAttributes);
        }

        public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
        {
            return AppDomainInstance.CreateInstanceFromAndUnwrap(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityAttributes);
        }

        public void DoCallBack(CrossAppDomainDelegate callBackDelegate)
        {
            AppDomainInstance.DoCallBack(callBackDelegate);
        }

        event ResolveEventHandler IAppDomain.AssemblyResolve
        {
            add { AppDomainInstance.AssemblyResolve += value; }
            remove { AppDomainInstance.AssemblyResolve -= value; }
        }

        public event AssemblyLoadEventHandler AssemblyLoad
        {
            add { AppDomainInstance.AssemblyLoad += value; }
            remove { AppDomainInstance.AssemblyLoad -= value; }
        }

        public event EventHandler DomainUnload
        {
            add { AppDomainInstance.DomainUnload += value; }
            remove { AppDomainInstance.DomainUnload -= value; }
        }

        public event EventHandler ProcessExit
        {
            add { AppDomainInstance.ProcessExit += value; }
            remove { AppDomainInstance.ProcessExit -= value; }
        }

        public event ResolveEventHandler ReflectionOnlyAssemblyResolve
        {
            add { AppDomainInstance.ReflectionOnlyAssemblyResolve += value; }
            remove { AppDomainInstance.ReflectionOnlyAssemblyResolve -= value; }
        }

        public event ResolveEventHandler ResourceResolve
        {
            add { AppDomainInstance.ResourceResolve += value; }
            remove { AppDomainInstance.ResourceResolve -= value; }
        }

        public event ResolveEventHandler TypeResolve
        {
            add { AppDomainInstance.TypeResolve += value; }
            remove { AppDomainInstance.TypeResolve -= value; }
        }

        public event UnhandledExceptionEventHandler UnhandledException
        {
            add { AppDomainInstance.UnhandledException += value; }
            remove { AppDomainInstance.UnhandledException -= value; }
        }

        public AppDomainManager DomainManager
        {
            get { return AppDomainInstance.DomainManager; }
        }

        public Evidence Evidence
        {
            get { return AppDomainInstance.Evidence; }
        }

        public AppDomainSetup SetupInformation
        {
            get { return AppDomainInstance.SetupInformation; }
        }

        public string BaseDirectory
        {
            get { return AppDomainInstance.BaseDirectory; }
        }

        public string DynamicDirectory
        {
            get { return AppDomainInstance.DynamicDirectory; }
        }

        public string FriendlyName
        {
            get { return AppDomainInstance.FriendlyName; }
        }
    }
}
