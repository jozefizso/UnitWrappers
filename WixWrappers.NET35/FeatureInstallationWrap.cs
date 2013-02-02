using Microsoft.Deployment.WindowsInstaller;

namespace WixWrappers.NET35
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