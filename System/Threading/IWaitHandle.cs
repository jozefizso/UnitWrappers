using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;

namespace UnitWrappers.System.Threading
{
    /// <summary>
    /// Encapsulates operating system–specific objects that wait for exclusive access to shared resources.
    /// 
    /// </summary>
    public interface IWaitHandle:IDisposable
    {
        void Close();
        bool WaitOne();
    }
}