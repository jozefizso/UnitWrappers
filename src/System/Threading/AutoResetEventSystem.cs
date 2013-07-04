using System.Security.AccessControl;
using System.Threading;

namespace UnitWrappers.System.Threading
{
    /// <summary>
    /// 
    /// </summary>
    public class AutoResetEventSystem
    {
        public IAutoResetEvent OpenExisting(string name)
        {
            return new AutoResetEventWrap(AutoResetEvent.OpenExisting(name) as AutoResetEvent);
        }

        public IAutoResetEvent OpenExisting(string name, EventWaitHandleRights rights)
        {
            return new AutoResetEventWrap(AutoResetEvent.OpenExisting(name, rights) as AutoResetEvent);
        }
    }
}