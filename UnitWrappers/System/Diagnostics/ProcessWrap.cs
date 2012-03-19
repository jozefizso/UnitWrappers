using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;

namespace UnitWrappers.System.Diagnostics
{
    ///<summary>
    /// Wrapper for <see cref="T:System.Diagnostics.Process"/> class.
    ///</summary>
    public class ProcessWrap :  IProcess
    {
        private IProcessStartInfo startInfo;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.Diagnostics.ProcessWrap"/> class from framework <see cref="Process"/> class.
        /// </summary>
        /// <param name="process"></param>
        public ProcessWrap(Process process)
        {
            UnderlyingObject = process;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.Diagnostics.ProcessWrap"/> class.
        /// </summary>
        public ProcessWrap()
        {
            UnderlyingObject = new Process();
        }

        public int ExitCode
        {
            get { return UnderlyingObject.ExitCode; }
        }

        public void Close()
        {
            UnderlyingObject.Close();
        }

        public Process UnderlyingObject { get; private set; }

        public bool Start()
        {
            return UnderlyingObject.Start();
        }

        public IProcessStartInfo StartInfo
        {
            get { return startInfo ?? (startInfo = new ProcessStartInfoWrap(UnderlyingObject.StartInfo)); }
            set { startInfo = value; }
        }

        public void WaitForExit()
        {
            UnderlyingObject.WaitForExit();
        }

        public bool WaitForExit(int milliseconds)
        {
            return UnderlyingObject.WaitForExit(milliseconds);
        }

        public bool WaitForInputIdle()
        {
            return UnderlyingObject.WaitForInputIdle();
        }

        public bool CloseMainWindow()
        {
            return UnderlyingObject.CloseMainWindow();
        }

        public void Kill()
        {
            UnderlyingObject.Kill();
        }

        public IntPtr MainWindowHandle
        {
            get { return UnderlyingObject.MainWindowHandle; }
        }

        public event DataReceivedEventHandler ErrorDataReceived
        {
            add { UnderlyingObject.ErrorDataReceived += value; }
            remove { UnderlyingObject.ErrorDataReceived -= value; }
        }

        public event EventHandler Exited
        {
            add { UnderlyingObject.Exited += value; }
            remove { UnderlyingObject.Exited -= value; }
        }

        public event DataReceivedEventHandler OutputDataReceived
        {
            add { UnderlyingObject.OutputDataReceived += value; }
            remove { UnderlyingObject.OutputDataReceived -= value; }
        }

        public void BeginErrorReadLine()
        {
            UnderlyingObject.BeginErrorReadLine();
        }

        public void BeginOutputReadLine()
        {
            UnderlyingObject.BeginOutputReadLine();
        }

        public void CancelErrorRead()
        {
            UnderlyingObject.CancelErrorRead();
        }

        public void CancelOutputRead()
        {
            UnderlyingObject.CancelOutputRead();
        }

        public void Refresh()
        {
            UnderlyingObject.Refresh();
        }

        public bool WaitForInputIdle(int milliseconds)
        {
          return  UnderlyingObject.WaitForInputIdle();
        }

        public int BasePriority
        {
            get { return UnderlyingObject.BasePriority; }
        }

        public bool EnableRaisingEvents
        {
            get { return UnderlyingObject.EnableRaisingEvents ; }
            set { UnderlyingObject.EnableRaisingEvents = value; }
        }

        public DateTime ExitTime
        {
            get { return UnderlyingObject.ExitTime ; }
        }

        public IntPtr Handle
        {
            get { return UnderlyingObject.Handle ; }
        }

        public int HandleCount
        {
            get { return UnderlyingObject.HandleCount ; }
        }

        public bool HasExited
        {
            get { return UnderlyingObject.HasExited ; }
        }

        public int Id
        {
            get { return UnderlyingObject.Id; }
        }

        public string MachineName
        {
            get { return UnderlyingObject.MachineName ; }
        }

        public ProcessModule MainModule
        {
            get { return UnderlyingObject.MainModule ; }
        }

        public string MainWindowTitle
        {
            get { return UnderlyingObject.MainWindowTitle; }
        }

        public IntPtr MaxWorkingSet
        {
            get { return UnderlyingObject.MaxWorkingSet; }
            set { UnderlyingObject.MaxWorkingSet = value; }
        }

        public IntPtr MinWorkingSet
        {
            get { return UnderlyingObject.MinWorkingSet; }
            set { UnderlyingObject.MinWorkingSet = value; }
        }

        public ProcessModuleCollection Modules
        {
            get { return UnderlyingObject.Modules; }
        }

        public long NonpagedSystemMemorySize64
        {
            get { return UnderlyingObject.NonpagedSystemMemorySize64; }
        }

        public long PagedMemorySize64
        {
            get { return UnderlyingObject.PagedMemorySize64; }
        }

        public long PagedSystemMemorySize64
        {
            get { return UnderlyingObject.PagedSystemMemorySize64; }
        }

        public long PeakPagedMemorySize64
        {
            get { return UnderlyingObject.PeakPagedMemorySize64; }
        }

        public long PeakVirtualMemorySize64
        {
            get { return UnderlyingObject.PeakVirtualMemorySize64; }
        }

        public long PeakWorkingSet64
        {
            get { return UnderlyingObject.PeakWorkingSet64; }
        }

        public bool PriorityBoostEnabled
        {
            get { return UnderlyingObject.PriorityBoostEnabled; }
            set { UnderlyingObject.PriorityBoostEnabled = value; }
        }

        public ProcessPriorityClass PriorityClass
        {
            get { return UnderlyingObject.PriorityClass ; }
            set { UnderlyingObject.PriorityClass = value; }
        }

        public TimeSpan PrivilegedProcessorTime
        {
            get { return UnderlyingObject .PrivilegedProcessorTime; }
        }

        public string ProcessName
        {
            get { return UnderlyingObject.ProcessName ; }
        }

        public IntPtr ProcessorAffinity
        {
            get { return UnderlyingObject.ProcessorAffinity; }
            set { UnderlyingObject.ProcessorAffinity = value; }
        }

        public bool Responding
        {
            get { return UnderlyingObject.Responding; }
        }

        public int SessionId
        {
            get { return UnderlyingObject.SessionId ; }
        }

        public StreamReader StandardError
        {
            get { return UnderlyingObject.StandardError; }
        }

        public StreamWriter StandardInput
        {
            get { return UnderlyingObject.StandardInput; }
        }

        public StreamReader StandardOutput
        {
            get { return UnderlyingObject.StandardOutput; }
        }

        public DateTime StartTime
        {
            get { return UnderlyingObject.StartTime ; }
        }

        public ISynchronizeInvoke SynchronizingObject
        {
            get { return UnderlyingObject.SynchronizingObject; }
            set { UnderlyingObject.SynchronizingObject = value; }
        }

        public ProcessThreadCollection Threads
        {
            get { return UnderlyingObject.Threads; }
        }

        public TimeSpan TotalProcessorTime
        {
            get { return UnderlyingObject.TotalProcessorTime ; }
        }

        public TimeSpan UserProcessorTime
        {
            get { return UnderlyingObject.UserProcessorTime; }
        }

        public long VirtualMemorySize64
        {
            get { return UnderlyingObject.VirtualMemorySize64; }
        }

        public long WorkingSet64
        {
            get { return UnderlyingObject.WorkingSet64; }
        }

        public override string ToString()
        {
            return UnderlyingObject.ToString();
        }

        public void Dispose()
        {
            UnderlyingObject.Dispose();
        }

        public ISite Site
        {
            get { return UnderlyingObject.Site; }
            set { UnderlyingObject.Site = value; }
        }

        public event EventHandler Disposed
        {
            add { UnderlyingObject.Disposed += value; }
            remove { UnderlyingObject.Disposed -= value; }
        }
    }
}