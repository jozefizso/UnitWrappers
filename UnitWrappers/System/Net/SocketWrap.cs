using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UnitWrappers.System.Net
{
    /// <summary>
    /// Wraps instance members of <see cref="Socket"/>
    /// </summary>
    public class SocketWrap : ISocket
    {
        public Socket UnderlyingObject { get; private set; }

        public SocketWrap(Socket underlyingObject)
        {
            UnderlyingObject = underlyingObject;
        }

        public SocketWrap(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
        {
            UnderlyingObject = new Socket(addressFamily, socketType, protocolType);
        }

        public SocketWrap(SocketInformation socketInformation)
        {
            UnderlyingObject = new Socket(socketInformation);
        }


        public int Available
        {
            get { return UnderlyingObject.Available; }
        }

        public EndPoint LocalEndPoint
        {
            get { return UnderlyingObject.LocalEndPoint; }
        }

        public EndPoint RemoteEndPoint
        {
            get { return UnderlyingObject.RemoteEndPoint; }
        }

        public IntPtr Handle
        {
            get { return UnderlyingObject.Handle; }
        }

        public bool Blocking
        {
            get { return UnderlyingObject.Blocking; }
            set { UnderlyingObject.Blocking = value; }
        }

        public bool UseOnlyOverlappedIO
        {
            get { return UnderlyingObject.UseOnlyOverlappedIO; }
            set { UnderlyingObject.UseOnlyOverlappedIO = value; }
        }

        public bool Connected
        {
            get { return UnderlyingObject.Connected; }
        }

        public AddressFamily AddressFamily
        {
            get { return UnderlyingObject.AddressFamily; }
        }

        public SocketType SocketType
        {
            get { return UnderlyingObject.SocketType; }
        }

        public ProtocolType ProtocolType
        {
            get { return UnderlyingObject.ProtocolType; }
        }

        public void Connect(EndPoint remoteEP)
        {
            UnderlyingObject.Connect(remoteEP);
        }

        public void Connect(IPAddress address, int port)
        {
           UnderlyingObject.Connect(address,port);
        }

        public void Connect(string host, int port)
        {
            UnderlyingObject.Connect(host,port);
        }

        public void Connect(IPAddress[] addresses, int port)
        {
           UnderlyingObject.Connect(addresses,port);
        }

        public void Close()
        {
            UnderlyingObject.Close();
        }

        public void Close(int timeout)
        {
            UnderlyingObject.Close(timeout);
        }

        public void Listen(int backlog)
        {
            UnderlyingObject.Listen(backlog);
        }

        public ISocket Accept()
        {
           return new SocketWrap(UnderlyingObject.Accept());
        }

        public bool Poll(int microSeconds, SelectMode mode)
        {
          return  UnderlyingObject.Poll(microSeconds, mode);
        }

        public void Dispose()
        {
            (UnderlyingObject as IDisposable).Dispose();
        }
    }
}
