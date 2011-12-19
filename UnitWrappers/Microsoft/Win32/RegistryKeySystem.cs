using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace UnitWrappers.Microsoft.Win32
{
    /// <summary>
    /// 
    /// </summary>
    public class RegistryKeySystem : IRegistryKeySystem
    {
        public IRegistryKey OpenRemoteBaseKey(RegistryHive hKey, string machineName)
        {
            return new RegistryKeyWrap(RegistryKey.OpenRemoteBaseKey(hKey, machineName));
        }

#if NET40

        [ComVisibleAttribute(false)]
public  IRegistryKey OpenRemoteBaseKey(
	RegistryHive hKey,
	string machineName,
	RegistryView view
)
        {
            return new RegistryKeyWrap(RegistryKey.OpenRemoteBaseKey(hKey, machineName, view));
        }
        [ComVisibleAttribute(false)]
        public IRegistryKey OpenBaseKey(
            RegistryHive hKey,
            RegistryView view
        )
        {
            return new RegistryKeyWrap(RegistryKey.OpenBaseKey(hKey, view));
        }

        [ComVisible(false)]
        [SecurityPermissionAttribute(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        public IRegistryKey FromHandle(
            SafeRegistryHandle handle
        )
        {
            return new RegistryKeyWrap(RegistryKey.FromHandle(handle));
        }

        [ComVisibleAttribute(false)]
        [SecurityPermissionAttribute(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        public IRegistryKey FromHandle(
            SafeRegistryHandle handle,
            RegistryView view
        )
        {
            return new RegistryKeyWrap(RegistryKey.FromHandle(handle, view));
        }
#endif
    }


}
