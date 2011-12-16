using System;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Threading;

namespace UnitWrappers.System.Threading
{
    public interface IThreadPool
    {
        [SecurityPermission(SecurityAction.Demand, ControlThread = true)]
        bool SetMaxThreads(int workerThreads, int completionPortThreads);

        void GetMaxThreads(out int workerThreads, out int completionPortThreads);

        [SecurityPermission(SecurityAction.Demand, ControlThread = true)]
        bool SetMinThreads(int workerThreads, int completionPortThreads);

        void GetMinThreads(out int workerThreads, out int completionPortThreads);
        void GetAvailableThreads(out int workerThreads, out int completionPortThreads);

        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.NoInlining)]
        RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce);

        [MethodImpl(MethodImplOptions.NoInlining)]
        bool QueueUserWorkItem(WaitCallback callBack, object state);

        [MethodImpl(MethodImplOptions.NoInlining)]
        bool QueueUserWorkItem(WaitCallback callBack);
    }
}