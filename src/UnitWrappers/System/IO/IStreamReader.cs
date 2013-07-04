using System.IO;
using System.Text;

namespace UnitWrappers.System.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.StreamReader"/> class.
    /// </summary>
    public interface IStreamReader : ITextReader
    {
        /// <summary>
        /// Returns the underlying stream. 
        /// </summary>
        /// <value>The underlying stream.</value>
        Stream BaseStream { get; }
        /// <summary>
        /// Gets the current character encoding that the current IStreamReader object is using. 
        /// </summary>
        /// <value>The current character encoding used by the current reader. The value can be different after the first call to any Read method of IStreamReader, since encoding autodetection is not done until the first call to a Read method. </value>
        Encoding CurrentEncoding { get; }
        /// <summary>
        /// Gets a value that indicates whether the current stream position is at the end of the stream. 
        /// </summary>
        /// <value> true if the current stream position is at the end of the stream; otherwise false. </value>
        bool EndOfStream { get; }

        /// <summary>
        /// Allows a IStreamReader object to discard its current data. 
        /// </summary>
        void DiscardBufferedData();
    }
}