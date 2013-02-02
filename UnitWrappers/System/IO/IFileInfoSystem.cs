namespace UnitWrappers.System.IO
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFileInfoSystem
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        IFileInfo CreateFileInfo(string fileName);
    }
}