using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace UnitWrappers.System.Threading
{
    public class MutexWrap:IMutex
    {
        public MutexWrap(Mutex mutex)
        {
            UnderlyingObject = mutex;
        }

        public Mutex UnderlyingObject { get; set; }
    }
}
