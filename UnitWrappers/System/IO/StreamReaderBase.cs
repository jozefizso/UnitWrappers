using System.IO;
using System.Text;

namespace UnitWrappers.System.IO
{
    public abstract class StreamReaderBase:TextReader, IStreamReader
    {
        public abstract Stream BaseStream { get; }
        public abstract Encoding CurrentEncoding { get; }
        public abstract bool EndOfStream { get; }
        public abstract void DiscardBufferedData();
    }
}