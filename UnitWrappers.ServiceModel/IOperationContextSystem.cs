using System.ServiceModel;

namespace UnitWrappers.System.ServiceModel
{
    /// <summary>
    /// Wraps static members of <see cref="OperationContext"/>
    /// </summary>
    public interface IOperationContextSystem
    {
        IOperationContext Current { get; set; }
    }
}