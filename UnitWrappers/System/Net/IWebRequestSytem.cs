using System;
using System.Net;
using System.Net.Cache;

namespace UnitWrappers.System.Net
{
    public interface IWebRequestSytem
    {
        WebRequest Create(Uri requestUri);

        WebRequest Create(string requestUriString);

        WebRequest CreateDefault(Uri requestUri);

        IWebProxy GetSystemWebProxy();

        bool RegisterPrefix(string prefix, IWebRequestCreate creator);

        RequestCachePolicy DefaultCachePolicy { get; set; }
    }
}