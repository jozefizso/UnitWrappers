using System.Diagnostics;
using System.Security;

namespace UnitWrappers.System.Diagnostics
{
    /// <summary>
    /// Wraps static members of <see cref="Process"/>.
    /// </summary>
    public interface IProcessSystem
    {
        /// <summary>
        /// Starts a process resource by specifying the name of a document or application file and associates the resource with a new <see cref="IProcess"/> component.
        /// </summary>
        /// <param name="fileName">The name of a document or application file to run in the process. </param>
        /// <returns></returns>
        IProcess Start(string fileName);

        /// <summary>
        /// Starts the process resource that is specified by the parameter containing process start information (for example, the file name of the process to start) and associates the resource with a new <see cref="IProcess"/> component.
        /// </summary>
        /// <param name="startInfo">The <see cref="IProcessStartInfo"/> that contains the information that is used to start the process, including the file name and any command-line arguments</param>
        /// <returns>A new <see cref="IProcess"/> component that is associated with the process resource, or null if no process resource is started (for example, if an existing process is reused).</returns>
        IProcess Start(IProcessStartInfo startInfo);

        /// <summary>
        /// Starts a process resource by specifying the name of an application and a set of command-line arguments, and associates the resource with a new <see cref="IProcess"/> component.
        /// </summary>
        /// <param name="fileName">The name of an application file to run in the process. </param>
        /// <param name="arguments">Command-line arguments to pass when starting the process. </param>
        /// <returns>A new <see cref="IProcess"/> component that is associated with the process, or null, if no process resource is started (for example, if an existing process is reused).</returns>
        IProcess Start(string fileName, string arguments);

        IProcess Start(string fileName, string userName, SecureString password, string domain);

        IProcess Start(string fileName, string arguments, string userName, SecureString password, string domain);

        IProcess GetCurrentProcess();
        IProcess GetProcessById(int processId);
        IProcess GetProcessById(int processId, string machineName);
        IProcess[] GetProcesses();
        IProcess[] GetProcesses(string machineName);
        IProcess[] GetProcessesByName(string processName);
        IProcess[] GetProcessesByName(string processName, string machineName);

        /// <summary>
        /// Puts a Process component in state to interact with operating system processes that run in a special mode by enabling the native property SeDebugPrivilege on the current thread.
        /// </summary>
        /// <remarks>
        /// Some operating system processes run in a special mode. Attempting to read properties of or attach to these processes is not possible unless you have called EnterDebugMode on the component. Call <see cref="IProcessSystem.LeaveDebugMode"/> when you no longer need access to these processes that run in special mode.
        /// </remarks>
        void EnterDebugMode();

        /// <summary>
        /// Takes a Process component out of the state that lets it interact with operating system processes that run in a special mode.
        /// </summary>
        ///<remarks>
        /// Some operating system processes run in a special mode. Attempting to read properties of or attach to these processes is not possible unless you have called <see cref="EnterDebugMode"/> on the component. Call LeaveDebugMode when you no longer need access to these processes that run in special mode.
        /// </remarks>
        void LeaveDebugMode();




    }
}