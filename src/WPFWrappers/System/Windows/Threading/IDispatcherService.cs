using System;
using System.ComponentModel;
using System.Windows.Threading;

namespace UnitWrappers.System.Windows.Threading
{
    /// <summary> 
    ///  Provides services to queue items for a thread. 
    /// </summary>
    public interface IDispatcherService
    {
 

        /// <summary>
        ///     Checks that the calling thread has access to this object. 
        /// </summary>
        /// <remarks>
        ///     Only the dispatcher thread may access DispatcherObjects.
        ///     <p/> 
        ///     This method is public so that any thread can probe to
        ///     see if it has access to the DispatcherObject. 
        /// </remarks> 
        /// <returns>
        ///     True if the calling thread has access to this object. 
        /// </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        bool CheckAccess();

        /// <summary>
        ///     Verifies that the calling thread has access to this object. 
        /// </summary>
        /// <remarks>
        ///     Only the dispatcher thread may access DispatcherObjects.
        ///     <p/> 
        ///     This method is public so that derived classes can probe to
        ///     see if the calling thread has access to itself. 
        /// </remarks> 
        [EditorBrowsable(EditorBrowsableState.Never)]
        void VerifyAccess();

        /// <summary>
        ///     Whether or not the dispatcher is shutting down.
        /// </summary> 
        bool HasShutdownStarted { get; }

        /// <summary> 
        ///     Whether or not the dispatcher has been shut down.
        /// </summary> 
        bool HasShutdownFinished { get; }

        /// <summary> 
        ///     Raised when the dispatcher is shutting down. 
        /// </summary>
        event EventHandler ShutdownStarted;

        /// <summary>
        ///     Raised when the dispatcher is shut down.
        /// </summary> 
        event EventHandler ShutdownFinished;

        /// <summary> 
        ///     Occurs when an untrapped thread exception is thrown.
        /// </summary> 
        /// <remarks> 
        ///     Raised during the filter stage for an exception raised during
        ///     execution of a delegate via Invoke or BeginInvoke. 
        ///     <P/>
        ///     The callstack is not unwound at this time (first-chance exception).
        ///     <P/>
        ///     Listeners to this event must be written with care to avoid 
        ///     creating secondary exceptions and to catch any that occur.
        ///     It is recommended to avoid allocating memory or doing any 
        ///     heavylifting if possible. 
        ///     Callers must have UIPermission(PermissionState.Unrestricted) to call this API.
        /// </remarks> 
        /// <SecurityNote>
        ///     Critical: partially-trusted code is not allowed to access our exception filter.
        ///     TreatAsSafe: link-demands
        /// </SecurityNote> 
        event DispatcherUnhandledExceptionFilterEventHandler UnhandledExceptionFilter;

        /// <summary>
        ///     Executes the specified delegate asynchronously on the thread that 
        ///     the Dispatcher was created on. 
        /// </summary>
        /// <param name="priority"> 
        ///     The priority that determines in what order the specified method
        ///     is invoked relative to the other pending methods in the Dispatcher.
        /// </param>
        /// <param name="method"> 
        ///     A delegate to a method that takes no parameters.
        /// </param> 
        /// <returns> 
        ///     An IAsyncResult object that represents the result of the
        ///     BeginInvoke operation. 
        /// </returns>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        DispatcherOperation BeginInvoke(DispatcherPriority priority, Delegate method);

        /// <summary>
        ///     Executes the specified delegate asynchronously with the specified 
        ///     arguments, on the thread that the Dispatcher was created on.
        /// </summary>
        /// <param name="priority">
        ///     The priority that determines in what order the specified method 
        ///     is invoked relative to the other pending methods in the Dispatcher.
        /// </param> 
        /// <param name="method"> 
        ///     A delegate to a method that takes parameters of the same number
        ///     and type that are contained in the args parameter. 
        /// </param>
        /// <param name="arg">
        ///     A object to pass as an argument to the given method.
        ///     This can be null if no arguments are needed. 
        /// </param>
        /// <returns> 
        ///     An IAsyncResult object that represents the result of the 
        ///     BeginInvoke operation.
        /// </returns> 
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        DispatcherOperation BeginInvoke(DispatcherPriority priority, Delegate method, object arg);

        /// <summary>
        ///     Executes the specified delegate asynchronously with the specified 
        ///     arguments, on the thread that the Dispatcher was created on.
        /// </summary>
        /// <param name="priority">
        ///     The priority that determines in what order the specified method 
        ///     is invoked relative to the other pending methods in the Dispatcher.
        /// </param> 
        /// <param name="method"> 
        ///     A delegate to a method that takes parameters of the same number
        ///     and type that are contained in the args parameter. 
        /// </param>
        /// <param name="arg">
        /// enh
        /// </param> 
        /// <param name="args">
        ///     An array of objects to pass as arguments to the given method. 
        ///     This can be null if no arguments are needed. 
        /// </param>
        /// <returns> 
        ///     An IAsyncResult object that represents the result of the
        ///     BeginInvoke operation.
        /// </returns>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        DispatcherOperation BeginInvoke(DispatcherPriority priority, Delegate method, object arg, params object[] args);

