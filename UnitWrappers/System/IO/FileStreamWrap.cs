using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
#if !PORTABLE
using UnitWrappers.Microsoft.Win32.SafeHandles;
#endif

using UnitWrappers.System.Security.AccessControl;

namespace UnitWrappers.System.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.FileStream"/> class.
    /// </summary>
    [Serializable]
    [ComVisible(true)]
    public class FileStreamWrap : FileStreamBase, IWrap<FileStream>
    {
        private FileStream _underlyingObject;

        //Stream IWrap<Stream>.UnderlyingObject { get { return _underlyingObject; } }
        FileStream IWrap<FileStream>.UnderlyingObject { get { return _underlyingObject; } }




      //  [SecuritySafeCritical]

        static FileStreamWrap()
        {
        }

        public static implicit operator FileStreamWrap(FileStream o)
        {
            return new FileStreamWrap(o);
        }

        public static implicit operator FileStream(FileStreamWrap o)
        {
            return o._underlyingObject;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.FileStreamWrap"/> class on the specified path. 
        /// </summary>
        /// <param name="fileStream">A <see cref="T:System.IO.FileStream"/> object.</param>
        public FileStreamWrap(FileStream fileStream)
        {
            _underlyingObject = fileStream;
            
        }


#if !PORTABLE
        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.FileStreamWrap"/> class for the specified file handle, with the specified read/write permission. 
        /// </summary>
        /// <param name="handle">A file handle for the file that the current FileStream object will encapsulate. </param>
        /// <param name="access">A FileAccess constant that sets the CanRead and CanWrite properties of the FileStream object. </param>
        public FileStreamWrap(ISafeFileHandle handle, FileAccess access)
        {
            _underlyingObject = new FileStream(handle.UnderlyingObject, access);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.FileStreamWrap"/> class for the specified file handle, with the specified read/write permission, and buffer size. 
        /// </summary>
        /// <param name="handle">A file handle for the file that the current FileStream object will encapsulate. </param>
        /// <param name="access">A FileAccess constant that sets the CanRead and CanWrite properties of the FileStream object. </param>
        /// <param name="bufferSize">A positive Int32 value greater than 0 indicating the buffer size. For bufferSize values between one and eight, the actual buffer size is set to eight bytes. </param>
        public FileStreamWrap(ISafeFileHandle handle, FileAccess access, int bufferSize)
        {
            _underlyingObject = new FileStream(handle.UnderlyingObject, access, bufferSize);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.FileStreamWrap"/> class for the specified file handle, with the specified read/write permission, and buffer size, and synchronous or asynchronous state. 
        /// </summary>
        /// <param name="handle">A file handle for the file that the current FileStream object will encapsulate. </param>
        /// <param name="access">A FileAccess constant that sets the CanRead and CanWrite properties of the FileStream object. </param>
        /// <param name="bufferSize">A positive Int32 value greater than 0 indicating the buffer size. For bufferSize values between one and eight, the actual buffer size is set to eight bytes. </param>
        /// <param name="isAsync"> true if the handle was opened asynchronously (that is, in overlapped I/O mode); otherwise, false. </param>

       // [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]

        public FileStreamWrap(ISafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync)
        {
            _underlyingObject = new FileStream(handle.UnderlyingObject, access, bufferSize, isAsync);
        }
#endif

        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.FileStreamWrap"/> class with the specified path and creation mode. 
        /// </summary>
        /// <param name="path">A relative or absolute path for the file that the current FileStream object will encapsulate.</param>
        /// <param name="mode">A FileMode constant that determines how to open or create the file.</param>
        public FileStreamWrap(string path, FileMode mode)
        {
            _underlyingObject = new FileStream(path, mode);
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.FileStreamWrap"/> class with the specified path and creation mode. 
        /// </summary>
        /// <param name="path">A relative or absolute path for the file that the current FileStream object will encapsulate.</param>
        /// <param name="mode">A FileMode constant that determines how to open or create the file.</param>
        /// <param name="access">A FileAccess constant that determines how the file can be accessed by the FileStream object. This gets the CanRead and CanWrite properties of the FileStream object. CanSeek is true if path specifies a disk file.</param>
        public FileStreamWrap(string path, FileMode mode, FileAccess access)
        {
            _underlyingObject = new FileStream(path, mode, access);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.FileStreamWrap"/> class with the specified path, creation mode, read/write permission, and sharing permission.
        /// </summary>
        /// <param name="path">A relative or absolute path for the file that the current FileStream object will encapsulate.</param>
        /// <param name="mode">A FileMode constant that determines how to open or create the file.</param>
        /// <param name="access">A FileAccess constant that determines how the file can be accessed by the FileStream object. This gets the CanRead and CanWrite properties of the FileStream object. CanSeek is true if path specifies a disk file.</param>
        /// <param name="share">A FileShare constant that determines how the file will be shared by processes. </param>
        public FileStreamWrap(string path, FileMode mode, FileAccess access, FileShare share)
        {
            _underlyingObject = new FileStream(path, mode, access, share);
        }



        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.FileStreamWrap"/> class with the specified path, creation mode, read/write permission, and sharing permission, and buffer size.
        /// </summary>
        /// <param name="path">A relative or absolute path for the file that the current FileStream object will encapsulate.</param>
        /// <param name="mode">A FileMode constant that determines how to open or create the file.</param>
        /// <param name="access">A FileAccess constant that determines how the file can be accessed by the FileStream object. This gets the CanRead and CanWrite properties of the FileStream object. CanSeek is true if path specifies a disk file.</param>
        /// <param name="share">A FileShare constant that determines how the file will be shared by processes. </param>
        /// <param name="bufferSize">A positive Int32 value greater than 0 indicating the buffer size. For bufferSize values between one and eight, the actual buffer size is set to eight bytes. </param>
        public FileStreamWrap(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize)
        {
            _underlyingObject = new FileStream(path, mode, access, share, bufferSize);
        }



        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.FileStreamWrap"/> class with the specified path, creation mode, read/write permission, and sharing permission, and buffer size.
        /// </summary>
        /// <param name="path">A relative or absolute path for the file that the current FileStream object will encapsulate.</param>
        /// <param name="mode">A FileMode constant that determines how to open or create the file.</param>
        /// <param name="access">A FileAccess constant that determines how the file can be accessed by the FileStream object. This gets the CanRead and CanWrite properties of the FileStream object. CanSeek is true if path specifies a disk file.</param>
        /// <param name="share">A FileShare constant that determines how the file will be shared by processes. </param>
        /// <param name="bufferSize">A positive Int32 value greater than 0 indicating the buffer size. For bufferSize values between one and eight, the actual buffer size is set to eight bytes.</param>
        /// <param name="useAsync">A positive Int32 value greater than 0 indicating the buffer size. For bufferSize values between one and eight, the actual buffer size is set to eight bytes.</param>
        public FileStreamWrap(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync)
        {
            _underlyingObject = new FileStream(path, mode, access, share, bufferSize, useAsync);
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.FileStreamWrap"/> class with the specified path, creation mode, read/write and sharing permission, the access other FileStreams can have to the same file, the buffer size, and additional file options.
        /// </summary>
        /// <param name="path">A relative or absolute path for the file that the current FileStream object will encapsulate.</param>
        /// <param name="mode">A FileMode constant that determines how to open or create the file.</param>
        /// <param name="access">A FileAccess constant that determines how the file can be accessed by the FileStream object. This gets the CanRead and CanWrite properties of the FileStream object. CanSeek is true if path specifies a disk file.</param>
        /// <param name="share">A FileShare constant that determines how the file will be shared by processes. </param>
        /// <param name="bufferSize">A positive Int32 value greater than 0 indicating the buffer size. For bufferSize values between one and eight, the actual buffer size is set to eight bytes.</param>
        /// <param name="options">A FileOptions value that specifies additional file options.</param>
        public FileStreamWrap(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options)
        {
            _underlyingObject = new FileStream(path, mode, access, share, bufferSize, options);
        }




        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.FileStreamWrap"/> class with the specified path, creation mode, access rights and sharing permission, the buffer size, and additional file options.
        /// </summary>
        /// <param name="path">A relative or absolute path for the file that the current FileStream object will encapsulate.</param>
        /// <param name="mode">A FileMode constant that determines how to open or create the file.</param>
        /// <param name="rights">A FileSystemRights constant that determines the access rights to use when creating access and audit rules for the file.</param>
        /// <param name="share">A FileShare constant that determines how the file will be shared by processes. </param>
        /// <param name="bufferSize">A positive Int32 value greater than 0 indicating the buffer size. For bufferSize values between one and eight, the actual buffer size is set to eight bytes.</param>
        /// <param name="options">A FileOptions value that specifies additional file options.</param>
        public FileStreamWrap(string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, FileOptions options)
        {
            _underlyingObject = new FileStream(path, mode, rights, share, bufferSize, options);
        }



        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.FileStreamWrap"/> class with the specified path, creation mode, access rights and sharing permission, the buffer size, additional file options, access control and audit security.
        /// </summary>
        /// <param name="path">A relative or absolute path for the file that the current FileStream object will encapsulate.</param>
        /// <param name="mode">A FileMode constant that determines how to open or create the file.</param>
        /// <param name="rights">A FileSystemRights constant that determines the access rights to use when creating access and audit rules for the file.</param>
        /// <param name="share">A FileShare constant that determines how the file will be shared by processes. </param>
        /// <param name="bufferSize">A positive Int32 value greater than 0 indicating the buffer size. For bufferSize values between one and eight, the actual buffer size is set to eight bytes.</param>
        /// <param name="options">A FileOptions value that specifies additional file options.</param>
        /// <param name="fileSecurity">A FileSecurity constant that determines the access control and audit security for the file.</param>
        public FileStreamWrap(string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, FileOptions options, FileSecurity fileSecurity)
        {
            _underlyingObject = new FileStream(path, mode, rights, share, bufferSize, options, fileSecurity);
        }


 

        /// <summary>
        /// Gets a value indicating whether the current stream supports reading.
        /// </summary>
        public override bool CanRead
        {
            get { return _underlyingObject.CanRead; }
        }

        /// <summary>
        /// Gets a value indicating whether the current stream supports seeking. 
        /// </summary>
        public override bool CanSeek
        {
            get { return _underlyingObject.CanSeek; }
        }

        public override bool CanTimeout
        {
            get { return _underlyingObject.CanTimeout; }
        }

        /// <summary>
        /// Gets a value indicating whether the current stream supports writing.
        /// </summary>
        public override bool CanWrite
        {
            get { return _underlyingObject.CanWrite; }
        }

        public override int ReadTimeout
        {
            get { return _underlyingObject.ReadTimeout; }
            set { _underlyingObject.ReadTimeout = value; }
        }

        /// <summary>
        /// Gets <see cref="T:System.IO.Stream"/> object.
        /// </summary>
        public Stream StreamInstance { get { return _underlyingObject; } }

        public override int WriteTimeout
        {
            get { return _underlyingObject.WriteTimeout; }
            set { _underlyingObject.WriteTimeout = value; }
        }

#if NET40
        //[SecuritySafeCritical]

        public override void Flush(bool flushToDisk)
        {
            _underlyingObject.Flush(flushToDisk);
        }
#endif
        public override bool IsAsync
        {
            get { return _underlyingObject.IsAsync; }
        }

        /// <summary>
        /// Gets the length in bytes of the stream.
        /// </summary>
        public override long Length
        {

          //  [SecuritySafeCritical]

            get { return _underlyingObject.Length; }
        }

        public override string Name
        {

         //   [SecuritySafeCritical]

            get { return _underlyingObject.Name; }
        }

        /// <summary>
        /// Gets or sets the current position of this stream.
        /// </summary>
        public override long Position
        {

        //    [SecuritySafeCritical]

            get { return _underlyingObject.Position; }

         //   [SecuritySafeCritical]

            set { _underlyingObject.Position = value; }
        }
#if !PORTABLE
        public override ISafeFileHandle SafeFileHandle
        {

          //  [SecurityCritical, SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)] 

            get { return new SafeFileHandleWrap(_underlyingObject.SafeFileHandle); }
        }
#endif

        /// Begins an asynchronous read.
        /// </summary>
        /// <param name="array">The buffer to read data into.</param>
        /// <param name="offset">The byte offset in array at which to begin reading.</param>
        /// <param name="numBytes">The maximum number of bytes to read.</param>
        /// <param name="userCallback">The method to be called when the asynchronous read operation is completed.</param>
        /// <param name="stateObject">A user-provided object that distinguishes this particular asynchronous read request from other requests.</param>
        /// <returns>A user-provided object that distinguishes this particular asynchronous read request from other requests.</returns>
        [HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        public override IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
        {

            return _underlyingObject.BeginRead(array, offset, numBytes, userCallback, stateObject);
        }

        /// <summary>
        /// Begins an asynchronous write. 
        /// </summary>
        /// <param name="array">The buffer to read data into.</param>
        /// <param name="offset">The byte offset in array at which to begin reading.</param>
        /// <param name="numBytes">The maximum number of bytes to read.</param>
        /// <param name="userCallback">The method to be called when the asynchronous read operation is completed.</param>
        /// <param name="stateObject">A user-provided object that distinguishes this particular asynchronous read request from other requests.</param>
        /// <returns>An IAsyncResult that references the asynchronous write.</returns>
        [HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
        {
            return _underlyingObject.BeginWrite(array, offset, numBytes, userCallback, stateObject);
        }

        /// <summary>
        /// Closes the current stream and releases any resources (such as sockets and file handles) associated with the current stream. 
        /// </summary>
        public override void Close()
        {
            _underlyingObject.Close();
        }

        /// <summary>
        /// Waits for the pending asynchronous read to complete. 
        /// </summary>
        /// <param name="asyncResult">The reference to the pending asynchronous request to wait for.</param>
        /// <returns>The number of bytes read from the stream, between 0 and the number of bytes you requested. Streams only return 0 at the end of the stream, otherwise, they should block until at least 1 byte is available.</returns>
        public override int EndRead(IAsyncResult asyncResult)
        {
            return _underlyingObject.EndRead(asyncResult);
        }

        /// <summary>
        /// Ends an asynchronous write, blocking until the I/O operation has completed. 
        /// </summary>
        /// <param name="asyncResult">The pending asynchronous I/O request. </param>
        public override void EndWrite(IAsyncResult asyncResult)
        {
            _underlyingObject.EndWrite(asyncResult);
        }

        /// <summary>
        /// Clears all buffers for this stream and causes any buffered data to be written to the file system.
        /// </summary>

         //   [SecuritySafeCritical]

        public override void Flush()
        {
            _underlyingObject.Flush();
        }


        //[SecuritySafeCritical]
        public override IFileSecurity GetAccessControl()
        {
            return new FileSecurityWrap(_underlyingObject.GetAccessControl());
        }
       // [SecuritySafeCritical]

        public override void Lock(long position, long length)
        {
            _underlyingObject.Lock(position, length);
        }

        /// <summary>
        /// Reads a block of bytes from the stream and writes the data in a given buffer. 
        /// </summary>
        /// <param name="buffer">When this method returns, contains the specified byte array with the values between offset and (offset + count - 1) replaced by the bytes read from the current source. </param>
        /// <param name="offset">The byte offset in array at which the read bytes will be placed. </param>
        /// <param name="count">The maximum number of bytes to read. </param>
        /// <returns>The total number of bytes read into the buffer. This might be less than the number of bytes requested if that number of bytes are not currently available, or zero if the end of the stream is reached. </returns>
        public override int Read(byte[] buffer, int offset, int count)
        {
            return _underlyingObject.Read(buffer, offset, count);
        }

        /// <summary>
        /// Reads a byte from the file and advances the read position one byte. 
        /// </summary>
        /// <returns>The byte, cast to an Int32, or -1 if the end of the stream has been reached.</returns>
        public override int ReadByte()
        {
            return _underlyingObject.ReadByte();
        }

        /// <summary>
        /// Sets the current position of this stream to the given value. 
        /// </summary>
        /// <param name="offset">The point relative to origin from which to begin seeking.</param>
        /// <param name="origin">Specifies the beginning, the end, or the current position as a reference point for origin, using a value of type SeekOrigin. </param>
        /// <returns>The new position in the stream.</returns>
        public override long Seek(long offset, SeekOrigin origin)
        {
            return _underlyingObject.Seek(offset, origin);
        }

        //[SecuritySafeCritical]

        public override void SetAccessControl(IFileSecurity fileSecurity)
        {
            _underlyingObject.SetAccessControl(fileSecurity.FileSecurityInstance);
        }

        /// <summary>
        /// Sets the length of this stream to the given value.
        /// </summary>
        /// <param name="value">The new length of the stream.</param>
        public override void SetLength(long value)
        {
            _underlyingObject.SetLength(value);
        }



        public override string ToString()
        {

            return _underlyingObject.ToString();
        }


        //[SecuritySafeCritical]

        public override void Unlock(long position, long length)
        {
            _underlyingObject.Unlock(position, length);
        }

        /// <summary>
        /// Writes a block of bytes to this stream using data from a buffer.
        /// </summary>
        /// <param name="buffer">The buffer containing data to write to the stream.</param>
        /// <param name="offset">The zero-based byte offset in array at which to begin copying bytes to the current stream.</param>
        /// <param name="count">The number of bytes to be written to the current stream.</param>
        public override void Write(byte[] buffer, int offset, int count)
        {
            _underlyingObject.Write(buffer, offset, count);
        }

        /// <summary>
        /// Writes a byte to the current position in the file stream.
        /// </summary>
        /// <param name="value">A byte to write to the stream.</param>
        public override void WriteByte(byte value)
        {
            _underlyingObject.WriteByte(value);
        }


        protected override void Dispose(bool disposing)
        {
             _underlyingObject.Dispose();
        }

    }
}