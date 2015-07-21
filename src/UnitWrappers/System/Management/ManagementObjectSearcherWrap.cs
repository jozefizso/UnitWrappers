using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Management.Instrumentation;

namespace UnitWrappers.System.Management
{
	public class ManagementObjectSearcherWrap : IManagementObjectSearcher, IWrap<ManagementObjectSearcher>
    {
		private ManagementObjectSearcher _underlyingObject;

		ManagementObjectSearcher IWrap<ManagementObjectSearcher>.UnderlyingObject { get { return _underlyingObject;}  }

        public ManagementObjectSearcherWrap(ManagementScope scope,ObjectQuery query)
        {
            _underlyingObject = new ManagementObjectSearcher(scope,query);
        }

        public ManagementObjectSearcherWrap(string queryString)
        {
            _underlyingObject = new ManagementObjectSearcher(queryString);
        }

        public ManagementObjectSearcherWrap(ManagementObjectSearcher managementObjectSearcher)
        {
            _underlyingObject = managementObjectSearcher;
        }

        public IEnumerable<ManagementBaseObject> Get()
        {
            return _underlyingObject.Get().Cast<ManagementBaseObject>();
        }
    }
}
