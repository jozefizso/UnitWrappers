using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using SystemWrapper.Security.AccessControl;

namespace SystemWrapper.IO
{
	/// <summary>
	/// Wrapper for <see cref="T:System.IO.FileInfo"/> class.
	/// </summary>
	[Serializable, ComVisible(true)]
	public class FileInfoWrap : IFileInfo
	{
		#region Constructors and Initializers

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileInfoWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="fileInfo">A <see cref="T:System.IO.FileInfo"/> object.</param>
		public FileInfoWrap(FileInfo fileInfo)
		{
			Initialize(fileInfo);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileInfoWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="fileInfo">A <see cref="T:System.IO.FileInfo"/> object.</param>
		public void Initialize(FileInfo fileInfo)
		{
			FileInfoInstance = fileInfo;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileInfoWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="fileName">The fully qualified name of the new file, or the relative file name.</param>
		public FileInfoWrap(string fileName)
		{
			Initialize(fileName);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileInfoWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="fileName">The fully qualified name of the new file, or the relative file name.</param>
		public void Initialize(string fileName)
		{
			FileInfoInstance = new FileInfo(fileName);
		}

		#endregion

		public FileAttributes Attributes
		{
			get { return FileInfoInstance.Attributes; }
			set { FileInfoInstance.Attributes = value; }
		}

		public DateTime CreationTime
		{
			get { return FileInfoInstance.CreationTime; }
			set { FileInfoInstance.CreationTime = value; }
		}

		public DateTime CreationTimeUtc
		{
			get { return FileInfoInstance.CreationTimeUtc; }
			set { FileInfoInstance.CreationTimeUtc = value; }
		}

		public IDirectoryInfo Directory
		{
			get { return new DirectoryInfoWrap(FileInfoInstance.Directory); }
		}

		public string DirectoryName
		{
			get { return FileInfoInstance.DirectoryName; }
		}

		public bool Exists
		{
			get { return FileInfoInstance.Exists; }
		}

		public string Extension
		{
			get { return FileInfoInstance.Extension; }
		}

		public FileInfo FileInfoInstance { get; private set; }

		public string FullName
		{
			get { return FileInfoInstance.FullName; }
		}

		public bool IsReadOnly
		{
			get { return FileInfoInstance.IsReadOnly; }
			set { FileInfoInstance.IsReadOnly = value; }
		}

		public DateTime LastAccessTime
		{
			get { return FileInfoInstance.LastAccessTime; }
			set { FileInfoInstance.LastAccessTime = value; }
		}

		public DateTime LastAccessTimeUtc
		{
			get { return FileInfoInstance.LastAccessTimeUtc; }
			set { FileInfoInstance.LastAccessTimeUtc = value; }
		}

		public DateTime LastWriteTime
		{
			get { return FileInfoInstance.LastWriteTime; }
			set { FileInfoInstance.LastWriteTime = value; }
		}

		public DateTime LastWriteTimeUtc
		{
			get { return FileInfoInstance.LastWriteTimeUtc; }
			set { FileInfoInstance.LastWriteTimeUtc = value; }
		}

		public long Length
		{
			get { return FileInfoInstance.Length; }
		}

		public string Name
		{
			get { return FileInfoInstance.Name; }
		}

		public IStreamWriter AppendText()
		{
			return new StreamWriterWrap(FileInfoInstance.AppendText());
		}

		public void Decrypt()
		{
			FileInfoInstance.Decrypt();
		}

		public void Delete()
		{
			FileInfoInstance.Delete();
		}

		public void Encrypt()
		{
			FileInfoInstance.Encrypt();
		}

		public IFileInfo CopyTo(string destFileName)
		{
			return new FileInfoWrap(FileInfoInstance.CopyTo(destFileName));
		}

		public IFileInfo CopyTo(string destFileName, bool overwrite)
		{
			return new FileInfoWrap(FileInfoInstance.CopyTo(destFileName, overwrite));
		}

		public IFileStream Create()
		{
			return new FileStreamWrap(FileInfoInstance.Create());
		}

		public IStreamWriter CreateText()
		{
			return new StreamWriterWrap(FileInfoInstance.CreateText());
		}

		public IFileSecurity GetAccessControl()
		{
			return new FileSecurityWrap(FileInfoInstance.GetAccessControl());
		}

		public IFileSecurity GetAccessControl(AccessControlSections includeSections)
		{
			return new FileSecurityWrap(FileInfoInstance.GetAccessControl(includeSections));
		}

		public void MoveTo(string destFileName)
		{
			FileInfoInstance.MoveTo(destFileName);
		}

		public IFileStream Open(FileMode mode)
		{
			return new FileStreamWrap(FileInfoInstance.Open(mode));
		}

		public IFileStream Open(FileMode mode, FileAccess access)
		{
			return new FileStreamWrap(FileInfoInstance.Open(mode, access));
		}

		public IFileStream Open(FileMode mode, FileAccess access, FileShare share)
		{
			return new FileStreamWrap(FileInfoInstance.Open(mode, access, share));
		}

		public IFileStream OpenRead()
		{
			return new FileStreamWrap(FileInfoInstance.OpenRead());
		}

		public IStreamReader OpenText()
		{
			return new StreamReaderWrap(FileInfoInstance.OpenText());
		}

		public IFileStream OpenWrite()
		{
			return new FileStreamWrap(FileInfoInstance.OpenWrite());
		}

		public void Refresh()
		{
			FileInfoInstance.Refresh();
		}

		public IFileInfo Replace(string destinationFileName, string destinationBackupFileName)
		{
			return new FileInfoWrap(FileInfoInstance.Replace(destinationFileName, destinationBackupFileName));
		}

		public IFileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
		{
			return new FileInfoWrap(FileInfoInstance.Replace(destinationFileName, destinationBackupFileName, ignoreMetadataErrors));
		}

		public void SetAccessControl(IFileSecurity fileSecurity)
		{
			FileInfoInstance.SetAccessControl(fileSecurity.FileSecurityInstance);
		}

		public override string ToString()
		{
			return FileInfoInstance.ToString();
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