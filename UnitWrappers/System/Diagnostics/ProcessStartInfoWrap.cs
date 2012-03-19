using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security;
using System.Text;

namespace UnitWrappers.System.Diagnostics
{
	///<summary>
	/// Wrapper for <see cref="T:System.Diagnostics.ProcessStartInfo"/> class.
	///</summary>
	/// <remarks>
	/// Class is wrapped because underlying object uses environment variables and registry undre the hood. Not simple data holder.
	/// </remarks>
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
        /// <inheritdoc />
		public string Arguments
		{
			get { return UnderlyingObject.Arguments; }
			set { UnderlyingObject.Arguments = value; }
		}
        /// <inheritdoc />
		public string FileName
		{
			get { return UnderlyingObject.FileName; }
			set { UnderlyingObject.FileName = value; }
		}
        /// <inheritdoc />
		public bool UseShellExecute
		{
			get { return UnderlyingObject.UseShellExecute; }
			set { UnderlyingObject.UseShellExecute = value; }
		}
        /// <inheritdoc />
	    public bool CreateNoWindow
	    {
            get { return UnderlyingObject.CreateNoWindow; }
            set { UnderlyingObject.CreateNoWindow = value; }
	    }
        /// <inheritdoc />
	    public string Domain
	    {
            get { return UnderlyingObject.Domain; }
            set { UnderlyingObject.Domain = value; }
	    }
        /// <inheritdoc />
	    public StringDictionary EnvironmentVariables
	    {
            get { return UnderlyingObject.EnvironmentVariables; }
	    }
        /// <inheritdoc />
	    public bool ErrorDialog
	    {
            get { return UnderlyingObject.ErrorDialog; }
            set { UnderlyingObject.ErrorDialog = value; }
	    }
        /// <inheritdoc />
	    public IntPtr ErrorDialogParentHandle
	    {
            get { return UnderlyingObject.ErrorDialogParentHandle; }
            set { UnderlyingObject.ErrorDialogParentHandle = value; }
	    }
        /// <inheritdoc />
	    public bool LoadUserProfile
	    {
            get { return UnderlyingObject.LoadUserProfile; }
            set { UnderlyingObject.LoadUserProfile = value; }
	    }
        /// <inheritdoc />
	    public SecureString Password
	    {
            get { return UnderlyingObject.Password; }
            set { UnderlyingObject.Password = value; }
	    }
        /// <inheritdoc />
	    public bool RedirectStandardError
	    {
            get { return UnderlyingObject.RedirectStandardError; }
            set { UnderlyingObject.RedirectStandardError = value; }
	    }
        /// <inheritdoc />
	    public bool RedirectStandardInput
	    {
            get { return UnderlyingObject.RedirectStandardInput; }
            set { UnderlyingObject.RedirectStandardInput = value; }
	    }

	    public bool RedirectStandardOutput
	    {
            get { return UnderlyingObject.RedirectStandardOutput; }
            set { UnderlyingObject.RedirectStandardOutput = value; }
	    }
        /// <inheritdoc />
	    public Encoding StandardErrorEncoding
	    {
            get { return UnderlyingObject.StandardErrorEncoding; }
            set { UnderlyingObject.StandardErrorEncoding = value; }
	    }
        /// <inheritdoc />
	    public Encoding StandardOutputEncoding
	    {
            get { return UnderlyingObject.StandardOutputEncoding; }
            set { UnderlyingObject.StandardOutputEncoding = value; }
	    }
        /// <inheritdoc />
	    public string UserName
	    {
            get { return UnderlyingObject.UserName; }
            set { UnderlyingObject.UserName = value; }
	    }

	    /// <inheritdoc />
	    public string Verb
	    {
            get { return UnderlyingObject.Verb; }
            set { UnderlyingObject.Verb = value; }
	    }
        /// <inheritdoc />
	    public string[] Verbs
	    {
            get { return UnderlyingObject.Verbs; }
	    }
        /// <inheritdoc />
	    public ProcessWindowStyle WindowStyle
	    {
            get { return UnderlyingObject.WindowStyle; }
            set { UnderlyingObject.WindowStyle = value; }
	    }
        /// <inheritdoc />
	    public string WorkingDirectory
	    {
            get { return UnderlyingObject.WorkingDirectory; }
            set { UnderlyingObject.WorkingDirectory = value; }
	    }
	}
}