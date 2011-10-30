using System;
using System.Threading;

namespace UnitWrappers.System.Threading
{
    public class AutoResetEventWrap : IAutoResetEvent
    {
        public AutoResetEvent UnderlyingObject { get; private set; }

        public AutoResetEventWrap(AutoResetEvent eventWaitHandle)
        {
            UnderlyingObject = eventWaitHandle;
        }

        public AutoResetEventWrap(bool initialState)
        {
            UnderlyingObject = new AutoResetEvent(initialState);
        }

        WaitHandle IWaitHandle.UnderlyingObject { get { return UnderlyingObject; } }

        public void Close()
        {
           UnderlyingObject.Close();
        }

        public bool WaitOne()
        {
            return UnderlyingObject.WaitOne();
        }

        void IDisposable.Dispose()
        {
            (UnderlyingObject as IDisposable).Dispose();
        }
    }
}