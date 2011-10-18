using System;
using System.IO.Compression;

namespace SystemWrapper.IO.Compression
{
	/// <summary>
	/// Description of IDeflateStream.
	/// </summary>
	public interface IDeflateStream
	{
		void Initialize(IStream stream, CompressionMode mode);

		int Read( byte[] array, int offset, int count );
		void Write( byte[] array, int offset, int count );
		void Flush();
		void Close();
		DeflateStream DeflateStreamInstance{ get; }
		//TODO
	}
}
