using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using UnitWrappers.System.Security.AccessControl;

namespace UnitWrappers.System.IO
{
	/// <summary>
	/// Wrapper for <see cref="T:System.IO.FileInfo"/> class.
	/// </summary>
	[Serializable, ComVisible(true)]
	public class FileInfoWrap : IFileInfo,IWrap<FileInfo>
	{
        public FileInfo _underlyingObject;

        FileInfo IWrap<FileInfo>.UnderlyingObject { get { return _underlyingObject; } }

        public static implicit operator FileInfoWrap(FileInfo o)
        {
            return new FileInfoWrap(o);
        }

        public static implicit operator FileInfo(FileInfoWrap o)
        {
            return o._underlyingObject;
        }

		/// <summary>
		/// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.FileInfoWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="fileInfo">A <see cref="T:System.IO.FileInfo"/> object.</param>
		public FileInfoWrap(FileInfo fileInfo)
		{
            _underlyingObject = fileInfo;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.FileInfoWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="fileName">The fully qualified name of the new file, or the relative file name.</param>
		public FileInfoWrap(string fileName)
		{
            _underlyingObject = new FileInfo(fileName);
		}


		public FileAttributes Attributes
		{
			get { return _underlyingObject.Attributes; }
			set { _underlyingObject.Attributes = value; }
		}

		public DateTime CreationTime
		{
			get { return _underlyingObject.CreationTime; }
			set { _underlyingObject.CreationTime = value; }
		}

		public DateTime CreationTimeUtc
		{
			get { return _underlyingObject.CreationTimeUtc; }
			set { _underlyingObject.CreationTimeUtc = value; }
		}

		public IDirectoryInfo Directory
		{
			get { return new DirectoryInfoWrap(_underlyingObject.Directory); }
		}

		public string DirectoryName
		{
			get { return _underlyingObject.DirectoryName; }
		}

		public bool Exists
		{
			get { return _underlyingObject.Exists; }
		}

		public string Extension
		{
			get { return _underlyingObject.Extension; }
		}

		public string FullName
		{
			get { return _underlyingObject.FullName; }
		}

		public bool IsReadOnly
		{
			get { return _underlyingObject.IsReadOnly; }
			set { _underlyingObject.IsReadOnly = value; }
		}

		public DateTime LastAccessTime
		{
			get { return _underlyingObject.LastAccessTime; }
			set { _underlyingObject.LastAccessTime = value; }
		}

		public DateTime LastAccessTimeUtc
		{
			get { return _underlyingObject.LastAccessTimeUtc; }
			set { _underlyingObject.LastAccessTimeUtc = value; }
		}

		public DateTime LastWriteTime
		{
			get { return _underlyingObject.LastWriteTime; }
			set { _underlyingObject.LastWriteTime = value; }
		}

		public DateTime LastWriteTimeUtc
		{
			get { return _underlyingObject.LastWriteTimeUtc; }
			set { _underlyingObject.LastWriteTimeUtc = value; }
		}

		public long Length
		{
			get { return _underlyingObject.Length; }
		}

		public string Name
		{
			get { return _underlyingObject.Name; }
		}

		public IStreamWriter AppendText()
		{
			return new StreamWriterWrap(_underlyingObject.AppendText());
		}

		public void Decrypt()
		{
			_underlyingObject.Decrypt();
		}

		public void Delete()
		{
			_underlyingObject.Delete();
		}

		public void Encrypt()
		{
			_underlyingObject.Encrypt();
		}

		public IFileInfo CopyTo(string destFileName)
		{
			return new FileInfoWrap(_underlyingObject.CopyTo(destFileName));
		}

		public IFileInfo CopyTo(string destFileName, bool overwrite)
		{
			return new FileInfoWrap(_underlyingObject.CopyTo(destFileName, overwrite));
		}

		public IFileStream Create()
		{
			return new FileStreamWrap(_underlyingObject.Create());
		}

		public IStreamWriter CreateText()
		{
			return new StreamWriterWrap(_underlyingObject.CreateText());
		}

		public IFileSecurity GetAccessControl()
		{
			return new FileSecurityWrap(_underlyingObject.GetAccessControl());
		}

		public IFileSecurity GetAccessControl(AccessControlSections includeSections)
		{
			return new FileSecurityWrap(_underlyingObject.GetAccessControl(includeSections));
		}

		public void MoveTo(string destFileName)
		{
			_underlyingObject.MoveTo(destFileName);
		}

		public IFileStream Open(FileMode mode)
		{
			return new FileStreamWrap(_underlyingObject.Open(mode));
		}

		public IFileStream Open(FileMode mode, FileAccess access)
		{
			return new FileStreamWrap(_underlyingObject.Open(mode, access));
		}

		public IFileStream Open(FileMode mode, FileAccess access, FileShare share)
		{
			return new FileStreamWrap(_underlyingObject.Open(mode, access, share));
		}

		public IFileStream OpenRead()
		{
			return new FileStreamWrap(_underlyingObject.OpenRead());
		}

		public IStreamReader OpenText()
		{
			return new StreamReaderWrap(_underlyingObject.OpenText());
		}

		public IFileStream OpenWrite()
		{
			return new FileStreamWrap(_underlyingObject.OpenWrite());
		}

		public void Refresh()
		{
			_underlyingObject.Refresh();
		}

		public IFileInfo Replace(string destinationFileName, string destinationBackupFileName)
		{
			return new FileInfoWrap(_underlyingObject.Replace(destinationFileName, destinationBackupFileName));
		}

		public IFileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
		{
			return new FileInfoWrap(_underlyingObject.Replace(destinationFileName, destinationBackupFileName, ignoreMetadataErrors));
		}

		public void SetAccessControl(IFileSecurity fileSecurity)
		{
			_underlyingObject.SetAccessControl(fileSecurity.FileSecurityInstance);
		}

		public override string ToString()
		{
			return _underlyingObject.ToString();
		}

		internal static IFileInfo[] ConvertFileInfoArrayIntoIFileInfoWrapArray(FileInfo[] fileInfos)
		{
			FileInfoWrap[] fileInfoWraps = new FileInfoWrap[fileInfos.Length];
			for (int i = 0; i < fileInfos.Length; i++)
				fileInfoWraps[i] = new FileInfoWrap(fileInfos[i]);
			return fileInfoWraps;
		}
	}
}