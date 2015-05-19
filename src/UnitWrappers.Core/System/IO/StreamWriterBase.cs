using System;
using System.IO;
using System.Runtime.Remoting;
using System.Text;

namespace UnitWrappers.System.IO
{

    /// <summary>
    /// 
    /// </summary>
    public abstract class StreamWriterBase : 

        MarshalByRefObject,
        IStreamWriter
    {


        public abstract void Dispose();
        public abstract IFormatProvider FormatProvider { get; }
        public abstract Encoding Encoding { get; }
        public abstract string NewLine { get; set; }
        public abstract void Close();
        public abstract void Flush();
        public abstract void Write(char value);
        public abstract void Write(char[] buffer);
        public abstract void Write(char[] buffer, int index, int count);
        public abstract void Write(bool value);
        public abstract void Write(int value);
        public abstract void Write(long value);
#if !PORTABLE
        public abstract void Write(uint value);
        public abstract void Write(ulong value);
        public abstract void WriteLine(uint value);
        public abstract void WriteLine(ulong value);
#endif
        public abstract void WriteLine(decimal value);
        public abstract void WriteLine(double value);
        public abstract void WriteLine(float value);
        public abstract void Write(float value);
        public abstract void Write(double value);
        public abstract void Write(decimal value);
        public abstract void Write(string value);
        public abstract void Write(object value);
        public abstract void Write(string format, object arg0);
        public abstract void Write(string format, object arg0, object arg1);
        public abstract void Write(string format, object arg0, object arg1, object arg2);
        public abstract void Write(string format, params object[] arg);
        public abstract void WriteLine();
        public abstract void WriteLine(char value);
        public abstract void WriteLine(char[] buffer);
        public abstract void WriteLine(char[] buffer, int index, int count);
        public abstract void WriteLine(bool value);
        public abstract void WriteLine(int value);
        public abstract void WriteLine(long value);
        public abstract void WriteLine(string value);
        public abstract void WriteLine(object value);
        public abstract void WriteLine(string format, object arg0);
        public abstract void WriteLine(string format, object arg0, object arg1);
        public abstract void WriteLine(string format, object arg0, object arg1, object arg2);
        public abstract void WriteLine(string format, params object[] arg);

        public abstract bool AutoFlush { get; set; }
        public abstract Stream BaseStream { get; }
     
    }
}