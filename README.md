### Sample 
```csharp
 var service = IoC.Get<HostService>();
 
 public class HostService()
 {
    ...
 
    public HostService(IFile file, IAppDomainSystem appDomainSystem, IProcessSystem processSystem)
 	{
   	_file = file;
 		_appDomainSystem = appDomainSystem;
 		_processSystem = processSystem;
 	}
 
 	public void Run()
 	{
 		if (_file.Exists("Daemon.exe")
 		     _processSystem.Start("Daemon.exe");
 		else if (_file.Exists("Daemon.dll")
 		{
 		 var domain = _appDomainSystem.CreateDomain("Daemon");
 			dynamic daemon = domain.CreateInstanceAndUnwrap("Daemon.dll","Daemon");
 			daemon.Start();
 		}
 		else 
 		     new Daemon().Start();
 	}
 }
```

### Description 
* Wraps classes into other classes with interfaces which are suitable for unit testing.
* Designed to be used with dependency injection containers. 
* Should be used with mocking libraries and correspondending automocking container extensions in tests.
* There are frameworks which use CLR implementaion hooks  to fake underlying implementaion of classes. These are not available for free on each paltform, but is viable alternative for wrappers in some cases.
* When used with container injection then reveals complex object which should be splitted according functional provided.
* Used at least in one prodcution desktop application.

### Design
* No wraps for POCOs and structs like instance of `DateTime`, `Version`. But static members like `DateTime.Now` are covered.
* Implicit conversion of wrappers to real object and vice versa.
* Wrapping `sender` of events (not all are done yet)
* No combined objects (e.g. `File`, `Path`, `Directory` into one like `IO` or `FileSystem` object contaning aforemention as properties) in compiled distribution (only samples which can be copy pasted).
* Static and instance members in different classes. E.g. `IAssemblySystem` and `IAssembly`.
* No `Wrap` word in interfaces. `Wrap` word in wrapping classes.
* Wrappers for static members also include `Create` methods for constuction of wraps instead of constuctor
* .NET 4.0, .NET 3.5 support (main target is .NET 4.0 and according Mono).
* All classes behave like they behave on .NET/Mono counterpart.
* One to one corresponce with real classes, casting back and forth. Close integration with no wrappers code. E.g. can convert `FileStreamWrap` to `FileStream` or `Stream`, `AssemblyWrap` to `Assembly`.
* Underlying object is not public API of wrapping interface (not visible from interfaces). Explicit `IWrap` implementation is used.
* Interfaces free of wrapped classes related info.


### Tooling
* Automatic coverage report generation.

### CLR implementation hooks vs wrappers
* Wrappers reveal complex code
* Wrappers enforce better desing
* Wrappers are open source and can be used on any CLR
* Wrappers are easy to inject into old codebase by replacing static methods with singletons
* Wrappers cannot be used to hook 3rd party components
* Wrappers add overhead during runtime, but wrappers usually wrap IO operations which take very large time relative to wrappers added overhead. Wrappers go domain first design. If something needs to be really fast, then should go to PInvoke.

### NOTE:
If massive breaking changes and fixes happen to make desing more correct. This changes will be marked by renaming to NUnitWrappers. Also possible to drop `UnitWrappers` namespace prefix to put wrappers into BCL namespaces.

### TODO:
* Virtual in memory file system.
* Wrap all `sender`s of events
* Real world sample with IoC/DI, Net, IO, WCF, etc.
* Semi-automatic migration, documenting, wrapping (using NRefactory/Mono.Cecil) of of types
* Wrapperasing /dewraperasing exsisting code (using NRefactory) Prove of Concept 
* Cover more of Mono, PortableLibrary, MonoDroid 
* Performance(calls and object graph construction) and memory usage overhead evaluation
* Support for code contracts and members' attributes defined on real .NET classes
* Namespace wide factories
* Tests which check method signatures (that wraps call right underlying methods) on code or IL level
* UnitsWrappers.GetInstance<IXyzWrap>()
* Test helpers like in http://systemioabstractions.codeplex.com
* Research F# scructural typing to provide F# version
* Virtual in memory web server.


