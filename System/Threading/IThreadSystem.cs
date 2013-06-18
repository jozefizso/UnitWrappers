using System;
#if !PORTABLE
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Contexts;
using System.Security.Permissions;
using System.Security.Principal;
using System.Threading;

#endif

namespace UnitWrappers.System.Threading
{
    public interface IThreadSystem
    {
        /// <summary>
        /// Gets the currently running thread.
        /// </summary>
        IThread CurrentThread { get; }

        IPrincipal CurrentPrincipal { get; [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)] set; }
#if !PORTABLE
        /// <summary>
        /// Suspends the current thread for a specified time.
        /// </summary>
        /// <param name="millisecondsTimeout">The number of milliseconds for which the thread is blocked. Specify zero (0) to indicate that this thread should be suspended to allow other waiting threads to execute. Specify Infinite  to block the thread indefinitely.</param>
        void Sleep(int millisecondsTimeout);

        /// <summary>
        /// Blocks the current thread for a specified time.
        /// </summary>
        /// <param name="timeout">A TimeSpan  set to the amount of time for which the thread is blocked. Specify zero to indicate that this thread should be suspended to allow other waiting threads to execute. Specify Timeout.Infinite to block the thread indefinitely.</param>
        void Sleep(TimeSpan timeout);

        /// <summary>
        /// Gets the current context in which the thread is executing.
        /// </summary>
        /// <value>
        /// A <see cref="Context"/> representing the current thread context
        /// </value>
        Context CurrentContext { get; }

        IThread CreateThread(ThreadStart start);

        IThread CreateThread(ParameterizedThreadStart start);
#endif

        [MethodImpl(MethodImplOptions.InternalCall)]
        void MemoryBarrier();
        [SecurityPermission(SecurityAction.Demand, ControlThread = true)]
        void ResetAbort();

        [HostProtection(SecurityAction.LinkDemand, SharedState = true, ExternalThreading = true)]
        void SetData(LocalDataStoreSlot slot, object data);
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success), HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
        void SpinWait(int iterations);
    }
}
