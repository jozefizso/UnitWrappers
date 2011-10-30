using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;

namespace UnitWrappers.System.Threading
{
    /// <summary>
    /// Wraps instance of <see cref="WaitHandle"/>
    /// </summary>
    public interface IWaitHandle:IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        WaitHandle UnderlyingObject { get; }

        void Close();
        bool WaitOne();
    }
}