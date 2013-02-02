using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace UnitWrappers.Microsoft.Win32
{
    public interface IRegistryKeySystem
    {
        IRegistryKey OpenRemoteBaseKey(RegistryHive hKey, string machineName);
#if NET40

        [ComVisible(false)]
        IRegistryKey OpenRemoteBaseKey(
            RegistryHive hKey,
            string machineName,
            RegistryView view
            );

        [ComVisibleAttribute(false)]
        IRegistryKey OpenBaseKey(
            RegistryHive hKey,
            RegistryView view
            );

        [ComVisible(false)]
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        IRegistryKey FromHandle(
            SafeRegistryHandle handle
            );

        [ComVisibleAttribute(false)]
        [SecurityPermissionAttribute(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        IRegistryKey FromHandle(
            SafeRegistryHandle handle,
            RegistryView view
            );
#endif
    }
}