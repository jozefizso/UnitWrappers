using System;
using System.Security;
using System.Security.Permissions;
#if !MONO && !PORTABLE && !ANDROID
using UnitWrappers.Microsoft.Win32.SafeHandles;
#endif

#if !ANDROID && !PORTABLE
using UnitWrappers.System.Security.AccessControl;
#endif

namespace UnitWrappers.System.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.FileStream"/> class.
    /// </summary>
    public interface IFileStream : IStream, IDisposable
    {

#if NET40
        /// <summary>
        /// Clears buffers for this stream and causes any buffered data to be written to the file, and also clears all intermediate file buffers.
        /// </summary>
        /// <param name="flushToDisk">true to flush all intermediate file buffers; otherwise, false. </param>
        void Flush(bool flushToDisk);
#endif

        /// <summary>
        /// Gets a value indicating whether the FileStream was opened asynchronously or synchronously.
        /// </summary>
        bool IsAsync { get; }
        /// <summary>
        /// Gets the name of the FileStreamBase that was passed to the constructor.
        /// </summary>
        string Name { get; }
#if !MONO && !PORTABLE && !ANDROID
        /// <summary>
        /// Gets a ISafeFileHandle object that represents the operating system file handle for the file that the current FileStream object encapsulates. 
        /// </summary>
        ISafeFileHandle SafeFileHandle
        {

          //  [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
          //  [SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)] 

            get;
        }
#endif

        /// <summary>
        /// Closes the current stream and releases any resources (such as sockets and file handles) associated with the current stream.
        /// </summary>
        //        void Close();
        /// <summary>
        /// Releases the unmanaged resources used by the FileStream and optionally releases the managed resources. 
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        //        void Dispose(bool disposing);

        /// <summary>
        /// Prevents other processes from changing the FileStream while permitting read access. 
        /// </summary>
        /// <param name="position">The beginning of the range to lock. The value of this parameter must be equal to or greater than zero (0). </param>
        /// <param name="length">The range to be locked. </param>
        void Lock(long position, long length);

#if !ANDROID && !PORTABLE
		/// <summary>
		/// Gets a IFileSecurity object that encapsulates the access control list (ACL) entries for the file described by the current FileStream object. 
		/// </summary>
		/// <returns>A IFileSecurity object that encapsulates the access control settings for the file described by the current FileStream object. </returns>
		IFileSecurity GetAccessControl();

        /// <summary>
        /// Applies access control list (ACL) entries described by a IFileSecurity object to the file described by the current FileStream object. 
        /// </summary>
        /// <param name="fileSecurity">A IFileSecurity object that describes an ACL entry to apply to the current file.</param>
        void SetAccessControl(IFileSecurity fileSecurity);
#endif

        /// <summary>
        /// Returns a String that represents the current Object. 
        /// </summary>
        /// <returns>A String that represents the current Object. </returns>
        string ToString();
        /// <summary>
        /// Allows access by other processes to all or part of a file that was previously locked.
        /// </summary>
        /// <param name="position">The beginning of the range to unlock.</param>
        /// <param name="length">The range to be unlocked.</param>
        void Unlock(long position, long length);
    }
}