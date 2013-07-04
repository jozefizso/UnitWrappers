using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;

namespace UnitWrappers.System.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.StreamWriter"/> class.
    /// </summary>
    [Serializable]
#if !PORTABLE
    [ComVisible(true)]
#endif
    public class StreamWriterWrap : StreamWriterBase, IWrap<StreamWriter>
    {
        public StreamWriter _underlyingObject;

        StreamWriter IWrap<StreamWriter>.UnderlyingObject
        {
            get { return _underlyingObject; }
        }



        public static implicit operator StreamWriterWrap(StreamWriter o)
        {
            return new StreamWriterWrap(o);
        }

        public static implicit operator StreamWriter(StreamWriterWrap o)
        {
            return o._underlyingObject;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.StreamWriterWrap"/> class on the specified path. 
        /// </summary>
        /// <param name="streamWriter">A <see cref="T:System.IO.StreamWriter"/> object.</param>
        public StreamWriterWrap(StreamWriter streamWriter)
        {
            _underlyingObject = streamWriter;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.StreamWriterWrap"/> class for the specified stream, using UTF-8 encoding and the default buffer size.
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        public StreamWriterWrap(Stream stream)
        {
            _underlyingObject = new StreamWriter(stream);
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.StreamWriterWrap"/> class for the specified stream, using UTF-8 encoding and the default buffer size.
        /// </summary>
        /// <param name="path">The complete file path to write to. path can be a file name.</param>
        public StreamWriterWrap(string path)
        {
            _underlyingObject = new StreamWriter(path);
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.StreamWriterWrap"/> class for the specified stream, using the specified encoding and the default buffer size. 
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        /// <param name="encoding">The character encoding to use.</param>
        public StreamWriterWrap(Stream stream, Encoding encoding)
        {
            _underlyingObject = new StreamWriter(stream, encoding);
        }


        /// <summary>
        /// Initializes a new instance of the StreamWriter class for the specified file on the specified path, using the default encoding and buffer size. If the file exists, it can be either overwritten or appended to. If the file does not exist, this constructor creates a new file.
        /// </summary>
        /// <param name="path">The complete file path to write to.</param>
        /// <param name="append">Determines whether data is to be appended to the file. If the file exists and append is false, the file is overwritten. If the file exists and append is true, the data is appended to the file. Otherwise, a new file is created.</param>
        public StreamWriterWrap(string path, bool append)
        {
            _underlyingObject = new StreamWriter(path, append);
        }


        /// <summary>
        /// Initializes a new instance of the StreamWriter class for the specified stream, using the specified encoding and buffer size. 
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        /// <param name="encoding">The character encoding to use.</param>
        /// <param name="bufferSize">Sets the buffer size.</param>
        public StreamWriterWrap(Stream stream, Encoding encoding, int bufferSize)
        {
            _underlyingObject = new StreamWriter(stream, encoding, bufferSize);
        }



        /// <summary>
        /// Initializes a new instance of the StreamWriter class for the specified file on the specified path, using the specified encoding and default buffer size. If the file exists, it can be either overwritten or appended to. If the file does not exist, this constructor creates a new file.
        /// </summary>
        /// <param name="path">The complete file path to write to.</param>
        /// <param name="append">Determines whether data is to be appended to the file. If the file exists and append is false, the file is overwritten. If the file exists and append is true, the data is appended to the file. Otherwise, a new file is created.</param>
        /// <param name="encoding">The character encoding to use.</param>
        public StreamWriterWrap(string path, bool append, Encoding encoding)
        {
            _underlyingObject = new StreamWriter(path, append, encoding);
        }



        /// <summary>
        /// Initializes a new instance of the StreamWriter class for the specified file on the specified path, using the specified encoding and buffer size. If the file exists, it can be either overwritten or appended to. If the file does not exist, this constructor creates a new file.
        /// </summary>
        /// <param name="path">The complete file path to write to.</param>
        /// <param name="append">Determines whether data is to be appended to the file. If the file exists and append is false, the file is overwritten. If the file exists and append is true, the data is appended to the file. Otherwise, a new file is created.</param>
        /// <param name="encoding">The character encoding to use.</param>
        /// <param name="bufferSize">Sets the buffer size.</param>
        public StreamWriterWrap(string path, bool append, Encoding encoding, int bufferSize)
        {
            _underlyingObject = new StreamWriter(path, append, encoding, bufferSize);
        }

        public override bool AutoFlush
        {
            get { return _underlyingObject.AutoFlush; }
            set { _underlyingObject.AutoFlush = value; }
        }

        public override Stream BaseStream
        {
            get { return _underlyingObject.BaseStream; }
        }

        public override void Dispose()
        {
            _underlyingObject.Dispose();
        }

        public override IFormatProvider FormatProvider
        {
            get { return _underlyingObject.FormatProvider; }
        }

        public override string NewLine
        {
            get { return _underlyingObject.NewLine; }
            set { _underlyingObject.NewLine = value; }
        }

        public override Encoding Encoding
        {
            get { return _underlyingObject.Encoding; }
        }


        public override void Close()
        {
            _underlyingObject.Close();
        }

        public override ObjRef CreateObjRef(Type requestedType)
        {
            return _underlyingObject.CreateObjRef(requestedType);
        }

        public override void Flush()
        {
            _underlyingObject.Flush();
        }

        public override void Write(char value)
        {
            _underlyingObject.Write(value);
        }

        public override void Write(char[] buffer)
        {
            _underlyingObject.Write(buffer);
        }

        public override void Write(decimal value)
        {
            _underlyingObject.Write(value);
        }

        public override void Write(ulong value)
        {
            _underlyingObject.Write(value);
        }

        public override void Write(string format, object arg0)
        {
            _underlyingObject.Write(format, arg0);
        }

        public override void Write(string format, object arg0, object arg1)
        {
            _underlyingObject.Write(format, arg0, arg1);
        }

        public override void Write(string format, object arg0, object arg1, object arg2)
        {
            _underlyingObject.Write(format, arg0, arg1, arg2);
        }

        public override void Write(string format, object[] arg)
        {
            _underlyingObject.Write(format, arg);
        }

        public override void Write(float value)
        {
            _underlyingObject.Write(value);
        }

        public override void Write(uint value)
        {
            _underlyingObject.Write(value);
        }

        public override void Write(double value)
        {
            _underlyingObject.Write(value);
        }

        public override void Write(int value)
        {
            _underlyingObject.Write(value);
        }

        public override void Write(long value)
        {
            _underlyingObject.Write(value);
        }

        public override void Write(object value)
        {
            _underlyingObject.Write(value);
        }

        public override void Write(string value)
        {
            _underlyingObject.Write(value);
        }

        public override void Write(bool value)
        {
            _underlyingObject.Write(value);
        }

        public override void Write(char[] buffer, int index, int count)
        {
            _underlyingObject.Write(buffer, index, count);
        }

        public override void WriteLine()
        {
            _underlyingObject.WriteLine();
        }

        public override void WriteLine(char value)
        {
            _underlyingObject.WriteLine(value);
        }

        public override void WriteLine(char[] buffer, int index, int count)
        {
            _underlyingObject.WriteLine(buffer,index,count);
        }

        public override void WriteLine(bool value)
        {
            _underlyingObject.WriteLine(value);
        }

        public override void WriteLine(string value)
        {
            _underlyingObject.WriteLine(value);
        }

        public override void WriteLine(string format, object arg0)
        {
            _underlyingObject.WriteLine(format, arg0);
        }

        public override void WriteLine(char[] buffer)
        {
            _underlyingObject.WriteLine(buffer);
        }

        public override void WriteLine(decimal value)
        {
            _underlyingObject.WriteLine(value);
        }

        public override void WriteLine(double value)
        {
            _underlyingObject.WriteLine(value);
        }

        public override void WriteLine(float value)
        {
            _underlyingObject.WriteLine(value);
        }

        public override void WriteLine(int value)
        {
            _underlyingObject.WriteLine(value);
        }

        public override void WriteLine(long value)
        {
            _underlyingObject.WriteLine(value);
        }

        public override void WriteLine(object value)
        {
            _underlyingObject.WriteLine(value);
        }

        public override void WriteLine(string format, object arg0, object arg1)
        {
            _underlyingObject.WriteLine(format, arg0, arg1);
        }

        public override void WriteLine(string format, object arg0, object arg1, object arg2)
        {
            _underlyingObject.WriteLine(format, arg0, arg1, arg2);
        }

        public override void WriteLine(string format, params object[] arg)
        {
            _underlyingObject.WriteLine(format, arg);
        }


        public override void WriteLine(uint value)
        {
            _underlyingObject.WriteLine(value);
        }

        public override void WriteLine(ulong value)
        {
            _underlyingObject.WriteLine(value);
        }

        public override string ToString()
        {
            return _underlyingObject.ToString();
        }

      

        public override object InitializeLifetimeService()
        {
            return _underlyingObject.InitializeLifetimeService();
        }
    }
}