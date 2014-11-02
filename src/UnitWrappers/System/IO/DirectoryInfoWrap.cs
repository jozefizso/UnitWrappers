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
	[Serializable]
    [ComVisible(true)]
	public class DirectoryInfoWrap : IDirectoryInfo, IWrap<DirectoryInfo>
	{
        private DirectoryInfo _underlyingObject;

        public static implicit operator DirectoryInfoWrap(DirectoryInfo o)
        {
            return new DirectoryInfoWrap(o);
        }

        public static implicit operator DirectoryInfo(DirectoryInfoWrap o)
        {
            return o._underlyingObject;
        }


        DirectoryInfo IWrap<DirectoryInfo>.UnderlyingObject
        {
            get { return _underlyingObject ; }
        }		

		/// <summary>
		/// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.DirectoryInfoWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="directoryInfo">A <see cref="T:System.IO.DirectoryInfo"/> object.</param>
		public DirectoryInfoWrap(DirectoryInfo directoryInfo)
		{
            _underlyingObject = directoryInfo;
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.DirectoryInfoWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="path">A string specifying the path on which to create the <see cref="T:UnitWrappers.System.IO.DirectoryInfoWrap"/>. </param>
		public DirectoryInfoWrap(string path)
		{
            _underlyingObject = new DirectoryInfo(path);
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

		public string Name
		{
			get { return _underlyingObject.Name; }
		}

		public IDirectoryInfo Parent
		{
			get { return new DirectoryInfoWrap(_underlyingObject.Parent); }
		}

		public IDirectoryInfo Root
		{
			get { return new DirectoryInfoWrap(_underlyingObject.Root); }
		}

		public void Create()
		{
			_underlyingObject.Create();
		}

		public void Create(IDirectorySecurity directorySecurity)
		{
            _underlyingObject.Create(((IWrap<DirectorySecurity>)directorySecurity).UnderlyingObject);
		}

		public ObjRef CreateObjRef(Type requestedType)
		{
			return _underlyingObject.CreateObjRef(requestedType);
		}

		public IDirectoryInfo CreateSubdirectory(string path)
		{
			return new DirectoryInfoWrap(_underlyingObject.CreateSubdirectory(path));
		}

		public IDirectoryInfo CreateSubdirectory(string path, IDirectorySecurity directorySecurity)
		{
            return new DirectoryInfoWrap(_underlyingObject.CreateSubdirectory(path, ((IWrap<DirectorySecurity>)directorySecurity).UnderlyingObject));
		}

		public void Delete()
		{
			_underlyingObject.Delete();
		}

		public void Delete(bool recursive)
		{
			_underlyingObject.Delete(recursive);
		}

		public IDirectorySecurity GetAccessControl()
		{
			return new DirectorySecurityWrap(_underlyingObject.GetAccessControl());
		}

		public IDirectorySecurity GetAccessControl(AccessControlSections includeSections)
		{
			return new DirectorySecurityWrap(_underlyingObject.GetAccessControl(includeSections));
		}

		public IDirectoryInfo[] GetDirectories()
		{
			DirectoryInfo[] directoryInfos = _underlyingObject.GetDirectories();
			return ConvertDirectoryInfoArrayIntoIDirectoryInfoWrapArray(directoryInfos);
		}

		public IDirectoryInfo[] GetDirectories(string searchPattern)
		{
			DirectoryInfo[] directoryInfos = _underlyingObject.GetDirectories(searchPattern);
			return ConvertDirectoryInfoArrayIntoIDirectoryInfoWrapArray(directoryInfos);
		}

		public IDirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption)
		{
			DirectoryInfo[] directoryInfos = _underlyingObject.GetDirectories(searchPattern, searchOption);
			return ConvertDirectoryInfoArrayIntoIDirectoryInfoWrapArray(directoryInfos);
		}

		public IFileInfo[] GetFiles()
		{
			FileInfo[] fileInfos = _underlyingObject.GetFiles();
		    return fileInfos.Select(x=> new FileInfoWrap(x)).ToArray();
		}

		public IFileInfo[] GetFiles(string searchPattern)
		{
			FileInfo[] fileInfos = _underlyingObject.GetFiles(searchPattern);
            return fileInfos.Select(x => new FileInfoWrap(x)).ToArray();
		}

		public IFileInfo[] GetFiles(string searchPattern, SearchOption searchOption)
		{
			FileInfo[] fileInfos = _underlyingObject.GetFiles(searchPattern, searchOption);
            return fileInfos.Select(x => new FileInfoWrap(x)).ToArray();
		}

		public FileSystemInfo[] GetFileSystemInfos()
		{
			return _underlyingObject.GetFileSystemInfos();
		}

		public FileSystemInfo[] GetFileSystemInfos(string searchPattern)
		{
			return _underlyingObject.GetFileSystemInfos(searchPattern);
		}

		public object GetLifetimeService()
		{
			return _underlyingObject.GetLifetimeService();
		}

		public object InitializeLifetimeService()
		{
			return _underlyingObject.InitializeLifetimeService();
		}

		public void MoveTo(string destDirName)
		{
			_underlyingObject.MoveTo(destDirName);
		}

		public void Refresh()
		{
			_underlyingObject.Refresh();
		}

    
		public void SetAccessControl(IDirectorySecurity directorySecurity)
		{
            _underlyingObject.SetAccessControl(((IWrap<DirectorySecurity>)directorySecurity).UnderlyingObject);
		}

		public override string ToString()
		{
			return _underlyingObject.ToString();
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