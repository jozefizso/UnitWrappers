using System;
using System.Globalization;

namespace UnitWrappers.System
{
    public interface IDateTimeSystem
    {
        /// <summary>
        /// Gets a DateTime object that is set to the current date and time on this computer, expressed as the local time.
        /// </summary>
        DateTime Now { get; }

        /// <summary>
        /// Gets the current date.
        /// </summary>
        DateTime Today { get; }
        /// <summary>
        /// Gets a DateTime object that is set to the current date and time on this computer, expressed as the Coordinated 
        /// </summary>
        DateTime UtcNow { get; }

        /// <summary>
        /// Creates a new DateTime object that represents the same time as the specified DateTime, but is designated in either local time, Coordinated Universal Time (UTC), or neither, as indicated by the specified DateTimeKind value.
        /// </summary>
        /// <param name="value">A DateTime object.</param>
        /// <param name="kind">One of the DateTimeKind values.</param>
        /// <returns>A new DateTime object consisting of the same time represented by the value parameter and the DateTimeKind value specified by the kind parameter.</returns>
        DateTime SpecifyKind(DateTime value, DateTimeKind kind);

        /// <summary>
        /// Returns the number of days in the specified month and year.
        /// </summary>
        /// <param name="year">The year. </param>
        /// <param name="month">The month (a number ranging from 1 to 12). </param>
        /// <returns>The number of days in month for the specified year.</returns>
        int DaysInMonth(int year, int month);

        /// <summary>
        /// Compares two instances of DateTime and returns an integer that indicates whether the first instance is earlier than, the same as, or later than the second instance.
        /// </summary>
        /// <param name="t1">The first DateTime. </param>
        /// <param name="t2">The second DateTime. </param>
        /// <returns>A signed number indicating the relative values of t1 and t2.</returns>
        int Compare(DateTime t1, DateTime t2);

