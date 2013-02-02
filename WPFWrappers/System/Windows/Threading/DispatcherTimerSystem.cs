using System;
using System.Windows.Threading;

namespace UnitWrappers.System.Windows.Threading
{
    public class DispatcherTimerSystem : IDispatcherTimerSystem
    {
        /// <inheritdoc />
        public IDispatcherTimer CreateDispatcherTimer()
        {
            return new DispatcherTimerWrap();
        }

        /// <inheritdoc />
        public IDispatcherTimer DispatcherTimerWrap(DispatcherPriority priority)
        {
            return new DispatcherTimerWrap(priority);
        }

        /// <inheritdoc />
        public IDispatcherTimer DispatcherTimerWrap(DispatcherPriority priority, IDispatcherService dispatcher)
        {
            return new DispatcherTimerWrap(priority,dispatcher);
        }

        /// <inheritdoc />
        public IDispatcherTimer DispatcherTimerWrap(TimeSpan interval, DispatcherPriority priority, EventHandler callback, IDispatcherService dispatcher)
        {
            return new DispatcherTimerWrap(interval,priority,callback,dispatcher);
        }
    }
}