### Develop


* UnitWrappers.sln:

Open SharpDevelop 4.X. Build in Debug or Release mode for Any Cpu.

* UnitWrappers.Mono.sln:

Linux

MonoDevelop

* UnitWrappers.Android.sln:

Xamarin Studio 4.0 with Android SDK


### Obsolete and new methods

Methods obsolete in .NET 4.0 or .NET 3.5 are not implemented.
New .NET methods sometimes backported to 3.5 wrappers.

### Related 
- http://systemwrapper.codeplex.com - has lesser coverage and bad design of wrapping

- https://github.com/tathamoddie/System.IO.Abstractions - has lesser coverage, adhoc custom interfaces and non generic testing helpers (i.e. ad hoc manual file system instead of real in memory implementation)

- https://sourceforge.net/projects/wrappergen/  - tools to generate wrapper for classes, old and need to be tuned 

- https://katanaproject.codeplex.com/wikipage?title=Packages&referringTitle=Home - generic `wrappers` for web servers

- http://msdn.microsoft.com/en-us/library/windows/apps/br211377.aspx - WinRT API provides IO via Interfaces, no need to wrap at all

- http://jolt.codeplex.com/wikipage?title=Jolt.Testing.CodeGeneration.Proxy&referringTitle=Jolt.Testing  code generator of IL for wrappers

### Coverage

Total number of wraps: 57

Microsoft.Win32.Registry-> UnitWrappers.Microsoft.Win32.IRegistry : 100%

Microsoft.Win32.RegistryKey-> UnitWrappers.Microsoft.Win32.IRegistryKeySystem UnitWrappers.Microsoft.Win32.IRegistryKey : 60%

Microsoft.Win32.SafeHandles.SafeFileHandle-> UnitWrappers.Microsoft.Win32.SafeHandles.ISafeFileHandle : 90%

System.AppDomain-> UnitWrappers.System.IAppDomain UnitWrappers.System.IAppDomainSystem : 40%

System.ComponentModel.BackgroundWorker-> UnitWrappers.System.ComponentModel.IBackgroundWorker : 65%

System.Configuration.ConfigurationManager-> UnitWrappers.System.Configuration.IConfigurationManager : 81%

System.Console-> UnitWrappers.System.IConsole : 9%

System.Data.SqlClient.SqlCommand-> UnitWrappers.System.Data.SqlClient.ISqlCommand : 2%

System.Data.SqlClient.SqlConnection-> UnitWrappers.System.Data.SqlClient.ISqlConnection : 36%

System.Data.SqlClient.SqlDataReader-> UnitWrappers.System.Data.SqlClient.ISqlDataReader : 57%

System.DateTime-> UnitWrappers.System.IDateTimeSystem : 20%

System.Diagnostics.Process-> UnitWrappers.System.Diagnostics.IProcessSystem UnitWrappers.System.Diagnostics.IProcess : 56%

System.Diagnostics.ProcessStartInfo-> UnitWrappers.System.Diagnostics.IProcessStartInfo : 34%

System.Environment-> UnitWrappers.System.IEnvironment : 55%

System.IO.BinaryReader-> UnitWrappers.System.IO.IBinaryReader : 92%

System.IO.BinaryWriter-> UnitWrappers.System.IO.IBinaryWriter : 88%

System.IO.Compression.DeflateStream-> UnitWrappers.System.IO.Compression.IDeflateStream : 12%

System.IO.Directory-> UnitWrappers.System.IO.IDirectory : 77%

System.IO.DirectoryInfo-> UnitWrappers.System.IO.IDirectoryInfo : 54%

System.IO.File-> UnitWrappers.System.IO.IFile : 89%

System.IO.FileInfo-> UnitWrappers.System.IO.IFileInfo UnitWrappers.System.IO.IFileInfoSystem : 58%

System.IO.FileStream-> UnitWrappers.System.IO.IFileStream : 71%

System.IO.FileSystemWatcher-> UnitWrappers.System.IO.IFileSystemWatcher : 50%

