using System;
using System.Threading;

namespace UnitWrappers.System.Threading
{
    /// <summary>
    /// Wraps instance of <see cref="WaitHandle"/>
    /// </summary>
    public class WaitHandleWrap : IWaitHandle,IWrap<WaitHandle>
    {
        private WaitHandle _underlyingObject;

        public static implicit operator WaitHandleWrap(WaitHandle o)
        {
            return new WaitHandleWrap(o);
        }

        public static implicit operator WaitHandle(WaitHandleWrap o)
        {
            return o._underlyingObject;
        }

        WaitHandle IWrap<WaitHandle>.UnderlyingObject { get { return _underlyingObject; } }

        public WaitHandleWrap(WaitHandle waitHandle)
        {
            _underlyingObject = waitHandle;
        }

        public bool WaitOne()
        {
            return _underlyingObject.WaitOne();
        }

        public void Close()
        {
            _underlyingObject.Close();
        }

        void IDisposable.Dispose()
        {
            (_underlyingObject as IDisposable).Dispose();
        }
    }
}