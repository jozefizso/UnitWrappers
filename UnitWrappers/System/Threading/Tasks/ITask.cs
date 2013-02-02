using System;

namespace UnitWrappers.System.Threading.Tasks
{
    public interface ITask: IAsyncResult, IDisposable
    {
        void Start();
        void Wait();
    }
}
