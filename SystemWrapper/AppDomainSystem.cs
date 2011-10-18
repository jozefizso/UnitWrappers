using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemWrapper
{
    /// <summary>
    /// Wraps static members of <see cref="AppDomain"/>
    /// </summary>
    public class AppDomainSystem:IAppDomainSystem
    {
        /// <inheritdoc />
        public void Unload(IAppDomain domain)
        {
            AppDomain.Unload(domain.AppDomainInstance);
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

    }
}
