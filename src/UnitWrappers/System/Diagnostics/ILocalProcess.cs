using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace UnitWrappers.System.Diagnostics
{
    /// <summary>
    /// Delaminates members which can be used only against local processes.
    /// </summary>
    public interface ILocalProcess
    {
        [Browsable(false), MonitoringDescription("ProcessTerminated"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        bool HasExited { get; }

        /// <summary>
        /// Gets the value that the associated process specified when it terminated.
        /// </summary>
        [MonitoringDescription("ProcessExitCode"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        int ExitCode { get; }

        [MonitoringDescription("ProcessExitTime"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        DateTime ExitTime { get; }

        [MonitoringDescription("ProcessStartTime"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        DateTime StartTime { get; }

        void Kill();
    }
}
