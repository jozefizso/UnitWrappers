using System.IO.Compression;

namespace UnitWrappers.System.IO.Compression
{
	/// <summary>
	/// Description of IDeflateStream.
	/// </summary>
	public interface IDeflateStream
	{
		int Read( byte[] array, int offset, int count );
		void Write( byte[] array, int offset, int count );
		void Flush();
		void Close();
		DeflateStream DeflateStreamInstance{ get; }
	}
}
