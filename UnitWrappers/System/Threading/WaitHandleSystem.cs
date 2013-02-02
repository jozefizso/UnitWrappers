using System.Linq;
using System.Threading;

namespace UnitWrappers.System.Threading
{
    public class WaitHandleSystem:IWaitHandleSystem
    {
        public bool SignalAndWait(IWaitHandle toSignal, IWaitHandle toWaitOn)
        {
            return WaitHandle.SignalAndWait(toSignal.UnderlyingObject, toWaitOn.UnderlyingObject);
        }

        public bool SignalAndWait(IWaitHandle toSignal, IWaitHandle toWaitOn, int millisecondsTimeout, bool exitContext)
        {
            return WaitHandle.SignalAndWait(toSignal.UnderlyingObject, toWaitOn.UnderlyingObject, millisecondsTimeout, exitContext);
        }

        public bool WaitAll(IWaitHandle[] waitHandles)
        {
            return WaitHandle.WaitAll(waitHandles.Select(x=>x.UnderlyingObject).ToArray());
        }

        public bool WaitAll(IWaitHandle[] waitHandles, int millisecondsTimeout)
        {
            return WaitHandle.WaitAll(waitHandles.Select(x => x.UnderlyingObject).ToArray(),millisecondsTimeout);
        }
    }
}