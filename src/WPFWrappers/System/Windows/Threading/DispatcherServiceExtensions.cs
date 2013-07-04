using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;

namespace UnitWrappers.System.Windows.Threading
{
    public static class DispatcherServiceExtensions
    {
        /// <summary>
        /// Executes the specified delegate asynchronously with normal priority on the thread that the specified Dispatcher was created on.
        /// </summary>
        /// <param name="action">The delegate to execute, which takes no arguments and does not return a value.</param>
        /// <returns>An IAsyncResult object that represents the result of the BeginInvoke operation.</returns>
        ///<exception cref="ArgumentNullException">action is Nothing</exception>
        public static DispatcherOperation BeginInvoke(this IDispatcherService dispatcher, Action action)
        {
            return dispatcher.BeginInvoke(action, DispatcherPriority.Normal);
        }

        public static DispatcherOperation BeginInvoke(
    this IDispatcherService dispatcher,
    Action action,
    DispatcherPriority priority
)
        {
            return dispatcher.BeginInvoke(action, priority);
        }

        /// <summary>
        /// Executes the specified delegate synchronously with normal priority on the thread that the specified Dispatcher was created
        /// </summary>
        /// <param name="dispatcher"></param>
        /// <param name="action"></param>
        public static void Invoke(
    this IDispatcherService dispatcher,
    Action action
)
        {
            dispatcher.Invoke(action, DispatcherPriority.Normal);
        }

        public static void Invoke(
    this IDispatcherService dispatcher,
    Action action,
    DispatcherPriority priority
)
        {
            dispatcher.Invoke(action, priority);
        }

        /// <summary>
        /// Executes the specified delegate synchronously on the thread that the specified Dispatcher was created on, and stops execution after the specified time-out period. 
        /// </summary>
        /// <param name="dispatcher"></param>
        /// <param name="action"></param>
        /// <param name="timeout"></param>
        public static void Invoke(
    this IDispatcherService dispatcher,
    Action action,
    TimeSpan timeout
)
        {
            dispatcher.Invoke(action, DispatcherPriority.Normal, timeout);
        }

        public static void Invoke(
    this IDispatcherService dispatcher,
    Action action,
    TimeSpan timeout,
    DispatcherPriority priority
)
        {
            dispatcher.Invoke(action, priority, timeout);
        }
    }
}
