using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using NUnit.Framework;
using Timer = System.Timers.Timer;

namespace UnitWrappers.NET40.Samples.System.Timers
{
    [TestFixture]
    public class TimerTests
    {
        [Test]
        public void Timer_Dispose_noTicksAnymore()
        {
            global::System.Timers.Timer t = new Timer(100);
            var tc = 0;
            t.Elapsed += (s, e) => tc++;
            t.Start();
            Thread.Sleep(200);
            t.Dispose();
            Thread.Sleep(500);
            Assert.Less(tc,3);
            Assert.GreaterOrEqual(tc, 1);
        }

   
    }
}
