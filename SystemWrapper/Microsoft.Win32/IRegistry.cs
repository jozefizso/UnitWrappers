using Microsoft.Win32;

namespace SystemWrapper.Microsoft.Win32
{
    public interface IRegistry
    {
        // Properties
        //    public static readonly RegistryKey ClassesRoot;
        //    public static readonly RegistryKey CurrentConfig;
        //    public static readonly RegistryKey CurrentUser;
        //    public static readonly RegistryKey DynData;
        IRegistryKey LocalMachine { get; }
        //    public static readonly RegistryKey PerformanceData;
        //    public static readonly RegistryKey Users;
        //
        //    // Methods
        //    static Registry();
        //    private static RegistryKey GetBaseKeyFromKeyName(string keyName, out string subKeyName);
        //    public static object GetValue(string keyName, string valueName, object defaultValue);
        //    public static void SetValue(string keyName, string valueName, object value);
        //    public static void SetValue(string keyName, string valueName, object value, RegistryValueKind valueKind);

    }
}