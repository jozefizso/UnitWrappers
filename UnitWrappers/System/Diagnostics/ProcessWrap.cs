using System;
using System.Diagnostics;

namespace UnitWrappers.System.Diagnostics
{
    ///<summary>
    /// Wrapper for <see cref="T:System.Diagnostics.Process"/> class.
    ///</summary>
    public class ProcessWrap : IProcess
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
    }
}