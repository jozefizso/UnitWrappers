using System.Security.AccessControl;

namespace UnitWrappers.System.Security.AccessControl
{
    /// <summary>
    /// Wrapper for <see cref="T:System.Security.AccessControl.DirectorySecurity"/> class.
    /// </summary>
    public interface IDirectorySecurity
    {
        /// <summary>
        /// Gets <see cref="T:System.Security.AccessControl.DirectorySecurity"/> object.
        /// </summary>
        DirectorySecurity DirectorySecurityInstance { get; }
    }
}