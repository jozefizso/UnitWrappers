using System;
using System.Threading;

namespace UnitWrappers.System.Threading
{
    /// <summary>
    /// 
    /// </summary>
    public class WaitHandleWrap : IWaitHandle
    {
        public WaitHandle UnderlyingObject { get; private set; }

        public WaitHandleWrap(WaitHandle waitHandle)
        {
            UnderlyingObject = waitHandle;
        }

        public bool WaitOne()
        {
            return UnderlyingObject.WaitOne();
        }

        public void Close()
        {
            UnderlyingObject.Close();
        }

        void IDisposable.Dispose()
        {
            (UnderlyingObject as IDisposable).Dispose();
        }
    }
}