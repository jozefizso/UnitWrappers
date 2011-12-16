using System;
using System.Globalization;
#if !PORTABLE
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
#endif
using System.Threading;

namespace UnitWrappers.System.Threading
{
    /// <summary>
    /// Wrapper for <see cref="Thread"/> class.
    /// </summary>
    public class ThreadWrap : IThread
    {
        public Thread UnderlyingObject { get; private set; }

        public ThreadWrap(Thread thread)
        {
            UnderlyingObject = thread;
        }

        public ExecutionContext ExecutionContext
        {
            get
            {
                return UnderlyingObject.ExecutionContext;
            }
        }

        public string Name
        {
            get { return UnderlyingObject.Name; }
            set { UnderlyingObject.Name = Name; }
        }

#if !PORTABLE
        public ThreadWrap(ThreadStart start)
        {
            UnderlyingObject = new global::System.Threading.Thread(start);
        }

        public ThreadWrap(ParameterizedThreadStart start)
        {
            UnderlyingObject = new global::System.Threading.Thread(start);
        }


        public ThreadWrap(ParameterizedThreadStart start, int maxStackSize)
        {
            UnderlyingObject = new global::System.Threading.Thread(start, maxStackSize);
        }

        public ThreadWrap(ThreadStart start, int maxStackSize)
        {
            UnderlyingObject = new global::System.Threading.Thread(start, maxStackSize);
        }
#endif
        /// <inheritdoc />
        public CultureInfo CurrentCulture
        {
            get
            {
                return UnderlyingObject.CurrentCulture;
            }
            set
            {
                UnderlyingObject.CurrentCulture = value;
            }
        }

        /// <inheritdoc />
        public CultureInfo CurrentUICulture
        {
            get
            {
                return UnderlyingObject.CurrentUICulture;
            }
            set
            {
                UnderlyingObject.CurrentUICulture = value;
            }
        }



#if !PORTABLE

        /// <inheritdoc />
        public bool IsAlive
        {
            get { return UnderlyingObject.IsAlive; }
        }

        /// <inheritdoc />
        public bool IsThreadPoolThread
        {
            get { return UnderlyingObject.IsThreadPoolThread; }
        }

        /// <inheritdoc />
        public ThreadState ThreadState
        {
            get { return UnderlyingObject.ThreadState; }
        }

        /// <inheritdoc />
        public bool IsBackground
        {
            get { return UnderlyingObject.IsBackground; }
            set { UnderlyingObject.IsBackground = value; }
        }
        /// <inheritdoc />
        public ThreadPriority Priority
        {
            get { return UnderlyingObject.Priority; }
            set { UnderlyingObject.Priority = value; }
        }

        /// <inheritdoc />
        public void Abort()
        {
            UnderlyingObject.Abort();
        }

        public void Abort(object stateInfo)
        {
           UnderlyingObject.Abort(stateInfo);
        }

        public ApartmentState GetApartmentState()
        {
            return UnderlyingObject.GetApartmentState();
        }

        /// <inheritdoc />
        public void SetApartmentState(ApartmentState state)
        {
            UnderlyingObject.SetApartmentState(state);
        }
        /// <inheritdoc />
        public void Start()
        {
            UnderlyingObject.Start();
        }
        /// <inheritdoc />
        public void Start(object parameter)
        {
            UnderlyingObject.Start(parameter);
        }
        /// <inheritdoc />
        public void Join()
        {
            UnderlyingObject.Join();
        }

        public bool Join(int millisecondsTimeout)
        {
          return  UnderlyingObject.Join(millisecondsTimeout);
        }

        public bool Join(TimeSpan timeout)
        {
            return UnderlyingObject.Join(timeout);
        }

        public void Interrupt()
        {
            UnderlyingObject.Interrupt();
        }

        public bool TrySetApartmentState(ApartmentState state)
        {
            return UnderlyingObject.TrySetApartmentState(state);
        }

#endif
        /// <inheritdoc />
        public int ManagedThreadId
        {
            get { return UnderlyingObject.ManagedThreadId; }
        }

        public override  int GetHashCode()
        {
            return UnderlyingObject.GetHashCode();
        }
    }
}
