using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security.AccessControl;
using UnitWrappers.System.Security.AccessControl;

namespace UnitWrappers.System.IO
{
	/// <summary>
	/// Wrapper for <see cref="T:System.IO.DirectoryInfo"/> class.
	/// </summary>
	[Serializable, ComVisible(true)]
	public class DirectoryInfoWrap : IDirectoryInfo
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.DirectoryInfoWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="directoryInfo">A <see cref="T:System.IO.DirectoryInfo"/> object.</param>
		public DirectoryInfoWrap(DirectoryInfo directoryInfo)
		{
            DirectoryInfo = directoryInfo;
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.DirectoryInfoWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="path">A string specifying the path on which to create the <see cref="T:UnitWrappers.System.IO.DirectoryInfoWrap"/>. </param>
		public DirectoryInfoWrap(string path)
		{
            DirectoryInfo = new DirectoryInfo(path);
		}


		public FileAttributes Attributes
		{
			get { return DirectoryInfo.Attributes; }
			set { DirectoryInfo.Attributes = value; }
		}

		public DateTime CreationTime
		{
			get { return DirectoryInfo.CreationTime; }
			set { DirectoryInfo.CreationTime = value; }
		}

		public DateTime CreationTimeUtc
		{
			get { return DirectoryInfo.CreationTimeUtc; }
			set { DirectoryInfo.CreationTimeUtc = value; }
		}

		public DirectoryInfo DirectoryInfo { get; private set; }

		public bool Exists
		{
			get { return DirectoryInfo.Exists; }
		}

		public string Extension
		{
			get { return DirectoryInfo.Extension; }
		}

		public string FullName
		{
			get { return DirectoryInfo.FullName; }
		}

		public DateTime LastAccessTime
		{
			get { return DirectoryInfo.LastAccessTime; }
			set { DirectoryInfo.LastAccessTime = value; }
		}

		public DateTime LastAccessTimeUtc
		{
			get { return DirectoryInfo.LastAccessTimeUtc; }
			set { DirectoryInfo.LastAccessTimeUtc = value; }
		}

		public DateTime LastWriteTime
		{
			get { return DirectoryInfo.LastWriteTime; }
			set { DirectoryInfo.LastWriteTime = value; }
		}

		public DateTime LastWriteTimeUtc
		{
			get { return DirectoryInfo.LastWriteTimeUtc; }
			set { DirectoryInfo.LastWriteTimeUtc = value; }
		}

		public string Name
		{
			get { return DirectoryInfo.Name; }
		}

		public IDirectoryInfo Parent
		{
			get { return new DirectoryInfoWrap(DirectoryInfo.Parent); }
		}

		public IDirectoryInfo Root
		{
			get { return new DirectoryInfoWrap(DirectoryInfo.Root); }
		}

		public void Create()
		{
			DirectoryInfo.Create();
		}

		public void Create(IDirectorySecurity directorySecurity)
		{
			DirectoryInfo.Create(directorySecurity.DirectorySecurityInstance);
		}

		public ObjRef CreateObjRef(Type requestedType)
		{
			return DirectoryInfo.CreateObjRef(requestedType);
		}

		public IDirectoryInfo CreateSubdirectory(string path)
		{
			return new DirectoryInfoWrap(DirectoryInfo.CreateSubdirectory(path));
		}

		public IDirectoryInfo CreateSubdirectory(string path, IDirectorySecurity directorySecurity)
		{
			return new DirectoryInfoWrap(DirectoryInfo.CreateSubdirectory(path, directorySecurity.DirectorySecurityInstance));
		}

		public void Delete()
		{
			DirectoryInfo.Delete();
		}

		public void Delete(bool recursive)
		{
			DirectoryInfo.Delete(recursive);
		}

		public IDirectorySecurity GetAccessControl()
		{
			return new DirectorySecurityWrap(DirectoryInfo.GetAccessControl());
		}

		public IDirectorySecurity GetAccessControl(AccessControlSections includeSections)
		{
			return new DirectorySecurityWrap(DirectoryInfo.GetAccessControl(includeSections));
		}

		public IDirectoryInfo[] GetDirectories()
		{
			DirectoryInfo[] directoryInfos = DirectoryInfo.GetDirectories();
			return ConvertDirectoryInfoArrayIntoIDirectoryInfoWrapArray(directoryInfos);
		}

		public IDirectoryInfo[] GetDirectories(string searchPattern)
		{
			DirectoryInfo[] directoryInfos = DirectoryInfo.GetDirectories(searchPattern);
			return ConvertDirectoryInfoArrayIntoIDirectoryInfoWrapArray(directoryInfos);
		}

		public IDirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption)
		{
			DirectoryInfo[] directoryInfos = DirectoryInfo.GetDirectories(searchPattern, searchOption);
			return ConvertDirectoryInfoArrayIntoIDirectoryInfoWrapArray(directoryInfos);
		}

		public IFileInfo[] GetFiles()
		{
			FileInfo[] fileInfos = DirectoryInfo.GetFiles();
		    return fileInfos.Select(x=> new FileInfoWrap(x)).ToArray();
		}

		public IFileInfo[] GetFiles(string searchPattern)
		{
			FileInfo[] fileInfos = DirectoryInfo.GetFiles(searchPattern);
            return fileInfos.Select(x => new FileInfoWrap(x)).ToArray();
		}

		public IFileInfo[] GetFiles(string searchPattern, SearchOption searchOption)
		{
			FileInfo[] fileInfos = DirectoryInfo.GetFiles(searchPattern, searchOption);
            return fileInfos.Select(x => new FileInfoWrap(x)).ToArray();
		}

		public FileSystemInfo[] GetFileSystemInfos()
		{
			return DirectoryInfo.GetFileSystemInfos();
		}

		public FileSystemInfo[] GetFileSystemInfos(string searchPattern)
		{
			return DirectoryInfo.GetFileSystemInfos(searchPattern);
		}

		public object GetLifetimeService()
		{
			return DirectoryInfo.GetLifetimeService();
		}

		public object InitializeLifetimeService()
		{
			return DirectoryInfo.InitializeLifetimeService();
		}

		public void MoveTo(string destDirName)
		{
			DirectoryInfo.MoveTo(destDirName);
		}

		public void Refresh()
		{
			DirectoryInfo.Refresh();
		}

		public void SetAccessControl(IDirectorySecurity directorySecurity)
		{
			DirectoryInfo.SetAccessControl(directorySecurity.DirectorySecurityInstance);
		}

		public override string ToString()
		{
			return DirectoryInfo.ToString();
		}

		private static IDirectoryInfo[] ConvertDirectoryInfoArrayIntoIDirectoryInfoWrapArray(DirectoryInfo[] directoryInfos)
		{
			IDirectoryInfo[] directoryInfoWraps = new DirectoryInfoWrap[directoryInfos.Length];
			for (int i = 0; i < directoryInfos.Length; i++)
				directoryInfoWraps[i] = new DirectoryInfoWrap(directoryInfos[i]);
			return directoryInfoWraps;
		}
	}
}