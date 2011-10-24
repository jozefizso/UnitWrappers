using System.Diagnostics;

namespace UnitWrappers.System.Diagnostics
{
    /// <summary>
    /// Wraps static members of <see cref="Process"/>.
    /// </summary>
    public interface IProcessSystem
    {
        IProcess Start(string fileName);
    }
}