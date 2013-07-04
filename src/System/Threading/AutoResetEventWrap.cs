using System;
using System.Threading;

namespace UnitWrappers.System.Threading
{
    public class AutoResetEventWrap : IAutoResetEvent, IWrap<AutoResetEvent>, IWrap<WaitHandle>
    {
        private AutoResetEvent _underlyingObject;

        public static implicit operator AutoResetEventWrap(AutoResetEvent o)
        {
            return new AutoResetEventWrap(o);
        }

        public static implicit operator AutoResetEvent(AutoResetEventWrap o)
        {
            return o._underlyingObject;
        }

        public AutoResetEventWrap(AutoResetEvent eventWaitHandle)
        {
            _underlyingObject = eventWaitHandle;
        }

        public AutoResetEventWrap(bool initialState)
        {
            _underlyingObject = new AutoResetEvent(initialState);
        }

        AutoResetEvent IWrap<AutoResetEvent>.UnderlyingObject { get { return _underlyingObject; } }
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