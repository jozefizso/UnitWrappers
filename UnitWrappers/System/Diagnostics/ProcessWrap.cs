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
            ProcessInstance = process;
        }

		/// <summary>
		/// Initializes a new instance of the <see cref="T:UnitWrappers.System.Diagnostics.ProcessWrap"/> class.
		/// </summary>
		public ProcessWrap()
		{
            ProcessInstance = new Process();
		}
		
		public int ExitCode
		{
			get { return ProcessInstance.ExitCode; }
		}

		public void Close()
		{
			ProcessInstance.Close();
		}

		public Process ProcessInstance { get; private set; }

		public bool Start()
		{
			return ProcessInstance.Start();
		}

		public IProcessStartInfo StartInfo
		{
			get { return startInfo ?? (startInfo = new ProcessStartInfoWrap(ProcessInstance.StartInfo)); }
			set { startInfo = value; }
		}

		public void WaitForExit()
		{
			ProcessInstance.WaitForExit();
		}

		public bool WaitForExit(int milliseconds)
		{
			return ProcessInstance.WaitForExit(milliseconds);
		}

		public bool WaitForInputIdle()
		{
			return ProcessInstance.WaitForInputIdle();
		}
	}
}