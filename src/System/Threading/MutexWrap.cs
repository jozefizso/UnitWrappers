using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;

namespace UnitWrappers.System.Threading
{
    public class MutexWrap : IMutex, IWrap<Mutex>, IWrap<WaitHandle>
    {

        private Mutex _underlyingObject;

        public static implicit operator MutexWrap(Mutex o)
        {
            return new MutexWrap(o);
        }

        public static implicit operator Mutex(MutexWrap o)
        {
            return o._underlyingObject;
        }


        public bool WaitOne()
        {
            return _underlyingObject.WaitOne();
        }

        Mutex IWrap<Mutex>.UnderlyingObject{get { return _underlyingObject; }}
        WaitHandle IWrap<WaitHandle>.UnderlyingObject { get { return _underlyingObject; } }

        public MutexWrap(Mutex mutex)
        {
            _underlyingObject = mutex;
        }

        public MutexWrap(bool initiallyOwned)
        {
            _underlyingObject = new Mutex(initiallyOwned);
        }

        public MutexWrap(bool initiallyOwned, string name)
        {
            _underlyingObject = new Mutex(initiallyOwned, name);
        }

        public void Close()
        {
            _underlyingObject.Close();
        }

        public MutexWrap(bool initiallyOwned, string name, out bool createNew)
        {
            _underlyingObject = new Mutex(initiallyOwned, name, out createNew);
        }

        public MutexWrap(bool initiallyOwned, string name, out bool createNew, MutexSecurity mutexSecurity)
        {
            _underlyingObject = new Mutex(initiallyOwned, name, out createNew, mutexSecurity);
        }


         void IDisposable.Dispose()
        {
            (_underlyingObject as IDisposable).Dispose();
        }
    }
}
