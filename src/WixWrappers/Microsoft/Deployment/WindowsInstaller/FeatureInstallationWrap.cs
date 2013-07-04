using Microsoft.Deployment.WindowsInstaller;

namespace UnitWrappers.Microsoft.Deployment.WindowsInstaller
{
    public class FeatureInstallationWrap : IFeatureInstallation
    {
        private FeatureInstallation _underlyaingObject;

        public FeatureInstallationWrap(FeatureInstallation underlyaingObject)
        {
            _underlyaingObject = underlyaingObject;

        }
    }
}