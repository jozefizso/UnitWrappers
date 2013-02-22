using System.Threading;

namespace UnitWrappers.TestsSupport
{
    public class SameThread : ThreadWrapBase
    {
        private ParameterizedThreadStart _parameterizedThreadStart;
        private ThreadStart _threadStart;
        private Thread _thread;

        public SameThread(ParameterizedThreadStart start)
        {
            _thread = Thread.CurrentThread;
            _parameterizedThreadStart = start;
        }

        public SameThread(ThreadStart start)
        {
            _thread = Thread.CurrentThread;
            _threadStart = start;
        }

        public override void Start()
        {
            _threadStart.Invoke();
        }

        public override void Start(object parameter)
        {
            _parameterizedThreadStart.Invoke(parameter);
        }




    }
}