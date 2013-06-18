using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Text;

namespace UnitWrappers.System.Security.Permissions
{
    [ComVisible(true)]
    [Serializable()]
    public class FileIOPermissionWrap : IFileIOPermission
    {
        public FileIOPermission UnderlyingObject { get; private set; }

        public FileIOPermissionWrap(FileIOPermission fileIOPermission)
        {
            UnderlyingObject = fileIOPermission;
        }

        public FileIOPermissionWrap(PermissionState state)
        {
            UnderlyingObject = new FileIOPermission(state);
        }

        public FileIOPermissionWrap(FileIOPermissionAccess access,string path)
        {
            UnderlyingObject = new FileIOPermission(access,path);
        }

        public FileIOPermissionWrap(FileIOPermissionAccess access, string[] pathList)
        {
            UnderlyingObject = new FileIOPermission(access, pathList);
        }


        public FileIOPermissionWrap(FileIOPermissionAccess access,AccessControlActions control,string path)
        {
            UnderlyingObject = new FileIOPermission(access,  control, path);
        }

        public FileIOPermissionWrap(FileIOPermissionAccess access, AccessControlActions control, string[] pathList)
        {
            UnderlyingObject = new FileIOPermission(access,control, pathList);
        }

        /// <inheritdoc />
        public IPermission Union(IPermission target)
        {
            return UnderlyingObject.Union(target);
        }
        /// <inheritdoc />
        public bool IsSubsetOf(IPermission target)
        {
            return UnderlyingObject.IsSubsetOf(target);
        }
        /// <inheritdoc />
        public void Assert()
        {
            UnderlyingObject.Assert();
        }
        /// <inheritdoc />
        public void Demand()
        {
            UnderlyingObject.Demand();
        }
        /// <inheritdoc />
        public void Deny()
        {
            UnderlyingObject.Deny();
        }
        /// <inheritdoc />
        public void PermitOnly()
        {
            UnderlyingObject.PermitOnly();
        }
        /// <inheritdoc />
        public SecurityElement ToXml()
        {
         return   UnderlyingObject.ToXml();
        }
        /// <inheritdoc />
        public void FromXml(SecurityElement elem)
        {
            UnderlyingObject.FromXml(elem);
        }
        /// <inheritdoc />
        public IPermission Copy()
        {
            return UnderlyingObject.Copy();
        }
        /// <inheritdoc />
        public IPermission Intersect(IPermission target)
        {
            return UnderlyingObject.Intersect(target);
        }


        /// <inheritdoc />
        public bool IsUnrestricted()
        {
            return UnderlyingObject.IsUnrestricted();
        }
    }
}
