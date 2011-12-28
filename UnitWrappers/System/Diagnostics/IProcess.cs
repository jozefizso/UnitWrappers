using System;
using System.ComponentModel;
using System.Diagnostics;

namespace UnitWrappers.System.Diagnostics
{
    /// <summary>
    /// Description of IProcess
    /// </summary>
    public interface IProcess : IComponent
    {

        // Properties

        /// <summary>
        /// Gets the value that the associated process specified when it terminated.
        /// </summary>
        [MonitoringDescription("ProcessExitCode"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        int ExitCode { get; }

        // Methods

        /// <summary>
        /// Frees all the resources that are associated with this component.
        /// </summary>
        void Close();
        /// <summary>
        /// Gets <see cref="T:System.Diagnostics.Process"/> object.
        /// </summary>
        Process UnderlyingObject { get; }
        /// <summary>
        /// Starts (or reuses) the process resource that is specified by the StartInfo  property of this Process component and associates it with the component.
        /// </summary>
        /// <returns>true if a process resource is started; false if no new process resource is started (for example, if an existing process is reused).</returns>
        bool Start();
        /// <summary>
        /// Gets or sets the properties to pass to the Start  method of the Process.
        /// </summary>
        IProcessStartInfo StartInfo { get; set; }
        /// <summary>
        /// Instructs the ProcessInstance  component to wait indefinitely for the associated process to exit.
        /// </summary>
        void WaitForExit();
        /// <summary>
        /// Instructs the Process  component to wait the specified number of milliseconds for the associated process to exit.
        /// </summary>
        /// <param name="milliseconds">The amount of time, in milliseconds, to wait for the associated process to exit. The maximum is the largest possible value of a 32-bit integer, which represents infinity to the operating system.</param>
        /// <returns>true if the associated process has exited; otherwise, false.</returns>
        bool WaitForExit(int milliseconds);
        /// <summary>
        /// Causes the Process  component to wait indefinitely for the associated process to enter an idle state. This overload applies only to processes with a user interface and, therefore, a message loop.
        /// </summary>
        /// <returns>true if the associated process has reached an idle state.</returns>
        bool WaitForInputIdle();

        bool CloseMainWindow();

        void Kill();

        [MonitoringDescription("ProcessMainWindowHandle"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        IntPtr MainWindowHandle { get; }


        [Browsable(true), MonitoringDescription("ProcessAssociated")]
        event DataReceivedEventHandler ErrorDataReceived;
        [Category("Behavior"), MonitoringDescription("ProcessExited")]
        event EventHandler Exited;
        [Browsable(true), MonitoringDescription("ProcessAssociated")]
        event DataReceivedEventHandler OutputDataReceived;

        //// Methods
        //public ProcessInstance();
        //[ComVisible(false)]
        //public void BeginErrorReadLine();
        //[ComVisible(false)]
        //public void BeginOutputReadLine();
        //[ComVisible(false)]
        //public void CancelErrorRead();
        //[ComVisible(false)]
        //public void CancelOutputRead();

 


        void Refresh();

        //public bool WaitForInputIdle(int milliseconds);

        //// Properties
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), MonitoringDescription("ProcessBasePriority")]
        //public int BasePriority { get; }
        [MonitoringDescription("ProcessEnableRaisingEvents"), Browsable(false), DefaultValue(false)]
        bool EnableRaisingEvents { get; set; }
        [MonitoringDescription("ProcessExitTime"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        DateTime ExitTime { get; }
        [MonitoringDescription("ProcessHandle"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        IntPtr Handle { get; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), MonitoringDescription("ProcessHandleCount")]
        int HandleCount { get; }
        [Browsable(false), MonitoringDescription("ProcessTerminated"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        bool HasExited { get; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), MonitoringDescription("ProcessId")]
        int Id { get; }
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), MonitoringDescription("ProcessMachineName")]
        string MachineName { get; }
        [MonitoringDescription("ProcessMainModule"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        ProcessModule MainModule { get; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), MonitoringDescription("ProcessMainWindowTitle")]
        string MainWindowTitle { get; }
        //[MonitoringDescription("ProcessMaxWorkingSet"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public IntPtr MaxWorkingSet { get; set; }
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), MonitoringDescription("ProcessMinWorkingSet")]
        //public IntPtr MinWorkingSet { get; set; }
        //[Browsable(false), MonitoringDescription("ProcessModules"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public ProcessModuleCollection Modules { get; }
        //[ComVisible(false), MonitoringDescription("ProcessNonpagedSystemMemorySize"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public long NonpagedSystemMemorySize64 { get; }
        //[ComVisible(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), MonitoringDescription("ProcessPagedMemorySize")]
        //public long PagedMemorySize64 { get; }
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), MonitoringDescription("ProcessPagedSystemMemorySize"), ComVisible(false)]
        //public long PagedSystemMemorySize64 { get; }
        //[MonitoringDescription("ProcessPeakPagedMemorySize"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), ComVisible(false)]
        //public long PeakPagedMemorySize64 { get; }
        //[ComVisible(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), MonitoringDescription("ProcessPeakVirtualMemorySize")]
        //public long PeakVirtualMemorySize64 { get; }
        //[ComVisible(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), MonitoringDescription("ProcessPeakWorkingSet")]
        //public long PeakWorkingSet64 { get; }
        //[MonitoringDescription("ProcessPriorityBoostEnabled"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public bool PriorityBoostEnabled { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), MonitoringDescription("ProcessPriorityClass")]
        ProcessPriorityClass PriorityClass { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), MonitoringDescription("ProcessPrivilegedProcessorTime")]
        TimeSpan PrivilegedProcessorTime { get; }
        [MonitoringDescription("ProcessProcessName"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        string ProcessName { get; }
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), MonitoringDescription("ProcessProcessorAffinity")]
        //public IntPtr ProcessorAffinity { get; set; }
        //[MonitoringDescription("ProcessResponding"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public bool Responding { get; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), MonitoringDescription("ProcessSessionId")]
        int SessionId { get; }
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), MonitoringDescription("ProcessStandardError"), Browsable(false)]
        //public StreamReader StandardError { get; }
        //[MonitoringDescription("ProcessStandardInput"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        //public StreamWriter StandardInput { get; }
        //[MonitoringDescription("ProcessStandardOutput"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        //public StreamReader StandardOutput { get; }
        [MonitoringDescription("ProcessStartTime"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        DateTime StartTime { get; }
        [MonitoringDescription("ProcessSynchronizingObject"), Browsable(false), DefaultValue((string)null)]
        ISynchronizeInvoke SynchronizingObject { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false), MonitoringDescription("ProcessThreads")]
        ProcessThreadCollection Threads { get; }
        [MonitoringDescription("ProcessTotalProcessorTime"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        TimeSpan TotalProcessorTime { get; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), MonitoringDescription("ProcessUserProcessorTime")]
        TimeSpan UserProcessorTime { get; }
        //[MonitoringDescription("ProcessVirtualMemorySize"), ComVisible(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public long VirtualMemorySize64 { get; }
        //[Obsolete("This property has been deprecated.  Please use System.Diagnostics.ProcessInstance.WorkingSet64 instead.  http://go.microsoft.com/fwlink/?linkid=14202"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), MonitoringDescription("ProcessWorkingSet")]
        //public int WorkingSet { get; }
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), ComVisible(false), MonitoringDescription("ProcessWorkingSet")]
        //public long WorkingSet64 { get; }


    }
}