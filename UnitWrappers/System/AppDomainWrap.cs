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
        /// <inheritdoc />
        public object GetData(string name)
        {
            return AppDomainInstance.GetData(name);
        }
        /// <inheritdoc />
        public override string ToString()
        {
            return AppDomainInstance.ToString();
        }
        /// <inheritdoc />
        public IAssembly Load(IAssemblyName assemblyRef)
        {
            return new AssemblyWrap(AppDomainInstance.Load(assemblyRef.AssemblyNameInstance));
        }
        /// <inheritdoc />
        public void SetData(string name, object data)
        {
            AppDomainInstance.SetData(name, data);
        }
        /// <inheritdoc />
        public object CreateInstanceAndUnwrap(string assemblyName, string typeName)
        {
            return AppDomainInstance.CreateInstanceAndUnwrap(assemblyName, typeName);
        }
        /// <inheritdoc />
        public object CreateInstanceAndUnwrap(string assemblyName, string typeName, object[] activationAttributes)
        {
            return AppDomainInstance.CreateInstanceAndUnwrap(assemblyName, typeName, activationAttributes);
        }
        /// <inheritdoc />
        public object CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
        {
            return AppDomainInstance.CreateInstanceAndUnwrap(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityAttributes);
        }
        /// <inheritdoc />
        public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName)
        {
            return AppDomainInstance.CreateInstanceFromAndUnwrap(assemblyName, typeName);
        }
        /// <inheritdoc />
        public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, object[] activationAttributes)
        {
            return AppDomainInstance.CreateInstanceFromAndUnwrap(assemblyName, typeName, activationAttributes);
        }
        /// <inheritdoc />
        public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
        {
            return AppDomainInstance.CreateInstanceFromAndUnwrap(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityAttributes);
        }
        /// <inheritdoc />
        public void DoCallBack(CrossAppDomainDelegate callBackDelegate)
        {
            AppDomainInstance.DoCallBack(callBackDelegate);
        }
        /// <inheritdoc />
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
        /// <inheritdoc />
        public event EventHandler DomainUnload
        {
            add { AppDomainInstance.DomainUnload += value; }
            remove { AppDomainInstance.DomainUnload -= value; }
        }
        /// <inheritdoc />
        public event EventHandler ProcessExit
        {
            add { AppDomainInstance.ProcessExit += value; }
            remove { AppDomainInstance.ProcessExit -= value; }
        }
        /// <inheritdoc />
        public event ResolveEventHandler ReflectionOnlyAssemblyResolve
        {
            add { AppDomainInstance.ReflectionOnlyAssemblyResolve += value; }
            remove { AppDomainInstance.ReflectionOnlyAssemblyResolve -= value; }
        }
        /// <inheritdoc />
        public event ResolveEventHandler ResourceResolve
        {
            add { AppDomainInstance.ResourceResolve += value; }
            remove { AppDomainInstance.ResourceResolve -= value; }
        }
        /// <inheritdoc />
        public event ResolveEventHandler TypeResolve
        {
            add { AppDomainInstance.TypeResolve += value; }
            remove { AppDomainInstance.TypeResolve -= value; }
        }
        /// <inheritdoc />
        public event UnhandledExceptionEventHandler UnhandledException
        {
            add { AppDomainInstance.UnhandledException += value; }
            remove { AppDomainInstance.UnhandledException -= value; }
        }
        /// <inheritdoc />
        public AppDomainManager DomainManager
        {
            get { return AppDomainInstance.DomainManager; }
        }
        /// <inheritdoc />
        public Evidence Evidence
        {
            get { return AppDomainInstance.Evidence; }
        }

        public AppDomainSetup SetupInformation
        {
            get { return AppDomainInstance.SetupInformation; }
        }
        /// <inheritdoc />
        public string BaseDirectory
        {
            get { return AppDomainInstance.BaseDirectory; }
        }
        /// <inheritdoc />
        public string DynamicDirectory
        {
            get { return AppDomainInstance.DynamicDirectory; }
        }
        /// <inheritdoc />
        public string FriendlyName
        {
            get { return AppDomainInstance.FriendlyName; }
        }
    }
}
