using System;
using System.Collections.Generic;

using System.Linq;
using System.Security.Principal;
using System.Text;

namespace UnitWrappers.System.Security.Principal
{
    /// <summary>
    /// Wraps instance members of <see cref="WindowsIdentity"/>
    /// </summary>
    public class WindowsIdentityWrap
    {
        public WindowsIdentityWrap(WindowsIdentity windowsIdentity)
        {
            UnderlyingObject = windowsIdentity;
        }

        protected WindowsIdentity UnderlyingObject { get; private set; }
    }
}
