using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using SystemWrapper.Security.AccessControl;

namespace SystemWrapper.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.File"/> class.
    /// </summary>
    [Serializable, ComVisible(true)]
    public class FileWrap : IFile
    {
        public void AppendAllText(string path, string contents)
        {
            File.AppendAllText(path, contents);
        }

        public void AppendAllText(string path, string contents, Encoding encoding)
        {
            File.AppendAllText(path, contents, encoding);
        }

        public IStreamWriter AppendText(string path)
        {
            return new StreamWriterWrap(File.AppendText(path));
        }

        public void Copy(string sourceFileName, string destFileName)
        {
            File.Copy(sourceFileName, destFileName);
        }

        public void Copy(string sourceFileName, string destFileName, bool overwrite)
        {
            File.Copy(sourceFileName, destFileName, overwrite);
        }

        public IFileStream Create(string path)
        {
            return new FileStreamWrap(File.Create(path));
        }

        public IFileStream Create(string path, int bufferSize)
        {
            return new FileStreamWrap(File.Create(path, bufferSize));
        }

        public IFileStream Create(string path, int bufferSize, FileOptions options)
        {
            return new FileStreamWrap(File.Create(path, bufferSize, options));
        }

        public IFileStream Create(string path, int bufferSize, FileOptions options, IFileSecurity fileSecurity)
        {
            return new FileStreamWrap(File.Create(path, bufferSize, options, fileSecurity.FileSecurityInstance));
        }

        public IStreamWriter CreateText(string path)
        {
            return new StreamWriterWrap(File.CreateText(path));
        }

        public void Decrypt(string path)
        {
            File.Decrypt(path);
        }

        public void Delete(string path)
        {
            File.Delete(path);
        }

        public void Encrypt(string path)
        {
            File.Encrypt(path);
        }

        public bool Exists(string path)
        {
            return File.Exists(path);
        }

        public IFileSecurity GetAccessControl(string path)
        {
            return new FileSecurityWrap(File.GetAccessControl(path));
        }

        public IFileSecurity GetAccessControl(string path, AccessControlSections includeSections)
        {
            return new FileSecurityWrap(File.GetAccessControl(path, includeSections));
        }

        public FileAttributes GetAttributes(string path)
        {
            return File.GetAttributes(path);
        }

        public DateTime GetCreationTime(string path)
        {
            return File.GetCreationTime(path);
        }

        public DateTime GetCreationTimeUtc(string path)
        {
            return File.GetCreationTimeUtc(path);
        }

        public DateTime GetLastAccessTime(string path)
        {
            return File.GetLastAccessTime(path);
        }

        public DateTime GetLastAccessTimeUtc(string path)
        {
            return File.GetLastAccessTimeUtc(path);
        }

        public DateTime GetLastWriteTime(string path)
        {
            return File.GetLastWriteTime(path);
        }

        public DateTime GetLastWriteTimeUtc(string path)
        {
            return File.GetLastWriteTimeUtc(path);
        }

        public void Move(string sourceFileName, string destFileName)
        {
            File.Move(sourceFileName, destFileName);
        }

        public IFileStream Open(string path, FileMode mode)
        {
            return new FileStreamWrap(File.Open(path, mode));
        }

        public IFileStream Open(string path, FileMode mode, FileAccess access)
        {
            return new FileStreamWrap(File.Open(path, mode, access));
        }

        public IFileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
        {
            return new FileStreamWrap(File.Open(path, mode, access, share));
        }

        public IFileStream OpenRead(string path)
        {
            return new FileStreamWrap(File.OpenRead(path));
        }

        public IStreamReader OpenText(string path)
        {
            return new StreamReaderWrap(File.OpenText(path));
        }

        public IFileStream OpenWrite(string path)
        {
            return new FileStreamWrap(File.OpenWrite(path));
        }

        public byte[] ReadAllBytes(string path)
        {
            return File.ReadAllBytes(path);
        }

        public string[] ReadAllLines(string path)
        {
            return File.ReadAllLines(path);
        }

        public string[] ReadAllLines(string path, Encoding encoding)
        {
            return File.ReadAllLines(path, encoding);
        }

        public string ReadAllText(string path)
        {
            return File.ReadAllText(path);
        }

        public string ReadAllText(string path, Encoding encoding)
        {
            return File.ReadAllText(path, encoding);
        }

        public void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName)
        {
            File.Replace(sourceFileName, destinationFileName, destinationBackupFileName);
        }

        public void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
        {
            File.Replace(sourceFileName, destinationFileName, destinationBackupFileName, ignoreMetadataErrors);
        }

        public void SetAccessControl(string path, IFileSecurity fileSecurity)
        {
            File.SetAccessControl(path, fileSecurity.FileSecurityInstance);
        }

        public void SetAttributes(string path, FileAttributes fileAttributes)
        {
            File.SetAttributes(path, fileAttributes);
        }

        public void SetCreationTime(string path, DateTime creationTime)
        {
            File.SetCreationTime(path, creationTime);
        }

        public void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
        {
            File.SetCreationTimeUtc(path, creationTimeUtc);
        }

        public void SetLastAccessTime(string path, DateTime lastAccessTime)
        {
            File.SetLastAccessTime(path, lastAccessTime);
        }

        public void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
        {
            File.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
        }

        public void SetLastWriteTime(string path, DateTime lastWriteTime)
        {
            File.SetLastWriteTime(path, lastWriteTime);
        }

        public void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
        {
            File.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
        }

        public void WriteAllBytes(string path, byte[] bytes)
        {
            File.WriteAllBytes(path, bytes);
        }

        public void WriteAllLines(string path, string[] contents)
        {
            File.WriteAllLines(path, contents);
        }

        public void WriteAllLines(string path, string[] contents, Encoding encoding)
        {
            File.WriteAllLines(path, contents, encoding);
        }

        public void WriteAllText(string path, string contents)
        {
            File.WriteAllText(path, contents);
        }

        public void WriteAllText(string path, string contents, Encoding encoding)
        {
            File.WriteAllText(path, contents, encoding);
        }
    }
}
