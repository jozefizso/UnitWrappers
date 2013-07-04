using Microsoft.Win32;

namespace UnitWrappers.Microsoft.Win32
{
    public class RegistryWrap : IRegistry
    {
        public IRegistryKey ClassesRoot
        {
            get { return new RegistryKeyWrap(Registry.ClassesRoot); }
        }

        public IRegistryKey CurrentConfig
        {
            get { return new RegistryKeyWrap(Registry.CurrentConfig); }
        }

        public IRegistryKey CurrentUser
        {
            get { return new RegistryKeyWrap(Registry.CurrentUser); }
        }

        public IRegistryKey LocalMachine
        {
            get { return new RegistryKeyWrap(Registry.LocalMachine); }
        }

        public IRegistryKey PerformanceData
        {
            get { return new RegistryKeyWrap(Registry.PerformanceData); }
        }

        public IRegistryKey Users
        {
            get { return new RegistryKeyWrap(Registry.Users); }
        }

        public object GetValue(string keyName, string valueName, object defaultValue)
        {
            return Registry.GetValue(keyName, valueName, defaultValue);
        }

        public void SetValue(string keyName, string valueName, object value)
        {
            Registry.SetValue(keyName, valueName, value);
        }

        public void SetValue(string keyName, string valueName, object value, RegistryValueKind valueKind)
        {
            Registry.SetValue(keyName, valueName, value, valueKind);
        }
    }
}