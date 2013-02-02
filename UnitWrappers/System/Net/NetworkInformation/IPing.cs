using System;
using System.Net.NetworkInformation;
namespace UnitWrappers.System.Net.NetworkInformation
{
	public interface IPing
	{
        /// <summary>
        /// Attempts to send an Internet Control Message Protocol (ICMP) echo message to the specified computer, and receive a corresponding ICMP echo reply message from that computer.
        /// </summary>
        /// <param name="hostNameOrAddress">A <see cref="String"/> that identifies the computer that is the destination for the ICMP echo message. The value specified for this parameter can be a host name or a string representation of an IP address.</param>
        /// <returns>A <see cref="PingReply"/> object that provides information about the ICMP echo reply message, if one was received, or provides the reason for the failure, if no message was received</returns>
	    PingReply Send(string hostNameOrAddress);
	}
}

