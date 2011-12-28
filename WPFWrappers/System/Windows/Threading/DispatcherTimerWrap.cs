using System;
using System.Windows.Threading;

namespace UnitWrappers.System.Windows.Threading
{
    /// <summary> 
    ///     A timer that is integrated into the Dispatcher queues, and will
    ///     be processed after a given amount of time at a specified priority.
    /// </summary>
    public class DispatcherTimerWrap : IDispatcherTimer
    {

        public DispatcherTimer UnderlyingObject { get; private set; }

        /// <summary> 
        ///     Creates a timer that uses the current thread's Dispatcher to 
        ///     process the timer event at background priority.
        /// </summary> 
        public DispatcherTimerWrap()
        {
            UnderlyingObject = new DispatcherTimer();
        }

        /// <summary>
        ///     Creates a timer that uses the current thread's Dispatcher to 
        ///     process the timer event at the specified priority. 
        /// </summary>
        /// <param name="priority"> 
        ///     The priority to process the timer at.
        /// </param>
        public DispatcherTimerWrap(DispatcherPriority priority)
        {
            UnderlyingObject = new DispatcherTimer(priority);
        }

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
        public DispatcherTimerWrap(DispatcherPriority priority, IDispatcherService dispatcher)
        {
            UnderlyingObject = new DispatcherTimer(priority, dispatcher.UnderlyingObject);
        }

        public DispatcherTimerWrap(DispatcherPriority priority, Dispatcher dispatcher)
        {
            UnderlyingObject = new DispatcherTimer(priority, dispatcher);
        }

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
        public DispatcherTimerWrap(TimeSpan interval, DispatcherPriority priority, EventHandler callback,
                                   IDispatcherService dispatcher)
        {
            UnderlyingObject = new DispatcherTimer(interval, priority, callback, dispatcher.UnderlyingObject);
        }

        public DispatcherTimerWrap(TimeSpan interval, DispatcherPriority priority, EventHandler callback,
                           Dispatcher dispatcher)
        {
            UnderlyingObject = new DispatcherTimer(interval, priority, callback, dispatcher);
        }

        /// <inheritdoc />
        public IDispatcherService Dispatcher
        {
            get { return new DispatcherWrap(UnderlyingObject.Dispatcher); }
        }

        /// <inheritdoc />
        public bool IsEnabled
        {
            get { return UnderlyingObject.IsEnabled; }

            set { UnderlyingObject.IsEnabled = value; }
        }

        /// <inheritdoc />
        public TimeSpan Interval
        {
            get { return UnderlyingObject.Interval; }

            set { UnderlyingObject.Interval = value; }
        }

        /// <inheritdoc />
        public void Start()
        {
            UnderlyingObject.Start();
        }

        /// <inheritdoc />
        public void Stop()
        {
            UnderlyingObject.Stop();
        }

        /// <inheritdoc />
        public event EventHandler Tick
        {
            add { UnderlyingObject.Tick += value; }
            remove { UnderlyingObject.Tick -= value; }
        }

        /// <inheritdoc />
        public object Tag
        {
            get { return UnderlyingObject.Tag; }

            set { UnderlyingObject.Tag = value; }
        }
    }







}


