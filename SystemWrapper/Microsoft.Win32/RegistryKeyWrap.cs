using System;
using Microsoft.Win32;

namespace SystemWrapper.Microsoft.Win32
{
    /// <summary>
    /// 
    /// </summary>
    public class RegistryKeyWrap : IRegistryKey
    {
        private RegistryKey _registryKeyInstance;

        public RegistryKeyWrap(RegistryKey registryKey)
        {
            _registryKeyInstance = registryKey;
        }


        public void Close()
        {
           _registryKeyInstance.Close();
        }

        public object GetValue(string name)
        {
            return _registryKeyInstance.GetValue(name);
        }

        public IRegistryKey OpenSubKey(string name)
        {
            return new RegistryKeyWrap(_registryKeyInstance.OpenSubKey(name));
        }

        public IRegistryKey OpenSubKey(string name, bool writable)
        {
            return new RegistryKeyWrap(_registryKeyInstance.OpenSubKey(name, writable));
        }

        public void SetValue(string name, object value)
        {
            _registryKeyInstance.SetValue(name, value);
        }

        public RegistryKey RegistryKeyInstance
        {
            get { return _registryKeyInstance; }
        }
    }
}