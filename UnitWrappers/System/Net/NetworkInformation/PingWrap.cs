using System;
using System.Net.NetworkInformation;
namespace UnitWrappers.System.Net.NetworkInformation
{
	public class PingWrap:IPing,IWrap<Ping>
	{
		
		public Ping _underlyingObject;
		
		Ping IWrap<Ping>.UnderlyingObject
		{
			get {return _underlyingObject;}
		}	
		
		public PingWrap ()
		{
			_underlyingObject = new Ping();
		}
		
		public PingWrap (Ping ping)
		{
			_underlyingObject = ping;
		}

        /// <inheritdoc />
        public PingReply Send(string hostNameOrAddress)
        {
            return _underlyingObject.Send(hostNameOrAddress);
        }
	}
}

