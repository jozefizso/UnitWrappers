using System.Security.AccessControl;
using System.Threading;

namespace UnitWrappers.System.Threading
{
    public class MutexSystem:IMutexSystem
    {
        public IMutex OpenExisting(string name)
        {
            return new MutexWrap(Mutex.OpenExisting(name));
        }

        public IMutex OpenExisting(string name, MutexRights rights)
        {
            return new MutexWrap(Mutex.OpenExisting(name,rights));
        }
    }
}