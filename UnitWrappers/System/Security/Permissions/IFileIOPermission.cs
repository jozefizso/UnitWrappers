using System.Security;
using System.Security.Permissions;

namespace UnitWrappers.System.Security.Permissions
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFileIOPermission : IUnrestrictedPermission, ISecurityEncodable, IPermission, IStackWalk
    {

    }
}