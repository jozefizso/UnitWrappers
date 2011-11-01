using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;

namespace UnitWrappers.System.IO.IsolatedStorage
{
    public class IsolatedStorageFileWrap
    {
        public IsolatedStorageFileWrap(IsolatedStorageFile isolatedStorageFile)
        {
            UnderlyingObject = isolatedStorageFile;
        }

        protected IsolatedStorageFile UnderlyingObject { get;private set; }
    }
}
