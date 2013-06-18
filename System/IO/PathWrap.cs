using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace UnitWrappers.System.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.Path"/> class.
    /// </summary>
    [Serializable, ComVisible(true)]
    public class PathWrap : IPath
    {
        public char AltDirectorySeparatorChar
        {
            get { return Path.AltDirectorySeparatorChar; }
        }

        public char DirectorySeparatorChar
        {
            get { return Path.DirectorySeparatorChar; }
        }

        public char PathSeparator
        {
            get { return Path.PathSeparator; }
        }

        public char VolumeSeparatorChar
        {
            get { return Path.VolumeSeparatorChar; }
        }

        public string ChangeExtension(string path, string extension)
        {
            return Path.ChangeExtension(path, extension);
        }

        public string Combine(string path1, string path2)
        {
            return Path.Combine(path1, path2);
        }

        public string Combine(string path1, string path2, string path3)
        {
#if NET35
            if (path1 == null || path2 == null || path3 == null)
                throw new ArgumentNullException((path1 == null) ? "path1" : (path2 == null) ? "path2" : "path3");
            CheckInvalidPathChars(path1);
            CheckInvalidPathChars(path2);
            CheckInvalidPathChars(path3);

            return CombineNoChecks(CombineNoChecks(path1, path2), path3);
#else
            return Path.Combine(path1, path2, path3);
#endif
        }



        public string Combine(string path1, string path2, string path3, string path4)
        {
#if NET35
            if (path1 == null || path2 == null || path3 == null || path4 == null)
                throw new ArgumentNullException((path1 == null) ? "path1" : (path2 == null) ? "path2" : (path3 == null) ? "path3" : "path4");
            CheckInvalidPathChars(path1);
            CheckInvalidPathChars(path2);
            CheckInvalidPathChars(path3);
            CheckInvalidPathChars(path4);
            return CombineNoChecks(CombineNoChecks(CombineNoChecks(path1, path2), path3), path4);
#else
            return Path.Combine(path1, path2, path3,path4);
#endif
        }

        public string Combine(params string[] paths)
        {
#if NET35
            if (paths == null)
                throw new ArgumentNullException("paths");
            int capacity = 0;
            int num = 0;
            for (int index = 0; index < paths.Length; ++index)
            {
                if (paths[index] == null)
                    throw new ArgumentNullException("paths");
                if (paths[index].Length != 0)
                {
                    CheckInvalidPathChars(paths[index]);
                    if (Path.IsPathRooted(paths[index]))
                    {
                        num = index;
                        capacity = paths[index].Length;
                    }
                    else
                        capacity += paths[index].Length;
                    char ch = paths[index][paths[index].Length - 1];
                    if ((int)ch != (int)Path.DirectorySeparatorChar && (int)ch != (int)Path.AltDirectorySeparatorChar && (int)ch != (int)Path.VolumeSeparatorChar)
                        ++capacity;
                }
            }
            StringBuilder stringBuilder = new StringBuilder(capacity);
            for (int index = num; index < paths.Length; ++index)
            {
                if (paths[index].Length != 0)
                {
                    if (stringBuilder.Length == 0)
                    {
                        stringBuilder.Append(paths[index]);
                    }
                    else
                    {
                        char ch = stringBuilder[stringBuilder.Length - 1];
                        if ((int)ch != (int)Path.DirectorySeparatorChar && (int)ch != (int)Path.AltDirectorySeparatorChar && (int)ch != (int)Path.VolumeSeparatorChar)
                            stringBuilder.Append(Path.DirectorySeparatorChar);
                        stringBuilder.Append(paths[index]);
                    }
                }
            }
            return ((object)stringBuilder).ToString();
#else
            return Path.Combine(paths);
#endif
        }

#if NET35

        private string CombineNoChecks(string path1, string path2)
        {
            if (path2.Length == 0)
                return path1;
            if (path1.Length == 0 || Path.IsPathRooted(path2))
                return path2;
            char ch = path1[path1.Length - 1];
            if ((int)ch != (int)Path.DirectorySeparatorChar && (int)ch != (int)Path.AltDirectorySeparatorChar && (int)ch != (int)Path.VolumeSeparatorChar)
                return path1 + (object)Path.DirectorySeparatorChar + path2;
            else
                return path1 + path2;
        }

        private static void CheckInvalidPathChars(String path)
        {
            //do not use reflection of internal because it can fail
            //var validation = typeof(Path).GetMember("CheckInvalidPathChars", MemberTypes.Method,
            //    BindingFlags.Static | BindingFlags.InvokeMethod | BindingFlags.NonPublic)[0] as MethodInfo;
            //Debug.Assert(validation!=null);
            //validation.Invoke(null, new object[]{path});

            // adapted from sources of .NET
            for (int i = 0; i < path.Length; i++)
            {
                int c = path[i];
                // Note: This list is duplicated in static char[] InvalidPathChars
                if (c == '\"' || c == '<' || c == '>' || c == '|' || c < 32)
                    throw new ArgumentException("Illegal characters in path.");
            }
        }

#endif

        public string GetDirectoryName(string path)
        {
            return Path.GetDirectoryName(path);
        }

        public string GetExtension(string path)
        {
            return Path.GetExtension(path);
        }

        public string GetFileName(string path)
        {
            return Path.GetFileName(path);
        }

        public string GetFileNameWithoutExtension(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        public string GetFullPath(string path)
        {
            return Path.GetFullPath(path);
        }

        public char[] GetInvalidFileNameChars()
        {
            return Path.GetInvalidFileNameChars();
        }

        public char[] GetInvalidPathChars()
        {
            return Path.GetInvalidPathChars();
        }

        public string GetPathRoot(string path)
        {
            return Path.GetPathRoot(path);
        }

        public string GetRandomFileName()
        {
            return Path.GetRandomFileName();
        }

        public string GetTempFileName()
        {
            return Path.GetTempFileName();
        }

        public string GetTempPath()
        {
            return Path.GetTempPath();
        }

        public bool HasExtension(string path)
        {
            return Path.HasExtension(path);
        }

        public bool IsPathRooted(string path)
        {
            return Path.IsPathRooted(path);
        }
    }
}