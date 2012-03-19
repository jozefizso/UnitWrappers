using Microsoft.Win32;

namespace UnitWrappers.Microsoft.Win32
{
    /// <summary>
    /// 
    /// </summary>
    public interface IRegistry
    {

        IRegistryKey ClassesRoot { get; }
        IRegistryKey CurrentConfig { get; }
        IRegistryKey CurrentUser { get; }
        IRegistryKey LocalMachine { get; }
        IRegistryKey PerformanceData { get; }
        IRegistryKey Users { get; }


        object GetValue(string keyName, string valueName, object defaultValue);
        void SetValue(string keyName, string valueName, object value);
        void SetValue(string keyName, string valueName, object value, RegistryValueKind valueKind);

    }
}