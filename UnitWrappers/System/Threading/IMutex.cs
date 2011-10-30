using System.ComponentModel;
using System.Threading;

namespace UnitWrappers.System.Threading
{
    public interface IMutex : IWaitHandle
    {
        /// <summary>
        /// 
        /// </summary>
        new Mutex UnderlyingObject { get; }
    }
}