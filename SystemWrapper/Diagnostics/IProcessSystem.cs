using System.Diagnostics;

namespace SystemWrapper.Diagnostics
{
    /// <summary>
    /// Wraps static memebers of <see cref="Process"/>.
    /// </summary>
    public interface IProcessSystem
    {
        IProcess Start(string fileName);
    }
}