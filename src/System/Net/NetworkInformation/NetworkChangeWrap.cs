using System.Net.NetworkInformation;

namespace UnitWrappers.System.Net.NetworkInformation
{
	public class NetworkChangeWrap:INetworkChange
	{
	
		/// <inheritdoc />
		public event NetworkAvailabilityChangedEventHandler NetworkAvailabilityChanged
		{
			add 
			{
				NetworkChange.NetworkAvailabilityChanged += value;
			}
			remove 
			{
				NetworkChange.NetworkAvailabilityChanged -= value;
			}
		}
		/// <inheritdoc />
		public event NetworkAddressChangedEventHandler NetworkAddressChanged
		{
			add 
			{
				NetworkChange.NetworkAddressChanged += value;
			}
			remove 
			{
				NetworkChange.NetworkAddressChanged -= value;
			}
		}
		
	}
}

