using System.Security.AccessControl;
using System.Security.Permissions;

namespace UnitWrappers.System.Security.Permissions
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPermissionsFactory
    {
        IFileIOPermission CreateFileIOPermission(PermissionState state);


        IFileIOPermission CreateFileIOPermission(FileIOPermissionAccess access, string path);

        IFileIOPermission CreateFileIOPermission(FileIOPermissionAccess access, string[] pathList);


        IFileIOPermission CreateFileIOPermission(FileIOPermissionAccess access, AccessControlActions control,
                                                 string path);

        IFileIOPermission CreateFileIOPermission(FileIOPermissionAccess access, AccessControlActions control,
                                                 string[] pathList);

    }


}