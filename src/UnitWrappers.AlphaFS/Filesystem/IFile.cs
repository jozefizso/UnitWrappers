using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitWrappers.Alphaleonis.Win32.Filesystem
{
    public interface IFile : UnitWrappers.System.IO.IFile
    {
        void Compress(string path);
    }
}
