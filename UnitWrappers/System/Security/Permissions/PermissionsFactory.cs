using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Text;

namespace UnitWrappers.System.Security.Permissions
{
    /// <summary>
    /// 
    /// </summary>
    public class PermissionsFactory : IPermissionsFactory
    {

        public IFileIOPermission CreateFileIOPermission(PermissionState state)
        {
            return new FileIOPermissionWrap(state);
        }

        public IFileIOPermission CreateFileIOPermission(FileIOPermissionAccess access, string path)
        {
            return new FileIOPermissionWrap(access, path);
        }

        public IFileIOPermission CreateFileIOPermission(FileIOPermissionAccess access, string[] pathList)
        {
            return new FileIOPermissionWrap(access, pathList);
        }

        public IFileIOPermission CreateFileIOPermission(FileIOPermissionAccess access, AccessControlActions control, string path)
        {
            return new FileIOPermissionWrap(access, control,path);
        }

        public IFileIOPermission CreateFileIOPermission(FileIOPermissionAccess access, AccessControlActions control, string[] pathList)
        {
            return new FileIOPermissionWrap(access, control, pathList);
        }
    }
}
