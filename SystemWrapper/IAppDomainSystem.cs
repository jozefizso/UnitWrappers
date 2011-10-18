using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemWrapper
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
        IAppDomain CreateDomain(string friendlyName);
    }
}
