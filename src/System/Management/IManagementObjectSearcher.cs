using System.Collections.Generic;
using System.Management;

namespace UnitWrappers.System.Management
{
    public interface IManagementObjectSearcher
    {
        ManagementObjectSearcher UnderlyingObject { get; set; }
        IEnumerable<ManagementBaseObject> Get();
    }
}