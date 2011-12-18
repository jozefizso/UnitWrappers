using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace UnitWrappers.Microsoft.Win32
{
    public interface IRegistryKey
    {


        /// <summary>
        /// Closes the key and flushes it to disk if its contents have been modified.
        /// </summary>
        void Close();
        IRegistryKey CreateSubKey(string subkey);
        [ComVisible(false)]
        IRegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck);
        //        [ComVisible(false)]
        //        RegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck, RegistrySecurity registrySecurity);
        void DeleteSubKey(string subkey);
        void DeleteSubKey(string subkey, bool throwOnMissingSubKey);
        void DeleteSubKeyTree(string subkey);
        void DeleteValue(string name);
        void DeleteValue(string name, bool throwOnMissingValue);
        void Flush();
        //        RegistrySecurity GetAccessControl();
        //        RegistrySecurity GetAccessControl(AccessControlSections includeSections);
        string[] GetSubKeyNames();
        object GetValue(string name);
        object GetValue(string name, object defaultValue);
        [ComVisible(false)]
        object GetValue(string name, object defaultValue, RegistryValueOptions options);
        [ComVisible(false)]
        RegistryValueKind GetValueKind(string name);
        string[] GetValueNames();

        IRegistryKey OpenSubKey(string name);
        [ComVisible(false)]
        IRegistryKey OpenSubKey(string name, RegistryKeyPermissionCheck permissionCheck);
        IRegistryKey OpenSubKey(string name, bool writable);
        // [ComVisible(false)]
        //RegistryKey OpenSubKey(string name, RegistryKeyPermissionCheck permissionCheck, RegistryRights rights);
        //        void SetAccessControl(RegistrySecurity registrySecurity);
        void SetValue(string name, object value);
        [ComVisible(false)]
        void SetValue(string name, object value, RegistryValueKind valueKind);


        string Name { get; }
        RegistryKey UnderlyingObject { get; }
        int SubKeyCount { get; }
        int ValueCount { get; }
    }
}