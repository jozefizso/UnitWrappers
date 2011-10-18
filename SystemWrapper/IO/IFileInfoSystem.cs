namespace SystemWrapper.IO
{
    public interface IFileInfoSystem
    {
        IFileInfo GetFileInfo(string fileName);
    }
}