        /// <summary>
        ///     Executes the specified delegate asynchronously with the specified
        ///     arguments, on the thread that the Dispatcher was created on. 
        /// </summary>
        /// <param name="method"> 
        ///     A delegate to a method that takes parameters of the same number 
        ///     and type that are contained in the args parameter.
        /// </param> 
        /// <param name="args">
        ///     An array of objects to pass as arguments to the given method.
        ///     This can be null if no arguments are needed.
        /// </param> 
        /// <returns>
        ///     An IAsyncResult object that represents the result of the 
        ///     BeginInvoke operation. 
        /// </returns>
        DispatcherOperation BeginInvoke(Delegate method, params object[] args);

        /// <summary>
        ///     Executes the specified delegate asynchronously with the specified 
        ///     arguments, on the thread that the Dispatcher was created on. 
        /// </summary>
        /// <param name="method"> 
        ///     A delegate to a method that takes parameters of the same number
        ///     and type that are contained in the args parameter.
        /// </param>
        /// <param name="priority"> 
        ///     The priority that determines in what order the specified method
        ///     is invoked relative to the other pending methods in the Dispatcher. 
        /// </param> 
        /// <param name="args">
        ///     An array of objects to pass as arguments to the given method. 
        ///     This can be null if no arguments are needed.
        /// </param>
        /// <returns>
        ///     An IAsyncResult object that represents the result of the 
        ///     BeginInvoke operation.
        /// </returns> 
        DispatcherOperation BeginInvoke(Delegate method, DispatcherPriority priority, params object[] args);

        /// <summary>
        ///     Executes the specified delegate synchronously on the thread that 
        ///     the Dispatcher was created on. 
        /// </summary>
        /// <param name="priority"> 
        ///     The priority that determines in what order the specified method
        ///     is invoked relative to the other pending methods in the Dispatcher.
        /// </param>
        /// <param name="method"> 
        ///     A delegate to a method that takes no parameters.
        /// </param> 
        /// <returns> 
        ///     The return value from the delegate being invoked, or null if
        ///     the delegate has no return value. 
        /// </returns>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        object Invoke(DispatcherPriority priority, Delegate method);

        /// <summary>
        ///     Executes the specified delegate synchronously with the specified 
        ///     arguments, on the thread that the Dispatcher was created on.
        /// </summary>
        /// <param name="priority">
        ///     The priority that determines in what order the specified method 
        ///     is invoked relative to the other pending methods in the Dispatcher.
        /// </param> 
        /// <param name="method"> 
        ///     A delegate to a method that takes parameters of the same number
        ///     and type that are contained in the args parameter. 
        /// </param>
        /// <param name="arg">
        ///     An object to pass as an argument to the given method.
        ///     This can be null if no arguments are needed. 
        /// </param>
        /// <returns> 
        ///     The return value from the delegate being invoked, or null if 
        ///     the delegate has no return value.
        /// </returns> 
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        object Invoke(DispatcherPriority priority, Delegate method, object arg);

        /// <summary> 
        ///     Executes the specified delegate synchronously with the specified
        ///     arguments, on the thread that the Dispatcher was created on. 
        /// </summary>
        /// <param name="priority">
        ///     The priority that determines in what order the specified method
        ///     is invoked relative to the other pending methods in the Dispatcher. 
        /// </param>
        /// <param name="method"> 
        ///     A delegate to a method that takes parameters of the same number 
        ///     and type that are contained in the args parameter.
        /// </param> 
        /// <param name="arg">
        /// </param>
        /// <param name="args">
        ///     An array of objects to pass as arguments to the given method. 
        ///     This can be null if no arguments are needed.
        /// </param> 
        /// <returns> 
        ///     The return value from the delegate being invoked, or null if
        ///     the delegate has no return value. 
        /// </returns>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        object Invoke(DispatcherPriority priority, Delegate method, object arg, params object[] args);

        /// <summary>
        ///     Executes the specified delegate synchronously on the thread that 
        ///     the Dispatcher was created on.
        /// </summary>
        /// <param name="priority">
        ///     The priority that determines in what order the specified method 
        ///     is invoked relative to the other pending methods in the Dispatcher.
        /// </param> 
        /// <param name="timeout"> 
        ///     The maximum amount of time to wait for the operation to complete.
        /// </param>        /// <param name="method"> 
        ///     A delegate to a method that takes no parameters.
        /// </param>
        /// <returns>
        ///     The return value from the delegate being invoked, or null if 
        ///     the delegate has no return value.
        /// </returns> 
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        object Invoke(DispatcherPriority priority, TimeSpan timeout, Delegate method);

