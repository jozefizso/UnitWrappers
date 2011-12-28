using System;
using System.Security;
using System.ComponentModel;
using System.Windows.Threading;
using UnitWrappers.System.Threading;

namespace UnitWrappers.System.Windows.Threading
{

    public class DispatcherWrap : IDispatcher
    {

        public Dispatcher UnderlyingObject { get; set; }

        public DispatcherWrap(Dispatcher dispatcher)
        {
            UnderlyingObject = dispatcher;
        }

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool CheckAccess()
        {
            return UnderlyingObject.CheckAccess();
        }

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void VerifyAccess()
        {
            UnderlyingObject.VerifyAccess();
        }

        /// <inheritdoc />
        public bool HasShutdownStarted
        {
            get { return UnderlyingObject.HasShutdownStarted; }
        }

        /// <inheritdoc />
        public bool HasShutdownFinished
        {
            get
            {
                return UnderlyingObject.HasShutdownFinished;
            }
        }

        /// <inheritdoc />
        public event EventHandler ShutdownStarted
        {
            add { UnderlyingObject.ShutdownStarted += value; }
            remove { UnderlyingObject.ShutdownStarted -= value; }
        }

        /// <inheritdoc /> 
        public event EventHandler ShutdownFinished
        {
            add { UnderlyingObject.ShutdownFinished += value; }
            remove { UnderlyingObject.ShutdownFinished -= value; }
        }

        /// <inheritdoc />
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public DispatcherOperation BeginInvoke(DispatcherPriority priority, Delegate method)
        {
            return UnderlyingObject.BeginInvoke(priority, method);
        }

        /// <inheritdoc />
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public DispatcherOperation BeginInvoke(DispatcherPriority priority, Delegate method, object arg)
        {
            return UnderlyingObject.BeginInvoke(priority, method, arg);
        }

        /// <inheritdoc />
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public DispatcherOperation BeginInvoke(DispatcherPriority priority, Delegate method, object arg, params object[] args)
        {
            return UnderlyingObject.BeginInvoke(priority, method, arg, args);
        }

        /// <inheritdoc />
        public DispatcherOperation BeginInvoke(Delegate method, params object[] args)
        {
            return UnderlyingObject.BeginInvoke(method, args);
        }

        /// <inheritdoc />
        public DispatcherOperation BeginInvoke(Delegate method, DispatcherPriority priority, params object[] args)
        {
            return UnderlyingObject.BeginInvoke(method, priority, args);
        }

        /// <inheritdoc />
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public object Invoke(DispatcherPriority priority, Delegate method)
        {
            return UnderlyingObject.Invoke(priority, method);
        }

        /// <inheritdoc />
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public object Invoke(DispatcherPriority priority, Delegate method, object arg)
        {
            return UnderlyingObject.Invoke(priority, method, arg);
        }

        /// <inheritdoc />
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public object Invoke(DispatcherPriority priority, Delegate method, object arg, params object[] args)
        {
            return UnderlyingObject.Invoke(priority, method, method, arg, args);
        }

        /// <inheritdoc />
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public object Invoke(DispatcherPriority priority, TimeSpan timeout, Delegate method)
        {
            return UnderlyingObject.Invoke(priority, timeout, method);
        }

        /// <inheritdoc />
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public object Invoke(DispatcherPriority priority, TimeSpan timeout, Delegate method, object arg)
        {
            return UnderlyingObject.Invoke(priority, timeout, method, arg);
        }

        /// <inheritdoc />
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public object Invoke(DispatcherPriority priority, TimeSpan timeout, Delegate method, object arg, params object[] args)
        {
            return UnderlyingObject.Invoke(priority, timeout, method, arg, args);
        }

        /// <inheritdoc />
        public object Invoke(Delegate method, params object[] args)
        {
            return UnderlyingObject.Invoke(method, args);
        }

        /// <inheritdoc />
        public object Invoke(Delegate method, DispatcherPriority priority, params object[] args)
        {
            return UnderlyingObject.Invoke(method, priority, args);
        }

        /// <inheritdoc />
        public object Invoke(Delegate method, TimeSpan timeout, params object[] args)
        {
            return UnderlyingObject.Invoke(method, timeout, args);
        }

        /// <inheritdoc />
        public object Invoke(Delegate method, TimeSpan timeout, DispatcherPriority priority, params object[] args)
        {
            return UnderlyingObject.Invoke(method, timeout, priority, args);
        }

        /// <inheritdoc />
        public IThread Thread
        {
            get
            {
                return new ThreadWrap(UnderlyingObject.Thread);
            }
        }

        /// <inheritdoc />
        [SecurityCritical]
        public void BeginInvokeShutdown(DispatcherPriority priority)
        {
            UnderlyingObject.BeginInvokeShutdown(priority);
        }

        /// <inheritdoc />
        [SecurityCritical]
        public void InvokeShutdown()
        {
            UnderlyingObject.InvokeShutdown();
        }

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public DispatcherHooks Hooks
        {
            get
            {
                return UnderlyingObject.Hooks;
            }
        }

        /// <inheritdoc />
        public event DispatcherUnhandledExceptionFilterEventHandler UnhandledExceptionFilter
        {
            add { UnderlyingObject.UnhandledExceptionFilter += value; }
            remove { UnderlyingObject.UnhandledExceptionFilter -= value; }
        }

        /// <inheritdoc />
        public event DispatcherUnhandledExceptionEventHandler UnhandledException
        {
            add { UnderlyingObject.UnhandledException += value; }
            remove { UnderlyingObject.UnhandledException -= value; }
        }
    }
}
