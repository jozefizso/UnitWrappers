using System.IO;
using System.Text;

namespace UnitWrappers.System.IO
{
    public abstract class StreamReaderBase:IStreamReader
    {
        public abstract Stream BaseStream { get; }
        public abstract Encoding CurrentEncoding { get; }
        public abstract bool EndOfStream { get; }
        public abstract void DiscardBufferedData();
        public abstract void Dispose();
        public abstract void Close();
        public abstract int Peek();
        public abstract int Read();
        public abstract int Read(char[] buffer, int index, int count);
        public abstract int ReadBlock(char[] buffer, int index, int count);
        public abstract string ReadLine();
        public abstract string ReadToEnd();
    }
}