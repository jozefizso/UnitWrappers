using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Text;

namespace UnitWrappers.System.Net
{
    public class WebRequestSystem : IWebRequestSystem
    {
        public WebRequest Create(Uri requestUri)
        {
            HttpWebRequest.Create("");
            return WebRequest.Create(requestUri);
        }

        public WebRequest Create(string requestUriString)
        {
            return WebRequest.Create(requestUriString);
        }

        public WebRequest CreateDefault(Uri requestUri)
        {
            return WebRequest.CreateDefault(requestUri);
        }

        public IWebProxy GetSystemWebProxy()
        {
            return WebRequest.GetSystemWebProxy();
        }

        public bool RegisterPrefix(string prefix, IWebRequestCreate creator)
        {
            return WebRequest.RegisterPrefix(prefix, creator);
        }

        public RequestCachePolicy DefaultCachePolicy
        {
            get { return WebRequest.DefaultCachePolicy; }
            set { WebRequest.DefaultCachePolicy = value; }
        }

        public IWebProxy DefaultWebProxy
        {
            get { return WebRequest.DefaultWebProxy; }
            set { WebRequest.DefaultWebProxy = value; }
        }
    }
}
