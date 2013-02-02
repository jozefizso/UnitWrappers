using Microsoft.Win32;

namespace UnitWrappers.Microsoft.Win32
{
    /// <summary>
    /// 
    /// </summary>
    public class RegistryKeyWrap : IRegistryKey
    {
        private RegistryKey _underlyingObject;

        RegistryKey IRegistryKey.UnderlyingObject
        {
            get { return _underlyingObject; }
        }

        public RegistryKeyWrap(RegistryKey registryKey)
        {
            _underlyingObject = registryKey;
        }


        public void Close()
        {
           _underlyingObject.Close();
        }

        public IRegistryKey CreateSubKey(string subkey)
        {
            return new RegistryKeyWrap(_underlyingObject.CreateSubKey(subkey));
        }

        public IRegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck)
        {
            return new RegistryKeyWrap(_underlyingObject.CreateSubKey(subkey, permissionCheck));
        }

        public void DeleteSubKey(string subkey)
        {
            _underlyingObject.DeleteSubKey(subkey);
        }

        public void DeleteSubKey(string subkey, bool throwOnMissingSubKey)
        {
            _underlyingObject.DeleteSubKey(subkey, throwOnMissingSubKey);
        }

        public void DeleteSubKeyTree(string subkey)
        {
            _underlyingObject.DeleteSubKeyTree(subkey);
        }

        public void DeleteValue(string name)
        {
            _underlyingObject.DeleteValue(name);
        }

        public void DeleteValue(string name, bool throwOnMissingValue)
        {
            _underlyingObject.DeleteValue(name, throwOnMissingValue);
        }

        public void Flush()
        {
            _underlyingObject.Flush();
        }

        public string[] GetSubKeyNames()
        {
            return _underlyingObject.GetSubKeyNames();
        }

        public object GetValue(string name)
        {
            return _underlyingObject.GetValue(name);
        }

        public object GetValue(string name, object defaultValue)
        {
            return _underlyingObject.GetValue(name, defaultValue);
        }

        public object GetValue(string name, object defaultValue, RegistryValueOptions options)
        {
            return _underlyingObject.GetValue(name, defaultValue, options);
        }

        public RegistryValueKind GetValueKind(string name)
        {
            return _underlyingObject.GetValueKind(name);
        }

        public string[] GetValueNames()
        {
            return _underlyingObject.GetValueNames();
        }



        public IRegistryKey OpenSubKey(string name)
        {
            return new RegistryKeyWrap(_underlyingObject.OpenSubKey(name));
        }

        public IRegistryKey OpenSubKey(string name, RegistryKeyPermissionCheck permissionCheck)
        {
            return new RegistryKeyWrap(_underlyingObject.OpenSubKey(name, permissionCheck));
        }

        public IRegistryKey OpenSubKey(string name, bool writable)
        {
            return new RegistryKeyWrap(_underlyingObject.OpenSubKey(name, writable));
        }

        public void SetValue(string name, object value)
        {
            _underlyingObject.SetValue(name, value);
        }

        public void SetValue(string name, object value, RegistryValueKind valueKind)
        {
            _underlyingObject.SetValue(name, value, valueKind);
        }

        public string Name
        {
            get { return _underlyingObject.Name; }
        }



        public int SubKeyCount
        {
            get { return _underlyingObject.SubKeyCount; }
        }

        public int ValueCount
        {
            get { return _underlyingObject.ValueCount; }
        }


    }
}