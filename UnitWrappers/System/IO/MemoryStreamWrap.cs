using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace UnitWrappers.System.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.MemoryStream"/> class.
    /// </summary>
    public class MemoryStreamWrap : MemoryStream, IMemoryStream, IWrap<MemoryStream>
    {
        private MemoryStream _underlyingObject;

        MemoryStream IWrap<MemoryStream>.UnderlyingObject { get { return _underlyingObject; } }

        /// <summary>
        /// Initializes a new instance of the MemoryStreamWrap class with an expandable capacity initialized to zero. 
        /// </summary>
        public MemoryStreamWrap()
        {
            _underlyingObject = new MemoryStream();
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.MemoryStreamWrap"/> class on the specified path. 
        /// </summary>
        /// <param name="memoryStream">A <see cref="T:System.IO.MemoryStream"/> object.</param>
        public MemoryStreamWrap(MemoryStream memoryStream)
        {
            _underlyingObject = memoryStream;
        }

        /// <summary>
        /// Initializes a new non-resizable instance of the MemoryStreamWrap class based on the specified byte array. 
        /// </summary>
        /// <param name="buffer">The array of unsigned bytes from which to create the current stream. </param>
        public MemoryStreamWrap(byte[] buffer)
        {
            _underlyingObject = new MemoryStream(buffer);
        }


        /// <summary>
        /// Initializes a new instance of the MemoryStreamWrap class with an expandable capacity initialized as specified. 
        /// </summary>
        /// <param name="capacity"></param>
        public MemoryStreamWrap(int capacity)
        {
            _underlyingObject = new MemoryStream(capacity);
        }


        /// <summary>
        /// Initializes a new non-resizable instance of the MemoryStreamWrap class based on the specified byte array with the CanWrite property set as specified. 
        /// </summary>
        /// <param name="buffer">The array of unsigned bytes from which to create this stream. </param>
        /// <param name="writable">The setting of the CanWrite property, which determines whether the stream supports writing. </param>
        public MemoryStreamWrap(byte[] buffer, bool writable)
        {
            _underlyingObject = new MemoryStream(buffer, writable);
        }



        /// <summary>
        /// Initializes a new non-resizable instance of the MemoryStreamWrap class based on the specified region (index) of a byte array. 
        /// </summary>
        /// <param name="buffer">The array of unsigned bytes from which to create this stream. </param>
        /// <param name="index">The index into buffer at which the stream begins.</param>
        /// <param name="count">The length of the stream in bytes. </param>
        public MemoryStreamWrap(byte[] buffer, int index, int count)
        {
            _underlyingObject = new MemoryStream(buffer, index, count);
        }



        /// <summary>
        /// Initializes a new non-resizable instance of the MemoryStreamWrap class based on the specified region of a byte array, with the CanWrite property set as specified. 
        /// </summary>
        /// <param name="buffer">The array of unsigned bytes from which to create this stream. </param>
        /// <param name="index">The index into buffer at which the stream begins.</param>
        /// <param name="count">The length of the stream in bytes. </param>
        /// <param name="writable">The setting of the CanWrite property, which determines whether the stream supports writing. </param>
        public MemoryStreamWrap(byte[] buffer, int index, int count, bool writable)
        {
            _underlyingObject = new MemoryStream(buffer, index, count, writable);
        }


        /// <summary>
        /// Initializes a new instance of the MemoryStreamWrap class based on the specified region of a byte array, with the CanWrite property set as specified, and the ability to call GetBuffer set as specified. 
        /// </summary>
        /// <param name="buffer">The array of unsigned bytes from which to create this stream. </param>
        /// <param name="index">The index into buffer at which the stream begins.</param>
        /// <param name="count">The length of the stream in bytes.</param>
        /// <param name="writable">The setting of the CanWrite property, which determines whether the stream supports writing. </param>
        /// <param name="publiclyVisible"> true to enable GetBuffer, which returns the unsigned byte array from which the stream was created; otherwise, false. </param>
        public MemoryStreamWrap(byte[] buffer, int index, int count, bool writable, bool publiclyVisible)
        {
            _underlyingObject = new MemoryStream(buffer, index, count, writable, publiclyVisible);
        }

        /// <summary>
        /// Gets a value indicating whether the current stream supports reading.
        /// </summary>
        public bool CanRead
        {
            get { return _underlyingObject.CanRead; }
        }

        /// <summary>
        /// Gets a value indicating whether the current stream supports seeking.
        /// </summary>
        public bool CanSeek
        {
            get { return _underlyingObject.CanSeek; }
        }

        [ComVisible(false)]
        public bool CanTimeout
        {
            get { return _underlyingObject.CanTimeout; }
        }

        /// <summary>
        /// Gets a value indicating whether the current stream supports writing. 
        /// </summary>
        public bool CanWrite
        {
            get { return _underlyingObject.CanWrite; }
        }

        public int Capacity
        {
            get { return _underlyingObject.Capacity; }
            set { _underlyingObject.Capacity = value; }
        }

        /// <summary>
        /// Gets the length of the stream in bytes.
        /// </summary>
        public long Length
        {
            get { return _underlyingObject.Length; }
        }


        /// <summary>
        /// Gets or sets the current position within the stream. 
        /// </summary>
        public long Position
        {
            get { return _underlyingObject.Position; }
            set { _underlyingObject.Position = value; }
        }

        [ComVisible(false)]
        public int ReadTimeout
        {
            get { return _underlyingObject.ReadTimeout; }
            set { _underlyingObject.ReadTimeout = value; }
        }

        public Stream StreamInstance { get { return _underlyingObject; } }

        [ComVisible(false)]
        public int WriteTimeout
        {
            get { return _underlyingObject.WriteTimeout; }
            set { _underlyingObject.WriteTimeout = value; }
        }

        [HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        public IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
        {
            return _underlyingObject.BeginRead(buffer, offset, count, callback, state);
        }

        [HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        public IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
        {
            return _underlyingObject.BeginWrite(buffer, offset, count, callback, state);
        }

        public virtual void Close()
        {
            _underlyingObject.Close();
        }

        public int EndRead(IAsyncResult asyncResult)
        {
            return _underlyingObject.EndRead(asyncResult);
        }

        public void EndWrite(IAsyncResult asyncResult)
        {
            _underlyingObject.EndWrite(asyncResult);
        }

        /// <summary>
        /// Overrides Stream.Flush so that no action is performed. 
        /// </summary>
        public void Flush()
        {
            _underlyingObject.Flush();
        }

        /// <summary>
        /// Reads a block of bytes from the current stream and writes the data to buffer. 
        /// </summary>
        /// <param name="buffer">When this method returns, contains the specified byte array with the values between offset and (offset + count - 1) replaced by the characters read from the current stream. </param>
        /// <param name="offset">The byte offset in buffer at which to begin reading.</param>
        /// <param name="count">The maximum number of bytes to read. </param>
        /// <returns>The total number of bytes written into the buffer. This can be less than the number of bytes requested if that number of bytes are not currently available, or zero if the end of the stream is reached before any bytes are read. </returns>
        public int Read(byte[] buffer, int offset, int count)
        {
            return _underlyingObject.Read(buffer, offset, count);
        }

        /// <summary>
        /// Reads a byte from the current stream. 
        /// </summary>
        /// <returns>The byte cast to a Int32, or -1 if the end of the stream has been reached.</returns>
        public int ReadByte()
        {
            return _underlyingObject.ReadByte();
        }

        /// <summary>
        /// Sets the position within the current stream to the specified value. 
        /// </summary>
        /// <param name="offset">The new position within the stream. This is relative to the loc parameter, and can be positive or negative. </param>
        /// <param name="origin">A value of type SeekOrigin, which acts as the seek reference point. </param>
        /// <returns>The new position within the stream, calculated by combining the initial reference point and the offset.</returns>
        public long Seek(long offset, SeekOrigin origin)
        {
            return _underlyingObject.Seek(offset, origin);
        }

        /// <summary>
        /// Sets the length of the current stream to the specified value. 
        /// </summary>
        /// <param name="value">The value at which to set the length.</param>
        public void SetLength(long value)
        {
            _underlyingObject.SetLength(value);
        }



        /// <summary>
        /// Writes a block of bytes to the current stream using data read from buffer. 
        /// </summary>
        /// <param name="buffer">The buffer to write data from. </param>
        /// <param name="offset">The byte offset in buffer at which to begin writing from. </param>
        /// <param name="count">The maximum number of bytes to write. </param>
        public void Write(byte[] buffer, int offset, int count)
        {
            _underlyingObject.Write(buffer, offset, count);
        }

        /// <summary>
        /// Writes a byte to the current stream at the current position. 
        /// </summary>
        /// <param name="value">The byte to write. </param>
        public void WriteByte(byte value)
        {
            _underlyingObject.WriteByte(value);
        }

        public byte[] GetBuffer()
        {
            return _underlyingObject.GetBuffer();
        }

        public byte[] ToArray()
        {
            return _underlyingObject.ToArray();
        }



        public void Dispose()
        {
            _underlyingObject.Dispose();
        }


    }
}
