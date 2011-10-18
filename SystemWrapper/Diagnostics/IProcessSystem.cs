using System.Diagnostics;

namespace SystemWrapper.Diagnostics
{
    /// <summary>
    /// Wraps static members of <see cref="Process"/>.
    /// </summary>
    public interface IProcessSystem
    {
        IProcess Start(string fileName);
    }
}