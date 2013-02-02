using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Deployment.WindowsInstaller;

namespace WixWrappers.NET35
{
    public class ProductInstallationSystem : IProductInstallationSystem
    {

        ///<inheritdoc/>
        public IEnumerable<IProductInstallation> AllProducts
        {
            get { return ProductInstallation.AllProducts.Select(x => new ProductInstallationWrap(x) as IProductInstallation); }
        }
        ///<inheritdoc/>
        public IEnumerable<IProductInstallation> GetProducts(string productCode, string userSid, UserContexts context)
        {
            return ProductInstallation.GetProducts(productCode, userSid, context).Select(x => new ProductInstallationWrap(x) as IProductInstallation);
        }
        ///<inheritdoc/>
        public IEnumerable<IProductInstallation> GetRelatedProducts(string upgradeCode)
        {
            return ProductInstallation.GetRelatedProducts(upgradeCode).Select(x => new ProductInstallationWrap(x) as IProductInstallation );
        }

    
    }
}