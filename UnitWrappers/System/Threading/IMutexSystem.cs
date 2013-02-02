using System.Security.AccessControl;

namespace UnitWrappers.System.Threading
{
    public interface IMutexSystem
    {
        IMutex OpenExisting(string name);
        IMutex OpenExisting(string name, MutexRights rights);
    }
}