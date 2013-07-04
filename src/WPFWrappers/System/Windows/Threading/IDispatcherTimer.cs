using System;
using System.Windows.Threading;

namespace UnitWrappers.System.Windows.Threading
{
    public interface IDispatcherTimer
    {
     

        /// <summary>
        ///     Gets the dispatcher this timer is associated with. 
        /// </summary>
        IDispatcherService Dispatcher { get; }

        /// <summary>
        ///     Gets or sets whether the timer is running. 
        /// </summary> 
        bool IsEnabled { get; set; }

        /// <summary> 
        ///     Gets or sets the time between timer ticks.
        /// </summary> 
        TimeSpan Interval { get; set; }

        /// <summary> 
        ///     Any data that the caller wants to pass along with the timer.
        /// </summary> 
        object Tag { get; set; }

        /// <summary> 
        ///     Starts the timer. 
        /// </summary>
        void Start();

        /// <summary> 
        ///     Stops the timer.
        /// </summary> 
        void Stop();

        /// <summary> 
        ///     Occurs when the specified timer interval has elapsed and the
        ///     timer is enabled. 
        /// </summary>
        event EventHandler Tick;
    }
}