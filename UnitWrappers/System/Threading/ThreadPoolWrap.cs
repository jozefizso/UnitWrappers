using System;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Threading;

namespace UnitWrappers.System.Threading
{
    [HostProtection(SecurityAction.LinkDemand, ExternalThreading = true, Synchronization = true)]
    public class ThreadPoolWrap : IThreadPool
    {
        [SecurityPermission(SecurityAction.Demand, ControlThread = true)]
        public bool SetMaxThreads(int workerThreads, int completionPortThreads)
        {
            return ThreadPool.SetMaxThreads(workerThreads, completionPortThreads);
        }

        public void GetMaxThreads(out int workerThreads, out int completionPortThreads)
        {
            ThreadPool.GetMaxThreads(out workerThreads, out completionPortThreads);
        }

        [SecurityPermission(SecurityAction.Demand, ControlThread = true)]
        public bool SetMinThreads(int workerThreads, int completionPortThreads)
        {
            return ThreadPool.SetMinThreads(workerThreads, completionPortThreads);
        }

        public void GetMinThreads(out int workerThreads, out int completionPortThreads)
        {
            ThreadPool.GetMinThreads(out workerThreads, out completionPortThreads);
        }

        public void GetAvailableThreads(out int workerThreads, out int completionPortThreads)
        {
            ThreadPool.GetAvailableThreads(out workerThreads, out completionPortThreads);
        }

        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce)
        {
            return ThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, millisecondsTimeOutInterval, executeOnlyOnce);
        }

        //[CLSCompliant(false)]
        //[MethodImpl(MethodImplOptions.NoInlining)]
        //[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.ControlEvidence | SecurityPermissionFlag.ControlPolicy)]
        //public  RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce)
        //{
        //    StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
        //    return ThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, millisecondsTimeOutInterval, executeOnlyOnce, ref stackMark, false);
        //}

        //[MethodImpl(MethodImplOptions.NoInlining)]
        //public  RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce)
        //{
        //    if (millisecondsTimeOutInterval < -1)
        //        throw new ArgumentOutOfRangeException("millisecondsTimeOutInterval", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
        //    StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
        //    return ThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, (uint)millisecondsTimeOutInterval, executeOnlyOnce, ref stackMark, true);
        //}

        //[MethodImpl(MethodImplOptions.NoInlining)]
        //[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.ControlEvidence | SecurityPermissionFlag.ControlPolicy)]
        //public  RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce)
        //{
        //    if (millisecondsTimeOutInterval < -1)
        //        throw new ArgumentOutOfRangeException("millisecondsTimeOutInterval", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
        //    StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
        //    return ThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, (uint)millisecondsTimeOutInterval, executeOnlyOnce, ref stackMark, false);
        //}

        //[MethodImpl(MethodImplOptions.NoInlining)]
        //public  RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, long millisecondsTimeOutInterval, bool executeOnlyOnce)
        //{
        //    if (millisecondsTimeOutInterval < -1L)
        //        throw new ArgumentOutOfRangeException("millisecondsTimeOutInterval", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
        //    StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
        //    return ThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, (uint)millisecondsTimeOutInterval, executeOnlyOnce, ref stackMark, true);
        //}

        //[MethodImpl(MethodImplOptions.NoInlining)]
        //[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.ControlEvidence | SecurityPermissionFlag.ControlPolicy)]
        //public  RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, long millisecondsTimeOutInterval, bool executeOnlyOnce)
        //{
        //    if (millisecondsTimeOutInterval < -1L)
        //        throw new ArgumentOutOfRangeException("millisecondsTimeOutInterval", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
        //    StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
        //    return ThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, (uint)millisecondsTimeOutInterval, executeOnlyOnce, ref stackMark, false);
        //}

        //[MethodImpl(MethodImplOptions.NoInlining)]
        //public  RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce)
        //{
        //    long num = (long)timeout.TotalMilliseconds;
        //    if (num < -1L)
        //        throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
        //    if (num > (long)int.MaxValue)
        //        throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("ArgumentOutOfRange_LessEqualToIntegerMaxVal"));
        //    StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
        //    return ThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, (uint)num, executeOnlyOnce, ref stackMark, true);
        //}

        //[MethodImpl(MethodImplOptions.NoInlining)]
        //[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.ControlEvidence | SecurityPermissionFlag.ControlPolicy)]
        //public  RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce)
        //{
        //    long num = (long)timeout.TotalMilliseconds;
        //    if (num < -1L)
        //        throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
        //    if (num > (long)int.MaxValue)
        //        throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("ArgumentOutOfRange_LessEqualToIntegerMaxVal"));
        //    StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
        //    return ThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, (uint)num, executeOnlyOnce, ref stackMark, false);
        //}

        [MethodImpl(MethodImplOptions.NoInlining)]
        public bool QueueUserWorkItem(WaitCallback callBack, object state)
        {
            return ThreadPool.QueueUserWorkItem(callBack, state);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public bool QueueUserWorkItem(WaitCallback callBack)
        {
            return ThreadPool.QueueUserWorkItem(callBack);
        }

        //[MethodImpl(MethodImplOptions.NoInlining)]
        //[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.ControlEvidence | SecurityPermissionFlag.ControlPolicy)]
        //public  bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state)
        //{
        //    StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
        //    return ThreadPool.QueueUserWorkItemHelper(callBack, state, ref stackMark, false);
        //}


        //[CLSCompliant(false)]
        //[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.ControlEvidence | SecurityPermissionFlag.ControlPolicy)]
        //public  unsafe bool UnsafeQueueNativeOverlapped(NativeOverlapped* overlapped)
        //{
        //    return ThreadPool.PostQueuedCompletionStatus(overlapped);
        //}


        //[Obsolete("ThreadPool.BindHandle(IntPtr) has been deprecated.  Please use ThreadPool.BindHandle(SafeHandle) instead.", false)]
        //[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        //public  bool BindHandle(IntPtr osHandle)
        //{
        //    return ThreadPool.BindIOCompletionCallbackNative(osHandle);
        //}

        //[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        //public  bool BindHandle(SafeHandle osHandle)
        //{
        //    if (osHandle == null)
        //        throw new ArgumentNullException("osHandle");
        //    bool success = false;
        //    RuntimeHelpers.PrepareConstrainedRegions();
        //    try
        //    {
        //        osHandle.DangerousAddRef(ref success);
        //        return ThreadPool.BindIOCompletionCallbackNative(osHandle.DangerousGetHandle());
        //    }
        //    finally
        //    {
        //        if (success)
        //            osHandle.DangerousRelease();
        //    }
        //}


    }
}
