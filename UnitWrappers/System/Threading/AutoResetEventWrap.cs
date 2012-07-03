using System;
using System.Threading;

namespace UnitWrappers.System.Threading
{
    public class AutoResetEventWrap : IAutoResetEvent
    {
        private AutoResetEvent _underlyingObject;

        public AutoResetEventWrap(AutoResetEvent eventWaitHandle)
        {
            _underlyingObject = eventWaitHandle;
        }

        public AutoResetEventWrap(bool initialState)
        {
            _underlyingObject = new AutoResetEvent(initialState);
        }

        WaitHandle IWrap<WaitHandle>.UnderlyingObject { get { return _underlyingObject; } }

        public void Close()
        {
            _underlyingObject.Close();
        }

        public bool WaitOne()
        {
            return _underlyingObject.WaitOne();
        }

        void IDisposable.Dispose()
        {
            (_underlyingObject as IDisposable).Dispose();
        }
    }
}