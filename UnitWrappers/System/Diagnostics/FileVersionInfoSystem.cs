namespace UnitWrappers.System.Diagnostics
{
    public class FileVersionInfoSystem:IFileVersionInfoSystem
    {
        public IFileVersionInfo GetVersionInfo(string fileName)
        {
            return new FileVersionInfoWrap(global::System.Diagnostics.FileVersionInfo.GetVersionInfo(fileName));
        }
    }
}