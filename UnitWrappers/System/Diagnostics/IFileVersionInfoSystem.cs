namespace UnitWrappers.System.Diagnostics
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFileVersionInfoSystem
    {
        /// <summary>
        /// Returns a <see cref="T:UnitWrappers.System.Diagnostics.IFileVersionInfo"/> representing the version information associated with the specified file.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:UnitWrappers.System.Diagnostics.IFileVersionInfo"/> containing information about the file. If the file did not contain version information, the <see cref="T:UnitWrappers:System.Diagnostics.IFileVersionInfo"/> contains only the name of the file requested.
        /// 
        /// </returns>
        /// <param name="fileName">The fully qualified path and name of the file to retrieve the version information for.
        ///                 </param><exception cref="T:System.IO.FileNotFoundException">The file specified cannot be found.
        ///                 </exception><filterpriority>1</filterpriority>
        IFileVersionInfo GetVersionInfo(string fileName);
    }
}