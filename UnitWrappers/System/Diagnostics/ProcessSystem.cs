using System.Diagnostics;

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
    }
}