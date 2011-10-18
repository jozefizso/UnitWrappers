

namespace SystemWrapper.IO
{
    public class FileInfoSystem: IFileInfoSystem
    {
        public IFileInfo GetFileInfo(string fileName)
        {
            return  new FileInfoWrap(fileName);
        }
    }
}