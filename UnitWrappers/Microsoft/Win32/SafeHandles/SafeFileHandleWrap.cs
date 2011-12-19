using System;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace UnitWrappers.Microsoft.Win32.SafeHandles
{
    /// <summary>
    /// Wrapper for <see cref="T:Microsoft.Win32.SafeHandles.SafeFileHandle"/> class.
    /// </summary>
    [SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode=true)]
    public class SafeFileHandleWrap : ISafeFileHandle
	{
	   /// <summary>
		/// Initializes a new instance of the <see cref="T:UnitWrappers.Microsoft.Win32.SafeHandles.SafeFileHandleWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="safeFileHandle">A <see cref="T:Microsoft.Win32.SafeHandles.SafeFileHandle"/> object.</param>
		public SafeFileHandleWrap(SafeFileHandle safeFileHandle)
		{
            UnderlyingObject = safeFileHandle;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:UnitWrappers.Microsoft.Win32.SafeHandles.SafeFileHandleWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="preexistingHandle">An IntPtr object that represents the pre-existing handle to use.</param>
		/// <param name="ownsHandle"> true to reliably release the handle during the finalization phase; false to prevent reliable release (not recommended).</param>
		public SafeFileHandleWrap(IntPtr preexistingHandle, bool ownsHandle)
		{
			UnderlyingObject = new SafeFileHandle(preexistingHandle, ownsHandle);
		}



		public bool IsClosed
        {
            get { return UnderlyingObject.IsClosed; }
        }

        public bool IsInvalid
        {
            get { return UnderlyingObject.IsInvalid; }
        }

        public SafeFileHandle UnderlyingObject { get; private set; }

        public void Close()
        {
            UnderlyingObject.Close();
        }

        public void DangerousAddRef(ref bool success)
        {
            UnderlyingObject.DangerousAddRef(ref success);
        }

        public IntPtr DangerousGetHandle()
        {
            return UnderlyingObject.DangerousGetHandle();
        }

        public void DangerousRelease()
        {
            UnderlyingObject.DangerousRelease();
        }

        public void SetHandleAsInvalid()
        {
            UnderlyingObject.SetHandleAsInvalid();
        }
    }
}