        /// <summary> 
        ///     Executes the specified delegate synchronously with the specified
        ///     arguments, on the thread that the Dispatcher was created on. 
        /// </summary> 
        /// <param name="priority">
        ///     The priority that determines in what order the specified method 
        ///     is invoked relative to the other pending methods in the Dispatcher.
        /// </param>
        /// <param name="timeout">
        ///     The maximum amount of time to wait for the operation to complete. 
        /// </param>
        /// <param name="method"> 
        ///     A delegate to a method that takes parameters of the same number 
        ///     and type that are contained in the args parameter.
        /// </param> 
        /// <param name="arg">
        ///     An object to pass as an argument to the given method.
        ///     This can be null if no arguments are needed.
        /// </param> 
        /// <returns>
        ///     The return value from the delegate being invoked, or null if 
        ///     the delegate has no return value. 
        /// </returns>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        object Invoke(DispatcherPriority priority, TimeSpan timeout, Delegate method, object arg);

        /// <summary> 
        ///     Executes the specified delegate synchronously with the specified 
        ///     arguments, on the thread that the Dispatcher was created on.
        /// </summary> 
        /// <param name="priority">
        ///     The priority that determines in what order the specified method
        ///     is invoked relative to the other pending methods in the Dispatcher.
        /// </param> 
        /// <param name="timeout">
        ///     The maximum amount of time to wait for the operation to complete. 
        /// </param> 
        /// <param name="method">
        ///     A delegate to a method that takes parameters of the same number 
        ///     and type that are contained in the args parameter.
        /// </param>
        /// <param name="arg">
        /// </param> 
        /// <param name="args">
        ///     An array of objects to pass as arguments to the given method. 
        ///     This can be null if no arguments are needed. 
        /// </param>
        /// <returns> 
        ///     The return value from the delegate being invoked, or null if
        ///     the delegate has no return value.
        /// </returns>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        object Invoke(DispatcherPriority priority, TimeSpan timeout, Delegate method, object arg, params object[] args);

        /// <summary>
        ///     Executes the specified delegate synchronously on the thread that
        ///     the Dispatcher was created on.
        /// </summary> 
        /// <param name="method">
        ///     A delegate to a method that takes parameters of the same number 
        ///     and type that are contained in the args parameter. 
        /// </param>
        /// <param name="args"> 
        ///     An array of objects to pass as arguments to the given method.
        ///     This can be null if no arguments are needed.
        /// </param>
        /// <returns> 
        ///     The return value from the delegate being invoked, or null if
        ///     the delegate has no return value. 
        /// </returns> 
        object Invoke(Delegate method, params object[] args);

        /// <summary> 
        ///     Executes the specified delegate synchronously on the thread that
        ///     the Dispatcher was created on. 
        /// </summary> 
        /// <param name="method">
        ///     A delegate to a method that takes parameters of the same number 
        ///     and type that are contained in the args parameter.
        /// </param>
        /// <param name="priority">
        ///     The priority that determines in what order the specified method 
        ///     is invoked relative to the other pending methods in the Dispatcher.
        /// </param> 
        /// <param name="args"> 
        ///     An array of objects to pass as arguments to the given method.
        ///     This can be null if no arguments are needed. 
        /// </param>
        /// <returns>
        ///     The return value from the delegate being invoked, or null if
        ///     the delegate has no return value. 
        /// </returns>
        object Invoke(Delegate method, DispatcherPriority priority, params object[] args);

        /// <summary>
        ///     Executes the specified delegate synchronously on the thread that
        ///     the Dispatcher was created on. 
        /// </summary>
        /// <param name="method"> 
        ///     A delegate to a method that takes parameters of the same number 
        ///     and type that are contained in the args parameter.
        /// </param> 
        /// <param name="timeout">
        ///     The maximum amount of time to wait for the operation to complete.
        /// </param>
        /// <param name="args"> 
        ///     An array of objects to pass as arguments to the given method.
        ///     This can be null if no arguments are needed. 
        /// </param> 
        /// <returns>
        ///     The return value from the delegate being invoked, or null if 
        ///     the delegate has no return value.
        /// </returns>
        object Invoke(Delegate method, TimeSpan timeout, params object[] args);

        /// <summary>
        ///     Executes the specified delegate synchronously on the thread that 
        ///     the Dispatcher was created on.
        /// </summary>
        /// <param name="method">
        ///     A delegate to a method that takes parameters of the same number 
        ///     and type that are contained in the args parameter.
        /// </param> 
        /// <param name="timeout"> 
        ///     The maximum amount of time to wait for the operation to complete.
        /// </param> 
        /// <param name="priority">
        ///     The priority that determines in what order the specified method
        ///     is invoked relative to the other pending methods in the Dispatcher.
        /// </param> 
        /// <param name="args">
        ///     An array of objects to pass as arguments to the given method. 
        ///     This can be null if no arguments are needed. 
        /// </param>
        /// <returns> 
        ///     The return value from the delegate being invoked, or null if
        ///     the delegate has no return value.
        /// </returns>
        object Invoke(Delegate method, TimeSpan timeout, DispatcherPriority priority, params object[] args);
    }
}