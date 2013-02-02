using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace UnitWrappers.System.Diagnostics
{
    public class FileVersionInfoWrap:IFileVersionInfo
    {
        public FileVersionInfo GetVersionInfo(string fileName)
        {
            return global::System.Diagnostics.FileVersionInfo.GetVersionInfo(fileName);
        }
    }

    public interface IFileVersionInfo   
    {
    }
}
