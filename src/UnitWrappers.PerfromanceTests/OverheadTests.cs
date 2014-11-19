using System;
using NStopwatch;
using NUnit.Framework;
using UnitWrappers.System;

namespace UnitWrappers.PerfromanceTests
{
    [TestFixture]
    public class OverheadTests
    {
        private IDateTimeSystem _dateTime;
        private IEnvironment _environment;

        [Test]
        public void DateTimeNow_callManyTimes()
        {
            var output = Console.Out;

            _dateTime = new DateTimeSystem();
       
            
            SpeedTesting.Do(output,5,200000,
               (r) => date_time_now(r),
               (r) => date_time_now_wapper(r));
        }



        public void date_time_now(long repeats)
        {
            for (var i = 0; i < repeats; i++)
            {
                var now = DateTime.Now;
            }
        }

        public void date_time_now_wapper(long repeats)
        {


            for (var i = 0; i < repeats; i++)
            {
                var now = _dateTime.Now;
            }
        }

        [Test]
        public void EnvironmentUserName()
        {
            var output = Console.Out;
            _environment = new EnvironmentWrap();
            SpeedTesting.Do(output,5,2000,
               (r) => environment_username(r),
               (r) => environment_username_wrapper(r));
        }

        public void environment_username(long repeats)
        {
            for (var i = 0; i < repeats; i++)
            {
                var name = Environment.UserName;
            }
        }

        public void environment_username_wrapper(long repeats)
        {
            for (var i = 0; i < repeats; i++)
            {
                var name = _environment.UserName;
            }
        }
    }
}
