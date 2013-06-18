using System;
using System.Security;
using System.Security.Policy;

namespace UnitWrappers.System
{
    /// <summary>
    /// Wraps static members of <see cref="AppDomain"/>
    /// </summary>
    public class AppDomainSystem:IAppDomainSystem
    {
        /// <inheritdoc />
        public void Unload(IAppDomain domain)
        {
            AppDomain.Unload(((IWrap<AppDomain>)domain).UnderlyingObject);
        }

        /// <inheritdoc />
        public IAppDomain CurrentDomain
        {
            get { return new AppDomainWrap(AppDomain.CurrentDomain); }
        }

        /// <inheritdoc />
        public IAppDomain CreateDomain(string friendlyName)
        {
            return new AppDomainWrap(AppDomain.CreateDomain(friendlyName));
        }
        /// <inheritdoc />
        public IAppDomain CreateDomain(string friendlyName, Evidence securityInfo, AppDomainSetup info, PermissionSet grantSet, params StrongName[] fullTrustAssemblies)
        {
            return new AppDomainWrap(AppDomain.CreateDomain(friendlyName, securityInfo, info, grantSet, fullTrustAssemblies));
        }
        /// <inheritdoc />
        public IAppDomain CreateDomain(string friendlyName, Evidence securityInfo)
        {
            return new AppDomainWrap(AppDomain.CreateDomain(friendlyName, securityInfo));
        }
        /// <inheritdoc />
        public IAppDomain CreateDomain(string friendlyName, Evidence securityInfo, AppDomainSetup info)
        {
            return new AppDomainWrap(AppDomain.CreateDomain(friendlyName, securityInfo, info));
        }
        /// <inheritdoc />
        public IAppDomain CreateDomain(string friendlyName, Evidence securityInfo, string appBasePath, string appRelativeSearchPath, bool shadowCopyFiles)
        {
            return new AppDomainWrap(AppDomain.CreateDomain(friendlyName, securityInfo, appBasePath, appRelativeSearchPath, shadowCopyFiles));
        }
        /// <inheritdoc />
        public IAppDomain CreateDomain(string friendlyName, Evidence securityInfo, string appBasePath, string appRelativeSearchPath, bool shadowCopyFiles, AppDomainInitializer adInit, string[] adInitArgs)
        {
            return new AppDomainWrap(AppDomain.CreateDomain(friendlyName, securityInfo, appBasePath, appRelativeSearchPath, shadowCopyFiles, adInit, adInitArgs));
        }


#if !NET35
        /// <inheritdoc />
        public bool MonitoringIsEnabled
        {
            get { return AppDomain.MonitoringIsEnabled; }
            set { AppDomain.MonitoringIsEnabled = value; }
        }

        /// <inheritdoc />
        public long MonitoringSurvivedProcessMemorySize
        {
            get { return AppDomain.MonitoringSurvivedProcessMemorySize; }
        }
#endif
    }
}
