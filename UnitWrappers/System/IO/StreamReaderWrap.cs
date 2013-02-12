using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace UnitWrappers.System.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.StreamReader"/> class.
    /// </summary>
    [Serializable]
    [ComVisible(true)]
    public class StreamReaderWrap : StreamReaderBase, IWrap<StreamReader>
    {

        private StreamReader _underlyingObject;

        public static implicit operator StreamReaderWrap(StreamReader o)
        {
            return new StreamReaderWrap(o);
        }

        public static implicit operator StreamReader(StreamReaderWrap o)
        {
            return o._underlyingObject;
        }

        StreamReader IWrap<StreamReader>.UnderlyingObject
        {
            get { return _underlyingObject; }
        }

		/// <summary>
		/// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.StreamReaderWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="streamReader">A <see cref="T:System.IO.StreamReader"/> object.</param>
		public StreamReaderWrap(StreamReader streamReader)
		{
            _underlyingObject = streamReader;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.IO.StreamReader"/> class for the specified stream.
		/// </summary>
		/// <param name="stream">The stream to write to.</param>
		public StreamReaderWrap(Stream stream)
		{
            _underlyingObject = new StreamReader(stream);
		}



		/// <summary>
		/// Initializes a new instance of the StreamReader class for the specified file name.
		/// </summary>
		/// <param name="path">The complete file path to be read.</param>
		public StreamReaderWrap(string path)
		{
            _underlyingObject = new StreamReader(path);
		}

		/// <summary>
		/// Initializes a new instance of the StreamReader class for the specified stream, with the specified byte order mark detection option.
		/// </summary>
		/// <param name="stream">The stream to be read. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file.</param>
		public StreamReaderWrap(Stream stream, bool detectEncodingFromByteOrderMarks)
		{
            _underlyingObject = new StreamReader(stream, detectEncodingFromByteOrderMarks);
		}

		/// <summary>
		/// Initializes a new instance of the StreamReader class for the specified stream, with the specified character encoding.
		/// </summary>
		/// <param name="stream">The stream to be read.</param>
		/// <param name="encoding">The character encoding to use.</param>
		public StreamReaderWrap(Stream stream, Encoding encoding)
		{
            _underlyingObject = new StreamReader(stream, encoding);
		}

		/// <summary>
		/// Initializes a new instance of the StreamReader class for the specified file name, with the specified byte order mark detection option.
		/// </summary>
		/// <param name="path">The complete file path to be read. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file.</param>
		public StreamReaderWrap(string path, bool detectEncodingFromByteOrderMarks)
		{
            _underlyingObject = new StreamReader(path, detectEncodingFromByteOrderMarks);
		}

		/// <summary>
		/// Initializes a new instance of the StreamReader class for the specified file name, with the specified character encoding.
		/// </summary>
		/// <param name="path">The complete file path to be read.</param>
		/// <param name="encoding">The character encoding to use.</param>
		public StreamReaderWrap(string path, Encoding encoding)
		{
            _underlyingObject = new StreamReader(path, encoding);
		}

		/// <summary>
		/// Initializes a new instance of the StreamReader class for the specified stream, with the specified character encoding and byte order mark detection option.
		/// </summary>
		/// <param name="stream">The stream to be read. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file.</param>
		public StreamReaderWrap(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks)
		{
            _underlyingObject = new StreamReader(stream, encoding, detectEncodingFromByteOrderMarks);
		}

     	/// <summary>
		/// Initializes a new instance of the StreamReader class for the specified file name, with the specified character encoding and byte order mark detection option. 
		/// </summary>
		/// <param name="path">The complete file path to be read.</param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file.</param>
		public StreamReaderWrap(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks)
		{
            _underlyingObject = new StreamReader(path, encoding, detectEncodingFromByteOrderMarks);
		}

		/// <summary>
		/// Initializes a new instance of the StreamReader class for the specified stream, with the specified character encoding and byte order mark detection option, and buffer size.
		/// </summary>
		/// <param name="stream">The stream to be read. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file.</param>
		/// <param name="bufferSize">The minimum buffer size. </param>
		public StreamReaderWrap(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
		{
            _underlyingObject = new StreamReader(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize);
		}

		/// <summary>
		/// Initializes a new instance of the StreamReader class for the specified file name, with the specified character encoding and byte order mark detection option. 
		/// </summary>
		/// <param name="path">The complete file path to be read.</param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file.</param>
		/// <param name="bufferSize">The minimum buffer size, in number of 16-bit characters.</param>
		public StreamReaderWrap(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
		{
            _underlyingObject = new StreamReader(path, encoding, detectEncodingFromByteOrderMarks, bufferSize);
		}

        /// <inheritdoc />
		public override Stream BaseStream
        {
            get { return _underlyingObject.BaseStream; }
        }
        /// <inheritdoc />
        public override Encoding CurrentEncoding
        {
            get { return _underlyingObject.CurrentEncoding; }
        }
        /// <inheritdoc />
        public override bool EndOfStream
        {
            get { return _underlyingObject.EndOfStream; }
        }




        /// <inheritdoc />
        public  override void Close()
        {
            _underlyingObject.Close();
        }
        /// <inheritdoc />
        public override void DiscardBufferedData()
        {
            _underlyingObject.DiscardBufferedData();
        }

        /// <summary>
        /// Returns the next available character but does not consume it. 
        /// </summary>
        /// <returns>An integer representing the next character to be read, or -1 if no more characters are available or the stream does not support seeking.</returns>
        public override int Peek()
        {
            return _underlyingObject.Peek();
        }
        /// <inheritdoc />
        public override int Read()
        {
            return _underlyingObject.Read();
        }

        /// <summary>
        /// Reads a maximum of count characters from the current stream into buffer, beginning at index. 
        /// </summary>
        /// <param name="buffer">When this method returns, contains the specified character array with the values between index and (index + count - 1) replaced by the characters read from the current source.</param>
        /// <param name="index">The index of buffer at which to begin writing.</param>
        /// <param name="count">The maximum number of characters to read. </param>
        /// <returns>The number of characters that have been read, or 0 if at the end of the stream and no data was read. The number will be less than or equal to the count parameter, depending on whether the data is available within the stream.</returns>
        public override int Read(char[] buffer, int index, int count)
        {
            return _underlyingObject.Read(buffer, index, count);
        }
        /// <inheritdoc />
        public override int ReadBlock(char[] buffer, int index, int count)
        {
            return _underlyingObject.ReadBlock(buffer, index, count);
        }
        /// <inheritdoc />
        public override string ReadLine()
        {
            return _underlyingObject.ReadLine();
        }

        /// <summary>
        /// Reads the stream from the current position to the end of the stream.
        /// </summary>
        /// <returns>The rest of the stream as a string, from the current position to the end. If the current position is at the end of the stream, returns the empty string("").</returns>
        public override string ReadToEnd()
        {
            return _underlyingObject.ReadToEnd();
        }
        /// <inheritdoc />
        public new  void Dispose()
        {
            _underlyingObject.Dispose();
        }

  
    }
}