namespace UnitWrappers
{

    public interface IWrap<out T>
    {
        T UnderlyingObject { get; }
    }
}