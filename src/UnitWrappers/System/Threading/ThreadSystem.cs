using System;
#if !PORTABLE
using System.Runtime.Remoting.Contexts;
#endif
using System.Security.Principal;
using System.Threading;

namespace UnitWrappers.System.Threading
{
    /// <summary>
    /// Wrapper for static members of <see cref="Thread"/> class.
    /// </summary>
    public class ThreadSystem : IThreadSystem
    {
        /// <inheritdoc />
        public IThread CurrentThread
        {
            get { return new ThreadWrap(Thread.CurrentThread); }
        }

        public IPrincipal CurrentPrincipal
        {
            get { return Thread.CurrentPrincipal; }
            set { Thread.CurrentPrincipal = value; }
        }

#if !PORTABLE
        /// <inheritdoc />
        public void Sleep(int millisecondsTimeout)
        {
            Thread.Sleep(millisecondsTimeout);
        }

        /// <inheritdoc />
        public void Sleep(TimeSpan timeout)
        {
            Thread.Sleep(timeout);
        }

        /// <inheritdoc />
        public Context CurrentContext
        {
            get { return Thread.CurrentContext; }
        }

        public IThread CreateThread(ThreadStart start)
        {
            return new ThreadWrap(start);
        }

        public IThread CreateThread(ParameterizedThreadStart start)
        {
            return new ThreadWrap(start);
        }

        public void MemoryBarrier()
        {
            Thread.MemoryBarrier();
        }

        public void ResetAbort()
        {
            Thread.ResetAbort();
        }

        public void SetData(LocalDataStoreSlot slot, object data)
        {
            Thread.SetData(slot,data);
        }

        public void SpinWait(int iterations)
        {
            Thread.SpinWait(iterations);
        }
#endif
    }
}