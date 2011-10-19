using System;
using Microsoft.Win32;

namespace MicrosoftWrapper.Win32
{
    public class RegistryWrap : IRegistry
    {
        public IRegistryKey LocalMachine
        {
            get { return new RegistryKeyWrap(Registry.LocalMachine); }
        }
    }
}