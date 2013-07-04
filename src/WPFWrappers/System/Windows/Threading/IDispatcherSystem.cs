using System;
using System.ComponentModel;
using System.Security;
using System.Security.Permissions;
using System.Windows.Threading;
using UnitWrappers.System.Threading;

namespace UnitWrappers.System.Windows.Threading
{
    public interface IDispatcherSystem
    {
        /// <summary> 
        /// Gets the <see cref="IDispatcher"/> for the thread currently executing and creates a new <see cref="IDispatcher"/> if one is not already associated with the thread. 
        /// </summary>
        /// <value>The dispatcher associated with the current thread.</value>
        /// <remarks>
        ///If a <see cref="IDispatcher"/> is not associated with the current thread, a new <see cref="IDispatcher"/> will be created. This is not the case with the <see cref="FromThread"/> method. <see cref="FromThread"/> will return Nothing if there is not a dispatcher associated with the specified thread. 
        /// </remarks>
        IDispatcher CurrentDispatcher { get; }

        /// <summary>
        /// Gets the <see cref="IDispatcher"/> for the specified thread. 
        /// </summary>
        /// <remarks> 
        /// If a dispatcher is not available for the specified thread, Nothing will be returned.
        ///<see cref="IDispatcher"/> does not create a <see cref="IDispatcher"/>  on a thread that does not have a <see cref="IDispatcher"/> . A new <see cref="IDispatcher"/>  is created on a thread that does not already have a <see cref="IDispatcher"/>  when attempting to get the <see cref="IDispatcher"/>  by using the <see cref="DispatcherSystem.CurrentDispatcher"/> property.
        /// </remarks> 
        /// <param name="thread">The thread to obtain the <see cref="DispatcherSystem"/> from.</param>
        /// <value>The dispatcher for thread.</value>
        IDispatcher FromThread(IThread thread);

        /// <summary> 
        ///    Pushes the main execution frame on the event queue of the The <see cref="IDispatcher"/>. 
        /// </summary> 
        /// <remarks>
        /// The <see cref="IDispatcher"/> processes the event queue in a loop. The loop is referred to as a frame. The initial loop is typically initiated by the application by calling <see cref="IDispatcher"/>.
        /// The main execution frame will continue until the The <see cref="DispatcherSystem"/> is shutdown
        /// </remarks> 
        ///<SecurityNote>
        ///    Critical: This code is blocked off more as defense in depth 
        ///    PublicOk: From a public perspective there is a link demand here 
        ///</SecurityNote>
        [UIPermission(SecurityAction.LinkDemand, Unrestricted = true)]
        [SecurityCritical]
        void Run();

        /// <summary> 
        ///     Enters an execute loop.
        /// </summary> 
        /// <param name="frame">
        ///     The frame for the dispatcher to process.
        /// </param>
        /// <remarks> 
        ///A <see cref="DispatcherFrame"/> represents a loop that processes pending work items.
        ///The <see cref="IDispatcher"/> processes the work item queue in a loop. The loop is referred to as a frame. The initial loop is typically initiated by the application by calling <see cref="IDispatcher"/> .
        ///<see cref="DispatcherFrame"/> enters a loop represented by the parameter frame. At each iteration of the loop, the <see cref="DispatcherFrame"/> will check the <see cref="IDispatcherService.HasShutdownStarted"/> property on the <see cref="IDispatcher"/> class to determine whether the loop should continue or if it should stop.
        /// <see cref="IDispatcher"/> allows for the Continue property to be set explicitly and it respects the <see cref="DispatcherFrame"/> property on the <see cref="InvalidOperationException"/>. This means when the <see cref="IDispatcherService.HasShutdownFinished"/> starts to shut down, frames that use the default <see cref="IDispatcher"/> implementation will exit, which enables all nested frames to exit.
        /// </remarks> 
        ///<SecurityNote> 
        ///    Critical: This code is blocked off more as defense in depth
        ///    PublicOk: From a public perspective there is a link demand here 
        ///</SecurityNote>
        /// <exception cref="IDispatcher">frame is Nothing.</exception>
        /// <exception cref="IDispatcher"><see cref="DispatcherSystem.Run"/> is true
        /// -or-
        /// frame is running on a different <see cref="DispatcherSystem.PushFrame"/>.
        /// -or-
        /// <see cref="DispatcherSystem"/> processing has been disabled.
        ///</exception>
        [UIPermissionAttribute(SecurityAction.LinkDemand, Unrestricted = true)]
        [SecurityCritical]
        void PushFrame(DispatcherFrame frame);

        /// <summary>
        /// Requests that all frames exit, including nested frames.
        /// </summary>
        /// <remarks> 
        ///     Callers must have UIPermission(PermissionState.Unrestricted) to call this API. 
        /// </remarks>
        /// <SecurityNote> 
        ///     Critical - calls a critical method - postThreadMessage.
        ///     PublicOK - all we're doing is posting a current message to our thread.
        ///                net effect is the dispatcher "wakes up"
        ///                and uses the continue flag ( which may have just changed). 
        /// </SecurityNote>
        [SecurityCritical]
        void ExitAllFrames();

        /// <summary>
        /// Determines whether the specified <see cref="DispatcherPriority"/> is a valid priority. 
        /// </summary>
        /// <param name="priority">
        /// The priority to check.
        /// </param> 
        /// <param name="parameterName">
        /// A string that will be returned by the exception that occurs if the priority is invalid.
        /// </param> 
        /// <exception cref="InvalidEnumArgumentException"><i>priority</i> is not a valid DispatcherPriority.</exception>
        void ValidatePriority(DispatcherPriority priority, string parameterName);
    }
}