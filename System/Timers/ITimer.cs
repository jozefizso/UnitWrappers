using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Security.Permissions;
using System.Timers;

namespace UnitWrappers.System.Timers
{


    public interface ITimer : ISupportInitialize, IDisposable
    {
        event ElapsedEventHandler Elapsed;

        double Interval { get; set; }

        bool AutoReset { get; set; }

        bool Enabled { get; set; }

        void Start();
    }
}
