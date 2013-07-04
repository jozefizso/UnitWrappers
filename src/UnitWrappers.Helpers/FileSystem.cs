using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitWrappers.System.IO;

namespace UnitWrappers.Helpers
{
    public class FileSystem
    {
        public IDirectory Directory { get; set; }
        public IFile File { get; set; }
        public IPath Path { get; set; }
    }
}
