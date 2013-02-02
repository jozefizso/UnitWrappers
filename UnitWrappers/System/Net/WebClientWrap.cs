using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;

namespace UnitWrappers.System.Net
{


    /// <summary>
    /// Wraps <see cref="WebClient"/>
    /// </summary>
#if !PORTABLE
    [ComVisible(true)]
#endif
    public class WebClientWrap : MarshalByRefObject, IWebClient
    {
        public WebClient UnderlyingObject { get; private set; }

        public WebClientWrap()
        {
            UnderlyingObject = new WebClient();
        }

        public WebClientWrap(WebClient webClient)
        {
            UnderlyingObject = webClient;
        }

        /// <inheritdoc />
        public string BaseAddress
        {
            get { return UnderlyingObject.BaseAddress; }
            set { UnderlyingObject.BaseAddress = value; }
        }

        public RequestCachePolicy CachePolicy
        {
            get { return UnderlyingObject.CachePolicy; }
            set { UnderlyingObject.CachePolicy = value; }
        }

        /// <inheritdoc />
        public IContainer Container
        {
            get { return UnderlyingObject.Container; }
        }

        /// <inheritdoc />
        public ICredentials Credentials
        {
            get { return UnderlyingObject.Credentials; }
            set { UnderlyingObject.Credentials = value; }
        }

        /// <inheritdoc />
        public Encoding Encoding
        {
            get { return UnderlyingObject.Encoding; }
            set { UnderlyingObject.Encoding = value; }
        }

        /// <inheritdoc />
        public WebHeaderCollection Headers
        {
            get { return UnderlyingObject.Headers; }
            set { UnderlyingObject.Headers = value; }
        }

        /// <inheritdoc />
        public bool IsBusy
        {
            get { return UnderlyingObject.IsBusy; }
        }

        /// <inheritdoc />
        public IWebProxy Proxy
        {
            get { return UnderlyingObject.Proxy; }
            set { UnderlyingObject.Proxy = value; }
        }

        /// <inheritdoc />
        public NameValueCollection QueryString
        {
            get { return UnderlyingObject.QueryString; }
            set { UnderlyingObject.QueryString = value; }
        }

        /// <inheritdoc />
        public WebHeaderCollection ResponseHeaders
        {
            get { return UnderlyingObject.ResponseHeaders; }
        }

        /// <inheritdoc />
        public ISite Site
        {
            get { return UnderlyingObject.Site; }
            set {  UnderlyingObject.Site = value; }
        }
        /// <inheritdoc />
        public bool UseDefaultCredentials
        {
            get
            {
                return UnderlyingObject.UseDefaultCredentials;
            }
            set { UnderlyingObject.UseDefaultCredentials = value; }
        }

        /// <inheritdoc />
        public void CancelAsync()
        {
            UnderlyingObject.CancelAsync();
        }

        /// <inheritdoc />
        public ObjRef CancelAsync(Type requestedType)
        {
            return UnderlyingObject.CreateObjRef(requestedType);
        }

        /// <inheritdoc />
        public void Dispose()
        {
            UnderlyingObject.Dispose();
        }

        /// <inheritdoc />
        public override string ToString()
        {
          return  UnderlyingObject.ToString();
        }

        /// <inheritdoc />
        public byte[] DownloadData(string address)
        {
            return UnderlyingObject.DownloadData(address);
        }

        /// <inheritdoc />
        public byte[] DownloadData(Uri address)
        {
            return UnderlyingObject.DownloadData(address);
        }

        /// <inheritdoc />
        public void DownloadDataAsync(Uri address)
        {
            UnderlyingObject.DownloadDataAsync(address);
        }

        /// <inheritdoc />
        public void DownloadDataAsync(Uri address, object userToken)
        {
            UnderlyingObject.DownloadDataAsync(address, userToken);
        }

        /// <inheritdoc />
        public void DownloadFile(string address, string fileName)
        {
            UnderlyingObject.DownloadFile(address, fileName);
        }

        /// <inheritdoc />
        public void DownloadFile(Uri address, string fileName)
        {
            UnderlyingObject.DownloadFile(address, fileName);
        }

        /// <inheritdoc />
        public void DownloadFileAsync(Uri address, string fileName)
        {
            UnderlyingObject.DownloadFileAsync(address, fileName);
        }

        /// <inheritdoc />
        public void DownloadFileAsync(Uri address, string fileName, object userToken)
        {
            UnderlyingObject.DownloadFileAsync(address, fileName, userToken);
        }

        /// <inheritdoc />
        public string DownloadString(string address)
        {
            return UnderlyingObject.DownloadString(address);
        }

        /// <inheritdoc />
        public string DownloadString(Uri address)
        {
            return UnderlyingObject.DownloadString(address);
        }

        /// <inheritdoc />
        public void DownloadStringAsync(Uri address)
        {
            UnderlyingObject.DownloadStringAsync(address);
        }

