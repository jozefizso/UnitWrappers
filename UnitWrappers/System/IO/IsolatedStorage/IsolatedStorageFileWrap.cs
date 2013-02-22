using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;

namespace UnitWrappers.System.IO.IsolatedStorage
{
    public class IsolatedStorageFileWrap : IIsolatedStorageFile,IWrap<IsolatedStorageFile>
    {
        private IsolatedStorageFile _underlyingObject;

        public IsolatedStorageFileWrap(IsolatedStorageFile isolatedStorageFile)
        {
            _underlyingObject = isolatedStorageFile;
        }

         IsolatedStorageFile IWrap<IsolatedStorageFile>.UnderlyingObject { get { return _underlyingObject; } }
    }
}
