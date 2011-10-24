using System;
using System.Runtime.Remoting.Contexts;
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
    }
}