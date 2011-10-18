using System.Diagnostics;

namespace SystemWrapper.Diagnostics
{
    public class ProcessSystem : IProcessSystem
    {
        public IProcess Start(string fileName)
        {
            return new ProcessWrap(Process.Start(fileName));
        }
    }
}