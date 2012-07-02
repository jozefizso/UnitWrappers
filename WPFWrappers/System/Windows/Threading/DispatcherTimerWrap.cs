using System;
using System.Windows.Threading;

namespace UnitWrappers.System.Windows.Threading
{
    /// <summary> 
    ///     A timer that is integrated into the Dispatcher queues, and will
    ///     be processed after a given amount of time at a specified priority.
    /// </summary>
    public class DispatcherTimerWrap : IDispatcherTimer,IWrap<DispatcherTimer>
    {
        private DispatcherTimer _underlyingObject;
         DispatcherTimer IWrap<DispatcherTimer>.UnderlyingObject
        {
            get { return _underlyingObject; }
     
        }

        /// <summary> 
        ///     Creates a timer that uses the current thread's Dispatcher to 
        ///     process the timer event at background priority.
        /// </summary> 
        public DispatcherTimerWrap()
        {
            _underlyingObject = new DispatcherTimer();
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
            _underlyingObject = new DispatcherTimer(priority);
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
            _underlyingObject = new DispatcherTimer(priority, ((IWrap<Dispatcher>)dispatcher).UnderlyingObject);
        }

        public DispatcherTimerWrap(DispatcherPriority priority, Dispatcher dispatcher)
        {
            _underlyingObject = new DispatcherTimer(priority, dispatcher);
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
            _underlyingObject = new DispatcherTimer(interval, priority, callback, ((IWrap<Dispatcher>)dispatcher).UnderlyingObject);
        }

        public DispatcherTimerWrap(TimeSpan interval, DispatcherPriority priority, EventHandler callback,
                           Dispatcher dispatcher)
        {
            _underlyingObject = new DispatcherTimer(interval, priority, callback, dispatcher);
        }

        /// <inheritdoc />
        public IDispatcherService Dispatcher
        {
            get { return new DispatcherWrap(_underlyingObject.Dispatcher); }
        }

        /// <inheritdoc />
        public bool IsEnabled
        {
            get { return _underlyingObject.IsEnabled; }

            set { _underlyingObject.IsEnabled = value; }
        }

        /// <inheritdoc />
        public TimeSpan Interval
        {
            get { return _underlyingObject.Interval; }

            set { _underlyingObject.Interval = value; }
        }

        /// <inheritdoc />
        public void Start()
        {
            _underlyingObject.Start();
        }

        /// <inheritdoc />
        public void Stop()
        {
            _underlyingObject.Stop();
        }

        /// <inheritdoc />
        public event EventHandler Tick
        {
            add { _underlyingObject.Tick += value; }
            remove { _underlyingObject.Tick -= value; }
        }

        /// <inheritdoc />
        public object Tag
        {
            get { return _underlyingObject.Tag; }

            set { _underlyingObject.Tag = value; }
        }
    }







}


