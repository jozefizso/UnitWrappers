namespace UnitWrappers.System.Threading
{
    public interface IWaitHandleSystem
    {
        bool  WaitAll(IWaitHandle[] waitHandles);
    }
}