using System.Collections.Generic;
using Microsoft.Deployment.WindowsInstaller;

namespace UnitWrappers.Microsoft.Deployment.WindowsInstaller
{
    public interface IProductInstallationSystem
    {

        /// <summary>
        /// Enumerates all product installations on the system.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An enumeration of product objects.
        /// </returns>

        IEnumerable<IProductInstallation> AllProducts { get; }

        /// <summary>
        /// Enumerates product installations based on certain criteria.
        /// 
        /// </summary>
        /// <param name="productCode">ProductCode (GUID) of the product instances to be enumerated. Only
        ///             instances of products within the scope of the context specified by the
        ///             <paramref name="userSid"/> and <paramref name="context"/> parameters will be
        ///             enumerated. This parameter may be set to null to enumerate all products in the specified
        ///             context.</param><param name="userSid">Specifies a security identifier (SID) that restricts the context
        ///             of enumeration. A SID value other than s-1-1-0 is considered a user SID and restricts
        ///             enumeration to the current user or any user in the system. The special SID string
        ///             s-1-1-0 (Everyone) specifies enumeration across all users in the system. This parameter
        ///             can be set to null to restrict the enumeration scope to the current user. When
        ///             <paramref name="context"/> is set to the machine context only,
        ///             <paramref name="userSid"/> must be null.</param><param name="context">Specifies the user context.</param>
        /// <returns>
        /// An enumeration of product objects for enumerated product instances.
        /// </returns>
        IEnumerable<IProductInstallation> GetProducts(string upgradeCode, string userSid, UserContexts context);

        /// <summary>
        /// Gets the set of all products with a specified upgrade code. This method lists the
        ///             currently installed and advertised products that have the specified UpgradeCode
        ///             property in their Property table.
        /// 
        /// </summary>
        /// <param name="upgradeCode">Upgrade code of related products</param>
        /// <returns>
        /// Enumeration of product codes
        /// </returns>
        IEnumerable<IProductInstallation> GetRelatedProducts(string upgradeCode);


    }
}
