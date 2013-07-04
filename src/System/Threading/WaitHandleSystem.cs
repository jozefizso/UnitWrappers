using System.Linq;
using System.Threading;

namespace UnitWrappers.System.Threading
{
    public class WaitHandleSystem:IWaitHandleSystem
    {
        public bool SignalAndWait(IWaitHandle toSignal, IWaitHandle toWaitOn)
        {
            return WaitHandle.SignalAndWait((WaitHandle)toSignal, (WaitHandle)toWaitOn);
        }

        public bool SignalAndWait(IWaitHandle toSignal, IWaitHandle toWaitOn, int millisecondsTimeout, bool exitContext)
        {
            return WaitHandle.SignalAndWait((WaitHandle)toSignal, (WaitHandle)toWaitOn, millisecondsTimeout, exitContext);
        }

        public bool WaitAll(IWaitHandle[] waitHandles)
        {
            return WaitHandle.WaitAll(waitHandles.Cast<WaitHandle>().ToArray());
        }

        public bool WaitAll(IWaitHandle[] waitHandles, int millisecondsTimeout)
        {
            return WaitHandle.WaitAll(waitHandles.Cast<WaitHandle>().ToArray(), millisecondsTimeout);
        }
    }
}