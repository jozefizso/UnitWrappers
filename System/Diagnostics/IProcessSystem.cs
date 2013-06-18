using System.Diagnostics;
using System.Security;

namespace UnitWrappers.System.Diagnostics
{
    /// <summary>
    /// Wraps static members of <see cref="Process"/>.
    /// </summary>
    public interface IProcessSystem:ILocalProcessSystem
    {
    
        IProcess GetProcessById(int processId, string machineName);
        
        IProcess[] GetProcesses(string machineName);

        /// <summary>
        /// Creates an array of new <see cref="IProcess"/> components and associates them with all the process resources on a remote computer that share the specified process name.
        /// </summary>
        /// <param name="processName">The friendly name of the process. </param>
        /// <param name="machineName">The name of a computer on the network. </param>
        /// <returns>An array of type <see cref="IProcess"/> that represents the process resources running the specified application or file.</returns>
        IProcess[] GetProcessesByName(string processName, string machineName);

    }
}