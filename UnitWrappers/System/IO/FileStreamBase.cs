using System.IO;
using System.Security;
using System.Security.Permissions;
using UnitWrappers.Microsoft.Win32.SafeHandles;
using UnitWrappers.System.Security.AccessControl;

namespace UnitWrappers.System.IO
{
    public abstract class FileStreamBase : Stream, IFileStream
    {

// [SecuritySafeCritical]

        static FileStreamBase()
        {
        }
#if NET40
        //[SecuritySafeCritical]

        public abstract void Flush(bool flushToDisk);
#endif
        public abstract bool IsAsync { get; }
        public abstract string Name
        {
          
            //[SecuritySafeCritical]

            get;

        }
#if !PORTABLE
        public abstract ISafeFileHandle SafeFileHandle
        {
            // [SecurityCritical, SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]


           //[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
           //[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]

            get;
        }
#endif

       // [SecuritySafeCritical]

        public abstract IFileSecurity GetAccessControl();

       // [SecuritySafeCritical]

        public abstract void Lock(long position, long length);

       // [SecuritySafeCritical]

        public abstract void SetAccessControl(IFileSecurity fileSecurity);

      //  [SecuritySafeCritical]

        public abstract void Unlock(long position, long length);

        
    }
}