        /// <summary>
        /// Returns a value indicating whether two instances of DateTime are equal.
        /// </summary>
        /// <param name="t1">The first DateTime instance. </param>
        /// <param name="t2">The second DateTime instance. </param>
        /// <returns> true if the two DateTime values are equal; otherwise, false.</returns>
        bool Equals(DateTime t1, DateTime t2);
#if !PORTABLE
        /// <summary>
        /// Deserializes a 64-bit binary value and recreates an original serialized DateTime object.
        /// </summary>
        /// <param name="dateData">A 64-bit signed integer that encodes the Kind property in a 2-bit field and the Ticks property in a 62-bit field. </param>
        /// <returns>A DateTime object that is equivalent to the DateTime object that was serialized by the ToBinary method.</returns>
        DateTime FromBinary(long dateData);
        /// <summary>
        /// Converts the specified Windows file time to an equivalent local time.
        /// </summary>
        /// <param name="fileTime">A Windows file time expressed in ticks. </param>
        /// <returns>A DateTime object that represents a local time equivalent to the date and time represented by the fileTime parameter.</returns>
        DateTime FromFileTime(long fileTime);
        /// <summary>
        /// Converts the specified Windows file time to an equivalent UTC time.
        /// </summary>
        /// <param name="fileTime">A Windows file time expressed in ticks. </param>
        /// <returns>A DateTime object that represents a UTC time equivalent to the date and time represented by the fileTime parameter.</returns>
        DateTime FromFileTimeUtc(long fileTime);
        /// <summary>
        /// Returns a DateTime equivalent to the specified OLE Automation Date.
        /// </summary>
        /// <param name="d">An OLE Automation Date value. </param>
        /// <returns>A DateTime that represents the same date and time as d.</returns>
        DateTime FromOADate(double d);
#endif
        /// <summary>
        /// Returns an indication whether the specified year is a leap year.
        /// </summary>
        /// <param name="year">A 4-digit year. </param>
        /// <returns> true if year is a leap year; otherwise, false.</returns>
        bool IsLeapYear(int year);
        /// <summary>
        /// Converts the specified string representation of a date and time to its DateTime equivalent.
        /// </summary>
        /// <param name="s">A string containing a date and time to convert. </param>
        /// <returns>A DateTime equivalent to the date and time contained in s.</returns>
        DateTime Parse(string s);
        /// <summary>
        /// Converts the specified string representation of a date and time to its DateTime equivalent using the specified culture-specific format information.
        /// </summary>
        /// <param name="s">A string containing a date and time to convert. </param>
        /// <param name="provider">An object that supplies culture-specific format information about s. </param>
        /// <returns>A DateTime equivalent to the date and time contained in s as specified by provider.</returns>
        DateTime Parse(string s, IFormatProvider provider);
        /// <summary>
        /// Converts the specified string representation of a date and time to its DateTime equivalent using the specified culture-specific format information and formatting style.
        /// </summary>
        /// <param name="s">A string containing a date and time to convert. </param>
        /// <param name="provider">An object that supplies culture-specific formatting information about s. </param>
        /// <param name="styles">A bitwise combination of the enumeration values that indicates the style elements that can be present in s for the parse operation to succeed and that defines how to interpret the parsed date in relation to the current time zone or the current date. A typical value to specify is None.</param>
        /// <returns>A DateTime equivalent to the date and time contained in s as specified by provider and styles.</returns>
        DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles);
        /// <summary>
        /// Converts the specified string representation of a date and time to its DateTime equivalent using the specified format and culture-specific format information. The format of the string representation must match the specified format exactly.
        /// </summary>
        /// <param name="s">A string that contains a date and time to convert. </param>
        /// <param name="format">A format specifier that defines the required format of s. </param>
        /// <param name="provider">An object that supplies culture-specific format information about s. </param>
        /// <returns>A DateTime equivalent to the date and time contained in s as specified by format and provider.</returns>
        DateTime ParseExact(string s, string format, IFormatProvider provider);
        /// <summary>
        /// Converts the specified string representation of a date and time to its DateTime equivalent using the specified format, culture-specific format information, and style. The format of the string representation must match the specified format exactly or an exception is thrown.
        /// </summary>
        /// <param name="s">A string that contains a date and time to convert. </param>
        /// <param name="format">A format specifier that defines the required format of s. </param>
        /// <param name="provider">An object that supplies culture-specific format information about s. </param>
        /// <param name="style">A bitwise combination of the enumeration values that provides additional information about s, about style elements that may be present in s, or about the conversion from s to a DateTime value. A typical value to specify is None.</param>
        /// <returns>A DateTime equivalent to the date and time contained in s as specified by format, provider, and style.</returns>
        DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style);
        /// <summary>
        /// Converts the specified string representation of a date and time to its DateTime equivalent using the specified array of formats, culture-specific format information, and style. The format of the string representation must match at least one of the specified formats exactly or an exception is thrown.
        /// </summary>
        /// <param name="s">A string containing one or more dates and times to convert. </param>
        /// <param name="formats">An array of allowable formats of s. </param>
        /// <param name="provider">An IFormatProvider that supplies culture-specific format information about s. </param>
        /// <param name="style">A bitwise combination of DateTimeStyles values that indicates the permitted format of s. A typical value to specify is None.</param>
        /// <returns>A DateTime equivalent to the date and time contained in s as specified by formats, provider, and style.</returns>
        DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style);

        /// <summary>
        /// Converts the specified string representation of a date and time to its DateTime equivalent and returns a value that indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="s">A string containing a date and time to convert.</param>
        /// <param name="result">When this method returns, contains the DateTime value equivalent to the date and time contained in s, if the conversion succeeded, or MinValue if the conversion failed. The conversion fails if the s parameter is nullNothingnullptra null reference (Nothing in Visual Basic), is an empty string (""), or does not contain a valid string representation of a date and time. This parameter is passed uninitialized.</param>
        /// <returns> true if the s parameter was converted successfully; otherwise, false.</returns>
        bool TryParse(string s, out DateTime result);
        /// <summary>
        /// Converts the specified string representation of a date and time to its DateTime equivalent using the specified culture-specific format information and formatting style, and returns a value that indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="s">A string containing a date and time to convert. </param>
        /// <param name="provider">An object that supplies culture-specific formatting information about s.</param>
        /// <param name="styles">A bitwise combination of enumeration values that defines how to interpret the parsed date in relation to the current time zone or the current date. A typical value to specify is None.</param>
        /// <param name="result">When this method returns, contains the DateTime value equivalent to the date and time contained in s, if the conversion succeeded, or MinValue if the conversion failed. The conversion fails if the s parameter is nullNothingnullptra null reference (Nothing in Visual Basic), is an empty string (""), or does not contain a valid string representation of a date and time. This parameter is passed uninitialized.</param>
        /// <returns> true if the s parameter was converted successfully; otherwise, false.</returns>
        bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result);
        /// <summary>
        /// Converts the specified string representation of a date and time to its DateTime equivalent using the specified array of formats, culture-specific format information, and style. The format of the string representation must match at least one of the specified formats exactly. The method returns a value that indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="s">A string containing a date and time to convert. </param>
        /// <param name="formats">An array of allowable formats of s. </param>
        /// <param name="provider">An IFormatProvider object that supplies culture-specific formatting information about s. </param>
        /// <param name="style">A bitwise combination of one or more enumeration values that indicate the permitted format of s. </param>
        /// <param name="result">When this method returns, contains the DateTime value equivalent to the date and time contained in s, if the conversion succeeded, or MinValue if the conversion failed. The conversion fails if s or formats is nullNothingnullptra null reference (Nothing in Visual Basic), s or an element of formats is an empty string, or the format of s is not exactly as specified by at least one of the format patterns in formats. This parameter is passed uninitialized.</param>
        /// <returns>true if the s parameter was converted successfully; otherwise, false.</returns>
        bool TryParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style, out DateTime result);
        /// <summary>
        /// Converts the specified string representation of a date and time to its DateTime equivalent using the specified format, culture-specific format information, and style. The format of the string representation must match the specified format exactly. The method returns a value that indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="s">A string containing a date and time to convert. </param>
        /// <param name="format">The required format of s. </param>
        /// <param name="provider">An IFormatProvider object that supplies culture-specific formatting information about s. </param>
        /// <param name="style">A bitwise combination of one or more enumeration values that indicate the permitted format of s. </param>
        /// <param name="result">When this method returns, contains the DateTime value equivalent to the date and time contained in s, if the conversion succeeded, or MinValue if the conversion failed. The conversion fails if either the s or format parameter is nullNothingnullptra null reference (Nothing in Visual Basic), is an empty string, or does not contain a date and time that correspond to the pattern specified in format. This parameter is passed uninitialized. </param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result);
    }
}