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
    public class AppDomainWrap : IAppDomain,IWrap<AppDomain>
    {
		private AppDomain _underlyingObject;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.AppDomainWrap"/> class. 
        /// </summary>
        /// <param name="appDomain">AppDomain object.</param>
        public AppDomainWrap(AppDomain appDomain)
        {
            _underlyingObject = appDomain;
        }

         AppDomain IWrap<AppDomain>.UnderlyingObject { get{return _underlyingObject;}}
		
        /// <inheritdoc />
        public object GetData(string name)
        {
            return _underlyingObject.GetData(name);
        }
        /// <inheritdoc />
        public override string ToString()
        {
            return _underlyingObject.ToString();
        }
        /// <inheritdoc />
        public IAssembly Load(IAssemblyName assemblyRef)
        {
            return new AssemblyWrap(_underlyingObject.Load(assemblyRef.AssemblyNameInstance));
        }
        /// <inheritdoc />
        public void SetData(string name, object data)
        {
            _underlyingObject.SetData(name, data);
        }
        /// <inheritdoc />
        public object CreateInstanceAndUnwrap(string assemblyName, string typeName)
        {
            return _underlyingObject.CreateInstanceAndUnwrap(assemblyName, typeName);
        }
        /// <inheritdoc />
        public object CreateInstanceAndUnwrap(string assemblyName, string typeName, object[] activationAttributes)
        {
            return _underlyingObject.CreateInstanceAndUnwrap(assemblyName, typeName, activationAttributes);
        }
        /// <inheritdoc />
        public object CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
        {
            return _underlyingObject.CreateInstanceAndUnwrap(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityAttributes);
        }
        /// <inheritdoc />
        public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName)
        {
            return _underlyingObject.CreateInstanceFromAndUnwrap(assemblyName, typeName);
        }
        /// <inheritdoc />
        public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, object[] activationAttributes)
        {
            return _underlyingObject.CreateInstanceFromAndUnwrap(assemblyName, typeName, activationAttributes);
        }
        /// <inheritdoc />
        public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
        {
            return _underlyingObject.CreateInstanceFromAndUnwrap(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityAttributes);
        }
        /// <inheritdoc />
        public void DoCallBack(CrossAppDomainDelegate callBackDelegate)
        {
            _underlyingObject.DoCallBack(callBackDelegate);
        }
        /// <inheritdoc />
        event ResolveEventHandler IAppDomain.AssemblyResolve
        {
            add { _underlyingObject.AssemblyResolve += value; }
            remove { _underlyingObject.AssemblyResolve -= value; }
        }

        public event AssemblyLoadEventHandler AssemblyLoad
        {
            add { _underlyingObject.AssemblyLoad += value; }
            remove { _underlyingObject.AssemblyLoad -= value; }
        }
        /// <inheritdoc />
        public event EventHandler DomainUnload
        {
            add { _underlyingObject.DomainUnload += value; }
            remove { _underlyingObject.DomainUnload -= value; }
        }
        /// <inheritdoc />
        public event EventHandler ProcessExit
        {
            add { _underlyingObject.ProcessExit += value; }
            remove { _underlyingObject.ProcessExit -= value; }
        }
        /// <inheritdoc />
        public event ResolveEventHandler ReflectionOnlyAssemblyResolve
        {
            add { _underlyingObject.ReflectionOnlyAssemblyResolve += value; }
            remove { _underlyingObject.ReflectionOnlyAssemblyResolve -= value; }
        }
        /// <inheritdoc />
        public event ResolveEventHandler ResourceResolve
        {
            add { _underlyingObject.ResourceResolve += value; }
            remove { _underlyingObject.ResourceResolve -= value; }
        }
        /// <inheritdoc />
        public event ResolveEventHandler TypeResolve
        {
            add { _underlyingObject.TypeResolve += value; }
            remove { _underlyingObject.TypeResolve -= value; }
        }
        /// <inheritdoc />
        public event UnhandledExceptionEventHandler UnhandledException
        {
            add { _underlyingObject.UnhandledException += value; }
            remove { _underlyingObject.UnhandledException -= value; }
        }
        /// <inheritdoc />
        public AppDomainManager DomainManager
        {
            get { return _underlyingObject.DomainManager; }
        }
        /// <inheritdoc />
        public Evidence Evidence
        {
            get { return _underlyingObject.Evidence; }
        }

        public AppDomainSetup SetupInformation
        {
            get { return _underlyingObject.SetupInformation; }
        }
        /// <inheritdoc />
        public string BaseDirectory
        {
            get { return _underlyingObject.BaseDirectory; }
        }
        /// <inheritdoc />
        public string DynamicDirectory
        {
            get { return _underlyingObject.DynamicDirectory; }
        }
        /// <inheritdoc />
        public string FriendlyName
        {
            get { return _underlyingObject.FriendlyName; }
        }
    }
}
