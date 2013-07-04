using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

using UnitWrappers.System.Threading;

namespace UnitWrappers.Samples.System.Threading
{
    [TestFixture]
    public class WaithHandles
    {

 

        [Test]
        public void WaitAll_MutexAndAutoResetEvent_runs()
        {
            IAutoResetEvent autoResetEvent = new AutoResetEventWrap(false);
            IMutex mutex = new MutexWrap(false);
            IWaitHandleSystem waitHandleSystem = NSubstitute.Substitute.For<IWaitHandleSystem>();
            waitHandleSystem.WaitAll(new IWaitHandle[] {mutex, autoResetEvent});
        }
    }
}
