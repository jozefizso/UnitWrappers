using System.Diagnostics;
using System.Linq;
using System.Security;

namespace UnitWrappers.System.Diagnostics
{
    /// <summary>
    /// Wraps static members of <see cref="Process"/>
    /// </summary>
    public class ProcessSystem : IProcessSystem
    {
        /// <inheritdoc />
        public IProcess Start(string fileName)
        {
            return new ProcessWrap(Process.Start(fileName));
        }
        /// <inheritdoc />
        public IProcess Start(IProcessStartInfo startInfo)
        {
            return new ProcessWrap(Process.Start(startInfo.UnderlyingObject));
        }
        /// <inheritdoc />
        public IProcess Start(string fileName, string arguments)
        {
            return new ProcessWrap(Process.Start(fileName, arguments));
        }
        /// <inheritdoc />
        public IProcess Start(string fileName, string userName, SecureString password, string domain)
        {
            return new ProcessWrap(Process.Start(fileName, userName, password, domain));
        }
        /// <inheritdoc />
        public IProcess Start(string fileName, string arguments, string userName, SecureString password, string domain)
        {
            return new ProcessWrap(Process.Start(fileName, arguments, userName, password, domain));
        }
        /// <inheritdoc />
        public IProcess GetCurrentProcess()
        {
            return new ProcessWrap(Process.GetCurrentProcess());
        }
        /// <inheritdoc />
        public IProcess GetProcessById(int processId)
        {
            return new ProcessWrap(Process.GetProcessById(processId));
        }
        /// <inheritdoc />
        public IProcess GetProcessById(int processId, string machineName)
        {
            return new ProcessWrap(Process.GetProcessById(processId, machineName));
        }
        /// <inheritdoc />
        public IProcess[] GetProcesses()
        {
            return Process.GetProcesses().Select(x => new ProcessWrap(x)).ToArray();
        }
        /// <inheritdoc />
        public IProcess[] GetProcesses(string machineName)
        {
            return Process.GetProcesses(machineName).Select(x => new ProcessWrap(x)).ToArray();
        }
        /// <inheritdoc />
        public IProcess[] GetProcessesByName(string processName)
        {
            return Process.GetProcessesByName(processName).Select(x => new ProcessWrap(x)).ToArray();
        }
        /// <inheritdoc />
        public IProcess[] GetProcessesByName(string processName, string machineName)
        {
            return Process.GetProcessesByName(processName, machineName).Select(x => new ProcessWrap(x)).ToArray();
        }
        /// <inheritdoc />
        public void EnterDebugMode()
        {
            Process.EnterDebugMode();
        }
        /// <inheritdoc />
        public void LeaveDebugMode()
        {
            Process.LeaveDebugMode();
        }
    }
}