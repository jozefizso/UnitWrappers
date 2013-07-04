using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Deployment.WindowsInstaller;

namespace UnitWrappers.Microsoft.Deployment.WindowsInstaller
{
    public class ProductInstallationWrap : IProductInstallation
    {
        private ProductInstallation _underlyaingObject;

        public ProductInstallationWrap(ProductInstallation underlyaingObject)
        {
            _underlyaingObject = underlyaingObject;
         
        }

        ///<inheritdoc/>
        public string AdvertisedProductName { get { return _underlyaingObject.AdvertisedProductName; } }
        ///<inheritdoc/>
        public bool AdvertisedPerMachine { get { return _underlyaingObject.AdvertisedPerMachine; } }
        ///<inheritdoc/>
        public string AdvertisedPackageCode { get { return _underlyaingObject.AdvertisedPackageCode; } }
        ///<inheritdoc/>
        public SourceList SourceList { get { return _underlyaingObject.SourceList; } }

        ///<inheritdoc/>
        public Version ProductVersion { get { return _underlyaingObject.ProductVersion; }}
         ///<inheritdoc/>
        public IEnumerable<IFeatureInstallation> Features { get { return _underlyaingObject.Features.Select(x=>new FeatureInstallationWrap(x) as IFeatureInstallation); } }
        ///<inheritdoc/>
        public string ProductCode { get { return _underlyaingObject.ProductCode; } }
        ///<inheritdoc/>
        public bool IsInstalled { get { return _underlyaingObject.IsInstalled; } }
        ///<inheritdoc/>
        public bool IsAdvertised { get { return _underlyaingObject.IsAdvertised; } }
        ///<inheritdoc/>
        public bool IsElevated { get { return _underlyaingObject.IsElevated; } }

        
    }
}