        /// <inheritdoc />
        public void DownloadStringAsync(Uri address, object userToken)
        {
            UnderlyingObject.DownloadStringAsync(address, userToken);
        }


        /// <inheritdoc />
        public override object InitializeLifetimeService()
        {
            return UnderlyingObject.InitializeLifetimeService();
        }

        /// <inheritdoc />
        public Stream OpenRead(string address)
        {
            return UnderlyingObject.OpenRead(address);
        }
        /// <inheritdoc />
        public Stream OpenRead(Uri address)
        {
            return UnderlyingObject.OpenRead(address);
        }
        /// <inheritdoc />
        public void OpenReadAsync(Uri address)
        {
            UnderlyingObject.OpenReadAsync(address);
        }
        /// <inheritdoc />
        public void OpenReadAsync(Uri address, object userToken)
        {
            UnderlyingObject.OpenReadAsync(address, userToken);
        }

        /// <inheritdoc />
        public Stream OpenWrite(string address)
        {
            return UnderlyingObject.OpenWrite(address);
        }

        /// <inheritdoc />
        public Stream OpenWrite(Uri address)
        {
            return UnderlyingObject.OpenWrite(address);
        }

        /// <inheritdoc />
        public Stream OpenWrite(string address, string method)
        {
            return UnderlyingObject.OpenWrite(address, method);
        }

        /// <inheritdoc />
        public Stream OpenWrite(Uri address, string method)
        {
            return UnderlyingObject.OpenWrite(address, method);
        }



        /// <inheritdoc />
        public void OpenWriteAsync(Uri address)
        {
            UnderlyingObject.OpenWriteAsync(address);
        }
        /// <inheritdoc />
        public void OpenWriteAsync(Uri address, string method)
        {
            UnderlyingObject.OpenWriteAsync(address, method);
        }
        /// <inheritdoc />
        public void OpenWriteAsync(Uri address, string method, object userToken)
        {
            UnderlyingObject.OpenWriteAsync(address, method, userToken);
        }

        /// <inheritdoc />
        public byte[] UploadData(string address, byte[] data)
        {
            return UnderlyingObject.UploadData(address, data);
        }

        /// <inheritdoc />
        public byte[] UploadData(string address, string method, byte[] data)
        {
            return UnderlyingObject.UploadData(address, method, data);
        }

        /// <inheritdoc />
        public byte[] UploadData(Uri address, byte[] data)
        {
            return UnderlyingObject.UploadData(address, data);
        }

        /// <inheritdoc />
        public byte[] UploadData(Uri address, string method, byte[] data)
        {
            return UnderlyingObject.UploadData(address, method, data);
        }

        /// <inheritdoc />
        public void UploadDataAsync(Uri address, byte[] data)
        {
            UnderlyingObject.UploadDataAsync(address, data);
        }

        /// <inheritdoc />
        public void UploadDataAsync(Uri address, string method, byte[] data)
        {
            UnderlyingObject.UploadDataAsync(address, method, data);
        }

        /// <inheritdoc />
        public void UploadDataAsync(Uri address, string method, byte[] data, object userToken)
        {
            UnderlyingObject.UploadDataAsync(address, method, data, userToken);
        }

        /// <inheritdoc />
        public byte[] UploadFile(string address, string fileName)
        {
            return UnderlyingObject.UploadFile(address, fileName);
        }

        /// <inheritdoc />
        public byte[] UploadFile(string address, string method, string fileName)
        {
            return UnderlyingObject.UploadFile(address, method, fileName);
        }

        /// <inheritdoc />
        public byte[] UploadFile(Uri address, string fileName)
        {
            return UnderlyingObject.UploadFile(address, fileName);
        }

        /// <inheritdoc />
        public byte[] UploadFile(Uri address, string method, string fileName)
        {
            return UnderlyingObject.UploadFile(address, method, fileName);
        }

        /// <inheritdoc />
        public void UploadFileAsync(Uri address, string fileName)
        {
            UnderlyingObject.UploadFileAsync(address, fileName);
        }

        /// <inheritdoc />
        public void UploadFileAsync(Uri address, string method, string fileName)
        {
            UnderlyingObject.UploadFileAsync(address, method, fileName);
        }

        /// <inheritdoc />
        public void UploadFileAsync(Uri address, string method, string fileName, object userToken)
        {
            UnderlyingObject.UploadFileAsync(address, method, fileName, userToken);
        }

        /// <inheritdoc />
        public string UploadString(string address, string data)
        {
            return UnderlyingObject.UploadString(address, data);
        }

        /// <inheritdoc />
        public string UploadString(string address, string method, string data)
        {
            return UnderlyingObject.UploadString(address, method, data);
        }

        /// <inheritdoc />
        public string UploadString(Uri address, string data)
        {
            return UnderlyingObject.UploadString(address, data);
        }

