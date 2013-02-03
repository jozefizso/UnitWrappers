using System;
using System.Security;
using System.ComponentModel;
using System.Windows.Threading;
using UnitWrappers.System.Threading;

namespace UnitWrappers.System.Windows.Threading
{

    public class DispatcherWrap : IDispatcher, IWrap<Dispatcher>
    {
        private Dispatcher _underlyingObject;

        public static implicit operator DispatcherWrap(Dispatcher o)
        {
            return new DispatcherWrap(o);
        }

        public static implicit operator Dispatcher(DispatcherWrap o)
        {
            return o._underlyingObject;
        }

        Dispatcher IWrap<Dispatcher>.UnderlyingObject { get { return _underlyingObject;  } }

        public DispatcherWrap(Dispatcher dispatcher)
        {
            _underlyingObject = dispatcher;
        }

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool CheckAccess()
        {
            return _underlyingObject.CheckAccess();
        }

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void VerifyAccess()
        {
            _underlyingObject.VerifyAccess();
        }

        /// <inheritdoc />
        public bool HasShutdownStarted
        {
            get { return _underlyingObject.HasShutdownStarted; }
        }

        /// <inheritdoc />
        public bool HasShutdownFinished
        {
            get
            {
                return _underlyingObject.HasShutdownFinished;
            }
        }

        /// <inheritdoc />
        public event EventHandler ShutdownStarted
        {
            add { _underlyingObject.ShutdownStarted += value; }
            remove { _underlyingObject.ShutdownStarted -= value; }
        }

        /// <inheritdoc /> 
        public event EventHandler ShutdownFinished
        {
            add { _underlyingObject.ShutdownFinished += value; }
            remove { _underlyingObject.ShutdownFinished -= value; }
        }

        /// <inheritdoc />
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public DispatcherOperation BeginInvoke(DispatcherPriority priority, Delegate method)
        {
            return _underlyingObject.BeginInvoke(priority, method);
        }

        /// <inheritdoc />
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public DispatcherOperation BeginInvoke(DispatcherPriority priority, Delegate method, object arg)
        {
            return _underlyingObject.BeginInvoke(priority, method, arg);
        }

        /// <inheritdoc />
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public DispatcherOperation BeginInvoke(DispatcherPriority priority, Delegate method, object arg, params object[] args)
        {
            return _underlyingObject.BeginInvoke(priority, method, arg, args);
        }

        /// <inheritdoc />
        public DispatcherOperation BeginInvoke(Delegate method, params object[] args)
        {
            return _underlyingObject.BeginInvoke(method, args);
        }

        /// <inheritdoc />
        public DispatcherOperation BeginInvoke(Delegate method, DispatcherPriority priority, params object[] args)
        {
            return _underlyingObject.BeginInvoke(method, priority, args);
        }

        /// <inheritdoc />
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public object Invoke(DispatcherPriority priority, Delegate method)
        {
            return _underlyingObject.Invoke(priority, method);
        }

        /// <inheritdoc />
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public object Invoke(DispatcherPriority priority, Delegate method, object arg)
        {
            return _underlyingObject.Invoke(priority, method, arg);
        }

        /// <inheritdoc />
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public object Invoke(DispatcherPriority priority, Delegate method, object arg, params object[] args)
        {
            return _underlyingObject.Invoke(priority, method, method, arg, args);
        }

        /// <inheritdoc />
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public object Invoke(DispatcherPriority priority, TimeSpan timeout, Delegate method)
        {
            return _underlyingObject.Invoke(priority, timeout, method);
        }

        /// <inheritdoc />
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public object Invoke(DispatcherPriority priority, TimeSpan timeout, Delegate method, object arg)
        {
            return _underlyingObject.Invoke(priority, timeout, method, arg);
        }

        /// <inheritdoc />
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public object Invoke(DispatcherPriority priority, TimeSpan timeout, Delegate method, object arg, params object[] args)
        {
            return _underlyingObject.Invoke(priority, timeout, method, arg, args);
        }

        /// <inheritdoc />
        public object Invoke(Delegate method, params object[] args)
        {
            return _underlyingObject.Invoke(method, args);
        }

        /// <inheritdoc />
        public object Invoke(Delegate method, DispatcherPriority priority, params object[] args)
        {
            return _underlyingObject.Invoke(method, priority, args);
        }

        /// <inheritdoc />
        public object Invoke(Delegate method, TimeSpan timeout, params object[] args)
        {
            return _underlyingObject.Invoke(method, timeout, args);
        }

        /// <inheritdoc />
        public object Invoke(Delegate method, TimeSpan timeout, DispatcherPriority priority, params object[] args)
        {
            return _underlyingObject.Invoke(method, timeout, priority, args);
        }

        /// <inheritdoc />
        public IThread Thread
        {
            get
            {
                return new ThreadWrap(_underlyingObject.Thread);
            }
        }

        /// <inheritdoc />
        [SecurityCritical]
        public void BeginInvokeShutdown(DispatcherPriority priority)
        {
            _underlyingObject.BeginInvokeShutdown(priority);
        }

        /// <inheritdoc />
        [SecurityCritical]
        public void InvokeShutdown()
        {
            _underlyingObject.InvokeShutdown();
        }

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public DispatcherHooks Hooks
        {
            get
            {
                return _underlyingObject.Hooks;
            }
        }

        /// <inheritdoc />
        public event DispatcherUnhandledExceptionFilterEventHandler UnhandledExceptionFilter
        {
            add { _underlyingObject.UnhandledExceptionFilter += value; }
            remove { _underlyingObject.UnhandledExceptionFilter -= value; }
        }

        /// <inheritdoc />
        public event DispatcherUnhandledExceptionEventHandler UnhandledException
        {
            add { _underlyingObject.UnhandledException += value; }
            remove { _underlyingObject.UnhandledException -= value; }
        }
    }
}
