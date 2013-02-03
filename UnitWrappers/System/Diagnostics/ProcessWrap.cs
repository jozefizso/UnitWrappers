using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;

namespace UnitWrappers.System.Diagnostics
{
    ///<summary>
    /// Wrapper for <see cref="T:System.Diagnostics.Process"/> class.
    ///</summary>
    public class ProcessWrap : IProcess, IWrap<Process>
    {
        public Process _underlyingObject;
        private IProcessStartInfo startInfo;

        Process IWrap<Process>.UnderlyingObject { get { return _underlyingObject; } }

        public static implicit operator ProcessWrap(Process o)
        {
            return new ProcessWrap(o);
        }

        public static implicit operator Process(ProcessWrap o)
        {
            return o._underlyingObject;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.Diagnostics.ProcessWrap"/> class from framework <see cref="Process"/> class.
        /// </summary>
        /// <param name="process"></param>
        public ProcessWrap(Process process)
        {
            _underlyingObject = process;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.Diagnostics.ProcessWrap"/> class.
        /// </summary>
        public ProcessWrap()
        {
            _underlyingObject = new Process();
        }

        public int ExitCode
        {
            get { return _underlyingObject.ExitCode; }
        }

        public void Close()
        {
            _underlyingObject.Close();
        }



        public bool Start()
        {
            return _underlyingObject.Start();
        }

        public IProcessStartInfo StartInfo
        {
            get { return startInfo ?? (startInfo = new ProcessStartInfoWrap(_underlyingObject.StartInfo)); }
            set { startInfo = value; }
        }

        public void WaitForExit()
        {
            _underlyingObject.WaitForExit();
        }

        public bool WaitForExit(int milliseconds)
        {
            return _underlyingObject.WaitForExit(milliseconds);
        }

        public bool WaitForInputIdle()
        {
            return _underlyingObject.WaitForInputIdle();
        }

        public bool CloseMainWindow()
        {
            return _underlyingObject.CloseMainWindow();
        }

        public void Kill()
        {
            _underlyingObject.Kill();
        }

        public IntPtr MainWindowHandle
        {
            get { return _underlyingObject.MainWindowHandle; }
        }

        public event DataReceivedEventHandler ErrorDataReceived
        {
            add { _underlyingObject.ErrorDataReceived += value; }
            remove { _underlyingObject.ErrorDataReceived -= value; }
        }

        public event EventHandler Exited
        {
            add { _underlyingObject.Exited += value; }
            remove { _underlyingObject.Exited -= value; }
        }

        public event DataReceivedEventHandler OutputDataReceived
        {
            add { _underlyingObject.OutputDataReceived += value; }
            remove { _underlyingObject.OutputDataReceived -= value; }
        }

        public void BeginErrorReadLine()
        {
            _underlyingObject.BeginErrorReadLine();
        }

        public void BeginOutputReadLine()
        {
            _underlyingObject.BeginOutputReadLine();
        }

        public void CancelErrorRead()
        {
            _underlyingObject.CancelErrorRead();
        }

        public void CancelOutputRead()
        {
            _underlyingObject.CancelOutputRead();
        }

        public void Refresh()
        {
            _underlyingObject.Refresh();
        }

        public bool WaitForInputIdle(int milliseconds)
        {
            return _underlyingObject.WaitForInputIdle();
        }

        public int BasePriority
        {
            get { return _underlyingObject.BasePriority; }
        }

        public bool EnableRaisingEvents
        {
            get { return _underlyingObject.EnableRaisingEvents; }
            set { _underlyingObject.EnableRaisingEvents = value; }
        }

        public DateTime ExitTime
        {
            get { return _underlyingObject.ExitTime; }
        }

        public IntPtr Handle
        {
            get { return _underlyingObject.Handle; }
        }

        public int HandleCount
        {
            get { return _underlyingObject.HandleCount; }
        }

        public bool HasExited
        {
            get { return _underlyingObject.HasExited; }
        }

        public int Id
        {
            get { return _underlyingObject.Id; }
        }

        public string MachineName
        {
            get { return _underlyingObject.MachineName; }
        }

        public ProcessModule MainModule
        {
            get { return _underlyingObject.MainModule; }
        }

        public string MainWindowTitle
        {
            get { return _underlyingObject.MainWindowTitle; }
        }

        public IntPtr MaxWorkingSet
        {
            get { return _underlyingObject.MaxWorkingSet; }
            set { _underlyingObject.MaxWorkingSet = value; }
        }

        public IntPtr MinWorkingSet
        {
            get { return _underlyingObject.MinWorkingSet; }
            set { _underlyingObject.MinWorkingSet = value; }
        }

        public ProcessModuleCollection Modules
        {
            get { return _underlyingObject.Modules; }
        }

        public long NonpagedSystemMemorySize64
        {
            get { return _underlyingObject.NonpagedSystemMemorySize64; }
        }

        public long PagedMemorySize64
        {
            get { return _underlyingObject.PagedMemorySize64; }
        }

        public long PagedSystemMemorySize64
        {
            get { return _underlyingObject.PagedSystemMemorySize64; }
        }

        public long PeakPagedMemorySize64
        {
            get { return _underlyingObject.PeakPagedMemorySize64; }
        }

        public long PeakVirtualMemorySize64
        {
            get { return _underlyingObject.PeakVirtualMemorySize64; }
        }

        public long PeakWorkingSet64
        {
            get { return _underlyingObject.PeakWorkingSet64; }
        }

        public bool PriorityBoostEnabled
        {
            get { return _underlyingObject.PriorityBoostEnabled; }
            set { _underlyingObject.PriorityBoostEnabled = value; }
        }

        public ProcessPriorityClass PriorityClass
        {
            get { return _underlyingObject.PriorityClass; }
            set { _underlyingObject.PriorityClass = value; }
        }

        public TimeSpan PrivilegedProcessorTime
        {
            get { return _underlyingObject.PrivilegedProcessorTime; }
        }

        public string ProcessName
        {
            get { return _underlyingObject.ProcessName; }
        }

        public IntPtr ProcessorAffinity
        {
            get { return _underlyingObject.ProcessorAffinity; }
            set { _underlyingObject.ProcessorAffinity = value; }
        }

        public bool Responding
        {
            get { return _underlyingObject.Responding; }
        }

        public int SessionId
        {
            get { return _underlyingObject.SessionId; }
        }

        public StreamReader StandardError
        {
            get { return _underlyingObject.StandardError; }
        }

        public StreamWriter StandardInput
        {
            get { return _underlyingObject.StandardInput; }
        }

        public StreamReader StandardOutput
        {
            get { return _underlyingObject.StandardOutput; }
        }

        public DateTime StartTime
        {
            get { return _underlyingObject.StartTime; }
        }

        public ISynchronizeInvoke SynchronizingObject
        {
            get { return _underlyingObject.SynchronizingObject; }
            set { _underlyingObject.SynchronizingObject = value; }
        }

        public ProcessThreadCollection Threads
        {
            get { return _underlyingObject.Threads; }
        }

        public TimeSpan TotalProcessorTime
        {
            get { return _underlyingObject.TotalProcessorTime; }
        }

        public TimeSpan UserProcessorTime
        {
            get { return _underlyingObject.UserProcessorTime; }
        }

        public long VirtualMemorySize64
        {
            get { return _underlyingObject.VirtualMemorySize64; }
        }

        public long WorkingSet64
        {
            get { return _underlyingObject.WorkingSet64; }
        }

        /// <summary>
        /// Formats the process's name as a string, combined with the parent component type, if applicable.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="P:System.Diagnostics.Process.ProcessName"/>, combined with the base component's <see cref="M:System.Object.ToString"/> return value.
        /// 
        /// </returns>
        /// <exception cref="T:System.PlatformNotSupportedException"><see cref="M:System.Diagnostics.Process.ToString"/> is not supported on Windows 98.
        ///                 </exception><filterpriority>2</filterpriority>
        public override string ToString()
        {
            return _underlyingObject.ToString();
        }

        public void Dispose()
        {
            _underlyingObject.Dispose();
        }

        public ISite Site
        {
            get { return _underlyingObject.Site; }
            set { _underlyingObject.Site = value; }
        }

        public event EventHandler Disposed
        {
            add { _underlyingObject.Disposed += value; }
            remove { _underlyingObject.Disposed -= value; }
        }


    }
}