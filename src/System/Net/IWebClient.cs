using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;

namespace UnitWrappers.System.Net
{
#if !PORTABLE && !MONO
    [ComVisible(true)]
#endif
    public interface IWebClient : IComponent
    {
        WebClient UnderlyingObject { get; }

        /// <inheritdoc />
        string BaseAddress { get; set; }

        RequestCachePolicy CachePolicy { get; set; }

        /// <inheritdoc />
        IContainer Container { get;  }

        /// <inheritdoc />
        ICredentials Credentials { get; set; }

        /// <inheritdoc />
        Encoding Encoding { get; set; }

        /// <inheritdoc />
        WebHeaderCollection Headers { get; set; }

        /// <inheritdoc />
        bool IsBusy { get;  }

        /// <inheritdoc />
        IWebProxy Proxy { get; set; }

        /// <inheritdoc />
        NameValueCollection QueryString { get; set; }

        /// <inheritdoc />
        WebHeaderCollection ResponseHeaders { get;  }

        /// <inheritdoc />
        bool UseDefaultCredentials { get; set; }

        /// <inheritdoc />
        void CancelAsync();

        /// <inheritdoc />
        ObjRef CancelAsync(Type requestedType);

        /// <inheritdoc />
        byte[] DownloadData(string address);

        /// <inheritdoc />
        byte[] DownloadData(Uri address);

        /// <inheritdoc />
        void DownloadDataAsync(Uri address);

        /// <inheritdoc />
        void DownloadDataAsync(Uri address, object userToken);

        /// <inheritdoc />
        void DownloadFile(string address, string fileName);

        /// <inheritdoc />
        void DownloadFile(Uri address, string fileName);

        /// <inheritdoc />
        void DownloadFileAsync(Uri address, string fileName);

        /// <inheritdoc />
        void DownloadFileAsync(Uri address, string fileName, object userToken);

        /// <inheritdoc />
        string DownloadString(string address);

        /// <inheritdoc />
        string DownloadString(Uri address);

        /// <inheritdoc />
        void DownloadStringAsync(Uri address);

        /// <inheritdoc />
        void DownloadStringAsync(Uri address, object userToken);

        /// <inheritdoc />
        object InitializeLifetimeService();

        /// <inheritdoc />
        Stream OpenRead(string address);

        /// <inheritdoc />
        Stream OpenRead(Uri address);

        /// <inheritdoc />
        void OpenReadAsync(Uri address);

        /// <inheritdoc />
        void OpenReadAsync(Uri address, object userToken);

        /// <inheritdoc />
        Stream OpenWrite(string address);

        /// <inheritdoc />
        Stream OpenWrite(Uri address);

        /// <inheritdoc />
        Stream OpenWrite(string address, string method);

        /// <inheritdoc />
        Stream OpenWrite(Uri address, string method);

        /// <inheritdoc />
        void OpenWriteAsync(Uri address);

        /// <inheritdoc />
        void OpenWriteAsync(Uri address, string method);

        /// <inheritdoc />
        void OpenWriteAsync(Uri address, string method, object userToken);

        /// <inheritdoc />
        byte[] UploadData(string address, byte[] data);

        /// <inheritdoc />
        byte[] UploadData(string address, string method, byte[] data);

        /// <inheritdoc />
        byte[] UploadData(Uri address, byte[] data);

        /// <inheritdoc />
        byte[] UploadData(Uri address, string method, byte[] data);

        /// <inheritdoc />
        void UploadDataAsync(Uri address, byte[] data);

        /// <inheritdoc />
        void UploadDataAsync(Uri address, string method, byte[] data);

        /// <inheritdoc />
        void UploadDataAsync(Uri address, string method, byte[] data, object userToken);

        /// <inheritdoc />
        byte[] UploadFile(string address, string fileName);

        /// <inheritdoc />
        byte[] UploadFile(string address, string method, string fileName);

        /// <inheritdoc />
        byte[] UploadFile(Uri address, string fileName);

        /// <inheritdoc />
        byte[] UploadFile(Uri address, string method, string fileName);

        /// <inheritdoc />
        void UploadFileAsync(Uri address, string fileName);

        /// <inheritdoc />
        void UploadFileAsync(Uri address, string method, string fileName);

        /// <inheritdoc />
        void UploadFileAsync(Uri address, string method, string fileName, object userToken);

        /// <inheritdoc />
        string UploadString(string address, string data);

        /// <inheritdoc />
        string UploadString(string address, string method, string data);

        /// <inheritdoc />
        string UploadString(Uri address, string data);

        /// <inheritdoc />
        string UploadString(Uri address, string method, string data);

        /// <inheritdoc />
        void UploadStringAsync(Uri address, string data);

        /// <inheritdoc />
        void UploadStringAsync(Uri address, string method, string data);

        /// <inheritdoc />
        void UploadStringAsync(Uri address, string method, string data, object userToken);

        /// <inheritdoc />
        byte[] UploadValues(string address, NameValueCollection data);

        /// <inheritdoc />
        byte[] UploadValues(string address, string method, NameValueCollection data);

        /// <inheritdoc />
        byte[] UploadValues(Uri address, NameValueCollection data);

        /// <inheritdoc />
        byte[] UploadValues(Uri address, string method, NameValueCollection data);

        /// <inheritdoc />
        void UploadValuesAsync(Uri address, NameValueCollection data);

        /// <inheritdoc />
        void UploadValuesAsync(Uri address, string method, NameValueCollection data);

        /// <inheritdoc />
        void UploadValuesAsync(Uri address, string method, NameValueCollection data, object userToken);

        /// <inheritdoc />
        event DownloadDataCompletedEventHandler DownloadDataCompleted;

        /// <inheritdoc />
        event AsyncCompletedEventHandler DownloadFileCompleted;

        /// <inheritdoc />
        event DownloadProgressChangedEventHandler DownloadProgressChanged;

        /// <inheritdoc />
        event DownloadStringCompletedEventHandler DownloadStringCompleted;

        /// <inheritdoc />
        event OpenReadCompletedEventHandler OpenReadCompleted;

        /// <inheritdoc />
        event OpenWriteCompletedEventHandler OpenWriteCompleted;

        /// <inheritdoc />
        event UploadDataCompletedEventHandler UploadDataCompleted;

        /// <inheritdoc />
        event UploadFileCompletedEventHandler UploadFileCompleted;

        /// <inheritdoc />
        event UploadProgressChangedEventHandler UploadProgressChanged;

        /// <inheritdoc />
        event UploadStringCompletedEventHandler UploadStringCompleted;

        /// <inheritdoc />
        event UploadValuesCompletedEventHandler UploadValuesCompleted;
    }
}
