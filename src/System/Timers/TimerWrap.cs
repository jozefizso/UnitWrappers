using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.ComponentModel;
using System.Security.Permissions;

namespace UnitWrappers.System.Timers
{
    [DefaultEvent("Elapsed")]
    [DefaultProperty("Interval")]
    [HostProtection(SecurityAction.LinkDemand, ExternalThreading = true, Synchronization = true)]
    public class TimerWrap : ITimer
    {
        public event ElapsedEventHandler Elapsed ;

        private readonly Timer _timer;

        public TimerWrap()
        {
            _timer = new Timer();
            _timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Elapsed !=null)
                   Elapsed(sender, e);
        }

        public double Interval
        {
            get { return _timer.Interval; }
            set { _timer.Interval = value; }
        }

        public bool AutoReset
        {
            get { return _timer.AutoReset; }
            set { _timer.AutoReset = value; }
        }

        public bool Enabled
        {
            get { return _timer.Enabled; }
            set { _timer.Enabled = value; }
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Dispose()
        {
            _timer.Dispose();
        }

        public void BeginInit()
        {
            _timer.BeginInit();
        }

        public void EndInit()
        {
            _timer.EndInit();
        }
    }
}
