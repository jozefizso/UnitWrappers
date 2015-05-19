using System;
using System.IO;
using System.Text;

namespace UnitWrappers.System.IO
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// <see cref="TextWriter"/> does not provides virtual <see cref="IDisposable.Dispose"/>
    /// </remarks>
    public interface ITextWriter : IDisposable
    {
        /// <summary>
        /// Gets an object that controls formatting.
        /// </summary>
        /// 
        /// <returns>
        /// An <see cref="T:System.IFormatProvider"/> object for a specific culture, or the formatting of the current culture if no other culture is specified.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        IFormatProvider FormatProvider { get; }

        /// <summary>
        /// When overridden in a derived class, returns the <see cref="T:System.Text.Encoding"/> in which the output is written.
        /// </summary>
        /// 
        /// <returns>
        /// The Encoding in which the output is written.
        /// </returns>
        /// <filterpriority>1</filterpriority>
        Encoding Encoding { get; }

        /// <summary>
        /// Gets or sets the line terminator string used by the current TextWriter.
        /// </summary>
        /// 
        /// <returns>
        /// The line terminator string for the current TextWriter.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        string NewLine { get; set; }

        /// <summary>
        /// Closes the current writer and releases any system resources associated with the writer.
        /// </summary>
        /// <filterpriority>1</filterpriority>
        void Close();


        /// <summary>
        /// Clears all buffers for the current writer and causes any buffered data to be written to the underlying device.
        /// </summary>
        /// <filterpriority>1</filterpriority>
        void Flush();

        /// <summary>
        /// Writes a character to the text stream.
        /// </summary>
        /// <param name="value">The character to write to the text stream. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        void Write(char value);

        /// <summary>
        /// Writes a character array to the text stream.
        /// </summary>
        /// <param name="buffer">The character array to write to the text stream. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        void Write(char[] buffer);


        /// <summary>
        /// Writes a subarray of characters to the text stream.
        /// </summary>
        /// <param name="buffer">The character array to write data from. </param><param name="index">Starting index in the buffer. </param><param name="count">The number of characters to write. </param><exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index"/> is less than <paramref name="count"/>. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="buffer"/> parameter is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index"/> or <paramref name="count"/> is negative. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        void Write(char[] buffer, int index, int count);

        /// <summary>
        /// Writes the text representation of a Boolean value to the text stream.
        /// </summary>
        /// <param name="value">The Boolean to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        void Write(bool value);


        /// <summary>
        /// Writes the text representation of a 4-byte signed integer to the text stream.
        /// </summary>
        /// <param name="value">The 4-byte signed integer to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        void Write(int value);



        /// <summary>
        /// Writes the text representation of an 8-byte signed integer to the text stream.
        /// </summary>
        /// <param name="value">The 8-byte signed integer to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        void Write(long value);

#if !PORTABLE
        /// <summary>
        /// Writes the text representation of a 4-byte unsigned integer to the text stream.
        /// </summary>
        /// <param name="value">The 4-byte unsigned integer to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        void Write(uint value);

        /// <summary>
        /// Writes the text representation of an 8-byte unsigned integer to the text stream.
        /// </summary>
        /// <param name="value">The 8-byte unsigned integer to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        void Write(ulong value);

        /// <summary>
        /// Writes the text representation of a 4-byte unsigned integer followed by a line terminator to the text stream.
        /// </summary>
        /// <param name="value">The 4-byte unsigned integer to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        void WriteLine(uint value);

        /// <summary>
        /// Writes the text representation of an 8-byte unsigned integer followed by a line terminator to the text stream.
        /// </summary>
        /// <param name="value">The 8-byte unsigned integer to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        void WriteLine(ulong value);
#endif
        void WriteLine(decimal value);

        void WriteLine(double value);

        void WriteLine(float value);

        /// <summary>
        /// Writes the text representation of a 4-byte floating-point value to the text stream.
        /// </summary>
        /// <param name="value">The 4-byte floating-point value to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        void Write(float value);

        /// <summary>
        /// Writes the text representation of an 8-byte floating-point value to the text stream.
        /// </summary>
        /// <param name="value">The 8-byte floating-point value to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        void Write(double value);

        /// <summary>
        /// Writes the text representation of a decimal value to the text stream.
        /// </summary>
        /// <param name="value">The decimal value to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        void Write(Decimal value);


        /// <summary>
        /// Writes a string to the text stream.
        /// </summary>
        /// <param name="value">The string to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        void Write(string value);

        /// <summary>
        /// Writes the text representation of an object to the text stream by calling ToString on that object.
        /// </summary>
        /// <param name="value">The object to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        void Write(object value);

        /// <summary>
        /// Writes out a formatted string, using the same semantics as <see cref="M:System.String.Format(System.String,System.Object)"/>.
        /// </summary>
        /// <param name="format">The formatting string. </param><param name="arg0">An object to write into the formatted string. </param><exception cref="T:System.ArgumentNullException"><paramref name="format"/> is null. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.FormatException">The format specification in format is invalid.-or- The number indicating an argument to be formatted is less than zero, or larger than or equal to the number of provided objects to be formatted. </exception><filterpriority>1</filterpriority>
        void Write(string format, object arg0);

        /// <summary>
        /// Writes out a formatted string, using the same semantics as <see cref="M:System.String.Format(System.String,System.Object)"/>.
        /// </summary>
        /// <param name="format">The formatting string. </param><param name="arg0">An object to write into the formatted string. </param><param name="arg1">An object to write into the formatted string. </param><exception cref="T:System.ArgumentNullException"><paramref name="format"/> is null. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.FormatException">The format specification in format is invalid.-or- The number indicating an argument to be formatted is less than zero, or larger than or equal to the number of provided objects to be formatted. </exception><filterpriority>1</filterpriority>
        void Write(string format, object arg0, object arg1);

        /// <summary>
        /// Writes out a formatted string, using the same semantics as <see cref="M:System.String.Format(System.String,System.Object)"/>.
        /// </summary>
        /// <param name="format">The formatting string. </param><param name="arg0">An object to write into the formatted string. </param><param name="arg1">An object to write into the formatted string. </param><param name="arg2">An object to write into the formatted string. </param><exception cref="T:System.ArgumentNullException"><paramref name="format"/> is null. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.FormatException">The format specification in format is invalid.-or- The number indicating an argument to be formatted is less than zero, or larger than or equal to the number of provided objects to be formatted. </exception><filterpriority>1</filterpriority>
        void Write(string format, object arg0, object arg1, object arg2);

        /// <summary>
        /// Writes out a formatted string, using the same semantics as <see cref="M:System.String.Format(System.String,System.Object)"/>.
        /// </summary>
        /// <param name="format">The formatting string. </param><param name="arg">The object array to write into the formatted string. </param><exception cref="T:System.ArgumentNullException"><paramref name="format"/> or <paramref name="arg"/> is null. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.FormatException">The format specification in format is invalid.-or- The number indicating an argument to be formatted is less than zero, or larger than or equal to <paramref name="arg"/>. Length. </exception><filterpriority>1</filterpriority>
        void Write(string format, params object[] arg);

        /// <summary>
        /// Writes a line terminator to the text stream.
        /// </summary>
        /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        void WriteLine();

        /// <summary>
        /// Writes a character followed by a line terminator to the text stream.
        /// </summary>
        /// <param name="value">The character to write to the text stream. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        void WriteLine(char value);

        /// <summary>
        /// Writes an array of characters followed by a line terminator to the text stream.
        /// </summary>
        /// <param name="buffer">The character array from which data is read. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        void WriteLine(char[] buffer);

        /// <summary>
        /// Writes a subarray of characters followed by a line terminator to the text stream.
        /// </summary>
        /// <param name="buffer">The character array from which data is read. </param><param name="index">The index into <paramref name="buffer"/> at which to begin reading. </param><param name="count">The maximum number of characters to write. </param><exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index"/> is less than <paramref name="count"/>. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="buffer"/> parameter is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index"/> or <paramref name="count"/> is negative. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        void WriteLine(char[] buffer, int index, int count);

        /// <summary>
        /// Writes the text representation of a Boolean followed by a line terminator to the text stream.
        /// </summary>
        /// <param name="value">The Boolean to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        void WriteLine(bool value);

        /// <summary>
        /// Writes the text representation of a 4-byte signed integer followed by a line terminator to the text stream.
        /// </summary>
        /// <param name="value">The 4-byte signed integer to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        void WriteLine(int value);

        /// <summary>
        /// Writes the text representation of an 8-byte signed integer followed by a line terminator to the text stream.
        /// </summary>
        /// <param name="value">The 8-byte signed integer to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        void WriteLine(long value);

        /// <summary>
        /// Writes a string followed by a line terminator to the text stream.
        /// </summary>
        /// <param name="value">The string to write. If <paramref name="value"/> is null, only the line termination characters are written. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        //[SecuritySafeCritical]
        void WriteLine(string value);

        /// <summary>
        /// Writes the text representation of an object by calling ToString on this object, followed by a line terminator to the text stream.
        /// </summary>
        /// <param name="value">The object to write. If <paramref name="value"/> is null, only the line termination characters are written. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        void WriteLine(object value);

        /// <summary>
        /// Writes out a formatted string and a new line, using the same semantics as <see cref="M:System.String.Format(System.String,System.Object)"/>.
        /// </summary>
        /// <param name="format">The formatted string. </param><param name="arg0">The object to write into the formatted string. </param><exception cref="T:System.ArgumentNullException"><paramref name="format"/> is null. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.FormatException">The format specification in format is invalid.-or- The number indicating an argument to be formatted is less than zero, or larger than or equal to the number of provided objects to be formatted. </exception><filterpriority>1</filterpriority>
        void WriteLine(string format, object arg0);

        /// <summary>
        /// Writes out a formatted string and a new line, using the same semantics as <see cref="M:System.String.Format(System.String,System.Object)"/>.
        /// </summary>
        /// <param name="format">The formatting string. </param><param name="arg0">The object to write into the format string. </param><param name="arg1">The object to write into the format string. </param><exception cref="T:System.ArgumentNullException"><paramref name="format"/> is null. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.FormatException">The format specification in format is invalid.-or- The number indicating an argument to be formatted is less than zero, or larger than or equal to the number of provided objects to be formatted. </exception><filterpriority>1</filterpriority>
        void WriteLine(string format, object arg0, object arg1);

        /// <summary>
        /// Writes out a formatted string and a new line, using the same semantics as <see cref="M:System.String.Format(System.String,System.Object)"/>.
        /// </summary>
        /// <param name="format">The formatting string. </param><param name="arg0">The object to write into the format string. </param><param name="arg1">The object to write into the format string. </param><param name="arg2">The object to write into the format string. </param><exception cref="T:System.ArgumentNullException"><paramref name="format"/> is null. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.FormatException">The format specification in format is invalid.-or- The number indicating an argument to be formatted is less than zero, or larger than or equal to the number of provided objects to be formatted. </exception><filterpriority>1</filterpriority>
        void WriteLine(string format, object arg0, object arg1, object arg2);

        /// <summary>
        /// Writes out a formatted string and a new line, using the same semantics as <see cref="M:System.String.Format(System.String,System.Object)"/>.
        /// </summary>
        /// <param name="format">The formatting string. </param><param name="arg">The object array to write into format string. </param><exception cref="T:System.ArgumentNullException">A string or object is passed in as null. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"/> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.FormatException">The format specification in format is invalid.-or- The number indicating an argument to be formatted is less than zero, or larger than or equal to arg.Length. </exception><filterpriority>1</filterpriority>
        void WriteLine(string format, params object[] arg);

    }
}