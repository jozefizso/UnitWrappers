using System;
using MeasureIt;
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
       
            
            SpeedTesting.Do(output,loop_datetimenow,
               () => date_time_now(),
               () => date_time_now_wapper());
        }

        private const int loop_datetimenow = 200000;

        public void date_time_now()
        {
            for (int i = 0; i < loop_datetimenow; i++)
            {
                var now = DateTime.Now;
            }
        }

        public void date_time_now_wapper()
        {


            for (int i = 0; i < loop_datetimenow; i++)
            {
                var now = _dateTime.Now;
            }
        }

        [Test]
        public void EnvironmentUserName()
        {
            var output = Console.Out;
            _environment = new EnvironmentWrap();
            SpeedTesting.Do(output,loop_datetimenow,
               () => environment_username(),
               () => environment_username_wrapper());
        }

        private int loop = 200;
        public void environment_username()
        {
            for (int i = 0; i < loop; i++)
            {
                var name = Environment.UserName;
            }
        }

        public void environment_username_wrapper()
        {
            for (int i = 0; i < loop; i++)
            {
                var name = _environment.UserName;
            }
        }
    }
}
