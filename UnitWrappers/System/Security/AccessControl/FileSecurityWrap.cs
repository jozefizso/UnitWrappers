using System.Security.AccessControl;

namespace UnitWrappers.System.Security.AccessControl
{
    /// <summary>
    /// Wrapper for <see cref="T:System.Security.AccessControl.FileSecurity"/> class.
    /// </summary>
    public class FileSecurityWrap : IFileSecurity
    {
        internal FileSecurity _fileSecurity;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:UnitWrappers.System.Security.AccessControl.FileSecurityWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="fileSecurity">A FileSecurity object.</param>
		public FileSecurityWrap(FileSecurity fileSecurity)
		{
            _fileSecurity = fileSecurity;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:UnitWrappers.System.Security.AccessControl.FileSecurityWrap"/> class on the specified path. 
		/// </summary>
		public FileSecurityWrap()
		{
            _fileSecurity = new FileSecurity();
		}

		public FileSecurity FileSecurityInstance
        {
            get { return _fileSecurity; }
        }
    }
}