        /// <inheritdoc />
        public string UploadString(Uri address, string method, string data)
        {
            return UnderlyingObject.UploadString(address, method, data);
        }

        /// <inheritdoc />
        public void UploadStringAsync(Uri address, string data)
        {
            UnderlyingObject.UploadStringAsync(address, data);
        }

        /// <inheritdoc />
        public void UploadStringAsync(Uri address, string method, string data)
        {
            UnderlyingObject.UploadStringAsync(address, method, data);
        }

        /// <inheritdoc />
        public void UploadStringAsync(Uri address, string method, string data, object userToken)
        {
            UnderlyingObject.UploadStringAsync(address, method, data, userToken);
        }

        /// <inheritdoc />
        public byte[] UploadValues(string address, NameValueCollection data)
        {
            return UnderlyingObject.UploadValues(address, data);
        }

        /// <inheritdoc />
        public byte[] UploadValues(string address, string method, NameValueCollection data)
        {
            return UnderlyingObject.UploadValues(address, method, data);
        }

        /// <inheritdoc />
        public byte[] UploadValues(Uri address, NameValueCollection data)
        {
            return UnderlyingObject.UploadValues(address, data);
        }

        /// <inheritdoc />
        public byte[] UploadValues(Uri address, string method, NameValueCollection data)
        {
            return UnderlyingObject.UploadValues(address, method, data);
        }

        /// <inheritdoc />
        public void UploadValuesAsync(Uri address, NameValueCollection data)
        {
            UnderlyingObject.UploadValuesAsync(address, data);
        }

        /// <inheritdoc />
        public void UploadValuesAsync(Uri address, string method, NameValueCollection data)
        {
            UnderlyingObject.UploadValuesAsync(address, method, data);
        }

        /// <inheritdoc />
        public void UploadValuesAsync(Uri address, string method, NameValueCollection data, object userToken)
        {
            UnderlyingObject.UploadValuesAsync(address, method, data, userToken);
        }


        /// <inheritdoc />
        public event EventHandler Disposed
        {
            add { UnderlyingObject.Disposed += value; }
            remove { UnderlyingObject.Disposed -= value; }
        }

        /// <inheritdoc />
        public event DownloadDataCompletedEventHandler DownloadDataCompleted
        {
            add { UnderlyingObject.DownloadDataCompleted += value; }
            remove { UnderlyingObject.DownloadDataCompleted -= value; }
        }

        /// <inheritdoc />
        public event AsyncCompletedEventHandler DownloadFileCompleted
        {
            add { UnderlyingObject.DownloadFileCompleted += value; }
            remove { UnderlyingObject.DownloadFileCompleted -= value; }
        }

        /// <inheritdoc />
        public event DownloadProgressChangedEventHandler DownloadProgressChanged
        {
            add { UnderlyingObject.DownloadProgressChanged += value; }
            remove { UnderlyingObject.DownloadProgressChanged -= value; }
        }

        /// <inheritdoc />
        public event DownloadStringCompletedEventHandler DownloadStringCompleted
        {
            add { UnderlyingObject.DownloadStringCompleted += value; }
            remove { UnderlyingObject.DownloadStringCompleted -= value; }
        }

        /// <inheritdoc />
        public event OpenReadCompletedEventHandler OpenReadCompleted
        {
            add { UnderlyingObject.OpenReadCompleted += value; }
            remove { UnderlyingObject.OpenReadCompleted -= value; }
        }

        /// <inheritdoc />
        public event OpenWriteCompletedEventHandler OpenWriteCompleted
        {
            add { UnderlyingObject.OpenWriteCompleted += value; }
            remove { UnderlyingObject.OpenWriteCompleted -= value; }
        }

        /// <inheritdoc />
        public event UploadDataCompletedEventHandler UploadDataCompleted
        {
            add { UnderlyingObject.UploadDataCompleted += value; }
            remove { UnderlyingObject.UploadDataCompleted -= value; }
        }

        /// <inheritdoc />
        public event UploadFileCompletedEventHandler UploadFileCompleted
        {
            add { UnderlyingObject.UploadFileCompleted += value; }
            remove { UnderlyingObject.UploadFileCompleted -= value; }
        }

        /// <inheritdoc />
        public event UploadProgressChangedEventHandler UploadProgressChanged
        {
            add { UnderlyingObject.UploadProgressChanged += value; }
            remove { UnderlyingObject.UploadProgressChanged -= value; }
        }

        /// <inheritdoc />
        public event UploadStringCompletedEventHandler UploadStringCompleted
        {
            add { UnderlyingObject.UploadStringCompleted += value; }
            remove { UnderlyingObject.UploadStringCompleted -= value; }
        }

        /// <inheritdoc />
        public event UploadValuesCompletedEventHandler UploadValuesCompleted
        {
            add { UnderlyingObject.UploadValuesCompleted += value; }
            remove { UnderlyingObject.UploadValuesCompleted -= value; }
        }

    }
}