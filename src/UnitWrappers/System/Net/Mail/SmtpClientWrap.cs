
using System;
using System.Net.Mail;

namespace UnitWrappers.System.Net.Mail
{

	public class SmtpClientWrap:IWrap<SmtpClient>
	{
		
	   private SmtpClient _underlyingObject;

        public static implicit operator SmtpClientWrap(SmtpClient o)
        {
            return new SmtpClientWrap(o);
        }

        public static implicit operator SmtpClient(SmtpClientWrap o)
        {
            return o._underlyingObject;
        }

        public SmtpClientWrap(SmtpClient client)
        {
            _underlyingObject = client;
        }
        
        public SmtpClientWrap(string host)
        {
        	_underlyingObject = new SmtpClient(host);
        }
        
        public SmtpClientWrap()
        {
        	_underlyingObject = new SmtpClient();
        }
        
        public SmtpClientWrap(string host,int port)
        {
        	_underlyingObject = new SmtpClient(host,port);
        }

        SmtpClient IWrap<SmtpClient>.UnderlyingObject { get{return _underlyingObject;}}
	}
}
