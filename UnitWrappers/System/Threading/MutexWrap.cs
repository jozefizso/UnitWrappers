using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;

namespace UnitWrappers.System.Threading
{
    public class MutexWrap : IMutex
    {
        /// <summary>
        /// 
        /// </summary>
        public Mutex UnderlyingObject { get; private set; }



        public bool WaitOne()
        {
            return UnderlyingObject.WaitOne();
        }

        WaitHandle IWaitHandle.UnderlyingObject
        {
            get { return UnderlyingObject; }

        }

        public MutexWrap(Mutex mutex)
        {
            UnderlyingObject = mutex;
        }

        public MutexWrap(bool initiallyOwned)
        {
            UnderlyingObject = new Mutex(initiallyOwned);
        }

        public MutexWrap(bool initiallyOwned, string name)
        {
            UnderlyingObject = new Mutex(initiallyOwned, name);
        }

        public void Close()
        {
            UnderlyingObject.Close();
        }

        public MutexWrap(bool initiallyOwned, string name, out bool createNew)
        {
            UnderlyingObject = new Mutex(initiallyOwned, name, out createNew);
        }

        public MutexWrap(bool initiallyOwned, string name, out bool createNew, MutexSecurity mutexSecurity)
        {
            UnderlyingObject = new Mutex(initiallyOwned, name, out createNew, mutexSecurity);
        }


         void IDisposable.Dispose()
        {
            (UnderlyingObject as IDisposable).Dispose();
        }
    }
}
