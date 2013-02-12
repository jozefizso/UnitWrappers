using System.IO;
using System.Security;
using System.Security.Permissions;
using UnitWrappers.Microsoft.Win32.SafeHandles;
using UnitWrappers.System.Security.AccessControl;

namespace UnitWrappers.System.IO
{
    public abstract class FileStreamBase : Stream, IFileStream
    {
#if NET401
 [SecuritySafeCritical]
#endif
        static FileStreamBase()
        {
        }
#if NET401
        [SecuritySafeCritical]

        public abstract void Flush(bool flushToDisk);
#endif
        public abstract bool IsAsync { get; }
        public abstract string Name
        {
            #if NET401
            [SecuritySafeCritical]
#endif
            get;

        }
#if !PORTABLE
        public abstract ISafeFileHandle SafeFileHandle
        {
#if NET401
            [SecurityCritical, SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
#endif
#if NET351
           [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
           [SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
#endif
            get;
        }
#endif
#if NET401
        [SecuritySafeCritical]
#endif
        public abstract IFileSecurity GetAccessControl();
#if NET401
        [SecuritySafeCritical]
#endif
        public abstract void Lock(long position, long length);
#if NET401
        [SecuritySafeCritical]
#endif
        public abstract void SetAccessControl(IFileSecurity fileSecurity);
#if NET401
        [SecuritySafeCritical]
#endif
        public abstract void Unlock(long position, long length);

        
    }
}