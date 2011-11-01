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
        private readonly global::System.Threading.Thread _thread;

        public ThreadWrap(Thread thread)
        {
            _thread = thread;
        }
        public ExecutionContext ExecutionContext
        {
            get
            {
                return _thread.ExecutionContext;
            }
        }

        public string Name
        {
            get { return _thread.Name; }
            set { _thread.Name = Name; }
        }

#if !PORTABLE
        public ThreadWrap(ThreadStart start)
        {
            _thread = new global::System.Threading.Thread(start);
        }

        public ThreadWrap(ParameterizedThreadStart start)
        {
            _thread = new global::System.Threading.Thread(start);
        }


        public ThreadWrap(ParameterizedThreadStart start, int maxStackSize)
        {
            _thread = new global::System.Threading.Thread(start, maxStackSize);
        }

        public ThreadWrap(ThreadStart start, int maxStackSize)
        {
            _thread = new global::System.Threading.Thread(start, maxStackSize);
        }
#endif
        /// <inheritdoc />
        public CultureInfo CurrentCulture
        {
            get
            {
                return _thread.CurrentCulture;
            }
            set
            {
                _thread.CurrentCulture = value;
            }
        }

        /// <inheritdoc />
        public CultureInfo CurrentUICulture
        {
            get
            {
                return _thread.CurrentUICulture;
            }
            set
            {
                _thread.CurrentUICulture = value;
            }
        }



#if !PORTABLE

        /// <inheritdoc />
        public bool IsAlive
        {
            get { return _thread.IsAlive; }
        }

        /// <inheritdoc />
        public bool IsThreadPoolThread
        {
            get { return _thread.IsThreadPoolThread; }
        }

        /// <inheritdoc />
        public ThreadState ThreadState
        {
            get { return _thread.ThreadState; }
        }

        /// <inheritdoc />
        public bool IsBackground
        {
            get { return _thread.IsBackground; }
            set { _thread.IsBackground = value; }
        }
        /// <inheritdoc />
        public ThreadPriority Priority
        {
            get { return _thread.Priority; }
            set { _thread.Priority = value; }
        }

        /// <inheritdoc />
        public void Abort()
        {
            _thread.Abort();
        }

        public void Abort(object stateInfo)
        {
           _thread.Abort(stateInfo);
        }

        public ApartmentState GetApartmentState()
        {
            return _thread.GetApartmentState();
        }

        /// <inheritdoc />
        public void SetApartmentState(ApartmentState state)
        {
            _thread.SetApartmentState(state);
        }
        /// <inheritdoc />
        public void Start()
        {
            _thread.Start();
        }
        /// <inheritdoc />
        public void Start(object parameter)
        {
            _thread.Start(parameter);
        }
        /// <inheritdoc />
        public void Join()
        {
            _thread.Join();
        }

        public bool Join(int millisecondsTimeout)
        {
          return  _thread.Join(millisecondsTimeout);
        }

        public bool Join(TimeSpan timeout)
        {
            return _thread.Join(timeout);
        }

        public void Interrupt()
        {
            _thread.Interrupt();
        }

        public bool TrySetApartmentState(ApartmentState state)
        {
            return _thread.TrySetApartmentState(state);
        }

#endif
        /// <inheritdoc />
        public int ManagedThreadId
        {
            get { return _thread.ManagedThreadId; }
        }

        public override  int GetHashCode()
        {
            return _thread.GetHashCode();
        }
    }
}
