using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.AccessControl;

namespace UnitWrappers.System.Security.AccessControl
{
    public class DirectorySecurityWrap : FileSystemSecurityWrap, IWrap<DirectorySecurity>,IDirectorySecurity
    {
        private DirectorySecurity _underlyingObject;

        public DirectorySecurityWrap(DirectorySecurity directorySecurity):base(directorySecurity)
        {
            _underlyingObject = directorySecurity;
        }

        DirectorySecurity IWrap<DirectorySecurity>.UnderlyingObject
        {
            get { return _underlyingObject; }
        }

        public static implicit operator DirectorySecurityWrap(DirectorySecurity o)
        {
            return new DirectorySecurityWrap(o);
        }

        public static implicit operator DirectorySecurity(DirectorySecurityWrap o)
        {
            return o._underlyingObject;
        }

    }

}
