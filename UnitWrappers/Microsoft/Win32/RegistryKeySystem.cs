using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace UnitWrappers.Microsoft.Win32
{
    public class RegistryKeySystem
    {
        public IRegistryKey OpenRemoteBaseKey(RegistryHive hKey, string machineName)
        {
            return new RegistryKeyWrap(RegistryKey.OpenRemoteBaseKey(hKey, machineName));
        }
    }
}
