namespace UnitWrappers.System.ServiceModel
{
    /// <summary>
    /// 
    /// </summary>
    public interface IOperationContextSystem
    {
        IOperationContext Current { get; set; }
    }
}