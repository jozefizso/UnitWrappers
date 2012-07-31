using System;
using System.Net.NetworkInformation;
namespace UnitWrappers.System.Net.NetworkInformation
{
	/// <summary>
	/// Provides configuration and statistical information for a network interface.
	/// </summary>
	public interface INetworkInterface
	{
		/// <summary>
		/// Returns objects that describe the network interfaces on the local computer.
		/// </summary>
		/// <returns>
		/// A <see cref="NetworkInterface"/> array that contains objects that describe the available network interfaces, or an empty array if no interfaces are detected
		/// </returns>
		/// <exception cref="NetworkInformationException"></exception>
		NetworkInterface[] GetAllNetworkInterfaces();
		
		/// <summary>
		/// Indicates whether any network connection is available.
		/// </summary>
		/// <returns>
		/// <c>true</c> if a network connection is available; otherwise, <c>false</c>.
		/// </returns>
		/// <remarks>
		/// A network connection is considered to be available if any network interface is marked "up" and is not a loopback or tunnel interface.
		/// </remarks>
		bool GetIsNetworkAvailable();
	}
	

}

