using Microsoft.Win32;

namespace UnitWrappers.Microsoft.Win32
{
    public class RegistryWrap : IRegistry
    {
        public IRegistryKey LocalMachine
        {
            get { return new RegistryKeyWrap(Registry.LocalMachine); }
        }
    }
}