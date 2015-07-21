using System.Collections.Generic;
using System.Management;

namespace UnitWrappers.System.Management
{
    public interface IManagementObjectSearcher
    {

        IEnumerable<ManagementBaseObject> Get();
    }
}