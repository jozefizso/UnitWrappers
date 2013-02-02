using System.Security.AccessControl;

namespace UnitWrappers.System.Security.AccessControl
{
    /// <summary>
    /// Wrapper for <see cref="T:System.Security.AccessControl.FileSecurity"/> class.
    /// </summary>
    public interface IFileSecurity
    {
        /// <summary>
        /// Gets <see cref="T:System.Security.AccessControl.DirectorySecurity"/> object.
        /// </summary>
        FileSecurity FileSecurityInstance { get; }
    }
}