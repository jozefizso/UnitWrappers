using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Windows.Threading;
using UnitWrappers.System.Threading;

namespace UnitWrappers.System.Windows.Threading
{
    public class DispatcherSystem
    {
        /// <summary> 
        ///     Returns the Dispatcher for the calling thread.
        /// </summary>
        /// <remarks>
        ///     If there is no dispatcher available for the current thread, 
        ///     and the thread allows a dispatcher to be auto-created, a new
        ///     dispatcher will be created. 
        ///     <P/> 
        ///     If there is no dispatcher for the current thread, and thread
        ///     does not allow one to be auto-created, an exception is thrown. 
        /// </remarks>
        public IDispatcher CurrentDispatcher
        {
            get
            {
                return new DispatcherWrap(Dispatcher.CurrentDispatcher);
            }
        }

        /// <summary>
        ///     Returns the Dispatcher for the specified thread. 
        /// </summary>
        /// <remarks> 
        ///     If there is no dispatcher available for the specified thread, 
        ///     this method will return null.
        /// </remarks> 
        //TODO: make UnitWrappers internals visible to and use IThread
        public IDispatcher FromThread(Thread thread)
        {
            return new DispatcherWrap(Dispatcher.FromThread(thread));
        }

        /// <summary> 
        ///     Push the main execution frame.
        /// </summary> 
        /// <remarks>
        ///     This frame will continue until the dispatcher is shut down.
        ///     Callers must have UIPermission(PermissionState.Unrestricted) to call this API.
        /// </remarks> 
        ///<SecurityNote>
        ///    Critical: This code is blocked off more as defense in depth 
        ///    PublicOk: From a public perspective there is a link demand here 
        ///</SecurityNote>
        [UIPermission(SecurityAction.LinkDemand, Unrestricted = true)]
        [SecurityCritical]
        public void Run()
        {
            Dispatcher.Run();
        }

        /// <summary> 
        ///     Push an execution frame.
        /// </summary> 
        /// <param name="frame">
        ///     The frame for the dispatcher to process.
        /// </param>
        /// <remarks> 
        ///     Callers must have UIPermission(PermissionState.Unrestricted) to call this API.
        /// </remarks> 
        ///<SecurityNote> 
        ///    Critical: This code is blocked off more as defense in depth
        ///    PublicOk: From a public perspective there is a link demand here 
        ///</SecurityNote>
        [UIPermissionAttribute(SecurityAction.LinkDemand, Unrestricted = true)]
        [SecurityCritical]
        public static void PushFrame(DispatcherFrame frame)
        {
            Dispatcher.PushFrame(frame);
        }

        /// <summary>
        ///     Requests that all nested frames exit. 
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
        public static void ExitAllFrames()
        {
            Dispatcher.ExitAllFrames();
        }

        /// <summary>
        ///     Validates that a priority is suitable for use by the dispatcher. 
        /// </summary>
        /// <param name="priority">
        ///     The priority to validate.
        /// </param> 
        /// <param name="parameterName">
        ///     The name if the argument to report in the ArgumentException 
        ///     that is raised if the priority is not suitable for use by 
        ///     the dispatcher.
        /// </param> 
        public void ValidatePriority(DispatcherPriority priority, string parameterName)
        {
            Dispatcher.ValidatePriority(priority,parameterName);
        }



    }
}
