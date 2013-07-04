namespace UnitWrappers.System.Threading
{
    public interface IWaitHandleSystem
    {

        bool SignalAndWait(IWaitHandle toSignal, IWaitHandle toWaitOn);

        bool SignalAndWait(IWaitHandle toSignal, IWaitHandle toWaitOn, int millisecondsTimeout, bool exitContext);

        bool WaitAll(IWaitHandle[] waitHandles);
        bool WaitAll(IWaitHandle[] waitHandles, int millisecondsTimeout);
    }
}