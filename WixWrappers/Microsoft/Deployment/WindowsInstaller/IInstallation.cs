using Microsoft.Deployment.WindowsInstaller;

namespace UnitWrappers.Microsoft.Deployment.WindowsInstaller
{
    public interface IInstallation
    {
        /// <summary>
        /// Gets the source list of this product installation.
        /// 
        /// </summary>
        SourceList SourceList { get; }
    }
}