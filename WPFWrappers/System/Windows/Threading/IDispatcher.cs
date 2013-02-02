using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Windows.Threading;
using UnitWrappers.System.Threading;

namespace UnitWrappers.System.Windows.Threading
{
    /// <summary>
    /// Provides services for managing the queue of work items for a thread.
    /// </summary>
    public interface IDispatcher:IDispatcherService
    {
        /// <summary> 
        /// Gets the thread this <see cref="IDispatcher"/> is associated with.
        /// </summary>
        IThread Thread { get; }

        /// <summary>
        ///     Begins the process of shutting down the dispatcher. 
        /// </summary>
        /// <remarks>
        ///     This API demand unrestricted UI Permission
        /// </remarks> 
        ///<SecurityNote>
        /// Critical - it calls critical methods (ShutdownCallback). 
        /// PublicOK - it demands unrestricted UI permission. 
        ///</SecurityNote>
        [SecurityCritical]
        void BeginInvokeShutdown(DispatcherPriority priority);

        /// <summary> 
        ///     Begins the process of shutting down the dispatcher.
        /// </summary>
        /// <remarks>
        ///     Callers must have UIPermission(PermissionState.Unrestricted) to call this API. 
        /// </remarks>
        ///<SecurityNote> 
        /// Critical - it calls critical methods (ShutdownCallback). 
        /// PublicOK - it demands unrestricted UI permission
        ///</SecurityNote> 
        [SecurityCritical]
        void InvokeShutdown();

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        DispatcherHooks Hooks { get; }

        /// <summary>
        ///     Occurs when an untrapped thread exception is thrown. 
        /// </summary>
        /// <remarks> 
        ///     Raised when an exception was caught that was raised during 
        ///     execution of a delegate via Invoke or BeginInvoke.
        ///     <P/> 
        ///     A handler can mark the exception as handled which will prevent
        ///     the internal "final" exception handler from being called.
        ///     <P/>
        ///     Listeners to this event must be written with care to avoid 
        ///     creating secondary exceptions and to catch any that occur.
        ///     It is recommended to avoid allocating memory or doing any 
        ///     heavylifting if possible. 
        /// </remarks>
        event DispatcherUnhandledExceptionEventHandler UnhandledException;
    }
}
