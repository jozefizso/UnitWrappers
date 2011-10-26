using System.Diagnostics;

namespace UnitWrappers.System.Diagnostics
{
	///<summary>
	/// Wrapper for <see cref="T:System.Diagnostics.ProcessStartInfo"/> class.
	///</summary>
	public class ProcessStartInfoWrap : IProcessStartInfo
	{
		public ProcessStartInfo UnderlyingObject { get; internal set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="T:UnitWrappers.System.Diagnostics.ProcessStartInfoWrap"/> class without specifying a file name with which to start the process. 
		/// </summary>
		public ProcessStartInfoWrap()
		{
            UnderlyingObject = new ProcessStartInfo();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:UnitWrappers.System.Diagnostics.ProcessStartInfoWrap"/> class and specifies a file name such as an application or document with which to start the process.
		/// </summary>
		public ProcessStartInfoWrap(string fileName)
		{
            UnderlyingObject = new ProcessStartInfo(fileName);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:UnitWrappers.System.Diagnostics.ProcessStartInfoWrap"/> class, specifies an application file name with which to start the process, and specifies a set of command-line arguments to pass to the application.
		/// </summary>
		public ProcessStartInfoWrap(string fileName, string arguments)
		{
            UnderlyingObject = new ProcessStartInfo(fileName, arguments);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:UnitWrappers.System.Diagnostics.ProcessStartInfoWrap"/> class with providing ProcessStartInfo instance. 
		/// </summary>
		/// <param name="processStartInfo">ProcessStartInfo instance</param>
		public ProcessStartInfoWrap(ProcessStartInfo processStartInfo)
		{
            UnderlyingObject = processStartInfo;
		}
	
		public string Arguments
		{
			get { return UnderlyingObject.Arguments; }
			set { UnderlyingObject.Arguments = value; }
		}

		public string FileName
		{
			get { return UnderlyingObject.FileName; }
			set { UnderlyingObject.FileName = value; }
		}

		public bool UseShellExecute
		{
			get { return UnderlyingObject.UseShellExecute; }
			set { UnderlyingObject.UseShellExecute = value; }
		}
	}
}