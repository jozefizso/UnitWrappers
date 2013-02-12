using System.IO;
using System.IO.Compression;

namespace UnitWrappers.System.IO.Compression
{
	/// <summary>
	/// Description of DeflateStreamWrap.
	/// </summary>
	public class DeflateStreamWrap : Stream,IDeflateStream
	{

		public DeflateStreamWrap(Stream stream, CompressionMode mode)
		{
            DeflateStreamInstance = new DeflateStream(stream, mode);
		}

	    public override long Seek(long offset, SeekOrigin origin)
	    {
	     return   DeflateStreamInstance.Seek(offset, origin);
	    }

	    public override void SetLength(long value)
	    {
	        throw new global::System.NotImplementedException();
	    }

	    public override int Read(byte[] array, int offset, int count)
		{
			return DeflateStreamInstance.Read( array, offset, count );
		}
        public override void Write(byte[] array, int offset, int count)
		{
			DeflateStreamInstance.Write( array, offset, count );
		}

	    public override bool CanRead
	    {
	        get { throw new global::System.NotImplementedException(); }
	    }

	    public override bool CanSeek
	    {
	        get { throw new global::System.NotImplementedException(); }
	    }

	    public override bool CanWrite
	    {
	        get { throw new global::System.NotImplementedException(); }
	    }

	    public override long Length
	    {
	        get { throw new global::System.NotImplementedException(); }
	    }

	    public override long Position { get; set; }

	    public override void Flush()
		{
			DeflateStreamInstance.Flush();
		}
        public override void Close()
		{
			DeflateStreamInstance.Close();
		}
		
		public DeflateStream DeflateStreamInstance{ get; private set; }
	}
}
