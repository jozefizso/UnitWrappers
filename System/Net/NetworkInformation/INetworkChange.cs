using System.Net.NetworkInformation;

namespace UnitWrappers.System.Net.NetworkInformation
{
	public interface INetworkChange
	{
		/// <summary>
		/// Occurs when the availability of the network changes.
		/// </summary>
        event NetworkAvailabilityChangedEventHandler NetworkAvailabilityChanged;
		
		/// <summary>
		/// Occurs when the IP address of a network interface changes.
		/// </summary>
		event NetworkAddressChangedEventHandler NetworkAddressChanged;
		
	}
}

