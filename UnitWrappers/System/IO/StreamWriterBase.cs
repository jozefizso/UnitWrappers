using System;
using System.IO;
using System.Runtime.Remoting;
using System.Text;

namespace UnitWrappers.System.IO
{

    /// <summary>
    /// 
    /// </summary>
    public abstract class StreamWriterBase : TextWriter, IStreamWriter
    {
        public abstract bool AutoFlush { get; set; }
        public abstract Stream BaseStream { get; }

        public abstract IFormatProvider FormatProvider { get; }
        public abstract string NewLine { get; set; }
        public abstract void Close();
        public abstract ObjRef CreateObjRef(Type requestedType);
        public abstract void Flush();
        public abstract void Write(char value);
        public abstract void Write(char[] buffer);
        public abstract void Write(string value);
        public abstract void Write(bool value);
        public abstract void Write(decimal value);
        public abstract void Write(double value);
        public abstract void Write(int value);
        public abstract void Write(long value);
        public abstract void Write(object value);
        public abstract void Write(float value);
        public abstract void Write(uint value);
        public abstract void Write(ulong value);
        public abstract void Write(string format, object arg0);
        public abstract void Write(string format, object[] arg);
        public abstract void Write(char[] buffer, int index, int count);
        public abstract void Write(string format, object arg0, object arg1);
        public abstract void Write(string format, object arg0, object arg1, object arg2);

      
    }
}