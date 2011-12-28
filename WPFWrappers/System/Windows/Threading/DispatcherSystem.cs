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


    public class DispatcherSystem : IDispatcherSystem
    {
        /// <inheritdoc />
        public IDispatcher CurrentDispatcher
        {
            get
            {
                return new DispatcherWrap(Dispatcher.CurrentDispatcher);
            }
        }

        /// <inheritdoc />
        public IDispatcher FromThread(IThread thread)
        {
            var wrap = (thread as ThreadWrap);
            if (wrap == null) throw new ArgumentException("Thread should wrap CLR thread","thread");
            return new DispatcherWrap(Dispatcher.FromThread(wrap.UnderlyingObject));
        }

        /// <inheritdoc />
        [UIPermission(SecurityAction.LinkDemand, Unrestricted = true)]
        [SecurityCritical]
        public void Run()
        {
            Dispatcher.Run();
        }

        /// <inheritdoc />
        [UIPermissionAttribute(SecurityAction.LinkDemand, Unrestricted = true)]
        [SecurityCritical]
        public void PushFrame(DispatcherFrame frame)
        {
            Dispatcher.PushFrame(frame);
        }

        /// <inheritdoc />
        [SecurityCritical]
        public void ExitAllFrames()
        {
            Dispatcher.ExitAllFrames();
        }

        /// <inheritdoc />
        public void ValidatePriority(DispatcherPriority priority, string parameterName)
        {
            Dispatcher.ValidatePriority(priority, parameterName);
        }
    }
}
