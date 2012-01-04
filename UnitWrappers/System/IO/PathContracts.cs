using System;
using System.Diagnostics.Contracts;

namespace UnitWrappers.System.IO
{
    [ContractClassFor(typeof(IPath))]
    internal abstract class PathContracts : IPath
    {
        public abstract char AltDirectorySeparatorChar { get; }
        public abstract char DirectorySeparatorChar { get; }
        public abstract char PathSeparator { get; }
        public abstract char VolumeSeparatorChar { get; }
        
        [Pure]
        string IPath.ChangeExtension(string path, string extension)
        {
            Contract.Ensures(Contract.Result<string>() != null || path == null);
            return default(string);
        }

        [Pure]
        string IPath.Combine(string path1, string path2)
        {
            Contract.Requires(path1!=null);
            Contract.Requires(path2 != null);
            return default(string);
        }

        public abstract string Combine(string path1, string path2, string path3);
        public abstract string Combine(string path1, string path2, string path3, string path4);
        public abstract string Combine(params string[] paths);
        public abstract string GetDirectoryName(string path);
        public abstract string GetExtension(string path);
        public abstract string GetFileName(string path);
        public abstract string GetFileNameWithoutExtension(string path);
        public abstract string GetFullPath(string path);
        public abstract char[] GetInvalidFileNameChars();
        public abstract char[] GetInvalidPathChars();
        public abstract string GetPathRoot(string path);
        public abstract string GetRandomFileName();
        public abstract string GetTempFileName();
        public abstract string GetTempPath();
        public abstract bool HasExtension(string path);
        public abstract bool IsPathRooted(string path);
    }
}