System.IO.MemoryStream-> UnitWrappers.System.IO.IMemoryStream : 80%

System.IO.Path-> UnitWrappers.System.IO.IPath : 100%

System.IO.Stream-> UnitWrappers.System.IO.IStream : 58%

System.IO.StreamReader-> UnitWrappers.System.IO.IStreamReader : 44%

System.IO.StreamWriter-> UnitWrappers.System.IO.IStreamWriter : 42%

System.IO.TextReader-> UnitWrappers.System.IO.ITextReader : 61%

System.Management.ManagementObjectSearcher-> UnitWrappers.System.Management.IManagementObjectSearcher : 6%

System.Net.NetworkInformation.NetworkChange-> UnitWrappers.System.Net.NetworkInformation.INetworkChange : 100%

System.Net.NetworkInformation.NetworkInterface-> UnitWrappers.System.Net.NetworkInformation.INetworkInterface : 8%

System.Net.NetworkInformation.Ping-> UnitWrappers.System.Net.NetworkInformation.IPing : 2%

System.Net.Sockets.Socket-> UnitWrappers.System.Net.Sockets.ISocket : 26%

System.Net.WebClient-> UnitWrappers.System.Net.IWebClient : 83%

System.Net.WebRequest-> UnitWrappers.System.Net.IWebRequestSystem : 9%

System.Reflection.Assembly-> UnitWrappers.System.Reflection.IAssembly UnitWrappers.System.Reflection.IAssemblySystem : 50%

System.Reflection.AssemblyName-> UnitWrappers.System.Reflection.IAssemblyName : 51%

System.Runtime.InteropServices.SafeHandle-> UnitWrappers.System.Runtime.InteropServices.ISafeHandle : 70%

System.Security.AccessControl.DirectorySecurity-> UnitWrappers.System.Security.AccessControl.IDirectorySecurity : 2%

System.Security.AccessControl.FileSecurity-> UnitWrappers.System.Security.AccessControl.IFileSecurity : 2%

System.Security.Permissions.FileIOPermission-> UnitWrappers.System.Security.Permissions.IFileIOPermission : 41%

System.ServiceModel.InstanceContext-> UnitWrappers.System.ServiceModel.IInstanceContext : 18%

System.ServiceModel.OperationContext-> UnitWrappers.System.ServiceModel.IOperationContextSystem UnitWrappers.System.ServiceModel.IOperationContext : 44%

System.ServiceModel.ServiceHost-> UnitWrappers.System.ServiceModel.IServiceHost : 18%

System.Threading.AutoResetEvent-> UnitWrappers.System.Threading.IAutoResetEvent : 25%

System.Threading.Mutex-> UnitWrappers.System.Threading.IMutexSystem UnitWrappers.System.Threading.IMutex : 28%

System.Threading.Tasks.Task-> UnitWrappers.System.Threading.Tasks.ITask : 18%

System.Threading.Thread-> UnitWrappers.System.Threading.IThread UnitWrappers.System.Threading.IThreadSystem : 33%

System.Threading.ThreadPool-> UnitWrappers.System.Threading.IThreadPool : 44%

System.Threading.WaitHandle-> UnitWrappers.System.Threading.IWaitHandleSystem UnitWrappers.System.Threading.IWaitHandle : 20%

System.Timers.Timer-> UnitWrappers.System.Timers.ITimer : 28%

System.Windows.Clipboard-> UnitWrappers.System.Windows.IClipboard : 100%

System.Windows.MessageBox-> UnitWrappers.System.Windows.IMessageBox : 100%

System.Windows.Threading.Dispatcher-> UnitWrappers.System.Windows.Threading.IDispatcherSystem UnitWrappers.System.Windows.Threading.IDispatcher : 91%

System.Windows.Threading.DispatcherTimer-> UnitWrappers.System.Windows.Threading.IDispatcherTimer UnitWrappers.System.Windows.Threading.IDispatcherTimerSystem : 65%

System.Windows.Window-> UnitWrappers.System.Windows.IWindowSystem UnitWrappers.System.Windows.IWindow : 10%


