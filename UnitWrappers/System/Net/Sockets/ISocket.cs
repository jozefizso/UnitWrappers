using System;
using System.Net;
using System.Net.Sockets;

namespace UnitWrappers.System.Net.Sockets
{

    public interface ISocket:IDisposable
    {

         int Available { get; }
         EndPoint LocalEndPoint { get; }
         EndPoint RemoteEndPoint { get; }
         IntPtr Handle { get; }
         bool Blocking { get; set; }
         bool UseOnlyOverlappedIO { get; set; }
         bool Connected { get; }
         AddressFamily AddressFamily { get; }
         SocketType SocketType { get; }
         ProtocolType ProtocolType { get; }
         //bool IsBound { get; }
         //bool ExclusiveAddressUse { get; set; }
         //int ReceiveBufferSize { get; set; }
         //int SendBufferSize { get; set; }
         //int ReceiveTimeout { get; set; }
         //int SendTimeout { get; set; }
         //LingerOption LingerState { get; set; }
         //bool NoDelay { get; set; }
         //short Ttl { get; set; }
         //bool DontFragment { get; set; }
         //bool MulticastLoopback { get; set; }
         //bool EnableBroadcast { get; set; }

        //public void Bind(EndPoint localEP);
          void Connect(EndPoint remoteEP);
          void Connect(IPAddress address, int port);
          void Connect(string host, int port);
          void Connect(IPAddress[] addresses, int port);
          void Close();
          void Close(int timeout);
          void Listen(int backlog);
          ISocket Accept();
        //public int Send(byte[] buffer, int size, SocketFlags socketFlags);
        //public int Send(byte[] buffer, SocketFlags socketFlags);
        //public int Send(byte[] buffer);
        //public int Send(IList<ArraySegment<byte>> buffers);
        //public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags);
        //public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode);
        //public void SendFile(string fileName);
        //public void SendFile(string fileName, byte[] preBuffer, byte[] postBuffer, TransmitFileOptions flags);
        //public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags);
        //public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode);
        //public int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP);
        //public int SendTo(byte[] buffer, int size, SocketFlags socketFlags, EndPoint remoteEP);
        //public int SendTo(byte[] buffer, SocketFlags socketFlags, EndPoint remoteEP);
        //public int SendTo(byte[] buffer, EndPoint remoteEP);
        //public int Receive(byte[] buffer, int size, SocketFlags socketFlags);
        //public int Receive(byte[] buffer, SocketFlags socketFlags);
        //public int Receive(byte[] buffer);
        //public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags);
        //public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode);
        //public int Receive(IList<ArraySegment<byte>> buffers);
        //public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags);
        //public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode);
        //public int ReceiveMessageFrom(byte[] buffer, int offset, int size, ref SocketFlags socketFlags, ref EndPoint remoteEP, out IPPacketInformation ipPacketInformation);
        //public int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP);
        //public int ReceiveFrom(byte[] buffer, int size, SocketFlags socketFlags, ref EndPoint remoteEP);
        //public int ReceiveFrom(byte[] buffer, SocketFlags socketFlags, ref EndPoint remoteEP);
        //public int ReceiveFrom(byte[] buffer, ref EndPoint remoteEP);
        //public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue);
        //public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue);
        //public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue);
        //public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue);
        //public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, bool optionValue);
        //public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, object optionValue);
        //public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName);
        //public void GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue);
        //public byte[] GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionLength);
        bool Poll(int microSeconds, SelectMode mode);
        //public static void Select(IList checkRead, IList checkWrite, IList checkError, int microSeconds);

        //[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        //public IAsyncResult BeginSendFile(string fileName, AsyncCallback callback, object state);

        //[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        //public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state);

        //public SocketInformation DuplicateAndClose(int targetProcessId);

        //[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        //public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state);

        //[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        //public IAsyncResult BeginConnect(IPAddress address, int port, AsyncCallback requestCallback, object state);

        //[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        //public IAsyncResult BeginConnect(IPAddress[] addresses, int port, AsyncCallback requestCallback, object state);

        //[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        //public IAsyncResult BeginDisconnect(bool reuseSocket, AsyncCallback callback, object state);

        //public void Disconnect(bool reuseSocket);
        //public void EndConnect(IAsyncResult asyncResult);
        //public void EndDisconnect(IAsyncResult asyncResult);

        //[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        //public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state);

        //[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        //public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state);

        //[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        //public IAsyncResult BeginSendFile(string fileName, byte[] preBuffer, byte[] postBuffer, TransmitFileOptions flags, AsyncCallback callback, object state);

        //[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        //public IAsyncResult BeginSend(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, AsyncCallback callback, object state);

        //[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        //public IAsyncResult BeginSend(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state);

        //public int EndSend(IAsyncResult asyncResult);
        //public int EndSend(IAsyncResult asyncResult, out SocketError errorCode);
        //public void EndSendFile(IAsyncResult asyncResult);

        //[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        //public IAsyncResult BeginSendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP, AsyncCallback callback, object state);

        //public int EndSendTo(IAsyncResult asyncResult);

        //[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        //public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state);

        //[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        //public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state);

        //[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        //public IAsyncResult BeginReceive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, AsyncCallback callback, object state);

        //[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        //public IAsyncResult BeginReceive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state);

        //public int EndReceive(IAsyncResult asyncResult);
        //public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode);
        //public IAsyncResult BeginReceiveMessageFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, AsyncCallback callback, object state);
        //public int EndReceiveMessageFrom(IAsyncResult asyncResult, ref SocketFlags socketFlags, ref EndPoint endPoint, out IPPacketInformation ipPacketInformation);

        //[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        //public IAsyncResult BeginReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, AsyncCallback callback, object state);

        //public int EndReceiveFrom(IAsyncResult asyncResult, ref EndPoint endPoint);

        //[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        //public IAsyncResult BeginAccept(AsyncCallback callback, object state);

        //[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        //public IAsyncResult BeginAccept(int receiveSize, AsyncCallback callback, object state);

        //[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        //public IAsyncResult BeginAccept(Socket acceptSocket, int receiveSize, AsyncCallback callback, object state);

        //public Socket EndAccept(IAsyncResult asyncResult);
        //public Socket EndAccept(out byte[] buffer, IAsyncResult asyncResult);
        //public Socket EndAccept(out byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult);
        //public void Shutdown(SocketShutdown how);
        //protected virtual void Dispose(bool disposing);
        //~Socket();
        //public bool AcceptAsync(SocketAsyncEventArgs e);
        //public bool ConnectAsync(SocketAsyncEventArgs e);
        //public bool DisconnectAsync(SocketAsyncEventArgs e);
        //public bool ReceiveAsync(SocketAsyncEventArgs e);
        //public bool ReceiveFromAsync(SocketAsyncEventArgs e);
        //public bool ReceiveMessageFromAsync(SocketAsyncEventArgs e);
        //public bool SendAsync(SocketAsyncEventArgs e);
        //public bool SendPacketsAsync(SocketAsyncEventArgs e);
        //public bool SendToAsync(SocketAsyncEventArgs e);

    }
}
