using System.Security.AccessControl;

namespace UnitWrappers.System.Security.AccessControl
{
    /// <summary>
    /// Wrapper for <see cref="T:System.Security.AccessControl.DirectorySecurity"/> class.
    /// </summary>
    public class DirectorySecurityWrap : IDirectorySecurity
    {
        private DirectorySecurity _directorySecurity;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:UnitWrappers.System.Security.AccessControl.DirectorySecurityWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="directorySecurity">A <see cref="T:System.Security.AccessControl.DirectorySecurity"/> object.</param>
		public DirectorySecurityWrap(DirectorySecurity directorySecurity)
		{
            _directorySecurity = directorySecurity;
		}


		public DirectorySecurity DirectorySecurityInstance
        {
            get { return _directorySecurity; }
        }
    }
}