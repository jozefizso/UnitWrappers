

namespace UnitWrappers.System.IO
{
    public class FileInfoSystem : IFileInfoSystem
    {
        public IFileInfo CreateFileInfo(string fileName)
        {
            return new FileInfoWrap(fileName);
        }
    }
}