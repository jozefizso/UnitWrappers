using System.Threading;

namespace UnitWrappers.System.Threading
{
    public class MutexSystem
    {
        public IMutex OpenExisting(string name)
        {
            return new MutexWrap(Mutex.OpenExisting(name));
        }

        public bool SignalAndWait(WaitHandle toSignal, WaitHandle toWaitOn)
        {
            return Mutex.SignalAndWait(toSignal, toWaitOn);
        }
    }
}