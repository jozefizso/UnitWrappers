using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitWrappers.System.IO;
using File = global::Alphaleonis.Win32.Filesystem.File;


namespace UnitWrappers.Alphaleonis.Win32.Filesystem
{


    public class FileWrap : UnitWrappers.Alphaleonis.Win32.Filesystem.IFile
    {

        public void AppendAllText(string path, string contents)
        {
            File.AppendAllText(path, contents);
        }

        public void Compress(string path)
        {
            File.Compress(path);
        }

        public void AppendAllText(string path, string contents, Encoding encoding)
        {
            throw new NotImplementedException();
        }

        public StreamWriterBase AppendText(string path)
        {
            throw new NotImplementedException();
        }

        public void Copy(string sourceFileName, string destFileName)
        {
            throw new NotImplementedException();
        }

        public void Copy(string sourceFileName, string destFileName, bool overwrite)
        {
            throw new NotImplementedException();
        }

        public FileStreamBase Create(string path)
        {
            throw new NotImplementedException();
        }

        public FileStreamBase Create(string path, int bufferSize)
        {
            throw new NotImplementedException();
        }

        public FileStreamBase Create(string path, int bufferSize, global::System.IO.FileOptions options)
        {
            throw new NotImplementedException();
        }

        public FileStreamBase Create(string path, int bufferSize, global::System.IO.FileOptions options, System.Security.AccessControl.IFileSecurity fileSecurity)
        {
            throw new NotImplementedException();
        }

        public StreamWriterBase CreateText(string path)
        {
            throw new NotImplementedException();
        }

        public void Decrypt(string path)
        {
            throw new NotImplementedException();
        }

        public void Delete(string path)
        {
            throw new NotImplementedException();
        }

        public void Encrypt(string path)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string path)
        {
            throw new NotImplementedException();
        }

        public System.Security.AccessControl.IFileSecurity GetAccessControl(string path)
        {
            throw new NotImplementedException();
        }

        public System.Security.AccessControl.IFileSecurity GetAccessControl(string path, global::System.Security.AccessControl.AccessControlSections includeSections)
        {
            throw new NotImplementedException();
        }

        public global::System.IO.FileAttributes GetAttributes(string path)
        {
            throw new NotImplementedException();
        }

        public DateTime GetCreationTime(string path)
        {
            throw new NotImplementedException();
        }

        public DateTime GetCreationTimeUtc(string path)
        {
            throw new NotImplementedException();
        }

        public DateTime GetLastAccessTime(string path)
        {
            throw new NotImplementedException();
        }

        public DateTime GetLastAccessTimeUtc(string path)
        {
            throw new NotImplementedException();
        }

        public DateTime GetLastWriteTime(string path)
        {
            throw new NotImplementedException();
        }

        public DateTime GetLastWriteTimeUtc(string path)
        {
            throw new NotImplementedException();
        }

        public void Move(string sourceFileName, string destFileName)
        {
            throw new NotImplementedException();
        }

        public FileStreamBase Open(string path, global::System.IO.FileMode mode)
        {
            throw new NotImplementedException();
        }

        public FileStreamBase Open(string path, global::System.IO.FileMode mode, global::System.IO.FileAccess access)
        {
            throw new NotImplementedException();
        }

        public FileStreamBase Open(string path, global::System.IO.FileMode mode, global::System.IO.FileAccess access, global::System.IO.FileShare share)
        {
            throw new NotImplementedException();
        }

        public FileStreamBase OpenRead(string path)
        {
            throw new NotImplementedException();
        }

        public StreamReaderBase OpenText(string path)
        {
            throw new NotImplementedException();
        }

        public FileStreamBase OpenWrite(string path)
        {
            throw new NotImplementedException();
        }

        public byte[] ReadAllBytes(string path)
        {
            throw new NotImplementedException();
        }

        public string[] ReadAllLines(string path)
        {
            throw new NotImplementedException();
        }

        public string[] ReadAllLines(string path, Encoding encoding)
        {
            throw new NotImplementedException();
        }

        public string ReadAllText(string path)
        {
            throw new NotImplementedException();
        }

        public string ReadAllText(string path, Encoding encoding)
        {
            throw new NotImplementedException();
        }

        public void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName)
        {
            throw new NotImplementedException();
        }

        public void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
        {
            throw new NotImplementedException();
        }

        public void SetAccessControl(string path, System.Security.AccessControl.IFileSecurity fileSecurity)
        {
            throw new NotImplementedException();
        }

        public void SetAttributes(string path, global::System.IO.FileAttributes fileAttributes)
        {
            throw new NotImplementedException();
        }

        public void SetCreationTime(string path, DateTime creationTime)
        {
            throw new NotImplementedException();
        }

        public void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
        {
            throw new NotImplementedException();
        }

        public void SetLastAccessTime(string path, DateTime lastAccessTime)
        {
            throw new NotImplementedException();
        }

        public void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
        {
            throw new NotImplementedException();
        }

        public void SetLastWriteTime(string path, DateTime lastWriteTime)
        {
            throw new NotImplementedException();
        }

        public void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
        {
            throw new NotImplementedException();
        }

        public void WriteAllBytes(string path, byte[] bytes)
        {
            throw new NotImplementedException();
        }

        public void WriteAllLines(string path, string[] contents)
        {
            throw new NotImplementedException();
        }

        public void WriteAllLines(string path, string[] contents, Encoding encoding)
        {
            throw new NotImplementedException();
        }

        public void WriteAllText(string path, string contents)
        {
            throw new NotImplementedException();
        }

        public void WriteAllText(string path, string contents, Encoding encoding)
        {
            throw new NotImplementedException();
        }

    
    }
}
