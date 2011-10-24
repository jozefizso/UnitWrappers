using System.Diagnostics;

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
    }
}