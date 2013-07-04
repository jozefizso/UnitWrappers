using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace UnitWrappers.System.Net.Sockets
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

        public bool IsBound
        {
            get { return UnderlyingObject.IsBound; }
        }

        public bool ExclusiveAddressUse
        {
            get { return UnderlyingObject.ExclusiveAddressUse; }
            set { UnderlyingObject.ExclusiveAddressUse = value; }
        }

        public int ReceiveBufferSize
        {
            get { return UnderlyingObject.ReceiveBufferSize; }
            set { UnderlyingObject.ReceiveBufferSize = value; }
        }

        public int SendBufferSize
        {
            get { return UnderlyingObject.SendBufferSize; }
            set { UnderlyingObject.SendBufferSize = value; }
        }

        public int ReceiveTimeout
        {
            get { return UnderlyingObject.ReceiveTimeout; }
            set { UnderlyingObject.ReceiveTimeout = value; }
        }

        public int SendTimeout
        {
            get { return UnderlyingObject.SendTimeout; }
            set { UnderlyingObject.SendTimeout = value; }
        }

        public LingerOption LingerState
        {
            get {return UnderlyingObject.LingerState ;}
            set { UnderlyingObject.LingerState = value; }
        }

        public bool NoDelay
        {
            get {return UnderlyingObject.NoDelay ;}
            set { UnderlyingObject.NoDelay = value; }
        }

        public short Ttl
        {
            get {return UnderlyingObject.Ttl ;}
            set { UnderlyingObject.Ttl = value; }
        }

        public bool DontFragment
        {
            get {return UnderlyingObject.DontFragment ;}
            set { UnderlyingObject.DontFragment = value; }
        }

        public bool MulticastLoopback
        {
            get {return UnderlyingObject.MulticastLoopback ;}
            set { UnderlyingObject.MulticastLoopback = value; }
        }

        public bool EnableBroadcast
        {
            get {return UnderlyingObject.EnableBroadcast ;}
            set { UnderlyingObject.EnableBroadcast = value; }
        }

        public void Bind(EndPoint localEP)
        {
            UnderlyingObject.Bind(localEP);
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

        public int Send(byte[] buffer, int size, SocketFlags socketFlags)
        {
            return UnderlyingObject.Send(buffer, size, socketFlags);
        }

        public int Send(byte[] buffer, SocketFlags socketFlags)
        {
            return UnderlyingObject.Send(buffer, socketFlags);
        }

        public int Send(byte[] buffer)
        {
            return UnderlyingObject.Send(buffer);
        }

        public int Send(IList<ArraySegment<byte>> buffers)
        {
            return UnderlyingObject.Send(buffers);
        }

        public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
        {
            return UnderlyingObject.Send(buffers, socketFlags);
        }

        public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
        {
            return UnderlyingObject.Send(buffers, socketFlags, out errorCode);
        }

        public void SendFile(string fileName)
        {
            UnderlyingObject.SendFile(fileName);
        }

        public void SendFile(string fileName, byte[] preBuffer, byte[] postBuffer, TransmitFileOptions flags)
        {
            UnderlyingObject.SendFile(fileName, preBuffer,postBuffer,flags);
        }

        public int Receive(byte[] buffer)
        {
            return UnderlyingObject.Receive(buffer);
        }

        public bool Poll(int microSeconds, SelectMode mode)
        {
          return  UnderlyingObject.Poll(microSeconds, mode);
        }

        public bool AcceptAsync(SocketAsyncEventArgs e)
        {
            return UnderlyingObject.AcceptAsync(e);
        }

        void IDisposable.Dispose()
        {
            (UnderlyingObject as IDisposable).Dispose();
        }
    }
}
