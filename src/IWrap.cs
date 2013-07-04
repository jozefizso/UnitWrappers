namespace UnitWrappers
{

    /// <summary>
    /// Should always be implemented explicitly.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IWrap<out T>
    {
        T UnderlyingObject { get; }
    }
}