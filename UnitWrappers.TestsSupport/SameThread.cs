using System;
using System.Globalization;
using System.Threading;
using UnitWrappers.System.Threading;

namespace UnitWrappers.TestsSupport
{
    public class SameThread : IThread
    {
        private ParameterizedThreadStart _parameterizedThreadStart;
        private ThreadStart _threadStart;

        public SameThread(ParameterizedThreadStart handler)
        {
            _parameterizedThreadStart = handler;
        }

        public SameThread(ThreadStart handler)
        {
            _threadStart = handler;
        }

        public CultureInfo CurrentCulture
        {
            get { return global::System.Threading.Thread.CurrentThread.CurrentCulture; }
            set { global::System.Threading.Thread.CurrentThread.CurrentCulture = value; }
        }

        public int ManagedThreadId { get; private set; }
        public CultureInfo CurrentUICulture { get; set; }
        public ExecutionContext ExecutionContext { get; private set; }
        public string Name { get; set; }

        public bool IsAlive
        {
            get { return false; }
        }

        public bool IsThreadPoolThread { get; private set; }
        public ThreadState ThreadState { get; private set; }
        public bool IsBackground { get; set; }
        public ThreadPriority Priority { get; set; }

        public void Abort()
        {
            
        }

        public void Abort(object stateInfo)
        {
            throw new NotImplementedException();
        }

        public ApartmentState GetApartmentState()
        {
            throw new NotImplementedException();
        }

        public void SetApartmentState(ApartmentState state)
        {
            
        }

        public void Start()
        {
            _threadStart.Invoke();
        }

        public void Start(object parameter)
        {
           _parameterizedThreadStart.Invoke(parameter);
        }

        public void Join()
        {
            throw new NotImplementedException();
        }

        public bool Join(int millisecondsTimeout)
        {
            throw new NotImplementedException();
        }

        public bool Join(TimeSpan timeout)
        {
            throw new NotImplementedException();
        }

        public void Interrupt()
        {
            throw new NotImplementedException();
        }

        public bool TrySetApartmentState(ApartmentState state)
        {
            throw new NotImplementedException();
        }
    }
}