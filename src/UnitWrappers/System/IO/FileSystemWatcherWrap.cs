using System;
using System.ComponentModel;
using System.IO;

namespace UnitWrappers.System.IO
{
    public class FileSystemWatcherWrap : IFileSystemWatcher
    {

        /// <summary> 
        /// Initializes a new instance of the <see cref='FileSystemWatcher'/> class. 
        /// </summary>
        public FileSystemWatcherWrap()
        {
            UnderlyingObject = new FileSystemWatcher();
        }

        /// <summary>
        ///       Initializes a new instance of the <see cref='FileSystemWatcher'/> class, 
        ///       given the specified directory to monitor.  
        /// </summary>
        public FileSystemWatcherWrap(string path)
            : this(path, "*.*")
        {
        }


        /// <summary>    
        ///       Initializes a new instance of the <see cref='FileSystemWatcher'/> class,
        ///       given the specified directory and type of files to monitor.
        /// </summary> 
        public FileSystemWatcherWrap(string path, string filter)
        {
            UnderlyingObject = new FileSystemWatcher(path, filter);
        }

        public FileSystemWatcher UnderlyingObject { get; private set; }


        /// <summary> 
        ///       Gets or sets the type of changes to watch for. 
        /// </summary>
        [DefaultValue(NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName)]
        public NotifyFilters NotifyFilter
        {
            get { return UnderlyingObject.NotifyFilter; }
            set { UnderlyingObject.NotifyFilter = value; }
        }

        /// <summary>
        ///    Gets or sets a value indicating whether the component is enabled.
        /// </summary> 
        [DefaultValue(false)]
        public bool EnableRaisingEvents
        {
            get { return UnderlyingObject.EnableRaisingEvents; }
            set { UnderlyingObject.EnableRaisingEvents = value; }
        }

        /// <summary> 
        ///    Gets or sets the filter string, used to determine what files are monitored in a directory.
        /// </summary> 
        [DefaultValue("*.*")]
        public string Filter
        {
            get { return UnderlyingObject.Filter; }
            set { UnderlyingObject.Filter = value; }
        }

        /// <summary> 
        ///       Gets or sets a
        ///       value indicating whether subdirectories within the specified path should be monitored.
        /// </summary>
        [DefaultValue(false)]
        public bool IncludeSubdirectories
        {
            get { return UnderlyingObject.IncludeSubdirectories; }
            set { UnderlyingObject.IncludeSubdirectories = value; }
        }

        /// <summary>
        ///    Gets or 
        ///       sets the size of the internal buffer. 
        /// </summary>
        [DefaultValue(8192)]
        public int InternalBufferSize
        {
            get { return UnderlyingObject.InternalBufferSize; }
            set { UnderlyingObject.InternalBufferSize = value; }
        }


        /// <summary> 
        ///    Gets or sets the path of the directory to watch.
        /// </summary>
        [DefaultValue("")]
        public string Path
        {
            get { return UnderlyingObject.Path; }
            set { UnderlyingObject.Path = value; }
        }

        /// <summary> 
        ///       Gets or sets the object used to marshal the event handler calls issued as a 
        ///       result of a directory change. 
        /// </summary> 
        [DefaultValue(null)]
        public ISynchronizeInvoke SynchronizingObject
        {
            get { return UnderlyingObject.SynchronizingObject; }
            set { UnderlyingObject.SynchronizingObject = value; }
        }

        /// <summary>
        ///    Notifies the object that initialization is beginning and tells it to standby. 
        /// </summary> 
        public void BeginInit()
        {
            UnderlyingObject.BeginInit();
        }

        /// <summary> 
        ///    
        ///       Notifies the object that initialization is complete.
        ///    
        /// </summary> 
        public void EndInit()
        {
            UnderlyingObject.EndInit();
        }


        /// <summary> 
        ///       Occurs when a file or directory in the specified <see cref='FileSystemWatcher.Path'/> 
        ///       is changed.
        /// </summary>
        public event FileSystemEventHandler Changed
        {
            add { UnderlyingObject.Changed += value; }
            remove { UnderlyingObject.Changed -= value; }
        }

        /// <summary>
        ///       Occurs when a file or directory in the specified <see cref='FileSystemWatcher.Path'/> 
        ///       is created.
        /// </summary>
        public event FileSystemEventHandler Created
        {
            add { UnderlyingObject.Created += value; }
            remove { UnderlyingObject.Created -= value; }
        }

        /// <summary>
        ///       Occurs when a file or directory in the specified <see cref='FileSystemWatcher.Path'/>
        ///       is deleted. 
        /// </summary>
        public event FileSystemEventHandler Deleted
        {
            add { UnderlyingObject.Deleted += value; }
            remove { UnderlyingObject.Deleted -= value; }
        }

        /// <summary>
        ///       Occurs when the internal buffer overflows.
        /// </summary>
        public event ErrorEventHandler Error
        {
            add { UnderlyingObject.Error += value; }
            remove { UnderlyingObject.Error -= value; }
        }

        /// <summary> 
        ///       Occurs when a file or directory in the specified <see cref='FileSystemWatcher.Path'/> 
        ///       is renamed.
        /// </summary>
        public event RenamedEventHandler Renamed
        {
            add { UnderlyingObject.Renamed += value; }
            remove { UnderlyingObject.Renamed -= value; }
        }


        /// <summary> 
        ///       A synchronous method that returns a structure that
        ///       contains specific information on the change that occurred, given the type
        ///       of change that you wish to monitor. 
        /// </summary> 
        public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType)
        {
            return UnderlyingObject.WaitForChanged(changeType);
        }

        /// <summary>
        ///       A synchronous 
        ///       method that returns a structure that contains specific information on the change that occurred, given the
        ///       type of change that you wish to monitor and the time (in milliseconds) to wait before timing out. 
        /// </summary>
        public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType, int timeout)
        {
            return UnderlyingObject.WaitForChanged(changeType, timeout);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (UnderlyingObject != null)
                {
                    UnderlyingObject.Dispose();
                    UnderlyingObject = null;
                }
                // get rid of managed resources      
            } // get rid of unmanaged resources  
        }

        ~FileSystemWatcherWrap()
        {
            Dispose(false);
        }
    }
}