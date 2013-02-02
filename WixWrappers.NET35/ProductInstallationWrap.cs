using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Deployment.WindowsInstaller;

namespace WixWrappers.NET35
{
    public class ProductInstallationWrap : IProductInstallation
    {
        private ProductInstallation _underlyaingObject;

        public ProductInstallationWrap(ProductInstallation underlyaingObject)
        {
            _underlyaingObject = underlyaingObject;
         
        }

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