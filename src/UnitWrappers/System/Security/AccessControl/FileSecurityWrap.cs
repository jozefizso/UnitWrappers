using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.AccessControl;

namespace UnitWrappers.System.Security.AccessControl
{
    public class FileSecurityWrap : FileSystemSecurityWrap, IWrap<FileSecurity>,IFileSecurity
    {
        private FileSecurity _underlyingObject;
        FileSecurity IWrap<FileSecurity>.UnderlyingObject
        {
            get { return _underlyingObject; }
        }

        public static implicit operator FileSecurityWrap(FileSecurity o)
        {
            return new FileSecurityWrap(o);
        }

        public static implicit operator FileSecurity(FileSecurityWrap o)
        {
            return o._underlyingObject;
        }

        public FileSecurityWrap(FileSecurity fileSecurity)
            : base(fileSecurity)
        {
            _underlyingObject = fileSecurity;
        }

        

    }

}
