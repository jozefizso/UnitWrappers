using System;
using System.Collections.Generic;

namespace UnitWrappers.Microsoft.Deployment.WindowsInstaller
{
    public interface IProductInstallation:IInstallation
    {

        /// <summary>
        /// Human readable product name.
        /// 
        /// </summary>
        string AdvertisedProductName { get; }

        /// <summary>
        /// True if the product is advertised per-machine;
        ///             false if it is per-user or not advertised.
        /// 
        /// </summary>
        bool AdvertisedPerMachine { get; }

        /// <summary>
        /// Identifier of the package that a product is installed from.
        /// 
        /// </summary>
        string AdvertisedPackageCode { get; }

   

        Version ProductVersion { get; }

        /// <summary>
        /// Gets the set of published features for the product.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// Enumeration of published features for the product.
        /// </returns>
        /// <exception cref="T:Microsoft.Deployment.WindowsInstaller.InstallerException">The installer configuration data is corrupt</exception>
        /// <remarks>
        /// <p>Because features are not ordered, any new feature has an arbitrary index, meaning
        ///             this property can return features in any order.
        ///             </p>
        /// </remarks>
        IEnumerable<IFeatureInstallation> Features { get; }

        /// <summary>
        /// Gets the ProductCode (GUID) of the product.
        /// 
        /// </summary>
        string ProductCode { get; }

        /// <summary>
        /// Gets a value indicating whether this product is installed on the current system.
        /// 
        /// </summary>
        bool IsInstalled { get; }

        /// <summary>
        /// Gets a value indicating whether this product is advertised on the current system.
        /// 
        /// </summary>
        bool IsAdvertised { get; }

        /// <summary>
        /// Checks whether the product is installed with elevated privileges. An application is called
        ///             a "managed application" if elevated (system) privileges are used to install the application.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// True if the product is elevated; false otherwise
        /// </returns>
        /// 
        /// <remarks>
        /// <p>Note that this property does not take into account policies such as AlwaysInstallElevated,
        ///             but verifies that the local system owns the product's registry data.
        ///             </p>
        /// </remarks>
        bool IsElevated { get; }

    }
}