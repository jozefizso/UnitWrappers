using System;
using System.Net;
using System.Net.NetworkInformation;
namespace UnitWrappers.System.Net.NetworkInformation
{
	
   public class NetworkInterfaceWrap:INetworkInterface
	{
		/// <inheritdoc />
		public NetworkInterface[] GetAllNetworkInterfaces()
		{
			return  NetworkInterface.GetAllNetworkInterfaces();
		}
		
		/// <inheritdoc />
		public bool GetIsNetworkAvailable()
		{
			return  NetworkInterface.GetIsNetworkAvailable();
		}
	}
}

