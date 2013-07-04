using System;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;

namespace UnitWrappers.System
{
    public interface IAppDomainSystem
    {
        /// <summary>
        /// Gets the current application domain for the current Thread.
        /// </summary>
        IAppDomain CurrentDomain { get; }

        /// <summary>
        /// Unloads the specified application domain.
        /// </summary>
        /// <param name="domain">An application domain to unload.</param>
        void Unload(IAppDomain domain);

        /// <summary>
        ///Creates a new application domain with the specified name
        /// </summary>
        /// <param name="friendlyName">The friendly name of the domain.</param>
        /// <returns>The newly created application domain.</returns>
        /// <exception cref="ArgumentNullException">friendlyName is null</exception>
        /// <remarks>
        /// The <i>friendlyName</i> parameter is intended to identify the domain in a manner that is meaningful to humans. This string should be suitable for display in user interfaces.
        /// This method overload uses the <seealso cref="AppDomainSetup"/> information from the default application domain.
        /// </remarks>
        IAppDomain CreateDomain(string friendlyName);

        IAppDomain CreateDomain(string friendlyName, Evidence securityInfo, AppDomainSetup info, PermissionSet grantSet, params StrongName[] fullTrustAssemblies);

        IAppDomain CreateDomain(string friendlyName, Evidence securityInfo);

        [SecurityPermissionAttribute(SecurityAction.Demand, ControlAppDomain = true)]
        IAppDomain CreateDomain(string friendlyName, Evidence securityInfo, AppDomainSetup info);

        IAppDomain CreateDomain(
            string friendlyName,
            Evidence securityInfo,
            string appBasePath,
            string appRelativeSearchPath,
            bool shadowCopyFiles
            );

        IAppDomain CreateDomain(
            string friendlyName,
            Evidence securityInfo,
            string appBasePath,
            string appRelativeSearchPath,
            bool shadowCopyFiles,
            AppDomainInitializer adInit,
            string[] adInitArgs
            );

#if !NET35
    /// <summary>
    /// Gets or sets a value that indicates whether CPU and memory monitoring of application domains is enabled for the current process. Once monitoring is enabled for a process, it cannot be disabled.
    /// </summary>
    /// <value>true if monitoring is enabled; otherwise false.</value>
        bool MonitoringIsEnabled { get; set; }

        /// <summary>
        /// Gets the total bytes that survived from the last full, blocking collection for all application domains in the process
        /// </summary>
        /// <value>The total number of surviving bytes for the process</value>
        /// <exception cref="InvalidOperationException">
        /// The <see cref="MonitoringIsEnabled"/> property is set to false.
        /// </exception>
        /// <remarks>
        /// After a full, blocking collection, this number represents the number of bytes currently held on the managed heap. It should be close to the number reported by the <see cref="GC.GetTotalMemory"/> method.
        /// Statistics are updated only after a full, blocking collection; that is, a collection that includes all generations and that stops the application while collection occurs. For example, the <see cref="GC.Collect()"/> method overload performs a full, blocking collection. (Concurrent collection occurs in the background and does not block the application.)
        /// </remarks>
        long MonitoringSurvivedProcessMemorySize { get; }
#endif
    }
}
