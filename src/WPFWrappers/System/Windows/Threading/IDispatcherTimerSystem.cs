using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;

namespace UnitWrappers.System.Windows.Threading
{
    public interface IDispatcherTimerSystem
    {

        /// <summary> 
        ///     Creates a timer that uses the current thread's Dispatcher to 
        ///     process the timer event at background priority.
        /// </summary> 
        IDispatcherTimer CreateDispatcherTimer();

        /// <summary>
        ///     Creates a timer that uses the current thread's Dispatcher to 
        ///     process the timer event at the specified priority. 
        /// </summary>
        /// <param name="priority"> 
        ///     The priority to process the timer at.
        /// </param>
        IDispatcherTimer DispatcherTimerWrap(DispatcherPriority priority);

        /// <summary>
        ///     Creates a timer that uses the specified Dispatcher to 
        ///     process the timer event at the specified priority.
        /// </summary>
        /// <param name="priority">
        ///     The priority to process the timer at. 
        /// </param>
        /// <param name="dispatcher"> 
        ///     The dispatcher to use to process the timer. 
        /// </param>
        IDispatcherTimer DispatcherTimerWrap(DispatcherPriority priority, IDispatcherService dispatcher);

        /// <summary>
        ///     Creates a timer that is bound to the specified dispatcher and
        ///     will be processed at the specified priority, after the
        ///     specified timeout. 
        /// </summary>
        /// <param name="interval"> 
        ///     The interval to tick the timer after. 
        /// </param>
        /// <param name="priority"> 
        ///     The priority to process the timer at.
        /// </param>
        /// <param name="callback">
        ///     The callback to call when the timer ticks. 
        /// </param>
        /// <param name="dispatcher"> 
        ///     The dispatcher to use to process the timer. 
        /// </param>
        IDispatcherTimer DispatcherTimerWrap(TimeSpan interval, DispatcherPriority priority, EventHandler callback,
                                             IDispatcherService dispatcher);
    }
}