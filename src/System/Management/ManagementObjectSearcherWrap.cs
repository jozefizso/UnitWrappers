using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Management.Instrumentation;

namespace UnitWrappers.System.Management
{
    public class ManagementObjectSearcherWrap : IManagementObjectSearcher
    {

        public ManagementObjectSearcher UnderlyingObject { get; set; }

        public ManagementObjectSearcherWrap(ManagementScope scope,ObjectQuery query)
        {
            UnderlyingObject = new ManagementObjectSearcher(scope,query);
        }

        public ManagementObjectSearcherWrap(string queryString)
        {
            UnderlyingObject = new ManagementObjectSearcher(queryString);
        }

        public ManagementObjectSearcherWrap(ManagementObjectSearcher managementObjectSearcher)
        {
            UnderlyingObject = managementObjectSearcher;
        }

        public IEnumerable<ManagementBaseObject> Get()
        {
            return UnderlyingObject.Get().Cast<ManagementBaseObject>();
        }
    }
}
