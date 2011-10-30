using System.Threading;

namespace UnitWrappers.System.Threading
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAutoResetEvent:IWaitHandle
    {
        /// <summary>
        /// 
        /// </summary>
        new AutoResetEvent UnderlyingObject { get; }
    }
}