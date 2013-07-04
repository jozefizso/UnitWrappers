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
    public class ThreadWrap : IThread,IWrap<Thread>
    {
        public Thread _underlyingObject;

        Thread IWrap<Thread>.UnderlyingObject { get { return _underlyingObject; } }


        public static implicit operator ThreadWrap(Thread o)
        {
            return new ThreadWrap(o);
        }

        public static implicit operator Thread(ThreadWrap o)
        {
            return o._underlyingObject;
        }


        public ThreadWrap(Thread thread)
        {
            _underlyingObject = thread;
        }
        #if !PORTABLE
        public ExecutionContext ExecutionContext
        {
            get
            {
                return _underlyingObject.ExecutionContext;
            }
        }


        public string Name
        {
            get { return _underlyingObject.Name; }
            set { _underlyingObject.Name = Name; }
        }

        public ThreadWrap(ThreadStart start)
        {
            _underlyingObject = new global::System.Threading.Thread(start);
        }

        public ThreadWrap(ParameterizedThreadStart start)
        {
            _underlyingObject = new global::System.Threading.Thread(start);
        }


        public ThreadWrap(ParameterizedThreadStart start, int maxStackSize)
        {
            _underlyingObject = new global::System.Threading.Thread(start, maxStackSize);
        }

        public ThreadWrap(ThreadStart start, int maxStackSize)
        {
            _underlyingObject = new global::System.Threading.Thread(start, maxStackSize);
        }
#endif
        /// <inheritdoc />
        public CultureInfo CurrentCulture
        {
            get
            {
                return _underlyingObject.CurrentCulture;
            }
            set
            {
                _underlyingObject.CurrentCulture = value;
            }
        }

        /// <inheritdoc />
        public CultureInfo CurrentUICulture
        {
            get
            {
                return _underlyingObject.CurrentUICulture;
            }
            set
            {
                _underlyingObject.CurrentUICulture = value;
            }
        }



#if !PORTABLE

        /// <inheritdoc />
        public bool IsAlive
        {
            get { return _underlyingObject.IsAlive; }
        }

        /// <inheritdoc />
        public bool IsThreadPoolThread
        {
            get { return _underlyingObject.IsThreadPoolThread; }
        }

        /// <inheritdoc />
        public ThreadState ThreadState
        {
            get { return _underlyingObject.ThreadState; }
        }

        /// <inheritdoc />
        public bool IsBackground
        {
            get { return _underlyingObject.IsBackground; }
            set { _underlyingObject.IsBackground = value; }
        }
        /// <inheritdoc />
        public ThreadPriority Priority
        {
            get { return _underlyingObject.Priority; }
            set { _underlyingObject.Priority = value; }
        }

        /// <inheritdoc />
        public void Abort()
        {
            _underlyingObject.Abort();
        }

        public void Abort(object stateInfo)
        {
           _underlyingObject.Abort(stateInfo);
        }

        public ApartmentState GetApartmentState()
        {
            return _underlyingObject.GetApartmentState();
        }

        /// <inheritdoc />
        public void SetApartmentState(ApartmentState state)
        {
            _underlyingObject.SetApartmentState(state);
        }
        /// <inheritdoc />
        public void Start()
        {
            _underlyingObject.Start();
        }
        /// <inheritdoc />
        public void Start(object parameter)
        {
            _underlyingObject.Start(parameter);
        }
        /// <inheritdoc />
        public void Join()
        {
            _underlyingObject.Join();
        }

        public bool Join(int millisecondsTimeout)
        {
          return  _underlyingObject.Join(millisecondsTimeout);
        }

        public bool Join(TimeSpan timeout)
        {
            return _underlyingObject.Join(timeout);
        }

        public void Interrupt()
        {
            _underlyingObject.Interrupt();
        }

        public bool TrySetApartmentState(ApartmentState state)
        {
            return _underlyingObject.TrySetApartmentState(state);
        }

#endif
        /// <inheritdoc />
        public int ManagedThreadId
        {
            get { return _underlyingObject.ManagedThreadId; }
        }

        public override  int GetHashCode()
        {
            return _underlyingObject.GetHashCode();
        }
    }
}
